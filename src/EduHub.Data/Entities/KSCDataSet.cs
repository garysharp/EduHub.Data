using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Positions Data Set
    /// </summary>
    public sealed class KSCDataSet : SetBase<KSC>
    {
        private Lazy<Dictionary<string, KSC>> KSCKEYIndex;

        internal KSCDataSet(EduHubContext Context)
            : base(Context)
        {
            KSCKEYIndex = new Lazy<Dictionary<string, KSC>>(() => this.ToDictionary(e => e.KSCKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSC"; } }

        /// <summary>
        /// Find KSC by KSCKEY key field
        /// </summary>
        /// <param name="Key">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSCKEY value didn't match any KSC entities</exception>
        public KSC FindByKSCKEY(string Key)
        {
            KSC result;
            if (KSCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY key field
        /// </summary>
        /// <param name="Key">KSCKEY value used to find KSC</param>
        /// <param name="Value">Related KSC entity</param>
        /// <returns>True if the KSC Entity is found</returns>
        public bool TryFindByKSCKEY(string Key, out KSC Value)
        {
            return KSCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY key field
        /// </summary>
        /// <param name="Key">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity, or null if not found</returns>
        public KSC TryFindByKSCKEY(string Key)
        {
            KSC result;
            if (KSCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KSC, string>[] BuildMapper(List<string> Headers)
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
    }
}
