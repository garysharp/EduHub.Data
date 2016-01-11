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
    /// Financial Commitments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFBANKDataSet : EduHubDataSet<GLFBANK>
    {
        /// <inheritdoc />
        public override string Name { get { return "GLFBANK"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal GLFBANKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<GLFBANK>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_FUND_ID = new Lazy<NullDictionary<short?, GLFBANK>>(() => this.ToNullDictionary(i => i.FUND_ID));
            Index_TID = new Lazy<Dictionary<int, GLFBANK>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLFBANK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLFBANK" /> fields for each CSV column header</returns>
        internal override Action<GLFBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLFBANK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "FUND_ID":
                        mapper[i] = (e, v) => e.FUND_ID = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TIME_FRAME":
                        mapper[i] = (e, v) => e.TIME_FRAME = v;
                        break;
                    case "LY_AMOUNT":
                        mapper[i] = (e, v) => e.LY_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_TIME_FRAME":
                        mapper[i] = (e, v) => e.LY_TIME_FRAME = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="GLFBANK" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="GLFBANK" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="GLFBANK" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{GLFBANK}"/> of entities</returns>
        internal override IEnumerable<GLFBANK> ApplyDeltaEntities(IEnumerable<GLFBANK> Entities, List<GLFBANK> DeltaEntities)
        {
            HashSet<short?> Index_FUND_ID = new HashSet<short?>(DeltaEntities.Select(i => i.FUND_ID));
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
                            overwritten = overwritten || Index_FUND_ID.Remove(entity.FUND_ID);
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

        private Lazy<Dictionary<string, IReadOnlyList<GLFBANK>>> Index_CODE;
        private Lazy<NullDictionary<short?, GLFBANK>> Index_FUND_ID;
        private Lazy<Dictionary<int, GLFBANK>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <returns>List of related GLFBANK entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBANK> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <param name="Value">List of related GLFBANK entities</param>
        /// <returns>True if the list of related GLFBANK entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLFBANK> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <returns>List of related GLFBANK entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBANK> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLFBANK> value;
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
        /// Find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK FindByFUND_ID(short? FUND_ID)
        {
            return Index_FUND_ID.Value[FUND_ID];
        }

        /// <summary>
        /// Attempt to find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <param name="Value">Related GLFBANK entity</param>
        /// <returns>True if the related GLFBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFUND_ID(short? FUND_ID, out GLFBANK Value)
        {
            return Index_FUND_ID.Value.TryGetValue(FUND_ID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK TryFindByFUND_ID(short? FUND_ID)
        {
            GLFBANK value;
            if (Index_FUND_ID.Value.TryGetValue(FUND_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <param name="Value">Related GLFBANK entity</param>
        /// <returns>True if the related GLFBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLFBANK Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK TryFindByTID(int TID)
        {
            GLFBANK value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a GLFBANK table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GLFBANK]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GLFBANK](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [FUND_ID] smallint NULL,
        [DESCRIPTION] varchar(50) NULL,
        [AMOUNT] money NULL,
        [TIME_FRAME] varchar(1) NULL,
        [LY_AMOUNT] money NULL,
        [LY_TIME_FRAME] varchar(1) NULL,
        [TRBATCH] smallint NULL,
        [TRAMT] money NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GLFBANK_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [GLFBANK_Index_CODE] ON [dbo].[GLFBANK]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [GLFBANK_Index_FUND_ID] ON [dbo].[GLFBANK]
    (
            [FUND_ID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLFBANK]') AND name = N'Index_FUND_ID')
    ALTER INDEX [Index_FUND_ID] ON [dbo].[GLFBANK] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLFBANK]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[GLFBANK] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLFBANK]') AND name = N'Index_FUND_ID')
    ALTER INDEX [Index_FUND_ID] ON [dbo].[GLFBANK] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[GLFBANK]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[GLFBANK] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="GLFBANK"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="GLFBANK"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<GLFBANK> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short?> Index_FUND_ID = new List<short?>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_FUND_ID.Add(entity.FUND_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[GLFBANK] WHERE");


            // Index_FUND_ID
            builder.Append("[FUND_ID] IN (");
            for (int index = 0; index < Index_FUND_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // FUND_ID
                var parameterFUND_ID = $"@p{parameterIndex++}";
                builder.Append(parameterFUND_ID);
                command.Parameters.Add(parameterFUND_ID, SqlDbType.SmallInt).Value = (object)Index_FUND_ID[index] ?? DBNull.Value;
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
        /// Provides a <see cref="IDataReader"/> for the GLFBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLFBANK data set</returns>
        public override EduHubDataSetDataReader<GLFBANK> GetDataSetDataReader()
        {
            return new GLFBANKDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GLFBANK data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GLFBANK data set</returns>
        public override EduHubDataSetDataReader<GLFBANK> GetDataSetDataReader(List<GLFBANK> Entities)
        {
            return new GLFBANKDataReader(new EduHubDataSetLoadedReader<GLFBANK>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLFBANKDataReader : EduHubDataSetDataReader<GLFBANK>
        {
            public GLFBANKDataReader(IEduHubDataSetReader<GLFBANK> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // FUND_ID
                        return Current.FUND_ID;
                    case 3: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 4: // AMOUNT
                        return Current.AMOUNT;
                    case 5: // TIME_FRAME
                        return Current.TIME_FRAME;
                    case 6: // LY_AMOUNT
                        return Current.LY_AMOUNT;
                    case 7: // LY_TIME_FRAME
                        return Current.LY_TIME_FRAME;
                    case 8: // TRBATCH
                        return Current.TRBATCH;
                    case 9: // TRAMT
                        return Current.TRAMT;
                    case 10: // LW_DATE
                        return Current.LW_DATE;
                    case 11: // LW_TIME
                        return Current.LW_TIME;
                    case 12: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // FUND_ID
                        return Current.FUND_ID == null;
                    case 3: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 4: // AMOUNT
                        return Current.AMOUNT == null;
                    case 5: // TIME_FRAME
                        return Current.TIME_FRAME == null;
                    case 6: // LY_AMOUNT
                        return Current.LY_AMOUNT == null;
                    case 7: // LY_TIME_FRAME
                        return Current.LY_TIME_FRAME == null;
                    case 8: // TRBATCH
                        return Current.TRBATCH == null;
                    case 9: // TRAMT
                        return Current.TRAMT == null;
                    case 10: // LW_DATE
                        return Current.LW_DATE == null;
                    case 11: // LW_TIME
                        return Current.LW_TIME == null;
                    case 12: // LW_USER
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
                    case 2: // FUND_ID
                        return "FUND_ID";
                    case 3: // DESCRIPTION
                        return "DESCRIPTION";
                    case 4: // AMOUNT
                        return "AMOUNT";
                    case 5: // TIME_FRAME
                        return "TIME_FRAME";
                    case 6: // LY_AMOUNT
                        return "LY_AMOUNT";
                    case 7: // LY_TIME_FRAME
                        return "LY_TIME_FRAME";
                    case 8: // TRBATCH
                        return "TRBATCH";
                    case 9: // TRAMT
                        return "TRAMT";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
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
                    case "FUND_ID":
                        return 2;
                    case "DESCRIPTION":
                        return 3;
                    case "AMOUNT":
                        return 4;
                    case "TIME_FRAME":
                        return 5;
                    case "LY_AMOUNT":
                        return 6;
                    case "LY_TIME_FRAME":
                        return 7;
                    case "TRBATCH":
                        return 8;
                    case "TRAMT":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
