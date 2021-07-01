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
    /// Pay Items Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PIDataSet : EduHubDataSet<PI>
    {
        /// <inheritdoc />
        public override string Name { get { return "PI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

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
        internal override Action<PI, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
        /// Merges <see cref="PI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PI}"/> of entities</returns>
        internal override IEnumerable<PI> ApplyDeltaEntities(IEnumerable<PI> Entities, List<PI> DeltaEntities)
        {
            HashSet<short> Index_PIKEY = new HashSet<short>(DeltaEntities.Select(i => i.PIKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PIKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PIKEY.Remove(entity.PIKEY);
                            
                            if (entity.PIKEY.CompareTo(deltaClusteredKey) <= 0)
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

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PI](
        [PIKEY] smallint NOT NULL,
        [PAYCODE] smallint NULL,
        [DESCRIPTION] varchar(30) NULL,
        [TRANSTYPE] varchar(1) NULL,
        [TAXABLE] varchar(1) NULL,
        [UNIT] varchar(3) NULL,
        [CATEGORY] varchar(5) NULL,
        [PAYG_BOX] smallint NULL,
        [TAXRATE] float NULL,
        [TAXFREE] money NULL,
        [BASEITEM] smallint NULL,
        [BASELOAD] float NULL,
        [BASETYPE] varchar(1) NULL,
        [AWARD] varchar(10) NULL,
        [ACCRUED] varchar(1) NULL,
        [ACCRUE_ITEM01] smallint NULL,
        [ACCRUE_ITEM02] smallint NULL,
        [ACCRUE_ITEM03] smallint NULL,
        [ACCRUE_ITEM04] smallint NULL,
        [ACCRUE_RATEA01] money NULL,
        [ACCRUE_RATEA02] money NULL,
        [ACCRUE_RATEA03] money NULL,
        [ACCRUE_RATEA04] money NULL,
        [ACCRUE_RATEB01] money NULL,
        [ACCRUE_RATEB02] money NULL,
        [ACCRUE_RATEB03] money NULL,
        [ACCRUE_RATEB04] money NULL,
        [AUTOCALC] varchar(1) NULL,
        [DHOURS] float NULL,
        [DRATE] float NULL,
        [DPAY_YEAR] smallint NULL,
        [DPAY_QTY] float NULL,
        [DVALUE] money NULL,
        [SUPER_LEVY] varchar(1) NULL,
        [PERS_SUPER] varchar(1) NULL,
        [PERS_SUPER_RATE] float NULL,
        [AFFECTS_LEAVE] varchar(1) NULL,
        [LEAVE_CODE] varchar(8) NULL,
        [PERCENT_AFFECT] float NULL,
        [CLR_GLCODE] varchar(10) NULL,
        [SHORT_DESC] varchar(10) NULL,
        [LEAVELOAD_ITEM] varchar(1) NULL,
        [LEAVE_BASEITEM] varchar(1) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [NORMAL_SPLIT] float NULL,
        [LPA_SPLIT] float NULL,
        [ANNUALISED_LOADING] float NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PI_Index_PIKEY] PRIMARY KEY CLUSTERED (
            [PIKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PI_Index_AWARD] ON [dbo].[PI]
    (
            [AWARD] ASC
    );
    CREATE NONCLUSTERED INDEX [PI_Index_BASEITEM] ON [dbo].[PI]
    (
            [BASEITEM] ASC
    );
    CREATE NONCLUSTERED INDEX [PI_Index_CLR_GLCODE] ON [dbo].[PI]
    (
            [CLR_GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PI_Index_INITIATIVE] ON [dbo].[PI]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PI_Index_PAYG_BOX] ON [dbo].[PI]
    (
            [PAYG_BOX] ASC
    );
    CREATE NONCLUSTERED INDEX [PI_Index_SUBPROGRAM] ON [dbo].[PI]
    (
            [SUBPROGRAM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_AWARD')
    ALTER INDEX [Index_AWARD] ON [dbo].[PI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_BASEITEM')
    ALTER INDEX [Index_BASEITEM] ON [dbo].[PI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_CLR_GLCODE')
    ALTER INDEX [Index_CLR_GLCODE] ON [dbo].[PI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_PAYG_BOX')
    ALTER INDEX [Index_PAYG_BOX] ON [dbo].[PI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PI] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_AWARD')
    ALTER INDEX [Index_AWARD] ON [dbo].[PI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_BASEITEM')
    ALTER INDEX [Index_BASEITEM] ON [dbo].[PI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_CLR_GLCODE')
    ALTER INDEX [Index_CLR_GLCODE] ON [dbo].[PI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_PAYG_BOX')
    ALTER INDEX [Index_PAYG_BOX] ON [dbo].[PI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PI]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short> Index_PIKEY = new List<short>();

            foreach (var entity in Entities)
            {
                Index_PIKEY.Add(entity.PIKEY);
            }

            builder.AppendLine("DELETE [dbo].[PI] WHERE");


            // Index_PIKEY
            builder.Append("[PIKEY] IN (");
            for (int index = 0; index < Index_PIKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PIKEY
                var parameterPIKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPIKEY);
                command.Parameters.Add(parameterPIKEY, SqlDbType.SmallInt).Value = Index_PIKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PI data set</returns>
        public override EduHubDataSetDataReader<PI> GetDataSetDataReader()
        {
            return new PIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PI data set</returns>
        public override EduHubDataSetDataReader<PI> GetDataSetDataReader(List<PI> Entities)
        {
            return new PIDataReader(new EduHubDataSetLoadedReader<PI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PIDataReader : EduHubDataSetDataReader<PI>
        {
            public PIDataReader(IEduHubDataSetReader<PI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 53; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PIKEY
                        return Current.PIKEY;
                    case 1: // PAYCODE
                        return Current.PAYCODE;
                    case 2: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 3: // TRANSTYPE
                        return Current.TRANSTYPE;
                    case 4: // TAXABLE
                        return Current.TAXABLE;
                    case 5: // UNIT
                        return Current.UNIT;
                    case 6: // CATEGORY
                        return Current.CATEGORY;
                    case 7: // PAYG_BOX
                        return Current.PAYG_BOX;
                    case 8: // TAXRATE
                        return Current.TAXRATE;
                    case 9: // TAXFREE
                        return Current.TAXFREE;
                    case 10: // BASEITEM
                        return Current.BASEITEM;
                    case 11: // BASELOAD
                        return Current.BASELOAD;
                    case 12: // BASETYPE
                        return Current.BASETYPE;
                    case 13: // AWARD
                        return Current.AWARD;
                    case 14: // ACCRUED
                        return Current.ACCRUED;
                    case 15: // ACCRUE_ITEM01
                        return Current.ACCRUE_ITEM01;
                    case 16: // ACCRUE_ITEM02
                        return Current.ACCRUE_ITEM02;
                    case 17: // ACCRUE_ITEM03
                        return Current.ACCRUE_ITEM03;
                    case 18: // ACCRUE_ITEM04
                        return Current.ACCRUE_ITEM04;
                    case 19: // ACCRUE_RATEA01
                        return Current.ACCRUE_RATEA01;
                    case 20: // ACCRUE_RATEA02
                        return Current.ACCRUE_RATEA02;
                    case 21: // ACCRUE_RATEA03
                        return Current.ACCRUE_RATEA03;
                    case 22: // ACCRUE_RATEA04
                        return Current.ACCRUE_RATEA04;
                    case 23: // ACCRUE_RATEB01
                        return Current.ACCRUE_RATEB01;
                    case 24: // ACCRUE_RATEB02
                        return Current.ACCRUE_RATEB02;
                    case 25: // ACCRUE_RATEB03
                        return Current.ACCRUE_RATEB03;
                    case 26: // ACCRUE_RATEB04
                        return Current.ACCRUE_RATEB04;
                    case 27: // AUTOCALC
                        return Current.AUTOCALC;
                    case 28: // DHOURS
                        return Current.DHOURS;
                    case 29: // DRATE
                        return Current.DRATE;
                    case 30: // DPAY_YEAR
                        return Current.DPAY_YEAR;
                    case 31: // DPAY_QTY
                        return Current.DPAY_QTY;
                    case 32: // DVALUE
                        return Current.DVALUE;
                    case 33: // SUPER_LEVY
                        return Current.SUPER_LEVY;
                    case 34: // PERS_SUPER
                        return Current.PERS_SUPER;
                    case 35: // PERS_SUPER_RATE
                        return Current.PERS_SUPER_RATE;
                    case 36: // AFFECTS_LEAVE
                        return Current.AFFECTS_LEAVE;
                    case 37: // LEAVE_CODE
                        return Current.LEAVE_CODE;
                    case 38: // PERCENT_AFFECT
                        return Current.PERCENT_AFFECT;
                    case 39: // CLR_GLCODE
                        return Current.CLR_GLCODE;
                    case 40: // SHORT_DESC
                        return Current.SHORT_DESC;
                    case 41: // LEAVELOAD_ITEM
                        return Current.LEAVELOAD_ITEM;
                    case 42: // LEAVE_BASEITEM
                        return Current.LEAVE_BASEITEM;
                    case 43: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 44: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 45: // INITIATIVE
                        return Current.INITIATIVE;
                    case 46: // NORMAL_SPLIT
                        return Current.NORMAL_SPLIT;
                    case 47: // LPA_SPLIT
                        return Current.LPA_SPLIT;
                    case 48: // ANNUALISED_LOADING
                        return Current.ANNUALISED_LOADING;
                    case 49: // ACTIVE
                        return Current.ACTIVE;
                    case 50: // LW_DATE
                        return Current.LW_DATE;
                    case 51: // LW_TIME
                        return Current.LW_TIME;
                    case 52: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // PAYCODE
                        return Current.PAYCODE == null;
                    case 2: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 3: // TRANSTYPE
                        return Current.TRANSTYPE == null;
                    case 4: // TAXABLE
                        return Current.TAXABLE == null;
                    case 5: // UNIT
                        return Current.UNIT == null;
                    case 6: // CATEGORY
                        return Current.CATEGORY == null;
                    case 7: // PAYG_BOX
                        return Current.PAYG_BOX == null;
                    case 8: // TAXRATE
                        return Current.TAXRATE == null;
                    case 9: // TAXFREE
                        return Current.TAXFREE == null;
                    case 10: // BASEITEM
                        return Current.BASEITEM == null;
                    case 11: // BASELOAD
                        return Current.BASELOAD == null;
                    case 12: // BASETYPE
                        return Current.BASETYPE == null;
                    case 13: // AWARD
                        return Current.AWARD == null;
                    case 14: // ACCRUED
                        return Current.ACCRUED == null;
                    case 15: // ACCRUE_ITEM01
                        return Current.ACCRUE_ITEM01 == null;
                    case 16: // ACCRUE_ITEM02
                        return Current.ACCRUE_ITEM02 == null;
                    case 17: // ACCRUE_ITEM03
                        return Current.ACCRUE_ITEM03 == null;
                    case 18: // ACCRUE_ITEM04
                        return Current.ACCRUE_ITEM04 == null;
                    case 19: // ACCRUE_RATEA01
                        return Current.ACCRUE_RATEA01 == null;
                    case 20: // ACCRUE_RATEA02
                        return Current.ACCRUE_RATEA02 == null;
                    case 21: // ACCRUE_RATEA03
                        return Current.ACCRUE_RATEA03 == null;
                    case 22: // ACCRUE_RATEA04
                        return Current.ACCRUE_RATEA04 == null;
                    case 23: // ACCRUE_RATEB01
                        return Current.ACCRUE_RATEB01 == null;
                    case 24: // ACCRUE_RATEB02
                        return Current.ACCRUE_RATEB02 == null;
                    case 25: // ACCRUE_RATEB03
                        return Current.ACCRUE_RATEB03 == null;
                    case 26: // ACCRUE_RATEB04
                        return Current.ACCRUE_RATEB04 == null;
                    case 27: // AUTOCALC
                        return Current.AUTOCALC == null;
                    case 28: // DHOURS
                        return Current.DHOURS == null;
                    case 29: // DRATE
                        return Current.DRATE == null;
                    case 30: // DPAY_YEAR
                        return Current.DPAY_YEAR == null;
                    case 31: // DPAY_QTY
                        return Current.DPAY_QTY == null;
                    case 32: // DVALUE
                        return Current.DVALUE == null;
                    case 33: // SUPER_LEVY
                        return Current.SUPER_LEVY == null;
                    case 34: // PERS_SUPER
                        return Current.PERS_SUPER == null;
                    case 35: // PERS_SUPER_RATE
                        return Current.PERS_SUPER_RATE == null;
                    case 36: // AFFECTS_LEAVE
                        return Current.AFFECTS_LEAVE == null;
                    case 37: // LEAVE_CODE
                        return Current.LEAVE_CODE == null;
                    case 38: // PERCENT_AFFECT
                        return Current.PERCENT_AFFECT == null;
                    case 39: // CLR_GLCODE
                        return Current.CLR_GLCODE == null;
                    case 40: // SHORT_DESC
                        return Current.SHORT_DESC == null;
                    case 41: // LEAVELOAD_ITEM
                        return Current.LEAVELOAD_ITEM == null;
                    case 42: // LEAVE_BASEITEM
                        return Current.LEAVE_BASEITEM == null;
                    case 43: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 44: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 45: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 46: // NORMAL_SPLIT
                        return Current.NORMAL_SPLIT == null;
                    case 47: // LPA_SPLIT
                        return Current.LPA_SPLIT == null;
                    case 48: // ANNUALISED_LOADING
                        return Current.ANNUALISED_LOADING == null;
                    case 49: // ACTIVE
                        return Current.ACTIVE == null;
                    case 50: // LW_DATE
                        return Current.LW_DATE == null;
                    case 51: // LW_TIME
                        return Current.LW_TIME == null;
                    case 52: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PIKEY
                        return "PIKEY";
                    case 1: // PAYCODE
                        return "PAYCODE";
                    case 2: // DESCRIPTION
                        return "DESCRIPTION";
                    case 3: // TRANSTYPE
                        return "TRANSTYPE";
                    case 4: // TAXABLE
                        return "TAXABLE";
                    case 5: // UNIT
                        return "UNIT";
                    case 6: // CATEGORY
                        return "CATEGORY";
                    case 7: // PAYG_BOX
                        return "PAYG_BOX";
                    case 8: // TAXRATE
                        return "TAXRATE";
                    case 9: // TAXFREE
                        return "TAXFREE";
                    case 10: // BASEITEM
                        return "BASEITEM";
                    case 11: // BASELOAD
                        return "BASELOAD";
                    case 12: // BASETYPE
                        return "BASETYPE";
                    case 13: // AWARD
                        return "AWARD";
                    case 14: // ACCRUED
                        return "ACCRUED";
                    case 15: // ACCRUE_ITEM01
                        return "ACCRUE_ITEM01";
                    case 16: // ACCRUE_ITEM02
                        return "ACCRUE_ITEM02";
                    case 17: // ACCRUE_ITEM03
                        return "ACCRUE_ITEM03";
                    case 18: // ACCRUE_ITEM04
                        return "ACCRUE_ITEM04";
                    case 19: // ACCRUE_RATEA01
                        return "ACCRUE_RATEA01";
                    case 20: // ACCRUE_RATEA02
                        return "ACCRUE_RATEA02";
                    case 21: // ACCRUE_RATEA03
                        return "ACCRUE_RATEA03";
                    case 22: // ACCRUE_RATEA04
                        return "ACCRUE_RATEA04";
                    case 23: // ACCRUE_RATEB01
                        return "ACCRUE_RATEB01";
                    case 24: // ACCRUE_RATEB02
                        return "ACCRUE_RATEB02";
                    case 25: // ACCRUE_RATEB03
                        return "ACCRUE_RATEB03";
                    case 26: // ACCRUE_RATEB04
                        return "ACCRUE_RATEB04";
                    case 27: // AUTOCALC
                        return "AUTOCALC";
                    case 28: // DHOURS
                        return "DHOURS";
                    case 29: // DRATE
                        return "DRATE";
                    case 30: // DPAY_YEAR
                        return "DPAY_YEAR";
                    case 31: // DPAY_QTY
                        return "DPAY_QTY";
                    case 32: // DVALUE
                        return "DVALUE";
                    case 33: // SUPER_LEVY
                        return "SUPER_LEVY";
                    case 34: // PERS_SUPER
                        return "PERS_SUPER";
                    case 35: // PERS_SUPER_RATE
                        return "PERS_SUPER_RATE";
                    case 36: // AFFECTS_LEAVE
                        return "AFFECTS_LEAVE";
                    case 37: // LEAVE_CODE
                        return "LEAVE_CODE";
                    case 38: // PERCENT_AFFECT
                        return "PERCENT_AFFECT";
                    case 39: // CLR_GLCODE
                        return "CLR_GLCODE";
                    case 40: // SHORT_DESC
                        return "SHORT_DESC";
                    case 41: // LEAVELOAD_ITEM
                        return "LEAVELOAD_ITEM";
                    case 42: // LEAVE_BASEITEM
                        return "LEAVE_BASEITEM";
                    case 43: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 44: // GLPROGRAM
                        return "GLPROGRAM";
                    case 45: // INITIATIVE
                        return "INITIATIVE";
                    case 46: // NORMAL_SPLIT
                        return "NORMAL_SPLIT";
                    case 47: // LPA_SPLIT
                        return "LPA_SPLIT";
                    case 48: // ANNUALISED_LOADING
                        return "ANNUALISED_LOADING";
                    case 49: // ACTIVE
                        return "ACTIVE";
                    case 50: // LW_DATE
                        return "LW_DATE";
                    case 51: // LW_TIME
                        return "LW_TIME";
                    case 52: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PIKEY":
                        return 0;
                    case "PAYCODE":
                        return 1;
                    case "DESCRIPTION":
                        return 2;
                    case "TRANSTYPE":
                        return 3;
                    case "TAXABLE":
                        return 4;
                    case "UNIT":
                        return 5;
                    case "CATEGORY":
                        return 6;
                    case "PAYG_BOX":
                        return 7;
                    case "TAXRATE":
                        return 8;
                    case "TAXFREE":
                        return 9;
                    case "BASEITEM":
                        return 10;
                    case "BASELOAD":
                        return 11;
                    case "BASETYPE":
                        return 12;
                    case "AWARD":
                        return 13;
                    case "ACCRUED":
                        return 14;
                    case "ACCRUE_ITEM01":
                        return 15;
                    case "ACCRUE_ITEM02":
                        return 16;
                    case "ACCRUE_ITEM03":
                        return 17;
                    case "ACCRUE_ITEM04":
                        return 18;
                    case "ACCRUE_RATEA01":
                        return 19;
                    case "ACCRUE_RATEA02":
                        return 20;
                    case "ACCRUE_RATEA03":
                        return 21;
                    case "ACCRUE_RATEA04":
                        return 22;
                    case "ACCRUE_RATEB01":
                        return 23;
                    case "ACCRUE_RATEB02":
                        return 24;
                    case "ACCRUE_RATEB03":
                        return 25;
                    case "ACCRUE_RATEB04":
                        return 26;
                    case "AUTOCALC":
                        return 27;
                    case "DHOURS":
                        return 28;
                    case "DRATE":
                        return 29;
                    case "DPAY_YEAR":
                        return 30;
                    case "DPAY_QTY":
                        return 31;
                    case "DVALUE":
                        return 32;
                    case "SUPER_LEVY":
                        return 33;
                    case "PERS_SUPER":
                        return 34;
                    case "PERS_SUPER_RATE":
                        return 35;
                    case "AFFECTS_LEAVE":
                        return 36;
                    case "LEAVE_CODE":
                        return 37;
                    case "PERCENT_AFFECT":
                        return 38;
                    case "CLR_GLCODE":
                        return 39;
                    case "SHORT_DESC":
                        return 40;
                    case "LEAVELOAD_ITEM":
                        return 41;
                    case "LEAVE_BASEITEM":
                        return 42;
                    case "SUBPROGRAM":
                        return 43;
                    case "GLPROGRAM":
                        return 44;
                    case "INITIATIVE":
                        return 45;
                    case "NORMAL_SPLIT":
                        return 46;
                    case "LPA_SPLIT":
                        return 47;
                    case "ANNUALISED_LOADING":
                        return 48;
                    case "ACTIVE":
                        return 49;
                    case "LW_DATE":
                        return 50;
                    case "LW_TIME":
                        return 51;
                    case "LW_USER":
                        return 52;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
