using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Behaviour Classifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCBDataSet : SetBase<KCB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCB"; } }

        internal KCBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCBKEY = new Lazy<Dictionary<string, KCB>>(() => this.ToDictionary(i => i.KCBKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCB" /> fields for each CSV column header</returns>
        protected override Action<KCB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCBKEY":
                        mapper[i] = (e, v) => e.KCBKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "POS_NEG":
                        mapper[i] = (e, v) => e.POS_NEG = v;
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

        private Lazy<Dictionary<string, KCB>> Index_KCBKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <returns>Related KCB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCB FindByKCBKEY(string KCBKEY)
        {
            return Index_KCBKEY.Value[KCBKEY];
        }

        /// <summary>
        /// Attempt to find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <param name="Value">Related KCB entity</param>
        /// <returns>True if the related KCB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCBKEY(string KCBKEY, out KCB Value)
        {
            return Index_KCBKEY.Value.TryGetValue(KCBKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <returns>Related KCB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCB TryFindByKCBKEY(string KCBKEY)
        {
            KCB value;
            if (Index_KCBKEY.Value.TryGetValue(KCBKEY, out value))
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
