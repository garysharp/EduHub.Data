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
    /// Rooms group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMGROUPDataSet : EduHubDataSet<SMGROUP>
    {
        /// <inheritdoc />
        public override string Name { get { return "SMGROUP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SMGROUPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GROUPKEY = new Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>>(() => this.ToGroupedDictionary(i => i.GROUPKEY));
            Index_GROUPKEY_ROOM = new Lazy<Dictionary<Tuple<string, string>, SMGROUP>>(() => this.ToDictionary(i => Tuple.Create(i.GROUPKEY, i.ROOM)));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SMGROUP>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_TID = new Lazy<Dictionary<int, SMGROUP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMGROUP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMGROUP" /> fields for each CSV column header</returns>
        internal override Action<SMGROUP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMGROUP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GROUPKEY":
                        mapper[i] = (e, v) => e.GROUPKEY = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
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
        /// Merges <see cref="SMGROUP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SMGROUP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SMGROUP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SMGROUP}"/> of entities</returns>
        internal override IEnumerable<SMGROUP> ApplyDeltaEntities(IEnumerable<SMGROUP> Entities, List<SMGROUP> DeltaEntities)
        {
            HashSet<Tuple<string, string>> Index_GROUPKEY_ROOM = new HashSet<Tuple<string, string>>(DeltaEntities.Select(i => Tuple.Create(i.GROUPKEY, i.ROOM)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.GROUPKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_GROUPKEY_ROOM.Remove(Tuple.Create(entity.GROUPKEY, entity.ROOM));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.GROUPKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>> Index_GROUPKEY;
        private Lazy<Dictionary<Tuple<string, string>, SMGROUP>> Index_GROUPKEY_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<SMGROUP>>> Index_ROOM;
        private Lazy<Dictionary<int, SMGROUP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> FindByGROUPKEY(string GROUPKEY)
        {
            return Index_GROUPKEY.Value[GROUPKEY];
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="Value">List of related SMGROUP entities</param>
        /// <returns>True if the list of related SMGROUP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGROUPKEY(string GROUPKEY, out IReadOnlyList<SMGROUP> Value)
        {
            return Index_GROUPKEY.Value.TryGetValue(GROUPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY field
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> TryFindByGROUPKEY(string GROUPKEY)
        {
            IReadOnlyList<SMGROUP> value;
            if (Index_GROUPKEY.Value.TryGetValue(GROUPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP FindByGROUPKEY_ROOM(string GROUPKEY, string ROOM)
        {
            return Index_GROUPKEY_ROOM.Value[Tuple.Create(GROUPKEY, ROOM)];
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <param name="Value">Related SMGROUP entity</param>
        /// <returns>True if the related SMGROUP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGROUPKEY_ROOM(string GROUPKEY, string ROOM, out SMGROUP Value)
        {
            return Index_GROUPKEY_ROOM.Value.TryGetValue(Tuple.Create(GROUPKEY, ROOM), out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by GROUPKEY and ROOM fields
        /// </summary>
        /// <param name="GROUPKEY">GROUPKEY value used to find SMGROUP</param>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP TryFindByGROUPKEY_ROOM(string GROUPKEY, string ROOM)
        {
            SMGROUP value;
            if (Index_GROUPKEY_ROOM.Value.TryGetValue(Tuple.Create(GROUPKEY, ROOM), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <param name="Value">List of related SMGROUP entities</param>
        /// <returns>True if the list of related SMGROUP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SMGROUP> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP</param>
        /// <returns>List of related SMGROUP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMGROUP> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SMGROUP> value;
            if (Index_ROOM.Value.TryGetValue(ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <param name="Value">Related SMGROUP entity</param>
        /// <returns>True if the related SMGROUP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMGROUP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMGROUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMGROUP</param>
        /// <returns>Related SMGROUP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMGROUP TryFindByTID(int TID)
        {
            SMGROUP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SMGROUP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMGROUP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMGROUP](
        [TID] int IDENTITY NOT NULL,
        [GROUPKEY] varchar(4) NOT NULL,
        [ROOM] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMGROUP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SMGROUP_Index_GROUPKEY] ON [dbo].[SMGROUP]
    (
            [GROUPKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SMGROUP_Index_GROUPKEY_ROOM] ON [dbo].[SMGROUP]
    (
            [GROUPKEY] ASC,
            [ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [SMGROUP_Index_ROOM] ON [dbo].[SMGROUP]
    (
            [ROOM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMGROUP]') AND name = N'Index_GROUPKEY_ROOM')
    ALTER INDEX [Index_GROUPKEY_ROOM] ON [dbo].[SMGROUP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMGROUP]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[SMGROUP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMGROUP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SMGROUP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMGROUP]') AND name = N'Index_GROUPKEY_ROOM')
    ALTER INDEX [Index_GROUPKEY_ROOM] ON [dbo].[SMGROUP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMGROUP]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[SMGROUP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMGROUP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SMGROUP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SMGROUP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SMGROUP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SMGROUP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, string>> Index_GROUPKEY_ROOM = new List<Tuple<string, string>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_GROUPKEY_ROOM.Add(Tuple.Create(entity.GROUPKEY, entity.ROOM));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SMGROUP] WHERE");


            // Index_GROUPKEY_ROOM
            builder.Append("(");
            for (int index = 0; index < Index_GROUPKEY_ROOM.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // GROUPKEY
                var parameterGROUPKEY = $"@p{parameterIndex++}";
                builder.Append("([GROUPKEY]=").Append(parameterGROUPKEY);
                command.Parameters.Add(parameterGROUPKEY, SqlDbType.VarChar, 4).Value = Index_GROUPKEY_ROOM[index].Item1;

                // ROOM
                if (Index_GROUPKEY_ROOM[index].Item2 == null)
                {
                    builder.Append(" AND [ROOM] IS NULL)");
                }
                else
                {
                    var parameterROOM = $"@p{parameterIndex++}";
                    builder.Append(" AND [ROOM]=").Append(parameterROOM).Append(")");
                    command.Parameters.Add(parameterROOM, SqlDbType.VarChar, 4).Value = Index_GROUPKEY_ROOM[index].Item2;
                }
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
        /// Provides a <see cref="IDataReader"/> for the SMGROUP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMGROUP data set</returns>
        public override EduHubDataSetDataReader<SMGROUP> GetDataSetDataReader()
        {
            return new SMGROUPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMGROUP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMGROUP data set</returns>
        public override EduHubDataSetDataReader<SMGROUP> GetDataSetDataReader(List<SMGROUP> Entities)
        {
            return new SMGROUPDataReader(new EduHubDataSetLoadedReader<SMGROUP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMGROUPDataReader : EduHubDataSetDataReader<SMGROUP>
        {
            public SMGROUPDataReader(IEduHubDataSetReader<SMGROUP> Reader)
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
                    case 1: // GROUPKEY
                        return Current.GROUPKEY;
                    case 2: // ROOM
                        return Current.ROOM;
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
                    case 2: // ROOM
                        return Current.ROOM == null;
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
                    case 1: // GROUPKEY
                        return "GROUPKEY";
                    case 2: // ROOM
                        return "ROOM";
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
                    case "GROUPKEY":
                        return 1;
                    case "ROOM":
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
