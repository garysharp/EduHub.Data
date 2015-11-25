using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Departments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKDDataSet : SetBase<AKD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKD"; } }

        internal AKDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEPARTMENT = new Lazy<Dictionary<string, AKD>>(() => this.ToDictionary(i => i.DEPARTMENT));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKD" /> fields for each CSV column header</returns>
        protected override Action<AKD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DEPARTMENT":
                        mapper[i] = (e, v) => e.DEPARTMENT = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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

        private Lazy<Dictionary<string, AKD>> Index_DEPARTMENT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKD by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AKD</param>
        /// <returns>Related AKD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKD FindByDEPARTMENT(string DEPARTMENT)
        {
            return Index_DEPARTMENT.Value[DEPARTMENT];
        }

        /// <summary>
        /// Attempt to find AKD by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AKD</param>
        /// <param name="Value">Related AKD entity</param>
        /// <returns>True if the related AKD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEPARTMENT(string DEPARTMENT, out AKD Value)
        {
            return Index_DEPARTMENT.Value.TryGetValue(DEPARTMENT, out Value);
        }

        /// <summary>
        /// Attempt to find AKD by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AKD</param>
        /// <returns>Related AKD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKD TryFindByDEPARTMENT(string DEPARTMENT)
        {
            AKD value;
            if (Index_DEPARTMENT.Value.TryGetValue(DEPARTMENT, out value))
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
