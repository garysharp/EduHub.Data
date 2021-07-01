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
    /// Report file audit Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPEPRINTDataSet : EduHubDataSet<SPEPRINT>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPEPRINT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPEPRINTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<SPEPRINT>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPEPRINT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPEPRINT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPEPRINT" /> fields for each CSV column header</returns>
        internal override Action<SPEPRINT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPEPRINT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PRINT_DATE":
                        mapper[i] = (e, v) => e.PRINT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PRINT_BY":
                        mapper[i] = (e, v) => e.PRINT_BY = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SEND_BY":
                        mapper[i] = (e, v) => e.SEND_BY = v;
                        break;
                    case "ENTITY_TABLE":
                        mapper[i] = (e, v) => e.ENTITY_TABLE = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
                        break;
                    case "COPY_ADDRESS":
                        mapper[i] = (e, v) => e.COPY_ADDRESS = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "ATTACHMENT_PATH":
                        mapper[i] = (e, v) => e.ATTACHMENT_PATH = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "DISPLAY":
                        mapper[i] = (e, v) => e.DISPLAY = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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
        /// Merges <see cref="SPEPRINT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPEPRINT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPEPRINT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPEPRINT}"/> of entities</returns>
        internal override IEnumerable<SPEPRINT> ApplyDeltaEntities(IEnumerable<SPEPRINT> Entities, List<SPEPRINT> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SPEPRINT>>> Index_CODE;
        private Lazy<Dictionary<int, SPEPRINT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <returns>List of related SPEPRINT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEPRINT> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <param name="Value">List of related SPEPRINT entities</param>
        /// <returns>True if the list of related SPEPRINT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<SPEPRINT> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <returns>List of related SPEPRINT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEPRINT> TryFindByCODE(string CODE)
        {
            IReadOnlyList<SPEPRINT> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <returns>Related SPEPRINT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEPRINT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <param name="Value">Related SPEPRINT entity</param>
        /// <returns>True if the related SPEPRINT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPEPRINT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <returns>Related SPEPRINT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEPRINT TryFindByTID(int TID)
        {
            SPEPRINT value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPEPRINT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPEPRINT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPEPRINT](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(15) NOT NULL,
        [PRINT_DATE] datetime NULL,
        [PRINT_BY] varchar(128) NULL,
        [SEND_DATE] datetime NULL,
        [SEND_BY] varchar(128) NULL,
        [ENTITY_TABLE] varchar(8) NULL,
        [ENTITY_KEY] varchar(20) NULL,
        [EMAIL_ADDRESS] varchar(60) NULL,
        [COPY_ADDRESS] varchar(60) NULL,
        [EMAIL_SUBJECT] varchar(100) NULL,
        [EMAIL_MESSAGE] varchar(MAX) NULL,
        [ATTACHMENT_PATH] varchar(255) NULL,
        [STATUS] varchar(30) NULL,
        [DISPLAY] varchar(1) NULL,
        [COMMENTS] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPEPRINT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SPEPRINT_Index_CODE] ON [dbo].[SPEPRINT]
    (
            [CODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPEPRINT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SPEPRINT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPEPRINT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SPEPRINT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPEPRINT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPEPRINT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPEPRINT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SPEPRINT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SPEPRINT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPEPRINT data set</returns>
        public override EduHubDataSetDataReader<SPEPRINT> GetDataSetDataReader()
        {
            return new SPEPRINTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPEPRINT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPEPRINT data set</returns>
        public override EduHubDataSetDataReader<SPEPRINT> GetDataSetDataReader(List<SPEPRINT> Entities)
        {
            return new SPEPRINTDataReader(new EduHubDataSetLoadedReader<SPEPRINT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPEPRINTDataReader : EduHubDataSetDataReader<SPEPRINT>
        {
            public SPEPRINTDataReader(IEduHubDataSetReader<SPEPRINT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 19; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // PRINT_DATE
                        return Current.PRINT_DATE;
                    case 3: // PRINT_BY
                        return Current.PRINT_BY;
                    case 4: // SEND_DATE
                        return Current.SEND_DATE;
                    case 5: // SEND_BY
                        return Current.SEND_BY;
                    case 6: // ENTITY_TABLE
                        return Current.ENTITY_TABLE;
                    case 7: // ENTITY_KEY
                        return Current.ENTITY_KEY;
                    case 8: // EMAIL_ADDRESS
                        return Current.EMAIL_ADDRESS;
                    case 9: // COPY_ADDRESS
                        return Current.COPY_ADDRESS;
                    case 10: // EMAIL_SUBJECT
                        return Current.EMAIL_SUBJECT;
                    case 11: // EMAIL_MESSAGE
                        return Current.EMAIL_MESSAGE;
                    case 12: // ATTACHMENT_PATH
                        return Current.ATTACHMENT_PATH;
                    case 13: // STATUS
                        return Current.STATUS;
                    case 14: // DISPLAY
                        return Current.DISPLAY;
                    case 15: // COMMENTS
                        return Current.COMMENTS;
                    case 16: // LW_DATE
                        return Current.LW_DATE;
                    case 17: // LW_TIME
                        return Current.LW_TIME;
                    case 18: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PRINT_DATE
                        return Current.PRINT_DATE == null;
                    case 3: // PRINT_BY
                        return Current.PRINT_BY == null;
                    case 4: // SEND_DATE
                        return Current.SEND_DATE == null;
                    case 5: // SEND_BY
                        return Current.SEND_BY == null;
                    case 6: // ENTITY_TABLE
                        return Current.ENTITY_TABLE == null;
                    case 7: // ENTITY_KEY
                        return Current.ENTITY_KEY == null;
                    case 8: // EMAIL_ADDRESS
                        return Current.EMAIL_ADDRESS == null;
                    case 9: // COPY_ADDRESS
                        return Current.COPY_ADDRESS == null;
                    case 10: // EMAIL_SUBJECT
                        return Current.EMAIL_SUBJECT == null;
                    case 11: // EMAIL_MESSAGE
                        return Current.EMAIL_MESSAGE == null;
                    case 12: // ATTACHMENT_PATH
                        return Current.ATTACHMENT_PATH == null;
                    case 13: // STATUS
                        return Current.STATUS == null;
                    case 14: // DISPLAY
                        return Current.DISPLAY == null;
                    case 15: // COMMENTS
                        return Current.COMMENTS == null;
                    case 16: // LW_DATE
                        return Current.LW_DATE == null;
                    case 17: // LW_TIME
                        return Current.LW_TIME == null;
                    case 18: // LW_USER
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // PRINT_DATE
                        return "PRINT_DATE";
                    case 3: // PRINT_BY
                        return "PRINT_BY";
                    case 4: // SEND_DATE
                        return "SEND_DATE";
                    case 5: // SEND_BY
                        return "SEND_BY";
                    case 6: // ENTITY_TABLE
                        return "ENTITY_TABLE";
                    case 7: // ENTITY_KEY
                        return "ENTITY_KEY";
                    case 8: // EMAIL_ADDRESS
                        return "EMAIL_ADDRESS";
                    case 9: // COPY_ADDRESS
                        return "COPY_ADDRESS";
                    case 10: // EMAIL_SUBJECT
                        return "EMAIL_SUBJECT";
                    case 11: // EMAIL_MESSAGE
                        return "EMAIL_MESSAGE";
                    case 12: // ATTACHMENT_PATH
                        return "ATTACHMENT_PATH";
                    case 13: // STATUS
                        return "STATUS";
                    case 14: // DISPLAY
                        return "DISPLAY";
                    case 15: // COMMENTS
                        return "COMMENTS";
                    case 16: // LW_DATE
                        return "LW_DATE";
                    case 17: // LW_TIME
                        return "LW_TIME";
                    case 18: // LW_USER
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
                    case "CODE":
                        return 1;
                    case "PRINT_DATE":
                        return 2;
                    case "PRINT_BY":
                        return 3;
                    case "SEND_DATE":
                        return 4;
                    case "SEND_BY":
                        return 5;
                    case "ENTITY_TABLE":
                        return 6;
                    case "ENTITY_KEY":
                        return 7;
                    case "EMAIL_ADDRESS":
                        return 8;
                    case "COPY_ADDRESS":
                        return 9;
                    case "EMAIL_SUBJECT":
                        return 10;
                    case "EMAIL_MESSAGE":
                        return 11;
                    case "ATTACHMENT_PATH":
                        return 12;
                    case "STATUS":
                        return 13;
                    case "DISPLAY":
                        return 14;
                    case "COMMENTS":
                        return 15;
                    case "LW_DATE":
                        return 16;
                    case "LW_TIME":
                        return 17;
                    case "LW_USER":
                        return 18;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
