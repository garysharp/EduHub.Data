using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvement Injuries Data Set
    /// </summary>
    public sealed class SAII_DataSet : SetBase<SAII_Entity>
    {
        internal SAII_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "SAII"; } }


        
        protected override Action<SAII_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SAII_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INVOLVEMENTID":
                        mapper[i] = (e, v) => e.INVOLVEMENTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SEVERITY":
                        mapper[i] = (e, v) => e.SEVERITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SRI_TYPE":
                        mapper[i] = (e, v) => e.SRI_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NATURE":
                        mapper[i] = (e, v) => e.NATURE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_INFO":
                        mapper[i] = (e, v) => e.OTHER_INFO = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v == null ? (short?)null : short.Parse(v);
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
