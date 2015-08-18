using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Note Categories Data Set
    /// </summary>
    public sealed class KPNDataSet : SetBase<KPN>
    {
        private Lazy<Dictionary<string, KPN>> KPNKEYIndex;

        internal KPNDataSet(EduHubContext Context)
            : base(Context)
        {
            KPNKEYIndex = new Lazy<Dictionary<string, KPN>>(() => this.ToDictionary(e => e.KPNKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPN"; } }

        /// <summary>
        /// Find KPN by KPNKEY key field
        /// </summary>
        /// <param name="Key">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPNKEY value didn't match any KPN entities</exception>
        public KPN FindByKPNKEY(string Key)
        {
            KPN result;
            if (KPNKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY key field
        /// </summary>
        /// <param name="Key">KPNKEY value used to find KPN</param>
        /// <param name="Value">Related KPN entity</param>
        /// <returns>True if the KPN Entity is found</returns>
        public bool TryFindByKPNKEY(string Key, out KPN Value)
        {
            return KPNKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY key field
        /// </summary>
        /// <param name="Key">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity, or null if not found</returns>
        public KPN TryFindByKPNKEY(string Key)
        {
            KPN result;
            if (KPNKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KPN, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPNKEY":
                        mapper[i] = (e, v) => e.KPNKEY = v;
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
    }
}
