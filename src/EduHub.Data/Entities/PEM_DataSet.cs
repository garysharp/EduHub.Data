using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Advice Slip Message Data Set
    /// </summary>
    public sealed class PEM_DataSet : SetBase<PEM_Entity>
    {
        internal PEM_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "PEM"; } }


        
        protected override Action<PEM_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PEM_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "START_TRPAYPERD":
                        mapper[i] = (e, v) => e.START_TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "END_TRPAYPERD":
                        mapper[i] = (e, v) => e.END_TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMP_MESSAGE":
                        mapper[i] = (e, v) => e.EMP_MESSAGE = v;
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
