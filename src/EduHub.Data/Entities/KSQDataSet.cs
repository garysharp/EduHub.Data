using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Available Qualifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSQDataSet : SetBase<KSQ>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSQ"; } }

        internal KSQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSQKEY = new Lazy<Dictionary<string, KSQ>>(() => this.ToDictionary(i => i.KSQKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSQ" /> fields for each CSV column header</returns>
        protected override Action<KSQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSQKEY":
                        mapper[i] = (e, v) => e.KSQKEY = v;
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

        private Lazy<Dictionary<string, KSQ>> Index_KSQKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <returns>Related KSQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSQ FindByKSQKEY(string KSQKEY)
        {
            return Index_KSQKEY.Value[KSQKEY];
        }

        /// <summary>
        /// Attempt to find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <param name="Value">Related KSQ entity</param>
        /// <returns>True if the related KSQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSQKEY(string KSQKEY, out KSQ Value)
        {
            return Index_KSQKEY.Value.TryGetValue(KSQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSQ by KSQKEY field
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find KSQ</param>
        /// <returns>Related KSQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSQ TryFindByKSQKEY(string KSQKEY)
        {
            KSQ value;
            if (Index_KSQKEY.Value.TryGetValue(KSQKEY, out value))
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
