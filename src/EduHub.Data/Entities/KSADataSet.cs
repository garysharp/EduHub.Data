using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Areas of Teaching Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSADataSet : SetBase<KSA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSA"; } }

        internal KSADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSAKEY = new Lazy<Dictionary<string, KSA>>(() => this.ToDictionary(i => i.KSAKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSA" /> fields for each CSV column header</returns>
        protected override Action<KSA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSAKEY":
                        mapper[i] = (e, v) => e.KSAKEY = v;
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

        private Lazy<Dictionary<string, KSA>> Index_KSAKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSA by KSAKEY field
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find KSA</param>
        /// <returns>Related KSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSA FindByKSAKEY(string KSAKEY)
        {
            return Index_KSAKEY.Value[KSAKEY];
        }

        /// <summary>
        /// Attempt to find KSA by KSAKEY field
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find KSA</param>
        /// <param name="Value">Related KSA entity</param>
        /// <returns>True if the related KSA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSAKEY(string KSAKEY, out KSA Value)
        {
            return Index_KSAKEY.Value.TryGetValue(KSAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSA by KSAKEY field
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find KSA</param>
        /// <returns>Related KSA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSA TryFindByKSAKEY(string KSAKEY)
        {
            KSA value;
            if (Index_KSAKEY.Value.TryGetValue(KSAKEY, out value))
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
