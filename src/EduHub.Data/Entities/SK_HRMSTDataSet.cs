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
    /// HRMS Temp Import Table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SK_HRMSTDataSet : EduHubDataSet<SK_HRMST>
    {
        /// <inheritdoc />
        public override string Name { get { return "SK_HRMST"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SK_HRMSTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SEQ = new Lazy<Dictionary<int, SK_HRMST>>(() => this.ToDictionary(i => i.SEQ));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SK_HRMST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SK_HRMST" /> fields for each CSV column header</returns>
        internal override Action<SK_HRMST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SK_HRMST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SEQ":
                        mapper[i] = (e, v) => e.SEQ = int.Parse(v);
                        break;
                    case "DEPTID":
                        mapper[i] = (e, v) => e.DEPTID = v;
                        break;
                    case "EMPLID":
                        mapper[i] = (e, v) => e.EMPLID = v;
                        break;
                    case "JOBCODE":
                        mapper[i] = (e, v) => e.JOBCODE = v;
                        break;
                    case "LAST_NAME":
                        mapper[i] = (e, v) => e.LAST_NAME = v;
                        break;
                    case "PREFIX":
                        mapper[i] = (e, v) => e.PREFIX = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "MIDDLE_NAME":
                        mapper[i] = (e, v) => e.MIDDLE_NAME = v;
                        break;
                    case "PREF_NAME":
                        mapper[i] = (e, v) => e.PREF_NAME = v;
                        break;
                    case "PREV_SURNAME":
                        mapper[i] = (e, v) => e.PREV_SURNAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTH_DATE":
                        mapper[i] = (e, v) => e.BIRTH_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "H_ADDRESS01":
                        mapper[i] = (e, v) => e.H_ADDRESS01 = v;
                        break;
                    case "H_ADDRESS02":
                        mapper[i] = (e, v) => e.H_ADDRESS02 = v;
                        break;
                    case "H_ADDRESS03":
                        mapper[i] = (e, v) => e.H_ADDRESS03 = v;
                        break;
                    case "H_STATE":
                        mapper[i] = (e, v) => e.H_STATE = v;
                        break;
                    case "H_POST_CODE":
                        mapper[i] = (e, v) => e.H_POST_CODE = v;
                        break;
                    case "P_ADDRESS01":
                        mapper[i] = (e, v) => e.P_ADDRESS01 = v;
                        break;
                    case "P_ADDRESS02":
                        mapper[i] = (e, v) => e.P_ADDRESS02 = v;
                        break;
                    case "P_ADDRESS03":
                        mapper[i] = (e, v) => e.P_ADDRESS03 = v;
                        break;
                    case "P_STATE":
                        mapper[i] = (e, v) => e.P_STATE = v;
                        break;
                    case "P_POST_CODE":
                        mapper[i] = (e, v) => e.P_POST_CODE = v;
                        break;
                    case "HOME_PHONE":
                        mapper[i] = (e, v) => e.HOME_PHONE = v;
                        break;
                    case "MOBILE_PHONE":
                        mapper[i] = (e, v) => e.MOBILE_PHONE = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
                        break;
                    case "EMERG_CONTACT":
                        mapper[i] = (e, v) => e.EMERG_CONTACT = v;
                        break;
                    case "EMERG_RELATE":
                        mapper[i] = (e, v) => e.EMERG_RELATE = v;
                        break;
                    case "EMERG_PHONE":
                        mapper[i] = (e, v) => e.EMERG_PHONE = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FINISH_DATE":
                        mapper[i] = (e, v) => e.FINISH_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SK_HRMST" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SK_HRMST" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SK_HRMST" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SK_HRMST}"/> of entities</returns>
        internal override IEnumerable<SK_HRMST> ApplyDeltaEntities(IEnumerable<SK_HRMST> Entities, List<SK_HRMST> DeltaEntities)
        {
            HashSet<int> Index_SEQ = new HashSet<int>(DeltaEntities.Select(i => i.SEQ));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SEQ;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SEQ.Remove(entity.SEQ);
                            
                            if (entity.SEQ.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SK_HRMST>> Index_SEQ;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SK_HRMST by SEQ field
        /// </summary>
        /// <param name="SEQ">SEQ value used to find SK_HRMST</param>
        /// <returns>Related SK_HRMST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SK_HRMST FindBySEQ(int SEQ)
        {
            return Index_SEQ.Value[SEQ];
        }

        /// <summary>
        /// Attempt to find SK_HRMST by SEQ field
        /// </summary>
        /// <param name="SEQ">SEQ value used to find SK_HRMST</param>
        /// <param name="Value">Related SK_HRMST entity</param>
        /// <returns>True if the related SK_HRMST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySEQ(int SEQ, out SK_HRMST Value)
        {
            return Index_SEQ.Value.TryGetValue(SEQ, out Value);
        }

        /// <summary>
        /// Attempt to find SK_HRMST by SEQ field
        /// </summary>
        /// <param name="SEQ">SEQ value used to find SK_HRMST</param>
        /// <returns>Related SK_HRMST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SK_HRMST TryFindBySEQ(int SEQ)
        {
            SK_HRMST value;
            if (Index_SEQ.Value.TryGetValue(SEQ, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SK_HRMST table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SK_HRMST]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SK_HRMST](
        [SEQ] int IDENTITY NOT NULL,
        [DEPTID] varchar(10) NULL,
        [EMPLID] varchar(11) NULL,
        [JOBCODE] varchar(6) NULL,
        [LAST_NAME] varchar(30) NULL,
        [PREFIX] varchar(4) NULL,
        [FIRST_NAME] varchar(30) NULL,
        [MIDDLE_NAME] varchar(30) NULL,
        [PREF_NAME] varchar(30) NULL,
        [PREV_SURNAME] varchar(30) NULL,
        [GENDER] varchar(1) NULL,
        [BIRTH_DATE] datetime NULL,
        [H_ADDRESS01] varchar(55) NULL,
        [H_ADDRESS02] varchar(55) NULL,
        [H_ADDRESS03] varchar(55) NULL,
        [H_STATE] varchar(6) NULL,
        [H_POST_CODE] varchar(12) NULL,
        [P_ADDRESS01] varchar(55) NULL,
        [P_ADDRESS02] varchar(55) NULL,
        [P_ADDRESS03] varchar(55) NULL,
        [P_STATE] varchar(6) NULL,
        [P_POST_CODE] varchar(12) NULL,
        [HOME_PHONE] varchar(24) NULL,
        [MOBILE_PHONE] varchar(31) NULL,
        [WORK_PHONE] varchar(24) NULL,
        [EMAIL_ADDRESS] varchar(70) NULL,
        [EMERG_CONTACT] varchar(50) NULL,
        [EMERG_RELATE] varchar(30) NULL,
        [EMERG_PHONE] varchar(24) NULL,
        [START_DATE] datetime NULL,
        [FINISH_DATE] datetime NULL,
        CONSTRAINT [SK_HRMST_Index_SEQ] PRIMARY KEY CLUSTERED (
            [SEQ] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SK_HRMSTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SK_HRMSTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SK_HRMST"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SK_HRMST"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SK_HRMST> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SEQ = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SEQ.Add(entity.SEQ);
            }

            builder.AppendLine("DELETE [dbo].[SK_HRMST] WHERE");


            // Index_SEQ
            builder.Append("[SEQ] IN (");
            for (int index = 0; index < Index_SEQ.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SEQ
                var parameterSEQ = $"@p{parameterIndex++}";
                builder.Append(parameterSEQ);
                command.Parameters.Add(parameterSEQ, SqlDbType.Int).Value = Index_SEQ[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SK_HRMST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SK_HRMST data set</returns>
        public override EduHubDataSetDataReader<SK_HRMST> GetDataSetDataReader()
        {
            return new SK_HRMSTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SK_HRMST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SK_HRMST data set</returns>
        public override EduHubDataSetDataReader<SK_HRMST> GetDataSetDataReader(List<SK_HRMST> Entities)
        {
            return new SK_HRMSTDataReader(new EduHubDataSetLoadedReader<SK_HRMST>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SK_HRMSTDataReader : EduHubDataSetDataReader<SK_HRMST>
        {
            public SK_HRMSTDataReader(IEduHubDataSetReader<SK_HRMST> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 31; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SEQ
                        return Current.SEQ;
                    case 1: // DEPTID
                        return Current.DEPTID;
                    case 2: // EMPLID
                        return Current.EMPLID;
                    case 3: // JOBCODE
                        return Current.JOBCODE;
                    case 4: // LAST_NAME
                        return Current.LAST_NAME;
                    case 5: // PREFIX
                        return Current.PREFIX;
                    case 6: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 7: // MIDDLE_NAME
                        return Current.MIDDLE_NAME;
                    case 8: // PREF_NAME
                        return Current.PREF_NAME;
                    case 9: // PREV_SURNAME
                        return Current.PREV_SURNAME;
                    case 10: // GENDER
                        return Current.GENDER;
                    case 11: // BIRTH_DATE
                        return Current.BIRTH_DATE;
                    case 12: // H_ADDRESS01
                        return Current.H_ADDRESS01;
                    case 13: // H_ADDRESS02
                        return Current.H_ADDRESS02;
                    case 14: // H_ADDRESS03
                        return Current.H_ADDRESS03;
                    case 15: // H_STATE
                        return Current.H_STATE;
                    case 16: // H_POST_CODE
                        return Current.H_POST_CODE;
                    case 17: // P_ADDRESS01
                        return Current.P_ADDRESS01;
                    case 18: // P_ADDRESS02
                        return Current.P_ADDRESS02;
                    case 19: // P_ADDRESS03
                        return Current.P_ADDRESS03;
                    case 20: // P_STATE
                        return Current.P_STATE;
                    case 21: // P_POST_CODE
                        return Current.P_POST_CODE;
                    case 22: // HOME_PHONE
                        return Current.HOME_PHONE;
                    case 23: // MOBILE_PHONE
                        return Current.MOBILE_PHONE;
                    case 24: // WORK_PHONE
                        return Current.WORK_PHONE;
                    case 25: // EMAIL_ADDRESS
                        return Current.EMAIL_ADDRESS;
                    case 26: // EMERG_CONTACT
                        return Current.EMERG_CONTACT;
                    case 27: // EMERG_RELATE
                        return Current.EMERG_RELATE;
                    case 28: // EMERG_PHONE
                        return Current.EMERG_PHONE;
                    case 29: // START_DATE
                        return Current.START_DATE;
                    case 30: // FINISH_DATE
                        return Current.FINISH_DATE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DEPTID
                        return Current.DEPTID == null;
                    case 2: // EMPLID
                        return Current.EMPLID == null;
                    case 3: // JOBCODE
                        return Current.JOBCODE == null;
                    case 4: // LAST_NAME
                        return Current.LAST_NAME == null;
                    case 5: // PREFIX
                        return Current.PREFIX == null;
                    case 6: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 7: // MIDDLE_NAME
                        return Current.MIDDLE_NAME == null;
                    case 8: // PREF_NAME
                        return Current.PREF_NAME == null;
                    case 9: // PREV_SURNAME
                        return Current.PREV_SURNAME == null;
                    case 10: // GENDER
                        return Current.GENDER == null;
                    case 11: // BIRTH_DATE
                        return Current.BIRTH_DATE == null;
                    case 12: // H_ADDRESS01
                        return Current.H_ADDRESS01 == null;
                    case 13: // H_ADDRESS02
                        return Current.H_ADDRESS02 == null;
                    case 14: // H_ADDRESS03
                        return Current.H_ADDRESS03 == null;
                    case 15: // H_STATE
                        return Current.H_STATE == null;
                    case 16: // H_POST_CODE
                        return Current.H_POST_CODE == null;
                    case 17: // P_ADDRESS01
                        return Current.P_ADDRESS01 == null;
                    case 18: // P_ADDRESS02
                        return Current.P_ADDRESS02 == null;
                    case 19: // P_ADDRESS03
                        return Current.P_ADDRESS03 == null;
                    case 20: // P_STATE
                        return Current.P_STATE == null;
                    case 21: // P_POST_CODE
                        return Current.P_POST_CODE == null;
                    case 22: // HOME_PHONE
                        return Current.HOME_PHONE == null;
                    case 23: // MOBILE_PHONE
                        return Current.MOBILE_PHONE == null;
                    case 24: // WORK_PHONE
                        return Current.WORK_PHONE == null;
                    case 25: // EMAIL_ADDRESS
                        return Current.EMAIL_ADDRESS == null;
                    case 26: // EMERG_CONTACT
                        return Current.EMERG_CONTACT == null;
                    case 27: // EMERG_RELATE
                        return Current.EMERG_RELATE == null;
                    case 28: // EMERG_PHONE
                        return Current.EMERG_PHONE == null;
                    case 29: // START_DATE
                        return Current.START_DATE == null;
                    case 30: // FINISH_DATE
                        return Current.FINISH_DATE == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SEQ
                        return "SEQ";
                    case 1: // DEPTID
                        return "DEPTID";
                    case 2: // EMPLID
                        return "EMPLID";
                    case 3: // JOBCODE
                        return "JOBCODE";
                    case 4: // LAST_NAME
                        return "LAST_NAME";
                    case 5: // PREFIX
                        return "PREFIX";
                    case 6: // FIRST_NAME
                        return "FIRST_NAME";
                    case 7: // MIDDLE_NAME
                        return "MIDDLE_NAME";
                    case 8: // PREF_NAME
                        return "PREF_NAME";
                    case 9: // PREV_SURNAME
                        return "PREV_SURNAME";
                    case 10: // GENDER
                        return "GENDER";
                    case 11: // BIRTH_DATE
                        return "BIRTH_DATE";
                    case 12: // H_ADDRESS01
                        return "H_ADDRESS01";
                    case 13: // H_ADDRESS02
                        return "H_ADDRESS02";
                    case 14: // H_ADDRESS03
                        return "H_ADDRESS03";
                    case 15: // H_STATE
                        return "H_STATE";
                    case 16: // H_POST_CODE
                        return "H_POST_CODE";
                    case 17: // P_ADDRESS01
                        return "P_ADDRESS01";
                    case 18: // P_ADDRESS02
                        return "P_ADDRESS02";
                    case 19: // P_ADDRESS03
                        return "P_ADDRESS03";
                    case 20: // P_STATE
                        return "P_STATE";
                    case 21: // P_POST_CODE
                        return "P_POST_CODE";
                    case 22: // HOME_PHONE
                        return "HOME_PHONE";
                    case 23: // MOBILE_PHONE
                        return "MOBILE_PHONE";
                    case 24: // WORK_PHONE
                        return "WORK_PHONE";
                    case 25: // EMAIL_ADDRESS
                        return "EMAIL_ADDRESS";
                    case 26: // EMERG_CONTACT
                        return "EMERG_CONTACT";
                    case 27: // EMERG_RELATE
                        return "EMERG_RELATE";
                    case 28: // EMERG_PHONE
                        return "EMERG_PHONE";
                    case 29: // START_DATE
                        return "START_DATE";
                    case 30: // FINISH_DATE
                        return "FINISH_DATE";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SEQ":
                        return 0;
                    case "DEPTID":
                        return 1;
                    case "EMPLID":
                        return 2;
                    case "JOBCODE":
                        return 3;
                    case "LAST_NAME":
                        return 4;
                    case "PREFIX":
                        return 5;
                    case "FIRST_NAME":
                        return 6;
                    case "MIDDLE_NAME":
                        return 7;
                    case "PREF_NAME":
                        return 8;
                    case "PREV_SURNAME":
                        return 9;
                    case "GENDER":
                        return 10;
                    case "BIRTH_DATE":
                        return 11;
                    case "H_ADDRESS01":
                        return 12;
                    case "H_ADDRESS02":
                        return 13;
                    case "H_ADDRESS03":
                        return 14;
                    case "H_STATE":
                        return 15;
                    case "H_POST_CODE":
                        return 16;
                    case "P_ADDRESS01":
                        return 17;
                    case "P_ADDRESS02":
                        return 18;
                    case "P_ADDRESS03":
                        return 19;
                    case "P_STATE":
                        return 20;
                    case "P_POST_CODE":
                        return 21;
                    case "HOME_PHONE":
                        return 22;
                    case "MOBILE_PHONE":
                        return 23;
                    case "WORK_PHONE":
                        return 24;
                    case "EMAIL_ADDRESS":
                        return 25;
                    case "EMERG_CONTACT":
                        return 26;
                    case "EMERG_RELATE":
                        return 27;
                    case "EMERG_PHONE":
                        return 28;
                    case "START_DATE":
                        return 29;
                    case "FINISH_DATE":
                        return 30;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
