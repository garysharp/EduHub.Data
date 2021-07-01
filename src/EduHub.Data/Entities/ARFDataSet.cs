using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Financial Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ARFDataSet : EduHubDataSet<ARF>
    {
        /// <inheritdoc />
        public override string Name { get { return "ARF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal ARFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.AMETHOD));
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_RELEASE_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.RELEASE_TYPE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, ARF>>(() => this.ToDictionary(i => i.TID));
            Index_TMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.TMETHOD));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<ARF>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ARF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ARF" /> fields for each CSV column header</returns>
        internal override Action<ARF, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.NEXT_SVC_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.ADEPN_BEGIN = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.TDEPN_BEGIN = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="ARF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="ARF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="ARF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{ARF}"/> of entities</returns>
        internal override IEnumerable<ARF> ApplyDeltaEntities(IEnumerable<ARF> Entities, List<ARF> DeltaEntities)
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

        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_AMETHOD;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_RELEASE_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, ARF>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_TMETHOD;
        private Lazy<NullDictionary<string, IReadOnlyList<ARF>>> Index_TRREF;

        #endregion

        #region Index Methods

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

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a ARF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[ARF](
        [TID] int NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRREF] varchar(10) NULL,
        [TRXCODE] varchar(10) NULL,
        [GL_TRXCODE] varchar(10) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [GL_TRXLEDGER] varchar(2) NULL,
        [TRDATE] datetime NULL,
        [TRTYPE] varchar(1) NULL,
        [TRDET] varchar(30) NULL,
        [TRPERD] int NULL,
        [TRBATCH] int NULL,
        [TRBANK] varchar(10) NULL,
        [DRAWER] varchar(20) NULL,
        [BSB] varchar(6) NULL,
        [BANK] varchar(20) NULL,
        [BRANCH] varchar(20) NULL,
        [ACCOUNT_NUMBER] int NULL,
        [RTYPE] varchar(2) NULL,
        [TRQTY] smallint NULL,
        [ST_QTY] smallint NULL,
        [AMEMO] varchar(MAX) NULL,
        [AMEMO_COPY] varchar(1) NULL,
        [NEXT_SVC_DATE] datetime NULL,
        [TRCOST] money NULL,
        [TRNETT] money NULL,
        [TRAMT] money NULL,
        [TRGROSS] money NULL,
        [GST_TYPE] varchar(4) NULL,
        [GST_RATE] float NULL,
        [GST_RECLAIM] varchar(1) NULL,
        [ACOST] money NULL,
        [GST_AMOUNT] money NULL,
        [GST_AMOUNT_SALE] money NULL,
        [AUNCL_GST] money NULL,
        [ADEPN] money NULL,
        [APTE_DEPN] money NULL,
        [AFLAG] varchar(1) NULL,
        [ADEPN_BEGIN] datetime NULL,
        [ARATE] float NULL,
        [AMETHOD] varchar(1) NULL,
        [AREVALS] money NULL,
        [AUNITS] int NULL,
        [TINCLUDE] varchar(1) NULL,
        [TCOST] money NULL,
        [TTRNETT] money NULL,
        [TTRAMT] money NULL,
        [TGST_AMOUNT] money NULL,
        [TUNCL_GST] money NULL,
        [TDEPN] money NULL,
        [TPTE_DEPN] money NULL,
        [TFLAG] varchar(1) NULL,
        [TDEPN_BEGIN] datetime NULL,
        [TRATE] float NULL,
        [TMETHOD] varchar(1) NULL,
        [TCON] money NULL,
        [ACON] money NULL,
        [TRORIG] money NULL,
        [ADEPLY] money NULL,
        [ADEPTY] money NULL,
        [AWDV] money NULL,
        [CRKEY] varchar(10) NULL,
        [TRINSTALL] varchar(1) NULL,
        [TDEPTY] money NULL,
        [TDEPLY] money NULL,
        [TWDV] money NULL,
        [LINE_NO] int NULL,
        [FLAG] int NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [RELEASE_TYPE] varchar(2) NULL,
        [RECEIVED_FROM] varchar(50) NULL,
        [LOCATION] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [ARF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_AMETHOD] ON [dbo].[ARF]
    (
            [AMETHOD] ASC
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_BSB] ON [dbo].[ARF]
    (
            [BSB] ASC
    );
    CREATE CLUSTERED INDEX [ARF_Index_CODE] ON [dbo].[ARF]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_GST_TYPE] ON [dbo].[ARF]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_INITIATIVE] ON [dbo].[ARF]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_LOCATION] ON [dbo].[ARF]
    (
            [LOCATION] ASC
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_RELEASE_TYPE] ON [dbo].[ARF]
    (
            [RELEASE_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_SUBPROGRAM] ON [dbo].[ARF]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_TMETHOD] ON [dbo].[ARF]
    (
            [TMETHOD] ASC
    );
    CREATE NONCLUSTERED INDEX [ARF_Index_TRREF] ON [dbo].[ARF]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_AMETHOD')
    ALTER INDEX [ARF_Index_AMETHOD] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_BSB')
    ALTER INDEX [ARF_Index_BSB] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_GST_TYPE')
    ALTER INDEX [ARF_Index_GST_TYPE] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_INITIATIVE')
    ALTER INDEX [ARF_Index_INITIATIVE] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_LOCATION')
    ALTER INDEX [ARF_Index_LOCATION] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_RELEASE_TYPE')
    ALTER INDEX [ARF_Index_RELEASE_TYPE] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_SUBPROGRAM')
    ALTER INDEX [ARF_Index_SUBPROGRAM] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_TID')
    ALTER INDEX [ARF_Index_TID] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_TMETHOD')
    ALTER INDEX [ARF_Index_TMETHOD] ON [dbo].[ARF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_TRREF')
    ALTER INDEX [ARF_Index_TRREF] ON [dbo].[ARF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_AMETHOD')
    ALTER INDEX [ARF_Index_AMETHOD] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_BSB')
    ALTER INDEX [ARF_Index_BSB] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_GST_TYPE')
    ALTER INDEX [ARF_Index_GST_TYPE] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_INITIATIVE')
    ALTER INDEX [ARF_Index_INITIATIVE] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_LOCATION')
    ALTER INDEX [ARF_Index_LOCATION] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_RELEASE_TYPE')
    ALTER INDEX [ARF_Index_RELEASE_TYPE] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_SUBPROGRAM')
    ALTER INDEX [ARF_Index_SUBPROGRAM] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_TID')
    ALTER INDEX [ARF_Index_TID] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_TMETHOD')
    ALTER INDEX [ARF_Index_TMETHOD] ON [dbo].[ARF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ARF]') AND name = N'ARF_Index_TRREF')
    ALTER INDEX [ARF_Index_TRREF] ON [dbo].[ARF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="ARF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="ARF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<ARF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[ARF] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the ARF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ARF data set</returns>
        public override EduHubDataSetDataReader<ARF> GetDataSetDataReader()
        {
            return new ARFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the ARF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ARF data set</returns>
        public override EduHubDataSetDataReader<ARF> GetDataSetDataReader(List<ARF> Entities)
        {
            return new ARFDataReader(new EduHubDataSetLoadedReader<ARF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class ARFDataReader : EduHubDataSetDataReader<ARF>
        {
            public ARFDataReader(IEduHubDataSetReader<ARF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 77; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // TRREF
                        return Current.TRREF;
                    case 3: // TRXCODE
                        return Current.TRXCODE;
                    case 4: // GL_TRXCODE
                        return Current.GL_TRXCODE;
                    case 5: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 6: // GL_TRXLEDGER
                        return Current.GL_TRXLEDGER;
                    case 7: // TRDATE
                        return Current.TRDATE;
                    case 8: // TRTYPE
                        return Current.TRTYPE;
                    case 9: // TRDET
                        return Current.TRDET;
                    case 10: // TRPERD
                        return Current.TRPERD;
                    case 11: // TRBATCH
                        return Current.TRBATCH;
                    case 12: // TRBANK
                        return Current.TRBANK;
                    case 13: // DRAWER
                        return Current.DRAWER;
                    case 14: // BSB
                        return Current.BSB;
                    case 15: // BANK
                        return Current.BANK;
                    case 16: // BRANCH
                        return Current.BRANCH;
                    case 17: // ACCOUNT_NUMBER
                        return Current.ACCOUNT_NUMBER;
                    case 18: // RTYPE
                        return Current.RTYPE;
                    case 19: // TRQTY
                        return Current.TRQTY;
                    case 20: // ST_QTY
                        return Current.ST_QTY;
                    case 21: // AMEMO
                        return Current.AMEMO;
                    case 22: // AMEMO_COPY
                        return Current.AMEMO_COPY;
                    case 23: // NEXT_SVC_DATE
                        return Current.NEXT_SVC_DATE;
                    case 24: // TRCOST
                        return Current.TRCOST;
                    case 25: // TRNETT
                        return Current.TRNETT;
                    case 26: // TRAMT
                        return Current.TRAMT;
                    case 27: // TRGROSS
                        return Current.TRGROSS;
                    case 28: // GST_TYPE
                        return Current.GST_TYPE;
                    case 29: // GST_RATE
                        return Current.GST_RATE;
                    case 30: // GST_RECLAIM
                        return Current.GST_RECLAIM;
                    case 31: // ACOST
                        return Current.ACOST;
                    case 32: // GST_AMOUNT
                        return Current.GST_AMOUNT;
                    case 33: // GST_AMOUNT_SALE
                        return Current.GST_AMOUNT_SALE;
                    case 34: // AUNCL_GST
                        return Current.AUNCL_GST;
                    case 35: // ADEPN
                        return Current.ADEPN;
                    case 36: // APTE_DEPN
                        return Current.APTE_DEPN;
                    case 37: // AFLAG
                        return Current.AFLAG;
                    case 38: // ADEPN_BEGIN
                        return Current.ADEPN_BEGIN;
                    case 39: // ARATE
                        return Current.ARATE;
                    case 40: // AMETHOD
                        return Current.AMETHOD;
                    case 41: // AREVALS
                        return Current.AREVALS;
                    case 42: // AUNITS
                        return Current.AUNITS;
                    case 43: // TINCLUDE
                        return Current.TINCLUDE;
                    case 44: // TCOST
                        return Current.TCOST;
                    case 45: // TTRNETT
                        return Current.TTRNETT;
                    case 46: // TTRAMT
                        return Current.TTRAMT;
                    case 47: // TGST_AMOUNT
                        return Current.TGST_AMOUNT;
                    case 48: // TUNCL_GST
                        return Current.TUNCL_GST;
                    case 49: // TDEPN
                        return Current.TDEPN;
                    case 50: // TPTE_DEPN
                        return Current.TPTE_DEPN;
                    case 51: // TFLAG
                        return Current.TFLAG;
                    case 52: // TDEPN_BEGIN
                        return Current.TDEPN_BEGIN;
                    case 53: // TRATE
                        return Current.TRATE;
                    case 54: // TMETHOD
                        return Current.TMETHOD;
                    case 55: // TCON
                        return Current.TCON;
                    case 56: // ACON
                        return Current.ACON;
                    case 57: // TRORIG
                        return Current.TRORIG;
                    case 58: // ADEPLY
                        return Current.ADEPLY;
                    case 59: // ADEPTY
                        return Current.ADEPTY;
                    case 60: // AWDV
                        return Current.AWDV;
                    case 61: // CRKEY
                        return Current.CRKEY;
                    case 62: // TRINSTALL
                        return Current.TRINSTALL;
                    case 63: // TDEPTY
                        return Current.TDEPTY;
                    case 64: // TDEPLY
                        return Current.TDEPLY;
                    case 65: // TWDV
                        return Current.TWDV;
                    case 66: // LINE_NO
                        return Current.LINE_NO;
                    case 67: // FLAG
                        return Current.FLAG;
                    case 68: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 69: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 70: // INITIATIVE
                        return Current.INITIATIVE;
                    case 71: // RELEASE_TYPE
                        return Current.RELEASE_TYPE;
                    case 72: // RECEIVED_FROM
                        return Current.RECEIVED_FROM;
                    case 73: // LOCATION
                        return Current.LOCATION;
                    case 74: // LW_DATE
                        return Current.LW_DATE;
                    case 75: // LW_TIME
                        return Current.LW_TIME;
                    case 76: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRREF
                        return Current.TRREF == null;
                    case 3: // TRXCODE
                        return Current.TRXCODE == null;
                    case 4: // GL_TRXCODE
                        return Current.GL_TRXCODE == null;
                    case 5: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 6: // GL_TRXLEDGER
                        return Current.GL_TRXLEDGER == null;
                    case 7: // TRDATE
                        return Current.TRDATE == null;
                    case 8: // TRTYPE
                        return Current.TRTYPE == null;
                    case 9: // TRDET
                        return Current.TRDET == null;
                    case 10: // TRPERD
                        return Current.TRPERD == null;
                    case 11: // TRBATCH
                        return Current.TRBATCH == null;
                    case 12: // TRBANK
                        return Current.TRBANK == null;
                    case 13: // DRAWER
                        return Current.DRAWER == null;
                    case 14: // BSB
                        return Current.BSB == null;
                    case 15: // BANK
                        return Current.BANK == null;
                    case 16: // BRANCH
                        return Current.BRANCH == null;
                    case 17: // ACCOUNT_NUMBER
                        return Current.ACCOUNT_NUMBER == null;
                    case 18: // RTYPE
                        return Current.RTYPE == null;
                    case 19: // TRQTY
                        return Current.TRQTY == null;
                    case 20: // ST_QTY
                        return Current.ST_QTY == null;
                    case 21: // AMEMO
                        return Current.AMEMO == null;
                    case 22: // AMEMO_COPY
                        return Current.AMEMO_COPY == null;
                    case 23: // NEXT_SVC_DATE
                        return Current.NEXT_SVC_DATE == null;
                    case 24: // TRCOST
                        return Current.TRCOST == null;
                    case 25: // TRNETT
                        return Current.TRNETT == null;
                    case 26: // TRAMT
                        return Current.TRAMT == null;
                    case 27: // TRGROSS
                        return Current.TRGROSS == null;
                    case 28: // GST_TYPE
                        return Current.GST_TYPE == null;
                    case 29: // GST_RATE
                        return Current.GST_RATE == null;
                    case 30: // GST_RECLAIM
                        return Current.GST_RECLAIM == null;
                    case 31: // ACOST
                        return Current.ACOST == null;
                    case 32: // GST_AMOUNT
                        return Current.GST_AMOUNT == null;
                    case 33: // GST_AMOUNT_SALE
                        return Current.GST_AMOUNT_SALE == null;
                    case 34: // AUNCL_GST
                        return Current.AUNCL_GST == null;
                    case 35: // ADEPN
                        return Current.ADEPN == null;
                    case 36: // APTE_DEPN
                        return Current.APTE_DEPN == null;
                    case 37: // AFLAG
                        return Current.AFLAG == null;
                    case 38: // ADEPN_BEGIN
                        return Current.ADEPN_BEGIN == null;
                    case 39: // ARATE
                        return Current.ARATE == null;
                    case 40: // AMETHOD
                        return Current.AMETHOD == null;
                    case 41: // AREVALS
                        return Current.AREVALS == null;
                    case 42: // AUNITS
                        return Current.AUNITS == null;
                    case 43: // TINCLUDE
                        return Current.TINCLUDE == null;
                    case 44: // TCOST
                        return Current.TCOST == null;
                    case 45: // TTRNETT
                        return Current.TTRNETT == null;
                    case 46: // TTRAMT
                        return Current.TTRAMT == null;
                    case 47: // TGST_AMOUNT
                        return Current.TGST_AMOUNT == null;
                    case 48: // TUNCL_GST
                        return Current.TUNCL_GST == null;
                    case 49: // TDEPN
                        return Current.TDEPN == null;
                    case 50: // TPTE_DEPN
                        return Current.TPTE_DEPN == null;
                    case 51: // TFLAG
                        return Current.TFLAG == null;
                    case 52: // TDEPN_BEGIN
                        return Current.TDEPN_BEGIN == null;
                    case 53: // TRATE
                        return Current.TRATE == null;
                    case 54: // TMETHOD
                        return Current.TMETHOD == null;
                    case 55: // TCON
                        return Current.TCON == null;
                    case 56: // ACON
                        return Current.ACON == null;
                    case 57: // TRORIG
                        return Current.TRORIG == null;
                    case 58: // ADEPLY
                        return Current.ADEPLY == null;
                    case 59: // ADEPTY
                        return Current.ADEPTY == null;
                    case 60: // AWDV
                        return Current.AWDV == null;
                    case 61: // CRKEY
                        return Current.CRKEY == null;
                    case 62: // TRINSTALL
                        return Current.TRINSTALL == null;
                    case 63: // TDEPTY
                        return Current.TDEPTY == null;
                    case 64: // TDEPLY
                        return Current.TDEPLY == null;
                    case 65: // TWDV
                        return Current.TWDV == null;
                    case 66: // LINE_NO
                        return Current.LINE_NO == null;
                    case 67: // FLAG
                        return Current.FLAG == null;
                    case 68: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 69: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 70: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 71: // RELEASE_TYPE
                        return Current.RELEASE_TYPE == null;
                    case 72: // RECEIVED_FROM
                        return Current.RECEIVED_FROM == null;
                    case 73: // LOCATION
                        return Current.LOCATION == null;
                    case 74: // LW_DATE
                        return Current.LW_DATE == null;
                    case 75: // LW_TIME
                        return Current.LW_TIME == null;
                    case 76: // LW_USER
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRREF
                        return "TRREF";
                    case 3: // TRXCODE
                        return "TRXCODE";
                    case 4: // GL_TRXCODE
                        return "GL_TRXCODE";
                    case 5: // TRXLEDGER
                        return "TRXLEDGER";
                    case 6: // GL_TRXLEDGER
                        return "GL_TRXLEDGER";
                    case 7: // TRDATE
                        return "TRDATE";
                    case 8: // TRTYPE
                        return "TRTYPE";
                    case 9: // TRDET
                        return "TRDET";
                    case 10: // TRPERD
                        return "TRPERD";
                    case 11: // TRBATCH
                        return "TRBATCH";
                    case 12: // TRBANK
                        return "TRBANK";
                    case 13: // DRAWER
                        return "DRAWER";
                    case 14: // BSB
                        return "BSB";
                    case 15: // BANK
                        return "BANK";
                    case 16: // BRANCH
                        return "BRANCH";
                    case 17: // ACCOUNT_NUMBER
                        return "ACCOUNT_NUMBER";
                    case 18: // RTYPE
                        return "RTYPE";
                    case 19: // TRQTY
                        return "TRQTY";
                    case 20: // ST_QTY
                        return "ST_QTY";
                    case 21: // AMEMO
                        return "AMEMO";
                    case 22: // AMEMO_COPY
                        return "AMEMO_COPY";
                    case 23: // NEXT_SVC_DATE
                        return "NEXT_SVC_DATE";
                    case 24: // TRCOST
                        return "TRCOST";
                    case 25: // TRNETT
                        return "TRNETT";
                    case 26: // TRAMT
                        return "TRAMT";
                    case 27: // TRGROSS
                        return "TRGROSS";
                    case 28: // GST_TYPE
                        return "GST_TYPE";
                    case 29: // GST_RATE
                        return "GST_RATE";
                    case 30: // GST_RECLAIM
                        return "GST_RECLAIM";
                    case 31: // ACOST
                        return "ACOST";
                    case 32: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 33: // GST_AMOUNT_SALE
                        return "GST_AMOUNT_SALE";
                    case 34: // AUNCL_GST
                        return "AUNCL_GST";
                    case 35: // ADEPN
                        return "ADEPN";
                    case 36: // APTE_DEPN
                        return "APTE_DEPN";
                    case 37: // AFLAG
                        return "AFLAG";
                    case 38: // ADEPN_BEGIN
                        return "ADEPN_BEGIN";
                    case 39: // ARATE
                        return "ARATE";
                    case 40: // AMETHOD
                        return "AMETHOD";
                    case 41: // AREVALS
                        return "AREVALS";
                    case 42: // AUNITS
                        return "AUNITS";
                    case 43: // TINCLUDE
                        return "TINCLUDE";
                    case 44: // TCOST
                        return "TCOST";
                    case 45: // TTRNETT
                        return "TTRNETT";
                    case 46: // TTRAMT
                        return "TTRAMT";
                    case 47: // TGST_AMOUNT
                        return "TGST_AMOUNT";
                    case 48: // TUNCL_GST
                        return "TUNCL_GST";
                    case 49: // TDEPN
                        return "TDEPN";
                    case 50: // TPTE_DEPN
                        return "TPTE_DEPN";
                    case 51: // TFLAG
                        return "TFLAG";
                    case 52: // TDEPN_BEGIN
                        return "TDEPN_BEGIN";
                    case 53: // TRATE
                        return "TRATE";
                    case 54: // TMETHOD
                        return "TMETHOD";
                    case 55: // TCON
                        return "TCON";
                    case 56: // ACON
                        return "ACON";
                    case 57: // TRORIG
                        return "TRORIG";
                    case 58: // ADEPLY
                        return "ADEPLY";
                    case 59: // ADEPTY
                        return "ADEPTY";
                    case 60: // AWDV
                        return "AWDV";
                    case 61: // CRKEY
                        return "CRKEY";
                    case 62: // TRINSTALL
                        return "TRINSTALL";
                    case 63: // TDEPTY
                        return "TDEPTY";
                    case 64: // TDEPLY
                        return "TDEPLY";
                    case 65: // TWDV
                        return "TWDV";
                    case 66: // LINE_NO
                        return "LINE_NO";
                    case 67: // FLAG
                        return "FLAG";
                    case 68: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 69: // GLPROGRAM
                        return "GLPROGRAM";
                    case 70: // INITIATIVE
                        return "INITIATIVE";
                    case 71: // RELEASE_TYPE
                        return "RELEASE_TYPE";
                    case 72: // RECEIVED_FROM
                        return "RECEIVED_FROM";
                    case 73: // LOCATION
                        return "LOCATION";
                    case 74: // LW_DATE
                        return "LW_DATE";
                    case 75: // LW_TIME
                        return "LW_TIME";
                    case 76: // LW_USER
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
                    case "CODE":
                        return 1;
                    case "TRREF":
                        return 2;
                    case "TRXCODE":
                        return 3;
                    case "GL_TRXCODE":
                        return 4;
                    case "TRXLEDGER":
                        return 5;
                    case "GL_TRXLEDGER":
                        return 6;
                    case "TRDATE":
                        return 7;
                    case "TRTYPE":
                        return 8;
                    case "TRDET":
                        return 9;
                    case "TRPERD":
                        return 10;
                    case "TRBATCH":
                        return 11;
                    case "TRBANK":
                        return 12;
                    case "DRAWER":
                        return 13;
                    case "BSB":
                        return 14;
                    case "BANK":
                        return 15;
                    case "BRANCH":
                        return 16;
                    case "ACCOUNT_NUMBER":
                        return 17;
                    case "RTYPE":
                        return 18;
                    case "TRQTY":
                        return 19;
                    case "ST_QTY":
                        return 20;
                    case "AMEMO":
                        return 21;
                    case "AMEMO_COPY":
                        return 22;
                    case "NEXT_SVC_DATE":
                        return 23;
                    case "TRCOST":
                        return 24;
                    case "TRNETT":
                        return 25;
                    case "TRAMT":
                        return 26;
                    case "TRGROSS":
                        return 27;
                    case "GST_TYPE":
                        return 28;
                    case "GST_RATE":
                        return 29;
                    case "GST_RECLAIM":
                        return 30;
                    case "ACOST":
                        return 31;
                    case "GST_AMOUNT":
                        return 32;
                    case "GST_AMOUNT_SALE":
                        return 33;
                    case "AUNCL_GST":
                        return 34;
                    case "ADEPN":
                        return 35;
                    case "APTE_DEPN":
                        return 36;
                    case "AFLAG":
                        return 37;
                    case "ADEPN_BEGIN":
                        return 38;
                    case "ARATE":
                        return 39;
                    case "AMETHOD":
                        return 40;
                    case "AREVALS":
                        return 41;
                    case "AUNITS":
                        return 42;
                    case "TINCLUDE":
                        return 43;
                    case "TCOST":
                        return 44;
                    case "TTRNETT":
                        return 45;
                    case "TTRAMT":
                        return 46;
                    case "TGST_AMOUNT":
                        return 47;
                    case "TUNCL_GST":
                        return 48;
                    case "TDEPN":
                        return 49;
                    case "TPTE_DEPN":
                        return 50;
                    case "TFLAG":
                        return 51;
                    case "TDEPN_BEGIN":
                        return 52;
                    case "TRATE":
                        return 53;
                    case "TMETHOD":
                        return 54;
                    case "TCON":
                        return 55;
                    case "ACON":
                        return 56;
                    case "TRORIG":
                        return 57;
                    case "ADEPLY":
                        return 58;
                    case "ADEPTY":
                        return 59;
                    case "AWDV":
                        return 60;
                    case "CRKEY":
                        return 61;
                    case "TRINSTALL":
                        return 62;
                    case "TDEPTY":
                        return 63;
                    case "TDEPLY":
                        return 64;
                    case "TWDV":
                        return 65;
                    case "LINE_NO":
                        return 66;
                    case "FLAG":
                        return 67;
                    case "SUBPROGRAM":
                        return 68;
                    case "GLPROGRAM":
                        return 69;
                    case "INITIATIVE":
                        return 70;
                    case "RELEASE_TYPE":
                        return 71;
                    case "RECEIVED_FROM":
                        return 72;
                    case "LOCATION":
                        return 73;
                    case "LW_DATE":
                        return 74;
                    case "LW_TIME":
                        return 75;
                    case "LW_USER":
                        return 76;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
