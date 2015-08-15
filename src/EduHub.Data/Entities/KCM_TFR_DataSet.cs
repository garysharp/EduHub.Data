using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// KCM Transfer Data Set
    /// </summary>
    public sealed class KCM_TFR_DataSet : SetBase<KCM_TFR_Entity>
    {

        internal KCM_TFR_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KCM_TFR"; } }

        protected override Action<KCM_TFR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCM_TFR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "KCM_TRANS_ID":
                        mapper[i] = (e, v) => e.KCM_TRANS_ID = v;
                        break;
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
                        break;
                    case "KCMKEY_NEW":
                        mapper[i] = (e, v) => e.KCMKEY_NEW = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
