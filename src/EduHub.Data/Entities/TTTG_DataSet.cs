using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Grid Subjects Data Set
    /// </summary>
    public sealed class TTTG_DataSet : SetBase<TTTG_Entity>
    {
        internal TTTG_DataSet(EduHubContext Context)
            : base(Context)
        {
            IDENT_Index = new Lazy<Dictionary<int, TTTG_Entity>>(() => this.ToDictionary(e => e.IDENT));
        }

        public override string SetName { get { return "TTTG"; } }

        private Lazy<Dictionary<int, TTTG_Entity>> IDENT_Index;

        public TTTG_Entity FindByIDENT(int Key)
        {
            TTTG_Entity result;
            if (IDENT_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByIDENT(int Key, out TTTG_Entity Value)
        {
            return IDENT_Index.Value.TryGetValue(Key, out Value);
        }
        public TTTG_Entity TryFindByIDENT(int Key)
        {
            TTTG_Entity result;
            if (IDENT_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<TTTG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TTTG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FIRST_CLASS":
                        mapper[i] = (e, v) => e.FIRST_CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NSET":
                        mapper[i] = (e, v) => e.NSET = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "IDENT":
                        mapper[i] = (e, v) => e.IDENT = int.Parse(v);
                        break;
                    case "CLASS_SIZE":
                        mapper[i] = (e, v) => e.CLASS_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXIMUM":
                        mapper[i] = (e, v) => e.MAXIMUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MINIMUM":
                        mapper[i] = (e, v) => e.MINIMUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MINLINE":
                        mapper[i] = (e, v) => e.MINLINE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXLINE":
                        mapper[i] = (e, v) => e.MAXLINE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MCOLOUR":
                        mapper[i] = (e, v) => e.MCOLOUR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GCOLOUR":
                        mapper[i] = (e, v) => e.GCOLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNITS":
                        mapper[i] = (e, v) => e.UNITS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "T1TEACH":
                        mapper[i] = (e, v) => e.T1TEACH = v;
                        break;
                    case "T2TEACH":
                        mapper[i] = (e, v) => e.T2TEACH = v;
                        break;
                    case "R1ROOM":
                        mapper[i] = (e, v) => e.R1ROOM = v;
                        break;
                    case "R2ROOM":
                        mapper[i] = (e, v) => e.R2ROOM = v;
                        break;
                    case "RESOURCES01":
                        mapper[i] = (e, v) => e.RESOURCES01 = v;
                        break;
                    case "RESOURCES02":
                        mapper[i] = (e, v) => e.RESOURCES02 = v;
                        break;
                    case "RESOURCES03":
                        mapper[i] = (e, v) => e.RESOURCES03 = v;
                        break;
                    case "RESOURCES04":
                        mapper[i] = (e, v) => e.RESOURCES04 = v;
                        break;
                    case "RESOURCES05":
                        mapper[i] = (e, v) => e.RESOURCES05 = v;
                        break;
                    case "RESOURCES06":
                        mapper[i] = (e, v) => e.RESOURCES06 = v;
                        break;
                    case "RESOURCES07":
                        mapper[i] = (e, v) => e.RESOURCES07 = v;
                        break;
                    case "RESOURCES08":
                        mapper[i] = (e, v) => e.RESOURCES08 = v;
                        break;
                    case "RESOURCES09":
                        mapper[i] = (e, v) => e.RESOURCES09 = v;
                        break;
                    case "LAB":
                        mapper[i] = (e, v) => e.LAB = v;
                        break;
                    case "FROW":
                        mapper[i] = (e, v) => e.FROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FCOL":
                        mapper[i] = (e, v) => e.FCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HROW":
                        mapper[i] = (e, v) => e.HROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HCOL":
                        mapper[i] = (e, v) => e.HCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "BLOCK":
                        mapper[i] = (e, v) => e.BLOCK = v;
                        break;
                    case "LOCK":
                        mapper[i] = (e, v) => e.LOCK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TCHAIN":
                        mapper[i] = (e, v) => e.TCHAIN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LCHAIN":
                        mapper[i] = (e, v) => e.LCHAIN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIED_COL":
                        mapper[i] = (e, v) => e.TIED_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LINK_COL":
                        mapper[i] = (e, v) => e.LINK_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_ROW_CLASSES":
                        mapper[i] = (e, v) => e.MAX_ROW_CLASSES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROW_GROUP":
                        mapper[i] = (e, v) => e.ROW_GROUP = v;
                        break;
                    case "DOUBLE_PERIODS":
                        mapper[i] = (e, v) => e.DOUBLE_PERIODS = v == null ? (short?)null : short.Parse(v);
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
