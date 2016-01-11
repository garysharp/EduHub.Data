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
    /// Asset Key Holders Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKKDataSet : EduHubDataSet<AKK>
    {
        /// <inheritdoc />
        public override string Name { get { return "AKK"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal AKKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<AKK>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<AKK>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, AKK>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKK" /> fields for each CSV column header</returns>
        internal override Action<AKK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
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
        /// Merges <see cref="AKK" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AKK" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AKK" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AKK}"/> of entities</returns>
        internal override IEnumerable<AKK> ApplyDeltaEntities(IEnumerable<AKK> Entities, List<AKK> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<AKK>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<AKK>>> Index_STAFF;
        private Lazy<Dictionary<int, AKK>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find AKK</param>
        /// <returns>List of related AKK entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKK> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find AKK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find AKK</param>
        /// <param name="Value">List of related AKK entities</param>
        /// <returns>True if the list of related AKK entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<AKK> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find AKK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find AKK</param>
        /// <returns>List of related AKK entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKK> TryFindByCODE(string CODE)
        {
            IReadOnlyList<AKK> value;
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
        /// Find AKK by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find AKK</param>
        /// <returns>List of related AKK entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKK> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find AKK by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find AKK</param>
        /// <param name="Value">List of related AKK entities</param>
        /// <returns>True if the list of related AKK entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<AKK> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find AKK by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find AKK</param>
        /// <returns>List of related AKK entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKK> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<AKK> value;
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
        /// Find AKK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AKK</param>
        /// <returns>Related AKK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKK FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find AKK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AKK</param>
        /// <param name="Value">Related AKK entity</param>
        /// <returns>True if the related AKK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out AKK Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find AKK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AKK</param>
        /// <returns>Related AKK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKK TryFindByTID(int TID)
        {
            AKK value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AKK table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKK]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKK](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [STAFF] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKK_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [AKK_Index_CODE] ON [dbo].[AKK]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [AKK_Index_STAFF] ON [dbo].[AKK]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKK]') AND name = N'Index_STAFF')
    ALTER INDEX [Index_STAFF] ON [dbo].[AKK] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKK]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[AKK] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKK]') AND name = N'Index_STAFF')
    ALTER INDEX [Index_STAFF] ON [dbo].[AKK] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKK]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[AKK] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AKK"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AKK"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AKK> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[AKK] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the AKK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKK data set</returns>
        public override EduHubDataSetDataReader<AKK> GetDataSetDataReader()
        {
            return new AKKDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKK data set</returns>
        public override EduHubDataSetDataReader<AKK> GetDataSetDataReader(List<AKK> Entities)
        {
            return new AKKDataReader(new EduHubDataSetLoadedReader<AKK>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKKDataReader : EduHubDataSetDataReader<AKK>
        {
            public AKKDataReader(IEduHubDataSetReader<AKK> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // STAFF
                        return Current.STAFF;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // STAFF
                        return Current.STAFF == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_USER
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
                    case 2: // STAFF
                        return "STAFF";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
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
                    case "STAFF":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
