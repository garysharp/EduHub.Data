using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Return Summary Data Data Set
    /// </summary>
    public sealed class SCEN_RTNDataSet : SetBase<SCEN_RTN>
    {
        private Lazy<Dictionary<int, SCEN_RTN>> IDIndex;

        internal SCEN_RTNDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_RTN>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_RTN"; } }

        /// <summary>
        /// Find SCEN_RTN by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RTN</param>
        /// <returns>Related SCEN_RTN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_RTN entities</exception>
        public SCEN_RTN FindByID(int Key)
        {
            SCEN_RTN result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCEN_RTN by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RTN</param>
        /// <param name="Value">Related SCEN_RTN entity</param>
        /// <returns>True if the SCEN_RTN entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_RTN Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RTN by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RTN</param>
        /// <returns>Related SCEN_RTN entity, or null if not found</returns>
        public SCEN_RTN TryFindByID(int Key)
        {
            SCEN_RTN result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_RTN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_RTN" /> fields for each CSV column header</returns>
        protected override Action<SCEN_RTN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_RTN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "RN_SCHOOLNUMBER":
                        mapper[i] = (e, v) => e.RN_SCHOOLNUMBER = v;
                        break;
                    case "RN_SCHOOLNAME":
                        mapper[i] = (e, v) => e.RN_SCHOOLNAME = v;
                        break;
                    case "RN_SCHOOLTYPE":
                        mapper[i] = (e, v) => e.RN_SCHOOLTYPE = v;
                        break;
                    case "RN_MONTH":
                        mapper[i] = (e, v) => e.RN_MONTH = v;
                        break;
                    case "RN_YEAR":
                        mapper[i] = (e, v) => e.RN_YEAR = v;
                        break;
                    case "RN_STATUS":
                        mapper[i] = (e, v) => e.RN_STATUS = v;
                        break;
                    case "RN_CREATED":
                        mapper[i] = (e, v) => e.RN_CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RN_CREATEUSER":
                        mapper[i] = (e, v) => e.RN_CREATEUSER = v;
                        break;
                    case "RN_LUPDATED":
                        mapper[i] = (e, v) => e.RN_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RN_LUPDATEUSER":
                        mapper[i] = (e, v) => e.RN_LUPDATEUSER = v;
                        break;
                    case "SD_LREFRESHED":
                        mapper[i] = (e, v) => e.SD_LREFRESHED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SD_LVALIDATED":
                        mapper[i] = (e, v) => e.SD_LVALIDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SD_SRPFUNDEDFTE":
                        mapper[i] = (e, v) => e.SD_SRPFUNDEDFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_NOTSRPFUNDEDFTE":
                        mapper[i] = (e, v) => e.SD_NOTSRPFUNDEDFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_TOTALFTE":
                        mapper[i] = (e, v) => e.SD_TOTALFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_INCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_INCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_SYSTEMEXCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_SYSTEMEXCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_MANUALLYEXCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_MANUALLYEXCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_TOTALHC":
                        mapper[i] = (e, v) => e.SD_TOTALHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_ERRORCOUNT":
                        mapper[i] = (e, v) => e.SD_ERRORCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_UNPROCESSEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.SD_UNPROCESSEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_ACKNOWLEDGEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.SD_ACKNOWLEDGEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_LHMGREFRESHED":
                        mapper[i] = (e, v) => e.CSD_LHMGREFRESHED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_LUPDATED":
                        mapper[i] = (e, v) => e.CSD_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_LUPDATEUSER":
                        mapper[i] = (e, v) => e.CSD_LUPDATEUSER = v;
                        break;
                    case "CSD_LVALIDATED":
                        mapper[i] = (e, v) => e.CSD_LVALIDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_CLASSCOUNT":
                        mapper[i] = (e, v) => e.CSD_CLASSCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_STUDENTHC":
                        mapper[i] = (e, v) => e.CSD_STUDENTHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_TEACHERFTE":
                        mapper[i] = (e, v) => e.CSD_TEACHERFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CSD_ERRORCOUNT":
                        mapper[i] = (e, v) => e.CSD_ERRORCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_UNPROCESSEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.CSD_UNPROCESSEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_ACKNOWLEDGEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.CSD_ACKNOWLEDGEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LD_CONTACTNAME":
                        mapper[i] = (e, v) => e.LD_CONTACTNAME = v;
                        break;
                    case "LD_CONTACTPHONE":
                        mapper[i] = (e, v) => e.LD_CONTACTPHONE = v;
                        break;
                    case "LD_PRINCIPALNAME":
                        mapper[i] = (e, v) => e.LD_PRINCIPALNAME = v;
                        break;
                    case "LD_PRINCIPALPHONE":
                        mapper[i] = (e, v) => e.LD_PRINCIPALPHONE = v;
                        break;
                    case "LD_COMMENTS":
                        mapper[i] = (e, v) => e.LD_COMMENTS = v;
                        break;
                    case "LD_USERCERTIFICATION":
                        mapper[i] = (e, v) => e.LD_USERCERTIFICATION = v;
                        break;
                    case "LD_FINALREPORTLOCATION":
                        mapper[i] = (e, v) => e.LD_FINALREPORTLOCATION = v;
                        break;
                    case "LD_STATUS":
                        mapper[i] = (e, v) => e.LD_STATUS = v;
                        break;
                    case "LD_CREATED":
                        mapper[i] = (e, v) => e.LD_CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LODGED":
                        mapper[i] = (e, v) => e.LD_LODGED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LUPDATEUSER":
                        mapper[i] = (e, v) => e.LD_LUPDATEUSER = v;
                        break;
                    case "LD_LUPDATED":
                        mapper[i] = (e, v) => e.LD_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
