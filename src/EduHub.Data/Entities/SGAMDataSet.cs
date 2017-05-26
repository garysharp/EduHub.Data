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
    /// Adult Group Members Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGAMDataSet : EduHubDataSet<SGAM>
    {
        /// <inheritdoc />
        public override string Name { get { return "SGAM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SGAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGAMKEY = new Lazy<Dictionary<string, IReadOnlyList<SGAM>>>(() => this.ToGroupedDictionary(i => i.SGAMKEY));
            Index_TID = new Lazy<Dictionary<int, SGAM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGAM" /> fields for each CSV column header</returns>
        internal override Action<SGAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGAMKEY":
                        mapper[i] = (e, v) => e.SGAMKEY = v;
                        break;
                    case "ADULT_PERSON_TYPE":
                        mapper[i] = (e, v) => e.ADULT_PERSON_TYPE = v;
                        break;
                    case "PERSON_LINK":
                        mapper[i] = (e, v) => e.PERSON_LINK = v;
                        break;
                    case "DF_PARTICIPATION":
                        mapper[i] = (e, v) => e.DF_PARTICIPATION = v;
                        break;
                    case "RESPONSIBLE":
                        mapper[i] = (e, v) => e.RESPONSIBLE = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OTHER_COMMENTS":
                        mapper[i] = (e, v) => e.OTHER_COMMENTS = v;
                        break;
                    case "GROUP_ROLE":
                        mapper[i] = (e, v) => e.GROUP_ROLE = v;
                        break;
                    case "SG_TYPE":
                        mapper[i] = (e, v) => e.SG_TYPE = v;
                        break;
                    case "HOUSE_HG":
                        mapper[i] = (e, v) => e.HOUSE_HG = v;
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
        /// Merges <see cref="SGAM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SGAM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SGAM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SGAM}"/> of entities</returns>
        internal override IEnumerable<SGAM> ApplyDeltaEntities(IEnumerable<SGAM> Entities, List<SGAM> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SGAMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SGAMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SGAM>>> Index_SGAMKEY;
        private Lazy<Dictionary<int, SGAM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <returns>List of related SGAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGAM> FindBySGAMKEY(string SGAMKEY)
        {
            return Index_SGAMKEY.Value[SGAMKEY];
        }

        /// <summary>
        /// Attempt to find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <param name="Value">List of related SGAM entities</param>
        /// <returns>True if the list of related SGAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGAMKEY(string SGAMKEY, out IReadOnlyList<SGAM> Value)
        {
            return Index_SGAMKEY.Value.TryGetValue(SGAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGAM by SGAMKEY field
        /// </summary>
        /// <param name="SGAMKEY">SGAMKEY value used to find SGAM</param>
        /// <returns>List of related SGAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGAM> TryFindBySGAMKEY(string SGAMKEY)
        {
            IReadOnlyList<SGAM> value;
            if (Index_SGAMKEY.Value.TryGetValue(SGAMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <returns>Related SGAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGAM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <param name="Value">Related SGAM entity</param>
        /// <returns>True if the related SGAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGAM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGAM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGAM</param>
        /// <returns>Related SGAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGAM TryFindByTID(int TID)
        {
            SGAM value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SGAM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGAM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGAM](
        [TID] int IDENTITY NOT NULL,
        [SGAMKEY] varchar(12) NOT NULL,
        [ADULT_PERSON_TYPE] varchar(2) NULL,
        [PERSON_LINK] varchar(10) NULL,
        [DF_PARTICIPATION] varchar(1) NULL,
        [RESPONSIBLE] varchar(1) NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [OTHER_COMMENTS] varchar(MAX) NULL,
        [GROUP_ROLE] varchar(30) NULL,
        [SG_TYPE] varchar(1) NULL,
        [HOUSE_HG] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGAM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SGAM_Index_SGAMKEY] ON [dbo].[SGAM]
    (
            [SGAMKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGAM]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGAM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGAM]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGAM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SGAM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SGAM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SGAM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SGAM] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SGAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGAM data set</returns>
        public override EduHubDataSetDataReader<SGAM> GetDataSetDataReader()
        {
            return new SGAMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGAM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGAM data set</returns>
        public override EduHubDataSetDataReader<SGAM> GetDataSetDataReader(List<SGAM> Entities)
        {
            return new SGAMDataReader(new EduHubDataSetLoadedReader<SGAM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGAMDataReader : EduHubDataSetDataReader<SGAM>
        {
            public SGAMDataReader(IEduHubDataSetReader<SGAM> Reader)
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
                    case 1: // SGAMKEY
                        return Current.SGAMKEY;
                    case 2: // ADULT_PERSON_TYPE
                        return Current.ADULT_PERSON_TYPE;
                    case 3: // PERSON_LINK
                        return Current.PERSON_LINK;
                    case 4: // DF_PARTICIPATION
                        return Current.DF_PARTICIPATION;
                    case 5: // RESPONSIBLE
                        return Current.RESPONSIBLE;
                    case 6: // START_DATE
                        return Current.START_DATE;
                    case 7: // END_DATE
                        return Current.END_DATE;
                    case 8: // OTHER_COMMENTS
                        return Current.OTHER_COMMENTS;
                    case 9: // GROUP_ROLE
                        return Current.GROUP_ROLE;
                    case 10: // SG_TYPE
                        return Current.SG_TYPE;
                    case 11: // HOUSE_HG
                        return Current.HOUSE_HG;
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
                    case 2: // ADULT_PERSON_TYPE
                        return Current.ADULT_PERSON_TYPE == null;
                    case 3: // PERSON_LINK
                        return Current.PERSON_LINK == null;
                    case 4: // DF_PARTICIPATION
                        return Current.DF_PARTICIPATION == null;
                    case 5: // RESPONSIBLE
                        return Current.RESPONSIBLE == null;
                    case 6: // START_DATE
                        return Current.START_DATE == null;
                    case 7: // END_DATE
                        return Current.END_DATE == null;
                    case 8: // OTHER_COMMENTS
                        return Current.OTHER_COMMENTS == null;
                    case 9: // GROUP_ROLE
                        return Current.GROUP_ROLE == null;
                    case 10: // SG_TYPE
                        return Current.SG_TYPE == null;
                    case 11: // HOUSE_HG
                        return Current.HOUSE_HG == null;
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
                    case 1: // SGAMKEY
                        return "SGAMKEY";
                    case 2: // ADULT_PERSON_TYPE
                        return "ADULT_PERSON_TYPE";
                    case 3: // PERSON_LINK
                        return "PERSON_LINK";
                    case 4: // DF_PARTICIPATION
                        return "DF_PARTICIPATION";
                    case 5: // RESPONSIBLE
                        return "RESPONSIBLE";
                    case 6: // START_DATE
                        return "START_DATE";
                    case 7: // END_DATE
                        return "END_DATE";
                    case 8: // OTHER_COMMENTS
                        return "OTHER_COMMENTS";
                    case 9: // GROUP_ROLE
                        return "GROUP_ROLE";
                    case 10: // SG_TYPE
                        return "SG_TYPE";
                    case 11: // HOUSE_HG
                        return "HOUSE_HG";
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
                    case "SGAMKEY":
                        return 1;
                    case "ADULT_PERSON_TYPE":
                        return 2;
                    case "PERSON_LINK":
                        return 3;
                    case "DF_PARTICIPATION":
                        return 4;
                    case "RESPONSIBLE":
                        return 5;
                    case "START_DATE":
                        return 6;
                    case "END_DATE":
                        return 7;
                    case "OTHER_COMMENTS":
                        return 8;
                    case "GROUP_ROLE":
                        return 9;
                    case "SG_TYPE":
                        return 10;
                    case "HOUSE_HG":
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
