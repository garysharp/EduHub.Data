using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Groupings Data Set
    /// </summary>
    public sealed class SG_DataSet : SetBase<SG_Entity>
    {
        private Lazy<Dictionary<string, SG_Entity>> SGKEY_Index;

        internal SG_DataSet(EduHubContext Context)
            : base(Context)
        {
            SGKEY_Index = new Lazy<Dictionary<string, SG_Entity>>(() => this.ToDictionary(e => e.SGKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SG"; } }

        /// <summary>
        /// Find SG by SGKEY key field
        /// </summary>
        /// <param name="Key">SGKEY value used to find SG</param>
        /// <returns>Related SG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SGKEY value didn't match any SG entities</exception>
        public SG_Entity FindBySGKEY(string Key)
        {
            SG_Entity result;
            if (SGKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SG by SGKEY key field
        /// </summary>
        /// <param name="Key">SGKEY value used to find SG</param>
        /// <param name="Value">Related SG entity</param>
        /// <returns>True if the SG Entity is found</returns>
        public bool TryFindBySGKEY(string Key, out SG_Entity Value)
        {
            return SGKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SG by SGKEY key field
        /// </summary>
        /// <param name="Key">SGKEY value used to find SG</param>
        /// <returns>Related SG entity, or null if not found</returns>
        public SG_Entity TryFindBySGKEY(string Key)
        {
            SG_Entity result;
            if (SGKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SGKEY":
                        mapper[i] = (e, v) => e.SGKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "GROUP_TYPE":
                        mapper[i] = (e, v) => e.GROUP_TYPE = v;
                        break;
                    case "GROUP_CATEGORY":
                        mapper[i] = (e, v) => e.GROUP_CATEGORY = v;
                        break;
                    case "SOURCE_SG":
                        mapper[i] = (e, v) => e.SOURCE_SG = v;
                        break;
                    case "STRICT_CRITERIA":
                        mapper[i] = (e, v) => e.STRICT_CRITERIA = v;
                        break;
                    case "MAX_NUMBER_STUD":
                        mapper[i] = (e, v) => e.MAX_NUMBER_STUD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STRUCTURE":
                        mapper[i] = (e, v) => e.STRUCTURE = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CESSATION_DATE":
                        mapper[i] = (e, v) => e.CESSATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOUSE_HOMEGROUP":
                        mapper[i] = (e, v) => e.HOUSE_HOMEGROUP = v;
                        break;
                    case "SCOPE":
                        mapper[i] = (e, v) => e.SCOPE = v;
                        break;
                    case "FROM_CAMPUS":
                        mapper[i] = (e, v) => e.FROM_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TO_CAMPUS":
                        mapper[i] = (e, v) => e.TO_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CAND_FIRST_YR":
                        mapper[i] = (e, v) => e.CAND_FIRST_YR = v;
                        break;
                    case "CAND_LAST_YR":
                        mapper[i] = (e, v) => e.CAND_LAST_YR = v;
                        break;
                    case "FUT_FIRST_YR":
                        mapper[i] = (e, v) => e.FUT_FIRST_YR = v;
                        break;
                    case "FUT_LAST_YR":
                        mapper[i] = (e, v) => e.FUT_LAST_YR = v;
                        break;
                    case "CAND_FIRST_AGE":
                        mapper[i] = (e, v) => e.CAND_FIRST_AGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAND_LAST_AGE":
                        mapper[i] = (e, v) => e.CAND_LAST_AGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_DATE":
                        mapper[i] = (e, v) => e.AGE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FIRST_DOB":
                        mapper[i] = (e, v) => e.FIRST_DOB = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_DOB":
                        mapper[i] = (e, v) => e.LAST_DOB = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GENDERA":
                        mapper[i] = (e, v) => e.GENDERA = v;
                        break;
                    case "GENDERB":
                        mapper[i] = (e, v) => e.GENDERB = v;
                        break;
                    case "HOUSE":
                        mapper[i] = (e, v) => e.HOUSE = v;
                        break;
                    case "DAYONE":
                        mapper[i] = (e, v) => e.DAYONE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DO_FIRST_PERD":
                        mapper[i] = (e, v) => e.DO_FIRST_PERD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LASTDAY":
                        mapper[i] = (e, v) => e.LASTDAY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LAST_PERD":
                        mapper[i] = (e, v) => e.LD_LAST_PERD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAYONE_AM_PM":
                        mapper[i] = (e, v) => e.DAYONE_AM_PM = v;
                        break;
                    case "LASTDAY_AM_PM":
                        mapper[i] = (e, v) => e.LASTDAY_AM_PM = v;
                        break;
                    case "ABS_TYPE":
                        mapper[i] = (e, v) => e.ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREV_ABS_TYPE":
                        mapper[i] = (e, v) => e.PREV_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v;
                        break;
                    case "DESTINATION":
                        mapper[i] = (e, v) => e.DESTINATION = v;
                        break;
                    case "VENUE_ADDRESS":
                        mapper[i] = (e, v) => e.VENUE_ADDRESS = v;
                        break;
                    case "EXC_GLCODE":
                        mapper[i] = (e, v) => e.EXC_GLCODE = v;
                        break;
                    case "FEEDBACK":
                        mapper[i] = (e, v) => e.FEEDBACK = v;
                        break;
                    case "SPECIAL_NEEDS":
                        mapper[i] = (e, v) => e.SPECIAL_NEEDS = v;
                        break;
                    case "EXC_PURPOSE":
                        mapper[i] = (e, v) => e.EXC_PURPOSE = v;
                        break;
                    case "EXC_SERVICE_PROVIDER":
                        mapper[i] = (e, v) => e.EXC_SERVICE_PROVIDER = v;
                        break;
                    case "TRANSPORT_METHOD":
                        mapper[i] = (e, v) => e.TRANSPORT_METHOD = v;
                        break;
                    case "EXC_TRANSPORT_PROVIDER":
                        mapper[i] = (e, v) => e.EXC_TRANSPORT_PROVIDER = v;
                        break;
                    case "FIXED_TRANS_COST":
                        mapper[i] = (e, v) => e.FIXED_TRANS_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PER_ST_TRANS_COST":
                        mapper[i] = (e, v) => e.PER_ST_TRANS_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FIXED_VENUE_COST":
                        mapper[i] = (e, v) => e.FIXED_VENUE_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PER_ST_VENUE_COST":
                        mapper[i] = (e, v) => e.PER_ST_VENUE_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OTHER_COSTS":
                        mapper[i] = (e, v) => e.OTHER_COSTS = v;
                        break;
                    case "EXC_AMOUNT":
                        mapper[i] = (e, v) => e.EXC_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STAFF_MEMBERS":
                        mapper[i] = (e, v) => e.STAFF_MEMBERS = v;
                        break;
                    case "PARENT_MEMBERS":
                        mapper[i] = (e, v) => e.PARENT_MEMBERS = v;
                        break;
                    case "RESP_PERSON_TYPE":
                        mapper[i] = (e, v) => e.RESP_PERSON_TYPE = v;
                        break;
                    case "ADULT_RESPONSIBLE":
                        mapper[i] = (e, v) => e.ADULT_RESPONSIBLE = v;
                        break;
                    case "RESP_PARENT_GENDER":
                        mapper[i] = (e, v) => e.RESP_PARENT_GENDER = v;
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
