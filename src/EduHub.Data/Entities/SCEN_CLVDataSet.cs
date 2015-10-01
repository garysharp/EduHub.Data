using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Validation Data Data Set
    /// </summary>
    public sealed class SCEN_CLVDataSet : SetBase<SCEN_CLV>
    {
        private Lazy<Dictionary<int, SCEN_CLV>> IDIndex;

        internal SCEN_CLVDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_CLV>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_CLV"; } }

        /// <summary>
        /// Find SCEN_CLV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_CLV</param>
        /// <returns>Related SCEN_CLV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_CLV entities</exception>
        public SCEN_CLV FindByID(int Key)
        {
            SCEN_CLV result;
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
        /// Attempt to find SCEN_CLV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_CLV</param>
        /// <param name="Value">Related SCEN_CLV entity</param>
        /// <returns>True if the SCEN_CLV entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_CLV Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_CLV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_CLV</param>
        /// <returns>Related SCEN_CLV entity, or null if not found</returns>
        public SCEN_CLV TryFindByID(int Key)
        {
            SCEN_CLV result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_CLV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_CLV" /> fields for each CSV column header</returns>
        protected override Action<SCEN_CLV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_CLV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "CLASSCODE":
                        mapper[i] = (e, v) => e.CLASSCODE = v;
                        break;
                    case "ID_CLASSVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_CLASSVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
