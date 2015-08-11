using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Scheduled Sessions Data Set
    /// </summary>
    public sealed class SXAS_DataSet : SetBase<SXAS_Entity>
    {
        internal SXAS_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, SXAS_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "SXAS"; } }

        private Lazy<Dictionary<int, SXAS_Entity>> TID_Index;

        public SXAS_Entity FindByTID(int Key)
        {
            SXAS_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out SXAS_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public SXAS_Entity TryFindByTID(int Key)
        {
            SXAS_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SXAS_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SXAS_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TXAS_ID":
                        mapper[i] = (e, v) => e.TXAS_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "EXP_ABS_TYPE":
                        mapper[i] = (e, v) => e.EXP_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
                        break;
                    case "ACT_ABS_TYPE":
                        mapper[i] = (e, v) => e.ACT_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "APPROVED":
                        mapper[i] = (e, v) => e.APPROVED = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "ACTION_TAKEN":
                        mapper[i] = (e, v) => e.ACTION_TAKEN = v;
                        break;
                    case "ABSENCE_DATE":
                        mapper[i] = (e, v) => e.ABSENCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ABSENCE_PERIOD":
                        mapper[i] = (e, v) => e.ABSENCE_PERIOD = v == null ? (short?)null : short.Parse(v);
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
