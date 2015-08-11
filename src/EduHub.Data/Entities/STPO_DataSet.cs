using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Position or Group Memberships Data Set
    /// </summary>
    public sealed class STPO_DataSet : SetBase<STPO_Entity>
    {
        internal STPO_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "STPO"; } }


        
        protected override Action<STPO_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<STPO_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STPOKEY":
                        mapper[i] = (e, v) => e.STPOKEY = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PERFORMANCE":
                        mapper[i] = (e, v) => e.PERFORMANCE = v;
                        break;
                    case "GROUP_ROLE":
                        mapper[i] = (e, v) => e.GROUP_ROLE = v;
                        break;
                    case "OTHER":
                        mapper[i] = (e, v) => e.OTHER = v;
                        break;
                    case "SG_TYPE":
                        mapper[i] = (e, v) => e.SG_TYPE = v;
                        break;
                    case "HOUSE_HG":
                        mapper[i] = (e, v) => e.HOUSE_HG = v;
                        break;
                    case "PERMISSION":
                        mapper[i] = (e, v) => e.PERMISSION = v;
                        break;
                    case "SCH_PERMISSION":
                        mapper[i] = (e, v) => e.SCH_PERMISSION = v;
                        break;
                    case "FULLY_PAID":
                        mapper[i] = (e, v) => e.FULLY_PAID = v;
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
