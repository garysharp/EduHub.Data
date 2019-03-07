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
    /// General Ledger Budgets Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLBUDGDataSet : EduHubDataSet<GLBUDG>
    {
        /// <inheritdoc />
        public override string Name { get { return "GLBUDG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal GLBUDGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BUDGETKEY = new Lazy<Dictionary<string, GLBUDG>>(() => this.ToDictionary(i => i.BUDGETKEY));
            Index_CODE = new Lazy<NullDictionary<string, IReadOnlyList<GLBUDG>>>(() => this.ToGroupedNullDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<GLBUDG>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLBUDG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLBUDG" /> fields for each CSV column header</returns>
        internal override Action<GLBUDG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLBUDG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BUDGETKEY":
                        mapper[i] = (e, v) => e.BUDGETKEY = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "GL_PROGRAM":
                        mapper[i] = (e, v) => e.GL_PROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "CURR01":
                        mapper[i] = (e, v) => e.CURR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR02":
                        mapper[i] = (e, v) => e.CURR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR03":
                        mapper[i] = (e, v) => e.CURR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR04":
                        mapper[i] = (e, v) => e.CURR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR05":
                        mapper[i] = (e, v) => e.CURR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR06":
                        mapper[i] = (e, v) => e.CURR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR07":
                        mapper[i] = (e, v) => e.CURR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR08":
                        mapper[i] = (e, v) => e.CURR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR09":
                        mapper[i] = (e, v) => e.CURR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR10":
                        mapper[i] = (e, v) => e.CURR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR11":
                        mapper[i] = (e, v) => e.CURR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR12":
                        mapper[i] = (e, v) => e.CURR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR01":
                        mapper[i] = (e, v) => e.LASTYR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR02":
                        mapper[i] = (e, v) => e.LASTYR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR03":
                        mapper[i] = (e, v) => e.LASTYR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR04":
                        mapper[i] = (e, v) => e.LASTYR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR05":
                        mapper[i] = (e, v) => e.LASTYR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR06":
                        mapper[i] = (e, v) => e.LASTYR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR07":
                        mapper[i] = (e, v) => e.LASTYR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR08":
                        mapper[i] = (e, v) => e.LASTYR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR09":
                        mapper[i] = (e, v) => e.LASTYR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR10":
                        mapper[i] = (e, v) => e.LASTYR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR11":
                        mapper[i] = (e, v) => e.LASTYR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR12":
                        mapper[i] = (e, v) => e.LASTYR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG01":
                        mapper[i] = (e, v) => e.BUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG02":
                        mapper[i] = (e, v) => e.BUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG03":
                        mapper[i] = (e, v) => e.BUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG04":
                        mapper[i] = (e, v) => e.BUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG05":
                        mapper[i] = (e, v) => e.BUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG06":
                        mapper[i] = (e, v) => e.BUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG07":
                        mapper[i] = (e, v) => e.BUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG08":
                        mapper[i] = (e, v) => e.BUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG09":
                        mapper[i] = (e, v) => e.BUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG10":
                        mapper[i] = (e, v) => e.BUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG11":
                        mapper[i] = (e, v) => e.BUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG12":
                        mapper[i] = (e, v) => e.BUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG01":
                        mapper[i] = (e, v) => e.NEXTBUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG02":
                        mapper[i] = (e, v) => e.NEXTBUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG03":
                        mapper[i] = (e, v) => e.NEXTBUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG04":
                        mapper[i] = (e, v) => e.NEXTBUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG05":
                        mapper[i] = (e, v) => e.NEXTBUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG06":
                        mapper[i] = (e, v) => e.NEXTBUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG07":
                        mapper[i] = (e, v) => e.NEXTBUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG08":
                        mapper[i] = (e, v) => e.NEXTBUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG09":
                        mapper[i] = (e, v) => e.NEXTBUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG10":
                        mapper[i] = (e, v) => e.NEXTBUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG11":
                        mapper[i] = (e, v) => e.NEXTBUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG12":
                        mapper[i] = (e, v) => e.NEXTBUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ANNUALBUDG":
                        mapper[i] = (e, v) => e.ANNUALBUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXT_ANN_BUDG":
                        mapper[i] = (e, v) => e.NEXT_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG01":
                        mapper[i] = (e, v) => e.LASTBUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG02":
                        mapper[i] = (e, v) => e.LASTBUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG03":
                        mapper[i] = (e, v) => e.LASTBUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG04":
                        mapper[i] = (e, v) => e.LASTBUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG05":
                        mapper[i] = (e, v) => e.LASTBUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG06":
                        mapper[i] = (e, v) => e.LASTBUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG07":
                        mapper[i] = (e, v) => e.LASTBUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG08":
                        mapper[i] = (e, v) => e.LASTBUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG09":
                        mapper[i] = (e, v) => e.LASTBUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG10":
                        mapper[i] = (e, v) => e.LASTBUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG11":
                        mapper[i] = (e, v) => e.LASTBUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG12":
                        mapper[i] = (e, v) => e.LASTBUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LAST_ANN_BUDG":
                        mapper[i] = (e, v) => e.LAST_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "IMPORTED":
                        mapper[i] = (e, v) => e.IMPORTED = v;
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
        /// Merges <see cref="GLBUDG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="GLBUDG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="GLBUDG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{GLBUDG}"/> of entities</returns>
        internal override IEnumerable<GLBUDG> ApplyDeltaEntities(IEnumerable<GLBUDG> Entities, List<GLBUDG> DeltaEntities)
        {
            HashSet<string> Index_BUDGETKEY = new HashSet<string>(DeltaEntities.Select(i => i.BUDGETKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.BUDGETKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_BUDGETKEY.Remove(entity.BUDGETKEY);
                            
                            if (entity.BUDGETKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, GLBUDG>> Index_BUDGETKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<GLBUDG>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLBUDG>>> Index_INITIATIVE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLBUDG by BUDGETKEY field
        /// </summary>
        /// <param name="BUDGETKEY">BUDGETKEY value used to find GLBUDG</param>
        /// <returns>Related GLBUDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBUDG FindByBUDGETKEY(string BUDGETKEY)
        {
            return Index_BUDGETKEY.Value[BUDGETKEY];
        }

        /// <summary>
        /// Attempt to find GLBUDG by BUDGETKEY field
        /// </summary>
        /// <param name="BUDGETKEY">BUDGETKEY value used to find GLBUDG</param>
        /// <param name="Value">Related GLBUDG entity</param>
        /// <returns>True if the related GLBUDG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBUDGETKEY(string BUDGETKEY, out GLBUDG Value)
        {
            return Index_BUDGETKEY.Value.TryGetValue(BUDGETKEY, out Value);
        }

        /// <summary>
        /// Attempt to find GLBUDG by BUDGETKEY field
        /// </summary>
        /// <param name="BUDGETKEY">BUDGETKEY value used to find GLBUDG</param>
        /// <returns>Related GLBUDG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBUDG TryFindByBUDGETKEY(string BUDGETKEY)
        {
            GLBUDG value;
            if (Index_BUDGETKEY.Value.TryGetValue(BUDGETKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLBUDG by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLBUDG</param>
        /// <returns>List of related GLBUDG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLBUDG> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLBUDG by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLBUDG</param>
        /// <param name="Value">List of related GLBUDG entities</param>
        /// <returns>True if the list of related GLBUDG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLBUDG> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLBUDG by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLBUDG</param>
        /// <returns>List of related GLBUDG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLBUDG> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLBUDG> value;
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
        /// Find GLBUDG by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLBUDG</param>
        /// <returns>List of related GLBUDG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLBUDG> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find GLBUDG by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLBUDG</param>
        /// <param name="Value">List of related GLBUDG entities</param>
        /// <returns>True if the list of related GLBUDG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLBUDG> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find GLBUDG by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLBUDG</param>
        /// <returns>List of related GLBUDG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLBUDG> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLBUDG> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a GLBUDG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLBUDG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLBUDG](
        [BUDGETKEY] varchar(15) NOT NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [TITLE] varchar(30) NULL,
        [CODE] varchar(10) NULL,
        [GL_PROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [CURR01] money NULL,
        [CURR02] money NULL,
        [CURR03] money NULL,
        [CURR04] money NULL,
        [CURR05] money NULL,
        [CURR06] money NULL,
        [CURR07] money NULL,
        [CURR08] money NULL,
        [CURR09] money NULL,
        [CURR10] money NULL,
        [CURR11] money NULL,
        [CURR12] money NULL,
        [OPBAL] money NULL,
        [LASTYR01] money NULL,
        [LASTYR02] money NULL,
        [LASTYR03] money NULL,
        [LASTYR04] money NULL,
        [LASTYR05] money NULL,
        [LASTYR06] money NULL,
        [LASTYR07] money NULL,
        [LASTYR08] money NULL,
        [LASTYR09] money NULL,
        [LASTYR10] money NULL,
        [LASTYR11] money NULL,
        [LASTYR12] money NULL,
        [BUDG01] money NULL,
        [BUDG02] money NULL,
        [BUDG03] money NULL,
        [BUDG04] money NULL,
        [BUDG05] money NULL,
        [BUDG06] money NULL,
        [BUDG07] money NULL,
        [BUDG08] money NULL,
        [BUDG09] money NULL,
        [BUDG10] money NULL,
        [BUDG11] money NULL,
        [BUDG12] money NULL,
        [NEXTBUDG01] money NULL,
        [NEXTBUDG02] money NULL,
        [NEXTBUDG03] money NULL,
        [NEXTBUDG04] money NULL,
        [NEXTBUDG05] money NULL,
        [NEXTBUDG06] money NULL,
        [NEXTBUDG07] money NULL,
        [NEXTBUDG08] money NULL,
        [NEXTBUDG09] money NULL,
        [NEXTBUDG10] money NULL,
        [NEXTBUDG11] money NULL,
        [NEXTBUDG12] money NULL,
        [ANNUALBUDG] money NULL,
        [NEXT_ANN_BUDG] money NULL,
        [LASTBUDG01] money NULL,
        [LASTBUDG02] money NULL,
        [LASTBUDG03] money NULL,
        [LASTBUDG04] money NULL,
        [LASTBUDG05] money NULL,
        [LASTBUDG06] money NULL,
        [LASTBUDG07] money NULL,
        [LASTBUDG08] money NULL,
        [LASTBUDG09] money NULL,
        [LASTBUDG10] money NULL,
        [LASTBUDG11] money NULL,
        [LASTBUDG12] money NULL,
        [LAST_ANN_BUDG] money NULL,
        [IMPORTED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLBUDG_Index_BUDGETKEY] PRIMARY KEY CLUSTERED (
            [BUDGETKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [GLBUDG_Index_CODE] ON [dbo].[GLBUDG]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLBUDG_Index_INITIATIVE] ON [dbo].[GLBUDG]
    (
            [INITIATIVE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLBUDG]') AND name = N'Index_CODE')
    ALTER INDEX [Index_CODE] ON [dbo].[GLBUDG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLBUDG]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[GLBUDG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLBUDG]') AND name = N'Index_CODE')
    ALTER INDEX [Index_CODE] ON [dbo].[GLBUDG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLBUDG]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[GLBUDG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="GLBUDG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="GLBUDG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<GLBUDG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_BUDGETKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_BUDGETKEY.Add(entity.BUDGETKEY);
            }

            builder.AppendLine("DELETE [dbo].[GLBUDG] WHERE");


            // Index_BUDGETKEY
            builder.Append("[BUDGETKEY] IN (");
            for (int index = 0; index < Index_BUDGETKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // BUDGETKEY
                var parameterBUDGETKEY = $"@p{parameterIndex++}";
                builder.Append(parameterBUDGETKEY);
                command.Parameters.Add(parameterBUDGETKEY, SqlDbType.VarChar, 15).Value = Index_BUDGETKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLBUDG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLBUDG data set</returns>
        public override EduHubDataSetDataReader<GLBUDG> GetDataSetDataReader()
        {
            return new GLBUDGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLBUDG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLBUDG data set</returns>
        public override EduHubDataSetDataReader<GLBUDG> GetDataSetDataReader(List<GLBUDG> Entities)
        {
            return new GLBUDGDataReader(new EduHubDataSetLoadedReader<GLBUDG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLBUDGDataReader : EduHubDataSetDataReader<GLBUDG>
        {
            public GLBUDGDataReader(IEduHubDataSetReader<GLBUDG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 74; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // BUDGETKEY
                        return Current.BUDGETKEY;
                    case 1: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 2: // TITLE
                        return Current.TITLE;
                    case 3: // CODE
                        return Current.CODE;
                    case 4: // GL_PROGRAM
                        return Current.GL_PROGRAM;
                    case 5: // INITIATIVE
                        return Current.INITIATIVE;
                    case 6: // CURR01
                        return Current.CURR01;
                    case 7: // CURR02
                        return Current.CURR02;
                    case 8: // CURR03
                        return Current.CURR03;
                    case 9: // CURR04
                        return Current.CURR04;
                    case 10: // CURR05
                        return Current.CURR05;
                    case 11: // CURR06
                        return Current.CURR06;
                    case 12: // CURR07
                        return Current.CURR07;
                    case 13: // CURR08
                        return Current.CURR08;
                    case 14: // CURR09
                        return Current.CURR09;
                    case 15: // CURR10
                        return Current.CURR10;
                    case 16: // CURR11
                        return Current.CURR11;
                    case 17: // CURR12
                        return Current.CURR12;
                    case 18: // OPBAL
                        return Current.OPBAL;
                    case 19: // LASTYR01
                        return Current.LASTYR01;
                    case 20: // LASTYR02
                        return Current.LASTYR02;
                    case 21: // LASTYR03
                        return Current.LASTYR03;
                    case 22: // LASTYR04
                        return Current.LASTYR04;
                    case 23: // LASTYR05
                        return Current.LASTYR05;
                    case 24: // LASTYR06
                        return Current.LASTYR06;
                    case 25: // LASTYR07
                        return Current.LASTYR07;
                    case 26: // LASTYR08
                        return Current.LASTYR08;
                    case 27: // LASTYR09
                        return Current.LASTYR09;
                    case 28: // LASTYR10
                        return Current.LASTYR10;
                    case 29: // LASTYR11
                        return Current.LASTYR11;
                    case 30: // LASTYR12
                        return Current.LASTYR12;
                    case 31: // BUDG01
                        return Current.BUDG01;
                    case 32: // BUDG02
                        return Current.BUDG02;
                    case 33: // BUDG03
                        return Current.BUDG03;
                    case 34: // BUDG04
                        return Current.BUDG04;
                    case 35: // BUDG05
                        return Current.BUDG05;
                    case 36: // BUDG06
                        return Current.BUDG06;
                    case 37: // BUDG07
                        return Current.BUDG07;
                    case 38: // BUDG08
                        return Current.BUDG08;
                    case 39: // BUDG09
                        return Current.BUDG09;
                    case 40: // BUDG10
                        return Current.BUDG10;
                    case 41: // BUDG11
                        return Current.BUDG11;
                    case 42: // BUDG12
                        return Current.BUDG12;
                    case 43: // NEXTBUDG01
                        return Current.NEXTBUDG01;
                    case 44: // NEXTBUDG02
                        return Current.NEXTBUDG02;
                    case 45: // NEXTBUDG03
                        return Current.NEXTBUDG03;
                    case 46: // NEXTBUDG04
                        return Current.NEXTBUDG04;
                    case 47: // NEXTBUDG05
                        return Current.NEXTBUDG05;
                    case 48: // NEXTBUDG06
                        return Current.NEXTBUDG06;
                    case 49: // NEXTBUDG07
                        return Current.NEXTBUDG07;
                    case 50: // NEXTBUDG08
                        return Current.NEXTBUDG08;
                    case 51: // NEXTBUDG09
                        return Current.NEXTBUDG09;
                    case 52: // NEXTBUDG10
                        return Current.NEXTBUDG10;
                    case 53: // NEXTBUDG11
                        return Current.NEXTBUDG11;
                    case 54: // NEXTBUDG12
                        return Current.NEXTBUDG12;
                    case 55: // ANNUALBUDG
                        return Current.ANNUALBUDG;
                    case 56: // NEXT_ANN_BUDG
                        return Current.NEXT_ANN_BUDG;
                    case 57: // LASTBUDG01
                        return Current.LASTBUDG01;
                    case 58: // LASTBUDG02
                        return Current.LASTBUDG02;
                    case 59: // LASTBUDG03
                        return Current.LASTBUDG03;
                    case 60: // LASTBUDG04
                        return Current.LASTBUDG04;
                    case 61: // LASTBUDG05
                        return Current.LASTBUDG05;
                    case 62: // LASTBUDG06
                        return Current.LASTBUDG06;
                    case 63: // LASTBUDG07
                        return Current.LASTBUDG07;
                    case 64: // LASTBUDG08
                        return Current.LASTBUDG08;
                    case 65: // LASTBUDG09
                        return Current.LASTBUDG09;
                    case 66: // LASTBUDG10
                        return Current.LASTBUDG10;
                    case 67: // LASTBUDG11
                        return Current.LASTBUDG11;
                    case 68: // LASTBUDG12
                        return Current.LASTBUDG12;
                    case 69: // LAST_ANN_BUDG
                        return Current.LAST_ANN_BUDG;
                    case 70: // IMPORTED
                        return Current.IMPORTED;
                    case 71: // LW_DATE
                        return Current.LW_DATE;
                    case 72: // LW_TIME
                        return Current.LW_TIME;
                    case 73: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 2: // TITLE
                        return Current.TITLE == null;
                    case 3: // CODE
                        return Current.CODE == null;
                    case 4: // GL_PROGRAM
                        return Current.GL_PROGRAM == null;
                    case 5: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 6: // CURR01
                        return Current.CURR01 == null;
                    case 7: // CURR02
                        return Current.CURR02 == null;
                    case 8: // CURR03
                        return Current.CURR03 == null;
                    case 9: // CURR04
                        return Current.CURR04 == null;
                    case 10: // CURR05
                        return Current.CURR05 == null;
                    case 11: // CURR06
                        return Current.CURR06 == null;
                    case 12: // CURR07
                        return Current.CURR07 == null;
                    case 13: // CURR08
                        return Current.CURR08 == null;
                    case 14: // CURR09
                        return Current.CURR09 == null;
                    case 15: // CURR10
                        return Current.CURR10 == null;
                    case 16: // CURR11
                        return Current.CURR11 == null;
                    case 17: // CURR12
                        return Current.CURR12 == null;
                    case 18: // OPBAL
                        return Current.OPBAL == null;
                    case 19: // LASTYR01
                        return Current.LASTYR01 == null;
                    case 20: // LASTYR02
                        return Current.LASTYR02 == null;
                    case 21: // LASTYR03
                        return Current.LASTYR03 == null;
                    case 22: // LASTYR04
                        return Current.LASTYR04 == null;
                    case 23: // LASTYR05
                        return Current.LASTYR05 == null;
                    case 24: // LASTYR06
                        return Current.LASTYR06 == null;
                    case 25: // LASTYR07
                        return Current.LASTYR07 == null;
                    case 26: // LASTYR08
                        return Current.LASTYR08 == null;
                    case 27: // LASTYR09
                        return Current.LASTYR09 == null;
                    case 28: // LASTYR10
                        return Current.LASTYR10 == null;
                    case 29: // LASTYR11
                        return Current.LASTYR11 == null;
                    case 30: // LASTYR12
                        return Current.LASTYR12 == null;
                    case 31: // BUDG01
                        return Current.BUDG01 == null;
                    case 32: // BUDG02
                        return Current.BUDG02 == null;
                    case 33: // BUDG03
                        return Current.BUDG03 == null;
                    case 34: // BUDG04
                        return Current.BUDG04 == null;
                    case 35: // BUDG05
                        return Current.BUDG05 == null;
                    case 36: // BUDG06
                        return Current.BUDG06 == null;
                    case 37: // BUDG07
                        return Current.BUDG07 == null;
                    case 38: // BUDG08
                        return Current.BUDG08 == null;
                    case 39: // BUDG09
                        return Current.BUDG09 == null;
                    case 40: // BUDG10
                        return Current.BUDG10 == null;
                    case 41: // BUDG11
                        return Current.BUDG11 == null;
                    case 42: // BUDG12
                        return Current.BUDG12 == null;
                    case 43: // NEXTBUDG01
                        return Current.NEXTBUDG01 == null;
                    case 44: // NEXTBUDG02
                        return Current.NEXTBUDG02 == null;
                    case 45: // NEXTBUDG03
                        return Current.NEXTBUDG03 == null;
                    case 46: // NEXTBUDG04
                        return Current.NEXTBUDG04 == null;
                    case 47: // NEXTBUDG05
                        return Current.NEXTBUDG05 == null;
                    case 48: // NEXTBUDG06
                        return Current.NEXTBUDG06 == null;
                    case 49: // NEXTBUDG07
                        return Current.NEXTBUDG07 == null;
                    case 50: // NEXTBUDG08
                        return Current.NEXTBUDG08 == null;
                    case 51: // NEXTBUDG09
                        return Current.NEXTBUDG09 == null;
                    case 52: // NEXTBUDG10
                        return Current.NEXTBUDG10 == null;
                    case 53: // NEXTBUDG11
                        return Current.NEXTBUDG11 == null;
                    case 54: // NEXTBUDG12
                        return Current.NEXTBUDG12 == null;
                    case 55: // ANNUALBUDG
                        return Current.ANNUALBUDG == null;
                    case 56: // NEXT_ANN_BUDG
                        return Current.NEXT_ANN_BUDG == null;
                    case 57: // LASTBUDG01
                        return Current.LASTBUDG01 == null;
                    case 58: // LASTBUDG02
                        return Current.LASTBUDG02 == null;
                    case 59: // LASTBUDG03
                        return Current.LASTBUDG03 == null;
                    case 60: // LASTBUDG04
                        return Current.LASTBUDG04 == null;
                    case 61: // LASTBUDG05
                        return Current.LASTBUDG05 == null;
                    case 62: // LASTBUDG06
                        return Current.LASTBUDG06 == null;
                    case 63: // LASTBUDG07
                        return Current.LASTBUDG07 == null;
                    case 64: // LASTBUDG08
                        return Current.LASTBUDG08 == null;
                    case 65: // LASTBUDG09
                        return Current.LASTBUDG09 == null;
                    case 66: // LASTBUDG10
                        return Current.LASTBUDG10 == null;
                    case 67: // LASTBUDG11
                        return Current.LASTBUDG11 == null;
                    case 68: // LASTBUDG12
                        return Current.LASTBUDG12 == null;
                    case 69: // LAST_ANN_BUDG
                        return Current.LAST_ANN_BUDG == null;
                    case 70: // IMPORTED
                        return Current.IMPORTED == null;
                    case 71: // LW_DATE
                        return Current.LW_DATE == null;
                    case 72: // LW_TIME
                        return Current.LW_TIME == null;
                    case 73: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // BUDGETKEY
                        return "BUDGETKEY";
                    case 1: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 2: // TITLE
                        return "TITLE";
                    case 3: // CODE
                        return "CODE";
                    case 4: // GL_PROGRAM
                        return "GL_PROGRAM";
                    case 5: // INITIATIVE
                        return "INITIATIVE";
                    case 6: // CURR01
                        return "CURR01";
                    case 7: // CURR02
                        return "CURR02";
                    case 8: // CURR03
                        return "CURR03";
                    case 9: // CURR04
                        return "CURR04";
                    case 10: // CURR05
                        return "CURR05";
                    case 11: // CURR06
                        return "CURR06";
                    case 12: // CURR07
                        return "CURR07";
                    case 13: // CURR08
                        return "CURR08";
                    case 14: // CURR09
                        return "CURR09";
                    case 15: // CURR10
                        return "CURR10";
                    case 16: // CURR11
                        return "CURR11";
                    case 17: // CURR12
                        return "CURR12";
                    case 18: // OPBAL
                        return "OPBAL";
                    case 19: // LASTYR01
                        return "LASTYR01";
                    case 20: // LASTYR02
                        return "LASTYR02";
                    case 21: // LASTYR03
                        return "LASTYR03";
                    case 22: // LASTYR04
                        return "LASTYR04";
                    case 23: // LASTYR05
                        return "LASTYR05";
                    case 24: // LASTYR06
                        return "LASTYR06";
                    case 25: // LASTYR07
                        return "LASTYR07";
                    case 26: // LASTYR08
                        return "LASTYR08";
                    case 27: // LASTYR09
                        return "LASTYR09";
                    case 28: // LASTYR10
                        return "LASTYR10";
                    case 29: // LASTYR11
                        return "LASTYR11";
                    case 30: // LASTYR12
                        return "LASTYR12";
                    case 31: // BUDG01
                        return "BUDG01";
                    case 32: // BUDG02
                        return "BUDG02";
                    case 33: // BUDG03
                        return "BUDG03";
                    case 34: // BUDG04
                        return "BUDG04";
                    case 35: // BUDG05
                        return "BUDG05";
                    case 36: // BUDG06
                        return "BUDG06";
                    case 37: // BUDG07
                        return "BUDG07";
                    case 38: // BUDG08
                        return "BUDG08";
                    case 39: // BUDG09
                        return "BUDG09";
                    case 40: // BUDG10
                        return "BUDG10";
                    case 41: // BUDG11
                        return "BUDG11";
                    case 42: // BUDG12
                        return "BUDG12";
                    case 43: // NEXTBUDG01
                        return "NEXTBUDG01";
                    case 44: // NEXTBUDG02
                        return "NEXTBUDG02";
                    case 45: // NEXTBUDG03
                        return "NEXTBUDG03";
                    case 46: // NEXTBUDG04
                        return "NEXTBUDG04";
                    case 47: // NEXTBUDG05
                        return "NEXTBUDG05";
                    case 48: // NEXTBUDG06
                        return "NEXTBUDG06";
                    case 49: // NEXTBUDG07
                        return "NEXTBUDG07";
                    case 50: // NEXTBUDG08
                        return "NEXTBUDG08";
                    case 51: // NEXTBUDG09
                        return "NEXTBUDG09";
                    case 52: // NEXTBUDG10
                        return "NEXTBUDG10";
                    case 53: // NEXTBUDG11
                        return "NEXTBUDG11";
                    case 54: // NEXTBUDG12
                        return "NEXTBUDG12";
                    case 55: // ANNUALBUDG
                        return "ANNUALBUDG";
                    case 56: // NEXT_ANN_BUDG
                        return "NEXT_ANN_BUDG";
                    case 57: // LASTBUDG01
                        return "LASTBUDG01";
                    case 58: // LASTBUDG02
                        return "LASTBUDG02";
                    case 59: // LASTBUDG03
                        return "LASTBUDG03";
                    case 60: // LASTBUDG04
                        return "LASTBUDG04";
                    case 61: // LASTBUDG05
                        return "LASTBUDG05";
                    case 62: // LASTBUDG06
                        return "LASTBUDG06";
                    case 63: // LASTBUDG07
                        return "LASTBUDG07";
                    case 64: // LASTBUDG08
                        return "LASTBUDG08";
                    case 65: // LASTBUDG09
                        return "LASTBUDG09";
                    case 66: // LASTBUDG10
                        return "LASTBUDG10";
                    case 67: // LASTBUDG11
                        return "LASTBUDG11";
                    case 68: // LASTBUDG12
                        return "LASTBUDG12";
                    case 69: // LAST_ANN_BUDG
                        return "LAST_ANN_BUDG";
                    case 70: // IMPORTED
                        return "IMPORTED";
                    case 71: // LW_DATE
                        return "LW_DATE";
                    case 72: // LW_TIME
                        return "LW_TIME";
                    case 73: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "BUDGETKEY":
                        return 0;
                    case "SUBPROGRAM":
                        return 1;
                    case "TITLE":
                        return 2;
                    case "CODE":
                        return 3;
                    case "GL_PROGRAM":
                        return 4;
                    case "INITIATIVE":
                        return 5;
                    case "CURR01":
                        return 6;
                    case "CURR02":
                        return 7;
                    case "CURR03":
                        return 8;
                    case "CURR04":
                        return 9;
                    case "CURR05":
                        return 10;
                    case "CURR06":
                        return 11;
                    case "CURR07":
                        return 12;
                    case "CURR08":
                        return 13;
                    case "CURR09":
                        return 14;
                    case "CURR10":
                        return 15;
                    case "CURR11":
                        return 16;
                    case "CURR12":
                        return 17;
                    case "OPBAL":
                        return 18;
                    case "LASTYR01":
                        return 19;
                    case "LASTYR02":
                        return 20;
                    case "LASTYR03":
                        return 21;
                    case "LASTYR04":
                        return 22;
                    case "LASTYR05":
                        return 23;
                    case "LASTYR06":
                        return 24;
                    case "LASTYR07":
                        return 25;
                    case "LASTYR08":
                        return 26;
                    case "LASTYR09":
                        return 27;
                    case "LASTYR10":
                        return 28;
                    case "LASTYR11":
                        return 29;
                    case "LASTYR12":
                        return 30;
                    case "BUDG01":
                        return 31;
                    case "BUDG02":
                        return 32;
                    case "BUDG03":
                        return 33;
                    case "BUDG04":
                        return 34;
                    case "BUDG05":
                        return 35;
                    case "BUDG06":
                        return 36;
                    case "BUDG07":
                        return 37;
                    case "BUDG08":
                        return 38;
                    case "BUDG09":
                        return 39;
                    case "BUDG10":
                        return 40;
                    case "BUDG11":
                        return 41;
                    case "BUDG12":
                        return 42;
                    case "NEXTBUDG01":
                        return 43;
                    case "NEXTBUDG02":
                        return 44;
                    case "NEXTBUDG03":
                        return 45;
                    case "NEXTBUDG04":
                        return 46;
                    case "NEXTBUDG05":
                        return 47;
                    case "NEXTBUDG06":
                        return 48;
                    case "NEXTBUDG07":
                        return 49;
                    case "NEXTBUDG08":
                        return 50;
                    case "NEXTBUDG09":
                        return 51;
                    case "NEXTBUDG10":
                        return 52;
                    case "NEXTBUDG11":
                        return 53;
                    case "NEXTBUDG12":
                        return 54;
                    case "ANNUALBUDG":
                        return 55;
                    case "NEXT_ANN_BUDG":
                        return 56;
                    case "LASTBUDG01":
                        return 57;
                    case "LASTBUDG02":
                        return 58;
                    case "LASTBUDG03":
                        return 59;
                    case "LASTBUDG04":
                        return 60;
                    case "LASTBUDG05":
                        return 61;
                    case "LASTBUDG06":
                        return 62;
                    case "LASTBUDG07":
                        return 63;
                    case "LASTBUDG08":
                        return 64;
                    case "LASTBUDG09":
                        return 65;
                    case "LASTBUDG10":
                        return 66;
                    case "LASTBUDG11":
                        return 67;
                    case "LASTBUDG12":
                        return 68;
                    case "LAST_ANN_BUDG":
                        return 69;
                    case "IMPORTED":
                        return 70;
                    case "LW_DATE":
                        return 71;
                    case "LW_TIME":
                        return 72;
                    case "LW_USER":
                        return 73;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
