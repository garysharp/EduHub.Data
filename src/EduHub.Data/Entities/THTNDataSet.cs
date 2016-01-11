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
    /// Timetable Labels Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class THTNDataSet : EduHubDataSet<THTN>
    {
        /// <inheritdoc />
        public override string Name { get { return "THTN"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal THTNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<THTN>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_QKEY = new Lazy<Dictionary<string, IReadOnlyList<THTN>>>(() => this.ToGroupedDictionary(i => i.QKEY));
            Index_TID = new Lazy<Dictionary<int, THTN>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="THTN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="THTN" /> fields for each CSV column header</returns>
        internal override Action<THTN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<THTN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "LABEL_NUMBER":
                        mapper[i] = (e, v) => e.LABEL_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LABEL_TYPE":
                        mapper[i] = (e, v) => e.LABEL_TYPE = v;
                        break;
                    case "LABEL_NAME":
                        mapper[i] = (e, v) => e.LABEL_NAME = v;
                        break;
                    case "LABEL_COLOUR":
                        mapper[i] = (e, v) => e.LABEL_COLOUR = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="THTN" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="THTN" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="THTN" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{THTN}"/> of entities</returns>
        internal override IEnumerable<THTN> ApplyDeltaEntities(IEnumerable<THTN> Entities, List<THTN> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.QKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.QKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<DateTime?, IReadOnlyList<THTN>>> Index_LW_DATE;
        private Lazy<Dictionary<string, IReadOnlyList<THTN>>> Index_QKEY;
        private Lazy<Dictionary<int, THTN>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <returns>List of related THTN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <param name="Value">List of related THTN entities</param>
        /// <returns>True if the list of related THTN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<THTN> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find THTN</param>
        /// <returns>List of related THTN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<THTN> value;
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
        /// Find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <returns>List of related THTN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> FindByQKEY(string QKEY)
        {
            return Index_QKEY.Value[QKEY];
        }

        /// <summary>
        /// Attempt to find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <param name="Value">List of related THTN entities</param>
        /// <returns>True if the list of related THTN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQKEY(string QKEY, out IReadOnlyList<THTN> Value)
        {
            return Index_QKEY.Value.TryGetValue(QKEY, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by QKEY field
        /// </summary>
        /// <param name="QKEY">QKEY value used to find THTN</param>
        /// <returns>List of related THTN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<THTN> TryFindByQKEY(string QKEY)
        {
            IReadOnlyList<THTN> value;
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
        /// Find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <returns>Related THTN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public THTN FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <param name="Value">Related THTN entity</param>
        /// <returns>True if the related THTN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out THTN Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find THTN by TID field
        /// </summary>
        /// <param name="TID">TID value used to find THTN</param>
        /// <returns>Related THTN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public THTN TryFindByTID(int TID)
        {
            THTN value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a THTN table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[THTN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[THTN](
        [TID] int IDENTITY NOT NULL,
        [QKEY] varchar(8) NOT NULL,
        [LABEL_NUMBER] smallint NULL,
        [LABEL_TYPE] varchar(1) NULL,
        [LABEL_NAME] varchar(20) NULL,
        [LABEL_COLOUR] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [THTN_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [THTN_Index_LW_DATE] ON [dbo].[THTN]
    (
            [LW_DATE] ASC
    );
    CREATE CLUSTERED INDEX [THTN_Index_QKEY] ON [dbo].[THTN]
    (
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[THTN]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[THTN] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[THTN]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[THTN] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[THTN]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[THTN] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[THTN]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[THTN] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="THTN"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="THTN"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<THTN> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[THTN] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the THTN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the THTN data set</returns>
        public override EduHubDataSetDataReader<THTN> GetDataSetDataReader()
        {
            return new THTNDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the THTN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the THTN data set</returns>
        public override EduHubDataSetDataReader<THTN> GetDataSetDataReader(List<THTN> Entities)
        {
            return new THTNDataReader(new EduHubDataSetLoadedReader<THTN>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class THTNDataReader : EduHubDataSetDataReader<THTN>
        {
            public THTNDataReader(IEduHubDataSetReader<THTN> Reader)
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
                    case 1: // QKEY
                        return Current.QKEY;
                    case 2: // LABEL_NUMBER
                        return Current.LABEL_NUMBER;
                    case 3: // LABEL_TYPE
                        return Current.LABEL_TYPE;
                    case 4: // LABEL_NAME
                        return Current.LABEL_NAME;
                    case 5: // LABEL_COLOUR
                        return Current.LABEL_COLOUR;
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
                    case 2: // LABEL_NUMBER
                        return Current.LABEL_NUMBER == null;
                    case 3: // LABEL_TYPE
                        return Current.LABEL_TYPE == null;
                    case 4: // LABEL_NAME
                        return Current.LABEL_NAME == null;
                    case 5: // LABEL_COLOUR
                        return Current.LABEL_COLOUR == null;
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
                    case 1: // QKEY
                        return "QKEY";
                    case 2: // LABEL_NUMBER
                        return "LABEL_NUMBER";
                    case 3: // LABEL_TYPE
                        return "LABEL_TYPE";
                    case 4: // LABEL_NAME
                        return "LABEL_NAME";
                    case 5: // LABEL_COLOUR
                        return "LABEL_COLOUR";
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
                    case "QKEY":
                        return 1;
                    case "LABEL_NUMBER":
                        return 2;
                    case "LABEL_TYPE":
                        return 3;
                    case "LABEL_NAME":
                        return 4;
                    case "LABEL_COLOUR":
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
