using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Field-Display Metadata for Census Return Data Data Set
    /// </summary>
    public sealed class SCEN_RFD_DataSet : SetBase<SCEN_RFD_Entity>
    {
        private Lazy<Dictionary<int, SCEN_RFD_Entity>> ID_Index;

        internal SCEN_RFD_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_RFD_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCEN_RFD"; } }

        /// <summary>
        /// Find SCEN_RFD by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RFD</param>
        /// <returns>Related SCEN_RFD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_RFD entities</exception>
        public SCEN_RFD_Entity FindByID(int Key)
        {
            SCEN_RFD_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the SCEN_RFD Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_RFD_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RFD by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RFD</param>
        /// <returns>Related SCEN_RFD entity, or null if not found</returns>
        public SCEN_RFD_Entity TryFindByID(int Key)
        {
            SCEN_RFD_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_RFD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_RFD_Entity, string>[Headers.Count];

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
