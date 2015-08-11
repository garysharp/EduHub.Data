using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Dates for Absences Data Set
    /// </summary>
    public sealed class KCC_DataSet : SetBase<KCC_Entity>
    {
        internal KCC_DataSet(EduHubContext Context)
            : base(Context)
        {
            KCCKEY_Index = new Lazy<Dictionary<DateTime, KCC_Entity>>(() => this.ToDictionary(e => e.KCCKEY));
        }

        public override string SetName { get { return "KCC"; } }

        private Lazy<Dictionary<DateTime, KCC_Entity>> KCCKEY_Index;

        public KCC_Entity FindByKCCKEY(DateTime Key)
        {
            KCC_Entity result;
            if (KCCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKCCKEY(DateTime Key, out KCC_Entity Value)
        {
            return KCCKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KCC_Entity TryFindByKCCKEY(DateTime Key)
        {
            KCC_Entity result;
            if (KCCKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KCC_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCC_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCCKEY":
                        mapper[i] = (e, v) => e.KCCKEY = DateTime.Parse(v);
                        break;
                    case "DAYTODAY":
                        mapper[i] = (e, v) => e.DAYTODAY = v;
                        break;
                    case "DAY_TYPE":
                        mapper[i] = (e, v) => e.DAY_TYPE = v;
                        break;
                    case "JULIAN":
                        mapper[i] = (e, v) => e.JULIAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_YEAR":
                        mapper[i] = (e, v) => e.DAY_YEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_MONTH":
                        mapper[i] = (e, v) => e.DAY_MONTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERM":
                        mapper[i] = (e, v) => e.TERM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WEEK":
                        mapper[i] = (e, v) => e.WEEK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_CYCLE":
                        mapper[i] = (e, v) => e.DAY_CYCLE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CURRENT_QUILT":
                        mapper[i] = (e, v) => e.CURRENT_QUILT = v;
                        break;
                    case "HALF_DAY_GENERATED":
                        mapper[i] = (e, v) => e.HALF_DAY_GENERATED = v;
                        break;
                    case "PERIOD_GENERATED":
                        mapper[i] = (e, v) => e.PERIOD_GENERATED = v;
                        break;
                    case "PAR_SOURCE":
                        mapper[i] = (e, v) => e.PAR_SOURCE = v;
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
