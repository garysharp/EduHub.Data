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
    /// Assets Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ARDataSet : EduHubDataSet<AR>
    {
        /// <inheritdoc />
        public override string Name { get { return "AR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal ARDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.AMETHOD));
            Index_ARKEY = new Lazy<Dictionary<string, AR>>(() => this.ToDictionary(i => i.ARKEY));
            Index_ARNUMBER = new Lazy<Dictionary<int, AR>>(() => this.ToDictionary(i => i.ARNUMBER));
            Index_ASSET_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.ASSET_TYPE));
            Index_BRANCH = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.BRANCH));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_CATEGORY = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.CATEGORY));
            Index_COMPONENT_OF = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.COMPONENT_OF));
            Index_CURR_SUPPLIER = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.CURR_SUPPLIER));
            Index_DEPARTMENT = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.DEPARTMENT));
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_ORIG_SUPPLIER = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.ORIG_SUPPLIER));
            Index_PTE_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.PTE_GLCODE));
            Index_RELEASE_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.RELEASE_TYPE));
            Index_TAX_CATEGORY = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.TAX_CATEGORY));
            Index_TMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.TMETHOD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AR" /> fields for each CSV column header</returns>
        internal override Action<AR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ARKEY":
                        mapper[i] = (e, v) => e.ARKEY = v;
                        break;
                    case "ARNUMBER":
                        mapper[i] = (e, v) => e.ARNUMBER = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DESCRIPTION01":
                        mapper[i] = (e, v) => e.DESCRIPTION01 = v;
                        break;
                    case "DESCRIPTION02":
                        mapper[i] = (e, v) => e.DESCRIPTION02 = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "ASSET_TYPE":
                        mapper[i] = (e, v) => e.ASSET_TYPE = v;
                        break;
                    case "RELEASE_TYPE":
                        mapper[i] = (e, v) => e.RELEASE_TYPE = v;
                        break;
                    case "TAX_CATEGORY":
                        mapper[i] = (e, v) => e.TAX_CATEGORY = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "DEPARTMENT":
                        mapper[i] = (e, v) => e.DEPARTMENT = v;
                        break;
                    case "BRANCH":
                        mapper[i] = (e, v) => e.BRANCH = v;
                        break;
                    case "LEASE_START_DATE":
                        mapper[i] = (e, v) => e.LEASE_START_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LEASE_END_DATE":
                        mapper[i] = (e, v) => e.LEASE_END_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LEASE_COST_MONTH":
                        mapper[i] = (e, v) => e.LEASE_COST_MONTH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ORIG_SUPPLIER":
                        mapper[i] = (e, v) => e.ORIG_SUPPLIER = v;
                        break;
                    case "CURR_SUPPLIER":
                        mapper[i] = (e, v) => e.CURR_SUPPLIER = v;
                        break;
                    case "ORIG_INVOICE_NO":
                        mapper[i] = (e, v) => e.ORIG_INVOICE_NO = v;
                        break;
                    case "LAST_INVOICE_NO":
                        mapper[i] = (e, v) => e.LAST_INVOICE_NO = v;
                        break;
                    case "PURDATE":
                        mapper[i] = (e, v) => e.PURDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_ADDN_DATE":
                        mapper[i] = (e, v) => e.LAST_ADDN_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_DISP_DATE":
                        mapper[i] = (e, v) => e.LAST_DISP_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_GST_RECLAIM":
                        mapper[i] = (e, v) => e.LAST_GST_RECLAIM = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_REVAL_DATE":
                        mapper[i] = (e, v) => e.LAST_REVAL_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PTE_GLCODE":
                        mapper[i] = (e, v) => e.PTE_GLCODE = v;
                        break;
                    case "PTE_USE_RATE":
                        mapper[i] = (e, v) => e.PTE_USE_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AOB_COST":
                        mapper[i] = (e, v) => e.AOB_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_REVALS":
                        mapper[i] = (e, v) => e.AOB_REVALS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_DISP_COST":
                        mapper[i] = (e, v) => e.AOB_DISP_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_DISP_REVALS":
                        mapper[i] = (e, v) => e.AOB_DISP_REVALS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_COST":
                        mapper[i] = (e, v) => e.ATY_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_REVALS":
                        mapper[i] = (e, v) => e.ATY_REVALS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_DISP_REVALS":
                        mapper[i] = (e, v) => e.ATY_DISP_REVALS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_DISP_COST":
                        mapper[i] = (e, v) => e.ATY_DISP_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_DEPN":
                        mapper[i] = (e, v) => e.AOB_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_PTE_DEPN":
                        mapper[i] = (e, v) => e.AOB_PTE_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_DISP_DEPN":
                        mapper[i] = (e, v) => e.AOB_DISP_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_DISP_PROF":
                        mapper[i] = (e, v) => e.AOB_DISP_PROF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_DEPN":
                        mapper[i] = (e, v) => e.ATY_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_PTE_DEPN":
                        mapper[i] = (e, v) => e.ATY_PTE_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_DISP_DEPN":
                        mapper[i] = (e, v) => e.ATY_DISP_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_DISP_PROF":
                        mapper[i] = (e, v) => e.ATY_DISP_PROF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ARATE":
                        mapper[i] = (e, v) => e.ARATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AMETHOD":
                        mapper[i] = (e, v) => e.AMETHOD = v;
                        break;
                    case "AEST_LIFE_UNITS":
                        mapper[i] = (e, v) => e.AEST_LIFE_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AUNITS_DESC":
                        mapper[i] = (e, v) => e.AUNITS_DESC = v;
                        break;
                    case "AUNITS_TO_DATE":
                        mapper[i] = (e, v) => e.AUNITS_TO_DATE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "AFLAG":
                        mapper[i] = (e, v) => e.AFLAG = v;
                        break;
                    case "ADEPN_START":
                        mapper[i] = (e, v) => e.ADEPN_START = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ADEPN_LAST_DATE":
                        mapper[i] = (e, v) => e.ADEPN_LAST_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "AOB_ORIG_GST":
                        mapper[i] = (e, v) => e.AOB_ORIG_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_UNCL_GST":
                        mapper[i] = (e, v) => e.AOB_UNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_DISP_UNCL_GST":
                        mapper[i] = (e, v) => e.AOB_DISP_UNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AOB_DISP_ORIG_GST":
                        mapper[i] = (e, v) => e.AOB_DISP_ORIG_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_ORIG_GST":
                        mapper[i] = (e, v) => e.ATY_ORIG_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_UNCL_GST":
                        mapper[i] = (e, v) => e.ATY_UNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_DISP_UNCL_GST":
                        mapper[i] = (e, v) => e.ATY_DISP_UNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ATY_DISP_ORIG_GST":
                        mapper[i] = (e, v) => e.ATY_DISP_ORIG_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_COST":
                        mapper[i] = (e, v) => e.TOB_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_DEPN":
                        mapper[i] = (e, v) => e.TOB_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_PTE_DEPN":
                        mapper[i] = (e, v) => e.TOB_PTE_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_DISP_COST":
                        mapper[i] = (e, v) => e.TOB_DISP_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_DISP_DEPN":
                        mapper[i] = (e, v) => e.TOB_DISP_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_DISP_PROF":
                        mapper[i] = (e, v) => e.TOB_DISP_PROF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_DISP_GAIN":
                        mapper[i] = (e, v) => e.TOB_DISP_GAIN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_COST":
                        mapper[i] = (e, v) => e.TTY_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_DEPN":
                        mapper[i] = (e, v) => e.TTY_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_PTE_DEPN":
                        mapper[i] = (e, v) => e.TTY_PTE_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_DISP_COST":
                        mapper[i] = (e, v) => e.TTY_DISP_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_DISP_DEPN":
                        mapper[i] = (e, v) => e.TTY_DISP_DEPN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_DISP_PROF":
                        mapper[i] = (e, v) => e.TTY_DISP_PROF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_DISP_GAIN":
                        mapper[i] = (e, v) => e.TTY_DISP_GAIN = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRATE":
                        mapper[i] = (e, v) => e.TRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TMETHOD":
                        mapper[i] = (e, v) => e.TMETHOD = v;
                        break;
                    case "TFLAG":
                        mapper[i] = (e, v) => e.TFLAG = v;
                        break;
                    case "TDEPN_START":
                        mapper[i] = (e, v) => e.TDEPN_START = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TDEPN_LAST_DATE":
                        mapper[i] = (e, v) => e.TDEPN_LAST_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TOB_ORIG_GST":
                        mapper[i] = (e, v) => e.TOB_ORIG_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_UNCL_GST":
                        mapper[i] = (e, v) => e.TOB_UNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_DISP_UNCL_GST":
                        mapper[i] = (e, v) => e.TOB_DISP_UNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TOB_DISP_ORIG_GST":
                        mapper[i] = (e, v) => e.TOB_DISP_ORIG_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_ORIG_GST":
                        mapper[i] = (e, v) => e.TTY_ORIG_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_UNCL_GST":
                        mapper[i] = (e, v) => e.TTY_UNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_DISP_UNCL_GST":
                        mapper[i] = (e, v) => e.TTY_DISP_UNCL_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TTY_DISP_ORIG_GST":
                        mapper[i] = (e, v) => e.TTY_DISP_ORIG_GST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OB_QTY":
                        mapper[i] = (e, v) => e.OB_QTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OB_DISP_QTY":
                        mapper[i] = (e, v) => e.OB_DISP_QTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TY_QTY":
                        mapper[i] = (e, v) => e.TY_QTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TY_DISP_QTY":
                        mapper[i] = (e, v) => e.TY_DISP_QTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OB_DISP_PROC":
                        mapper[i] = (e, v) => e.OB_DISP_PROC = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TY_DISP_PROC":
                        mapper[i] = (e, v) => e.TY_DISP_PROC = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LAST_ST_DATE":
                        mapper[i] = (e, v) => e.LAST_ST_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_SVC_DATE":
                        mapper[i] = (e, v) => e.LAST_SVC_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "NEXT_SVC_DATE":
                        mapper[i] = (e, v) => e.NEXT_SVC_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_SVC_DETAILS":
                        mapper[i] = (e, v) => e.LAST_SVC_DETAILS = v;
                        break;
                    case "OWNER":
                        mapper[i] = (e, v) => e.OWNER = v;
                        break;
                    case "EXPECTED_LIFE":
                        mapper[i] = (e, v) => e.EXPECTED_LIFE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WARRANTY":
                        mapper[i] = (e, v) => e.WARRANTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WARRANTYEXP":
                        mapper[i] = (e, v) => e.WARRANTYEXP = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SERIAL":
                        mapper[i] = (e, v) => e.SERIAL = v;
                        break;
                    case "CLEANING":
                        mapper[i] = (e, v) => e.CLEANING = v;
                        break;
                    case "HAZARD":
                        mapper[i] = (e, v) => e.HAZARD = v;
                        break;
                    case "SITE_REFERENCE":
                        mapper[i] = (e, v) => e.SITE_REFERENCE = v;
                        break;
                    case "EXTRA_DETAILS":
                        mapper[i] = (e, v) => e.EXTRA_DETAILS = v;
                        break;
                    case "COMPONENT_OF":
                        mapper[i] = (e, v) => e.COMPONENT_OF = v;
                        break;
                    case "ASSET_PIC":
                        mapper[i] = (e, v) => e.ASSET_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FAIR_MARKET":
                        mapper[i] = (e, v) => e.FAIR_MARKET = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AKR_DESC":
                        mapper[i] = (e, v) => e.AKR_DESC = v;
                        break;
                    case "ATTACHMENT":
                        mapper[i] = (e, v) => e.ATTACHMENT = null; // eduHub is not encoding byte arrays
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
        /// Merges <see cref="AR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AR}"/> of entities</returns>
        internal override IEnumerable<AR> ApplyDeltaEntities(IEnumerable<AR> Entities, List<AR> DeltaEntities)
        {
            HashSet<string> Index_ARKEY = new HashSet<string>(DeltaEntities.Select(i => i.ARKEY));
            HashSet<int> Index_ARNUMBER = new HashSet<int>(DeltaEntities.Select(i => i.ARNUMBER));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ARKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_ARKEY.Remove(entity.ARKEY);
                            overwritten = overwritten || Index_ARNUMBER.Remove(entity.ARNUMBER);
                            
                            if (entity.ARKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_AMETHOD;
        private Lazy<Dictionary<string, AR>> Index_ARKEY;
        private Lazy<Dictionary<int, AR>> Index_ARNUMBER;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_ASSET_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_BRANCH;
        private Lazy<NullDictionary<int?, IReadOnlyList<AR>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_COMPONENT_OF;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_CURR_SUPPLIER;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_DEPARTMENT;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_ORIG_SUPPLIER;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_PTE_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_RELEASE_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_TAX_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_TMETHOD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AR by AMETHOD field
        /// </summary>
        /// <param name="AMETHOD">AMETHOD value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByAMETHOD(string AMETHOD)
        {
            return Index_AMETHOD.Value[AMETHOD];
        }

        /// <summary>
        /// Attempt to find AR by AMETHOD field
        /// </summary>
        /// <param name="AMETHOD">AMETHOD value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAMETHOD(string AMETHOD, out IReadOnlyList<AR> Value)
        {
            return Index_AMETHOD.Value.TryGetValue(AMETHOD, out Value);
        }

        /// <summary>
        /// Attempt to find AR by AMETHOD field
        /// </summary>
        /// <param name="AMETHOD">AMETHOD value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByAMETHOD(string AMETHOD)
        {
            IReadOnlyList<AR> value;
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
        /// Find AR by ARKEY field
        /// </summary>
        /// <param name="ARKEY">ARKEY value used to find AR</param>
        /// <returns>Related AR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AR FindByARKEY(string ARKEY)
        {
            return Index_ARKEY.Value[ARKEY];
        }

        /// <summary>
        /// Attempt to find AR by ARKEY field
        /// </summary>
        /// <param name="ARKEY">ARKEY value used to find AR</param>
        /// <param name="Value">Related AR entity</param>
        /// <returns>True if the related AR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByARKEY(string ARKEY, out AR Value)
        {
            return Index_ARKEY.Value.TryGetValue(ARKEY, out Value);
        }

        /// <summary>
        /// Attempt to find AR by ARKEY field
        /// </summary>
        /// <param name="ARKEY">ARKEY value used to find AR</param>
        /// <returns>Related AR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AR TryFindByARKEY(string ARKEY)
        {
            AR value;
            if (Index_ARKEY.Value.TryGetValue(ARKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by ARNUMBER field
        /// </summary>
        /// <param name="ARNUMBER">ARNUMBER value used to find AR</param>
        /// <returns>Related AR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AR FindByARNUMBER(int ARNUMBER)
        {
            return Index_ARNUMBER.Value[ARNUMBER];
        }

        /// <summary>
        /// Attempt to find AR by ARNUMBER field
        /// </summary>
        /// <param name="ARNUMBER">ARNUMBER value used to find AR</param>
        /// <param name="Value">Related AR entity</param>
        /// <returns>True if the related AR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByARNUMBER(int ARNUMBER, out AR Value)
        {
            return Index_ARNUMBER.Value.TryGetValue(ARNUMBER, out Value);
        }

        /// <summary>
        /// Attempt to find AR by ARNUMBER field
        /// </summary>
        /// <param name="ARNUMBER">ARNUMBER value used to find AR</param>
        /// <returns>Related AR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AR TryFindByARNUMBER(int ARNUMBER)
        {
            AR value;
            if (Index_ARNUMBER.Value.TryGetValue(ARNUMBER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by ASSET_TYPE field
        /// </summary>
        /// <param name="ASSET_TYPE">ASSET_TYPE value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByASSET_TYPE(string ASSET_TYPE)
        {
            return Index_ASSET_TYPE.Value[ASSET_TYPE];
        }

        /// <summary>
        /// Attempt to find AR by ASSET_TYPE field
        /// </summary>
        /// <param name="ASSET_TYPE">ASSET_TYPE value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByASSET_TYPE(string ASSET_TYPE, out IReadOnlyList<AR> Value)
        {
            return Index_ASSET_TYPE.Value.TryGetValue(ASSET_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find AR by ASSET_TYPE field
        /// </summary>
        /// <param name="ASSET_TYPE">ASSET_TYPE value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByASSET_TYPE(string ASSET_TYPE)
        {
            IReadOnlyList<AR> value;
            if (Index_ASSET_TYPE.Value.TryGetValue(ASSET_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByBRANCH(string BRANCH)
        {
            return Index_BRANCH.Value[BRANCH];
        }

        /// <summary>
        /// Attempt to find AR by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBRANCH(string BRANCH, out IReadOnlyList<AR> Value)
        {
            return Index_BRANCH.Value.TryGetValue(BRANCH, out Value);
        }

        /// <summary>
        /// Attempt to find AR by BRANCH field
        /// </summary>
        /// <param name="BRANCH">BRANCH value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByBRANCH(string BRANCH)
        {
            IReadOnlyList<AR> value;
            if (Index_BRANCH.Value.TryGetValue(BRANCH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find AR by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<AR> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find AR by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<AR> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByCATEGORY(string CATEGORY)
        {
            return Index_CATEGORY.Value[CATEGORY];
        }

        /// <summary>
        /// Attempt to find AR by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCATEGORY(string CATEGORY, out IReadOnlyList<AR> Value)
        {
            return Index_CATEGORY.Value.TryGetValue(CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find AR by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByCATEGORY(string CATEGORY)
        {
            IReadOnlyList<AR> value;
            if (Index_CATEGORY.Value.TryGetValue(CATEGORY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by COMPONENT_OF field
        /// </summary>
        /// <param name="COMPONENT_OF">COMPONENT_OF value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByCOMPONENT_OF(string COMPONENT_OF)
        {
            return Index_COMPONENT_OF.Value[COMPONENT_OF];
        }

        /// <summary>
        /// Attempt to find AR by COMPONENT_OF field
        /// </summary>
        /// <param name="COMPONENT_OF">COMPONENT_OF value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPONENT_OF(string COMPONENT_OF, out IReadOnlyList<AR> Value)
        {
            return Index_COMPONENT_OF.Value.TryGetValue(COMPONENT_OF, out Value);
        }

        /// <summary>
        /// Attempt to find AR by COMPONENT_OF field
        /// </summary>
        /// <param name="COMPONENT_OF">COMPONENT_OF value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByCOMPONENT_OF(string COMPONENT_OF)
        {
            IReadOnlyList<AR> value;
            if (Index_COMPONENT_OF.Value.TryGetValue(COMPONENT_OF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by CURR_SUPPLIER field
        /// </summary>
        /// <param name="CURR_SUPPLIER">CURR_SUPPLIER value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByCURR_SUPPLIER(string CURR_SUPPLIER)
        {
            return Index_CURR_SUPPLIER.Value[CURR_SUPPLIER];
        }

        /// <summary>
        /// Attempt to find AR by CURR_SUPPLIER field
        /// </summary>
        /// <param name="CURR_SUPPLIER">CURR_SUPPLIER value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCURR_SUPPLIER(string CURR_SUPPLIER, out IReadOnlyList<AR> Value)
        {
            return Index_CURR_SUPPLIER.Value.TryGetValue(CURR_SUPPLIER, out Value);
        }

        /// <summary>
        /// Attempt to find AR by CURR_SUPPLIER field
        /// </summary>
        /// <param name="CURR_SUPPLIER">CURR_SUPPLIER value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByCURR_SUPPLIER(string CURR_SUPPLIER)
        {
            IReadOnlyList<AR> value;
            if (Index_CURR_SUPPLIER.Value.TryGetValue(CURR_SUPPLIER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByDEPARTMENT(string DEPARTMENT)
        {
            return Index_DEPARTMENT.Value[DEPARTMENT];
        }

        /// <summary>
        /// Attempt to find AR by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEPARTMENT(string DEPARTMENT, out IReadOnlyList<AR> Value)
        {
            return Index_DEPARTMENT.Value.TryGetValue(DEPARTMENT, out Value);
        }

        /// <summary>
        /// Attempt to find AR by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByDEPARTMENT(string DEPARTMENT)
        {
            IReadOnlyList<AR> value;
            if (Index_DEPARTMENT.Value.TryGetValue(DEPARTMENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find AR by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<AR> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find AR by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<AR> value;
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
        /// Find AR by ORIG_SUPPLIER field
        /// </summary>
        /// <param name="ORIG_SUPPLIER">ORIG_SUPPLIER value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByORIG_SUPPLIER(string ORIG_SUPPLIER)
        {
            return Index_ORIG_SUPPLIER.Value[ORIG_SUPPLIER];
        }

        /// <summary>
        /// Attempt to find AR by ORIG_SUPPLIER field
        /// </summary>
        /// <param name="ORIG_SUPPLIER">ORIG_SUPPLIER value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SUPPLIER(string ORIG_SUPPLIER, out IReadOnlyList<AR> Value)
        {
            return Index_ORIG_SUPPLIER.Value.TryGetValue(ORIG_SUPPLIER, out Value);
        }

        /// <summary>
        /// Attempt to find AR by ORIG_SUPPLIER field
        /// </summary>
        /// <param name="ORIG_SUPPLIER">ORIG_SUPPLIER value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByORIG_SUPPLIER(string ORIG_SUPPLIER)
        {
            IReadOnlyList<AR> value;
            if (Index_ORIG_SUPPLIER.Value.TryGetValue(ORIG_SUPPLIER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by PTE_GLCODE field
        /// </summary>
        /// <param name="PTE_GLCODE">PTE_GLCODE value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByPTE_GLCODE(string PTE_GLCODE)
        {
            return Index_PTE_GLCODE.Value[PTE_GLCODE];
        }

        /// <summary>
        /// Attempt to find AR by PTE_GLCODE field
        /// </summary>
        /// <param name="PTE_GLCODE">PTE_GLCODE value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPTE_GLCODE(string PTE_GLCODE, out IReadOnlyList<AR> Value)
        {
            return Index_PTE_GLCODE.Value.TryGetValue(PTE_GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find AR by PTE_GLCODE field
        /// </summary>
        /// <param name="PTE_GLCODE">PTE_GLCODE value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByPTE_GLCODE(string PTE_GLCODE)
        {
            IReadOnlyList<AR> value;
            if (Index_PTE_GLCODE.Value.TryGetValue(PTE_GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by RELEASE_TYPE field
        /// </summary>
        /// <param name="RELEASE_TYPE">RELEASE_TYPE value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByRELEASE_TYPE(string RELEASE_TYPE)
        {
            return Index_RELEASE_TYPE.Value[RELEASE_TYPE];
        }

        /// <summary>
        /// Attempt to find AR by RELEASE_TYPE field
        /// </summary>
        /// <param name="RELEASE_TYPE">RELEASE_TYPE value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRELEASE_TYPE(string RELEASE_TYPE, out IReadOnlyList<AR> Value)
        {
            return Index_RELEASE_TYPE.Value.TryGetValue(RELEASE_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find AR by RELEASE_TYPE field
        /// </summary>
        /// <param name="RELEASE_TYPE">RELEASE_TYPE value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByRELEASE_TYPE(string RELEASE_TYPE)
        {
            IReadOnlyList<AR> value;
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
        /// Find AR by TAX_CATEGORY field
        /// </summary>
        /// <param name="TAX_CATEGORY">TAX_CATEGORY value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByTAX_CATEGORY(string TAX_CATEGORY)
        {
            return Index_TAX_CATEGORY.Value[TAX_CATEGORY];
        }

        /// <summary>
        /// Attempt to find AR by TAX_CATEGORY field
        /// </summary>
        /// <param name="TAX_CATEGORY">TAX_CATEGORY value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTAX_CATEGORY(string TAX_CATEGORY, out IReadOnlyList<AR> Value)
        {
            return Index_TAX_CATEGORY.Value.TryGetValue(TAX_CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find AR by TAX_CATEGORY field
        /// </summary>
        /// <param name="TAX_CATEGORY">TAX_CATEGORY value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByTAX_CATEGORY(string TAX_CATEGORY)
        {
            IReadOnlyList<AR> value;
            if (Index_TAX_CATEGORY.Value.TryGetValue(TAX_CATEGORY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AR by TMETHOD field
        /// </summary>
        /// <param name="TMETHOD">TMETHOD value used to find AR</param>
        /// <returns>List of related AR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> FindByTMETHOD(string TMETHOD)
        {
            return Index_TMETHOD.Value[TMETHOD];
        }

        /// <summary>
        /// Attempt to find AR by TMETHOD field
        /// </summary>
        /// <param name="TMETHOD">TMETHOD value used to find AR</param>
        /// <param name="Value">List of related AR entities</param>
        /// <returns>True if the list of related AR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTMETHOD(string TMETHOD, out IReadOnlyList<AR> Value)
        {
            return Index_TMETHOD.Value.TryGetValue(TMETHOD, out Value);
        }

        /// <summary>
        /// Attempt to find AR by TMETHOD field
        /// </summary>
        /// <param name="TMETHOD">TMETHOD value used to find AR</param>
        /// <returns>List of related AR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AR> TryFindByTMETHOD(string TMETHOD)
        {
            IReadOnlyList<AR> value;
            if (Index_TMETHOD.Value.TryGetValue(TMETHOD, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AR](
        [ARKEY] varchar(10) NOT NULL,
        [ARNUMBER] int IDENTITY NOT NULL,
        [TITLE] varchar(40) NULL,
        [DESCRIPTION01] varchar(30) NULL,
        [DESCRIPTION02] varchar(30) NULL,
        [CATEGORY] varchar(10) NULL,
        [ASSET_TYPE] varchar(2) NULL,
        [RELEASE_TYPE] varchar(2) NULL,
        [TAX_CATEGORY] varchar(10) NULL,
        [LOCATION] varchar(10) NULL,
        [DEPARTMENT] varchar(10) NULL,
        [BRANCH] varchar(10) NULL,
        [LEASE_START_DATE] datetime NULL,
        [LEASE_END_DATE] datetime NULL,
        [LEASE_COST_MONTH] money NULL,
        [ORIG_SUPPLIER] varchar(10) NULL,
        [CURR_SUPPLIER] varchar(10) NULL,
        [ORIG_INVOICE_NO] varchar(10) NULL,
        [LAST_INVOICE_NO] varchar(10) NULL,
        [PURDATE] datetime NULL,
        [LAST_ADDN_DATE] datetime NULL,
        [LAST_DISP_DATE] datetime NULL,
        [LAST_GST_RECLAIM] datetime NULL,
        [LAST_REVAL_DATE] datetime NULL,
        [PTE_GLCODE] varchar(10) NULL,
        [PTE_USE_RATE] float NULL,
        [AOB_COST] money NULL,
        [AOB_REVALS] money NULL,
        [AOB_DISP_COST] money NULL,
        [AOB_DISP_REVALS] money NULL,
        [ATY_COST] money NULL,
        [ATY_REVALS] money NULL,
        [ATY_DISP_REVALS] money NULL,
        [ATY_DISP_COST] money NULL,
        [AOB_DEPN] money NULL,
        [AOB_PTE_DEPN] money NULL,
        [AOB_DISP_DEPN] money NULL,
        [AOB_DISP_PROF] money NULL,
        [ATY_DEPN] money NULL,
        [ATY_PTE_DEPN] money NULL,
        [ATY_DISP_DEPN] money NULL,
        [ATY_DISP_PROF] money NULL,
        [ARATE] float NULL,
        [AMETHOD] varchar(1) NULL,
        [AEST_LIFE_UNITS] int NULL,
        [AUNITS_DESC] varchar(30) NULL,
        [AUNITS_TO_DATE] int NULL,
        [AFLAG] varchar(1) NULL,
        [ADEPN_START] datetime NULL,
        [ADEPN_LAST_DATE] datetime NULL,
        [AOB_ORIG_GST] money NULL,
        [AOB_UNCL_GST] money NULL,
        [AOB_DISP_UNCL_GST] money NULL,
        [AOB_DISP_ORIG_GST] money NULL,
        [ATY_ORIG_GST] money NULL,
        [ATY_UNCL_GST] money NULL,
        [ATY_DISP_UNCL_GST] money NULL,
        [ATY_DISP_ORIG_GST] money NULL,
        [TOB_COST] money NULL,
        [TOB_DEPN] money NULL,
        [TOB_PTE_DEPN] money NULL,
        [TOB_DISP_COST] money NULL,
        [TOB_DISP_DEPN] money NULL,
        [TOB_DISP_PROF] money NULL,
        [TOB_DISP_GAIN] money NULL,
        [TTY_COST] money NULL,
        [TTY_DEPN] money NULL,
        [TTY_PTE_DEPN] money NULL,
        [TTY_DISP_COST] money NULL,
        [TTY_DISP_DEPN] money NULL,
        [TTY_DISP_PROF] money NULL,
        [TTY_DISP_GAIN] money NULL,
        [TRATE] float NULL,
        [TMETHOD] varchar(1) NULL,
        [TFLAG] varchar(1) NULL,
        [TDEPN_START] datetime NULL,
        [TDEPN_LAST_DATE] datetime NULL,
        [TOB_ORIG_GST] money NULL,
        [TOB_UNCL_GST] money NULL,
        [TOB_DISP_UNCL_GST] money NULL,
        [TOB_DISP_ORIG_GST] money NULL,
        [TTY_ORIG_GST] money NULL,
        [TTY_UNCL_GST] money NULL,
        [TTY_DISP_UNCL_GST] money NULL,
        [TTY_DISP_ORIG_GST] money NULL,
        [OB_QTY] smallint NULL,
        [OB_DISP_QTY] smallint NULL,
        [TY_QTY] smallint NULL,
        [TY_DISP_QTY] smallint NULL,
        [OB_DISP_PROC] money NULL,
        [TY_DISP_PROC] money NULL,
        [LAST_ST_DATE] datetime NULL,
        [LAST_SVC_DATE] datetime NULL,
        [NEXT_SVC_DATE] datetime NULL,
        [LAST_SVC_DETAILS] varchar(MAX) NULL,
        [OWNER] varchar(30) NULL,
        [EXPECTED_LIFE] smallint NULL,
        [WARRANTY] smallint NULL,
        [WARRANTYEXP] datetime NULL,
        [SERIAL] varchar(20) NULL,
        [CLEANING] varchar(MAX) NULL,
        [HAZARD] varchar(MAX) NULL,
        [SITE_REFERENCE] varchar(20) NULL,
        [EXTRA_DETAILS] varchar(MAX) NULL,
        [COMPONENT_OF] varchar(10) NULL,
        [ASSET_PIC] varbinary(MAX) NULL,
        [CAMPUS] int NULL,
        [FAIR_MARKET] money NULL,
        [AKR_DESC] varchar(40) NULL,
        [ATTACHMENT] varbinary(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AR_Index_ARKEY] PRIMARY KEY CLUSTERED (
            [ARKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [AR_Index_AMETHOD] ON [dbo].[AR]
    (
            [AMETHOD] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_ARNUMBER] ON [dbo].[AR]
    (
            [ARNUMBER] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_ASSET_TYPE] ON [dbo].[AR]
    (
            [ASSET_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_BRANCH] ON [dbo].[AR]
    (
            [BRANCH] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_CAMPUS] ON [dbo].[AR]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_CATEGORY] ON [dbo].[AR]
    (
            [CATEGORY] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_COMPONENT_OF] ON [dbo].[AR]
    (
            [COMPONENT_OF] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_CURR_SUPPLIER] ON [dbo].[AR]
    (
            [CURR_SUPPLIER] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_DEPARTMENT] ON [dbo].[AR]
    (
            [DEPARTMENT] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_LOCATION] ON [dbo].[AR]
    (
            [LOCATION] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_ORIG_SUPPLIER] ON [dbo].[AR]
    (
            [ORIG_SUPPLIER] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_PTE_GLCODE] ON [dbo].[AR]
    (
            [PTE_GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_RELEASE_TYPE] ON [dbo].[AR]
    (
            [RELEASE_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_TAX_CATEGORY] ON [dbo].[AR]
    (
            [TAX_CATEGORY] ASC
    );
    CREATE NONCLUSTERED INDEX [AR_Index_TMETHOD] ON [dbo].[AR]
    (
            [TMETHOD] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_AMETHOD')
    ALTER INDEX [AR_Index_AMETHOD] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_ARNUMBER')
    ALTER INDEX [AR_Index_ARNUMBER] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_ASSET_TYPE')
    ALTER INDEX [AR_Index_ASSET_TYPE] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_BRANCH')
    ALTER INDEX [AR_Index_BRANCH] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_CAMPUS')
    ALTER INDEX [AR_Index_CAMPUS] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_CATEGORY')
    ALTER INDEX [AR_Index_CATEGORY] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_COMPONENT_OF')
    ALTER INDEX [AR_Index_COMPONENT_OF] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_CURR_SUPPLIER')
    ALTER INDEX [AR_Index_CURR_SUPPLIER] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_DEPARTMENT')
    ALTER INDEX [AR_Index_DEPARTMENT] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_LOCATION')
    ALTER INDEX [AR_Index_LOCATION] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_ORIG_SUPPLIER')
    ALTER INDEX [AR_Index_ORIG_SUPPLIER] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_PTE_GLCODE')
    ALTER INDEX [AR_Index_PTE_GLCODE] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_RELEASE_TYPE')
    ALTER INDEX [AR_Index_RELEASE_TYPE] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_TAX_CATEGORY')
    ALTER INDEX [AR_Index_TAX_CATEGORY] ON [dbo].[AR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_TMETHOD')
    ALTER INDEX [AR_Index_TMETHOD] ON [dbo].[AR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_AMETHOD')
    ALTER INDEX [AR_Index_AMETHOD] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_ARNUMBER')
    ALTER INDEX [AR_Index_ARNUMBER] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_ASSET_TYPE')
    ALTER INDEX [AR_Index_ASSET_TYPE] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_BRANCH')
    ALTER INDEX [AR_Index_BRANCH] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_CAMPUS')
    ALTER INDEX [AR_Index_CAMPUS] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_CATEGORY')
    ALTER INDEX [AR_Index_CATEGORY] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_COMPONENT_OF')
    ALTER INDEX [AR_Index_COMPONENT_OF] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_CURR_SUPPLIER')
    ALTER INDEX [AR_Index_CURR_SUPPLIER] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_DEPARTMENT')
    ALTER INDEX [AR_Index_DEPARTMENT] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_LOCATION')
    ALTER INDEX [AR_Index_LOCATION] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_ORIG_SUPPLIER')
    ALTER INDEX [AR_Index_ORIG_SUPPLIER] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_PTE_GLCODE')
    ALTER INDEX [AR_Index_PTE_GLCODE] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_RELEASE_TYPE')
    ALTER INDEX [AR_Index_RELEASE_TYPE] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_TAX_CATEGORY')
    ALTER INDEX [AR_Index_TAX_CATEGORY] ON [dbo].[AR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AR]') AND name = N'AR_Index_TMETHOD')
    ALTER INDEX [AR_Index_TMETHOD] ON [dbo].[AR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_ARKEY = new List<string>();
            List<int> Index_ARNUMBER = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ARKEY.Add(entity.ARKEY);
                Index_ARNUMBER.Add(entity.ARNUMBER);
            }

            builder.AppendLine("DELETE [dbo].[AR] WHERE");


            // Index_ARKEY
            builder.Append("[ARKEY] IN (");
            for (int index = 0; index < Index_ARKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ARKEY
                var parameterARKEY = $"@p{parameterIndex++}";
                builder.Append(parameterARKEY);
                command.Parameters.Add(parameterARKEY, SqlDbType.VarChar, 10).Value = Index_ARKEY[index];
            }
            builder.AppendLine(") OR");

            // Index_ARNUMBER
            builder.Append("[ARNUMBER] IN (");
            for (int index = 0; index < Index_ARNUMBER.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ARNUMBER
                var parameterARNUMBER = $"@p{parameterIndex++}";
                builder.Append(parameterARNUMBER);
                command.Parameters.Add(parameterARNUMBER, SqlDbType.Int).Value = Index_ARNUMBER[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AR data set</returns>
        public override EduHubDataSetDataReader<AR> GetDataSetDataReader()
        {
            return new ARDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AR data set</returns>
        public override EduHubDataSetDataReader<AR> GetDataSetDataReader(List<AR> Entities)
        {
            return new ARDataReader(new EduHubDataSetLoadedReader<AR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class ARDataReader : EduHubDataSetDataReader<AR>
        {
            public ARDataReader(IEduHubDataSetReader<AR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 113; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ARKEY
                        return Current.ARKEY;
                    case 1: // ARNUMBER
                        return Current.ARNUMBER;
                    case 2: // TITLE
                        return Current.TITLE;
                    case 3: // DESCRIPTION01
                        return Current.DESCRIPTION01;
                    case 4: // DESCRIPTION02
                        return Current.DESCRIPTION02;
                    case 5: // CATEGORY
                        return Current.CATEGORY;
                    case 6: // ASSET_TYPE
                        return Current.ASSET_TYPE;
                    case 7: // RELEASE_TYPE
                        return Current.RELEASE_TYPE;
                    case 8: // TAX_CATEGORY
                        return Current.TAX_CATEGORY;
                    case 9: // LOCATION
                        return Current.LOCATION;
                    case 10: // DEPARTMENT
                        return Current.DEPARTMENT;
                    case 11: // BRANCH
                        return Current.BRANCH;
                    case 12: // LEASE_START_DATE
                        return Current.LEASE_START_DATE;
                    case 13: // LEASE_END_DATE
                        return Current.LEASE_END_DATE;
                    case 14: // LEASE_COST_MONTH
                        return Current.LEASE_COST_MONTH;
                    case 15: // ORIG_SUPPLIER
                        return Current.ORIG_SUPPLIER;
                    case 16: // CURR_SUPPLIER
                        return Current.CURR_SUPPLIER;
                    case 17: // ORIG_INVOICE_NO
                        return Current.ORIG_INVOICE_NO;
                    case 18: // LAST_INVOICE_NO
                        return Current.LAST_INVOICE_NO;
                    case 19: // PURDATE
                        return Current.PURDATE;
                    case 20: // LAST_ADDN_DATE
                        return Current.LAST_ADDN_DATE;
                    case 21: // LAST_DISP_DATE
                        return Current.LAST_DISP_DATE;
                    case 22: // LAST_GST_RECLAIM
                        return Current.LAST_GST_RECLAIM;
                    case 23: // LAST_REVAL_DATE
                        return Current.LAST_REVAL_DATE;
                    case 24: // PTE_GLCODE
                        return Current.PTE_GLCODE;
                    case 25: // PTE_USE_RATE
                        return Current.PTE_USE_RATE;
                    case 26: // AOB_COST
                        return Current.AOB_COST;
                    case 27: // AOB_REVALS
                        return Current.AOB_REVALS;
                    case 28: // AOB_DISP_COST
                        return Current.AOB_DISP_COST;
                    case 29: // AOB_DISP_REVALS
                        return Current.AOB_DISP_REVALS;
                    case 30: // ATY_COST
                        return Current.ATY_COST;
                    case 31: // ATY_REVALS
                        return Current.ATY_REVALS;
                    case 32: // ATY_DISP_REVALS
                        return Current.ATY_DISP_REVALS;
                    case 33: // ATY_DISP_COST
                        return Current.ATY_DISP_COST;
                    case 34: // AOB_DEPN
                        return Current.AOB_DEPN;
                    case 35: // AOB_PTE_DEPN
                        return Current.AOB_PTE_DEPN;
                    case 36: // AOB_DISP_DEPN
                        return Current.AOB_DISP_DEPN;
                    case 37: // AOB_DISP_PROF
                        return Current.AOB_DISP_PROF;
                    case 38: // ATY_DEPN
                        return Current.ATY_DEPN;
                    case 39: // ATY_PTE_DEPN
                        return Current.ATY_PTE_DEPN;
                    case 40: // ATY_DISP_DEPN
                        return Current.ATY_DISP_DEPN;
                    case 41: // ATY_DISP_PROF
                        return Current.ATY_DISP_PROF;
                    case 42: // ARATE
                        return Current.ARATE;
                    case 43: // AMETHOD
                        return Current.AMETHOD;
                    case 44: // AEST_LIFE_UNITS
                        return Current.AEST_LIFE_UNITS;
                    case 45: // AUNITS_DESC
                        return Current.AUNITS_DESC;
                    case 46: // AUNITS_TO_DATE
                        return Current.AUNITS_TO_DATE;
                    case 47: // AFLAG
                        return Current.AFLAG;
                    case 48: // ADEPN_START
                        return Current.ADEPN_START;
                    case 49: // ADEPN_LAST_DATE
                        return Current.ADEPN_LAST_DATE;
                    case 50: // AOB_ORIG_GST
                        return Current.AOB_ORIG_GST;
                    case 51: // AOB_UNCL_GST
                        return Current.AOB_UNCL_GST;
                    case 52: // AOB_DISP_UNCL_GST
                        return Current.AOB_DISP_UNCL_GST;
                    case 53: // AOB_DISP_ORIG_GST
                        return Current.AOB_DISP_ORIG_GST;
                    case 54: // ATY_ORIG_GST
                        return Current.ATY_ORIG_GST;
                    case 55: // ATY_UNCL_GST
                        return Current.ATY_UNCL_GST;
                    case 56: // ATY_DISP_UNCL_GST
                        return Current.ATY_DISP_UNCL_GST;
                    case 57: // ATY_DISP_ORIG_GST
                        return Current.ATY_DISP_ORIG_GST;
                    case 58: // TOB_COST
                        return Current.TOB_COST;
                    case 59: // TOB_DEPN
                        return Current.TOB_DEPN;
                    case 60: // TOB_PTE_DEPN
                        return Current.TOB_PTE_DEPN;
                    case 61: // TOB_DISP_COST
                        return Current.TOB_DISP_COST;
                    case 62: // TOB_DISP_DEPN
                        return Current.TOB_DISP_DEPN;
                    case 63: // TOB_DISP_PROF
                        return Current.TOB_DISP_PROF;
                    case 64: // TOB_DISP_GAIN
                        return Current.TOB_DISP_GAIN;
                    case 65: // TTY_COST
                        return Current.TTY_COST;
                    case 66: // TTY_DEPN
                        return Current.TTY_DEPN;
                    case 67: // TTY_PTE_DEPN
                        return Current.TTY_PTE_DEPN;
                    case 68: // TTY_DISP_COST
                        return Current.TTY_DISP_COST;
                    case 69: // TTY_DISP_DEPN
                        return Current.TTY_DISP_DEPN;
                    case 70: // TTY_DISP_PROF
                        return Current.TTY_DISP_PROF;
                    case 71: // TTY_DISP_GAIN
                        return Current.TTY_DISP_GAIN;
                    case 72: // TRATE
                        return Current.TRATE;
                    case 73: // TMETHOD
                        return Current.TMETHOD;
                    case 74: // TFLAG
                        return Current.TFLAG;
                    case 75: // TDEPN_START
                        return Current.TDEPN_START;
                    case 76: // TDEPN_LAST_DATE
                        return Current.TDEPN_LAST_DATE;
                    case 77: // TOB_ORIG_GST
                        return Current.TOB_ORIG_GST;
                    case 78: // TOB_UNCL_GST
                        return Current.TOB_UNCL_GST;
                    case 79: // TOB_DISP_UNCL_GST
                        return Current.TOB_DISP_UNCL_GST;
                    case 80: // TOB_DISP_ORIG_GST
                        return Current.TOB_DISP_ORIG_GST;
                    case 81: // TTY_ORIG_GST
                        return Current.TTY_ORIG_GST;
                    case 82: // TTY_UNCL_GST
                        return Current.TTY_UNCL_GST;
                    case 83: // TTY_DISP_UNCL_GST
                        return Current.TTY_DISP_UNCL_GST;
                    case 84: // TTY_DISP_ORIG_GST
                        return Current.TTY_DISP_ORIG_GST;
                    case 85: // OB_QTY
                        return Current.OB_QTY;
                    case 86: // OB_DISP_QTY
                        return Current.OB_DISP_QTY;
                    case 87: // TY_QTY
                        return Current.TY_QTY;
                    case 88: // TY_DISP_QTY
                        return Current.TY_DISP_QTY;
                    case 89: // OB_DISP_PROC
                        return Current.OB_DISP_PROC;
                    case 90: // TY_DISP_PROC
                        return Current.TY_DISP_PROC;
                    case 91: // LAST_ST_DATE
                        return Current.LAST_ST_DATE;
                    case 92: // LAST_SVC_DATE
                        return Current.LAST_SVC_DATE;
                    case 93: // NEXT_SVC_DATE
                        return Current.NEXT_SVC_DATE;
                    case 94: // LAST_SVC_DETAILS
                        return Current.LAST_SVC_DETAILS;
                    case 95: // OWNER
                        return Current.OWNER;
                    case 96: // EXPECTED_LIFE
                        return Current.EXPECTED_LIFE;
                    case 97: // WARRANTY
                        return Current.WARRANTY;
                    case 98: // WARRANTYEXP
                        return Current.WARRANTYEXP;
                    case 99: // SERIAL
                        return Current.SERIAL;
                    case 100: // CLEANING
                        return Current.CLEANING;
                    case 101: // HAZARD
                        return Current.HAZARD;
                    case 102: // SITE_REFERENCE
                        return Current.SITE_REFERENCE;
                    case 103: // EXTRA_DETAILS
                        return Current.EXTRA_DETAILS;
                    case 104: // COMPONENT_OF
                        return Current.COMPONENT_OF;
                    case 105: // ASSET_PIC
                        return Current.ASSET_PIC;
                    case 106: // CAMPUS
                        return Current.CAMPUS;
                    case 107: // FAIR_MARKET
                        return Current.FAIR_MARKET;
                    case 108: // AKR_DESC
                        return Current.AKR_DESC;
                    case 109: // ATTACHMENT
                        return Current.ATTACHMENT;
                    case 110: // LW_DATE
                        return Current.LW_DATE;
                    case 111: // LW_TIME
                        return Current.LW_TIME;
                    case 112: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TITLE
                        return Current.TITLE == null;
                    case 3: // DESCRIPTION01
                        return Current.DESCRIPTION01 == null;
                    case 4: // DESCRIPTION02
                        return Current.DESCRIPTION02 == null;
                    case 5: // CATEGORY
                        return Current.CATEGORY == null;
                    case 6: // ASSET_TYPE
                        return Current.ASSET_TYPE == null;
                    case 7: // RELEASE_TYPE
                        return Current.RELEASE_TYPE == null;
                    case 8: // TAX_CATEGORY
                        return Current.TAX_CATEGORY == null;
                    case 9: // LOCATION
                        return Current.LOCATION == null;
                    case 10: // DEPARTMENT
                        return Current.DEPARTMENT == null;
                    case 11: // BRANCH
                        return Current.BRANCH == null;
                    case 12: // LEASE_START_DATE
                        return Current.LEASE_START_DATE == null;
                    case 13: // LEASE_END_DATE
                        return Current.LEASE_END_DATE == null;
                    case 14: // LEASE_COST_MONTH
                        return Current.LEASE_COST_MONTH == null;
                    case 15: // ORIG_SUPPLIER
                        return Current.ORIG_SUPPLIER == null;
                    case 16: // CURR_SUPPLIER
                        return Current.CURR_SUPPLIER == null;
                    case 17: // ORIG_INVOICE_NO
                        return Current.ORIG_INVOICE_NO == null;
                    case 18: // LAST_INVOICE_NO
                        return Current.LAST_INVOICE_NO == null;
                    case 19: // PURDATE
                        return Current.PURDATE == null;
                    case 20: // LAST_ADDN_DATE
                        return Current.LAST_ADDN_DATE == null;
                    case 21: // LAST_DISP_DATE
                        return Current.LAST_DISP_DATE == null;
                    case 22: // LAST_GST_RECLAIM
                        return Current.LAST_GST_RECLAIM == null;
                    case 23: // LAST_REVAL_DATE
                        return Current.LAST_REVAL_DATE == null;
                    case 24: // PTE_GLCODE
                        return Current.PTE_GLCODE == null;
                    case 25: // PTE_USE_RATE
                        return Current.PTE_USE_RATE == null;
                    case 26: // AOB_COST
                        return Current.AOB_COST == null;
                    case 27: // AOB_REVALS
                        return Current.AOB_REVALS == null;
                    case 28: // AOB_DISP_COST
                        return Current.AOB_DISP_COST == null;
                    case 29: // AOB_DISP_REVALS
                        return Current.AOB_DISP_REVALS == null;
                    case 30: // ATY_COST
                        return Current.ATY_COST == null;
                    case 31: // ATY_REVALS
                        return Current.ATY_REVALS == null;
                    case 32: // ATY_DISP_REVALS
                        return Current.ATY_DISP_REVALS == null;
                    case 33: // ATY_DISP_COST
                        return Current.ATY_DISP_COST == null;
                    case 34: // AOB_DEPN
                        return Current.AOB_DEPN == null;
                    case 35: // AOB_PTE_DEPN
                        return Current.AOB_PTE_DEPN == null;
                    case 36: // AOB_DISP_DEPN
                        return Current.AOB_DISP_DEPN == null;
                    case 37: // AOB_DISP_PROF
                        return Current.AOB_DISP_PROF == null;
                    case 38: // ATY_DEPN
                        return Current.ATY_DEPN == null;
                    case 39: // ATY_PTE_DEPN
                        return Current.ATY_PTE_DEPN == null;
                    case 40: // ATY_DISP_DEPN
                        return Current.ATY_DISP_DEPN == null;
                    case 41: // ATY_DISP_PROF
                        return Current.ATY_DISP_PROF == null;
                    case 42: // ARATE
                        return Current.ARATE == null;
                    case 43: // AMETHOD
                        return Current.AMETHOD == null;
                    case 44: // AEST_LIFE_UNITS
                        return Current.AEST_LIFE_UNITS == null;
                    case 45: // AUNITS_DESC
                        return Current.AUNITS_DESC == null;
                    case 46: // AUNITS_TO_DATE
                        return Current.AUNITS_TO_DATE == null;
                    case 47: // AFLAG
                        return Current.AFLAG == null;
                    case 48: // ADEPN_START
                        return Current.ADEPN_START == null;
                    case 49: // ADEPN_LAST_DATE
                        return Current.ADEPN_LAST_DATE == null;
                    case 50: // AOB_ORIG_GST
                        return Current.AOB_ORIG_GST == null;
                    case 51: // AOB_UNCL_GST
                        return Current.AOB_UNCL_GST == null;
                    case 52: // AOB_DISP_UNCL_GST
                        return Current.AOB_DISP_UNCL_GST == null;
                    case 53: // AOB_DISP_ORIG_GST
                        return Current.AOB_DISP_ORIG_GST == null;
                    case 54: // ATY_ORIG_GST
                        return Current.ATY_ORIG_GST == null;
                    case 55: // ATY_UNCL_GST
                        return Current.ATY_UNCL_GST == null;
                    case 56: // ATY_DISP_UNCL_GST
                        return Current.ATY_DISP_UNCL_GST == null;
                    case 57: // ATY_DISP_ORIG_GST
                        return Current.ATY_DISP_ORIG_GST == null;
                    case 58: // TOB_COST
                        return Current.TOB_COST == null;
                    case 59: // TOB_DEPN
                        return Current.TOB_DEPN == null;
                    case 60: // TOB_PTE_DEPN
                        return Current.TOB_PTE_DEPN == null;
                    case 61: // TOB_DISP_COST
                        return Current.TOB_DISP_COST == null;
                    case 62: // TOB_DISP_DEPN
                        return Current.TOB_DISP_DEPN == null;
                    case 63: // TOB_DISP_PROF
                        return Current.TOB_DISP_PROF == null;
                    case 64: // TOB_DISP_GAIN
                        return Current.TOB_DISP_GAIN == null;
                    case 65: // TTY_COST
                        return Current.TTY_COST == null;
                    case 66: // TTY_DEPN
                        return Current.TTY_DEPN == null;
                    case 67: // TTY_PTE_DEPN
                        return Current.TTY_PTE_DEPN == null;
                    case 68: // TTY_DISP_COST
                        return Current.TTY_DISP_COST == null;
                    case 69: // TTY_DISP_DEPN
                        return Current.TTY_DISP_DEPN == null;
                    case 70: // TTY_DISP_PROF
                        return Current.TTY_DISP_PROF == null;
                    case 71: // TTY_DISP_GAIN
                        return Current.TTY_DISP_GAIN == null;
                    case 72: // TRATE
                        return Current.TRATE == null;
                    case 73: // TMETHOD
                        return Current.TMETHOD == null;
                    case 74: // TFLAG
                        return Current.TFLAG == null;
                    case 75: // TDEPN_START
                        return Current.TDEPN_START == null;
                    case 76: // TDEPN_LAST_DATE
                        return Current.TDEPN_LAST_DATE == null;
                    case 77: // TOB_ORIG_GST
                        return Current.TOB_ORIG_GST == null;
                    case 78: // TOB_UNCL_GST
                        return Current.TOB_UNCL_GST == null;
                    case 79: // TOB_DISP_UNCL_GST
                        return Current.TOB_DISP_UNCL_GST == null;
                    case 80: // TOB_DISP_ORIG_GST
                        return Current.TOB_DISP_ORIG_GST == null;
                    case 81: // TTY_ORIG_GST
                        return Current.TTY_ORIG_GST == null;
                    case 82: // TTY_UNCL_GST
                        return Current.TTY_UNCL_GST == null;
                    case 83: // TTY_DISP_UNCL_GST
                        return Current.TTY_DISP_UNCL_GST == null;
                    case 84: // TTY_DISP_ORIG_GST
                        return Current.TTY_DISP_ORIG_GST == null;
                    case 85: // OB_QTY
                        return Current.OB_QTY == null;
                    case 86: // OB_DISP_QTY
                        return Current.OB_DISP_QTY == null;
                    case 87: // TY_QTY
                        return Current.TY_QTY == null;
                    case 88: // TY_DISP_QTY
                        return Current.TY_DISP_QTY == null;
                    case 89: // OB_DISP_PROC
                        return Current.OB_DISP_PROC == null;
                    case 90: // TY_DISP_PROC
                        return Current.TY_DISP_PROC == null;
                    case 91: // LAST_ST_DATE
                        return Current.LAST_ST_DATE == null;
                    case 92: // LAST_SVC_DATE
                        return Current.LAST_SVC_DATE == null;
                    case 93: // NEXT_SVC_DATE
                        return Current.NEXT_SVC_DATE == null;
                    case 94: // LAST_SVC_DETAILS
                        return Current.LAST_SVC_DETAILS == null;
                    case 95: // OWNER
                        return Current.OWNER == null;
                    case 96: // EXPECTED_LIFE
                        return Current.EXPECTED_LIFE == null;
                    case 97: // WARRANTY
                        return Current.WARRANTY == null;
                    case 98: // WARRANTYEXP
                        return Current.WARRANTYEXP == null;
                    case 99: // SERIAL
                        return Current.SERIAL == null;
                    case 100: // CLEANING
                        return Current.CLEANING == null;
                    case 101: // HAZARD
                        return Current.HAZARD == null;
                    case 102: // SITE_REFERENCE
                        return Current.SITE_REFERENCE == null;
                    case 103: // EXTRA_DETAILS
                        return Current.EXTRA_DETAILS == null;
                    case 104: // COMPONENT_OF
                        return Current.COMPONENT_OF == null;
                    case 105: // ASSET_PIC
                        return Current.ASSET_PIC == null;
                    case 106: // CAMPUS
                        return Current.CAMPUS == null;
                    case 107: // FAIR_MARKET
                        return Current.FAIR_MARKET == null;
                    case 108: // AKR_DESC
                        return Current.AKR_DESC == null;
                    case 109: // ATTACHMENT
                        return Current.ATTACHMENT == null;
                    case 110: // LW_DATE
                        return Current.LW_DATE == null;
                    case 111: // LW_TIME
                        return Current.LW_TIME == null;
                    case 112: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ARKEY
                        return "ARKEY";
                    case 1: // ARNUMBER
                        return "ARNUMBER";
                    case 2: // TITLE
                        return "TITLE";
                    case 3: // DESCRIPTION01
                        return "DESCRIPTION01";
                    case 4: // DESCRIPTION02
                        return "DESCRIPTION02";
                    case 5: // CATEGORY
                        return "CATEGORY";
                    case 6: // ASSET_TYPE
                        return "ASSET_TYPE";
                    case 7: // RELEASE_TYPE
                        return "RELEASE_TYPE";
                    case 8: // TAX_CATEGORY
                        return "TAX_CATEGORY";
                    case 9: // LOCATION
                        return "LOCATION";
                    case 10: // DEPARTMENT
                        return "DEPARTMENT";
                    case 11: // BRANCH
                        return "BRANCH";
                    case 12: // LEASE_START_DATE
                        return "LEASE_START_DATE";
                    case 13: // LEASE_END_DATE
                        return "LEASE_END_DATE";
                    case 14: // LEASE_COST_MONTH
                        return "LEASE_COST_MONTH";
                    case 15: // ORIG_SUPPLIER
                        return "ORIG_SUPPLIER";
                    case 16: // CURR_SUPPLIER
                        return "CURR_SUPPLIER";
                    case 17: // ORIG_INVOICE_NO
                        return "ORIG_INVOICE_NO";
                    case 18: // LAST_INVOICE_NO
                        return "LAST_INVOICE_NO";
                    case 19: // PURDATE
                        return "PURDATE";
                    case 20: // LAST_ADDN_DATE
                        return "LAST_ADDN_DATE";
                    case 21: // LAST_DISP_DATE
                        return "LAST_DISP_DATE";
                    case 22: // LAST_GST_RECLAIM
                        return "LAST_GST_RECLAIM";
                    case 23: // LAST_REVAL_DATE
                        return "LAST_REVAL_DATE";
                    case 24: // PTE_GLCODE
                        return "PTE_GLCODE";
                    case 25: // PTE_USE_RATE
                        return "PTE_USE_RATE";
                    case 26: // AOB_COST
                        return "AOB_COST";
                    case 27: // AOB_REVALS
                        return "AOB_REVALS";
                    case 28: // AOB_DISP_COST
                        return "AOB_DISP_COST";
                    case 29: // AOB_DISP_REVALS
                        return "AOB_DISP_REVALS";
                    case 30: // ATY_COST
                        return "ATY_COST";
                    case 31: // ATY_REVALS
                        return "ATY_REVALS";
                    case 32: // ATY_DISP_REVALS
                        return "ATY_DISP_REVALS";
                    case 33: // ATY_DISP_COST
                        return "ATY_DISP_COST";
                    case 34: // AOB_DEPN
                        return "AOB_DEPN";
                    case 35: // AOB_PTE_DEPN
                        return "AOB_PTE_DEPN";
                    case 36: // AOB_DISP_DEPN
                        return "AOB_DISP_DEPN";
                    case 37: // AOB_DISP_PROF
                        return "AOB_DISP_PROF";
                    case 38: // ATY_DEPN
                        return "ATY_DEPN";
                    case 39: // ATY_PTE_DEPN
                        return "ATY_PTE_DEPN";
                    case 40: // ATY_DISP_DEPN
                        return "ATY_DISP_DEPN";
                    case 41: // ATY_DISP_PROF
                        return "ATY_DISP_PROF";
                    case 42: // ARATE
                        return "ARATE";
                    case 43: // AMETHOD
                        return "AMETHOD";
                    case 44: // AEST_LIFE_UNITS
                        return "AEST_LIFE_UNITS";
                    case 45: // AUNITS_DESC
                        return "AUNITS_DESC";
                    case 46: // AUNITS_TO_DATE
                        return "AUNITS_TO_DATE";
                    case 47: // AFLAG
                        return "AFLAG";
                    case 48: // ADEPN_START
                        return "ADEPN_START";
                    case 49: // ADEPN_LAST_DATE
                        return "ADEPN_LAST_DATE";
                    case 50: // AOB_ORIG_GST
                        return "AOB_ORIG_GST";
                    case 51: // AOB_UNCL_GST
                        return "AOB_UNCL_GST";
                    case 52: // AOB_DISP_UNCL_GST
                        return "AOB_DISP_UNCL_GST";
                    case 53: // AOB_DISP_ORIG_GST
                        return "AOB_DISP_ORIG_GST";
                    case 54: // ATY_ORIG_GST
                        return "ATY_ORIG_GST";
                    case 55: // ATY_UNCL_GST
                        return "ATY_UNCL_GST";
                    case 56: // ATY_DISP_UNCL_GST
                        return "ATY_DISP_UNCL_GST";
                    case 57: // ATY_DISP_ORIG_GST
                        return "ATY_DISP_ORIG_GST";
                    case 58: // TOB_COST
                        return "TOB_COST";
                    case 59: // TOB_DEPN
                        return "TOB_DEPN";
                    case 60: // TOB_PTE_DEPN
                        return "TOB_PTE_DEPN";
                    case 61: // TOB_DISP_COST
                        return "TOB_DISP_COST";
                    case 62: // TOB_DISP_DEPN
                        return "TOB_DISP_DEPN";
                    case 63: // TOB_DISP_PROF
                        return "TOB_DISP_PROF";
                    case 64: // TOB_DISP_GAIN
                        return "TOB_DISP_GAIN";
                    case 65: // TTY_COST
                        return "TTY_COST";
                    case 66: // TTY_DEPN
                        return "TTY_DEPN";
                    case 67: // TTY_PTE_DEPN
                        return "TTY_PTE_DEPN";
                    case 68: // TTY_DISP_COST
                        return "TTY_DISP_COST";
                    case 69: // TTY_DISP_DEPN
                        return "TTY_DISP_DEPN";
                    case 70: // TTY_DISP_PROF
                        return "TTY_DISP_PROF";
                    case 71: // TTY_DISP_GAIN
                        return "TTY_DISP_GAIN";
                    case 72: // TRATE
                        return "TRATE";
                    case 73: // TMETHOD
                        return "TMETHOD";
                    case 74: // TFLAG
                        return "TFLAG";
                    case 75: // TDEPN_START
                        return "TDEPN_START";
                    case 76: // TDEPN_LAST_DATE
                        return "TDEPN_LAST_DATE";
                    case 77: // TOB_ORIG_GST
                        return "TOB_ORIG_GST";
                    case 78: // TOB_UNCL_GST
                        return "TOB_UNCL_GST";
                    case 79: // TOB_DISP_UNCL_GST
                        return "TOB_DISP_UNCL_GST";
                    case 80: // TOB_DISP_ORIG_GST
                        return "TOB_DISP_ORIG_GST";
                    case 81: // TTY_ORIG_GST
                        return "TTY_ORIG_GST";
                    case 82: // TTY_UNCL_GST
                        return "TTY_UNCL_GST";
                    case 83: // TTY_DISP_UNCL_GST
                        return "TTY_DISP_UNCL_GST";
                    case 84: // TTY_DISP_ORIG_GST
                        return "TTY_DISP_ORIG_GST";
                    case 85: // OB_QTY
                        return "OB_QTY";
                    case 86: // OB_DISP_QTY
                        return "OB_DISP_QTY";
                    case 87: // TY_QTY
                        return "TY_QTY";
                    case 88: // TY_DISP_QTY
                        return "TY_DISP_QTY";
                    case 89: // OB_DISP_PROC
                        return "OB_DISP_PROC";
                    case 90: // TY_DISP_PROC
                        return "TY_DISP_PROC";
                    case 91: // LAST_ST_DATE
                        return "LAST_ST_DATE";
                    case 92: // LAST_SVC_DATE
                        return "LAST_SVC_DATE";
                    case 93: // NEXT_SVC_DATE
                        return "NEXT_SVC_DATE";
                    case 94: // LAST_SVC_DETAILS
                        return "LAST_SVC_DETAILS";
                    case 95: // OWNER
                        return "OWNER";
                    case 96: // EXPECTED_LIFE
                        return "EXPECTED_LIFE";
                    case 97: // WARRANTY
                        return "WARRANTY";
                    case 98: // WARRANTYEXP
                        return "WARRANTYEXP";
                    case 99: // SERIAL
                        return "SERIAL";
                    case 100: // CLEANING
                        return "CLEANING";
                    case 101: // HAZARD
                        return "HAZARD";
                    case 102: // SITE_REFERENCE
                        return "SITE_REFERENCE";
                    case 103: // EXTRA_DETAILS
                        return "EXTRA_DETAILS";
                    case 104: // COMPONENT_OF
                        return "COMPONENT_OF";
                    case 105: // ASSET_PIC
                        return "ASSET_PIC";
                    case 106: // CAMPUS
                        return "CAMPUS";
                    case 107: // FAIR_MARKET
                        return "FAIR_MARKET";
                    case 108: // AKR_DESC
                        return "AKR_DESC";
                    case 109: // ATTACHMENT
                        return "ATTACHMENT";
                    case 110: // LW_DATE
                        return "LW_DATE";
                    case 111: // LW_TIME
                        return "LW_TIME";
                    case 112: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ARKEY":
                        return 0;
                    case "ARNUMBER":
                        return 1;
                    case "TITLE":
                        return 2;
                    case "DESCRIPTION01":
                        return 3;
                    case "DESCRIPTION02":
                        return 4;
                    case "CATEGORY":
                        return 5;
                    case "ASSET_TYPE":
                        return 6;
                    case "RELEASE_TYPE":
                        return 7;
                    case "TAX_CATEGORY":
                        return 8;
                    case "LOCATION":
                        return 9;
                    case "DEPARTMENT":
                        return 10;
                    case "BRANCH":
                        return 11;
                    case "LEASE_START_DATE":
                        return 12;
                    case "LEASE_END_DATE":
                        return 13;
                    case "LEASE_COST_MONTH":
                        return 14;
                    case "ORIG_SUPPLIER":
                        return 15;
                    case "CURR_SUPPLIER":
                        return 16;
                    case "ORIG_INVOICE_NO":
                        return 17;
                    case "LAST_INVOICE_NO":
                        return 18;
                    case "PURDATE":
                        return 19;
                    case "LAST_ADDN_DATE":
                        return 20;
                    case "LAST_DISP_DATE":
                        return 21;
                    case "LAST_GST_RECLAIM":
                        return 22;
                    case "LAST_REVAL_DATE":
                        return 23;
                    case "PTE_GLCODE":
                        return 24;
                    case "PTE_USE_RATE":
                        return 25;
                    case "AOB_COST":
                        return 26;
                    case "AOB_REVALS":
                        return 27;
                    case "AOB_DISP_COST":
                        return 28;
                    case "AOB_DISP_REVALS":
                        return 29;
                    case "ATY_COST":
                        return 30;
                    case "ATY_REVALS":
                        return 31;
                    case "ATY_DISP_REVALS":
                        return 32;
                    case "ATY_DISP_COST":
                        return 33;
                    case "AOB_DEPN":
                        return 34;
                    case "AOB_PTE_DEPN":
                        return 35;
                    case "AOB_DISP_DEPN":
                        return 36;
                    case "AOB_DISP_PROF":
                        return 37;
                    case "ATY_DEPN":
                        return 38;
                    case "ATY_PTE_DEPN":
                        return 39;
                    case "ATY_DISP_DEPN":
                        return 40;
                    case "ATY_DISP_PROF":
                        return 41;
                    case "ARATE":
                        return 42;
                    case "AMETHOD":
                        return 43;
                    case "AEST_LIFE_UNITS":
                        return 44;
                    case "AUNITS_DESC":
                        return 45;
                    case "AUNITS_TO_DATE":
                        return 46;
                    case "AFLAG":
                        return 47;
                    case "ADEPN_START":
                        return 48;
                    case "ADEPN_LAST_DATE":
                        return 49;
                    case "AOB_ORIG_GST":
                        return 50;
                    case "AOB_UNCL_GST":
                        return 51;
                    case "AOB_DISP_UNCL_GST":
                        return 52;
                    case "AOB_DISP_ORIG_GST":
                        return 53;
                    case "ATY_ORIG_GST":
                        return 54;
                    case "ATY_UNCL_GST":
                        return 55;
                    case "ATY_DISP_UNCL_GST":
                        return 56;
                    case "ATY_DISP_ORIG_GST":
                        return 57;
                    case "TOB_COST":
                        return 58;
                    case "TOB_DEPN":
                        return 59;
                    case "TOB_PTE_DEPN":
                        return 60;
                    case "TOB_DISP_COST":
                        return 61;
                    case "TOB_DISP_DEPN":
                        return 62;
                    case "TOB_DISP_PROF":
                        return 63;
                    case "TOB_DISP_GAIN":
                        return 64;
                    case "TTY_COST":
                        return 65;
                    case "TTY_DEPN":
                        return 66;
                    case "TTY_PTE_DEPN":
                        return 67;
                    case "TTY_DISP_COST":
                        return 68;
                    case "TTY_DISP_DEPN":
                        return 69;
                    case "TTY_DISP_PROF":
                        return 70;
                    case "TTY_DISP_GAIN":
                        return 71;
                    case "TRATE":
                        return 72;
                    case "TMETHOD":
                        return 73;
                    case "TFLAG":
                        return 74;
                    case "TDEPN_START":
                        return 75;
                    case "TDEPN_LAST_DATE":
                        return 76;
                    case "TOB_ORIG_GST":
                        return 77;
                    case "TOB_UNCL_GST":
                        return 78;
                    case "TOB_DISP_UNCL_GST":
                        return 79;
                    case "TOB_DISP_ORIG_GST":
                        return 80;
                    case "TTY_ORIG_GST":
                        return 81;
                    case "TTY_UNCL_GST":
                        return 82;
                    case "TTY_DISP_UNCL_GST":
                        return 83;
                    case "TTY_DISP_ORIG_GST":
                        return 84;
                    case "OB_QTY":
                        return 85;
                    case "OB_DISP_QTY":
                        return 86;
                    case "TY_QTY":
                        return 87;
                    case "TY_DISP_QTY":
                        return 88;
                    case "OB_DISP_PROC":
                        return 89;
                    case "TY_DISP_PROC":
                        return 90;
                    case "LAST_ST_DATE":
                        return 91;
                    case "LAST_SVC_DATE":
                        return 92;
                    case "NEXT_SVC_DATE":
                        return 93;
                    case "LAST_SVC_DETAILS":
                        return 94;
                    case "OWNER":
                        return 95;
                    case "EXPECTED_LIFE":
                        return 96;
                    case "WARRANTY":
                        return 97;
                    case "WARRANTYEXP":
                        return 98;
                    case "SERIAL":
                        return 99;
                    case "CLEANING":
                        return 100;
                    case "HAZARD":
                        return 101;
                    case "SITE_REFERENCE":
                        return 102;
                    case "EXTRA_DETAILS":
                        return 103;
                    case "COMPONENT_OF":
                        return 104;
                    case "ASSET_PIC":
                        return 105;
                    case "CAMPUS":
                        return 106;
                    case "FAIR_MARKET":
                        return 107;
                    case "AKR_DESC":
                        return 108;
                    case "ATTACHMENT":
                        return 109;
                    case "LW_DATE":
                        return 110;
                    case "LW_TIME":
                        return 111;
                    case "LW_USER":
                        return 112;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
