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
    /// Leave Group Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLTDataSet : EduHubDataSet<PLT>
    {
        /// <inheritdoc />
        public override string Name { get { return "PLT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PLTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PLT>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
            Index_LEAVE_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<PLT>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_GROUP));
            Index_LEAVE_GROUP_LEAVE_CODE = new Lazy<Dictionary<Tuple<string, string>, PLT>>(() => this.ToDictionary(i => Tuple.Create(i.LEAVE_GROUP, i.LEAVE_CODE)));
            Index_PLTKEY = new Lazy<Dictionary<string, PLT>>(() => this.ToDictionary(i => i.PLTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLT" /> fields for each CSV column header</returns>
        internal override Action<PLT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "CALC_METHOD":
                        mapper[i] = (e, v) => e.CALC_METHOD = v;
                        break;
                    case "PERIOD_ALLOT01":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT02":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT03":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT04":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT05":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT06":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT06 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT07":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT07 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT08":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT08 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT09":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT09 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT10":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT10 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT11":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT11 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_ALLOT12":
                        mapper[i] = (e, v) => e.PERIOD_ALLOT12 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH01":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH02":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH03":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH04":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH05":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH06":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH07":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH08":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH09":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH10":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH11":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_LENGTH12":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v;
                        break;
                    case "ANNUAL_ENTITLEMENT":
                        mapper[i] = (e, v) => e.ANNUAL_ENTITLEMENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ROLL_OVER":
                        mapper[i] = (e, v) => e.ROLL_OVER = v;
                        break;
                    case "ROLL_PERCENT":
                        mapper[i] = (e, v) => e.ROLL_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_LOADING":
                        mapper[i] = (e, v) => e.LEAVE_LOADING = v;
                        break;
                    case "LOADING_PERCENT":
                        mapper[i] = (e, v) => e.LOADING_PERCENT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="PLT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PLT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PLT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PLT}"/> of entities</returns>
        internal override IEnumerable<PLT> ApplyDeltaEntities(IEnumerable<PLT> Entities, List<PLT> DeltaEntities)
        {
            HashSet<Tuple<string, string>> Index_LEAVE_GROUP_LEAVE_CODE = new HashSet<Tuple<string, string>>(DeltaEntities.Select(i => Tuple.Create(i.LEAVE_GROUP, i.LEAVE_CODE)));
            HashSet<string> Index_PLTKEY = new HashSet<string>(DeltaEntities.Select(i => i.PLTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PLTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_LEAVE_GROUP_LEAVE_CODE.Remove(Tuple.Create(entity.LEAVE_GROUP, entity.LEAVE_CODE));
                            overwritten = overwritten || Index_PLTKEY.Remove(entity.PLTKEY);
                            
                            if (entity.PLTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PLT>>> Index_LEAVE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PLT>>> Index_LEAVE_GROUP;
        private Lazy<Dictionary<Tuple<string, string>, PLT>> Index_LEAVE_GROUP_LEAVE_CODE;
        private Lazy<Dictionary<string, PLT>> Index_PLTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PLT by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <returns>List of related PLT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PLT> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <param name="Value">List of related PLT entities</param>
        /// <returns>True if the list of related PLT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PLT> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <returns>List of related PLT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PLT> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PLT> value;
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
        /// Find PLT by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <returns>List of related PLT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PLT> FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <param name="Value">List of related PLT entities</param>
        /// <returns>True if the list of related PLT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PLT> Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <returns>List of related PLT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PLT> TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PLT> value;
            if (Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PLT by LEAVE_GROUP and LEAVE_CODE fields
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <returns>Related PLT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLT FindByLEAVE_GROUP_LEAVE_CODE(string LEAVE_GROUP, string LEAVE_CODE)
        {
            return Index_LEAVE_GROUP_LEAVE_CODE.Value[Tuple.Create(LEAVE_GROUP, LEAVE_CODE)];
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_GROUP and LEAVE_CODE fields
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <param name="Value">Related PLT entity</param>
        /// <returns>True if the related PLT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP_LEAVE_CODE(string LEAVE_GROUP, string LEAVE_CODE, out PLT Value)
        {
            return Index_LEAVE_GROUP_LEAVE_CODE.Value.TryGetValue(Tuple.Create(LEAVE_GROUP, LEAVE_CODE), out Value);
        }

        /// <summary>
        /// Attempt to find PLT by LEAVE_GROUP and LEAVE_CODE fields
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLT</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PLT</param>
        /// <returns>Related PLT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLT TryFindByLEAVE_GROUP_LEAVE_CODE(string LEAVE_GROUP, string LEAVE_CODE)
        {
            PLT value;
            if (Index_LEAVE_GROUP_LEAVE_CODE.Value.TryGetValue(Tuple.Create(LEAVE_GROUP, LEAVE_CODE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PLT by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PLT</param>
        /// <returns>Related PLT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLT FindByPLTKEY(string PLTKEY)
        {
            return Index_PLTKEY.Value[PLTKEY];
        }

        /// <summary>
        /// Attempt to find PLT by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PLT</param>
        /// <param name="Value">Related PLT entity</param>
        /// <returns>True if the related PLT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLTKEY(string PLTKEY, out PLT Value)
        {
            return Index_PLTKEY.Value.TryGetValue(PLTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PLT by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PLT</param>
        /// <returns>Related PLT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLT TryFindByPLTKEY(string PLTKEY)
        {
            PLT value;
            if (Index_PLTKEY.Value.TryGetValue(PLTKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PLT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PLT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PLT](
        [PLTKEY] varchar(16) NOT NULL,
        [LEAVE_GROUP] varchar(8) NULL,
        [LEAVE_CODE] varchar(8) NULL,
        [CALC_METHOD] varchar(8) NULL,
        [PERIOD_ALLOT01] float NULL,
        [PERIOD_ALLOT02] float NULL,
        [PERIOD_ALLOT03] float NULL,
        [PERIOD_ALLOT04] float NULL,
        [PERIOD_ALLOT05] float NULL,
        [PERIOD_ALLOT06] float NULL,
        [PERIOD_ALLOT07] float NULL,
        [PERIOD_ALLOT08] float NULL,
        [PERIOD_ALLOT09] float NULL,
        [PERIOD_ALLOT10] float NULL,
        [PERIOD_ALLOT11] float NULL,
        [PERIOD_ALLOT12] float NULL,
        [PERIOD_LENGTH01] smallint NULL,
        [PERIOD_LENGTH02] smallint NULL,
        [PERIOD_LENGTH03] smallint NULL,
        [PERIOD_LENGTH04] smallint NULL,
        [PERIOD_LENGTH05] smallint NULL,
        [PERIOD_LENGTH06] smallint NULL,
        [PERIOD_LENGTH07] smallint NULL,
        [PERIOD_LENGTH08] smallint NULL,
        [PERIOD_LENGTH09] smallint NULL,
        [PERIOD_LENGTH10] smallint NULL,
        [PERIOD_LENGTH11] smallint NULL,
        [PERIOD_LENGTH12] smallint NULL,
        [PERIOD_UNITS] varchar(6) NULL,
        [ANNUAL_ENTITLEMENT] float NULL,
        [ROLL_OVER] varchar(1) NULL,
        [ROLL_PERCENT] float NULL,
        [LEAVE_LOADING] varchar(1) NULL,
        [LOADING_PERCENT] float NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PLT_Index_PLTKEY] PRIMARY KEY CLUSTERED (
            [PLTKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PLT_Index_LEAVE_CODE] ON [dbo].[PLT]
    (
            [LEAVE_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PLT_Index_LEAVE_GROUP] ON [dbo].[PLT]
    (
            [LEAVE_GROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [PLT_Index_LEAVE_GROUP_LEAVE_CODE] ON [dbo].[PLT]
    (
            [LEAVE_GROUP] ASC,
            [LEAVE_CODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PLT]') AND name = N'PLT_Index_LEAVE_CODE')
    ALTER INDEX [PLT_Index_LEAVE_CODE] ON [dbo].[PLT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PLT]') AND name = N'PLT_Index_LEAVE_GROUP')
    ALTER INDEX [PLT_Index_LEAVE_GROUP] ON [dbo].[PLT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PLT]') AND name = N'PLT_Index_LEAVE_GROUP_LEAVE_CODE')
    ALTER INDEX [PLT_Index_LEAVE_GROUP_LEAVE_CODE] ON [dbo].[PLT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PLT]') AND name = N'PLT_Index_LEAVE_CODE')
    ALTER INDEX [PLT_Index_LEAVE_CODE] ON [dbo].[PLT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PLT]') AND name = N'PLT_Index_LEAVE_GROUP')
    ALTER INDEX [PLT_Index_LEAVE_GROUP] ON [dbo].[PLT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PLT]') AND name = N'PLT_Index_LEAVE_GROUP_LEAVE_CODE')
    ALTER INDEX [PLT_Index_LEAVE_GROUP_LEAVE_CODE] ON [dbo].[PLT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PLT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PLT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PLT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, string>> Index_LEAVE_GROUP_LEAVE_CODE = new List<Tuple<string, string>>();
            List<string> Index_PLTKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_LEAVE_GROUP_LEAVE_CODE.Add(Tuple.Create(entity.LEAVE_GROUP, entity.LEAVE_CODE));
                Index_PLTKEY.Add(entity.PLTKEY);
            }

            builder.AppendLine("DELETE [dbo].[PLT] WHERE");


            // Index_LEAVE_GROUP_LEAVE_CODE
            builder.Append("(");
            for (int index = 0; index < Index_LEAVE_GROUP_LEAVE_CODE.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // LEAVE_GROUP
                if (Index_LEAVE_GROUP_LEAVE_CODE[index].Item1 == null)
                {
                    builder.Append("([LEAVE_GROUP] IS NULL");
                }
                else
                {
                    var parameterLEAVE_GROUP = $"@p{parameterIndex++}";
                    builder.Append("([LEAVE_GROUP]=").Append(parameterLEAVE_GROUP);
                    command.Parameters.Add(parameterLEAVE_GROUP, SqlDbType.VarChar, 8).Value = Index_LEAVE_GROUP_LEAVE_CODE[index].Item1;
                }

                // LEAVE_CODE
                if (Index_LEAVE_GROUP_LEAVE_CODE[index].Item2 == null)
                {
                    builder.Append(" AND [LEAVE_CODE] IS NULL)");
                }
                else
                {
                    var parameterLEAVE_CODE = $"@p{parameterIndex++}";
                    builder.Append(" AND [LEAVE_CODE]=").Append(parameterLEAVE_CODE).Append(")");
                    command.Parameters.Add(parameterLEAVE_CODE, SqlDbType.VarChar, 8).Value = Index_LEAVE_GROUP_LEAVE_CODE[index].Item2;
                }
            }
            builder.AppendLine(") OR");

            // Index_PLTKEY
            builder.Append("[PLTKEY] IN (");
            for (int index = 0; index < Index_PLTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PLTKEY
                var parameterPLTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPLTKEY);
                command.Parameters.Add(parameterPLTKEY, SqlDbType.VarChar, 16).Value = Index_PLTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PLT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PLT data set</returns>
        public override EduHubDataSetDataReader<PLT> GetDataSetDataReader()
        {
            return new PLTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PLT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PLT data set</returns>
        public override EduHubDataSetDataReader<PLT> GetDataSetDataReader(List<PLT> Entities)
        {
            return new PLTDataReader(new EduHubDataSetLoadedReader<PLT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PLTDataReader : EduHubDataSetDataReader<PLT>
        {
            public PLTDataReader(IEduHubDataSetReader<PLT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 38; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PLTKEY
                        return Current.PLTKEY;
                    case 1: // LEAVE_GROUP
                        return Current.LEAVE_GROUP;
                    case 2: // LEAVE_CODE
                        return Current.LEAVE_CODE;
                    case 3: // CALC_METHOD
                        return Current.CALC_METHOD;
                    case 4: // PERIOD_ALLOT01
                        return Current.PERIOD_ALLOT01;
                    case 5: // PERIOD_ALLOT02
                        return Current.PERIOD_ALLOT02;
                    case 6: // PERIOD_ALLOT03
                        return Current.PERIOD_ALLOT03;
                    case 7: // PERIOD_ALLOT04
                        return Current.PERIOD_ALLOT04;
                    case 8: // PERIOD_ALLOT05
                        return Current.PERIOD_ALLOT05;
                    case 9: // PERIOD_ALLOT06
                        return Current.PERIOD_ALLOT06;
                    case 10: // PERIOD_ALLOT07
                        return Current.PERIOD_ALLOT07;
                    case 11: // PERIOD_ALLOT08
                        return Current.PERIOD_ALLOT08;
                    case 12: // PERIOD_ALLOT09
                        return Current.PERIOD_ALLOT09;
                    case 13: // PERIOD_ALLOT10
                        return Current.PERIOD_ALLOT10;
                    case 14: // PERIOD_ALLOT11
                        return Current.PERIOD_ALLOT11;
                    case 15: // PERIOD_ALLOT12
                        return Current.PERIOD_ALLOT12;
                    case 16: // PERIOD_LENGTH01
                        return Current.PERIOD_LENGTH01;
                    case 17: // PERIOD_LENGTH02
                        return Current.PERIOD_LENGTH02;
                    case 18: // PERIOD_LENGTH03
                        return Current.PERIOD_LENGTH03;
                    case 19: // PERIOD_LENGTH04
                        return Current.PERIOD_LENGTH04;
                    case 20: // PERIOD_LENGTH05
                        return Current.PERIOD_LENGTH05;
                    case 21: // PERIOD_LENGTH06
                        return Current.PERIOD_LENGTH06;
                    case 22: // PERIOD_LENGTH07
                        return Current.PERIOD_LENGTH07;
                    case 23: // PERIOD_LENGTH08
                        return Current.PERIOD_LENGTH08;
                    case 24: // PERIOD_LENGTH09
                        return Current.PERIOD_LENGTH09;
                    case 25: // PERIOD_LENGTH10
                        return Current.PERIOD_LENGTH10;
                    case 26: // PERIOD_LENGTH11
                        return Current.PERIOD_LENGTH11;
                    case 27: // PERIOD_LENGTH12
                        return Current.PERIOD_LENGTH12;
                    case 28: // PERIOD_UNITS
                        return Current.PERIOD_UNITS;
                    case 29: // ANNUAL_ENTITLEMENT
                        return Current.ANNUAL_ENTITLEMENT;
                    case 30: // ROLL_OVER
                        return Current.ROLL_OVER;
                    case 31: // ROLL_PERCENT
                        return Current.ROLL_PERCENT;
                    case 32: // LEAVE_LOADING
                        return Current.LEAVE_LOADING;
                    case 33: // LOADING_PERCENT
                        return Current.LOADING_PERCENT;
                    case 34: // ACTIVE
                        return Current.ACTIVE;
                    case 35: // LW_DATE
                        return Current.LW_DATE;
                    case 36: // LW_TIME
                        return Current.LW_TIME;
                    case 37: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LEAVE_GROUP
                        return Current.LEAVE_GROUP == null;
                    case 2: // LEAVE_CODE
                        return Current.LEAVE_CODE == null;
                    case 3: // CALC_METHOD
                        return Current.CALC_METHOD == null;
                    case 4: // PERIOD_ALLOT01
                        return Current.PERIOD_ALLOT01 == null;
                    case 5: // PERIOD_ALLOT02
                        return Current.PERIOD_ALLOT02 == null;
                    case 6: // PERIOD_ALLOT03
                        return Current.PERIOD_ALLOT03 == null;
                    case 7: // PERIOD_ALLOT04
                        return Current.PERIOD_ALLOT04 == null;
                    case 8: // PERIOD_ALLOT05
                        return Current.PERIOD_ALLOT05 == null;
                    case 9: // PERIOD_ALLOT06
                        return Current.PERIOD_ALLOT06 == null;
                    case 10: // PERIOD_ALLOT07
                        return Current.PERIOD_ALLOT07 == null;
                    case 11: // PERIOD_ALLOT08
                        return Current.PERIOD_ALLOT08 == null;
                    case 12: // PERIOD_ALLOT09
                        return Current.PERIOD_ALLOT09 == null;
                    case 13: // PERIOD_ALLOT10
                        return Current.PERIOD_ALLOT10 == null;
                    case 14: // PERIOD_ALLOT11
                        return Current.PERIOD_ALLOT11 == null;
                    case 15: // PERIOD_ALLOT12
                        return Current.PERIOD_ALLOT12 == null;
                    case 16: // PERIOD_LENGTH01
                        return Current.PERIOD_LENGTH01 == null;
                    case 17: // PERIOD_LENGTH02
                        return Current.PERIOD_LENGTH02 == null;
                    case 18: // PERIOD_LENGTH03
                        return Current.PERIOD_LENGTH03 == null;
                    case 19: // PERIOD_LENGTH04
                        return Current.PERIOD_LENGTH04 == null;
                    case 20: // PERIOD_LENGTH05
                        return Current.PERIOD_LENGTH05 == null;
                    case 21: // PERIOD_LENGTH06
                        return Current.PERIOD_LENGTH06 == null;
                    case 22: // PERIOD_LENGTH07
                        return Current.PERIOD_LENGTH07 == null;
                    case 23: // PERIOD_LENGTH08
                        return Current.PERIOD_LENGTH08 == null;
                    case 24: // PERIOD_LENGTH09
                        return Current.PERIOD_LENGTH09 == null;
                    case 25: // PERIOD_LENGTH10
                        return Current.PERIOD_LENGTH10 == null;
                    case 26: // PERIOD_LENGTH11
                        return Current.PERIOD_LENGTH11 == null;
                    case 27: // PERIOD_LENGTH12
                        return Current.PERIOD_LENGTH12 == null;
                    case 28: // PERIOD_UNITS
                        return Current.PERIOD_UNITS == null;
                    case 29: // ANNUAL_ENTITLEMENT
                        return Current.ANNUAL_ENTITLEMENT == null;
                    case 30: // ROLL_OVER
                        return Current.ROLL_OVER == null;
                    case 31: // ROLL_PERCENT
                        return Current.ROLL_PERCENT == null;
                    case 32: // LEAVE_LOADING
                        return Current.LEAVE_LOADING == null;
                    case 33: // LOADING_PERCENT
                        return Current.LOADING_PERCENT == null;
                    case 34: // ACTIVE
                        return Current.ACTIVE == null;
                    case 35: // LW_DATE
                        return Current.LW_DATE == null;
                    case 36: // LW_TIME
                        return Current.LW_TIME == null;
                    case 37: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PLTKEY
                        return "PLTKEY";
                    case 1: // LEAVE_GROUP
                        return "LEAVE_GROUP";
                    case 2: // LEAVE_CODE
                        return "LEAVE_CODE";
                    case 3: // CALC_METHOD
                        return "CALC_METHOD";
                    case 4: // PERIOD_ALLOT01
                        return "PERIOD_ALLOT01";
                    case 5: // PERIOD_ALLOT02
                        return "PERIOD_ALLOT02";
                    case 6: // PERIOD_ALLOT03
                        return "PERIOD_ALLOT03";
                    case 7: // PERIOD_ALLOT04
                        return "PERIOD_ALLOT04";
                    case 8: // PERIOD_ALLOT05
                        return "PERIOD_ALLOT05";
                    case 9: // PERIOD_ALLOT06
                        return "PERIOD_ALLOT06";
                    case 10: // PERIOD_ALLOT07
                        return "PERIOD_ALLOT07";
                    case 11: // PERIOD_ALLOT08
                        return "PERIOD_ALLOT08";
                    case 12: // PERIOD_ALLOT09
                        return "PERIOD_ALLOT09";
                    case 13: // PERIOD_ALLOT10
                        return "PERIOD_ALLOT10";
                    case 14: // PERIOD_ALLOT11
                        return "PERIOD_ALLOT11";
                    case 15: // PERIOD_ALLOT12
                        return "PERIOD_ALLOT12";
                    case 16: // PERIOD_LENGTH01
                        return "PERIOD_LENGTH01";
                    case 17: // PERIOD_LENGTH02
                        return "PERIOD_LENGTH02";
                    case 18: // PERIOD_LENGTH03
                        return "PERIOD_LENGTH03";
                    case 19: // PERIOD_LENGTH04
                        return "PERIOD_LENGTH04";
                    case 20: // PERIOD_LENGTH05
                        return "PERIOD_LENGTH05";
                    case 21: // PERIOD_LENGTH06
                        return "PERIOD_LENGTH06";
                    case 22: // PERIOD_LENGTH07
                        return "PERIOD_LENGTH07";
                    case 23: // PERIOD_LENGTH08
                        return "PERIOD_LENGTH08";
                    case 24: // PERIOD_LENGTH09
                        return "PERIOD_LENGTH09";
                    case 25: // PERIOD_LENGTH10
                        return "PERIOD_LENGTH10";
                    case 26: // PERIOD_LENGTH11
                        return "PERIOD_LENGTH11";
                    case 27: // PERIOD_LENGTH12
                        return "PERIOD_LENGTH12";
                    case 28: // PERIOD_UNITS
                        return "PERIOD_UNITS";
                    case 29: // ANNUAL_ENTITLEMENT
                        return "ANNUAL_ENTITLEMENT";
                    case 30: // ROLL_OVER
                        return "ROLL_OVER";
                    case 31: // ROLL_PERCENT
                        return "ROLL_PERCENT";
                    case 32: // LEAVE_LOADING
                        return "LEAVE_LOADING";
                    case 33: // LOADING_PERCENT
                        return "LOADING_PERCENT";
                    case 34: // ACTIVE
                        return "ACTIVE";
                    case 35: // LW_DATE
                        return "LW_DATE";
                    case 36: // LW_TIME
                        return "LW_TIME";
                    case 37: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PLTKEY":
                        return 0;
                    case "LEAVE_GROUP":
                        return 1;
                    case "LEAVE_CODE":
                        return 2;
                    case "CALC_METHOD":
                        return 3;
                    case "PERIOD_ALLOT01":
                        return 4;
                    case "PERIOD_ALLOT02":
                        return 5;
                    case "PERIOD_ALLOT03":
                        return 6;
                    case "PERIOD_ALLOT04":
                        return 7;
                    case "PERIOD_ALLOT05":
                        return 8;
                    case "PERIOD_ALLOT06":
                        return 9;
                    case "PERIOD_ALLOT07":
                        return 10;
                    case "PERIOD_ALLOT08":
                        return 11;
                    case "PERIOD_ALLOT09":
                        return 12;
                    case "PERIOD_ALLOT10":
                        return 13;
                    case "PERIOD_ALLOT11":
                        return 14;
                    case "PERIOD_ALLOT12":
                        return 15;
                    case "PERIOD_LENGTH01":
                        return 16;
                    case "PERIOD_LENGTH02":
                        return 17;
                    case "PERIOD_LENGTH03":
                        return 18;
                    case "PERIOD_LENGTH04":
                        return 19;
                    case "PERIOD_LENGTH05":
                        return 20;
                    case "PERIOD_LENGTH06":
                        return 21;
                    case "PERIOD_LENGTH07":
                        return 22;
                    case "PERIOD_LENGTH08":
                        return 23;
                    case "PERIOD_LENGTH09":
                        return 24;
                    case "PERIOD_LENGTH10":
                        return 25;
                    case "PERIOD_LENGTH11":
                        return 26;
                    case "PERIOD_LENGTH12":
                        return 27;
                    case "PERIOD_UNITS":
                        return 28;
                    case "ANNUAL_ENTITLEMENT":
                        return 29;
                    case "ROLL_OVER":
                        return 30;
                    case "ROLL_PERCENT":
                        return 31;
                    case "LEAVE_LOADING":
                        return 32;
                    case "LOADING_PERCENT":
                        return 33;
                    case "ACTIVE":
                        return 34;
                    case "LW_DATE":
                        return 35;
                    case "LW_TIME":
                        return 36;
                    case "LW_USER":
                        return 37;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
