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
    /// Calendar Dates for Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCCDataSet : EduHubDataSet<KCC>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CURRENT_QUILT = new Lazy<NullDictionary<string, IReadOnlyList<KCC>>>(() => this.ToGroupedNullDictionary(i => i.CURRENT_QUILT));
            Index_KCCKEY = new Lazy<Dictionary<DateTime, KCC>>(() => this.ToDictionary(i => i.KCCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCC" /> fields for each CSV column header</returns>
        internal override Action<KCC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCCKEY":
                        mapper[i] = (e, v) => e.KCCKEY = DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DAYTODAY":
                        mapper[i] = (e, v) => e.DAYTODAY = v;
                        break;
                    case "DAY_TYPE":
                        mapper[i] = (e, v) => e.DAY_TYPE = v;
                        break;
                    case "JULIAN":
                        mapper[i] = (e, v) => e.JULIAN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_YEAR":
                        mapper[i] = (e, v) => e.DAY_YEAR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_MONTH":
                        mapper[i] = (e, v) => e.DAY_MONTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERM":
                        mapper[i] = (e, v) => e.TERM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WEEK":
                        mapper[i] = (e, v) => e.WEEK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAY_CYCLE":
                        mapper[i] = (e, v) => e.DAY_CYCLE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CURRENT_QUILT":
                        mapper[i] = (e, v) => e.CURRENT_QUILT = v;
                        break;
                    case "HALF_DAY_GENERATED":
                        mapper[i] = (e, v) => e.HALF_DAY_GENERATED = v;
                        break;
                    case "PERIOD_GENERATED":
                        mapper[i] = (e, v) => e.PERIOD_GENERATED = v;
                        break;
                    case "PAR_SOURCE":
                        mapper[i] = (e, v) => e.PAR_SOURCE = v;
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
        /// Merges <see cref="KCC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCC}"/> of entities</returns>
        internal override IEnumerable<KCC> ApplyDeltaEntities(IEnumerable<KCC> Entities, List<KCC> DeltaEntities)
        {
            HashSet<DateTime> Index_KCCKEY = new HashSet<DateTime>(DeltaEntities.Select(i => i.KCCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KCCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KCCKEY.Remove(entity.KCCKEY);
                            
                            if (entity.KCCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<KCC>>> Index_CURRENT_QUILT;
        private Lazy<Dictionary<DateTime, KCC>> Index_KCCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <returns>List of related KCC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCC> FindByCURRENT_QUILT(string CURRENT_QUILT)
        {
            return Index_CURRENT_QUILT.Value[CURRENT_QUILT];
        }

        /// <summary>
        /// Attempt to find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <param name="Value">List of related KCC entities</param>
        /// <returns>True if the list of related KCC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCURRENT_QUILT(string CURRENT_QUILT, out IReadOnlyList<KCC> Value)
        {
            return Index_CURRENT_QUILT.Value.TryGetValue(CURRENT_QUILT, out Value);
        }

        /// <summary>
        /// Attempt to find KCC by CURRENT_QUILT field
        /// </summary>
        /// <param name="CURRENT_QUILT">CURRENT_QUILT value used to find KCC</param>
        /// <returns>List of related KCC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCC> TryFindByCURRENT_QUILT(string CURRENT_QUILT)
        {
            IReadOnlyList<KCC> value;
            if (Index_CURRENT_QUILT.Value.TryGetValue(CURRENT_QUILT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <returns>Related KCC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCC FindByKCCKEY(DateTime KCCKEY)
        {
            return Index_KCCKEY.Value[KCCKEY];
        }

        /// <summary>
        /// Attempt to find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <param name="Value">Related KCC entity</param>
        /// <returns>True if the related KCC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCCKEY(DateTime KCCKEY, out KCC Value)
        {
            return Index_KCCKEY.Value.TryGetValue(KCCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCC by KCCKEY field
        /// </summary>
        /// <param name="KCCKEY">KCCKEY value used to find KCC</param>
        /// <returns>Related KCC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCC TryFindByKCCKEY(DateTime KCCKEY)
        {
            KCC value;
            if (Index_KCCKEY.Value.TryGetValue(KCCKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCC](
        [KCCKEY] datetime NOT NULL,
        [DAYTODAY] varchar(10) NULL,
        [DAY_TYPE] varchar(1) NULL,
        [JULIAN] smallint NULL,
        [SEMESTER] smallint NULL,
        [DAY_YEAR] smallint NULL,
        [DAY_MONTH] smallint NULL,
        [TERM] smallint NULL,
        [WEEK] smallint NULL,
        [DAY_CYCLE] smallint NULL,
        [CURRENT_QUILT] varchar(8) NULL,
        [HALF_DAY_GENERATED] varchar(1) NULL,
        [PERIOD_GENERATED] varchar(1) NULL,
        [PAR_SOURCE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCC_Index_KCCKEY] PRIMARY KEY CLUSTERED (
            [KCCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCC_Index_CURRENT_QUILT] ON [dbo].[KCC]
    (
            [CURRENT_QUILT] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCC]') AND name = N'Index_CURRENT_QUILT')
    ALTER INDEX [Index_CURRENT_QUILT] ON [dbo].[KCC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCC]') AND name = N'Index_CURRENT_QUILT')
    ALTER INDEX [Index_CURRENT_QUILT] ON [dbo].[KCC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<DateTime> Index_KCCKEY = new List<DateTime>();

            foreach (var entity in Entities)
            {
                Index_KCCKEY.Add(entity.KCCKEY);
            }

            builder.AppendLine("DELETE [dbo].[KCC] WHERE");


            // Index_KCCKEY
            builder.Append("[KCCKEY] IN (");
            for (int index = 0; index < Index_KCCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KCCKEY
                var parameterKCCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKCCKEY);
                command.Parameters.Add(parameterKCCKEY, SqlDbType.DateTime).Value = Index_KCCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCC data set</returns>
        public override EduHubDataSetDataReader<KCC> GetDataSetDataReader()
        {
            return new KCCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCC data set</returns>
        public override EduHubDataSetDataReader<KCC> GetDataSetDataReader(List<KCC> Entities)
        {
            return new KCCDataReader(new EduHubDataSetLoadedReader<KCC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCCDataReader : EduHubDataSetDataReader<KCC>
        {
            public KCCDataReader(IEduHubDataSetReader<KCC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 17; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KCCKEY
                        return Current.KCCKEY;
                    case 1: // DAYTODAY
                        return Current.DAYTODAY;
                    case 2: // DAY_TYPE
                        return Current.DAY_TYPE;
                    case 3: // JULIAN
                        return Current.JULIAN;
                    case 4: // SEMESTER
                        return Current.SEMESTER;
                    case 5: // DAY_YEAR
                        return Current.DAY_YEAR;
                    case 6: // DAY_MONTH
                        return Current.DAY_MONTH;
                    case 7: // TERM
                        return Current.TERM;
                    case 8: // WEEK
                        return Current.WEEK;
                    case 9: // DAY_CYCLE
                        return Current.DAY_CYCLE;
                    case 10: // CURRENT_QUILT
                        return Current.CURRENT_QUILT;
                    case 11: // HALF_DAY_GENERATED
                        return Current.HALF_DAY_GENERATED;
                    case 12: // PERIOD_GENERATED
                        return Current.PERIOD_GENERATED;
                    case 13: // PAR_SOURCE
                        return Current.PAR_SOURCE;
                    case 14: // LW_DATE
                        return Current.LW_DATE;
                    case 15: // LW_TIME
                        return Current.LW_TIME;
                    case 16: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DAYTODAY
                        return Current.DAYTODAY == null;
                    case 2: // DAY_TYPE
                        return Current.DAY_TYPE == null;
                    case 3: // JULIAN
                        return Current.JULIAN == null;
                    case 4: // SEMESTER
                        return Current.SEMESTER == null;
                    case 5: // DAY_YEAR
                        return Current.DAY_YEAR == null;
                    case 6: // DAY_MONTH
                        return Current.DAY_MONTH == null;
                    case 7: // TERM
                        return Current.TERM == null;
                    case 8: // WEEK
                        return Current.WEEK == null;
                    case 9: // DAY_CYCLE
                        return Current.DAY_CYCLE == null;
                    case 10: // CURRENT_QUILT
                        return Current.CURRENT_QUILT == null;
                    case 11: // HALF_DAY_GENERATED
                        return Current.HALF_DAY_GENERATED == null;
                    case 12: // PERIOD_GENERATED
                        return Current.PERIOD_GENERATED == null;
                    case 13: // PAR_SOURCE
                        return Current.PAR_SOURCE == null;
                    case 14: // LW_DATE
                        return Current.LW_DATE == null;
                    case 15: // LW_TIME
                        return Current.LW_TIME == null;
                    case 16: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCCKEY
                        return "KCCKEY";
                    case 1: // DAYTODAY
                        return "DAYTODAY";
                    case 2: // DAY_TYPE
                        return "DAY_TYPE";
                    case 3: // JULIAN
                        return "JULIAN";
                    case 4: // SEMESTER
                        return "SEMESTER";
                    case 5: // DAY_YEAR
                        return "DAY_YEAR";
                    case 6: // DAY_MONTH
                        return "DAY_MONTH";
                    case 7: // TERM
                        return "TERM";
                    case 8: // WEEK
                        return "WEEK";
                    case 9: // DAY_CYCLE
                        return "DAY_CYCLE";
                    case 10: // CURRENT_QUILT
                        return "CURRENT_QUILT";
                    case 11: // HALF_DAY_GENERATED
                        return "HALF_DAY_GENERATED";
                    case 12: // PERIOD_GENERATED
                        return "PERIOD_GENERATED";
                    case 13: // PAR_SOURCE
                        return "PAR_SOURCE";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    case 16: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCCKEY":
                        return 0;
                    case "DAYTODAY":
                        return 1;
                    case "DAY_TYPE":
                        return 2;
                    case "JULIAN":
                        return 3;
                    case "SEMESTER":
                        return 4;
                    case "DAY_YEAR":
                        return 5;
                    case "DAY_MONTH":
                        return 6;
                    case "TERM":
                        return 7;
                    case "WEEK":
                        return 8;
                    case "DAY_CYCLE":
                        return 9;
                    case "CURRENT_QUILT":
                        return 10;
                    case "HALF_DAY_GENERATED":
                        return 11;
                    case "PERIOD_GENERATED":
                        return 12;
                    case "PAR_SOURCE":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    case "LW_USER":
                        return 16;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
