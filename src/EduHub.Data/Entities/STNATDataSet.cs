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
    /// Student Notes and Attachments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STNATDataSet : EduHubDataSet<STNAT>
    {
        /// <inheritdoc />
        public override string Name { get { return "STNAT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STNATDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_NOTE_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<STNAT>>>(() => this.ToGroupedNullDictionary(i => i.NOTE_TYPE));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STNAT>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STNAT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STNAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STNAT" /> fields for each CSV column header</returns>
        internal override Action<STNAT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STNAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
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
        /// Merges <see cref="STNAT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STNAT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STNAT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STNAT}"/> of entities</returns>
        internal override IEnumerable<STNAT> ApplyDeltaEntities(IEnumerable<STNAT> Entities, List<STNAT> DeltaEntities)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STNAT>>> Index_NOTE_TYPE;
        private Lazy<Dictionary<string, IReadOnlyList<STNAT>>> Index_SKEY;
        private Lazy<Dictionary<int, STNAT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STNAT by NOTE_TYPE field
        /// </summary>
        /// <param name="NOTE_TYPE">NOTE_TYPE value used to find STNAT</param>
        /// <returns>List of related STNAT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STNAT> FindByNOTE_TYPE(string NOTE_TYPE)
        {
            return Index_NOTE_TYPE.Value[NOTE_TYPE];
        }

        /// <summary>
        /// Attempt to find STNAT by NOTE_TYPE field
        /// </summary>
        /// <param name="NOTE_TYPE">NOTE_TYPE value used to find STNAT</param>
        /// <param name="Value">List of related STNAT entities</param>
        /// <returns>True if the list of related STNAT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNOTE_TYPE(string NOTE_TYPE, out IReadOnlyList<STNAT> Value)
        {
            return Index_NOTE_TYPE.Value.TryGetValue(NOTE_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find STNAT by NOTE_TYPE field
        /// </summary>
        /// <param name="NOTE_TYPE">NOTE_TYPE value used to find STNAT</param>
        /// <returns>List of related STNAT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STNAT> TryFindByNOTE_TYPE(string NOTE_TYPE)
        {
            IReadOnlyList<STNAT> value;
            if (Index_NOTE_TYPE.Value.TryGetValue(NOTE_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STNAT by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STNAT</param>
        /// <returns>List of related STNAT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STNAT> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STNAT by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STNAT</param>
        /// <param name="Value">List of related STNAT entities</param>
        /// <returns>True if the list of related STNAT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STNAT> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STNAT by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STNAT</param>
        /// <returns>List of related STNAT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STNAT> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STNAT> value;
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
        /// Find STNAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STNAT</param>
        /// <returns>Related STNAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STNAT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STNAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STNAT</param>
        /// <param name="Value">Related STNAT entity</param>
        /// <returns>True if the related STNAT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STNAT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STNAT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STNAT</param>
        /// <returns>Related STNAT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STNAT TryFindByTID(int TID)
        {
            STNAT value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STNAT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STNAT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STNAT](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [NOTE_TYPE] varchar(10) NULL,
        [DESCRIPTION] varchar(30) NULL,
        [REMARK] varchar(MAX) NULL,
        [ATTACHMENT] varbinary(MAX) NULL,
        [ATTACH_DATE] datetime NULL,
        [ADDED_BY] varchar(128) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STNAT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STNAT_Index_NOTE_TYPE] ON [dbo].[STNAT]
    (
            [NOTE_TYPE] ASC
    );
    CREATE CLUSTERED INDEX [STNAT_Index_SKEY] ON [dbo].[STNAT]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STNAT]') AND name = N'Index_NOTE_TYPE')
    ALTER INDEX [Index_NOTE_TYPE] ON [dbo].[STNAT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STNAT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STNAT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STNAT]') AND name = N'Index_NOTE_TYPE')
    ALTER INDEX [Index_NOTE_TYPE] ON [dbo].[STNAT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STNAT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STNAT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STNAT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STNAT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STNAT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STNAT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STNAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STNAT data set</returns>
        public override EduHubDataSetDataReader<STNAT> GetDataSetDataReader()
        {
            return new STNATDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STNAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STNAT data set</returns>
        public override EduHubDataSetDataReader<STNAT> GetDataSetDataReader(List<STNAT> Entities)
        {
            return new STNATDataReader(new EduHubDataSetLoadedReader<STNAT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STNATDataReader : EduHubDataSetDataReader<STNAT>
        {
            public STNATDataReader(IEduHubDataSetReader<STNAT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SKEY
                        return Current.SKEY;
                    case 2: // NOTE_TYPE
                        return Current.NOTE_TYPE;
                    case 3: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 4: // REMARK
                        return Current.REMARK;
                    case 5: // ATTACHMENT
                        return Current.ATTACHMENT;
                    case 6: // ATTACH_DATE
                        return Current.ATTACH_DATE;
                    case 7: // ADDED_BY
                        return Current.ADDED_BY;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // NOTE_TYPE
                        return Current.NOTE_TYPE == null;
                    case 3: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 4: // REMARK
                        return Current.REMARK == null;
                    case 5: // ATTACHMENT
                        return Current.ATTACHMENT == null;
                    case 6: // ATTACH_DATE
                        return Current.ATTACH_DATE == null;
                    case 7: // ADDED_BY
                        return Current.ADDED_BY == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
                    case 10: // LW_USER
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
                    case 2: // NOTE_TYPE
                        return "NOTE_TYPE";
                    case 3: // DESCRIPTION
                        return "DESCRIPTION";
                    case 4: // REMARK
                        return "REMARK";
                    case 5: // ATTACHMENT
                        return "ATTACHMENT";
                    case 6: // ATTACH_DATE
                        return "ATTACH_DATE";
                    case 7: // ADDED_BY
                        return "ADDED_BY";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
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
                    case "NOTE_TYPE":
                        return 2;
                    case "DESCRIPTION":
                        return 3;
                    case "REMARK":
                        return 4;
                    case "ATTACHMENT":
                        return 5;
                    case "ATTACH_DATE":
                        return 6;
                    case "ADDED_BY":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
