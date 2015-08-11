using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Half-Day Absences Data Set
    /// </summary>
    public sealed class SXAB_DataSet : SetBase<SXAB_Entity>
    {
        internal SXAB_DataSet(EduHubContext Context)
            : base(Context)
        {
            SXAB_ID_Index = new Lazy<Dictionary<int, SXAB_Entity>>(() => this.ToDictionary(e => e.SXAB_ID));
        }

        public override string SetName { get { return "SXAB"; } }

        private Lazy<Dictionary<int, SXAB_Entity>> SXAB_ID_Index;

        public SXAB_Entity FindBySXAB_ID(int Key)
        {
            SXAB_Entity result;
            if (SXAB_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySXAB_ID(int Key, out SXAB_Entity Value)
        {
            return SXAB_ID_Index.Value.TryGetValue(Key, out Value);
        }
        public SXAB_Entity TryFindBySXAB_ID(int Key)
        {
            SXAB_Entity result;
            if (SXAB_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SXAB_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SXAB_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SXAB_ID":
                        mapper[i] = (e, v) => e.SXAB_ID = int.Parse(v);
                        break;
                    case "TXHG_TID":
                        mapper[i] = (e, v) => e.TXHG_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "ABSENCE_DATE":
                        mapper[i] = (e, v) => e.ABSENCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ABSENCE_COMMENT":
                        mapper[i] = (e, v) => e.ABSENCE_COMMENT = v;
                        break;
                    case "AM_EXP_TYPE":
                        mapper[i] = (e, v) => e.AM_EXP_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_ATTENDED":
                        mapper[i] = (e, v) => e.AM_ATTENDED = v;
                        break;
                    case "AM_ACT_TYPE":
                        mapper[i] = (e, v) => e.AM_ACT_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_APPROVED":
                        mapper[i] = (e, v) => e.AM_APPROVED = v;
                        break;
                    case "AM_LATE_ARRIVAL":
                        mapper[i] = (e, v) => e.AM_LATE_ARRIVAL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_EARLY_LEFT":
                        mapper[i] = (e, v) => e.AM_EARLY_LEFT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_EXP_TYPE":
                        mapper[i] = (e, v) => e.PM_EXP_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_ATTENDED":
                        mapper[i] = (e, v) => e.PM_ATTENDED = v;
                        break;
                    case "PM_ACT_TYPE":
                        mapper[i] = (e, v) => e.PM_ACT_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_APPROVED":
                        mapper[i] = (e, v) => e.PM_APPROVED = v;
                        break;
                    case "PM_LATE_ARRIVAL":
                        mapper[i] = (e, v) => e.PM_LATE_ARRIVAL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_EARLY_LEFT":
                        mapper[i] = (e, v) => e.PM_EARLY_LEFT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "CONTACT_METHOD":
                        mapper[i] = (e, v) => e.CONTACT_METHOD = v;
                        break;
                    case "SICKBAY":
                        mapper[i] = (e, v) => e.SICKBAY = v;
                        break;
                    case "LAST_ACTION":
                        mapper[i] = (e, v) => e.LAST_ACTION = v;
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
