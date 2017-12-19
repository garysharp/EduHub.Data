using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Purchase Requisitions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRPRDataSet : EduHubDataSet<CRPR>
    {
        /// <inheritdoc />
        public override string Name { get { return "CRPR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal CRPRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_APPROVED_BY = new Lazy<NullDictionary<string, IReadOnlyList<CRPR>>>(() => this.ToGroupedNullDictionary(i => i.APPROVED_BY));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<CRPR>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<CRPR>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_STAFF_ORDER_BY = new Lazy<NullDictionary<string, IReadOnlyList<CRPR>>>(() => this.ToGroupedNullDictionary(i => i.STAFF_ORDER_BY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<CRPR>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, CRPR>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<CRPR>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CRPR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CRPR" /> fields for each CSV column header</returns>
        internal override Action<CRPR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CRPR, string>[Headers.Count];

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
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRXCODE":
                        mapper[i] = (e, v) => e.TRXCODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRORDER":
                        mapper[i] = (e, v) => e.TRORDER = v;
                        break;
                    case "STAFF_ORDER_BY":
                        mapper[i] = (e, v) => e.STAFF_ORDER_BY = v;
                        break;
                    case "APPROVED_BY":
                        mapper[i] = (e, v) => e.APPROVED_BY = v;
                        break;
                    case "POCOMMENT":
                        mapper[i] = (e, v) => e.POCOMMENT = v;
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LINE_NO":
                        mapper[i] = (e, v) => e.LINE_NO = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="CRPR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="CRPR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="CRPR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{CRPR}"/> of entities</returns>
        internal override IEnumerable<CRPR> ApplyDeltaEntities(IEnumerable<CRPR> Entities, List<CRPR> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<CRPR>>> Index_APPROVED_BY;
        private Lazy<Dictionary<string, IReadOnlyList<CRPR>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRPR>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRPR>>> Index_STAFF_ORDER_BY;
        private Lazy<NullDictionary<string, IReadOnlyList<CRPR>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, CRPR>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<CRPR>>> Index_TRREF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CRPR by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find CRPR</param>
        /// <returns>List of related CRPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> FindByAPPROVED_BY(string APPROVED_BY)
        {
            return Index_APPROVED_BY.Value[APPROVED_BY];
        }

        /// <summary>
        /// Attempt to find CRPR by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find CRPR</param>
        /// <param name="Value">List of related CRPR entities</param>
        /// <returns>True if the list of related CRPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAPPROVED_BY(string APPROVED_BY, out IReadOnlyList<CRPR> Value)
        {
            return Index_APPROVED_BY.Value.TryGetValue(APPROVED_BY, out Value);
        }

        /// <summary>
        /// Attempt to find CRPR by APPROVED_BY field
        /// </summary>
        /// <param name="APPROVED_BY">APPROVED_BY value used to find CRPR</param>
        /// <returns>List of related CRPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> TryFindByAPPROVED_BY(string APPROVED_BY)
        {
            IReadOnlyList<CRPR> value;
            if (Index_APPROVED_BY.Value.TryGetValue(APPROVED_BY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRPR by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRPR</param>
        /// <returns>List of related CRPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find CRPR by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRPR</param>
        /// <param name="Value">List of related CRPR entities</param>
        /// <returns>True if the list of related CRPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<CRPR> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find CRPR by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRPR</param>
        /// <returns>List of related CRPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> TryFindByCODE(string CODE)
        {
            IReadOnlyList<CRPR> value;
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
        /// Find CRPR by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find CRPR</param>
        /// <returns>List of related CRPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find CRPR by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find CRPR</param>
        /// <param name="Value">List of related CRPR entities</param>
        /// <returns>True if the list of related CRPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<CRPR> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find CRPR by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find CRPR</param>
        /// <returns>List of related CRPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<CRPR> value;
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
        /// Find CRPR by STAFF_ORDER_BY field
        /// </summary>
        /// <param name="STAFF_ORDER_BY">STAFF_ORDER_BY value used to find CRPR</param>
        /// <returns>List of related CRPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> FindBySTAFF_ORDER_BY(string STAFF_ORDER_BY)
        {
            return Index_STAFF_ORDER_BY.Value[STAFF_ORDER_BY];
        }

        /// <summary>
        /// Attempt to find CRPR by STAFF_ORDER_BY field
        /// </summary>
        /// <param name="STAFF_ORDER_BY">STAFF_ORDER_BY value used to find CRPR</param>
        /// <param name="Value">List of related CRPR entities</param>
        /// <returns>True if the list of related CRPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF_ORDER_BY(string STAFF_ORDER_BY, out IReadOnlyList<CRPR> Value)
        {
            return Index_STAFF_ORDER_BY.Value.TryGetValue(STAFF_ORDER_BY, out Value);
        }

        /// <summary>
        /// Attempt to find CRPR by STAFF_ORDER_BY field
        /// </summary>
        /// <param name="STAFF_ORDER_BY">STAFF_ORDER_BY value used to find CRPR</param>
        /// <returns>List of related CRPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> TryFindBySTAFF_ORDER_BY(string STAFF_ORDER_BY)
        {
            IReadOnlyList<CRPR> value;
            if (Index_STAFF_ORDER_BY.Value.TryGetValue(STAFF_ORDER_BY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRPR by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find CRPR</param>
        /// <returns>List of related CRPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find CRPR by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find CRPR</param>
        /// <param name="Value">List of related CRPR entities</param>
        /// <returns>True if the list of related CRPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<CRPR> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find CRPR by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find CRPR</param>
        /// <returns>List of related CRPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<CRPR> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRPR</param>
        /// <returns>Related CRPR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRPR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find CRPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRPR</param>
        /// <param name="Value">Related CRPR entity</param>
        /// <returns>True if the related CRPR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out CRPR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find CRPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRPR</param>
        /// <returns>Related CRPR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRPR TryFindByTID(int TID)
        {
            CRPR value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRPR by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRPR</param>
        /// <returns>List of related CRPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find CRPR by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRPR</param>
        /// <param name="Value">List of related CRPR entities</param>
        /// <returns>True if the list of related CRPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<CRPR> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find CRPR by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRPR</param>
        /// <returns>List of related CRPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRPR> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<CRPR> value;
            if (Index_TRREF.Value.TryGetValue(TRREF, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a CRPR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[CRPR](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRTYPE] varchar(1) NULL,
        [TRDATE] datetime NULL,
        [TRREF] varchar(10) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [TRXCODE] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [INITIATIVE] varchar(3) NULL,
        [TRCOST] money NULL,
        [TRQTY] int NULL,
        [TRDET] varchar(30) NULL,
        [TRORDER] varchar(10) NULL,
        [STAFF_ORDER_BY] varchar(4) NULL,
        [APPROVED_BY] varchar(4) NULL,
        [POCOMMENT] varchar(MAX) NULL,
        [TRNETT] money NULL,
        [LINE_NO] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [CRPR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [CRPR_Index_APPROVED_BY] ON [dbo].[CRPR]
    (
            [APPROVED_BY] ASC
    );
    CREATE CLUSTERED INDEX [CRPR_Index_CODE] ON [dbo].[CRPR]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [CRPR_Index_INITIATIVE] ON [dbo].[CRPR]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [CRPR_Index_STAFF_ORDER_BY] ON [dbo].[CRPR]
    (
            [STAFF_ORDER_BY] ASC
    );
    CREATE NONCLUSTERED INDEX [CRPR_Index_SUBPROGRAM] ON [dbo].[CRPR]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [CRPR_Index_TRREF] ON [dbo].[CRPR]
    (
            [TRREF] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_APPROVED_BY')
    ALTER INDEX [Index_APPROVED_BY] ON [dbo].[CRPR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[CRPR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_STAFF_ORDER_BY')
    ALTER INDEX [Index_STAFF_ORDER_BY] ON [dbo].[CRPR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[CRPR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[CRPR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[CRPR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_APPROVED_BY')
    ALTER INDEX [Index_APPROVED_BY] ON [dbo].[CRPR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[CRPR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_STAFF_ORDER_BY')
    ALTER INDEX [Index_STAFF_ORDER_BY] ON [dbo].[CRPR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[CRPR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[CRPR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRPR]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[CRPR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="CRPR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="CRPR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<CRPR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[CRPR] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CRPR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRPR data set</returns>
        public override EduHubDataSetDataReader<CRPR> GetDataSetDataReader()
        {
            return new CRPRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CRPR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRPR data set</returns>
        public override EduHubDataSetDataReader<CRPR> GetDataSetDataReader(List<CRPR> Entities)
        {
            return new CRPRDataReader(new EduHubDataSetLoadedReader<CRPR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class CRPRDataReader : EduHubDataSetDataReader<CRPR>
        {
            public CRPRDataReader(IEduHubDataSetReader<CRPR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 21; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // TRTYPE
                        return Current.TRTYPE;
                    case 3: // TRDATE
                        return Current.TRDATE;
                    case 4: // TRREF
                        return Current.TRREF;
                    case 5: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 6: // TRXCODE
                        return Current.TRXCODE;
                    case 7: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 8: // INITIATIVE
                        return Current.INITIATIVE;
                    case 9: // TRCOST
                        return Current.TRCOST;
                    case 10: // TRQTY
                        return Current.TRQTY;
                    case 11: // TRDET
                        return Current.TRDET;
                    case 12: // TRORDER
                        return Current.TRORDER;
                    case 13: // STAFF_ORDER_BY
                        return Current.STAFF_ORDER_BY;
                    case 14: // APPROVED_BY
                        return Current.APPROVED_BY;
                    case 15: // POCOMMENT
                        return Current.POCOMMENT;
                    case 16: // TRNETT
                        return Current.TRNETT;
                    case 17: // LINE_NO
                        return Current.LINE_NO;
                    case 18: // LW_DATE
                        return Current.LW_DATE;
                    case 19: // LW_TIME
                        return Current.LW_TIME;
                    case 20: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRTYPE
                        return Current.TRTYPE == null;
                    case 3: // TRDATE
                        return Current.TRDATE == null;
                    case 4: // TRREF
                        return Current.TRREF == null;
                    case 5: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 6: // TRXCODE
                        return Current.TRXCODE == null;
                    case 7: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 8: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 9: // TRCOST
                        return Current.TRCOST == null;
                    case 10: // TRQTY
                        return Current.TRQTY == null;
                    case 11: // TRDET
                        return Current.TRDET == null;
                    case 12: // TRORDER
                        return Current.TRORDER == null;
                    case 13: // STAFF_ORDER_BY
                        return Current.STAFF_ORDER_BY == null;
                    case 14: // APPROVED_BY
                        return Current.APPROVED_BY == null;
                    case 15: // POCOMMENT
                        return Current.POCOMMENT == null;
                    case 16: // TRNETT
                        return Current.TRNETT == null;
                    case 17: // LINE_NO
                        return Current.LINE_NO == null;
                    case 18: // LW_DATE
                        return Current.LW_DATE == null;
                    case 19: // LW_TIME
                        return Current.LW_TIME == null;
                    case 20: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRTYPE
                        return "TRTYPE";
                    case 3: // TRDATE
                        return "TRDATE";
                    case 4: // TRREF
                        return "TRREF";
                    case 5: // TRXLEDGER
                        return "TRXLEDGER";
                    case 6: // TRXCODE
                        return "TRXCODE";
                    case 7: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 8: // INITIATIVE
                        return "INITIATIVE";
                    case 9: // TRCOST
                        return "TRCOST";
                    case 10: // TRQTY
                        return "TRQTY";
                    case 11: // TRDET
                        return "TRDET";
                    case 12: // TRORDER
                        return "TRORDER";
                    case 13: // STAFF_ORDER_BY
                        return "STAFF_ORDER_BY";
                    case 14: // APPROVED_BY
                        return "APPROVED_BY";
                    case 15: // POCOMMENT
                        return "POCOMMENT";
                    case 16: // TRNETT
                        return "TRNETT";
                    case 17: // LINE_NO
                        return "LINE_NO";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "TRTYPE":
                        return 2;
                    case "TRDATE":
                        return 3;
                    case "TRREF":
                        return 4;
                    case "TRXLEDGER":
                        return 5;
                    case "TRXCODE":
                        return 6;
                    case "SUBPROGRAM":
                        return 7;
                    case "INITIATIVE":
                        return 8;
                    case "TRCOST":
                        return 9;
                    case "TRQTY":
                        return 10;
                    case "TRDET":
                        return 11;
                    case "TRORDER":
                        return 12;
                    case "STAFF_ORDER_BY":
                        return 13;
                    case "APPROVED_BY":
                        return 14;
                    case "POCOMMENT":
                        return 15;
                    case "TRNETT":
                        return 16;
                    case "LINE_NO":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
