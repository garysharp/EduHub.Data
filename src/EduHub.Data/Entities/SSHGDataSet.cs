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
    /// Specialist Subjects per Home Group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SSHGDataSet : EduHubDataSet<SSHG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SSHG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SSHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_HOMEGROUP = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.HOMEGROUP));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_SUBJECT = new Lazy<Dictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedDictionary(i => i.SUBJECT));
            Index_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.TEACHER));
            Index_TEACHING_HG = new Lazy<NullDictionary<string, IReadOnlyList<SSHG>>>(() => this.ToGroupedNullDictionary(i => i.TEACHING_HG));
            Index_TID = new Lazy<Dictionary<int, SSHG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SSHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SSHG" /> fields for each CSV column header</returns>
        internal override Action<SSHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SSHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "HOMEGROUP":
                        mapper[i] = (e, v) => e.HOMEGROUP = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "VARIATION":
                        mapper[i] = (e, v) => e.VARIATION = v;
                        break;
                    case "TEACHING_HG":
                        mapper[i] = (e, v) => e.TEACHING_HG = v;
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
        /// Merges <see cref="SSHG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SSHG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SSHG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SSHG}"/> of entities</returns>
        internal override IEnumerable<SSHG> ApplyDeltaEntities(IEnumerable<SSHG> Entities, List<SSHG> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SUBJECT;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SUBJECT.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_HOMEGROUP;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SSHG>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_STUDENT;
        private Lazy<Dictionary<string, IReadOnlyList<SSHG>>> Index_SUBJECT;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<SSHG>>> Index_TEACHING_HG;
        private Lazy<Dictionary<int, SSHG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByHOMEGROUP(string HOMEGROUP)
        {
            return Index_HOMEGROUP.Value[HOMEGROUP];
        }

        /// <summary>
        /// Attempt to find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOMEGROUP(string HOMEGROUP, out IReadOnlyList<SSHG> Value)
        {
            return Index_HOMEGROUP.Value.TryGetValue(HOMEGROUP, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by HOMEGROUP field
        /// </summary>
        /// <param name="HOMEGROUP">HOMEGROUP value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByHOMEGROUP(string HOMEGROUP)
        {
            IReadOnlyList<SSHG> value;
            if (Index_HOMEGROUP.Value.TryGetValue(HOMEGROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SSHG> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SSHG> value;
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
        /// Find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<SSHG> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<SSHG> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindBySUBJECT(string SUBJECT)
        {
            return Index_SUBJECT.Value[SUBJECT];
        }

        /// <summary>
        /// Attempt to find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJECT(string SUBJECT, out IReadOnlyList<SSHG> Value)
        {
            return Index_SUBJECT.Value.TryGetValue(SUBJECT, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by SUBJECT field
        /// </summary>
        /// <param name="SUBJECT">SUBJECT value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindBySUBJECT(string SUBJECT)
        {
            IReadOnlyList<SSHG> value;
            if (Index_SUBJECT.Value.TryGetValue(SUBJECT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByTEACHER(string TEACHER)
        {
            return Index_TEACHER.Value[TEACHER];
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHER(string TEACHER, out IReadOnlyList<SSHG> Value)
        {
            return Index_TEACHER.Value.TryGetValue(TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHER field
        /// </summary>
        /// <param name="TEACHER">TEACHER value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByTEACHER(string TEACHER)
        {
            IReadOnlyList<SSHG> value;
            if (Index_TEACHER.Value.TryGetValue(TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <returns>List of related SSHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> FindByTEACHING_HG(string TEACHING_HG)
        {
            return Index_TEACHING_HG.Value[TEACHING_HG];
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <param name="Value">List of related SSHG entities</param>
        /// <returns>True if the list of related SSHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACHING_HG(string TEACHING_HG, out IReadOnlyList<SSHG> Value)
        {
            return Index_TEACHING_HG.Value.TryGetValue(TEACHING_HG, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TEACHING_HG field
        /// </summary>
        /// <param name="TEACHING_HG">TEACHING_HG value used to find SSHG</param>
        /// <returns>List of related SSHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SSHG> TryFindByTEACHING_HG(string TEACHING_HG)
        {
            IReadOnlyList<SSHG> value;
            if (Index_TEACHING_HG.Value.TryGetValue(TEACHING_HG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <returns>Related SSHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SSHG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <param name="Value">Related SSHG entity</param>
        /// <returns>True if the related SSHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SSHG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SSHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SSHG</param>
        /// <returns>Related SSHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SSHG TryFindByTID(int TID)
        {
            SSHG value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SSHG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SSHG](
        [TID] int IDENTITY NOT NULL,
        [HOMEGROUP] varchar(3) NULL,
        [SUBJECT] varchar(10) NOT NULL,
        [TEACHER] varchar(4) NULL,
        [STUDENT] varchar(10) NULL,
        [VARIATION] varchar(3) NULL,
        [TEACHING_HG] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SSHG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_HOMEGROUP] ON [dbo].[SSHG]
    (
            [HOMEGROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_LW_DATE] ON [dbo].[SSHG]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_STUDENT] ON [dbo].[SSHG]
    (
            [STUDENT] ASC
    );
    CREATE CLUSTERED INDEX [SSHG_Index_SUBJECT] ON [dbo].[SSHG]
    (
            [SUBJECT] ASC
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_TEACHER] ON [dbo].[SSHG]
    (
            [TEACHER] ASC
    );
    CREATE NONCLUSTERED INDEX [SSHG_Index_TEACHING_HG] ON [dbo].[SSHG]
    (
            [TEACHING_HG] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_HOMEGROUP')
    ALTER INDEX [SSHG_Index_HOMEGROUP] ON [dbo].[SSHG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_LW_DATE')
    ALTER INDEX [SSHG_Index_LW_DATE] ON [dbo].[SSHG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_STUDENT')
    ALTER INDEX [SSHG_Index_STUDENT] ON [dbo].[SSHG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_TEACHER')
    ALTER INDEX [SSHG_Index_TEACHER] ON [dbo].[SSHG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_TEACHING_HG')
    ALTER INDEX [SSHG_Index_TEACHING_HG] ON [dbo].[SSHG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_TID')
    ALTER INDEX [SSHG_Index_TID] ON [dbo].[SSHG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_HOMEGROUP')
    ALTER INDEX [SSHG_Index_HOMEGROUP] ON [dbo].[SSHG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_LW_DATE')
    ALTER INDEX [SSHG_Index_LW_DATE] ON [dbo].[SSHG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_STUDENT')
    ALTER INDEX [SSHG_Index_STUDENT] ON [dbo].[SSHG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_TEACHER')
    ALTER INDEX [SSHG_Index_TEACHER] ON [dbo].[SSHG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_TEACHING_HG')
    ALTER INDEX [SSHG_Index_TEACHING_HG] ON [dbo].[SSHG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SSHG]') AND name = N'SSHG_Index_TID')
    ALTER INDEX [SSHG_Index_TID] ON [dbo].[SSHG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SSHG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SSHG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SSHG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SSHG] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SSHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SSHG data set</returns>
        public override EduHubDataSetDataReader<SSHG> GetDataSetDataReader()
        {
            return new SSHGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SSHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SSHG data set</returns>
        public override EduHubDataSetDataReader<SSHG> GetDataSetDataReader(List<SSHG> Entities)
        {
            return new SSHGDataReader(new EduHubDataSetLoadedReader<SSHG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SSHGDataReader : EduHubDataSetDataReader<SSHG>
        {
            public SSHGDataReader(IEduHubDataSetReader<SSHG> Reader)
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
                    case 1: // HOMEGROUP
                        return Current.HOMEGROUP;
                    case 2: // SUBJECT
                        return Current.SUBJECT;
                    case 3: // TEACHER
                        return Current.TEACHER;
                    case 4: // STUDENT
                        return Current.STUDENT;
                    case 5: // VARIATION
                        return Current.VARIATION;
                    case 6: // TEACHING_HG
                        return Current.TEACHING_HG;
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
                    case 1: // HOMEGROUP
                        return Current.HOMEGROUP == null;
                    case 3: // TEACHER
                        return Current.TEACHER == null;
                    case 4: // STUDENT
                        return Current.STUDENT == null;
                    case 5: // VARIATION
                        return Current.VARIATION == null;
                    case 6: // TEACHING_HG
                        return Current.TEACHING_HG == null;
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
                    case 1: // HOMEGROUP
                        return "HOMEGROUP";
                    case 2: // SUBJECT
                        return "SUBJECT";
                    case 3: // TEACHER
                        return "TEACHER";
                    case 4: // STUDENT
                        return "STUDENT";
                    case 5: // VARIATION
                        return "VARIATION";
                    case 6: // TEACHING_HG
                        return "TEACHING_HG";
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
                    case "HOMEGROUP":
                        return 1;
                    case "SUBJECT":
                        return 2;
                    case "TEACHER":
                        return 3;
                    case "STUDENT":
                        return 4;
                    case "VARIATION":
                        return 5;
                    case "TEACHING_HG":
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
