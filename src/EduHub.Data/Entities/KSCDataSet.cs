using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Positions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSCDataSet : SetBase<KSC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSC"; } }

        internal KSCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSCKEY = new Lazy<Dictionary<string, KSC>>(() => this.ToDictionary(i => i.KSCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSC" /> fields for each CSV column header</returns>
        protected override Action<KSC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSCKEY":
                        mapper[i] = (e, v) => e.KSCKEY = v;
                        break;
                    case "SF_POSITION":
                        mapper[i] = (e, v) => e.SF_POSITION = v;
                        break;
                    case "ALLOTMENT":
                        mapper[i] = (e, v) => e.ALLOTMENT = v == null ? (short?)null : short.Parse(v);
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

        private Lazy<Dictionary<string, KSC>> Index_KSCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSC FindByKSCKEY(string KSCKEY)
        {
            return Index_KSCKEY.Value[KSCKEY];
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <param name="Value">Related KSC entity</param>
        /// <returns>True if the related KSC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSCKEY(string KSCKEY, out KSC Value)
        {
            return Index_KSCKEY.Value.TryGetValue(KSCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY field
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSC TryFindByKSCKEY(string KSCKEY)
        {
            KSC value;
            if (Index_KSCKEY.Value.TryGetValue(KSCKEY, out value))
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
