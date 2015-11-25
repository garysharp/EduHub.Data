using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Super (SGL and Employee) History YTD Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPUHDataSet : SetBase<PEPUH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPUH"; } }

        internal PEPUHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPUH>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PEPUH>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_SUPER_FUND = new Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>>(() => this.ToGroupedNullDictionary(i => i.SUPER_FUND));
            Index_TID = new Lazy<Dictionary<int, PEPUH>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPUH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPUH" /> fields for each CSV column header</returns>
        protected override Action<PEPUH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPUH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PAYITEM":
                        mapper[i] = (e, v) => e.PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPERD":
                        mapper[i] = (e, v) => e.TRPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRPAYAMT":
                        mapper[i] = (e, v) => e.TRPAYAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRSUPER_PC":
                        mapper[i] = (e, v) => e.TRSUPER_PC = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRSUPER_AMT":
                        mapper[i] = (e, v) => e.TRSUPER_AMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
        /// Merges <see cref="PEPUH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEPUH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEPUH" /> items to added or update the base <see cref="PEPUH" /> items</param>
        /// <returns>A merged list of <see cref="PEPUH" /> items</returns>
        protected override List<PEPUH> ApplyDeltaItems(List<PEPUH> Items, List<PEPUH> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEPUH deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<PEPUH>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>> Index_INITIATIVE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEPUH>>> Index_PAYITEM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPUH>>> Index_SUPER_FUND;
        private Lazy<Dictionary<int, PEPUH>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPUH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPUH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPUH> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPUH> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPUH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PEPUH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEPUH> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEPUH> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPUH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PEPUH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PEPUH> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PEPUH> value;
            if (Index_PAYITEM.Value.TryGetValue(PAYITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPUH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PEPUH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEPUH> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEPUH> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPUH by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> FindBySUPER_FUND(string SUPER_FUND)
        {
            return Index_SUPER_FUND.Value[SUPER_FUND];
        }

        /// <summary>
        /// Attempt to find PEPUH by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPUH</param>
        /// <param name="Value">List of related PEPUH entities</param>
        /// <returns>True if the list of related PEPUH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPER_FUND(string SUPER_FUND, out IReadOnlyList<PEPUH> Value)
        {
            return Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPUH</param>
        /// <returns>List of related PEPUH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPUH> TryFindBySUPER_FUND(string SUPER_FUND)
        {
            IReadOnlyList<PEPUH> value;
            if (Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPUH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPUH</param>
        /// <returns>Related PEPUH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPUH FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPUH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPUH</param>
        /// <param name="Value">Related PEPUH entity</param>
        /// <returns>True if the related PEPUH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPUH Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPUH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPUH</param>
        /// <returns>Related PEPUH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPUH TryFindByTID(int TID)
        {
            PEPUH value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
