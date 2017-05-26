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
    /// Student Merit Behaviour Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STMBDataSet : EduHubDataSet<STMB>
    {
        /// <inheritdoc />
        public override string Name { get { return "STMB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STMBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AWARD = new Lazy<NullDictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedNullDictionary(i => i.AWARD));
            Index_B_CODE = new Lazy<NullDictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedNullDictionary(i => i.B_CODE));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STMB>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STMB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STMB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STMB" /> fields for each CSV column header</returns>
        internal override Action<STMB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STMB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "B_CODE":
                        mapper[i] = (e, v) => e.B_CODE = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECOMMEND_TYPE":
                        mapper[i] = (e, v) => e.RECOMMEND_TYPE = v;
                        break;
                    case "RECOMMEND_KEY":
                        mapper[i] = (e, v) => e.RECOMMEND_KEY = v;
                        break;
                    case "RECOMMEND_DFAB":
                        mapper[i] = (e, v) => e.RECOMMEND_DFAB = v;
                        break;
                    case "RECOMMEND_OTHER":
                        mapper[i] = (e, v) => e.RECOMMEND_OTHER = v;
                        break;
                    case "AWARD":
                        mapper[i] = (e, v) => e.AWARD = v;
                        break;
                    case "STMB_COMMENT":
                        mapper[i] = (e, v) => e.STMB_COMMENT = v;
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
        /// Merges <see cref="STMB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STMB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STMB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STMB}"/> of entities</returns>
        internal override IEnumerable<STMB> ApplyDeltaEntities(IEnumerable<STMB> Entities, List<STMB> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STMB>>> Index_AWARD;
        private Lazy<NullDictionary<string, IReadOnlyList<STMB>>> Index_B_CODE;
        private Lazy<Dictionary<string, IReadOnlyList<STMB>>> Index_SKEY;
        private Lazy<Dictionary<int, STMB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindByAWARD(string AWARD)
        {
            return Index_AWARD.Value[AWARD];
        }

        /// <summary>
        /// Attempt to find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAWARD(string AWARD, out IReadOnlyList<STMB> Value)
        {
            return Index_AWARD.Value.TryGetValue(AWARD, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by AWARD field
        /// </summary>
        /// <param name="AWARD">AWARD value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindByAWARD(string AWARD)
        {
            IReadOnlyList<STMB> value;
            if (Index_AWARD.Value.TryGetValue(AWARD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindByB_CODE(string B_CODE)
        {
            return Index_B_CODE.Value[B_CODE];
        }

        /// <summary>
        /// Attempt to find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByB_CODE(string B_CODE, out IReadOnlyList<STMB> Value)
        {
            return Index_B_CODE.Value.TryGetValue(B_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by B_CODE field
        /// </summary>
        /// <param name="B_CODE">B_CODE value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindByB_CODE(string B_CODE)
        {
            IReadOnlyList<STMB> value;
            if (Index_B_CODE.Value.TryGetValue(B_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <returns>List of related STMB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <param name="Value">List of related STMB entities</param>
        /// <returns>True if the list of related STMB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STMB> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STMB</param>
        /// <returns>List of related STMB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STMB> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STMB> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <returns>Related STMB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <param name="Value">Related STMB entity</param>
        /// <returns>True if the related STMB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STMB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STMB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STMB</param>
        /// <returns>Related STMB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STMB TryFindByTID(int TID)
        {
            STMB value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STMB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STMB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STMB](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [B_CODE] varchar(10) NULL,
        [DETAIL] varchar(MAX) NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [RECOMMEND_TYPE] varchar(2) NULL,
        [RECOMMEND_KEY] varchar(10) NULL,
        [RECOMMEND_DFAB] varchar(1) NULL,
        [RECOMMEND_OTHER] varchar(MAX) NULL,
        [AWARD] varchar(10) NULL,
        [STMB_COMMENT] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STMB_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STMB_Index_AWARD] ON [dbo].[STMB]
    (
            [AWARD] ASC
    );
    CREATE NONCLUSTERED INDEX [STMB_Index_B_CODE] ON [dbo].[STMB]
    (
            [B_CODE] ASC
    );
    CREATE CLUSTERED INDEX [STMB_Index_SKEY] ON [dbo].[STMB]
    (
            [SKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STMB]') AND name = N'Index_AWARD')
    ALTER INDEX [Index_AWARD] ON [dbo].[STMB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STMB]') AND name = N'Index_B_CODE')
    ALTER INDEX [Index_B_CODE] ON [dbo].[STMB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STMB]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STMB] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STMB]') AND name = N'Index_AWARD')
    ALTER INDEX [Index_AWARD] ON [dbo].[STMB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STMB]') AND name = N'Index_B_CODE')
    ALTER INDEX [Index_B_CODE] ON [dbo].[STMB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STMB]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STMB] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STMB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STMB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STMB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STMB] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STMB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STMB data set</returns>
        public override EduHubDataSetDataReader<STMB> GetDataSetDataReader()
        {
            return new STMBDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STMB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STMB data set</returns>
        public override EduHubDataSetDataReader<STMB> GetDataSetDataReader(List<STMB> Entities)
        {
            return new STMBDataReader(new EduHubDataSetLoadedReader<STMB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STMBDataReader : EduHubDataSetDataReader<STMB>
        {
            public STMBDataReader(IEduHubDataSetReader<STMB> Reader)
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
                    case 1: // SKEY
                        return Current.SKEY;
                    case 2: // B_CODE
                        return Current.B_CODE;
                    case 3: // DETAIL
                        return Current.DETAIL;
                    case 4: // START_DATE
                        return Current.START_DATE;
                    case 5: // END_DATE
                        return Current.END_DATE;
                    case 6: // RECOMMEND_TYPE
                        return Current.RECOMMEND_TYPE;
                    case 7: // RECOMMEND_KEY
                        return Current.RECOMMEND_KEY;
                    case 8: // RECOMMEND_DFAB
                        return Current.RECOMMEND_DFAB;
                    case 9: // RECOMMEND_OTHER
                        return Current.RECOMMEND_OTHER;
                    case 10: // AWARD
                        return Current.AWARD;
                    case 11: // STMB_COMMENT
                        return Current.STMB_COMMENT;
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
                    case 2: // B_CODE
                        return Current.B_CODE == null;
                    case 3: // DETAIL
                        return Current.DETAIL == null;
                    case 4: // START_DATE
                        return Current.START_DATE == null;
                    case 5: // END_DATE
                        return Current.END_DATE == null;
                    case 6: // RECOMMEND_TYPE
                        return Current.RECOMMEND_TYPE == null;
                    case 7: // RECOMMEND_KEY
                        return Current.RECOMMEND_KEY == null;
                    case 8: // RECOMMEND_DFAB
                        return Current.RECOMMEND_DFAB == null;
                    case 9: // RECOMMEND_OTHER
                        return Current.RECOMMEND_OTHER == null;
                    case 10: // AWARD
                        return Current.AWARD == null;
                    case 11: // STMB_COMMENT
                        return Current.STMB_COMMENT == null;
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
                    case 1: // SKEY
                        return "SKEY";
                    case 2: // B_CODE
                        return "B_CODE";
                    case 3: // DETAIL
                        return "DETAIL";
                    case 4: // START_DATE
                        return "START_DATE";
                    case 5: // END_DATE
                        return "END_DATE";
                    case 6: // RECOMMEND_TYPE
                        return "RECOMMEND_TYPE";
                    case 7: // RECOMMEND_KEY
                        return "RECOMMEND_KEY";
                    case 8: // RECOMMEND_DFAB
                        return "RECOMMEND_DFAB";
                    case 9: // RECOMMEND_OTHER
                        return "RECOMMEND_OTHER";
                    case 10: // AWARD
                        return "AWARD";
                    case 11: // STMB_COMMENT
                        return "STMB_COMMENT";
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
                    case "SKEY":
                        return 1;
                    case "B_CODE":
                        return 2;
                    case "DETAIL":
                        return 3;
                    case "START_DATE":
                        return 4;
                    case "END_DATE":
                        return 5;
                    case "RECOMMEND_TYPE":
                        return 6;
                    case "RECOMMEND_KEY":
                        return 7;
                    case "RECOMMEND_DFAB":
                        return 8;
                    case "RECOMMEND_OTHER":
                        return 9;
                    case "AWARD":
                        return 10;
                    case "STMB_COMMENT":
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
