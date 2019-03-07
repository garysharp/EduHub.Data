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
    /// Room Availablity Extras Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMAVDataSet : EduHubDataSet<SMAV>
    {
        /// <inheritdoc />
        public override string Name { get { return "SMAV"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SMAVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROOM = new Lazy<Dictionary<string, IReadOnlyList<SMAV>>>(() => this.ToGroupedDictionary(i => i.ROOM));
            Index_TID = new Lazy<Dictionary<int, SMAV>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMAV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMAV" /> fields for each CSV column header</returns>
        internal override Action<SMAV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMAV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "END_TIME":
                        mapper[i] = (e, v) => e.END_TIME = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "AVAILABLE_DATE":
                        mapper[i] = (e, v) => e.AVAILABLE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SMAV" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SMAV" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SMAV" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SMAV}"/> of entities</returns>
        internal override IEnumerable<SMAV> ApplyDeltaEntities(IEnumerable<SMAV> Entities, List<SMAV> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ROOM;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.ROOM.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SMAV>>> Index_ROOM;
        private Lazy<Dictionary<int, SMAV>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <returns>List of related SMAV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAV> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <param name="Value">List of related SMAV entities</param>
        /// <returns>True if the list of related SMAV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SMAV> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SMAV by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV</param>
        /// <returns>List of related SMAV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAV> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SMAV> value;
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
        /// Find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <returns>Related SMAV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <param name="Value">Related SMAV entity</param>
        /// <returns>True if the related SMAV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMAV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAV</param>
        /// <returns>Related SMAV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAV TryFindByTID(int TID)
        {
            SMAV value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SMAV table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMAV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMAV](
        [TID] int IDENTITY NOT NULL,
        [ROOM] varchar(4) NOT NULL,
        [DAY_NUMBER] smallint NULL,
        [START_TIME] datetime NULL,
        [END_TIME] datetime NULL,
        [AVAILABLE_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMAV_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SMAV_Index_ROOM] ON [dbo].[SMAV]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMAV]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SMAV] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMAV]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SMAV] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SMAV"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SMAV"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SMAV> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SMAV] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SMAV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMAV data set</returns>
        public override EduHubDataSetDataReader<SMAV> GetDataSetDataReader()
        {
            return new SMAVDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMAV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMAV data set</returns>
        public override EduHubDataSetDataReader<SMAV> GetDataSetDataReader(List<SMAV> Entities)
        {
            return new SMAVDataReader(new EduHubDataSetLoadedReader<SMAV>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMAVDataReader : EduHubDataSetDataReader<SMAV>
        {
            public SMAVDataReader(IEduHubDataSetReader<SMAV> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ROOM
                        return Current.ROOM;
                    case 2: // DAY_NUMBER
                        return Current.DAY_NUMBER;
                    case 3: // START_TIME
                        return Current.START_TIME;
                    case 4: // END_TIME
                        return Current.END_TIME;
                    case 5: // AVAILABLE_DATE
                        return Current.AVAILABLE_DATE;
                    case 6: // LW_DATE
                        return Current.LW_DATE;
                    case 7: // LW_TIME
                        return Current.LW_TIME;
                    case 8: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // DAY_NUMBER
                        return Current.DAY_NUMBER == null;
                    case 3: // START_TIME
                        return Current.START_TIME == null;
                    case 4: // END_TIME
                        return Current.END_TIME == null;
                    case 5: // AVAILABLE_DATE
                        return Current.AVAILABLE_DATE == null;
                    case 6: // LW_DATE
                        return Current.LW_DATE == null;
                    case 7: // LW_TIME
                        return Current.LW_TIME == null;
                    case 8: // LW_USER
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
                    case 1: // ROOM
                        return "ROOM";
                    case 2: // DAY_NUMBER
                        return "DAY_NUMBER";
                    case 3: // START_TIME
                        return "START_TIME";
                    case 4: // END_TIME
                        return "END_TIME";
                    case 5: // AVAILABLE_DATE
                        return "AVAILABLE_DATE";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
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
                    case "ROOM":
                        return 1;
                    case "DAY_NUMBER":
                        return 2;
                    case "START_TIME":
                        return 3;
                    case "END_TIME":
                        return 4;
                    case "AVAILABLE_DATE":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
