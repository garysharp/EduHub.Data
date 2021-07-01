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
    /// Specialist Subjects Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SSDataSet : EduHubDataSet<SS>
    {
        /// <inheritdoc />
        public override string Name { get { return "SS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEFAULT_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<SS>>>(() => this.ToGroupedNullDictionary(i => i.DEFAULT_TEACHER));
            Index_FROM_HOMEGROUP = new Lazy<NullDictionary<string, IReadOnlyList<SS>>>(() => this.ToGroupedNullDictionary(i => i.FROM_HOMEGROUP));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<SS>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
            Index_SSKEY = new Lazy<Dictionary<string, SS>>(() => this.ToDictionary(i => i.SSKEY));
            Index_TO_HOMEGROUP = new Lazy<NullDictionary<string, IReadOnlyList<SS>>>(() => this.ToGroupedNullDictionary(i => i.TO_HOMEGROUP));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SS" /> fields for each CSV column header</returns>
        internal override Action<SS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SSKEY":
                        mapper[i] = (e, v) => e.SSKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FROM_HOMEGROUP":
                        mapper[i] = (e, v) => e.FROM_HOMEGROUP = v;
                        break;
                    case "TO_HOMEGROUP":
                        mapper[i] = (e, v) => e.TO_HOMEGROUP = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "DEFAULT_TEACHER":
                        mapper[i] = (e, v) => e.DEFAULT_TEACHER = v;
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
        /// Merges <see cref="SS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SS}"/> of entities</returns>
        internal override IEnumerable<SS> ApplyDeltaEntities(IEnumerable<SS> Entities, List<SS> DeltaEntities)
        {
            HashSet<string> Index_SSKEY = new HashSet<string>(DeltaEntities.Select(i => i.SSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SSKEY.Remove(entity.SSKEY);
                            
                            if (entity.SSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SS>>> Index_DEFAULT_TEACHER;
        private Lazy<NullDictionary<string, IReadOnlyList<SS>>> Index_FROM_HOMEGROUP;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<SS>>> Index_LW_DATE;
        private Lazy<Dictionary<string, SS>> Index_SSKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SS>>> Index_TO_HOMEGROUP;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SS by DEFAULT_TEACHER field
        /// </summary>
        /// <param name="DEFAULT_TEACHER">DEFAULT_TEACHER value used to find SS</param>
        /// <returns>List of related SS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> FindByDEFAULT_TEACHER(string DEFAULT_TEACHER)
        {
            return Index_DEFAULT_TEACHER.Value[DEFAULT_TEACHER];
        }

        /// <summary>
        /// Attempt to find SS by DEFAULT_TEACHER field
        /// </summary>
        /// <param name="DEFAULT_TEACHER">DEFAULT_TEACHER value used to find SS</param>
        /// <param name="Value">List of related SS entities</param>
        /// <returns>True if the list of related SS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEFAULT_TEACHER(string DEFAULT_TEACHER, out IReadOnlyList<SS> Value)
        {
            return Index_DEFAULT_TEACHER.Value.TryGetValue(DEFAULT_TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find SS by DEFAULT_TEACHER field
        /// </summary>
        /// <param name="DEFAULT_TEACHER">DEFAULT_TEACHER value used to find SS</param>
        /// <returns>List of related SS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> TryFindByDEFAULT_TEACHER(string DEFAULT_TEACHER)
        {
            IReadOnlyList<SS> value;
            if (Index_DEFAULT_TEACHER.Value.TryGetValue(DEFAULT_TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SS by FROM_HOMEGROUP field
        /// </summary>
        /// <param name="FROM_HOMEGROUP">FROM_HOMEGROUP value used to find SS</param>
        /// <returns>List of related SS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> FindByFROM_HOMEGROUP(string FROM_HOMEGROUP)
        {
            return Index_FROM_HOMEGROUP.Value[FROM_HOMEGROUP];
        }

        /// <summary>
        /// Attempt to find SS by FROM_HOMEGROUP field
        /// </summary>
        /// <param name="FROM_HOMEGROUP">FROM_HOMEGROUP value used to find SS</param>
        /// <param name="Value">List of related SS entities</param>
        /// <returns>True if the list of related SS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFROM_HOMEGROUP(string FROM_HOMEGROUP, out IReadOnlyList<SS> Value)
        {
            return Index_FROM_HOMEGROUP.Value.TryGetValue(FROM_HOMEGROUP, out Value);
        }

        /// <summary>
        /// Attempt to find SS by FROM_HOMEGROUP field
        /// </summary>
        /// <param name="FROM_HOMEGROUP">FROM_HOMEGROUP value used to find SS</param>
        /// <returns>List of related SS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> TryFindByFROM_HOMEGROUP(string FROM_HOMEGROUP)
        {
            IReadOnlyList<SS> value;
            if (Index_FROM_HOMEGROUP.Value.TryGetValue(FROM_HOMEGROUP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SS</param>
        /// <returns>List of related SS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find SS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SS</param>
        /// <param name="Value">List of related SS entities</param>
        /// <returns>True if the list of related SS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<SS> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find SS by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find SS</param>
        /// <returns>List of related SS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<SS> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SS by SSKEY field
        /// </summary>
        /// <param name="SSKEY">SSKEY value used to find SS</param>
        /// <returns>Related SS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SS FindBySSKEY(string SSKEY)
        {
            return Index_SSKEY.Value[SSKEY];
        }

        /// <summary>
        /// Attempt to find SS by SSKEY field
        /// </summary>
        /// <param name="SSKEY">SSKEY value used to find SS</param>
        /// <param name="Value">Related SS entity</param>
        /// <returns>True if the related SS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySSKEY(string SSKEY, out SS Value)
        {
            return Index_SSKEY.Value.TryGetValue(SSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SS by SSKEY field
        /// </summary>
        /// <param name="SSKEY">SSKEY value used to find SS</param>
        /// <returns>Related SS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SS TryFindBySSKEY(string SSKEY)
        {
            SS value;
            if (Index_SSKEY.Value.TryGetValue(SSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SS by TO_HOMEGROUP field
        /// </summary>
        /// <param name="TO_HOMEGROUP">TO_HOMEGROUP value used to find SS</param>
        /// <returns>List of related SS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> FindByTO_HOMEGROUP(string TO_HOMEGROUP)
        {
            return Index_TO_HOMEGROUP.Value[TO_HOMEGROUP];
        }

        /// <summary>
        /// Attempt to find SS by TO_HOMEGROUP field
        /// </summary>
        /// <param name="TO_HOMEGROUP">TO_HOMEGROUP value used to find SS</param>
        /// <param name="Value">List of related SS entities</param>
        /// <returns>True if the list of related SS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTO_HOMEGROUP(string TO_HOMEGROUP, out IReadOnlyList<SS> Value)
        {
            return Index_TO_HOMEGROUP.Value.TryGetValue(TO_HOMEGROUP, out Value);
        }

        /// <summary>
        /// Attempt to find SS by TO_HOMEGROUP field
        /// </summary>
        /// <param name="TO_HOMEGROUP">TO_HOMEGROUP value used to find SS</param>
        /// <returns>List of related SS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SS> TryFindByTO_HOMEGROUP(string TO_HOMEGROUP)
        {
            IReadOnlyList<SS> value;
            if (Index_TO_HOMEGROUP.Value.TryGetValue(TO_HOMEGROUP, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SS](
        [SSKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [FROM_HOMEGROUP] varchar(3) NULL,
        [TO_HOMEGROUP] varchar(3) NULL,
        [ACTIVE] varchar(1) NULL,
        [DEFAULT_TEACHER] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SS_Index_SSKEY] PRIMARY KEY CLUSTERED (
            [SSKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SS_Index_DEFAULT_TEACHER] ON [dbo].[SS]
    (
            [DEFAULT_TEACHER] ASC
    );
    CREATE NONCLUSTERED INDEX [SS_Index_FROM_HOMEGROUP] ON [dbo].[SS]
    (
            [FROM_HOMEGROUP] ASC
    );
    CREATE NONCLUSTERED INDEX [SS_Index_LW_DATE] ON [dbo].[SS]
    (
            [LW_DATE] ASC
    );
    CREATE NONCLUSTERED INDEX [SS_Index_TO_HOMEGROUP] ON [dbo].[SS]
    (
            [TO_HOMEGROUP] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SS]') AND name = N'SS_Index_DEFAULT_TEACHER')
    ALTER INDEX [SS_Index_DEFAULT_TEACHER] ON [dbo].[SS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SS]') AND name = N'SS_Index_FROM_HOMEGROUP')
    ALTER INDEX [SS_Index_FROM_HOMEGROUP] ON [dbo].[SS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SS]') AND name = N'SS_Index_LW_DATE')
    ALTER INDEX [SS_Index_LW_DATE] ON [dbo].[SS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SS]') AND name = N'SS_Index_TO_HOMEGROUP')
    ALTER INDEX [SS_Index_TO_HOMEGROUP] ON [dbo].[SS] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SS]') AND name = N'SS_Index_DEFAULT_TEACHER')
    ALTER INDEX [SS_Index_DEFAULT_TEACHER] ON [dbo].[SS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SS]') AND name = N'SS_Index_FROM_HOMEGROUP')
    ALTER INDEX [SS_Index_FROM_HOMEGROUP] ON [dbo].[SS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SS]') AND name = N'SS_Index_LW_DATE')
    ALTER INDEX [SS_Index_LW_DATE] ON [dbo].[SS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SS]') AND name = N'SS_Index_TO_HOMEGROUP')
    ALTER INDEX [SS_Index_TO_HOMEGROUP] ON [dbo].[SS] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SSKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SSKEY.Add(entity.SSKEY);
            }

            builder.AppendLine("DELETE [dbo].[SS] WHERE");


            // Index_SSKEY
            builder.Append("[SSKEY] IN (");
            for (int index = 0; index < Index_SSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SSKEY
                var parameterSSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSSKEY);
                command.Parameters.Add(parameterSSKEY, SqlDbType.VarChar, 10).Value = Index_SSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SS data set</returns>
        public override EduHubDataSetDataReader<SS> GetDataSetDataReader()
        {
            return new SSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SS data set</returns>
        public override EduHubDataSetDataReader<SS> GetDataSetDataReader(List<SS> Entities)
        {
            return new SSDataReader(new EduHubDataSetLoadedReader<SS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SSDataReader : EduHubDataSetDataReader<SS>
        {
            public SSDataReader(IEduHubDataSetReader<SS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SSKEY
                        return Current.SSKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // FROM_HOMEGROUP
                        return Current.FROM_HOMEGROUP;
                    case 3: // TO_HOMEGROUP
                        return Current.TO_HOMEGROUP;
                    case 4: // ACTIVE
                        return Current.ACTIVE;
                    case 5: // DEFAULT_TEACHER
                        return Current.DEFAULT_TEACHER;
                    case 6: // LW_DATE
                        return Current.LW_DATE;
                    case 7: // LW_TIME
                        return Current.LW_TIME;
                    case 8: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // FROM_HOMEGROUP
                        return Current.FROM_HOMEGROUP == null;
                    case 3: // TO_HOMEGROUP
                        return Current.TO_HOMEGROUP == null;
                    case 4: // ACTIVE
                        return Current.ACTIVE == null;
                    case 5: // DEFAULT_TEACHER
                        return Current.DEFAULT_TEACHER == null;
                    case 6: // LW_DATE
                        return Current.LW_DATE == null;
                    case 7: // LW_TIME
                        return Current.LW_TIME == null;
                    case 8: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SSKEY
                        return "SSKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // FROM_HOMEGROUP
                        return "FROM_HOMEGROUP";
                    case 3: // TO_HOMEGROUP
                        return "TO_HOMEGROUP";
                    case 4: // ACTIVE
                        return "ACTIVE";
                    case 5: // DEFAULT_TEACHER
                        return "DEFAULT_TEACHER";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SSKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "FROM_HOMEGROUP":
                        return 2;
                    case "TO_HOMEGROUP":
                        return 3;
                    case "ACTIVE":
                        return 4;
                    case "DEFAULT_TEACHER":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
