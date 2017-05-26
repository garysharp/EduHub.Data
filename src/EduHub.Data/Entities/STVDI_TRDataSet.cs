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
    /// STVDI Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STVDI_TRDataSet : EduHubDataSet<STVDI_TR>
    {
        /// <inheritdoc />
        public override string Name { get { return "STVDI_TR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STVDI_TRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<STVDI_TR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_STVDI_TRANS_ID = new Lazy<NullDictionary<string, STVDI_TR>>(() => this.ToNullDictionary(i => i.STVDI_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, STVDI_TR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STVDI_TR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STVDI_TR" /> fields for each CSV column header</returns>
        internal override Action<STVDI_TR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STVDI_TR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "STVDI_TRANS_ID":
                        mapper[i] = (e, v) => e.STVDI_TRANS_ID = v;
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
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="STVDI_TR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STVDI_TR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STVDI_TR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STVDI_TR}"/> of entities</returns>
        internal override IEnumerable<STVDI_TR> ApplyDeltaEntities(IEnumerable<STVDI_TR> Entities, List<STVDI_TR> DeltaEntities)
        {
            HashSet<string> Index_STVDI_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.STVDI_TRANS_ID));
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
                            overwritten = overwritten || Index_STVDI_TRANS_ID.Remove(entity.STVDI_TRANS_ID);
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

        private Lazy<Dictionary<string, IReadOnlyList<STVDI_TR>>> Index_ORIG_SCHOOL;
        private Lazy<NullDictionary<string, STVDI_TR>> Index_STVDI_TRANS_ID;
        private Lazy<Dictionary<int, STVDI_TR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STVDI_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STVDI_TR</param>
        /// <returns>List of related STVDI_TR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI_TR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STVDI_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STVDI_TR</param>
        /// <param name="Value">List of related STVDI_TR entities</param>
        /// <returns>True if the list of related STVDI_TR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<STVDI_TR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STVDI_TR</param>
        /// <returns>List of related STVDI_TR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STVDI_TR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<STVDI_TR> value;
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
        /// Find STVDI_TR by STVDI_TRANS_ID field
        /// </summary>
        /// <param name="STVDI_TRANS_ID">STVDI_TRANS_ID value used to find STVDI_TR</param>
        /// <returns>Related STVDI_TR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDI_TR FindBySTVDI_TRANS_ID(string STVDI_TRANS_ID)
        {
            return Index_STVDI_TRANS_ID.Value[STVDI_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find STVDI_TR by STVDI_TRANS_ID field
        /// </summary>
        /// <param name="STVDI_TRANS_ID">STVDI_TRANS_ID value used to find STVDI_TR</param>
        /// <param name="Value">Related STVDI_TR entity</param>
        /// <returns>True if the related STVDI_TR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTVDI_TRANS_ID(string STVDI_TRANS_ID, out STVDI_TR Value)
        {
            return Index_STVDI_TRANS_ID.Value.TryGetValue(STVDI_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI_TR by STVDI_TRANS_ID field
        /// </summary>
        /// <param name="STVDI_TRANS_ID">STVDI_TRANS_ID value used to find STVDI_TR</param>
        /// <returns>Related STVDI_TR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDI_TR TryFindBySTVDI_TRANS_ID(string STVDI_TRANS_ID)
        {
            STVDI_TR value;
            if (Index_STVDI_TRANS_ID.Value.TryGetValue(STVDI_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STVDI_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDI_TR</param>
        /// <returns>Related STVDI_TR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDI_TR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STVDI_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDI_TR</param>
        /// <param name="Value">Related STVDI_TR entity</param>
        /// <returns>True if the related STVDI_TR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STVDI_TR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STVDI_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STVDI_TR</param>
        /// <returns>Related STVDI_TR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STVDI_TR TryFindByTID(int TID)
        {
            STVDI_TR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STVDI_TR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STVDI_TR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STVDI_TR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [STVDI_TRANS_ID] varchar(30) NULL,
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
        CONSTRAINT [STVDI_TR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [STVDI_TR_Index_ORIG_SCHOOL] ON [dbo].[STVDI_TR]
    (
            [ORIG_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [STVDI_TR_Index_STVDI_TRANS_ID] ON [dbo].[STVDI_TR]
    (
            [STVDI_TRANS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI_TR]') AND name = N'Index_STVDI_TRANS_ID')
    ALTER INDEX [Index_STVDI_TRANS_ID] ON [dbo].[STVDI_TR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI_TR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STVDI_TR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI_TR]') AND name = N'Index_STVDI_TRANS_ID')
    ALTER INDEX [Index_STVDI_TRANS_ID] ON [dbo].[STVDI_TR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STVDI_TR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STVDI_TR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STVDI_TR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STVDI_TR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STVDI_TR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_STVDI_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_STVDI_TRANS_ID.Add(entity.STVDI_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STVDI_TR] WHERE");


            // Index_STVDI_TRANS_ID
            builder.Append("[STVDI_TRANS_ID] IN (");
            for (int index = 0; index < Index_STVDI_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // STVDI_TRANS_ID
                var parameterSTVDI_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSTVDI_TRANS_ID);
                command.Parameters.Add(parameterSTVDI_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_STVDI_TRANS_ID[index] ?? DBNull.Value;
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
        /// Provides a <see cref="IDataReader"/> for the STVDI_TR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDI_TR data set</returns>
        public override EduHubDataSetDataReader<STVDI_TR> GetDataSetDataReader()
        {
            return new STVDI_TRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STVDI_TR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STVDI_TR data set</returns>
        public override EduHubDataSetDataReader<STVDI_TR> GetDataSetDataReader(List<STVDI_TR> Entities)
        {
            return new STVDI_TRDataReader(new EduHubDataSetLoadedReader<STVDI_TR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STVDI_TRDataReader : EduHubDataSetDataReader<STVDI_TR>
        {
            public STVDI_TRDataReader(IEduHubDataSetReader<STVDI_TR> Reader)
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
                    case 2: // STVDI_TRANS_ID
                        return Current.STVDI_TRANS_ID;
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
                    case 2: // STVDI_TRANS_ID
                        return Current.STVDI_TRANS_ID == null;
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
                    case 2: // STVDI_TRANS_ID
                        return "STVDI_TRANS_ID";
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
                    case "STVDI_TRANS_ID":
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
