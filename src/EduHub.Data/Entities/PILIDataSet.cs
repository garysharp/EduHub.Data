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
    /// Pay Item Leave Items Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PILIDataSet : EduHubDataSet<PILI>
    {
        /// <inheritdoc />
        public override string Name { get { return "PILI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PILIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
            Index_LEAVE_GROUP = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_GROUP));
            Index_PIKEY = new Lazy<Dictionary<short, IReadOnlyList<PILI>>>(() => this.ToGroupedDictionary(i => i.PIKEY));
            Index_PLTKEY = new Lazy<NullDictionary<string, IReadOnlyList<PILI>>>(() => this.ToGroupedNullDictionary(i => i.PLTKEY));
            Index_TID = new Lazy<Dictionary<int, PILI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PILI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PILI" /> fields for each CSV column header</returns>
        internal override Action<PILI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PILI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PIKEY":
                        mapper[i] = (e, v) => e.PIKEY = short.Parse(v);
                        break;
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
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
        /// Merges <see cref="PILI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PILI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PILI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PILI}"/> of entities</returns>
        internal override IEnumerable<PILI> ApplyDeltaEntities(IEnumerable<PILI> Entities, List<PILI> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PIKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.PIKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_LEAVE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_LEAVE_GROUP;
        private Lazy<Dictionary<short, IReadOnlyList<PILI>>> Index_PIKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PILI>>> Index_PLTKEY;
        private Lazy<Dictionary<int, PILI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PILI> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PILI> value;
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
        /// Find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out IReadOnlyList<PILI> Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            IReadOnlyList<PILI> value;
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
        /// Find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByPIKEY(short PIKEY)
        {
            return Index_PIKEY.Value[PIKEY];
        }

        /// <summary>
        /// Attempt to find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPIKEY(short PIKEY, out IReadOnlyList<PILI> Value)
        {
            return Index_PIKEY.Value.TryGetValue(PIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by PIKEY field
        /// </summary>
        /// <param name="PIKEY">PIKEY value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByPIKEY(short PIKEY)
        {
            IReadOnlyList<PILI> value;
            if (Index_PIKEY.Value.TryGetValue(PIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <returns>List of related PILI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> FindByPLTKEY(string PLTKEY)
        {
            return Index_PLTKEY.Value[PLTKEY];
        }

        /// <summary>
        /// Attempt to find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <param name="Value">List of related PILI entities</param>
        /// <returns>True if the list of related PILI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLTKEY(string PLTKEY, out IReadOnlyList<PILI> Value)
        {
            return Index_PLTKEY.Value.TryGetValue(PLTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PILI</param>
        /// <returns>List of related PILI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PILI> TryFindByPLTKEY(string PLTKEY)
        {
            IReadOnlyList<PILI> value;
            if (Index_PLTKEY.Value.TryGetValue(PLTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <returns>Related PILI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PILI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <param name="Value">Related PILI entity</param>
        /// <returns>True if the related PILI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PILI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PILI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PILI</param>
        /// <returns>Related PILI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PILI TryFindByTID(int TID)
        {
            PILI value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PILI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PILI](
        [TID] int IDENTITY NOT NULL,
        [PIKEY] smallint NOT NULL,
        [PLTKEY] varchar(16) NULL,
        [LEAVE_GROUP] varchar(8) NULL,
        [LEAVE_CODE] varchar(8) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PILI_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PILI_Index_LEAVE_CODE] ON [dbo].[PILI]
    (
            [LEAVE_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PILI_Index_LEAVE_GROUP] ON [dbo].[PILI]
    (
            [LEAVE_GROUP] ASC
    );
    CREATE CLUSTERED INDEX [PILI_Index_PIKEY] ON [dbo].[PILI]
    (
            [PIKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [PILI_Index_PLTKEY] ON [dbo].[PILI]
    (
            [PLTKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND name = N'PILI_Index_LEAVE_CODE')
    ALTER INDEX [PILI_Index_LEAVE_CODE] ON [dbo].[PILI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND name = N'PILI_Index_LEAVE_GROUP')
    ALTER INDEX [PILI_Index_LEAVE_GROUP] ON [dbo].[PILI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND name = N'PILI_Index_PLTKEY')
    ALTER INDEX [PILI_Index_PLTKEY] ON [dbo].[PILI] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND name = N'PILI_Index_TID')
    ALTER INDEX [PILI_Index_TID] ON [dbo].[PILI] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND name = N'PILI_Index_LEAVE_CODE')
    ALTER INDEX [PILI_Index_LEAVE_CODE] ON [dbo].[PILI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND name = N'PILI_Index_LEAVE_GROUP')
    ALTER INDEX [PILI_Index_LEAVE_GROUP] ON [dbo].[PILI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND name = N'PILI_Index_PLTKEY')
    ALTER INDEX [PILI_Index_PLTKEY] ON [dbo].[PILI] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PILI]') AND name = N'PILI_Index_TID')
    ALTER INDEX [PILI_Index_TID] ON [dbo].[PILI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PILI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PILI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PILI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PILI] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PILI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PILI data set</returns>
        public override EduHubDataSetDataReader<PILI> GetDataSetDataReader()
        {
            return new PILIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PILI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PILI data set</returns>
        public override EduHubDataSetDataReader<PILI> GetDataSetDataReader(List<PILI> Entities)
        {
            return new PILIDataReader(new EduHubDataSetLoadedReader<PILI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PILIDataReader : EduHubDataSetDataReader<PILI>
        {
            public PILIDataReader(IEduHubDataSetReader<PILI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // PIKEY
                        return Current.PIKEY;
                    case 2: // PLTKEY
                        return Current.PLTKEY;
                    case 3: // LEAVE_GROUP
                        return Current.LEAVE_GROUP;
                    case 4: // LEAVE_CODE
                        return Current.LEAVE_CODE;
                    case 5: // LW_DATE
                        return Current.LW_DATE;
                    case 6: // LW_TIME
                        return Current.LW_TIME;
                    case 7: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PLTKEY
                        return Current.PLTKEY == null;
                    case 3: // LEAVE_GROUP
                        return Current.LEAVE_GROUP == null;
                    case 4: // LEAVE_CODE
                        return Current.LEAVE_CODE == null;
                    case 5: // LW_DATE
                        return Current.LW_DATE == null;
                    case 6: // LW_TIME
                        return Current.LW_TIME == null;
                    case 7: // LW_USER
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
                    case 1: // PIKEY
                        return "PIKEY";
                    case 2: // PLTKEY
                        return "PLTKEY";
                    case 3: // LEAVE_GROUP
                        return "LEAVE_GROUP";
                    case 4: // LEAVE_CODE
                        return "LEAVE_CODE";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
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
                    case "PIKEY":
                        return 1;
                    case "PLTKEY":
                        return 2;
                    case "LEAVE_GROUP":
                        return 3;
                    case "LEAVE_CODE":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
