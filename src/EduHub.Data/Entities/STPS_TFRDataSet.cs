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
    /// STPS Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPS_TFRDataSet : EduHubDataSet<STPS_TFR>
    {
        /// <inheritdoc />
        public override string Name { get { return "STPS_TFR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STPS_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<STPS_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_STPS_TRANS_ID = new Lazy<NullDictionary<string, STPS_TFR>>(() => this.ToNullDictionary(i => i.STPS_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, STPS_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPS_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPS_TFR" /> fields for each CSV column header</returns>
        internal override Action<STPS_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPS_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "STPS_TRANS_ID":
                        mapper[i] = (e, v) => e.STPS_TRANS_ID = v;
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "SKEY_NEW":
                        mapper[i] = (e, v) => e.SKEY_NEW = v;
                        break;
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "ENROL_DATE":
                        mapper[i] = (e, v) => e.ENROL_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DEPART_DATE":
                        mapper[i] = (e, v) => e.DEPART_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "REASON_LEFT":
                        mapper[i] = (e, v) => e.REASON_LEFT = v;
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
        /// Merges <see cref="STPS_TFR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STPS_TFR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STPS_TFR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STPS_TFR}"/> of entities</returns>
        internal override IEnumerable<STPS_TFR> ApplyDeltaEntities(IEnumerable<STPS_TFR> Entities, List<STPS_TFR> DeltaEntities)
        {
            HashSet<string> Index_STPS_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.STPS_TRANS_ID));
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
                            overwritten = overwritten || Index_STPS_TRANS_ID.Remove(entity.STPS_TRANS_ID);
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

        private Lazy<Dictionary<string, IReadOnlyList<STPS_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<NullDictionary<string, STPS_TFR>> Index_STPS_TRANS_ID;
        private Lazy<Dictionary<int, STPS_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STPS_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STPS_TFR</param>
        /// <returns>List of related STPS_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPS_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STPS_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STPS_TFR</param>
        /// <param name="Value">List of related STPS_TFR entities</param>
        /// <returns>True if the list of related STPS_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<STPS_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STPS_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STPS_TFR</param>
        /// <returns>List of related STPS_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPS_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<STPS_TFR> value;
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
        /// Find STPS_TFR by STPS_TRANS_ID field
        /// </summary>
        /// <param name="STPS_TRANS_ID">STPS_TRANS_ID value used to find STPS_TFR</param>
        /// <returns>Related STPS_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPS_TFR FindBySTPS_TRANS_ID(string STPS_TRANS_ID)
        {
            return Index_STPS_TRANS_ID.Value[STPS_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find STPS_TFR by STPS_TRANS_ID field
        /// </summary>
        /// <param name="STPS_TRANS_ID">STPS_TRANS_ID value used to find STPS_TFR</param>
        /// <param name="Value">Related STPS_TFR entity</param>
        /// <returns>True if the related STPS_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTPS_TRANS_ID(string STPS_TRANS_ID, out STPS_TFR Value)
        {
            return Index_STPS_TRANS_ID.Value.TryGetValue(STPS_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STPS_TFR by STPS_TRANS_ID field
        /// </summary>
        /// <param name="STPS_TRANS_ID">STPS_TRANS_ID value used to find STPS_TFR</param>
        /// <returns>Related STPS_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPS_TFR TryFindBySTPS_TRANS_ID(string STPS_TRANS_ID)
        {
            STPS_TFR value;
            if (Index_STPS_TRANS_ID.Value.TryGetValue(STPS_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPS_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPS_TFR</param>
        /// <returns>Related STPS_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPS_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STPS_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPS_TFR</param>
        /// <param name="Value">Related STPS_TFR entity</param>
        /// <returns>True if the related STPS_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STPS_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STPS_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPS_TFR</param>
        /// <returns>Related STPS_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPS_TFR TryFindByTID(int TID)
        {
            STPS_TFR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STPS_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STPS_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STPS_TFR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [STPS_TRANS_ID] varchar(30) NULL,
        [SKEY] varchar(10) NULL,
        [SKEY_NEW] varchar(10) NULL,
        [SCHOOL] varchar(8) NULL,
        [ENROL_DATE] datetime NULL,
        [DEPART_DATE] datetime NULL,
        [REASON_LEFT] varchar(MAX) NULL,
        [ST_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STPS_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [STPS_TFR_Index_ORIG_SCHOOL] ON [dbo].[STPS_TFR]
    (
            [ORIG_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [STPS_TFR_Index_STPS_TRANS_ID] ON [dbo].[STPS_TFR]
    (
            [STPS_TRANS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPS_TFR]') AND name = N'Index_STPS_TRANS_ID')
    ALTER INDEX [Index_STPS_TRANS_ID] ON [dbo].[STPS_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPS_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STPS_TFR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPS_TFR]') AND name = N'Index_STPS_TRANS_ID')
    ALTER INDEX [Index_STPS_TRANS_ID] ON [dbo].[STPS_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPS_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STPS_TFR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STPS_TFR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STPS_TFR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STPS_TFR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_STPS_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_STPS_TRANS_ID.Add(entity.STPS_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STPS_TFR] WHERE");


            // Index_STPS_TRANS_ID
            builder.Append("[STPS_TRANS_ID] IN (");
            for (int index = 0; index < Index_STPS_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // STPS_TRANS_ID
                var parameterSTPS_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSTPS_TRANS_ID);
                command.Parameters.Add(parameterSTPS_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_STPS_TRANS_ID[index] ?? DBNull.Value;
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
        /// Provides a <see cref="IDataReader"/> for the STPS_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STPS_TFR data set</returns>
        public override EduHubDataSetDataReader<STPS_TFR> GetDataSetDataReader()
        {
            return new STPS_TFRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STPS_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STPS_TFR data set</returns>
        public override EduHubDataSetDataReader<STPS_TFR> GetDataSetDataReader(List<STPS_TFR> Entities)
        {
            return new STPS_TFRDataReader(new EduHubDataSetLoadedReader<STPS_TFR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STPS_TFRDataReader : EduHubDataSetDataReader<STPS_TFR>
        {
            public STPS_TFRDataReader(IEduHubDataSetReader<STPS_TFR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 15; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ORIG_SCHOOL
                        return Current.ORIG_SCHOOL;
                    case 2: // STPS_TRANS_ID
                        return Current.STPS_TRANS_ID;
                    case 3: // SKEY
                        return Current.SKEY;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW;
                    case 5: // SCHOOL
                        return Current.SCHOOL;
                    case 6: // ENROL_DATE
                        return Current.ENROL_DATE;
                    case 7: // DEPART_DATE
                        return Current.DEPART_DATE;
                    case 8: // REASON_LEFT
                        return Current.REASON_LEFT;
                    case 9: // ST_TRANS_ID
                        return Current.ST_TRANS_ID;
                    case 10: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 11: // IMP_DATE
                        return Current.IMP_DATE;
                    case 12: // LW_DATE
                        return Current.LW_DATE;
                    case 13: // LW_TIME
                        return Current.LW_TIME;
                    case 14: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // STPS_TRANS_ID
                        return Current.STPS_TRANS_ID == null;
                    case 3: // SKEY
                        return Current.SKEY == null;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW == null;
                    case 5: // SCHOOL
                        return Current.SCHOOL == null;
                    case 6: // ENROL_DATE
                        return Current.ENROL_DATE == null;
                    case 7: // DEPART_DATE
                        return Current.DEPART_DATE == null;
                    case 8: // REASON_LEFT
                        return Current.REASON_LEFT == null;
                    case 9: // ST_TRANS_ID
                        return Current.ST_TRANS_ID == null;
                    case 10: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 11: // IMP_DATE
                        return Current.IMP_DATE == null;
                    case 12: // LW_DATE
                        return Current.LW_DATE == null;
                    case 13: // LW_TIME
                        return Current.LW_TIME == null;
                    case 14: // LW_USER
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
                    case 2: // STPS_TRANS_ID
                        return "STPS_TRANS_ID";
                    case 3: // SKEY
                        return "SKEY";
                    case 4: // SKEY_NEW
                        return "SKEY_NEW";
                    case 5: // SCHOOL
                        return "SCHOOL";
                    case 6: // ENROL_DATE
                        return "ENROL_DATE";
                    case 7: // DEPART_DATE
                        return "DEPART_DATE";
                    case 8: // REASON_LEFT
                        return "REASON_LEFT";
                    case 9: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 10: // IMP_STATUS
                        return "IMP_STATUS";
                    case 11: // IMP_DATE
                        return "IMP_DATE";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
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
                    case "STPS_TRANS_ID":
                        return 2;
                    case "SKEY":
                        return 3;
                    case "SKEY_NEW":
                        return 4;
                    case "SCHOOL":
                        return 5;
                    case "ENROL_DATE":
                        return 6;
                    case "DEPART_DATE":
                        return 7;
                    case "REASON_LEFT":
                        return 8;
                    case "ST_TRANS_ID":
                        return 9;
                    case "IMP_STATUS":
                        return 10;
                    case "IMP_DATE":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
