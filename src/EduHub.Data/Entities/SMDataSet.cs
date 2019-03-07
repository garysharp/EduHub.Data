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
    /// Rooms Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMDataSet : EduHubDataSet<SM>
    {
        /// <inheritdoc />
        public override string Name { get { return "SM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_FACULTY = new Lazy<NullDictionary<string, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.FACULTY));
            Index_ROOM = new Lazy<Dictionary<string, SM>>(() => this.ToDictionary(i => i.ROOM));
            Index_STAFF_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SM>>>(() => this.ToGroupedNullDictionary(i => i.STAFF_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SM" /> fields for each CSV column header</returns>
        internal override Action<SM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SEATING":
                        mapper[i] = (e, v) => e.SEATING = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROOM_TYPE":
                        mapper[i] = (e, v) => e.ROOM_TYPE = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "AREA_CODE":
                        mapper[i] = (e, v) => e.AREA_CODE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STAFF_CODE":
                        mapper[i] = (e, v) => e.STAFF_CODE = v;
                        break;
                    case "COMMENTA":
                        mapper[i] = (e, v) => e.COMMENTA = v;
                        break;
                    case "BOARD":
                        mapper[i] = (e, v) => e.BOARD = v;
                        break;
                    case "BLACKOUT":
                        mapper[i] = (e, v) => e.BLACKOUT = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GROUP_INDICATOR":
                        mapper[i] = (e, v) => e.GROUP_INDICATOR = v;
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
        /// Merges <see cref="SM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SM}"/> of entities</returns>
        internal override IEnumerable<SM> ApplyDeltaEntities(IEnumerable<SM> Entities, List<SM> DeltaEntities)
        {
            HashSet<string> Index_ROOM = new HashSet<string>(DeltaEntities.Select(i => i.ROOM));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ROOM;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ROOM.Remove(entity.ROOM);
                            
                            if (entity.ROOM.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<SM>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SM>>> Index_FACULTY;
        private Lazy<Dictionary<string, SM>> Index_ROOM;
        private Lazy<NullDictionary<string, IReadOnlyList<SM>>> Index_STAFF_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SM> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SM by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SM> value;
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
        /// Find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindByFACULTY(string FACULTY)
        {
            return Index_FACULTY.Value[FACULTY];
        }

        /// <summary>
        /// Attempt to find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFACULTY(string FACULTY, out IReadOnlyList<SM> Value)
        {
            return Index_FACULTY.Value.TryGetValue(FACULTY, out Value);
        }

        /// <summary>
        /// Attempt to find SM by FACULTY field
        /// </summary>
        /// <param name="FACULTY">FACULTY value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindByFACULTY(string FACULTY)
        {
            IReadOnlyList<SM> value;
            if (Index_FACULTY.Value.TryGetValue(FACULTY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <returns>Related SM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SM FindByROOM(string ROOM)
        {
            return Index_ROOM.Value[ROOM];
        }

        /// <summary>
        /// Attempt to find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <param name="Value">Related SM entity</param>
        /// <returns>True if the related SM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROOM(string ROOM, out SM Value)
        {
            return Index_ROOM.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Attempt to find SM by ROOM field
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SM</param>
        /// <returns>Related SM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SM TryFindByROOM(string ROOM)
        {
            SM value;
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
        /// Find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <returns>List of related SM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> FindBySTAFF_CODE(string STAFF_CODE)
        {
            return Index_STAFF_CODE.Value[STAFF_CODE];
        }

        /// <summary>
        /// Attempt to find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <param name="Value">List of related SM entities</param>
        /// <returns>True if the list of related SM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF_CODE(string STAFF_CODE, out IReadOnlyList<SM> Value)
        {
            return Index_STAFF_CODE.Value.TryGetValue(STAFF_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SM by STAFF_CODE field
        /// </summary>
        /// <param name="STAFF_CODE">STAFF_CODE value used to find SM</param>
        /// <returns>List of related SM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SM> TryFindBySTAFF_CODE(string STAFF_CODE)
        {
            IReadOnlyList<SM> value;
            if (Index_STAFF_CODE.Value.TryGetValue(STAFF_CODE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SM](
        [ROOM] varchar(4) NOT NULL,
        [TITLE] varchar(30) NULL,
        [SEATING] smallint NULL,
        [DESCRIPTION] varchar(40) NULL,
        [ROOM_TYPE] varchar(1) NULL,
        [FACULTY] varchar(10) NULL,
        [AREA_CODE] varchar(4) NULL,
        [CAMPUS] int NULL,
        [STAFF_CODE] varchar(4) NULL,
        [COMMENTA] varchar(MAX) NULL,
        [BOARD] varchar(4) NULL,
        [BLACKOUT] varchar(1) NULL,
        [NORMAL_ALLOTMENT] smallint NULL,
        [GROUP_INDICATOR] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SM_Index_ROOM] PRIMARY KEY CLUSTERED (
            [ROOM] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SM_Index_CAMPUS] ON [dbo].[SM]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SM_Index_FACULTY] ON [dbo].[SM]
    (
            [FACULTY] ASC
    );
    CREATE NONCLUSTERED INDEX [SM_Index_STAFF_CODE] ON [dbo].[SM]
    (
            [STAFF_CODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SM]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SM]') AND name = N'Index_FACULTY')
    ALTER INDEX [Index_FACULTY] ON [dbo].[SM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SM]') AND name = N'Index_STAFF_CODE')
    ALTER INDEX [Index_STAFF_CODE] ON [dbo].[SM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SM]') AND name = N'Index_CAMPUS')
    ALTER INDEX [Index_CAMPUS] ON [dbo].[SM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SM]') AND name = N'Index_FACULTY')
    ALTER INDEX [Index_FACULTY] ON [dbo].[SM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SM]') AND name = N'Index_STAFF_CODE')
    ALTER INDEX [Index_STAFF_CODE] ON [dbo].[SM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_ROOM = new List<string>();

            foreach (var entity in Entities)
            {
                Index_ROOM.Add(entity.ROOM);
            }

            builder.AppendLine("DELETE [dbo].[SM] WHERE");


            // Index_ROOM
            builder.Append("[ROOM] IN (");
            for (int index = 0; index < Index_ROOM.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ROOM
                var parameterROOM = $"@p{parameterIndex++}";
                builder.Append(parameterROOM);
                command.Parameters.Add(parameterROOM, SqlDbType.VarChar, 4).Value = Index_ROOM[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SM data set</returns>
        public override EduHubDataSetDataReader<SM> GetDataSetDataReader()
        {
            return new SMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SM data set</returns>
        public override EduHubDataSetDataReader<SM> GetDataSetDataReader(List<SM> Entities)
        {
            return new SMDataReader(new EduHubDataSetLoadedReader<SM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMDataReader : EduHubDataSetDataReader<SM>
        {
            public SMDataReader(IEduHubDataSetReader<SM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 17; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ROOM
                        return Current.ROOM;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // SEATING
                        return Current.SEATING;
                    case 3: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 4: // ROOM_TYPE
                        return Current.ROOM_TYPE;
                    case 5: // FACULTY
                        return Current.FACULTY;
                    case 6: // AREA_CODE
                        return Current.AREA_CODE;
                    case 7: // CAMPUS
                        return Current.CAMPUS;
                    case 8: // STAFF_CODE
                        return Current.STAFF_CODE;
                    case 9: // COMMENTA
                        return Current.COMMENTA;
                    case 10: // BOARD
                        return Current.BOARD;
                    case 11: // BLACKOUT
                        return Current.BLACKOUT;
                    case 12: // NORMAL_ALLOTMENT
                        return Current.NORMAL_ALLOTMENT;
                    case 13: // GROUP_INDICATOR
                        return Current.GROUP_INDICATOR;
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
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // SEATING
                        return Current.SEATING == null;
                    case 3: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 4: // ROOM_TYPE
                        return Current.ROOM_TYPE == null;
                    case 5: // FACULTY
                        return Current.FACULTY == null;
                    case 6: // AREA_CODE
                        return Current.AREA_CODE == null;
                    case 7: // CAMPUS
                        return Current.CAMPUS == null;
                    case 8: // STAFF_CODE
                        return Current.STAFF_CODE == null;
                    case 9: // COMMENTA
                        return Current.COMMENTA == null;
                    case 10: // BOARD
                        return Current.BOARD == null;
                    case 11: // BLACKOUT
                        return Current.BLACKOUT == null;
                    case 12: // NORMAL_ALLOTMENT
                        return Current.NORMAL_ALLOTMENT == null;
                    case 13: // GROUP_INDICATOR
                        return Current.GROUP_INDICATOR == null;
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
                    case 0: // ROOM
                        return "ROOM";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // SEATING
                        return "SEATING";
                    case 3: // DESCRIPTION
                        return "DESCRIPTION";
                    case 4: // ROOM_TYPE
                        return "ROOM_TYPE";
                    case 5: // FACULTY
                        return "FACULTY";
                    case 6: // AREA_CODE
                        return "AREA_CODE";
                    case 7: // CAMPUS
                        return "CAMPUS";
                    case 8: // STAFF_CODE
                        return "STAFF_CODE";
                    case 9: // COMMENTA
                        return "COMMENTA";
                    case 10: // BOARD
                        return "BOARD";
                    case 11: // BLACKOUT
                        return "BLACKOUT";
                    case 12: // NORMAL_ALLOTMENT
                        return "NORMAL_ALLOTMENT";
                    case 13: // GROUP_INDICATOR
                        return "GROUP_INDICATOR";
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
                    case "ROOM":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "SEATING":
                        return 2;
                    case "DESCRIPTION":
                        return 3;
                    case "ROOM_TYPE":
                        return 4;
                    case "FACULTY":
                        return 5;
                    case "AREA_CODE":
                        return 6;
                    case "CAMPUS":
                        return 7;
                    case "STAFF_CODE":
                        return 8;
                    case "COMMENTA":
                        return 9;
                    case "BOARD":
                        return 10;
                    case "BLACKOUT":
                        return 11;
                    case "NORMAL_ALLOTMENT":
                        return 12;
                    case "GROUP_INDICATOR":
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
