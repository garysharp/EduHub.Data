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
    /// Student Transport Company Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTRCMPDataSet : EduHubDataSet<KTRCMP>
    {
        /// <inheritdoc />
        public override string Name { get { return "KTRCMP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KTRCMPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COMPANY_CODE = new Lazy<NullDictionary<string, KTRCMP>>(() => this.ToNullDictionary(i => i.COMPANY_CODE));
            Index_COMPANY_ID = new Lazy<Dictionary<int, KTRCMP>>(() => this.ToDictionary(i => i.COMPANY_ID));
            Index_COMPANY_NAME = new Lazy<NullDictionary<string, KTRCMP>>(() => this.ToNullDictionary(i => i.COMPANY_NAME));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTRCMP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTRCMP" /> fields for each CSV column header</returns>
        internal override Action<KTRCMP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTRCMP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COMPANY_ID":
                        mapper[i] = (e, v) => e.COMPANY_ID = int.Parse(v);
                        break;
                    case "COMPANY_CODE":
                        mapper[i] = (e, v) => e.COMPANY_CODE = v;
                        break;
                    case "COMPANY_NAME":
                        mapper[i] = (e, v) => e.COMPANY_NAME = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "PHONE":
                        mapper[i] = (e, v) => e.PHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KTRCMP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KTRCMP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KTRCMP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KTRCMP}"/> of entities</returns>
        internal override IEnumerable<KTRCMP> ApplyDeltaEntities(IEnumerable<KTRCMP> Entities, List<KTRCMP> DeltaEntities)
        {
            HashSet<string> Index_COMPANY_CODE = new HashSet<string>(DeltaEntities.Select(i => i.COMPANY_CODE));
            HashSet<int> Index_COMPANY_ID = new HashSet<int>(DeltaEntities.Select(i => i.COMPANY_ID));
            HashSet<string> Index_COMPANY_NAME = new HashSet<string>(DeltaEntities.Select(i => i.COMPANY_NAME));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.COMPANY_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_COMPANY_CODE.Remove(entity.COMPANY_CODE);
                            overwritten = overwritten || Index_COMPANY_ID.Remove(entity.COMPANY_ID);
                            overwritten = overwritten || Index_COMPANY_NAME.Remove(entity.COMPANY_NAME);
                            
                            if (entity.COMPANY_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, KTRCMP>> Index_COMPANY_CODE;
        private Lazy<Dictionary<int, KTRCMP>> Index_COMPANY_ID;
        private Lazy<NullDictionary<string, KTRCMP>> Index_COMPANY_NAME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_CODE(string COMPANY_CODE)
        {
            return Index_COMPANY_CODE.Value[COMPANY_CODE];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_CODE(string COMPANY_CODE, out KTRCMP Value)
        {
            return Index_COMPANY_CODE.Value.TryGetValue(COMPANY_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_CODE(string COMPANY_CODE)
        {
            KTRCMP value;
            if (Index_COMPANY_CODE.Value.TryGetValue(COMPANY_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_ID(int COMPANY_ID)
        {
            return Index_COMPANY_ID.Value[COMPANY_ID];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_ID(int COMPANY_ID, out KTRCMP Value)
        {
            return Index_COMPANY_ID.Value.TryGetValue(COMPANY_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_ID(int COMPANY_ID)
        {
            KTRCMP value;
            if (Index_COMPANY_ID.Value.TryGetValue(COMPANY_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_NAME(string COMPANY_NAME)
        {
            return Index_COMPANY_NAME.Value[COMPANY_NAME];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_NAME(string COMPANY_NAME, out KTRCMP Value)
        {
            return Index_COMPANY_NAME.Value.TryGetValue(COMPANY_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_NAME(string COMPANY_NAME)
        {
            KTRCMP value;
            if (Index_COMPANY_NAME.Value.TryGetValue(COMPANY_NAME, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KTRCMP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KTRCMP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KTRCMP](
        [COMPANY_ID] int NOT NULL,
        [COMPANY_CODE] varchar(20) NULL,
        [COMPANY_NAME] varchar(60) NULL,
        [CONTACT] varchar(30) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [PHONE] varchar(20) NULL,
        [MOBILE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [EMAIL] varchar(60) NULL,
        [NOTES] varchar(200) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        CONSTRAINT [KTRCMP_Index_COMPANY_ID] PRIMARY KEY CLUSTERED (
            [COMPANY_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KTRCMP_Index_COMPANY_CODE] ON [dbo].[KTRCMP]
    (
            [COMPANY_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [KTRCMP_Index_COMPANY_NAME] ON [dbo].[KTRCMP]
    (
            [COMPANY_NAME] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KTRCMP]') AND name = N'Index_COMPANY_CODE')
    ALTER INDEX [Index_COMPANY_CODE] ON [dbo].[KTRCMP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KTRCMP]') AND name = N'Index_COMPANY_NAME')
    ALTER INDEX [Index_COMPANY_NAME] ON [dbo].[KTRCMP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KTRCMP]') AND name = N'Index_COMPANY_CODE')
    ALTER INDEX [Index_COMPANY_CODE] ON [dbo].[KTRCMP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KTRCMP]') AND name = N'Index_COMPANY_NAME')
    ALTER INDEX [Index_COMPANY_NAME] ON [dbo].[KTRCMP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KTRCMP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KTRCMP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KTRCMP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_COMPANY_CODE = new List<string>();
            List<int> Index_COMPANY_ID = new List<int>();
            List<string> Index_COMPANY_NAME = new List<string>();

            foreach (var entity in Entities)
            {
                Index_COMPANY_CODE.Add(entity.COMPANY_CODE);
                Index_COMPANY_ID.Add(entity.COMPANY_ID);
                Index_COMPANY_NAME.Add(entity.COMPANY_NAME);
            }

            builder.AppendLine("DELETE [dbo].[KTRCMP] WHERE");


            // Index_COMPANY_CODE
            builder.Append("[COMPANY_CODE] IN (");
            for (int index = 0; index < Index_COMPANY_CODE.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // COMPANY_CODE
                var parameterCOMPANY_CODE = $"@p{parameterIndex++}";
                builder.Append(parameterCOMPANY_CODE);
                command.Parameters.Add(parameterCOMPANY_CODE, SqlDbType.VarChar, 20).Value = (object)Index_COMPANY_CODE[index] ?? DBNull.Value;
            }
            builder.AppendLine(") OR");

            // Index_COMPANY_ID
            builder.Append("[COMPANY_ID] IN (");
            for (int index = 0; index < Index_COMPANY_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // COMPANY_ID
                var parameterCOMPANY_ID = $"@p{parameterIndex++}";
                builder.Append(parameterCOMPANY_ID);
                command.Parameters.Add(parameterCOMPANY_ID, SqlDbType.Int).Value = Index_COMPANY_ID[index];
            }
            builder.AppendLine(") OR");

            // Index_COMPANY_NAME
            builder.Append("[COMPANY_NAME] IN (");
            for (int index = 0; index < Index_COMPANY_NAME.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // COMPANY_NAME
                var parameterCOMPANY_NAME = $"@p{parameterIndex++}";
                builder.Append(parameterCOMPANY_NAME);
                command.Parameters.Add(parameterCOMPANY_NAME, SqlDbType.VarChar, 60).Value = (object)Index_COMPANY_NAME[index] ?? DBNull.Value;
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KTRCMP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KTRCMP data set</returns>
        public override EduHubDataSetDataReader<KTRCMP> GetDataSetDataReader()
        {
            return new KTRCMPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KTRCMP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KTRCMP data set</returns>
        public override EduHubDataSetDataReader<KTRCMP> GetDataSetDataReader(List<KTRCMP> Entities)
        {
            return new KTRCMPDataReader(new EduHubDataSetLoadedReader<KTRCMP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KTRCMPDataReader : EduHubDataSetDataReader<KTRCMP>
        {
            public KTRCMPDataReader(IEduHubDataSetReader<KTRCMP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 16; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // COMPANY_ID
                        return Current.COMPANY_ID;
                    case 1: // COMPANY_CODE
                        return Current.COMPANY_CODE;
                    case 2: // COMPANY_NAME
                        return Current.COMPANY_NAME;
                    case 3: // CONTACT
                        return Current.CONTACT;
                    case 4: // ADDRESS01
                        return Current.ADDRESS01;
                    case 5: // ADDRESS02
                        return Current.ADDRESS02;
                    case 6: // ADDRESS03
                        return Current.ADDRESS03;
                    case 7: // STATE
                        return Current.STATE;
                    case 8: // POSTCODE
                        return Current.POSTCODE;
                    case 9: // PHONE
                        return Current.PHONE;
                    case 10: // MOBILE
                        return Current.MOBILE;
                    case 11: // FAX
                        return Current.FAX;
                    case 12: // EMAIL
                        return Current.EMAIL;
                    case 13: // NOTES
                        return Current.NOTES;
                    case 14: // LW_DATE
                        return Current.LW_DATE;
                    case 15: // LW_TIME
                        return Current.LW_TIME;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // COMPANY_CODE
                        return Current.COMPANY_CODE == null;
                    case 2: // COMPANY_NAME
                        return Current.COMPANY_NAME == null;
                    case 3: // CONTACT
                        return Current.CONTACT == null;
                    case 4: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 5: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 6: // ADDRESS03
                        return Current.ADDRESS03 == null;
                    case 7: // STATE
                        return Current.STATE == null;
                    case 8: // POSTCODE
                        return Current.POSTCODE == null;
                    case 9: // PHONE
                        return Current.PHONE == null;
                    case 10: // MOBILE
                        return Current.MOBILE == null;
                    case 11: // FAX
                        return Current.FAX == null;
                    case 12: // EMAIL
                        return Current.EMAIL == null;
                    case 13: // NOTES
                        return Current.NOTES == null;
                    case 14: // LW_DATE
                        return Current.LW_DATE == null;
                    case 15: // LW_TIME
                        return Current.LW_TIME == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // COMPANY_ID
                        return "COMPANY_ID";
                    case 1: // COMPANY_CODE
                        return "COMPANY_CODE";
                    case 2: // COMPANY_NAME
                        return "COMPANY_NAME";
                    case 3: // CONTACT
                        return "CONTACT";
                    case 4: // ADDRESS01
                        return "ADDRESS01";
                    case 5: // ADDRESS02
                        return "ADDRESS02";
                    case 6: // ADDRESS03
                        return "ADDRESS03";
                    case 7: // STATE
                        return "STATE";
                    case 8: // POSTCODE
                        return "POSTCODE";
                    case 9: // PHONE
                        return "PHONE";
                    case 10: // MOBILE
                        return "MOBILE";
                    case 11: // FAX
                        return "FAX";
                    case 12: // EMAIL
                        return "EMAIL";
                    case 13: // NOTES
                        return "NOTES";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "COMPANY_ID":
                        return 0;
                    case "COMPANY_CODE":
                        return 1;
                    case "COMPANY_NAME":
                        return 2;
                    case "CONTACT":
                        return 3;
                    case "ADDRESS01":
                        return 4;
                    case "ADDRESS02":
                        return 5;
                    case "ADDRESS03":
                        return 6;
                    case "STATE":
                        return 7;
                    case "POSTCODE":
                        return 8;
                    case "PHONE":
                        return 9;
                    case "MOBILE":
                        return 10;
                    case "FAX":
                        return 11;
                    case "EMAIL":
                        return 12;
                    case "NOTES":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
