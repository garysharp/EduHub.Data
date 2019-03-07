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
    /// STVDO Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STVDO_TRDataSet : EduHubDataSet<STVDO_TR>
    {
        /// <inheritdoc />
        public override string Name { get { return "STVDO_TR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STVDO_TRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<STVDO_TR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_STVDO_TRANS_ID = new Lazy<NullDictionary<string, STVDO_TR>>(() => this.ToNullDictionary(i => i.STVDO_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, STVDO_TR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STVDO_TR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STVDO_TR" /> fields for each CSV column header</returns>
        internal override Action<STVDO_TR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STVDO_TR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "STVDO_TRANS_ID":
                        mapper[i] = (e, v) => e.STVDO_TRANS_ID = v;
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "SKEY_NEW":
                        mapper[i] = (e, v) => e.SKEY_NEW = v;
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
                    case "VDOMAIN":
                        mapper[i] = (e, v) => e.VDOMAIN = v;
                        break;
                    case "VDIMENSION":
                        mapper[i] = (e, v) => e.VDIMENSION = v;
                        break;
                    case "SCORE":
                        mapper[i] = (e, v) => e.SCORE = v;
                        break;
                    case "ORIGINAL_SCHOOL":
                        mapper[i] = (e, v) => e.ORIGINAL_SCHOOL = v;
                        break;
                    case "ST_TRANS_ID":
                        mapper[i] = (e, v) => e.ST_TRANS_ID = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="STVDO_TR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STVDO_TR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STVDO_TR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STVDO_TR}"/> of entities</returns>
        internal override IEnumerable<STVDO_TR> ApplyDeltaEntities(IEnumerable<STVDO_TR> Entities, List<STVDO_TR> DeltaEntities)
        {
            HashSet<string> Index_STVDO_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.STVDO_TRANS_ID));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ORIG_SCHOOL;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_STVDO_TRANS_ID.Remove(entity.STVDO_TRANS_ID);
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.ORIG_SCHOOL.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<STVDO_TR>>> Index_ORIG_SCHOOL;
        private Lazy<NullDictionary<string, STVDO_TR>> Index_STVDO_TRANS_ID;
        private Lazy<Dictionary<int, STVDO_TR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STVDO_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STVDO_TR</param>
        /// <returns>List of related STVDO_TR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO_TR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STVDO_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STVDO_TR</param>
        /// <param name="Value">List of related STVDO_TR entities</param>
        /// <returns>True if the list of related STVDO_TR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<STVDO_TR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STVDO_TR</param>
        /// <returns>List of related STVDO_TR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDO_TR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<STVDO_TR> value;
            if (Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO_TR by STVDO_TRANS_ID field
        /// </summary>
        /// <param name="STVDO_TRANS_ID">STVDO_TRANS_ID value used to find STVDO_TR</param>
        /// <returns>Related STVDO_TR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDO_TR FindBySTVDO_TRANS_ID(string STVDO_TRANS_ID)
        {
            return Index_STVDO_TRANS_ID.Value[STVDO_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find STVDO_TR by STVDO_TRANS_ID field
        /// </summary>
        /// <param name="STVDO_TRANS_ID">STVDO_TRANS_ID value used to find STVDO_TR</param>
        /// <param name="Value">Related STVDO_TR entity</param>
        /// <returns>True if the related STVDO_TR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTVDO_TRANS_ID(string STVDO_TRANS_ID, out STVDO_TR Value)
        {
            return Index_STVDO_TRANS_ID.Value.TryGetValue(STVDO_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO_TR by STVDO_TRANS_ID field
        /// </summary>
        /// <param name="STVDO_TRANS_ID">STVDO_TRANS_ID value used to find STVDO_TR</param>
        /// <returns>Related STVDO_TR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDO_TR TryFindBySTVDO_TRANS_ID(string STVDO_TRANS_ID)
        {
            STVDO_TR value;
            if (Index_STVDO_TRANS_ID.Value.TryGetValue(STVDO_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDO_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO_TR</param>
        /// <returns>Related STVDO_TR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDO_TR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STVDO_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO_TR</param>
        /// <param name="Value">Related STVDO_TR entity</param>
        /// <returns>True if the related STVDO_TR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STVDO_TR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STVDO_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDO_TR</param>
        /// <returns>Related STVDO_TR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDO_TR TryFindByTID(int TID)
        {
            STVDO_TR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STVDO_TR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STVDO_TR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STVDO_TR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [STVDO_TRANS_ID] varchar(30) NULL,
        [SKEY] varchar(10) NULL,
        [SKEY_NEW] varchar(10) NULL,
        [SCHOOL_YEAR] varchar(4) NULL,
        [CAMPUS] int NULL,
        [YEAR_SEMESTER] varchar(6) NULL,
        [VDOMAIN] varchar(10) NULL,
        [VDIMENSION] varchar(10) NULL,
        [SCORE] varchar(6) NULL,
        [ORIGINAL_SCHOOL] varchar(8) NULL,
        [ST_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STVDO_TR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [STVDO_TR_Index_ORIG_SCHOOL] ON [dbo].[STVDO_TR]
    (
            [ORIG_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDO_TR_Index_STVDO_TRANS_ID] ON [dbo].[STVDO_TR]
    (
            [STVDO_TRANS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO_TR]') AND name = N'Index_STVDO_TRANS_ID')
    ALTER INDEX [Index_STVDO_TRANS_ID] ON [dbo].[STVDO_TR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO_TR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STVDO_TR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO_TR]') AND name = N'Index_STVDO_TRANS_ID')
    ALTER INDEX [Index_STVDO_TRANS_ID] ON [dbo].[STVDO_TR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDO_TR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STVDO_TR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STVDO_TR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STVDO_TR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STVDO_TR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_STVDO_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_STVDO_TRANS_ID.Add(entity.STVDO_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STVDO_TR] WHERE");


            // Index_STVDO_TRANS_ID
            builder.Append("[STVDO_TRANS_ID] IN (");
            for (int index = 0; index < Index_STVDO_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // STVDO_TRANS_ID
                var parameterSTVDO_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSTVDO_TRANS_ID);
                command.Parameters.Add(parameterSTVDO_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_STVDO_TRANS_ID[index] ?? DBNull.Value;
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
        /// Provides a <see cref="IDataReader"/> for the STVDO_TR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDO_TR data set</returns>
        public override EduHubDataSetDataReader<STVDO_TR> GetDataSetDataReader()
        {
            return new STVDO_TRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STVDO_TR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDO_TR data set</returns>
        public override EduHubDataSetDataReader<STVDO_TR> GetDataSetDataReader(List<STVDO_TR> Entities)
        {
            return new STVDO_TRDataReader(new EduHubDataSetLoadedReader<STVDO_TR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STVDO_TRDataReader : EduHubDataSetDataReader<STVDO_TR>
        {
            public STVDO_TRDataReader(IEduHubDataSetReader<STVDO_TR> Reader)
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
                    case 1: // ORIG_SCHOOL
                        return Current.ORIG_SCHOOL;
                    case 2: // STVDO_TRANS_ID
                        return Current.STVDO_TRANS_ID;
                    case 3: // SKEY
                        return Current.SKEY;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW;
                    case 5: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 6: // CAMPUS
                        return Current.CAMPUS;
                    case 7: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER;
                    case 8: // VDOMAIN
                        return Current.VDOMAIN;
                    case 9: // VDIMENSION
                        return Current.VDIMENSION;
                    case 10: // SCORE
                        return Current.SCORE;
                    case 11: // ORIGINAL_SCHOOL
                        return Current.ORIGINAL_SCHOOL;
                    case 12: // ST_TRANS_ID
                        return Current.ST_TRANS_ID;
                    case 13: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 14: // IMP_DATE
                        return Current.IMP_DATE;
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
                    case 2: // STVDO_TRANS_ID
                        return Current.STVDO_TRANS_ID == null;
                    case 3: // SKEY
                        return Current.SKEY == null;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW == null;
                    case 5: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 6: // CAMPUS
                        return Current.CAMPUS == null;
                    case 7: // YEAR_SEMESTER
                        return Current.YEAR_SEMESTER == null;
                    case 8: // VDOMAIN
                        return Current.VDOMAIN == null;
                    case 9: // VDIMENSION
                        return Current.VDIMENSION == null;
                    case 10: // SCORE
                        return Current.SCORE == null;
                    case 11: // ORIGINAL_SCHOOL
                        return Current.ORIGINAL_SCHOOL == null;
                    case 12: // ST_TRANS_ID
                        return Current.ST_TRANS_ID == null;
                    case 13: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 14: // IMP_DATE
                        return Current.IMP_DATE == null;
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
                    case 1: // ORIG_SCHOOL
                        return "ORIG_SCHOOL";
                    case 2: // STVDO_TRANS_ID
                        return "STVDO_TRANS_ID";
                    case 3: // SKEY
                        return "SKEY";
                    case 4: // SKEY_NEW
                        return "SKEY_NEW";
                    case 5: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 6: // CAMPUS
                        return "CAMPUS";
                    case 7: // YEAR_SEMESTER
                        return "YEAR_SEMESTER";
                    case 8: // VDOMAIN
                        return "VDOMAIN";
                    case 9: // VDIMENSION
                        return "VDIMENSION";
                    case 10: // SCORE
                        return "SCORE";
                    case 11: // ORIGINAL_SCHOOL
                        return "ORIGINAL_SCHOOL";
                    case 12: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 13: // IMP_STATUS
                        return "IMP_STATUS";
                    case 14: // IMP_DATE
                        return "IMP_DATE";
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
                    case "ORIG_SCHOOL":
                        return 1;
                    case "STVDO_TRANS_ID":
                        return 2;
                    case "SKEY":
                        return 3;
                    case "SKEY_NEW":
                        return 4;
                    case "SCHOOL_YEAR":
                        return 5;
                    case "CAMPUS":
                        return 6;
                    case "YEAR_SEMESTER":
                        return 7;
                    case "VDOMAIN":
                        return 8;
                    case "VDIMENSION":
                        return 9;
                    case "SCORE":
                        return 10;
                    case "ORIGINAL_SCHOOL":
                        return 11;
                    case "ST_TRANS_ID":
                        return 12;
                    case "IMP_STATUS":
                        return 13;
                    case "IMP_DATE":
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
