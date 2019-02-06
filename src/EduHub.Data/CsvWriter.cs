using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EduHub.Data
{
    internal class CsvWriter : IDisposable
    {
        private Stream stream;
        private readonly bool leaveOpen;
        private StreamWriter writer;
        private readonly string[] header;
        private readonly int columnCount;

        public IReadOnlyList<string> Header { get { return header; } }

        public CsvWriter(Stream Stream, string[] Header, bool leaveOpen)
        {
            if (Stream == null)
                throw new ArgumentNullException(nameof(Stream));

            if (!Stream.CanWrite)
                throw new ArgumentException("Stream is not writable", nameof(Stream));

            stream = Stream;
            this.leaveOpen = leaveOpen;
            writer = new StreamWriter(stream, Encoding.Default, 1024, leaveOpen);
            header = Header;
            columnCount = header.Length;

            WriteHeader();
            RecordCount = 0;
        }

        public int CurrentColumn { get; private set; }
        public int RecordCount { get; private set; }

        public void WriteEndOfRecord()
        {
            while (CurrentColumn++ < columnCount)
                writer.Write(',');

            writer.WriteLine();
            CurrentColumn = 0;
            RecordCount++;
        }

        public void Write(string Value)
        {
            PrepareCell();

            if (Value == null)
                return;

            if (Value.IndexOf('"') >= 0)
            {
                // escape quotes
                Value = $"\"{Value.Replace("\"", "\"\"")}\"";
            }
            writer.Write(Value);
        }

        public void Write(int Value)
        {
            PrepareCell();
            writer.Write(Value);
        }

        private void WriteHeader()
        {
            foreach (var item in header)
            {
                Write(item);
            }

            WriteEndOfRecord();
        }

        private void PrepareCell()
        {
            if (CurrentColumn++ >= columnCount)
                throw new InvalidOperationException("To many columns were written");

            if (CurrentColumn != 1)
                writer.Write(',');
        }

        public void Dispose()
        {
            if (writer != null)
            {
                try
                {
                    writer.Dispose();
                    if (!leaveOpen && stream != null)
                        stream.Dispose();
                }
                finally
                {
                    writer = null;
                    stream = null;
                }
            }
        }
    }
}
