#if !EduHubScoped
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
    /// Subject Prerequisites Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUPRDataSet : EduHubDataSet<SUPR>
    {
        /// <inheritdoc />
        public override string Name { get { return "SUPR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SUPRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PREREQUISITE = new Lazy<NullDictionary<string, IReadOnlyList<SUPR>>>(() => this.ToGroupedNullDictionary(i => i.PREREQUISITE));
            Index_SUPRKEY = new Lazy<Dictionary<string, IReadOnlyList<SUPR>>>(() => this.ToGroupedDictionary(i => i.SUPRKEY));
            Index_TID = new Lazy<Dictionary<int, SUPR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SUPR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SUPR" /> fields for each CSV column header</returns>
        internal override Action<SUPR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SUPR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SUPRKEY":
                        mapper[i] = (e, v) => e.SUPRKEY = v;
                        break;
                    case "PREREQUISITE":
                        mapper[i] = (e, v) => e.PREREQUISITE = v;
                        break;
                    case "RESULT":
                        mapper[i] = (e, v) => e.RESULT = v;
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
        /// Merges <see cref="SUPR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SUPR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SUPR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SUPR}"/> of entities</returns>
        internal override IEnumerable<SUPR> ApplyDeltaEntities(IEnumerable<SUPR> Entities, List<SUPR> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SUPRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SUPRKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SUPR>>> Index_PREREQUISITE;
        private Lazy<Dictionary<string, IReadOnlyList<SUPR>>> Index_SUPRKEY;
        private Lazy<Dictionary<int, SUPR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <returns>List of related SUPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> FindByPREREQUISITE(string PREREQUISITE)
        {
            return Index_PREREQUISITE.Value[PREREQUISITE];
        }

        /// <summary>
        /// Attempt to find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <param name="Value">List of related SUPR entities</param>
        /// <returns>True if the list of related SUPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPREREQUISITE(string PREREQUISITE, out IReadOnlyList<SUPR> Value)
        {
            return Index_PREREQUISITE.Value.TryGetValue(PREREQUISITE, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by PREREQUISITE field
        /// </summary>
        /// <param name="PREREQUISITE">PREREQUISITE value used to find SUPR</param>
        /// <returns>List of related SUPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> TryFindByPREREQUISITE(string PREREQUISITE)
        {
            IReadOnlyList<SUPR> value;
            if (Index_PREREQUISITE.Value.TryGetValue(PREREQUISITE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <returns>List of related SUPR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> FindBySUPRKEY(string SUPRKEY)
        {
            return Index_SUPRKEY.Value[SUPRKEY];
        }

        /// <summary>
        /// Attempt to find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <param name="Value">List of related SUPR entities</param>
        /// <returns>True if the list of related SUPR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPRKEY(string SUPRKEY, out IReadOnlyList<SUPR> Value)
        {
            return Index_SUPRKEY.Value.TryGetValue(SUPRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by SUPRKEY field
        /// </summary>
        /// <param name="SUPRKEY">SUPRKEY value used to find SUPR</param>
        /// <returns>List of related SUPR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUPR> TryFindBySUPRKEY(string SUPRKEY)
        {
            IReadOnlyList<SUPR> value;
            if (Index_SUPRKEY.Value.TryGetValue(SUPRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <returns>Related SUPR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUPR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <param name="Value">Related SUPR entity</param>
        /// <returns>True if the related SUPR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SUPR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SUPR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUPR</param>
        /// <returns>Related SUPR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUPR TryFindByTID(int TID)
        {
            SUPR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SUPR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SUPR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SUPR](
        [TID] int IDENTITY NOT NULL,
        [SUPRKEY] varchar(5) NOT NULL,
        [PREREQUISITE] varchar(5) NULL,
        [RESULT] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SUPR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SUPR_Index_PREREQUISITE] ON [dbo].[SUPR]
    (
            [PREREQUISITE] ASC
    );
    CREATE CLUSTERED INDEX [SUPR_Index_SUPRKEY] ON [dbo].[SUPR]
    (
            [SUPRKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SUPR]') AND name = N'SUPR_Index_PREREQUISITE')
    ALTER INDEX [SUPR_Index_PREREQUISITE] ON [dbo].[SUPR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SUPR]') AND name = N'SUPR_Index_TID')
    ALTER INDEX [SUPR_Index_TID] ON [dbo].[SUPR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SUPR]') AND name = N'SUPR_Index_PREREQUISITE')
    ALTER INDEX [SUPR_Index_PREREQUISITE] ON [dbo].[SUPR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SUPR]') AND name = N'SUPR_Index_TID')
    ALTER INDEX [SUPR_Index_TID] ON [dbo].[SUPR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SUPR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SUPR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SUPR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SUPR] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SUPR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SUPR data set</returns>
        public override EduHubDataSetDataReader<SUPR> GetDataSetDataReader()
        {
            return new SUPRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SUPR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SUPR data set</returns>
        public override EduHubDataSetDataReader<SUPR> GetDataSetDataReader(List<SUPR> Entities)
        {
            return new SUPRDataReader(new EduHubDataSetLoadedReader<SUPR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SUPRDataReader : EduHubDataSetDataReader<SUPR>
        {
            public SUPRDataReader(IEduHubDataSetReader<SUPR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SUPRKEY
                        return Current.SUPRKEY;
                    case 2: // PREREQUISITE
                        return Current.PREREQUISITE;
                    case 3: // RESULT
                        return Current.RESULT;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PREREQUISITE
                        return Current.PREREQUISITE == null;
                    case 3: // RESULT
                        return Current.RESULT == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
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
                    case 1: // SUPRKEY
                        return "SUPRKEY";
                    case 2: // PREREQUISITE
                        return "PREREQUISITE";
                    case 3: // RESULT
                        return "RESULT";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
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
                    case "SUPRKEY":
                        return 1;
                    case "PREREQUISITE":
                        return 2;
                    case "RESULT":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
