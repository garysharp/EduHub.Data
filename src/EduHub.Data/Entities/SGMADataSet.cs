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
    /// Group Meeting Attendance Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGMADataSet : EduHubDataSet<SGMA>
    {
        /// <inheritdoc />
        public override string Name { get { return "SGMA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SGMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGMAKEY = new Lazy<Dictionary<string, IReadOnlyList<SGMA>>>(() => this.ToGroupedDictionary(i => i.SGMAKEY));
            Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION = new Lazy<Dictionary<Tuple<string, int?, string, string, string>, SGMA>>(() => this.ToDictionary(i => Tuple.Create(i.SGMAKEY, i.SGM_TID, i.MEMBER_PERSON_TYPE, i.MEMBER_LINK, i.DF_PARTICIPATION)));
            Index_TID = new Lazy<Dictionary<int, SGMA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGMA" /> fields for each CSV column header</returns>
        internal override Action<SGMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGMAKEY":
                        mapper[i] = (e, v) => e.SGMAKEY = v;
                        break;
                    case "SGM_TID":
                        mapper[i] = (e, v) => e.SGM_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MEMBER_PERSON_TYPE":
                        mapper[i] = (e, v) => e.MEMBER_PERSON_TYPE = v;
                        break;
                    case "MEMBER_LINK":
                        mapper[i] = (e, v) => e.MEMBER_LINK = v;
                        break;
                    case "DF_PARTICIPATION":
                        mapper[i] = (e, v) => e.DF_PARTICIPATION = v;
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
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
        /// Merges <see cref="SGMA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SGMA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SGMA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SGMA}"/> of entities</returns>
        internal override IEnumerable<SGMA> ApplyDeltaEntities(IEnumerable<SGMA> Entities, List<SGMA> DeltaEntities)
        {
            HashSet<Tuple<string, int?, string, string, string>> Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION = new HashSet<Tuple<string, int?, string, string, string>>(DeltaEntities.Select(i => Tuple.Create(i.SGMAKEY, i.SGM_TID, i.MEMBER_PERSON_TYPE, i.MEMBER_LINK, i.DF_PARTICIPATION)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SGMAKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Remove(Tuple.Create(entity.SGMAKEY, entity.SGM_TID, entity.MEMBER_PERSON_TYPE, entity.MEMBER_LINK, entity.DF_PARTICIPATION));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.SGMAKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SGMA>>> Index_SGMAKEY;
        private Lazy<Dictionary<Tuple<string, int?, string, string, string>, SGMA>> Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION;
        private Lazy<Dictionary<int, SGMA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <returns>List of related SGMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGMA> FindBySGMAKEY(string SGMAKEY)
        {
            return Index_SGMAKEY.Value[SGMAKEY];
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="Value">List of related SGMA entities</param>
        /// <returns>True if the list of related SGMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMAKEY(string SGMAKEY, out IReadOnlyList<SGMA> Value)
        {
            return Index_SGMAKEY.Value.TryGetValue(SGMAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY field
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <returns>List of related SGMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGMA> TryFindBySGMAKEY(string SGMAKEY)
        {
            IReadOnlyList<SGMA> value;
            if (Index_SGMAKEY.Value.TryGetValue(SGMAKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <returns>Related SGMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA FindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION)
        {
            return Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value[Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION)];
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <param name="Value">Related SGMA entity</param>
        /// <returns>True if the related SGMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION, out SGMA Value)
        {
            return Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value.TryGetValue(Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION), out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK and DF_PARTICIPATION fields
        /// </summary>
        /// <param name="SGMAKEY">SGMAKEY value used to find SGMA</param>
        /// <param name="SGM_TID">SGM_TID value used to find SGMA</param>
        /// <param name="MEMBER_PERSON_TYPE">MEMBER_PERSON_TYPE value used to find SGMA</param>
        /// <param name="MEMBER_LINK">MEMBER_LINK value used to find SGMA</param>
        /// <param name="DF_PARTICIPATION">DF_PARTICIPATION value used to find SGMA</param>
        /// <returns>Related SGMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA TryFindBySGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION(string SGMAKEY, int? SGM_TID, string MEMBER_PERSON_TYPE, string MEMBER_LINK, string DF_PARTICIPATION)
        {
            SGMA value;
            if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Value.TryGetValue(Tuple.Create(SGMAKEY, SGM_TID, MEMBER_PERSON_TYPE, MEMBER_LINK, DF_PARTICIPATION), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <returns>Related SGMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <param name="Value">Related SGMA entity</param>
        /// <returns>True if the related SGMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGMA</param>
        /// <returns>Related SGMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGMA TryFindByTID(int TID)
        {
            SGMA value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SGMA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGMA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGMA](
        [TID] int IDENTITY NOT NULL,
        [SGMAKEY] varchar(12) NOT NULL,
        [SGM_TID] int NULL,
        [MEMBER_PERSON_TYPE] varchar(2) NULL,
        [MEMBER_LINK] varchar(10) NULL,
        [DF_PARTICIPATION] varchar(1) NULL,
        [ATTENDED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGMA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SGMA_Index_SGMAKEY] ON [dbo].[SGMA]
    (
            [SGMAKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SGMA_Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION] ON [dbo].[SGMA]
    (
            [SGMAKEY] ASC,
            [SGM_TID] ASC,
            [MEMBER_PERSON_TYPE] ASC,
            [MEMBER_LINK] ASC,
            [DF_PARTICIPATION] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGMA]') AND name = N'Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION')
    ALTER INDEX [Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION] ON [dbo].[SGMA] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGMA]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGMA] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGMA]') AND name = N'Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION')
    ALTER INDEX [Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION] ON [dbo].[SGMA] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGMA]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGMA] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SGMA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SGMA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SGMA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, int?, string, string, string>> Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION = new List<Tuple<string, int?, string, string, string>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Add(Tuple.Create(entity.SGMAKEY, entity.SGM_TID, entity.MEMBER_PERSON_TYPE, entity.MEMBER_LINK, entity.DF_PARTICIPATION));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SGMA] WHERE");


            // Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION
            builder.Append("(");
            for (int index = 0; index < Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // SGMAKEY
                var parameterSGMAKEY = $"@p{parameterIndex++}";
                builder.Append("([SGMAKEY]=").Append(parameterSGMAKEY);
                command.Parameters.Add(parameterSGMAKEY, SqlDbType.VarChar, 12).Value = Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item1;

                // SGM_TID
                if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item2 == null)
                {
                    builder.Append(" AND [SGM_TID] IS NULL");
                }
                else
                {
                    var parameterSGM_TID = $"@p{parameterIndex++}";
                    builder.Append(" AND [SGM_TID]=").Append(parameterSGM_TID);
                    command.Parameters.Add(parameterSGM_TID, SqlDbType.Int).Value = Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item2;
                }

                // MEMBER_PERSON_TYPE
                if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item3 == null)
                {
                    builder.Append(" AND [MEMBER_PERSON_TYPE] IS NULL");
                }
                else
                {
                    var parameterMEMBER_PERSON_TYPE = $"@p{parameterIndex++}";
                    builder.Append(" AND [MEMBER_PERSON_TYPE]=").Append(parameterMEMBER_PERSON_TYPE);
                    command.Parameters.Add(parameterMEMBER_PERSON_TYPE, SqlDbType.VarChar, 2).Value = Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item3;
                }

                // MEMBER_LINK
                if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item4 == null)
                {
                    builder.Append(" AND [MEMBER_LINK] IS NULL");
                }
                else
                {
                    var parameterMEMBER_LINK = $"@p{parameterIndex++}";
                    builder.Append(" AND [MEMBER_LINK]=").Append(parameterMEMBER_LINK);
                    command.Parameters.Add(parameterMEMBER_LINK, SqlDbType.VarChar, 10).Value = Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item4;
                }

                // DF_PARTICIPATION
                if (Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item5 == null)
                {
                    builder.Append(" AND [DF_PARTICIPATION] IS NULL)");
                }
                else
                {
                    var parameterDF_PARTICIPATION = $"@p{parameterIndex++}";
                    builder.Append(" AND [DF_PARTICIPATION]=").Append(parameterDF_PARTICIPATION).Append(")");
                    command.Parameters.Add(parameterDF_PARTICIPATION, SqlDbType.VarChar, 1).Value = Index_SGMAKEY_SGM_TID_MEMBER_PERSON_TYPE_MEMBER_LINK_DF_PARTICIPATION[index].Item5;
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
        /// Provides a <see cref="IDataReader"/> for the SGMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGMA data set</returns>
        public override EduHubDataSetDataReader<SGMA> GetDataSetDataReader()
        {
            return new SGMADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGMA data set</returns>
        public override EduHubDataSetDataReader<SGMA> GetDataSetDataReader(List<SGMA> Entities)
        {
            return new SGMADataReader(new EduHubDataSetLoadedReader<SGMA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGMADataReader : EduHubDataSetDataReader<SGMA>
        {
            public SGMADataReader(IEduHubDataSetReader<SGMA> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 10; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SGMAKEY
                        return Current.SGMAKEY;
                    case 2: // SGM_TID
                        return Current.SGM_TID;
                    case 3: // MEMBER_PERSON_TYPE
                        return Current.MEMBER_PERSON_TYPE;
                    case 4: // MEMBER_LINK
                        return Current.MEMBER_LINK;
                    case 5: // DF_PARTICIPATION
                        return Current.DF_PARTICIPATION;
                    case 6: // ATTENDED
                        return Current.ATTENDED;
                    case 7: // LW_DATE
                        return Current.LW_DATE;
                    case 8: // LW_TIME
                        return Current.LW_TIME;
                    case 9: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SGM_TID
                        return Current.SGM_TID == null;
                    case 3: // MEMBER_PERSON_TYPE
                        return Current.MEMBER_PERSON_TYPE == null;
                    case 4: // MEMBER_LINK
                        return Current.MEMBER_LINK == null;
                    case 5: // DF_PARTICIPATION
                        return Current.DF_PARTICIPATION == null;
                    case 6: // ATTENDED
                        return Current.ATTENDED == null;
                    case 7: // LW_DATE
                        return Current.LW_DATE == null;
                    case 8: // LW_TIME
                        return Current.LW_TIME == null;
                    case 9: // LW_USER
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
                    case 1: // SGMAKEY
                        return "SGMAKEY";
                    case 2: // SGM_TID
                        return "SGM_TID";
                    case 3: // MEMBER_PERSON_TYPE
                        return "MEMBER_PERSON_TYPE";
                    case 4: // MEMBER_LINK
                        return "MEMBER_LINK";
                    case 5: // DF_PARTICIPATION
                        return "DF_PARTICIPATION";
                    case 6: // ATTENDED
                        return "ATTENDED";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
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
                    case "SGMAKEY":
                        return 1;
                    case "SGM_TID":
                        return 2;
                    case "MEMBER_PERSON_TYPE":
                        return 3;
                    case "MEMBER_LINK":
                        return 4;
                    case "DF_PARTICIPATION":
                        return 5;
                    case "ATTENDED":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
