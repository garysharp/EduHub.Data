using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ARDataSet : SetBase<AR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AR"; } }

        internal ARDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ARKEY = new Lazy<Dictionary<string, AR>>(() => this.ToDictionary(i => i.ARKEY));
            Index_CATEGORY = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.CATEGORY));
            Index_ASSET_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.ASSET_TYPE));
            Index_RELEASE_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.RELEASE_TYPE));
            Index_TAX_CATEGORY = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.TAX_CATEGORY));
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_DEPARTMENT = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.DEPARTMENT));
            Index_BRANCH = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.BRANCH));
            Index_ORIG_SUPPLIER = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.ORIG_SUPPLIER));
            Index_CURR_SUPPLIER = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.CURR_SUPPLIER));
            Index_PTE_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.PTE_GLCODE));
            Index_AMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.AMETHOD));
            Index_TMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.TMETHOD));
            Index_COMPONENT_OF = new Lazy<NullDictionary<string, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.COMPONENT_OF));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<AR>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AR" /> fields for each CSV column header</returns>
        protected override Action<AR, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.LEASE_START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LEASE_END_DATE":
                        mapper[i] = (e, v) => e.LEASE_END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.PURDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_ADDN_DATE":
                        mapper[i] = (e, v) => e.LAST_ADDN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_DISP_DATE":
                        mapper[i] = (e, v) => e.LAST_DISP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_GST_RECLAIM":
                        mapper[i] = (e, v) => e.LAST_GST_RECLAIM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_REVAL_DATE":
                        mapper[i] = (e, v) => e.LAST_REVAL_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.ADEPN_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ADEPN_LAST_DATE":
                        mapper[i] = (e, v) => e.ADEPN_LAST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.TDEPN_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TDEPN_LAST_DATE":
                        mapper[i] = (e, v) => e.TDEPN_LAST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.LAST_ST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_SVC_DATE":
                        mapper[i] = (e, v) => e.LAST_SVC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NEXT_SVC_DATE":
                        mapper[i] = (e, v) => e.NEXT_SVC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.WARRANTYEXP = v == null ? (DateTime?)null : DateTime.Parse(v);
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

        private Lazy<Dictionary<string, AR>> Index_ARKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_ASSET_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_RELEASE_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_TAX_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_DEPARTMENT;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_BRANCH;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_ORIG_SUPPLIER;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_CURR_SUPPLIER;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_PTE_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_AMETHOD;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_TMETHOD;
        private Lazy<NullDictionary<string, IReadOnlyList<AR>>> Index_COMPONENT_OF;
        private Lazy<NullDictionary<int?, IReadOnlyList<AR>>> Index_CAMPUS;

        #endregion

        #region Index Methods

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

        #endregion

    }
}
