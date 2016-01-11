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
    /// Languages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLDataSet : EduHubDataSet<KGL>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGLKEY = new Lazy<Dictionary<string, KGL>>(() => this.ToDictionary(i => i.KGLKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KGL>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGL" /> fields for each CSV column header</returns>
        internal override Action<KGL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGLKEY":
                        mapper[i] = (e, v) => e.KGLKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NOTICES_AVAILABLE":
                        mapper[i] = (e, v) => e.NOTICES_AVAILABLE = v;
                        break;
                    case "ASCL":
                        mapper[i] = (e, v) => e.ASCL = v;
                        break;
                    case "CASESKEY":
                        mapper[i] = (e, v) => e.CASESKEY = v;
                        break;
                    case "CASES_CASES21_CONV":
                        mapper[i] = (e, v) => e.CASES_CASES21_CONV = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
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
        /// Merges <see cref="KGL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGL}"/> of entities</returns>
        internal override IEnumerable<KGL> ApplyDeltaEntities(IEnumerable<KGL> Entities, List<KGL> DeltaEntities)
        {
            HashSet<string> Index_KGLKEY = new HashSet<string>(DeltaEntities.Select(i => i.KGLKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KGLKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KGLKEY.Remove(entity.KGLKEY);
                            
                            if (entity.KGLKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGL>> Index_KGLKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KGL>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGL FindByKGLKEY(string KGLKEY)
        {
            return Index_KGLKEY.Value[KGLKEY];
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <param name="Value">Related KGL entity</param>
        /// <returns>True if the related KGL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGLKEY(string KGLKEY, out KGL Value)
        {
            return Index_KGLKEY.Value.TryGetValue(KGLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY field
        /// </summary>
        /// <param name="KGLKEY">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGL TryFindByKGLKEY(string KGLKEY)
        {
            KGL value;
            if (Index_KGLKEY.Value.TryGetValue(KGLKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <returns>List of related KGL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGL> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <param name="Value">List of related KGL entities</param>
        /// <returns>True if the list of related KGL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KGL> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KGL by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGL</param>
        /// <returns>List of related KGL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGL> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KGL> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGL](
        [KGLKEY] varchar(7) NOT NULL,
        [DESCRIPTION] varchar(75) NULL,
        [NOTICES_AVAILABLE] varchar(1) NULL,
        [ASCL] varchar(4) NULL,
        [CASESKEY] varchar(2) NULL,
        [CASES_CASES21_CONV] varchar(1) NULL,
        [OBSOLETE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGL_Index_KGLKEY] PRIMARY KEY CLUSTERED (
            [KGLKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGL_Index_LW_DATE] ON [dbo].[KGL]
    (
            [LW_DATE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGL]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[KGL] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGL]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[KGL] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KGLKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KGLKEY.Add(entity.KGLKEY);
            }

            builder.AppendLine("DELETE [dbo].[KGL] WHERE");


            // Index_KGLKEY
            builder.Append("[KGLKEY] IN (");
            for (int index = 0; index < Index_KGLKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KGLKEY
                var parameterKGLKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKGLKEY);
                command.Parameters.Add(parameterKGLKEY, SqlDbType.VarChar, 7).Value = Index_KGLKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGL data set</returns>
        public override EduHubDataSetDataReader<KGL> GetDataSetDataReader()
        {
            return new KGLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGL data set</returns>
        public override EduHubDataSetDataReader<KGL> GetDataSetDataReader(List<KGL> Entities)
        {
            return new KGLDataReader(new EduHubDataSetLoadedReader<KGL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGLDataReader : EduHubDataSetDataReader<KGL>
        {
            public KGLDataReader(IEduHubDataSetReader<KGL> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 10; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KGLKEY
                        return Current.KGLKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // NOTICES_AVAILABLE
                        return Current.NOTICES_AVAILABLE;
                    case 3: // ASCL
                        return Current.ASCL;
                    case 4: // CASESKEY
                        return Current.CASESKEY;
                    case 5: // CASES_CASES21_CONV
                        return Current.CASES_CASES21_CONV;
                    case 6: // OBSOLETE
                        return Current.OBSOLETE;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // NOTICES_AVAILABLE
                        return Current.NOTICES_AVAILABLE == null;
                    case 3: // ASCL
                        return Current.ASCL == null;
                    case 4: // CASESKEY
                        return Current.CASESKEY == null;
                    case 5: // CASES_CASES21_CONV
                        return Current.CASES_CASES21_CONV == null;
                    case 6: // OBSOLETE
                        return Current.OBSOLETE == null;
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
                    case 0: // KGLKEY
                        return "KGLKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // NOTICES_AVAILABLE
                        return "NOTICES_AVAILABLE";
                    case 3: // ASCL
                        return "ASCL";
                    case 4: // CASESKEY
                        return "CASESKEY";
                    case 5: // CASES_CASES21_CONV
                        return "CASES_CASES21_CONV";
                    case 6: // OBSOLETE
                        return "OBSOLETE";
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
                    case "KGLKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "NOTICES_AVAILABLE":
                        return 2;
                    case "ASCL":
                        return 3;
                    case "CASESKEY":
                        return 4;
                    case "CASES_CASES21_CONV":
                        return 5;
                    case "OBSOLETE":
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
