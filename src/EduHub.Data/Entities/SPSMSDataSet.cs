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
    /// SMS messages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPSMSDataSet : EduHubDataSet<SPSMS>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPSMS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPSMSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_REPLY_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SPSMS>>>(() => this.ToGroupedNullDictionary(i => i.REPLY_CODE));
            Index_SPSMSKEY = new Lazy<Dictionary<int, SPSMS>>(() => this.ToDictionary(i => i.SPSMSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPSMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPSMS" /> fields for each CSV column header</returns>
        internal override Action<SPSMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPSMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPSMSKEY":
                        mapper[i] = (e, v) => e.SPSMSKEY = int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "CREATED_DATE":
                        mapper[i] = (e, v) => e.CREATED_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CREATED_BY":
                        mapper[i] = (e, v) => e.CREATED_BY = v;
                        break;
                    case "NOTIFY_REPLIES":
                        mapper[i] = (e, v) => e.NOTIFY_REPLIES = v;
                        break;
                    case "AUTO_MESSAGE":
                        mapper[i] = (e, v) => e.AUTO_MESSAGE = v;
                        break;
                    case "EMERGENCY":
                        mapper[i] = (e, v) => e.EMERGENCY = v;
                        break;
                    case "REPLY_CODE":
                        mapper[i] = (e, v) => e.REPLY_CODE = v;
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
        /// Merges <see cref="SPSMS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPSMS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPSMS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPSMS}"/> of entities</returns>
        internal override IEnumerable<SPSMS> ApplyDeltaEntities(IEnumerable<SPSMS> Entities, List<SPSMS> DeltaEntities)
        {
            HashSet<int> Index_SPSMSKEY = new HashSet<int>(DeltaEntities.Select(i => i.SPSMSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SPSMSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SPSMSKEY.Remove(entity.SPSMSKEY);
                            
                            if (entity.SPSMSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SPSMS>>> Index_REPLY_CODE;
        private Lazy<Dictionary<int, SPSMS>> Index_SPSMSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPSMS by REPLY_CODE field
        /// </summary>
        /// <param name="REPLY_CODE">REPLY_CODE value used to find SPSMS</param>
        /// <returns>List of related SPSMS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPSMS> FindByREPLY_CODE(string REPLY_CODE)
        {
            return Index_REPLY_CODE.Value[REPLY_CODE];
        }

        /// <summary>
        /// Attempt to find SPSMS by REPLY_CODE field
        /// </summary>
        /// <param name="REPLY_CODE">REPLY_CODE value used to find SPSMS</param>
        /// <param name="Value">List of related SPSMS entities</param>
        /// <returns>True if the list of related SPSMS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREPLY_CODE(string REPLY_CODE, out IReadOnlyList<SPSMS> Value)
        {
            return Index_REPLY_CODE.Value.TryGetValue(REPLY_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPSMS by REPLY_CODE field
        /// </summary>
        /// <param name="REPLY_CODE">REPLY_CODE value used to find SPSMS</param>
        /// <returns>List of related SPSMS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPSMS> TryFindByREPLY_CODE(string REPLY_CODE)
        {
            IReadOnlyList<SPSMS> value;
            if (Index_REPLY_CODE.Value.TryGetValue(REPLY_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPSMS FindBySPSMSKEY(int SPSMSKEY)
        {
            return Index_SPSMSKEY.Value[SPSMSKEY];
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <param name="Value">Related SPSMS entity</param>
        /// <returns>True if the related SPSMS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPSMSKEY(int SPSMSKEY, out SPSMS Value)
        {
            return Index_SPSMSKEY.Value.TryGetValue(SPSMSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPSMS TryFindBySPSMSKEY(int SPSMSKEY)
        {
            SPSMS value;
            if (Index_SPSMSKEY.Value.TryGetValue(SPSMSKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPSMS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPSMS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPSMS](
        [SPSMSKEY] int IDENTITY NOT NULL,
        [MESSAGE] varchar(160) NULL,
        [CREATED_DATE] datetime NULL,
        [CREATED_BY] varchar(128) NULL,
        [NOTIFY_REPLIES] varchar(1) NULL,
        [AUTO_MESSAGE] varchar(1) NULL,
        [EMERGENCY] varchar(1) NULL,
        [REPLY_CODE] varchar(15) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPSMS_Index_SPSMSKEY] PRIMARY KEY CLUSTERED (
            [SPSMSKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SPSMS_Index_REPLY_CODE] ON [dbo].[SPSMS]
    (
            [REPLY_CODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPSMS]') AND name = N'Index_REPLY_CODE')
    ALTER INDEX [Index_REPLY_CODE] ON [dbo].[SPSMS] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPSMS]') AND name = N'Index_REPLY_CODE')
    ALTER INDEX [Index_REPLY_CODE] ON [dbo].[SPSMS] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPSMS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPSMS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPSMS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SPSMSKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SPSMSKEY.Add(entity.SPSMSKEY);
            }

            builder.AppendLine("DELETE [dbo].[SPSMS] WHERE");


            // Index_SPSMSKEY
            builder.Append("[SPSMSKEY] IN (");
            for (int index = 0; index < Index_SPSMSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SPSMSKEY
                var parameterSPSMSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSPSMSKEY);
                command.Parameters.Add(parameterSPSMSKEY, SqlDbType.Int).Value = Index_SPSMSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPSMS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPSMS data set</returns>
        public override EduHubDataSetDataReader<SPSMS> GetDataSetDataReader()
        {
            return new SPSMSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPSMS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPSMS data set</returns>
        public override EduHubDataSetDataReader<SPSMS> GetDataSetDataReader(List<SPSMS> Entities)
        {
            return new SPSMSDataReader(new EduHubDataSetLoadedReader<SPSMS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPSMSDataReader : EduHubDataSetDataReader<SPSMS>
        {
            public SPSMSDataReader(IEduHubDataSetReader<SPSMS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SPSMSKEY
                        return Current.SPSMSKEY;
                    case 1: // MESSAGE
                        return Current.MESSAGE;
                    case 2: // CREATED_DATE
                        return Current.CREATED_DATE;
                    case 3: // CREATED_BY
                        return Current.CREATED_BY;
                    case 4: // NOTIFY_REPLIES
                        return Current.NOTIFY_REPLIES;
                    case 5: // AUTO_MESSAGE
                        return Current.AUTO_MESSAGE;
                    case 6: // EMERGENCY
                        return Current.EMERGENCY;
                    case 7: // REPLY_CODE
                        return Current.REPLY_CODE;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // MESSAGE
                        return Current.MESSAGE == null;
                    case 2: // CREATED_DATE
                        return Current.CREATED_DATE == null;
                    case 3: // CREATED_BY
                        return Current.CREATED_BY == null;
                    case 4: // NOTIFY_REPLIES
                        return Current.NOTIFY_REPLIES == null;
                    case 5: // AUTO_MESSAGE
                        return Current.AUTO_MESSAGE == null;
                    case 6: // EMERGENCY
                        return Current.EMERGENCY == null;
                    case 7: // REPLY_CODE
                        return Current.REPLY_CODE == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
                    case 10: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SPSMSKEY
                        return "SPSMSKEY";
                    case 1: // MESSAGE
                        return "MESSAGE";
                    case 2: // CREATED_DATE
                        return "CREATED_DATE";
                    case 3: // CREATED_BY
                        return "CREATED_BY";
                    case 4: // NOTIFY_REPLIES
                        return "NOTIFY_REPLIES";
                    case 5: // AUTO_MESSAGE
                        return "AUTO_MESSAGE";
                    case 6: // EMERGENCY
                        return "EMERGENCY";
                    case 7: // REPLY_CODE
                        return "REPLY_CODE";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SPSMSKEY":
                        return 0;
                    case "MESSAGE":
                        return 1;
                    case "CREATED_DATE":
                        return 2;
                    case "CREATED_BY":
                        return 3;
                    case "NOTIFY_REPLIES":
                        return 4;
                    case "AUTO_MESSAGE":
                        return 5;
                    case "EMERGENCY":
                        return 6;
                    case "REPLY_CODE":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
