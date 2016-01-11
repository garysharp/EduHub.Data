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
    /// Disciplinary Actions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDPADataSet : EduHubDataSet<SDPA>
    {
        /// <inheritdoc />
        public override string Name { get { return "SDPA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SDPADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACTION_TAKEN = new Lazy<NullDictionary<string, IReadOnlyList<SDPA>>>(() => this.ToGroupedNullDictionary(i => i.ACTION_TAKEN));
            Index_SDP_STUDENT = new Lazy<Dictionary<int, IReadOnlyList<SDPA>>>(() => this.ToGroupedDictionary(i => i.SDP_STUDENT));
            Index_TAKEN_BY = new Lazy<NullDictionary<string, IReadOnlyList<SDPA>>>(() => this.ToGroupedNullDictionary(i => i.TAKEN_BY));
            Index_TID = new Lazy<Dictionary<int, SDPA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDPA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDPA" /> fields for each CSV column header</returns>
        internal override Action<SDPA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDPA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SDP_STUDENT":
                        mapper[i] = (e, v) => e.SDP_STUDENT = int.Parse(v);
                        break;
                    case "TAKEN_BY":
                        mapper[i] = (e, v) => e.TAKEN_BY = v;
                        break;
                    case "ACTION_TAKEN":
                        mapper[i] = (e, v) => e.ACTION_TAKEN = v;
                        break;
                    case "OTHER_ACTION":
                        mapper[i] = (e, v) => e.OTHER_ACTION = v;
                        break;
                    case "COMPLIED":
                        mapper[i] = (e, v) => e.COMPLIED = v;
                        break;
                    case "PARENT_INFORMED":
                        mapper[i] = (e, v) => e.PARENT_INFORMED = v;
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
        /// Merges <see cref="SDPA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SDPA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SDPA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SDPA}"/> of entities</returns>
        internal override IEnumerable<SDPA> ApplyDeltaEntities(IEnumerable<SDPA> Entities, List<SDPA> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SDP_STUDENT;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SDP_STUDENT.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SDPA>>> Index_ACTION_TAKEN;
        private Lazy<Dictionary<int, IReadOnlyList<SDPA>>> Index_SDP_STUDENT;
        private Lazy<NullDictionary<string, IReadOnlyList<SDPA>>> Index_TAKEN_BY;
        private Lazy<Dictionary<int, SDPA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDPA by ACTION_TAKEN field
        /// </summary>
        /// <param name="ACTION_TAKEN">ACTION_TAKEN value used to find SDPA</param>
        /// <returns>List of related SDPA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> FindByACTION_TAKEN(string ACTION_TAKEN)
        {
            return Index_ACTION_TAKEN.Value[ACTION_TAKEN];
        }

        /// <summary>
        /// Attempt to find SDPA by ACTION_TAKEN field
        /// </summary>
        /// <param name="ACTION_TAKEN">ACTION_TAKEN value used to find SDPA</param>
        /// <param name="Value">List of related SDPA entities</param>
        /// <returns>True if the list of related SDPA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACTION_TAKEN(string ACTION_TAKEN, out IReadOnlyList<SDPA> Value)
        {
            return Index_ACTION_TAKEN.Value.TryGetValue(ACTION_TAKEN, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by ACTION_TAKEN field
        /// </summary>
        /// <param name="ACTION_TAKEN">ACTION_TAKEN value used to find SDPA</param>
        /// <returns>List of related SDPA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> TryFindByACTION_TAKEN(string ACTION_TAKEN)
        {
            IReadOnlyList<SDPA> value;
            if (Index_ACTION_TAKEN.Value.TryGetValue(ACTION_TAKEN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDPA by SDP_STUDENT field
        /// </summary>
        /// <param name="SDP_STUDENT">SDP_STUDENT value used to find SDPA</param>
        /// <returns>List of related SDPA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> FindBySDP_STUDENT(int SDP_STUDENT)
        {
            return Index_SDP_STUDENT.Value[SDP_STUDENT];
        }

        /// <summary>
        /// Attempt to find SDPA by SDP_STUDENT field
        /// </summary>
        /// <param name="SDP_STUDENT">SDP_STUDENT value used to find SDPA</param>
        /// <param name="Value">List of related SDPA entities</param>
        /// <returns>True if the list of related SDPA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDP_STUDENT(int SDP_STUDENT, out IReadOnlyList<SDPA> Value)
        {
            return Index_SDP_STUDENT.Value.TryGetValue(SDP_STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by SDP_STUDENT field
        /// </summary>
        /// <param name="SDP_STUDENT">SDP_STUDENT value used to find SDPA</param>
        /// <returns>List of related SDPA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> TryFindBySDP_STUDENT(int SDP_STUDENT)
        {
            IReadOnlyList<SDPA> value;
            if (Index_SDP_STUDENT.Value.TryGetValue(SDP_STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDPA by TAKEN_BY field
        /// </summary>
        /// <param name="TAKEN_BY">TAKEN_BY value used to find SDPA</param>
        /// <returns>List of related SDPA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> FindByTAKEN_BY(string TAKEN_BY)
        {
            return Index_TAKEN_BY.Value[TAKEN_BY];
        }

        /// <summary>
        /// Attempt to find SDPA by TAKEN_BY field
        /// </summary>
        /// <param name="TAKEN_BY">TAKEN_BY value used to find SDPA</param>
        /// <param name="Value">List of related SDPA entities</param>
        /// <returns>True if the list of related SDPA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTAKEN_BY(string TAKEN_BY, out IReadOnlyList<SDPA> Value)
        {
            return Index_TAKEN_BY.Value.TryGetValue(TAKEN_BY, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by TAKEN_BY field
        /// </summary>
        /// <param name="TAKEN_BY">TAKEN_BY value used to find SDPA</param>
        /// <returns>List of related SDPA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDPA> TryFindByTAKEN_BY(string TAKEN_BY)
        {
            IReadOnlyList<SDPA> value;
            if (Index_TAKEN_BY.Value.TryGetValue(TAKEN_BY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDPA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDPA</param>
        /// <returns>Related SDPA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDPA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SDPA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDPA</param>
        /// <param name="Value">Related SDPA entity</param>
        /// <returns>True if the related SDPA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SDPA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SDPA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDPA</param>
        /// <returns>Related SDPA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDPA TryFindByTID(int TID)
        {
            SDPA value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SDPA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SDPA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SDPA](
        [TID] int IDENTITY NOT NULL,
        [SDP_STUDENT] int NOT NULL,
        [TAKEN_BY] varchar(4) NULL,
        [ACTION_TAKEN] varchar(5) NULL,
        [OTHER_ACTION] text NULL,
        [COMPLIED] varchar(1) NULL,
        [PARENT_INFORMED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SDPA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SDPA_Index_ACTION_TAKEN] ON [dbo].[SDPA]
    (
            [ACTION_TAKEN] ASC
    );
    CREATE CLUSTERED INDEX [SDPA_Index_SDP_STUDENT] ON [dbo].[SDPA]
    (
            [SDP_STUDENT] ASC
    );
    CREATE NONCLUSTERED INDEX [SDPA_Index_TAKEN_BY] ON [dbo].[SDPA]
    (
            [TAKEN_BY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDPA]') AND name = N'Index_ACTION_TAKEN')
    ALTER INDEX [Index_ACTION_TAKEN] ON [dbo].[SDPA] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDPA]') AND name = N'Index_TAKEN_BY')
    ALTER INDEX [Index_TAKEN_BY] ON [dbo].[SDPA] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDPA]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SDPA] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDPA]') AND name = N'Index_ACTION_TAKEN')
    ALTER INDEX [Index_ACTION_TAKEN] ON [dbo].[SDPA] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDPA]') AND name = N'Index_TAKEN_BY')
    ALTER INDEX [Index_TAKEN_BY] ON [dbo].[SDPA] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDPA]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SDPA] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SDPA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SDPA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SDPA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SDPA] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SDPA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDPA data set</returns>
        public override EduHubDataSetDataReader<SDPA> GetDataSetDataReader()
        {
            return new SDPADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDPA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDPA data set</returns>
        public override EduHubDataSetDataReader<SDPA> GetDataSetDataReader(List<SDPA> Entities)
        {
            return new SDPADataReader(new EduHubDataSetLoadedReader<SDPA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SDPADataReader : EduHubDataSetDataReader<SDPA>
        {
            public SDPADataReader(IEduHubDataSetReader<SDPA> Reader)
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
                    case 1: // SDP_STUDENT
                        return Current.SDP_STUDENT;
                    case 2: // TAKEN_BY
                        return Current.TAKEN_BY;
                    case 3: // ACTION_TAKEN
                        return Current.ACTION_TAKEN;
                    case 4: // OTHER_ACTION
                        return Current.OTHER_ACTION;
                    case 5: // COMPLIED
                        return Current.COMPLIED;
                    case 6: // PARENT_INFORMED
                        return Current.PARENT_INFORMED;
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
                    case 2: // TAKEN_BY
                        return Current.TAKEN_BY == null;
                    case 3: // ACTION_TAKEN
                        return Current.ACTION_TAKEN == null;
                    case 4: // OTHER_ACTION
                        return Current.OTHER_ACTION == null;
                    case 5: // COMPLIED
                        return Current.COMPLIED == null;
                    case 6: // PARENT_INFORMED
                        return Current.PARENT_INFORMED == null;
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
                    case 1: // SDP_STUDENT
                        return "SDP_STUDENT";
                    case 2: // TAKEN_BY
                        return "TAKEN_BY";
                    case 3: // ACTION_TAKEN
                        return "ACTION_TAKEN";
                    case 4: // OTHER_ACTION
                        return "OTHER_ACTION";
                    case 5: // COMPLIED
                        return "COMPLIED";
                    case 6: // PARENT_INFORMED
                        return "PARENT_INFORMED";
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
                    case "SDP_STUDENT":
                        return 1;
                    case "TAKEN_BY":
                        return 2;
                    case "ACTION_TAKEN":
                        return 3;
                    case "OTHER_ACTION":
                        return 4;
                    case "COMPLIED":
                        return 5;
                    case "PARENT_INFORMED":
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
