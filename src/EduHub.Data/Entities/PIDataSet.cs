using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Items Data Set
    /// </summary>
    public sealed class PIDataSet : SetBase<PI>
    {
        private Lazy<Dictionary<short, PI>> PIKEYIndex;

        internal PIDataSet(EduHubContext Context)
            : base(Context)
        {
            PIKEYIndex = new Lazy<Dictionary<short, PI>>(() => this.ToDictionary(e => e.PIKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PI"; } }

        /// <summary>
        /// Find PI by PIKEY key field
        /// </summary>
        /// <param name="Key">PIKEY value used to find PI</param>
        /// <returns>Related PI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PIKEY value didn't match any PI entities</exception>
        public PI FindByPIKEY(short Key)
        {
            PI result;
            if (PIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PI by PIKEY key field
        /// </summary>
        /// <param name="Key">PIKEY value used to find PI</param>
        /// <param name="Value">Related PI entity</param>
        /// <returns>True if the PI entity is found</returns>
        public bool TryFindByPIKEY(short Key, out PI Value)
        {
            return PIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PI by PIKEY key field
        /// </summary>
        /// <param name="Key">PIKEY value used to find PI</param>
        /// <returns>Related PI entity, or null if not found</returns>
        public PI TryFindByPIKEY(short Key)
        {
            PI result;
            if (PIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PI" /> fields for each CSV column header</returns>
        protected override Action<PI, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PIKEY":
                        mapper[i] = (e, v) => e.PIKEY = short.Parse(v);
                        break;
                    case "PAYCODE":
                        mapper[i] = (e, v) => e.PAYCODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "TAXABLE":
                        mapper[i] = (e, v) => e.TAXABLE = v;
                        break;
                    case "UNIT":
                        mapper[i] = (e, v) => e.UNIT = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "PAYG_BOX":
                        mapper[i] = (e, v) => e.PAYG_BOX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TAXRATE":
                        mapper[i] = (e, v) => e.TAXRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TAXFREE":
                        mapper[i] = (e, v) => e.TAXFREE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BASEITEM":
                        mapper[i] = (e, v) => e.BASEITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "BASELOAD":
                        mapper[i] = (e, v) => e.BASELOAD = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "BASETYPE":
                        mapper[i] = (e, v) => e.BASETYPE = v;
                        break;
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
                        break;
                    case "ACCRUED":
                        mapper[i] = (e, v) => e.ACCRUED = v;
                        break;
                    case "ACCRUE_ITEM01":
                        mapper[i] = (e, v) => e.ACCRUE_ITEM01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACCRUE_ITEM02":
                        mapper[i] = (e, v) => e.ACCRUE_ITEM02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACCRUE_ITEM03":
                        mapper[i] = (e, v) => e.ACCRUE_ITEM03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACCRUE_ITEM04":
                        mapper[i] = (e, v) => e.ACCRUE_ITEM04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACCRUE_RATEA01":
                        mapper[i] = (e, v) => e.ACCRUE_RATEA01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEA02":
                        mapper[i] = (e, v) => e.ACCRUE_RATEA02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEA03":
                        mapper[i] = (e, v) => e.ACCRUE_RATEA03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEA04":
                        mapper[i] = (e, v) => e.ACCRUE_RATEA04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEB01":
                        mapper[i] = (e, v) => e.ACCRUE_RATEB01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEB02":
                        mapper[i] = (e, v) => e.ACCRUE_RATEB02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEB03":
                        mapper[i] = (e, v) => e.ACCRUE_RATEB03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCRUE_RATEB04":
                        mapper[i] = (e, v) => e.ACCRUE_RATEB04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AUTOCALC":
                        mapper[i] = (e, v) => e.AUTOCALC = v;
                        break;
                    case "DHOURS":
                        mapper[i] = (e, v) => e.DHOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DRATE":
                        mapper[i] = (e, v) => e.DRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DPAY_YEAR":
                        mapper[i] = (e, v) => e.DPAY_YEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DPAY_QTY":
                        mapper[i] = (e, v) => e.DPAY_QTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DVALUE":
                        mapper[i] = (e, v) => e.DVALUE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_LEVY":
                        mapper[i] = (e, v) => e.SUPER_LEVY = v;
                        break;
                    case "PERS_SUPER":
                        mapper[i] = (e, v) => e.PERS_SUPER = v;
                        break;
                    case "PERS_SUPER_RATE":
                        mapper[i] = (e, v) => e.PERS_SUPER_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AFFECTS_LEAVE":
                        mapper[i] = (e, v) => e.AFFECTS_LEAVE = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "PERCENT_AFFECT":
                        mapper[i] = (e, v) => e.PERCENT_AFFECT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLR_GLCODE":
                        mapper[i] = (e, v) => e.CLR_GLCODE = v;
                        break;
                    case "SHORT_DESC":
                        mapper[i] = (e, v) => e.SHORT_DESC = v;
                        break;
                    case "LEAVELOAD_ITEM":
                        mapper[i] = (e, v) => e.LEAVELOAD_ITEM = v;
                        break;
                    case "LEAVE_BASEITEM":
                        mapper[i] = (e, v) => e.LEAVE_BASEITEM = v;
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
                    case "NORMAL_SPLIT":
                        mapper[i] = (e, v) => e.NORMAL_SPLIT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LPA_SPLIT":
                        mapper[i] = (e, v) => e.LPA_SPLIT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ANNUALISED_LOADING":
                        mapper[i] = (e, v) => e.ANNUALISED_LOADING = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
