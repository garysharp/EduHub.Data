using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Student Validation Data Data Set
    /// </summary>
    public sealed class SCEN_ASVDataSet : SetBase<SCEN_ASV>
    {
        private Lazy<Dictionary<int, SCEN_ASV>> IDIndex;

        internal SCEN_ASVDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_ASV>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_ASV"; } }

        /// <summary>
        /// Find SCEN_ASV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ASV</param>
        /// <returns>Related SCEN_ASV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_ASV entities</exception>
        public SCEN_ASV FindByID(int Key)
        {
            SCEN_ASV result;
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
        /// Attempt to find SCEN_ASV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ASV</param>
        /// <param name="Value">Related SCEN_ASV entity</param>
        /// <returns>True if the SCEN_ASV entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_ASV Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ASV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ASV</param>
        /// <returns>Related SCEN_ASV entity, or null if not found</returns>
        public SCEN_ASV TryFindByID(int Key)
        {
            SCEN_ASV result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ASV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ASV" /> fields for each CSV column header</returns>
        protected override Action<SCEN_ASV, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_ASV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ID_STUDENTVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_STUDENTVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FIELDVALUES":
                        mapper[i] = (e, v) => e.FIELDVALUES = v;
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
