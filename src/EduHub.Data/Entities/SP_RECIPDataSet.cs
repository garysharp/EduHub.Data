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
    /// SMS Reply Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SP_RECIPDataSet : EduHubDataSet<SP_RECIP>
    {
        /// <inheritdoc />
        public override string Name { get { return "SP_RECIP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SP_RECIPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<SP_RECIP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_CODE_SFKEY = new Lazy<Dictionary<Tuple<string, string>, SP_RECIP>>(() => this.ToDictionary(i => Tuple.Create(i.CODE, i.SFKEY)));
            Index_SFKEY = new Lazy<NullDictionary<string, IReadOnlyList<SP_RECIP>>>(() => this.ToGroupedNullDictionary(i => i.SFKEY));
            Index_TID = new Lazy<Dictionary<int, SP_RECIP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SP_RECIP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SP_RECIP" /> fields for each CSV column header</returns>
        internal override Action<SP_RECIP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SP_RECIP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "SFKEY":
                        mapper[i] = (e, v) => e.SFKEY = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SP_RECIP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SP_RECIP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SP_RECIP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SP_RECIP}"/> of entities</returns>
        internal override IEnumerable<SP_RECIP> ApplyDeltaEntities(IEnumerable<SP_RECIP> Entities, List<SP_RECIP> DeltaEntities)
        {
            HashSet<Tuple<string, string>> Index_CODE_SFKEY = new HashSet<Tuple<string, string>>(DeltaEntities.Select(i => Tuple.Create(i.CODE, i.SFKEY)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_CODE_SFKEY.Remove(Tuple.Create(entity.CODE, entity.SFKEY));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SP_RECIP>>> Index_CODE;
        private Lazy<Dictionary<Tuple<string, string>, SP_RECIP>> Index_CODE_SFKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SP_RECIP>>> Index_SFKEY;
        private Lazy<Dictionary<int, SP_RECIP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SP_RECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_RECIP</param>
        /// <returns>List of related SP_RECIP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SP_RECIP> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SP_RECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_RECIP</param>
        /// <param name="Value">List of related SP_RECIP entities</param>
        /// <returns>True if the list of related SP_RECIP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<SP_RECIP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SP_RECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_RECIP</param>
        /// <returns>List of related SP_RECIP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SP_RECIP> TryFindByCODE(string CODE)
        {
            IReadOnlyList<SP_RECIP> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SP_RECIP by CODE and SFKEY fields
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_RECIP</param>
        /// <param name="SFKEY">SFKEY value used to find SP_RECIP</param>
        /// <returns>Related SP_RECIP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SP_RECIP FindByCODE_SFKEY(string CODE, string SFKEY)
        {
            return Index_CODE_SFKEY.Value[Tuple.Create(CODE, SFKEY)];
        }

        /// <summary>
        /// Attempt to find SP_RECIP by CODE and SFKEY fields
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_RECIP</param>
        /// <param name="SFKEY">SFKEY value used to find SP_RECIP</param>
        /// <param name="Value">Related SP_RECIP entity</param>
        /// <returns>True if the related SP_RECIP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE_SFKEY(string CODE, string SFKEY, out SP_RECIP Value)
        {
            return Index_CODE_SFKEY.Value.TryGetValue(Tuple.Create(CODE, SFKEY), out Value);
        }

        /// <summary>
        /// Attempt to find SP_RECIP by CODE and SFKEY fields
        /// </summary>
        /// <param name="CODE">CODE value used to find SP_RECIP</param>
        /// <param name="SFKEY">SFKEY value used to find SP_RECIP</param>
        /// <returns>Related SP_RECIP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SP_RECIP TryFindByCODE_SFKEY(string CODE, string SFKEY)
        {
            SP_RECIP value;
            if (Index_CODE_SFKEY.Value.TryGetValue(Tuple.Create(CODE, SFKEY), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SP_RECIP by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SP_RECIP</param>
        /// <returns>List of related SP_RECIP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SP_RECIP> FindBySFKEY(string SFKEY)
        {
            return Index_SFKEY.Value[SFKEY];
        }

        /// <summary>
        /// Attempt to find SP_RECIP by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SP_RECIP</param>
        /// <param name="Value">List of related SP_RECIP entities</param>
        /// <returns>True if the list of related SP_RECIP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySFKEY(string SFKEY, out IReadOnlyList<SP_RECIP> Value)
        {
            return Index_SFKEY.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SP_RECIP by SFKEY field
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SP_RECIP</param>
        /// <returns>List of related SP_RECIP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SP_RECIP> TryFindBySFKEY(string SFKEY)
        {
            IReadOnlyList<SP_RECIP> value;
            if (Index_SFKEY.Value.TryGetValue(SFKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SP_RECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SP_RECIP</param>
        /// <returns>Related SP_RECIP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SP_RECIP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SP_RECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SP_RECIP</param>
        /// <param name="Value">Related SP_RECIP entity</param>
        /// <returns>True if the related SP_RECIP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SP_RECIP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SP_RECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SP_RECIP</param>
        /// <returns>Related SP_RECIP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SP_RECIP TryFindByTID(int TID)
        {
            SP_RECIP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SP_RECIP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_RECIP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SP_RECIP](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(15) NOT NULL,
        [SFKEY] varchar(4) NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SP_RECIP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SP_RECIP_Index_CODE] ON [dbo].[SP_RECIP]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [SP_RECIP_Index_CODE_SFKEY] ON [dbo].[SP_RECIP]
    (
            [CODE] ASC,
            [SFKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SP_RECIP_Index_SFKEY] ON [dbo].[SP_RECIP]
    (
            [SFKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SP_RECIP]') AND name = N'Index_CODE_SFKEY')
    ALTER INDEX [Index_CODE_SFKEY] ON [dbo].[SP_RECIP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SP_RECIP]') AND name = N'Index_SFKEY')
    ALTER INDEX [Index_SFKEY] ON [dbo].[SP_RECIP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SP_RECIP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SP_RECIP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SP_RECIP]') AND name = N'Index_CODE_SFKEY')
    ALTER INDEX [Index_CODE_SFKEY] ON [dbo].[SP_RECIP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SP_RECIP]') AND name = N'Index_SFKEY')
    ALTER INDEX [Index_SFKEY] ON [dbo].[SP_RECIP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SP_RECIP]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SP_RECIP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SP_RECIP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SP_RECIP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SP_RECIP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<string, string>> Index_CODE_SFKEY = new List<Tuple<string, string>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_CODE_SFKEY.Add(Tuple.Create(entity.CODE, entity.SFKEY));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SP_RECIP] WHERE");


            // Index_CODE_SFKEY
            builder.Append("(");
            for (int index = 0; index < Index_CODE_SFKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // CODE
                var parameterCODE = $"@p{parameterIndex++}";
                builder.Append("([CODE]=").Append(parameterCODE);
                command.Parameters.Add(parameterCODE, SqlDbType.VarChar, 15).Value = Index_CODE_SFKEY[index].Item1;

                // SFKEY
                if (Index_CODE_SFKEY[index].Item2 == null)
                {
                    builder.Append(" AND [SFKEY] IS NULL)");
                }
                else
                {
                    var parameterSFKEY = $"@p{parameterIndex++}";
                    builder.Append(" AND [SFKEY]=").Append(parameterSFKEY).Append(")");
                    command.Parameters.Add(parameterSFKEY, SqlDbType.VarChar, 4).Value = Index_CODE_SFKEY[index].Item2;
                }
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
        /// Provides a <see cref="IDataReader"/> for the SP_RECIP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SP_RECIP data set</returns>
        public override EduHubDataSetDataReader<SP_RECIP> GetDataSetDataReader()
        {
            return new SP_RECIPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SP_RECIP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SP_RECIP data set</returns>
        public override EduHubDataSetDataReader<SP_RECIP> GetDataSetDataReader(List<SP_RECIP> Entities)
        {
            return new SP_RECIPDataReader(new EduHubDataSetLoadedReader<SP_RECIP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SP_RECIPDataReader : EduHubDataSetDataReader<SP_RECIP>
        {
            public SP_RECIPDataReader(IEduHubDataSetReader<SP_RECIP> Reader)
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
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // SFKEY
                        return Current.SFKEY;
                    case 3: // LW_TIME
                        return Current.LW_TIME;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
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
                    case 2: // SFKEY
                        return Current.SFKEY == null;
                    case 3: // LW_TIME
                        return Current.LW_TIME == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // SFKEY
                        return "SFKEY";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_DATE
                        return "LW_DATE";
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
                    case "CODE":
                        return 1;
                    case "SFKEY":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_DATE":
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
