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
    /// Exam Periods Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEPDataSet : EduHubDataSet<TTEP>
    {
        /// <inheritdoc />
        public override string Name { get { return "TTEP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TTEPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEP>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEP" /> fields for each CSV column header</returns>
        internal override Action<TTEP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "TTEI_TID":
                        mapper[i] = (e, v) => e.TTEI_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXAM_DATE":
                        mapper[i] = (e, v) => e.EXAM_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EXAM_ROW":
                        mapper[i] = (e, v) => e.EXAM_ROW = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="TTEP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TTEP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TTEP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TTEP}"/> of entities</returns>
        internal override IEnumerable<TTEP> ApplyDeltaEntities(IEnumerable<TTEP> Entities, List<TTEP> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<TTEP>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEP by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEP</param>
        /// <returns>List of related TTEP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEP> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEP by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEP</param>
        /// <param name="Value">List of related TTEP entities</param>
        /// <returns>True if the list of related TTEP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEP> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEP by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEP</param>
        /// <returns>List of related TTEP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEP> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEP> value;
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
        /// Find TTEP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEP</param>
        /// <returns>Related TTEP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEP</param>
        /// <param name="Value">Related TTEP entity</param>
        /// <returns>True if the related TTEP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEP</param>
        /// <returns>Related TTEP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEP TryFindByTID(int TID)
        {
            TTEP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TTEP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTEP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTEP](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [TTEI_TID] int NULL,
        [EXAM_DATE] datetime NULL,
        [TIME_START] datetime NULL,
        [TIME_END] datetime NULL,
        [EXAM_ROW] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTEP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TTEP_Index_GKEY] ON [dbo].[TTEP]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEP]') AND name = N'TTEP_Index_TID')
    ALTER INDEX [TTEP_Index_TID] ON [dbo].[TTEP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEP]') AND name = N'TTEP_Index_TID')
    ALTER INDEX [TTEP_Index_TID] ON [dbo].[TTEP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TTEP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TTEP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TTEP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TTEP] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TTEP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEP data set</returns>
        public override EduHubDataSetDataReader<TTEP> GetDataSetDataReader()
        {
            return new TTEPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTEP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEP data set</returns>
        public override EduHubDataSetDataReader<TTEP> GetDataSetDataReader(List<TTEP> Entities)
        {
            return new TTEPDataReader(new EduHubDataSetLoadedReader<TTEP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTEPDataReader : EduHubDataSetDataReader<TTEP>
        {
            public TTEPDataReader(IEduHubDataSetReader<TTEP> Reader)
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
                    case 2: // TTEI_TID
                        return Current.TTEI_TID;
                    case 3: // EXAM_DATE
                        return Current.EXAM_DATE;
                    case 4: // TIME_START
                        return Current.TIME_START;
                    case 5: // TIME_END
                        return Current.TIME_END;
                    case 6: // EXAM_ROW
                        return Current.EXAM_ROW;
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
                    case 2: // TTEI_TID
                        return Current.TTEI_TID == null;
                    case 3: // EXAM_DATE
                        return Current.EXAM_DATE == null;
                    case 4: // TIME_START
                        return Current.TIME_START == null;
                    case 5: // TIME_END
                        return Current.TIME_END == null;
                    case 6: // EXAM_ROW
                        return Current.EXAM_ROW == null;
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
                    case 2: // TTEI_TID
                        return "TTEI_TID";
                    case 3: // EXAM_DATE
                        return "EXAM_DATE";
                    case 4: // TIME_START
                        return "TIME_START";
                    case 5: // TIME_END
                        return "TIME_END";
                    case 6: // EXAM_ROW
                        return "EXAM_ROW";
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
                    case "TTEI_TID":
                        return 2;
                    case "EXAM_DATE":
                        return 3;
                    case "TIME_START":
                        return 4;
                    case "TIME_END":
                        return 5;
                    case "EXAM_ROW":
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
#endif
