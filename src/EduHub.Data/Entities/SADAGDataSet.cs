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
    /// Absence by Cohort Aggregations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADAGDataSet : EduHubDataSet<SADAG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SADAG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SADAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SADAG_ID = new Lazy<Dictionary<int, SADAG>>(() => this.ToDictionary(i => i.SADAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADAG" /> fields for each CSV column header</returns>
        internal override Action<SADAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SADAG_ID":
                        mapper[i] = (e, v) => e.SADAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABS_CODE":
                        mapper[i] = (e, v) => e.ABS_CODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAYS":
                        mapper[i] = (e, v) => e.DAYS = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SADAG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SADAG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SADAG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SADAG}"/> of entities</returns>
        internal override IEnumerable<SADAG> ApplyDeltaEntities(IEnumerable<SADAG> Entities, List<SADAG> DeltaEntities)
        {
            HashSet<int> Index_SADAG_ID = new HashSet<int>(DeltaEntities.Select(i => i.SADAG_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SADAG_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SADAG_ID.Remove(entity.SADAG_ID);
                            
                            if (entity.SADAG_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SADAG>> Index_SADAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <returns>Related SADAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADAG FindBySADAG_ID(int SADAG_ID)
        {
            return Index_SADAG_ID.Value[SADAG_ID];
        }

        /// <summary>
        /// Attempt to find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <param name="Value">Related SADAG entity</param>
        /// <returns>True if the related SADAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySADAG_ID(int SADAG_ID, out SADAG Value)
        {
            return Index_SADAG_ID.Value.TryGetValue(SADAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <returns>Related SADAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADAG TryFindBySADAG_ID(int SADAG_ID)
        {
            SADAG value;
            if (Index_SADAG_ID.Value.TryGetValue(SADAG_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SADAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SADAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SADAG](
        [SADAG_ID] int IDENTITY NOT NULL,
        [BRY] smallint NULL,
        [SCHOOL_YEAR] varchar(2) NULL,
        [FTE] float NULL,
        [ABS_CODE] smallint NULL,
        [DAYS] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SADAG_Index_SADAG_ID] PRIMARY KEY CLUSTERED (
            [SADAG_ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SADAGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SADAGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SADAG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SADAG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SADAG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SADAG_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SADAG_ID.Add(entity.SADAG_ID);
            }

            builder.AppendLine("DELETE [dbo].[SADAG] WHERE");


            // Index_SADAG_ID
            builder.Append("[SADAG_ID] IN (");
            for (int index = 0; index < Index_SADAG_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SADAG_ID
                var parameterSADAG_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSADAG_ID);
                command.Parameters.Add(parameterSADAG_ID, SqlDbType.Int).Value = Index_SADAG_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SADAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADAG data set</returns>
        public override EduHubDataSetDataReader<SADAG> GetDataSetDataReader()
        {
            return new SADAGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SADAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SADAG data set</returns>
        public override EduHubDataSetDataReader<SADAG> GetDataSetDataReader(List<SADAG> Entities)
        {
            return new SADAGDataReader(new EduHubDataSetLoadedReader<SADAG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SADAGDataReader : EduHubDataSetDataReader<SADAG>
        {
            public SADAGDataReader(IEduHubDataSetReader<SADAG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SADAG_ID
                        return Current.SADAG_ID;
                    case 1: // BRY
                        return Current.BRY;
                    case 2: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 3: // FTE
                        return Current.FTE;
                    case 4: // ABS_CODE
                        return Current.ABS_CODE;
                    case 5: // DAYS
                        return Current.DAYS;
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
                    case 1: // BRY
                        return Current.BRY == null;
                    case 2: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 3: // FTE
                        return Current.FTE == null;
                    case 4: // ABS_CODE
                        return Current.ABS_CODE == null;
                    case 5: // DAYS
                        return Current.DAYS == null;
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
                    case 0: // SADAG_ID
                        return "SADAG_ID";
                    case 1: // BRY
                        return "BRY";
                    case 2: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 3: // FTE
                        return "FTE";
                    case 4: // ABS_CODE
                        return "ABS_CODE";
                    case 5: // DAYS
                        return "DAYS";
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
                    case "SADAG_ID":
                        return 0;
                    case "BRY":
                        return 1;
                    case "SCHOOL_YEAR":
                        return 2;
                    case "FTE":
                        return 3;
                    case "ABS_CODE":
                        return 4;
                    case "DAYS":
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
