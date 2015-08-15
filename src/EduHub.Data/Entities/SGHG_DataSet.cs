using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Eligibility Criteria Data Set
    /// </summary>
    public sealed class SGHG_DataSet : SetBase<SGHG_Entity>
    {

        internal SGHG_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SGHG"; } }

        protected override Action<SGHG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SGHG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SGHGKEY":
                        mapper[i] = (e, v) => e.SGHGKEY = v;
                        break;
                    case "KGCLINK":
                        mapper[i] = (e, v) => e.KGCLINK = v;
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
