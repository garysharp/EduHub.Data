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
    /// SMC Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMC_TFRDataSet : EduHubDataSet<SMC_TFR>
    {
        /// <inheritdoc />
        public override string Name { get { return "SMC_TFR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SMC_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<SMC_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, SMC_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMC_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMC_TFR" /> fields for each CSV column header</returns>
        internal override Action<SMC_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMC_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "SMC_TRANS_ID":
                        mapper[i] = (e, v) => e.SMC_TRANS_ID = v;
                        break;
                    case "SMCKEY":
                        mapper[i] = (e, v) => e.SMCKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "CONDITION_EXISTS":
                        mapper[i] = (e, v) => e.CONDITION_EXISTS = v;
                        break;
                    case "STUDENT_NEW":
                        mapper[i] = (e, v) => e.STUDENT_NEW = v;
                        break;
                    case "MED_CONDITION":
                        mapper[i] = (e, v) => e.MED_CONDITION = v;
                        break;
                    case "MED_CONDITION_NEW":
                        mapper[i] = (e, v) => e.MED_CONDITION_NEW = v;
                        break;
                    case "MED_CONDITION_ACT":
                        mapper[i] = (e, v) => e.MED_CONDITION_ACT = v;
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
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "KCM_TRANS_ID":
                        mapper[i] = (e, v) => e.KCM_TRANS_ID = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SMC_TFR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SMC_TFR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SMC_TFR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SMC_TFR}"/> of entities</returns>
        internal override IEnumerable<SMC_TFR> ApplyDeltaEntities(IEnumerable<SMC_TFR> Entities, List<SMC_TFR> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ORIG_SCHOOL;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.ORIG_SCHOOL.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SMC_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, SMC_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMC_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find SMC_TFR</param>
        /// <returns>List of related SMC_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find SMC_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find SMC_TFR</param>
        /// <param name="Value">List of related SMC_TFR entities</param>
        /// <returns>True if the list of related SMC_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<SMC_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find SMC_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find SMC_TFR</param>
        /// <returns>List of related SMC_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMC_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<SMC_TFR> value;
            if (Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMC_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMC_TFR</param>
        /// <returns>Related SMC_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMC_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMC_TFR</param>
        /// <param name="Value">Related SMC_TFR entity</param>
        /// <returns>True if the related SMC_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMC_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMC_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMC_TFR</param>
        /// <returns>Related SMC_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMC_TFR TryFindByTID(int TID)
        {
            SMC_TFR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SMC_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMC_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMC_TFR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [SMC_TRANS_ID] varchar(30) NULL,
        [SMCKEY] int NULL,
        [STUDENT] varchar(10) NULL,
        [CONDITION_EXISTS] varchar(1) NULL,
        [STUDENT_NEW] varchar(10) NULL,
        [MED_CONDITION] varchar(10) NULL,
        [MED_CONDITION_NEW] varchar(10) NULL,
        [MED_CONDITION_ACT] varchar(1) NULL,
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
        [ST_TRANS_ID] varchar(30) NULL,
        [KCM_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMC_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SMC_TFR_Index_ORIG_SCHOOL] ON [dbo].[SMC_TFR]
    (
            [ORIG_SCHOOL] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SMC_TFR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMC_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SMC_TFR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SMC_TFR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SMC_TFR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SMC_TFR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SMC_TFR] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SMC_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMC_TFR data set</returns>
        public override EduHubDataSetDataReader<SMC_TFR> GetDataSetDataReader()
        {
            return new SMC_TFRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMC_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMC_TFR data set</returns>
        public override EduHubDataSetDataReader<SMC_TFR> GetDataSetDataReader(List<SMC_TFR> Entities)
        {
            return new SMC_TFRDataReader(new EduHubDataSetLoadedReader<SMC_TFR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMC_TFRDataReader : EduHubDataSetDataReader<SMC_TFR>
        {
            public SMC_TFRDataReader(IEduHubDataSetReader<SMC_TFR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 45; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ORIG_SCHOOL
                        return Current.ORIG_SCHOOL;
                    case 2: // SMC_TRANS_ID
                        return Current.SMC_TRANS_ID;
                    case 3: // SMCKEY
                        return Current.SMCKEY;
                    case 4: // STUDENT
                        return Current.STUDENT;
                    case 5: // CONDITION_EXISTS
                        return Current.CONDITION_EXISTS;
                    case 6: // STUDENT_NEW
                        return Current.STUDENT_NEW;
                    case 7: // MED_CONDITION
                        return Current.MED_CONDITION;
                    case 8: // MED_CONDITION_NEW
                        return Current.MED_CONDITION_NEW;
                    case 9: // MED_CONDITION_ACT
                        return Current.MED_CONDITION_ACT;
                    case 10: // SYMPTOMS
                        return Current.SYMPTOMS;
                    case 11: // SMC_COMMENT
                        return Current.SMC_COMMENT;
                    case 12: // REGULAR_MEDICATION
                        return Current.REGULAR_MEDICATION;
                    case 13: // REGULAR_POISON_RATING
                        return Current.REGULAR_POISON_RATING;
                    case 14: // REGULAR_DOSAGE
                        return Current.REGULAR_DOSAGE;
                    case 15: // REGULAR_FREQUENCY
                        return Current.REGULAR_FREQUENCY;
                    case 16: // REGULAR_DOSAGE_TIME
                        return Current.REGULAR_DOSAGE_TIME;
                    case 17: // REGULAR_MEDICATION_LOCAT
                        return Current.REGULAR_MEDICATION_LOCAT;
                    case 18: // REGULAR_ADMIN_BY
                        return Current.REGULAR_ADMIN_BY;
                    case 19: // REMINDER
                        return Current.REMINDER;
                    case 20: // INFORM_DOCTOR
                        return Current.INFORM_DOCTOR;
                    case 21: // INFORM_EMERG_CONTACT
                        return Current.INFORM_EMERG_CONTACT;
                    case 22: // ADMINISTER_MEDICATION
                        return Current.ADMINISTER_MEDICATION;
                    case 23: // OTHER_MEDICAL_ACTION
                        return Current.OTHER_MEDICAL_ACTION;
                    case 24: // SMC_ACTION
                        return Current.SMC_ACTION;
                    case 25: // AD_HOC_MEDICATION
                        return Current.AD_HOC_MEDICATION;
                    case 26: // AD_HOC_POISON_RATING
                        return Current.AD_HOC_POISON_RATING;
                    case 27: // AD_HOC_DOSAGE
                        return Current.AD_HOC_DOSAGE;
                    case 28: // AD_HOC_FREQUENCY
                        return Current.AD_HOC_FREQUENCY;
                    case 29: // AD_HOC_MEDICATION_LOCAT
                        return Current.AD_HOC_MEDICATION_LOCAT;
                    case 30: // AD_HOC_ADMIN_BY
                        return Current.AD_HOC_ADMIN_BY;
                    case 31: // HOME_MEDICATION
                        return Current.HOME_MEDICATION;
                    case 32: // ASTHMA_WHEEZE
                        return Current.ASTHMA_WHEEZE;
                    case 33: // ASTHMA_COUGH
                        return Current.ASTHMA_COUGH;
                    case 34: // ASTHMA_DIFFBRE
                        return Current.ASTHMA_DIFFBRE;
                    case 35: // ASTHMA_TGTCHES
                        return Current.ASTHMA_TGTCHES;
                    case 36: // ASTHMA_SYMTEXE
                        return Current.ASTHMA_SYMTEXE;
                    case 37: // ASTHMA_MGT_PLAN
                        return Current.ASTHMA_MGT_PLAN;
                    case 38: // ST_TRANS_ID
                        return Current.ST_TRANS_ID;
                    case 39: // KCM_TRANS_ID
                        return Current.KCM_TRANS_ID;
                    case 40: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 41: // IMP_DATE
                        return Current.IMP_DATE;
                    case 42: // LW_DATE
                        return Current.LW_DATE;
                    case 43: // LW_TIME
                        return Current.LW_TIME;
                    case 44: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SMC_TRANS_ID
                        return Current.SMC_TRANS_ID == null;
                    case 3: // SMCKEY
                        return Current.SMCKEY == null;
                    case 4: // STUDENT
                        return Current.STUDENT == null;
                    case 5: // CONDITION_EXISTS
                        return Current.CONDITION_EXISTS == null;
                    case 6: // STUDENT_NEW
                        return Current.STUDENT_NEW == null;
                    case 7: // MED_CONDITION
                        return Current.MED_CONDITION == null;
                    case 8: // MED_CONDITION_NEW
                        return Current.MED_CONDITION_NEW == null;
                    case 9: // MED_CONDITION_ACT
                        return Current.MED_CONDITION_ACT == null;
                    case 10: // SYMPTOMS
                        return Current.SYMPTOMS == null;
                    case 11: // SMC_COMMENT
                        return Current.SMC_COMMENT == null;
                    case 12: // REGULAR_MEDICATION
                        return Current.REGULAR_MEDICATION == null;
                    case 13: // REGULAR_POISON_RATING
                        return Current.REGULAR_POISON_RATING == null;
                    case 14: // REGULAR_DOSAGE
                        return Current.REGULAR_DOSAGE == null;
                    case 15: // REGULAR_FREQUENCY
                        return Current.REGULAR_FREQUENCY == null;
                    case 16: // REGULAR_DOSAGE_TIME
                        return Current.REGULAR_DOSAGE_TIME == null;
                    case 17: // REGULAR_MEDICATION_LOCAT
                        return Current.REGULAR_MEDICATION_LOCAT == null;
                    case 18: // REGULAR_ADMIN_BY
                        return Current.REGULAR_ADMIN_BY == null;
                    case 19: // REMINDER
                        return Current.REMINDER == null;
                    case 20: // INFORM_DOCTOR
                        return Current.INFORM_DOCTOR == null;
                    case 21: // INFORM_EMERG_CONTACT
                        return Current.INFORM_EMERG_CONTACT == null;
                    case 22: // ADMINISTER_MEDICATION
                        return Current.ADMINISTER_MEDICATION == null;
                    case 23: // OTHER_MEDICAL_ACTION
                        return Current.OTHER_MEDICAL_ACTION == null;
                    case 24: // SMC_ACTION
                        return Current.SMC_ACTION == null;
                    case 25: // AD_HOC_MEDICATION
                        return Current.AD_HOC_MEDICATION == null;
                    case 26: // AD_HOC_POISON_RATING
                        return Current.AD_HOC_POISON_RATING == null;
                    case 27: // AD_HOC_DOSAGE
                        return Current.AD_HOC_DOSAGE == null;
                    case 28: // AD_HOC_FREQUENCY
                        return Current.AD_HOC_FREQUENCY == null;
                    case 29: // AD_HOC_MEDICATION_LOCAT
                        return Current.AD_HOC_MEDICATION_LOCAT == null;
                    case 30: // AD_HOC_ADMIN_BY
                        return Current.AD_HOC_ADMIN_BY == null;
                    case 31: // HOME_MEDICATION
                        return Current.HOME_MEDICATION == null;
                    case 32: // ASTHMA_WHEEZE
                        return Current.ASTHMA_WHEEZE == null;
                    case 33: // ASTHMA_COUGH
                        return Current.ASTHMA_COUGH == null;
                    case 34: // ASTHMA_DIFFBRE
                        return Current.ASTHMA_DIFFBRE == null;
                    case 35: // ASTHMA_TGTCHES
                        return Current.ASTHMA_TGTCHES == null;
                    case 36: // ASTHMA_SYMTEXE
                        return Current.ASTHMA_SYMTEXE == null;
                    case 37: // ASTHMA_MGT_PLAN
                        return Current.ASTHMA_MGT_PLAN == null;
                    case 38: // ST_TRANS_ID
                        return Current.ST_TRANS_ID == null;
                    case 39: // KCM_TRANS_ID
                        return Current.KCM_TRANS_ID == null;
                    case 40: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 41: // IMP_DATE
                        return Current.IMP_DATE == null;
                    case 42: // LW_DATE
                        return Current.LW_DATE == null;
                    case 43: // LW_TIME
                        return Current.LW_TIME == null;
                    case 44: // LW_USER
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
                    case 1: // ORIG_SCHOOL
                        return "ORIG_SCHOOL";
                    case 2: // SMC_TRANS_ID
                        return "SMC_TRANS_ID";
                    case 3: // SMCKEY
                        return "SMCKEY";
                    case 4: // STUDENT
                        return "STUDENT";
                    case 5: // CONDITION_EXISTS
                        return "CONDITION_EXISTS";
                    case 6: // STUDENT_NEW
                        return "STUDENT_NEW";
                    case 7: // MED_CONDITION
                        return "MED_CONDITION";
                    case 8: // MED_CONDITION_NEW
                        return "MED_CONDITION_NEW";
                    case 9: // MED_CONDITION_ACT
                        return "MED_CONDITION_ACT";
                    case 10: // SYMPTOMS
                        return "SYMPTOMS";
                    case 11: // SMC_COMMENT
                        return "SMC_COMMENT";
                    case 12: // REGULAR_MEDICATION
                        return "REGULAR_MEDICATION";
                    case 13: // REGULAR_POISON_RATING
                        return "REGULAR_POISON_RATING";
                    case 14: // REGULAR_DOSAGE
                        return "REGULAR_DOSAGE";
                    case 15: // REGULAR_FREQUENCY
                        return "REGULAR_FREQUENCY";
                    case 16: // REGULAR_DOSAGE_TIME
                        return "REGULAR_DOSAGE_TIME";
                    case 17: // REGULAR_MEDICATION_LOCAT
                        return "REGULAR_MEDICATION_LOCAT";
                    case 18: // REGULAR_ADMIN_BY
                        return "REGULAR_ADMIN_BY";
                    case 19: // REMINDER
                        return "REMINDER";
                    case 20: // INFORM_DOCTOR
                        return "INFORM_DOCTOR";
                    case 21: // INFORM_EMERG_CONTACT
                        return "INFORM_EMERG_CONTACT";
                    case 22: // ADMINISTER_MEDICATION
                        return "ADMINISTER_MEDICATION";
                    case 23: // OTHER_MEDICAL_ACTION
                        return "OTHER_MEDICAL_ACTION";
                    case 24: // SMC_ACTION
                        return "SMC_ACTION";
                    case 25: // AD_HOC_MEDICATION
                        return "AD_HOC_MEDICATION";
                    case 26: // AD_HOC_POISON_RATING
                        return "AD_HOC_POISON_RATING";
                    case 27: // AD_HOC_DOSAGE
                        return "AD_HOC_DOSAGE";
                    case 28: // AD_HOC_FREQUENCY
                        return "AD_HOC_FREQUENCY";
                    case 29: // AD_HOC_MEDICATION_LOCAT
                        return "AD_HOC_MEDICATION_LOCAT";
                    case 30: // AD_HOC_ADMIN_BY
                        return "AD_HOC_ADMIN_BY";
                    case 31: // HOME_MEDICATION
                        return "HOME_MEDICATION";
                    case 32: // ASTHMA_WHEEZE
                        return "ASTHMA_WHEEZE";
                    case 33: // ASTHMA_COUGH
                        return "ASTHMA_COUGH";
                    case 34: // ASTHMA_DIFFBRE
                        return "ASTHMA_DIFFBRE";
                    case 35: // ASTHMA_TGTCHES
                        return "ASTHMA_TGTCHES";
                    case 36: // ASTHMA_SYMTEXE
                        return "ASTHMA_SYMTEXE";
                    case 37: // ASTHMA_MGT_PLAN
                        return "ASTHMA_MGT_PLAN";
                    case 38: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 39: // KCM_TRANS_ID
                        return "KCM_TRANS_ID";
                    case 40: // IMP_STATUS
                        return "IMP_STATUS";
                    case 41: // IMP_DATE
                        return "IMP_DATE";
                    case 42: // LW_DATE
                        return "LW_DATE";
                    case 43: // LW_TIME
                        return "LW_TIME";
                    case 44: // LW_USER
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
                    case "ORIG_SCHOOL":
                        return 1;
                    case "SMC_TRANS_ID":
                        return 2;
                    case "SMCKEY":
                        return 3;
                    case "STUDENT":
                        return 4;
                    case "CONDITION_EXISTS":
                        return 5;
                    case "STUDENT_NEW":
                        return 6;
                    case "MED_CONDITION":
                        return 7;
                    case "MED_CONDITION_NEW":
                        return 8;
                    case "MED_CONDITION_ACT":
                        return 9;
                    case "SYMPTOMS":
                        return 10;
                    case "SMC_COMMENT":
                        return 11;
                    case "REGULAR_MEDICATION":
                        return 12;
                    case "REGULAR_POISON_RATING":
                        return 13;
                    case "REGULAR_DOSAGE":
                        return 14;
                    case "REGULAR_FREQUENCY":
                        return 15;
                    case "REGULAR_DOSAGE_TIME":
                        return 16;
                    case "REGULAR_MEDICATION_LOCAT":
                        return 17;
                    case "REGULAR_ADMIN_BY":
                        return 18;
                    case "REMINDER":
                        return 19;
                    case "INFORM_DOCTOR":
                        return 20;
                    case "INFORM_EMERG_CONTACT":
                        return 21;
                    case "ADMINISTER_MEDICATION":
                        return 22;
                    case "OTHER_MEDICAL_ACTION":
                        return 23;
                    case "SMC_ACTION":
                        return 24;
                    case "AD_HOC_MEDICATION":
                        return 25;
                    case "AD_HOC_POISON_RATING":
                        return 26;
                    case "AD_HOC_DOSAGE":
                        return 27;
                    case "AD_HOC_FREQUENCY":
                        return 28;
                    case "AD_HOC_MEDICATION_LOCAT":
                        return 29;
                    case "AD_HOC_ADMIN_BY":
                        return 30;
                    case "HOME_MEDICATION":
                        return 31;
                    case "ASTHMA_WHEEZE":
                        return 32;
                    case "ASTHMA_COUGH":
                        return 33;
                    case "ASTHMA_DIFFBRE":
                        return 34;
                    case "ASTHMA_TGTCHES":
                        return 35;
                    case "ASTHMA_SYMTEXE":
                        return 36;
                    case "ASTHMA_MGT_PLAN":
                        return 37;
                    case "ST_TRANS_ID":
                        return 38;
                    case "KCM_TRANS_ID":
                        return 39;
                    case "IMP_STATUS":
                        return 40;
                    case "IMP_DATE":
                        return 41;
                    case "LW_DATE":
                        return 42;
                    case "LW_TIME":
                        return 43;
                    case "LW_USER":
                        return 44;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
