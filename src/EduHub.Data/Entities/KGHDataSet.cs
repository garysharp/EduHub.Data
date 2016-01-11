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
    /// Houses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGHDataSet : EduHubDataSet<KGH>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGH"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<KGH>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_KGHKEY = new Lazy<Dictionary<string, KGH>>(() => this.ToDictionary(i => i.KGHKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGH" /> fields for each CSV column header</returns>
        internal override Action<KGH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGHKEY":
                        mapper[i] = (e, v) => e.KGHKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "HOUSE_SIZE":
                        mapper[i] = (e, v) => e.HOUSE_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F01":
                        mapper[i] = (e, v) => e.AGE_F01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F02":
                        mapper[i] = (e, v) => e.AGE_F02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F03":
                        mapper[i] = (e, v) => e.AGE_F03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F04":
                        mapper[i] = (e, v) => e.AGE_F04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F05":
                        mapper[i] = (e, v) => e.AGE_F05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F06":
                        mapper[i] = (e, v) => e.AGE_F06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F07":
                        mapper[i] = (e, v) => e.AGE_F07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F08":
                        mapper[i] = (e, v) => e.AGE_F08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F09":
                        mapper[i] = (e, v) => e.AGE_F09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F10":
                        mapper[i] = (e, v) => e.AGE_F10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F11":
                        mapper[i] = (e, v) => e.AGE_F11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F12":
                        mapper[i] = (e, v) => e.AGE_F12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F13":
                        mapper[i] = (e, v) => e.AGE_F13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F14":
                        mapper[i] = (e, v) => e.AGE_F14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F15":
                        mapper[i] = (e, v) => e.AGE_F15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F16":
                        mapper[i] = (e, v) => e.AGE_F16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F17":
                        mapper[i] = (e, v) => e.AGE_F17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F18":
                        mapper[i] = (e, v) => e.AGE_F18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F19":
                        mapper[i] = (e, v) => e.AGE_F19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F20":
                        mapper[i] = (e, v) => e.AGE_F20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M01":
                        mapper[i] = (e, v) => e.AGE_M01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M02":
                        mapper[i] = (e, v) => e.AGE_M02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M03":
                        mapper[i] = (e, v) => e.AGE_M03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M04":
                        mapper[i] = (e, v) => e.AGE_M04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M05":
                        mapper[i] = (e, v) => e.AGE_M05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M06":
                        mapper[i] = (e, v) => e.AGE_M06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M07":
                        mapper[i] = (e, v) => e.AGE_M07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M08":
                        mapper[i] = (e, v) => e.AGE_M08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M09":
                        mapper[i] = (e, v) => e.AGE_M09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M10":
                        mapper[i] = (e, v) => e.AGE_M10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M11":
                        mapper[i] = (e, v) => e.AGE_M11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M12":
                        mapper[i] = (e, v) => e.AGE_M12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M13":
                        mapper[i] = (e, v) => e.AGE_M13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M14":
                        mapper[i] = (e, v) => e.AGE_M14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M15":
                        mapper[i] = (e, v) => e.AGE_M15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M16":
                        mapper[i] = (e, v) => e.AGE_M16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M17":
                        mapper[i] = (e, v) => e.AGE_M17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M18":
                        mapper[i] = (e, v) => e.AGE_M18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M19":
                        mapper[i] = (e, v) => e.AGE_M19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M20":
                        mapper[i] = (e, v) => e.AGE_M20 = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="KGH" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGH" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGH" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGH}"/> of entities</returns>
        internal override IEnumerable<KGH> ApplyDeltaEntities(IEnumerable<KGH> Entities, List<KGH> DeltaEntities)
        {
            HashSet<string> Index_KGHKEY = new HashSet<string>(DeltaEntities.Select(i => i.KGHKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KGHKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KGHKEY.Remove(entity.KGHKEY);
                            
                            if (entity.KGHKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<KGH>>> Index_CAMPUS;
        private Lazy<Dictionary<string, KGH>> Index_KGHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGH by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGH</param>
        /// <returns>List of related KGH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGH> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find KGH by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGH</param>
        /// <param name="Value">List of related KGH entities</param>
        /// <returns>True if the list of related KGH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<KGH> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find KGH by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGH</param>
        /// <returns>List of related KGH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGH> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<KGH> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGH by KGHKEY field
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find KGH</param>
        /// <returns>Related KGH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGH FindByKGHKEY(string KGHKEY)
        {
            return Index_KGHKEY.Value[KGHKEY];
        }

        /// <summary>
        /// Attempt to find KGH by KGHKEY field
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find KGH</param>
        /// <param name="Value">Related KGH entity</param>
        /// <returns>True if the related KGH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGHKEY(string KGHKEY, out KGH Value)
        {
            return Index_KGHKEY.Value.TryGetValue(KGHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGH by KGHKEY field
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find KGH</param>
        /// <returns>Related KGH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGH TryFindByKGHKEY(string KGHKEY)
        {
            KGH value;
            if (Index_KGHKEY.Value.TryGetValue(KGHKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGH table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGH](
        [KGHKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [CAMPUS] int NULL,
        [ACTIVE] varchar(1) NULL,
        [HOUSE_SIZE] smallint NULL,
        [MALES] smallint NULL,
        [FEMALES] smallint NULL,
        [AGE_F01] smallint NULL,
        [AGE_F02] smallint NULL,
        [AGE_F03] smallint NULL,
        [AGE_F04] smallint NULL,
        [AGE_F05] smallint NULL,
        [AGE_F06] smallint NULL,
        [AGE_F07] smallint NULL,
        [AGE_F08] smallint NULL,
        [AGE_F09] smallint NULL,
        [AGE_F10] smallint NULL,
        [AGE_F11] smallint NULL,
        [AGE_F12] smallint NULL,
        [AGE_F13] smallint NULL,
        [AGE_F14] smallint NULL,
        [AGE_F15] smallint NULL,
        [AGE_F16] smallint NULL,
        [AGE_F17] smallint NULL,
        [AGE_F18] smallint NULL,
        [AGE_F19] smallint NULL,
        [AGE_F20] smallint NULL,
        [AGE_M01] smallint NULL,
        [AGE_M02] smallint NULL,
        [AGE_M03] smallint NULL,
        [AGE_M04] smallint NULL,
        [AGE_M05] smallint NULL,
        [AGE_M06] smallint NULL,
        [AGE_M07] smallint NULL,
        [AGE_M08] smallint NULL,
        [AGE_M09] smallint NULL,
        [AGE_M10] smallint NULL,
        [AGE_M11] smallint NULL,
        [AGE_M12] smallint NULL,
        [AGE_M13] smallint NULL,
        [AGE_M14] smallint NULL,
        [AGE_M15] smallint NULL,
        [AGE_M16] smallint NULL,
        [AGE_M17] smallint NULL,
        [AGE_M18] smallint NULL,
        [AGE_M19] smallint NULL,
        [AGE_M20] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGH_Index_KGHKEY] PRIMARY KEY CLUSTERED (
            [KGHKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGH_Index_CAMPUS] ON [dbo].[KGH]
    (
            [CAMPUS] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGH]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[KGH] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGH]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[KGH] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGH"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGH"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGH> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KGHKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KGHKEY.Add(entity.KGHKEY);
            }

            builder.AppendLine("DELETE [dbo].[KGH] WHERE");


            // Index_KGHKEY
            builder.Append("[KGHKEY] IN (");
            for (int index = 0; index < Index_KGHKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KGHKEY
                var parameterKGHKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKGHKEY);
                command.Parameters.Add(parameterKGHKEY, SqlDbType.VarChar, 10).Value = Index_KGHKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGH data set</returns>
        public override EduHubDataSetDataReader<KGH> GetDataSetDataReader()
        {
            return new KGHDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGH data set</returns>
        public override EduHubDataSetDataReader<KGH> GetDataSetDataReader(List<KGH> Entities)
        {
            return new KGHDataReader(new EduHubDataSetLoadedReader<KGH>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGHDataReader : EduHubDataSetDataReader<KGH>
        {
            public KGHDataReader(IEduHubDataSetReader<KGH> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 50; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KGHKEY
                        return Current.KGHKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // CAMPUS
                        return Current.CAMPUS;
                    case 3: // ACTIVE
                        return Current.ACTIVE;
                    case 4: // HOUSE_SIZE
                        return Current.HOUSE_SIZE;
                    case 5: // MALES
                        return Current.MALES;
                    case 6: // FEMALES
                        return Current.FEMALES;
                    case 7: // AGE_F01
                        return Current.AGE_F01;
                    case 8: // AGE_F02
                        return Current.AGE_F02;
                    case 9: // AGE_F03
                        return Current.AGE_F03;
                    case 10: // AGE_F04
                        return Current.AGE_F04;
                    case 11: // AGE_F05
                        return Current.AGE_F05;
                    case 12: // AGE_F06
                        return Current.AGE_F06;
                    case 13: // AGE_F07
                        return Current.AGE_F07;
                    case 14: // AGE_F08
                        return Current.AGE_F08;
                    case 15: // AGE_F09
                        return Current.AGE_F09;
                    case 16: // AGE_F10
                        return Current.AGE_F10;
                    case 17: // AGE_F11
                        return Current.AGE_F11;
                    case 18: // AGE_F12
                        return Current.AGE_F12;
                    case 19: // AGE_F13
                        return Current.AGE_F13;
                    case 20: // AGE_F14
                        return Current.AGE_F14;
                    case 21: // AGE_F15
                        return Current.AGE_F15;
                    case 22: // AGE_F16
                        return Current.AGE_F16;
                    case 23: // AGE_F17
                        return Current.AGE_F17;
                    case 24: // AGE_F18
                        return Current.AGE_F18;
                    case 25: // AGE_F19
                        return Current.AGE_F19;
                    case 26: // AGE_F20
                        return Current.AGE_F20;
                    case 27: // AGE_M01
                        return Current.AGE_M01;
                    case 28: // AGE_M02
                        return Current.AGE_M02;
                    case 29: // AGE_M03
                        return Current.AGE_M03;
                    case 30: // AGE_M04
                        return Current.AGE_M04;
                    case 31: // AGE_M05
                        return Current.AGE_M05;
                    case 32: // AGE_M06
                        return Current.AGE_M06;
                    case 33: // AGE_M07
                        return Current.AGE_M07;
                    case 34: // AGE_M08
                        return Current.AGE_M08;
                    case 35: // AGE_M09
                        return Current.AGE_M09;
                    case 36: // AGE_M10
                        return Current.AGE_M10;
                    case 37: // AGE_M11
                        return Current.AGE_M11;
                    case 38: // AGE_M12
                        return Current.AGE_M12;
                    case 39: // AGE_M13
                        return Current.AGE_M13;
                    case 40: // AGE_M14
                        return Current.AGE_M14;
                    case 41: // AGE_M15
                        return Current.AGE_M15;
                    case 42: // AGE_M16
                        return Current.AGE_M16;
                    case 43: // AGE_M17
                        return Current.AGE_M17;
                    case 44: // AGE_M18
                        return Current.AGE_M18;
                    case 45: // AGE_M19
                        return Current.AGE_M19;
                    case 46: // AGE_M20
                        return Current.AGE_M20;
                    case 47: // LW_DATE
                        return Current.LW_DATE;
                    case 48: // LW_TIME
                        return Current.LW_TIME;
                    case 49: // LW_USER
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
                    case 2: // CAMPUS
                        return Current.CAMPUS == null;
                    case 3: // ACTIVE
                        return Current.ACTIVE == null;
                    case 4: // HOUSE_SIZE
                        return Current.HOUSE_SIZE == null;
                    case 5: // MALES
                        return Current.MALES == null;
                    case 6: // FEMALES
                        return Current.FEMALES == null;
                    case 7: // AGE_F01
                        return Current.AGE_F01 == null;
                    case 8: // AGE_F02
                        return Current.AGE_F02 == null;
                    case 9: // AGE_F03
                        return Current.AGE_F03 == null;
                    case 10: // AGE_F04
                        return Current.AGE_F04 == null;
                    case 11: // AGE_F05
                        return Current.AGE_F05 == null;
                    case 12: // AGE_F06
                        return Current.AGE_F06 == null;
                    case 13: // AGE_F07
                        return Current.AGE_F07 == null;
                    case 14: // AGE_F08
                        return Current.AGE_F08 == null;
                    case 15: // AGE_F09
                        return Current.AGE_F09 == null;
                    case 16: // AGE_F10
                        return Current.AGE_F10 == null;
                    case 17: // AGE_F11
                        return Current.AGE_F11 == null;
                    case 18: // AGE_F12
                        return Current.AGE_F12 == null;
                    case 19: // AGE_F13
                        return Current.AGE_F13 == null;
                    case 20: // AGE_F14
                        return Current.AGE_F14 == null;
                    case 21: // AGE_F15
                        return Current.AGE_F15 == null;
                    case 22: // AGE_F16
                        return Current.AGE_F16 == null;
                    case 23: // AGE_F17
                        return Current.AGE_F17 == null;
                    case 24: // AGE_F18
                        return Current.AGE_F18 == null;
                    case 25: // AGE_F19
                        return Current.AGE_F19 == null;
                    case 26: // AGE_F20
                        return Current.AGE_F20 == null;
                    case 27: // AGE_M01
                        return Current.AGE_M01 == null;
                    case 28: // AGE_M02
                        return Current.AGE_M02 == null;
                    case 29: // AGE_M03
                        return Current.AGE_M03 == null;
                    case 30: // AGE_M04
                        return Current.AGE_M04 == null;
                    case 31: // AGE_M05
                        return Current.AGE_M05 == null;
                    case 32: // AGE_M06
                        return Current.AGE_M06 == null;
                    case 33: // AGE_M07
                        return Current.AGE_M07 == null;
                    case 34: // AGE_M08
                        return Current.AGE_M08 == null;
                    case 35: // AGE_M09
                        return Current.AGE_M09 == null;
                    case 36: // AGE_M10
                        return Current.AGE_M10 == null;
                    case 37: // AGE_M11
                        return Current.AGE_M11 == null;
                    case 38: // AGE_M12
                        return Current.AGE_M12 == null;
                    case 39: // AGE_M13
                        return Current.AGE_M13 == null;
                    case 40: // AGE_M14
                        return Current.AGE_M14 == null;
                    case 41: // AGE_M15
                        return Current.AGE_M15 == null;
                    case 42: // AGE_M16
                        return Current.AGE_M16 == null;
                    case 43: // AGE_M17
                        return Current.AGE_M17 == null;
                    case 44: // AGE_M18
                        return Current.AGE_M18 == null;
                    case 45: // AGE_M19
                        return Current.AGE_M19 == null;
                    case 46: // AGE_M20
                        return Current.AGE_M20 == null;
                    case 47: // LW_DATE
                        return Current.LW_DATE == null;
                    case 48: // LW_TIME
                        return Current.LW_TIME == null;
                    case 49: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KGHKEY
                        return "KGHKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // CAMPUS
                        return "CAMPUS";
                    case 3: // ACTIVE
                        return "ACTIVE";
                    case 4: // HOUSE_SIZE
                        return "HOUSE_SIZE";
                    case 5: // MALES
                        return "MALES";
                    case 6: // FEMALES
                        return "FEMALES";
                    case 7: // AGE_F01
                        return "AGE_F01";
                    case 8: // AGE_F02
                        return "AGE_F02";
                    case 9: // AGE_F03
                        return "AGE_F03";
                    case 10: // AGE_F04
                        return "AGE_F04";
                    case 11: // AGE_F05
                        return "AGE_F05";
                    case 12: // AGE_F06
                        return "AGE_F06";
                    case 13: // AGE_F07
                        return "AGE_F07";
                    case 14: // AGE_F08
                        return "AGE_F08";
                    case 15: // AGE_F09
                        return "AGE_F09";
                    case 16: // AGE_F10
                        return "AGE_F10";
                    case 17: // AGE_F11
                        return "AGE_F11";
                    case 18: // AGE_F12
                        return "AGE_F12";
                    case 19: // AGE_F13
                        return "AGE_F13";
                    case 20: // AGE_F14
                        return "AGE_F14";
                    case 21: // AGE_F15
                        return "AGE_F15";
                    case 22: // AGE_F16
                        return "AGE_F16";
                    case 23: // AGE_F17
                        return "AGE_F17";
                    case 24: // AGE_F18
                        return "AGE_F18";
                    case 25: // AGE_F19
                        return "AGE_F19";
                    case 26: // AGE_F20
                        return "AGE_F20";
                    case 27: // AGE_M01
                        return "AGE_M01";
                    case 28: // AGE_M02
                        return "AGE_M02";
                    case 29: // AGE_M03
                        return "AGE_M03";
                    case 30: // AGE_M04
                        return "AGE_M04";
                    case 31: // AGE_M05
                        return "AGE_M05";
                    case 32: // AGE_M06
                        return "AGE_M06";
                    case 33: // AGE_M07
                        return "AGE_M07";
                    case 34: // AGE_M08
                        return "AGE_M08";
                    case 35: // AGE_M09
                        return "AGE_M09";
                    case 36: // AGE_M10
                        return "AGE_M10";
                    case 37: // AGE_M11
                        return "AGE_M11";
                    case 38: // AGE_M12
                        return "AGE_M12";
                    case 39: // AGE_M13
                        return "AGE_M13";
                    case 40: // AGE_M14
                        return "AGE_M14";
                    case 41: // AGE_M15
                        return "AGE_M15";
                    case 42: // AGE_M16
                        return "AGE_M16";
                    case 43: // AGE_M17
                        return "AGE_M17";
                    case 44: // AGE_M18
                        return "AGE_M18";
                    case 45: // AGE_M19
                        return "AGE_M19";
                    case 46: // AGE_M20
                        return "AGE_M20";
                    case 47: // LW_DATE
                        return "LW_DATE";
                    case 48: // LW_TIME
                        return "LW_TIME";
                    case 49: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KGHKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "CAMPUS":
                        return 2;
                    case "ACTIVE":
                        return 3;
                    case "HOUSE_SIZE":
                        return 4;
                    case "MALES":
                        return 5;
                    case "FEMALES":
                        return 6;
                    case "AGE_F01":
                        return 7;
                    case "AGE_F02":
                        return 8;
                    case "AGE_F03":
                        return 9;
                    case "AGE_F04":
                        return 10;
                    case "AGE_F05":
                        return 11;
                    case "AGE_F06":
                        return 12;
                    case "AGE_F07":
                        return 13;
                    case "AGE_F08":
                        return 14;
                    case "AGE_F09":
                        return 15;
                    case "AGE_F10":
                        return 16;
                    case "AGE_F11":
                        return 17;
                    case "AGE_F12":
                        return 18;
                    case "AGE_F13":
                        return 19;
                    case "AGE_F14":
                        return 20;
                    case "AGE_F15":
                        return 21;
                    case "AGE_F16":
                        return 22;
                    case "AGE_F17":
                        return 23;
                    case "AGE_F18":
                        return 24;
                    case "AGE_F19":
                        return 25;
                    case "AGE_F20":
                        return 26;
                    case "AGE_M01":
                        return 27;
                    case "AGE_M02":
                        return 28;
                    case "AGE_M03":
                        return 29;
                    case "AGE_M04":
                        return 30;
                    case "AGE_M05":
                        return 31;
                    case "AGE_M06":
                        return 32;
                    case "AGE_M07":
                        return 33;
                    case "AGE_M08":
                        return 34;
                    case "AGE_M09":
                        return 35;
                    case "AGE_M10":
                        return 36;
                    case "AGE_M11":
                        return 37;
                    case "AGE_M12":
                        return 38;
                    case "AGE_M13":
                        return 39;
                    case "AGE_M14":
                        return 40;
                    case "AGE_M15":
                        return 41;
                    case "AGE_M16":
                        return 42;
                    case "AGE_M17":
                        return 43;
                    case "AGE_M18":
                        return 44;
                    case "AGE_M19":
                        return 45;
                    case "AGE_M20":
                        return 46;
                    case "LW_DATE":
                        return 47;
                    case "LW_TIME":
                        return 48;
                    case "LW_USER":
                        return 49;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
