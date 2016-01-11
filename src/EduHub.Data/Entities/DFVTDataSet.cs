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
    /// Family Voluntary Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFVTDataSet : EduHubDataSet<DFVT>
    {
        /// <inheritdoc />
        public override string Name { get { return "DFVT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal DFVTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FAMILY = new Lazy<Dictionary<string, IReadOnlyList<DFVT>>>(() => this.ToGroupedDictionary(i => i.FAMILY));
            Index_GST_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<DFVT>>>(() => this.ToGroupedNullDictionary(i => i.GST_TYPE));
            Index_TID = new Lazy<Dictionary<int, DFVT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFVT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFVT" /> fields for each CSV column header</returns>
        internal override Action<DFVT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFVT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRXCODE":
                        mapper[i] = (e, v) => e.TRXCODE = v;
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRNETT":
                        mapper[i] = (e, v) => e.TRNETT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRGROSS":
                        mapper[i] = (e, v) => e.TRGROSS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_AMOUNT":
                        mapper[i] = (e, v) => e.GST_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GROUPING":
                        mapper[i] = (e, v) => e.GROUPING = v;
                        break;
                    case "FROM_DATE":
                        mapper[i] = (e, v) => e.FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SHORTCUT":
                        mapper[i] = (e, v) => e.SHORTCUT = v;
                        break;
                    case "APPEAL":
                        mapper[i] = (e, v) => e.APPEAL = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
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
        /// Merges <see cref="DFVT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="DFVT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="DFVT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{DFVT}"/> of entities</returns>
        internal override IEnumerable<DFVT> ApplyDeltaEntities(IEnumerable<DFVT> Entities, List<DFVT> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.FAMILY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.FAMILY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<DFVT>>> Index_FAMILY;
        private Lazy<NullDictionary<string, IReadOnlyList<DFVT>>> Index_GST_TYPE;
        private Lazy<Dictionary<int, DFVT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <returns>List of related DFVT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> FindByFAMILY(string FAMILY)
        {
            return Index_FAMILY.Value[FAMILY];
        }

        /// <summary>
        /// Attempt to find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <param name="Value">List of related DFVT entities</param>
        /// <returns>True if the list of related DFVT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMILY(string FAMILY, out IReadOnlyList<DFVT> Value)
        {
            return Index_FAMILY.Value.TryGetValue(FAMILY, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find DFVT</param>
        /// <returns>List of related DFVT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> TryFindByFAMILY(string FAMILY)
        {
            IReadOnlyList<DFVT> value;
            if (Index_FAMILY.Value.TryGetValue(FAMILY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <returns>List of related DFVT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> FindByGST_TYPE(string GST_TYPE)
        {
            return Index_GST_TYPE.Value[GST_TYPE];
        }

        /// <summary>
        /// Attempt to find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <param name="Value">List of related DFVT entities</param>
        /// <returns>True if the list of related DFVT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGST_TYPE(string GST_TYPE, out IReadOnlyList<DFVT> Value)
        {
            return Index_GST_TYPE.Value.TryGetValue(GST_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by GST_TYPE field
        /// </summary>
        /// <param name="GST_TYPE">GST_TYPE value used to find DFVT</param>
        /// <returns>List of related DFVT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFVT> TryFindByGST_TYPE(string GST_TYPE)
        {
            IReadOnlyList<DFVT> value;
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
        /// Find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <returns>Related DFVT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFVT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <param name="Value">Related DFVT entity</param>
        /// <returns>True if the related DFVT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFVT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFVT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFVT</param>
        /// <returns>Related DFVT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFVT TryFindByTID(int TID)
        {
            DFVT value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a DFVT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DFVT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DFVT](
        [TID] int IDENTITY NOT NULL,
        [FAMILY] varchar(10) NOT NULL,
        [TRBATCH] int NULL,
        [TRXLEDGER] varchar(2) NULL,
        [TRXCODE] varchar(10) NULL,
        [TRAMT] money NULL,
        [TRDET] varchar(30) NULL,
        [TRNETT] money NULL,
        [TRGROSS] money NULL,
        [GST_AMOUNT] money NULL,
        [GST_TYPE] varchar(4) NULL,
        [GST_RATE] float NULL,
        [GROUPING] varchar(2) NULL,
        [FROM_DATE] datetime NULL,
        [SHORTCUT] varchar(2) NULL,
        [APPEAL] varchar(10) NULL,
        [TRTYPE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [DFVT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [DFVT_Index_FAMILY] ON [dbo].[DFVT]
    (
            [FAMILY] ASC
    );
    CREATE NONCLUSTERED INDEX [DFVT_Index_GST_TYPE] ON [dbo].[DFVT]
    (
            [GST_TYPE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DFVT]') AND name = N'Index_GST_TYPE')
    ALTER INDEX [Index_GST_TYPE] ON [dbo].[DFVT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DFVT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[DFVT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DFVT]') AND name = N'Index_GST_TYPE')
    ALTER INDEX [Index_GST_TYPE] ON [dbo].[DFVT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DFVT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[DFVT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="DFVT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="DFVT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<DFVT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[DFVT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the DFVT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DFVT data set</returns>
        public override EduHubDataSetDataReader<DFVT> GetDataSetDataReader()
        {
            return new DFVTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DFVT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DFVT data set</returns>
        public override EduHubDataSetDataReader<DFVT> GetDataSetDataReader(List<DFVT> Entities)
        {
            return new DFVTDataReader(new EduHubDataSetLoadedReader<DFVT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DFVTDataReader : EduHubDataSetDataReader<DFVT>
        {
            public DFVTDataReader(IEduHubDataSetReader<DFVT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 20; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // FAMILY
                        return Current.FAMILY;
                    case 2: // TRBATCH
                        return Current.TRBATCH;
                    case 3: // TRXLEDGER
                        return Current.TRXLEDGER;
                    case 4: // TRXCODE
                        return Current.TRXCODE;
                    case 5: // TRAMT
                        return Current.TRAMT;
                    case 6: // TRDET
                        return Current.TRDET;
                    case 7: // TRNETT
                        return Current.TRNETT;
                    case 8: // TRGROSS
                        return Current.TRGROSS;
                    case 9: // GST_AMOUNT
                        return Current.GST_AMOUNT;
                    case 10: // GST_TYPE
                        return Current.GST_TYPE;
                    case 11: // GST_RATE
                        return Current.GST_RATE;
                    case 12: // GROUPING
                        return Current.GROUPING;
                    case 13: // FROM_DATE
                        return Current.FROM_DATE;
                    case 14: // SHORTCUT
                        return Current.SHORTCUT;
                    case 15: // APPEAL
                        return Current.APPEAL;
                    case 16: // TRTYPE
                        return Current.TRTYPE;
                    case 17: // LW_DATE
                        return Current.LW_DATE;
                    case 18: // LW_TIME
                        return Current.LW_TIME;
                    case 19: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRBATCH
                        return Current.TRBATCH == null;
                    case 3: // TRXLEDGER
                        return Current.TRXLEDGER == null;
                    case 4: // TRXCODE
                        return Current.TRXCODE == null;
                    case 5: // TRAMT
                        return Current.TRAMT == null;
                    case 6: // TRDET
                        return Current.TRDET == null;
                    case 7: // TRNETT
                        return Current.TRNETT == null;
                    case 8: // TRGROSS
                        return Current.TRGROSS == null;
                    case 9: // GST_AMOUNT
                        return Current.GST_AMOUNT == null;
                    case 10: // GST_TYPE
                        return Current.GST_TYPE == null;
                    case 11: // GST_RATE
                        return Current.GST_RATE == null;
                    case 12: // GROUPING
                        return Current.GROUPING == null;
                    case 13: // FROM_DATE
                        return Current.FROM_DATE == null;
                    case 14: // SHORTCUT
                        return Current.SHORTCUT == null;
                    case 15: // APPEAL
                        return Current.APPEAL == null;
                    case 16: // TRTYPE
                        return Current.TRTYPE == null;
                    case 17: // LW_DATE
                        return Current.LW_DATE == null;
                    case 18: // LW_TIME
                        return Current.LW_TIME == null;
                    case 19: // LW_USER
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
                    case 1: // FAMILY
                        return "FAMILY";
                    case 2: // TRBATCH
                        return "TRBATCH";
                    case 3: // TRXLEDGER
                        return "TRXLEDGER";
                    case 4: // TRXCODE
                        return "TRXCODE";
                    case 5: // TRAMT
                        return "TRAMT";
                    case 6: // TRDET
                        return "TRDET";
                    case 7: // TRNETT
                        return "TRNETT";
                    case 8: // TRGROSS
                        return "TRGROSS";
                    case 9: // GST_AMOUNT
                        return "GST_AMOUNT";
                    case 10: // GST_TYPE
                        return "GST_TYPE";
                    case 11: // GST_RATE
                        return "GST_RATE";
                    case 12: // GROUPING
                        return "GROUPING";
                    case 13: // FROM_DATE
                        return "FROM_DATE";
                    case 14: // SHORTCUT
                        return "SHORTCUT";
                    case 15: // APPEAL
                        return "APPEAL";
                    case 16: // TRTYPE
                        return "TRTYPE";
                    case 17: // LW_DATE
                        return "LW_DATE";
                    case 18: // LW_TIME
                        return "LW_TIME";
                    case 19: // LW_USER
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
                    case "FAMILY":
                        return 1;
                    case "TRBATCH":
                        return 2;
                    case "TRXLEDGER":
                        return 3;
                    case "TRXCODE":
                        return 4;
                    case "TRAMT":
                        return 5;
                    case "TRDET":
                        return 6;
                    case "TRNETT":
                        return 7;
                    case "TRGROSS":
                        return 8;
                    case "GST_AMOUNT":
                        return 9;
                    case "GST_TYPE":
                        return 10;
                    case "GST_RATE":
                        return 11;
                    case "GROUPING":
                        return 12;
                    case "FROM_DATE":
                        return 13;
                    case "SHORTCUT":
                        return 14;
                    case "APPEAL":
                        return 15;
                    case "TRTYPE":
                        return 16;
                    case "LW_DATE":
                        return 17;
                    case "LW_TIME":
                        return 18;
                    case "LW_USER":
                        return 19;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
