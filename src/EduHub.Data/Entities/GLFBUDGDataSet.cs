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
    /// SP2 dummy table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFBUDGDataSet : EduHubDataSet<GLFBUDG>
    {
        /// <inheritdoc />
        public override string Name { get { return "GLFBUDG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal GLFBUDGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKEY = new Lazy<Dictionary<string, IReadOnlyList<GLFBUDG>>>(() => this.ToGroupedDictionary(i => i.BKEY));
            Index_TID = new Lazy<Dictionary<int, GLFBUDG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLFBUDG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLFBUDG" /> fields for each CSV column header</returns>
        internal override Action<GLFBUDG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLFBUDG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BKEY":
                        mapper[i] = (e, v) => e.BKEY = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="GLFBUDG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="GLFBUDG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="GLFBUDG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{GLFBUDG}"/> of entities</returns>
        internal override IEnumerable<GLFBUDG> ApplyDeltaEntities(IEnumerable<GLFBUDG> Entities, List<GLFBUDG> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.BKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.BKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<GLFBUDG>>> Index_BKEY;
        private Lazy<Dictionary<int, GLFBUDG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <returns>List of related GLFBUDG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBUDG> FindByBKEY(string BKEY)
        {
            return Index_BKEY.Value[BKEY];
        }

        /// <summary>
        /// Attempt to find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <param name="Value">List of related GLFBUDG entities</param>
        /// <returns>True if the list of related GLFBUDG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKEY(string BKEY, out IReadOnlyList<GLFBUDG> Value)
        {
            return Index_BKEY.Value.TryGetValue(BKEY, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBUDG by BKEY field
        /// </summary>
        /// <param name="BKEY">BKEY value used to find GLFBUDG</param>
        /// <returns>List of related GLFBUDG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBUDG> TryFindByBKEY(string BKEY)
        {
            IReadOnlyList<GLFBUDG> value;
            if (Index_BKEY.Value.TryGetValue(BKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <returns>Related GLFBUDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBUDG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <param name="Value">Related GLFBUDG entity</param>
        /// <returns>True if the related GLFBUDG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLFBUDG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBUDG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBUDG</param>
        /// <returns>Related GLFBUDG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBUDG TryFindByTID(int TID)
        {
            GLFBUDG value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a GLFBUDG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLFBUDG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLFBUDG](
        [TID] int IDENTITY NOT NULL,
        [BKEY] varchar(15) NOT NULL,
        [TRBATCH] int NULL,
        [TRAMT] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLFBUDG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [GLFBUDG_Index_BKEY] ON [dbo].[GLFBUDG]
    (
            [BKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLFBUDG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[GLFBUDG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLFBUDG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[GLFBUDG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="GLFBUDG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="GLFBUDG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<GLFBUDG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[GLFBUDG] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the GLFBUDG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLFBUDG data set</returns>
        public override EduHubDataSetDataReader<GLFBUDG> GetDataSetDataReader()
        {
            return new GLFBUDGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLFBUDG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLFBUDG data set</returns>
        public override EduHubDataSetDataReader<GLFBUDG> GetDataSetDataReader(List<GLFBUDG> Entities)
        {
            return new GLFBUDGDataReader(new EduHubDataSetLoadedReader<GLFBUDG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLFBUDGDataReader : EduHubDataSetDataReader<GLFBUDG>
        {
            public GLFBUDGDataReader(IEduHubDataSetReader<GLFBUDG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // BKEY
                        return Current.BKEY;
                    case 2: // TRBATCH
                        return Current.TRBATCH;
                    case 3: // TRAMT
                        return Current.TRAMT;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRBATCH
                        return Current.TRBATCH == null;
                    case 3: // TRAMT
                        return Current.TRAMT == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
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
                    case 1: // BKEY
                        return "BKEY";
                    case 2: // TRBATCH
                        return "TRBATCH";
                    case 3: // TRAMT
                        return "TRAMT";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
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
                    case "BKEY":
                        return 1;
                    case "TRBATCH":
                        return 2;
                    case "TRAMT":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
