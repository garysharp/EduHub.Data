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
    /// Event Instances Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TETEDataSet : EduHubDataSet<TETE>
    {
        /// <inheritdoc />
        public override string Name { get { return "TETE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TETEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<TETE>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_TETEKEY = new Lazy<Dictionary<int, IReadOnlyList<TETE>>>(() => this.ToGroupedDictionary(i => i.TETEKEY));
            Index_TID = new Lazy<Dictionary<int, TETE>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TETE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TETE" /> fields for each CSV column header</returns>
        internal override Action<TETE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TETE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TETEKEY":
                        mapper[i] = (e, v) => e.TETEKEY = int.Parse(v);
                        break;
                    case "EVENT_DATE":
                        mapper[i] = (e, v) => e.EVENT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CONVENOR":
                        mapper[i] = (e, v) => e.CONVENOR = v;
                        break;
                    case "CONVENOR_TYPE":
                        mapper[i] = (e, v) => e.CONVENOR_TYPE = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
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
        /// Merges <see cref="TETE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TETE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TETE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TETE}"/> of entities</returns>
        internal override IEnumerable<TETE> ApplyDeltaEntities(IEnumerable<TETE> Entities, List<TETE> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TETEKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TETEKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<TETE>>> Index_LOCATION;
        private Lazy<Dictionary<int, IReadOnlyList<TETE>>> Index_TETEKEY;
        private Lazy<Dictionary<int, TETE>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <returns>List of related TETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <param name="Value">List of related TETE entities</param>
        /// <returns>True if the list of related TETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<TETE> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TETE</param>
        /// <returns>List of related TETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<TETE> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <returns>List of related TETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> FindByTETEKEY(int TETEKEY)
        {
            return Index_TETEKEY.Value[TETEKEY];
        }

        /// <summary>
        /// Attempt to find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <param name="Value">List of related TETE entities</param>
        /// <returns>True if the list of related TETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTETEKEY(int TETEKEY, out IReadOnlyList<TETE> Value)
        {
            return Index_TETEKEY.Value.TryGetValue(TETEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by TETEKEY field
        /// </summary>
        /// <param name="TETEKEY">TETEKEY value used to find TETE</param>
        /// <returns>List of related TETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETE> TryFindByTETEKEY(int TETEKEY)
        {
            IReadOnlyList<TETE> value;
            if (Index_TETEKEY.Value.TryGetValue(TETEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <returns>Related TETE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETE FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <param name="Value">Related TETE entity</param>
        /// <returns>True if the related TETE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TETE Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TETE by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETE</param>
        /// <returns>Related TETE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETE TryFindByTID(int TID)
        {
            TETE value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TETE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TETE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TETE](
        [TID] int IDENTITY NOT NULL,
        [TETEKEY] int NOT NULL,
        [EVENT_DATE] datetime NULL,
        [COMMENTS] varchar(MAX) NULL,
        [TIME_FROM] datetime NULL,
        [TIME_TO] datetime NULL,
        [CONVENOR] varchar(10) NULL,
        [CONVENOR_TYPE] varchar(8) NULL,
        [LOCATION] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TETE_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TETE_Index_LOCATION] ON [dbo].[TETE]
    (
            [LOCATION] ASC
    );
    CREATE CLUSTERED INDEX [TETE_Index_TETEKEY] ON [dbo].[TETE]
    (
            [TETEKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TETE]') AND name = N'Index_LOCATION')
    ALTER INDEX [Index_LOCATION] ON [dbo].[TETE] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TETE]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TETE] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TETE]') AND name = N'Index_LOCATION')
    ALTER INDEX [Index_LOCATION] ON [dbo].[TETE] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TETE]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TETE] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TETE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TETE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TETE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TETE] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TETE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TETE data set</returns>
        public override EduHubDataSetDataReader<TETE> GetDataSetDataReader()
        {
            return new TETEDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TETE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TETE data set</returns>
        public override EduHubDataSetDataReader<TETE> GetDataSetDataReader(List<TETE> Entities)
        {
            return new TETEDataReader(new EduHubDataSetLoadedReader<TETE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TETEDataReader : EduHubDataSetDataReader<TETE>
        {
            public TETEDataReader(IEduHubDataSetReader<TETE> Reader)
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
                    case 1: // TETEKEY
                        return Current.TETEKEY;
                    case 2: // EVENT_DATE
                        return Current.EVENT_DATE;
                    case 3: // COMMENTS
                        return Current.COMMENTS;
                    case 4: // TIME_FROM
                        return Current.TIME_FROM;
                    case 5: // TIME_TO
                        return Current.TIME_TO;
                    case 6: // CONVENOR
                        return Current.CONVENOR;
                    case 7: // CONVENOR_TYPE
                        return Current.CONVENOR_TYPE;
                    case 8: // LOCATION
                        return Current.LOCATION;
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
                    case 2: // EVENT_DATE
                        return Current.EVENT_DATE == null;
                    case 3: // COMMENTS
                        return Current.COMMENTS == null;
                    case 4: // TIME_FROM
                        return Current.TIME_FROM == null;
                    case 5: // TIME_TO
                        return Current.TIME_TO == null;
                    case 6: // CONVENOR
                        return Current.CONVENOR == null;
                    case 7: // CONVENOR_TYPE
                        return Current.CONVENOR_TYPE == null;
                    case 8: // LOCATION
                        return Current.LOCATION == null;
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
                    case 1: // TETEKEY
                        return "TETEKEY";
                    case 2: // EVENT_DATE
                        return "EVENT_DATE";
                    case 3: // COMMENTS
                        return "COMMENTS";
                    case 4: // TIME_FROM
                        return "TIME_FROM";
                    case 5: // TIME_TO
                        return "TIME_TO";
                    case 6: // CONVENOR
                        return "CONVENOR";
                    case 7: // CONVENOR_TYPE
                        return "CONVENOR_TYPE";
                    case 8: // LOCATION
                        return "LOCATION";
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
                    case "TETEKEY":
                        return 1;
                    case "EVENT_DATE":
                        return 2;
                    case "COMMENTS":
                        return 3;
                    case "TIME_FROM":
                        return 4;
                    case "TIME_TO":
                        return 5;
                    case "CONVENOR":
                        return 6;
                    case "CONVENOR_TYPE":
                        return 7;
                    case "LOCATION":
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
