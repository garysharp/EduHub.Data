using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types Data Set
    /// </summary>
    public sealed class KCT_DataSet : SetBase<KCT_Entity>
    {
        private Lazy<Dictionary<short, KCT_Entity>> KCTKEY_Index;

        internal KCT_DataSet(EduHubContext Context)
            : base(Context)
        {
            KCTKEY_Index = new Lazy<Dictionary<short, KCT_Entity>>(() => this.ToDictionary(e => e.KCTKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KCT"; } }

        /// <summary>
        /// Find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCTKEY value didn't match any KCT entities</exception>
        public KCT_Entity FindByKCTKEY(short Key)
        {
            KCT_Entity result;
            if (KCTKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <param name="Value">Related KCT entity</param>
        /// <returns>True if the KCT Entity is found</returns>
        public bool TryFindByKCTKEY(short Key, out KCT_Entity Value)
        {
            return KCTKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity, or null if not found</returns>
        public KCT_Entity TryFindByKCTKEY(short Key)
        {
            KCT_Entity result;
            if (KCTKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KCT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCTKEY":
                        mapper[i] = (e, v) => e.KCTKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABBREV_DESC":
                        mapper[i] = (e, v) => e.ABBREV_DESC = v;
                        break;
                    case "CURRICULUM":
                        mapper[i] = (e, v) => e.CURRICULUM = v;
                        break;
                    case "DOE_TYPE":
                        mapper[i] = (e, v) => e.DOE_TYPE = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "PRE_APPROVED":
                        mapper[i] = (e, v) => e.PRE_APPROVED = v;
                        break;
                    case "ABS_RATE":
                        mapper[i] = (e, v) => e.ABS_RATE = v == null ? (short?)null : short.Parse(v);
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
