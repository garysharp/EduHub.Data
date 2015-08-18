using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year Levels Data Set
    /// </summary>
    public sealed class KCYDataSet : SetBase<KCY>
    {
        private Lazy<Dictionary<string, KCY>> KCYKEYIndex;

        internal KCYDataSet(EduHubContext Context)
            : base(Context)
        {
            KCYKEYIndex = new Lazy<Dictionary<string, KCY>>(() => this.ToDictionary(e => e.KCYKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCY"; } }

        /// <summary>
        /// Find KCY by KCYKEY key field
        /// </summary>
        /// <param name="Key">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCYKEY value didn't match any KCY entities</exception>
        public KCY FindByKCYKEY(string Key)
        {
            KCY result;
            if (KCYKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY key field
        /// </summary>
        /// <param name="Key">KCYKEY value used to find KCY</param>
        /// <param name="Value">Related KCY entity</param>
        /// <returns>True if the KCY Entity is found</returns>
        public bool TryFindByKCYKEY(string Key, out KCY Value)
        {
            return KCYKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY key field
        /// </summary>
        /// <param name="Key">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity, or null if not found</returns>
        public KCY TryFindByKCYKEY(string Key)
        {
            KCY result;
            if (KCYKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KCY, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCYKEY":
                        mapper[i] = (e, v) => e.KCYKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NUM_EQVT":
                        mapper[i] = (e, v) => e.NUM_EQVT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SHORT_DESC":
                        mapper[i] = (e, v) => e.SHORT_DESC = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "NEXT_YR":
                        mapper[i] = (e, v) => e.NEXT_YR = v;
                        break;
                    case "FINAL_YR":
                        mapper[i] = (e, v) => e.FINAL_YR = v;
                        break;
                    case "CSF_REQUIRED":
                        mapper[i] = (e, v) => e.CSF_REQUIRED = v;
                        break;
                    case "HALF_DAY_ABS":
                        mapper[i] = (e, v) => e.HALF_DAY_ABS = v;
                        break;
                    case "PERIOD_ABS":
                        mapper[i] = (e, v) => e.PERIOD_ABS = v;
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
