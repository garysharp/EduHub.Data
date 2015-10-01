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
            // Default record size = 23
            var record = new List<string>(header == null ? 23 : header.Length);

            if (this.charPosition == charLength && ReadBuffer() == 0)
            {
                return null;
            }

            stringBuilder.Clear();
            bool escapedField = false;

            do
            {
                var charPosition = this.charPosition;
                var fieldPosition = charPosition;

                do
                {
                    var c = charBuffer[charPosition];

                    switch (c)
                    {
                        case ',':
                            if (!escapedField)
                            {
                                if (stringBuilder.Length == 0)
                                {
                                    if (fieldPosition == charPosition)
                                    {
                                        record.Add(null);
                                    }
                                    else
                                    {
                                        record.Add(new string(charBuffer, fieldPosition, charPosition - fieldPosition));
                                    }
                                }
                                else
                                {
                                    stringBuilder.Append(charBuffer, fieldPosition, charPosition - fieldPosition);
                                    record.Add(stringBuilder.ToString());
                                    stringBuilder.Clear();
                                }

                                fieldPosition = charPosition + 1;
                            }
                            break;
                        case '"':
                            if (!escapedField)
                            {
                                // Is first character?
                                if (fieldPosition == charPosition && stringBuilder.Length == 0)
                                {
                                    escapedField = true;
                                    fieldPosition++;
                                }
                            }
                            else
                            {
                                char n;

                                if (++charPosition < charLength)
                                {
                                    n = charBuffer[charPosition];
                                }
                                else
                                {
                                    if (fieldPosition != --charPosition)
                                    {
                                        stringBuilder.Append(charBuffer, fieldPosition, charPosition - fieldPosition);
                                    }

                                    if (ReadBuffer() > 0)
                                    {
                                        charPosition = fieldPosition = this.charPosition;
                                        n = charBuffer[charPosition];
                                    }
                                    else
                                    {
                                        // End of Stream
                                        record.Add(stringBuilder.ToString());
                                        return record;
                                    }
                                }

                                switch (n)
                                {
                                    case ',':
                                    case '\r':
                                    case '\n':
                                        if (stringBuilder.Length == 0 && fieldPosition == charPosition)
                                        {
                                            record.Add(string.Empty);
                                        }
                                        else if (stringBuilder.Length == 0)
                                        {
                                            record.Add(new string(charBuffer, fieldPosition, charPosition - fieldPosition - 1));
                                        }
                                        else if (fieldPosition == charPosition)
                                        {
                                            record.Add(stringBuilder.ToString());
                                            stringBuilder.Clear();
                                        }
                                        else
                                        {
                                            stringBuilder.Append(charBuffer, fieldPosition, charPosition - fieldPosition - 1);
                                            record.Add(stringBuilder.ToString());
                                            stringBuilder.Clear();
                                        }
                                        fieldPosition = charPosition + 1;
                                        escapedField = false;

                                        if (n != ',')
                                        {
                                            this.charPosition = ++charPosition;
                                            if (n == '\r' && (charPosition < charLength || ReadBuffer() > 0) && charBuffer[this.charPosition] == '\n')
                                            {
                                                this.charPosition++;
                                            }
                                            return record;
                                        }

                                        break;
                                    case '"':
                                        // Escaped " - include
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
                                if (stringBuilder.Length == 0)
                                {
                                    if (fieldPosition == charPosition)
                                    {
                                        record.Add(null);
                                    }
                                    else
                                    {
                                        record.Add(new string(charBuffer, fieldPosition, charPosition - fieldPosition));
                                    }
                                }
                                else
                                {
                                    stringBuilder.Append(charBuffer, fieldPosition, charPosition - fieldPosition);
                                    record.Add(stringBuilder.ToString());
                                    stringBuilder.Clear();
                                }

                                this.charPosition = charPosition++;

                                if (c == '\r' && (charPosition < charLength || ReadBuffer() > 0) && charBuffer[this.charPosition] == '\n')
                                {
                                    this.charPosition++;
                                }

                                return record;
                            }
                            break;
                    }

                    charPosition++;

                } while (charPosition < charLength);

                if (fieldPosition != charPosition)
                {
                    stringBuilder.Append(charBuffer, fieldPosition, charPosition - fieldPosition);
                }

            } while (ReadBuffer() > 0);

            if (stringBuilder.Length > 0)
            {
                record.Add(stringBuilder.ToString());
                stringBuilder.Clear();
            }

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
