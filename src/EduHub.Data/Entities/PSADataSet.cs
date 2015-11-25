using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Award Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSADataSet : SetBase<PSA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PSA"; } }

        internal PSADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSAKEY = new Lazy<Dictionary<string, PSA>>(() => this.ToDictionary(i => i.PSAKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PSA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PSA" /> fields for each CSV column header</returns>
        protected override Action<PSA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PSA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSAKEY":
                        mapper[i] = (e, v) => e.PSAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AWARD_TYPE":
                        mapper[i] = (e, v) => e.AWARD_TYPE = v;
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

        private Lazy<Dictionary<string, PSA>> Index_PSAKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSA FindByPSAKEY(string PSAKEY)
        {
            return Index_PSAKEY.Value[PSAKEY];
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <param name="Value">Related PSA entity</param>
        /// <returns>True if the related PSA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSAKEY(string PSAKEY, out PSA Value)
        {
            return Index_PSAKEY.Value.TryGetValue(PSAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PSA by PSAKEY field
        /// </summary>
        /// <param name="PSAKEY">PSAKEY value used to find PSA</param>
        /// <returns>Related PSA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSA TryFindByPSAKEY(string PSAKEY)
        {
            PSA value;
            if (Index_PSAKEY.Value.TryGetValue(PSAKEY, out value))
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
