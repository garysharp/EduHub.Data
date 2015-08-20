using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Data deleted from DataMirror monitored tables Data Set
    /// </summary>
    public sealed class KDELETEDataSet : SetBase<KDELETE>
    {
        private Lazy<Dictionary<int, KDELETE>> IDIndex;

        internal KDELETEDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, KDELETE>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDELETE"; } }

        /// <summary>
        /// Find KDELETE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any KDELETE entities</exception>
        public KDELETE FindByID(int Key)
        {
            KDELETE result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KDELETE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find KDELETE</param>
        /// <param name="Value">Related KDELETE entity</param>
        /// <returns>True if the KDELETE entity is found</returns>
        public bool TryFindByID(int Key, out KDELETE Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KDELETE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity, or null if not found</returns>
        public KDELETE TryFindByID(int Key)
        {
            KDELETE result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDELETE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDELETE" /> fields for each CSV column header</returns>
        protected override Action<KDELETE, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KDELETE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TABLENAME":
                        mapper[i] = (e, v) => e.TABLENAME = v;
                        break;
                    case "IDVALUE":
                        mapper[i] = (e, v) => e.IDVALUE = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }
    }
}
