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
    public sealed partial class SDGMDataSet : EduHubDataSet<SDGM>
    {
        /// <inheritdoc />
        public override string Name { get { return "SDGM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SDGMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PERSON_LINK = new Lazy<NullDictionary<string, IReadOnlyList<SDGM>>>(() => this.ToGroupedNullDictionary(i => i.PERSON_LINK));
            Index_SDGMKEY = new Lazy<Dictionary<string, IReadOnlyList<SDGM>>>(() => this.ToGroupedDictionary(i => i.SDGMKEY));
            Index_TID = new Lazy<Dictionary<int, SDGM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDGM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDGM" /> fields for each CSV column header</returns>
        internal override Action<SDGM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDGM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SDGMKEY":
                        mapper[i] = (e, v) => e.SDGMKEY = v;
                        break;
                    case "PERSON_LINK":
                        mapper[i] = (e, v) => e.PERSON_LINK = v;
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
        /// Merges <see cref="SDGM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SDGM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SDGM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SDGM}"/> of entities</returns>
        internal override IEnumerable<SDGM> ApplyDeltaEntities(IEnumerable<SDGM> Entities, List<SDGM> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SDGMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SDGMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SDGM>>> Index_PERSON_LINK;
        private Lazy<Dictionary<string, IReadOnlyList<SDGM>>> Index_SDGMKEY;
        private Lazy<Dictionary<int, SDGM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <returns>List of related SDGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> FindByPERSON_LINK(string PERSON_LINK)
        {
            return Index_PERSON_LINK.Value[PERSON_LINK];
        }

        /// <summary>
        /// Attempt to find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <param name="Value">List of related SDGM entities</param>
        /// <returns>True if the list of related SDGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPERSON_LINK(string PERSON_LINK, out IReadOnlyList<SDGM> Value)
        {
            return Index_PERSON_LINK.Value.TryGetValue(PERSON_LINK, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by PERSON_LINK field
        /// </summary>
        /// <param name="PERSON_LINK">PERSON_LINK value used to find SDGM</param>
        /// <returns>List of related SDGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> TryFindByPERSON_LINK(string PERSON_LINK)
        {
            IReadOnlyList<SDGM> value;
            if (Index_PERSON_LINK.Value.TryGetValue(PERSON_LINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <returns>List of related SDGM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> FindBySDGMKEY(string SDGMKEY)
        {
            return Index_SDGMKEY.Value[SDGMKEY];
        }

        /// <summary>
        /// Attempt to find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <param name="Value">List of related SDGM entities</param>
        /// <returns>True if the list of related SDGM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDGMKEY(string SDGMKEY, out IReadOnlyList<SDGM> Value)
        {
            return Index_SDGMKEY.Value.TryGetValue(SDGMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by SDGMKEY field
        /// </summary>
        /// <param name="SDGMKEY">SDGMKEY value used to find SDGM</param>
        /// <returns>List of related SDGM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDGM> TryFindBySDGMKEY(string SDGMKEY)
        {
            IReadOnlyList<SDGM> value;
            if (Index_SDGMKEY.Value.TryGetValue(SDGMKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <returns>Related SDGM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDGM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <param name="Value">Related SDGM entity</param>
        /// <returns>True if the related SDGM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SDGM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SDGM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SDGM</param>
        /// <returns>Related SDGM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDGM TryFindByTID(int TID)
        {
            SDGM value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SDGM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SDGM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SDGM](
        [TID] int IDENTITY NOT NULL,
        [SDGMKEY] varchar(12) NOT NULL,
        [PERSON_LINK] varchar(10) NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [OTHER_COMMENTS] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SDGM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SDGM_Index_PERSON_LINK] ON [dbo].[SDGM]
    (
            [PERSON_LINK] ASC
    );
    CREATE CLUSTERED INDEX [SDGM_Index_SDGMKEY] ON [dbo].[SDGM]
    (
            [SDGMKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDGM]') AND name = N'Index_PERSON_LINK')
    ALTER INDEX [Index_PERSON_LINK] ON [dbo].[SDGM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDGM]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SDGM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDGM]') AND name = N'Index_PERSON_LINK')
    ALTER INDEX [Index_PERSON_LINK] ON [dbo].[SDGM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDGM]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SDGM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SDGM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SDGM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SDGM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SDGM] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SDGM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDGM data set</returns>
        public override EduHubDataSetDataReader<SDGM> GetDataSetDataReader()
        {
            return new SDGMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDGM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDGM data set</returns>
        public override EduHubDataSetDataReader<SDGM> GetDataSetDataReader(List<SDGM> Entities)
        {
            return new SDGMDataReader(new EduHubDataSetLoadedReader<SDGM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SDGMDataReader : EduHubDataSetDataReader<SDGM>
        {
            public SDGMDataReader(IEduHubDataSetReader<SDGM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SDGMKEY
                        return Current.SDGMKEY;
                    case 2: // PERSON_LINK
                        return Current.PERSON_LINK;
                    case 3: // START_DATE
                        return Current.START_DATE;
                    case 4: // END_DATE
                        return Current.END_DATE;
                    case 5: // OTHER_COMMENTS
                        return Current.OTHER_COMMENTS;
                    case 6: // LW_DATE
                        return Current.LW_DATE;
                    case 7: // LW_TIME
                        return Current.LW_TIME;
                    case 8: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PERSON_LINK
                        return Current.PERSON_LINK == null;
                    case 3: // START_DATE
                        return Current.START_DATE == null;
                    case 4: // END_DATE
                        return Current.END_DATE == null;
                    case 5: // OTHER_COMMENTS
                        return Current.OTHER_COMMENTS == null;
                    case 6: // LW_DATE
                        return Current.LW_DATE == null;
                    case 7: // LW_TIME
                        return Current.LW_TIME == null;
                    case 8: // LW_USER
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
                    case 1: // SDGMKEY
                        return "SDGMKEY";
                    case 2: // PERSON_LINK
                        return "PERSON_LINK";
                    case 3: // START_DATE
                        return "START_DATE";
                    case 4: // END_DATE
                        return "END_DATE";
                    case 5: // OTHER_COMMENTS
                        return "OTHER_COMMENTS";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
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
                    case "SDGMKEY":
                        return 1;
                    case "PERSON_LINK":
                        return 2;
                    case "START_DATE":
                        return 3;
                    case "END_DATE":
                        return 4;
                    case "OTHER_COMMENTS":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
