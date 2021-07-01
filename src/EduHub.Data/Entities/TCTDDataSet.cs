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
    /// Calendar Period Information Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCTDDataSet : EduHubDataSet<TCTD>
    {
        /// <inheritdoc />
        public override string Name { get { return "TCTD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TCTDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QKEY = new Lazy<NullDictionary<string, IReadOnlyList<TCTD>>>(() => this.ToGroupedNullDictionary(i => i.QKEY));
            Index_TCTDKEY = new Lazy<Dictionary<DateTime, IReadOnlyList<TCTD>>>(() => this.ToGroupedDictionary(i => i.TCTDKEY));
            Index_TCTDKEY_TIME_TYPE_QKEY = new Lazy<Dictionary<Tuple<DateTime, short?, string>, IReadOnlyList<TCTD>>>(() => this.ToGroupedDictionary(i => Tuple.Create(i.TCTDKEY, i.TIME_TYPE, i.QKEY)));
            Index_TID = new Lazy<Dictionary<int, TCTD>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTD" /> fields for each CSV column header</returns>
        internal override Action<TCTD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TCTDKEY":
                        mapper[i] = (e, v) => e.TCTDKEY = DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "TIME_INDEX":
                        mapper[i] = (e, v) => e.TIME_INDEX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TIME_TYPE":
                        mapper[i] = (e, v) => e.TIME_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_NAME":
                        mapper[i] = (e, v) => e.TIME_NAME = v;
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
        /// Merges <see cref="TCTD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TCTD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TCTD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TCTD}"/> of entities</returns>
        internal override IEnumerable<TCTD> ApplyDeltaEntities(IEnumerable<TCTD> Entities, List<TCTD> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TCTDKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TCTDKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<TCTD>>> Index_QKEY;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTD>>> Index_TCTDKEY;
        private Lazy<Dictionary<Tuple<DateTime, short?, string>, IReadOnlyList<TCTD>>> Index_TCTDKEY_TIME_TYPE_QKEY;
        private Lazy<Dictionary<int, TCTD>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <param name="Value">List of related TCTD entities</param>
        /// <returns>True if the list of related TCTD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<TCTD> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<TCTD> value;
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
        /// Find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> FindByTCTDKEY(DateTime TCTDKEY)
        {
            return Index_TCTDKEY.Value[TCTDKEY];
        }

        /// <summary>
        /// Attempt to find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <param name="Value">List of related TCTD entities</param>
        /// <returns>True if the list of related TCTD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTDKEY(DateTime TCTDKEY, out IReadOnlyList<TCTD> Value)
        {
            return Index_TCTDKEY.Value.TryGetValue(TCTDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by TCTDKEY field
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> TryFindByTCTDKEY(DateTime TCTDKEY)
        {
            IReadOnlyList<TCTD> value;
            if (Index_TCTDKEY.Value.TryGetValue(TCTDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTD by TCTDKEY, TIME_TYPE and QKEY fields
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <param name="TIME_TYPE">TIME_TYPE value used to find TCTD</param>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> FindByTCTDKEY_TIME_TYPE_QKEY(DateTime TCTDKEY, short? TIME_TYPE, string QKEY)
        {
            return Index_TCTDKEY_TIME_TYPE_QKEY.Value[Tuple.Create(TCTDKEY, TIME_TYPE, QKEY)];
        }

        /// <summary>
        /// Attempt to find TCTD by TCTDKEY, TIME_TYPE and QKEY fields
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <param name="TIME_TYPE">TIME_TYPE value used to find TCTD</param>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <param name="Value">List of related TCTD entities</param>
        /// <returns>True if the list of related TCTD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCTDKEY_TIME_TYPE_QKEY(DateTime TCTDKEY, short? TIME_TYPE, string QKEY, out IReadOnlyList<TCTD> Value)
        {
            return Index_TCTDKEY_TIME_TYPE_QKEY.Value.TryGetValue(Tuple.Create(TCTDKEY, TIME_TYPE, QKEY), out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by TCTDKEY, TIME_TYPE and QKEY fields
        /// </summary>
        /// <param name="TCTDKEY">TCTDKEY value used to find TCTD</param>
        /// <param name="TIME_TYPE">TIME_TYPE value used to find TCTD</param>
        /// <param name="QKEY">QKEY value used to find TCTD</param>
        /// <returns>List of related TCTD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TCTD> TryFindByTCTDKEY_TIME_TYPE_QKEY(DateTime TCTDKEY, short? TIME_TYPE, string QKEY)
        {
            IReadOnlyList<TCTD> value;
            if (Index_TCTDKEY_TIME_TYPE_QKEY.Value.TryGetValue(Tuple.Create(TCTDKEY, TIME_TYPE, QKEY), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <returns>Related TCTD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTD FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <param name="Value">Related TCTD entity</param>
        /// <returns>True if the related TCTD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TCTD Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TCTD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TCTD</param>
        /// <returns>Related TCTD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCTD TryFindByTID(int TID)
        {
            TCTD value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TCTD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TCTD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TCTD](
        [TID] int IDENTITY NOT NULL,
        [TCTDKEY] datetime NOT NULL,
        [QKEY] varchar(8) NULL,
        [TIME_INDEX] smallint NULL,
        [TIME_START] datetime NULL,
        [TIME_END] datetime NULL,
        [TIME_TYPE] smallint NULL,
        [TIME_NAME] varchar(20) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TCTD_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TCTD_Index_QKEY] ON [dbo].[TCTD]
    (
            [QKEY] ASC
    );
    CREATE CLUSTERED INDEX [TCTD_Index_TCTDKEY] ON [dbo].[TCTD]
    (
            [TCTDKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [TCTD_Index_TCTDKEY_TIME_TYPE_QKEY] ON [dbo].[TCTD]
    (
            [TCTDKEY] ASC,
            [TIME_TYPE] ASC,
            [QKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTD]') AND name = N'TCTD_Index_QKEY')
    ALTER INDEX [TCTD_Index_QKEY] ON [dbo].[TCTD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTD]') AND name = N'TCTD_Index_TCTDKEY_TIME_TYPE_QKEY')
    ALTER INDEX [TCTD_Index_TCTDKEY_TIME_TYPE_QKEY] ON [dbo].[TCTD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTD]') AND name = N'TCTD_Index_TID')
    ALTER INDEX [TCTD_Index_TID] ON [dbo].[TCTD] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTD]') AND name = N'TCTD_Index_QKEY')
    ALTER INDEX [TCTD_Index_QKEY] ON [dbo].[TCTD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTD]') AND name = N'TCTD_Index_TCTDKEY_TIME_TYPE_QKEY')
    ALTER INDEX [TCTD_Index_TCTDKEY_TIME_TYPE_QKEY] ON [dbo].[TCTD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TCTD]') AND name = N'TCTD_Index_TID')
    ALTER INDEX [TCTD_Index_TID] ON [dbo].[TCTD] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TCTD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TCTD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TCTD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TCTD] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TCTD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTD data set</returns>
        public override EduHubDataSetDataReader<TCTD> GetDataSetDataReader()
        {
            return new TCTDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCTD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCTD data set</returns>
        public override EduHubDataSetDataReader<TCTD> GetDataSetDataReader(List<TCTD> Entities)
        {
            return new TCTDDataReader(new EduHubDataSetLoadedReader<TCTD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCTDDataReader : EduHubDataSetDataReader<TCTD>
        {
            public TCTDDataReader(IEduHubDataSetReader<TCTD> Reader)
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
                    case 1: // TCTDKEY
                        return Current.TCTDKEY;
                    case 2: // QKEY
                        return Current.QKEY;
                    case 3: // TIME_INDEX
                        return Current.TIME_INDEX;
                    case 4: // TIME_START
                        return Current.TIME_START;
                    case 5: // TIME_END
                        return Current.TIME_END;
                    case 6: // TIME_TYPE
                        return Current.TIME_TYPE;
                    case 7: // TIME_NAME
                        return Current.TIME_NAME;
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
                    case 2: // QKEY
                        return Current.QKEY == null;
                    case 3: // TIME_INDEX
                        return Current.TIME_INDEX == null;
                    case 4: // TIME_START
                        return Current.TIME_START == null;
                    case 5: // TIME_END
                        return Current.TIME_END == null;
                    case 6: // TIME_TYPE
                        return Current.TIME_TYPE == null;
                    case 7: // TIME_NAME
                        return Current.TIME_NAME == null;
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
                    case 1: // TCTDKEY
                        return "TCTDKEY";
                    case 2: // QKEY
                        return "QKEY";
                    case 3: // TIME_INDEX
                        return "TIME_INDEX";
                    case 4: // TIME_START
                        return "TIME_START";
                    case 5: // TIME_END
                        return "TIME_END";
                    case 6: // TIME_TYPE
                        return "TIME_TYPE";
                    case 7: // TIME_NAME
                        return "TIME_NAME";
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
                    case "TCTDKEY":
                        return 1;
                    case "QKEY":
                        return 2;
                    case "TIME_INDEX":
                        return 3;
                    case "TIME_START":
                        return 4;
                    case "TIME_END":
                        return 5;
                    case "TIME_TYPE":
                        return 6;
                    case "TIME_NAME":
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
