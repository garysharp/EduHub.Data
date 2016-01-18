using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EduHub.Data
{
    internal class CsvReader : IDisposable
    {
        private const int BufferSize = 4096;

        private Stream stream;
        private Decoder decoder;
        private int maxCharPerBuffer;

        private byte[] byteBuffer;
        private int byteLength;

        private char[] charBuffer;
        private int charLength;
        private int charPosition;
        private StringBuilder stringBuilder;

        private int recordsRead;
        private string[] header;

        public IReadOnlyList<string> Header { get { return header; } }

        public CsvReader(Stream Stream)
        {
            if (Stream == null)
                throw new ArgumentNullException(nameof(Stream));

            if (!Stream.CanRead)
                throw new ArgumentException("Stream is not readable", nameof(Stream));

            stream = Stream;

            decoder = Encoding.UTF8.GetDecoder();
            maxCharPerBuffer = Encoding.UTF8.GetMaxCharCount(BufferSize);

            byteBuffer = new byte[BufferSize];
            byteLength = 0;

            charBuffer = new char[maxCharPerBuffer];

            stringBuilder = new StringBuilder(80);

            header = ReadRecord().ToArray();
            recordsRead = 0;
        }

        public double Progress
        {
            get
            {
                if (stream.Length > 0)
                {
                    return (stream.Position / (double)stream.Length) * 100;
                }
                else { return 100; }
            }
        }

        public int RecordsRead
        {
            get
            {
                return recordsRead;
            }
        }

        private int ReadBuffer()
        {
            charPosition = 0;

            byteLength = stream.Read(byteBuffer, 0, byteBuffer.Length);
            if (byteLength == 0)
            {
                return 0;
            }

            charLength = decoder.GetChars(byteBuffer, 0, byteLength, charBuffer, 0);

            return charLength;
        }

        public bool EndOfStream
        {
            get
            {
                if (charPosition < charLength)
                {
                    return false;
                }
                return ReadBuffer() == 0;
            }
        }

        public IEnumerable<List<string>> ReadRecords()
        {
            while (true)
            {
                var record = ReadRecord();
                if (record == null)
                {
                    yield break;
                }
                else
                {
                    yield return record;
                }
            }
        }

        public List<string> ReadRecord()
        {
            if (charPosition == charLength && ReadBuffer() == 0)
            {
                return null;
            }

            // Default record size = 23
            var record = new List<string>(header?.Length ?? 23);

            stringBuilder.Clear();
            bool escapedField = false;

            do
            {
                var charPositionLocal = charPosition;
                var fieldPositionLocal = charPositionLocal;

                do
                {
                    var c = charBuffer[charPositionLocal];

                    switch (c)
                    {
                        case ',':
                            if (!escapedField)
                            {
                                if (stringBuilder.Length == 0)
                                {
                                    if (fieldPositionLocal == charPositionLocal)
                                    {
                                        record.Add(null);
                                    }
                                    else
                                    {
                                        record.Add(new string(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal));
                                    }
                                }
                                else
                                {
                                    stringBuilder.Append(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal);
                                    record.Add(stringBuilder.ToString());
                                    stringBuilder.Clear();
                                }

                                fieldPositionLocal = charPositionLocal + 1;
                            }
                            break;
                        case '"':
                            if (!escapedField)
                            {
                                // Is first character?
                                if (fieldPositionLocal == charPositionLocal && stringBuilder.Length == 0)
                                {
                                    escapedField = true;
                                    fieldPositionLocal++;
                                }
                            }
                            else
                            {
                                char n;

                                if (++charPositionLocal < charLength)
                                {
                                    n = charBuffer[charPositionLocal];
                                }
                                else
                                {
                                    if (fieldPositionLocal != --charPositionLocal)
                                    {
                                        stringBuilder.Append(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal);
                                    }

                                    if (ReadBuffer() > 0)
                                    {
                                        charPositionLocal = fieldPositionLocal = charPosition;
                                        n = charBuffer[charPositionLocal];
                                    }
                                    else
                                    {
                                        // End of Stream
                                        record.Add(stringBuilder.ToString());
                                        recordsRead++;
                                        return record;
                                    }
                                }

                                switch (n)
                                {
                                    case ',':
                                    case '\r':
                                    case '\n':
                                        if (stringBuilder.Length == 0 && fieldPositionLocal == charPositionLocal)
                                        {
                                            record.Add(string.Empty);
                                        }
                                        else if (stringBuilder.Length == 0)
                                        {
                                            record.Add(new string(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal - 1));
                                        }
                                        else if (fieldPositionLocal == charPositionLocal)
                                        {
                                            record.Add(stringBuilder.ToString());
                                            stringBuilder.Clear();
                                        }
                                        else
                                        {
                                            stringBuilder.Append(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal - 1);
                                            record.Add(stringBuilder.ToString());
                                            stringBuilder.Clear();
                                        }
                                        fieldPositionLocal = charPositionLocal + 1;
                                        escapedField = false;

                                        if (n != ',')
                                        {
                                            charPosition = ++charPositionLocal;
                                            if (n == '\r' && (charPositionLocal < charLength || ReadBuffer() > 0) && charBuffer[charPosition] == '\n')
                                            {
                                                charPosition++;
                                            }
                                            recordsRead++;
                                            return record;
                                        }

                                        break;
                                    case '"':
                                        // Escaped " - include
                                        stringBuilder.Append(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal);
                                        fieldPositionLocal = charPositionLocal + 1;
                                        break;
                                    default:
                                        throw new InvalidDataException("A CSV field is incorrectly escaped");
                                }
                            }
                            break;
                        case '\r':
                        case '\n':
                            if (!escapedField)
                            {
                                if (stringBuilder.Length == 0 && fieldPositionLocal == charPositionLocal)
                                {
                                    record.Add(null);
                                }
                                else if (stringBuilder.Length == 0)
                                {
                                    record.Add(new string(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal));
                                }
                                else if (fieldPositionLocal == charPositionLocal)
                                {
                                    record.Add(stringBuilder.ToString());
                                    stringBuilder.Clear();
                                }
                                else
                                {
                                    stringBuilder.Append(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal);
                                    record.Add(stringBuilder.ToString());
                                    stringBuilder.Clear();
                                }

                                charPosition = ++charPositionLocal;

                                if (c == '\r' && (charPositionLocal < charLength || ReadBuffer() > 0) && charBuffer[charPosition] == '\n')
                                {
                                    charPosition++;
                                }

                                recordsRead++;
                                return record;
                            }
                            break;
                    }

                    charPositionLocal++;

                } while (charPositionLocal < charLength);

                if (fieldPositionLocal != charPositionLocal)
                {
                    stringBuilder.Append(charBuffer, fieldPositionLocal, charPositionLocal - fieldPositionLocal);
                }

            } while (ReadBuffer() > 0);

            if (stringBuilder.Length > 0)
            {
                record.Add(stringBuilder.ToString());
                stringBuilder.Clear();
            }

            recordsRead++;
            return record;
        }

        public void Dispose()
        {
            if (stream != null)
            {
                try
                {
                    stream.Dispose();
                }
                finally
                {
                    stream = null;
                    decoder = null;
                    byteBuffer = null;
                    charBuffer = null;
                }
            }
        }
    }
}
