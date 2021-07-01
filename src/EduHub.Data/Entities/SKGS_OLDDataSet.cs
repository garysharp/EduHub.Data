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
    /// Old SKGS Schools Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SKGS_OLDDataSet : EduHubDataSet<SKGS_OLD>
    {
        /// <inheritdoc />
        public override string Name { get { return "SKGS_OLD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SKGS_OLDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_NEW_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<SKGS_OLD>>>(() => this.ToGroupedNullDictionary(i => i.NEW_SCHOOL));
            Index_SCHOOL = new Lazy<Dictionary<string, SKGS_OLD>>(() => this.ToDictionary(i => i.SCHOOL));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SKGS_OLD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SKGS_OLD" /> fields for each CSV column header</returns>
        internal override Action<SKGS_OLD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SKGS_OLD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "NEW_SCHOOL":
                        mapper[i] = (e, v) => e.NEW_SCHOOL = v;
                        break;
                    case "SCHOOL_TYPE":
                        mapper[i] = (e, v) => e.SCHOOL_TYPE = v;
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "SCHOOL_NUMBER":
                        mapper[i] = (e, v) => e.SCHOOL_NUMBER = v;
                        break;
                    case "CAMPUS_TYPE":
                        mapper[i] = (e, v) => e.CAMPUS_TYPE = v;
                        break;
                    case "CAMPUS_NAME":
                        mapper[i] = (e, v) => e.CAMPUS_NAME = v;
                        break;
                    case "REGION":
                        mapper[i] = (e, v) => e.REGION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REGION_NAME":
                        mapper[i] = (e, v) => e.REGION_NAME = v;
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
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "MAILING_ADDRESS01":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS01 = v;
                        break;
                    case "MAILING_ADDRESS02":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS02 = v;
                        break;
                    case "MAILING_SUBURB":
                        mapper[i] = (e, v) => e.MAILING_SUBURB = v;
                        break;
                    case "MAILING_STATE":
                        mapper[i] = (e, v) => e.MAILING_STATE = v;
                        break;
                    case "MAILING_POSTCODE":
                        mapper[i] = (e, v) => e.MAILING_POSTCODE = v;
                        break;
                    case "DELIVERY_ADDRESS01":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS01 = v;
                        break;
                    case "DELIVERY_ADDRESS02":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS02 = v;
                        break;
                    case "DELIVERY_SUBURB":
                        mapper[i] = (e, v) => e.DELIVERY_SUBURB = v;
                        break;
                    case "DELIVERY_STATE":
                        mapper[i] = (e, v) => e.DELIVERY_STATE = v;
                        break;
                    case "DELIVERY_POSTCODE":
                        mapper[i] = (e, v) => e.DELIVERY_POSTCODE = v;
                        break;
                    case "DELIVERY_TELEPHONE":
                        mapper[i] = (e, v) => e.DELIVERY_TELEPHONE = v;
                        break;
                    case "DELIVERY_FAX":
                        mapper[i] = (e, v) => e.DELIVERY_FAX = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "INTERNET_ADDRESS":
                        mapper[i] = (e, v) => e.INTERNET_ADDRESS = v;
                        break;
                    case "CASES21_RELEASE":
                        mapper[i] = (e, v) => e.CASES21_RELEASE = v;
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "SCH_PRINCIPAL_SALUTATION":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_SALUTATION = v;
                        break;
                    case "SCH_PRINCIPAL_FIRST_NAME":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_FIRST_NAME = v;
                        break;
                    case "SCH_PRINCIPAL_SURNAME":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_SURNAME = v;
                        break;
                    case "SCH_PRINCIPAL_TELEPHONE":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_TELEPHONE = v;
                        break;
                    case "SALUTATION":
                        mapper[i] = (e, v) => e.SALUTATION = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "CLOSED":
                        mapper[i] = (e, v) => e.CLOSED = v;
                        break;
                    case "CONCURRENT_ENROL":
                        mapper[i] = (e, v) => e.CONCURRENT_ENROL = v;
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
        /// Merges <see cref="SKGS_OLD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SKGS_OLD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SKGS_OLD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SKGS_OLD}"/> of entities</returns>
        internal override IEnumerable<SKGS_OLD> ApplyDeltaEntities(IEnumerable<SKGS_OLD> Entities, List<SKGS_OLD> DeltaEntities)
        {
            HashSet<string> Index_SCHOOL = new HashSet<string>(DeltaEntities.Select(i => i.SCHOOL));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCHOOL;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SCHOOL.Remove(entity.SCHOOL);
                            
                            if (entity.SCHOOL.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SKGS_OLD>>> Index_NEW_SCHOOL;
        private Lazy<Dictionary<string, SKGS_OLD>> Index_SCHOOL;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SKGS_OLD by NEW_SCHOOL field
        /// </summary>
        /// <param name="NEW_SCHOOL">NEW_SCHOOL value used to find SKGS_OLD</param>
        /// <returns>List of related SKGS_OLD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SKGS_OLD> FindByNEW_SCHOOL(string NEW_SCHOOL)
        {
            return Index_NEW_SCHOOL.Value[NEW_SCHOOL];
        }

        /// <summary>
        /// Attempt to find SKGS_OLD by NEW_SCHOOL field
        /// </summary>
        /// <param name="NEW_SCHOOL">NEW_SCHOOL value used to find SKGS_OLD</param>
        /// <param name="Value">List of related SKGS_OLD entities</param>
        /// <returns>True if the list of related SKGS_OLD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNEW_SCHOOL(string NEW_SCHOOL, out IReadOnlyList<SKGS_OLD> Value)
        {
            return Index_NEW_SCHOOL.Value.TryGetValue(NEW_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find SKGS_OLD by NEW_SCHOOL field
        /// </summary>
        /// <param name="NEW_SCHOOL">NEW_SCHOOL value used to find SKGS_OLD</param>
        /// <returns>List of related SKGS_OLD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SKGS_OLD> TryFindByNEW_SCHOOL(string NEW_SCHOOL)
        {
            IReadOnlyList<SKGS_OLD> value;
            if (Index_NEW_SCHOOL.Value.TryGetValue(NEW_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SKGS_OLD by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SKGS_OLD</param>
        /// <returns>Related SKGS_OLD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SKGS_OLD FindBySCHOOL(string SCHOOL)
        {
            return Index_SCHOOL.Value[SCHOOL];
        }

        /// <summary>
        /// Attempt to find SKGS_OLD by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SKGS_OLD</param>
        /// <param name="Value">Related SKGS_OLD entity</param>
        /// <returns>True if the related SKGS_OLD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL(string SCHOOL, out SKGS_OLD Value)
        {
            return Index_SCHOOL.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find SKGS_OLD by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SKGS_OLD</param>
        /// <returns>Related SKGS_OLD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SKGS_OLD TryFindBySCHOOL(string SCHOOL)
        {
            SKGS_OLD value;
            if (Index_SCHOOL.Value.TryGetValue(SCHOOL, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SKGS_OLD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SKGS_OLD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SKGS_OLD](
        [SCHOOL] varchar(8) NOT NULL,
        [NAME] varchar(40) NULL,
        [NEW_SCHOOL] varchar(8) NULL,
        [SCHOOL_TYPE] varchar(33) NULL,
        [ENTITY] varchar(2) NULL,
        [SCHOOL_ID] varchar(4) NULL,
        [SCHOOL_NUMBER] varchar(2) NULL,
        [CAMPUS_TYPE] varchar(33) NULL,
        [CAMPUS_NAME] varchar(40) NULL,
        [REGION] smallint NULL,
        [REGION_NAME] varchar(30) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [SUBURB] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [MAILING_ADDRESS01] varchar(30) NULL,
        [MAILING_ADDRESS02] varchar(30) NULL,
        [MAILING_SUBURB] varchar(30) NULL,
        [MAILING_STATE] varchar(3) NULL,
        [MAILING_POSTCODE] varchar(4) NULL,
        [DELIVERY_ADDRESS01] varchar(30) NULL,
        [DELIVERY_ADDRESS02] varchar(30) NULL,
        [DELIVERY_SUBURB] varchar(30) NULL,
        [DELIVERY_STATE] varchar(3) NULL,
        [DELIVERY_POSTCODE] varchar(4) NULL,
        [DELIVERY_TELEPHONE] varchar(20) NULL,
        [DELIVERY_FAX] varchar(20) NULL,
        [E_MAIL] varchar(255) NULL,
        [INTERNET_ADDRESS] varchar(255) NULL,
        [CASES21_RELEASE] varchar(12) NULL,
        [MAP_TYPE] varchar(1) NULL,
        [MAP_NUM] varchar(4) NULL,
        [X_AXIS] varchar(2) NULL,
        [Y_AXIS] varchar(2) NULL,
        [SCH_PRINCIPAL_SALUTATION] varchar(4) NULL,
        [SCH_PRINCIPAL_FIRST_NAME] varchar(20) NULL,
        [SCH_PRINCIPAL_SURNAME] varchar(30) NULL,
        [SCH_PRINCIPAL_TELEPHONE] varchar(20) NULL,
        [SALUTATION] varchar(4) NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [CLOSED] varchar(1) NULL,
        [CONCURRENT_ENROL] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SKGS_OLD_Index_SCHOOL] PRIMARY KEY CLUSTERED (
            [SCHOOL] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SKGS_OLD_Index_NEW_SCHOOL] ON [dbo].[SKGS_OLD]
    (
            [NEW_SCHOOL] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SKGS_OLD]') AND name = N'Index_NEW_SCHOOL')
    ALTER INDEX [Index_NEW_SCHOOL] ON [dbo].[SKGS_OLD] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SKGS_OLD]') AND name = N'Index_NEW_SCHOOL')
    ALTER INDEX [Index_NEW_SCHOOL] ON [dbo].[SKGS_OLD] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SKGS_OLD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SKGS_OLD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SKGS_OLD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SCHOOL = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SCHOOL.Add(entity.SCHOOL);
            }

            builder.AppendLine("DELETE [dbo].[SKGS_OLD] WHERE");


            // Index_SCHOOL
            builder.Append("[SCHOOL] IN (");
            for (int index = 0; index < Index_SCHOOL.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCHOOL
                var parameterSCHOOL = $"@p{parameterIndex++}";
                builder.Append(parameterSCHOOL);
                command.Parameters.Add(parameterSCHOOL, SqlDbType.VarChar, 8).Value = Index_SCHOOL[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SKGS_OLD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SKGS_OLD data set</returns>
        public override EduHubDataSetDataReader<SKGS_OLD> GetDataSetDataReader()
        {
            return new SKGS_OLDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SKGS_OLD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SKGS_OLD data set</returns>
        public override EduHubDataSetDataReader<SKGS_OLD> GetDataSetDataReader(List<SKGS_OLD> Entities)
        {
            return new SKGS_OLDDataReader(new EduHubDataSetLoadedReader<SKGS_OLD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SKGS_OLDDataReader : EduHubDataSetDataReader<SKGS_OLD>
        {
            public SKGS_OLDDataReader(IEduHubDataSetReader<SKGS_OLD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 49; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCHOOL
                        return Current.SCHOOL;
                    case 1: // NAME
                        return Current.NAME;
                    case 2: // NEW_SCHOOL
                        return Current.NEW_SCHOOL;
                    case 3: // SCHOOL_TYPE
                        return Current.SCHOOL_TYPE;
                    case 4: // ENTITY
                        return Current.ENTITY;
                    case 5: // SCHOOL_ID
                        return Current.SCHOOL_ID;
                    case 6: // SCHOOL_NUMBER
                        return Current.SCHOOL_NUMBER;
                    case 7: // CAMPUS_TYPE
                        return Current.CAMPUS_TYPE;
                    case 8: // CAMPUS_NAME
                        return Current.CAMPUS_NAME;
                    case 9: // REGION
                        return Current.REGION;
                    case 10: // REGION_NAME
                        return Current.REGION_NAME;
                    case 11: // ADDRESS01
                        return Current.ADDRESS01;
                    case 12: // ADDRESS02
                        return Current.ADDRESS02;
                    case 13: // SUBURB
                        return Current.SUBURB;
                    case 14: // STATE
                        return Current.STATE;
                    case 15: // POSTCODE
                        return Current.POSTCODE;
                    case 16: // TELEPHONE
                        return Current.TELEPHONE;
                    case 17: // FAX
                        return Current.FAX;
                    case 18: // MAILING_ADDRESS01
                        return Current.MAILING_ADDRESS01;
                    case 19: // MAILING_ADDRESS02
                        return Current.MAILING_ADDRESS02;
                    case 20: // MAILING_SUBURB
                        return Current.MAILING_SUBURB;
                    case 21: // MAILING_STATE
                        return Current.MAILING_STATE;
                    case 22: // MAILING_POSTCODE
                        return Current.MAILING_POSTCODE;
                    case 23: // DELIVERY_ADDRESS01
                        return Current.DELIVERY_ADDRESS01;
                    case 24: // DELIVERY_ADDRESS02
                        return Current.DELIVERY_ADDRESS02;
                    case 25: // DELIVERY_SUBURB
                        return Current.DELIVERY_SUBURB;
                    case 26: // DELIVERY_STATE
                        return Current.DELIVERY_STATE;
                    case 27: // DELIVERY_POSTCODE
                        return Current.DELIVERY_POSTCODE;
                    case 28: // DELIVERY_TELEPHONE
                        return Current.DELIVERY_TELEPHONE;
                    case 29: // DELIVERY_FAX
                        return Current.DELIVERY_FAX;
                    case 30: // E_MAIL
                        return Current.E_MAIL;
                    case 31: // INTERNET_ADDRESS
                        return Current.INTERNET_ADDRESS;
                    case 32: // CASES21_RELEASE
                        return Current.CASES21_RELEASE;
                    case 33: // MAP_TYPE
                        return Current.MAP_TYPE;
                    case 34: // MAP_NUM
                        return Current.MAP_NUM;
                    case 35: // X_AXIS
                        return Current.X_AXIS;
                    case 36: // Y_AXIS
                        return Current.Y_AXIS;
                    case 37: // SCH_PRINCIPAL_SALUTATION
                        return Current.SCH_PRINCIPAL_SALUTATION;
                    case 38: // SCH_PRINCIPAL_FIRST_NAME
                        return Current.SCH_PRINCIPAL_FIRST_NAME;
                    case 39: // SCH_PRINCIPAL_SURNAME
                        return Current.SCH_PRINCIPAL_SURNAME;
                    case 40: // SCH_PRINCIPAL_TELEPHONE
                        return Current.SCH_PRINCIPAL_TELEPHONE;
                    case 41: // SALUTATION
                        return Current.SALUTATION;
                    case 42: // SURNAME
                        return Current.SURNAME;
                    case 43: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 44: // CLOSED
                        return Current.CLOSED;
                    case 45: // CONCURRENT_ENROL
                        return Current.CONCURRENT_ENROL;
                    case 46: // LW_DATE
                        return Current.LW_DATE;
                    case 47: // LW_TIME
                        return Current.LW_TIME;
                    case 48: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // NAME
                        return Current.NAME == null;
                    case 2: // NEW_SCHOOL
                        return Current.NEW_SCHOOL == null;
                    case 3: // SCHOOL_TYPE
                        return Current.SCHOOL_TYPE == null;
                    case 4: // ENTITY
                        return Current.ENTITY == null;
                    case 5: // SCHOOL_ID
                        return Current.SCHOOL_ID == null;
                    case 6: // SCHOOL_NUMBER
                        return Current.SCHOOL_NUMBER == null;
                    case 7: // CAMPUS_TYPE
                        return Current.CAMPUS_TYPE == null;
                    case 8: // CAMPUS_NAME
                        return Current.CAMPUS_NAME == null;
                    case 9: // REGION
                        return Current.REGION == null;
                    case 10: // REGION_NAME
                        return Current.REGION_NAME == null;
                    case 11: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 12: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 13: // SUBURB
                        return Current.SUBURB == null;
                    case 14: // STATE
                        return Current.STATE == null;
                    case 15: // POSTCODE
                        return Current.POSTCODE == null;
                    case 16: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 17: // FAX
                        return Current.FAX == null;
                    case 18: // MAILING_ADDRESS01
                        return Current.MAILING_ADDRESS01 == null;
                    case 19: // MAILING_ADDRESS02
                        return Current.MAILING_ADDRESS02 == null;
                    case 20: // MAILING_SUBURB
                        return Current.MAILING_SUBURB == null;
                    case 21: // MAILING_STATE
                        return Current.MAILING_STATE == null;
                    case 22: // MAILING_POSTCODE
                        return Current.MAILING_POSTCODE == null;
                    case 23: // DELIVERY_ADDRESS01
                        return Current.DELIVERY_ADDRESS01 == null;
                    case 24: // DELIVERY_ADDRESS02
                        return Current.DELIVERY_ADDRESS02 == null;
                    case 25: // DELIVERY_SUBURB
                        return Current.DELIVERY_SUBURB == null;
                    case 26: // DELIVERY_STATE
                        return Current.DELIVERY_STATE == null;
                    case 27: // DELIVERY_POSTCODE
                        return Current.DELIVERY_POSTCODE == null;
                    case 28: // DELIVERY_TELEPHONE
                        return Current.DELIVERY_TELEPHONE == null;
                    case 29: // DELIVERY_FAX
                        return Current.DELIVERY_FAX == null;
                    case 30: // E_MAIL
                        return Current.E_MAIL == null;
                    case 31: // INTERNET_ADDRESS
                        return Current.INTERNET_ADDRESS == null;
                    case 32: // CASES21_RELEASE
                        return Current.CASES21_RELEASE == null;
                    case 33: // MAP_TYPE
                        return Current.MAP_TYPE == null;
                    case 34: // MAP_NUM
                        return Current.MAP_NUM == null;
                    case 35: // X_AXIS
                        return Current.X_AXIS == null;
                    case 36: // Y_AXIS
                        return Current.Y_AXIS == null;
                    case 37: // SCH_PRINCIPAL_SALUTATION
                        return Current.SCH_PRINCIPAL_SALUTATION == null;
                    case 38: // SCH_PRINCIPAL_FIRST_NAME
                        return Current.SCH_PRINCIPAL_FIRST_NAME == null;
                    case 39: // SCH_PRINCIPAL_SURNAME
                        return Current.SCH_PRINCIPAL_SURNAME == null;
                    case 40: // SCH_PRINCIPAL_TELEPHONE
                        return Current.SCH_PRINCIPAL_TELEPHONE == null;
                    case 41: // SALUTATION
                        return Current.SALUTATION == null;
                    case 42: // SURNAME
                        return Current.SURNAME == null;
                    case 43: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 44: // CLOSED
                        return Current.CLOSED == null;
                    case 45: // CONCURRENT_ENROL
                        return Current.CONCURRENT_ENROL == null;
                    case 46: // LW_DATE
                        return Current.LW_DATE == null;
                    case 47: // LW_TIME
                        return Current.LW_TIME == null;
                    case 48: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCHOOL
                        return "SCHOOL";
                    case 1: // NAME
                        return "NAME";
                    case 2: // NEW_SCHOOL
                        return "NEW_SCHOOL";
                    case 3: // SCHOOL_TYPE
                        return "SCHOOL_TYPE";
                    case 4: // ENTITY
                        return "ENTITY";
                    case 5: // SCHOOL_ID
                        return "SCHOOL_ID";
                    case 6: // SCHOOL_NUMBER
                        return "SCHOOL_NUMBER";
                    case 7: // CAMPUS_TYPE
                        return "CAMPUS_TYPE";
                    case 8: // CAMPUS_NAME
                        return "CAMPUS_NAME";
                    case 9: // REGION
                        return "REGION";
                    case 10: // REGION_NAME
                        return "REGION_NAME";
                    case 11: // ADDRESS01
                        return "ADDRESS01";
                    case 12: // ADDRESS02
                        return "ADDRESS02";
                    case 13: // SUBURB
                        return "SUBURB";
                    case 14: // STATE
                        return "STATE";
                    case 15: // POSTCODE
                        return "POSTCODE";
                    case 16: // TELEPHONE
                        return "TELEPHONE";
                    case 17: // FAX
                        return "FAX";
                    case 18: // MAILING_ADDRESS01
                        return "MAILING_ADDRESS01";
                    case 19: // MAILING_ADDRESS02
                        return "MAILING_ADDRESS02";
                    case 20: // MAILING_SUBURB
                        return "MAILING_SUBURB";
                    case 21: // MAILING_STATE
                        return "MAILING_STATE";
                    case 22: // MAILING_POSTCODE
                        return "MAILING_POSTCODE";
                    case 23: // DELIVERY_ADDRESS01
                        return "DELIVERY_ADDRESS01";
                    case 24: // DELIVERY_ADDRESS02
                        return "DELIVERY_ADDRESS02";
                    case 25: // DELIVERY_SUBURB
                        return "DELIVERY_SUBURB";
                    case 26: // DELIVERY_STATE
                        return "DELIVERY_STATE";
                    case 27: // DELIVERY_POSTCODE
                        return "DELIVERY_POSTCODE";
                    case 28: // DELIVERY_TELEPHONE
                        return "DELIVERY_TELEPHONE";
                    case 29: // DELIVERY_FAX
                        return "DELIVERY_FAX";
                    case 30: // E_MAIL
                        return "E_MAIL";
                    case 31: // INTERNET_ADDRESS
                        return "INTERNET_ADDRESS";
                    case 32: // CASES21_RELEASE
                        return "CASES21_RELEASE";
                    case 33: // MAP_TYPE
                        return "MAP_TYPE";
                    case 34: // MAP_NUM
                        return "MAP_NUM";
                    case 35: // X_AXIS
                        return "X_AXIS";
                    case 36: // Y_AXIS
                        return "Y_AXIS";
                    case 37: // SCH_PRINCIPAL_SALUTATION
                        return "SCH_PRINCIPAL_SALUTATION";
                    case 38: // SCH_PRINCIPAL_FIRST_NAME
                        return "SCH_PRINCIPAL_FIRST_NAME";
                    case 39: // SCH_PRINCIPAL_SURNAME
                        return "SCH_PRINCIPAL_SURNAME";
                    case 40: // SCH_PRINCIPAL_TELEPHONE
                        return "SCH_PRINCIPAL_TELEPHONE";
                    case 41: // SALUTATION
                        return "SALUTATION";
                    case 42: // SURNAME
                        return "SURNAME";
                    case 43: // FIRST_NAME
                        return "FIRST_NAME";
                    case 44: // CLOSED
                        return "CLOSED";
                    case 45: // CONCURRENT_ENROL
                        return "CONCURRENT_ENROL";
                    case 46: // LW_DATE
                        return "LW_DATE";
                    case 47: // LW_TIME
                        return "LW_TIME";
                    case 48: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCHOOL":
                        return 0;
                    case "NAME":
                        return 1;
                    case "NEW_SCHOOL":
                        return 2;
                    case "SCHOOL_TYPE":
                        return 3;
                    case "ENTITY":
                        return 4;
                    case "SCHOOL_ID":
                        return 5;
                    case "SCHOOL_NUMBER":
                        return 6;
                    case "CAMPUS_TYPE":
                        return 7;
                    case "CAMPUS_NAME":
                        return 8;
                    case "REGION":
                        return 9;
                    case "REGION_NAME":
                        return 10;
                    case "ADDRESS01":
                        return 11;
                    case "ADDRESS02":
                        return 12;
                    case "SUBURB":
                        return 13;
                    case "STATE":
                        return 14;
                    case "POSTCODE":
                        return 15;
                    case "TELEPHONE":
                        return 16;
                    case "FAX":
                        return 17;
                    case "MAILING_ADDRESS01":
                        return 18;
                    case "MAILING_ADDRESS02":
                        return 19;
                    case "MAILING_SUBURB":
                        return 20;
                    case "MAILING_STATE":
                        return 21;
                    case "MAILING_POSTCODE":
                        return 22;
                    case "DELIVERY_ADDRESS01":
                        return 23;
                    case "DELIVERY_ADDRESS02":
                        return 24;
                    case "DELIVERY_SUBURB":
                        return 25;
                    case "DELIVERY_STATE":
                        return 26;
                    case "DELIVERY_POSTCODE":
                        return 27;
                    case "DELIVERY_TELEPHONE":
                        return 28;
                    case "DELIVERY_FAX":
                        return 29;
                    case "E_MAIL":
                        return 30;
                    case "INTERNET_ADDRESS":
                        return 31;
                    case "CASES21_RELEASE":
                        return 32;
                    case "MAP_TYPE":
                        return 33;
                    case "MAP_NUM":
                        return 34;
                    case "X_AXIS":
                        return 35;
                    case "Y_AXIS":
                        return 36;
                    case "SCH_PRINCIPAL_SALUTATION":
                        return 37;
                    case "SCH_PRINCIPAL_FIRST_NAME":
                        return 38;
                    case "SCH_PRINCIPAL_SURNAME":
                        return 39;
                    case "SCH_PRINCIPAL_TELEPHONE":
                        return 40;
                    case "SALUTATION":
                        return 41;
                    case "SURNAME":
                        return 42;
                    case "FIRST_NAME":
                        return 43;
                    case "CLOSED":
                        return 44;
                    case "CONCURRENT_ENROL":
                        return 45;
                    case "LW_DATE":
                        return 46;
                    case "LW_TIME":
                        return 47;
                    case "LW_USER":
                        return 48;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
