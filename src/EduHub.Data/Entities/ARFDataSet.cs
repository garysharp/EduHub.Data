using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Financial Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ARFDataSet : SetBase<ARF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "ARF"; } }

        internal ARFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, ARF>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_AMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.AMETHOD));
            Index_TMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.TMETHOD));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_RELEASE_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.RELEASE_TYPE));
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ARF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ARF" /> fields for each CSV column header</returns>
        protected override Action<ARF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<ARF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRXCODE":
                        mapper[i] = (e, v) => e.TRXCODE = v;
                        break;
                    case "GL_TRXCODE":
                        mapper[i] = (e, v) => e.GL_TRXCODE = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "GL_TRXLEDGER":
                        mapper[i] = (e, v) => e.GL_TRXLEDGER = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRPERD":
                        mapper[i] = (e, v) => e.TRPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRBANK":
                        mapper[i] = (e, v) => e.TRBANK = v;
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
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ST_QTY":
                        mapper[i] = (e, v) => e.ST_QTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AMEMO":
                        mapper[i] = (e, v) => e.AMEMO = v;
                        break;
                    case "AMEMO_COPY":
                        mapper[i] = (e, v) => e.AMEMO_COPY = v;
                        break;
                    case "NEXT_SVC_DATE":
                        mapper[i] = (e, v) => e.NEXT_SVC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "ACOST":
                        mapper[i] = (e, v) => e.ACOST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_AMOUNT_SALE":
                        mapper[i] = (e, v) => e.GST_AMOUNT_SALE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AUNCL_GST":
                        mapper[i] = (e, v) => e.AUNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ADEPN":
                        mapper[i] = (e, v) => e.ADEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "APTE_DEPN":
                        mapper[i] = (e, v) => e.APTE_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AFLAG":
                        mapper[i] = (e, v) => e.AFLAG = v;
                        break;
                    case "ADEPN_BEGIN":
                        mapper[i] = (e, v) => e.ADEPN_BEGIN = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ARATE":
                        mapper[i] = (e, v) => e.ARATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AMETHOD":
                        mapper[i] = (e, v) => e.AMETHOD = v;
                        break;
                    case "AREVALS":
                        mapper[i] = (e, v) => e.AREVALS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AUNITS":
                        mapper[i] = (e, v) => e.AUNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TINCLUDE":
                        mapper[i] = (e, v) => e.TINCLUDE = v;
                        break;
                    case "TCOST":
                        mapper[i] = (e, v) => e.TCOST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTRNETT":
                        mapper[i] = (e, v) => e.TTRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTRAMT":
                        mapper[i] = (e, v) => e.TTRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TGST_AMOUNT":
                        mapper[i] = (e, v) => e.TGST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TUNCL_GST":
                        mapper[i] = (e, v) => e.TUNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TDEPN":
                        mapper[i] = (e, v) => e.TDEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TPTE_DEPN":
                        mapper[i] = (e, v) => e.TPTE_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TFLAG":
                        mapper[i] = (e, v) => e.TFLAG = v;
                        break;
                    case "TDEPN_BEGIN":
                        mapper[i] = (e, v) => e.TDEPN_BEGIN = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRATE":
                        mapper[i] = (e, v) => e.TRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TMETHOD":
                        mapper[i] = (e, v) => e.TMETHOD = v;
                        break;
                    case "TCON":
                        mapper[i] = (e, v) => e.TCON = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACON":
                        mapper[i] = (e, v) => e.ACON = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRORIG":
                        mapper[i] = (e, v) => e.TRORIG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ADEPLY":
                        mapper[i] = (e, v) => e.ADEPLY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ADEPTY":
                        mapper[i] = (e, v) => e.ADEPTY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AWDV":
                        mapper[i] = (e, v) => e.AWDV = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "TRINSTALL":
                        mapper[i] = (e, v) => e.TRINSTALL = v;
                        break;
                    case "TDEPTY":
                        mapper[i] = (e, v) => e.TDEPTY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TDEPLY":
                        mapper[i] = (e, v) => e.TDEPLY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TWDV":
                        mapper[i] = (e, v) => e.TWDV = v == null ? (decimal?)null : decimal.Parse(v);
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
                    case "RELEASE_TYPE":
                        mapper[i] = (e, v) => e.RELEASE_TYPE = v;
                        break;
                    case "RECEIVED_FROM":
                        mapper[i] = (e, v) => e.RECEIVED_FROM = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> Index_CODE;
        private Lazy<Dictionary<int, ARF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_TRREF;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_BSB;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_AMETHOD;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_TMETHOD;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_RELEASE_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_LOCATION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find ARF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find ARF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<ARF> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByCODE(string CODE)
        {
            IReadOnlyList<ARF> value;
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
        /// Find ARF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ARF</param>
        /// <returns>Related ARF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ARF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find ARF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ARF</param>
        /// <param name="Value">Related ARF entity</param>
        /// <returns>True if the related ARF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out ARF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ARF</param>
        /// <returns>Related ARF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ARF TryFindByTID(int TID)
        {
            ARF value;
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
        /// Find ARF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find ARF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<ARF> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<ARF> value;
            if (Index_TRREF.Value.TryGetValue(TRREF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ARF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find ARF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<ARF> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByBSB(string BSB)
        {
            IReadOnlyList<ARF> value;
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
        /// Find ARF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find ARF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<ARF> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<ARF> value;
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
        /// Find ARF by AMETHOD field
        /// </summary>
        /// <param name="AMETHOD">AMETHOD value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByAMETHOD(string AMETHOD)
        {
            return Index_AMETHOD.Value[AMETHOD];
        }

        /// <summary>
        /// Attempt to find ARF by AMETHOD field
        /// </summary>
        /// <param name="AMETHOD">AMETHOD value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAMETHOD(string AMETHOD, out IReadOnlyList<ARF> Value)
        {
            return Index_AMETHOD.Value.TryGetValue(AMETHOD, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by AMETHOD field
        /// </summary>
        /// <param name="AMETHOD">AMETHOD value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByAMETHOD(string AMETHOD)
        {
            IReadOnlyList<ARF> value;
            if (Index_AMETHOD.Value.TryGetValue(AMETHOD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ARF by TMETHOD field
        /// </summary>
        /// <param name="TMETHOD">TMETHOD value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByTMETHOD(string TMETHOD)
        {
            return Index_TMETHOD.Value[TMETHOD];
        }

        /// <summary>
        /// Attempt to find ARF by TMETHOD field
        /// </summary>
        /// <param name="TMETHOD">TMETHOD value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTMETHOD(string TMETHOD, out IReadOnlyList<ARF> Value)
        {
            return Index_TMETHOD.Value.TryGetValue(TMETHOD, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by TMETHOD field
        /// </summary>
        /// <param name="TMETHOD">TMETHOD value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByTMETHOD(string TMETHOD)
        {
            IReadOnlyList<ARF> value;
            if (Index_TMETHOD.Value.TryGetValue(TMETHOD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ARF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find ARF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<ARF> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<ARF> value;
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
        /// Find ARF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find ARF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<ARF> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<ARF> value;
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
        /// Find ARF by RELEASE_TYPE field
        /// </summary>
        /// <param name="RELEASE_TYPE">RELEASE_TYPE value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByRELEASE_TYPE(string RELEASE_TYPE)
        {
            return Index_RELEASE_TYPE.Value[RELEASE_TYPE];
        }

        /// <summary>
        /// Attempt to find ARF by RELEASE_TYPE field
        /// </summary>
        /// <param name="RELEASE_TYPE">RELEASE_TYPE value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRELEASE_TYPE(string RELEASE_TYPE, out IReadOnlyList<ARF> Value)
        {
            return Index_RELEASE_TYPE.Value.TryGetValue(RELEASE_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by RELEASE_TYPE field
        /// </summary>
        /// <param name="RELEASE_TYPE">RELEASE_TYPE value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByRELEASE_TYPE(string RELEASE_TYPE)
        {
            IReadOnlyList<ARF> value;
            if (Index_RELEASE_TYPE.Value.TryGetValue(RELEASE_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ARF by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find ARF</param>
        /// <returns>List of related ARF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find ARF by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find ARF</param>
        /// <param name="Value">List of related ARF entities</param>
        /// <returns>True if the list of related ARF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<ARF> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find ARF</param>
        /// <returns>List of related ARF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ARF> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<ARF> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
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
