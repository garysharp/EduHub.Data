using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Super LTD History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PESHDataSet : SetBase<PESH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PESH"; } }

        internal PESHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PESH>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PESH>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PESH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PESH" /> fields for each CSV column header</returns>
        protected override Action<PESH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PESH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AMOUNT_OPBAL":
                        mapper[i] = (e, v) => e.AMOUNT_OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AMOUNT_YTD":
                        mapper[i] = (e, v) => e.AMOUNT_YTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AMOUNT_LTD":
                        mapper[i] = (e, v) => e.AMOUNT_LTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH01":
                        mapper[i] = (e, v) => e.SUPER_MTH01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH02":
                        mapper[i] = (e, v) => e.SUPER_MTH02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH03":
                        mapper[i] = (e, v) => e.SUPER_MTH03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH04":
                        mapper[i] = (e, v) => e.SUPER_MTH04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH05":
                        mapper[i] = (e, v) => e.SUPER_MTH05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH06":
                        mapper[i] = (e, v) => e.SUPER_MTH06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH07":
                        mapper[i] = (e, v) => e.SUPER_MTH07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH08":
                        mapper[i] = (e, v) => e.SUPER_MTH08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH09":
                        mapper[i] = (e, v) => e.SUPER_MTH09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH10":
                        mapper[i] = (e, v) => e.SUPER_MTH10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH11":
                        mapper[i] = (e, v) => e.SUPER_MTH11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH12":
                        mapper[i] = (e, v) => e.SUPER_MTH12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV01":
                        mapper[i] = (e, v) => e.SUPER_PROV01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV02":
                        mapper[i] = (e, v) => e.SUPER_PROV02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV03":
                        mapper[i] = (e, v) => e.SUPER_PROV03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV04":
                        mapper[i] = (e, v) => e.SUPER_PROV04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV05":
                        mapper[i] = (e, v) => e.SUPER_PROV05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV06":
                        mapper[i] = (e, v) => e.SUPER_PROV06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV07":
                        mapper[i] = (e, v) => e.SUPER_PROV07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV08":
                        mapper[i] = (e, v) => e.SUPER_PROV08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV09":
                        mapper[i] = (e, v) => e.SUPER_PROV09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV10":
                        mapper[i] = (e, v) => e.SUPER_PROV10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV11":
                        mapper[i] = (e, v) => e.SUPER_PROV11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV12":
                        mapper[i] = (e, v) => e.SUPER_PROV12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PAID_YTD":
                        mapper[i] = (e, v) => e.SUPER_PAID_YTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PAID_TODATE":
                        mapper[i] = (e, v) => e.SUPER_PAID_TODATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUPER_UNPAID_LYR":
                        mapper[i] = (e, v) => e.SUPER_UNPAID_LYR = v == null ? (decimal?)null : decimal.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<PESH>>> Index_CODE;
        private Lazy<Dictionary<int, PESH>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PESH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESH</param>
        /// <returns>List of related PESH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESH> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PESH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESH</param>
        /// <param name="Value">List of related PESH entities</param>
        /// <returns>True if the list of related PESH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PESH> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PESH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESH</param>
        /// <returns>List of related PESH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESH> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PESH> value;
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
        /// Find PESH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESH</param>
        /// <returns>Related PESH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESH FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PESH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESH</param>
        /// <param name="Value">Related PESH entity</param>
        /// <returns>True if the related PESH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PESH Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PESH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESH</param>
        /// <returns>Related PESH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESH TryFindByTID(int TID)
        {
            PESH value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
