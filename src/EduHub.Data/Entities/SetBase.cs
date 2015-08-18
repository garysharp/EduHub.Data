using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EduHub.Data.Entities
{
    public abstract class SetBase<T> : IReadOnlyList<T> where T : EntityBase
    {
        protected EduHubContext Context;
        protected static Action<T, string> MapperNoOp = (entity, field) => { };
        private Lazy<List<T>> Items;

        internal SetBase(EduHubContext Context)
        {
            this.Context = Context;
            this.Items = new Lazy<List<T>>(Parse);
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public abstract string Name { get; }
        protected abstract Action<T, string>[] BuildMapper(List<string> Headers);

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

        private List<T> Parse()
        {
            List<T> items = new List<T>();
            string filename = Filename;

            if (!File.Exists(filename))
                throw new EduHubDataSetNotFoundException(Name, filename);

            // Create temporary file
            var fileTemp = Path.GetTempFileName();

            // Copy to temporary file (don't directly process eduHub files)
            try
            {
                File.Copy(filename, fileTemp, true);

                using (var recordIter = File.ReadLines(fileTemp).GetEnumerator())
                {
                    // Read Headers
                    recordIter.MoveNext();
                    var headerRecord = recordIter.Current;
                    var headers = SplitCsvRecord(recordIter);

                    // Request Mapper
                    var mapper = BuildMapper(headers);

                    // Read Records
                    while (recordIter.MoveNext())
                    {
                        var record = SplitCsvRecord(recordIter);
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
            finally
            {
                // Remove temporary file
                File.Delete(fileTemp);
            }

            return items;
        }

        private static List<string> SplitCsvRecord(IEnumerator<string> RecordIter)
        {
            List<string> fields = new List<string>();
            StringBuilder fieldBuilder = new StringBuilder();
            bool textQualifier = false;

            while (true)
            {
                for (int i = 0; i < RecordIter.Current.Length; i++)
                {
                    var c = RecordIter.Current[i];
                    switch (c)
                    {
                        case ',':
                            if (textQualifier)
                            {
                                fieldBuilder.Append(c);
                            }
                            else
                            {
                                if (fieldBuilder.Length == 0)
                                {
                                    fields.Add(null);
                                }
                                else
                                {
                                    fields.Add(fieldBuilder.ToString());
                                    fieldBuilder.Clear();
                                }
                            }
                            break;
                        case '"':
                            if (!textQualifier && fieldBuilder.Length == 0)
                            {
                                // Beginning of record (Text Qualifier)
                                textQualifier = true;
                            }
                            else if (i + 1 == RecordIter.Current.Length)
                            {
                                // End of record
                                if (textQualifier)
                                {
                                    // End of field
                                    textQualifier = false;
                                }
                            }
                            else if (textQualifier && RecordIter.Current[i + 1] == '"')
                            {
                                // Escaped character
                                fieldBuilder.Append(c);
                                i++;
                            }
                            else if (textQualifier && RecordIter.Current[i + 1] == ',')
                            {
                                // End of field
                                fields.Add(fieldBuilder.ToString());
                                fieldBuilder.Clear();
                                textQualifier = false;
                                i++;
                            }
                            break;
                        default:
                            fieldBuilder.Append(c);
                            break;
                    }
                }
                if (textQualifier == false)
                {
                    if (fieldBuilder.Length > 0)
                    {
                        fields.Add(fieldBuilder.ToString());
                    }
                    break;
                }
                fieldBuilder.AppendLine();
                RecordIter.MoveNext();
            }

            return fields;
        }

        public T this[int index]
        {
            get
            {
                return Items.Value[index];
            }
        }

        public int Count
        {
            get
            {
                return Items.Value.Count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Items.Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.Value.GetEnumerator();
        }
    }
}
