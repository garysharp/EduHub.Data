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
    /// Student Data Transfer Table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class ST_TFRIODataSet : EduHubDataSet<ST_TFRIO>
    {
        /// <inheritdoc />
        public override string Name { get { return "ST_TFRIO"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal ST_TFRIODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEST_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<ST_TFRIO>>>(() => this.ToGroupedDictionary(i => i.DEST_SCHOOL));
            Index_ST_TRANS_ID = new Lazy<NullDictionary<string, ST_TFRIO>>(() => this.ToNullDictionary(i => i.ST_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, ST_TFRIO>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ST_TFRIO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ST_TFRIO" /> fields for each CSV column header</returns>
        internal override Action<ST_TFRIO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<ST_TFRIO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "STKEY_NEW":
                        mapper[i] = (e, v) => e.STKEY_NEW = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TFR_PERMISSION":
                        mapper[i] = (e, v) => e.TFR_PERMISSION = v;
                        break;
                    case "SOURCE_SCHOOL":
                        mapper[i] = (e, v) => e.SOURCE_SCHOOL = v;
                        break;
                    case "DEST_SCHOOL":
                        mapper[i] = (e, v) => e.DEST_SCHOOL = v;
                        break;
                    case "RECD_AT_DEST":
                        mapper[i] = (e, v) => e.RECD_AT_DEST = v;
                        break;
                    case "TFR_STATUS":
                        mapper[i] = (e, v) => e.TFR_STATUS = v;
                        break;
                    case "TFR_DATE":
                        mapper[i] = (e, v) => e.TFR_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TFR_COMMENT":
                        mapper[i] = (e, v) => e.TFR_COMMENT = v;
                        break;
                    case "YEAR_SEMESTER":
                        mapper[i] = (e, v) => e.YEAR_SEMESTER = v;
                        break;
                    case "TFR_TYPE":
                        mapper[i] = (e, v) => e.TFR_TYPE = v;
                        break;
                    case "STUDENT_LEAVING":
                        mapper[i] = (e, v) => e.STUDENT_LEAVING = v;
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
        /// Merges <see cref="ST_TFRIO" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="ST_TFRIO" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="ST_TFRIO" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{ST_TFRIO}"/> of entities</returns>
        internal override IEnumerable<ST_TFRIO> ApplyDeltaEntities(IEnumerable<ST_TFRIO> Entities, List<ST_TFRIO> DeltaEntities)
        {
            HashSet<string> Index_ST_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.ST_TRANS_ID));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.DEST_SCHOOL;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_ST_TRANS_ID.Remove(entity.ST_TRANS_ID);
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.DEST_SCHOOL.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<ST_TFRIO>>> Index_DEST_SCHOOL;
        private Lazy<NullDictionary<string, ST_TFRIO>> Index_ST_TRANS_ID;
        private Lazy<Dictionary<int, ST_TFRIO>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <returns>List of related ST_TFRIO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFRIO> FindByDEST_SCHOOL(string DEST_SCHOOL)
        {
            return Index_DEST_SCHOOL.Value[DEST_SCHOOL];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <param name="Value">List of related ST_TFRIO entities</param>
        /// <returns>True if the list of related ST_TFRIO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEST_SCHOOL(string DEST_SCHOOL, out IReadOnlyList<ST_TFRIO> Value)
        {
            return Index_DEST_SCHOOL.Value.TryGetValue(DEST_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by DEST_SCHOOL field
        /// </summary>
        /// <param name="DEST_SCHOOL">DEST_SCHOOL value used to find ST_TFRIO</param>
        /// <returns>List of related ST_TFRIO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<ST_TFRIO> TryFindByDEST_SCHOOL(string DEST_SCHOOL)
        {
            IReadOnlyList<ST_TFRIO> value;
            if (Index_DEST_SCHOOL.Value.TryGetValue(DEST_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO FindByST_TRANS_ID(string ST_TRANS_ID)
        {
            return Index_ST_TRANS_ID.Value[ST_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <param name="Value">Related ST_TFRIO entity</param>
        /// <returns>True if the related ST_TFRIO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByST_TRANS_ID(string ST_TRANS_ID, out ST_TFRIO Value)
        {
            return Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by ST_TRANS_ID field
        /// </summary>
        /// <param name="ST_TRANS_ID">ST_TRANS_ID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO TryFindByST_TRANS_ID(string ST_TRANS_ID)
        {
            ST_TFRIO value;
            if (Index_ST_TRANS_ID.Value.TryGetValue(ST_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <param name="Value">Related ST_TFRIO entity</param>
        /// <returns>True if the related ST_TFRIO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out ST_TFRIO Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find ST_TFRIO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find ST_TFRIO</param>
        /// <returns>Related ST_TFRIO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public ST_TFRIO TryFindByTID(int TID)
        {
            ST_TFRIO value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a ST_TFRIO table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ST_TFRIO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[ST_TFRIO](
        [TID] int IDENTITY NOT NULL,
        [ST_TRANS_ID] varchar(30) NULL,
        [STKEY] varchar(10) NULL,
        [STKEY_NEW] varchar(10) NULL,
        [REGISTRATION] smallint NULL,
        [TFR_PERMISSION] varchar(1) NULL,
        [SOURCE_SCHOOL] varchar(8) NULL,
        [DEST_SCHOOL] varchar(8) NOT NULL,
        [RECD_AT_DEST] varchar(1) NULL,
        [TFR_STATUS] varchar(10) NULL,
        [TFR_DATE] datetime NULL,
        [TFR_COMMENT] varchar(250) NULL,
        [YEAR_SEMESTER] varchar(6) NULL,
        [TFR_TYPE] varchar(2) NULL,
        [STUDENT_LEAVING] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [ST_TFRIO_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [ST_TFRIO_Index_DEST_SCHOOL] ON [dbo].[ST_TFRIO]
    (
            [DEST_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [ST_TFRIO_Index_ST_TRANS_ID] ON [dbo].[ST_TFRIO]
    (
            [ST_TRANS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFRIO]') AND name = N'ST_TFRIO_Index_ST_TRANS_ID')
    ALTER INDEX [ST_TFRIO_Index_ST_TRANS_ID] ON [dbo].[ST_TFRIO] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFRIO]') AND name = N'ST_TFRIO_Index_TID')
    ALTER INDEX [ST_TFRIO_Index_TID] ON [dbo].[ST_TFRIO] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFRIO]') AND name = N'ST_TFRIO_Index_ST_TRANS_ID')
    ALTER INDEX [ST_TFRIO_Index_ST_TRANS_ID] ON [dbo].[ST_TFRIO] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[ST_TFRIO]') AND name = N'ST_TFRIO_Index_TID')
    ALTER INDEX [ST_TFRIO_Index_TID] ON [dbo].[ST_TFRIO] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="ST_TFRIO"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="ST_TFRIO"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<ST_TFRIO> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_ST_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ST_TRANS_ID.Add(entity.ST_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[ST_TFRIO] WHERE");


            // Index_ST_TRANS_ID
            builder.Append("[ST_TRANS_ID] IN (");
            for (int index = 0; index < Index_ST_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ST_TRANS_ID
                var parameterST_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterST_TRANS_ID);
                command.Parameters.Add(parameterST_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_ST_TRANS_ID[index] ?? DBNull.Value;
            }
            builder.AppendLine(") OR");

            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the ST_TFRIO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ST_TFRIO data set</returns>
        public override EduHubDataSetDataReader<ST_TFRIO> GetDataSetDataReader()
        {
            return new ST_TFRIODataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the ST_TFRIO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the ST_TFRIO data set</returns>
        public override EduHubDataSetDataReader<ST_TFRIO> GetDataSetDataReader(List<ST_TFRIO> Entities)
        {
            return new ST_TFRIODataReader(new EduHubDataSetLoadedReader<ST_TFRIO>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class ST_TFRIODataReader : EduHubDataSetDataReader<ST_TFRIO>
        {
            public ST_TFRIODataReader(IEduHubDataSetReader<ST_TFRIO> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 18; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ST_TRANS_ID
                        return Current.ST_TRANS_ID;
                    case 2: // STKEY
                        return Current.STKEY;
                    case 3: // STKEY_NEW
                        return Current.STKEY_NEW;
                    case 4: // REGISTRATION
                        return Current.REGISTRATION;
                    case 5: // TFR_PERMISSION
                        return Current.TFR_PERMISSION;
                    case 6: // SOURCE_SCHOOL
                        return Current.SOURCE_SCHOOL;
                    case 7: // DEST_SCHOOL
                        return Current.DEST_SCHOOL;
                    case 8: // RECD_AT_DEST
                        return Current.RECD_AT_DEST;
                    case 9: // TFR_STATUS
                        return Current.TFR_STATUS;
                    case 10: // TFR_DATE
                        return Current.TFR_DATE;
                    case 11: // TFR_COMMENT
                        return Current.TFR_COMMENT;
                    case 12: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER;
                    case 13: // TFR_TYPE
                        return Current.TFR_TYPE;
                    case 14: // STUDENT_LEAVING
                        return Current.STUDENT_LEAVING;
                    case 15: // LW_DATE
                        return Current.LW_DATE;
                    case 16: // LW_TIME
                        return Current.LW_TIME;
                    case 17: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ST_TRANS_ID
                        return Current.ST_TRANS_ID == null;
                    case 2: // STKEY
                        return Current.STKEY == null;
                    case 3: // STKEY_NEW
                        return Current.STKEY_NEW == null;
                    case 4: // REGISTRATION
                        return Current.REGISTRATION == null;
                    case 5: // TFR_PERMISSION
                        return Current.TFR_PERMISSION == null;
                    case 6: // SOURCE_SCHOOL
                        return Current.SOURCE_SCHOOL == null;
                    case 8: // RECD_AT_DEST
                        return Current.RECD_AT_DEST == null;
                    case 9: // TFR_STATUS
                        return Current.TFR_STATUS == null;
                    case 10: // TFR_DATE
                        return Current.TFR_DATE == null;
                    case 11: // TFR_COMMENT
                        return Current.TFR_COMMENT == null;
                    case 12: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER == null;
                    case 13: // TFR_TYPE
                        return Current.TFR_TYPE == null;
                    case 14: // STUDENT_LEAVING
                        return Current.STUDENT_LEAVING == null;
                    case 15: // LW_DATE
                        return Current.LW_DATE == null;
                    case 16: // LW_TIME
                        return Current.LW_TIME == null;
                    case 17: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 2: // STKEY
                        return "STKEY";
                    case 3: // STKEY_NEW
                        return "STKEY_NEW";
                    case 4: // REGISTRATION
                        return "REGISTRATION";
                    case 5: // TFR_PERMISSION
                        return "TFR_PERMISSION";
                    case 6: // SOURCE_SCHOOL
                        return "SOURCE_SCHOOL";
                    case 7: // DEST_SCHOOL
                        return "DEST_SCHOOL";
                    case 8: // RECD_AT_DEST
                        return "RECD_AT_DEST";
                    case 9: // TFR_STATUS
                        return "TFR_STATUS";
                    case 10: // TFR_DATE
                        return "TFR_DATE";
                    case 11: // TFR_COMMENT
                        return "TFR_COMMENT";
                    case 12: // YEAR_SEMESTER
                        return "YEAR_SEMESTER";
                    case 13: // TFR_TYPE
                        return "TFR_TYPE";
                    case 14: // STUDENT_LEAVING
                        return "STUDENT_LEAVING";
                    case 15: // LW_DATE
                        return "LW_DATE";
                    case 16: // LW_TIME
                        return "LW_TIME";
                    case 17: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "ST_TRANS_ID":
                        return 1;
                    case "STKEY":
                        return 2;
                    case "STKEY_NEW":
                        return 3;
                    case "REGISTRATION":
                        return 4;
                    case "TFR_PERMISSION":
                        return 5;
                    case "SOURCE_SCHOOL":
                        return 6;
                    case "DEST_SCHOOL":
                        return 7;
                    case "RECD_AT_DEST":
                        return 8;
                    case "TFR_STATUS":
                        return 9;
                    case "TFR_DATE":
                        return 10;
                    case "TFR_COMMENT":
                        return 11;
                    case "YEAR_SEMESTER":
                        return 12;
                    case "TFR_TYPE":
                        return 13;
                    case "STUDENT_LEAVING":
                        return 14;
                    case "LW_DATE":
                        return 15;
                    case "LW_TIME":
                        return 16;
                    case "LW_USER":
                        return 17;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
