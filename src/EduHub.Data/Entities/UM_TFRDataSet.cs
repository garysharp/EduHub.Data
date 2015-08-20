using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// UM Transfer Data Set
    /// </summary>
    public sealed class UM_TFRDataSet : SetBase<UM_TFR>
    {

        internal UM_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "UM_TFR"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="UM_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="UM_TFR" /> fields for each CSV column header</returns>
        protected override Action<UM_TFR, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<UM_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "UM_TRANS_ID":
                        mapper[i] = (e, v) => e.UM_TRANS_ID = v;
                        break;
                    case "UMKEY":
                        mapper[i] = (e, v) => e.UMKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UMKEY_NEW":
                        mapper[i] = (e, v) => e.UMKEY_NEW = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "SILENT":
                        mapper[i] = (e, v) => e.SILENT = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DPID":
                        mapper[i] = (e, v) => e.DPID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BARCODE":
                        mapper[i] = (e, v) => e.BARCODE = v;
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
