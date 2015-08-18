using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Institutions Data Set
    /// </summary>
    public sealed class KSIDataSet : SetBase<KSI>
    {
        private Lazy<Dictionary<string, KSI>> KSIKEYIndex;

        internal KSIDataSet(EduHubContext Context)
            : base(Context)
        {
            KSIKEYIndex = new Lazy<Dictionary<string, KSI>>(() => this.ToDictionary(e => e.KSIKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSI"; } }

        /// <summary>
        /// Find KSI by KSIKEY key field
        /// </summary>
        /// <param name="Key">KSIKEY value used to find KSI</param>
        /// <returns>Related KSI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSIKEY value didn't match any KSI entities</exception>
        public KSI FindByKSIKEY(string Key)
        {
            KSI result;
            if (KSIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSI by KSIKEY key field
        /// </summary>
        /// <param name="Key">KSIKEY value used to find KSI</param>
        /// <param name="Value">Related KSI entity</param>
        /// <returns>True if the KSI Entity is found</returns>
        public bool TryFindByKSIKEY(string Key, out KSI Value)
        {
            return KSIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSI by KSIKEY key field
        /// </summary>
        /// <param name="Key">KSIKEY value used to find KSI</param>
        /// <returns>Related KSI entity, or null if not found</returns>
        public KSI TryFindByKSIKEY(string Key)
        {
            KSI result;
            if (KSIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KSI, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KSI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSIKEY":
                        mapper[i] = (e, v) => e.KSIKEY = v;
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
