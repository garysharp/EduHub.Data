#if !EduHubScoped
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
    /// SMS Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPRECIPDataSet : EduHubDataSet<SPRECIP>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPRECIP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPRECIPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<int, IReadOnlyList<SPRECIP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPRECIP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPRECIP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPRECIP" /> fields for each CSV column header</returns>
        internal override Action<SPRECIP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPRECIP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = int.Parse(v);
                        break;
                    case "RECIPIENT_TABLE":
                        mapper[i] = (e, v) => e.RECIPIENT_TABLE = v;
                        break;
                    case "RECIPIENT_KEY":
                        mapper[i] = (e, v) => e.RECIPIENT_KEY = v;
                        break;
                    case "RECIPIENT_NUMBER":
                        mapper[i] = (e, v) => e.RECIPIENT_NUMBER = v;
                        break;
                    case "READ_RECEIPT":
                        mapper[i] = (e, v) => e.READ_RECEIPT = v;
                        break;
                    case "SOURCE_TABLE":
                        mapper[i] = (e, v) => e.SOURCE_TABLE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "STATUS_MESSAGE":
                        mapper[i] = (e, v) => e.STATUS_MESSAGE = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DELIVERED_DATE":
                        mapper[i] = (e, v) => e.DELIVERED_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "MESSAGEID":
                        mapper[i] = (e, v) => e.MESSAGEID = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="SPRECIP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPRECIP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPRECIP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPRECIP}"/> of entities</returns>
        internal override IEnumerable<SPRECIP> ApplyDeltaEntities(IEnumerable<SPRECIP> Entities, List<SPRECIP> DeltaEntities)
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

        private Lazy<Dictionary<int, IReadOnlyList<SPRECIP>>> Index_CODE;
        private Lazy<Dictionary<int, SPRECIP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <returns>List of related SPRECIP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPRECIP> FindByCODE(int CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <param name="Value">List of related SPRECIP entities</param>
        /// <returns>True if the list of related SPRECIP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(int CODE, out IReadOnlyList<SPRECIP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <returns>List of related SPRECIP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPRECIP> TryFindByCODE(int CODE)
        {
            IReadOnlyList<SPRECIP> value;
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
        /// Find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <returns>Related SPRECIP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPRECIP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <param name="Value">Related SPRECIP entity</param>
        /// <returns>True if the related SPRECIP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPRECIP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <returns>Related SPRECIP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPRECIP TryFindByTID(int TID)
        {
            SPRECIP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPRECIP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPRECIP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPRECIP](
        [TID] int IDENTITY NOT NULL,
        [CODE] int NOT NULL,
        [RECIPIENT_TABLE] varchar(8) NULL,
        [RECIPIENT_KEY] varchar(20) NULL,
        [RECIPIENT_NUMBER] varchar(15) NULL,
        [READ_RECEIPT] varchar(1) NULL,
        [SOURCE_TABLE] varchar(8) NULL,
        [SOURCE_KEY] varchar(20) NULL,
        [STATUS] varchar(1) NULL,
        [STATUS_MESSAGE] varchar(100) NULL,
        [SEND_DATE] datetime NULL,
        [DELIVERED_DATE] datetime NULL,
        [MESSAGEID] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPRECIP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SPRECIP_Index_CODE] ON [dbo].[SPRECIP]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPRECIP]') AND name = N'SPRECIP_Index_TID')
    ALTER INDEX [SPRECIP_Index_TID] ON [dbo].[SPRECIP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPRECIP]') AND name = N'SPRECIP_Index_TID')
    ALTER INDEX [SPRECIP_Index_TID] ON [dbo].[SPRECIP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPRECIP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPRECIP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPRECIP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SPRECIP] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SPRECIP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPRECIP data set</returns>
        public override EduHubDataSetDataReader<SPRECIP> GetDataSetDataReader()
        {
            return new SPRECIPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPRECIP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPRECIP data set</returns>
        public override EduHubDataSetDataReader<SPRECIP> GetDataSetDataReader(List<SPRECIP> Entities)
        {
            return new SPRECIPDataReader(new EduHubDataSetLoadedReader<SPRECIP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPRECIPDataReader : EduHubDataSetDataReader<SPRECIP>
        {
            public SPRECIPDataReader(IEduHubDataSetReader<SPRECIP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 16; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // RECIPIENT_TABLE
                        return Current.RECIPIENT_TABLE;
                    case 3: // RECIPIENT_KEY
                        return Current.RECIPIENT_KEY;
                    case 4: // RECIPIENT_NUMBER
                        return Current.RECIPIENT_NUMBER;
                    case 5: // READ_RECEIPT
                        return Current.READ_RECEIPT;
                    case 6: // SOURCE_TABLE
                        return Current.SOURCE_TABLE;
                    case 7: // SOURCE_KEY
                        return Current.SOURCE_KEY;
                    case 8: // STATUS
                        return Current.STATUS;
                    case 9: // STATUS_MESSAGE
                        return Current.STATUS_MESSAGE;
                    case 10: // SEND_DATE
                        return Current.SEND_DATE;
                    case 11: // DELIVERED_DATE
                        return Current.DELIVERED_DATE;
                    case 12: // MESSAGEID
                        return Current.MESSAGEID;
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
                    case 2: // RECIPIENT_TABLE
                        return Current.RECIPIENT_TABLE == null;
                    case 3: // RECIPIENT_KEY
                        return Current.RECIPIENT_KEY == null;
                    case 4: // RECIPIENT_NUMBER
                        return Current.RECIPIENT_NUMBER == null;
                    case 5: // READ_RECEIPT
                        return Current.READ_RECEIPT == null;
                    case 6: // SOURCE_TABLE
                        return Current.SOURCE_TABLE == null;
                    case 7: // SOURCE_KEY
                        return Current.SOURCE_KEY == null;
                    case 8: // STATUS
                        return Current.STATUS == null;
                    case 9: // STATUS_MESSAGE
                        return Current.STATUS_MESSAGE == null;
                    case 10: // SEND_DATE
                        return Current.SEND_DATE == null;
                    case 11: // DELIVERED_DATE
                        return Current.DELIVERED_DATE == null;
                    case 12: // MESSAGEID
                        return Current.MESSAGEID == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // RECIPIENT_TABLE
                        return "RECIPIENT_TABLE";
                    case 3: // RECIPIENT_KEY
                        return "RECIPIENT_KEY";
                    case 4: // RECIPIENT_NUMBER
                        return "RECIPIENT_NUMBER";
                    case 5: // READ_RECEIPT
                        return "READ_RECEIPT";
                    case 6: // SOURCE_TABLE
                        return "SOURCE_TABLE";
                    case 7: // SOURCE_KEY
                        return "SOURCE_KEY";
                    case 8: // STATUS
                        return "STATUS";
                    case 9: // STATUS_MESSAGE
                        return "STATUS_MESSAGE";
                    case 10: // SEND_DATE
                        return "SEND_DATE";
                    case 11: // DELIVERED_DATE
                        return "DELIVERED_DATE";
                    case 12: // MESSAGEID
                        return "MESSAGEID";
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
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "RECIPIENT_TABLE":
                        return 2;
                    case "RECIPIENT_KEY":
                        return 3;
                    case "RECIPIENT_NUMBER":
                        return 4;
                    case "READ_RECEIPT":
                        return 5;
                    case "SOURCE_TABLE":
                        return 6;
                    case "SOURCE_KEY":
                        return 7;
                    case "STATUS":
                        return 8;
                    case "STATUS_MESSAGE":
                        return 9;
                    case "SEND_DATE":
                        return 10;
                    case "DELIVERED_DATE":
                        return 11;
                    case "MESSAGEID":
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
#endif
