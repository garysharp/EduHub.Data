using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Selections & Marks Data Set
    /// </summary>
    public sealed class STMA_DataSet : SetBase<STMA_Entity>
    {
        internal STMA_DataSet(EduHubContext Context)
            : base(Context)
        {
            IDENT_Index = new Lazy<Dictionary<int, STMA_Entity>>(() => this.ToDictionary(e => e.IDENT));
            TTPERIOD_Index = new Lazy<Dictionary<string, STMA_Entity>>(() => this.ToDictionary(e => e.TTPERIOD));
        }

        public override string SetName { get { return "STMA"; } }

        private Lazy<Dictionary<int, STMA_Entity>> IDENT_Index;
        private Lazy<Dictionary<string, STMA_Entity>> TTPERIOD_Index;

        public STMA_Entity FindByIDENT(int Key)
        {
            STMA_Entity result;
            if (IDENT_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByIDENT(int Key, out STMA_Entity Value)
        {
            return IDENT_Index.Value.TryGetValue(Key, out Value);
        }
        public STMA_Entity TryFindByIDENT(int Key)
        {
            STMA_Entity result;
            if (IDENT_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public STMA_Entity FindByTTPERIOD(string Key)
        {
            STMA_Entity result;
            if (TTPERIOD_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTTPERIOD(string Key, out STMA_Entity Value)
        {
            return TTPERIOD_Index.Value.TryGetValue(Key, out Value);
        }
        public STMA_Entity TryFindByTTPERIOD(string Key)
        {
            STMA_Entity result;
            if (TTPERIOD_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<STMA_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<STMA_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "MKEY":
                        mapper[i] = (e, v) => e.MKEY = v;
                        break;
                    case "CKEY":
                        mapper[i] = (e, v) => e.CKEY = v;
                        break;
                    case "PRIORITY":
                        mapper[i] = (e, v) => e.PRIORITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FULLNAME":
                        mapper[i] = (e, v) => e.FULLNAME = v;
                        break;
                    case "TEACHER_NAME":
                        mapper[i] = (e, v) => e.TEACHER_NAME = v;
                        break;
                    case "IDENT":
                        mapper[i] = (e, v) => e.IDENT = int.Parse(v);
                        break;
                    case "LOCK":
                        mapper[i] = (e, v) => e.LOCK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRPERIOD":
                        mapper[i] = (e, v) => e.TRPERIOD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "CYEAR":
                        mapper[i] = (e, v) => e.CYEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DROPOUT":
                        mapper[i] = (e, v) => e.DROPOUT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GRADE01":
                        mapper[i] = (e, v) => e.GRADE01 = v;
                        break;
                    case "GRADE02":
                        mapper[i] = (e, v) => e.GRADE02 = v;
                        break;
                    case "GRADE03":
                        mapper[i] = (e, v) => e.GRADE03 = v;
                        break;
                    case "GRADE04":
                        mapper[i] = (e, v) => e.GRADE04 = v;
                        break;
                    case "GRADE05":
                        mapper[i] = (e, v) => e.GRADE05 = v;
                        break;
                    case "COMMENTA":
                        mapper[i] = (e, v) => e.COMMENTA = v;
                        break;
                    case "COMMENTB":
                        mapper[i] = (e, v) => e.COMMENTB = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "TOT_CLASS_PERIODS":
                        mapper[i] = (e, v) => e.TOT_CLASS_PERIODS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOT_APPROVED_ABS":
                        mapper[i] = (e, v) => e.TOT_APPROVED_ABS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOT_UNAPPROVED_ABS":
                        mapper[i] = (e, v) => e.TOT_UNAPPROVED_ABS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EQUIVALENT_KLA":
                        mapper[i] = (e, v) => e.EQUIVALENT_KLA = v;
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
