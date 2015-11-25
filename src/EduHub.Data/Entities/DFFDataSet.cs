using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Financial Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFFDataSet : SetBase<DFF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DFF"; } }

        internal DFFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, DFF>>(() => this.ToDictionary(i => i.TID));
            Index_TRSTUD = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.TRSTUD));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
            Index_SUBJECT = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.SUBJECT));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<DFF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
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

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> Index_CODE;
        private Lazy<Dictionary<int, DFF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_TRSTUD;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_STUDENT;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_BSB;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_FEE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<DFF>>> Index_INITIATIVE;

        #endregion

        #region Index Methods

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

        #endregion

    }
}
