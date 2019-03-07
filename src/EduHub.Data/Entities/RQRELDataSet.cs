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
    /// Staff Purchasing Group Link Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQRELDataSet : EduHubDataSet<RQREL>
    {
        /// <inheritdoc />
        public override string Name { get { return "RQREL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal RQRELDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_RQPGKEY = new Lazy<Dictionary<string, IReadOnlyList<RQREL>>>(() => this.ToGroupedDictionary(i => i.RQPGKEY));
            Index_SFKEY = new Lazy<NullDictionary<string, IReadOnlyList<RQREL>>>(() => this.ToGroupedNullDictionary(i => i.SFKEY));
            Index_SFKEY_RQPGKEY = new Lazy<Dictionary<Tuple<string, string>, RQREL>>(() => this.ToDictionary(i => Tuple.Create(i.SFKEY, i.RQPGKEY)));
            Index_TID = new Lazy<Dictionary<int, RQREL>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="RQREL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="RQREL" /> fields for each CSV column header</returns>
        internal override Action<RQREL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<RQREL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "RQPGKEY":
                        mapper[i] = (e, v) => e.RQPGKEY = v;
                        break;
                    case "SFKEY":
                        mapper[i] = (e, v) => e.SFKEY = v;
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
        /// Merges <see cref="RQREL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="RQREL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="RQREL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{RQREL}"/> of entities</returns>
        internal override IEnumerable<RQREL> ApplyDeltaEntities(IEnumerable<RQREL> Entities, List<RQREL> DeltaEntities)
        {
            HashSet<Tuple<string, string>> Index_SFKEY_RQPGKEY = new HashSet<Tuple<string, string>>(DeltaEntities.Select(i => Tuple.Create(i.SFKEY, i.RQPGKEY)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.RQPGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_SFKEY_RQPGKEY.Remove(Tuple.Create(entity.SFKEY, entity.RQPGKEY));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.RQPGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<RQREL>>> Index_RQPGKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<RQREL>>> Index_SFKEY;
        private Lazy<Dictionary<Tuple<string, string>, RQREL>> Index_SFKEY_RQPGKEY;
        private Lazy<Dictionary<int, RQREL>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find RQREL by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQREL</param>
        /// <returns>List of related RQREL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQREL> FindByRQPGKEY(string RQPGKEY)
        {
            return Index_RQPGKEY.Value[RQPGKEY];
        }

        /// <summary>
        /// Attempt to find RQREL by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQREL</param>
        /// <param name="Value">List of related RQREL entities</param>
        /// <returns>True if the list of related RQREL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRQPGKEY(string RQPGKEY, out IReadOnlyList<RQREL> Value)
        {
            return Index_RQPGKEY.Value.TryGetValue(RQPGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find RQREL by RQPGKEY field
        /// </summary>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQREL</param>
        /// <returns>List of related RQREL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQREL> TryFindByRQPGKEY(string RQPGKEY)
        {
            IReadOnlyList<RQREL> value;
            if (Index_RQPGKEY.Value.TryGetValue(RQPGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQREL by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQREL</param>
        /// <returns>List of related RQREL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQREL> FindBySFKEY(string SFKEY)
        {
            return Index_SFKEY.Value[SFKEY];
        }

        /// <summary>
        /// Attempt to find RQREL by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQREL</param>
        /// <param name="Value">List of related RQREL entities</param>
        /// <returns>True if the list of related RQREL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySFKEY(string SFKEY, out IReadOnlyList<RQREL> Value)
        {
            return Index_SFKEY.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find RQREL by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQREL</param>
        /// <returns>List of related RQREL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQREL> TryFindBySFKEY(string SFKEY)
        {
            IReadOnlyList<RQREL> value;
            if (Index_SFKEY.Value.TryGetValue(SFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQREL by SFKEY and RQPGKEY fields
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQREL</param>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQREL</param>
        /// <returns>Related RQREL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQREL FindBySFKEY_RQPGKEY(string SFKEY, string RQPGKEY)
        {
            return Index_SFKEY_RQPGKEY.Value[Tuple.Create(SFKEY, RQPGKEY)];
        }

        /// <summary>
        /// Attempt to find RQREL by SFKEY and RQPGKEY fields
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQREL</param>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQREL</param>
        /// <param name="Value">Related RQREL entity</param>
        /// <returns>True if the related RQREL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySFKEY_RQPGKEY(string SFKEY, string RQPGKEY, out RQREL Value)
        {
            return Index_SFKEY_RQPGKEY.Value.TryGetValue(Tuple.Create(SFKEY, RQPGKEY), out Value);
        }

        /// <summary>
        /// Attempt to find RQREL by SFKEY and RQPGKEY fields
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find RQREL</param>
        /// <param name="RQPGKEY">RQPGKEY value used to find RQREL</param>
        /// <returns>Related RQREL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQREL TryFindBySFKEY_RQPGKEY(string SFKEY, string RQPGKEY)
        {
            RQREL value;
            if (Index_SFKEY_RQPGKEY.Value.TryGetValue(Tuple.Create(SFKEY, RQPGKEY), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQREL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQREL</param>
        /// <returns>Related RQREL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQREL FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find RQREL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQREL</param>
        /// <param name="Value">Related RQREL entity</param>
        /// <returns>True if the related RQREL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out RQREL Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find RQREL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQREL</param>
        /// <returns>Related RQREL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQREL TryFindByTID(int TID)
        {
            RQREL value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a RQREL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[RQREL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[RQREL](
        [TID] int IDENTITY NOT NULL,
        [RQPGKEY] varchar(10) NOT NULL,
        [SFKEY] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [RQREL_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [RQREL_Index_RQPGKEY] ON [dbo].[RQREL]
    (
            [RQPGKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [RQREL_Index_SFKEY] ON [dbo].[RQREL]
    (
            [SFKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [RQREL_Index_SFKEY_RQPGKEY] ON [dbo].[RQREL]
    (
            [SFKEY] ASC,
            [RQPGKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQREL]') AND name = N'Index_SFKEY')
    ALTER INDEX [Index_SFKEY] ON [dbo].[RQREL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQREL]') AND name = N'Index_SFKEY_RQPGKEY')
    ALTER INDEX [Index_SFKEY_RQPGKEY] ON [dbo].[RQREL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQREL]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[RQREL] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQREL]') AND name = N'Index_SFKEY')
    ALTER INDEX [Index_SFKEY] ON [dbo].[RQREL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQREL]') AND name = N'Index_SFKEY_RQPGKEY')
    ALTER INDEX [Index_SFKEY_RQPGKEY] ON [dbo].[RQREL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQREL]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[RQREL] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="RQREL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="RQREL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<RQREL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, string>> Index_SFKEY_RQPGKEY = new List<Tuple<string, string>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SFKEY_RQPGKEY.Add(Tuple.Create(entity.SFKEY, entity.RQPGKEY));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[RQREL] WHERE");


            // Index_SFKEY_RQPGKEY
            builder.Append("(");
            for (int index = 0; index < Index_SFKEY_RQPGKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // SFKEY
                if (Index_SFKEY_RQPGKEY[index].Item1 == null)
                {
                    builder.Append("([SFKEY] IS NULL");
                }
                else
                {
                    var parameterSFKEY = $"@p{parameterIndex++}";
                    builder.Append("([SFKEY]=").Append(parameterSFKEY);
                    command.Parameters.Add(parameterSFKEY, SqlDbType.VarChar, 4).Value = Index_SFKEY_RQPGKEY[index].Item1;
                }

                // RQPGKEY
                var parameterRQPGKEY = $"@p{parameterIndex++}";
                builder.Append(" AND [RQPGKEY]=").Append(parameterRQPGKEY).Append(")");
                command.Parameters.Add(parameterRQPGKEY, SqlDbType.VarChar, 10).Value = Index_SFKEY_RQPGKEY[index].Item2;
            }
            builder.AppendLine(") OR");

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
        /// Provides a <see cref="IDataReader"/> for the RQREL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQREL data set</returns>
        public override EduHubDataSetDataReader<RQREL> GetDataSetDataReader()
        {
            return new RQRELDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the RQREL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQREL data set</returns>
        public override EduHubDataSetDataReader<RQREL> GetDataSetDataReader(List<RQREL> Entities)
        {
            return new RQRELDataReader(new EduHubDataSetLoadedReader<RQREL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class RQRELDataReader : EduHubDataSetDataReader<RQREL>
        {
            public RQRELDataReader(IEduHubDataSetReader<RQREL> Reader)
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
                    case 1: // RQPGKEY
                        return Current.RQPGKEY;
                    case 2: // SFKEY
                        return Current.SFKEY;
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
                    case 2: // SFKEY
                        return Current.SFKEY == null;
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
                    case 1: // RQPGKEY
                        return "RQPGKEY";
                    case 2: // SFKEY
                        return "SFKEY";
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
                    case "RQPGKEY":
                        return 1;
                    case "SFKEY":
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
