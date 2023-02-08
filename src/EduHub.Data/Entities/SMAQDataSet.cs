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
    /// Room Availability in Quilt Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMAQDataSet : EduHubDataSet<SMAQ>
    {
        /// <inheritdoc />
        public override string Name { get { return "SMAQ"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SMAQDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<SMAQ>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
            Index_SMAQKEY = new Lazy<Dictionary<string, IReadOnlyList<SMAQ>>>(() => this.ToGroupedDictionary(i => i.SMAQKEY));
            Index_TID = new Lazy<Dictionary<int, SMAQ>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMAQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMAQ" /> fields for each CSV column header</returns>
        internal override Action<SMAQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMAQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SMAQKEY":
                        mapper[i] = (e, v) => e.SMAQKEY = v;
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
        /// Merges <see cref="SMAQ" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SMAQ" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SMAQ" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SMAQ}"/> of entities</returns>
        internal override IEnumerable<SMAQ> ApplyDeltaEntities(IEnumerable<SMAQ> Entities, List<SMAQ> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SMAQKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SMAQKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SMAQ>>> Index_QKEY;
        private Lazy<Dictionary<string, IReadOnlyList<SMAQ>>> Index_SMAQKEY;
        private Lazy<Dictionary<int, SMAQ>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SMAQ</param>
        /// <returns>List of related SMAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAQ> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find SMAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SMAQ</param>
        /// <param name="Value">List of related SMAQ entities</param>
        /// <returns>True if the list of related SMAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<SMAQ> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMAQ by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find SMAQ</param>
        /// <returns>List of related SMAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAQ> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<SMAQ> value;
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
        /// Find SMAQ by SMAQKEY field
        /// </summary>
        /// <param name="SMAQKEY">SMAQKEY value used to find SMAQ</param>
        /// <returns>List of related SMAQ entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAQ> FindBySMAQKEY(string SMAQKEY)
        {
            return Index_SMAQKEY.Value[SMAQKEY];
        }

        /// <summary>
        /// Attempt to find SMAQ by SMAQKEY field
        /// </summary>
        /// <param name="SMAQKEY">SMAQKEY value used to find SMAQ</param>
        /// <param name="Value">List of related SMAQ entities</param>
        /// <returns>True if the list of related SMAQ entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySMAQKEY(string SMAQKEY, out IReadOnlyList<SMAQ> Value)
        {
            return Index_SMAQKEY.Value.TryGetValue(SMAQKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMAQ by SMAQKEY field
        /// </summary>
        /// <param name="SMAQKEY">SMAQKEY value used to find SMAQ</param>
        /// <returns>List of related SMAQ entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMAQ> TryFindBySMAQKEY(string SMAQKEY)
        {
            IReadOnlyList<SMAQ> value;
            if (Index_SMAQKEY.Value.TryGetValue(SMAQKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAQ</param>
        /// <returns>Related SMAQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAQ FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAQ</param>
        /// <param name="Value">Related SMAQ entity</param>
        /// <returns>True if the related SMAQ entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMAQ Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMAQ by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMAQ</param>
        /// <returns>Related SMAQ entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMAQ TryFindByTID(int TID)
        {
            SMAQ value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SMAQ table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMAQ]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMAQ](
        [TID] int IDENTITY NOT NULL,
        [SMAQKEY] varchar(4) NOT NULL,
        [QKEY] varchar(8) NULL,
        [DAY_NUMBER] smallint NULL,
        [START_PERIOD] smallint NULL,
        [END_PERIOD] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMAQ_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SMAQ_Index_QKEY] ON [dbo].[SMAQ]
    (
            [QKEY] ASC
    );
    CREATE CLUSTERED INDEX [SMAQ_Index_SMAQKEY] ON [dbo].[SMAQ]
    (
            [SMAQKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMAQ]') AND name = N'SMAQ_Index_QKEY')
    ALTER INDEX [SMAQ_Index_QKEY] ON [dbo].[SMAQ] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMAQ]') AND name = N'SMAQ_Index_TID')
    ALTER INDEX [SMAQ_Index_TID] ON [dbo].[SMAQ] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMAQ]') AND name = N'SMAQ_Index_QKEY')
    ALTER INDEX [SMAQ_Index_QKEY] ON [dbo].[SMAQ] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMAQ]') AND name = N'SMAQ_Index_TID')
    ALTER INDEX [SMAQ_Index_TID] ON [dbo].[SMAQ] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SMAQ"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SMAQ"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SMAQ> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SMAQ] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SMAQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMAQ data set</returns>
        public override EduHubDataSetDataReader<SMAQ> GetDataSetDataReader()
        {
            return new SMAQDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMAQ data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMAQ data set</returns>
        public override EduHubDataSetDataReader<SMAQ> GetDataSetDataReader(List<SMAQ> Entities)
        {
            return new SMAQDataReader(new EduHubDataSetLoadedReader<SMAQ>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMAQDataReader : EduHubDataSetDataReader<SMAQ>
        {
            public SMAQDataReader(IEduHubDataSetReader<SMAQ> Reader)
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
                    case 1: // SMAQKEY
                        return Current.SMAQKEY;
                    case 2: // QKEY
                        return Current.QKEY;
                    case 3: // DAY_NUMBER
                        return Current.DAY_NUMBER;
                    case 4: // START_PERIOD
                        return Current.START_PERIOD;
                    case 5: // END_PERIOD
                        return Current.END_PERIOD;
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
                    case 2: // QKEY
                        return Current.QKEY == null;
                    case 3: // DAY_NUMBER
                        return Current.DAY_NUMBER == null;
                    case 4: // START_PERIOD
                        return Current.START_PERIOD == null;
                    case 5: // END_PERIOD
                        return Current.END_PERIOD == null;
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
                    case 1: // SMAQKEY
                        return "SMAQKEY";
                    case 2: // QKEY
                        return "QKEY";
                    case 3: // DAY_NUMBER
                        return "DAY_NUMBER";
                    case 4: // START_PERIOD
                        return "START_PERIOD";
                    case 5: // END_PERIOD
                        return "END_PERIOD";
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
                    case "SMAQKEY":
                        return 1;
                    case "QKEY":
                        return 2;
                    case "DAY_NUMBER":
                        return 3;
                    case "START_PERIOD":
                        return 4;
                    case "END_PERIOD":
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
#endif
