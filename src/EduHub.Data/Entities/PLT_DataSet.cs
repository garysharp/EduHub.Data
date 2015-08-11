using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Group Types Data Set
    /// </summary>
    public sealed class PLT_DataSet : SetBase<PLT_Entity>
    {
        internal PLT_DataSet(EduHubContext Context)
            : base(Context)
        {
            PLTKEY_Index = new Lazy<Dictionary<string, PLT_Entity>>(() => this.ToDictionary(e => e.PLTKEY));
        }

        public override string SetName { get { return "PLT"; } }

        private Lazy<Dictionary<string, PLT_Entity>> PLTKEY_Index;

        public PLT_Entity FindByPLTKEY(string Key)
        {
            PLT_Entity result;
            if (PLTKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPLTKEY(string Key, out PLT_Entity Value)
        {
            return PLTKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public PLT_Entity TryFindByPLTKEY(string Key)
        {
            PLT_Entity result;
            if (PLTKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<PLT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PLT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "CALC_METHOD":
                        mapper[i] = (e, v) => e.CALC_METHOD = v;
                        break;
                    case "PERIOD_ALLOT01":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT02":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT03":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT04":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT05":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT06":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT06 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT07":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT07 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT08":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT08 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT09":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT09 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT10":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT10 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT11":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT11 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT12":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT12 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH01":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH02":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH03":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH04":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH05":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH06":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH07":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH08":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH09":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH10":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH11":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH12":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v;
                        break;
                    case "ANNUAL_ENTITLEMENT":
                        mapper[i] = (e, v) => e.ANNUAL_ENTITLEMENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ROLL_OVER":
                        mapper[i] = (e, v) => e.ROLL_OVER = v;
                        break;
                    case "ROLL_PERCENT":
                        mapper[i] = (e, v) => e.ROLL_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_LOADING":
                        mapper[i] = (e, v) => e.LEAVE_LOADING = v;
                        break;
                    case "LOADING_PERCENT":
                        mapper[i] = (e, v) => e.LOADING_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
