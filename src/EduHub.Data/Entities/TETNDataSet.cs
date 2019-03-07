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
    /// Event Attendees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TETNDataSet : EduHubDataSet<TETN>
    {
        /// <inheritdoc />
        public override string Name { get { return "TETN"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TETNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TETELINK_ATTENDEE_TYPE = new Lazy<Dictionary<Tuple<int?, string>, IReadOnlyList<TETN>>>(() => this.ToGroupedDictionary(i => Tuple.Create(i.TETELINK, i.ATTENDEE_TYPE)));
            Index_TETNKEY = new Lazy<Dictionary<int, IReadOnlyList<TETN>>>(() => this.ToGroupedDictionary(i => i.TETNKEY));
            Index_TID = new Lazy<Dictionary<int, TETN>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TETN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TETN" /> fields for each CSV column header</returns>
        internal override Action<TETN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TETN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TETNKEY":
                        mapper[i] = (e, v) => e.TETNKEY = int.Parse(v);
                        break;
                    case "TETELINK":
                        mapper[i] = (e, v) => e.TETELINK = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ATTENDEE":
                        mapper[i] = (e, v) => e.ATTENDEE = v;
                        break;
                    case "ATTENDEE_TYPE":
                        mapper[i] = (e, v) => e.ATTENDEE_TYPE = v;
                        break;
                    case "ATTENDEE_DETAIL":
                        mapper[i] = (e, v) => e.ATTENDEE_DETAIL = v;
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
        /// Merges <see cref="TETN" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TETN" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TETN" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TETN}"/> of entities</returns>
        internal override IEnumerable<TETN> ApplyDeltaEntities(IEnumerable<TETN> Entities, List<TETN> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TETNKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TETNKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<Tuple<int?, string>, IReadOnlyList<TETN>>> Index_TETELINK_ATTENDEE_TYPE;
        private Lazy<Dictionary<int, IReadOnlyList<TETN>>> Index_TETNKEY;
        private Lazy<Dictionary<int, TETN>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TETN by TETELINK and ATTENDEE_TYPE fields
        /// </summary>
        /// <param name="TETELINK">TETELINK value used to find TETN</param>
        /// <param name="ATTENDEE_TYPE">ATTENDEE_TYPE value used to find TETN</param>
        /// <returns>List of related TETN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETN> FindByTETELINK_ATTENDEE_TYPE(int? TETELINK, string ATTENDEE_TYPE)
        {
            return Index_TETELINK_ATTENDEE_TYPE.Value[Tuple.Create(TETELINK, ATTENDEE_TYPE)];
        }

        /// <summary>
        /// Attempt to find TETN by TETELINK and ATTENDEE_TYPE fields
        /// </summary>
        /// <param name="TETELINK">TETELINK value used to find TETN</param>
        /// <param name="ATTENDEE_TYPE">ATTENDEE_TYPE value used to find TETN</param>
        /// <param name="Value">List of related TETN entities</param>
        /// <returns>True if the list of related TETN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTETELINK_ATTENDEE_TYPE(int? TETELINK, string ATTENDEE_TYPE, out IReadOnlyList<TETN> Value)
        {
            return Index_TETELINK_ATTENDEE_TYPE.Value.TryGetValue(Tuple.Create(TETELINK, ATTENDEE_TYPE), out Value);
        }

        /// <summary>
        /// Attempt to find TETN by TETELINK and ATTENDEE_TYPE fields
        /// </summary>
        /// <param name="TETELINK">TETELINK value used to find TETN</param>
        /// <param name="ATTENDEE_TYPE">ATTENDEE_TYPE value used to find TETN</param>
        /// <returns>List of related TETN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETN> TryFindByTETELINK_ATTENDEE_TYPE(int? TETELINK, string ATTENDEE_TYPE)
        {
            IReadOnlyList<TETN> value;
            if (Index_TETELINK_ATTENDEE_TYPE.Value.TryGetValue(Tuple.Create(TETELINK, ATTENDEE_TYPE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <returns>List of related TETN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETN> FindByTETNKEY(int TETNKEY)
        {
            return Index_TETNKEY.Value[TETNKEY];
        }

        /// <summary>
        /// Attempt to find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <param name="Value">List of related TETN entities</param>
        /// <returns>True if the list of related TETN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTETNKEY(int TETNKEY, out IReadOnlyList<TETN> Value)
        {
            return Index_TETNKEY.Value.TryGetValue(TETNKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TETN by TETNKEY field
        /// </summary>
        /// <param name="TETNKEY">TETNKEY value used to find TETN</param>
        /// <returns>List of related TETN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TETN> TryFindByTETNKEY(int TETNKEY)
        {
            IReadOnlyList<TETN> value;
            if (Index_TETNKEY.Value.TryGetValue(TETNKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <returns>Related TETN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETN FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <param name="Value">Related TETN entity</param>
        /// <returns>True if the related TETN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TETN Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TETN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TETN</param>
        /// <returns>Related TETN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TETN TryFindByTID(int TID)
        {
            TETN value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TETN table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TETN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TETN](
        [TID] int IDENTITY NOT NULL,
        [TETNKEY] int NOT NULL,
        [TETELINK] int NULL,
        [ATTENDEE] varchar(10) NULL,
        [ATTENDEE_TYPE] varchar(8) NULL,
        [ATTENDEE_DETAIL] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TETN_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TETN_Index_TETELINK_ATTENDEE_TYPE] ON [dbo].[TETN]
    (
            [TETELINK] ASC,
            [ATTENDEE_TYPE] ASC
    );
    CREATE CLUSTERED INDEX [TETN_Index_TETNKEY] ON [dbo].[TETN]
    (
            [TETNKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TETN]') AND name = N'Index_TETELINK_ATTENDEE_TYPE')
    ALTER INDEX [Index_TETELINK_ATTENDEE_TYPE] ON [dbo].[TETN] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TETN]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TETN] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TETN]') AND name = N'Index_TETELINK_ATTENDEE_TYPE')
    ALTER INDEX [Index_TETELINK_ATTENDEE_TYPE] ON [dbo].[TETN] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TETN]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TETN] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TETN"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TETN"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TETN> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TETN] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TETN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TETN data set</returns>
        public override EduHubDataSetDataReader<TETN> GetDataSetDataReader()
        {
            return new TETNDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TETN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TETN data set</returns>
        public override EduHubDataSetDataReader<TETN> GetDataSetDataReader(List<TETN> Entities)
        {
            return new TETNDataReader(new EduHubDataSetLoadedReader<TETN>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TETNDataReader : EduHubDataSetDataReader<TETN>
        {
            public TETNDataReader(IEduHubDataSetReader<TETN> Reader)
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
                    case 1: // TETNKEY
                        return Current.TETNKEY;
                    case 2: // TETELINK
                        return Current.TETELINK;
                    case 3: // ATTENDEE
                        return Current.ATTENDEE;
                    case 4: // ATTENDEE_TYPE
                        return Current.ATTENDEE_TYPE;
                    case 5: // ATTENDEE_DETAIL
                        return Current.ATTENDEE_DETAIL;
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
                    case 2: // TETELINK
                        return Current.TETELINK == null;
                    case 3: // ATTENDEE
                        return Current.ATTENDEE == null;
                    case 4: // ATTENDEE_TYPE
                        return Current.ATTENDEE_TYPE == null;
                    case 5: // ATTENDEE_DETAIL
                        return Current.ATTENDEE_DETAIL == null;
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
                    case 1: // TETNKEY
                        return "TETNKEY";
                    case 2: // TETELINK
                        return "TETELINK";
                    case 3: // ATTENDEE
                        return "ATTENDEE";
                    case 4: // ATTENDEE_TYPE
                        return "ATTENDEE_TYPE";
                    case 5: // ATTENDEE_DETAIL
                        return "ATTENDEE_DETAIL";
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
                    case "TETNKEY":
                        return 1;
                    case "TETELINK":
                        return 2;
                    case "ATTENDEE":
                        return 3;
                    case "ATTENDEE_TYPE":
                        return 4;
                    case "ATTENDEE_DETAIL":
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
