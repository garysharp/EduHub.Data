using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Pay Steps or Pay Class Data Set
    /// </summary>
    public sealed class PSFDataSet : SetBase<PSF>
    {

        internal PSFDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PSF"; } }

        protected override Action<PSF, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EFFECTIVE_FROM_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EFFECTIVE_TO_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
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
