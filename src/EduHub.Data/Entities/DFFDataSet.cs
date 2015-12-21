using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Financial Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFFDataSet : EduHubDataSet<DFF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DFF"; } }

        internal DFFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_SUBJECT = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, DFF>>(() => this.ToDictionary(i => i.TID));
            Index_TRSTUD = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.TRSTUD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFF" /> fields for each CSV column header</returns>
        protected override Action<DFF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRSTUD":
                        mapper[i] = (e, v) => e.TRSTUD = v;
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
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
                    case "TRPAID":
                        mapper[i] = (e, v) => e.TRPAID = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRINV":
                        mapper[i] = (e, v) => e.TRINV = v;
                        break;
                    case "TRDELETE":
                        mapper[i] = (e, v) => e.TRDELETE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRDEL_MONTHS":
                        mapper[i] = (e, v) => e.TRDEL_MONTHS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERCENTAGE":
                        mapper[i] = (e, v) => e.PERCENTAGE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRBANK":
                        mapper[i] = (e, v) => e.TRBANK = v;
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ORIG_DATE":
                        mapper[i] = (e, v) => e.ORIG_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ORIG_GROSS":
                        mapper[i] = (e, v) => e.ORIG_GROSS = v == null ? (decimal?)null : decimal.Parse(v);
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
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
                        break;
                    case "SPLIT_ITEM":
                        mapper[i] = (e, v) => e.SPLIT_ITEM = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
                        break;
                    case "TRMETHOD":
                        mapper[i] = (e, v) => e.TRMETHOD = v;
                        break;
                    case "MASTERTID":
                        mapper[i] = (e, v) => e.MASTERTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ALLOCTID":
                        mapper[i] = (e, v) => e.ALLOCTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
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
                    case "VOLUNTARY":
                        mapper[i] = (e, v) => e.VOLUNTARY = v;
                        break;
                    case "EMA_RECEIPT":
                        mapper[i] = (e, v) => e.EMA_RECEIPT = v;
                        break;
                    case "EMA_PERIOD":
                        mapper[i] = (e, v) => e.EMA_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EMA_TID":
                        mapper[i] = (e, v) => e.EMA_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "GL_PROCESSED":
                        mapper[i] = (e, v) => e.GL_PROCESSED = v;
                        break;
                    case "PRINT_CHEQUE":
                        mapper[i] = (e, v) => e.PRINT_CHEQUE = v;
                        break;
                    case "RECEIPT_PRINTED":
                        mapper[i] = (e, v) => e.RECEIPT_PRINTED = v;
                        break;
                    case "DEBIT":
                        mapper[i] = (e, v) => e.DEBIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CREDIT":
                        mapper[i] = (e, v) => e.CREDIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CANCELLED":
                        mapper[i] = (e, v) => e.CANCELLED = v;
                        break;
                    case "STATEMENT_PRINT":
                        mapper[i] = (e, v) => e.STATEMENT_PRINT = v;
                        break;
                    case "ST_SURNAME":
                        mapper[i] = (e, v) => e.ST_SURNAME = v;
                        break;
                    case "ST_FIRSTNAME":
                        mapper[i] = (e, v) => e.ST_FIRSTNAME = v;
                        break;
                    case "FEE_DESCRIPTION":
                        mapper[i] = (e, v) => e.FEE_DESCRIPTION = v;
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
        /// Merges <see cref="DFF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="DFF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="DFF" /> items to added or update the base <see cref="DFF" /> items</param>
        /// <returns>A merged list of <see cref="DFF" /> items</returns>
        protected override List<DFF> ApplyDeltaItems(List<DFF> Items, List<DFF> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (DFF deltaItem in DeltaItems)
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

        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_FEE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_STUDENT;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, DFF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_TRSTUD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find DFF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<DFF> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindByBSB(string BSB)
        {
            IReadOnlyList<DFF> value;
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
        /// Find DFF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find DFF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<DFF> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindByCODE(string CODE)
        {
            IReadOnlyList<DFF> value;
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
        /// Find DFF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindByFEE_CODE(string FEE_CODE)
        {
            return Index_FEE_CODE.Value[FEE_CODE];
        }

        /// <summary>
        /// Attempt to find DFF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE(string FEE_CODE, out IReadOnlyList<DFF> Value)
        {
            return Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindByFEE_CODE(string FEE_CODE)
        {
            IReadOnlyList<DFF> value;
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
        /// Find DFF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find DFF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<DFF> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<DFF> value;
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
        /// Find DFF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find DFF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<DFF> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<DFF> value;
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
        /// Find DFF by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find DFF by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<DFF> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<DFF> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFF by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find DFF by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<DFF> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<DFF> value;
            if (Index_SUBJECT.Value.TryGetValue(SUBJECT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find DFF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<DFF> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<DFF> value;
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
        /// Find DFF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFF</param>
        /// <returns>Related DFF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFF</param>
        /// <param name="Value">Related DFF entity</param>
        /// <returns>True if the related DFF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFF</param>
        /// <returns>Related DFF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFF TryFindByTID(int TID)
        {
            DFF value;
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
        /// Find DFF by TRSTUD field
        /// </summary>
        /// <param name="TRSTUD">TRSTUD value used to find DFF</param>
        /// <returns>List of related DFF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> FindByTRSTUD(string TRSTUD)
        {
            return Index_TRSTUD.Value[TRSTUD];
        }

        /// <summary>
        /// Attempt to find DFF by TRSTUD field
        /// </summary>
        /// <param name="TRSTUD">TRSTUD value used to find DFF</param>
        /// <param name="Value">List of related DFF entities</param>
        /// <returns>True if the list of related DFF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRSTUD(string TRSTUD, out IReadOnlyList<DFF> Value)
        {
            return Index_TRSTUD.Value.TryGetValue(TRSTUD, out Value);
        }

        /// <summary>
        /// Attempt to find DFF by TRSTUD field
        /// </summary>
        /// <param name="TRSTUD">TRSTUD value used to find DFF</param>
        /// <returns>List of related DFF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFF> TryFindByTRSTUD(string TRSTUD)
        {
            IReadOnlyList<DFF> value;
            if (Index_TRSTUD.Value.TryGetValue(TRSTUD, out value))
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
        /// Returns SQL which checks for the existence of a DFF table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DFF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DFF](
        [TID] int NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRSTUD] varchar(10) NULL,
        [STUDENT] varchar(10) NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [REFERENCE_NO] varchar(21) NULL,
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
        [TRPAID] money NULL,
        [TRINV] varchar(10) NULL,
        [TRDELETE] smallint NULL,
        [TRDET] varchar(30) NULL,
        [TRDEL_MONTHS] smallint NULL,
        [PERCENTAGE] float NULL,
        [TRBANK] varchar(10) NULL,
        [TRNETT] money NULL,
        [TRGROSS] money NULL,
        [GST_AMOUNT] money NULL,
        [GST_TYPE] varchar(4) NULL,
        [GST_RATE] float NULL,
        [ORIG_DATE] datetime NULL,
        [ORIG_GROSS] money NULL,
        [DRAWER] varchar(30) NULL,
        [BSB] varchar(6) NULL,
        [BANK] varchar(20) NULL,
        [BRANCH] varchar(20) NULL,
        [ACCOUNT_NUMBER] int NULL,
        [RTYPE] varchar(2) NULL,
        [SPLIT_ITEM] varchar(10) NULL,
        [FEE_CODE] varchar(10) NULL,
        [TRMETHOD] varchar(1) NULL,
        [MASTERTID] int NULL,
        [ALLOCTID] int NULL,
        [SUBJECT] varchar(5) NULL,
        [LINE_NO] int NULL,
        [FLAG] int NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [VOLUNTARY] varchar(1) NULL,
        [EMA_RECEIPT] varchar(1) NULL,
        [EMA_PERIOD] smallint NULL,
        [EMA_TID] int NULL,
        [GL_PROCESSED] varchar(1) NULL,
        [PRINT_CHEQUE] varchar(1) NULL,
        [RECEIPT_PRINTED] varchar(1) NULL,
        [DEBIT] money NULL,
        [CREDIT] money NULL,
        [CANCELLED] varchar(3) NULL,
        [STATEMENT_PRINT] varchar(1) NULL,
        [ST_SURNAME] varchar(30) NULL,
        [ST_FIRSTNAME] varchar(20) NULL,
        [FEE_DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DFF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [DFF_Index_BSB] ON [dbo].[DFF]
    (
            [BSB] ASC
    );
    CREATE CLUSTERED INDEX [DFF_Index_CODE] ON [dbo].[DFF]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [DFF_Index_FEE_CODE] ON [dbo].[DFF]
    (
            [FEE_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [DFF_Index_GST_TYPE] ON [dbo].[DFF]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [DFF_Index_INITIATIVE] ON [dbo].[DFF]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [DFF_Index_STUDENT] ON [dbo].[DFF]
    (
            [STUDENT] ASC
    );
    CREATE NONCLUSTERED INDEX [DFF_Index_SUBJECT] ON [dbo].[DFF]
    (
            [SUBJECT] ASC
    );
    CREATE NONCLUSTERED INDEX [DFF_Index_SUBPROGRAM] ON [dbo].[DFF]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [DFF_Index_TRSTUD] ON [dbo].[DFF]
    (
            [TRSTUD] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DFF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DFF data set</returns>
        public override IDataReader GetDataReader()
        {
            return new DFFDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DFFDataReader : IDataReader, IDataRecord
        {
            private List<DFF> Items;
            private int CurrentIndex;
            private DFF CurrentItem;

            public DFFDataReader(List<DFF> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 64; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return CurrentItem.TID;
                    case 1: // CODE
                        return CurrentItem.CODE;
                    case 2: // TRSTUD
                        return CurrentItem.TRSTUD;
                    case 3: // STUDENT
                        return CurrentItem.STUDENT;
                    case 4: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE;
                    case 5: // REFERENCE_NO
                        return CurrentItem.REFERENCE_NO;
                    case 6: // TRBATCH
                        return CurrentItem.TRBATCH;
                    case 7: // TRPERD
                        return CurrentItem.TRPERD;
                    case 8: // TRTYPE
                        return CurrentItem.TRTYPE;
                    case 9: // TRDATE
                        return CurrentItem.TRDATE;
                    case 10: // TRREF
                        return CurrentItem.TRREF;
                    case 11: // TRXLEDGER
                        return CurrentItem.TRXLEDGER;
                    case 12: // TRXCODE
                        return CurrentItem.TRXCODE;
                    case 13: // TRCOST
                        return CurrentItem.TRCOST;
                    case 14: // TRQTY
                        return CurrentItem.TRQTY;
                    case 15: // TRAMT
                        return CurrentItem.TRAMT;
                    case 16: // TRPAID
                        return CurrentItem.TRPAID;
                    case 17: // TRINV
                        return CurrentItem.TRINV;
                    case 18: // TRDELETE
                        return CurrentItem.TRDELETE;
                    case 19: // TRDET
                        return CurrentItem.TRDET;
                    case 20: // TRDEL_MONTHS
                        return CurrentItem.TRDEL_MONTHS;
                    case 21: // PERCENTAGE
                        return CurrentItem.PERCENTAGE;
                    case 22: // TRBANK
                        return CurrentItem.TRBANK;
                    case 23: // TRNETT
                        return CurrentItem.TRNETT;
                    case 24: // TRGROSS
                        return CurrentItem.TRGROSS;
                    case 25: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT;
                    case 26: // GST_TYPE
                        return CurrentItem.GST_TYPE;
                    case 27: // GST_RATE
                        return CurrentItem.GST_RATE;
                    case 28: // ORIG_DATE
                        return CurrentItem.ORIG_DATE;
                    case 29: // ORIG_GROSS
                        return CurrentItem.ORIG_GROSS;
                    case 30: // DRAWER
                        return CurrentItem.DRAWER;
                    case 31: // BSB
                        return CurrentItem.BSB;
                    case 32: // BANK
                        return CurrentItem.BANK;
                    case 33: // BRANCH
                        return CurrentItem.BRANCH;
                    case 34: // ACCOUNT_NUMBER
                        return CurrentItem.ACCOUNT_NUMBER;
                    case 35: // RTYPE
                        return CurrentItem.RTYPE;
                    case 36: // SPLIT_ITEM
                        return CurrentItem.SPLIT_ITEM;
                    case 37: // FEE_CODE
                        return CurrentItem.FEE_CODE;
                    case 38: // TRMETHOD
                        return CurrentItem.TRMETHOD;
                    case 39: // MASTERTID
                        return CurrentItem.MASTERTID;
                    case 40: // ALLOCTID
                        return CurrentItem.ALLOCTID;
                    case 41: // SUBJECT
                        return CurrentItem.SUBJECT;
                    case 42: // LINE_NO
                        return CurrentItem.LINE_NO;
                    case 43: // FLAG
                        return CurrentItem.FLAG;
                    case 44: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 45: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 46: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 47: // VOLUNTARY
                        return CurrentItem.VOLUNTARY;
                    case 48: // EMA_RECEIPT
                        return CurrentItem.EMA_RECEIPT;
                    case 49: // EMA_PERIOD
                        return CurrentItem.EMA_PERIOD;
                    case 50: // EMA_TID
                        return CurrentItem.EMA_TID;
                    case 51: // GL_PROCESSED
                        return CurrentItem.GL_PROCESSED;
                    case 52: // PRINT_CHEQUE
                        return CurrentItem.PRINT_CHEQUE;
                    case 53: // RECEIPT_PRINTED
                        return CurrentItem.RECEIPT_PRINTED;
                    case 54: // DEBIT
                        return CurrentItem.DEBIT;
                    case 55: // CREDIT
                        return CurrentItem.CREDIT;
                    case 56: // CANCELLED
                        return CurrentItem.CANCELLED;
                    case 57: // STATEMENT_PRINT
                        return CurrentItem.STATEMENT_PRINT;
                    case 58: // ST_SURNAME
                        return CurrentItem.ST_SURNAME;
                    case 59: // ST_FIRSTNAME
                        return CurrentItem.ST_FIRSTNAME;
                    case 60: // FEE_DESCRIPTION
                        return CurrentItem.FEE_DESCRIPTION;
                    case 61: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 62: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 63: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRSTUD
                        return CurrentItem.TRSTUD == null;
                    case 3: // STUDENT
                        return CurrentItem.STUDENT == null;
                    case 4: // BPAY_REFERENCE
                        return CurrentItem.BPAY_REFERENCE == null;
                    case 5: // REFERENCE_NO
                        return CurrentItem.REFERENCE_NO == null;
                    case 6: // TRBATCH
                        return CurrentItem.TRBATCH == null;
                    case 7: // TRPERD
                        return CurrentItem.TRPERD == null;
                    case 8: // TRTYPE
                        return CurrentItem.TRTYPE == null;
                    case 9: // TRDATE
                        return CurrentItem.TRDATE == null;
                    case 10: // TRREF
                        return CurrentItem.TRREF == null;
                    case 11: // TRXLEDGER
                        return CurrentItem.TRXLEDGER == null;
                    case 12: // TRXCODE
                        return CurrentItem.TRXCODE == null;
                    case 13: // TRCOST
                        return CurrentItem.TRCOST == null;
                    case 14: // TRQTY
                        return CurrentItem.TRQTY == null;
                    case 15: // TRAMT
                        return CurrentItem.TRAMT == null;
                    case 16: // TRPAID
                        return CurrentItem.TRPAID == null;
                    case 17: // TRINV
                        return CurrentItem.TRINV == null;
                    case 18: // TRDELETE
                        return CurrentItem.TRDELETE == null;
                    case 19: // TRDET
                        return CurrentItem.TRDET == null;
                    case 20: // TRDEL_MONTHS
                        return CurrentItem.TRDEL_MONTHS == null;
                    case 21: // PERCENTAGE
                        return CurrentItem.PERCENTAGE == null;
                    case 22: // TRBANK
                        return CurrentItem.TRBANK == null;
                    case 23: // TRNETT
                        return CurrentItem.TRNETT == null;
                    case 24: // TRGROSS
                        return CurrentItem.TRGROSS == null;
                    case 25: // GST_AMOUNT
                        return CurrentItem.GST_AMOUNT == null;
                    case 26: // GST_TYPE
                        return CurrentItem.GST_TYPE == null;
                    case 27: // GST_RATE
                        return CurrentItem.GST_RATE == null;
                    case 28: // ORIG_DATE
                        return CurrentItem.ORIG_DATE == null;
                    case 29: // ORIG_GROSS
                        return CurrentItem.ORIG_GROSS == null;
                    case 30: // DRAWER
                        return CurrentItem.DRAWER == null;
                    case 31: // BSB
                        return CurrentItem.BSB == null;
                    case 32: // BANK
                        return CurrentItem.BANK == null;
                    case 33: // BRANCH
                        return CurrentItem.BRANCH == null;
                    case 34: // ACCOUNT_NUMBER
                        return CurrentItem.ACCOUNT_NUMBER == null;
                    case 35: // RTYPE
                        return CurrentItem.RTYPE == null;
                    case 36: // SPLIT_ITEM
                        return CurrentItem.SPLIT_ITEM == null;
                    case 37: // FEE_CODE
                        return CurrentItem.FEE_CODE == null;
                    case 38: // TRMETHOD
                        return CurrentItem.TRMETHOD == null;
                    case 39: // MASTERTID
                        return CurrentItem.MASTERTID == null;
                    case 40: // ALLOCTID
                        return CurrentItem.ALLOCTID == null;
                    case 41: // SUBJECT
                        return CurrentItem.SUBJECT == null;
                    case 42: // LINE_NO
                        return CurrentItem.LINE_NO == null;
                    case 43: // FLAG
                        return CurrentItem.FLAG == null;
                    case 44: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 45: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 46: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 47: // VOLUNTARY
                        return CurrentItem.VOLUNTARY == null;
                    case 48: // EMA_RECEIPT
                        return CurrentItem.EMA_RECEIPT == null;
                    case 49: // EMA_PERIOD
                        return CurrentItem.EMA_PERIOD == null;
                    case 50: // EMA_TID
                        return CurrentItem.EMA_TID == null;
                    case 51: // GL_PROCESSED
                        return CurrentItem.GL_PROCESSED == null;
                    case 52: // PRINT_CHEQUE
                        return CurrentItem.PRINT_CHEQUE == null;
                    case 53: // RECEIPT_PRINTED
                        return CurrentItem.RECEIPT_PRINTED == null;
                    case 54: // DEBIT
                        return CurrentItem.DEBIT == null;
                    case 55: // CREDIT
                        return CurrentItem.CREDIT == null;
                    case 56: // CANCELLED
                        return CurrentItem.CANCELLED == null;
                    case 57: // STATEMENT_PRINT
                        return CurrentItem.STATEMENT_PRINT == null;
                    case 58: // ST_SURNAME
                        return CurrentItem.ST_SURNAME == null;
                    case 59: // ST_FIRSTNAME
                        return CurrentItem.ST_FIRSTNAME == null;
                    case 60: // FEE_DESCRIPTION
                        return CurrentItem.FEE_DESCRIPTION == null;
                    case 61: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 62: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 63: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRSTUD
                        return "TRSTUD";
                    case 3: // STUDENT
                        return "STUDENT";
                    case 4: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 5: // REFERENCE_NO
                        return "REFERENCE_NO";
                    case 6: // TRBATCH
                        return "TRBATCH";
                    case 7: // TRPERD
                        return "TRPERD";
                    case 8: // TRTYPE
                        return "TRTYPE";
                    case 9: // TRDATE
                        return "TRDATE";
                    case 10: // TRREF
                        return "TRREF";
                    case 11: // TRXLEDGER
                        return "TRXLEDGER";
                    case 12: // TRXCODE
                        return "TRXCODE";
                    case 13: // TRCOST
                        return "TRCOST";
                    case 14: // TRQTY
                        return "TRQTY";
                    case 15: // TRAMT
                        return "TRAMT";
                    case 16: // TRPAID
                        return "TRPAID";
                    case 17: // TRINV
                        return "TRINV";
                    case 18: // TRDELETE
                        return "TRDELETE";
                    case 19: // TRDET
                        return "TRDET";
                    case 20: // TRDEL_MONTHS
                        return "TRDEL_MONTHS";
                    case 21: // PERCENTAGE
                        return "PERCENTAGE";
                    case 22: // TRBANK
                        return "TRBANK";
                    case 23: // TRNETT
                        return "TRNETT";
                    case 24: // TRGROSS
                        return "TRGROSS";
                    case 25: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 26: // GST_TYPE
                        return "GST_TYPE";
                    case 27: // GST_RATE
                        return "GST_RATE";
                    case 28: // ORIG_DATE
                        return "ORIG_DATE";
                    case 29: // ORIG_GROSS
                        return "ORIG_GROSS";
                    case 30: // DRAWER
                        return "DRAWER";
                    case 31: // BSB
                        return "BSB";
                    case 32: // BANK
                        return "BANK";
                    case 33: // BRANCH
                        return "BRANCH";
                    case 34: // ACCOUNT_NUMBER
                        return "ACCOUNT_NUMBER";
                    case 35: // RTYPE
                        return "RTYPE";
                    case 36: // SPLIT_ITEM
                        return "SPLIT_ITEM";
                    case 37: // FEE_CODE
                        return "FEE_CODE";
                    case 38: // TRMETHOD
                        return "TRMETHOD";
                    case 39: // MASTERTID
                        return "MASTERTID";
                    case 40: // ALLOCTID
                        return "ALLOCTID";
                    case 41: // SUBJECT
                        return "SUBJECT";
                    case 42: // LINE_NO
                        return "LINE_NO";
                    case 43: // FLAG
                        return "FLAG";
                    case 44: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 45: // GLPROGRAM
                        return "GLPROGRAM";
                    case 46: // INITIATIVE
                        return "INITIATIVE";
                    case 47: // VOLUNTARY
                        return "VOLUNTARY";
                    case 48: // EMA_RECEIPT
                        return "EMA_RECEIPT";
                    case 49: // EMA_PERIOD
                        return "EMA_PERIOD";
                    case 50: // EMA_TID
                        return "EMA_TID";
                    case 51: // GL_PROCESSED
                        return "GL_PROCESSED";
                    case 52: // PRINT_CHEQUE
                        return "PRINT_CHEQUE";
                    case 53: // RECEIPT_PRINTED
                        return "RECEIPT_PRINTED";
                    case 54: // DEBIT
                        return "DEBIT";
                    case 55: // CREDIT
                        return "CREDIT";
                    case 56: // CANCELLED
                        return "CANCELLED";
                    case 57: // STATEMENT_PRINT
                        return "STATEMENT_PRINT";
                    case 58: // ST_SURNAME
                        return "ST_SURNAME";
                    case 59: // ST_FIRSTNAME
                        return "ST_FIRSTNAME";
                    case 60: // FEE_DESCRIPTION
                        return "FEE_DESCRIPTION";
                    case 61: // LW_DATE
                        return "LW_DATE";
                    case 62: // LW_TIME
                        return "LW_TIME";
                    case 63: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "TRSTUD":
                        return 2;
                    case "STUDENT":
                        return 3;
                    case "BPAY_REFERENCE":
                        return 4;
                    case "REFERENCE_NO":
                        return 5;
                    case "TRBATCH":
                        return 6;
                    case "TRPERD":
                        return 7;
                    case "TRTYPE":
                        return 8;
                    case "TRDATE":
                        return 9;
                    case "TRREF":
                        return 10;
                    case "TRXLEDGER":
                        return 11;
                    case "TRXCODE":
                        return 12;
                    case "TRCOST":
                        return 13;
                    case "TRQTY":
                        return 14;
                    case "TRAMT":
                        return 15;
                    case "TRPAID":
                        return 16;
                    case "TRINV":
                        return 17;
                    case "TRDELETE":
                        return 18;
                    case "TRDET":
                        return 19;
                    case "TRDEL_MONTHS":
                        return 20;
                    case "PERCENTAGE":
                        return 21;
                    case "TRBANK":
                        return 22;
                    case "TRNETT":
                        return 23;
                    case "TRGROSS":
                        return 24;
                    case "GST_AMOUNT":
                        return 25;
                    case "GST_TYPE":
                        return 26;
                    case "GST_RATE":
                        return 27;
                    case "ORIG_DATE":
                        return 28;
                    case "ORIG_GROSS":
                        return 29;
                    case "DRAWER":
                        return 30;
                    case "BSB":
                        return 31;
                    case "BANK":
                        return 32;
                    case "BRANCH":
                        return 33;
                    case "ACCOUNT_NUMBER":
                        return 34;
                    case "RTYPE":
                        return 35;
                    case "SPLIT_ITEM":
                        return 36;
                    case "FEE_CODE":
                        return 37;
                    case "TRMETHOD":
                        return 38;
                    case "MASTERTID":
                        return 39;
                    case "ALLOCTID":
                        return 40;
                    case "SUBJECT":
                        return 41;
                    case "LINE_NO":
                        return 42;
                    case "FLAG":
                        return 43;
                    case "SUBPROGRAM":
                        return 44;
                    case "GLPROGRAM":
                        return 45;
                    case "INITIATIVE":
                        return 46;
                    case "VOLUNTARY":
                        return 47;
                    case "EMA_RECEIPT":
                        return 48;
                    case "EMA_PERIOD":
                        return 49;
                    case "EMA_TID":
                        return 50;
                    case "GL_PROCESSED":
                        return 51;
                    case "PRINT_CHEQUE":
                        return 52;
                    case "RECEIPT_PRINTED":
                        return 53;
                    case "DEBIT":
                        return 54;
                    case "CREDIT":
                        return 55;
                    case "CANCELLED":
                        return 56;
                    case "STATEMENT_PRINT":
                        return 57;
                    case "ST_SURNAME":
                        return 58;
                    case "ST_FIRSTNAME":
                        return 59;
                    case "FEE_DESCRIPTION":
                        return 60;
                    case "LW_DATE":
                        return 61;
                    case "LW_TIME":
                        return 62;
                    case "LW_USER":
                        return 63;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
