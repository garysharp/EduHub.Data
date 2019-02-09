using EduHub.Data.WriteBack.Entities;
using System.IO;

namespace EduHub.Data.WriteBack
{
    internal abstract class WriteBackCsvWriter<T> : WriteBackWriter<T> where T : WriteBackEntity
    {
        private readonly MemoryStream stream;

        public WriteBackCsvWriter(WriteBackContext Context, WriteBackDataSet<T> DataSet, string[] CsvHeader)
            : base(Context, DataSet)
        {
            stream = new MemoryStream();
            CsvWriter = new CsvWriter(stream, CsvHeader, true);
        }

        protected CsvWriter CsvWriter { get; }

        public override void Commit()
        {
            // flush CSV writer
            CsvWriter.Dispose();

            // delete any existing file
            if (File.Exists(DataSet.Filename))
                File.Delete(DataSet.Filename);

            // ensure directory exists
            if (!Directory.Exists(Context.WriteBackDirectory))
                Directory.CreateDirectory(Context.WriteBackDirectory);

            // write file
            using (var fileStream = new FileStream(DataSet.Filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                fileStream.Write(stream.GetBuffer(), 0, (int)stream.Length);
            }
        }

        public override void Dispose(bool Disposed)
        {
            CsvWriter.Dispose();
        }
    }
}
