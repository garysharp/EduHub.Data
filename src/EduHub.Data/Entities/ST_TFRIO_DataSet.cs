using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Data Transfer Table Data Set
    /// </summary>
    public sealed class ST_TFRIO_DataSet : SetBase<ST_TFRIO_Entity>
    {

        internal ST_TFRIO_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "ST_TFRIO"; } }

        protected override Action<ST_TFRIO_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<ST_TFRIO_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "STKEY_NEW":
                        mapper[i] = (e, v) => e.STKEY_NEW = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TFR_PERMISSION":
                        mapper[i] = (e, v) => e.TFR_PERMISSION = v;
                        break;
                    case "SOURCE_SCHOOL":
                        mapper[i] = (e, v) => e.SOURCE_SCHOOL = v;
                        break;
                    case "DEST_SCHOOL":
                        mapper[i] = (e, v) => e.DEST_SCHOOL = v;
                        break;
                    case "RECD_AT_DEST":
                        mapper[i] = (e, v) => e.RECD_AT_DEST = v;
                        break;
                    case "TFR_STATUS":
                        mapper[i] = (e, v) => e.TFR_STATUS = v;
                        break;
                    case "TFR_DATE":
                        mapper[i] = (e, v) => e.TFR_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TFR_COMMENT":
                        mapper[i] = (e, v) => e.TFR_COMMENT = v;
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
