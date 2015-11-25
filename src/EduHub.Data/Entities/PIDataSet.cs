using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Items Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PIDataSet : SetBase<PI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PI"; } }

        internal PIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AWARD = new Lazy<NullDictionary<string, IReadOnlyList<PI>>>(() => this.ToGroupedNullDictionary(i => i.AWARD));
            Index_BASEITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PI>>>(() => this.ToGroupedNullDictionary(i => i.BASEITEM));
            Index_CLR_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PI>>>(() => this.ToGroupedNullDictionary(i => i.CLR_GLCODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PI>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PAYG_BOX = new Lazy<NullDictionary<short?, IReadOnlyList<PI>>>(() => this.ToGroupedNullDictionary(i => i.PAYG_BOX));
            Index_PIKEY = new Lazy<Dictionary<short, PI>>(() => this.ToDictionary(i => i.PIKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PI>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PI" /> fields for each CSV column header</returns>
        protected override Action<PI, string>[] BuildMapper(IReadOnlyList<string> Headers)
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

        /// <summary>
        /// Merges <see cref="PI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PI" /> items to added or update the base <see cref="PI" /> items</param>
        /// <returns>A merged list of <see cref="PI" /> items</returns>
        protected override List<PI> ApplyDeltaItems(List<PI> Items, List<PI> DeltaItems)
        {
            Dictionary<short, int> Index_PIKEY = Items.ToIndexDictionary(i => i.PIKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PI deltaItem in DeltaItems)
            {
                int index;

                if (Index_PIKEY.TryGetValue(deltaItem.PIKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PI>>> Index_AWARD;
        private Lazy<NullDictionary<short?, IReadOnlyList<PI>>> Index_BASEITEM;
        private Lazy<NullDictionary<string, IReadOnlyList<PI>>> Index_CLR_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PI>>> Index_INITIATIVE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PI>>> Index_PAYG_BOX;
        private Lazy<Dictionary<short, PI>> Index_PIKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PI>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PI by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find PI</param>
        /// <returns>List of related PI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> FindByAWARD(string AWARD)
        {
            return Index_AWARD.Value[AWARD];
        }

        /// <summary>
        /// Attempt to find PI by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find PI</param>
        /// <param name="Value">List of related PI entities</param>
        /// <returns>True if the list of related PI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAWARD(string AWARD, out IReadOnlyList<PI> Value)
        {
            return Index_AWARD.Value.TryGetValue(AWARD, out Value);
        }

        /// <summary>
        /// Attempt to find PI by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find PI</param>
        /// <returns>List of related PI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> TryFindByAWARD(string AWARD)
        {
            IReadOnlyList<PI> value;
            if (Index_AWARD.Value.TryGetValue(AWARD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PI by BASEITEM field
        /// </summary>
        /// <param name="BASEITEM">BASEITEM value used to find PI</param>
        /// <returns>List of related PI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> FindByBASEITEM(short? BASEITEM)
        {
            return Index_BASEITEM.Value[BASEITEM];
        }

        /// <summary>
        /// Attempt to find PI by BASEITEM field
        /// </summary>
        /// <param name="BASEITEM">BASEITEM value used to find PI</param>
        /// <param name="Value">List of related PI entities</param>
        /// <returns>True if the list of related PI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBASEITEM(short? BASEITEM, out IReadOnlyList<PI> Value)
        {
            return Index_BASEITEM.Value.TryGetValue(BASEITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PI by BASEITEM field
        /// </summary>
        /// <param name="BASEITEM">BASEITEM value used to find PI</param>
        /// <returns>List of related PI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> TryFindByBASEITEM(short? BASEITEM)
        {
            IReadOnlyList<PI> value;
            if (Index_BASEITEM.Value.TryGetValue(BASEITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PI by CLR_GLCODE field
        /// </summary>
        /// <param name="CLR_GLCODE">CLR_GLCODE value used to find PI</param>
        /// <returns>List of related PI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> FindByCLR_GLCODE(string CLR_GLCODE)
        {
            return Index_CLR_GLCODE.Value[CLR_GLCODE];
        }

        /// <summary>
        /// Attempt to find PI by CLR_GLCODE field
        /// </summary>
        /// <param name="CLR_GLCODE">CLR_GLCODE value used to find PI</param>
        /// <param name="Value">List of related PI entities</param>
        /// <returns>True if the list of related PI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCLR_GLCODE(string CLR_GLCODE, out IReadOnlyList<PI> Value)
        {
            return Index_CLR_GLCODE.Value.TryGetValue(CLR_GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PI by CLR_GLCODE field
        /// </summary>
        /// <param name="CLR_GLCODE">CLR_GLCODE value used to find PI</param>
        /// <returns>List of related PI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> TryFindByCLR_GLCODE(string CLR_GLCODE)
        {
            IReadOnlyList<PI> value;
            if (Index_CLR_GLCODE.Value.TryGetValue(CLR_GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PI by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PI</param>
        /// <returns>List of related PI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PI by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PI</param>
        /// <param name="Value">List of related PI entities</param>
        /// <returns>True if the list of related PI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PI> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PI by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PI</param>
        /// <returns>List of related PI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PI> value;
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
        /// Find PI by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PI</param>
        /// <returns>List of related PI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> FindByPAYG_BOX(short? PAYG_BOX)
        {
            return Index_PAYG_BOX.Value[PAYG_BOX];
        }

        /// <summary>
        /// Attempt to find PI by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PI</param>
        /// <param name="Value">List of related PI entities</param>
        /// <returns>True if the list of related PI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYG_BOX(short? PAYG_BOX, out IReadOnlyList<PI> Value)
        {
            return Index_PAYG_BOX.Value.TryGetValue(PAYG_BOX, out Value);
        }

        /// <summary>
        /// Attempt to find PI by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PI</param>
        /// <returns>List of related PI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> TryFindByPAYG_BOX(short? PAYG_BOX)
        {
            IReadOnlyList<PI> value;
            if (Index_PAYG_BOX.Value.TryGetValue(PAYG_BOX, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PI</param>
        /// <returns>Related PI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PI FindByPIKEY(short PIKEY)
        {
            return Index_PIKEY.Value[PIKEY];
        }

        /// <summary>
        /// Attempt to find PI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PI</param>
        /// <param name="Value">Related PI entity</param>
        /// <returns>True if the related PI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPIKEY(short PIKEY, out PI Value)
        {
            return Index_PIKEY.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PI</param>
        /// <returns>Related PI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PI TryFindByPIKEY(short PIKEY)
        {
            PI value;
            if (Index_PIKEY.Value.TryGetValue(PIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PI by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PI</param>
        /// <returns>List of related PI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PI by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PI</param>
        /// <param name="Value">List of related PI entities</param>
        /// <returns>True if the list of related PI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PI> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PI by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PI</param>
        /// <returns>List of related PI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PI> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PI> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
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
