using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard Disciplinary Actions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAMDataSet : SetBase<KAM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAM"; } }

        internal KAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KAMKEY = new Lazy<Dictionary<string, KAM>>(() => this.ToDictionary(i => i.KAMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAM" /> fields for each CSV column header</returns>
        protected override Action<KAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAMKEY":
                        mapper[i] = (e, v) => e.KAMKEY = v;
                        break;
                    case "BRIEF":
                        mapper[i] = (e, v) => e.BRIEF = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
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

        private Lazy<Dictionary<string, KAM>> Index_KAMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAM FindByKAMKEY(string KAMKEY)
        {
            return Index_KAMKEY.Value[KAMKEY];
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <param name="Value">Related KAM entity</param>
        /// <returns>True if the related KAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKAMKEY(string KAMKEY, out KAM Value)
        {
            return Index_KAMKEY.Value.TryGetValue(KAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY field
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAM TryFindByKAMKEY(string KAMKEY)
        {
            KAM value;
            if (Index_KAMKEY.Value.TryGetValue(KAMKEY, out value))
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
