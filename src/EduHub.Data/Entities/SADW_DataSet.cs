using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Witnesses Data Set
    /// </summary>
    public sealed class SADW_DataSet : SetBase<SADW_Entity>
    {

        internal SADW_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SADW"; } }

        protected override Action<SADW_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SADW_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "WITNESS_TYPE":
                        mapper[i] = (e, v) => e.WITNESS_TYPE = v;
                        break;
                    case "WITNESSKEY":
                        mapper[i] = (e, v) => e.WITNESSKEY = v;
                        break;
                    case "WITNESS_DFAB":
                        mapper[i] = (e, v) => e.WITNESS_DFAB = v;
                        break;
                    case "FULL_NAME":
                        mapper[i] = (e, v) => e.FULL_NAME = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
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
