using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// DR Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRFDataSet : EduHubDataSet<DRF>
    {
        /// <inheritdoc />
        public override string Name { get { return "DRF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

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
        internal override Action<DRF, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
        /// <param name="Entities">Iterator for base <see cref="DRF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="DRF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{DRF}"/> of entities</returns>
        internal override IEnumerable<DRF> ApplyDeltaEntities(IEnumerable<DRF> Entities, List<DRF> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
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

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a DRF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DRF](
        [TID] int NOT NULL,
        [ALLOCTID] int NULL,
        [CODE] varchar(10) NOT NULL,
        [TRBATCH] int NULL,
        [TRPERD] int NULL,
        [TRTYPE] varchar(1) NULL,
        [TRDATE] datetime NULL,
        [TRREF] varchar(10) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [TRXCODE] varchar(10) NULL,
        [TRCOST] money NULL,
        [TRQTY] float NULL,
        [TRAMT] money NULL,
        [TRNETT] money NULL,
        [GST_BOX] varchar(3) NULL,
        [GST_PERD] int NULL,
        [GST_AMOUNT] money NULL,
        [TRGROSS] money NULL,
        [GST_RATE] float NULL,
        [GST_TYPE] varchar(4) NULL,
        [GST_RECLAIM] varchar(1) NULL,
        [GST_SALE_PURCH] varchar(2) NULL,
        [WITHHOLD_AMOUNT] money NULL,
        [WITHHOLD_TYPE] varchar(4) NULL,
        [TRPAID] money NULL,
        [TRDET] varchar(30) NULL,
        [TRINV] varchar(10) NULL,
        [TRDELETE] smallint NULL,
        [TRRATE] float NULL,
        [COSTPRICE] money NULL,
        [COMMPAID] money NULL,
        [COMMDATE] datetime NULL,
        [TRBANK] varchar(10) NULL,
        [RTYPE] varchar(2) NULL,
        [DRAWER] varchar(30) NULL,
        [BSB] varchar(6) NULL,
        [BANK] varchar(20) NULL,
        [BRANCH] varchar(20) NULL,
        [ACCOUNT_NUMBER] int NULL,
        [MASTERTID] int NULL,
        [LINE_NO] int NULL,
        [FLAG] int NULL,
        [FEE_CODE] varchar(10) NULL,
        [FEE_DESCRIPTION] varchar(30) NULL,
        [STATEMENT_PRINT] varchar(1) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [DEBIT] money NULL,
        [CREDIT] money NULL,
        [PRINT_CHEQUE] varchar(1) NULL,
        [CANCELLED] varchar(3) NULL,
        [RECEIPT_PRINTED] varchar(1) NULL,
        [BPAY_SEQUENCE] int NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [REFERENCE_NO] varchar(21) NULL,
        [TRMETHOD] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DRF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [DRF_Index_BSB] ON [dbo].[DRF]
    (
            [BSB] ASC
    );
    CREATE CLUSTERED INDEX [DRF_Index_CODE] ON [dbo].[DRF]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [DRF_Index_FEE_CODE] ON [dbo].[DRF]
    (
            [FEE_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [DRF_Index_GST_TYPE] ON [dbo].[DRF]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [DRF_Index_INITIATIVE] ON [dbo].[DRF]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [DRF_Index_SUBPROGRAM] ON [dbo].[DRF]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [DRF_Index_TRBATCH] ON [dbo].[DRF]
    (
            [TRBATCH] ASC
    );
    CREATE NONCLUSTERED INDEX [DRF_Index_TRREF] ON [dbo].[DRF]
    (
            [TRREF] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_BSB')
    ALTER INDEX [Index_BSB] ON [dbo].[DRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_FEE_CODE')
    ALTER INDEX [Index_FEE_CODE] ON [dbo].[DRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_GST_TYPE')
    ALTER INDEX [Index_GST_TYPE] ON [dbo].[DRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[DRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[DRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[DRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_TRBATCH')
    ALTER INDEX [Index_TRBATCH] ON [dbo].[DRF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[DRF] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_BSB')
    ALTER INDEX [Index_BSB] ON [dbo].[DRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_FEE_CODE')
    ALTER INDEX [Index_FEE_CODE] ON [dbo].[DRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_GST_TYPE')
    ALTER INDEX [Index_GST_TYPE] ON [dbo].[DRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[DRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[DRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[DRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_TRBATCH')
    ALTER INDEX [Index_TRBATCH] ON [dbo].[DRF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DRF]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[DRF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="DRF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="DRF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<DRF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[DRF] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DRF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DRF data set</returns>
        public override EduHubDataSetDataReader<DRF> GetDataSetDataReader()
        {
            return new DRFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DRF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DRF data set</returns>
        public override EduHubDataSetDataReader<DRF> GetDataSetDataReader(List<DRF> Entities)
        {
            return new DRFDataReader(new EduHubDataSetLoadedReader<DRF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DRFDataReader : EduHubDataSetDataReader<DRF>
        {
            public DRFDataReader(IEduHubDataSetReader<DRF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 60; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ALLOCTID
                        return Current.ALLOCTID;
                    case 2: // CODE
                        return Current.CODE;
                    case 3: // TRBATCH
                        return Current.TRBATCH;
                    case 4: // TRPERD
                        return Current.TRPERD;
                    case 5: // TRTYPE
                        return Current.TRTYPE;
                    case 6: // TRDATE
                        return Current.TRDATE;
                    case 7: // TRREF
                        return Current.TRREF;
                    case 8: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 9: // TRXCODE
                        return Current.TRXCODE;
                    case 10: // TRCOST
                        return Current.TRCOST;
                    case 11: // TRQTY
                        return Current.TRQTY;
                    case 12: // TRAMT
                        return Current.TRAMT;
                    case 13: // TRNETT
                        return Current.TRNETT;
                    case 14: // GST_BOX
                        return Current.GST_BOX;
                    case 15: // GST_PERD
                        return Current.GST_PERD;
                    case 16: // GST_AMOUNT
                        return Current.GST_AMOUNT;
                    case 17: // TRGROSS
                        return Current.TRGROSS;
                    case 18: // GST_RATE
                        return Current.GST_RATE;
                    case 19: // GST_TYPE
                        return Current.GST_TYPE;
                    case 20: // GST_RECLAIM
                        return Current.GST_RECLAIM;
                    case 21: // GST_SALE_PURCH
                        return Current.GST_SALE_PURCH;
                    case 22: // WITHHOLD_AMOUNT
                        return Current.WITHHOLD_AMOUNT;
                    case 23: // WITHHOLD_TYPE
                        return Current.WITHHOLD_TYPE;
                    case 24: // TRPAID
                        return Current.TRPAID;
                    case 25: // TRDET
                        return Current.TRDET;
                    case 26: // TRINV
                        return Current.TRINV;
                    case 27: // TRDELETE
                        return Current.TRDELETE;
                    case 28: // TRRATE
                        return Current.TRRATE;
                    case 29: // COSTPRICE
                        return Current.COSTPRICE;
                    case 30: // COMMPAID
                        return Current.COMMPAID;
                    case 31: // COMMDATE
                        return Current.COMMDATE;
                    case 32: // TRBANK
                        return Current.TRBANK;
                    case 33: // RTYPE
                        return Current.RTYPE;
                    case 34: // DRAWER
                        return Current.DRAWER;
                    case 35: // BSB
                        return Current.BSB;
                    case 36: // BANK
                        return Current.BANK;
                    case 37: // BRANCH
                        return Current.BRANCH;
                    case 38: // ACCOUNT_NUMBER
                        return Current.ACCOUNT_NUMBER;
                    case 39: // MASTERTID
                        return Current.MASTERTID;
                    case 40: // LINE_NO
                        return Current.LINE_NO;
                    case 41: // FLAG
                        return Current.FLAG;
                    case 42: // FEE_CODE
                        return Current.FEE_CODE;
                    case 43: // FEE_DESCRIPTION
                        return Current.FEE_DESCRIPTION;
                    case 44: // STATEMENT_PRINT
                        return Current.STATEMENT_PRINT;
                    case 45: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 46: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 47: // INITIATIVE
                        return Current.INITIATIVE;
                    case 48: // DEBIT
                        return Current.DEBIT;
                    case 49: // CREDIT
                        return Current.CREDIT;
                    case 50: // PRINT_CHEQUE
                        return Current.PRINT_CHEQUE;
                    case 51: // CANCELLED
                        return Current.CANCELLED;
                    case 52: // RECEIPT_PRINTED
                        return Current.RECEIPT_PRINTED;
                    case 53: // BPAY_SEQUENCE
                        return Current.BPAY_SEQUENCE;
                    case 54: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE;
                    case 55: // REFERENCE_NO
                        return Current.REFERENCE_NO;
                    case 56: // TRMETHOD
                        return Current.TRMETHOD;
                    case 57: // LW_DATE
                        return Current.LW_DATE;
                    case 58: // LW_TIME
                        return Current.LW_TIME;
                    case 59: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ALLOCTID
                        return Current.ALLOCTID == null;
                    case 3: // TRBATCH
                        return Current.TRBATCH == null;
                    case 4: // TRPERD
                        return Current.TRPERD == null;
                    case 5: // TRTYPE
                        return Current.TRTYPE == null;
                    case 6: // TRDATE
                        return Current.TRDATE == null;
                    case 7: // TRREF
                        return Current.TRREF == null;
                    case 8: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 9: // TRXCODE
                        return Current.TRXCODE == null;
                    case 10: // TRCOST
                        return Current.TRCOST == null;
                    case 11: // TRQTY
                        return Current.TRQTY == null;
                    case 12: // TRAMT
                        return Current.TRAMT == null;
                    case 13: // TRNETT
                        return Current.TRNETT == null;
                    case 14: // GST_BOX
                        return Current.GST_BOX == null;
                    case 15: // GST_PERD
                        return Current.GST_PERD == null;
                    case 16: // GST_AMOUNT
                        return Current.GST_AMOUNT == null;
                    case 17: // TRGROSS
                        return Current.TRGROSS == null;
                    case 18: // GST_RATE
                        return Current.GST_RATE == null;
                    case 19: // GST_TYPE
                        return Current.GST_TYPE == null;
                    case 20: // GST_RECLAIM
                        return Current.GST_RECLAIM == null;
                    case 21: // GST_SALE_PURCH
                        return Current.GST_SALE_PURCH == null;
                    case 22: // WITHHOLD_AMOUNT
                        return Current.WITHHOLD_AMOUNT == null;
                    case 23: // WITHHOLD_TYPE
                        return Current.WITHHOLD_TYPE == null;
                    case 24: // TRPAID
                        return Current.TRPAID == null;
                    case 25: // TRDET
                        return Current.TRDET == null;
                    case 26: // TRINV
                        return Current.TRINV == null;
                    case 27: // TRDELETE
                        return Current.TRDELETE == null;
                    case 28: // TRRATE
                        return Current.TRRATE == null;
                    case 29: // COSTPRICE
                        return Current.COSTPRICE == null;
                    case 30: // COMMPAID
                        return Current.COMMPAID == null;
                    case 31: // COMMDATE
                        return Current.COMMDATE == null;
                    case 32: // TRBANK
                        return Current.TRBANK == null;
                    case 33: // RTYPE
                        return Current.RTYPE == null;
                    case 34: // DRAWER
                        return Current.DRAWER == null;
                    case 35: // BSB
                        return Current.BSB == null;
                    case 36: // BANK
                        return Current.BANK == null;
                    case 37: // BRANCH
                        return Current.BRANCH == null;
                    case 38: // ACCOUNT_NUMBER
                        return Current.ACCOUNT_NUMBER == null;
                    case 39: // MASTERTID
                        return Current.MASTERTID == null;
                    case 40: // LINE_NO
                        return Current.LINE_NO == null;
                    case 41: // FLAG
                        return Current.FLAG == null;
                    case 42: // FEE_CODE
                        return Current.FEE_CODE == null;
                    case 43: // FEE_DESCRIPTION
                        return Current.FEE_DESCRIPTION == null;
                    case 44: // STATEMENT_PRINT
                        return Current.STATEMENT_PRINT == null;
                    case 45: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 46: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 47: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 48: // DEBIT
                        return Current.DEBIT == null;
                    case 49: // CREDIT
                        return Current.CREDIT == null;
                    case 50: // PRINT_CHEQUE
                        return Current.PRINT_CHEQUE == null;
                    case 51: // CANCELLED
                        return Current.CANCELLED == null;
                    case 52: // RECEIPT_PRINTED
                        return Current.RECEIPT_PRINTED == null;
                    case 53: // BPAY_SEQUENCE
                        return Current.BPAY_SEQUENCE == null;
                    case 54: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE == null;
                    case 55: // REFERENCE_NO
                        return Current.REFERENCE_NO == null;
                    case 56: // TRMETHOD
                        return Current.TRMETHOD == null;
                    case 57: // LW_DATE
                        return Current.LW_DATE == null;
                    case 58: // LW_TIME
                        return Current.LW_TIME == null;
                    case 59: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // ALLOCTID
                        return "ALLOCTID";
                    case 2: // CODE
                        return "CODE";
                    case 3: // TRBATCH
                        return "TRBATCH";
                    case 4: // TRPERD
                        return "TRPERD";
                    case 5: // TRTYPE
                        return "TRTYPE";
                    case 6: // TRDATE
                        return "TRDATE";
                    case 7: // TRREF
                        return "TRREF";
                    case 8: // TRXLEDGER
                        return "TRXLEDGER";
                    case 9: // TRXCODE
                        return "TRXCODE";
                    case 10: // TRCOST
                        return "TRCOST";
                    case 11: // TRQTY
                        return "TRQTY";
                    case 12: // TRAMT
                        return "TRAMT";
                    case 13: // TRNETT
                        return "TRNETT";
                    case 14: // GST_BOX
                        return "GST_BOX";
                    case 15: // GST_PERD
                        return "GST_PERD";
                    case 16: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 17: // TRGROSS
                        return "TRGROSS";
                    case 18: // GST_RATE
                        return "GST_RATE";
                    case 19: // GST_TYPE
                        return "GST_TYPE";
                    case 20: // GST_RECLAIM
                        return "GST_RECLAIM";
                    case 21: // GST_SALE_PURCH
                        return "GST_SALE_PURCH";
                    case 22: // WITHHOLD_AMOUNT
                        return "WITHHOLD_AMOUNT";
                    case 23: // WITHHOLD_TYPE
                        return "WITHHOLD_TYPE";
                    case 24: // TRPAID
                        return "TRPAID";
                    case 25: // TRDET
                        return "TRDET";
                    case 26: // TRINV
                        return "TRINV";
                    case 27: // TRDELETE
                        return "TRDELETE";
                    case 28: // TRRATE
                        return "TRRATE";
                    case 29: // COSTPRICE
                        return "COSTPRICE";
                    case 30: // COMMPAID
                        return "COMMPAID";
                    case 31: // COMMDATE
                        return "COMMDATE";
                    case 32: // TRBANK
                        return "TRBANK";
                    case 33: // RTYPE
                        return "RTYPE";
                    case 34: // DRAWER
                        return "DRAWER";
                    case 35: // BSB
                        return "BSB";
                    case 36: // BANK
                        return "BANK";
                    case 37: // BRANCH
                        return "BRANCH";
                    case 38: // ACCOUNT_NUMBER
                        return "ACCOUNT_NUMBER";
                    case 39: // MASTERTID
                        return "MASTERTID";
                    case 40: // LINE_NO
                        return "LINE_NO";
                    case 41: // FLAG
                        return "FLAG";
                    case 42: // FEE_CODE
                        return "FEE_CODE";
                    case 43: // FEE_DESCRIPTION
                        return "FEE_DESCRIPTION";
                    case 44: // STATEMENT_PRINT
                        return "STATEMENT_PRINT";
                    case 45: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 46: // GLPROGRAM
                        return "GLPROGRAM";
                    case 47: // INITIATIVE
                        return "INITIATIVE";
                    case 48: // DEBIT
                        return "DEBIT";
                    case 49: // CREDIT
                        return "CREDIT";
                    case 50: // PRINT_CHEQUE
                        return "PRINT_CHEQUE";
                    case 51: // CANCELLED
                        return "CANCELLED";
                    case 52: // RECEIPT_PRINTED
                        return "RECEIPT_PRINTED";
                    case 53: // BPAY_SEQUENCE
                        return "BPAY_SEQUENCE";
                    case 54: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 55: // REFERENCE_NO
                        return "REFERENCE_NO";
                    case 56: // TRMETHOD
                        return "TRMETHOD";
                    case 57: // LW_DATE
                        return "LW_DATE";
                    case 58: // LW_TIME
                        return "LW_TIME";
                    case 59: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "ALLOCTID":
                        return 1;
                    case "CODE":
                        return 2;
                    case "TRBATCH":
                        return 3;
                    case "TRPERD":
                        return 4;
                    case "TRTYPE":
                        return 5;
                    case "TRDATE":
                        return 6;
                    case "TRREF":
                        return 7;
                    case "TRXLEDGER":
                        return 8;
                    case "TRXCODE":
                        return 9;
                    case "TRCOST":
                        return 10;
                    case "TRQTY":
                        return 11;
                    case "TRAMT":
                        return 12;
                    case "TRNETT":
                        return 13;
                    case "GST_BOX":
                        return 14;
                    case "GST_PERD":
                        return 15;
                    case "GST_AMOUNT":
                        return 16;
                    case "TRGROSS":
                        return 17;
                    case "GST_RATE":
                        return 18;
                    case "GST_TYPE":
                        return 19;
                    case "GST_RECLAIM":
                        return 20;
                    case "GST_SALE_PURCH":
                        return 21;
                    case "WITHHOLD_AMOUNT":
                        return 22;
                    case "WITHHOLD_TYPE":
                        return 23;
                    case "TRPAID":
                        return 24;
                    case "TRDET":
                        return 25;
                    case "TRINV":
                        return 26;
                    case "TRDELETE":
                        return 27;
                    case "TRRATE":
                        return 28;
                    case "COSTPRICE":
                        return 29;
                    case "COMMPAID":
                        return 30;
                    case "COMMDATE":
                        return 31;
                    case "TRBANK":
                        return 32;
                    case "RTYPE":
                        return 33;
                    case "DRAWER":
                        return 34;
                    case "BSB":
                        return 35;
                    case "BANK":
                        return 36;
                    case "BRANCH":
                        return 37;
                    case "ACCOUNT_NUMBER":
                        return 38;
                    case "MASTERTID":
                        return 39;
                    case "LINE_NO":
                        return 40;
                    case "FLAG":
                        return 41;
                    case "FEE_CODE":
                        return 42;
                    case "FEE_DESCRIPTION":
                        return 43;
                    case "STATEMENT_PRINT":
                        return 44;
                    case "SUBPROGRAM":
                        return 45;
                    case "GLPROGRAM":
                        return 46;
                    case "INITIATIVE":
                        return 47;
                    case "DEBIT":
                        return 48;
                    case "CREDIT":
                        return 49;
                    case "PRINT_CHEQUE":
                        return 50;
                    case "CANCELLED":
                        return 51;
                    case "RECEIPT_PRINTED":
                        return 52;
                    case "BPAY_SEQUENCE":
                        return 53;
                    case "BPAY_REFERENCE":
                        return 54;
                    case "REFERENCE_NO":
                        return 55;
                    case "TRMETHOD":
                        return 56;
                    case "LW_DATE":
                        return 57;
                    case "LW_TIME":
                        return 58;
                    case "LW_USER":
                        return 59;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
