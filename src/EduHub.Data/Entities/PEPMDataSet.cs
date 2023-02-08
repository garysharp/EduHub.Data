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
    /// Pay Methods Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPMDataSet : EduHubDataSet<PEPM>
    {
        /// <inheritdoc />
        public override string Name { get { return "PEPM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PEPMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<PEPM>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPM>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PEPM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPM" /> fields for each CSV column header</returns>
        internal override Action<PEPM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "PAYMODE":
                        mapper[i] = (e, v) => e.PAYMODE = v;
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CHQ_NO":
                        mapper[i] = (e, v) => e.CHQ_NO = v;
                        break;
                    case "DAMOUNT":
                        mapper[i] = (e, v) => e.DAMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EFT_CREATED":
                        mapper[i] = (e, v) => e.EFT_CREATED = v;
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
        /// Merges <see cref="PEPM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PEPM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PEPM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PEPM}"/> of entities</returns>
        internal override IEnumerable<PEPM> ApplyDeltaEntities(IEnumerable<PEPM> Entities, List<PEPM> DeltaEntities)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PEPM>>> Index_BSB;
        private Lazy<Dictionary<string, IReadOnlyList<PEPM>>> Index_CODE;
        private Lazy<Dictionary<int, PEPM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <returns>List of related PEPM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <param name="Value">List of related PEPM entities</param>
        /// <returns>True if the list of related PEPM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<PEPM> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM</param>
        /// <returns>List of related PEPM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> TryFindByBSB(string BSB)
        {
            IReadOnlyList<PEPM> value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <returns>List of related PEPM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <param name="Value">List of related PEPM entities</param>
        /// <returns>True if the list of related PEPM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPM> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPM</param>
        /// <returns>List of related PEPM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPM> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPM> value;
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
        /// Find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <returns>Related PEPM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <param name="Value">Related PEPM entity</param>
        /// <returns>True if the related PEPM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPM</param>
        /// <returns>Related PEPM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPM TryFindByTID(int TID)
        {
            PEPM value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PEPM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEPM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEPM](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [NAME] varchar(30) NULL,
        [PAYMODE] varchar(2) NULL,
        [REFERENCE_NO] varchar(20) NULL,
        [CHQ_NO] varchar(10) NULL,
        [DAMOUNT] money NULL,
        [BANK] varchar(12) NULL,
        [BSB] varchar(6) NULL,
        [ACCOUNT_NO] varchar(15) NULL,
        [AMOUNT] money NULL,
        [FLAG] varchar(1) NULL,
        [TRBATCH] int NULL,
        [EFT_CREATED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEPM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PEPM_Index_BSB] ON [dbo].[PEPM]
    (
            [BSB] ASC
    );
    CREATE CLUSTERED INDEX [PEPM_Index_CODE] ON [dbo].[PEPM]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPM]') AND name = N'PEPM_Index_BSB')
    ALTER INDEX [PEPM_Index_BSB] ON [dbo].[PEPM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPM]') AND name = N'PEPM_Index_TID')
    ALTER INDEX [PEPM_Index_TID] ON [dbo].[PEPM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPM]') AND name = N'PEPM_Index_BSB')
    ALTER INDEX [PEPM_Index_BSB] ON [dbo].[PEPM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPM]') AND name = N'PEPM_Index_TID')
    ALTER INDEX [PEPM_Index_TID] ON [dbo].[PEPM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PEPM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PEPM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PEPM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PEPM] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PEPM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPM data set</returns>
        public override EduHubDataSetDataReader<PEPM> GetDataSetDataReader()
        {
            return new PEPMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEPM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPM data set</returns>
        public override EduHubDataSetDataReader<PEPM> GetDataSetDataReader(List<PEPM> Entities)
        {
            return new PEPMDataReader(new EduHubDataSetLoadedReader<PEPM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEPMDataReader : EduHubDataSetDataReader<PEPM>
        {
            public PEPMDataReader(IEduHubDataSetReader<PEPM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 17; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // NAME
                        return Current.NAME;
                    case 3: // PAYMODE
                        return Current.PAYMODE;
                    case 4: // REFERENCE_NO
                        return Current.REFERENCE_NO;
                    case 5: // CHQ_NO
                        return Current.CHQ_NO;
                    case 6: // DAMOUNT
                        return Current.DAMOUNT;
                    case 7: // BANK
                        return Current.BANK;
                    case 8: // BSB
                        return Current.BSB;
                    case 9: // ACCOUNT_NO
                        return Current.ACCOUNT_NO;
                    case 10: // AMOUNT
                        return Current.AMOUNT;
                    case 11: // FLAG
                        return Current.FLAG;
                    case 12: // TRBATCH
                        return Current.TRBATCH;
                    case 13: // EFT_CREATED
                        return Current.EFT_CREATED;
                    case 14: // LW_DATE
                        return Current.LW_DATE;
                    case 15: // LW_TIME
                        return Current.LW_TIME;
                    case 16: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // NAME
                        return Current.NAME == null;
                    case 3: // PAYMODE
                        return Current.PAYMODE == null;
                    case 4: // REFERENCE_NO
                        return Current.REFERENCE_NO == null;
                    case 5: // CHQ_NO
                        return Current.CHQ_NO == null;
                    case 6: // DAMOUNT
                        return Current.DAMOUNT == null;
                    case 7: // BANK
                        return Current.BANK == null;
                    case 8: // BSB
                        return Current.BSB == null;
                    case 9: // ACCOUNT_NO
                        return Current.ACCOUNT_NO == null;
                    case 10: // AMOUNT
                        return Current.AMOUNT == null;
                    case 11: // FLAG
                        return Current.FLAG == null;
                    case 12: // TRBATCH
                        return Current.TRBATCH == null;
                    case 13: // EFT_CREATED
                        return Current.EFT_CREATED == null;
                    case 14: // LW_DATE
                        return Current.LW_DATE == null;
                    case 15: // LW_TIME
                        return Current.LW_TIME == null;
                    case 16: // LW_USER
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
                    case 2: // NAME
                        return "NAME";
                    case 3: // PAYMODE
                        return "PAYMODE";
                    case 4: // REFERENCE_NO
                        return "REFERENCE_NO";
                    case 5: // CHQ_NO
                        return "CHQ_NO";
                    case 6: // DAMOUNT
                        return "DAMOUNT";
                    case 7: // BANK
                        return "BANK";
                    case 8: // BSB
                        return "BSB";
                    case 9: // ACCOUNT_NO
                        return "ACCOUNT_NO";
                    case 10: // AMOUNT
                        return "AMOUNT";
                    case 11: // FLAG
                        return "FLAG";
                    case 12: // TRBATCH
                        return "TRBATCH";
                    case 13: // EFT_CREATED
                        return "EFT_CREATED";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    case 16: // LW_USER
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
                    case "NAME":
                        return 2;
                    case "PAYMODE":
                        return 3;
                    case "REFERENCE_NO":
                        return 4;
                    case "CHQ_NO":
                        return 5;
                    case "DAMOUNT":
                        return 6;
                    case "BANK":
                        return 7;
                    case "BSB":
                        return 8;
                    case "ACCOUNT_NO":
                        return 9;
                    case "AMOUNT":
                        return 10;
                    case "FLAG":
                        return 11;
                    case "TRBATCH":
                        return 12;
                    case "EFT_CREATED":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    case "LW_USER":
                        return 16;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
