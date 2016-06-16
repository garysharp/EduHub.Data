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
    /// Report email templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPEMAILDataSet : EduHubDataSet<SPEMAIL>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPEMAIL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPEMAILDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_REPORT = new Lazy<NullDictionary<string, IReadOnlyList<SPEMAIL>>>(() => this.ToGroupedNullDictionary(i => i.REPORT));
            Index_SPEMAILKEY = new Lazy<Dictionary<string, SPEMAIL>>(() => this.ToDictionary(i => i.SPEMAILKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPEMAIL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPEMAIL" /> fields for each CSV column header</returns>
        internal override Action<SPEMAIL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPEMAIL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPEMAILKEY":
                        mapper[i] = (e, v) => e.SPEMAILKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "REPORT":
                        mapper[i] = (e, v) => e.REPORT = v;
                        break;
                    case "PRINT_PATH":
                        mapper[i] = (e, v) => e.PRINT_PATH = v;
                        break;
                    case "IMPORTANCE":
                        mapper[i] = (e, v) => e.IMPORTANCE = v;
                        break;
                    case "SEND_OPTION":
                        mapper[i] = (e, v) => e.SEND_OPTION = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "EMAIL_HTML":
                        mapper[i] = (e, v) => e.EMAIL_HTML = v;
                        break;
                    case "HTML_MESSAGE":
                        mapper[i] = (e, v) => e.HTML_MESSAGE = v;
                        break;
                    case "FROM_ADDRESS":
                        mapper[i] = (e, v) => e.FROM_ADDRESS = v;
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
        /// Merges <see cref="SPEMAIL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPEMAIL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPEMAIL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPEMAIL}"/> of entities</returns>
        internal override IEnumerable<SPEMAIL> ApplyDeltaEntities(IEnumerable<SPEMAIL> Entities, List<SPEMAIL> DeltaEntities)
        {
            HashSet<string> Index_SPEMAILKEY = new HashSet<string>(DeltaEntities.Select(i => i.SPEMAILKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SPEMAILKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SPEMAILKEY.Remove(entity.SPEMAILKEY);
                            
                            if (entity.SPEMAILKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SPEMAIL>>> Index_REPORT;
        private Lazy<Dictionary<string, SPEMAIL>> Index_SPEMAILKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <returns>List of related SPEMAIL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEMAIL> FindByREPORT(string REPORT)
        {
            return Index_REPORT.Value[REPORT];
        }

        /// <summary>
        /// Attempt to find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <param name="Value">List of related SPEMAIL entities</param>
        /// <returns>True if the list of related SPEMAIL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREPORT(string REPORT, out IReadOnlyList<SPEMAIL> Value)
        {
            return Index_REPORT.Value.TryGetValue(REPORT, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMAIL by REPORT field
        /// </summary>
        /// <param name="REPORT">REPORT value used to find SPEMAIL</param>
        /// <returns>List of related SPEMAIL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEMAIL> TryFindByREPORT(string REPORT)
        {
            IReadOnlyList<SPEMAIL> value;
            if (Index_REPORT.Value.TryGetValue(REPORT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <returns>Related SPEMAIL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEMAIL FindBySPEMAILKEY(string SPEMAILKEY)
        {
            return Index_SPEMAILKEY.Value[SPEMAILKEY];
        }

        /// <summary>
        /// Attempt to find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <param name="Value">Related SPEMAIL entity</param>
        /// <returns>True if the related SPEMAIL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPEMAILKEY(string SPEMAILKEY, out SPEMAIL Value)
        {
            return Index_SPEMAILKEY.Value.TryGetValue(SPEMAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMAIL by SPEMAILKEY field
        /// </summary>
        /// <param name="SPEMAILKEY">SPEMAILKEY value used to find SPEMAIL</param>
        /// <returns>Related SPEMAIL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEMAIL TryFindBySPEMAILKEY(string SPEMAILKEY)
        {
            SPEMAIL value;
            if (Index_SPEMAILKEY.Value.TryGetValue(SPEMAILKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPEMAIL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPEMAIL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPEMAIL](
        [SPEMAILKEY] varchar(15) NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [REPORT] varchar(10) NULL,
        [PRINT_PATH] varchar(128) NULL,
        [IMPORTANCE] varchar(6) NULL,
        [SEND_OPTION] varchar(15) NULL,
        [EMAIL_SUBJECT] varchar(70) NULL,
        [EMAIL_MESSAGE] text NULL,
        [EMAIL_HTML] varchar(128) NULL,
        [HTML_MESSAGE] varchar(1) NULL,
        [FROM_ADDRESS] varchar(128) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPEMAIL_Index_SPEMAILKEY] PRIMARY KEY CLUSTERED (
            [SPEMAILKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SPEMAIL_Index_REPORT] ON [dbo].[SPEMAIL]
    (
            [REPORT] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPEMAIL]') AND name = N'Index_REPORT')
    ALTER INDEX [Index_REPORT] ON [dbo].[SPEMAIL] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPEMAIL]') AND name = N'Index_REPORT')
    ALTER INDEX [Index_REPORT] ON [dbo].[SPEMAIL] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPEMAIL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPEMAIL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPEMAIL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SPEMAILKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SPEMAILKEY.Add(entity.SPEMAILKEY);
            }

            builder.AppendLine("DELETE [dbo].[SPEMAIL] WHERE");


            // Index_SPEMAILKEY
            builder.Append("[SPEMAILKEY] IN (");
            for (int index = 0; index < Index_SPEMAILKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SPEMAILKEY
                var parameterSPEMAILKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSPEMAILKEY);
                command.Parameters.Add(parameterSPEMAILKEY, SqlDbType.VarChar, 15).Value = Index_SPEMAILKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPEMAIL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPEMAIL data set</returns>
        public override EduHubDataSetDataReader<SPEMAIL> GetDataSetDataReader()
        {
            return new SPEMAILDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPEMAIL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPEMAIL data set</returns>
        public override EduHubDataSetDataReader<SPEMAIL> GetDataSetDataReader(List<SPEMAIL> Entities)
        {
            return new SPEMAILDataReader(new EduHubDataSetLoadedReader<SPEMAIL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPEMAILDataReader : EduHubDataSetDataReader<SPEMAIL>
        {
            public SPEMAILDataReader(IEduHubDataSetReader<SPEMAIL> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SPEMAILKEY
                        return Current.SPEMAILKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // REPORT
                        return Current.REPORT;
                    case 3: // PRINT_PATH
                        return Current.PRINT_PATH;
                    case 4: // IMPORTANCE
                        return Current.IMPORTANCE;
                    case 5: // SEND_OPTION
                        return Current.SEND_OPTION;
                    case 6: // EMAIL_SUBJECT
                        return Current.EMAIL_SUBJECT;
                    case 7: // EMAIL_MESSAGE
                        return Current.EMAIL_MESSAGE;
                    case 8: // EMAIL_HTML
                        return Current.EMAIL_HTML;
                    case 9: // HTML_MESSAGE
                        return Current.HTML_MESSAGE;
                    case 10: // FROM_ADDRESS
                        return Current.FROM_ADDRESS;
                    case 11: // LW_DATE
                        return Current.LW_DATE;
                    case 12: // LW_TIME
                        return Current.LW_TIME;
                    case 13: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // REPORT
                        return Current.REPORT == null;
                    case 3: // PRINT_PATH
                        return Current.PRINT_PATH == null;
                    case 4: // IMPORTANCE
                        return Current.IMPORTANCE == null;
                    case 5: // SEND_OPTION
                        return Current.SEND_OPTION == null;
                    case 6: // EMAIL_SUBJECT
                        return Current.EMAIL_SUBJECT == null;
                    case 7: // EMAIL_MESSAGE
                        return Current.EMAIL_MESSAGE == null;
                    case 8: // EMAIL_HTML
                        return Current.EMAIL_HTML == null;
                    case 9: // HTML_MESSAGE
                        return Current.HTML_MESSAGE == null;
                    case 10: // FROM_ADDRESS
                        return Current.FROM_ADDRESS == null;
                    case 11: // LW_DATE
                        return Current.LW_DATE == null;
                    case 12: // LW_TIME
                        return Current.LW_TIME == null;
                    case 13: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SPEMAILKEY
                        return "SPEMAILKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // REPORT
                        return "REPORT";
                    case 3: // PRINT_PATH
                        return "PRINT_PATH";
                    case 4: // IMPORTANCE
                        return "IMPORTANCE";
                    case 5: // SEND_OPTION
                        return "SEND_OPTION";
                    case 6: // EMAIL_SUBJECT
                        return "EMAIL_SUBJECT";
                    case 7: // EMAIL_MESSAGE
                        return "EMAIL_MESSAGE";
                    case 8: // EMAIL_HTML
                        return "EMAIL_HTML";
                    case 9: // HTML_MESSAGE
                        return "HTML_MESSAGE";
                    case 10: // FROM_ADDRESS
                        return "FROM_ADDRESS";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SPEMAILKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "REPORT":
                        return 2;
                    case "PRINT_PATH":
                        return 3;
                    case "IMPORTANCE":
                        return 4;
                    case "SEND_OPTION":
                        return 5;
                    case "EMAIL_SUBJECT":
                        return 6;
                    case "EMAIL_MESSAGE":
                        return 7;
                    case "EMAIL_HTML":
                        return 8;
                    case "HTML_MESSAGE":
                        return 9;
                    case "FROM_ADDRESS":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
