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
    /// PRMS Order Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPRMSDataSet : EduHubDataSet<KPRMS>
    {
        /// <inheritdoc />
        public override string Name { get { return "KPRMS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KPRMSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KPRMS>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPRMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPRMS" /> fields for each CSV column header</returns>
        internal override Action<KPRMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPRMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PRMS_ORDERNO":
                        mapper[i] = (e, v) => e.PRMS_ORDERNO = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ORDER_LINENO":
                        mapper[i] = (e, v) => e.ORDER_LINENO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ORDER_DESC":
                        mapper[i] = (e, v) => e.ORDER_DESC = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "GLSUBPROG":
                        mapper[i] = (e, v) => e.GLSUBPROG = v;
                        break;
                    case "GLINIT":
                        mapper[i] = (e, v) => e.GLINIT = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "GST_CODE":
                        mapper[i] = (e, v) => e.GST_CODE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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
        /// Merges <see cref="KPRMS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KPRMS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KPRMS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KPRMS}"/> of entities</returns>
        internal override IEnumerable<KPRMS> ApplyDeltaEntities(IEnumerable<KPRMS> Entities, List<KPRMS> DeltaEntities)
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

        private Lazy<Dictionary<int, KPRMS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <returns>Related KPRMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPRMS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <param name="Value">Related KPRMS entity</param>
        /// <returns>True if the related KPRMS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KPRMS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KPRMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KPRMS</param>
        /// <returns>Related KPRMS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPRMS TryFindByTID(int TID)
        {
            KPRMS value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KPRMS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPRMS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPRMS](
        [TID] int IDENTITY NOT NULL,
        [PRMS_ORDERNO] varchar(10) NULL,
        [TRDATE] datetime NULL,
        [ORDER_LINENO] smallint NULL,
        [ORDER_DESC] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [GLSUBPROG] varchar(4) NULL,
        [GLINIT] varchar(3) NULL,
        [TRQTY] float NULL,
        [AMOUNT] money NULL,
        [CRKEY] varchar(10) NULL,
        [GST_CODE] varchar(4) NULL,
        [GST_RATE] money NULL,
        [ABN] varchar(15) NULL,
        [SCHOOL_ID] varchar(4) NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPRMS_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KPRMSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KPRMSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KPRMS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KPRMS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KPRMS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KPRMS] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the KPRMS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPRMS data set</returns>
        public override EduHubDataSetDataReader<KPRMS> GetDataSetDataReader()
        {
            return new KPRMSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPRMS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPRMS data set</returns>
        public override EduHubDataSetDataReader<KPRMS> GetDataSetDataReader(List<KPRMS> Entities)
        {
            return new KPRMSDataReader(new EduHubDataSetLoadedReader<KPRMS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPRMSDataReader : EduHubDataSetDataReader<KPRMS>
        {
            public KPRMSDataReader(IEduHubDataSetReader<KPRMS> Reader)
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
                    case 1: // PRMS_ORDERNO
                        return Current.PRMS_ORDERNO;
                    case 2: // TRDATE
                        return Current.TRDATE;
                    case 3: // ORDER_LINENO
                        return Current.ORDER_LINENO;
                    case 4: // ORDER_DESC
                        return Current.ORDER_DESC;
                    case 5: // GLCODE
                        return Current.GLCODE;
                    case 6: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 7: // GLSUBPROG
                        return Current.GLSUBPROG;
                    case 8: // GLINIT
                        return Current.GLINIT;
                    case 9: // TRQTY
                        return Current.TRQTY;
                    case 10: // AMOUNT
                        return Current.AMOUNT;
                    case 11: // CRKEY
                        return Current.CRKEY;
                    case 12: // GST_CODE
                        return Current.GST_CODE;
                    case 13: // GST_RATE
                        return Current.GST_RATE;
                    case 14: // ABN
                        return Current.ABN;
                    case 15: // SCHOOL_ID
                        return Current.SCHOOL_ID;
                    case 16: // DELETE_FLAG
                        return Current.DELETE_FLAG;
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
                    case 1: // PRMS_ORDERNO
                        return Current.PRMS_ORDERNO == null;
                    case 2: // TRDATE
                        return Current.TRDATE == null;
                    case 3: // ORDER_LINENO
                        return Current.ORDER_LINENO == null;
                    case 4: // ORDER_DESC
                        return Current.ORDER_DESC == null;
                    case 5: // GLCODE
                        return Current.GLCODE == null;
                    case 6: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 7: // GLSUBPROG
                        return Current.GLSUBPROG == null;
                    case 8: // GLINIT
                        return Current.GLINIT == null;
                    case 9: // TRQTY
                        return Current.TRQTY == null;
                    case 10: // AMOUNT
                        return Current.AMOUNT == null;
                    case 11: // CRKEY
                        return Current.CRKEY == null;
                    case 12: // GST_CODE
                        return Current.GST_CODE == null;
                    case 13: // GST_RATE
                        return Current.GST_RATE == null;
                    case 14: // ABN
                        return Current.ABN == null;
                    case 15: // SCHOOL_ID
                        return Current.SCHOOL_ID == null;
                    case 16: // DELETE_FLAG
                        return Current.DELETE_FLAG == null;
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
                    case 1: // PRMS_ORDERNO
                        return "PRMS_ORDERNO";
                    case 2: // TRDATE
                        return "TRDATE";
                    case 3: // ORDER_LINENO
                        return "ORDER_LINENO";
                    case 4: // ORDER_DESC
                        return "ORDER_DESC";
                    case 5: // GLCODE
                        return "GLCODE";
                    case 6: // GLPROGRAM
                        return "GLPROGRAM";
                    case 7: // GLSUBPROG
                        return "GLSUBPROG";
                    case 8: // GLINIT
                        return "GLINIT";
                    case 9: // TRQTY
                        return "TRQTY";
                    case 10: // AMOUNT
                        return "AMOUNT";
                    case 11: // CRKEY
                        return "CRKEY";
                    case 12: // GST_CODE
                        return "GST_CODE";
                    case 13: // GST_RATE
                        return "GST_RATE";
                    case 14: // ABN
                        return "ABN";
                    case 15: // SCHOOL_ID
                        return "SCHOOL_ID";
                    case 16: // DELETE_FLAG
                        return "DELETE_FLAG";
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
                    case "PRMS_ORDERNO":
                        return 1;
                    case "TRDATE":
                        return 2;
                    case "ORDER_LINENO":
                        return 3;
                    case "ORDER_DESC":
                        return 4;
                    case "GLCODE":
                        return 5;
                    case "GLPROGRAM":
                        return 6;
                    case "GLSUBPROG":
                        return 7;
                    case "GLINIT":
                        return 8;
                    case "TRQTY":
                        return 9;
                    case "AMOUNT":
                        return 10;
                    case "CRKEY":
                        return 11;
                    case "GST_CODE":
                        return 12;
                    case "GST_RATE":
                        return 13;
                    case "ABN":
                        return 14;
                    case "SCHOOL_ID":
                        return 15;
                    case "DELETE_FLAG":
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
