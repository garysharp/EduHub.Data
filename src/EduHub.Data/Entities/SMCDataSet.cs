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
    /// Student Medical Conditions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMCDataSet : EduHubDataSet<SMC>
    {
        /// <inheritdoc />
        public override string Name { get { return "SMC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SMCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_MED_CONDITION = new Lazy<NullDictionary<string, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.MED_CONDITION));
            Index_SMCKEY = new Lazy<Dictionary<int, SMC>>(() => this.ToDictionary(i => i.SMCKEY));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<SMC>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMC" /> fields for each CSV column header</returns>
        internal override Action<SMC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SMCKEY":
                        mapper[i] = (e, v) => e.SMCKEY = int.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "MED_CONDITION":
                        mapper[i] = (e, v) => e.MED_CONDITION = v;
                        break;
                    case "SYMPTOMS":
                        mapper[i] = (e, v) => e.SYMPTOMS = v;
                        break;
                    case "SMC_COMMENT":
                        mapper[i] = (e, v) => e.SMC_COMMENT = v;
                        break;
                    case "REGULAR_MEDICATION":
                        mapper[i] = (e, v) => e.REGULAR_MEDICATION = v;
                        break;
                    case "REGULAR_POISON_RATING":
                        mapper[i] = (e, v) => e.REGULAR_POISON_RATING = v;
                        break;
                    case "REGULAR_DOSAGE":
                        mapper[i] = (e, v) => e.REGULAR_DOSAGE = v;
                        break;
                    case "REGULAR_FREQUENCY":
                        mapper[i] = (e, v) => e.REGULAR_FREQUENCY = v;
                        break;
                    case "REGULAR_DOSAGE_TIME":
                        mapper[i] = (e, v) => e.REGULAR_DOSAGE_TIME = v;
                        break;
                    case "REGULAR_MEDICATION_LOCAT":
                        mapper[i] = (e, v) => e.REGULAR_MEDICATION_LOCAT = v;
                        break;
                    case "REGULAR_ADMIN_BY":
                        mapper[i] = (e, v) => e.REGULAR_ADMIN_BY = v;
                        break;
                    case "REMINDER":
                        mapper[i] = (e, v) => e.REMINDER = v;
                        break;
                    case "INFORM_DOCTOR":
                        mapper[i] = (e, v) => e.INFORM_DOCTOR = v;
                        break;
                    case "INFORM_EMERG_CONTACT":
                        mapper[i] = (e, v) => e.INFORM_EMERG_CONTACT = v;
                        break;
                    case "ADMINISTER_MEDICATION":
                        mapper[i] = (e, v) => e.ADMINISTER_MEDICATION = v;
                        break;
                    case "OTHER_MEDICAL_ACTION":
                        mapper[i] = (e, v) => e.OTHER_MEDICAL_ACTION = v;
                        break;
                    case "SMC_ACTION":
                        mapper[i] = (e, v) => e.SMC_ACTION = v;
                        break;
                    case "AD_HOC_MEDICATION":
                        mapper[i] = (e, v) => e.AD_HOC_MEDICATION = v;
                        break;
                    case "AD_HOC_POISON_RATING":
                        mapper[i] = (e, v) => e.AD_HOC_POISON_RATING = v;
                        break;
                    case "AD_HOC_DOSAGE":
                        mapper[i] = (e, v) => e.AD_HOC_DOSAGE = v;
                        break;
                    case "AD_HOC_FREQUENCY":
                        mapper[i] = (e, v) => e.AD_HOC_FREQUENCY = v;
                        break;
                    case "AD_HOC_MEDICATION_LOCAT":
                        mapper[i] = (e, v) => e.AD_HOC_MEDICATION_LOCAT = v;
                        break;
                    case "AD_HOC_ADMIN_BY":
                        mapper[i] = (e, v) => e.AD_HOC_ADMIN_BY = v;
                        break;
                    case "HOME_MEDICATION":
                        mapper[i] = (e, v) => e.HOME_MEDICATION = v;
                        break;
                    case "ASTHMA_WHEEZE":
                        mapper[i] = (e, v) => e.ASTHMA_WHEEZE = v;
                        break;
                    case "ASTHMA_COUGH":
                        mapper[i] = (e, v) => e.ASTHMA_COUGH = v;
                        break;
                    case "ASTHMA_DIFFBRE":
                        mapper[i] = (e, v) => e.ASTHMA_DIFFBRE = v;
                        break;
                    case "ASTHMA_TGTCHES":
                        mapper[i] = (e, v) => e.ASTHMA_TGTCHES = v;
                        break;
                    case "ASTHMA_SYMTEXE":
                        mapper[i] = (e, v) => e.ASTHMA_SYMTEXE = v;
                        break;
                    case "ASTHMA_MGT_PLAN":
                        mapper[i] = (e, v) => e.ASTHMA_MGT_PLAN = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "ROOM_TYPE":
                        mapper[i] = (e, v) => e.ROOM_TYPE = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GROUP_INDICATOR":
                        mapper[i] = (e, v) => e.GROUP_INDICATOR = v;
                        break;
                    case "DISABILITY_ADJUSTMENT":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT = v;
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
        /// Merges <see cref="SMC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SMC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SMC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SMC}"/> of entities</returns>
        internal override IEnumerable<SMC> ApplyDeltaEntities(IEnumerable<SMC> Entities, List<SMC> DeltaEntities)
        {
            HashSet<int> Index_SMCKEY = new HashSet<int>(DeltaEntities.Select(i => i.SMCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SMCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SMCKEY.Remove(entity.SMCKEY);
                            
                            if (entity.SMCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<SMC>>> Index_CAMPUS;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SMC>>> Index_LW_DATE;
        private Lazy<NullDictionary<string, IReadOnlyList<SMC>>> Index_MED_CONDITION;
        private Lazy<Dictionary<int, SMC>> Index_SMCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SMC>>> Index_STUDENT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SMC> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SMC> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SMC> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SMC> value;
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
        /// Find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindByMED_CONDITION(string MED_CONDITION)
        {
            return Index_MED_CONDITION.Value[MED_CONDITION];
        }

        /// <summary>
        /// Attempt to find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMED_CONDITION(string MED_CONDITION, out IReadOnlyList<SMC> Value)
        {
            return Index_MED_CONDITION.Value.TryGetValue(MED_CONDITION, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by MED_CONDITION field
        /// </summary>
        /// <param name="MED_CONDITION">MED_CONDITION value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindByMED_CONDITION(string MED_CONDITION)
        {
            IReadOnlyList<SMC> value;
            if (Index_MED_CONDITION.Value.TryGetValue(MED_CONDITION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <returns>Related SMC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC FindBySMCKEY(int SMCKEY)
        {
            return Index_SMCKEY.Value[SMCKEY];
        }

        /// <summary>
        /// Attempt to find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <param name="Value">Related SMC entity</param>
        /// <returns>True if the related SMC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySMCKEY(int SMCKEY, out SMC Value)
        {
            return Index_SMCKEY.Value.TryGetValue(SMCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by SMCKEY field
        /// </summary>
        /// <param name="SMCKEY">SMCKEY value used to find SMC</param>
        /// <returns>Related SMC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC TryFindBySMCKEY(int SMCKEY)
        {
            SMC value;
            if (Index_SMCKEY.Value.TryGetValue(SMCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <returns>List of related SMC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <param name="Value">List of related SMC entities</param>
        /// <returns>True if the list of related SMC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<SMC> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find SMC by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find SMC</param>
        /// <returns>List of related SMC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<SMC> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SMC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMC](
        [SMCKEY] int IDENTITY NOT NULL,
        [STUDENT] varchar(10) NULL,
        [MED_CONDITION] varchar(10) NULL,
        [SYMPTOMS] text NULL,
        [SMC_COMMENT] text NULL,
        [REGULAR_MEDICATION] varchar(60) NULL,
        [REGULAR_POISON_RATING] varchar(2) NULL,
        [REGULAR_DOSAGE] varchar(30) NULL,
        [REGULAR_FREQUENCY] varchar(15) NULL,
        [REGULAR_DOSAGE_TIME] varchar(15) NULL,
        [REGULAR_MEDICATION_LOCAT] varchar(30) NULL,
        [REGULAR_ADMIN_BY] varchar(7) NULL,
        [REMINDER] varchar(1) NULL,
        [INFORM_DOCTOR] varchar(1) NULL,
        [INFORM_EMERG_CONTACT] varchar(1) NULL,
        [ADMINISTER_MEDICATION] varchar(1) NULL,
        [OTHER_MEDICAL_ACTION] varchar(1) NULL,
        [SMC_ACTION] text NULL,
        [AD_HOC_MEDICATION] varchar(60) NULL,
        [AD_HOC_POISON_RATING] varchar(2) NULL,
        [AD_HOC_DOSAGE] varchar(30) NULL,
        [AD_HOC_FREQUENCY] varchar(15) NULL,
        [AD_HOC_MEDICATION_LOCAT] varchar(30) NULL,
        [AD_HOC_ADMIN_BY] varchar(7) NULL,
        [HOME_MEDICATION] varchar(60) NULL,
        [ASTHMA_WHEEZE] varchar(1) NULL,
        [ASTHMA_COUGH] varchar(1) NULL,
        [ASTHMA_DIFFBRE] varchar(1) NULL,
        [ASTHMA_TGTCHES] varchar(1) NULL,
        [ASTHMA_SYMTEXE] varchar(1) NULL,
        [ASTHMA_MGT_PLAN] text NULL,
        [CAMPUS] int NULL,
        [FACULTY] varchar(10) NULL,
        [ROOM_TYPE] varchar(1) NULL,
        [NORMAL_ALLOTMENT] smallint NULL,
        [GROUP_INDICATOR] varchar(1) NULL,
        [DISABILITY_ADJUSTMENT] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMC_Index_SMCKEY] PRIMARY KEY CLUSTERED (
            [SMCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SMC_Index_CAMPUS] ON [dbo].[SMC]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SMC_Index_LW_DATE] ON [dbo].[SMC]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SMC_Index_MED_CONDITION] ON [dbo].[SMC]
    (
            [MED_CONDITION] ASC
    );
    CREATE NONCLUSTERED INDEX [SMC_Index_STUDENT] ON [dbo].[SMC]
    (
            [STUDENT] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SMC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SMC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND name = N'Index_MED_CONDITION')
    ALTER INDEX [Index_MED_CONDITION] ON [dbo].[SMC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND name = N'Index_STUDENT')
    ALTER INDEX [Index_STUDENT] ON [dbo].[SMC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SMC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[SMC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND name = N'Index_MED_CONDITION')
    ALTER INDEX [Index_MED_CONDITION] ON [dbo].[SMC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC]') AND name = N'Index_STUDENT')
    ALTER INDEX [Index_STUDENT] ON [dbo].[SMC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SMC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SMC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SMC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SMCKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SMCKEY.Add(entity.SMCKEY);
            }

            builder.AppendLine("DELETE [dbo].[SMC] WHERE");


            // Index_SMCKEY
            builder.Append("[SMCKEY] IN (");
            for (int index = 0; index < Index_SMCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SMCKEY
                var parameterSMCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSMCKEY);
                command.Parameters.Add(parameterSMCKEY, SqlDbType.Int).Value = Index_SMCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMC data set</returns>
        public override EduHubDataSetDataReader<SMC> GetDataSetDataReader()
        {
            return new SMCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMC data set</returns>
        public override EduHubDataSetDataReader<SMC> GetDataSetDataReader(List<SMC> Entities)
        {
            return new SMCDataReader(new EduHubDataSetLoadedReader<SMC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMCDataReader : EduHubDataSetDataReader<SMC>
        {
            public SMCDataReader(IEduHubDataSetReader<SMC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 40; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SMCKEY
                        return Current.SMCKEY;
                    case 1: // STUDENT
                        return Current.STUDENT;
                    case 2: // MED_CONDITION
                        return Current.MED_CONDITION;
                    case 3: // SYMPTOMS
                        return Current.SYMPTOMS;
                    case 4: // SMC_COMMENT
                        return Current.SMC_COMMENT;
                    case 5: // REGULAR_MEDICATION
                        return Current.REGULAR_MEDICATION;
                    case 6: // REGULAR_POISON_RATING
                        return Current.REGULAR_POISON_RATING;
                    case 7: // REGULAR_DOSAGE
                        return Current.REGULAR_DOSAGE;
                    case 8: // REGULAR_FREQUENCY
                        return Current.REGULAR_FREQUENCY;
                    case 9: // REGULAR_DOSAGE_TIME
                        return Current.REGULAR_DOSAGE_TIME;
                    case 10: // REGULAR_MEDICATION_LOCAT
                        return Current.REGULAR_MEDICATION_LOCAT;
                    case 11: // REGULAR_ADMIN_BY
                        return Current.REGULAR_ADMIN_BY;
                    case 12: // REMINDER
                        return Current.REMINDER;
                    case 13: // INFORM_DOCTOR
                        return Current.INFORM_DOCTOR;
                    case 14: // INFORM_EMERG_CONTACT
                        return Current.INFORM_EMERG_CONTACT;
                    case 15: // ADMINISTER_MEDICATION
                        return Current.ADMINISTER_MEDICATION;
                    case 16: // OTHER_MEDICAL_ACTION
                        return Current.OTHER_MEDICAL_ACTION;
                    case 17: // SMC_ACTION
                        return Current.SMC_ACTION;
                    case 18: // AD_HOC_MEDICATION
                        return Current.AD_HOC_MEDICATION;
                    case 19: // AD_HOC_POISON_RATING
                        return Current.AD_HOC_POISON_RATING;
                    case 20: // AD_HOC_DOSAGE
                        return Current.AD_HOC_DOSAGE;
                    case 21: // AD_HOC_FREQUENCY
                        return Current.AD_HOC_FREQUENCY;
                    case 22: // AD_HOC_MEDICATION_LOCAT
                        return Current.AD_HOC_MEDICATION_LOCAT;
                    case 23: // AD_HOC_ADMIN_BY
                        return Current.AD_HOC_ADMIN_BY;
                    case 24: // HOME_MEDICATION
                        return Current.HOME_MEDICATION;
                    case 25: // ASTHMA_WHEEZE
                        return Current.ASTHMA_WHEEZE;
                    case 26: // ASTHMA_COUGH
                        return Current.ASTHMA_COUGH;
                    case 27: // ASTHMA_DIFFBRE
                        return Current.ASTHMA_DIFFBRE;
                    case 28: // ASTHMA_TGTCHES
                        return Current.ASTHMA_TGTCHES;
                    case 29: // ASTHMA_SYMTEXE
                        return Current.ASTHMA_SYMTEXE;
                    case 30: // ASTHMA_MGT_PLAN
                        return Current.ASTHMA_MGT_PLAN;
                    case 31: // CAMPUS
                        return Current.CAMPUS;
                    case 32: // FACULTY
                        return Current.FACULTY;
                    case 33: // ROOM_TYPE
                        return Current.ROOM_TYPE;
                    case 34: // NORMAL_ALLOTMENT
                        return Current.NORMAL_ALLOTMENT;
                    case 35: // GROUP_INDICATOR
                        return Current.GROUP_INDICATOR;
                    case 36: // DISABILITY_ADJUSTMENT
                        return Current.DISABILITY_ADJUSTMENT;
                    case 37: // LW_DATE
                        return Current.LW_DATE;
                    case 38: // LW_TIME
                        return Current.LW_TIME;
                    case 39: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // STUDENT
                        return Current.STUDENT == null;
                    case 2: // MED_CONDITION
                        return Current.MED_CONDITION == null;
                    case 3: // SYMPTOMS
                        return Current.SYMPTOMS == null;
                    case 4: // SMC_COMMENT
                        return Current.SMC_COMMENT == null;
                    case 5: // REGULAR_MEDICATION
                        return Current.REGULAR_MEDICATION == null;
                    case 6: // REGULAR_POISON_RATING
                        return Current.REGULAR_POISON_RATING == null;
                    case 7: // REGULAR_DOSAGE
                        return Current.REGULAR_DOSAGE == null;
                    case 8: // REGULAR_FREQUENCY
                        return Current.REGULAR_FREQUENCY == null;
                    case 9: // REGULAR_DOSAGE_TIME
                        return Current.REGULAR_DOSAGE_TIME == null;
                    case 10: // REGULAR_MEDICATION_LOCAT
                        return Current.REGULAR_MEDICATION_LOCAT == null;
                    case 11: // REGULAR_ADMIN_BY
                        return Current.REGULAR_ADMIN_BY == null;
                    case 12: // REMINDER
                        return Current.REMINDER == null;
                    case 13: // INFORM_DOCTOR
                        return Current.INFORM_DOCTOR == null;
                    case 14: // INFORM_EMERG_CONTACT
                        return Current.INFORM_EMERG_CONTACT == null;
                    case 15: // ADMINISTER_MEDICATION
                        return Current.ADMINISTER_MEDICATION == null;
                    case 16: // OTHER_MEDICAL_ACTION
                        return Current.OTHER_MEDICAL_ACTION == null;
                    case 17: // SMC_ACTION
                        return Current.SMC_ACTION == null;
                    case 18: // AD_HOC_MEDICATION
                        return Current.AD_HOC_MEDICATION == null;
                    case 19: // AD_HOC_POISON_RATING
                        return Current.AD_HOC_POISON_RATING == null;
                    case 20: // AD_HOC_DOSAGE
                        return Current.AD_HOC_DOSAGE == null;
                    case 21: // AD_HOC_FREQUENCY
                        return Current.AD_HOC_FREQUENCY == null;
                    case 22: // AD_HOC_MEDICATION_LOCAT
                        return Current.AD_HOC_MEDICATION_LOCAT == null;
                    case 23: // AD_HOC_ADMIN_BY
                        return Current.AD_HOC_ADMIN_BY == null;
                    case 24: // HOME_MEDICATION
                        return Current.HOME_MEDICATION == null;
                    case 25: // ASTHMA_WHEEZE
                        return Current.ASTHMA_WHEEZE == null;
                    case 26: // ASTHMA_COUGH
                        return Current.ASTHMA_COUGH == null;
                    case 27: // ASTHMA_DIFFBRE
                        return Current.ASTHMA_DIFFBRE == null;
                    case 28: // ASTHMA_TGTCHES
                        return Current.ASTHMA_TGTCHES == null;
                    case 29: // ASTHMA_SYMTEXE
                        return Current.ASTHMA_SYMTEXE == null;
                    case 30: // ASTHMA_MGT_PLAN
                        return Current.ASTHMA_MGT_PLAN == null;
                    case 31: // CAMPUS
                        return Current.CAMPUS == null;
                    case 32: // FACULTY
                        return Current.FACULTY == null;
                    case 33: // ROOM_TYPE
                        return Current.ROOM_TYPE == null;
                    case 34: // NORMAL_ALLOTMENT
                        return Current.NORMAL_ALLOTMENT == null;
                    case 35: // GROUP_INDICATOR
                        return Current.GROUP_INDICATOR == null;
                    case 36: // DISABILITY_ADJUSTMENT
                        return Current.DISABILITY_ADJUSTMENT == null;
                    case 37: // LW_DATE
                        return Current.LW_DATE == null;
                    case 38: // LW_TIME
                        return Current.LW_TIME == null;
                    case 39: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SMCKEY
                        return "SMCKEY";
                    case 1: // STUDENT
                        return "STUDENT";
                    case 2: // MED_CONDITION
                        return "MED_CONDITION";
                    case 3: // SYMPTOMS
                        return "SYMPTOMS";
                    case 4: // SMC_COMMENT
                        return "SMC_COMMENT";
                    case 5: // REGULAR_MEDICATION
                        return "REGULAR_MEDICATION";
                    case 6: // REGULAR_POISON_RATING
                        return "REGULAR_POISON_RATING";
                    case 7: // REGULAR_DOSAGE
                        return "REGULAR_DOSAGE";
                    case 8: // REGULAR_FREQUENCY
                        return "REGULAR_FREQUENCY";
                    case 9: // REGULAR_DOSAGE_TIME
                        return "REGULAR_DOSAGE_TIME";
                    case 10: // REGULAR_MEDICATION_LOCAT
                        return "REGULAR_MEDICATION_LOCAT";
                    case 11: // REGULAR_ADMIN_BY
                        return "REGULAR_ADMIN_BY";
                    case 12: // REMINDER
                        return "REMINDER";
                    case 13: // INFORM_DOCTOR
                        return "INFORM_DOCTOR";
                    case 14: // INFORM_EMERG_CONTACT
                        return "INFORM_EMERG_CONTACT";
                    case 15: // ADMINISTER_MEDICATION
                        return "ADMINISTER_MEDICATION";
                    case 16: // OTHER_MEDICAL_ACTION
                        return "OTHER_MEDICAL_ACTION";
                    case 17: // SMC_ACTION
                        return "SMC_ACTION";
                    case 18: // AD_HOC_MEDICATION
                        return "AD_HOC_MEDICATION";
                    case 19: // AD_HOC_POISON_RATING
                        return "AD_HOC_POISON_RATING";
                    case 20: // AD_HOC_DOSAGE
                        return "AD_HOC_DOSAGE";
                    case 21: // AD_HOC_FREQUENCY
                        return "AD_HOC_FREQUENCY";
                    case 22: // AD_HOC_MEDICATION_LOCAT
                        return "AD_HOC_MEDICATION_LOCAT";
                    case 23: // AD_HOC_ADMIN_BY
                        return "AD_HOC_ADMIN_BY";
                    case 24: // HOME_MEDICATION
                        return "HOME_MEDICATION";
                    case 25: // ASTHMA_WHEEZE
                        return "ASTHMA_WHEEZE";
                    case 26: // ASTHMA_COUGH
                        return "ASTHMA_COUGH";
                    case 27: // ASTHMA_DIFFBRE
                        return "ASTHMA_DIFFBRE";
                    case 28: // ASTHMA_TGTCHES
                        return "ASTHMA_TGTCHES";
                    case 29: // ASTHMA_SYMTEXE
                        return "ASTHMA_SYMTEXE";
                    case 30: // ASTHMA_MGT_PLAN
                        return "ASTHMA_MGT_PLAN";
                    case 31: // CAMPUS
                        return "CAMPUS";
                    case 32: // FACULTY
                        return "FACULTY";
                    case 33: // ROOM_TYPE
                        return "ROOM_TYPE";
                    case 34: // NORMAL_ALLOTMENT
                        return "NORMAL_ALLOTMENT";
                    case 35: // GROUP_INDICATOR
                        return "GROUP_INDICATOR";
                    case 36: // DISABILITY_ADJUSTMENT
                        return "DISABILITY_ADJUSTMENT";
                    case 37: // LW_DATE
                        return "LW_DATE";
                    case 38: // LW_TIME
                        return "LW_TIME";
                    case 39: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SMCKEY":
                        return 0;
                    case "STUDENT":
                        return 1;
                    case "MED_CONDITION":
                        return 2;
                    case "SYMPTOMS":
                        return 3;
                    case "SMC_COMMENT":
                        return 4;
                    case "REGULAR_MEDICATION":
                        return 5;
                    case "REGULAR_POISON_RATING":
                        return 6;
                    case "REGULAR_DOSAGE":
                        return 7;
                    case "REGULAR_FREQUENCY":
                        return 8;
                    case "REGULAR_DOSAGE_TIME":
                        return 9;
                    case "REGULAR_MEDICATION_LOCAT":
                        return 10;
                    case "REGULAR_ADMIN_BY":
                        return 11;
                    case "REMINDER":
                        return 12;
                    case "INFORM_DOCTOR":
                        return 13;
                    case "INFORM_EMERG_CONTACT":
                        return 14;
                    case "ADMINISTER_MEDICATION":
                        return 15;
                    case "OTHER_MEDICAL_ACTION":
                        return 16;
                    case "SMC_ACTION":
                        return 17;
                    case "AD_HOC_MEDICATION":
                        return 18;
                    case "AD_HOC_POISON_RATING":
                        return 19;
                    case "AD_HOC_DOSAGE":
                        return 20;
                    case "AD_HOC_FREQUENCY":
                        return 21;
                    case "AD_HOC_MEDICATION_LOCAT":
                        return 22;
                    case "AD_HOC_ADMIN_BY":
                        return 23;
                    case "HOME_MEDICATION":
                        return 24;
                    case "ASTHMA_WHEEZE":
                        return 25;
                    case "ASTHMA_COUGH":
                        return 26;
                    case "ASTHMA_DIFFBRE":
                        return 27;
                    case "ASTHMA_TGTCHES":
                        return 28;
                    case "ASTHMA_SYMTEXE":
                        return 29;
                    case "ASTHMA_MGT_PLAN":
                        return 30;
                    case "CAMPUS":
                        return 31;
                    case "FACULTY":
                        return 32;
                    case "ROOM_TYPE":
                        return 33;
                    case "NORMAL_ALLOTMENT":
                        return 34;
                    case "GROUP_INDICATOR":
                        return 35;
                    case "DISABILITY_ADJUSTMENT":
                        return 36;
                    case "LW_DATE":
                        return 37;
                    case "LW_TIME":
                        return 38;
                    case "LW_USER":
                        return 39;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
