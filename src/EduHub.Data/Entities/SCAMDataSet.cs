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
    /// School Association Meetings Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCAMDataSet : EduHubDataSet<SCAM>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCAM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SCAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_MEETING_LOCATION = new Lazy<NullDictionary<int?, IReadOnlyList<SCAM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_LOCATION));
            Index_MEETING_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SCAM>>>(() => this.ToGroupedNullDictionary(i => i.MEETING_ROOM));
            Index_SCAMKEY = new Lazy<Dictionary<string, IReadOnlyList<SCAM>>>(() => this.ToGroupedDictionary(i => i.SCAMKEY));
            Index_SCAMKEY_MEETING_DATE_MEETING_TIME = new Lazy<Dictionary<Tuple<string, DateTime?, short?>, SCAM>>(() => this.ToDictionary(i => Tuple.Create(i.SCAMKEY, i.MEETING_DATE, i.MEETING_TIME)));
            Index_TID = new Lazy<Dictionary<int, SCAM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCAM" /> fields for each CSV column header</returns>
        internal override Action<SCAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SCAMKEY":
                        mapper[i] = (e, v) => e.SCAMKEY = v;
                        break;
                    case "MEETING_DATE":
                        mapper[i] = (e, v) => e.MEETING_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "MEETING_TIME":
                        mapper[i] = (e, v) => e.MEETING_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MEETING_PURPOSE":
                        mapper[i] = (e, v) => e.MEETING_PURPOSE = v;
                        break;
                    case "MEETING_LOCATION":
                        mapper[i] = (e, v) => e.MEETING_LOCATION = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MEETING_ROOM":
                        mapper[i] = (e, v) => e.MEETING_ROOM = v;
                        break;
                    case "MINUTES_MEMO":
                        mapper[i] = (e, v) => e.MINUTES_MEMO = v;
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
        /// Merges <see cref="SCAM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCAM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCAM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCAM}"/> of entities</returns>
        internal override IEnumerable<SCAM> ApplyDeltaEntities(IEnumerable<SCAM> Entities, List<SCAM> DeltaEntities)
        {
            HashSet<Tuple<string, DateTime?, short?>> Index_SCAMKEY_MEETING_DATE_MEETING_TIME = new HashSet<Tuple<string, DateTime?, short?>>(DeltaEntities.Select(i => Tuple.Create(i.SCAMKEY, i.MEETING_DATE, i.MEETING_TIME)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCAMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Remove(Tuple.Create(entity.SCAMKEY, entity.MEETING_DATE, entity.MEETING_TIME));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.SCAMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<SCAM>>> Index_MEETING_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<SCAM>>> Index_MEETING_ROOM;
        private Lazy<Dictionary<string, IReadOnlyList<SCAM>>> Index_SCAMKEY;
        private Lazy<Dictionary<Tuple<string, DateTime?, short?>, SCAM>> Index_SCAMKEY_MEETING_DATE_MEETING_TIME;
        private Lazy<Dictionary<int, SCAM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindByMEETING_LOCATION(int? MEETING_LOCATION)
        {
            return Index_MEETING_LOCATION.Value[MEETING_LOCATION];
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_LOCATION(int? MEETING_LOCATION, out IReadOnlyList<SCAM> Value)
        {
            return Index_MEETING_LOCATION.Value.TryGetValue(MEETING_LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_LOCATION field
        /// </summary>
        /// <param name="MEETING_LOCATION">MEETING_LOCATION value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindByMEETING_LOCATION(int? MEETING_LOCATION)
        {
            IReadOnlyList<SCAM> value;
            if (Index_MEETING_LOCATION.Value.TryGetValue(MEETING_LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindByMEETING_ROOM(string MEETING_ROOM)
        {
            return Index_MEETING_ROOM.Value[MEETING_ROOM];
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMEETING_ROOM(string MEETING_ROOM, out IReadOnlyList<SCAM> Value)
        {
            return Index_MEETING_ROOM.Value.TryGetValue(MEETING_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by MEETING_ROOM field
        /// </summary>
        /// <param name="MEETING_ROOM">MEETING_ROOM value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindByMEETING_ROOM(string MEETING_ROOM)
        {
            IReadOnlyList<SCAM> value;
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
        /// Find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <returns>List of related SCAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> FindBySCAMKEY(string SCAMKEY)
        {
            return Index_SCAMKEY.Value[SCAMKEY];
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="Value">List of related SCAM entities</param>
        /// <returns>True if the list of related SCAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAMKEY(string SCAMKEY, out IReadOnlyList<SCAM> Value)
        {
            return Index_SCAMKEY.Value.TryGetValue(SCAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY field
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <returns>List of related SCAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SCAM> TryFindBySCAMKEY(string SCAMKEY)
        {
            IReadOnlyList<SCAM> value;
            if (Index_SCAMKEY.Value.TryGetValue(SCAMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <returns>Related SCAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM FindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            return Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value[Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME)];
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <param name="Value">Related SCAM entity</param>
        /// <returns>True if the related SCAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME, out SCAM Value)
        {
            return Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME), out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by SCAMKEY, MEETING_DATE and MEETING_TIME fields
        /// </summary>
        /// <param name="SCAMKEY">SCAMKEY value used to find SCAM</param>
        /// <param name="MEETING_DATE">MEETING_DATE value used to find SCAM</param>
        /// <param name="MEETING_TIME">MEETING_TIME value used to find SCAM</param>
        /// <returns>Related SCAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM TryFindBySCAMKEY_MEETING_DATE_MEETING_TIME(string SCAMKEY, DateTime? MEETING_DATE, short? MEETING_TIME)
        {
            SCAM value;
            if (Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Value.TryGetValue(Tuple.Create(SCAMKEY, MEETING_DATE, MEETING_TIME), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <returns>Related SCAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <param name="Value">Related SCAM entity</param>
        /// <returns>True if the related SCAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SCAM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SCAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SCAM</param>
        /// <returns>Related SCAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCAM TryFindByTID(int TID)
        {
            SCAM value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCAM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCAM](
        [TID] int IDENTITY NOT NULL,
        [SCAMKEY] varchar(15) NOT NULL,
        [MEETING_DATE] datetime NULL,
        [MEETING_TIME] smallint NULL,
        [MEETING_PURPOSE] varchar(MAX) NULL,
        [MEETING_LOCATION] int NULL,
        [MEETING_ROOM] varchar(4) NULL,
        [MINUTES_MEMO] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SCAM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SCAM_Index_MEETING_LOCATION] ON [dbo].[SCAM]
    (
            [MEETING_LOCATION] ASC
    );
    CREATE NONCLUSTERED INDEX [SCAM_Index_MEETING_ROOM] ON [dbo].[SCAM]
    (
            [MEETING_ROOM] ASC
    );
    CREATE CLUSTERED INDEX [SCAM_Index_SCAMKEY] ON [dbo].[SCAM]
    (
            [SCAMKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SCAM_Index_SCAMKEY_MEETING_DATE_MEETING_TIME] ON [dbo].[SCAM]
    (
            [SCAMKEY] ASC,
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND name = N'SCAM_Index_MEETING_LOCATION')
    ALTER INDEX [SCAM_Index_MEETING_LOCATION] ON [dbo].[SCAM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND name = N'SCAM_Index_MEETING_ROOM')
    ALTER INDEX [SCAM_Index_MEETING_ROOM] ON [dbo].[SCAM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND name = N'SCAM_Index_SCAMKEY_MEETING_DATE_MEETING_TIME')
    ALTER INDEX [SCAM_Index_SCAMKEY_MEETING_DATE_MEETING_TIME] ON [dbo].[SCAM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND name = N'SCAM_Index_TID')
    ALTER INDEX [SCAM_Index_TID] ON [dbo].[SCAM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND name = N'SCAM_Index_MEETING_LOCATION')
    ALTER INDEX [SCAM_Index_MEETING_LOCATION] ON [dbo].[SCAM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND name = N'SCAM_Index_MEETING_ROOM')
    ALTER INDEX [SCAM_Index_MEETING_ROOM] ON [dbo].[SCAM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND name = N'SCAM_Index_SCAMKEY_MEETING_DATE_MEETING_TIME')
    ALTER INDEX [SCAM_Index_SCAMKEY_MEETING_DATE_MEETING_TIME] ON [dbo].[SCAM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SCAM]') AND name = N'SCAM_Index_TID')
    ALTER INDEX [SCAM_Index_TID] ON [dbo].[SCAM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCAM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCAM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCAM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, DateTime?, short?>> Index_SCAMKEY_MEETING_DATE_MEETING_TIME = new List<Tuple<string, DateTime?, short?>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Add(Tuple.Create(entity.SCAMKEY, entity.MEETING_DATE, entity.MEETING_TIME));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SCAM] WHERE");


            // Index_SCAMKEY_MEETING_DATE_MEETING_TIME
            builder.Append("(");
            for (int index = 0; index < Index_SCAMKEY_MEETING_DATE_MEETING_TIME.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // SCAMKEY
                var parameterSCAMKEY = $"@p{parameterIndex++}";
                builder.Append("([SCAMKEY]=").Append(parameterSCAMKEY);
                command.Parameters.Add(parameterSCAMKEY, SqlDbType.VarChar, 15).Value = Index_SCAMKEY_MEETING_DATE_MEETING_TIME[index].Item1;

                // MEETING_DATE
                if (Index_SCAMKEY_MEETING_DATE_MEETING_TIME[index].Item2 == null)
                {
                    builder.Append(" AND [MEETING_DATE] IS NULL");
                }
                else
                {
                    var parameterMEETING_DATE = $"@p{parameterIndex++}";
                    builder.Append(" AND [MEETING_DATE]=").Append(parameterMEETING_DATE);
                    command.Parameters.Add(parameterMEETING_DATE, SqlDbType.DateTime).Value = Index_SCAMKEY_MEETING_DATE_MEETING_TIME[index].Item2;
                }

                // MEETING_TIME
                if (Index_SCAMKEY_MEETING_DATE_MEETING_TIME[index].Item3 == null)
                {
                    builder.Append(" AND [MEETING_TIME] IS NULL)");
                }
                else
                {
                    var parameterMEETING_TIME = $"@p{parameterIndex++}";
                    builder.Append(" AND [MEETING_TIME]=").Append(parameterMEETING_TIME).Append(")");
                    command.Parameters.Add(parameterMEETING_TIME, SqlDbType.SmallInt).Value = Index_SCAMKEY_MEETING_DATE_MEETING_TIME[index].Item3;
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
        /// Provides a <see cref="IDataReader"/> for the SCAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCAM data set</returns>
        public override EduHubDataSetDataReader<SCAM> GetDataSetDataReader()
        {
            return new SCAMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCAM data set</returns>
        public override EduHubDataSetDataReader<SCAM> GetDataSetDataReader(List<SCAM> Entities)
        {
            return new SCAMDataReader(new EduHubDataSetLoadedReader<SCAM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCAMDataReader : EduHubDataSetDataReader<SCAM>
        {
            public SCAMDataReader(IEduHubDataSetReader<SCAM> Reader)
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
                    case 1: // SCAMKEY
                        return Current.SCAMKEY;
                    case 2: // MEETING_DATE
                        return Current.MEETING_DATE;
                    case 3: // MEETING_TIME
                        return Current.MEETING_TIME;
                    case 4: // MEETING_PURPOSE
                        return Current.MEETING_PURPOSE;
                    case 5: // MEETING_LOCATION
                        return Current.MEETING_LOCATION;
                    case 6: // MEETING_ROOM
                        return Current.MEETING_ROOM;
                    case 7: // MINUTES_MEMO
                        return Current.MINUTES_MEMO;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
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
                    case 4: // MEETING_PURPOSE
                        return Current.MEETING_PURPOSE == null;
                    case 5: // MEETING_LOCATION
                        return Current.MEETING_LOCATION == null;
                    case 6: // MEETING_ROOM
                        return Current.MEETING_ROOM == null;
                    case 7: // MINUTES_MEMO
                        return Current.MINUTES_MEMO == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
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
                    case 1: // SCAMKEY
                        return "SCAMKEY";
                    case 2: // MEETING_DATE
                        return "MEETING_DATE";
                    case 3: // MEETING_TIME
                        return "MEETING_TIME";
                    case 4: // MEETING_PURPOSE
                        return "MEETING_PURPOSE";
                    case 5: // MEETING_LOCATION
                        return "MEETING_LOCATION";
                    case 6: // MEETING_ROOM
                        return "MEETING_ROOM";
                    case 7: // MINUTES_MEMO
                        return "MINUTES_MEMO";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
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
                    case "SCAMKEY":
                        return 1;
                    case "MEETING_DATE":
                        return 2;
                    case "MEETING_TIME":
                        return 3;
                    case "MEETING_PURPOSE":
                        return 4;
                    case "MEETING_LOCATION":
                        return 5;
                    case "MEETING_ROOM":
                        return 6;
                    case "MINUTES_MEMO":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
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
