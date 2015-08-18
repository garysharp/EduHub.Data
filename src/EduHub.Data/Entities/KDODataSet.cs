using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Domains Data Set
    /// </summary>
    public sealed class KDODataSet : SetBase<KDO>
    {
        private Lazy<Dictionary<string, KDO>> KDOKEYIndex;

        internal KDODataSet(EduHubContext Context)
            : base(Context)
        {
            KDOKEYIndex = new Lazy<Dictionary<string, KDO>>(() => this.ToDictionary(e => e.KDOKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDO"; } }

        /// <summary>
        /// Find KDO by KDOKEY key field
        /// </summary>
        /// <param name="Key">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KDOKEY value didn't match any KDO entities</exception>
        public KDO FindByKDOKEY(string Key)
        {
            KDO result;
            if (KDOKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY key field
        /// </summary>
        /// <param name="Key">KDOKEY value used to find KDO</param>
        /// <param name="Value">Related KDO entity</param>
        /// <returns>True if the KDO Entity is found</returns>
        public bool TryFindByKDOKEY(string Key, out KDO Value)
        {
            return KDOKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KDO by KDOKEY key field
        /// </summary>
        /// <param name="Key">KDOKEY value used to find KDO</param>
        /// <returns>Related KDO entity, or null if not found</returns>
        public KDO TryFindByKDOKEY(string Key)
        {
            KDO result;
            if (KDOKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KDO, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KDO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AUSVELS_START":
                        mapper[i] = (e, v) => e.AUSVELS_START = v;
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
