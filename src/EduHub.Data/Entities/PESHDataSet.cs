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
    /// Employee Super LTD History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PESHDataSet : EduHubDataSet<PESH>
    {
        /// <inheritdoc />
        public override string Name { get { return "PESH"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PESHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PESH>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PESH>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PESH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PESH" /> fields for each CSV column header</returns>
        internal override Action<PESH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PESH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AMOUNT_OPBAL":
                        mapper[i] = (e, v) => e.AMOUNT_OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AMOUNT_YTD":
                        mapper[i] = (e, v) => e.AMOUNT_YTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AMOUNT_LTD":
                        mapper[i] = (e, v) => e.AMOUNT_LTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH01":
                        mapper[i] = (e, v) => e.SUPER_MTH01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH02":
                        mapper[i] = (e, v) => e.SUPER_MTH02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH03":
                        mapper[i] = (e, v) => e.SUPER_MTH03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH04":
                        mapper[i] = (e, v) => e.SUPER_MTH04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH05":
                        mapper[i] = (e, v) => e.SUPER_MTH05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH06":
                        mapper[i] = (e, v) => e.SUPER_MTH06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH07":
                        mapper[i] = (e, v) => e.SUPER_MTH07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH08":
                        mapper[i] = (e, v) => e.SUPER_MTH08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH09":
                        mapper[i] = (e, v) => e.SUPER_MTH09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH10":
                        mapper[i] = (e, v) => e.SUPER_MTH10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH11":
                        mapper[i] = (e, v) => e.SUPER_MTH11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_MTH12":
                        mapper[i] = (e, v) => e.SUPER_MTH12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV01":
                        mapper[i] = (e, v) => e.SUPER_PROV01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV02":
                        mapper[i] = (e, v) => e.SUPER_PROV02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV03":
                        mapper[i] = (e, v) => e.SUPER_PROV03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV04":
                        mapper[i] = (e, v) => e.SUPER_PROV04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV05":
                        mapper[i] = (e, v) => e.SUPER_PROV05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV06":
                        mapper[i] = (e, v) => e.SUPER_PROV06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV07":
                        mapper[i] = (e, v) => e.SUPER_PROV07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV08":
                        mapper[i] = (e, v) => e.SUPER_PROV08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV09":
                        mapper[i] = (e, v) => e.SUPER_PROV09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV10":
                        mapper[i] = (e, v) => e.SUPER_PROV10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV11":
                        mapper[i] = (e, v) => e.SUPER_PROV11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PROV12":
                        mapper[i] = (e, v) => e.SUPER_PROV12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PAID_YTD":
                        mapper[i] = (e, v) => e.SUPER_PAID_YTD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_PAID_TODATE":
                        mapper[i] = (e, v) => e.SUPER_PAID_TODATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUPER_UNPAID_LYR":
                        mapper[i] = (e, v) => e.SUPER_UNPAID_LYR = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="PESH" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PESH" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PESH" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PESH}"/> of entities</returns>
        internal override IEnumerable<PESH> ApplyDeltaEntities(IEnumerable<PESH> Entities, List<PESH> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<PESH>>> Index_CODE;
        private Lazy<Dictionary<int, PESH>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PESH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESH</param>
        /// <returns>List of related PESH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESH> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PESH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESH</param>
        /// <param name="Value">List of related PESH entities</param>
        /// <returns>True if the list of related PESH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PESH> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PESH by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PESH</param>
        /// <returns>List of related PESH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PESH> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PESH> value;
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
        /// Find PESH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESH</param>
        /// <returns>Related PESH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESH FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PESH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESH</param>
        /// <param name="Value">Related PESH entity</param>
        /// <returns>True if the related PESH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PESH Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PESH by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PESH</param>
        /// <returns>Related PESH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PESH TryFindByTID(int TID)
        {
            PESH value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PESH table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PESH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PESH](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRTYPE] varchar(1) NULL,
        [SUPER_FUND] varchar(10) NULL,
        [SUPER_MEMBER] varchar(20) NULL,
        [LASTPAYDATE] datetime NULL,
        [AMOUNT_OPBAL] money NULL,
        [AMOUNT_YTD] money NULL,
        [AMOUNT_LTD] money NULL,
        [SUPER_MTH01] money NULL,
        [SUPER_MTH02] money NULL,
        [SUPER_MTH03] money NULL,
        [SUPER_MTH04] money NULL,
        [SUPER_MTH05] money NULL,
        [SUPER_MTH06] money NULL,
        [SUPER_MTH07] money NULL,
        [SUPER_MTH08] money NULL,
        [SUPER_MTH09] money NULL,
        [SUPER_MTH10] money NULL,
        [SUPER_MTH11] money NULL,
        [SUPER_MTH12] money NULL,
        [SUPER_PROV01] money NULL,
        [SUPER_PROV02] money NULL,
        [SUPER_PROV03] money NULL,
        [SUPER_PROV04] money NULL,
        [SUPER_PROV05] money NULL,
        [SUPER_PROV06] money NULL,
        [SUPER_PROV07] money NULL,
        [SUPER_PROV08] money NULL,
        [SUPER_PROV09] money NULL,
        [SUPER_PROV10] money NULL,
        [SUPER_PROV11] money NULL,
        [SUPER_PROV12] money NULL,
        [SUPER_PAID_YTD] money NULL,
        [SUPER_PAID_TODATE] datetime NULL,
        [SUPER_UNPAID_LYR] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PESH_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PESH_Index_CODE] ON [dbo].[PESH]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PESH]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PESH] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PESH]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PESH] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PESH"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PESH"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PESH> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PESH] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PESH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PESH data set</returns>
        public override EduHubDataSetDataReader<PESH> GetDataSetDataReader()
        {
            return new PESHDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PESH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PESH data set</returns>
        public override EduHubDataSetDataReader<PESH> GetDataSetDataReader(List<PESH> Entities)
        {
            return new PESHDataReader(new EduHubDataSetLoadedReader<PESH>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PESHDataReader : EduHubDataSetDataReader<PESH>
        {
            public PESHDataReader(IEduHubDataSetReader<PESH> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 39; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // TRTYPE
                        return Current.TRTYPE;
                    case 3: // SUPER_FUND
                        return Current.SUPER_FUND;
                    case 4: // SUPER_MEMBER
                        return Current.SUPER_MEMBER;
                    case 5: // LASTPAYDATE
                        return Current.LASTPAYDATE;
                    case 6: // AMOUNT_OPBAL
                        return Current.AMOUNT_OPBAL;
                    case 7: // AMOUNT_YTD
                        return Current.AMOUNT_YTD;
                    case 8: // AMOUNT_LTD
                        return Current.AMOUNT_LTD;
                    case 9: // SUPER_MTH01
                        return Current.SUPER_MTH01;
                    case 10: // SUPER_MTH02
                        return Current.SUPER_MTH02;
                    case 11: // SUPER_MTH03
                        return Current.SUPER_MTH03;
                    case 12: // SUPER_MTH04
                        return Current.SUPER_MTH04;
                    case 13: // SUPER_MTH05
                        return Current.SUPER_MTH05;
                    case 14: // SUPER_MTH06
                        return Current.SUPER_MTH06;
                    case 15: // SUPER_MTH07
                        return Current.SUPER_MTH07;
                    case 16: // SUPER_MTH08
                        return Current.SUPER_MTH08;
                    case 17: // SUPER_MTH09
                        return Current.SUPER_MTH09;
                    case 18: // SUPER_MTH10
                        return Current.SUPER_MTH10;
                    case 19: // SUPER_MTH11
                        return Current.SUPER_MTH11;
                    case 20: // SUPER_MTH12
                        return Current.SUPER_MTH12;
                    case 21: // SUPER_PROV01
                        return Current.SUPER_PROV01;
                    case 22: // SUPER_PROV02
                        return Current.SUPER_PROV02;
                    case 23: // SUPER_PROV03
                        return Current.SUPER_PROV03;
                    case 24: // SUPER_PROV04
                        return Current.SUPER_PROV04;
                    case 25: // SUPER_PROV05
                        return Current.SUPER_PROV05;
                    case 26: // SUPER_PROV06
                        return Current.SUPER_PROV06;
                    case 27: // SUPER_PROV07
                        return Current.SUPER_PROV07;
                    case 28: // SUPER_PROV08
                        return Current.SUPER_PROV08;
                    case 29: // SUPER_PROV09
                        return Current.SUPER_PROV09;
                    case 30: // SUPER_PROV10
                        return Current.SUPER_PROV10;
                    case 31: // SUPER_PROV11
                        return Current.SUPER_PROV11;
                    case 32: // SUPER_PROV12
                        return Current.SUPER_PROV12;
                    case 33: // SUPER_PAID_YTD
                        return Current.SUPER_PAID_YTD;
                    case 34: // SUPER_PAID_TODATE
                        return Current.SUPER_PAID_TODATE;
                    case 35: // SUPER_UNPAID_LYR
                        return Current.SUPER_UNPAID_LYR;
                    case 36: // LW_DATE
                        return Current.LW_DATE;
                    case 37: // LW_TIME
                        return Current.LW_TIME;
                    case 38: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRTYPE
                        return Current.TRTYPE == null;
                    case 3: // SUPER_FUND
                        return Current.SUPER_FUND == null;
                    case 4: // SUPER_MEMBER
                        return Current.SUPER_MEMBER == null;
                    case 5: // LASTPAYDATE
                        return Current.LASTPAYDATE == null;
                    case 6: // AMOUNT_OPBAL
                        return Current.AMOUNT_OPBAL == null;
                    case 7: // AMOUNT_YTD
                        return Current.AMOUNT_YTD == null;
                    case 8: // AMOUNT_LTD
                        return Current.AMOUNT_LTD == null;
                    case 9: // SUPER_MTH01
                        return Current.SUPER_MTH01 == null;
                    case 10: // SUPER_MTH02
                        return Current.SUPER_MTH02 == null;
                    case 11: // SUPER_MTH03
                        return Current.SUPER_MTH03 == null;
                    case 12: // SUPER_MTH04
                        return Current.SUPER_MTH04 == null;
                    case 13: // SUPER_MTH05
                        return Current.SUPER_MTH05 == null;
                    case 14: // SUPER_MTH06
                        return Current.SUPER_MTH06 == null;
                    case 15: // SUPER_MTH07
                        return Current.SUPER_MTH07 == null;
                    case 16: // SUPER_MTH08
                        return Current.SUPER_MTH08 == null;
                    case 17: // SUPER_MTH09
                        return Current.SUPER_MTH09 == null;
                    case 18: // SUPER_MTH10
                        return Current.SUPER_MTH10 == null;
                    case 19: // SUPER_MTH11
                        return Current.SUPER_MTH11 == null;
                    case 20: // SUPER_MTH12
                        return Current.SUPER_MTH12 == null;
                    case 21: // SUPER_PROV01
                        return Current.SUPER_PROV01 == null;
                    case 22: // SUPER_PROV02
                        return Current.SUPER_PROV02 == null;
                    case 23: // SUPER_PROV03
                        return Current.SUPER_PROV03 == null;
                    case 24: // SUPER_PROV04
                        return Current.SUPER_PROV04 == null;
                    case 25: // SUPER_PROV05
                        return Current.SUPER_PROV05 == null;
                    case 26: // SUPER_PROV06
                        return Current.SUPER_PROV06 == null;
                    case 27: // SUPER_PROV07
                        return Current.SUPER_PROV07 == null;
                    case 28: // SUPER_PROV08
                        return Current.SUPER_PROV08 == null;
                    case 29: // SUPER_PROV09
                        return Current.SUPER_PROV09 == null;
                    case 30: // SUPER_PROV10
                        return Current.SUPER_PROV10 == null;
                    case 31: // SUPER_PROV11
                        return Current.SUPER_PROV11 == null;
                    case 32: // SUPER_PROV12
                        return Current.SUPER_PROV12 == null;
                    case 33: // SUPER_PAID_YTD
                        return Current.SUPER_PAID_YTD == null;
                    case 34: // SUPER_PAID_TODATE
                        return Current.SUPER_PAID_TODATE == null;
                    case 35: // SUPER_UNPAID_LYR
                        return Current.SUPER_UNPAID_LYR == null;
                    case 36: // LW_DATE
                        return Current.LW_DATE == null;
                    case 37: // LW_TIME
                        return Current.LW_TIME == null;
                    case 38: // LW_USER
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
                    case 2: // TRTYPE
                        return "TRTYPE";
                    case 3: // SUPER_FUND
                        return "SUPER_FUND";
                    case 4: // SUPER_MEMBER
                        return "SUPER_MEMBER";
                    case 5: // LASTPAYDATE
                        return "LASTPAYDATE";
                    case 6: // AMOUNT_OPBAL
                        return "AMOUNT_OPBAL";
                    case 7: // AMOUNT_YTD
                        return "AMOUNT_YTD";
                    case 8: // AMOUNT_LTD
                        return "AMOUNT_LTD";
                    case 9: // SUPER_MTH01
                        return "SUPER_MTH01";
                    case 10: // SUPER_MTH02
                        return "SUPER_MTH02";
                    case 11: // SUPER_MTH03
                        return "SUPER_MTH03";
                    case 12: // SUPER_MTH04
                        return "SUPER_MTH04";
                    case 13: // SUPER_MTH05
                        return "SUPER_MTH05";
                    case 14: // SUPER_MTH06
                        return "SUPER_MTH06";
                    case 15: // SUPER_MTH07
                        return "SUPER_MTH07";
                    case 16: // SUPER_MTH08
                        return "SUPER_MTH08";
                    case 17: // SUPER_MTH09
                        return "SUPER_MTH09";
                    case 18: // SUPER_MTH10
                        return "SUPER_MTH10";
                    case 19: // SUPER_MTH11
                        return "SUPER_MTH11";
                    case 20: // SUPER_MTH12
                        return "SUPER_MTH12";
                    case 21: // SUPER_PROV01
                        return "SUPER_PROV01";
                    case 22: // SUPER_PROV02
                        return "SUPER_PROV02";
                    case 23: // SUPER_PROV03
                        return "SUPER_PROV03";
                    case 24: // SUPER_PROV04
                        return "SUPER_PROV04";
                    case 25: // SUPER_PROV05
                        return "SUPER_PROV05";
                    case 26: // SUPER_PROV06
                        return "SUPER_PROV06";
                    case 27: // SUPER_PROV07
                        return "SUPER_PROV07";
                    case 28: // SUPER_PROV08
                        return "SUPER_PROV08";
                    case 29: // SUPER_PROV09
                        return "SUPER_PROV09";
                    case 30: // SUPER_PROV10
                        return "SUPER_PROV10";
                    case 31: // SUPER_PROV11
                        return "SUPER_PROV11";
                    case 32: // SUPER_PROV12
                        return "SUPER_PROV12";
                    case 33: // SUPER_PAID_YTD
                        return "SUPER_PAID_YTD";
                    case 34: // SUPER_PAID_TODATE
                        return "SUPER_PAID_TODATE";
                    case 35: // SUPER_UNPAID_LYR
                        return "SUPER_UNPAID_LYR";
                    case 36: // LW_DATE
                        return "LW_DATE";
                    case 37: // LW_TIME
                        return "LW_TIME";
                    case 38: // LW_USER
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
                    case "TRTYPE":
                        return 2;
                    case "SUPER_FUND":
                        return 3;
                    case "SUPER_MEMBER":
                        return 4;
                    case "LASTPAYDATE":
                        return 5;
                    case "AMOUNT_OPBAL":
                        return 6;
                    case "AMOUNT_YTD":
                        return 7;
                    case "AMOUNT_LTD":
                        return 8;
                    case "SUPER_MTH01":
                        return 9;
                    case "SUPER_MTH02":
                        return 10;
                    case "SUPER_MTH03":
                        return 11;
                    case "SUPER_MTH04":
                        return 12;
                    case "SUPER_MTH05":
                        return 13;
                    case "SUPER_MTH06":
                        return 14;
                    case "SUPER_MTH07":
                        return 15;
                    case "SUPER_MTH08":
                        return 16;
                    case "SUPER_MTH09":
                        return 17;
                    case "SUPER_MTH10":
                        return 18;
                    case "SUPER_MTH11":
                        return 19;
                    case "SUPER_MTH12":
                        return 20;
                    case "SUPER_PROV01":
                        return 21;
                    case "SUPER_PROV02":
                        return 22;
                    case "SUPER_PROV03":
                        return 23;
                    case "SUPER_PROV04":
                        return 24;
                    case "SUPER_PROV05":
                        return 25;
                    case "SUPER_PROV06":
                        return 26;
                    case "SUPER_PROV07":
                        return 27;
                    case "SUPER_PROV08":
                        return 28;
                    case "SUPER_PROV09":
                        return 29;
                    case "SUPER_PROV10":
                        return 30;
                    case "SUPER_PROV11":
                        return 31;
                    case "SUPER_PROV12":
                        return 32;
                    case "SUPER_PAID_YTD":
                        return 33;
                    case "SUPER_PAID_TODATE":
                        return 34;
                    case "SUPER_UNPAID_LYR":
                        return 35;
                    case "LW_DATE":
                        return 36;
                    case "LW_TIME":
                        return 37;
                    case "LW_USER":
                        return 38;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
