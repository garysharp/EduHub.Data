using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Usage Data Set
    /// </summary>
    public sealed class STBTDataSet : SetBase<STBT>
    {

        internal STBTDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STBT"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STBT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STBT" /> fields for each CSV column header</returns>
        protected override Action<STBT, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<STBT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STBTKEY":
                        mapper[i] = (e, v) => e.STBTKEY = v;
                        break;
                    case "ROUTE":
                        mapper[i] = (e, v) => e.ROUTE = v;
                        break;
                    case "DAYS_USED01":
                        mapper[i] = (e, v) => e.DAYS_USED01 = v;
                        break;
                    case "DAYS_USED02":
                        mapper[i] = (e, v) => e.DAYS_USED02 = v;
                        break;
                    case "DAYS_USED03":
                        mapper[i] = (e, v) => e.DAYS_USED03 = v;
                        break;
                    case "DAYS_USED04":
                        mapper[i] = (e, v) => e.DAYS_USED04 = v;
                        break;
                    case "DAYS_USED05":
                        mapper[i] = (e, v) => e.DAYS_USED05 = v;
                        break;
                    case "TRANSPORT_NOTES":
                        mapper[i] = (e, v) => e.TRANSPORT_NOTES = v;
                        break;
                    case "DATE_STARTED":
                        mapper[i] = (e, v) => e.DATE_STARTED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TERMINATED":
                        mapper[i] = (e, v) => e.TERMINATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AM1_PICKUP":
                        mapper[i] = (e, v) => e.AM1_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM1_PU_SITE":
                        mapper[i] = (e, v) => e.AM1_PU_SITE = v;
                        break;
                    case "AM1_SETDOWN":
                        mapper[i] = (e, v) => e.AM1_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM1_SD_SITE":
                        mapper[i] = (e, v) => e.AM1_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM1_ROUTE":
                        mapper[i] = (e, v) => e.AM1_ROUTE = v;
                        break;
                    case "PM1_PICKUP":
                        mapper[i] = (e, v) => e.PM1_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM1_PU_SITE":
                        mapper[i] = (e, v) => e.PM1_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM1_SETDOWN":
                        mapper[i] = (e, v) => e.PM1_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM1_SD_SITE":
                        mapper[i] = (e, v) => e.PM1_SD_SITE = v;
                        break;
                    case "PM1_ROUTE":
                        mapper[i] = (e, v) => e.PM1_ROUTE = v;
                        break;
                    case "AM2_PICKUP":
                        mapper[i] = (e, v) => e.AM2_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM2_PU_SITE":
                        mapper[i] = (e, v) => e.AM2_PU_SITE = v;
                        break;
                    case "AM2_SETDOWN":
                        mapper[i] = (e, v) => e.AM2_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM2_SD_SITE":
                        mapper[i] = (e, v) => e.AM2_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM2_ROUTE":
                        mapper[i] = (e, v) => e.AM2_ROUTE = v;
                        break;
                    case "PM2_PICKUP":
                        mapper[i] = (e, v) => e.PM2_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM2_PU_SITE":
                        mapper[i] = (e, v) => e.PM2_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM2_SETDOWN":
                        mapper[i] = (e, v) => e.PM2_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM2_SD_SITE":
                        mapper[i] = (e, v) => e.PM2_SD_SITE = v;
                        break;
                    case "PM2_ROUTE":
                        mapper[i] = (e, v) => e.PM2_ROUTE = v;
                        break;
                    case "AM3_PICKUP":
                        mapper[i] = (e, v) => e.AM3_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM3_PU_SITE":
                        mapper[i] = (e, v) => e.AM3_PU_SITE = v;
                        break;
                    case "AM3_SETDOWN":
                        mapper[i] = (e, v) => e.AM3_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM3_SD_SITE":
                        mapper[i] = (e, v) => e.AM3_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM3_ROUTE":
                        mapper[i] = (e, v) => e.AM3_ROUTE = v;
                        break;
                    case "PM3_PICKUP":
                        mapper[i] = (e, v) => e.PM3_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM3_PU_SITE":
                        mapper[i] = (e, v) => e.PM3_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM3_SETDOWN":
                        mapper[i] = (e, v) => e.PM3_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM3_SD_SITE":
                        mapper[i] = (e, v) => e.PM3_SD_SITE = v;
                        break;
                    case "PM3_ROUTE":
                        mapper[i] = (e, v) => e.PM3_ROUTE = v;
                        break;
                    case "AM4_PICKUP":
                        mapper[i] = (e, v) => e.AM4_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM4_PU_SITE":
                        mapper[i] = (e, v) => e.AM4_PU_SITE = v;
                        break;
                    case "AM4_SETDOWN":
                        mapper[i] = (e, v) => e.AM4_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM4_SD_SITE":
                        mapper[i] = (e, v) => e.AM4_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM4_ROUTE":
                        mapper[i] = (e, v) => e.AM4_ROUTE = v;
                        break;
                    case "PM4_PICKUP":
                        mapper[i] = (e, v) => e.PM4_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM4_PU_SITE":
                        mapper[i] = (e, v) => e.PM4_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM4_SETDOWN":
                        mapper[i] = (e, v) => e.PM4_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM4_SD_SITE":
                        mapper[i] = (e, v) => e.PM4_SD_SITE = v;
                        break;
                    case "PM4_ROUTE":
                        mapper[i] = (e, v) => e.PM4_ROUTE = v;
                        break;
                    case "AM5_PICKUP":
                        mapper[i] = (e, v) => e.AM5_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM5_PU_SITE":
                        mapper[i] = (e, v) => e.AM5_PU_SITE = v;
                        break;
                    case "AM5_SETDOWN":
                        mapper[i] = (e, v) => e.AM5_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM5_SD_SITE":
                        mapper[i] = (e, v) => e.AM5_SD_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AM5_ROUTE":
                        mapper[i] = (e, v) => e.AM5_ROUTE = v;
                        break;
                    case "PM5_PICKUP":
                        mapper[i] = (e, v) => e.PM5_PICKUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM5_PU_SITE":
                        mapper[i] = (e, v) => e.PM5_PU_SITE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM5_SETDOWN":
                        mapper[i] = (e, v) => e.PM5_SETDOWN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM5_SD_SITE":
                        mapper[i] = (e, v) => e.PM5_SD_SITE = v;
                        break;
                    case "PM5_ROUTE":
                        mapper[i] = (e, v) => e.PM5_ROUTE = v;
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
