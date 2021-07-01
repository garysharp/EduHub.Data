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
    /// Staff Availability in Quilt Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFAQDataSet : EduHubDataSet<SFAQ>
    {
        /// <inheritdoc />
        public override string Name { get { return "SFAQ"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SFAQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<SFAQ>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
            Index_SFAQKEY = new Lazy<Dictionary<string, IReadOnlyList<SFAQ>>>(() => this.ToGroupedDictionary(i => i.SFAQKEY));
            Index_TID = new Lazy<Dictionary<int, SFAQ>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFAQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFAQ" /> fields for each CSV column header</returns>
        internal override Action<SFAQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFAQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SFAQKEY":
                        mapper[i] = (e, v) => e.SFAQKEY = v;
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_PERIOD":
                        mapper[i] = (e, v) => e.START_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_PERIOD":
                        mapper[i] = (e, v) => e.END_PERIOD = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SFAQ" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SFAQ" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SFAQ" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SFAQ}"/> of entities</returns>
        internal override IEnumerable<SFAQ> ApplyDeltaEntities(IEnumerable<SFAQ> Entities, List<SFAQ> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SFAQKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SFAQKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SFAQ>>> Index_QKEY;
        private Lazy<Dictionary<string, IReadOnlyList<SFAQ>>> Index_SFAQKEY;
        private Lazy<Dictionary<int, SFAQ>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <param name="Value">List of related SFAQ entities</param>
        /// <returns>True if the list of related SFAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<SFAQ> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<SFAQ> value;
            if (Index_QKEY.Value.TryGetValue(QKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> FindBySFAQKEY(string SFAQKEY)
        {
            return Index_SFAQKEY.Value[SFAQKEY];
        }

        /// <summary>
        /// Attempt to find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <param name="Value">List of related SFAQ entities</param>
        /// <returns>True if the list of related SFAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySFAQKEY(string SFAQKEY, out IReadOnlyList<SFAQ> Value)
        {
            return Index_SFAQKEY.Value.TryGetValue(SFAQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by SFAQKEY field
        /// </summary>
        /// <param name="SFAQKEY">SFAQKEY value used to find SFAQ</param>
        /// <returns>List of related SFAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAQ> TryFindBySFAQKEY(string SFAQKEY)
        {
            IReadOnlyList<SFAQ> value;
            if (Index_SFAQKEY.Value.TryGetValue(SFAQKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <returns>Related SFAQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAQ FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <param name="Value">Related SFAQ entity</param>
        /// <returns>True if the related SFAQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SFAQ Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SFAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAQ</param>
        /// <returns>Related SFAQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAQ TryFindByTID(int TID)
        {
            SFAQ value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SFAQ table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SFAQ]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SFAQ](
        [TID] int IDENTITY NOT NULL,
        [SFAQKEY] varchar(4) NOT NULL,
        [QKEY] varchar(8) NULL,
        [DAY_NUMBER] smallint NULL,
        [START_PERIOD] smallint NULL,
        [END_PERIOD] smallint NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SFAQ_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SFAQ_Index_QKEY] ON [dbo].[SFAQ]
    (
            [QKEY] ASC
    );
    CREATE CLUSTERED INDEX [SFAQ_Index_SFAQKEY] ON [dbo].[SFAQ]
    (
            [SFAQKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SFAQ]') AND name = N'SFAQ_Index_QKEY')
    ALTER INDEX [SFAQ_Index_QKEY] ON [dbo].[SFAQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SFAQ]') AND name = N'SFAQ_Index_TID')
    ALTER INDEX [SFAQ_Index_TID] ON [dbo].[SFAQ] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SFAQ]') AND name = N'SFAQ_Index_QKEY')
    ALTER INDEX [SFAQ_Index_QKEY] ON [dbo].[SFAQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SFAQ]') AND name = N'SFAQ_Index_TID')
    ALTER INDEX [SFAQ_Index_TID] ON [dbo].[SFAQ] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SFAQ"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SFAQ"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SFAQ> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SFAQ] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SFAQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SFAQ data set</returns>
        public override EduHubDataSetDataReader<SFAQ> GetDataSetDataReader()
        {
            return new SFAQDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SFAQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SFAQ data set</returns>
        public override EduHubDataSetDataReader<SFAQ> GetDataSetDataReader(List<SFAQ> Entities)
        {
            return new SFAQDataReader(new EduHubDataSetLoadedReader<SFAQ>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SFAQDataReader : EduHubDataSetDataReader<SFAQ>
        {
            public SFAQDataReader(IEduHubDataSetReader<SFAQ> Reader)
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
                    case 1: // SFAQKEY
                        return Current.SFAQKEY;
                    case 2: // QKEY
                        return Current.QKEY;
                    case 3: // DAY_NUMBER
                        return Current.DAY_NUMBER;
                    case 4: // START_PERIOD
                        return Current.START_PERIOD;
                    case 5: // END_PERIOD
                        return Current.END_PERIOD;
                    case 6: // LW_TIME
                        return Current.LW_TIME;
                    case 7: // LW_DATE
                        return Current.LW_DATE;
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
                    case 2: // QKEY
                        return Current.QKEY == null;
                    case 3: // DAY_NUMBER
                        return Current.DAY_NUMBER == null;
                    case 4: // START_PERIOD
                        return Current.START_PERIOD == null;
                    case 5: // END_PERIOD
                        return Current.END_PERIOD == null;
                    case 6: // LW_TIME
                        return Current.LW_TIME == null;
                    case 7: // LW_DATE
                        return Current.LW_DATE == null;
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
                    case 1: // SFAQKEY
                        return "SFAQKEY";
                    case 2: // QKEY
                        return "QKEY";
                    case 3: // DAY_NUMBER
                        return "DAY_NUMBER";
                    case 4: // START_PERIOD
                        return "START_PERIOD";
                    case 5: // END_PERIOD
                        return "END_PERIOD";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_DATE
                        return "LW_DATE";
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
                    case "SFAQKEY":
                        return 1;
                    case "QKEY":
                        return 2;
                    case "DAY_NUMBER":
                        return 3;
                    case "START_PERIOD":
                        return 4;
                    case "END_PERIOD":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_DATE":
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
