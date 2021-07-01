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
    /// Exam Staff Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEFDataSet : EduHubDataSet<TTEF>
    {
        /// <inheritdoc />
        public override string Name { get { return "TTEF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TTEFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<TTEF>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, TTEF>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEF" /> fields for each CSV column header</returns>
        internal override Action<TTEF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEP_TID":
                        mapper[i] = (e, v) => e.TTEP_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
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
        /// Merges <see cref="TTEF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TTEF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TTEF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TTEF}"/> of entities</returns>
        internal override IEnumerable<TTEF> ApplyDeltaEntities(IEnumerable<TTEF> Entities, List<TTEF> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.GKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.GKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<TTEF>>> Index_GKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<TTEF>>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<TTEF>>> Index_STAFF;
        private Lazy<Dictionary<int, TTEF>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEF> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEF> value;
            if (Index_GKEY.Value.TryGetValue(GKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<TTEF> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<TTEF> value;
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
        /// Find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <returns>List of related TTEF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <param name="Value">List of related TTEF entities</param>
        /// <returns>True if the list of related TTEF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<TTEF> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find TTEF</param>
        /// <returns>List of related TTEF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEF> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<TTEF> value;
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
        /// Find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <returns>Related TTEF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <param name="Value">Related TTEF entity</param>
        /// <returns>True if the related TTEF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEF</param>
        /// <returns>Related TTEF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEF TryFindByTID(int TID)
        {
            TTEF value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TTEF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTEF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTEF](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [TTEP_TID] int NULL,
        [TIME_START] datetime NULL,
        [TIME_END] datetime NULL,
        [STAFF] varchar(4) NULL,
        [ROOM] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTEF_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TTEF_Index_GKEY] ON [dbo].[TTEF]
    (
            [GKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TTEF_Index_ROOM] ON [dbo].[TTEF]
    (
            [ROOM] ASC
    );
    CREATE NONCLUSTERED INDEX [TTEF_Index_STAFF] ON [dbo].[TTEF]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEF]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[TTEF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEF]') AND name = N'Index_STAFF')
    ALTER INDEX [Index_STAFF] ON [dbo].[TTEF] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TTEF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEF]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[TTEF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEF]') AND name = N'Index_STAFF')
    ALTER INDEX [Index_STAFF] ON [dbo].[TTEF] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEF]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TTEF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TTEF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TTEF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TTEF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TTEF] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TTEF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEF data set</returns>
        public override EduHubDataSetDataReader<TTEF> GetDataSetDataReader()
        {
            return new TTEFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTEF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEF data set</returns>
        public override EduHubDataSetDataReader<TTEF> GetDataSetDataReader(List<TTEF> Entities)
        {
            return new TTEFDataReader(new EduHubDataSetLoadedReader<TTEF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTEFDataReader : EduHubDataSetDataReader<TTEF>
        {
            public TTEFDataReader(IEduHubDataSetReader<TTEF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 10; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // GKEY
                        return Current.GKEY;
                    case 2: // TTEP_TID
                        return Current.TTEP_TID;
                    case 3: // TIME_START
                        return Current.TIME_START;
                    case 4: // TIME_END
                        return Current.TIME_END;
                    case 5: // STAFF
                        return Current.STAFF;
                    case 6: // ROOM
                        return Current.ROOM;
                    case 7: // LW_DATE
                        return Current.LW_DATE;
                    case 8: // LW_TIME
                        return Current.LW_TIME;
                    case 9: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TTEP_TID
                        return Current.TTEP_TID == null;
                    case 3: // TIME_START
                        return Current.TIME_START == null;
                    case 4: // TIME_END
                        return Current.TIME_END == null;
                    case 5: // STAFF
                        return Current.STAFF == null;
                    case 6: // ROOM
                        return Current.ROOM == null;
                    case 7: // LW_DATE
                        return Current.LW_DATE == null;
                    case 8: // LW_TIME
                        return Current.LW_TIME == null;
                    case 9: // LW_USER
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
                    case 1: // GKEY
                        return "GKEY";
                    case 2: // TTEP_TID
                        return "TTEP_TID";
                    case 3: // TIME_START
                        return "TIME_START";
                    case 4: // TIME_END
                        return "TIME_END";
                    case 5: // STAFF
                        return "STAFF";
                    case 6: // ROOM
                        return "ROOM";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
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
                    case "GKEY":
                        return 1;
                    case "TTEP_TID":
                        return 2;
                    case "TIME_START":
                        return 3;
                    case "TIME_END":
                        return 4;
                    case "STAFF":
                        return 5;
                    case "ROOM":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
