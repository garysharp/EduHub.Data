using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Excluded Data Data Set
    /// </summary>
    public sealed class SCEN_STEDataSet : SetBase<SCEN_STE>
    {
        private Lazy<Dictionary<int, SCEN_STE>> IDIndex;

        internal SCEN_STEDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_STE>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_STE"; } }

        /// <summary>
        /// Find SCEN_STE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STE</param>
        /// <returns>Related SCEN_STE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_STE entities</exception>
        public SCEN_STE FindByID(int Key)
        {
            SCEN_STE result;
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
        /// Attempt to find SCEN_STE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STE</param>
        /// <param name="Value">Related SCEN_STE entity</param>
        /// <returns>True if the SCEN_STE entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_STE Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_STE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STE</param>
        /// <returns>Related SCEN_STE entity, or null if not found</returns>
        public SCEN_STE TryFindByID(int Key)
        {
            SCEN_STE result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_STE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_STE" /> fields for each CSV column header</returns>
        protected override Action<SCEN_STE, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_STE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STE_TYPE":
                        mapper[i] = (e, v) => e.STE_TYPE = v;
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
