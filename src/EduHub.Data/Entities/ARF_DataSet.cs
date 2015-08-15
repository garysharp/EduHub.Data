using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Financial Transactions Data Set
    /// </summary>
    public sealed class ARF_DataSet : SetBase<ARF_Entity>
    {
        private Lazy<Dictionary<string, ARF_Entity>> TRREF_Index;

        internal ARF_DataSet(EduHubContext Context)
            : base(Context)
        {
            TRREF_Index = new Lazy<Dictionary<string, ARF_Entity>>(() => this.ToDictionary(e => e.TRREF));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "ARF"; } }

        /// <summary>
        /// Find ARF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find ARF</param>
        /// <returns>Related ARF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TRREF value didn't match any ARF entities</exception>
        public ARF_Entity FindByTRREF(string Key)
        {
            ARF_Entity result;
            if (TRREF_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find ARF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find ARF</param>
        /// <param name="Value">Related ARF entity</param>
        /// <returns>True if the ARF Entity is found</returns>
        public bool TryFindByTRREF(string Key, out ARF_Entity Value)
        {
            return TRREF_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find ARF by TRREF key field
        /// </summary>
        /// <param name="Key">TRREF value used to find ARF</param>
        /// <returns>Related ARF entity, or null if not found</returns>
        public ARF_Entity TryFindByTRREF(string Key)
        {
            ARF_Entity result;
            if (TRREF_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<ARF_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<ARF_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
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
    }
}
