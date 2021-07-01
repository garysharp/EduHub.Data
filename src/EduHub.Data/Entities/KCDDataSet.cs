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
    /// Doctors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCDDataSet : EduHubDataSet<KCD>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCDKEY = new Lazy<Dictionary<string, KCD>>(() => this.ToDictionary(i => i.KCDKEY));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KCD>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCD" /> fields for each CSV column header</returns>
        internal override Action<KCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCDKEY":
                        mapper[i] = (e, v) => e.KCDKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DR_GROUP":
                        mapper[i] = (e, v) => e.DR_GROUP = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
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
        /// Merges <see cref="KCD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCD}"/> of entities</returns>
        internal override IEnumerable<KCD> ApplyDeltaEntities(IEnumerable<KCD> Entities, List<KCD> DeltaEntities)
        {
            HashSet<string> Index_KCDKEY = new HashSet<string>(DeltaEntities.Select(i => i.KCDKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KCDKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KCDKEY.Remove(entity.KCDKEY);
                            
                            if (entity.KCDKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KCD>> Index_KCDKEY;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KCD>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <returns>Related KCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD FindByKCDKEY(string KCDKEY)
        {
            return Index_KCDKEY.Value[KCDKEY];
        }

        /// <summary>
        /// Attempt to find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <param name="Value">Related KCD entity</param>
        /// <returns>True if the related KCD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCDKEY(string KCDKEY, out KCD Value)
        {
            return Index_KCDKEY.Value.TryGetValue(KCDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCD by KCDKEY field
        /// </summary>
        /// <param name="KCDKEY">KCDKEY value used to find KCD</param>
        /// <returns>Related KCD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCD TryFindByKCDKEY(string KCDKEY)
        {
            KCD value;
            if (Index_KCDKEY.Value.TryGetValue(KCDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <returns>List of related KCD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <param name="Value">List of related KCD entities</param>
        /// <returns>True if the list of related KCD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KCD> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KCD by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KCD</param>
        /// <returns>List of related KCD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCD> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KCD> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCD](
        [KCDKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [DR_GROUP] varchar(1) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [SUBURB] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [FAX] varchar(20) NULL,
        [KAP_LINK] varchar(34) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCD_Index_KCDKEY] PRIMARY KEY CLUSTERED (
            [KCDKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCD_Index_LW_DATE] ON [dbo].[KCD]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCD]') AND name = N'KCD_Index_LW_DATE')
    ALTER INDEX [KCD_Index_LW_DATE] ON [dbo].[KCD] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCD]') AND name = N'KCD_Index_LW_DATE')
    ALTER INDEX [KCD_Index_LW_DATE] ON [dbo].[KCD] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KCDKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KCDKEY.Add(entity.KCDKEY);
            }

            builder.AppendLine("DELETE [dbo].[KCD] WHERE");


            // Index_KCDKEY
            builder.Append("[KCDKEY] IN (");
            for (int index = 0; index < Index_KCDKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KCDKEY
                var parameterKCDKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKCDKEY);
                command.Parameters.Add(parameterKCDKEY, SqlDbType.VarChar, 10).Value = Index_KCDKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCD data set</returns>
        public override EduHubDataSetDataReader<KCD> GetDataSetDataReader()
        {
            return new KCDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCD data set</returns>
        public override EduHubDataSetDataReader<KCD> GetDataSetDataReader(List<KCD> Entities)
        {
            return new KCDDataReader(new EduHubDataSetLoadedReader<KCD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCDDataReader : EduHubDataSetDataReader<KCD>
        {
            public KCDDataReader(IEduHubDataSetReader<KCD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KCDKEY
                        return Current.KCDKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // DR_GROUP
                        return Current.DR_GROUP;
                    case 3: // ADDRESS01
                        return Current.ADDRESS01;
                    case 4: // ADDRESS02
                        return Current.ADDRESS02;
                    case 5: // SUBURB
                        return Current.SUBURB;
                    case 6: // STATE
                        return Current.STATE;
                    case 7: // POSTCODE
                        return Current.POSTCODE;
                    case 8: // TELEPHONE
                        return Current.TELEPHONE;
                    case 9: // FAX
                        return Current.FAX;
                    case 10: // KAP_LINK
                        return Current.KAP_LINK;
                    case 11: // LW_DATE
                        return Current.LW_DATE;
                    case 12: // LW_TIME
                        return Current.LW_TIME;
                    case 13: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // DR_GROUP
                        return Current.DR_GROUP == null;
                    case 3: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 4: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 5: // SUBURB
                        return Current.SUBURB == null;
                    case 6: // STATE
                        return Current.STATE == null;
                    case 7: // POSTCODE
                        return Current.POSTCODE == null;
                    case 8: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 9: // FAX
                        return Current.FAX == null;
                    case 10: // KAP_LINK
                        return Current.KAP_LINK == null;
                    case 11: // LW_DATE
                        return Current.LW_DATE == null;
                    case 12: // LW_TIME
                        return Current.LW_TIME == null;
                    case 13: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCDKEY
                        return "KCDKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // DR_GROUP
                        return "DR_GROUP";
                    case 3: // ADDRESS01
                        return "ADDRESS01";
                    case 4: // ADDRESS02
                        return "ADDRESS02";
                    case 5: // SUBURB
                        return "SUBURB";
                    case 6: // STATE
                        return "STATE";
                    case 7: // POSTCODE
                        return "POSTCODE";
                    case 8: // TELEPHONE
                        return "TELEPHONE";
                    case 9: // FAX
                        return "FAX";
                    case 10: // KAP_LINK
                        return "KAP_LINK";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCDKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "DR_GROUP":
                        return 2;
                    case "ADDRESS01":
                        return 3;
                    case "ADDRESS02":
                        return 4;
                    case "SUBURB":
                        return 5;
                    case "STATE":
                        return 6;
                    case "POSTCODE":
                        return 7;
                    case "TELEPHONE":
                        return 8;
                    case "FAX":
                        return 9;
                    case "KAP_LINK":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
