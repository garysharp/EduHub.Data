using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Awards and Prizes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGWDataSet : SetBase<KGW>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGW"; } }

        internal KGWDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AWARD = new Lazy<Dictionary<string, KGW>>(() => this.ToDictionary(i => i.AWARD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGW" /> fields for each CSV column header</returns>
        protected override Action<KGW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
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

        private Lazy<Dictionary<string, KGW>> Index_AWARD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGW by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find KGW</param>
        /// <returns>Related KGW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGW FindByAWARD(string AWARD)
        {
            return Index_AWARD.Value[AWARD];
        }

        /// <summary>
        /// Attempt to find KGW by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find KGW</param>
        /// <param name="Value">Related KGW entity</param>
        /// <returns>True if the related KGW entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAWARD(string AWARD, out KGW Value)
        {
            return Index_AWARD.Value.TryGetValue(AWARD, out Value);
        }

        /// <summary>
        /// Attempt to find KGW by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find KGW</param>
        /// <returns>Related KGW entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGW TryFindByAWARD(string AWARD)
        {
            KGW value;
            if (Index_AWARD.Value.TryGetValue(AWARD, out value))
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
