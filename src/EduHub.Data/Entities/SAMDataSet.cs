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
    /// School Association Members Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAMDataSet : EduHubDataSet<SAM>
    {
        /// <inheritdoc />
        public override string Name { get { return "SAM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ADDRESSKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ADDRESSKEY));
            Index_ASSOC_NAME = new Lazy<NullDictionary<string, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ASSOC_NAME));
            Index_ASSOC_POSN = new Lazy<NullDictionary<string, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ASSOC_POSN));
            Index_MAILKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.MAILKEY));
            Index_SAMKEY = new Lazy<Dictionary<int, SAM>>(() => this.ToDictionary(i => i.SAMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAM" /> fields for each CSV column header</returns>
        internal override Action<SAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAMKEY":
                        mapper[i] = (e, v) => e.SAMKEY = int.Parse(v);
                        break;
                    case "PERSON_TYPE":
                        mapper[i] = (e, v) => e.PERSON_TYPE = v;
                        break;
                    case "PERSON":
                        mapper[i] = (e, v) => e.PERSON = v;
                        break;
                    case "WHICH_PARENT":
                        mapper[i] = (e, v) => e.WHICH_PARENT = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "PARENT_OS":
                        mapper[i] = (e, v) => e.PARENT_OS = v;
                        break;
                    case "LOTE":
                        mapper[i] = (e, v) => e.LOTE = v;
                        break;
                    case "LBOTE":
                        mapper[i] = (e, v) => e.LBOTE = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "ASSOC_NAME":
                        mapper[i] = (e, v) => e.ASSOC_NAME = v;
                        break;
                    case "ASSOC_POSN":
                        mapper[i] = (e, v) => e.ASSOC_POSN = v;
                        break;
                    case "ADDRESSKEY":
                        mapper[i] = (e, v) => e.ADDRESSKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOME_E_MAIL":
                        mapper[i] = (e, v) => e.HOME_E_MAIL = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "WORK_FAX":
                        mapper[i] = (e, v) => e.WORK_FAX = v;
                        break;
                    case "WORK_E_MAIL":
                        mapper[i] = (e, v) => e.WORK_E_MAIL = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "MOBILE_PHONE":
                        mapper[i] = (e, v) => e.MOBILE_PHONE = v;
                        break;
                    case "SIGNATORY":
                        mapper[i] = (e, v) => e.SIGNATORY = v;
                        break;
                    case "SAM_COMMENT":
                        mapper[i] = (e, v) => e.SAM_COMMENT = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SAM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SAM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SAM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SAM}"/> of entities</returns>
        internal override IEnumerable<SAM> ApplyDeltaEntities(IEnumerable<SAM> Entities, List<SAM> DeltaEntities)
        {
            HashSet<int> Index_SAMKEY = new HashSet<int>(DeltaEntities.Select(i => i.SAMKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SAMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SAMKEY.Remove(entity.SAMKEY);
                            
                            if (entity.SAMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<SAM>>> Index_ADDRESSKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SAM>>> Index_ASSOC_NAME;
        private Lazy<NullDictionary<string, IReadOnlyList<SAM>>> Index_ASSOC_POSN;
        private Lazy<NullDictionary<int?, IReadOnlyList<SAM>>> Index_MAILKEY;
        private Lazy<Dictionary<int, SAM>> Index_SAMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByADDRESSKEY(int? ADDRESSKEY)
        {
            return Index_ADDRESSKEY.Value[ADDRESSKEY];
        }

        /// <summary>
        /// Attempt to find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByADDRESSKEY(int? ADDRESSKEY, out IReadOnlyList<SAM> Value)
        {
            return Index_ADDRESSKEY.Value.TryGetValue(ADDRESSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByADDRESSKEY(int? ADDRESSKEY)
        {
            IReadOnlyList<SAM> value;
            if (Index_ADDRESSKEY.Value.TryGetValue(ADDRESSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByASSOC_NAME(string ASSOC_NAME)
        {
            return Index_ASSOC_NAME.Value[ASSOC_NAME];
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByASSOC_NAME(string ASSOC_NAME, out IReadOnlyList<SAM> Value)
        {
            return Index_ASSOC_NAME.Value.TryGetValue(ASSOC_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByASSOC_NAME(string ASSOC_NAME)
        {
            IReadOnlyList<SAM> value;
            if (Index_ASSOC_NAME.Value.TryGetValue(ASSOC_NAME, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByASSOC_POSN(string ASSOC_POSN)
        {
            return Index_ASSOC_POSN.Value[ASSOC_POSN];
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByASSOC_POSN(string ASSOC_POSN, out IReadOnlyList<SAM> Value)
        {
            return Index_ASSOC_POSN.Value.TryGetValue(ASSOC_POSN, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByASSOC_POSN(string ASSOC_POSN)
        {
            IReadOnlyList<SAM> value;
            if (Index_ASSOC_POSN.Value.TryGetValue(ASSOC_POSN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByMAILKEY(int? MAILKEY)
        {
            return Index_MAILKEY.Value[MAILKEY];
        }

        /// <summary>
        /// Attempt to find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILKEY(int? MAILKEY, out IReadOnlyList<SAM> Value)
        {
            return Index_MAILKEY.Value.TryGetValue(MAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByMAILKEY(int? MAILKEY)
        {
            IReadOnlyList<SAM> value;
            if (Index_MAILKEY.Value.TryGetValue(MAILKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <returns>Related SAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAM FindBySAMKEY(int SAMKEY)
        {
            return Index_SAMKEY.Value[SAMKEY];
        }

        /// <summary>
        /// Attempt to find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <param name="Value">Related SAM entity</param>
        /// <returns>True if the related SAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMKEY(int SAMKEY, out SAM Value)
        {
            return Index_SAMKEY.Value.TryGetValue(SAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <returns>Related SAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAM TryFindBySAMKEY(int SAMKEY)
        {
            SAM value;
            if (Index_SAMKEY.Value.TryGetValue(SAMKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SAM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAM](
        [SAMKEY] int IDENTITY NOT NULL,
        [PERSON_TYPE] varchar(2) NULL,
        [PERSON] varchar(10) NULL,
        [WHICH_PARENT] varchar(1) NULL,
        [GENDER] varchar(1) NULL,
        [BIRTHDATE] datetime NULL,
        [KOORIE] varchar(1) NULL,
        [PARENT_OS] varchar(1) NULL,
        [LOTE] varchar(1) NULL,
        [LBOTE] varchar(1) NULL,
        [DISABILITY] varchar(1) NULL,
        [ASSOC_NAME] varchar(15) NULL,
        [ASSOC_POSN] varchar(25) NULL,
        [ADDRESSKEY] int NULL,
        [MAILKEY] int NULL,
        [HOME_E_MAIL] varchar(60) NULL,
        [WORK_PHONE] varchar(20) NULL,
        [WORK_FAX] varchar(20) NULL,
        [WORK_E_MAIL] varchar(60) NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(20) NULL,
        [TITLE] varchar(4) NULL,
        [MOBILE_PHONE] varchar(20) NULL,
        [SIGNATORY] varchar(1) NULL,
        [SAM_COMMENT] varchar(MAX) NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAM_Index_SAMKEY] PRIMARY KEY CLUSTERED (
            [SAMKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SAM_Index_ADDRESSKEY] ON [dbo].[SAM]
    (
            [ADDRESSKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SAM_Index_ASSOC_NAME] ON [dbo].[SAM]
    (
            [ASSOC_NAME] ASC
    );
    CREATE NONCLUSTERED INDEX [SAM_Index_ASSOC_POSN] ON [dbo].[SAM]
    (
            [ASSOC_POSN] ASC
    );
    CREATE NONCLUSTERED INDEX [SAM_Index_MAILKEY] ON [dbo].[SAM]
    (
            [MAILKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND name = N'Index_ADDRESSKEY')
    ALTER INDEX [Index_ADDRESSKEY] ON [dbo].[SAM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND name = N'Index_ASSOC_NAME')
    ALTER INDEX [Index_ASSOC_NAME] ON [dbo].[SAM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND name = N'Index_ASSOC_POSN')
    ALTER INDEX [Index_ASSOC_POSN] ON [dbo].[SAM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND name = N'Index_MAILKEY')
    ALTER INDEX [Index_MAILKEY] ON [dbo].[SAM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND name = N'Index_ADDRESSKEY')
    ALTER INDEX [Index_ADDRESSKEY] ON [dbo].[SAM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND name = N'Index_ASSOC_NAME')
    ALTER INDEX [Index_ASSOC_NAME] ON [dbo].[SAM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND name = N'Index_ASSOC_POSN')
    ALTER INDEX [Index_ASSOC_POSN] ON [dbo].[SAM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAM]') AND name = N'Index_MAILKEY')
    ALTER INDEX [Index_MAILKEY] ON [dbo].[SAM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SAM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SAM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SAM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SAMKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SAMKEY.Add(entity.SAMKEY);
            }

            builder.AppendLine("DELETE [dbo].[SAM] WHERE");


            // Index_SAMKEY
            builder.Append("[SAMKEY] IN (");
            for (int index = 0; index < Index_SAMKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SAMKEY
                var parameterSAMKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSAMKEY);
                command.Parameters.Add(parameterSAMKEY, SqlDbType.Int).Value = Index_SAMKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAM data set</returns>
        public override EduHubDataSetDataReader<SAM> GetDataSetDataReader()
        {
            return new SAMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAM data set</returns>
        public override EduHubDataSetDataReader<SAM> GetDataSetDataReader(List<SAM> Entities)
        {
            return new SAMDataReader(new EduHubDataSetLoadedReader<SAM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAMDataReader : EduHubDataSetDataReader<SAM>
        {
            public SAMDataReader(IEduHubDataSetReader<SAM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 30; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SAMKEY
                        return Current.SAMKEY;
                    case 1: // PERSON_TYPE
                        return Current.PERSON_TYPE;
                    case 2: // PERSON
                        return Current.PERSON;
                    case 3: // WHICH_PARENT
                        return Current.WHICH_PARENT;
                    case 4: // GENDER
                        return Current.GENDER;
                    case 5: // BIRTHDATE
                        return Current.BIRTHDATE;
                    case 6: // KOORIE
                        return Current.KOORIE;
                    case 7: // PARENT_OS
                        return Current.PARENT_OS;
                    case 8: // LOTE
                        return Current.LOTE;
                    case 9: // LBOTE
                        return Current.LBOTE;
                    case 10: // DISABILITY
                        return Current.DISABILITY;
                    case 11: // ASSOC_NAME
                        return Current.ASSOC_NAME;
                    case 12: // ASSOC_POSN
                        return Current.ASSOC_POSN;
                    case 13: // ADDRESSKEY
                        return Current.ADDRESSKEY;
                    case 14: // MAILKEY
                        return Current.MAILKEY;
                    case 15: // HOME_E_MAIL
                        return Current.HOME_E_MAIL;
                    case 16: // WORK_PHONE
                        return Current.WORK_PHONE;
                    case 17: // WORK_FAX
                        return Current.WORK_FAX;
                    case 18: // WORK_E_MAIL
                        return Current.WORK_E_MAIL;
                    case 19: // SURNAME
                        return Current.SURNAME;
                    case 20: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 21: // TITLE
                        return Current.TITLE;
                    case 22: // MOBILE_PHONE
                        return Current.MOBILE_PHONE;
                    case 23: // SIGNATORY
                        return Current.SIGNATORY;
                    case 24: // SAM_COMMENT
                        return Current.SAM_COMMENT;
                    case 25: // START_DATE
                        return Current.START_DATE;
                    case 26: // END_DATE
                        return Current.END_DATE;
                    case 27: // LW_DATE
                        return Current.LW_DATE;
                    case 28: // LW_TIME
                        return Current.LW_TIME;
                    case 29: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // PERSON_TYPE
                        return Current.PERSON_TYPE == null;
                    case 2: // PERSON
                        return Current.PERSON == null;
                    case 3: // WHICH_PARENT
                        return Current.WHICH_PARENT == null;
                    case 4: // GENDER
                        return Current.GENDER == null;
                    case 5: // BIRTHDATE
                        return Current.BIRTHDATE == null;
                    case 6: // KOORIE
                        return Current.KOORIE == null;
                    case 7: // PARENT_OS
                        return Current.PARENT_OS == null;
                    case 8: // LOTE
                        return Current.LOTE == null;
                    case 9: // LBOTE
                        return Current.LBOTE == null;
                    case 10: // DISABILITY
                        return Current.DISABILITY == null;
                    case 11: // ASSOC_NAME
                        return Current.ASSOC_NAME == null;
                    case 12: // ASSOC_POSN
                        return Current.ASSOC_POSN == null;
                    case 13: // ADDRESSKEY
                        return Current.ADDRESSKEY == null;
                    case 14: // MAILKEY
                        return Current.MAILKEY == null;
                    case 15: // HOME_E_MAIL
                        return Current.HOME_E_MAIL == null;
                    case 16: // WORK_PHONE
                        return Current.WORK_PHONE == null;
                    case 17: // WORK_FAX
                        return Current.WORK_FAX == null;
                    case 18: // WORK_E_MAIL
                        return Current.WORK_E_MAIL == null;
                    case 19: // SURNAME
                        return Current.SURNAME == null;
                    case 20: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 21: // TITLE
                        return Current.TITLE == null;
                    case 22: // MOBILE_PHONE
                        return Current.MOBILE_PHONE == null;
                    case 23: // SIGNATORY
                        return Current.SIGNATORY == null;
                    case 24: // SAM_COMMENT
                        return Current.SAM_COMMENT == null;
                    case 25: // START_DATE
                        return Current.START_DATE == null;
                    case 26: // END_DATE
                        return Current.END_DATE == null;
                    case 27: // LW_DATE
                        return Current.LW_DATE == null;
                    case 28: // LW_TIME
                        return Current.LW_TIME == null;
                    case 29: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SAMKEY
                        return "SAMKEY";
                    case 1: // PERSON_TYPE
                        return "PERSON_TYPE";
                    case 2: // PERSON
                        return "PERSON";
                    case 3: // WHICH_PARENT
                        return "WHICH_PARENT";
                    case 4: // GENDER
                        return "GENDER";
                    case 5: // BIRTHDATE
                        return "BIRTHDATE";
                    case 6: // KOORIE
                        return "KOORIE";
                    case 7: // PARENT_OS
                        return "PARENT_OS";
                    case 8: // LOTE
                        return "LOTE";
                    case 9: // LBOTE
                        return "LBOTE";
                    case 10: // DISABILITY
                        return "DISABILITY";
                    case 11: // ASSOC_NAME
                        return "ASSOC_NAME";
                    case 12: // ASSOC_POSN
                        return "ASSOC_POSN";
                    case 13: // ADDRESSKEY
                        return "ADDRESSKEY";
                    case 14: // MAILKEY
                        return "MAILKEY";
                    case 15: // HOME_E_MAIL
                        return "HOME_E_MAIL";
                    case 16: // WORK_PHONE
                        return "WORK_PHONE";
                    case 17: // WORK_FAX
                        return "WORK_FAX";
                    case 18: // WORK_E_MAIL
                        return "WORK_E_MAIL";
                    case 19: // SURNAME
                        return "SURNAME";
                    case 20: // FIRST_NAME
                        return "FIRST_NAME";
                    case 21: // TITLE
                        return "TITLE";
                    case 22: // MOBILE_PHONE
                        return "MOBILE_PHONE";
                    case 23: // SIGNATORY
                        return "SIGNATORY";
                    case 24: // SAM_COMMENT
                        return "SAM_COMMENT";
                    case 25: // START_DATE
                        return "START_DATE";
                    case 26: // END_DATE
                        return "END_DATE";
                    case 27: // LW_DATE
                        return "LW_DATE";
                    case 28: // LW_TIME
                        return "LW_TIME";
                    case 29: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SAMKEY":
                        return 0;
                    case "PERSON_TYPE":
                        return 1;
                    case "PERSON":
                        return 2;
                    case "WHICH_PARENT":
                        return 3;
                    case "GENDER":
                        return 4;
                    case "BIRTHDATE":
                        return 5;
                    case "KOORIE":
                        return 6;
                    case "PARENT_OS":
                        return 7;
                    case "LOTE":
                        return 8;
                    case "LBOTE":
                        return 9;
                    case "DISABILITY":
                        return 10;
                    case "ASSOC_NAME":
                        return 11;
                    case "ASSOC_POSN":
                        return 12;
                    case "ADDRESSKEY":
                        return 13;
                    case "MAILKEY":
                        return 14;
                    case "HOME_E_MAIL":
                        return 15;
                    case "WORK_PHONE":
                        return 16;
                    case "WORK_FAX":
                        return 17;
                    case "WORK_E_MAIL":
                        return 18;
                    case "SURNAME":
                        return 19;
                    case "FIRST_NAME":
                        return 20;
                    case "TITLE":
                        return 21;
                    case "MOBILE_PHONE":
                        return 22;
                    case "SIGNATORY":
                        return 23;
                    case "SAM_COMMENT":
                        return 24;
                    case "START_DATE":
                        return 25;
                    case "END_DATE":
                        return 26;
                    case "LW_DATE":
                        return 27;
                    case "LW_TIME":
                        return 28;
                    case "LW_USER":
                        return 29;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
