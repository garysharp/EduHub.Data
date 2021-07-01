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
    /// Reports for emailing Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KREPORTDataSet : EduHubDataSet<KREPORT>
    {
        /// <inheritdoc />
        public override string Name { get { return "KREPORT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KREPORTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KREPORTKEY = new Lazy<Dictionary<string, KREPORT>>(() => this.ToDictionary(i => i.KREPORTKEY));
            Index_ROLE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<KREPORT>>>(() => this.ToGroupedNullDictionary(i => i.ROLE_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KREPORT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KREPORT" /> fields for each CSV column header</returns>
        internal override Action<KREPORT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KREPORT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KREPORTKEY":
                        mapper[i] = (e, v) => e.KREPORTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_CODE":
                        mapper[i] = (e, v) => e.ROLE_CODE = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
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
        /// Merges <see cref="KREPORT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KREPORT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KREPORT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KREPORT}"/> of entities</returns>
        internal override IEnumerable<KREPORT> ApplyDeltaEntities(IEnumerable<KREPORT> Entities, List<KREPORT> DeltaEntities)
        {
            HashSet<string> Index_KREPORTKEY = new HashSet<string>(DeltaEntities.Select(i => i.KREPORTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KREPORTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KREPORTKEY.Remove(entity.KREPORTKEY);
                            
                            if (entity.KREPORTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KREPORT>> Index_KREPORTKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KREPORT>>> Index_ROLE_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <returns>Related KREPORT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KREPORT FindByKREPORTKEY(string KREPORTKEY)
        {
            return Index_KREPORTKEY.Value[KREPORTKEY];
        }

        /// <summary>
        /// Attempt to find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <param name="Value">Related KREPORT entity</param>
        /// <returns>True if the related KREPORT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKREPORTKEY(string KREPORTKEY, out KREPORT Value)
        {
            return Index_KREPORTKEY.Value.TryGetValue(KREPORTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KREPORT by KREPORTKEY field
        /// </summary>
        /// <param name="KREPORTKEY">KREPORTKEY value used to find KREPORT</param>
        /// <returns>Related KREPORT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KREPORT TryFindByKREPORTKEY(string KREPORTKEY)
        {
            KREPORT value;
            if (Index_KREPORTKEY.Value.TryGetValue(KREPORTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <returns>List of related KREPORT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KREPORT> FindByROLE_CODE(string ROLE_CODE)
        {
            return Index_ROLE_CODE.Value[ROLE_CODE];
        }

        /// <summary>
        /// Attempt to find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <param name="Value">List of related KREPORT entities</param>
        /// <returns>True if the list of related KREPORT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROLE_CODE(string ROLE_CODE, out IReadOnlyList<KREPORT> Value)
        {
            return Index_ROLE_CODE.Value.TryGetValue(ROLE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KREPORT by ROLE_CODE field
        /// </summary>
        /// <param name="ROLE_CODE">ROLE_CODE value used to find KREPORT</param>
        /// <returns>List of related KREPORT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KREPORT> TryFindByROLE_CODE(string ROLE_CODE)
        {
            IReadOnlyList<KREPORT> value;
            if (Index_ROLE_CODE.Value.TryGetValue(ROLE_CODE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KREPORT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KREPORT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KREPORT](
        [KREPORTKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [ROLE_CODE] varchar(2) NULL,
        [REPORT_NAME] varchar(80) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KREPORT_Index_KREPORTKEY] PRIMARY KEY CLUSTERED (
            [KREPORTKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KREPORT_Index_ROLE_CODE] ON [dbo].[KREPORT]
    (
            [ROLE_CODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KREPORT]') AND name = N'Index_ROLE_CODE')
    ALTER INDEX [Index_ROLE_CODE] ON [dbo].[KREPORT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KREPORT]') AND name = N'Index_ROLE_CODE')
    ALTER INDEX [Index_ROLE_CODE] ON [dbo].[KREPORT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KREPORT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KREPORT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KREPORT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KREPORTKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KREPORTKEY.Add(entity.KREPORTKEY);
            }

            builder.AppendLine("DELETE [dbo].[KREPORT] WHERE");


            // Index_KREPORTKEY
            builder.Append("[KREPORTKEY] IN (");
            for (int index = 0; index < Index_KREPORTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KREPORTKEY
                var parameterKREPORTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKREPORTKEY);
                command.Parameters.Add(parameterKREPORTKEY, SqlDbType.VarChar, 10).Value = Index_KREPORTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KREPORT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KREPORT data set</returns>
        public override EduHubDataSetDataReader<KREPORT> GetDataSetDataReader()
        {
            return new KREPORTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KREPORT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KREPORT data set</returns>
        public override EduHubDataSetDataReader<KREPORT> GetDataSetDataReader(List<KREPORT> Entities)
        {
            return new KREPORTDataReader(new EduHubDataSetLoadedReader<KREPORT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KREPORTDataReader : EduHubDataSetDataReader<KREPORT>
        {
            public KREPORTDataReader(IEduHubDataSetReader<KREPORT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KREPORTKEY
                        return Current.KREPORTKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // ROLE_CODE
                        return Current.ROLE_CODE;
                    case 3: // REPORT_NAME
                        return Current.REPORT_NAME;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // ROLE_CODE
                        return Current.ROLE_CODE == null;
                    case 3: // REPORT_NAME
                        return Current.REPORT_NAME == null;
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
                    case 0: // KREPORTKEY
                        return "KREPORTKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ROLE_CODE
                        return "ROLE_CODE";
                    case 3: // REPORT_NAME
                        return "REPORT_NAME";
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
                    case "KREPORTKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ROLE_CODE":
                        return 2;
                    case "REPORT_NAME":
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
