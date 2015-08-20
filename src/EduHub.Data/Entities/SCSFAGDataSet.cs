using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Data Aggregates Data Set
    /// </summary>
    public sealed class SCSFAGDataSet : SetBase<SCSFAG>
    {

        internal SCSFAGDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCSFAG"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCSFAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCSFAG" /> fields for each CSV column header</returns>
        protected override Action<SCSFAG, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCSFAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "YEAR_SEMESTER":
                        mapper[i] = (e, v) => e.YEAR_SEMESTER = v;
                        break;
                    case "ST_CAMPUS":
                        mapper[i] = (e, v) => e.ST_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ST_YEAR_LEVEL":
                        mapper[i] = (e, v) => e.ST_YEAR_LEVEL = v;
                        break;
                    case "ST_CATEGORY":
                        mapper[i] = (e, v) => e.ST_CATEGORY = v;
                        break;
                    case "TOTAL_IN_GROUP":
                        mapper[i] = (e, v) => e.TOTAL_IN_GROUP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT01":
                        mapper[i] = (e, v) => e.NUMBER_AT01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT02":
                        mapper[i] = (e, v) => e.NUMBER_AT02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT03":
                        mapper[i] = (e, v) => e.NUMBER_AT03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT04":
                        mapper[i] = (e, v) => e.NUMBER_AT04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT05":
                        mapper[i] = (e, v) => e.NUMBER_AT05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT06":
                        mapper[i] = (e, v) => e.NUMBER_AT06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT07":
                        mapper[i] = (e, v) => e.NUMBER_AT07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT08":
                        mapper[i] = (e, v) => e.NUMBER_AT08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT09":
                        mapper[i] = (e, v) => e.NUMBER_AT09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT10":
                        mapper[i] = (e, v) => e.NUMBER_AT10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT11":
                        mapper[i] = (e, v) => e.NUMBER_AT11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT12":
                        mapper[i] = (e, v) => e.NUMBER_AT12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT13":
                        mapper[i] = (e, v) => e.NUMBER_AT13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT14":
                        mapper[i] = (e, v) => e.NUMBER_AT14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT15":
                        mapper[i] = (e, v) => e.NUMBER_AT15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT16":
                        mapper[i] = (e, v) => e.NUMBER_AT16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT17":
                        mapper[i] = (e, v) => e.NUMBER_AT17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT18":
                        mapper[i] = (e, v) => e.NUMBER_AT18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT19":
                        mapper[i] = (e, v) => e.NUMBER_AT19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT20":
                        mapper[i] = (e, v) => e.NUMBER_AT20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT21":
                        mapper[i] = (e, v) => e.NUMBER_AT21 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT22":
                        mapper[i] = (e, v) => e.NUMBER_AT22 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT23":
                        mapper[i] = (e, v) => e.NUMBER_AT23 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT24":
                        mapper[i] = (e, v) => e.NUMBER_AT24 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT25":
                        mapper[i] = (e, v) => e.NUMBER_AT25 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT26":
                        mapper[i] = (e, v) => e.NUMBER_AT26 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT27":
                        mapper[i] = (e, v) => e.NUMBER_AT27 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT28":
                        mapper[i] = (e, v) => e.NUMBER_AT28 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_MEAN":
                        mapper[i] = (e, v) => e.SCHOOL_MEAN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_MIN":
                        mapper[i] = (e, v) => e.SCHOOL_MIN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_MAX":
                        mapper[i] = (e, v) => e.SCHOOL_MAX = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_15TH":
                        mapper[i] = (e, v) => e.SCHOOL_15TH = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_25TH":
                        mapper[i] = (e, v) => e.SCHOOL_25TH = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SCHOOL_75TH":
                        mapper[i] = (e, v) => e.SCHOOL_75TH = v == null ? (double?)null : double.Parse(v);
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
