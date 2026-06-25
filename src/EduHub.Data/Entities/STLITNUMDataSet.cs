#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
#if NET452
using System.Data.SqlClient;
#elif NET10_0
using Microsoft.Data.SqlClient;
#endif
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Literacy and Numeracy Programs Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STLITNUMDataSet : EduHubDataSet<STLITNUM>
    {
        /// <inheritdoc />
        public override string Name { get { return "STLITNUM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STLITNUMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<STLITNUM>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STLITNUM>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STLITNUM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STLITNUM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STLITNUM" /> fields for each CSV column header</returns>
        internal override Action<STLITNUM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STLITNUM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "FOCUS":
                        mapper[i] = (e, v) => e.FOCUS = v;
                        break;
                    case "TIMEFRAME01":
                        mapper[i] = (e, v) => e.TIMEFRAME01 = v;
                        break;
                    case "TIMEFRAME02":
                        mapper[i] = (e, v) => e.TIMEFRAME02 = v;
                        break;
                    case "TIMEFRAME03":
                        mapper[i] = (e, v) => e.TIMEFRAME03 = v;
                        break;
                    case "TIMEFRAME04":
                        mapper[i] = (e, v) => e.TIMEFRAME04 = v;
                        break;
                    case "DEL_MODEL":
                        mapper[i] = (e, v) => e.DEL_MODEL = v;
                        break;
                    case "SESSION_LENGTH":
                        mapper[i] = (e, v) => e.SESSION_LENGTH = v;
                        break;
                    case "SESSION_FREQ":
                        mapper[i] = (e, v) => e.SESSION_FREQ = v;
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
        /// Merges <see cref="STLITNUM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STLITNUM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STLITNUM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STLITNUM}"/> of entities</returns>
        internal override IEnumerable<STLITNUM> ApplyDeltaEntities(IEnumerable<STLITNUM> Entities, List<STLITNUM> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<DateTime?, IReadOnlyList<STLITNUM>>> Index_LW_DATE;
        private Lazy<Dictionary<string, IReadOnlyList<STLITNUM>>> Index_SKEY;
        private Lazy<Dictionary<int, STLITNUM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STLITNUM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STLITNUM</param>
        /// <returns>List of related STLITNUM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STLITNUM> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find STLITNUM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STLITNUM</param>
        /// <param name="Value">List of related STLITNUM entities</param>
        /// <returns>True if the list of related STLITNUM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<STLITNUM> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find STLITNUM by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find STLITNUM</param>
        /// <returns>List of related STLITNUM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STLITNUM> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<STLITNUM> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STLITNUM by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STLITNUM</param>
        /// <returns>List of related STLITNUM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STLITNUM> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STLITNUM by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STLITNUM</param>
        /// <param name="Value">List of related STLITNUM entities</param>
        /// <returns>True if the list of related STLITNUM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STLITNUM> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STLITNUM by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STLITNUM</param>
        /// <returns>List of related STLITNUM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STLITNUM> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STLITNUM> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STLITNUM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STLITNUM</param>
        /// <returns>Related STLITNUM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STLITNUM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STLITNUM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STLITNUM</param>
        /// <param name="Value">Related STLITNUM entity</param>
        /// <returns>True if the related STLITNUM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STLITNUM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STLITNUM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STLITNUM</param>
        /// <returns>Related STLITNUM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STLITNUM TryFindByTID(int TID)
        {
            STLITNUM value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STLITNUM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STLITNUM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STLITNUM](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [FOCUS] varchar(30) NULL,
        [TIMEFRAME01] varchar(1) NULL,
        [TIMEFRAME02] varchar(1) NULL,
        [TIMEFRAME03] varchar(1) NULL,
        [TIMEFRAME04] varchar(1) NULL,
        [DEL_MODEL] varchar(15) NULL,
        [SESSION_LENGTH] varchar(20) NULL,
        [SESSION_FREQ] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STLITNUM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STLITNUM_Index_LW_DATE] ON [dbo].[STLITNUM]
    (
            [LW_DATE] ASC
    );
    CREATE CLUSTERED INDEX [STLITNUM_Index_SKEY] ON [dbo].[STLITNUM]
    (
            [SKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STLITNUM]') AND name = N'STLITNUM_Index_LW_DATE')
    ALTER INDEX [STLITNUM_Index_LW_DATE] ON [dbo].[STLITNUM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STLITNUM]') AND name = N'STLITNUM_Index_TID')
    ALTER INDEX [STLITNUM_Index_TID] ON [dbo].[STLITNUM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STLITNUM]') AND name = N'STLITNUM_Index_LW_DATE')
    ALTER INDEX [STLITNUM_Index_LW_DATE] ON [dbo].[STLITNUM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STLITNUM]') AND name = N'STLITNUM_Index_TID')
    ALTER INDEX [STLITNUM_Index_TID] ON [dbo].[STLITNUM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STLITNUM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STLITNUM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STLITNUM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STLITNUM] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STLITNUM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STLITNUM data set</returns>
        public override EduHubDataSetDataReader<STLITNUM> GetDataSetDataReader()
        {
            return new STLITNUMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STLITNUM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STLITNUM data set</returns>
        public override EduHubDataSetDataReader<STLITNUM> GetDataSetDataReader(List<STLITNUM> Entities)
        {
            return new STLITNUMDataReader(new EduHubDataSetLoadedReader<STLITNUM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STLITNUMDataReader : EduHubDataSetDataReader<STLITNUM>
        {
            public STLITNUMDataReader(IEduHubDataSetReader<STLITNUM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SKEY
                        return Current.SKEY;
                    case 2: // FOCUS
                        return Current.FOCUS;
                    case 3: // TIMEFRAME01
                        return Current.TIMEFRAME01;
                    case 4: // TIMEFRAME02
                        return Current.TIMEFRAME02;
                    case 5: // TIMEFRAME03
                        return Current.TIMEFRAME03;
                    case 6: // TIMEFRAME04
                        return Current.TIMEFRAME04;
                    case 7: // DEL_MODEL
                        return Current.DEL_MODEL;
                    case 8: // SESSION_LENGTH
                        return Current.SESSION_LENGTH;
                    case 9: // SESSION_FREQ
                        return Current.SESSION_FREQ;
                    case 10: // LW_DATE
                        return Current.LW_DATE;
                    case 11: // LW_TIME
                        return Current.LW_TIME;
                    case 12: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // FOCUS
                        return Current.FOCUS == null;
                    case 3: // TIMEFRAME01
                        return Current.TIMEFRAME01 == null;
                    case 4: // TIMEFRAME02
                        return Current.TIMEFRAME02 == null;
                    case 5: // TIMEFRAME03
                        return Current.TIMEFRAME03 == null;
                    case 6: // TIMEFRAME04
                        return Current.TIMEFRAME04 == null;
                    case 7: // DEL_MODEL
                        return Current.DEL_MODEL == null;
                    case 8: // SESSION_LENGTH
                        return Current.SESSION_LENGTH == null;
                    case 9: // SESSION_FREQ
                        return Current.SESSION_FREQ == null;
                    case 10: // LW_DATE
                        return Current.LW_DATE == null;
                    case 11: // LW_TIME
                        return Current.LW_TIME == null;
                    case 12: // LW_USER
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
                    case 1: // SKEY
                        return "SKEY";
                    case 2: // FOCUS
                        return "FOCUS";
                    case 3: // TIMEFRAME01
                        return "TIMEFRAME01";
                    case 4: // TIMEFRAME02
                        return "TIMEFRAME02";
                    case 5: // TIMEFRAME03
                        return "TIMEFRAME03";
                    case 6: // TIMEFRAME04
                        return "TIMEFRAME04";
                    case 7: // DEL_MODEL
                        return "DEL_MODEL";
                    case 8: // SESSION_LENGTH
                        return "SESSION_LENGTH";
                    case 9: // SESSION_FREQ
                        return "SESSION_FREQ";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
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
                    case "SKEY":
                        return 1;
                    case "FOCUS":
                        return 2;
                    case "TIMEFRAME01":
                        return 3;
                    case "TIMEFRAME02":
                        return 4;
                    case "TIMEFRAME03":
                        return 5;
                    case "TIMEFRAME04":
                        return 6;
                    case "DEL_MODEL":
                        return 7;
                    case "SESSION_LENGTH":
                        return 8;
                    case "SESSION_FREQ":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
