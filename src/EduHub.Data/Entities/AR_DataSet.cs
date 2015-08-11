using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets Data Set
    /// </summary>
    public sealed class AR_DataSet : SetBase<AR_Entity>
    {
        internal AR_DataSet(EduHubContext Context)
            : base(Context)
        {
            ARKEY_Index = new Lazy<Dictionary<string, AR_Entity>>(() => this.ToDictionary(e => e.ARKEY));
        }

        public override string SetName { get { return "AR"; } }

        private Lazy<Dictionary<string, AR_Entity>> ARKEY_Index;

        public AR_Entity FindByARKEY(string Key)
        {
            AR_Entity result;
            if (ARKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByARKEY(string Key, out AR_Entity Value)
        {
            return ARKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public AR_Entity TryFindByARKEY(string Key)
        {
            AR_Entity result;
            if (ARKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<AR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<AR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ARKEY":
                        mapper[i] = (e, v) => e.ARKEY = v;
                        break;
                    case "ARNUMBER":
                        mapper[i] = (e, v) => e.ARNUMBER = v == null ? (int?)null : int.Parse(v);
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
    }
}
