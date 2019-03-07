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
    /// STNAT Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STNAT_TRDataSet : EduHubDataSet<STNAT_TR>
    {
        /// <inheritdoc />
        public override string Name { get { return "STNAT_TR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STNAT_TRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<STNAT_TR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_STNAT_TRANS_ID = new Lazy<NullDictionary<string, STNAT_TR>>(() => this.ToNullDictionary(i => i.STNAT_TRANS_ID));
            Index_TID = new Lazy<Dictionary<int, STNAT_TR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STNAT_TR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STNAT_TR" /> fields for each CSV column header</returns>
        internal override Action<STNAT_TR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STNAT_TR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "STNAT_TRANS_ID":
                        mapper[i] = (e, v) => e.STNAT_TRANS_ID = v;
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "SKEY_NEW":
                        mapper[i] = (e, v) => e.SKEY_NEW = v;
                        break;
                    case "NOTE_TYPE":
                        mapper[i] = (e, v) => e.NOTE_TYPE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "REMARK":
                        mapper[i] = (e, v) => e.REMARK = v;
                        break;
                    case "ATTACHMENT":
                        mapper[i] = (e, v) => e.ATTACHMENT = null; // eduHub is not encoding byte arrays
                        break;
                    case "ATTACH_DATE":
                        mapper[i] = (e, v) => e.ATTACH_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ADDED_BY":
                        mapper[i] = (e, v) => e.ADDED_BY = v;
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
        /// Merges <see cref="STNAT_TR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STNAT_TR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STNAT_TR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STNAT_TR}"/> of entities</returns>
        internal override IEnumerable<STNAT_TR> ApplyDeltaEntities(IEnumerable<STNAT_TR> Entities, List<STNAT_TR> DeltaEntities)
        {
            HashSet<string> Index_STNAT_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.STNAT_TRANS_ID));
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
                            overwritten = overwritten || Index_STNAT_TRANS_ID.Remove(entity.STNAT_TRANS_ID);
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

        private Lazy<Dictionary<string, IReadOnlyList<STNAT_TR>>> Index_ORIG_SCHOOL;
        private Lazy<NullDictionary<string, STNAT_TR>> Index_STNAT_TRANS_ID;
        private Lazy<Dictionary<int, STNAT_TR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STNAT_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STNAT_TR</param>
        /// <returns>List of related STNAT_TR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STNAT_TR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find STNAT_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STNAT_TR</param>
        /// <param name="Value">List of related STNAT_TR entities</param>
        /// <returns>True if the list of related STNAT_TR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<STNAT_TR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STNAT_TR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find STNAT_TR</param>
        /// <returns>List of related STNAT_TR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STNAT_TR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<STNAT_TR> value;
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
        /// Find STNAT_TR by STNAT_TRANS_ID field
        /// </summary>
        /// <param name="STNAT_TRANS_ID">STNAT_TRANS_ID value used to find STNAT_TR</param>
        /// <returns>Related STNAT_TR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STNAT_TR FindBySTNAT_TRANS_ID(string STNAT_TRANS_ID)
        {
            return Index_STNAT_TRANS_ID.Value[STNAT_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find STNAT_TR by STNAT_TRANS_ID field
        /// </summary>
        /// <param name="STNAT_TRANS_ID">STNAT_TRANS_ID value used to find STNAT_TR</param>
        /// <param name="Value">Related STNAT_TR entity</param>
        /// <returns>True if the related STNAT_TR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTNAT_TRANS_ID(string STNAT_TRANS_ID, out STNAT_TR Value)
        {
            return Index_STNAT_TRANS_ID.Value.TryGetValue(STNAT_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find STNAT_TR by STNAT_TRANS_ID field
        /// </summary>
        /// <param name="STNAT_TRANS_ID">STNAT_TRANS_ID value used to find STNAT_TR</param>
        /// <returns>Related STNAT_TR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STNAT_TR TryFindBySTNAT_TRANS_ID(string STNAT_TRANS_ID)
        {
            STNAT_TR value;
            if (Index_STNAT_TRANS_ID.Value.TryGetValue(STNAT_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STNAT_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STNAT_TR</param>
        /// <returns>Related STNAT_TR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STNAT_TR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STNAT_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STNAT_TR</param>
        /// <param name="Value">Related STNAT_TR entity</param>
        /// <returns>True if the related STNAT_TR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STNAT_TR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STNAT_TR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STNAT_TR</param>
        /// <returns>Related STNAT_TR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STNAT_TR TryFindByTID(int TID)
        {
            STNAT_TR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STNAT_TR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STNAT_TR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STNAT_TR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [STNAT_TRANS_ID] varchar(30) NULL,
        [SKEY] varchar(10) NULL,
        [SKEY_NEW] varchar(10) NULL,
        [NOTE_TYPE] varchar(10) NULL,
        [DESCRIPTION] varchar(30) NULL,
        [REMARK] varchar(MAX) NULL,
        [ATTACHMENT] varbinary(MAX) NULL,
        [ATTACH_DATE] datetime NULL,
        [ADDED_BY] varchar(128) NULL,
        [ST_TRANS_ID] varchar(30) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STNAT_TR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [STNAT_TR_Index_ORIG_SCHOOL] ON [dbo].[STNAT_TR]
    (
            [ORIG_SCHOOL] ASC
    );
    CREATE NONCLUSTERED INDEX [STNAT_TR_Index_STNAT_TRANS_ID] ON [dbo].[STNAT_TR]
    (
            [STNAT_TRANS_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STNAT_TR]') AND name = N'Index_STNAT_TRANS_ID')
    ALTER INDEX [Index_STNAT_TRANS_ID] ON [dbo].[STNAT_TR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STNAT_TR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STNAT_TR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STNAT_TR]') AND name = N'Index_STNAT_TRANS_ID')
    ALTER INDEX [Index_STNAT_TRANS_ID] ON [dbo].[STNAT_TR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STNAT_TR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STNAT_TR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STNAT_TR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STNAT_TR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STNAT_TR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_STNAT_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_STNAT_TRANS_ID.Add(entity.STNAT_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STNAT_TR] WHERE");


            // Index_STNAT_TRANS_ID
            builder.Append("[STNAT_TRANS_ID] IN (");
            for (int index = 0; index < Index_STNAT_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // STNAT_TRANS_ID
                var parameterSTNAT_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSTNAT_TRANS_ID);
                command.Parameters.Add(parameterSTNAT_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_STNAT_TRANS_ID[index] ?? DBNull.Value;
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
        /// Provides a <see cref="IDataReader"/> for the STNAT_TR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STNAT_TR data set</returns>
        public override EduHubDataSetDataReader<STNAT_TR> GetDataSetDataReader()
        {
            return new STNAT_TRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STNAT_TR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STNAT_TR data set</returns>
        public override EduHubDataSetDataReader<STNAT_TR> GetDataSetDataReader(List<STNAT_TR> Entities)
        {
            return new STNAT_TRDataReader(new EduHubDataSetLoadedReader<STNAT_TR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STNAT_TRDataReader : EduHubDataSetDataReader<STNAT_TR>
        {
            public STNAT_TRDataReader(IEduHubDataSetReader<STNAT_TR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 17; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // ORIG_SCHOOL
                        return Current.ORIG_SCHOOL;
                    case 2: // STNAT_TRANS_ID
                        return Current.STNAT_TRANS_ID;
                    case 3: // SKEY
                        return Current.SKEY;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW;
                    case 5: // NOTE_TYPE
                        return Current.NOTE_TYPE;
                    case 6: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 7: // REMARK
                        return Current.REMARK;
                    case 8: // ATTACHMENT
                        return Current.ATTACHMENT;
                    case 9: // ATTACH_DATE
                        return Current.ATTACH_DATE;
                    case 10: // ADDED_BY
                        return Current.ADDED_BY;
                    case 11: // ST_TRANS_ID
                        return Current.ST_TRANS_ID;
                    case 12: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 13: // IMP_DATE
                        return Current.IMP_DATE;
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
                    case 2: // STNAT_TRANS_ID
                        return Current.STNAT_TRANS_ID == null;
                    case 3: // SKEY
                        return Current.SKEY == null;
                    case 4: // SKEY_NEW
                        return Current.SKEY_NEW == null;
                    case 5: // NOTE_TYPE
                        return Current.NOTE_TYPE == null;
                    case 6: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 7: // REMARK
                        return Current.REMARK == null;
                    case 8: // ATTACHMENT
                        return Current.ATTACHMENT == null;
                    case 9: // ATTACH_DATE
                        return Current.ATTACH_DATE == null;
                    case 10: // ADDED_BY
                        return Current.ADDED_BY == null;
                    case 11: // ST_TRANS_ID
                        return Current.ST_TRANS_ID == null;
                    case 12: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 13: // IMP_DATE
                        return Current.IMP_DATE == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // ORIG_SCHOOL
                        return "ORIG_SCHOOL";
                    case 2: // STNAT_TRANS_ID
                        return "STNAT_TRANS_ID";
                    case 3: // SKEY
                        return "SKEY";
                    case 4: // SKEY_NEW
                        return "SKEY_NEW";
                    case 5: // NOTE_TYPE
                        return "NOTE_TYPE";
                    case 6: // DESCRIPTION
                        return "DESCRIPTION";
                    case 7: // REMARK
                        return "REMARK";
                    case 8: // ATTACHMENT
                        return "ATTACHMENT";
                    case 9: // ATTACH_DATE
                        return "ATTACH_DATE";
                    case 10: // ADDED_BY
                        return "ADDED_BY";
                    case 11: // ST_TRANS_ID
                        return "ST_TRANS_ID";
                    case 12: // IMP_STATUS
                        return "IMP_STATUS";
                    case 13: // IMP_DATE
                        return "IMP_DATE";
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
                    case "TID":
                        return 0;
                    case "ORIG_SCHOOL":
                        return 1;
                    case "STNAT_TRANS_ID":
                        return 2;
                    case "SKEY":
                        return 3;
                    case "SKEY_NEW":
                        return 4;
                    case "NOTE_TYPE":
                        return 5;
                    case "DESCRIPTION":
                        return 6;
                    case "REMARK":
                        return 7;
                    case "ATTACHMENT":
                        return 8;
                    case "ATTACH_DATE":
                        return 9;
                    case "ADDED_BY":
                        return 10;
                    case "ST_TRANS_ID":
                        return 11;
                    case "IMP_STATUS":
                        return 12;
                    case "IMP_DATE":
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
