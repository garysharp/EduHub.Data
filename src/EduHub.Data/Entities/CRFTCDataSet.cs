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
    /// Creditor Fuel Tax Credits Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRFTCDataSet : EduHubDataSet<CRFTC>
    {
        /// <inheritdoc />
        public override string Name { get { return "CRFTC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal CRFTCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<CRFTC>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_FTC_CODE = new Lazy<NullDictionary<string, IReadOnlyList<CRFTC>>>(() => this.ToGroupedNullDictionary(i => i.FTC_CODE));
            Index_TID = new Lazy<Dictionary<int, CRFTC>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<CRFTC>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CRFTC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CRFTC" /> fields for each CSV column header</returns>
        internal override Action<CRFTC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CRFTC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "FUEL_TYPE":
                        mapper[i] = (e, v) => e.FUEL_TYPE = v;
                        break;
                    case "FTC_CODE":
                        mapper[i] = (e, v) => e.FTC_CODE = v;
                        break;
                    case "TOT_LITRES":
                        mapper[i] = (e, v) => e.TOT_LITRES = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_PERC":
                        mapper[i] = (e, v) => e.CLAIM_PERC = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_LITRES":
                        mapper[i] = (e, v) => e.CLAIM_LITRES = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_AMOUNT":
                        mapper[i] = (e, v) => e.CLAIM_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CLAIM_PERIOD":
                        mapper[i] = (e, v) => e.CLAIM_PERIOD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
        /// Merges <see cref="CRFTC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="CRFTC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="CRFTC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{CRFTC}"/> of entities</returns>
        internal override IEnumerable<CRFTC> ApplyDeltaEntities(IEnumerable<CRFTC> Entities, List<CRFTC> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<CRFTC>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<CRFTC>>> Index_FTC_CODE;
        private Lazy<Dictionary<int, CRFTC>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<CRFTC>>> Index_TRREF;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CRFTC by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find CRFTC by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRFTC</param>
        /// <param name="Value">List of related CRFTC entities</param>
        /// <returns>True if the list of related CRFTC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<CRFTC> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find CRFTC by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> TryFindByCODE(string CODE)
        {
            IReadOnlyList<CRFTC> value;
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
        /// Find CRFTC by FTC_CODE field
        /// </summary>
        /// <param name="FTC_CODE">FTC_CODE value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> FindByFTC_CODE(string FTC_CODE)
        {
            return Index_FTC_CODE.Value[FTC_CODE];
        }

        /// <summary>
        /// Attempt to find CRFTC by FTC_CODE field
        /// </summary>
        /// <param name="FTC_CODE">FTC_CODE value used to find CRFTC</param>
        /// <param name="Value">List of related CRFTC entities</param>
        /// <returns>True if the list of related CRFTC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFTC_CODE(string FTC_CODE, out IReadOnlyList<CRFTC> Value)
        {
            return Index_FTC_CODE.Value.TryGetValue(FTC_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find CRFTC by FTC_CODE field
        /// </summary>
        /// <param name="FTC_CODE">FTC_CODE value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> TryFindByFTC_CODE(string FTC_CODE)
        {
            IReadOnlyList<CRFTC> value;
            if (Index_FTC_CODE.Value.TryGetValue(FTC_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRFTC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRFTC</param>
        /// <returns>Related CRFTC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRFTC FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find CRFTC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRFTC</param>
        /// <param name="Value">Related CRFTC entity</param>
        /// <returns>True if the related CRFTC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out CRFTC Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find CRFTC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRFTC</param>
        /// <returns>Related CRFTC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRFTC TryFindByTID(int TID)
        {
            CRFTC value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRFTC by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find CRFTC by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRFTC</param>
        /// <param name="Value">List of related CRFTC entities</param>
        /// <returns>True if the list of related CRFTC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<CRFTC> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find CRFTC by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<CRFTC> value;
            if (Index_TRREF.Value.TryGetValue(TRREF, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a CRFTC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[CRFTC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[CRFTC](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRDATE] datetime NULL,
        [TRBATCH] int NULL,
        [TRREF] varchar(10) NULL,
        [FUEL_TYPE] varchar(5) NULL,
        [FTC_CODE] varchar(3) NULL,
        [TOT_LITRES] float NULL,
        [CLAIM_PERC] float NULL,
        [CLAIM_LITRES] float NULL,
        [CLAIM_AMOUNT] money NULL,
        [CLAIM_PERIOD] int NULL,
        [NOTES] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [CRFTC_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [CRFTC_Index_CODE] ON [dbo].[CRFTC]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [CRFTC_Index_FTC_CODE] ON [dbo].[CRFTC]
    (
            [FTC_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [CRFTC_Index_TRREF] ON [dbo].[CRFTC]
    (
            [TRREF] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRFTC]') AND name = N'Index_FTC_CODE')
    ALTER INDEX [Index_FTC_CODE] ON [dbo].[CRFTC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRFTC]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[CRFTC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRFTC]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[CRFTC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRFTC]') AND name = N'Index_FTC_CODE')
    ALTER INDEX [Index_FTC_CODE] ON [dbo].[CRFTC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRFTC]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[CRFTC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRFTC]') AND name = N'Index_TRREF')
    ALTER INDEX [Index_TRREF] ON [dbo].[CRFTC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="CRFTC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="CRFTC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<CRFTC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[CRFTC] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the CRFTC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRFTC data set</returns>
        public override EduHubDataSetDataReader<CRFTC> GetDataSetDataReader()
        {
            return new CRFTCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CRFTC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRFTC data set</returns>
        public override EduHubDataSetDataReader<CRFTC> GetDataSetDataReader(List<CRFTC> Entities)
        {
            return new CRFTCDataReader(new EduHubDataSetLoadedReader<CRFTC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class CRFTCDataReader : EduHubDataSetDataReader<CRFTC>
        {
            public CRFTCDataReader(IEduHubDataSetReader<CRFTC> Reader)
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
                    case 2: // TRDATE
                        return Current.TRDATE;
                    case 3: // TRBATCH
                        return Current.TRBATCH;
                    case 4: // TRREF
                        return Current.TRREF;
                    case 5: // FUEL_TYPE
                        return Current.FUEL_TYPE;
                    case 6: // FTC_CODE
                        return Current.FTC_CODE;
                    case 7: // TOT_LITRES
                        return Current.TOT_LITRES;
                    case 8: // CLAIM_PERC
                        return Current.CLAIM_PERC;
                    case 9: // CLAIM_LITRES
                        return Current.CLAIM_LITRES;
                    case 10: // CLAIM_AMOUNT
                        return Current.CLAIM_AMOUNT;
                    case 11: // CLAIM_PERIOD
                        return Current.CLAIM_PERIOD;
                    case 12: // NOTES
                        return Current.NOTES;
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
                    case 2: // TRDATE
                        return Current.TRDATE == null;
                    case 3: // TRBATCH
                        return Current.TRBATCH == null;
                    case 4: // TRREF
                        return Current.TRREF == null;
                    case 5: // FUEL_TYPE
                        return Current.FUEL_TYPE == null;
                    case 6: // FTC_CODE
                        return Current.FTC_CODE == null;
                    case 7: // TOT_LITRES
                        return Current.TOT_LITRES == null;
                    case 8: // CLAIM_PERC
                        return Current.CLAIM_PERC == null;
                    case 9: // CLAIM_LITRES
                        return Current.CLAIM_LITRES == null;
                    case 10: // CLAIM_AMOUNT
                        return Current.CLAIM_AMOUNT == null;
                    case 11: // CLAIM_PERIOD
                        return Current.CLAIM_PERIOD == null;
                    case 12: // NOTES
                        return Current.NOTES == null;
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
                    case 2: // TRDATE
                        return "TRDATE";
                    case 3: // TRBATCH
                        return "TRBATCH";
                    case 4: // TRREF
                        return "TRREF";
                    case 5: // FUEL_TYPE
                        return "FUEL_TYPE";
                    case 6: // FTC_CODE
                        return "FTC_CODE";
                    case 7: // TOT_LITRES
                        return "TOT_LITRES";
                    case 8: // CLAIM_PERC
                        return "CLAIM_PERC";
                    case 9: // CLAIM_LITRES
                        return "CLAIM_LITRES";
                    case 10: // CLAIM_AMOUNT
                        return "CLAIM_AMOUNT";
                    case 11: // CLAIM_PERIOD
                        return "CLAIM_PERIOD";
                    case 12: // NOTES
                        return "NOTES";
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
                    case "TRDATE":
                        return 2;
                    case "TRBATCH":
                        return 3;
                    case "TRREF":
                        return 4;
                    case "FUEL_TYPE":
                        return 5;
                    case "FTC_CODE":
                        return 6;
                    case "TOT_LITRES":
                        return 7;
                    case "CLAIM_PERC":
                        return 8;
                    case "CLAIM_LITRES":
                        return 9;
                    case "CLAIM_AMOUNT":
                        return 10;
                    case "CLAIM_PERIOD":
                        return 11;
                    case "NOTES":
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
