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
    /// Australian Postcodes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAPDataSet : EduHubDataSet<KAP>
    {
        /// <inheritdoc />
        public override string Name { get { return "KAP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KAPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KAPKEY = new Lazy<Dictionary<string, KAP>>(() => this.ToDictionary(i => i.KAPKEY));
            Index_PLACE_NAME = new Lazy<NullDictionary<string, IReadOnlyList<KAP>>>(() => this.ToGroupedNullDictionary(i => i.PLACE_NAME));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAP" /> fields for each CSV column header</returns>
        internal override Action<KAP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAPKEY":
                        mapper[i] = (e, v) => e.KAPKEY = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "PLACE_NAME":
                        mapper[i] = (e, v) => e.PLACE_NAME = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "DISCRIMINATOR":
                        mapper[i] = (e, v) => e.DISCRIMINATOR = v;
                        break;
                    case "STREET_ADD":
                        mapper[i] = (e, v) => e.STREET_ADD = v;
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
        /// Merges <see cref="KAP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KAP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KAP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KAP}"/> of entities</returns>
        internal override IEnumerable<KAP> ApplyDeltaEntities(IEnumerable<KAP> Entities, List<KAP> DeltaEntities)
        {
            HashSet<string> Index_KAPKEY = new HashSet<string>(DeltaEntities.Select(i => i.KAPKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KAPKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KAPKEY.Remove(entity.KAPKEY);
                            
                            if (entity.KAPKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KAP>> Index_KAPKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KAP>>> Index_PLACE_NAME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <returns>Related KAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAP FindByKAPKEY(string KAPKEY)
        {
            return Index_KAPKEY.Value[KAPKEY];
        }

        /// <summary>
        /// Attempt to find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <param name="Value">Related KAP entity</param>
        /// <returns>True if the related KAP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKAPKEY(string KAPKEY, out KAP Value)
        {
            return Index_KAPKEY.Value.TryGetValue(KAPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <returns>Related KAP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAP TryFindByKAPKEY(string KAPKEY)
        {
            KAP value;
            if (Index_KAPKEY.Value.TryGetValue(KAPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <returns>List of related KAP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KAP> FindByPLACE_NAME(string PLACE_NAME)
        {
            return Index_PLACE_NAME.Value[PLACE_NAME];
        }

        /// <summary>
        /// Attempt to find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <param name="Value">List of related KAP entities</param>
        /// <returns>True if the list of related KAP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLACE_NAME(string PLACE_NAME, out IReadOnlyList<KAP> Value)
        {
            return Index_PLACE_NAME.Value.TryGetValue(PLACE_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <returns>List of related KAP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KAP> TryFindByPLACE_NAME(string PLACE_NAME)
        {
            IReadOnlyList<KAP> value;
            if (Index_PLACE_NAME.Value.TryGetValue(PLACE_NAME, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KAP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KAP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KAP](
        [KAPKEY] varchar(34) NOT NULL,
        [POSTCODE] varchar(4) NULL,
        [PLACE_NAME] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [DISCRIMINATOR] varchar(30) NULL,
        [STREET_ADD] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KAP_Index_KAPKEY] PRIMARY KEY CLUSTERED (
            [KAPKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KAP_Index_PLACE_NAME] ON [dbo].[KAP]
    (
            [PLACE_NAME] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KAP]') AND name = N'KAP_Index_PLACE_NAME')
    ALTER INDEX [KAP_Index_PLACE_NAME] ON [dbo].[KAP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KAP]') AND name = N'KAP_Index_PLACE_NAME')
    ALTER INDEX [KAP_Index_PLACE_NAME] ON [dbo].[KAP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KAP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KAP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KAP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KAPKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KAPKEY.Add(entity.KAPKEY);
            }

            builder.AppendLine("DELETE [dbo].[KAP] WHERE");


            // Index_KAPKEY
            builder.Append("[KAPKEY] IN (");
            for (int index = 0; index < Index_KAPKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KAPKEY
                var parameterKAPKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKAPKEY);
                command.Parameters.Add(parameterKAPKEY, SqlDbType.VarChar, 34).Value = Index_KAPKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAP data set</returns>
        public override EduHubDataSetDataReader<KAP> GetDataSetDataReader()
        {
            return new KAPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAP data set</returns>
        public override EduHubDataSetDataReader<KAP> GetDataSetDataReader(List<KAP> Entities)
        {
            return new KAPDataReader(new EduHubDataSetLoadedReader<KAP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KAPDataReader : EduHubDataSetDataReader<KAP>
        {
            public KAPDataReader(IEduHubDataSetReader<KAP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KAPKEY
                        return Current.KAPKEY;
                    case 1: // POSTCODE
                        return Current.POSTCODE;
                    case 2: // PLACE_NAME
                        return Current.PLACE_NAME;
                    case 3: // STATE
                        return Current.STATE;
                    case 4: // DISCRIMINATOR
                        return Current.DISCRIMINATOR;
                    case 5: // STREET_ADD
                        return Current.STREET_ADD;
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
                    case 1: // POSTCODE
                        return Current.POSTCODE == null;
                    case 2: // PLACE_NAME
                        return Current.PLACE_NAME == null;
                    case 3: // STATE
                        return Current.STATE == null;
                    case 4: // DISCRIMINATOR
                        return Current.DISCRIMINATOR == null;
                    case 5: // STREET_ADD
                        return Current.STREET_ADD == null;
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
                    case 0: // KAPKEY
                        return "KAPKEY";
                    case 1: // POSTCODE
                        return "POSTCODE";
                    case 2: // PLACE_NAME
                        return "PLACE_NAME";
                    case 3: // STATE
                        return "STATE";
                    case 4: // DISCRIMINATOR
                        return "DISCRIMINATOR";
                    case 5: // STREET_ADD
                        return "STREET_ADD";
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
                    case "KAPKEY":
                        return 0;
                    case "POSTCODE":
                        return 1;
                    case "PLACE_NAME":
                        return 2;
                    case "STATE":
                        return 3;
                    case "DISCRIMINATOR":
                        return 4;
                    case "STREET_ADD":
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
#endif
