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
    /// STAR Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STAR_TFRDataSet : EduHubDataSet<STAR_TFR>
    {
        /// <inheritdoc />
        public override string Name { get { return "STAR_TFR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STAR_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<STAR_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_STAR_TRANS_ID = new Lazy<NullDictionary<string, STAR_TFR>>(() => this.ToNullDictionary(i => i.STAR_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, STAR_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STAR_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STAR_TFR" /> fields for each CSV column header</returns>
        internal override Action<STAR_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STAR_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "STAR_TRANS_ID":
                        mapper[i] = (e, v) => e.STAR_TRANS_ID = v;
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "SKEY_NEW":
                        mapper[i] = (e, v) => e.SKEY_NEW = v;
                        break;
                    case "ACCESS_TYPE":
                        mapper[i] = (e, v) => e.ACCESS_TYPE = v;
                        break;
                    case "RESTRICTION":
                        mapper[i] = (e, v) => e.RESTRICTION = v;
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
        /// Merges <see cref="STAR_TFR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STAR_TFR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STAR_TFR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STAR_TFR}"/> of entities</returns>
        internal override IEnumerable<STAR_TFR> ApplyDeltaEntities(IEnumerable<STAR_TFR> Entities, List<STAR_TFR> DeltaEntities)
        {
            HashSet<string> Index_STAR_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.STAR_TRANS_ID));
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
                            overwritten = overwritten || Index_STAR_TRANS_ID.Remove(entity.STAR_TRANS_ID);
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

        private Lazy<Dictionary<string, IReadOnlyList<STAR_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<NullDictionary<string, STAR_TFR>> Index_STAR_TRANS_ID;
        private Lazy<Dictionary<int, STAR_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STAR_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STAR_TFR</param>
        /// <returns>List of related STAR_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STAR_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STAR_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STAR_TFR</param>
        /// <param name="Value">List of related STAR_TFR entities</param>
        /// <returns>True if the list of related STAR_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<STAR_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STAR_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STAR_TFR</param>
        /// <returns>List of related STAR_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STAR_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<STAR_TFR> value;
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
        /// Find STAR_TFR by STAR_TRANS_ID field
        /// </summary>
        /// <param name="STAR_TRANS_ID">STAR_TRANS_ID value used to find STAR_TFR</param>
        /// <returns>Related STAR_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STAR_TFR FindBySTAR_TRANS_ID(string STAR_TRANS_ID)
        {
            return Index_STAR_TRANS_ID.Value[STAR_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find STAR_TFR by STAR_TRANS_ID field
        /// </summary>
        /// <param name="STAR_TRANS_ID">STAR_TRANS_ID value used to find STAR_TFR</param>
        /// <param name="Value">Related STAR_TFR entity</param>
        /// <returns>True if the related STAR_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAR_TRANS_ID(string STAR_TRANS_ID, out STAR_TFR Value)
        {
            return Index_STAR_TRANS_ID.Value.TryGetValue(STAR_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STAR_TFR by STAR_TRANS_ID field
        /// </summary>
        /// <param name="STAR_TRANS_ID">STAR_TRANS_ID value used to find STAR_TFR</param>
        /// <returns>Related STAR_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STAR_TFR TryFindBySTAR_TRANS_ID(string STAR_TRANS_ID)
        {
            STAR_TFR value;
            if (Index_STAR_TRANS_ID.Value.TryGetValue(STAR_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STAR_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STAR_TFR</param>
        /// <returns>Related STAR_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STAR_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STAR_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STAR_TFR</param>
        /// <param name="Value">Related STAR_TFR entity</param>
        /// <returns>True if the related STAR_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STAR_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STAR_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STAR_TFR</param>
        /// <returns>Related STAR_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STAR_TFR TryFindByTID(int TID)
        {
            STAR_TFR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STAR_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STAR_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STAR_TFR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [STAR_TRANS_ID] varchar(30) NULL,
        [SKEY] varchar(10) NULL,
        [SKEY_NEW] varchar(10) NULL,
        [ACCESS_TYPE] varchar(30) NULL,
        [RESTRICTION] varchar(MAX) NULL,
        [ST_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STAR_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [STAR_TFR_Index_ORIG_SCHOOL] ON [dbo].[STAR_TFR]
    (
            [ORIG_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [STAR_TFR_Index_STAR_TRANS_ID] ON [dbo].[STAR_TFR]
    (
            [STAR_TRANS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STAR_TFR]') AND name = N'Index_STAR_TRANS_ID')
    ALTER INDEX [Index_STAR_TRANS_ID] ON [dbo].[STAR_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STAR_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STAR_TFR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STAR_TFR]') AND name = N'Index_STAR_TRANS_ID')
    ALTER INDEX [Index_STAR_TRANS_ID] ON [dbo].[STAR_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STAR_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STAR_TFR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STAR_TFR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STAR_TFR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STAR_TFR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_STAR_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_STAR_TRANS_ID.Add(entity.STAR_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STAR_TFR] WHERE");


            // Index_STAR_TRANS_ID
            builder.Append("[STAR_TRANS_ID] IN (");
            for (int index = 0; index < Index_STAR_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // STAR_TRANS_ID
                var parameterSTAR_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSTAR_TRANS_ID);
                command.Parameters.Add(parameterSTAR_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_STAR_TRANS_ID[index] ?? DBNull.Value;
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
        /// Provides a <see cref="IDataReader"/> for the STAR_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STAR_TFR data set</returns>
        public override EduHubDataSetDataReader<STAR_TFR> GetDataSetDataReader()
        {
            return new STAR_TFRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STAR_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STAR_TFR data set</returns>
        public override EduHubDataSetDataReader<STAR_TFR> GetDataSetDataReader(List<STAR_TFR> Entities)
        {
            return new STAR_TFRDataReader(new EduHubDataSetLoadedReader<STAR_TFR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STAR_TFRDataReader : EduHubDataSetDataReader<STAR_TFR>
        {
            public STAR_TFRDataReader(IEduHubDataSetReader<STAR_TFR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ORIG_SCHOOL
                        return Current.ORIG_SCHOOL;
                    case 2: // STAR_TRANS_ID
                        return Current.STAR_TRANS_ID;
                    case 3: // SKEY
                        return Current.SKEY;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW;
                    case 5: // ACCESS_TYPE
                        return Current.ACCESS_TYPE;
                    case 6: // RESTRICTION
                        return Current.RESTRICTION;
                    case 7: // ST_TRANS_ID
                        return Current.ST_TRANS_ID;
                    case 8: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 9: // IMP_DATE
                        return Current.IMP_DATE;
                    case 10: // LW_DATE
                        return Current.LW_DATE;
                    case 11: // LW_TIME
                        return Current.LW_TIME;
                    case 12: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // STAR_TRANS_ID
                        return Current.STAR_TRANS_ID == null;
                    case 3: // SKEY
                        return Current.SKEY == null;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW == null;
                    case 5: // ACCESS_TYPE
                        return Current.ACCESS_TYPE == null;
                    case 6: // RESTRICTION
                        return Current.RESTRICTION == null;
                    case 7: // ST_TRANS_ID
                        return Current.ST_TRANS_ID == null;
                    case 8: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 9: // IMP_DATE
                        return Current.IMP_DATE == null;
                    case 10: // LW_DATE
                        return Current.LW_DATE == null;
                    case 11: // LW_TIME
                        return Current.LW_TIME == null;
                    case 12: // LW_USER
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
                    case 2: // STAR_TRANS_ID
                        return "STAR_TRANS_ID";
                    case 3: // SKEY
                        return "SKEY";
                    case 4: // SKEY_NEW
                        return "SKEY_NEW";
                    case 5: // ACCESS_TYPE
                        return "ACCESS_TYPE";
                    case 6: // RESTRICTION
                        return "RESTRICTION";
                    case 7: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 8: // IMP_STATUS
                        return "IMP_STATUS";
                    case 9: // IMP_DATE
                        return "IMP_DATE";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
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
                    case "STAR_TRANS_ID":
                        return 2;
                    case "SKEY":
                        return 3;
                    case "SKEY_NEW":
                        return 4;
                    case "ACCESS_TYPE":
                        return 5;
                    case "RESTRICTION":
                        return 6;
                    case "ST_TRANS_ID":
                        return 7;
                    case "IMP_STATUS":
                        return 8;
                    case "IMP_DATE":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
