using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimensions Data Set
    /// </summary>
    public sealed class KDI_DataSet : SetBase<KDI_Entity>
    {
        private Lazy<Dictionary<string, KDI_Entity>> KDIKEY_Index;

        internal KDI_DataSet(EduHubContext Context)
            : base(Context)
        {
            KDIKEY_Index = new Lazy<Dictionary<string, KDI_Entity>>(() => this.ToDictionary(e => e.KDIKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KDI"; } }

        /// <summary>
        /// Find KDI by KDIKEY key field
        /// </summary>
        /// <param name="Key">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KDIKEY value didn't match any KDI entities</exception>
        public KDI_Entity FindByKDIKEY(string Key)
        {
            KDI_Entity result;
            if (KDIKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY key field
        /// </summary>
        /// <param name="Key">KDIKEY value used to find KDI</param>
        /// <param name="Value">Related KDI entity</param>
        /// <returns>True if the KDI Entity is found</returns>
        public bool TryFindByKDIKEY(string Key, out KDI_Entity Value)
        {
            return KDIKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY key field
        /// </summary>
        /// <param name="Key">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity, or null if not found</returns>
        public KDI_Entity TryFindByKDIKEY(string Key)
        {
            KDI_Entity result;
            if (KDIKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KDI_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KDI_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDIKEY":
                        mapper[i] = (e, v) => e.KDIKEY = v;
                        break;
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MIN_SCORE":
                        mapper[i] = (e, v) => e.MIN_SCORE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MAX_SCORE":
                        mapper[i] = (e, v) => e.MAX_SCORE = v == null ? (double?)null : double.Parse(v);
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
