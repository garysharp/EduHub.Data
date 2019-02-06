using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EduHub.Data.WriteBack.Entities
{
    internal class WriteBackResponseRecord : IWriteBackResponseRecord
    {
        public WriteBackResponseRecord(string Entity, string EntityKey, string ErrorText)
        {
            this.Entity = Entity;
            this.EntityKey = EntityKey;
            this.ErrorText = ErrorText;
        }

        /// <inheritdoc />
        public string Entity { get; }

        /// <inheritdoc />
        public string EntityKey { get; }

        /// <inheritdoc />
        public string ErrorText { get; }

        public static List<IWriteBackResponseRecord> Load(string Filename)
        {
            // Copy to memory stream (don't directly process eduHub files)
            using (var stream = new MemoryStream())
            {
                using (var fileStream = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    fileStream.CopyTo(stream);
                stream.Position = 0;

                using (var reader = new CsvReader(stream))
                {
                    var header = reader.Header.ToList();
                    var entityOrdinal = header.IndexOf("ENTITY");
                    var entityKeyOrdinal = header.IndexOf("ENTITY_KEY");
                    var errorTextOrdinal = header.IndexOf("ERROR_TEXT");

                    var records = new List<IWriteBackResponseRecord>();

                    foreach (var record in reader.ReadRecords())
                    {
                        records.Add(new WriteBackResponseRecord(
                            Entity: record[entityOrdinal],
                            EntityKey: record[entityKeyOrdinal],
                            ErrorText: record[errorTextOrdinal]));
                    }

                    return records;
                }
            }
        }
    }
}
