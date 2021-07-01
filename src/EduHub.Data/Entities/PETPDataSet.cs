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
    /// Termination Payment Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PETPDataSet : EduHubDataSet<PETP>
    {
        /// <inheritdoc />
        public override string Name { get { return "PETP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PETPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PETP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PETP>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_TID = new Lazy<Dictionary<int, PETP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PETP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PETP" /> fields for each CSV column header</returns>
        internal override Action<PETP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PETP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PAYITEM":
                        mapper[i] = (e, v) => e.PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PEFTID":
                        mapper[i] = (e, v) => e.PEFTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "DEATH_BENEFIT":
                        mapper[i] = (e, v) => e.DEATH_BENEFIT = v;
                        break;
                    case "BENEFIT_TYPE":
                        mapper[i] = (e, v) => e.BENEFIT_TYPE = v;
                        break;
                    case "TRANSITIONAL":
                        mapper[i] = (e, v) => e.TRANSITIONAL = v;
                        break;
                    case "RELATED":
                        mapper[i] = (e, v) => e.RELATED = v;
                        break;
                    case "ETP_CODE":
                        mapper[i] = (e, v) => e.ETP_CODE = v;
                        break;
                    case "TAX_RATE":
                        mapper[i] = (e, v) => e.TAX_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PATCH_RECORD":
                        mapper[i] = (e, v) => e.PATCH_RECORD = v;
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
        /// Merges <see cref="PETP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PETP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PETP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PETP}"/> of entities</returns>
        internal override IEnumerable<PETP> ApplyDeltaEntities(IEnumerable<PETP> Entities, List<PETP> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<PETP>>> Index_CODE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PETP>>> Index_PAYITEM;
        private Lazy<Dictionary<int, PETP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PETP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PETP</param>
        /// <returns>List of related PETP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PETP> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PETP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PETP</param>
        /// <param name="Value">List of related PETP entities</param>
        /// <returns>True if the list of related PETP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PETP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PETP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PETP</param>
        /// <returns>List of related PETP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PETP> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PETP> value;
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
        /// Find PETP by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PETP</param>
        /// <returns>List of related PETP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PETP> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PETP by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PETP</param>
        /// <param name="Value">List of related PETP entities</param>
        /// <returns>True if the list of related PETP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PETP> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PETP by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PETP</param>
        /// <returns>List of related PETP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PETP> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PETP> value;
            if (Index_PAYITEM.Value.TryGetValue(PAYITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PETP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PETP</param>
        /// <returns>Related PETP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PETP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PETP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PETP</param>
        /// <param name="Value">Related PETP entity</param>
        /// <returns>True if the related PETP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PETP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PETP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PETP</param>
        /// <returns>Related PETP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PETP TryFindByTID(int TID)
        {
            PETP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PETP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PETP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PETP](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [PAYITEM] smallint NULL,
        [PEFTID] int NULL,
        [DEATH_BENEFIT] varchar(1) NULL,
        [BENEFIT_TYPE] varchar(1) NULL,
        [TRANSITIONAL] varchar(1) NULL,
        [RELATED] varchar(1) NULL,
        [ETP_CODE] varchar(1) NULL,
        [TAX_RATE] float NULL,
        [PATCH_RECORD] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PETP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PETP_Index_CODE] ON [dbo].[PETP]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PETP_Index_PAYITEM] ON [dbo].[PETP]
    (
            [PAYITEM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PETP]') AND name = N'Index_PAYITEM')
    ALTER INDEX [Index_PAYITEM] ON [dbo].[PETP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PETP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PETP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PETP]') AND name = N'Index_PAYITEM')
    ALTER INDEX [Index_PAYITEM] ON [dbo].[PETP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PETP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PETP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PETP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PETP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PETP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PETP] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PETP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PETP data set</returns>
        public override EduHubDataSetDataReader<PETP> GetDataSetDataReader()
        {
            return new PETPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PETP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PETP data set</returns>
        public override EduHubDataSetDataReader<PETP> GetDataSetDataReader(List<PETP> Entities)
        {
            return new PETPDataReader(new EduHubDataSetLoadedReader<PETP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PETPDataReader : EduHubDataSetDataReader<PETP>
        {
            public PETPDataReader(IEduHubDataSetReader<PETP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // PAYITEM
                        return Current.PAYITEM;
                    case 3: // PEFTID
                        return Current.PEFTID;
                    case 4: // DEATH_BENEFIT
                        return Current.DEATH_BENEFIT;
                    case 5: // BENEFIT_TYPE
                        return Current.BENEFIT_TYPE;
                    case 6: // TRANSITIONAL
                        return Current.TRANSITIONAL;
                    case 7: // RELATED
                        return Current.RELATED;
                    case 8: // ETP_CODE
                        return Current.ETP_CODE;
                    case 9: // TAX_RATE
                        return Current.TAX_RATE;
                    case 10: // PATCH_RECORD
                        return Current.PATCH_RECORD;
                    case 11: // LW_DATE
                        return Current.LW_DATE;
                    case 12: // LW_TIME
                        return Current.LW_TIME;
                    case 13: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PAYITEM
                        return Current.PAYITEM == null;
                    case 3: // PEFTID
                        return Current.PEFTID == null;
                    case 4: // DEATH_BENEFIT
                        return Current.DEATH_BENEFIT == null;
                    case 5: // BENEFIT_TYPE
                        return Current.BENEFIT_TYPE == null;
                    case 6: // TRANSITIONAL
                        return Current.TRANSITIONAL == null;
                    case 7: // RELATED
                        return Current.RELATED == null;
                    case 8: // ETP_CODE
                        return Current.ETP_CODE == null;
                    case 9: // TAX_RATE
                        return Current.TAX_RATE == null;
                    case 10: // PATCH_RECORD
                        return Current.PATCH_RECORD == null;
                    case 11: // LW_DATE
                        return Current.LW_DATE == null;
                    case 12: // LW_TIME
                        return Current.LW_TIME == null;
                    case 13: // LW_USER
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
                    case 2: // PAYITEM
                        return "PAYITEM";
                    case 3: // PEFTID
                        return "PEFTID";
                    case 4: // DEATH_BENEFIT
                        return "DEATH_BENEFIT";
                    case 5: // BENEFIT_TYPE
                        return "BENEFIT_TYPE";
                    case 6: // TRANSITIONAL
                        return "TRANSITIONAL";
                    case 7: // RELATED
                        return "RELATED";
                    case 8: // ETP_CODE
                        return "ETP_CODE";
                    case 9: // TAX_RATE
                        return "TAX_RATE";
                    case 10: // PATCH_RECORD
                        return "PATCH_RECORD";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
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
                    case "PAYITEM":
                        return 2;
                    case "PEFTID":
                        return 3;
                    case "DEATH_BENEFIT":
                        return 4;
                    case "BENEFIT_TYPE":
                        return 5;
                    case "TRANSITIONAL":
                        return 6;
                    case "RELATED":
                        return 7;
                    case "ETP_CODE":
                        return 8;
                    case "TAX_RATE":
                        return 9;
                    case "PATCH_RECORD":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
