using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Locations Data Set
    /// </summary>
    public sealed class AKL_DataSet : SetBase<AKL_Entity>
    {
        internal AKL_DataSet(EduHubContext Context)
            : base(Context)
        {
            LOCATION_Index = new Lazy<Dictionary<string, AKL_Entity>>(() => this.ToDictionary(e => e.LOCATION));
        }

        public override string SetName { get { return "AKL"; } }

        private Lazy<Dictionary<string, AKL_Entity>> LOCATION_Index;

        public AKL_Entity FindByLOCATION(string Key)
        {
            AKL_Entity result;
            if (LOCATION_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByLOCATION(string Key, out AKL_Entity Value)
        {
            return LOCATION_Index.Value.TryGetValue(Key, out Value);
        }
        public AKL_Entity TryFindByLOCATION(string Key)
        {
            AKL_Entity result;
            if (LOCATION_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<AKL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<AKL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ESTIMATE_UNITS":
                        mapper[i] = (e, v) => e.ESTIMATE_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNITS_TO_DATE":
                        mapper[i] = (e, v) => e.UNITS_TO_DATE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACUTOFF":
                        mapper[i] = (e, v) => e.ACUTOFF = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATEFU":
                        mapper[i] = (e, v) => e.DATEFU = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PURDATE":
                        mapper[i] = (e, v) => e.PURDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AFLAG":
                        mapper[i] = (e, v) => e.AFLAG = v;
                        break;
                    case "TFLAG":
                        mapper[i] = (e, v) => e.TFLAG = v;
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
