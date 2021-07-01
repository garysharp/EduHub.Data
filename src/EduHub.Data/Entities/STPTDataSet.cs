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
    /// Student Part-Time Enrolments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPTDataSet : EduHubDataSet<STPT>
    {
        /// <inheritdoc />
        public override string Name { get { return "STPT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STPTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHL_NUM = new Lazy<NullDictionary<string, IReadOnlyList<STPT>>>(() => this.ToGroupedNullDictionary(i => i.SCHL_NUM));
            Index_STPTKEY = new Lazy<Dictionary<string, IReadOnlyList<STPT>>>(() => this.ToGroupedDictionary(i => i.STPTKEY));
            Index_STPTKEY_SCHL_NUM = new Lazy<Dictionary<Tuple<string, string>, STPT>>(() => this.ToDictionary(i => Tuple.Create(i.STPTKEY, i.SCHL_NUM)));
            Index_TID = new Lazy<Dictionary<int, STPT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPT" /> fields for each CSV column header</returns>
        internal override Action<STPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STPTKEY":
                        mapper[i] = (e, v) => e.STPTKEY = v;
                        break;
                    case "SCHL_NUM":
                        mapper[i] = (e, v) => e.SCHL_NUM = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ENROLLED":
                        mapper[i] = (e, v) => e.ENROLLED = v;
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
        /// Merges <see cref="STPT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STPT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STPT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STPT}"/> of entities</returns>
        internal override IEnumerable<STPT> ApplyDeltaEntities(IEnumerable<STPT> Entities, List<STPT> DeltaEntities)
        {
            HashSet<Tuple<string, string>> Index_STPTKEY_SCHL_NUM = new HashSet<Tuple<string, string>>(DeltaEntities.Select(i => Tuple.Create(i.STPTKEY, i.SCHL_NUM)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.STPTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_STPTKEY_SCHL_NUM.Remove(Tuple.Create(entity.STPTKEY, entity.SCHL_NUM));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.STPTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STPT>>> Index_SCHL_NUM;
        private Lazy<Dictionary<string, IReadOnlyList<STPT>>> Index_STPTKEY;
        private Lazy<Dictionary<Tuple<string, string>, STPT>> Index_STPTKEY_SCHL_NUM;
        private Lazy<Dictionary<int, STPT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>List of related STPT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> FindBySCHL_NUM(string SCHL_NUM)
        {
            return Index_SCHL_NUM.Value[SCHL_NUM];
        }

        /// <summary>
        /// Attempt to find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <param name="Value">List of related STPT entities</param>
        /// <returns>True if the list of related STPT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHL_NUM(string SCHL_NUM, out IReadOnlyList<STPT> Value)
        {
            return Index_SCHL_NUM.Value.TryGetValue(SCHL_NUM, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by SCHL_NUM field
        /// </summary>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>List of related STPT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> TryFindBySCHL_NUM(string SCHL_NUM)
        {
            IReadOnlyList<STPT> value;
            if (Index_SCHL_NUM.Value.TryGetValue(SCHL_NUM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <returns>List of related STPT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> FindBySTPTKEY(string STPTKEY)
        {
            return Index_STPTKEY.Value[STPTKEY];
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="Value">List of related STPT entities</param>
        /// <returns>True if the list of related STPT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPTKEY(string STPTKEY, out IReadOnlyList<STPT> Value)
        {
            return Index_STPTKEY.Value.TryGetValue(STPTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY field
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <returns>List of related STPT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPT> TryFindBySTPTKEY(string STPTKEY)
        {
            IReadOnlyList<STPT> value;
            if (Index_STPTKEY.Value.TryGetValue(STPTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>Related STPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT FindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM)
        {
            return Index_STPTKEY_SCHL_NUM.Value[Tuple.Create(STPTKEY, SCHL_NUM)];
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <param name="Value">Related STPT entity</param>
        /// <returns>True if the related STPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM, out STPT Value)
        {
            return Index_STPTKEY_SCHL_NUM.Value.TryGetValue(Tuple.Create(STPTKEY, SCHL_NUM), out Value);
        }

        /// <summary>
        /// Attempt to find STPT by STPTKEY and SCHL_NUM fields
        /// </summary>
        /// <param name="STPTKEY">STPTKEY value used to find STPT</param>
        /// <param name="SCHL_NUM">SCHL_NUM value used to find STPT</param>
        /// <returns>Related STPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT TryFindBySTPTKEY_SCHL_NUM(string STPTKEY, string SCHL_NUM)
        {
            STPT value;
            if (Index_STPTKEY_SCHL_NUM.Value.TryGetValue(Tuple.Create(STPTKEY, SCHL_NUM), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <returns>Related STPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <param name="Value">Related STPT entity</param>
        /// <returns>True if the related STPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STPT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STPT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPT</param>
        /// <returns>Related STPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPT TryFindByTID(int TID)
        {
            STPT value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STPT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STPT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STPT](
        [TID] int IDENTITY NOT NULL,
        [STPTKEY] varchar(10) NOT NULL,
        [SCHL_NUM] varchar(8) NULL,
        [SGB_TIME_FRACTION] float NULL,
        [ACTUAL_TIME_FRACTION] float NULL,
        [ENROLLED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STPT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STPT_Index_SCHL_NUM] ON [dbo].[STPT]
    (
            [SCHL_NUM] ASC
    );
    CREATE CLUSTERED INDEX [STPT_Index_STPTKEY] ON [dbo].[STPT]
    (
            [STPTKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STPT_Index_STPTKEY_SCHL_NUM] ON [dbo].[STPT]
    (
            [STPTKEY] ASC,
            [SCHL_NUM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPT]') AND name = N'STPT_Index_SCHL_NUM')
    ALTER INDEX [STPT_Index_SCHL_NUM] ON [dbo].[STPT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPT]') AND name = N'STPT_Index_STPTKEY_SCHL_NUM')
    ALTER INDEX [STPT_Index_STPTKEY_SCHL_NUM] ON [dbo].[STPT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPT]') AND name = N'STPT_Index_TID')
    ALTER INDEX [STPT_Index_TID] ON [dbo].[STPT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPT]') AND name = N'STPT_Index_SCHL_NUM')
    ALTER INDEX [STPT_Index_SCHL_NUM] ON [dbo].[STPT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPT]') AND name = N'STPT_Index_STPTKEY_SCHL_NUM')
    ALTER INDEX [STPT_Index_STPTKEY_SCHL_NUM] ON [dbo].[STPT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPT]') AND name = N'STPT_Index_TID')
    ALTER INDEX [STPT_Index_TID] ON [dbo].[STPT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STPT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STPT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STPT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, string>> Index_STPTKEY_SCHL_NUM = new List<Tuple<string, string>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_STPTKEY_SCHL_NUM.Add(Tuple.Create(entity.STPTKEY, entity.SCHL_NUM));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STPT] WHERE");


            // Index_STPTKEY_SCHL_NUM
            builder.Append("(");
            for (int index = 0; index < Index_STPTKEY_SCHL_NUM.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // STPTKEY
                var parameterSTPTKEY = $"@p{parameterIndex++}";
                builder.Append("([STPTKEY]=").Append(parameterSTPTKEY);
                command.Parameters.Add(parameterSTPTKEY, SqlDbType.VarChar, 10).Value = Index_STPTKEY_SCHL_NUM[index].Item1;

                // SCHL_NUM
                if (Index_STPTKEY_SCHL_NUM[index].Item2 == null)
                {
                    builder.Append(" AND [SCHL_NUM] IS NULL)");
                }
                else
                {
                    var parameterSCHL_NUM = $"@p{parameterIndex++}";
                    builder.Append(" AND [SCHL_NUM]=").Append(parameterSCHL_NUM).Append(")");
                    command.Parameters.Add(parameterSCHL_NUM, SqlDbType.VarChar, 8).Value = Index_STPTKEY_SCHL_NUM[index].Item2;
                }
            }
            builder.AppendLine(") OR");

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
        /// Provides a <see cref="IDataReader"/> for the STPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STPT data set</returns>
        public override EduHubDataSetDataReader<STPT> GetDataSetDataReader()
        {
            return new STPTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STPT data set</returns>
        public override EduHubDataSetDataReader<STPT> GetDataSetDataReader(List<STPT> Entities)
        {
            return new STPTDataReader(new EduHubDataSetLoadedReader<STPT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STPTDataReader : EduHubDataSetDataReader<STPT>
        {
            public STPTDataReader(IEduHubDataSetReader<STPT> Reader)
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
                    case 1: // STPTKEY
                        return Current.STPTKEY;
                    case 2: // SCHL_NUM
                        return Current.SCHL_NUM;
                    case 3: // SGB_TIME_FRACTION
                        return Current.SGB_TIME_FRACTION;
                    case 4: // ACTUAL_TIME_FRACTION
                        return Current.ACTUAL_TIME_FRACTION;
                    case 5: // ENROLLED
                        return Current.ENROLLED;
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
                    case 2: // SCHL_NUM
                        return Current.SCHL_NUM == null;
                    case 3: // SGB_TIME_FRACTION
                        return Current.SGB_TIME_FRACTION == null;
                    case 4: // ACTUAL_TIME_FRACTION
                        return Current.ACTUAL_TIME_FRACTION == null;
                    case 5: // ENROLLED
                        return Current.ENROLLED == null;
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
                    case 1: // STPTKEY
                        return "STPTKEY";
                    case 2: // SCHL_NUM
                        return "SCHL_NUM";
                    case 3: // SGB_TIME_FRACTION
                        return "SGB_TIME_FRACTION";
                    case 4: // ACTUAL_TIME_FRACTION
                        return "ACTUAL_TIME_FRACTION";
                    case 5: // ENROLLED
                        return "ENROLLED";
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
                    case "STPTKEY":
                        return 1;
                    case "SCHL_NUM":
                        return 2;
                    case "SGB_TIME_FRACTION":
                        return 3;
                    case "ACTUAL_TIME_FRACTION":
                        return 4;
                    case "ENROLLED":
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
