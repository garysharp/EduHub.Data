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
    /// Purchase Requisition Transaction Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQTDataSet : EduHubDataSet<RQT>
    {
        /// <inheritdoc />
        public override string Name { get { return "RQT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal RQTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<RQT>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<RQT>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_TID = new Lazy<Dictionary<int, RQT>>(() => this.ToDictionary(i => i.TID));
            Index_TRORDER = new Lazy<Dictionary<int, IReadOnlyList<RQT>>>(() => this.ToGroupedDictionary(i => i.TRORDER));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="RQT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="RQT" /> fields for each CSV column header</returns>
        internal override Action<RQT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<RQT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TRORDER":
                        mapper[i] = (e, v) => e.TRORDER = int.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRCOST":
                        mapper[i] = (e, v) => e.TRCOST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRXCODE":
                        mapper[i] = (e, v) => e.TRXCODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
        /// Merges <see cref="RQT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="RQT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="RQT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{RQT}"/> of entities</returns>
        internal override IEnumerable<RQT> ApplyDeltaEntities(IEnumerable<RQT> Entities, List<RQT> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TRORDER;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TRORDER.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<RQT>>> Index_INITIATIVE;
        private Lazy<NullDictionary<string, IReadOnlyList<RQT>>> Index_SUBPROGRAM;
        private Lazy<Dictionary<int, RQT>> Index_TID;
        private Lazy<Dictionary<int, IReadOnlyList<RQT>>> Index_TRORDER;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find RQT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQT</param>
        /// <returns>List of related RQT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQT> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find RQT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQT</param>
        /// <param name="Value">List of related RQT entities</param>
        /// <returns>True if the list of related RQT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<RQT> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find RQT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find RQT</param>
        /// <returns>List of related RQT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQT> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<RQT> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQT by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQT</param>
        /// <returns>List of related RQT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQT> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find RQT by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQT</param>
        /// <param name="Value">List of related RQT entities</param>
        /// <returns>True if the list of related RQT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<RQT> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find RQT by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find RQT</param>
        /// <returns>List of related RQT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQT> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<RQT> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find RQT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQT</param>
        /// <returns>Related RQT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find RQT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQT</param>
        /// <param name="Value">Related RQT entity</param>
        /// <returns>True if the related RQT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out RQT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find RQT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find RQT</param>
        /// <returns>Related RQT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public RQT TryFindByTID(int TID)
        {
            RQT value;
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
        /// Find RQT by TRORDER field
        /// </summary>
        /// <param name="TRORDER">TRORDER value used to find RQT</param>
        /// <returns>List of related RQT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQT> FindByTRORDER(int TRORDER)
        {
            return Index_TRORDER.Value[TRORDER];
        }

        /// <summary>
        /// Attempt to find RQT by TRORDER field
        /// </summary>
        /// <param name="TRORDER">TRORDER value used to find RQT</param>
        /// <param name="Value">List of related RQT entities</param>
        /// <returns>True if the list of related RQT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRORDER(int TRORDER, out IReadOnlyList<RQT> Value)
        {
            return Index_TRORDER.Value.TryGetValue(TRORDER, out Value);
        }

        /// <summary>
        /// Attempt to find RQT by TRORDER field
        /// </summary>
        /// <param name="TRORDER">TRORDER value used to find RQT</param>
        /// <returns>List of related RQT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<RQT> TryFindByTRORDER(int TRORDER)
        {
            IReadOnlyList<RQT> value;
            if (Index_TRORDER.Value.TryGetValue(TRORDER, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a RQT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[RQT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[RQT](
        [TID] int IDENTITY NOT NULL,
        [TRORDER] int NOT NULL,
        [TRDET] varchar(30) NULL,
        [TRQTY] int NULL,
        [TRCOST] money NULL,
        [TRAMT] money NULL,
        [TRXCODE] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [RQT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [RQT_Index_INITIATIVE] ON [dbo].[RQT]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [RQT_Index_SUBPROGRAM] ON [dbo].[RQT]
    (
            [SUBPROGRAM] ASC
    );
    CREATE CLUSTERED INDEX [RQT_Index_TRORDER] ON [dbo].[RQT]
    (
            [TRORDER] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQT]') AND name = N'RQT_Index_INITIATIVE')
    ALTER INDEX [RQT_Index_INITIATIVE] ON [dbo].[RQT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQT]') AND name = N'RQT_Index_SUBPROGRAM')
    ALTER INDEX [RQT_Index_SUBPROGRAM] ON [dbo].[RQT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQT]') AND name = N'RQT_Index_TID')
    ALTER INDEX [RQT_Index_TID] ON [dbo].[RQT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQT]') AND name = N'RQT_Index_INITIATIVE')
    ALTER INDEX [RQT_Index_INITIATIVE] ON [dbo].[RQT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQT]') AND name = N'RQT_Index_SUBPROGRAM')
    ALTER INDEX [RQT_Index_SUBPROGRAM] ON [dbo].[RQT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[RQT]') AND name = N'RQT_Index_TID')
    ALTER INDEX [RQT_Index_TID] ON [dbo].[RQT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="RQT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="RQT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<RQT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[RQT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the RQT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQT data set</returns>
        public override EduHubDataSetDataReader<RQT> GetDataSetDataReader()
        {
            return new RQTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the RQT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the RQT data set</returns>
        public override EduHubDataSetDataReader<RQT> GetDataSetDataReader(List<RQT> Entities)
        {
            return new RQTDataReader(new EduHubDataSetLoadedReader<RQT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class RQTDataReader : EduHubDataSetDataReader<RQT>
        {
            public RQTDataReader(IEduHubDataSetReader<RQT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 12; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // TRORDER
                        return Current.TRORDER;
                    case 2: // TRDET
                        return Current.TRDET;
                    case 3: // TRQTY
                        return Current.TRQTY;
                    case 4: // TRCOST
                        return Current.TRCOST;
                    case 5: // TRAMT
                        return Current.TRAMT;
                    case 6: // TRXCODE
                        return Current.TRXCODE;
                    case 7: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 8: // INITIATIVE
                        return Current.INITIATIVE;
                    case 9: // LW_DATE
                        return Current.LW_DATE;
                    case 10: // LW_TIME
                        return Current.LW_TIME;
                    case 11: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // TRDET
                        return Current.TRDET == null;
                    case 3: // TRQTY
                        return Current.TRQTY == null;
                    case 4: // TRCOST
                        return Current.TRCOST == null;
                    case 5: // TRAMT
                        return Current.TRAMT == null;
                    case 6: // TRXCODE
                        return Current.TRXCODE == null;
                    case 7: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 8: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 9: // LW_DATE
                        return Current.LW_DATE == null;
                    case 10: // LW_TIME
                        return Current.LW_TIME == null;
                    case 11: // LW_USER
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
                    case 1: // TRORDER
                        return "TRORDER";
                    case 2: // TRDET
                        return "TRDET";
                    case 3: // TRQTY
                        return "TRQTY";
                    case 4: // TRCOST
                        return "TRCOST";
                    case 5: // TRAMT
                        return "TRAMT";
                    case 6: // TRXCODE
                        return "TRXCODE";
                    case 7: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 8: // INITIATIVE
                        return "INITIATIVE";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
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
                    case "TRORDER":
                        return 1;
                    case "TRDET":
                        return 2;
                    case "TRQTY":
                        return 3;
                    case "TRCOST":
                        return 4;
                    case "TRAMT":
                        return 5;
                    case "TRXCODE":
                        return 6;
                    case "SUBPROGRAM":
                        return 7;
                    case "INITIATIVE":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
