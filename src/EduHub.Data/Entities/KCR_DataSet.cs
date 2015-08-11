using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Routes/Stops Data Set
    /// </summary>
    public sealed class KCR_DataSet : SetBase<KCR_Entity>
    {
        internal KCR_DataSet(EduHubContext Context)
            : base(Context)
        {
            KCRKEY_Index = new Lazy<Dictionary<string, KCR_Entity>>(() => this.ToDictionary(e => e.KCRKEY));
        }

        public override string SetName { get { return "KCR"; } }

        private Lazy<Dictionary<string, KCR_Entity>> KCRKEY_Index;

        public KCR_Entity FindByKCRKEY(string Key)
        {
            KCR_Entity result;
            if (KCRKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKCRKEY(string Key, out KCR_Entity Value)
        {
            return KCRKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KCR_Entity TryFindByKCRKEY(string Key)
        {
            KCR_Entity result;
            if (KCRKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KCR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCRKEY":
                        mapper[i] = (e, v) => e.KCRKEY = v;
                        break;
                    case "TRANSPORT_TYPE":
                        mapper[i] = (e, v) => e.TRANSPORT_TYPE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROUTE_CODE":
                        mapper[i] = (e, v) => e.ROUTE_CODE = v;
                        break;
                    case "STOP_DESCRIP":
                        mapper[i] = (e, v) => e.STOP_DESCRIP = v;
                        break;
                    case "DAYOFWK01":
                        mapper[i] = (e, v) => e.DAYOFWK01 = v;
                        break;
                    case "DAYOFWK02":
                        mapper[i] = (e, v) => e.DAYOFWK02 = v;
                        break;
                    case "DAYOFWK03":
                        mapper[i] = (e, v) => e.DAYOFWK03 = v;
                        break;
                    case "DAYOFWK04":
                        mapper[i] = (e, v) => e.DAYOFWK04 = v;
                        break;
                    case "DAYOFWK05":
                        mapper[i] = (e, v) => e.DAYOFWK05 = v;
                        break;
                    case "DEPART_AM":
                        mapper[i] = (e, v) => e.DEPART_AM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEPART_PM":
                        mapper[i] = (e, v) => e.DEPART_PM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ARRIVE_AM":
                        mapper[i] = (e, v) => e.ARRIVE_AM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ARRIVE_PM":
                        mapper[i] = (e, v) => e.ARRIVE_PM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "NO_OF_STUD":
                        mapper[i] = (e, v) => e.NO_OF_STUD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PROG_NO":
                        mapper[i] = (e, v) => e.PROG_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DIST_LAST":
                        mapper[i] = (e, v) => e.DIST_LAST = v == null ? (double?)null : double.Parse(v);
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
