using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Base Data Set for eduHub Entities
    /// </summary>
    /// <typeparam name="T">An eduHub Entity derived from <see cref="EntityBase"/></typeparam>
    public abstract class SetBase<T> : IReadOnlyList<T> where T : EntityBase
    {
        /// <summary>
        /// EduHubContext this Data Set belongs to
        /// </summary>
        protected readonly EduHubContext Context;
        /// <summary>
        /// Helper method for Mapper Builders used to ignore fields (no operation)
        /// </summary>
        protected static Action<T, string> MapperNoOp = (entity, field) => { };
        private Lazy<List<T>> Items;

        internal SetBase(EduHubContext Context)
        {
            this.Context = Context;
            this.Items = new Lazy<List<T>>(LoadCsv);
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize an entity
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize entity fields for each CSV column header</returns>
        protected abstract Action<T, string>[] BuildMapper(IReadOnlyList<string> Headers);

        /// <summary>
        /// Data Set Location
        /// </summary>
        public string Filename
        {
            get
            {
                return Path.Combine(Context.EduHubDirectory, $"{Name}_{Context.EduHubSiteIdentifier}.csv");
            }
        }

        /// <summary>
        /// Indicates if the eduHub Directory contains this data set
        /// </summary>
        public bool IsAvailable
        {
            get
            {
                return File.Exists(Filename);
            }
        }

        /// <summary>
        /// Throws an exception if the set is unavailable
        /// </summary>
        public void EnsureAvailable()
        {
            if (!IsAvailable)
            {
                throw new EduHubDataSetNotFoundException(Name, Filename);
            }
        }

        /// <summary>
        /// Data Set Age
        /// </summary>
        public DateTime? Age
        {
            get
            {
                var filename = Filename;
                if (File.Exists(filename))
                {
                    return File.GetLastWriteTime(filename);
                }
                else
                {
                    return null;
                }
            }
        }

        private List<T> LoadCsv()
        {
            List<T> items = new List<T>();

            if (!File.Exists(Filename))
                throw new EduHubDataSetNotFoundException(Name, Filename);

            // Create temporary file
            var fileTemp = Path.GetTempFileName();

            // Copy to temporary file (don't directly process eduHub files)
            try
            {
                File.Copy(Filename, fileTemp, true);

                using (FileStream stream = File.OpenRead(fileTemp))
                {
                    using (CsvReader reader = new CsvReader(stream))
                    {
                        var mapper = BuildMapper(reader.Header);

                        foreach (var record in reader.ReadRecords())
                        {
                            var entity = Activator.CreateInstance<T>();
                            entity.Context = Context;

                            for (int i = 0; i < record.Count; i++)
                            {
                                mapper[i](entity, record[i]);
                            }
                            items.Add(entity);
                        }
                    }
                }
            }
            finally
            {
                // Remove temporary file
                File.Delete(fileTemp);
            }

            return items;
        }

        /// <summary>
        /// Gets the EduHub entity at the specified index in the data set.
        /// </summary>
        /// <param name="index">The zero-based index of the entity to get.</param>
        /// <returns>The entity at the specified index in the data set.</returns>
        public T this[int index]
        {
            get
            {
                return Items.Value[index];
            }
        }

        /// <summary>
        /// Gets the number of entities in the data set.
        /// </summary>
        /// <returns>The number of entities in the data set.</returns>
        public int Count
        {
            get
            {
                return Items.Value.Count;
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the data set.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the data set.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return Items.Value.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a data set.
        /// </summary>
        /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the data set.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.Value.GetEnumerator();
        }
    }
}
