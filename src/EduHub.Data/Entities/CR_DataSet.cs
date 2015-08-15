using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Payable Data Set
    /// </summary>
    public sealed class CR_DataSet : SetBase<CR_Entity>
    {
        private Lazy<Dictionary<string, CR_Entity>> CRKEY_Index;

        internal CR_DataSet(EduHubContext Context)
            : base(Context)
        {
            CRKEY_Index = new Lazy<Dictionary<string, CR_Entity>>(() => this.ToDictionary(e => e.CRKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "CR"; } }

        /// <summary>
        /// Find CR by CRKEY key field
        /// </summary>
        /// <param name="Key">CRKEY value used to find CR</param>
        /// <returns>Related CR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">CRKEY value didn't match any CR entities</exception>
        public CR_Entity FindByCRKEY(string Key)
        {
            CR_Entity result;
            if (CRKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find CR by CRKEY key field
        /// </summary>
        /// <param name="Key">CRKEY value used to find CR</param>
        /// <param name="Value">Related CR entity</param>
        /// <returns>True if the CR Entity is found</returns>
        public bool TryFindByCRKEY(string Key, out CR_Entity Value)
        {
            return CRKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find CR by CRKEY key field
        /// </summary>
        /// <param name="Key">CRKEY value used to find CR</param>
        /// <returns>Related CR entity, or null if not found</returns>
        public CR_Entity TryFindByCRKEY(string Key)
        {
            CR_Entity result;
            if (CRKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<CR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<CR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MTDPURCH":
                        mapper[i] = (e, v) => e.MTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "YTDPURCH":
                        mapper[i] = (e, v) => e.YTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED01":
                        mapper[i] = (e, v) => e.AGED01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED02":
                        mapper[i] = (e, v) => e.AGED02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED03":
                        mapper[i] = (e, v) => e.AGED03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED04":
                        mapper[i] = (e, v) => e.AGED04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED05":
                        mapper[i] = (e, v) => e.AGED05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRLIMIT":
                        mapper[i] = (e, v) => e.CRLIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LASTPAY":
                        mapper[i] = (e, v) => e.LASTPAY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERMS":
                        mapper[i] = (e, v) => e.TERMS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DISCOUNT":
                        mapper[i] = (e, v) => e.DISCOUNT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "CR_EMAIL":
                        mapper[i] = (e, v) => e.CR_EMAIL = v;
                        break;
                    case "EMAIL_FOR_PAYMENTS":
                        mapper[i] = (e, v) => e.EMAIL_FOR_PAYMENTS = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "COMMITMENT":
                        mapper[i] = (e, v) => e.COMMITMENT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STOP_FLAG":
                        mapper[i] = (e, v) => e.STOP_FLAG = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "PAYG_RATE":
                        mapper[i] = (e, v) => e.PAYG_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.ACCOUNT_NAME = v;
                        break;
                    case "LODGE_REF":
                        mapper[i] = (e, v) => e.LODGE_REF = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "PAYG_BIRTHDATE":
                        mapper[i] = (e, v) => e.PAYG_BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_STARTDATE":
                        mapper[i] = (e, v) => e.PAYG_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_TERMDATE":
                        mapper[i] = (e, v) => e.PAYG_TERMDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_ADDRESS01":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS01 = v;
                        break;
                    case "PAYG_ADDRESS02":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS02 = v;
                        break;
                    case "PAYG_SUBURB":
                        mapper[i] = (e, v) => e.PAYG_SUBURB = v;
                        break;
                    case "PAYG_STATE":
                        mapper[i] = (e, v) => e.PAYG_STATE = v;
                        break;
                    case "PAYG_POST":
                        mapper[i] = (e, v) => e.PAYG_POST = v;
                        break;
                    case "PAYG_COUNTRY":
                        mapper[i] = (e, v) => e.PAYG_COUNTRY = v;
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PRMS_FLAG":
                        mapper[i] = (e, v) => e.PRMS_FLAG = v;
                        break;
                    case "LW_PRMSINFO_DATE":
                        mapper[i] = (e, v) => e.LW_PRMSINFO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
