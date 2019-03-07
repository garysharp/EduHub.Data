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
    /// Employee Leave Audit Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PELADataSet : EduHubDataSet<PELA>
    {
        /// <inheritdoc />
        public override string Name { get { return "PELA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PELADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PELA>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
            Index_PEKEY = new Lazy<Dictionary<string, IReadOnlyList<PELA>>>(() => this.ToGroupedDictionary(i => i.PEKEY));
            Index_TID = new Lazy<Dictionary<int, PELA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PELA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PELA" /> fields for each CSV column header</returns>
        internal override Action<PELA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PELA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_STARTDATE":
                        mapper[i] = (e, v) => e.LEAVE_STARTDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_CALC_DATE":
                        mapper[i] = (e, v) => e.LAST_CALC_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LAST_ANNIV_DATE":
                        mapper[i] = (e, v) => e.LAST_ANNIV_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ANNIVERSARY_DATE":
                        mapper[i] = (e, v) => e.ANNIVERSARY_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LEAVE_ENT_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_ENT_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_PRORATA_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_PRORATA_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH_STEP":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PENALTY_DAYS":
                        mapper[i] = (e, v) => e.PENALTY_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATE_START":
                        mapper[i] = (e, v) => e.DATE_START = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DATE_END":
                        mapper[i] = (e, v) => e.DATE_END = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CHANGE_TYPE":
                        mapper[i] = (e, v) => e.CHANGE_TYPE = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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
        /// Merges <see cref="PELA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PELA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PELA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PELA}"/> of entities</returns>
        internal override IEnumerable<PELA> ApplyDeltaEntities(IEnumerable<PELA> Entities, List<PELA> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PEKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.PEKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PELA>>> Index_LEAVE_CODE;
        private Lazy<Dictionary<string, IReadOnlyList<PELA>>> Index_PEKEY;
        private Lazy<Dictionary<int, PELA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <returns>List of related PELA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <param name="Value">List of related PELA entities</param>
        /// <returns>True if the list of related PELA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PELA> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELA</param>
        /// <returns>List of related PELA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PELA> value;
            if (Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <returns>List of related PELA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> FindByPEKEY(string PEKEY)
        {
            return Index_PEKEY.Value[PEKEY];
        }

        /// <summary>
        /// Attempt to find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <param name="Value">List of related PELA entities</param>
        /// <returns>True if the list of related PELA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPEKEY(string PEKEY, out IReadOnlyList<PELA> Value)
        {
            return Index_PEKEY.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELA</param>
        /// <returns>List of related PELA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELA> TryFindByPEKEY(string PEKEY)
        {
            IReadOnlyList<PELA> value;
            if (Index_PEKEY.Value.TryGetValue(PEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <returns>Related PELA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <param name="Value">Related PELA entity</param>
        /// <returns>True if the related PELA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PELA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PELA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELA</param>
        /// <returns>Related PELA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELA TryFindByTID(int TID)
        {
            PELA value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PELA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PELA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PELA](
        [TID] int IDENTITY NOT NULL,
        [PEKEY] varchar(10) NOT NULL,
        [LEAVE_CODE] varchar(8) NULL,
        [TRQTY] float NULL,
        [LEAVE_STARTDATE] datetime NULL,
        [LAST_CALC_DATE] datetime NULL,
        [LAST_ANNIV_DATE] datetime NULL,
        [ANNIVERSARY_DATE] datetime NULL,
        [LEAVE_ENT_HOURS] float NULL,
        [LEAVE_PRORATA_HOURS] float NULL,
        [PERIOD_LENGTH_STEP] smallint NULL,
        [PENALTY_DAYS] smallint NULL,
        [DATE_START] datetime NULL,
        [DATE_END] datetime NULL,
        [CHANGE_TYPE] varchar(8) NULL,
        [COMMENTS] varchar(35) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PELA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PELA_Index_LEAVE_CODE] ON [dbo].[PELA]
    (
            [LEAVE_CODE] ASC
    );
    CREATE CLUSTERED INDEX [PELA_Index_PEKEY] ON [dbo].[PELA]
    (
            [PEKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PELA]') AND name = N'Index_LEAVE_CODE')
    ALTER INDEX [Index_LEAVE_CODE] ON [dbo].[PELA] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PELA]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PELA] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PELA]') AND name = N'Index_LEAVE_CODE')
    ALTER INDEX [Index_LEAVE_CODE] ON [dbo].[PELA] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PELA]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PELA] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PELA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PELA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PELA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PELA] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PELA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PELA data set</returns>
        public override EduHubDataSetDataReader<PELA> GetDataSetDataReader()
        {
            return new PELADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PELA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PELA data set</returns>
        public override EduHubDataSetDataReader<PELA> GetDataSetDataReader(List<PELA> Entities)
        {
            return new PELADataReader(new EduHubDataSetLoadedReader<PELA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PELADataReader : EduHubDataSetDataReader<PELA>
        {
            public PELADataReader(IEduHubDataSetReader<PELA> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 19; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // PEKEY
                        return Current.PEKEY;
                    case 2: // LEAVE_CODE
                        return Current.LEAVE_CODE;
                    case 3: // TRQTY
                        return Current.TRQTY;
                    case 4: // LEAVE_STARTDATE
                        return Current.LEAVE_STARTDATE;
                    case 5: // LAST_CALC_DATE
                        return Current.LAST_CALC_DATE;
                    case 6: // LAST_ANNIV_DATE
                        return Current.LAST_ANNIV_DATE;
                    case 7: // ANNIVERSARY_DATE
                        return Current.ANNIVERSARY_DATE;
                    case 8: // LEAVE_ENT_HOURS
                        return Current.LEAVE_ENT_HOURS;
                    case 9: // LEAVE_PRORATA_HOURS
                        return Current.LEAVE_PRORATA_HOURS;
                    case 10: // PERIOD_LENGTH_STEP
                        return Current.PERIOD_LENGTH_STEP;
                    case 11: // PENALTY_DAYS
                        return Current.PENALTY_DAYS;
                    case 12: // DATE_START
                        return Current.DATE_START;
                    case 13: // DATE_END
                        return Current.DATE_END;
                    case 14: // CHANGE_TYPE
                        return Current.CHANGE_TYPE;
                    case 15: // COMMENTS
                        return Current.COMMENTS;
                    case 16: // LW_DATE
                        return Current.LW_DATE;
                    case 17: // LW_TIME
                        return Current.LW_TIME;
                    case 18: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // LEAVE_CODE
                        return Current.LEAVE_CODE == null;
                    case 3: // TRQTY
                        return Current.TRQTY == null;
                    case 4: // LEAVE_STARTDATE
                        return Current.LEAVE_STARTDATE == null;
                    case 5: // LAST_CALC_DATE
                        return Current.LAST_CALC_DATE == null;
                    case 6: // LAST_ANNIV_DATE
                        return Current.LAST_ANNIV_DATE == null;
                    case 7: // ANNIVERSARY_DATE
                        return Current.ANNIVERSARY_DATE == null;
                    case 8: // LEAVE_ENT_HOURS
                        return Current.LEAVE_ENT_HOURS == null;
                    case 9: // LEAVE_PRORATA_HOURS
                        return Current.LEAVE_PRORATA_HOURS == null;
                    case 10: // PERIOD_LENGTH_STEP
                        return Current.PERIOD_LENGTH_STEP == null;
                    case 11: // PENALTY_DAYS
                        return Current.PENALTY_DAYS == null;
                    case 12: // DATE_START
                        return Current.DATE_START == null;
                    case 13: // DATE_END
                        return Current.DATE_END == null;
                    case 14: // CHANGE_TYPE
                        return Current.CHANGE_TYPE == null;
                    case 15: // COMMENTS
                        return Current.COMMENTS == null;
                    case 16: // LW_DATE
                        return Current.LW_DATE == null;
                    case 17: // LW_TIME
                        return Current.LW_TIME == null;
                    case 18: // LW_USER
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
                    case 1: // PEKEY
                        return "PEKEY";
                    case 2: // LEAVE_CODE
                        return "LEAVE_CODE";
                    case 3: // TRQTY
                        return "TRQTY";
                    case 4: // LEAVE_STARTDATE
                        return "LEAVE_STARTDATE";
                    case 5: // LAST_CALC_DATE
                        return "LAST_CALC_DATE";
                    case 6: // LAST_ANNIV_DATE
                        return "LAST_ANNIV_DATE";
                    case 7: // ANNIVERSARY_DATE
                        return "ANNIVERSARY_DATE";
                    case 8: // LEAVE_ENT_HOURS
                        return "LEAVE_ENT_HOURS";
                    case 9: // LEAVE_PRORATA_HOURS
                        return "LEAVE_PRORATA_HOURS";
                    case 10: // PERIOD_LENGTH_STEP
                        return "PERIOD_LENGTH_STEP";
                    case 11: // PENALTY_DAYS
                        return "PENALTY_DAYS";
                    case 12: // DATE_START
                        return "DATE_START";
                    case 13: // DATE_END
                        return "DATE_END";
                    case 14: // CHANGE_TYPE
                        return "CHANGE_TYPE";
                    case 15: // COMMENTS
                        return "COMMENTS";
                    case 16: // LW_DATE
                        return "LW_DATE";
                    case 17: // LW_TIME
                        return "LW_TIME";
                    case 18: // LW_USER
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
                    case "PEKEY":
                        return 1;
                    case "LEAVE_CODE":
                        return 2;
                    case "TRQTY":
                        return 3;
                    case "LEAVE_STARTDATE":
                        return 4;
                    case "LAST_CALC_DATE":
                        return 5;
                    case "LAST_ANNIV_DATE":
                        return 6;
                    case "ANNIVERSARY_DATE":
                        return 7;
                    case "LEAVE_ENT_HOURS":
                        return 8;
                    case "LEAVE_PRORATA_HOURS":
                        return 9;
                    case "PERIOD_LENGTH_STEP":
                        return 10;
                    case "PENALTY_DAYS":
                        return 11;
                    case "DATE_START":
                        return 12;
                    case "DATE_END":
                        return 13;
                    case "CHANGE_TYPE":
                        return 14;
                    case "COMMENTS":
                        return 15;
                    case "LW_DATE":
                        return 16;
                    case "LW_TIME":
                        return 17;
                    case "LW_USER":
                        return 18;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
