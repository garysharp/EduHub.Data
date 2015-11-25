using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// DR Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRFDataSet : SetBase<DRF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DRF"; } }

        internal DRFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<DRF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<DRF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<DRF>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<DRF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<DRF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<DRF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, DRF>>(() => this.ToDictionary(i => i.TID));
            Index_TRBATCH = new Lazy<NullDictionary<int?, IReadOnlyList<DRF>>>(() => this.ToGroupedNullDictionary(i => i.TRBATCH));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<DRF>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DRF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DRF" /> fields for each CSV column header</returns>
        protected override Action<DRF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DRF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ALLOCTID":
                        mapper[i] = (e, v) => e.ALLOCTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPERD":
                        mapper[i] = (e, v) => e.TRPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRXCODE":
                        mapper[i] = (e, v) => e.TRXCODE = v;
                        break;
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_BOX":
                        mapper[i] = (e, v) => e.GST_BOX = v;
                        break;
                    case "GST_PERD":
                        mapper[i] = (e, v) => e.GST_PERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "GST_SALE_PURCH":
                        mapper[i] = (e, v) => e.GST_SALE_PURCH = v;
                        break;
                    case "WITHHOLD_AMOUNT":
                        mapper[i] = (e, v) => e.WITHHOLD_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WITHHOLD_TYPE":
                        mapper[i] = (e, v) => e.WITHHOLD_TYPE = v;
                        break;
                    case "TRPAID":
                        mapper[i] = (e, v) => e.TRPAID = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRINV":
                        mapper[i] = (e, v) => e.TRINV = v;
                        break;
                    case "TRDELETE":
                        mapper[i] = (e, v) => e.TRDELETE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRRATE":
                        mapper[i] = (e, v) => e.TRRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COSTPRICE":
                        mapper[i] = (e, v) => e.COSTPRICE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMPAID":
                        mapper[i] = (e, v) => e.COMMPAID = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMDATE":
                        mapper[i] = (e, v) => e.COMMDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRBANK":
                        mapper[i] = (e, v) => e.TRBANK = v;
                        break;
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
                        break;
                    case "DRAWER":
                        mapper[i] = (e, v) => e.DRAWER = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "BRANCH":
                        mapper[i] = (e, v) => e.BRANCH = v;
                        break;
                    case "ACCOUNT_NUMBER":
                        mapper[i] = (e, v) => e.ACCOUNT_NUMBER = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MASTERTID":
                        mapper[i] = (e, v) => e.MASTERTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LINE_NO":
                        mapper[i] = (e, v) => e.LINE_NO = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
                        break;
                    case "FEE_DESCRIPTION":
                        mapper[i] = (e, v) => e.FEE_DESCRIPTION = v;
                        break;
                    case "STATEMENT_PRINT":
                        mapper[i] = (e, v) => e.STATEMENT_PRINT = v;
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
                    case "DEBIT":
                        mapper[i] = (e, v) => e.DEBIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CREDIT":
                        mapper[i] = (e, v) => e.CREDIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PRINT_CHEQUE":
                        mapper[i] = (e, v) => e.PRINT_CHEQUE = v;
                        break;
                    case "CANCELLED":
                        mapper[i] = (e, v) => e.CANCELLED = v;
                        break;
                    case "RECEIPT_PRINTED":
                        mapper[i] = (e, v) => e.RECEIPT_PRINTED = v;
                        break;
                    case "BPAY_SEQUENCE":
                        mapper[i] = (e, v) => e.BPAY_SEQUENCE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "TRMETHOD":
                        mapper[i] = (e, v) => e.TRMETHOD = v;
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
        /// Merges <see cref="DRF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DRF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DRF" /> items to added or update the base <see cref="DRF" /> items</param>
        /// <returns>A merged list of <see cref="DRF" /> items</returns>
        protected override List<DRF> ApplyDeltaItems(List<DRF> Items, List<DRF> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DRF deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<DRF>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<DRF>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<DRF>>> Index_FEE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<DRF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<DRF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<DRF>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, DRF>> Index_TID;
        private Lazy<NullDictionary<int?, IReadOnlyList<DRF>>> Index_TRBATCH;
        private Lazy<NullDictionary<string, IReadOnlyList<DRF>>> Index_TRREF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DRF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find DRF</param>
        /// <returns>List of related DRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find DRF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find DRF</param>
        /// <param name="Value">List of related DRF entities</param>
        /// <returns>True if the list of related DRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<DRF> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find DRF</param>
        /// <returns>List of related DRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> TryFindByBSB(string BSB)
        {
            IReadOnlyList<DRF> value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DRF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find DRF</param>
        /// <returns>List of related DRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find DRF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find DRF</param>
        /// <param name="Value">List of related DRF entities</param>
        /// <returns>True if the list of related DRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<DRF> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find DRF</param>
        /// <returns>List of related DRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> TryFindByCODE(string CODE)
        {
            IReadOnlyList<DRF> value;
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
        /// Find DRF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find DRF</param>
        /// <returns>List of related DRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> FindByFEE_CODE(string FEE_CODE)
        {
            return Index_FEE_CODE.Value[FEE_CODE];
        }

        /// <summary>
        /// Attempt to find DRF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find DRF</param>
        /// <param name="Value">List of related DRF entities</param>
        /// <returns>True if the list of related DRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE(string FEE_CODE, out IReadOnlyList<DRF> Value)
        {
            return Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find DRF</param>
        /// <returns>List of related DRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> TryFindByFEE_CODE(string FEE_CODE)
        {
            IReadOnlyList<DRF> value;
            if (Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DRF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DRF</param>
        /// <returns>List of related DRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find DRF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DRF</param>
        /// <param name="Value">List of related DRF entities</param>
        /// <returns>True if the list of related DRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<DRF> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DRF</param>
        /// <returns>List of related DRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<DRF> value;
            if (Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DRF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DRF</param>
        /// <returns>List of related DRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find DRF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DRF</param>
        /// <param name="Value">List of related DRF entities</param>
        /// <returns>True if the list of related DRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<DRF> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DRF</param>
        /// <returns>List of related DRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<DRF> value;
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
        /// Find DRF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DRF</param>
        /// <returns>List of related DRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find DRF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DRF</param>
        /// <param name="Value">List of related DRF entities</param>
        /// <returns>True if the list of related DRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<DRF> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DRF</param>
        /// <returns>List of related DRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<DRF> value;
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
        /// Find DRF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRF</param>
        /// <returns>Related DRF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DRF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DRF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRF</param>
        /// <param name="Value">Related DRF entity</param>
        /// <returns>True if the related DRF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DRF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DRF</param>
        /// <returns>Related DRF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DRF TryFindByTID(int TID)
        {
            DRF value;
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
        /// Find DRF by TRBATCH field
        /// </summary>
        /// <param name="TRBATCH">TRBATCH value used to find DRF</param>
        /// <returns>List of related DRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> FindByTRBATCH(int? TRBATCH)
        {
            return Index_TRBATCH.Value[TRBATCH];
        }

        /// <summary>
        /// Attempt to find DRF by TRBATCH field
        /// </summary>
        /// <param name="TRBATCH">TRBATCH value used to find DRF</param>
        /// <param name="Value">List of related DRF entities</param>
        /// <returns>True if the list of related DRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRBATCH(int? TRBATCH, out IReadOnlyList<DRF> Value)
        {
            return Index_TRBATCH.Value.TryGetValue(TRBATCH, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by TRBATCH field
        /// </summary>
        /// <param name="TRBATCH">TRBATCH value used to find DRF</param>
        /// <returns>List of related DRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> TryFindByTRBATCH(int? TRBATCH)
        {
            IReadOnlyList<DRF> value;
            if (Index_TRBATCH.Value.TryGetValue(TRBATCH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DRF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find DRF</param>
        /// <returns>List of related DRF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find DRF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find DRF</param>
        /// <param name="Value">List of related DRF entities</param>
        /// <returns>True if the list of related DRF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<DRF> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find DRF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find DRF</param>
        /// <returns>List of related DRF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DRF> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<DRF> value;
            if (Index_TRREF.Value.TryGetValue(TRREF, out value))
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
