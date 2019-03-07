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
    /// STSUP Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSUP_TRDataSet : EduHubDataSet<STSUP_TR>
    {
        /// <inheritdoc />
        public override string Name { get { return "STSUP_TR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STSUP_TRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<STSUP_TR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_STSUP_TRANS_ID = new Lazy<NullDictionary<string, STSUP_TR>>(() => this.ToNullDictionary(i => i.STSUP_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, STSUP_TR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSUP_TR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSUP_TR" /> fields for each CSV column header</returns>
        internal override Action<STSUP_TR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSUP_TR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "STSUP_TRANS_ID":
                        mapper[i] = (e, v) => e.STSUP_TRANS_ID = v;
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "SKEY_NEW":
                        mapper[i] = (e, v) => e.SKEY_NEW = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "SUPPORT_ROLE":
                        mapper[i] = (e, v) => e.SUPPORT_ROLE = v;
                        break;
                    case "SUPPORT_ROLE_NEW":
                        mapper[i] = (e, v) => e.SUPPORT_ROLE_NEW = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "BUS_PHONE":
                        mapper[i] = (e, v) => e.BUS_PHONE = v;
                        break;
                    case "BUS_EMAIL":
                        mapper[i] = (e, v) => e.BUS_EMAIL = v;
                        break;
                    case "ADDED_BY":
                        mapper[i] = (e, v) => e.ADDED_BY = v;
                        break;
                    case "SUPPORT_SERVICES":
                        mapper[i] = (e, v) => e.SUPPORT_SERVICES = v;
                        break;
                    case "STUDENT_SUPPORT":
                        mapper[i] = (e, v) => e.STUDENT_SUPPORT = v;
                        break;
                    case "STUDENT_OTHER_SUPPORT":
                        mapper[i] = (e, v) => e.STUDENT_OTHER_SUPPORT = v;
                        break;
                    case "CHILD_PROTECTION":
                        mapper[i] = (e, v) => e.CHILD_PROTECTION = v;
                        break;
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "KGO_TRANS_ID":
                        mapper[i] = (e, v) => e.KGO_TRANS_ID = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="STSUP_TR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STSUP_TR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STSUP_TR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STSUP_TR}"/> of entities</returns>
        internal override IEnumerable<STSUP_TR> ApplyDeltaEntities(IEnumerable<STSUP_TR> Entities, List<STSUP_TR> DeltaEntities)
        {
            HashSet<string> Index_STSUP_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.STSUP_TRANS_ID));
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

                            bool overwritten = false;
                            overwritten = overwritten || Index_STSUP_TRANS_ID.Remove(entity.STSUP_TRANS_ID);
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
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

        private Lazy<Dictionary<string, IReadOnlyList<STSUP_TR>>> Index_ORIG_SCHOOL;
        private Lazy<NullDictionary<string, STSUP_TR>> Index_STSUP_TRANS_ID;
        private Lazy<Dictionary<int, STSUP_TR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STSUP_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STSUP_TR</param>
        /// <returns>List of related STSUP_TR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSUP_TR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STSUP_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STSUP_TR</param>
        /// <param name="Value">List of related STSUP_TR entities</param>
        /// <returns>True if the list of related STSUP_TR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<STSUP_TR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STSUP_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STSUP_TR</param>
        /// <returns>List of related STSUP_TR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSUP_TR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<STSUP_TR> value;
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
        /// Find STSUP_TR by STSUP_TRANS_ID field
        /// </summary>
        /// <param name="STSUP_TRANS_ID">STSUP_TRANS_ID value used to find STSUP_TR</param>
        /// <returns>Related STSUP_TR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSUP_TR FindBySTSUP_TRANS_ID(string STSUP_TRANS_ID)
        {
            return Index_STSUP_TRANS_ID.Value[STSUP_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find STSUP_TR by STSUP_TRANS_ID field
        /// </summary>
        /// <param name="STSUP_TRANS_ID">STSUP_TRANS_ID value used to find STSUP_TR</param>
        /// <param name="Value">Related STSUP_TR entity</param>
        /// <returns>True if the related STSUP_TR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTSUP_TRANS_ID(string STSUP_TRANS_ID, out STSUP_TR Value)
        {
            return Index_STSUP_TRANS_ID.Value.TryGetValue(STSUP_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STSUP_TR by STSUP_TRANS_ID field
        /// </summary>
        /// <param name="STSUP_TRANS_ID">STSUP_TRANS_ID value used to find STSUP_TR</param>
        /// <returns>Related STSUP_TR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSUP_TR TryFindBySTSUP_TRANS_ID(string STSUP_TRANS_ID)
        {
            STSUP_TR value;
            if (Index_STSUP_TRANS_ID.Value.TryGetValue(STSUP_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSUP_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSUP_TR</param>
        /// <returns>Related STSUP_TR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSUP_TR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STSUP_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSUP_TR</param>
        /// <param name="Value">Related STSUP_TR entity</param>
        /// <returns>True if the related STSUP_TR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STSUP_TR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STSUP_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSUP_TR</param>
        /// <returns>Related STSUP_TR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSUP_TR TryFindByTID(int TID)
        {
            STSUP_TR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STSUP_TR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STSUP_TR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STSUP_TR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [STSUP_TRANS_ID] varchar(30) NULL,
        [SKEY] varchar(10) NULL,
        [SKEY_NEW] varchar(10) NULL,
        [FIRST_NAME] varchar(30) NULL,
        [SURNAME] varchar(30) NULL,
        [SUPPORT_ROLE] varchar(10) NULL,
        [SUPPORT_ROLE_NEW] varchar(10) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [SUBURB] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [KAP_LINK] varchar(34) NULL,
        [BUS_PHONE] varchar(20) NULL,
        [BUS_EMAIL] varchar(60) NULL,
        [ADDED_BY] varchar(128) NULL,
        [SUPPORT_SERVICES] varchar(1) NULL,
        [STUDENT_SUPPORT] varchar(1) NULL,
        [STUDENT_OTHER_SUPPORT] varchar(1) NULL,
        [CHILD_PROTECTION] varchar(1) NULL,
        [ST_TRANS_ID] varchar(30) NULL,
        [KGO_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STSUP_TR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [STSUP_TR_Index_ORIG_SCHOOL] ON [dbo].[STSUP_TR]
    (
            [ORIG_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [STSUP_TR_Index_STSUP_TRANS_ID] ON [dbo].[STSUP_TR]
    (
            [STSUP_TRANS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSUP_TR]') AND name = N'Index_STSUP_TRANS_ID')
    ALTER INDEX [Index_STSUP_TRANS_ID] ON [dbo].[STSUP_TR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSUP_TR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STSUP_TR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSUP_TR]') AND name = N'Index_STSUP_TRANS_ID')
    ALTER INDEX [Index_STSUP_TRANS_ID] ON [dbo].[STSUP_TR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSUP_TR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STSUP_TR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STSUP_TR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STSUP_TR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STSUP_TR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_STSUP_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_STSUP_TRANS_ID.Add(entity.STSUP_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STSUP_TR] WHERE");


            // Index_STSUP_TRANS_ID
            builder.Append("[STSUP_TRANS_ID] IN (");
            for (int index = 0; index < Index_STSUP_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // STSUP_TRANS_ID
                var parameterSTSUP_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSTSUP_TRANS_ID);
                command.Parameters.Add(parameterSTSUP_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_STSUP_TRANS_ID[index] ?? DBNull.Value;
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
        /// Provides a <see cref="IDataReader"/> for the STSUP_TR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSUP_TR data set</returns>
        public override EduHubDataSetDataReader<STSUP_TR> GetDataSetDataReader()
        {
            return new STSUP_TRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STSUP_TR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSUP_TR data set</returns>
        public override EduHubDataSetDataReader<STSUP_TR> GetDataSetDataReader(List<STSUP_TR> Entities)
        {
            return new STSUP_TRDataReader(new EduHubDataSetLoadedReader<STSUP_TR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STSUP_TRDataReader : EduHubDataSetDataReader<STSUP_TR>
        {
            public STSUP_TRDataReader(IEduHubDataSetReader<STSUP_TR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 29; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ORIG_SCHOOL
                        return Current.ORIG_SCHOOL;
                    case 2: // STSUP_TRANS_ID
                        return Current.STSUP_TRANS_ID;
                    case 3: // SKEY
                        return Current.SKEY;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW;
                    case 5: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 6: // SURNAME
                        return Current.SURNAME;
                    case 7: // SUPPORT_ROLE
                        return Current.SUPPORT_ROLE;
                    case 8: // SUPPORT_ROLE_NEW
                        return Current.SUPPORT_ROLE_NEW;
                    case 9: // ADDRESS01
                        return Current.ADDRESS01;
                    case 10: // ADDRESS02
                        return Current.ADDRESS02;
                    case 11: // SUBURB
                        return Current.SUBURB;
                    case 12: // STATE
                        return Current.STATE;
                    case 13: // POSTCODE
                        return Current.POSTCODE;
                    case 14: // KAP_LINK
                        return Current.KAP_LINK;
                    case 15: // BUS_PHONE
                        return Current.BUS_PHONE;
                    case 16: // BUS_EMAIL
                        return Current.BUS_EMAIL;
                    case 17: // ADDED_BY
                        return Current.ADDED_BY;
                    case 18: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES;
                    case 19: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT;
                    case 20: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT;
                    case 21: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION;
                    case 22: // ST_TRANS_ID
                        return Current.ST_TRANS_ID;
                    case 23: // KGO_TRANS_ID
                        return Current.KGO_TRANS_ID;
                    case 24: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 25: // IMP_DATE
                        return Current.IMP_DATE;
                    case 26: // LW_DATE
                        return Current.LW_DATE;
                    case 27: // LW_TIME
                        return Current.LW_TIME;
                    case 28: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // STSUP_TRANS_ID
                        return Current.STSUP_TRANS_ID == null;
                    case 3: // SKEY
                        return Current.SKEY == null;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW == null;
                    case 5: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 6: // SURNAME
                        return Current.SURNAME == null;
                    case 7: // SUPPORT_ROLE
                        return Current.SUPPORT_ROLE == null;
                    case 8: // SUPPORT_ROLE_NEW
                        return Current.SUPPORT_ROLE_NEW == null;
                    case 9: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 10: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 11: // SUBURB
                        return Current.SUBURB == null;
                    case 12: // STATE
                        return Current.STATE == null;
                    case 13: // POSTCODE
                        return Current.POSTCODE == null;
                    case 14: // KAP_LINK
                        return Current.KAP_LINK == null;
                    case 15: // BUS_PHONE
                        return Current.BUS_PHONE == null;
                    case 16: // BUS_EMAIL
                        return Current.BUS_EMAIL == null;
                    case 17: // ADDED_BY
                        return Current.ADDED_BY == null;
                    case 18: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES == null;
                    case 19: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT == null;
                    case 20: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT == null;
                    case 21: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION == null;
                    case 22: // ST_TRANS_ID
                        return Current.ST_TRANS_ID == null;
                    case 23: // KGO_TRANS_ID
                        return Current.KGO_TRANS_ID == null;
                    case 24: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 25: // IMP_DATE
                        return Current.IMP_DATE == null;
                    case 26: // LW_DATE
                        return Current.LW_DATE == null;
                    case 27: // LW_TIME
                        return Current.LW_TIME == null;
                    case 28: // LW_USER
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
                    case 2: // STSUP_TRANS_ID
                        return "STSUP_TRANS_ID";
                    case 3: // SKEY
                        return "SKEY";
                    case 4: // SKEY_NEW
                        return "SKEY_NEW";
                    case 5: // FIRST_NAME
                        return "FIRST_NAME";
                    case 6: // SURNAME
                        return "SURNAME";
                    case 7: // SUPPORT_ROLE
                        return "SUPPORT_ROLE";
                    case 8: // SUPPORT_ROLE_NEW
                        return "SUPPORT_ROLE_NEW";
                    case 9: // ADDRESS01
                        return "ADDRESS01";
                    case 10: // ADDRESS02
                        return "ADDRESS02";
                    case 11: // SUBURB
                        return "SUBURB";
                    case 12: // STATE
                        return "STATE";
                    case 13: // POSTCODE
                        return "POSTCODE";
                    case 14: // KAP_LINK
                        return "KAP_LINK";
                    case 15: // BUS_PHONE
                        return "BUS_PHONE";
                    case 16: // BUS_EMAIL
                        return "BUS_EMAIL";
                    case 17: // ADDED_BY
                        return "ADDED_BY";
                    case 18: // SUPPORT_SERVICES
                        return "SUPPORT_SERVICES";
                    case 19: // STUDENT_SUPPORT
                        return "STUDENT_SUPPORT";
                    case 20: // STUDENT_OTHER_SUPPORT
                        return "STUDENT_OTHER_SUPPORT";
                    case 21: // CHILD_PROTECTION
                        return "CHILD_PROTECTION";
                    case 22: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 23: // KGO_TRANS_ID
                        return "KGO_TRANS_ID";
                    case 24: // IMP_STATUS
                        return "IMP_STATUS";
                    case 25: // IMP_DATE
                        return "IMP_DATE";
                    case 26: // LW_DATE
                        return "LW_DATE";
                    case 27: // LW_TIME
                        return "LW_TIME";
                    case 28: // LW_USER
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
                    case "STSUP_TRANS_ID":
                        return 2;
                    case "SKEY":
                        return 3;
                    case "SKEY_NEW":
                        return 4;
                    case "FIRST_NAME":
                        return 5;
                    case "SURNAME":
                        return 6;
                    case "SUPPORT_ROLE":
                        return 7;
                    case "SUPPORT_ROLE_NEW":
                        return 8;
                    case "ADDRESS01":
                        return 9;
                    case "ADDRESS02":
                        return 10;
                    case "SUBURB":
                        return 11;
                    case "STATE":
                        return 12;
                    case "POSTCODE":
                        return 13;
                    case "KAP_LINK":
                        return 14;
                    case "BUS_PHONE":
                        return 15;
                    case "BUS_EMAIL":
                        return 16;
                    case "ADDED_BY":
                        return 17;
                    case "SUPPORT_SERVICES":
                        return 18;
                    case "STUDENT_SUPPORT":
                        return 19;
                    case "STUDENT_OTHER_SUPPORT":
                        return 20;
                    case "CHILD_PROTECTION":
                        return 21;
                    case "ST_TRANS_ID":
                        return 22;
                    case "KGO_TRANS_ID":
                        return 23;
                    case "IMP_STATUS":
                        return 24;
                    case "IMP_DATE":
                        return 25;
                    case "LW_DATE":
                        return 26;
                    case "LW_TIME":
                        return 27;
                    case "LW_USER":
                        return 28;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
