using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Field-Display Metadata for Census Return Data Data Set
    /// </summary>
    public sealed class SCEN_RFDDataSet : SetBase<SCEN_RFD>
    {
        private Lazy<Dictionary<int, SCEN_RFD>> IDIndex;

        internal SCEN_RFDDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_RFD>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_RFD"; } }

        /// <summary>
        /// Find SCEN_RFD by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RFD</param>
        /// <returns>Related SCEN_RFD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_RFD entities</exception>
        public SCEN_RFD FindByID(int Key)
        {
            SCEN_RFD result;
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
        /// Attempt to find SCEN_RFD by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RFD</param>
        /// <param name="Value">Related SCEN_RFD entity</param>
        /// <returns>True if the SCEN_RFD entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_RFD Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RFD by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RFD</param>
        /// <returns>Related SCEN_RFD entity, or null if not found</returns>
        public SCEN_RFD TryFindByID(int Key)
        {
            SCEN_RFD result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_RFD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_RFD" /> fields for each CSV column header</returns>
        protected override Action<SCEN_RFD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_RFD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "COLUMNNAME":
                        mapper[i] = (e, v) => e.COLUMNNAME = v;
                        break;
                    case "COLUMNDISPLAYNAME":
                        mapper[i] = (e, v) => e.COLUMNDISPLAYNAME = v;
                        break;
                    case "RFD_TYPE":
                        mapper[i] = (e, v) => e.RFD_TYPE = v;
                        break;
                    case "TYPEORDER":
                        mapper[i] = (e, v) => e.TYPEORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEFAULTCOLUMNDISPLAYORDER":
                        mapper[i] = (e, v) => e.DEFAULTCOLUMNDISPLAYORDER = v == null ? (short?)null : short.Parse(v);
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
