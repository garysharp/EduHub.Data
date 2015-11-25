using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SACAGDataSet : SetBase<SACAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SACAG"; } }

        internal SACAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SACAG_ID = new Lazy<Dictionary<int, SACAG>>(() => this.ToDictionary(i => i.SACAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SACAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SACAG" /> fields for each CSV column header</returns>
        protected override Action<SACAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SACAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SACAG_ID":
                        mapper[i] = (e, v) => e.SACAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "UNAPPROVED":
                        mapper[i] = (e, v) => e.UNAPPROVED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "APPROVED":
                        mapper[i] = (e, v) => e.APPROVED = v == null ? (double?)null : double.Parse(v);
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

        #region Index Fields

        private Lazy<Dictionary<int, SACAG>> Index_SACAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <returns>Related SACAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SACAG FindBySACAG_ID(int SACAG_ID)
        {
            return Index_SACAG_ID.Value[SACAG_ID];
        }

        /// <summary>
        /// Attempt to find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <param name="Value">Related SACAG entity</param>
        /// <returns>True if the related SACAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySACAG_ID(int SACAG_ID, out SACAG Value)
        {
            return Index_SACAG_ID.Value.TryGetValue(SACAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <returns>Related SACAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SACAG TryFindBySACAG_ID(int SACAG_ID)
        {
            SACAG value;
            if (Index_SACAG_ID.Value.TryGetValue(SACAG_ID, out value))
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
