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
    /// Exam Grid Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEXDataSet : EduHubDataSet<TTEX>
    {
        /// <inheritdoc />
        public override string Name { get { return "TTEX"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TTEXDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_EXAM_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<TTEX>>>(() => this.ToGroupedNullDictionary(i => i.EXAM_ROOM));
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEX>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEX>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEX" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEX" /> fields for each CSV column header</returns>
        internal override Action<TTEX, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEX, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTES_TID":
                        mapper[i] = (e, v) => e.TTES_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXAM_ROW":
                        mapper[i] = (e, v) => e.EXAM_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_COL":
                        mapper[i] = (e, v) => e.EXAM_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_FIX_ROW":
                        mapper[i] = (e, v) => e.EXAM_FIX_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_FIX_COL":
                        mapper[i] = (e, v) => e.EXAM_FIX_COL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "EXAM_ROOM":
                        mapper[i] = (e, v) => e.EXAM_ROOM = v;
                        break;
                    case "EXAM_DESCRIPTION":
                        mapper[i] = (e, v) => e.EXAM_DESCRIPTION = v;
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
        /// Merges <see cref="TTEX" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TTEX" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TTEX" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TTEX}"/> of entities</returns>
        internal override IEnumerable<TTEX> ApplyDeltaEntities(IEnumerable<TTEX> Entities, List<TTEX> DeltaEntities)
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

        private Lazy<NullDictionary<string, IReadOnlyList<TTEX>>> Index_EXAM_ROOM;
        private Lazy<Dictionary<string, IReadOnlyList<TTEX>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEX>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <returns>List of related TTEX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> FindByEXAM_ROOM(string EXAM_ROOM)
        {
            return Index_EXAM_ROOM.Value[EXAM_ROOM];
        }

        /// <summary>
        /// Attempt to find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <param name="Value">List of related TTEX entities</param>
        /// <returns>True if the list of related TTEX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEXAM_ROOM(string EXAM_ROOM, out IReadOnlyList<TTEX> Value)
        {
            return Index_EXAM_ROOM.Value.TryGetValue(EXAM_ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by EXAM_ROOM field
        /// </summary>
        /// <param name="EXAM_ROOM">EXAM_ROOM value used to find TTEX</param>
        /// <returns>List of related TTEX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> TryFindByEXAM_ROOM(string EXAM_ROOM)
        {
            IReadOnlyList<TTEX> value;
            if (Index_EXAM_ROOM.Value.TryGetValue(EXAM_ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <returns>List of related TTEX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <param name="Value">List of related TTEX entities</param>
        /// <returns>True if the list of related TTEX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEX> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEX</param>
        /// <returns>List of related TTEX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEX> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEX> value;
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
        /// Find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <returns>Related TTEX entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEX FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <param name="Value">Related TTEX entity</param>
        /// <returns>True if the related TTEX entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEX Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEX</param>
        /// <returns>Related TTEX entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEX TryFindByTID(int TID)
        {
            TTEX value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TTEX table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTEX]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTEX](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [TTES_TID] int NULL,
        [EXAM_ROW] smallint NULL,
        [EXAM_COL] smallint NULL,
        [EXAM_FIX_ROW] smallint NULL,
        [EXAM_FIX_COL] smallint NULL,
        [EXAM_ROOM] varchar(4) NULL,
        [EXAM_DESCRIPTION] varchar(15) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTEX_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TTEX_Index_EXAM_ROOM] ON [dbo].[TTEX]
    (
            [EXAM_ROOM] ASC
    );
    CREATE CLUSTERED INDEX [TTEX_Index_GKEY] ON [dbo].[TTEX]
    (
            [GKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEX]') AND name = N'Index_EXAM_ROOM')
    ALTER INDEX [Index_EXAM_ROOM] ON [dbo].[TTEX] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEX]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TTEX] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEX]') AND name = N'Index_EXAM_ROOM')
    ALTER INDEX [Index_EXAM_ROOM] ON [dbo].[TTEX] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEX]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TTEX] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TTEX"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TTEX"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TTEX> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TTEX] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TTEX data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEX data set</returns>
        public override EduHubDataSetDataReader<TTEX> GetDataSetDataReader()
        {
            return new TTEXDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTEX data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEX data set</returns>
        public override EduHubDataSetDataReader<TTEX> GetDataSetDataReader(List<TTEX> Entities)
        {
            return new TTEXDataReader(new EduHubDataSetLoadedReader<TTEX>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTEXDataReader : EduHubDataSetDataReader<TTEX>
        {
            public TTEXDataReader(IEduHubDataSetReader<TTEX> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 12; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // GKEY
                        return Current.GKEY;
                    case 2: // TTES_TID
                        return Current.TTES_TID;
                    case 3: // EXAM_ROW
                        return Current.EXAM_ROW;
                    case 4: // EXAM_COL
                        return Current.EXAM_COL;
                    case 5: // EXAM_FIX_ROW
                        return Current.EXAM_FIX_ROW;
                    case 6: // EXAM_FIX_COL
                        return Current.EXAM_FIX_COL;
                    case 7: // EXAM_ROOM
                        return Current.EXAM_ROOM;
                    case 8: // EXAM_DESCRIPTION
                        return Current.EXAM_DESCRIPTION;
                    case 9: // LW_DATE
                        return Current.LW_DATE;
                    case 10: // LW_TIME
                        return Current.LW_TIME;
                    case 11: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TTES_TID
                        return Current.TTES_TID == null;
                    case 3: // EXAM_ROW
                        return Current.EXAM_ROW == null;
                    case 4: // EXAM_COL
                        return Current.EXAM_COL == null;
                    case 5: // EXAM_FIX_ROW
                        return Current.EXAM_FIX_ROW == null;
                    case 6: // EXAM_FIX_COL
                        return Current.EXAM_FIX_COL == null;
                    case 7: // EXAM_ROOM
                        return Current.EXAM_ROOM == null;
                    case 8: // EXAM_DESCRIPTION
                        return Current.EXAM_DESCRIPTION == null;
                    case 9: // LW_DATE
                        return Current.LW_DATE == null;
                    case 10: // LW_TIME
                        return Current.LW_TIME == null;
                    case 11: // LW_USER
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
                    case 2: // TTES_TID
                        return "TTES_TID";
                    case 3: // EXAM_ROW
                        return "EXAM_ROW";
                    case 4: // EXAM_COL
                        return "EXAM_COL";
                    case 5: // EXAM_FIX_ROW
                        return "EXAM_FIX_ROW";
                    case 6: // EXAM_FIX_COL
                        return "EXAM_FIX_COL";
                    case 7: // EXAM_ROOM
                        return "EXAM_ROOM";
                    case 8: // EXAM_DESCRIPTION
                        return "EXAM_DESCRIPTION";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
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
                    case "TTES_TID":
                        return 2;
                    case "EXAM_ROW":
                        return 3;
                    case "EXAM_COL":
                        return 4;
                    case "EXAM_FIX_ROW":
                        return 5;
                    case "EXAM_FIX_COL":
                        return 6;
                    case "EXAM_ROOM":
                        return 7;
                    case "EXAM_DESCRIPTION":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
