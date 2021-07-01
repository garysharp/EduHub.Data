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
    /// General Ledger Fees Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGFCDataSet : EduHubDataSet<SGFC>
    {
        /// <inheritdoc />
        public override string Name { get { return "SGFC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SGFCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<SGFC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<SGFC>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<SGFC>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SGFCKEY = new Lazy<Dictionary<string, SGFC>>(() => this.ToDictionary(i => i.SGFCKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<SGFC>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGFC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGFC" /> fields for each CSV column header</returns>
        internal override Action<SGFC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGFC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SGFCKEY":
                        mapper[i] = (e, v) => e.SGFCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SGGROUP":
                        mapper[i] = (e, v) => e.SGGROUP = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
                        break;
                    case "METHOD":
                        mapper[i] = (e, v) => e.METHOD = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS_AMOUNT":
                        mapper[i] = (e, v) => e.GROSS_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
        /// Merges <see cref="SGFC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SGFC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SGFC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SGFC}"/> of entities</returns>
        internal override IEnumerable<SGFC> ApplyDeltaEntities(IEnumerable<SGFC> Entities, List<SGFC> DeltaEntities)
        {
            HashSet<string> Index_SGFCKEY = new HashSet<string>(DeltaEntities.Select(i => i.SGFCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SGFCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SGFCKEY.Remove(entity.SGFCKEY);
                            
                            if (entity.SGFCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SGFC>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<SGFC>>> Index_GST_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<SGFC>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, SGFC>> Index_SGFCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SGFC>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SGFC</param>
        /// <returns>List of related SGFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGFC> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find SGFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SGFC</param>
        /// <param name="Value">List of related SGFC entities</param>
        /// <returns>True if the list of related SGFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<SGFC> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find SGFC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find SGFC</param>
        /// <returns>List of related SGFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGFC> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<SGFC> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SGFC</param>
        /// <returns>List of related SGFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGFC> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find SGFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SGFC</param>
        /// <param name="Value">List of related SGFC entities</param>
        /// <returns>True if the list of related SGFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<SGFC> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SGFC by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find SGFC</param>
        /// <returns>List of related SGFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGFC> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<SGFC> value;
            if (Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SGFC</param>
        /// <returns>List of related SGFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGFC> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find SGFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SGFC</param>
        /// <param name="Value">List of related SGFC entities</param>
        /// <returns>True if the list of related SGFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<SGFC> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find SGFC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SGFC</param>
        /// <returns>List of related SGFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGFC> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<SGFC> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGFC by SGFCKEY field
        /// </summary>
        /// <param name="SGFCKEY">SGFCKEY value used to find SGFC</param>
        /// <returns>Related SGFC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGFC FindBySGFCKEY(string SGFCKEY)
        {
            return Index_SGFCKEY.Value[SGFCKEY];
        }

        /// <summary>
        /// Attempt to find SGFC by SGFCKEY field
        /// </summary>
        /// <param name="SGFCKEY">SGFCKEY value used to find SGFC</param>
        /// <param name="Value">Related SGFC entity</param>
        /// <returns>True if the related SGFC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGFCKEY(string SGFCKEY, out SGFC Value)
        {
            return Index_SGFCKEY.Value.TryGetValue(SGFCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGFC by SGFCKEY field
        /// </summary>
        /// <param name="SGFCKEY">SGFCKEY value used to find SGFC</param>
        /// <returns>Related SGFC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGFC TryFindBySGFCKEY(string SGFCKEY)
        {
            SGFC value;
            if (Index_SGFCKEY.Value.TryGetValue(SGFCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SGFC</param>
        /// <returns>List of related SGFC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGFC> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find SGFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SGFC</param>
        /// <param name="Value">List of related SGFC entities</param>
        /// <returns>True if the list of related SGFC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<SGFC> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find SGFC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SGFC</param>
        /// <returns>List of related SGFC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGFC> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<SGFC> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SGFC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGFC](
        [SGFCKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [SGGROUP] varchar(10) NULL,
        [STATEMENT] varchar(1) NULL,
        [METHOD] varchar(1) NULL,
        [AMOUNT] money NULL,
        [GROSS_AMOUNT] money NULL,
        [GLCODE] varchar(10) NULL,
        [GST_TYPE] varchar(4) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGFC_Index_SGFCKEY] PRIMARY KEY CLUSTERED (
            [SGFCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SGFC_Index_GLCODE] ON [dbo].[SGFC]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [SGFC_Index_GST_TYPE] ON [dbo].[SGFC]
    (
            [GST_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SGFC_Index_INITIATIVE] ON [dbo].[SGFC]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [SGFC_Index_SUBPROGRAM] ON [dbo].[SGFC]
    (
            [SUBPROGRAM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND name = N'SGFC_Index_GLCODE')
    ALTER INDEX [SGFC_Index_GLCODE] ON [dbo].[SGFC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND name = N'SGFC_Index_GST_TYPE')
    ALTER INDEX [SGFC_Index_GST_TYPE] ON [dbo].[SGFC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND name = N'SGFC_Index_INITIATIVE')
    ALTER INDEX [SGFC_Index_INITIATIVE] ON [dbo].[SGFC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND name = N'SGFC_Index_SUBPROGRAM')
    ALTER INDEX [SGFC_Index_SUBPROGRAM] ON [dbo].[SGFC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND name = N'SGFC_Index_GLCODE')
    ALTER INDEX [SGFC_Index_GLCODE] ON [dbo].[SGFC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND name = N'SGFC_Index_GST_TYPE')
    ALTER INDEX [SGFC_Index_GST_TYPE] ON [dbo].[SGFC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND name = N'SGFC_Index_INITIATIVE')
    ALTER INDEX [SGFC_Index_INITIATIVE] ON [dbo].[SGFC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGFC]') AND name = N'SGFC_Index_SUBPROGRAM')
    ALTER INDEX [SGFC_Index_SUBPROGRAM] ON [dbo].[SGFC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SGFC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SGFC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SGFC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SGFCKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SGFCKEY.Add(entity.SGFCKEY);
            }

            builder.AppendLine("DELETE [dbo].[SGFC] WHERE");


            // Index_SGFCKEY
            builder.Append("[SGFCKEY] IN (");
            for (int index = 0; index < Index_SGFCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SGFCKEY
                var parameterSGFCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSGFCKEY);
                command.Parameters.Add(parameterSGFCKEY, SqlDbType.VarChar, 10).Value = Index_SGFCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGFC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGFC data set</returns>
        public override EduHubDataSetDataReader<SGFC> GetDataSetDataReader()
        {
            return new SGFCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGFC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGFC data set</returns>
        public override EduHubDataSetDataReader<SGFC> GetDataSetDataReader(List<SGFC> Entities)
        {
            return new SGFCDataReader(new EduHubDataSetLoadedReader<SGFC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGFCDataReader : EduHubDataSetDataReader<SGFC>
        {
            public SGFCDataReader(IEduHubDataSetReader<SGFC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 15; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SGFCKEY
                        return Current.SGFCKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // SGGROUP
                        return Current.SGGROUP;
                    case 3: // STATEMENT
                        return Current.STATEMENT;
                    case 4: // METHOD
                        return Current.METHOD;
                    case 5: // AMOUNT
                        return Current.AMOUNT;
                    case 6: // GROSS_AMOUNT
                        return Current.GROSS_AMOUNT;
                    case 7: // GLCODE
                        return Current.GLCODE;
                    case 8: // GST_TYPE
                        return Current.GST_TYPE;
                    case 9: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 10: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 11: // INITIATIVE
                        return Current.INITIATIVE;
                    case 12: // LW_DATE
                        return Current.LW_DATE;
                    case 13: // LW_TIME
                        return Current.LW_TIME;
                    case 14: // LW_USER
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
                    case 2: // SGGROUP
                        return Current.SGGROUP == null;
                    case 3: // STATEMENT
                        return Current.STATEMENT == null;
                    case 4: // METHOD
                        return Current.METHOD == null;
                    case 5: // AMOUNT
                        return Current.AMOUNT == null;
                    case 6: // GROSS_AMOUNT
                        return Current.GROSS_AMOUNT == null;
                    case 7: // GLCODE
                        return Current.GLCODE == null;
                    case 8: // GST_TYPE
                        return Current.GST_TYPE == null;
                    case 9: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 10: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 11: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 12: // LW_DATE
                        return Current.LW_DATE == null;
                    case 13: // LW_TIME
                        return Current.LW_TIME == null;
                    case 14: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SGFCKEY
                        return "SGFCKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // SGGROUP
                        return "SGGROUP";
                    case 3: // STATEMENT
                        return "STATEMENT";
                    case 4: // METHOD
                        return "METHOD";
                    case 5: // AMOUNT
                        return "AMOUNT";
                    case 6: // GROSS_AMOUNT
                        return "GROSS_AMOUNT";
                    case 7: // GLCODE
                        return "GLCODE";
                    case 8: // GST_TYPE
                        return "GST_TYPE";
                    case 9: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 10: // GLPROGRAM
                        return "GLPROGRAM";
                    case 11: // INITIATIVE
                        return "INITIATIVE";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SGFCKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "SGGROUP":
                        return 2;
                    case "STATEMENT":
                        return 3;
                    case "METHOD":
                        return 4;
                    case "AMOUNT":
                        return 5;
                    case "GROSS_AMOUNT":
                        return 6;
                    case "GLCODE":
                        return 7;
                    case "GST_TYPE":
                        return 8;
                    case "SUBPROGRAM":
                        return 9;
                    case "GLPROGRAM":
                        return 10;
                    case "INITIATIVE":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
