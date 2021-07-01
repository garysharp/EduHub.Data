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
    /// Countries Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGTDataSet : EduHubDataSet<KGT>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<Dictionary<string, KGT>>(() => this.ToDictionary(i => i.COUNTRY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KGT>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGT" /> fields for each CSV column header</returns>
        internal override Action<KGT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ENGLISH_SPEAKING":
                        mapper[i] = (e, v) => e.ENGLISH_SPEAKING = v;
                        break;
                    case "SACC":
                        mapper[i] = (e, v) => e.SACC = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
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
        /// Merges <see cref="KGT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGT}"/> of entities</returns>
        internal override IEnumerable<KGT> ApplyDeltaEntities(IEnumerable<KGT> Entities, List<KGT> DeltaEntities)
        {
            HashSet<string> Index_COUNTRY = new HashSet<string>(DeltaEntities.Select(i => i.COUNTRY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.COUNTRY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_COUNTRY.Remove(entity.COUNTRY);
                            
                            if (entity.COUNTRY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGT>> Index_COUNTRY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KGT>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGT FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <param name="Value">Related KGT entity</param>
        /// <returns>True if the related KGT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out KGT Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGT TryFindByCOUNTRY(string COUNTRY)
        {
            KGT value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <returns>List of related KGT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGT> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <param name="Value">List of related KGT entities</param>
        /// <returns>True if the list of related KGT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KGT> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KGT by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KGT</param>
        /// <returns>List of related KGT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGT> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KGT> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGT](
        [COUNTRY] varchar(6) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [ENGLISH_SPEAKING] varchar(1) NULL,
        [SACC] varchar(4) NULL,
        [OBSOLETE] varchar(1) NULL,
        [REFUGEE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGT_Index_COUNTRY] PRIMARY KEY CLUSTERED (
            [COUNTRY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGT_Index_LW_DATE] ON [dbo].[KGT]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGT]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[KGT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGT]') AND name = N'Index_LW_DATE')
    ALTER INDEX [Index_LW_DATE] ON [dbo].[KGT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_COUNTRY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_COUNTRY.Add(entity.COUNTRY);
            }

            builder.AppendLine("DELETE [dbo].[KGT] WHERE");


            // Index_COUNTRY
            builder.Append("[COUNTRY] IN (");
            for (int index = 0; index < Index_COUNTRY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // COUNTRY
                var parameterCOUNTRY = $"@p{parameterIndex++}";
                builder.Append(parameterCOUNTRY);
                command.Parameters.Add(parameterCOUNTRY, SqlDbType.VarChar, 6).Value = Index_COUNTRY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGT data set</returns>
        public override EduHubDataSetDataReader<KGT> GetDataSetDataReader()
        {
            return new KGTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGT data set</returns>
        public override EduHubDataSetDataReader<KGT> GetDataSetDataReader(List<KGT> Entities)
        {
            return new KGTDataReader(new EduHubDataSetLoadedReader<KGT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGTDataReader : EduHubDataSetDataReader<KGT>
        {
            public KGTDataReader(IEduHubDataSetReader<KGT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // COUNTRY
                        return Current.COUNTRY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // ENGLISH_SPEAKING
                        return Current.ENGLISH_SPEAKING;
                    case 3: // SACC
                        return Current.SACC;
                    case 4: // OBSOLETE
                        return Current.OBSOLETE;
                    case 5: // REFUGEE
                        return Current.REFUGEE;
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
                    case 2: // ENGLISH_SPEAKING
                        return Current.ENGLISH_SPEAKING == null;
                    case 3: // SACC
                        return Current.SACC == null;
                    case 4: // OBSOLETE
                        return Current.OBSOLETE == null;
                    case 5: // REFUGEE
                        return Current.REFUGEE == null;
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
                    case 0: // COUNTRY
                        return "COUNTRY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ENGLISH_SPEAKING
                        return "ENGLISH_SPEAKING";
                    case 3: // SACC
                        return "SACC";
                    case 4: // OBSOLETE
                        return "OBSOLETE";
                    case 5: // REFUGEE
                        return "REFUGEE";
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
                    case "COUNTRY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ENGLISH_SPEAKING":
                        return 2;
                    case "SACC":
                        return 3;
                    case "OBSOLETE":
                        return 4;
                    case "REFUGEE":
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
