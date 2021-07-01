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
    /// Association Member Attendances Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAMADataSet : EduHubDataSet<SAMA>
    {
        /// <inheritdoc />
        public override string Name { get { return "SAMA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SAMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SAMAKEY = new Lazy<Dictionary<int, IReadOnlyList<SAMA>>>(() => this.ToGroupedDictionary(i => i.SAMAKEY));
            Index_SAMAKEY_SCAM_TID = new Lazy<Dictionary<Tuple<int, int?>, SAMA>>(() => this.ToDictionary(i => Tuple.Create(i.SAMAKEY, i.SCAM_TID)));
            Index_TID = new Lazy<Dictionary<int, SAMA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAMA" /> fields for each CSV column header</returns>
        internal override Action<SAMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SAMAKEY":
                        mapper[i] = (e, v) => e.SAMAKEY = int.Parse(v);
                        break;
                    case "SCAM_TID":
                        mapper[i] = (e, v) => e.SCAM_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
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
        /// Merges <see cref="SAMA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SAMA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SAMA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SAMA}"/> of entities</returns>
        internal override IEnumerable<SAMA> ApplyDeltaEntities(IEnumerable<SAMA> Entities, List<SAMA> DeltaEntities)
        {
            HashSet<Tuple<int, int?>> Index_SAMAKEY_SCAM_TID = new HashSet<Tuple<int, int?>>(DeltaEntities.Select(i => Tuple.Create(i.SAMAKEY, i.SCAM_TID)));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SAMAKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_SAMAKEY_SCAM_TID.Remove(Tuple.Create(entity.SAMAKEY, entity.SCAM_TID));
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.SAMAKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, IReadOnlyList<SAMA>>> Index_SAMAKEY;
        private Lazy<Dictionary<Tuple<int, int?>, SAMA>> Index_SAMAKEY_SCAM_TID;
        private Lazy<Dictionary<int, SAMA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <returns>List of related SAMA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAMA> FindBySAMAKEY(int SAMAKEY)
        {
            return Index_SAMAKEY.Value[SAMAKEY];
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="Value">List of related SAMA entities</param>
        /// <returns>True if the list of related SAMA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMAKEY(int SAMAKEY, out IReadOnlyList<SAMA> Value)
        {
            return Index_SAMAKEY.Value.TryGetValue(SAMAKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY field
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <returns>List of related SAMA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAMA> TryFindBySAMAKEY(int SAMAKEY)
        {
            IReadOnlyList<SAMA> value;
            if (Index_SAMAKEY.Value.TryGetValue(SAMAKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <returns>Related SAMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA FindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID)
        {
            return Index_SAMAKEY_SCAM_TID.Value[Tuple.Create(SAMAKEY, SCAM_TID)];
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <param name="Value">Related SAMA entity</param>
        /// <returns>True if the related SAMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID, out SAMA Value)
        {
            return Index_SAMAKEY_SCAM_TID.Value.TryGetValue(Tuple.Create(SAMAKEY, SCAM_TID), out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by SAMAKEY and SCAM_TID fields
        /// </summary>
        /// <param name="SAMAKEY">SAMAKEY value used to find SAMA</param>
        /// <param name="SCAM_TID">SCAM_TID value used to find SAMA</param>
        /// <returns>Related SAMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA TryFindBySAMAKEY_SCAM_TID(int SAMAKEY, int? SCAM_TID)
        {
            SAMA value;
            if (Index_SAMAKEY_SCAM_TID.Value.TryGetValue(Tuple.Create(SAMAKEY, SCAM_TID), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <returns>Related SAMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <param name="Value">Related SAMA entity</param>
        /// <returns>True if the related SAMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAMA</param>
        /// <returns>Related SAMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAMA TryFindByTID(int TID)
        {
            SAMA value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SAMA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAMA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAMA](
        [TID] int IDENTITY NOT NULL,
        [SAMAKEY] int NOT NULL,
        [SCAM_TID] int NULL,
        [ATTENDED] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAMA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SAMA_Index_SAMAKEY] ON [dbo].[SAMA]
    (
            [SAMAKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SAMA_Index_SAMAKEY_SCAM_TID] ON [dbo].[SAMA]
    (
            [SAMAKEY] ASC,
            [SCAM_TID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAMA]') AND name = N'SAMA_Index_SAMAKEY_SCAM_TID')
    ALTER INDEX [SAMA_Index_SAMAKEY_SCAM_TID] ON [dbo].[SAMA] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAMA]') AND name = N'SAMA_Index_TID')
    ALTER INDEX [SAMA_Index_TID] ON [dbo].[SAMA] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAMA]') AND name = N'SAMA_Index_SAMAKEY_SCAM_TID')
    ALTER INDEX [SAMA_Index_SAMAKEY_SCAM_TID] ON [dbo].[SAMA] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAMA]') AND name = N'SAMA_Index_TID')
    ALTER INDEX [SAMA_Index_TID] ON [dbo].[SAMA] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SAMA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SAMA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SAMA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<Tuple<int, int?>> Index_SAMAKEY_SCAM_TID = new List<Tuple<int, int?>>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SAMAKEY_SCAM_TID.Add(Tuple.Create(entity.SAMAKEY, entity.SCAM_TID));
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SAMA] WHERE");


            // Index_SAMAKEY_SCAM_TID
            builder.Append("(");
            for (int index = 0; index < Index_SAMAKEY_SCAM_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(" OR ");

                // SAMAKEY
                var parameterSAMAKEY = $"@p{parameterIndex++}";
                builder.Append("([SAMAKEY]=").Append(parameterSAMAKEY);
                command.Parameters.Add(parameterSAMAKEY, SqlDbType.Int).Value = Index_SAMAKEY_SCAM_TID[index].Item1;

                // SCAM_TID
                if (Index_SAMAKEY_SCAM_TID[index].Item2 == null)
                {
                    builder.Append(" AND [SCAM_TID] IS NULL)");
                }
                else
                {
                    var parameterSCAM_TID = $"@p{parameterIndex++}";
                    builder.Append(" AND [SCAM_TID]=").Append(parameterSCAM_TID).Append(")");
                    command.Parameters.Add(parameterSCAM_TID, SqlDbType.Int).Value = Index_SAMAKEY_SCAM_TID[index].Item2;
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
        /// Provides a <see cref="IDataReader"/> for the SAMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAMA data set</returns>
        public override EduHubDataSetDataReader<SAMA> GetDataSetDataReader()
        {
            return new SAMADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAMA data set</returns>
        public override EduHubDataSetDataReader<SAMA> GetDataSetDataReader(List<SAMA> Entities)
        {
            return new SAMADataReader(new EduHubDataSetLoadedReader<SAMA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAMADataReader : EduHubDataSetDataReader<SAMA>
        {
            public SAMADataReader(IEduHubDataSetReader<SAMA> Reader)
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
                    case 1: // SAMAKEY
                        return Current.SAMAKEY;
                    case 2: // SCAM_TID
                        return Current.SCAM_TID;
                    case 3: // ATTENDED
                        return Current.ATTENDED;
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
                    case 2: // SCAM_TID
                        return Current.SCAM_TID == null;
                    case 3: // ATTENDED
                        return Current.ATTENDED == null;
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
                    case 1: // SAMAKEY
                        return "SAMAKEY";
                    case 2: // SCAM_TID
                        return "SCAM_TID";
                    case 3: // ATTENDED
                        return "ATTENDED";
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
                    case "SAMAKEY":
                        return 1;
                    case "SCAM_TID":
                        return 2;
                    case "ATTENDED":
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
