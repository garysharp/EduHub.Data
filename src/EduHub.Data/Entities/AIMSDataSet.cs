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
    /// AIMS Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AIMSDataSet : EduHubDataSet<AIMS>
    {
        /// <inheritdoc />
        public override string Name { get { return "AIMS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal AIMSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AIMSKEY = new Lazy<NullDictionary<string, IReadOnlyList<AIMS>>>(() => this.ToGroupedNullDictionary(i => i.AIMSKEY));
            Index_TID = new Lazy<Dictionary<int, AIMS>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AIMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AIMS" /> fields for each CSV column header</returns>
        internal override Action<AIMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AIMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "AIMSKEY":
                        mapper[i] = (e, v) => e.AIMSKEY = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ORDERID":
                        mapper[i] = (e, v) => e.ORDERID = v;
                        break;
                    case "ORDER_AMT":
                        mapper[i] = (e, v) => e.ORDER_AMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "LINE":
                        mapper[i] = (e, v) => e.LINE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_CA":
                        mapper[i] = (e, v) => e.GST_CA = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MATCHABLE":
                        mapper[i] = (e, v) => e.MATCHABLE = v;
                        break;
                    case "MATCH_OUTCOME":
                        mapper[i] = (e, v) => e.MATCH_OUTCOME = v;
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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
        /// Merges <see cref="AIMS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AIMS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AIMS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AIMS}"/> of entities</returns>
        internal override IEnumerable<AIMS> ApplyDeltaEntities(IEnumerable<AIMS> Entities, List<AIMS> DeltaEntities)
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

        private Lazy<NullDictionary<string, IReadOnlyList<AIMS>>> Index_AIMSKEY;
        private Lazy<Dictionary<int, AIMS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AIMS by AIMSKEY field
        /// </summary>
        /// <param name="AIMSKEY">AIMSKEY value used to find AIMS</param>
        /// <returns>List of related AIMS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AIMS> FindByAIMSKEY(string AIMSKEY)
        {
            return Index_AIMSKEY.Value[AIMSKEY];
        }

        /// <summary>
        /// Attempt to find AIMS by AIMSKEY field
        /// </summary>
        /// <param name="AIMSKEY">AIMSKEY value used to find AIMS</param>
        /// <param name="Value">List of related AIMS entities</param>
        /// <returns>True if the list of related AIMS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAIMSKEY(string AIMSKEY, out IReadOnlyList<AIMS> Value)
        {
            return Index_AIMSKEY.Value.TryGetValue(AIMSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find AIMS by AIMSKEY field
        /// </summary>
        /// <param name="AIMSKEY">AIMSKEY value used to find AIMS</param>
        /// <returns>List of related AIMS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AIMS> TryFindByAIMSKEY(string AIMSKEY)
        {
            IReadOnlyList<AIMS> value;
            if (Index_AIMSKEY.Value.TryGetValue(AIMSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AIMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AIMS</param>
        /// <returns>Related AIMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AIMS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find AIMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AIMS</param>
        /// <param name="Value">Related AIMS entity</param>
        /// <returns>True if the related AIMS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out AIMS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find AIMS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find AIMS</param>
        /// <returns>Related AIMS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AIMS TryFindByTID(int TID)
        {
            AIMS value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AIMS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AIMS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AIMS](
        [TID] int IDENTITY NOT NULL,
        [CRKEY] varchar(10) NULL,
        [AIMSKEY] varchar(20) NULL,
        [NAME] varchar(50) NULL,
        [ADDRESS01] varchar(50) NULL,
        [ADDRESS02] varchar(50) NULL,
        [SUBURB] varchar(50) NULL,
        [STATE] varchar(4) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [ABN] varchar(15) NULL,
        [MOBILE] varchar(20) NULL,
        [EMAIL] varchar(60) NULL,
        [TRDATE] datetime NULL,
        [ORDERID] varchar(20) NULL,
        [ORDER_AMT] money NULL,
        [GST_TYPE] varchar(4) NULL,
        [LINE] smallint NULL,
        [DESCRIPTION] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [INITIATIVE] varchar(3) NULL,
        [GST_RATE] float NULL,
        [GST_CA] varchar(20) NULL,
        [TRQTY] smallint NULL,
        [MATCHABLE] varchar(1) NULL,
        [MATCH_OUTCOME] varchar(1) NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AIMS_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [AIMS_Index_AIMSKEY] ON [dbo].[AIMS]
    (
            [AIMSKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AIMS]') AND name = N'AIMS_Index_AIMSKEY')
    ALTER INDEX [AIMS_Index_AIMSKEY] ON [dbo].[AIMS] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AIMS]') AND name = N'AIMS_Index_AIMSKEY')
    ALTER INDEX [AIMS_Index_AIMSKEY] ON [dbo].[AIMS] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AIMS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AIMS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AIMS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[AIMS] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the AIMS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AIMS data set</returns>
        public override EduHubDataSetDataReader<AIMS> GetDataSetDataReader()
        {
            return new AIMSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AIMS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AIMS data set</returns>
        public override EduHubDataSetDataReader<AIMS> GetDataSetDataReader(List<AIMS> Entities)
        {
            return new AIMSDataReader(new EduHubDataSetLoadedReader<AIMS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AIMSDataReader : EduHubDataSetDataReader<AIMS>
        {
            public AIMSDataReader(IEduHubDataSetReader<AIMS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 33; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CRKEY
                        return Current.CRKEY;
                    case 2: // AIMSKEY
                        return Current.AIMSKEY;
                    case 3: // NAME
                        return Current.NAME;
                    case 4: // ADDRESS01
                        return Current.ADDRESS01;
                    case 5: // ADDRESS02
                        return Current.ADDRESS02;
                    case 6: // SUBURB
                        return Current.SUBURB;
                    case 7: // STATE
                        return Current.STATE;
                    case 8: // POSTCODE
                        return Current.POSTCODE;
                    case 9: // TELEPHONE
                        return Current.TELEPHONE;
                    case 10: // FAX
                        return Current.FAX;
                    case 11: // ABN
                        return Current.ABN;
                    case 12: // MOBILE
                        return Current.MOBILE;
                    case 13: // EMAIL
                        return Current.EMAIL;
                    case 14: // TRDATE
                        return Current.TRDATE;
                    case 15: // ORDERID
                        return Current.ORDERID;
                    case 16: // ORDER_AMT
                        return Current.ORDER_AMT;
                    case 17: // GST_TYPE
                        return Current.GST_TYPE;
                    case 18: // LINE
                        return Current.LINE;
                    case 19: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 20: // GLCODE
                        return Current.GLCODE;
                    case 21: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 22: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 23: // INITIATIVE
                        return Current.INITIATIVE;
                    case 24: // GST_RATE
                        return Current.GST_RATE;
                    case 25: // GST_CA
                        return Current.GST_CA;
                    case 26: // TRQTY
                        return Current.TRQTY;
                    case 27: // MATCHABLE
                        return Current.MATCHABLE;
                    case 28: // MATCH_OUTCOME
                        return Current.MATCH_OUTCOME;
                    case 29: // DELETE_FLAG
                        return Current.DELETE_FLAG;
                    case 30: // LW_DATE
                        return Current.LW_DATE;
                    case 31: // LW_TIME
                        return Current.LW_TIME;
                    case 32: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // CRKEY
                        return Current.CRKEY == null;
                    case 2: // AIMSKEY
                        return Current.AIMSKEY == null;
                    case 3: // NAME
                        return Current.NAME == null;
                    case 4: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 5: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 6: // SUBURB
                        return Current.SUBURB == null;
                    case 7: // STATE
                        return Current.STATE == null;
                    case 8: // POSTCODE
                        return Current.POSTCODE == null;
                    case 9: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 10: // FAX
                        return Current.FAX == null;
                    case 11: // ABN
                        return Current.ABN == null;
                    case 12: // MOBILE
                        return Current.MOBILE == null;
                    case 13: // EMAIL
                        return Current.EMAIL == null;
                    case 14: // TRDATE
                        return Current.TRDATE == null;
                    case 15: // ORDERID
                        return Current.ORDERID == null;
                    case 16: // ORDER_AMT
                        return Current.ORDER_AMT == null;
                    case 17: // GST_TYPE
                        return Current.GST_TYPE == null;
                    case 18: // LINE
                        return Current.LINE == null;
                    case 19: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 20: // GLCODE
                        return Current.GLCODE == null;
                    case 21: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 22: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 23: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 24: // GST_RATE
                        return Current.GST_RATE == null;
                    case 25: // GST_CA
                        return Current.GST_CA == null;
                    case 26: // TRQTY
                        return Current.TRQTY == null;
                    case 27: // MATCHABLE
                        return Current.MATCHABLE == null;
                    case 28: // MATCH_OUTCOME
                        return Current.MATCH_OUTCOME == null;
                    case 29: // DELETE_FLAG
                        return Current.DELETE_FLAG == null;
                    case 30: // LW_DATE
                        return Current.LW_DATE == null;
                    case 31: // LW_TIME
                        return Current.LW_TIME == null;
                    case 32: // LW_USER
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
                    case 1: // CRKEY
                        return "CRKEY";
                    case 2: // AIMSKEY
                        return "AIMSKEY";
                    case 3: // NAME
                        return "NAME";
                    case 4: // ADDRESS01
                        return "ADDRESS01";
                    case 5: // ADDRESS02
                        return "ADDRESS02";
                    case 6: // SUBURB
                        return "SUBURB";
                    case 7: // STATE
                        return "STATE";
                    case 8: // POSTCODE
                        return "POSTCODE";
                    case 9: // TELEPHONE
                        return "TELEPHONE";
                    case 10: // FAX
                        return "FAX";
                    case 11: // ABN
                        return "ABN";
                    case 12: // MOBILE
                        return "MOBILE";
                    case 13: // EMAIL
                        return "EMAIL";
                    case 14: // TRDATE
                        return "TRDATE";
                    case 15: // ORDERID
                        return "ORDERID";
                    case 16: // ORDER_AMT
                        return "ORDER_AMT";
                    case 17: // GST_TYPE
                        return "GST_TYPE";
                    case 18: // LINE
                        return "LINE";
                    case 19: // DESCRIPTION
                        return "DESCRIPTION";
                    case 20: // GLCODE
                        return "GLCODE";
                    case 21: // GLPROGRAM
                        return "GLPROGRAM";
                    case 22: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 23: // INITIATIVE
                        return "INITIATIVE";
                    case 24: // GST_RATE
                        return "GST_RATE";
                    case 25: // GST_CA
                        return "GST_CA";
                    case 26: // TRQTY
                        return "TRQTY";
                    case 27: // MATCHABLE
                        return "MATCHABLE";
                    case 28: // MATCH_OUTCOME
                        return "MATCH_OUTCOME";
                    case 29: // DELETE_FLAG
                        return "DELETE_FLAG";
                    case 30: // LW_DATE
                        return "LW_DATE";
                    case 31: // LW_TIME
                        return "LW_TIME";
                    case 32: // LW_USER
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
                    case "CRKEY":
                        return 1;
                    case "AIMSKEY":
                        return 2;
                    case "NAME":
                        return 3;
                    case "ADDRESS01":
                        return 4;
                    case "ADDRESS02":
                        return 5;
                    case "SUBURB":
                        return 6;
                    case "STATE":
                        return 7;
                    case "POSTCODE":
                        return 8;
                    case "TELEPHONE":
                        return 9;
                    case "FAX":
                        return 10;
                    case "ABN":
                        return 11;
                    case "MOBILE":
                        return 12;
                    case "EMAIL":
                        return 13;
                    case "TRDATE":
                        return 14;
                    case "ORDERID":
                        return 15;
                    case "ORDER_AMT":
                        return 16;
                    case "GST_TYPE":
                        return 17;
                    case "LINE":
                        return 18;
                    case "DESCRIPTION":
                        return 19;
                    case "GLCODE":
                        return 20;
                    case "GLPROGRAM":
                        return 21;
                    case "SUBPROGRAM":
                        return 22;
                    case "INITIATIVE":
                        return 23;
                    case "GST_RATE":
                        return 24;
                    case "GST_CA":
                        return 25;
                    case "TRQTY":
                        return 26;
                    case "MATCHABLE":
                        return 27;
                    case "MATCH_OUTCOME":
                        return 28;
                    case "DELETE_FLAG":
                        return 29;
                    case "LW_DATE":
                        return 30;
                    case "LW_TIME":
                        return 31;
                    case "LW_USER":
                        return 32;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
