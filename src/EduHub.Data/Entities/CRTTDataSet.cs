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
    /// Creditor Trade Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRTTDataSet : EduHubDataSet<CRTT>
    {
        /// <inheritdoc />
        public override string Name { get { return "CRTT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal CRTTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CRKEY = new Lazy<Dictionary<string, IReadOnlyList<CRTT>>>(() => this.ToGroupedDictionary(i => i.CRKEY));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<CRTT>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, CRTT>>(() => this.ToDictionary(i => i.TID));
            Index_TRADE_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<CRTT>>>(() => this.ToGroupedNullDictionary(i => i.TRADE_TYPE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CRTT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CRTT" /> fields for each CSV column header</returns>
        internal override Action<CRTT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CRTT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "TRADE_TYPE":
                        mapper[i] = (e, v) => e.TRADE_TYPE = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
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
        /// Merges <see cref="CRTT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="CRTT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="CRTT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{CRTT}"/> of entities</returns>
        internal override IEnumerable<CRTT> ApplyDeltaEntities(IEnumerable<CRTT> Entities, List<CRTT> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CRKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<CRTT>>> Index_CRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<CRTT>>> Index_STAFF;
        private Lazy<Dictionary<int, CRTT>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<CRTT>>> Index_TRADE_TYPE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CRTT by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CRTT</param>
        /// <returns>List of related CRTT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRTT> FindByCRKEY(string CRKEY)
        {
            return Index_CRKEY.Value[CRKEY];
        }

        /// <summary>
        /// Attempt to find CRTT by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CRTT</param>
        /// <param name="Value">List of related CRTT entities</param>
        /// <returns>True if the list of related CRTT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCRKEY(string CRKEY, out IReadOnlyList<CRTT> Value)
        {
            return Index_CRKEY.Value.TryGetValue(CRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CRTT by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CRTT</param>
        /// <returns>List of related CRTT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRTT> TryFindByCRKEY(string CRKEY)
        {
            IReadOnlyList<CRTT> value;
            if (Index_CRKEY.Value.TryGetValue(CRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRTT by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find CRTT</param>
        /// <returns>List of related CRTT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRTT> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find CRTT by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find CRTT</param>
        /// <param name="Value">List of related CRTT entities</param>
        /// <returns>True if the list of related CRTT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<CRTT> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find CRTT by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find CRTT</param>
        /// <returns>List of related CRTT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRTT> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<CRTT> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRTT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRTT</param>
        /// <returns>Related CRTT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRTT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find CRTT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRTT</param>
        /// <param name="Value">Related CRTT entity</param>
        /// <returns>True if the related CRTT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out CRTT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find CRTT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRTT</param>
        /// <returns>Related CRTT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRTT TryFindByTID(int TID)
        {
            CRTT value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRTT by TRADE_TYPE field
        /// </summary>
        /// <param name="TRADE_TYPE">TRADE_TYPE value used to find CRTT</param>
        /// <returns>List of related CRTT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRTT> FindByTRADE_TYPE(string TRADE_TYPE)
        {
            return Index_TRADE_TYPE.Value[TRADE_TYPE];
        }

        /// <summary>
        /// Attempt to find CRTT by TRADE_TYPE field
        /// </summary>
        /// <param name="TRADE_TYPE">TRADE_TYPE value used to find CRTT</param>
        /// <param name="Value">List of related CRTT entities</param>
        /// <returns>True if the list of related CRTT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRADE_TYPE(string TRADE_TYPE, out IReadOnlyList<CRTT> Value)
        {
            return Index_TRADE_TYPE.Value.TryGetValue(TRADE_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find CRTT by TRADE_TYPE field
        /// </summary>
        /// <param name="TRADE_TYPE">TRADE_TYPE value used to find CRTT</param>
        /// <returns>List of related CRTT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRTT> TryFindByTRADE_TYPE(string TRADE_TYPE)
        {
            IReadOnlyList<CRTT> value;
            if (Index_TRADE_TYPE.Value.TryGetValue(TRADE_TYPE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a CRTT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[CRTT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[CRTT](
        [TID] int IDENTITY NOT NULL,
        [CRKEY] varchar(10) NOT NULL,
        [TRADE_TYPE] varchar(10) NULL,
        [STAFF] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [CRTT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [CRTT_Index_CRKEY] ON [dbo].[CRTT]
    (
            [CRKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [CRTT_Index_STAFF] ON [dbo].[CRTT]
    (
            [STAFF] ASC
    );
    CREATE NONCLUSTERED INDEX [CRTT_Index_TRADE_TYPE] ON [dbo].[CRTT]
    (
            [TRADE_TYPE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRTT]') AND name = N'CRTT_Index_STAFF')
    ALTER INDEX [CRTT_Index_STAFF] ON [dbo].[CRTT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRTT]') AND name = N'CRTT_Index_TID')
    ALTER INDEX [CRTT_Index_TID] ON [dbo].[CRTT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRTT]') AND name = N'CRTT_Index_TRADE_TYPE')
    ALTER INDEX [CRTT_Index_TRADE_TYPE] ON [dbo].[CRTT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRTT]') AND name = N'CRTT_Index_STAFF')
    ALTER INDEX [CRTT_Index_STAFF] ON [dbo].[CRTT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRTT]') AND name = N'CRTT_Index_TID')
    ALTER INDEX [CRTT_Index_TID] ON [dbo].[CRTT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CRTT]') AND name = N'CRTT_Index_TRADE_TYPE')
    ALTER INDEX [CRTT_Index_TRADE_TYPE] ON [dbo].[CRTT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="CRTT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="CRTT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<CRTT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[CRTT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the CRTT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRTT data set</returns>
        public override EduHubDataSetDataReader<CRTT> GetDataSetDataReader()
        {
            return new CRTTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CRTT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CRTT data set</returns>
        public override EduHubDataSetDataReader<CRTT> GetDataSetDataReader(List<CRTT> Entities)
        {
            return new CRTTDataReader(new EduHubDataSetLoadedReader<CRTT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class CRTTDataReader : EduHubDataSetDataReader<CRTT>
        {
            public CRTTDataReader(IEduHubDataSetReader<CRTT> Reader)
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
                    case 1: // CRKEY
                        return Current.CRKEY;
                    case 2: // TRADE_TYPE
                        return Current.TRADE_TYPE;
                    case 3: // STAFF
                        return Current.STAFF;
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
                    case 2: // TRADE_TYPE
                        return Current.TRADE_TYPE == null;
                    case 3: // STAFF
                        return Current.STAFF == null;
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
                    case 1: // CRKEY
                        return "CRKEY";
                    case 2: // TRADE_TYPE
                        return "TRADE_TYPE";
                    case 3: // STAFF
                        return "STAFF";
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
                    case "CRKEY":
                        return 1;
                    case "TRADE_TYPE":
                        return 2;
                    case "STAFF":
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
