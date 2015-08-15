using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Houses Data Set
    /// </summary>
    public sealed class KGH_DataSet : SetBase<KGH_Entity>
    {
        private Lazy<Dictionary<string, KGH_Entity>> KGHKEY_Index;

        internal KGH_DataSet(EduHubContext Context)
            : base(Context)
        {
            KGHKEY_Index = new Lazy<Dictionary<string, KGH_Entity>>(() => this.ToDictionary(e => e.KGHKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KGH"; } }

        /// <summary>
        /// Find KGH by KGHKEY key field
        /// </summary>
        /// <param name="Key">KGHKEY value used to find KGH</param>
        /// <returns>Related KGH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGHKEY value didn't match any KGH entities</exception>
        public KGH_Entity FindByKGHKEY(string Key)
        {
            KGH_Entity result;
            if (KGHKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGH by KGHKEY key field
        /// </summary>
        /// <param name="Key">KGHKEY value used to find KGH</param>
        /// <param name="Value">Related KGH entity</param>
        /// <returns>True if the KGH Entity is found</returns>
        public bool TryFindByKGHKEY(string Key, out KGH_Entity Value)
        {
            return KGHKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGH by KGHKEY key field
        /// </summary>
        /// <param name="Key">KGHKEY value used to find KGH</param>
        /// <returns>Related KGH entity, or null if not found</returns>
        public KGH_Entity TryFindByKGHKEY(string Key)
        {
            KGH_Entity result;
            if (KGHKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KGH_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGH_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGHKEY":
                        mapper[i] = (e, v) => e.KGHKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "HOUSE_SIZE":
                        mapper[i] = (e, v) => e.HOUSE_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F01":
                        mapper[i] = (e, v) => e.AGE_F01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F02":
                        mapper[i] = (e, v) => e.AGE_F02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F03":
                        mapper[i] = (e, v) => e.AGE_F03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F04":
                        mapper[i] = (e, v) => e.AGE_F04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F05":
                        mapper[i] = (e, v) => e.AGE_F05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F06":
                        mapper[i] = (e, v) => e.AGE_F06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F07":
                        mapper[i] = (e, v) => e.AGE_F07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F08":
                        mapper[i] = (e, v) => e.AGE_F08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F09":
                        mapper[i] = (e, v) => e.AGE_F09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F10":
                        mapper[i] = (e, v) => e.AGE_F10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F11":
                        mapper[i] = (e, v) => e.AGE_F11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F12":
                        mapper[i] = (e, v) => e.AGE_F12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F13":
                        mapper[i] = (e, v) => e.AGE_F13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F14":
                        mapper[i] = (e, v) => e.AGE_F14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F15":
                        mapper[i] = (e, v) => e.AGE_F15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F16":
                        mapper[i] = (e, v) => e.AGE_F16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F17":
                        mapper[i] = (e, v) => e.AGE_F17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F18":
                        mapper[i] = (e, v) => e.AGE_F18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F19":
                        mapper[i] = (e, v) => e.AGE_F19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F20":
                        mapper[i] = (e, v) => e.AGE_F20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M01":
                        mapper[i] = (e, v) => e.AGE_M01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M02":
                        mapper[i] = (e, v) => e.AGE_M02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M03":
                        mapper[i] = (e, v) => e.AGE_M03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M04":
                        mapper[i] = (e, v) => e.AGE_M04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M05":
                        mapper[i] = (e, v) => e.AGE_M05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M06":
                        mapper[i] = (e, v) => e.AGE_M06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M07":
                        mapper[i] = (e, v) => e.AGE_M07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M08":
                        mapper[i] = (e, v) => e.AGE_M08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M09":
                        mapper[i] = (e, v) => e.AGE_M09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M10":
                        mapper[i] = (e, v) => e.AGE_M10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M11":
                        mapper[i] = (e, v) => e.AGE_M11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M12":
                        mapper[i] = (e, v) => e.AGE_M12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M13":
                        mapper[i] = (e, v) => e.AGE_M13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M14":
                        mapper[i] = (e, v) => e.AGE_M14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M15":
                        mapper[i] = (e, v) => e.AGE_M15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M16":
                        mapper[i] = (e, v) => e.AGE_M16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M17":
                        mapper[i] = (e, v) => e.AGE_M17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M18":
                        mapper[i] = (e, v) => e.AGE_M18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M19":
                        mapper[i] = (e, v) => e.AGE_M19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M20":
                        mapper[i] = (e, v) => e.AGE_M20 = v == null ? (short?)null : short.Parse(v);
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
