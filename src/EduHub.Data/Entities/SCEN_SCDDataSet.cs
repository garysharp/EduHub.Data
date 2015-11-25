using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Column-Display Metadata for displaying Student Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_SCDDataSet : SetBase<SCEN_SCD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_SCD"; } }

        internal SCEN_SCDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_SCD>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_SCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_SCD" /> fields for each CSV column header</returns>
        protected override Action<SCEN_SCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_SCD, string>[Headers.Count];

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

        #region Index Fields

        private Lazy<Dictionary<int, SCEN_SCD>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <returns>Related SCEN_SCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_SCD FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <param name="Value">Related SCEN_SCD entity</param>
        /// <returns>True if the related SCEN_SCD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_SCD Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <returns>Related SCEN_SCD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_SCD TryFindByID(int ID)
        {
            SCEN_SCD value;
            if (Index_ID.Value.TryGetValue(ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
