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
    /// Contact Links Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCLDataSet : EduHubDataSet<KPCL>
    {
        /// <inheritdoc />
        public override string Name { get { return "KPCL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KPCLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<KPCL>>>(() => this.ToGroupedNullDictionary(i => i.CONTACT));
            Index_CONTACT_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<KPCL>>>(() => this.ToGroupedNullDictionary(i => i.CONTACT_TYPE));
            Index_KPCLKEY = new Lazy<Dictionary<int, KPCL>>(() => this.ToDictionary(i => i.KPCLKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPCL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPCL" /> fields for each CSV column header</returns>
        internal override Action<KPCL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPCL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCLKEY":
                        mapper[i] = (e, v) => e.KPCLKEY = int.Parse(v);
                        break;
                    case "LINK":
                        mapper[i] = (e, v) => e.LINK = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "CONTACT_TYPE":
                        mapper[i] = (e, v) => e.CONTACT_TYPE = v;
                        break;
                    case "CONTACT_PREFERENCE":
                        mapper[i] = (e, v) => e.CONTACT_PREFERENCE = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="KPCL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KPCL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KPCL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KPCL}"/> of entities</returns>
        internal override IEnumerable<KPCL> ApplyDeltaEntities(IEnumerable<KPCL> Entities, List<KPCL> DeltaEntities)
        {
            HashSet<int> Index_KPCLKEY = new HashSet<int>(DeltaEntities.Select(i => i.KPCLKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KPCLKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KPCLKEY.Remove(entity.KPCLKEY);
                            
                            if (entity.KPCLKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<KPCL>>> Index_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<KPCL>>> Index_CONTACT_TYPE;
        private Lazy<Dictionary<int, KPCL>> Index_KPCLKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <returns>List of related KPCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> FindByCONTACT(string CONTACT)
        {
            return Index_CONTACT.Value[CONTACT];
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <param name="Value">List of related KPCL entities</param>
        /// <returns>True if the list of related KPCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCONTACT(string CONTACT, out IReadOnlyList<KPCL> Value)
        {
            return Index_CONTACT.Value.TryGetValue(CONTACT, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <returns>List of related KPCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> TryFindByCONTACT(string CONTACT)
        {
            IReadOnlyList<KPCL> value;
            if (Index_CONTACT.Value.TryGetValue(CONTACT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <returns>List of related KPCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> FindByCONTACT_TYPE(string CONTACT_TYPE)
        {
            return Index_CONTACT_TYPE.Value[CONTACT_TYPE];
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <param name="Value">List of related KPCL entities</param>
        /// <returns>True if the list of related KPCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCONTACT_TYPE(string CONTACT_TYPE, out IReadOnlyList<KPCL> Value)
        {
            return Index_CONTACT_TYPE.Value.TryGetValue(CONTACT_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <returns>List of related KPCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> TryFindByCONTACT_TYPE(string CONTACT_TYPE)
        {
            IReadOnlyList<KPCL> value;
            if (Index_CONTACT_TYPE.Value.TryGetValue(CONTACT_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCL FindByKPCLKEY(int KPCLKEY)
        {
            return Index_KPCLKEY.Value[KPCLKEY];
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <param name="Value">Related KPCL entity</param>
        /// <returns>True if the related KPCL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCLKEY(int KPCLKEY, out KPCL Value)
        {
            return Index_KPCLKEY.Value.TryGetValue(KPCLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCL TryFindByKPCLKEY(int KPCLKEY)
        {
            KPCL value;
            if (Index_KPCLKEY.Value.TryGetValue(KPCLKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KPCL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPCL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPCL](
        [KPCLKEY] int IDENTITY NOT NULL,
        [LINK] varchar(10) NULL,
        [SOURCE] varchar(3) NULL,
        [CONTACT] varchar(10) NULL,
        [CONTACT_TYPE] varchar(10) NULL,
        [CONTACT_PREFERENCE] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPCL_Index_KPCLKEY] PRIMARY KEY CLUSTERED (
            [KPCLKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KPCL_Index_CONTACT] ON [dbo].[KPCL]
    (
            [CONTACT] ASC
    );
    CREATE NONCLUSTERED INDEX [KPCL_Index_CONTACT_TYPE] ON [dbo].[KPCL]
    (
            [CONTACT_TYPE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KPCL]') AND name = N'Index_CONTACT')
    ALTER INDEX [Index_CONTACT] ON [dbo].[KPCL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KPCL]') AND name = N'Index_CONTACT_TYPE')
    ALTER INDEX [Index_CONTACT_TYPE] ON [dbo].[KPCL] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KPCL]') AND name = N'Index_CONTACT')
    ALTER INDEX [Index_CONTACT] ON [dbo].[KPCL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KPCL]') AND name = N'Index_CONTACT_TYPE')
    ALTER INDEX [Index_CONTACT_TYPE] ON [dbo].[KPCL] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KPCL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KPCL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KPCL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_KPCLKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KPCLKEY.Add(entity.KPCLKEY);
            }

            builder.AppendLine("DELETE [dbo].[KPCL] WHERE");


            // Index_KPCLKEY
            builder.Append("[KPCLKEY] IN (");
            for (int index = 0; index < Index_KPCLKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KPCLKEY
                var parameterKPCLKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKPCLKEY);
                command.Parameters.Add(parameterKPCLKEY, SqlDbType.Int).Value = Index_KPCLKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPCL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPCL data set</returns>
        public override EduHubDataSetDataReader<KPCL> GetDataSetDataReader()
        {
            return new KPCLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPCL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPCL data set</returns>
        public override EduHubDataSetDataReader<KPCL> GetDataSetDataReader(List<KPCL> Entities)
        {
            return new KPCLDataReader(new EduHubDataSetLoadedReader<KPCL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPCLDataReader : EduHubDataSetDataReader<KPCL>
        {
            public KPCLDataReader(IEduHubDataSetReader<KPCL> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KPCLKEY
                        return Current.KPCLKEY;
                    case 1: // LINK
                        return Current.LINK;
                    case 2: // SOURCE
                        return Current.SOURCE;
                    case 3: // CONTACT
                        return Current.CONTACT;
                    case 4: // CONTACT_TYPE
                        return Current.CONTACT_TYPE;
                    case 5: // CONTACT_PREFERENCE
                        return Current.CONTACT_PREFERENCE;
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
                    case 1: // LINK
                        return Current.LINK == null;
                    case 2: // SOURCE
                        return Current.SOURCE == null;
                    case 3: // CONTACT
                        return Current.CONTACT == null;
                    case 4: // CONTACT_TYPE
                        return Current.CONTACT_TYPE == null;
                    case 5: // CONTACT_PREFERENCE
                        return Current.CONTACT_PREFERENCE == null;
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
                    case 0: // KPCLKEY
                        return "KPCLKEY";
                    case 1: // LINK
                        return "LINK";
                    case 2: // SOURCE
                        return "SOURCE";
                    case 3: // CONTACT
                        return "CONTACT";
                    case 4: // CONTACT_TYPE
                        return "CONTACT_TYPE";
                    case 5: // CONTACT_PREFERENCE
                        return "CONTACT_PREFERENCE";
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
                    case "KPCLKEY":
                        return 0;
                    case "LINK":
                        return 1;
                    case "SOURCE":
                        return 2;
                    case "CONTACT":
                        return 3;
                    case "CONTACT_TYPE":
                        return 4;
                    case "CONTACT_PREFERENCE":
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
