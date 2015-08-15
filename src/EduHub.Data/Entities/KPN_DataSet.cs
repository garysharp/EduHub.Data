using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Note Categories Data Set
    /// </summary>
    public sealed class KPN_DataSet : SetBase<KPN_Entity>
    {
        private Lazy<Dictionary<string, KPN_Entity>> KPNKEY_Index;

        internal KPN_DataSet(EduHubContext Context)
            : base(Context)
        {
            KPNKEY_Index = new Lazy<Dictionary<string, KPN_Entity>>(() => this.ToDictionary(e => e.KPNKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KPN"; } }

        /// <summary>
        /// Find KPN by KPNKEY key field
        /// </summary>
        /// <param name="Key">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPNKEY value didn't match any KPN entities</exception>
        public KPN_Entity FindByKPNKEY(string Key)
        {
            KPN_Entity result;
            if (KPNKEY_Index.Value.TryGetValue(Key, out result))
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
        public bool TryFindByKPNKEY(string Key, out KPN_Entity Value)
        {
            return KPNKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY key field
        /// </summary>
        /// <param name="Key">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity, or null if not found</returns>
        public KPN_Entity TryFindByKPNKEY(string Key)
        {
            KPN_Entity result;
            if (KPNKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KPN_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KPN_Entity, string>[Headers.Count];

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
