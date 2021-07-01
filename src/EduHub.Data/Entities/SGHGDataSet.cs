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
    /// Home Group Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGHGDataSet : EduHubDataSet<SGHG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SGHG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SGHGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGCLINK = new Lazy<NullDictionary<string, IReadOnlyList<SGHG>>>(() => this.ToGroupedNullDictionary(i => i.KGCLINK));
            Index_SGHGKEY = new Lazy<Dictionary<string, IReadOnlyList<SGHG>>>(() => this.ToGroupedDictionary(i => i.SGHGKEY));
            Index_TID = new Lazy<Dictionary<int, SGHG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGHG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGHG" /> fields for each CSV column header</returns>
        internal override Action<SGHG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGHG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGHGKEY":
                        mapper[i] = (e, v) => e.SGHGKEY = v;
                        break;
                    case "KGCLINK":
                        mapper[i] = (e, v) => e.KGCLINK = v;
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
        /// Merges <see cref="SGHG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SGHG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SGHG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SGHG}"/> of entities</returns>
        internal override IEnumerable<SGHG> ApplyDeltaEntities(IEnumerable<SGHG> Entities, List<SGHG> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SGHGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SGHGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SGHG>>> Index_KGCLINK;
        private Lazy<Dictionary<string, IReadOnlyList<SGHG>>> Index_SGHGKEY;
        private Lazy<Dictionary<int, SGHG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <returns>List of related SGHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> FindByKGCLINK(string KGCLINK)
        {
            return Index_KGCLINK.Value[KGCLINK];
        }

        /// <summary>
        /// Attempt to find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <param name="Value">List of related SGHG entities</param>
        /// <returns>True if the list of related SGHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCLINK(string KGCLINK, out IReadOnlyList<SGHG> Value)
        {
            return Index_KGCLINK.Value.TryGetValue(KGCLINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by KGCLINK field
        /// </summary>
        /// <param name="KGCLINK">KGCLINK value used to find SGHG</param>
        /// <returns>List of related SGHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> TryFindByKGCLINK(string KGCLINK)
        {
            IReadOnlyList<SGHG> value;
            if (Index_KGCLINK.Value.TryGetValue(KGCLINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <returns>List of related SGHG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> FindBySGHGKEY(string SGHGKEY)
        {
            return Index_SGHGKEY.Value[SGHGKEY];
        }

        /// <summary>
        /// Attempt to find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <param name="Value">List of related SGHG entities</param>
        /// <returns>True if the list of related SGHG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGHGKEY(string SGHGKEY, out IReadOnlyList<SGHG> Value)
        {
            return Index_SGHGKEY.Value.TryGetValue(SGHGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by SGHGKEY field
        /// </summary>
        /// <param name="SGHGKEY">SGHGKEY value used to find SGHG</param>
        /// <returns>List of related SGHG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGHG> TryFindBySGHGKEY(string SGHGKEY)
        {
            IReadOnlyList<SGHG> value;
            if (Index_SGHGKEY.Value.TryGetValue(SGHGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <returns>Related SGHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGHG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <param name="Value">Related SGHG entity</param>
        /// <returns>True if the related SGHG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGHG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGHG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGHG</param>
        /// <returns>Related SGHG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGHG TryFindByTID(int TID)
        {
            SGHG value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SGHG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGHG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGHG](
        [TID] int IDENTITY NOT NULL,
        [SGHGKEY] varchar(12) NOT NULL,
        [KGCLINK] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGHG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SGHG_Index_KGCLINK] ON [dbo].[SGHG]
    (
            [KGCLINK] ASC
    );
    CREATE CLUSTERED INDEX [SGHG_Index_SGHGKEY] ON [dbo].[SGHG]
    (
            [SGHGKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGHG]') AND name = N'SGHG_Index_KGCLINK')
    ALTER INDEX [SGHG_Index_KGCLINK] ON [dbo].[SGHG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGHG]') AND name = N'SGHG_Index_TID')
    ALTER INDEX [SGHG_Index_TID] ON [dbo].[SGHG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGHG]') AND name = N'SGHG_Index_KGCLINK')
    ALTER INDEX [SGHG_Index_KGCLINK] ON [dbo].[SGHG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGHG]') AND name = N'SGHG_Index_TID')
    ALTER INDEX [SGHG_Index_TID] ON [dbo].[SGHG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SGHG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SGHG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SGHG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SGHG] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SGHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGHG data set</returns>
        public override EduHubDataSetDataReader<SGHG> GetDataSetDataReader()
        {
            return new SGHGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGHG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGHG data set</returns>
        public override EduHubDataSetDataReader<SGHG> GetDataSetDataReader(List<SGHG> Entities)
        {
            return new SGHGDataReader(new EduHubDataSetLoadedReader<SGHG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGHGDataReader : EduHubDataSetDataReader<SGHG>
        {
            public SGHGDataReader(IEduHubDataSetReader<SGHG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SGHGKEY
                        return Current.SGHGKEY;
                    case 2: // KGCLINK
                        return Current.KGCLINK;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // KGCLINK
                        return Current.KGCLINK == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_USER
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
                    case 1: // SGHGKEY
                        return "SGHGKEY";
                    case 2: // KGCLINK
                        return "KGCLINK";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
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
                    case "SGHGKEY":
                        return 1;
                    case "KGCLINK":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
