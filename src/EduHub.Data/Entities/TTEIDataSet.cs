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
    /// Exam Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTEIDataSet : EduHubDataSet<TTEI>
    {
        /// <inheritdoc />
        public override string Name { get { return "TTEI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TTEIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GKEY = new Lazy<Dictionary<string, IReadOnlyList<TTEI>>>(() => this.ToGroupedDictionary(i => i.GKEY));
            Index_TID = new Lazy<Dictionary<int, TTEI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TTEI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TTEI" /> fields for each CSV column header</returns>
        internal override Action<TTEI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TTEI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "GKEY":
                        mapper[i] = (e, v) => e.GKEY = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MAX_SIZE":
                        mapper[i] = (e, v) => e.MAX_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_LINES":
                        mapper[i] = (e, v) => e.MAX_LINES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "USE_FIXED":
                        mapper[i] = (e, v) => e.USE_FIXED = v;
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
        /// Merges <see cref="TTEI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TTEI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TTEI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TTEI}"/> of entities</returns>
        internal override IEnumerable<TTEI> ApplyDeltaEntities(IEnumerable<TTEI> Entities, List<TTEI> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<TTEI>>> Index_GKEY;
        private Lazy<Dictionary<int, TTEI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <returns>List of related TTEI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEI> FindByGKEY(string GKEY)
        {
            return Index_GKEY.Value[GKEY];
        }

        /// <summary>
        /// Attempt to find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <param name="Value">List of related TTEI entities</param>
        /// <returns>True if the list of related TTEI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGKEY(string GKEY, out IReadOnlyList<TTEI> Value)
        {
            return Index_GKEY.Value.TryGetValue(GKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TTEI by GKEY field
        /// </summary>
        /// <param name="GKEY">GKEY value used to find TTEI</param>
        /// <returns>List of related TTEI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TTEI> TryFindByGKEY(string GKEY)
        {
            IReadOnlyList<TTEI> value;
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
        /// Find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <returns>Related TTEI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <param name="Value">Related TTEI entity</param>
        /// <returns>True if the related TTEI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out TTEI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find TTEI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find TTEI</param>
        /// <returns>Related TTEI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TTEI TryFindByTID(int TID)
        {
            TTEI value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TTEI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TTEI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TTEI](
        [TID] int IDENTITY NOT NULL,
        [GKEY] varchar(8) NOT NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [MAX_SIZE] smallint NULL,
        [MAX_LINES] smallint NULL,
        [USE_FIXED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TTEI_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [TTEI_Index_GKEY] ON [dbo].[TTEI]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEI]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TTEI] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[TTEI]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[TTEI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TTEI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TTEI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TTEI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[TTEI] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the TTEI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEI data set</returns>
        public override EduHubDataSetDataReader<TTEI> GetDataSetDataReader()
        {
            return new TTEIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TTEI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TTEI data set</returns>
        public override EduHubDataSetDataReader<TTEI> GetDataSetDataReader(List<TTEI> Entities)
        {
            return new TTEIDataReader(new EduHubDataSetLoadedReader<TTEI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TTEIDataReader : EduHubDataSetDataReader<TTEI>
        {
            public TTEIDataReader(IEduHubDataSetReader<TTEI> Reader)
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
                    case 2: // START_DATE
                        return Current.START_DATE;
                    case 3: // END_DATE
                        return Current.END_DATE;
                    case 4: // MAX_SIZE
                        return Current.MAX_SIZE;
                    case 5: // MAX_LINES
                        return Current.MAX_LINES;
                    case 6: // USE_FIXED
                        return Current.USE_FIXED;
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
                    case 2: // START_DATE
                        return Current.START_DATE == null;
                    case 3: // END_DATE
                        return Current.END_DATE == null;
                    case 4: // MAX_SIZE
                        return Current.MAX_SIZE == null;
                    case 5: // MAX_LINES
                        return Current.MAX_LINES == null;
                    case 6: // USE_FIXED
                        return Current.USE_FIXED == null;
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
                    case 2: // START_DATE
                        return "START_DATE";
                    case 3: // END_DATE
                        return "END_DATE";
                    case 4: // MAX_SIZE
                        return "MAX_SIZE";
                    case 5: // MAX_LINES
                        return "MAX_LINES";
                    case 6: // USE_FIXED
                        return "USE_FIXED";
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
                    case "START_DATE":
                        return 2;
                    case "END_DATE":
                        return 3;
                    case "MAX_SIZE":
                        return 4;
                    case "MAX_LINES":
                        return 5;
                    case "USE_FIXED":
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
