using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace EduHub.Data.Entities
{
    internal class EduHubDataSetReader<T> : IEduHubDataSetReader<T> where T : EduHubEntity
    {
        private readonly EduHubDataSet<T> dataSet;
        private readonly EduHubContext context;

        private string filenameTemp;
        private FileStream stream;
        private CsvReader reader;
        private Action<T, string>[] mapper;

        private DateTime? entityLastModifiedMax;

        internal EduHubDataSetReader(EduHubDataSet<T> DataSet, string Filename)
        {
            if (DataSet == null)
                throw new ArgumentNullException(nameof(DataSet));
            if (Filename == null)
                throw new ArgumentNullException(nameof(Filename));
            if (!File.Exists(Filename))
                throw new FileNotFoundException("eduHub data set not found", Filename);

            dataSet = DataSet;
            context = DataSet.Context;

            // Copy to memory stream (don't directly process eduHub files)
            var stream = new MemoryStream();
            using (var fileStream = new FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                fileStream.CopyTo(stream);
            stream.Position = 0;

            // Initialize Csv Reader
            reader = new CsvReader(stream);
        }

        internal EduHubDataSetReader(EduHubDataSet<T> DataSet)
            : this(DataSet, DataSet.Filename)
        {
        }

        /// <inheritdoc />
        public string Name { get { return dataSet.Name; } }

        /// <inheritdoc />
        public EduHubContext Context { get { return context; } }

        /// <inheritdoc />
        public EduHubDataSet<T> DataSet { get { return dataSet; } }

        /// <inheritdoc />
        public bool HasEntities { get { return reader.RecordsRead > 0 || !reader.EndOfStream; } }

        /// <inheritdoc />
        public double Progress
        {
            get
            {
                return reader?.Progress ?? 0;
            }
        }

        /// <inheritdoc />
        public int EntitiesRead { get { return reader.RecordsRead; } }

        /// <inheritdoc />
        public DateTime? EntityLastModifiedMax { get { return entityLastModifiedMax; } }

        public IEnumerator<T> GetEnumerator()
        {
            var lastModifiedSupported = DataSet.SupportsEntityLastModified;

            // Build mapper
            mapper = DataSet.BuildMapper(reader.Header);

            while (true)
            {
                // Read CSV Record
                var record = reader.ReadRecord();

                // End of Stream?
                if (record == null)
                {
                    break;
                }

                // Create blank entity
                var entity = Activator.CreateInstance<T>();

                // Set entity context
                entity.Context = context;

                // Use mapper to fill entity
                for (int i = 0; i < record.Count; i++)
                {
                    mapper[i](entity, record[i]);
                }

                if (lastModifiedSupported &&            // Last modified supported
                    entity.EntityLastModified != null &&
                    (entityLastModifiedMax == null ||   // Last modified never set
                        entityLastModifiedMax < entity.EntityLastModified)) // Newer date
                {
                    entityLastModifiedMax = entity.EntityLastModified;
                }

                // Set entity as current item in enumerator
                yield return entity;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            if (reader != null)
            {
                reader.Dispose();
                reader = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
            if (filenameTemp != null && File.Exists(filenameTemp))
            {
                File.Delete(filenameTemp);
                filenameTemp = null;
            }
        }
    }
}
