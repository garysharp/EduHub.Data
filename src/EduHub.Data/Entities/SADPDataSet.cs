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
    /// Accident Prevention Measures Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADPDataSet : EduHubDataSet<SADP>
    {
        /// <inheritdoc />
        public override string Name { get { return "SADP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SADPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACCIDENTID = new Lazy<Dictionary<int, IReadOnlyList<SADP>>>(() => this.ToGroupedDictionary(i => i.ACCIDENTID));
            Index_ACCIDENTID_PREVENTION = new Lazy<Dictionary<Tuple<int, short?>, SADP>>(() => this.ToDictionary(i => Tuple.Create(i.ACCIDENTID, i.PREVENTION)));
            Index_TID = new Lazy<Dictionary<int, SADP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADP" /> fields for each CSV column header</returns>
        internal override Action<SADP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = int.Parse(v);
                        break;
                    case "PREVENTION":
                        mapper[i] = (e, v) => e.PREVENTION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_PREV_INFO":
                        mapper[i] = (e, v) => e.OTHER_PREV_INFO = v;
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
        /// Merges <see cref="SADP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SADP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SADP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SADP}"/> of entities</returns>
        internal override IEnumerable<SADP> ApplyDeltaEntities(IEnumerable<SADP> Entities, List<SADP> DeltaEntities)
        {
            HashSet<Tuple<int, short?>> Index_ACCIDENTID_PREVENTION = new HashSet<Tuple<int, short?>>(DeltaEntities.Select(i => Tuple.Create(i.ACCIDENTID, i.PREVENTION)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ACCIDENTID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_ACCIDENTID_PREVENTION.Remove(Tuple.Create(entity.ACCIDENTID, entity.PREVENTION));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.ACCIDENTID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, IReadOnlyList<SADP>>> Index_ACCIDENTID;
        private Lazy<Dictionary<Tuple<int, short?>, SADP>> Index_ACCIDENTID_PREVENTION;
        private Lazy<Dictionary<int, SADP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <returns>List of related SADP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADP> FindByACCIDENTID(int ACCIDENTID)
        {
            return Index_ACCIDENTID.Value[ACCIDENTID];
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="Value">List of related SADP entities</param>
        /// <returns>True if the list of related SADP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID(int ACCIDENTID, out IReadOnlyList<SADP> Value)
        {
            return Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <returns>List of related SADP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SADP> TryFindByACCIDENTID(int ACCIDENTID)
        {
            IReadOnlyList<SADP> value;
            if (Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <returns>Related SADP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP FindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION)
        {
            return Index_ACCIDENTID_PREVENTION.Value[Tuple.Create(ACCIDENTID, PREVENTION)];
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <param name="Value">Related SADP entity</param>
        /// <returns>True if the related SADP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION, out SADP Value)
        {
            return Index_ACCIDENTID_PREVENTION.Value.TryGetValue(Tuple.Create(ACCIDENTID, PREVENTION), out Value);
        }

        /// <summary>
        /// Attempt to find SADP by ACCIDENTID and PREVENTION fields
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SADP</param>
        /// <param name="PREVENTION">PREVENTION value used to find SADP</param>
        /// <returns>Related SADP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP TryFindByACCIDENTID_PREVENTION(int ACCIDENTID, short? PREVENTION)
        {
            SADP value;
            if (Index_ACCIDENTID_PREVENTION.Value.TryGetValue(Tuple.Create(ACCIDENTID, PREVENTION), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <returns>Related SADP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <param name="Value">Related SADP entity</param>
        /// <returns>True if the related SADP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SADP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SADP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SADP</param>
        /// <returns>Related SADP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADP TryFindByTID(int TID)
        {
            SADP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SADP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SADP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SADP](
        [TID] int IDENTITY NOT NULL,
        [ACCIDENTID] int NOT NULL,
        [PREVENTION] smallint NULL,
        [OTHER_PREV_INFO] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SADP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SADP_Index_ACCIDENTID] ON [dbo].[SADP]
    (
            [ACCIDENTID] ASC
    );
    CREATE NONCLUSTERED INDEX [SADP_Index_ACCIDENTID_PREVENTION] ON [dbo].[SADP]
    (
            [ACCIDENTID] ASC,
            [PREVENTION] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SADP]') AND name = N'Index_ACCIDENTID_PREVENTION')
    ALTER INDEX [Index_ACCIDENTID_PREVENTION] ON [dbo].[SADP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SADP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SADP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SADP]') AND name = N'Index_ACCIDENTID_PREVENTION')
    ALTER INDEX [Index_ACCIDENTID_PREVENTION] ON [dbo].[SADP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SADP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SADP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SADP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SADP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SADP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<int, short?>> Index_ACCIDENTID_PREVENTION = new List<Tuple<int, short?>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ACCIDENTID_PREVENTION.Add(Tuple.Create(entity.ACCIDENTID, entity.PREVENTION));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SADP] WHERE");


            // Index_ACCIDENTID_PREVENTION
            builder.Append("(");
            for (int index = 0; index < Index_ACCIDENTID_PREVENTION.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // ACCIDENTID
                var parameterACCIDENTID = $"@p{parameterIndex++}";
                builder.Append("([ACCIDENTID]=").Append(parameterACCIDENTID);
                command.Parameters.Add(parameterACCIDENTID, SqlDbType.Int).Value = Index_ACCIDENTID_PREVENTION[index].Item1;

                // PREVENTION
                if (Index_ACCIDENTID_PREVENTION[index].Item2 == null)
                {
                    builder.Append(" AND [PREVENTION] IS NULL)");
                }
                else
                {
                    var parameterPREVENTION = $"@p{parameterIndex++}";
                    builder.Append(" AND [PREVENTION]=").Append(parameterPREVENTION).Append(")");
                    command.Parameters.Add(parameterPREVENTION, SqlDbType.SmallInt).Value = Index_ACCIDENTID_PREVENTION[index].Item2;
                }
            }
            builder.AppendLine(") OR");

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
        /// Provides a <see cref="IDataReader"/> for the SADP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADP data set</returns>
        public override EduHubDataSetDataReader<SADP> GetDataSetDataReader()
        {
            return new SADPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SADP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADP data set</returns>
        public override EduHubDataSetDataReader<SADP> GetDataSetDataReader(List<SADP> Entities)
        {
            return new SADPDataReader(new EduHubDataSetLoadedReader<SADP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SADPDataReader : EduHubDataSetDataReader<SADP>
        {
            public SADPDataReader(IEduHubDataSetReader<SADP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ACCIDENTID
                        return Current.ACCIDENTID;
                    case 2: // PREVENTION
                        return Current.PREVENTION;
                    case 3: // OTHER_PREV_INFO
                        return Current.OTHER_PREV_INFO;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PREVENTION
                        return Current.PREVENTION == null;
                    case 3: // OTHER_PREV_INFO
                        return Current.OTHER_PREV_INFO == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
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
                    case 1: // ACCIDENTID
                        return "ACCIDENTID";
                    case 2: // PREVENTION
                        return "PREVENTION";
                    case 3: // OTHER_PREV_INFO
                        return "OTHER_PREV_INFO";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
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
                    case "ACCIDENTID":
                        return 1;
                    case "PREVENTION":
                        return 2;
                    case "OTHER_PREV_INFO":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
