using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Invoice Allocations Data Set
    /// </summary>
    public sealed class STSB_DataSet : SetBase<STSB_Entity>
    {
        internal STSB_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "STSB"; } }


        
        protected override Action<STSB_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<STSB_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "PERCENTAGE":
                        mapper[i] = (e, v) => e.PERCENTAGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SPLIT_ITEM":
                        mapper[i] = (e, v) => e.SPLIT_ITEM = v;
                        break;
                    case "ITEM_TYPE":
                        mapper[i] = (e, v) => e.ITEM_TYPE = v;
                        break;
                    case "SPLIT_ITEM_SU":
                        mapper[i] = (e, v) => e.SPLIT_ITEM_SU = v;
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
