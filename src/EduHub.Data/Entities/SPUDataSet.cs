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
    /// Publications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPUDataSet : EduHubDataSet<SPU>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPU"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPUDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_HOME_LANGUAGE = new Lazy<NullDictionary<string, IReadOnlyList<SPU>>>(() => this.ToGroupedNullDictionary(i => i.HOME_LANGUAGE));
            Index_MAILING_LIST = new Lazy<NullDictionary<string, IReadOnlyList<SPU>>>(() => this.ToGroupedNullDictionary(i => i.MAILING_LIST));
            Index_SPUKEY = new Lazy<Dictionary<string, SPU>>(() => this.ToDictionary(i => i.SPUKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPU" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPU" /> fields for each CSV column header</returns>
        internal override Action<SPU, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPU, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPUKEY":
                        mapper[i] = (e, v) => e.SPUKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TARGET":
                        mapper[i] = (e, v) => e.TARGET = v;
                        break;
                    case "LANGUAGE_INDICATOR":
                        mapper[i] = (e, v) => e.LANGUAGE_INDICATOR = v;
                        break;
                    case "MAILING_MECHANISM":
                        mapper[i] = (e, v) => e.MAILING_MECHANISM = v;
                        break;
                    case "PUBLICATION_TYPE":
                        mapper[i] = (e, v) => e.PUBLICATION_TYPE = v;
                        break;
                    case "ADDRESS_COMMENT":
                        mapper[i] = (e, v) => e.ADDRESS_COMMENT = v;
                        break;
                    case "STUDENT_SPECIFIC":
                        mapper[i] = (e, v) => e.STUDENT_SPECIFIC = v;
                        break;
                    case "MAILING_LIST":
                        mapper[i] = (e, v) => e.MAILING_LIST = v;
                        break;
                    case "ACTUAL_ELIGIBLE_MEMBERS":
                        mapper[i] = (e, v) => e.ACTUAL_ELIGIBLE_MEMBERS = v;
                        break;
                    case "HOME_LANGUAGE":
                        mapper[i] = (e, v) => e.HOME_LANGUAGE = v;
                        break;
                    case "PRIMARY_SORT":
                        mapper[i] = (e, v) => e.PRIMARY_SORT = v;
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
        /// Merges <see cref="SPU" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPU" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPU" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPU}"/> of entities</returns>
        internal override IEnumerable<SPU> ApplyDeltaEntities(IEnumerable<SPU> Entities, List<SPU> DeltaEntities)
        {
            HashSet<string> Index_SPUKEY = new HashSet<string>(DeltaEntities.Select(i => i.SPUKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SPUKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SPUKEY.Remove(entity.SPUKEY);
                            
                            if (entity.SPUKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SPU>>> Index_HOME_LANGUAGE;
        private Lazy<NullDictionary<string, IReadOnlyList<SPU>>> Index_MAILING_LIST;
        private Lazy<Dictionary<string, SPU>> Index_SPUKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPU by HOME_LANGUAGE field
        /// </summary>
        /// <param name="HOME_LANGUAGE">HOME_LANGUAGE value used to find SPU</param>
        /// <returns>List of related SPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPU> FindByHOME_LANGUAGE(string HOME_LANGUAGE)
        {
            return Index_HOME_LANGUAGE.Value[HOME_LANGUAGE];
        }

        /// <summary>
        /// Attempt to find SPU by HOME_LANGUAGE field
        /// </summary>
        /// <param name="HOME_LANGUAGE">HOME_LANGUAGE value used to find SPU</param>
        /// <param name="Value">List of related SPU entities</param>
        /// <returns>True if the list of related SPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_LANGUAGE(string HOME_LANGUAGE, out IReadOnlyList<SPU> Value)
        {
            return Index_HOME_LANGUAGE.Value.TryGetValue(HOME_LANGUAGE, out Value);
        }

        /// <summary>
        /// Attempt to find SPU by HOME_LANGUAGE field
        /// </summary>
        /// <param name="HOME_LANGUAGE">HOME_LANGUAGE value used to find SPU</param>
        /// <returns>List of related SPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPU> TryFindByHOME_LANGUAGE(string HOME_LANGUAGE)
        {
            IReadOnlyList<SPU> value;
            if (Index_HOME_LANGUAGE.Value.TryGetValue(HOME_LANGUAGE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPU by MAILING_LIST field
        /// </summary>
        /// <param name="MAILING_LIST">MAILING_LIST value used to find SPU</param>
        /// <returns>List of related SPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPU> FindByMAILING_LIST(string MAILING_LIST)
        {
            return Index_MAILING_LIST.Value[MAILING_LIST];
        }

        /// <summary>
        /// Attempt to find SPU by MAILING_LIST field
        /// </summary>
        /// <param name="MAILING_LIST">MAILING_LIST value used to find SPU</param>
        /// <param name="Value">List of related SPU entities</param>
        /// <returns>True if the list of related SPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILING_LIST(string MAILING_LIST, out IReadOnlyList<SPU> Value)
        {
            return Index_MAILING_LIST.Value.TryGetValue(MAILING_LIST, out Value);
        }

        /// <summary>
        /// Attempt to find SPU by MAILING_LIST field
        /// </summary>
        /// <param name="MAILING_LIST">MAILING_LIST value used to find SPU</param>
        /// <returns>List of related SPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPU> TryFindByMAILING_LIST(string MAILING_LIST)
        {
            IReadOnlyList<SPU> value;
            if (Index_MAILING_LIST.Value.TryGetValue(MAILING_LIST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPU by SPUKEY field
        /// </summary>
        /// <param name="SPUKEY">SPUKEY value used to find SPU</param>
        /// <returns>Related SPU entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPU FindBySPUKEY(string SPUKEY)
        {
            return Index_SPUKEY.Value[SPUKEY];
        }

        /// <summary>
        /// Attempt to find SPU by SPUKEY field
        /// </summary>
        /// <param name="SPUKEY">SPUKEY value used to find SPU</param>
        /// <param name="Value">Related SPU entity</param>
        /// <returns>True if the related SPU entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPUKEY(string SPUKEY, out SPU Value)
        {
            return Index_SPUKEY.Value.TryGetValue(SPUKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPU by SPUKEY field
        /// </summary>
        /// <param name="SPUKEY">SPUKEY value used to find SPU</param>
        /// <returns>Related SPU entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPU TryFindBySPUKEY(string SPUKEY)
        {
            SPU value;
            if (Index_SPUKEY.Value.TryGetValue(SPUKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPU table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPU]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPU](
        [SPUKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [DESCRIPTION] varchar(MAX) NULL,
        [TARGET] varchar(1) NULL,
        [LANGUAGE_INDICATOR] varchar(1) NULL,
        [MAILING_MECHANISM] varchar(1) NULL,
        [PUBLICATION_TYPE] varchar(1) NULL,
        [ADDRESS_COMMENT] varchar(40) NULL,
        [STUDENT_SPECIFIC] varchar(1) NULL,
        [MAILING_LIST] varchar(12) NULL,
        [ACTUAL_ELIGIBLE_MEMBERS] varchar(1) NULL,
        [HOME_LANGUAGE] varchar(7) NULL,
        [PRIMARY_SORT] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPU_Index_SPUKEY] PRIMARY KEY CLUSTERED (
            [SPUKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SPU_Index_HOME_LANGUAGE] ON [dbo].[SPU]
    (
            [HOME_LANGUAGE] ASC
    );
    CREATE NONCLUSTERED INDEX [SPU_Index_MAILING_LIST] ON [dbo].[SPU]
    (
            [MAILING_LIST] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPU]') AND name = N'SPU_Index_HOME_LANGUAGE')
    ALTER INDEX [SPU_Index_HOME_LANGUAGE] ON [dbo].[SPU] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPU]') AND name = N'SPU_Index_MAILING_LIST')
    ALTER INDEX [SPU_Index_MAILING_LIST] ON [dbo].[SPU] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPU]') AND name = N'SPU_Index_HOME_LANGUAGE')
    ALTER INDEX [SPU_Index_HOME_LANGUAGE] ON [dbo].[SPU] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPU]') AND name = N'SPU_Index_MAILING_LIST')
    ALTER INDEX [SPU_Index_MAILING_LIST] ON [dbo].[SPU] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPU"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPU"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPU> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SPUKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SPUKEY.Add(entity.SPUKEY);
            }

            builder.AppendLine("DELETE [dbo].[SPU] WHERE");


            // Index_SPUKEY
            builder.Append("[SPUKEY] IN (");
            for (int index = 0; index < Index_SPUKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SPUKEY
                var parameterSPUKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSPUKEY);
                command.Parameters.Add(parameterSPUKEY, SqlDbType.VarChar, 10).Value = Index_SPUKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPU data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPU data set</returns>
        public override EduHubDataSetDataReader<SPU> GetDataSetDataReader()
        {
            return new SPUDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPU data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPU data set</returns>
        public override EduHubDataSetDataReader<SPU> GetDataSetDataReader(List<SPU> Entities)
        {
            return new SPUDataReader(new EduHubDataSetLoadedReader<SPU>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPUDataReader : EduHubDataSetDataReader<SPU>
        {
            public SPUDataReader(IEduHubDataSetReader<SPU> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 16; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SPUKEY
                        return Current.SPUKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 3: // TARGET
                        return Current.TARGET;
                    case 4: // LANGUAGE_INDICATOR
                        return Current.LANGUAGE_INDICATOR;
                    case 5: // MAILING_MECHANISM
                        return Current.MAILING_MECHANISM;
                    case 6: // PUBLICATION_TYPE
                        return Current.PUBLICATION_TYPE;
                    case 7: // ADDRESS_COMMENT
                        return Current.ADDRESS_COMMENT;
                    case 8: // STUDENT_SPECIFIC
                        return Current.STUDENT_SPECIFIC;
                    case 9: // MAILING_LIST
                        return Current.MAILING_LIST;
                    case 10: // ACTUAL_ELIGIBLE_MEMBERS
                        return Current.ACTUAL_ELIGIBLE_MEMBERS;
                    case 11: // HOME_LANGUAGE
                        return Current.HOME_LANGUAGE;
                    case 12: // PRIMARY_SORT
                        return Current.PRIMARY_SORT;
                    case 13: // LW_DATE
                        return Current.LW_DATE;
                    case 14: // LW_TIME
                        return Current.LW_TIME;
                    case 15: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 3: // TARGET
                        return Current.TARGET == null;
                    case 4: // LANGUAGE_INDICATOR
                        return Current.LANGUAGE_INDICATOR == null;
                    case 5: // MAILING_MECHANISM
                        return Current.MAILING_MECHANISM == null;
                    case 6: // PUBLICATION_TYPE
                        return Current.PUBLICATION_TYPE == null;
                    case 7: // ADDRESS_COMMENT
                        return Current.ADDRESS_COMMENT == null;
                    case 8: // STUDENT_SPECIFIC
                        return Current.STUDENT_SPECIFIC == null;
                    case 9: // MAILING_LIST
                        return Current.MAILING_LIST == null;
                    case 10: // ACTUAL_ELIGIBLE_MEMBERS
                        return Current.ACTUAL_ELIGIBLE_MEMBERS == null;
                    case 11: // HOME_LANGUAGE
                        return Current.HOME_LANGUAGE == null;
                    case 12: // PRIMARY_SORT
                        return Current.PRIMARY_SORT == null;
                    case 13: // LW_DATE
                        return Current.LW_DATE == null;
                    case 14: // LW_TIME
                        return Current.LW_TIME == null;
                    case 15: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SPUKEY
                        return "SPUKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // DESCRIPTION
                        return "DESCRIPTION";
                    case 3: // TARGET
                        return "TARGET";
                    case 4: // LANGUAGE_INDICATOR
                        return "LANGUAGE_INDICATOR";
                    case 5: // MAILING_MECHANISM
                        return "MAILING_MECHANISM";
                    case 6: // PUBLICATION_TYPE
                        return "PUBLICATION_TYPE";
                    case 7: // ADDRESS_COMMENT
                        return "ADDRESS_COMMENT";
                    case 8: // STUDENT_SPECIFIC
                        return "STUDENT_SPECIFIC";
                    case 9: // MAILING_LIST
                        return "MAILING_LIST";
                    case 10: // ACTUAL_ELIGIBLE_MEMBERS
                        return "ACTUAL_ELIGIBLE_MEMBERS";
                    case 11: // HOME_LANGUAGE
                        return "HOME_LANGUAGE";
                    case 12: // PRIMARY_SORT
                        return "PRIMARY_SORT";
                    case 13: // LW_DATE
                        return "LW_DATE";
                    case 14: // LW_TIME
                        return "LW_TIME";
                    case 15: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SPUKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "DESCRIPTION":
                        return 2;
                    case "TARGET":
                        return 3;
                    case "LANGUAGE_INDICATOR":
                        return 4;
                    case "MAILING_MECHANISM":
                        return 5;
                    case "PUBLICATION_TYPE":
                        return 6;
                    case "ADDRESS_COMMENT":
                        return 7;
                    case "STUDENT_SPECIFIC":
                        return 8;
                    case "MAILING_LIST":
                        return 9;
                    case "ACTUAL_ELIGIBLE_MEMBERS":
                        return 10;
                    case "HOME_LANGUAGE":
                        return 11;
                    case "PRIMARY_SORT":
                        return 12;
                    case "LW_DATE":
                        return 13;
                    case "LW_TIME":
                        return 14;
                    case "LW_USER":
                        return 15;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
