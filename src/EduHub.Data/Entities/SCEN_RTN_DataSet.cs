using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Return Summary Data Data Set
    /// </summary>
    public sealed class SCEN_RTN_DataSet : SetBase<SCEN_RTN_Entity>
    {
        internal SCEN_RTN_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_RTN_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        public override string SetName { get { return "SCEN_RTN"; } }

        private Lazy<Dictionary<int, SCEN_RTN_Entity>> ID_Index;

        public SCEN_RTN_Entity FindByID(int Key)
        {
            SCEN_RTN_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByID(int Key, out SCEN_RTN_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }
        public SCEN_RTN_Entity TryFindByID(int Key)
        {
            SCEN_RTN_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SCEN_RTN_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_RTN_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "RN_SCHOOLNUMBER":
                        mapper[i] = (e, v) => e.RN_SCHOOLNUMBER = v;
                        break;
                    case "RN_SCHOOLNAME":
                        mapper[i] = (e, v) => e.RN_SCHOOLNAME = v;
                        break;
                    case "RN_SCHOOLTYPE":
                        mapper[i] = (e, v) => e.RN_SCHOOLTYPE = v;
                        break;
                    case "RN_MONTH":
                        mapper[i] = (e, v) => e.RN_MONTH = v;
                        break;
                    case "RN_YEAR":
                        mapper[i] = (e, v) => e.RN_YEAR = v;
                        break;
                    case "RN_STATUS":
                        mapper[i] = (e, v) => e.RN_STATUS = v;
                        break;
                    case "RN_CREATED":
                        mapper[i] = (e, v) => e.RN_CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RN_CREATEUSER":
                        mapper[i] = (e, v) => e.RN_CREATEUSER = v;
                        break;
                    case "RN_LUPDATED":
                        mapper[i] = (e, v) => e.RN_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RN_LUPDATEUSER":
                        mapper[i] = (e, v) => e.RN_LUPDATEUSER = v;
                        break;
                    case "SD_LREFRESHED":
                        mapper[i] = (e, v) => e.SD_LREFRESHED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SD_LVALIDATED":
                        mapper[i] = (e, v) => e.SD_LVALIDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SD_SRPFUNDEDFTE":
                        mapper[i] = (e, v) => e.SD_SRPFUNDEDFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_NOTSRPFUNDEDFTE":
                        mapper[i] = (e, v) => e.SD_NOTSRPFUNDEDFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_TOTALFTE":
                        mapper[i] = (e, v) => e.SD_TOTALFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_INCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_INCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_SYSTEMEXCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_SYSTEMEXCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_MANUALLYEXCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_MANUALLYEXCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_TOTALHC":
                        mapper[i] = (e, v) => e.SD_TOTALHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_ERRORCOUNT":
                        mapper[i] = (e, v) => e.SD_ERRORCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_UNPROCESSEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.SD_UNPROCESSEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_ACKNOWLEDGEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.SD_ACKNOWLEDGEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_LHMGREFRESHED":
                        mapper[i] = (e, v) => e.CSD_LHMGREFRESHED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_LUPDATED":
                        mapper[i] = (e, v) => e.CSD_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_LUPDATEUSER":
                        mapper[i] = (e, v) => e.CSD_LUPDATEUSER = v;
                        break;
                    case "CSD_LVALIDATED":
                        mapper[i] = (e, v) => e.CSD_LVALIDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_CLASSCOUNT":
                        mapper[i] = (e, v) => e.CSD_CLASSCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_STUDENTHC":
                        mapper[i] = (e, v) => e.CSD_STUDENTHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_TEACHERFTE":
                        mapper[i] = (e, v) => e.CSD_TEACHERFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CSD_ERRORCOUNT":
                        mapper[i] = (e, v) => e.CSD_ERRORCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_UNPROCESSEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.CSD_UNPROCESSEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_ACKNOWLEDGEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.CSD_ACKNOWLEDGEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LD_CONTACTNAME":
                        mapper[i] = (e, v) => e.LD_CONTACTNAME = v;
                        break;
                    case "LD_CONTACTPHONE":
                        mapper[i] = (e, v) => e.LD_CONTACTPHONE = v;
                        break;
                    case "LD_PRINCIPALNAME":
                        mapper[i] = (e, v) => e.LD_PRINCIPALNAME = v;
                        break;
                    case "LD_PRINCIPALPHONE":
                        mapper[i] = (e, v) => e.LD_PRINCIPALPHONE = v;
                        break;
                    case "LD_COMMENTS":
                        mapper[i] = (e, v) => e.LD_COMMENTS = v;
                        break;
                    case "LD_USERCERTIFICATION":
                        mapper[i] = (e, v) => e.LD_USERCERTIFICATION = v;
                        break;
                    case "LD_FINALREPORTLOCATION":
                        mapper[i] = (e, v) => e.LD_FINALREPORTLOCATION = v;
                        break;
                    case "LD_STATUS":
                        mapper[i] = (e, v) => e.LD_STATUS = v;
                        break;
                    case "LD_CREATED":
                        mapper[i] = (e, v) => e.LD_CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LODGED":
                        mapper[i] = (e, v) => e.LD_LODGED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LUPDATEUSER":
                        mapper[i] = (e, v) => e.LD_LUPDATEUSER = v;
                        break;
                    case "LD_LUPDATED":
                        mapper[i] = (e, v) => e.LD_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
