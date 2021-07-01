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
    /// Teacher Replacements Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTRDataSet : EduHubDataSet<TCTR>
    {
        /// <inheritdoc />
        public override string Name { get { return "TCTR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TCTRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TCTR>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_TCTRKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTR>>>(() => this.ToGroupedDictionary(i => i.TCTRKEY));
            Index_TEACH = new Lazy<NullDictionary<string, IReadOnlyList<TCTR>>>(() => this.ToGroupedNullDictionary(i => i.TEACH));
            Index_TID = new Lazy<Dictionary<int, TCTR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTR" /> fields for each CSV column header</returns>
        internal override Action<TCTR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTRKEY":
                        mapper[i] = (e, v) => e.TCTRKEY = DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TCTQ_TID":
                        mapper[i] = (e, v) => e.TCTQ_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "COMMENT_R":
                        mapper[i] = (e, v) => e.COMMENT_R = v;
                        break;
                    case "COUNT_EXTRAS":
                        mapper[i] = (e, v) => e.COUNT_EXTRAS = v;
                        break;
                    case "EXTRAS_VALUE":
                        mapper[i] = (e, v) => e.EXTRAS_VALUE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABSENTEE_TID":
                        mapper[i] = (e, v) => e.ABSENTEE_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER_CLASH":
                        mapper[i] = (e, v) => e.TEACHER_CLASH = v;
                        break;
                    case "ROOM_CLASH":
                        mapper[i] = (e, v) => e.ROOM_CLASH = v;
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
        /// Merges <see cref="TCTR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TCTR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TCTR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TCTR}"/> of entities</returns>
        internal override IEnumerable<TCTR> ApplyDeltaEntities(IEnumerable<TCTR> Entities, List<TCTR> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TCTRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TCTRKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<TCTR>>> Index_ROOM;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTR>>> Index_TCTRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TCTR>>> Index_TEACH;
        private Lazy<Dictionary<int, TCTR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<TCTR> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<TCTR> value;
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
        /// Find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByTCTRKEY(DateTime TCTRKEY)
        {
            return Index_TCTRKEY.Value[TCTRKEY];
        }

        /// <summary>
        /// Attempt to find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTRKEY(DateTime TCTRKEY, out IReadOnlyList<TCTR> Value)
        {
            return Index_TCTRKEY.Value.TryGetValue(TCTRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TCTRKEY field
        /// </summary>
        /// <param name="TCTRKEY">TCTRKEY value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByTCTRKEY(DateTime TCTRKEY)
        {
            IReadOnlyList<TCTR> value;
            if (Index_TCTRKEY.Value.TryGetValue(TCTRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <returns>List of related TCTR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> FindByTEACH(string TEACH)
        {
            return Index_TEACH.Value[TEACH];
        }

        /// <summary>
        /// Attempt to find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <param name="Value">List of related TCTR entities</param>
        /// <returns>True if the list of related TCTR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACH(string TEACH, out IReadOnlyList<TCTR> Value)
        {
            return Index_TEACH.Value.TryGetValue(TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find TCTR</param>
        /// <returns>List of related TCTR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTR> TryFindByTEACH(string TEACH)
        {
            IReadOnlyList<TCTR> value;
            if (Index_TEACH.Value.TryGetValue(TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <returns>Related TCTR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <param name="Value">Related TCTR entity</param>
        /// <returns>True if the related TCTR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTR</param>
        /// <returns>Related TCTR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTR TryFindByTID(int TID)
        {
            TCTR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TCTR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TCTR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TCTR](
        [TID] int IDENTITY NOT NULL,
        [TCTRKEY] datetime NOT NULL,
        [TCTQ_TID] int NULL,
        [TEACH] varchar(4) NULL,
        [ROOM] varchar(4) NULL,
        [COMMENT_R] varchar(MAX) NULL,
        [COUNT_EXTRAS] varchar(1) NULL,
        [EXTRAS_VALUE] float NULL,
        [ABSENTEE_TID] int NULL,
        [TEACHER_CLASH] varchar(1) NULL,
        [ROOM_CLASH] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TCTR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TCTR_Index_ROOM] ON [dbo].[TCTR]
    (
            [ROOM] ASC
    );
    CREATE CLUSTERED INDEX [TCTR_Index_TCTRKEY] ON [dbo].[TCTR]
    (
            [TCTRKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTR_Index_TEACH] ON [dbo].[TCTR]
    (
            [TEACH] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTR]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[TCTR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTR]') AND name = N'Index_TEACH')
    ALTER INDEX [Index_TEACH] ON [dbo].[TCTR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TCTR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTR]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[TCTR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTR]') AND name = N'Index_TEACH')
    ALTER INDEX [Index_TEACH] ON [dbo].[TCTR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TCTR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TCTR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TCTR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TCTR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TCTR] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TCTR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTR data set</returns>
        public override EduHubDataSetDataReader<TCTR> GetDataSetDataReader()
        {
            return new TCTRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCTR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTR data set</returns>
        public override EduHubDataSetDataReader<TCTR> GetDataSetDataReader(List<TCTR> Entities)
        {
            return new TCTRDataReader(new EduHubDataSetLoadedReader<TCTR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCTRDataReader : EduHubDataSetDataReader<TCTR>
        {
            public TCTRDataReader(IEduHubDataSetReader<TCTR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // TCTRKEY
                        return Current.TCTRKEY;
                    case 2: // TCTQ_TID
                        return Current.TCTQ_TID;
                    case 3: // TEACH
                        return Current.TEACH;
                    case 4: // ROOM
                        return Current.ROOM;
                    case 5: // COMMENT_R
                        return Current.COMMENT_R;
                    case 6: // COUNT_EXTRAS
                        return Current.COUNT_EXTRAS;
                    case 7: // EXTRAS_VALUE
                        return Current.EXTRAS_VALUE;
                    case 8: // ABSENTEE_TID
                        return Current.ABSENTEE_TID;
                    case 9: // TEACHER_CLASH
                        return Current.TEACHER_CLASH;
                    case 10: // ROOM_CLASH
                        return Current.ROOM_CLASH;
                    case 11: // LW_DATE
                        return Current.LW_DATE;
                    case 12: // LW_TIME
                        return Current.LW_TIME;
                    case 13: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TCTQ_TID
                        return Current.TCTQ_TID == null;
                    case 3: // TEACH
                        return Current.TEACH == null;
                    case 4: // ROOM
                        return Current.ROOM == null;
                    case 5: // COMMENT_R
                        return Current.COMMENT_R == null;
                    case 6: // COUNT_EXTRAS
                        return Current.COUNT_EXTRAS == null;
                    case 7: // EXTRAS_VALUE
                        return Current.EXTRAS_VALUE == null;
                    case 8: // ABSENTEE_TID
                        return Current.ABSENTEE_TID == null;
                    case 9: // TEACHER_CLASH
                        return Current.TEACHER_CLASH == null;
                    case 10: // ROOM_CLASH
                        return Current.ROOM_CLASH == null;
                    case 11: // LW_DATE
                        return Current.LW_DATE == null;
                    case 12: // LW_TIME
                        return Current.LW_TIME == null;
                    case 13: // LW_USER
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
                    case 1: // TCTRKEY
                        return "TCTRKEY";
                    case 2: // TCTQ_TID
                        return "TCTQ_TID";
                    case 3: // TEACH
                        return "TEACH";
                    case 4: // ROOM
                        return "ROOM";
                    case 5: // COMMENT_R
                        return "COMMENT_R";
                    case 6: // COUNT_EXTRAS
                        return "COUNT_EXTRAS";
                    case 7: // EXTRAS_VALUE
                        return "EXTRAS_VALUE";
                    case 8: // ABSENTEE_TID
                        return "ABSENTEE_TID";
                    case 9: // TEACHER_CLASH
                        return "TEACHER_CLASH";
                    case 10: // ROOM_CLASH
                        return "ROOM_CLASH";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
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
                    case "TCTRKEY":
                        return 1;
                    case "TCTQ_TID":
                        return 2;
                    case "TEACH":
                        return 3;
                    case "ROOM":
                        return 4;
                    case "COMMENT_R":
                        return 5;
                    case "COUNT_EXTRAS":
                        return 6;
                    case "EXTRAS_VALUE":
                        return 7;
                    case "ABSENTEE_TID":
                        return 8;
                    case "TEACHER_CLASH":
                        return 9;
                    case "ROOM_CLASH":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
