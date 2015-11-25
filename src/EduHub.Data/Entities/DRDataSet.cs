using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Receivable Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DRDataSet : SetBase<DR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "DR"; } }

        internal DRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DRKEY = new Lazy<Dictionary<string, DR>>(() => this.ToDictionary(i => i.DRKEY));
            Index_DRTABLEA = new Lazy<NullDictionary<string, IReadOnlyList<DR>>>(() => this.ToGroupedNullDictionary(i => i.DRTABLEA));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DR" /> fields for each CSV column header</returns>
        protected override Action<DR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DRKEY":
                        mapper[i] = (e, v) => e.DRKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHARGES":
                        mapper[i] = (e, v) => e.CHARGES = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHARGES_YTD":
                        mapper[i] = (e, v) => e.CHARGES_YTD = v == null ? (decimal?)null : decimal.Parse(v);
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
                    case "LASTREC":
                        mapper[i] = (e, v) => e.LASTREC = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTRECDATE":
                        mapper[i] = (e, v) => e.LASTRECDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "DRTYPE":
                        mapper[i] = (e, v) => e.DRTYPE = v;
                        break;
                    case "DRTABLEA":
                        mapper[i] = (e, v) => e.DRTABLEA = v;
                        break;
                    case "BUSNAME":
                        mapper[i] = (e, v) => e.BUSNAME = v;
                        break;
                    case "BUSADD01":
                        mapper[i] = (e, v) => e.BUSADD01 = v;
                        break;
                    case "BUSADD02":
                        mapper[i] = (e, v) => e.BUSADD02 = v;
                        break;
                    case "BUSSTATE":
                        mapper[i] = (e, v) => e.BUSSTATE = v;
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
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "BILLING_EMAIL":
                        mapper[i] = (e, v) => e.BILLING_EMAIL = v;
                        break;
                    case "MAILNAME":
                        mapper[i] = (e, v) => e.MAILNAME = v;
                        break;
                    case "MAILADD01":
                        mapper[i] = (e, v) => e.MAILADD01 = v;
                        break;
                    case "MAILADD02":
                        mapper[i] = (e, v) => e.MAILADD02 = v;
                        break;
                    case "MAILSTATE":
                        mapper[i] = (e, v) => e.MAILSTATE = v;
                        break;
                    case "MAILPOST":
                        mapper[i] = (e, v) => e.MAILPOST = v;
                        break;
                    case "DELNAME":
                        mapper[i] = (e, v) => e.DELNAME = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "DELIVPOST":
                        mapper[i] = (e, v) => e.DELIVPOST = v;
                        break;
                    case "REMARK":
                        mapper[i] = (e, v) => e.REMARK = v;
                        break;
                    case "PRICELEVEL":
                        mapper[i] = (e, v) => e.PRICELEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MEMO_FLAG":
                        mapper[i] = (e, v) => e.MEMO_FLAG = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "DRSHORT":
                        mapper[i] = (e, v) => e.DRSHORT = v;
                        break;
                    case "CSR":
                        mapper[i] = (e, v) => e.CSR = v;
                        break;
                    case "DRGROUP":
                        mapper[i] = (e, v) => e.DRGROUP = v;
                        break;
                    case "COMMENCE":
                        mapper[i] = (e, v) => e.COMMENCE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DRFCOUNT":
                        mapper[i] = (e, v) => e.DRFCOUNT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TAX_INVOICE":
                        mapper[i] = (e, v) => e.TAX_INVOICE = v;
                        break;
                    case "BPAY_SEQUENCE":
                        mapper[i] = (e, v) => e.BPAY_SEQUENCE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
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

        private Lazy<Dictionary<string, DR>> Index_DRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<DR>>> Index_DRTABLEA;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <returns>Related DR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DR FindByDRKEY(string DRKEY)
        {
            return Index_DRKEY.Value[DRKEY];
        }

        /// <summary>
        /// Attempt to find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <param name="Value">Related DR entity</param>
        /// <returns>True if the related DR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDRKEY(string DRKEY, out DR Value)
        {
            return Index_DRKEY.Value.TryGetValue(DRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DR by DRKEY field
        /// </summary>
        /// <param name="DRKEY">DRKEY value used to find DR</param>
        /// <returns>Related DR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DR TryFindByDRKEY(string DRKEY)
        {
            DR value;
            if (Index_DRKEY.Value.TryGetValue(DRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <returns>List of related DR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> FindByDRTABLEA(string DRTABLEA)
        {
            return Index_DRTABLEA.Value[DRTABLEA];
        }

        /// <summary>
        /// Attempt to find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <param name="Value">List of related DR entities</param>
        /// <returns>True if the list of related DR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDRTABLEA(string DRTABLEA, out IReadOnlyList<DR> Value)
        {
            return Index_DRTABLEA.Value.TryGetValue(DRTABLEA, out Value);
        }

        /// <summary>
        /// Attempt to find DR by DRTABLEA field
        /// </summary>
        /// <param name="DRTABLEA">DRTABLEA value used to find DR</param>
        /// <returns>List of related DR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DR> TryFindByDRTABLEA(string DRTABLEA)
        {
            IReadOnlyList<DR> value;
            if (Index_DRTABLEA.Value.TryGetValue(DRTABLEA, out value))
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
