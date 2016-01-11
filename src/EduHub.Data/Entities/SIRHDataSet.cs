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
    /// On line receipt history Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIRHDataSet : EduHubDataSet<SIRH>
    {
        /// <inheritdoc />
        public override string Name { get { return "SIRH"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SIRHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PRINT_ID = new Lazy<Dictionary<int, SIRH>>(() => this.ToDictionary(i => i.PRINT_ID));
            Index_SIRHKEY = new Lazy<Dictionary<string, SIRH>>(() => this.ToDictionary(i => i.SIRHKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SIRH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SIRH" /> fields for each CSV column header</returns>
        internal override Action<SIRH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SIRH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SIRHKEY":
                        mapper[i] = (e, v) => e.SIRHKEY = v;
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
                        break;
                    case "RECEIPT_USER":
                        mapper[i] = (e, v) => e.RECEIPT_USER = v;
                        break;
                    case "RECEIPT_DATE":
                        mapper[i] = (e, v) => e.RECEIPT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECEIPT_TIME":
                        mapper[i] = (e, v) => e.RECEIPT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NEW_TRREF":
                        mapper[i] = (e, v) => e.NEW_TRREF = v;
                        break;
                    case "ERROR_FLAG":
                        mapper[i] = (e, v) => e.ERROR_FLAG = v;
                        break;
                    case "ERROR_COMMENT":
                        mapper[i] = (e, v) => e.ERROR_COMMENT = v;
                        break;
                    case "ERROR_USER":
                        mapper[i] = (e, v) => e.ERROR_USER = v;
                        break;
                    case "FORMAT_ID":
                        mapper[i] = (e, v) => e.FORMAT_ID = v;
                        break;
                    case "PRINT_ID":
                        mapper[i] = (e, v) => e.PRINT_ID = int.Parse(v);
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
        /// Merges <see cref="SIRH" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SIRH" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SIRH" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SIRH}"/> of entities</returns>
        internal override IEnumerable<SIRH> ApplyDeltaEntities(IEnumerable<SIRH> Entities, List<SIRH> DeltaEntities)
        {
            HashSet<int> Index_PRINT_ID = new HashSet<int>(DeltaEntities.Select(i => i.PRINT_ID));
            HashSet<string> Index_SIRHKEY = new HashSet<string>(DeltaEntities.Select(i => i.SIRHKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SIRHKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_PRINT_ID.Remove(entity.PRINT_ID);
                            overwritten = overwritten || Index_SIRHKEY.Remove(entity.SIRHKEY);
                            
                            if (entity.SIRHKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SIRH>> Index_PRINT_ID;
        private Lazy<Dictionary<string, SIRH>> Index_SIRHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <returns>Related SIRH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH FindByPRINT_ID(int PRINT_ID)
        {
            return Index_PRINT_ID.Value[PRINT_ID];
        }

        /// <summary>
        /// Attempt to find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <param name="Value">Related SIRH entity</param>
        /// <returns>True if the related SIRH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPRINT_ID(int PRINT_ID, out SIRH Value)
        {
            return Index_PRINT_ID.Value.TryGetValue(PRINT_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SIRH by PRINT_ID field
        /// </summary>
        /// <param name="PRINT_ID">PRINT_ID value used to find SIRH</param>
        /// <returns>Related SIRH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH TryFindByPRINT_ID(int PRINT_ID)
        {
            SIRH value;
            if (Index_PRINT_ID.Value.TryGetValue(PRINT_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <returns>Related SIRH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH FindBySIRHKEY(string SIRHKEY)
        {
            return Index_SIRHKEY.Value[SIRHKEY];
        }

        /// <summary>
        /// Attempt to find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <param name="Value">Related SIRH entity</param>
        /// <returns>True if the related SIRH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySIRHKEY(string SIRHKEY, out SIRH Value)
        {
            return Index_SIRHKEY.Value.TryGetValue(SIRHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SIRH by SIRHKEY field
        /// </summary>
        /// <param name="SIRHKEY">SIRHKEY value used to find SIRH</param>
        /// <returns>Related SIRH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIRH TryFindBySIRHKEY(string SIRHKEY)
        {
            SIRH value;
            if (Index_SIRHKEY.Value.TryGetValue(SIRHKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SIRH table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SIRH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SIRH](
        [SIRHKEY] varchar(20) NOT NULL,
        [CODE] varchar(10) NULL,
        [TRXLEDGER] varchar(2) NULL,
        [TRREF] varchar(10) NULL,
        [TRBATCH] int NULL,
        [TRDET] varchar(30) NULL,
        [TRDATE] datetime NULL,
        [TRAMT] money NULL,
        [RTYPE] varchar(2) NULL,
        [RECEIPT_USER] varchar(128) NULL,
        [RECEIPT_DATE] datetime NULL,
        [RECEIPT_TIME] smallint NULL,
        [NEW_TRREF] varchar(10) NULL,
        [ERROR_FLAG] varchar(1) NULL,
        [ERROR_COMMENT] text NULL,
        [ERROR_USER] varchar(128) NULL,
        [FORMAT_ID] varchar(7) NULL,
        [PRINT_ID] int IDENTITY NOT NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SIRH_Index_SIRHKEY] PRIMARY KEY CLUSTERED (
            [SIRHKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SIRH_Index_PRINT_ID] ON [dbo].[SIRH]
    (
            [PRINT_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SIRH]') AND name = N'Index_PRINT_ID')
    ALTER INDEX [Index_PRINT_ID] ON [dbo].[SIRH] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SIRH]') AND name = N'Index_PRINT_ID')
    ALTER INDEX [Index_PRINT_ID] ON [dbo].[SIRH] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SIRH"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SIRH"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SIRH> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_PRINT_ID = new List<int>();
            List<string> Index_SIRHKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_PRINT_ID.Add(entity.PRINT_ID);
                Index_SIRHKEY.Add(entity.SIRHKEY);
            }

            builder.AppendLine("DELETE [dbo].[SIRH] WHERE");


            // Index_PRINT_ID
            builder.Append("[PRINT_ID] IN (");
            for (int index = 0; index < Index_PRINT_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PRINT_ID
                var parameterPRINT_ID = $"@p{parameterIndex++}";
                builder.Append(parameterPRINT_ID);
                command.Parameters.Add(parameterPRINT_ID, SqlDbType.Int).Value = Index_PRINT_ID[index];
            }
            builder.AppendLine(") OR");

            // Index_SIRHKEY
            builder.Append("[SIRHKEY] IN (");
            for (int index = 0; index < Index_SIRHKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SIRHKEY
                var parameterSIRHKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSIRHKEY);
                command.Parameters.Add(parameterSIRHKEY, SqlDbType.VarChar, 20).Value = Index_SIRHKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SIRH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SIRH data set</returns>
        public override EduHubDataSetDataReader<SIRH> GetDataSetDataReader()
        {
            return new SIRHDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SIRH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SIRH data set</returns>
        public override EduHubDataSetDataReader<SIRH> GetDataSetDataReader(List<SIRH> Entities)
        {
            return new SIRHDataReader(new EduHubDataSetLoadedReader<SIRH>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SIRHDataReader : EduHubDataSetDataReader<SIRH>
        {
            public SIRHDataReader(IEduHubDataSetReader<SIRH> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 21; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SIRHKEY
                        return Current.SIRHKEY;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 3: // TRREF
                        return Current.TRREF;
                    case 4: // TRBATCH
                        return Current.TRBATCH;
                    case 5: // TRDET
                        return Current.TRDET;
                    case 6: // TRDATE
                        return Current.TRDATE;
                    case 7: // TRAMT
                        return Current.TRAMT;
                    case 8: // RTYPE
                        return Current.RTYPE;
                    case 9: // RECEIPT_USER
                        return Current.RECEIPT_USER;
                    case 10: // RECEIPT_DATE
                        return Current.RECEIPT_DATE;
                    case 11: // RECEIPT_TIME
                        return Current.RECEIPT_TIME;
                    case 12: // NEW_TRREF
                        return Current.NEW_TRREF;
                    case 13: // ERROR_FLAG
                        return Current.ERROR_FLAG;
                    case 14: // ERROR_COMMENT
                        return Current.ERROR_COMMENT;
                    case 15: // ERROR_USER
                        return Current.ERROR_USER;
                    case 16: // FORMAT_ID
                        return Current.FORMAT_ID;
                    case 17: // PRINT_ID
                        return Current.PRINT_ID;
                    case 18: // LW_DATE
                        return Current.LW_DATE;
                    case 19: // LW_TIME
                        return Current.LW_TIME;
                    case 20: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // CODE
                        return Current.CODE == null;
                    case 2: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 3: // TRREF
                        return Current.TRREF == null;
                    case 4: // TRBATCH
                        return Current.TRBATCH == null;
                    case 5: // TRDET
                        return Current.TRDET == null;
                    case 6: // TRDATE
                        return Current.TRDATE == null;
                    case 7: // TRAMT
                        return Current.TRAMT == null;
                    case 8: // RTYPE
                        return Current.RTYPE == null;
                    case 9: // RECEIPT_USER
                        return Current.RECEIPT_USER == null;
                    case 10: // RECEIPT_DATE
                        return Current.RECEIPT_DATE == null;
                    case 11: // RECEIPT_TIME
                        return Current.RECEIPT_TIME == null;
                    case 12: // NEW_TRREF
                        return Current.NEW_TRREF == null;
                    case 13: // ERROR_FLAG
                        return Current.ERROR_FLAG == null;
                    case 14: // ERROR_COMMENT
                        return Current.ERROR_COMMENT == null;
                    case 15: // ERROR_USER
                        return Current.ERROR_USER == null;
                    case 16: // FORMAT_ID
                        return Current.FORMAT_ID == null;
                    case 18: // LW_DATE
                        return Current.LW_DATE == null;
                    case 19: // LW_TIME
                        return Current.LW_TIME == null;
                    case 20: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SIRHKEY
                        return "SIRHKEY";
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRXLEDGER
                        return "TRXLEDGER";
                    case 3: // TRREF
                        return "TRREF";
                    case 4: // TRBATCH
                        return "TRBATCH";
                    case 5: // TRDET
                        return "TRDET";
                    case 6: // TRDATE
                        return "TRDATE";
                    case 7: // TRAMT
                        return "TRAMT";
                    case 8: // RTYPE
                        return "RTYPE";
                    case 9: // RECEIPT_USER
                        return "RECEIPT_USER";
                    case 10: // RECEIPT_DATE
                        return "RECEIPT_DATE";
                    case 11: // RECEIPT_TIME
                        return "RECEIPT_TIME";
                    case 12: // NEW_TRREF
                        return "NEW_TRREF";
                    case 13: // ERROR_FLAG
                        return "ERROR_FLAG";
                    case 14: // ERROR_COMMENT
                        return "ERROR_COMMENT";
                    case 15: // ERROR_USER
                        return "ERROR_USER";
                    case 16: // FORMAT_ID
                        return "FORMAT_ID";
                    case 17: // PRINT_ID
                        return "PRINT_ID";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SIRHKEY":
                        return 0;
                    case "CODE":
                        return 1;
                    case "TRXLEDGER":
                        return 2;
                    case "TRREF":
                        return 3;
                    case "TRBATCH":
                        return 4;
                    case "TRDET":
                        return 5;
                    case "TRDATE":
                        return 6;
                    case "TRAMT":
                        return 7;
                    case "RTYPE":
                        return 8;
                    case "RECEIPT_USER":
                        return 9;
                    case "RECEIPT_DATE":
                        return 10;
                    case "RECEIPT_TIME":
                        return 11;
                    case "NEW_TRREF":
                        return 12;
                    case "ERROR_FLAG":
                        return 13;
                    case "ERROR_COMMENT":
                        return 14;
                    case "ERROR_USER":
                        return 15;
                    case "FORMAT_ID":
                        return 16;
                    case "PRINT_ID":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
