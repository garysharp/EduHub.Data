using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability for Calendar Extras Data Set
    /// </summary>
    public sealed class SFAV_DataSet : SetBase<SFAV_Entity>
    {
        internal SFAV_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "SFAV"; } }


        
        protected override Action<SFAV_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SFAV_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_TIME":
                        mapper[i] = (e, v) => e.END_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AVAILABLE_DATE":
                        mapper[i] = (e, v) => e.AVAILABLE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
