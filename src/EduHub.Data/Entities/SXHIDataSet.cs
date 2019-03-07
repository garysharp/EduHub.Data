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
    /// Student History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SXHIDataSet : EduHubDataSet<SXHI>
    {
        /// <inheritdoc />
        public override string Name { get { return "SXHI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SXHIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SKEY = new Lazy<NullDictionary<string, IReadOnlyList<SXHI>>>(() => this.ToGroupedNullDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, SXHI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SXHI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SXHI" /> fields for each CSV column header</returns>
        internal override Action<SXHI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SXHI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STREG":
                        mapper[i] = (e, v) => e.STREG = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "HKEY":
                        mapper[i] = (e, v) => e.HKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "HOME_GROUP":
                        mapper[i] = (e, v) => e.HOME_GROUP = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "FAMB":
                        mapper[i] = (e, v) => e.FAMB = v;
                        break;
                    case "FAMC":
                        mapper[i] = (e, v) => e.FAMC = v;
                        break;
                    case "RESIDENT_STATUS":
                        mapper[i] = (e, v) => e.RESIDENT_STATUS = v;
                        break;
                    case "PERMANENT_BASIS":
                        mapper[i] = (e, v) => e.PERMANENT_BASIS = v;
                        break;
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "VISA_STAT_CODE":
                        mapper[i] = (e, v) => e.VISA_STAT_CODE = v;
                        break;
                    case "VISA_EXPIRY":
                        mapper[i] = (e, v) => e.VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACCESS_ALERT":
                        mapper[i] = (e, v) => e.ACCESS_ALERT = v;
                        break;
                    case "ACCESS":
                        mapper[i] = (e, v) => e.ACCESS = v;
                        break;
                    case "ACCESS_TYPE":
                        mapper[i] = (e, v) => e.ACCESS_TYPE = v;
                        break;
                    case "NEXT_SCHOOL":
                        mapper[i] = (e, v) => e.NEXT_SCHOOL = v;
                        break;
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EXIT_DATE":
                        mapper[i] = (e, v) => e.EXIT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "INTERNATIONAL_ST_ID":
                        mapper[i] = (e, v) => e.INTERNATIONAL_ST_ID = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "VSN":
                        mapper[i] = (e, v) => e.VSN = v;
                        break;
                    case "VSR_TYPE":
                        mapper[i] = (e, v) => e.VSR_TYPE = v;
                        break;
                    case "PREVIOUS_TID":
                        mapper[i] = (e, v) => e.PREVIOUS_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SXHI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SXHI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SXHI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SXHI}"/> of entities</returns>
        internal override IEnumerable<SXHI> ApplyDeltaEntities(IEnumerable<SXHI> Entities, List<SXHI> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SXHI>>> Index_SKEY;
        private Lazy<Dictionary<int, SXHI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SXHI by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find SXHI</param>
        /// <returns>List of related SXHI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXHI> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find SXHI by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find SXHI</param>
        /// <param name="Value">List of related SXHI entities</param>
        /// <returns>True if the list of related SXHI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<SXHI> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SXHI by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find SXHI</param>
        /// <returns>List of related SXHI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SXHI> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<SXHI> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SXHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SXHI</param>
        /// <returns>Related SXHI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXHI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SXHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SXHI</param>
        /// <param name="Value">Related SXHI entity</param>
        /// <returns>True if the related SXHI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SXHI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SXHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SXHI</param>
        /// <returns>Related SXHI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SXHI TryFindByTID(int TID)
        {
            SXHI value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SXHI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SXHI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SXHI](
        [TID] int IDENTITY NOT NULL,
        [STREG] int NULL,
        [SKEY] varchar(10) NULL,
        [HKEY] varchar(10) NULL,
        [CREATION_USER] varchar(128) NULL,
        [CREATION_DATE] datetime NULL,
        [CREATION_TIME] smallint NULL,
        [OBSOLETE_USER] varchar(128) NULL,
        [OBSOLETE_DATE] datetime NULL,
        [OBSOLETE_TIME] smallint NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [STATUS] varchar(4) NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [HOME_GROUP] varchar(40) NULL,
        [FAMILY] varchar(60) NULL,
        [FAMB] varchar(60) NULL,
        [FAMC] varchar(60) NULL,
        [RESIDENT_STATUS] varchar(1) NULL,
        [PERMANENT_BASIS] varchar(1) NULL,
        [VISA_SUBCLASS] varchar(3) NULL,
        [VISA_STAT_CODE] varchar(4) NULL,
        [VISA_EXPIRY] datetime NULL,
        [SGB_FUNDED] varchar(1) NULL,
        [SGB_TIME_FRACTION] float NULL,
        [ACTUAL_TIME_FRACTION] float NULL,
        [ACCESS_ALERT] varchar(1) NULL,
        [ACCESS] varchar(MAX) NULL,
        [ACCESS_TYPE] varchar(20) NULL,
        [NEXT_SCHOOL] varchar(50) NULL,
        [ENTRY] datetime NULL,
        [EXIT_DATE] datetime NULL,
        [INTERNATIONAL_ST_ID] varchar(7) NULL,
        [SECOND_NAME] varchar(20) NULL,
        [GENDER] varchar(1) NULL,
        [BIRTHDATE] datetime NULL,
        [VSN] varchar(12) NULL,
        [VSR_TYPE] varchar(1) NULL,
        [PREVIOUS_TID] int NULL,
        [CHANGE_MADE] varchar(80) NULL,
        CONSTRAINT [SXHI_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SXHI_Index_SKEY] ON [dbo].[SXHI]
    (
            [SKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXHI]') AND name = N'Index_SKEY')
    ALTER INDEX [Index_SKEY] ON [dbo].[SXHI] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SXHI]') AND name = N'Index_SKEY')
    ALTER INDEX [Index_SKEY] ON [dbo].[SXHI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SXHI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SXHI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SXHI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SXHI] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SXHI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SXHI data set</returns>
        public override EduHubDataSetDataReader<SXHI> GetDataSetDataReader()
        {
            return new SXHIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SXHI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SXHI data set</returns>
        public override EduHubDataSetDataReader<SXHI> GetDataSetDataReader(List<SXHI> Entities)
        {
            return new SXHIDataReader(new EduHubDataSetLoadedReader<SXHI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SXHIDataReader : EduHubDataSetDataReader<SXHI>
        {
            public SXHIDataReader(IEduHubDataSetReader<SXHI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 40; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // STREG
                        return Current.STREG;
                    case 2: // SKEY
                        return Current.SKEY;
                    case 3: // HKEY
                        return Current.HKEY;
                    case 4: // CREATION_USER
                        return Current.CREATION_USER;
                    case 5: // CREATION_DATE
                        return Current.CREATION_DATE;
                    case 6: // CREATION_TIME
                        return Current.CREATION_TIME;
                    case 7: // OBSOLETE_USER
                        return Current.OBSOLETE_USER;
                    case 8: // OBSOLETE_DATE
                        return Current.OBSOLETE_DATE;
                    case 9: // OBSOLETE_TIME
                        return Current.OBSOLETE_TIME;
                    case 10: // SURNAME
                        return Current.SURNAME;
                    case 11: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 12: // STATUS
                        return Current.STATUS;
                    case 13: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 14: // HOME_GROUP
                        return Current.HOME_GROUP;
                    case 15: // FAMILY
                        return Current.FAMILY;
                    case 16: // FAMB
                        return Current.FAMB;
                    case 17: // FAMC
                        return Current.FAMC;
                    case 18: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS;
                    case 19: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS;
                    case 20: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS;
                    case 21: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE;
                    case 22: // VISA_EXPIRY
                        return Current.VISA_EXPIRY;
                    case 23: // SGB_FUNDED
                        return Current.SGB_FUNDED;
                    case 24: // SGB_TIME_FRACTION
                        return Current.SGB_TIME_FRACTION;
                    case 25: // ACTUAL_TIME_FRACTION
                        return Current.ACTUAL_TIME_FRACTION;
                    case 26: // ACCESS_ALERT
                        return Current.ACCESS_ALERT;
                    case 27: // ACCESS
                        return Current.ACCESS;
                    case 28: // ACCESS_TYPE
                        return Current.ACCESS_TYPE;
                    case 29: // NEXT_SCHOOL
                        return Current.NEXT_SCHOOL;
                    case 30: // ENTRY
                        return Current.ENTRY;
                    case 31: // EXIT_DATE
                        return Current.EXIT_DATE;
                    case 32: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID;
                    case 33: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 34: // GENDER
                        return Current.GENDER;
                    case 35: // BIRTHDATE
                        return Current.BIRTHDATE;
                    case 36: // VSN
                        return Current.VSN;
                    case 37: // VSR_TYPE
                        return Current.VSR_TYPE;
                    case 38: // PREVIOUS_TID
                        return Current.PREVIOUS_TID;
                    case 39: // CHANGE_MADE
                        return Current.CHANGE_MADE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // STREG
                        return Current.STREG == null;
                    case 2: // SKEY
                        return Current.SKEY == null;
                    case 3: // HKEY
                        return Current.HKEY == null;
                    case 4: // CREATION_USER
                        return Current.CREATION_USER == null;
                    case 5: // CREATION_DATE
                        return Current.CREATION_DATE == null;
                    case 6: // CREATION_TIME
                        return Current.CREATION_TIME == null;
                    case 7: // OBSOLETE_USER
                        return Current.OBSOLETE_USER == null;
                    case 8: // OBSOLETE_DATE
                        return Current.OBSOLETE_DATE == null;
                    case 9: // OBSOLETE_TIME
                        return Current.OBSOLETE_TIME == null;
                    case 10: // SURNAME
                        return Current.SURNAME == null;
                    case 11: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 12: // STATUS
                        return Current.STATUS == null;
                    case 13: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 14: // HOME_GROUP
                        return Current.HOME_GROUP == null;
                    case 15: // FAMILY
                        return Current.FAMILY == null;
                    case 16: // FAMB
                        return Current.FAMB == null;
                    case 17: // FAMC
                        return Current.FAMC == null;
                    case 18: // RESIDENT_STATUS
                        return Current.RESIDENT_STATUS == null;
                    case 19: // PERMANENT_BASIS
                        return Current.PERMANENT_BASIS == null;
                    case 20: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS == null;
                    case 21: // VISA_STAT_CODE
                        return Current.VISA_STAT_CODE == null;
                    case 22: // VISA_EXPIRY
                        return Current.VISA_EXPIRY == null;
                    case 23: // SGB_FUNDED
                        return Current.SGB_FUNDED == null;
                    case 24: // SGB_TIME_FRACTION
                        return Current.SGB_TIME_FRACTION == null;
                    case 25: // ACTUAL_TIME_FRACTION
                        return Current.ACTUAL_TIME_FRACTION == null;
                    case 26: // ACCESS_ALERT
                        return Current.ACCESS_ALERT == null;
                    case 27: // ACCESS
                        return Current.ACCESS == null;
                    case 28: // ACCESS_TYPE
                        return Current.ACCESS_TYPE == null;
                    case 29: // NEXT_SCHOOL
                        return Current.NEXT_SCHOOL == null;
                    case 30: // ENTRY
                        return Current.ENTRY == null;
                    case 31: // EXIT_DATE
                        return Current.EXIT_DATE == null;
                    case 32: // INTERNATIONAL_ST_ID
                        return Current.INTERNATIONAL_ST_ID == null;
                    case 33: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 34: // GENDER
                        return Current.GENDER == null;
                    case 35: // BIRTHDATE
                        return Current.BIRTHDATE == null;
                    case 36: // VSN
                        return Current.VSN == null;
                    case 37: // VSR_TYPE
                        return Current.VSR_TYPE == null;
                    case 38: // PREVIOUS_TID
                        return Current.PREVIOUS_TID == null;
                    case 39: // CHANGE_MADE
                        return Current.CHANGE_MADE == null;
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
                    case 1: // STREG
                        return "STREG";
                    case 2: // SKEY
                        return "SKEY";
                    case 3: // HKEY
                        return "HKEY";
                    case 4: // CREATION_USER
                        return "CREATION_USER";
                    case 5: // CREATION_DATE
                        return "CREATION_DATE";
                    case 6: // CREATION_TIME
                        return "CREATION_TIME";
                    case 7: // OBSOLETE_USER
                        return "OBSOLETE_USER";
                    case 8: // OBSOLETE_DATE
                        return "OBSOLETE_DATE";
                    case 9: // OBSOLETE_TIME
                        return "OBSOLETE_TIME";
                    case 10: // SURNAME
                        return "SURNAME";
                    case 11: // FIRST_NAME
                        return "FIRST_NAME";
                    case 12: // STATUS
                        return "STATUS";
                    case 13: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 14: // HOME_GROUP
                        return "HOME_GROUP";
                    case 15: // FAMILY
                        return "FAMILY";
                    case 16: // FAMB
                        return "FAMB";
                    case 17: // FAMC
                        return "FAMC";
                    case 18: // RESIDENT_STATUS
                        return "RESIDENT_STATUS";
                    case 19: // PERMANENT_BASIS
                        return "PERMANENT_BASIS";
                    case 20: // VISA_SUBCLASS
                        return "VISA_SUBCLASS";
                    case 21: // VISA_STAT_CODE
                        return "VISA_STAT_CODE";
                    case 22: // VISA_EXPIRY
                        return "VISA_EXPIRY";
                    case 23: // SGB_FUNDED
                        return "SGB_FUNDED";
                    case 24: // SGB_TIME_FRACTION
                        return "SGB_TIME_FRACTION";
                    case 25: // ACTUAL_TIME_FRACTION
                        return "ACTUAL_TIME_FRACTION";
                    case 26: // ACCESS_ALERT
                        return "ACCESS_ALERT";
                    case 27: // ACCESS
                        return "ACCESS";
                    case 28: // ACCESS_TYPE
                        return "ACCESS_TYPE";
                    case 29: // NEXT_SCHOOL
                        return "NEXT_SCHOOL";
                    case 30: // ENTRY
                        return "ENTRY";
                    case 31: // EXIT_DATE
                        return "EXIT_DATE";
                    case 32: // INTERNATIONAL_ST_ID
                        return "INTERNATIONAL_ST_ID";
                    case 33: // SECOND_NAME
                        return "SECOND_NAME";
                    case 34: // GENDER
                        return "GENDER";
                    case 35: // BIRTHDATE
                        return "BIRTHDATE";
                    case 36: // VSN
                        return "VSN";
                    case 37: // VSR_TYPE
                        return "VSR_TYPE";
                    case 38: // PREVIOUS_TID
                        return "PREVIOUS_TID";
                    case 39: // CHANGE_MADE
                        return "CHANGE_MADE";
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
                    case "STREG":
                        return 1;
                    case "SKEY":
                        return 2;
                    case "HKEY":
                        return 3;
                    case "CREATION_USER":
                        return 4;
                    case "CREATION_DATE":
                        return 5;
                    case "CREATION_TIME":
                        return 6;
                    case "OBSOLETE_USER":
                        return 7;
                    case "OBSOLETE_DATE":
                        return 8;
                    case "OBSOLETE_TIME":
                        return 9;
                    case "SURNAME":
                        return 10;
                    case "FIRST_NAME":
                        return 11;
                    case "STATUS":
                        return 12;
                    case "SCHOOL_YEAR":
                        return 13;
                    case "HOME_GROUP":
                        return 14;
                    case "FAMILY":
                        return 15;
                    case "FAMB":
                        return 16;
                    case "FAMC":
                        return 17;
                    case "RESIDENT_STATUS":
                        return 18;
                    case "PERMANENT_BASIS":
                        return 19;
                    case "VISA_SUBCLASS":
                        return 20;
                    case "VISA_STAT_CODE":
                        return 21;
                    case "VISA_EXPIRY":
                        return 22;
                    case "SGB_FUNDED":
                        return 23;
                    case "SGB_TIME_FRACTION":
                        return 24;
                    case "ACTUAL_TIME_FRACTION":
                        return 25;
                    case "ACCESS_ALERT":
                        return 26;
                    case "ACCESS":
                        return 27;
                    case "ACCESS_TYPE":
                        return 28;
                    case "NEXT_SCHOOL":
                        return 29;
                    case "ENTRY":
                        return 30;
                    case "EXIT_DATE":
                        return 31;
                    case "INTERNATIONAL_ST_ID":
                        return 32;
                    case "SECOND_NAME":
                        return 33;
                    case "GENDER":
                        return 34;
                    case "BIRTHDATE":
                        return 35;
                    case "VSN":
                        return 36;
                    case "VSR_TYPE":
                        return 37;
                    case "PREVIOUS_TID":
                        return 38;
                    case "CHANGE_MADE":
                        return 39;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
