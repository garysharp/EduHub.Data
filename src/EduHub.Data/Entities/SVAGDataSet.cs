﻿using System;
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
    /// VELS Aggregated Dimensions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SVAGDataSet : EduHubDataSet<SVAG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SVAG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SVAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COHORT = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.COHORT));
            Index_SVAGKEY = new Lazy<Dictionary<int, SVAG>>(() => this.ToDictionary(i => i.SVAGKEY));
            Index_VDIMENSION = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.VDIMENSION));
            Index_VDOMAIN = new Lazy<NullDictionary<string, IReadOnlyList<SVAG>>>(() => this.ToGroupedNullDictionary(i => i.VDOMAIN));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SVAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SVAG" /> fields for each CSV column header</returns>
        internal override Action<SVAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SVAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SVAGKEY":
                        mapper[i] = (e, v) => e.SVAGKEY = int.Parse(v);
                        break;
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "YEAR_SEMESTER":
                        mapper[i] = (e, v) => e.YEAR_SEMESTER = v;
                        break;
                    case "VDIMENSION":
                        mapper[i] = (e, v) => e.VDIMENSION = v;
                        break;
                    case "VDOMAIN":
                        mapper[i] = (e, v) => e.VDOMAIN = v;
                        break;
                    case "NUMBER_AT01":
                        mapper[i] = (e, v) => e.NUMBER_AT01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT02":
                        mapper[i] = (e, v) => e.NUMBER_AT02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT03":
                        mapper[i] = (e, v) => e.NUMBER_AT03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT04":
                        mapper[i] = (e, v) => e.NUMBER_AT04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT05":
                        mapper[i] = (e, v) => e.NUMBER_AT05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT06":
                        mapper[i] = (e, v) => e.NUMBER_AT06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT07":
                        mapper[i] = (e, v) => e.NUMBER_AT07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT08":
                        mapper[i] = (e, v) => e.NUMBER_AT08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT09":
                        mapper[i] = (e, v) => e.NUMBER_AT09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT10":
                        mapper[i] = (e, v) => e.NUMBER_AT10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT11":
                        mapper[i] = (e, v) => e.NUMBER_AT11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT12":
                        mapper[i] = (e, v) => e.NUMBER_AT12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT13":
                        mapper[i] = (e, v) => e.NUMBER_AT13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT14":
                        mapper[i] = (e, v) => e.NUMBER_AT14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT15":
                        mapper[i] = (e, v) => e.NUMBER_AT15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT16":
                        mapper[i] = (e, v) => e.NUMBER_AT16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT17":
                        mapper[i] = (e, v) => e.NUMBER_AT17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT18":
                        mapper[i] = (e, v) => e.NUMBER_AT18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT19":
                        mapper[i] = (e, v) => e.NUMBER_AT19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT20":
                        mapper[i] = (e, v) => e.NUMBER_AT20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT21":
                        mapper[i] = (e, v) => e.NUMBER_AT21 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT22":
                        mapper[i] = (e, v) => e.NUMBER_AT22 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT23":
                        mapper[i] = (e, v) => e.NUMBER_AT23 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT24":
                        mapper[i] = (e, v) => e.NUMBER_AT24 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT25":
                        mapper[i] = (e, v) => e.NUMBER_AT25 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT26":
                        mapper[i] = (e, v) => e.NUMBER_AT26 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT27":
                        mapper[i] = (e, v) => e.NUMBER_AT27 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT28":
                        mapper[i] = (e, v) => e.NUMBER_AT28 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT29":
                        mapper[i] = (e, v) => e.NUMBER_AT29 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT30":
                        mapper[i] = (e, v) => e.NUMBER_AT30 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT31":
                        mapper[i] = (e, v) => e.NUMBER_AT31 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT32":
                        mapper[i] = (e, v) => e.NUMBER_AT32 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT33":
                        mapper[i] = (e, v) => e.NUMBER_AT33 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_AT34":
                        mapper[i] = (e, v) => e.NUMBER_AT34 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NO_NA":
                        mapper[i] = (e, v) => e.NO_NA = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NO_NT":
                        mapper[i] = (e, v) => e.NO_NT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NO_DNP":
                        mapper[i] = (e, v) => e.NO_DNP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TOTAL_NUMBER":
                        mapper[i] = (e, v) => e.TOTAL_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SENT_TO_DEET":
                        mapper[i] = (e, v) => e.SENT_TO_DEET = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SVAG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SVAG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SVAG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SVAG}"/> of entities</returns>
        internal override IEnumerable<SVAG> ApplyDeltaEntities(IEnumerable<SVAG> Entities, List<SVAG> DeltaEntities)
        {
            HashSet<int> Index_SVAGKEY = new HashSet<int>(DeltaEntities.Select(i => i.SVAGKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SVAGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SVAGKEY.Remove(entity.SVAGKEY);
                            
                            if (entity.SVAGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_COHORT;
        private Lazy<Dictionary<int, SVAG>> Index_SVAGKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_VDIMENSION;
        private Lazy<NullDictionary<string, IReadOnlyList<SVAG>>> Index_VDOMAIN;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindByCOHORT(string COHORT)
        {
            return Index_COHORT.Value[COHORT];
        }

        /// <summary>
        /// Attempt to find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOHORT(string COHORT, out IReadOnlyList<SVAG> Value)
        {
            return Index_COHORT.Value.TryGetValue(COHORT, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by COHORT field
        /// </summary>
        /// <param name="COHORT">COHORT value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindByCOHORT(string COHORT)
        {
            IReadOnlyList<SVAG> value;
            if (Index_COHORT.Value.TryGetValue(COHORT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <returns>Related SVAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SVAG FindBySVAGKEY(int SVAGKEY)
        {
            return Index_SVAGKEY.Value[SVAGKEY];
        }

        /// <summary>
        /// Attempt to find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <param name="Value">Related SVAG entity</param>
        /// <returns>True if the related SVAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySVAGKEY(int SVAGKEY, out SVAG Value)
        {
            return Index_SVAGKEY.Value.TryGetValue(SVAGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by SVAGKEY field
        /// </summary>
        /// <param name="SVAGKEY">SVAGKEY value used to find SVAG</param>
        /// <returns>Related SVAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SVAG TryFindBySVAGKEY(int SVAGKEY)
        {
            SVAG value;
            if (Index_SVAGKEY.Value.TryGetValue(SVAGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindByVDIMENSION(string VDIMENSION)
        {
            return Index_VDIMENSION.Value[VDIMENSION];
        }

        /// <summary>
        /// Attempt to find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDIMENSION(string VDIMENSION, out IReadOnlyList<SVAG> Value)
        {
            return Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by VDIMENSION field
        /// </summary>
        /// <param name="VDIMENSION">VDIMENSION value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindByVDIMENSION(string VDIMENSION)
        {
            IReadOnlyList<SVAG> value;
            if (Index_VDIMENSION.Value.TryGetValue(VDIMENSION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SVAG by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find SVAG</param>
        /// <returns>List of related SVAG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> FindByVDOMAIN(string VDOMAIN)
        {
            return Index_VDOMAIN.Value[VDOMAIN];
        }

        /// <summary>
        /// Attempt to find SVAG by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find SVAG</param>
        /// <param name="Value">List of related SVAG entities</param>
        /// <returns>True if the list of related SVAG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVDOMAIN(string VDOMAIN, out IReadOnlyList<SVAG> Value)
        {
            return Index_VDOMAIN.Value.TryGetValue(VDOMAIN, out Value);
        }

        /// <summary>
        /// Attempt to find SVAG by VDOMAIN field
        /// </summary>
        /// <param name="VDOMAIN">VDOMAIN value used to find SVAG</param>
        /// <returns>List of related SVAG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SVAG> TryFindByVDOMAIN(string VDOMAIN)
        {
            IReadOnlyList<SVAG> value;
            if (Index_VDOMAIN.Value.TryGetValue(VDOMAIN, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SVAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SVAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SVAG](
        [SVAGKEY] int IDENTITY NOT NULL,
        [COHORT] varchar(2) NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [CAMPUS] int NULL,
        [YEAR_SEMESTER] varchar(6) NULL,
        [VDIMENSION] varchar(10) NULL,
        [VDOMAIN] varchar(10) NULL,
        [NUMBER_AT01] smallint NULL,
        [NUMBER_AT02] smallint NULL,
        [NUMBER_AT03] smallint NULL,
        [NUMBER_AT04] smallint NULL,
        [NUMBER_AT05] smallint NULL,
        [NUMBER_AT06] smallint NULL,
        [NUMBER_AT07] smallint NULL,
        [NUMBER_AT08] smallint NULL,
        [NUMBER_AT09] smallint NULL,
        [NUMBER_AT10] smallint NULL,
        [NUMBER_AT11] smallint NULL,
        [NUMBER_AT12] smallint NULL,
        [NUMBER_AT13] smallint NULL,
        [NUMBER_AT14] smallint NULL,
        [NUMBER_AT15] smallint NULL,
        [NUMBER_AT16] smallint NULL,
        [NUMBER_AT17] smallint NULL,
        [NUMBER_AT18] smallint NULL,
        [NUMBER_AT19] smallint NULL,
        [NUMBER_AT20] smallint NULL,
        [NUMBER_AT21] smallint NULL,
        [NUMBER_AT22] smallint NULL,
        [NUMBER_AT23] smallint NULL,
        [NUMBER_AT24] smallint NULL,
        [NUMBER_AT25] smallint NULL,
        [NUMBER_AT26] smallint NULL,
        [NUMBER_AT27] smallint NULL,
        [NUMBER_AT28] smallint NULL,
        [NUMBER_AT29] smallint NULL,
        [NUMBER_AT30] smallint NULL,
        [NUMBER_AT31] smallint NULL,
        [NUMBER_AT32] smallint NULL,
        [NUMBER_AT33] smallint NULL,
        [NUMBER_AT34] smallint NULL,
        [NO_NA] smallint NULL,
        [NO_NT] smallint NULL,
        [NO_DNP] smallint NULL,
        [TOTAL_NUMBER] smallint NULL,
        [SENT_TO_DEET] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SVAG_Index_SVAGKEY] PRIMARY KEY CLUSTERED (
            [SVAGKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SVAG_Index_COHORT] ON [dbo].[SVAG]
    (
            [COHORT] ASC
    );
    CREATE NONCLUSTERED INDEX [SVAG_Index_VDIMENSION] ON [dbo].[SVAG]
    (
            [VDIMENSION] ASC
    );
    CREATE NONCLUSTERED INDEX [SVAG_Index_VDOMAIN] ON [dbo].[SVAG]
    (
            [VDOMAIN] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SVAG]') AND name = N'Index_COHORT')
    ALTER INDEX [Index_COHORT] ON [dbo].[SVAG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SVAG]') AND name = N'Index_VDIMENSION')
    ALTER INDEX [Index_VDIMENSION] ON [dbo].[SVAG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SVAG]') AND name = N'Index_VDOMAIN')
    ALTER INDEX [Index_VDOMAIN] ON [dbo].[SVAG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SVAG]') AND name = N'Index_COHORT')
    ALTER INDEX [Index_COHORT] ON [dbo].[SVAG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SVAG]') AND name = N'Index_VDIMENSION')
    ALTER INDEX [Index_VDIMENSION] ON [dbo].[SVAG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SVAG]') AND name = N'Index_VDOMAIN')
    ALTER INDEX [Index_VDOMAIN] ON [dbo].[SVAG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SVAG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SVAG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SVAG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SVAGKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SVAGKEY.Add(entity.SVAGKEY);
            }

            builder.AppendLine("DELETE [dbo].[SVAG] WHERE");


            // Index_SVAGKEY
            builder.Append("[SVAGKEY] IN (");
            for (int index = 0; index < Index_SVAGKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SVAGKEY
                var parameterSVAGKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSVAGKEY);
                command.Parameters.Add(parameterSVAGKEY, SqlDbType.Int).Value = Index_SVAGKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SVAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SVAG data set</returns>
        public override EduHubDataSetDataReader<SVAG> GetDataSetDataReader()
        {
            return new SVAGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SVAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SVAG data set</returns>
        public override EduHubDataSetDataReader<SVAG> GetDataSetDataReader(List<SVAG> Entities)
        {
            return new SVAGDataReader(new EduHubDataSetLoadedReader<SVAG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SVAGDataReader : EduHubDataSetDataReader<SVAG>
        {
            public SVAGDataReader(IEduHubDataSetReader<SVAG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 49; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SVAGKEY
                        return Current.SVAGKEY;
                    case 1: // COHORT
                        return Current.COHORT;
                    case 2: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 3: // CAMPUS
                        return Current.CAMPUS;
                    case 4: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER;
                    case 5: // VDIMENSION
                        return Current.VDIMENSION;
                    case 6: // VDOMAIN
                        return Current.VDOMAIN;
                    case 7: // NUMBER_AT01
                        return Current.NUMBER_AT01;
                    case 8: // NUMBER_AT02
                        return Current.NUMBER_AT02;
                    case 9: // NUMBER_AT03
                        return Current.NUMBER_AT03;
                    case 10: // NUMBER_AT04
                        return Current.NUMBER_AT04;
                    case 11: // NUMBER_AT05
                        return Current.NUMBER_AT05;
                    case 12: // NUMBER_AT06
                        return Current.NUMBER_AT06;
                    case 13: // NUMBER_AT07
                        return Current.NUMBER_AT07;
                    case 14: // NUMBER_AT08
                        return Current.NUMBER_AT08;
                    case 15: // NUMBER_AT09
                        return Current.NUMBER_AT09;
                    case 16: // NUMBER_AT10
                        return Current.NUMBER_AT10;
                    case 17: // NUMBER_AT11
                        return Current.NUMBER_AT11;
                    case 18: // NUMBER_AT12
                        return Current.NUMBER_AT12;
                    case 19: // NUMBER_AT13
                        return Current.NUMBER_AT13;
                    case 20: // NUMBER_AT14
                        return Current.NUMBER_AT14;
                    case 21: // NUMBER_AT15
                        return Current.NUMBER_AT15;
                    case 22: // NUMBER_AT16
                        return Current.NUMBER_AT16;
                    case 23: // NUMBER_AT17
                        return Current.NUMBER_AT17;
                    case 24: // NUMBER_AT18
                        return Current.NUMBER_AT18;
                    case 25: // NUMBER_AT19
                        return Current.NUMBER_AT19;
                    case 26: // NUMBER_AT20
                        return Current.NUMBER_AT20;
                    case 27: // NUMBER_AT21
                        return Current.NUMBER_AT21;
                    case 28: // NUMBER_AT22
                        return Current.NUMBER_AT22;
                    case 29: // NUMBER_AT23
                        return Current.NUMBER_AT23;
                    case 30: // NUMBER_AT24
                        return Current.NUMBER_AT24;
                    case 31: // NUMBER_AT25
                        return Current.NUMBER_AT25;
                    case 32: // NUMBER_AT26
                        return Current.NUMBER_AT26;
                    case 33: // NUMBER_AT27
                        return Current.NUMBER_AT27;
                    case 34: // NUMBER_AT28
                        return Current.NUMBER_AT28;
                    case 35: // NUMBER_AT29
                        return Current.NUMBER_AT29;
                    case 36: // NUMBER_AT30
                        return Current.NUMBER_AT30;
                    case 37: // NUMBER_AT31
                        return Current.NUMBER_AT31;
                    case 38: // NUMBER_AT32
                        return Current.NUMBER_AT32;
                    case 39: // NUMBER_AT33
                        return Current.NUMBER_AT33;
                    case 40: // NUMBER_AT34
                        return Current.NUMBER_AT34;
                    case 41: // NO_NA
                        return Current.NO_NA;
                    case 42: // NO_NT
                        return Current.NO_NT;
                    case 43: // NO_DNP
                        return Current.NO_DNP;
                    case 44: // TOTAL_NUMBER
                        return Current.TOTAL_NUMBER;
                    case 45: // SENT_TO_DEET
                        return Current.SENT_TO_DEET;
                    case 46: // LW_DATE
                        return Current.LW_DATE;
                    case 47: // LW_TIME
                        return Current.LW_TIME;
                    case 48: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // COHORT
                        return Current.COHORT == null;
                    case 2: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 3: // CAMPUS
                        return Current.CAMPUS == null;
                    case 4: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER == null;
                    case 5: // VDIMENSION
                        return Current.VDIMENSION == null;
                    case 6: // VDOMAIN
                        return Current.VDOMAIN == null;
                    case 7: // NUMBER_AT01
                        return Current.NUMBER_AT01 == null;
                    case 8: // NUMBER_AT02
                        return Current.NUMBER_AT02 == null;
                    case 9: // NUMBER_AT03
                        return Current.NUMBER_AT03 == null;
                    case 10: // NUMBER_AT04
                        return Current.NUMBER_AT04 == null;
                    case 11: // NUMBER_AT05
                        return Current.NUMBER_AT05 == null;
                    case 12: // NUMBER_AT06
                        return Current.NUMBER_AT06 == null;
                    case 13: // NUMBER_AT07
                        return Current.NUMBER_AT07 == null;
                    case 14: // NUMBER_AT08
                        return Current.NUMBER_AT08 == null;
                    case 15: // NUMBER_AT09
                        return Current.NUMBER_AT09 == null;
                    case 16: // NUMBER_AT10
                        return Current.NUMBER_AT10 == null;
                    case 17: // NUMBER_AT11
                        return Current.NUMBER_AT11 == null;
                    case 18: // NUMBER_AT12
                        return Current.NUMBER_AT12 == null;
                    case 19: // NUMBER_AT13
                        return Current.NUMBER_AT13 == null;
                    case 20: // NUMBER_AT14
                        return Current.NUMBER_AT14 == null;
                    case 21: // NUMBER_AT15
                        return Current.NUMBER_AT15 == null;
                    case 22: // NUMBER_AT16
                        return Current.NUMBER_AT16 == null;
                    case 23: // NUMBER_AT17
                        return Current.NUMBER_AT17 == null;
                    case 24: // NUMBER_AT18
                        return Current.NUMBER_AT18 == null;
                    case 25: // NUMBER_AT19
                        return Current.NUMBER_AT19 == null;
                    case 26: // NUMBER_AT20
                        return Current.NUMBER_AT20 == null;
                    case 27: // NUMBER_AT21
                        return Current.NUMBER_AT21 == null;
                    case 28: // NUMBER_AT22
                        return Current.NUMBER_AT22 == null;
                    case 29: // NUMBER_AT23
                        return Current.NUMBER_AT23 == null;
                    case 30: // NUMBER_AT24
                        return Current.NUMBER_AT24 == null;
                    case 31: // NUMBER_AT25
                        return Current.NUMBER_AT25 == null;
                    case 32: // NUMBER_AT26
                        return Current.NUMBER_AT26 == null;
                    case 33: // NUMBER_AT27
                        return Current.NUMBER_AT27 == null;
                    case 34: // NUMBER_AT28
                        return Current.NUMBER_AT28 == null;
                    case 35: // NUMBER_AT29
                        return Current.NUMBER_AT29 == null;
                    case 36: // NUMBER_AT30
                        return Current.NUMBER_AT30 == null;
                    case 37: // NUMBER_AT31
                        return Current.NUMBER_AT31 == null;
                    case 38: // NUMBER_AT32
                        return Current.NUMBER_AT32 == null;
                    case 39: // NUMBER_AT33
                        return Current.NUMBER_AT33 == null;
                    case 40: // NUMBER_AT34
                        return Current.NUMBER_AT34 == null;
                    case 41: // NO_NA
                        return Current.NO_NA == null;
                    case 42: // NO_NT
                        return Current.NO_NT == null;
                    case 43: // NO_DNP
                        return Current.NO_DNP == null;
                    case 44: // TOTAL_NUMBER
                        return Current.TOTAL_NUMBER == null;
                    case 45: // SENT_TO_DEET
                        return Current.SENT_TO_DEET == null;
                    case 46: // LW_DATE
                        return Current.LW_DATE == null;
                    case 47: // LW_TIME
                        return Current.LW_TIME == null;
                    case 48: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SVAGKEY
                        return "SVAGKEY";
                    case 1: // COHORT
                        return "COHORT";
                    case 2: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 3: // CAMPUS
                        return "CAMPUS";
                    case 4: // YEAR_SEMESTER
                        return "YEAR_SEMESTER";
                    case 5: // VDIMENSION
                        return "VDIMENSION";
                    case 6: // VDOMAIN
                        return "VDOMAIN";
                    case 7: // NUMBER_AT01
                        return "NUMBER_AT01";
                    case 8: // NUMBER_AT02
                        return "NUMBER_AT02";
                    case 9: // NUMBER_AT03
                        return "NUMBER_AT03";
                    case 10: // NUMBER_AT04
                        return "NUMBER_AT04";
                    case 11: // NUMBER_AT05
                        return "NUMBER_AT05";
                    case 12: // NUMBER_AT06
                        return "NUMBER_AT06";
                    case 13: // NUMBER_AT07
                        return "NUMBER_AT07";
                    case 14: // NUMBER_AT08
                        return "NUMBER_AT08";
                    case 15: // NUMBER_AT09
                        return "NUMBER_AT09";
                    case 16: // NUMBER_AT10
                        return "NUMBER_AT10";
                    case 17: // NUMBER_AT11
                        return "NUMBER_AT11";
                    case 18: // NUMBER_AT12
                        return "NUMBER_AT12";
                    case 19: // NUMBER_AT13
                        return "NUMBER_AT13";
                    case 20: // NUMBER_AT14
                        return "NUMBER_AT14";
                    case 21: // NUMBER_AT15
                        return "NUMBER_AT15";
                    case 22: // NUMBER_AT16
                        return "NUMBER_AT16";
                    case 23: // NUMBER_AT17
                        return "NUMBER_AT17";
                    case 24: // NUMBER_AT18
                        return "NUMBER_AT18";
                    case 25: // NUMBER_AT19
                        return "NUMBER_AT19";
                    case 26: // NUMBER_AT20
                        return "NUMBER_AT20";
                    case 27: // NUMBER_AT21
                        return "NUMBER_AT21";
                    case 28: // NUMBER_AT22
                        return "NUMBER_AT22";
                    case 29: // NUMBER_AT23
                        return "NUMBER_AT23";
                    case 30: // NUMBER_AT24
                        return "NUMBER_AT24";
                    case 31: // NUMBER_AT25
                        return "NUMBER_AT25";
                    case 32: // NUMBER_AT26
                        return "NUMBER_AT26";
                    case 33: // NUMBER_AT27
                        return "NUMBER_AT27";
                    case 34: // NUMBER_AT28
                        return "NUMBER_AT28";
                    case 35: // NUMBER_AT29
                        return "NUMBER_AT29";
                    case 36: // NUMBER_AT30
                        return "NUMBER_AT30";
                    case 37: // NUMBER_AT31
                        return "NUMBER_AT31";
                    case 38: // NUMBER_AT32
                        return "NUMBER_AT32";
                    case 39: // NUMBER_AT33
                        return "NUMBER_AT33";
                    case 40: // NUMBER_AT34
                        return "NUMBER_AT34";
                    case 41: // NO_NA
                        return "NO_NA";
                    case 42: // NO_NT
                        return "NO_NT";
                    case 43: // NO_DNP
                        return "NO_DNP";
                    case 44: // TOTAL_NUMBER
                        return "TOTAL_NUMBER";
                    case 45: // SENT_TO_DEET
                        return "SENT_TO_DEET";
                    case 46: // LW_DATE
                        return "LW_DATE";
                    case 47: // LW_TIME
                        return "LW_TIME";
                    case 48: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SVAGKEY":
                        return 0;
                    case "COHORT":
                        return 1;
                    case "SCHOOL_YEAR":
                        return 2;
                    case "CAMPUS":
                        return 3;
                    case "YEAR_SEMESTER":
                        return 4;
                    case "VDIMENSION":
                        return 5;
                    case "VDOMAIN":
                        return 6;
                    case "NUMBER_AT01":
                        return 7;
                    case "NUMBER_AT02":
                        return 8;
                    case "NUMBER_AT03":
                        return 9;
                    case "NUMBER_AT04":
                        return 10;
                    case "NUMBER_AT05":
                        return 11;
                    case "NUMBER_AT06":
                        return 12;
                    case "NUMBER_AT07":
                        return 13;
                    case "NUMBER_AT08":
                        return 14;
                    case "NUMBER_AT09":
                        return 15;
                    case "NUMBER_AT10":
                        return 16;
                    case "NUMBER_AT11":
                        return 17;
                    case "NUMBER_AT12":
                        return 18;
                    case "NUMBER_AT13":
                        return 19;
                    case "NUMBER_AT14":
                        return 20;
                    case "NUMBER_AT15":
                        return 21;
                    case "NUMBER_AT16":
                        return 22;
                    case "NUMBER_AT17":
                        return 23;
                    case "NUMBER_AT18":
                        return 24;
                    case "NUMBER_AT19":
                        return 25;
                    case "NUMBER_AT20":
                        return 26;
                    case "NUMBER_AT21":
                        return 27;
                    case "NUMBER_AT22":
                        return 28;
                    case "NUMBER_AT23":
                        return 29;
                    case "NUMBER_AT24":
                        return 30;
                    case "NUMBER_AT25":
                        return 31;
                    case "NUMBER_AT26":
                        return 32;
                    case "NUMBER_AT27":
                        return 33;
                    case "NUMBER_AT28":
                        return 34;
                    case "NUMBER_AT29":
                        return 35;
                    case "NUMBER_AT30":
                        return 36;
                    case "NUMBER_AT31":
                        return 37;
                    case "NUMBER_AT32":
                        return 38;
                    case "NUMBER_AT33":
                        return 39;
                    case "NUMBER_AT34":
                        return 40;
                    case "NO_NA":
                        return 41;
                    case "NO_NT":
                        return 42;
                    case "NO_DNP":
                        return 43;
                    case "TOTAL_NUMBER":
                        return 44;
                    case "SENT_TO_DEET":
                        return 45;
                    case "LW_DATE":
                        return 46;
                    case "LW_TIME":
                        return 47;
                    case "LW_USER":
                        return 48;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
