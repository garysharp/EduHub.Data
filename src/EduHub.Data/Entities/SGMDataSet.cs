#if !EduHubScoped
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
    /// Special Group Meetings Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGMDataSet : EduHubDataSet<SGM>
    {
        /// <inheritdoc />
        public override string Name { get { return "SGM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SGMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_MEETING_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SGM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_DATE));
            Index_MEETING_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SGM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_ROOM));
            Index_SGMKEY = new Lazy<Dictionary<string, IReadOnlyList<SGM>>>(() => this.ToGroupedDictionary(i => i.SGMKEY));
            Index_SGMKEY_MEETING_DATE_MEETING_TIME = new Lazy<Dictionary<Tuple<string, DateTime?, short?>, SGM>>(() => this.ToDictionary(i => Tuple.Create(i.SGMKEY, i.MEETING_DATE, i.MEETING_TIME)));
            Index_TID = new Lazy<Dictionary<int, SGM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGM" /> fields for each CSV column header</returns>
        internal override Action<SGM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGMKEY":
                        mapper[i] = (e, v) => e.SGMKEY = v;
                        break;
                    case "MEETING_DATE":
                        mapper[i] = (e, v) => e.MEETING_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "MEETING_TIME":
                        mapper[i] = (e, v) => e.MEETING_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PURPOSE_BRIEF":
                        mapper[i] = (e, v) => e.PURPOSE_BRIEF = v;
                        break;
                    case "PURPOSE_DETAIL":
                        mapper[i] = (e, v) => e.PURPOSE_DETAIL = v;
                        break;
                    case "MEETING_ROOM":
                        mapper[i] = (e, v) => e.MEETING_ROOM = v;
                        break;
                    case "MINUTES_MEMO":
                        mapper[i] = (e, v) => e.MINUTES_MEMO = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SGM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SGM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SGM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SGM}"/> of entities</returns>
        internal override IEnumerable<SGM> ApplyDeltaEntities(IEnumerable<SGM> Entities, List<SGM> DeltaEntities)
        {
            HashSet<Tuple<string, DateTime?, short?>> Index_SGMKEY_MEETING_DATE_MEETING_TIME = new HashSet<Tuple<string, DateTime?, short?>>(DeltaEntities.Select(i => Tuple.Create(i.SGMKEY, i.MEETING_DATE, i.MEETING_TIME)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SGMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_SGMKEY_MEETING_DATE_MEETING_TIME.Remove(Tuple.Create(entity.SGMKEY, entity.MEETING_DATE, entity.MEETING_TIME));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.SGMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SGM>>> Index_MEETING_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SGM>>> Index_MEETING_ROOM;
        private Lazy<Dictionary<string, IReadOnlyList<SGM>>> Index_SGMKEY;
        private Lazy<Dictionary<Tuple<string, DateTime?, short?>, SGM>> Index_SGMKEY_MEETING_DATE_MEETING_TIME;
        private Lazy<Dictionary<int, SGM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGM by MEETING_DATE field
        /// </summary>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <returns>List of related SGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> FindByMEETING_DATE(DateTime? MEETING_DATE)
        {
            return Index_MEETING_DATE.Value[MEETING_DATE];
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_DATE field
        /// </summary>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <param name="Value">List of related SGM entities</param>
        /// <returns>True if the list of related SGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_DATE(DateTime? MEETING_DATE, out IReadOnlyList<SGM> Value)
        {
            return Index_MEETING_DATE.Value.TryGetValue(MEETING_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_DATE field
        /// </summary>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <returns>List of related SGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> TryFindByMEETING_DATE(DateTime? MEETING_DATE)
        {
            IReadOnlyList<SGM> value;
            if (Index_MEETING_DATE.Value.TryGetValue(MEETING_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SGM</param>
        /// <returns>List of related SGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> FindByMEETING_ROOM(string MEETING_ROOM)
        {
            return Index_MEETING_ROOM.Value[MEETING_ROOM];
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SGM</param>
        /// <param name="Value">List of related SGM entities</param>
        /// <returns>True if the list of related SGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_ROOM(string MEETING_ROOM, out IReadOnlyList<SGM> Value)
        {
            return Index_MEETING_ROOM.Value.TryGetValue(MEETING_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SGM</param>
        /// <returns>List of related SGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> TryFindByMEETING_ROOM(string MEETING_ROOM)
        {
            IReadOnlyList<SGM> value;
            if (Index_MEETING_ROOM.Value.TryGetValue(MEETING_ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGM by SGMKEY field
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <returns>List of related SGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> FindBySGMKEY(string SGMKEY)
        {
            return Index_SGMKEY.Value[SGMKEY];
        }

        /// <summary>
        /// Attempt to find SGM by SGMKEY field
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <param name="Value">List of related SGM entities</param>
        /// <returns>True if the list of related SGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMKEY(string SGMKEY, out IReadOnlyList<SGM> Value)
        {
            return Index_SGMKEY.Value.TryGetValue(SGMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by SGMKEY field
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <returns>List of related SGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGM> TryFindBySGMKEY(string SGMKEY)
        {
            IReadOnlyList<SGM> value;
            if (Index_SGMKEY.Value.TryGetValue(SGMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGM by SGMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SGM</param>
        /// <returns>Related SGM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGM FindBySGMKEY_MEETING_DATE_MEETING_TIME(string SGMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            return Index_SGMKEY_MEETING_DATE_MEETING_TIME.Value[Tuple.Create(SGMKEY, MEETING_DATE, MEETING_TIME)];
        }

        /// <summary>
        /// Attempt to find SGM by SGMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SGM</param>
        /// <param name="Value">Related SGM entity</param>
        /// <returns>True if the related SGM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMKEY_MEETING_DATE_MEETING_TIME(string SGMKEY, DateTime? MEETING_DATE, short? MEETING_TIME, out SGM Value)
        {
            return Index_SGMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SGMKEY, MEETING_DATE, MEETING_TIME), out Value);
        }

        /// <summary>
        /// Attempt to find SGM by SGMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SGMKEY">SGMKEY value used to find SGM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SGM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SGM</param>
        /// <returns>Related SGM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGM TryFindBySGMKEY_MEETING_DATE_MEETING_TIME(string SGMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            SGM value;
            if (Index_SGMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SGMKEY, MEETING_DATE, MEETING_TIME), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGM</param>
        /// <returns>Related SGM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGM</param>
        /// <param name="Value">Related SGM entity</param>
        /// <returns>True if the related SGM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGM</param>
        /// <returns>Related SGM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGM TryFindByTID(int TID)
        {
            SGM value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SGM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGM](
        [TID] int IDENTITY NOT NULL,
        [SGMKEY] varchar(12) NOT NULL,
        [MEETING_DATE] datetime NULL,
        [MEETING_TIME] smallint NULL,
        [PURPOSE_BRIEF] varchar(20) NULL,
        [PURPOSE_DETAIL] varchar(MAX) NULL,
        [MEETING_ROOM] varchar(4) NULL,
        [MINUTES_MEMO] varchar(MAX) NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SGM_Index_MEETING_DATE] ON [dbo].[SGM]
    (
            [MEETING_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SGM_Index_MEETING_ROOM] ON [dbo].[SGM]
    (
            [MEETING_ROOM] ASC
    );
    CREATE CLUSTERED INDEX [SGM_Index_SGMKEY] ON [dbo].[SGM]
    (
            [SGMKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SGM_Index_SGMKEY_MEETING_DATE_MEETING_TIME] ON [dbo].[SGM]
    (
            [SGMKEY] ASC,
            [MEETING_DATE] ASC,
            [MEETING_TIME] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND name = N'SGM_Index_MEETING_DATE')
    ALTER INDEX [SGM_Index_MEETING_DATE] ON [dbo].[SGM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND name = N'SGM_Index_MEETING_ROOM')
    ALTER INDEX [SGM_Index_MEETING_ROOM] ON [dbo].[SGM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND name = N'SGM_Index_SGMKEY_MEETING_DATE_MEETING_TIME')
    ALTER INDEX [SGM_Index_SGMKEY_MEETING_DATE_MEETING_TIME] ON [dbo].[SGM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND name = N'SGM_Index_TID')
    ALTER INDEX [SGM_Index_TID] ON [dbo].[SGM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND name = N'SGM_Index_MEETING_DATE')
    ALTER INDEX [SGM_Index_MEETING_DATE] ON [dbo].[SGM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND name = N'SGM_Index_MEETING_ROOM')
    ALTER INDEX [SGM_Index_MEETING_ROOM] ON [dbo].[SGM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND name = N'SGM_Index_SGMKEY_MEETING_DATE_MEETING_TIME')
    ALTER INDEX [SGM_Index_SGMKEY_MEETING_DATE_MEETING_TIME] ON [dbo].[SGM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGM]') AND name = N'SGM_Index_TID')
    ALTER INDEX [SGM_Index_TID] ON [dbo].[SGM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SGM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SGM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SGM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, DateTime?, short?>> Index_SGMKEY_MEETING_DATE_MEETING_TIME = new List<Tuple<string, DateTime?, short?>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SGMKEY_MEETING_DATE_MEETING_TIME.Add(Tuple.Create(entity.SGMKEY, entity.MEETING_DATE, entity.MEETING_TIME));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SGM] WHERE");


            // Index_SGMKEY_MEETING_DATE_MEETING_TIME
            builder.Append("(");
            for (int index = 0; index < Index_SGMKEY_MEETING_DATE_MEETING_TIME.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // SGMKEY
                var parameterSGMKEY = $"@p{parameterIndex++}";
                builder.Append("([SGMKEY]=").Append(parameterSGMKEY);
                command.Parameters.Add(parameterSGMKEY, SqlDbType.VarChar, 12).Value = Index_SGMKEY_MEETING_DATE_MEETING_TIME[index].Item1;

                // MEETING_DATE
                if (Index_SGMKEY_MEETING_DATE_MEETING_TIME[index].Item2 == null)
                {
                    builder.Append(" AND [MEETING_DATE] IS NULL");
                }
                else
                {
                    var parameterMEETING_DATE = $"@p{parameterIndex++}";
                    builder.Append(" AND [MEETING_DATE]=").Append(parameterMEETING_DATE);
                    command.Parameters.Add(parameterMEETING_DATE, SqlDbType.DateTime).Value = Index_SGMKEY_MEETING_DATE_MEETING_TIME[index].Item2;
                }

                // MEETING_TIME
                if (Index_SGMKEY_MEETING_DATE_MEETING_TIME[index].Item3 == null)
                {
                    builder.Append(" AND [MEETING_TIME] IS NULL)");
                }
                else
                {
                    var parameterMEETING_TIME = $"@p{parameterIndex++}";
                    builder.Append(" AND [MEETING_TIME]=").Append(parameterMEETING_TIME).Append(")");
                    command.Parameters.Add(parameterMEETING_TIME, SqlDbType.SmallInt).Value = Index_SGMKEY_MEETING_DATE_MEETING_TIME[index].Item3;
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
        /// Provides a <see cref="IDataReader"/> for the SGM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGM data set</returns>
        public override EduHubDataSetDataReader<SGM> GetDataSetDataReader()
        {
            return new SGMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGM data set</returns>
        public override EduHubDataSetDataReader<SGM> GetDataSetDataReader(List<SGM> Entities)
        {
            return new SGMDataReader(new EduHubDataSetLoadedReader<SGM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGMDataReader : EduHubDataSetDataReader<SGM>
        {
            public SGMDataReader(IEduHubDataSetReader<SGM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SGMKEY
                        return Current.SGMKEY;
                    case 2: // MEETING_DATE
                        return Current.MEETING_DATE;
                    case 3: // MEETING_TIME
                        return Current.MEETING_TIME;
                    case 4: // PURPOSE_BRIEF
                        return Current.PURPOSE_BRIEF;
                    case 5: // PURPOSE_DETAIL
                        return Current.PURPOSE_DETAIL;
                    case 6: // MEETING_ROOM
                        return Current.MEETING_ROOM;
                    case 7: // MINUTES_MEMO
                        return Current.MINUTES_MEMO;
                    case 8: // LW_TIME
                        return Current.LW_TIME;
                    case 9: // LW_DATE
                        return Current.LW_DATE;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // MEETING_DATE
                        return Current.MEETING_DATE == null;
                    case 3: // MEETING_TIME
                        return Current.MEETING_TIME == null;
                    case 4: // PURPOSE_BRIEF
                        return Current.PURPOSE_BRIEF == null;
                    case 5: // PURPOSE_DETAIL
                        return Current.PURPOSE_DETAIL == null;
                    case 6: // MEETING_ROOM
                        return Current.MEETING_ROOM == null;
                    case 7: // MINUTES_MEMO
                        return Current.MINUTES_MEMO == null;
                    case 8: // LW_TIME
                        return Current.LW_TIME == null;
                    case 9: // LW_DATE
                        return Current.LW_DATE == null;
                    case 10: // LW_USER
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
                    case 1: // SGMKEY
                        return "SGMKEY";
                    case 2: // MEETING_DATE
                        return "MEETING_DATE";
                    case 3: // MEETING_TIME
                        return "MEETING_TIME";
                    case 4: // PURPOSE_BRIEF
                        return "PURPOSE_BRIEF";
                    case 5: // PURPOSE_DETAIL
                        return "PURPOSE_DETAIL";
                    case 6: // MEETING_ROOM
                        return "MEETING_ROOM";
                    case 7: // MINUTES_MEMO
                        return "MINUTES_MEMO";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_USER
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
                    case "SGMKEY":
                        return 1;
                    case "MEETING_DATE":
                        return 2;
                    case "MEETING_TIME":
                        return 3;
                    case "PURPOSE_BRIEF":
                        return 4;
                    case "PURPOSE_DETAIL":
                        return 5;
                    case "MEETING_ROOM":
                        return 6;
                    case "MINUTES_MEMO":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
