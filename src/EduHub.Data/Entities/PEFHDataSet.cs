using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Transaction History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEFHDataSet : SetBase<PEFH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEFH"; } }

        internal PEFHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEFH>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PAY_STEP = new Lazy<NullDictionary<short?, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.PAY_STEP));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, PEFH>>(() => this.ToDictionary(i => i.TID));
            Index_TRCENTRE = new Lazy<NullDictionary<string, IReadOnlyList<PEFH>>>(() => this.ToGroupedNullDictionary(i => i.TRCENTRE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEFH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEFH" /> fields for each CSV column header</returns>
        protected override Action<PEFH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEFH, string>[Headers.Count];

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
                    case "TRCENTRE":
                        mapper[i] = (e, v) => e.TRCENTRE = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPAYCODE":
                        mapper[i] = (e, v) => e.TRPAYCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRPAYPERD":
                        mapper[i] = (e, v) => e.TRPAYPERD = v == null ? (int?)null : int.Parse(v);
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
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRPITYPE":
                        mapper[i] = (e, v) => e.TRPITYPE = v;
                        break;
                    case "TRUNIT":
                        mapper[i] = (e, v) => e.TRUNIT = v;
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRNEXTPAYDATE":
                        mapper[i] = (e, v) => e.TRNEXTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRNEXTPAYPERD":
                        mapper[i] = (e, v) => e.TRNEXTPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPAYSPAN":
                        mapper[i] = (e, v) => e.TRPAYSPAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRTAXSPAN":
                        mapper[i] = (e, v) => e.TRTAXSPAN = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PNNEXTPAYDATE":
                        mapper[i] = (e, v) => e.PNNEXTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "WORKED_HOURS":
                        mapper[i] = (e, v) => e.WORKED_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PAY_STEP":
                        mapper[i] = (e, v) => e.PAY_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYSIGNTYPE":
                        mapper[i] = (e, v) => e.PAYSIGNTYPE = v;
                        break;
                    case "SYSTEM_TAX":
                        mapper[i] = (e, v) => e.SYSTEM_TAX = v;
                        break;
                    case "LINE_NO":
                        mapper[i] = (e, v) => e.LINE_NO = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v == null ? (int?)null : int.Parse(v);
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
                    case "SPLIT_PERCENT":
                        mapper[i] = (e, v) => e.SPLIT_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ALTER_TRQTY":
                        mapper[i] = (e, v) => e.ALTER_TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ANNUALISED_LOADING":
                        mapper[i] = (e, v) => e.ANNUALISED_LOADING = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="PEFH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEFH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEFH" /> items to added or update the base <see cref="PEFH" /> items</param>
        /// <returns>A merged list of <see cref="PEFH" /> items</returns>
        protected override List<PEFH> ApplyDeltaItems(List<PEFH> Items, List<PEFH> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEFH deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEFH>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEFH>>> Index_INITIATIVE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEFH>>> Index_PAY_STEP;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEFH>>> Index_PAYITEM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEFH>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, PEFH>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<PEFH>>> Index_TRCENTRE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEFH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEFH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEFH> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PEFH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEFH> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByPAY_STEP(short? PAY_STEP)
        {
            return Index_PAY_STEP.Value[PAY_STEP];
        }

        /// <summary>
        /// Attempt to find PEFH by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAY_STEP(short? PAY_STEP, out IReadOnlyList<PEFH> Value)
        {
            return Index_PAY_STEP.Value.TryGetValue(PAY_STEP, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by PAY_STEP field
        /// </summary>
        /// <param name="PAY_STEP">PAY_STEP value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByPAY_STEP(short? PAY_STEP)
        {
            IReadOnlyList<PEFH> value;
            if (Index_PAY_STEP.Value.TryGetValue(PAY_STEP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEFH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PEFH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PEFH> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PEFH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEFH> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEFH> value;
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
        /// Find PEFH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEFH</param>
        /// <returns>Related PEFH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEFH FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEFH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEFH</param>
        /// <param name="Value">Related PEFH entity</param>
        /// <returns>True if the related PEFH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEFH Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEFH</param>
        /// <returns>Related PEFH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEFH TryFindByTID(int TID)
        {
            PEFH value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEFH by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEFH</param>
        /// <returns>List of related PEFH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> FindByTRCENTRE(string TRCENTRE)
        {
            return Index_TRCENTRE.Value[TRCENTRE];
        }

        /// <summary>
        /// Attempt to find PEFH by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEFH</param>
        /// <param name="Value">List of related PEFH entities</param>
        /// <returns>True if the list of related PEFH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRCENTRE(string TRCENTRE, out IReadOnlyList<PEFH> Value)
        {
            return Index_TRCENTRE.Value.TryGetValue(TRCENTRE, out Value);
        }

        /// <summary>
        /// Attempt to find PEFH by TRCENTRE field
        /// </summary>
        /// <param name="TRCENTRE">TRCENTRE value used to find PEFH</param>
        /// <returns>List of related PEFH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEFH> TryFindByTRCENTRE(string TRCENTRE)
        {
            IReadOnlyList<PEFH> value;
            if (Index_TRCENTRE.Value.TryGetValue(TRCENTRE, out value))
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
