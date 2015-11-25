using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Groupings Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGDataSet : SetBase<SG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SG"; } }

        internal SGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ABS_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.ABS_TYPE));
            Index_CAND_FIRST_YR = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.CAND_FIRST_YR));
            Index_CAND_LAST_YR = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.CAND_LAST_YR));
            Index_FROM_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.FROM_CAMPUS));
            Index_FUT_FIRST_YR = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.FUT_FIRST_YR));
            Index_FUT_LAST_YR = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.FUT_LAST_YR));
            Index_HOUSE = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.HOUSE));
            Index_SGKEY = new Lazy<Dictionary<string, SG>>(() => this.ToDictionary(i => i.SGKEY));
            Index_TO_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.TO_CAMPUS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SG" /> fields for each CSV column header</returns>
        protected override Action<SG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SG, string>[Headers.Count];

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

        /// <summary>
        /// Merges <see cref="SG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SG" /> items to added or update the base <see cref="SG" /> items</param>
        /// <returns>A merged list of <see cref="SG" /> items</returns>
        protected override List<SG> ApplyDeltaItems(List<SG> Items, List<SG> DeltaItems)
        {
            Dictionary<string, int> Index_SGKEY = Items.ToIndexDictionary(i => i.SGKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SGKEY.TryGetValue(deltaItem.SGKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<short?, IReadOnlyList<SG>>> Index_ABS_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_CAND_FIRST_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_CAND_LAST_YR;
        private Lazy<NullDictionary<int?, IReadOnlyList<SG>>> Index_FROM_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_FUT_FIRST_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_FUT_LAST_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_HOUSE;
        private Lazy<Dictionary<string, SG>> Index_SGKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<SG>>> Index_TO_CAMPUS;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SG by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByABS_TYPE(short? ABS_TYPE)
        {
            return Index_ABS_TYPE.Value[ABS_TYPE];
        }

        /// <summary>
        /// Attempt to find SG by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByABS_TYPE(short? ABS_TYPE, out IReadOnlyList<SG> Value)
        {
            return Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SG by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByABS_TYPE(short? ABS_TYPE)
        {
            IReadOnlyList<SG> value;
            if (Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by CAND_FIRST_YR field
        /// </summary>
        /// <param name="CAND_FIRST_YR">CAND_FIRST_YR value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByCAND_FIRST_YR(string CAND_FIRST_YR)
        {
            return Index_CAND_FIRST_YR.Value[CAND_FIRST_YR];
        }

        /// <summary>
        /// Attempt to find SG by CAND_FIRST_YR field
        /// </summary>
        /// <param name="CAND_FIRST_YR">CAND_FIRST_YR value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAND_FIRST_YR(string CAND_FIRST_YR, out IReadOnlyList<SG> Value)
        {
            return Index_CAND_FIRST_YR.Value.TryGetValue(CAND_FIRST_YR, out Value);
        }

        /// <summary>
        /// Attempt to find SG by CAND_FIRST_YR field
        /// </summary>
        /// <param name="CAND_FIRST_YR">CAND_FIRST_YR value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByCAND_FIRST_YR(string CAND_FIRST_YR)
        {
            IReadOnlyList<SG> value;
            if (Index_CAND_FIRST_YR.Value.TryGetValue(CAND_FIRST_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by CAND_LAST_YR field
        /// </summary>
        /// <param name="CAND_LAST_YR">CAND_LAST_YR value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByCAND_LAST_YR(string CAND_LAST_YR)
        {
            return Index_CAND_LAST_YR.Value[CAND_LAST_YR];
        }

        /// <summary>
        /// Attempt to find SG by CAND_LAST_YR field
        /// </summary>
        /// <param name="CAND_LAST_YR">CAND_LAST_YR value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAND_LAST_YR(string CAND_LAST_YR, out IReadOnlyList<SG> Value)
        {
            return Index_CAND_LAST_YR.Value.TryGetValue(CAND_LAST_YR, out Value);
        }

        /// <summary>
        /// Attempt to find SG by CAND_LAST_YR field
        /// </summary>
        /// <param name="CAND_LAST_YR">CAND_LAST_YR value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByCAND_LAST_YR(string CAND_LAST_YR)
        {
            IReadOnlyList<SG> value;
            if (Index_CAND_LAST_YR.Value.TryGetValue(CAND_LAST_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by FROM_CAMPUS field
        /// </summary>
        /// <param name="FROM_CAMPUS">FROM_CAMPUS value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByFROM_CAMPUS(int? FROM_CAMPUS)
        {
            return Index_FROM_CAMPUS.Value[FROM_CAMPUS];
        }

        /// <summary>
        /// Attempt to find SG by FROM_CAMPUS field
        /// </summary>
        /// <param name="FROM_CAMPUS">FROM_CAMPUS value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFROM_CAMPUS(int? FROM_CAMPUS, out IReadOnlyList<SG> Value)
        {
            return Index_FROM_CAMPUS.Value.TryGetValue(FROM_CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SG by FROM_CAMPUS field
        /// </summary>
        /// <param name="FROM_CAMPUS">FROM_CAMPUS value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByFROM_CAMPUS(int? FROM_CAMPUS)
        {
            IReadOnlyList<SG> value;
            if (Index_FROM_CAMPUS.Value.TryGetValue(FROM_CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by FUT_FIRST_YR field
        /// </summary>
        /// <param name="FUT_FIRST_YR">FUT_FIRST_YR value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByFUT_FIRST_YR(string FUT_FIRST_YR)
        {
            return Index_FUT_FIRST_YR.Value[FUT_FIRST_YR];
        }

        /// <summary>
        /// Attempt to find SG by FUT_FIRST_YR field
        /// </summary>
        /// <param name="FUT_FIRST_YR">FUT_FIRST_YR value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFUT_FIRST_YR(string FUT_FIRST_YR, out IReadOnlyList<SG> Value)
        {
            return Index_FUT_FIRST_YR.Value.TryGetValue(FUT_FIRST_YR, out Value);
        }

        /// <summary>
        /// Attempt to find SG by FUT_FIRST_YR field
        /// </summary>
        /// <param name="FUT_FIRST_YR">FUT_FIRST_YR value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByFUT_FIRST_YR(string FUT_FIRST_YR)
        {
            IReadOnlyList<SG> value;
            if (Index_FUT_FIRST_YR.Value.TryGetValue(FUT_FIRST_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by FUT_LAST_YR field
        /// </summary>
        /// <param name="FUT_LAST_YR">FUT_LAST_YR value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByFUT_LAST_YR(string FUT_LAST_YR)
        {
            return Index_FUT_LAST_YR.Value[FUT_LAST_YR];
        }

        /// <summary>
        /// Attempt to find SG by FUT_LAST_YR field
        /// </summary>
        /// <param name="FUT_LAST_YR">FUT_LAST_YR value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFUT_LAST_YR(string FUT_LAST_YR, out IReadOnlyList<SG> Value)
        {
            return Index_FUT_LAST_YR.Value.TryGetValue(FUT_LAST_YR, out Value);
        }

        /// <summary>
        /// Attempt to find SG by FUT_LAST_YR field
        /// </summary>
        /// <param name="FUT_LAST_YR">FUT_LAST_YR value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByFUT_LAST_YR(string FUT_LAST_YR)
        {
            IReadOnlyList<SG> value;
            if (Index_FUT_LAST_YR.Value.TryGetValue(FUT_LAST_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByHOUSE(string HOUSE)
        {
            return Index_HOUSE.Value[HOUSE];
        }

        /// <summary>
        /// Attempt to find SG by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOUSE(string HOUSE, out IReadOnlyList<SG> Value)
        {
            return Index_HOUSE.Value.TryGetValue(HOUSE, out Value);
        }

        /// <summary>
        /// Attempt to find SG by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByHOUSE(string HOUSE)
        {
            IReadOnlyList<SG> value;
            if (Index_HOUSE.Value.TryGetValue(HOUSE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by SGKEY field
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SG</param>
        /// <returns>Related SG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SG FindBySGKEY(string SGKEY)
        {
            return Index_SGKEY.Value[SGKEY];
        }

        /// <summary>
        /// Attempt to find SG by SGKEY field
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SG</param>
        /// <param name="Value">Related SG entity</param>
        /// <returns>True if the related SG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGKEY(string SGKEY, out SG Value)
        {
            return Index_SGKEY.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SG by SGKEY field
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SG</param>
        /// <returns>Related SG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SG TryFindBySGKEY(string SGKEY)
        {
            SG value;
            if (Index_SGKEY.Value.TryGetValue(SGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by TO_CAMPUS field
        /// </summary>
        /// <param name="TO_CAMPUS">TO_CAMPUS value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByTO_CAMPUS(int? TO_CAMPUS)
        {
            return Index_TO_CAMPUS.Value[TO_CAMPUS];
        }

        /// <summary>
        /// Attempt to find SG by TO_CAMPUS field
        /// </summary>
        /// <param name="TO_CAMPUS">TO_CAMPUS value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTO_CAMPUS(int? TO_CAMPUS, out IReadOnlyList<SG> Value)
        {
            return Index_TO_CAMPUS.Value.TryGetValue(TO_CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SG by TO_CAMPUS field
        /// </summary>
        /// <param name="TO_CAMPUS">TO_CAMPUS value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByTO_CAMPUS(int? TO_CAMPUS)
        {
            IReadOnlyList<SG> value;
            if (Index_TO_CAMPUS.Value.TryGetValue(TO_CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
