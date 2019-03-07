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
    /// Accidents Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADDataSet : EduHubDataSet<SAD>
    {
        /// <inheritdoc />
        public override string Name { get { return "SAD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SADDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AREA_DUTY_TEACHER = new Lazy<NullDictionary<string, IReadOnlyList<SAD>>>(() => this.ToGroupedNullDictionary(i => i.AREA_DUTY_TEACHER));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SAD>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_ROOM = new Lazy<NullDictionary<string, IReadOnlyList<SAD>>>(() => this.ToGroupedNullDictionary(i => i.ROOM));
            Index_SADKEY = new Lazy<Dictionary<int, SAD>>(() => this.ToDictionary(i => i.SADKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAD" /> fields for each CSV column header</returns>
        internal override Action<SAD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SADKEY":
                        mapper[i] = (e, v) => e.SADKEY = int.Parse(v);
                        break;
                    case "DETAIL_OUTLINE":
                        mapper[i] = (e, v) => e.DETAIL_OUTLINE = v;
                        break;
                    case "ACCIDENT_DATE":
                        mapper[i] = (e, v) => e.ACCIDENT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ACCIDENT_TIME":
                        mapper[i] = (e, v) => e.ACCIDENT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GENERAL_ACTIVITY":
                        mapper[i] = (e, v) => e.GENERAL_ACTIVITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DETAILED_ACTIVITY":
                        mapper[i] = (e, v) => e.DETAILED_ACTIVITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_ACTIVITY_INFO":
                        mapper[i] = (e, v) => e.OTHER_ACTIVITY_INFO = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_DESC_INFO":
                        mapper[i] = (e, v) => e.OTHER_DESC_INFO = v;
                        break;
                    case "ACCIDENT_SITE":
                        mapper[i] = (e, v) => e.ACCIDENT_SITE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXTERNAL_ADDRESS":
                        mapper[i] = (e, v) => e.EXTERNAL_ADDRESS = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "AREA_DUTY_TEACHER":
                        mapper[i] = (e, v) => e.AREA_DUTY_TEACHER = v;
                        break;
                    case "DUTY_TEACHER_FULL_NAME":
                        mapper[i] = (e, v) => e.DUTY_TEACHER_FULL_NAME = v;
                        break;
                    case "TEACHERS_ON_DUTY":
                        mapper[i] = (e, v) => e.TEACHERS_ON_DUTY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "MAILED":
                        mapper[i] = (e, v) => e.MAILED = v;
                        break;
                    case "FIRST_INJURED_PARTY":
                        mapper[i] = (e, v) => e.FIRST_INJURED_PARTY = v;
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
        /// Merges <see cref="SAD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SAD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SAD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SAD}"/> of entities</returns>
        internal override IEnumerable<SAD> ApplyDeltaEntities(IEnumerable<SAD> Entities, List<SAD> DeltaEntities)
        {
            HashSet<int> Index_SADKEY = new HashSet<int>(DeltaEntities.Select(i => i.SADKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SADKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SADKEY.Remove(entity.SADKEY);
                            
                            if (entity.SADKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SAD>>> Index_AREA_DUTY_TEACHER;
        private Lazy<NullDictionary<int?, IReadOnlyList<SAD>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SAD>>> Index_ROOM;
        private Lazy<Dictionary<int, SAD>> Index_SADKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAD by AREA_DUTY_TEACHER field
        /// </summary>
        /// <param name="AREA_DUTY_TEACHER">AREA_DUTY_TEACHER value used to find SAD</param>
        /// <returns>List of related SAD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> FindByAREA_DUTY_TEACHER(string AREA_DUTY_TEACHER)
        {
            return Index_AREA_DUTY_TEACHER.Value[AREA_DUTY_TEACHER];
        }

        /// <summary>
        /// Attempt to find SAD by AREA_DUTY_TEACHER field
        /// </summary>
        /// <param name="AREA_DUTY_TEACHER">AREA_DUTY_TEACHER value used to find SAD</param>
        /// <param name="Value">List of related SAD entities</param>
        /// <returns>True if the list of related SAD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAREA_DUTY_TEACHER(string AREA_DUTY_TEACHER, out IReadOnlyList<SAD> Value)
        {
            return Index_AREA_DUTY_TEACHER.Value.TryGetValue(AREA_DUTY_TEACHER, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by AREA_DUTY_TEACHER field
        /// </summary>
        /// <param name="AREA_DUTY_TEACHER">AREA_DUTY_TEACHER value used to find SAD</param>
        /// <returns>List of related SAD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> TryFindByAREA_DUTY_TEACHER(string AREA_DUTY_TEACHER)
        {
            IReadOnlyList<SAD> value;
            if (Index_AREA_DUTY_TEACHER.Value.TryGetValue(AREA_DUTY_TEACHER, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAD by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SAD</param>
        /// <returns>List of related SAD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SAD by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SAD</param>
        /// <param name="Value">List of related SAD entities</param>
        /// <returns>True if the list of related SAD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SAD> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SAD</param>
        /// <returns>List of related SAD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SAD> value;
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
        /// Find SAD by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SAD</param>
        /// <returns>List of related SAD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SAD by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SAD</param>
        /// <param name="Value">List of related SAD entities</param>
        /// <returns>True if the list of related SAD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out IReadOnlyList<SAD> Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SAD</param>
        /// <returns>List of related SAD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAD> TryFindByROOM(string ROOM)
        {
            IReadOnlyList<SAD> value;
            if (Index_ROOM.Value.TryGetValue(ROOM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAD by SADKEY field
        /// </summary>
        /// <param name="SADKEY">SADKEY value used to find SAD</param>
        /// <returns>Related SAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAD FindBySADKEY(int SADKEY)
        {
            return Index_SADKEY.Value[SADKEY];
        }

        /// <summary>
        /// Attempt to find SAD by SADKEY field
        /// </summary>
        /// <param name="SADKEY">SADKEY value used to find SAD</param>
        /// <param name="Value">Related SAD entity</param>
        /// <returns>True if the related SAD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySADKEY(int SADKEY, out SAD Value)
        {
            return Index_SADKEY.Value.TryGetValue(SADKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAD by SADKEY field
        /// </summary>
        /// <param name="SADKEY">SADKEY value used to find SAD</param>
        /// <returns>Related SAD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAD TryFindBySADKEY(int SADKEY)
        {
            SAD value;
            if (Index_SADKEY.Value.TryGetValue(SADKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SAD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAD](
        [SADKEY] int IDENTITY NOT NULL,
        [DETAIL_OUTLINE] varchar(MAX) NULL,
        [ACCIDENT_DATE] datetime NULL,
        [ACCIDENT_TIME] smallint NULL,
        [GENERAL_ACTIVITY] smallint NULL,
        [DETAILED_ACTIVITY] smallint NULL,
        [OTHER_ACTIVITY_INFO] varchar(MAX) NULL,
        [DESCRIPTION] smallint NULL,
        [OTHER_DESC_INFO] varchar(MAX) NULL,
        [ACCIDENT_SITE] smallint NULL,
        [CAMPUS] int NULL,
        [EXTERNAL_ADDRESS] varchar(MAX) NULL,
        [ROOM] varchar(4) NULL,
        [AREA_DUTY_TEACHER] varchar(4) NULL,
        [DUTY_TEACHER_FULL_NAME] varchar(64) NULL,
        [TEACHERS_ON_DUTY] smallint NULL,
        [CREATION_DATE] datetime NULL,
        [MAILED] varchar(1) NULL,
        [FIRST_INJURED_PARTY] varchar(64) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAD_Index_SADKEY] PRIMARY KEY CLUSTERED (
            [SADKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SAD_Index_AREA_DUTY_TEACHER] ON [dbo].[SAD]
    (
            [AREA_DUTY_TEACHER] ASC
    );
    CREATE NONCLUSTERED INDEX [SAD_Index_CAMPUS] ON [dbo].[SAD]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SAD_Index_ROOM] ON [dbo].[SAD]
    (
            [ROOM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAD]') AND name = N'Index_AREA_DUTY_TEACHER')
    ALTER INDEX [Index_AREA_DUTY_TEACHER] ON [dbo].[SAD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAD]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SAD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAD]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[SAD] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAD]') AND name = N'Index_AREA_DUTY_TEACHER')
    ALTER INDEX [Index_AREA_DUTY_TEACHER] ON [dbo].[SAD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAD]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SAD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAD]') AND name = N'Index_ROOM')
    ALTER INDEX [Index_ROOM] ON [dbo].[SAD] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SAD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SAD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SAD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SADKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SADKEY.Add(entity.SADKEY);
            }

            builder.AppendLine("DELETE [dbo].[SAD] WHERE");


            // Index_SADKEY
            builder.Append("[SADKEY] IN (");
            for (int index = 0; index < Index_SADKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SADKEY
                var parameterSADKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSADKEY);
                command.Parameters.Add(parameterSADKEY, SqlDbType.Int).Value = Index_SADKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAD data set</returns>
        public override EduHubDataSetDataReader<SAD> GetDataSetDataReader()
        {
            return new SADDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAD data set</returns>
        public override EduHubDataSetDataReader<SAD> GetDataSetDataReader(List<SAD> Entities)
        {
            return new SADDataReader(new EduHubDataSetLoadedReader<SAD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SADDataReader : EduHubDataSetDataReader<SAD>
        {
            public SADDataReader(IEduHubDataSetReader<SAD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 22; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SADKEY
                        return Current.SADKEY;
                    case 1: // DETAIL_OUTLINE
                        return Current.DETAIL_OUTLINE;
                    case 2: // ACCIDENT_DATE
                        return Current.ACCIDENT_DATE;
                    case 3: // ACCIDENT_TIME
                        return Current.ACCIDENT_TIME;
                    case 4: // GENERAL_ACTIVITY
                        return Current.GENERAL_ACTIVITY;
                    case 5: // DETAILED_ACTIVITY
                        return Current.DETAILED_ACTIVITY;
                    case 6: // OTHER_ACTIVITY_INFO
                        return Current.OTHER_ACTIVITY_INFO;
                    case 7: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 8: // OTHER_DESC_INFO
                        return Current.OTHER_DESC_INFO;
                    case 9: // ACCIDENT_SITE
                        return Current.ACCIDENT_SITE;
                    case 10: // CAMPUS
                        return Current.CAMPUS;
                    case 11: // EXTERNAL_ADDRESS
                        return Current.EXTERNAL_ADDRESS;
                    case 12: // ROOM
                        return Current.ROOM;
                    case 13: // AREA_DUTY_TEACHER
                        return Current.AREA_DUTY_TEACHER;
                    case 14: // DUTY_TEACHER_FULL_NAME
                        return Current.DUTY_TEACHER_FULL_NAME;
                    case 15: // TEACHERS_ON_DUTY
                        return Current.TEACHERS_ON_DUTY;
                    case 16: // CREATION_DATE
                        return Current.CREATION_DATE;
                    case 17: // MAILED
                        return Current.MAILED;
                    case 18: // FIRST_INJURED_PARTY
                        return Current.FIRST_INJURED_PARTY;
                    case 19: // LW_DATE
                        return Current.LW_DATE;
                    case 20: // LW_TIME
                        return Current.LW_TIME;
                    case 21: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DETAIL_OUTLINE
                        return Current.DETAIL_OUTLINE == null;
                    case 2: // ACCIDENT_DATE
                        return Current.ACCIDENT_DATE == null;
                    case 3: // ACCIDENT_TIME
                        return Current.ACCIDENT_TIME == null;
                    case 4: // GENERAL_ACTIVITY
                        return Current.GENERAL_ACTIVITY == null;
                    case 5: // DETAILED_ACTIVITY
                        return Current.DETAILED_ACTIVITY == null;
                    case 6: // OTHER_ACTIVITY_INFO
                        return Current.OTHER_ACTIVITY_INFO == null;
                    case 7: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 8: // OTHER_DESC_INFO
                        return Current.OTHER_DESC_INFO == null;
                    case 9: // ACCIDENT_SITE
                        return Current.ACCIDENT_SITE == null;
                    case 10: // CAMPUS
                        return Current.CAMPUS == null;
                    case 11: // EXTERNAL_ADDRESS
                        return Current.EXTERNAL_ADDRESS == null;
                    case 12: // ROOM
                        return Current.ROOM == null;
                    case 13: // AREA_DUTY_TEACHER
                        return Current.AREA_DUTY_TEACHER == null;
                    case 14: // DUTY_TEACHER_FULL_NAME
                        return Current.DUTY_TEACHER_FULL_NAME == null;
                    case 15: // TEACHERS_ON_DUTY
                        return Current.TEACHERS_ON_DUTY == null;
                    case 16: // CREATION_DATE
                        return Current.CREATION_DATE == null;
                    case 17: // MAILED
                        return Current.MAILED == null;
                    case 18: // FIRST_INJURED_PARTY
                        return Current.FIRST_INJURED_PARTY == null;
                    case 19: // LW_DATE
                        return Current.LW_DATE == null;
                    case 20: // LW_TIME
                        return Current.LW_TIME == null;
                    case 21: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SADKEY
                        return "SADKEY";
                    case 1: // DETAIL_OUTLINE
                        return "DETAIL_OUTLINE";
                    case 2: // ACCIDENT_DATE
                        return "ACCIDENT_DATE";
                    case 3: // ACCIDENT_TIME
                        return "ACCIDENT_TIME";
                    case 4: // GENERAL_ACTIVITY
                        return "GENERAL_ACTIVITY";
                    case 5: // DETAILED_ACTIVITY
                        return "DETAILED_ACTIVITY";
                    case 6: // OTHER_ACTIVITY_INFO
                        return "OTHER_ACTIVITY_INFO";
                    case 7: // DESCRIPTION
                        return "DESCRIPTION";
                    case 8: // OTHER_DESC_INFO
                        return "OTHER_DESC_INFO";
                    case 9: // ACCIDENT_SITE
                        return "ACCIDENT_SITE";
                    case 10: // CAMPUS
                        return "CAMPUS";
                    case 11: // EXTERNAL_ADDRESS
                        return "EXTERNAL_ADDRESS";
                    case 12: // ROOM
                        return "ROOM";
                    case 13: // AREA_DUTY_TEACHER
                        return "AREA_DUTY_TEACHER";
                    case 14: // DUTY_TEACHER_FULL_NAME
                        return "DUTY_TEACHER_FULL_NAME";
                    case 15: // TEACHERS_ON_DUTY
                        return "TEACHERS_ON_DUTY";
                    case 16: // CREATION_DATE
                        return "CREATION_DATE";
                    case 17: // MAILED
                        return "MAILED";
                    case 18: // FIRST_INJURED_PARTY
                        return "FIRST_INJURED_PARTY";
                    case 19: // LW_DATE
                        return "LW_DATE";
                    case 20: // LW_TIME
                        return "LW_TIME";
                    case 21: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SADKEY":
                        return 0;
                    case "DETAIL_OUTLINE":
                        return 1;
                    case "ACCIDENT_DATE":
                        return 2;
                    case "ACCIDENT_TIME":
                        return 3;
                    case "GENERAL_ACTIVITY":
                        return 4;
                    case "DETAILED_ACTIVITY":
                        return 5;
                    case "OTHER_ACTIVITY_INFO":
                        return 6;
                    case "DESCRIPTION":
                        return 7;
                    case "OTHER_DESC_INFO":
                        return 8;
                    case "ACCIDENT_SITE":
                        return 9;
                    case "CAMPUS":
                        return 10;
                    case "EXTERNAL_ADDRESS":
                        return 11;
                    case "ROOM":
                        return 12;
                    case "AREA_DUTY_TEACHER":
                        return 13;
                    case "DUTY_TEACHER_FULL_NAME":
                        return 14;
                    case "TEACHERS_ON_DUTY":
                        return 15;
                    case "CREATION_DATE":
                        return 16;
                    case "MAILED":
                        return 17;
                    case "FIRST_INJURED_PARTY":
                        return 18;
                    case "LW_DATE":
                        return 19;
                    case "LW_TIME":
                        return 20;
                    case "LW_USER":
                        return 21;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
