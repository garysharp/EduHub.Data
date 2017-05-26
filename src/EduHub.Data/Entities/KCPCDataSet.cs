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
    /// Creditor Purchasing Card Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCPCDataSet : EduHubDataSet<KCPC>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCPC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCPCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<KCPC>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<KCPC>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, KCPC>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCPC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCPC" /> fields for each CSV column header</returns>
        internal override Action<KCPC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCPC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "CARDHOLDER_NAME":
                        mapper[i] = (e, v) => e.CARDHOLDER_NAME = v;
                        break;
                    case "CARD_NO":
                        mapper[i] = (e, v) => e.CARD_NO = v;
                        break;
                    case "STAFF_POSITION":
                        mapper[i] = (e, v) => e.STAFF_POSITION = v;
                        break;
                    case "ISSUE_DATE":
                        mapper[i] = (e, v) => e.ISSUE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXPIRY_MONTH":
                        mapper[i] = (e, v) => e.EXPIRY_MONTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXPIRY_YEAR":
                        mapper[i] = (e, v) => e.EXPIRY_YEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNDERTAKING_CARDHOLDER":
                        mapper[i] = (e, v) => e.UNDERTAKING_CARDHOLDER = v;
                        break;
                    case "CARD_LIMIT":
                        mapper[i] = (e, v) => e.CARD_LIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CHANGE_LIMIT":
                        mapper[i] = (e, v) => e.CHANGE_LIMIT = v;
                        break;
                    case "CANCELLATION_DATE":
                        mapper[i] = (e, v) => e.CANCELLATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "PROCESSED":
                        mapper[i] = (e, v) => e.PROCESSED = v;
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
        /// Merges <see cref="KCPC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCPC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCPC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCPC}"/> of entities</returns>
        internal override IEnumerable<KCPC> ApplyDeltaEntities(IEnumerable<KCPC> Entities, List<KCPC> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<KCPC>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<KCPC>>> Index_STAFF;
        private Lazy<Dictionary<int, KCPC>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCPC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KCPC</param>
        /// <returns>List of related KCPC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCPC> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find KCPC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KCPC</param>
        /// <param name="Value">List of related KCPC entities</param>
        /// <returns>True if the list of related KCPC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<KCPC> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find KCPC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KCPC</param>
        /// <returns>List of related KCPC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCPC> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<KCPC> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCPC by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find KCPC</param>
        /// <returns>List of related KCPC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCPC> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find KCPC by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find KCPC</param>
        /// <param name="Value">List of related KCPC entities</param>
        /// <returns>True if the list of related KCPC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<KCPC> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find KCPC by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find KCPC</param>
        /// <returns>List of related KCPC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCPC> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<KCPC> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCPC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCPC</param>
        /// <returns>Related KCPC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCPC FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KCPC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCPC</param>
        /// <param name="Value">Related KCPC entity</param>
        /// <returns>True if the related KCPC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KCPC Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KCPC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCPC</param>
        /// <returns>Related KCPC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCPC TryFindByTID(int TID)
        {
            KCPC value;
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

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCPC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCPC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCPC](
        [TID] int IDENTITY NOT NULL,
        [STAFF] varchar(4) NULL,
        [CARDHOLDER_NAME] varchar(30) NULL,
        [CARD_NO] varchar(4) NULL,
        [STAFF_POSITION] varchar(10) NULL,
        [ISSUE_DATE] datetime NULL,
        [EXPIRY_MONTH] smallint NULL,
        [EXPIRY_YEAR] smallint NULL,
        [CAMPUS] int NULL,
        [UNDERTAKING_CARDHOLDER] varchar(3) NULL,
        [CARD_LIMIT] money NULL,
        [CHANGE_LIMIT] varchar(MAX) NULL,
        [CANCELLATION_DATE] datetime NULL,
        [ACTIVE] varchar(1) NULL,
        [PROCESSED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCPC_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCPC_Index_CAMPUS] ON [dbo].[KCPC]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [KCPC_Index_STAFF] ON [dbo].[KCPC]
    (
            [STAFF] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCPC]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[KCPC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCPC]') AND name = N'Index_STAFF')
    ALTER INDEX [Index_STAFF] ON [dbo].[KCPC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCPC]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[KCPC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCPC]') AND name = N'Index_STAFF')
    ALTER INDEX [Index_STAFF] ON [dbo].[KCPC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCPC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCPC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCPC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KCPC] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the KCPC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCPC data set</returns>
        public override EduHubDataSetDataReader<KCPC> GetDataSetDataReader()
        {
            return new KCPCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCPC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCPC data set</returns>
        public override EduHubDataSetDataReader<KCPC> GetDataSetDataReader(List<KCPC> Entities)
        {
            return new KCPCDataReader(new EduHubDataSetLoadedReader<KCPC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCPCDataReader : EduHubDataSetDataReader<KCPC>
        {
            public KCPCDataReader(IEduHubDataSetReader<KCPC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 18; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // STAFF
                        return Current.STAFF;
                    case 2: // CARDHOLDER_NAME
                        return Current.CARDHOLDER_NAME;
                    case 3: // CARD_NO
                        return Current.CARD_NO;
                    case 4: // STAFF_POSITION
                        return Current.STAFF_POSITION;
                    case 5: // ISSUE_DATE
                        return Current.ISSUE_DATE;
                    case 6: // EXPIRY_MONTH
                        return Current.EXPIRY_MONTH;
                    case 7: // EXPIRY_YEAR
                        return Current.EXPIRY_YEAR;
                    case 8: // CAMPUS
                        return Current.CAMPUS;
                    case 9: // UNDERTAKING_CARDHOLDER
                        return Current.UNDERTAKING_CARDHOLDER;
                    case 10: // CARD_LIMIT
                        return Current.CARD_LIMIT;
                    case 11: // CHANGE_LIMIT
                        return Current.CHANGE_LIMIT;
                    case 12: // CANCELLATION_DATE
                        return Current.CANCELLATION_DATE;
                    case 13: // ACTIVE
                        return Current.ACTIVE;
                    case 14: // PROCESSED
                        return Current.PROCESSED;
                    case 15: // LW_DATE
                        return Current.LW_DATE;
                    case 16: // LW_TIME
                        return Current.LW_TIME;
                    case 17: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // STAFF
                        return Current.STAFF == null;
                    case 2: // CARDHOLDER_NAME
                        return Current.CARDHOLDER_NAME == null;
                    case 3: // CARD_NO
                        return Current.CARD_NO == null;
                    case 4: // STAFF_POSITION
                        return Current.STAFF_POSITION == null;
                    case 5: // ISSUE_DATE
                        return Current.ISSUE_DATE == null;
                    case 6: // EXPIRY_MONTH
                        return Current.EXPIRY_MONTH == null;
                    case 7: // EXPIRY_YEAR
                        return Current.EXPIRY_YEAR == null;
                    case 8: // CAMPUS
                        return Current.CAMPUS == null;
                    case 9: // UNDERTAKING_CARDHOLDER
                        return Current.UNDERTAKING_CARDHOLDER == null;
                    case 10: // CARD_LIMIT
                        return Current.CARD_LIMIT == null;
                    case 11: // CHANGE_LIMIT
                        return Current.CHANGE_LIMIT == null;
                    case 12: // CANCELLATION_DATE
                        return Current.CANCELLATION_DATE == null;
                    case 13: // ACTIVE
                        return Current.ACTIVE == null;
                    case 14: // PROCESSED
                        return Current.PROCESSED == null;
                    case 15: // LW_DATE
                        return Current.LW_DATE == null;
                    case 16: // LW_TIME
                        return Current.LW_TIME == null;
                    case 17: // LW_USER
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
                    case 1: // STAFF
                        return "STAFF";
                    case 2: // CARDHOLDER_NAME
                        return "CARDHOLDER_NAME";
                    case 3: // CARD_NO
                        return "CARD_NO";
                    case 4: // STAFF_POSITION
                        return "STAFF_POSITION";
                    case 5: // ISSUE_DATE
                        return "ISSUE_DATE";
                    case 6: // EXPIRY_MONTH
                        return "EXPIRY_MONTH";
                    case 7: // EXPIRY_YEAR
                        return "EXPIRY_YEAR";
                    case 8: // CAMPUS
                        return "CAMPUS";
                    case 9: // UNDERTAKING_CARDHOLDER
                        return "UNDERTAKING_CARDHOLDER";
                    case 10: // CARD_LIMIT
                        return "CARD_LIMIT";
                    case 11: // CHANGE_LIMIT
                        return "CHANGE_LIMIT";
                    case 12: // CANCELLATION_DATE
                        return "CANCELLATION_DATE";
                    case 13: // ACTIVE
                        return "ACTIVE";
                    case 14: // PROCESSED
                        return "PROCESSED";
                    case 15: // LW_DATE
                        return "LW_DATE";
                    case 16: // LW_TIME
                        return "LW_TIME";
                    case 17: // LW_USER
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
                    case "STAFF":
                        return 1;
                    case "CARDHOLDER_NAME":
                        return 2;
                    case "CARD_NO":
                        return 3;
                    case "STAFF_POSITION":
                        return 4;
                    case "ISSUE_DATE":
                        return 5;
                    case "EXPIRY_MONTH":
                        return 6;
                    case "EXPIRY_YEAR":
                        return 7;
                    case "CAMPUS":
                        return 8;
                    case "UNDERTAKING_CARDHOLDER":
                        return 9;
                    case "CARD_LIMIT":
                        return 10;
                    case "CHANGE_LIMIT":
                        return 11;
                    case "CANCELLATION_DATE":
                        return 12;
                    case "ACTIVE":
                        return 13;
                    case "PROCESSED":
                        return 14;
                    case "LW_DATE":
                        return 15;
                    case "LW_TIME":
                        return 16;
                    case "LW_USER":
                        return 17;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
