using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sickbay Medication Administrations Data Set
    /// </summary>
    public sealed class SAIM_DataSet : SetBase<SAIM_Entity>
    {
        internal SAIM_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "SAIM"; } }


        
        protected override Action<SAIM_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SAIM_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INVOLVEMENTID":
                        mapper[i] = (e, v) => e.INVOLVEMENTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MEDICATION":
                        mapper[i] = (e, v) => e.MEDICATION = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ADMIN_BY_OTHER":
                        mapper[i] = (e, v) => e.ADMIN_BY_OTHER = v;
                        break;
                    case "ADMIN_TIME":
                        mapper[i] = (e, v) => e.ADMIN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DOSE":
                        mapper[i] = (e, v) => e.DOSE = v;
                        break;
                    case "ADMIN_NOTES":
                        mapper[i] = (e, v) => e.ADMIN_NOTES = v;
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
