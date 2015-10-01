using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Validation Data Data Set
    /// </summary>
    public sealed class SCEN_STVDataSet : SetBase<SCEN_STV>
    {
        private Lazy<Dictionary<int, SCEN_STV>> IDIndex;

        internal SCEN_STVDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_STV>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_STV"; } }

        /// <summary>
        /// Find SCEN_STV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STV</param>
        /// <returns>Related SCEN_STV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_STV entities</exception>
        public SCEN_STV FindByID(int Key)
        {
            SCEN_STV result;
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
        /// Attempt to find SCEN_STV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STV</param>
        /// <param name="Value">Related SCEN_STV entity</param>
        /// <returns>True if the SCEN_STV entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_STV Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_STV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STV</param>
        /// <returns>Related SCEN_STV entity, or null if not found</returns>
        public SCEN_STV TryFindByID(int Key)
        {
            SCEN_STV result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_STV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_STV" /> fields for each CSV column header</returns>
        protected override Action<SCEN_STV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_STV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
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
