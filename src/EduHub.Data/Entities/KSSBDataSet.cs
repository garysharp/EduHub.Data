#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
#if NET452
using System.Data.SqlClient;
#elif NET10_0
using Microsoft.Data.SqlClient;
#endif
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Saving Bonus Trns Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSSBDataSet : EduHubDataSet<KSSB>
    {
        /// <inheritdoc />
        public override string Name { get { return "KSSB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KSSBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CRKEY = new Lazy<NullDictionary<string, IReadOnlyList<KSSB>>>(() => this.ToGroupedNullDictionary(i => i.CRKEY));
            Index_SKEY = new Lazy<NullDictionary<string, IReadOnlyList<KSSB>>>(() => this.ToGroupedNullDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, KSSB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSSB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSSB" /> fields for each CSV column header</returns>
        internal override Action<KSSB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSSB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TRAN_ID":
                        mapper[i] = (e, v) => e.TRAN_ID = v;
                        break;
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ONLINE_VOUCHER":
                        mapper[i] = (e, v) => e.ONLINE_VOUCHER = v;
                        break;
                    case "VOUCHER_CODE":
                        mapper[i] = (e, v) => e.VOUCHER_CODE = v;
                        break;
                    case "ITEM_CATEGORY":
                        mapper[i] = (e, v) => e.ITEM_CATEGORY = v;
                        break;
                    case "TRAN_TYPE":
                        mapper[i] = (e, v) => e.TRAN_TYPE = v;
                        break;
                    case "TRAN_AMT":
                        mapper[i] = (e, v) => e.TRAN_AMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DFF_TID":
                        mapper[i] = (e, v) => e.DFF_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CRF_TID":
                        mapper[i] = (e, v) => e.CRF_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TO_INVOICE":
                        mapper[i] = (e, v) => e.TO_INVOICE = v;
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
        /// Merges <see cref="KSSB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KSSB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KSSB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KSSB}"/> of entities</returns>
        internal override IEnumerable<KSSB> ApplyDeltaEntities(IEnumerable<KSSB> Entities, List<KSSB> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<KSSB>>> Index_CRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KSSB>>> Index_SKEY;
        private Lazy<Dictionary<int, KSSB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSSB by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find KSSB</param>
        /// <returns>List of related KSSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSSB> FindByCRKEY(string CRKEY)
        {
            return Index_CRKEY.Value[CRKEY];
        }

        /// <summary>
        /// Attempt to find KSSB by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find KSSB</param>
        /// <param name="Value">List of related KSSB entities</param>
        /// <returns>True if the list of related KSSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCRKEY(string CRKEY, out IReadOnlyList<KSSB> Value)
        {
            return Index_CRKEY.Value.TryGetValue(CRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSSB by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find KSSB</param>
        /// <returns>List of related KSSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSSB> TryFindByCRKEY(string CRKEY)
        {
            IReadOnlyList<KSSB> value;
            if (Index_CRKEY.Value.TryGetValue(CRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KSSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find KSSB</param>
        /// <returns>List of related KSSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSSB> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find KSSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find KSSB</param>
        /// <param name="Value">List of related KSSB entities</param>
        /// <returns>True if the list of related KSSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<KSSB> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find KSSB</param>
        /// <returns>List of related KSSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KSSB> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<KSSB> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KSSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KSSB</param>
        /// <returns>Related KSSB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSSB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KSSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KSSB</param>
        /// <param name="Value">Related KSSB entity</param>
        /// <returns>True if the related KSSB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KSSB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KSSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KSSB</param>
        /// <returns>Related KSSB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSSB TryFindByTID(int TID)
        {
            KSSB value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KSSB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSSB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSSB](
        [TID] int IDENTITY NOT NULL,
        [TRAN_ID] varchar(20) NULL,
        [CRKEY] varchar(10) NULL,
        [SKEY] varchar(10) NULL,
        [TRDATE] datetime NULL,
        [ONLINE_VOUCHER] varchar(20) NULL,
        [VOUCHER_CODE] varchar(20) NULL,
        [ITEM_CATEGORY] varchar(20) NULL,
        [TRAN_TYPE] varchar(20) NULL,
        [TRAN_AMT] money NULL,
        [DFF_TID] int NULL,
        [CRF_TID] int NULL,
        [TO_INVOICE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSSB_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KSSB_Index_CRKEY] ON [dbo].[KSSB]
    (
            [CRKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [KSSB_Index_SKEY] ON [dbo].[KSSB]
    (
            [SKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KSSB]') AND name = N'KSSB_Index_CRKEY')
    ALTER INDEX [KSSB_Index_CRKEY] ON [dbo].[KSSB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KSSB]') AND name = N'KSSB_Index_SKEY')
    ALTER INDEX [KSSB_Index_SKEY] ON [dbo].[KSSB] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KSSB]') AND name = N'KSSB_Index_CRKEY')
    ALTER INDEX [KSSB_Index_CRKEY] ON [dbo].[KSSB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KSSB]') AND name = N'KSSB_Index_SKEY')
    ALTER INDEX [KSSB_Index_SKEY] ON [dbo].[KSSB] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KSSB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KSSB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KSSB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KSSB] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the KSSB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSSB data set</returns>
        public override EduHubDataSetDataReader<KSSB> GetDataSetDataReader()
        {
            return new KSSBDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSSB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSSB data set</returns>
        public override EduHubDataSetDataReader<KSSB> GetDataSetDataReader(List<KSSB> Entities)
        {
            return new KSSBDataReader(new EduHubDataSetLoadedReader<KSSB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSSBDataReader : EduHubDataSetDataReader<KSSB>
        {
            public KSSBDataReader(IEduHubDataSetReader<KSSB> Reader)
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
                    case 1: // TRAN_ID
                        return Current.TRAN_ID;
                    case 2: // CRKEY
                        return Current.CRKEY;
                    case 3: // SKEY
                        return Current.SKEY;
                    case 4: // TRDATE
                        return Current.TRDATE;
                    case 5: // ONLINE_VOUCHER
                        return Current.ONLINE_VOUCHER;
                    case 6: // VOUCHER_CODE
                        return Current.VOUCHER_CODE;
                    case 7: // ITEM_CATEGORY
                        return Current.ITEM_CATEGORY;
                    case 8: // TRAN_TYPE
                        return Current.TRAN_TYPE;
                    case 9: // TRAN_AMT
                        return Current.TRAN_AMT;
                    case 10: // DFF_TID
                        return Current.DFF_TID;
                    case 11: // CRF_TID
                        return Current.CRF_TID;
                    case 12: // TO_INVOICE
                        return Current.TO_INVOICE;
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
                    case 1: // TRAN_ID
                        return Current.TRAN_ID == null;
                    case 2: // CRKEY
                        return Current.CRKEY == null;
                    case 3: // SKEY
                        return Current.SKEY == null;
                    case 4: // TRDATE
                        return Current.TRDATE == null;
                    case 5: // ONLINE_VOUCHER
                        return Current.ONLINE_VOUCHER == null;
                    case 6: // VOUCHER_CODE
                        return Current.VOUCHER_CODE == null;
                    case 7: // ITEM_CATEGORY
                        return Current.ITEM_CATEGORY == null;
                    case 8: // TRAN_TYPE
                        return Current.TRAN_TYPE == null;
                    case 9: // TRAN_AMT
                        return Current.TRAN_AMT == null;
                    case 10: // DFF_TID
                        return Current.DFF_TID == null;
                    case 11: // CRF_TID
                        return Current.CRF_TID == null;
                    case 12: // TO_INVOICE
                        return Current.TO_INVOICE == null;
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
                    case 1: // TRAN_ID
                        return "TRAN_ID";
                    case 2: // CRKEY
                        return "CRKEY";
                    case 3: // SKEY
                        return "SKEY";
                    case 4: // TRDATE
                        return "TRDATE";
                    case 5: // ONLINE_VOUCHER
                        return "ONLINE_VOUCHER";
                    case 6: // VOUCHER_CODE
                        return "VOUCHER_CODE";
                    case 7: // ITEM_CATEGORY
                        return "ITEM_CATEGORY";
                    case 8: // TRAN_TYPE
                        return "TRAN_TYPE";
                    case 9: // TRAN_AMT
                        return "TRAN_AMT";
                    case 10: // DFF_TID
                        return "DFF_TID";
                    case 11: // CRF_TID
                        return "CRF_TID";
                    case 12: // TO_INVOICE
                        return "TO_INVOICE";
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
                    case "TRAN_ID":
                        return 1;
                    case "CRKEY":
                        return 2;
                    case "SKEY":
                        return 3;
                    case "TRDATE":
                        return 4;
                    case "ONLINE_VOUCHER":
                        return 5;
                    case "VOUCHER_CODE":
                        return 6;
                    case "ITEM_CATEGORY":
                        return 7;
                    case "TRAN_TYPE":
                        return 8;
                    case "TRAN_AMT":
                        return 9;
                    case "DFF_TID":
                        return 10;
                    case "CRF_TID":
                        return 11;
                    case "TO_INVOICE":
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
