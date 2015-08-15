using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Column-Display Metadata for displaying Student Data Data Set
    /// </summary>
    public sealed class SCEN_SCD_DataSet : SetBase<SCEN_SCD_Entity>
    {
        private Lazy<Dictionary<int, SCEN_SCD_Entity>> ID_Index;

        internal SCEN_SCD_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_SCD_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCEN_SCD"; } }

        /// <summary>
        /// Find SCEN_SCD by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_SCD</param>
        /// <returns>Related SCEN_SCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_SCD entities</exception>
        public SCEN_SCD_Entity FindByID(int Key)
        {
            SCEN_SCD_Entity result;
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
        /// Attempt to find SCEN_SCD by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_SCD</param>
        /// <param name="Value">Related SCEN_SCD entity</param>
        /// <returns>True if the SCEN_SCD Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_SCD_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_SCD by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_SCD</param>
        /// <returns>Related SCEN_SCD entity, or null if not found</returns>
        public SCEN_SCD_Entity TryFindByID(int Key)
        {
            SCEN_SCD_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_SCD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_SCD_Entity, string>[Headers.Count];

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
                    case "DEFAULTCOLUMNDISPLAYWIDTH":
                        mapper[i] = (e, v) => e.DEFAULTCOLUMNDISPLAYWIDTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEFAULTCOLUMNDISPLAYORDER":
                        mapper[i] = (e, v) => e.DEFAULTCOLUMNDISPLAYORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREFERREDCOLUMNDISPLAYWIDTH":
                        mapper[i] = (e, v) => e.PREFERREDCOLUMNDISPLAYWIDTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREFERREDCOLUMNDISPLAYORDER":
                        mapper[i] = (e, v) => e.PREFERREDCOLUMNDISPLAYORDER = v == null ? (short?)null : short.Parse(v);
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
