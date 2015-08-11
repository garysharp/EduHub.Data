using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Data Data Set
    /// </summary>
    public sealed class SCEN_CL_DataSet : SetBase<SCEN_CL_Entity>
    {
        internal SCEN_CL_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_CL_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        public override string SetName { get { return "SCEN_CL"; } }

        private Lazy<Dictionary<int, SCEN_CL_Entity>> ID_Index;

        public SCEN_CL_Entity FindByID(int Key)
        {
            SCEN_CL_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByID(int Key, out SCEN_CL_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }
        public SCEN_CL_Entity TryFindByID(int Key)
        {
            SCEN_CL_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SCEN_CL_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_CL_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "CAMPUSNUMBER":
                        mapper[i] = (e, v) => e.CAMPUSNUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASSCODE":
                        mapper[i] = (e, v) => e.CLASSCODE = v;
                        break;
                    case "CLASSTYPE":
                        mapper[i] = (e, v) => e.CLASSTYPE = v;
                        break;
                    case "FTETEACHERS":
                        mapper[i] = (e, v) => e.FTETEACHERS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PREP":
                        mapper[i] = (e, v) => e.PREP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR01":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR02":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR03":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR04":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR05":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR06":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR07":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR08":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR09":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR10":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR11":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR12":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRIMARYUG":
                        mapper[i] = (e, v) => e.PRIMARYUG = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SENIORUG":
                        mapper[i] = (e, v) => e.SENIORUG = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
