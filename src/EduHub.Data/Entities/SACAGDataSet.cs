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
    public sealed partial class SACAGDataSet : EduHubDataSet<SACAG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SACAG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SACAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SACAG_ID = new Lazy<Dictionary<int, SACAG>>(() => this.ToDictionary(i => i.SACAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SACAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SACAG" /> fields for each CSV column header</returns>
        internal override Action<SACAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SACAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SACAG_ID":
                        mapper[i] = (e, v) => e.SACAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "UNAPPROVED":
                        mapper[i] = (e, v) => e.UNAPPROVED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "APPROVED":
                        mapper[i] = (e, v) => e.APPROVED = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SACAG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SACAG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SACAG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SACAG}"/> of entities</returns>
        internal override IEnumerable<SACAG> ApplyDeltaEntities(IEnumerable<SACAG> Entities, List<SACAG> DeltaEntities)
        {
            HashSet<int> Index_SACAG_ID = new HashSet<int>(DeltaEntities.Select(i => i.SACAG_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SACAG_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SACAG_ID.Remove(entity.SACAG_ID);
                            
                            if (entity.SACAG_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SACAG>> Index_SACAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <returns>Related SACAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SACAG FindBySACAG_ID(int SACAG_ID)
        {
            return Index_SACAG_ID.Value[SACAG_ID];
        }

        /// <summary>
        /// Attempt to find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <param name="Value">Related SACAG entity</param>
        /// <returns>True if the related SACAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySACAG_ID(int SACAG_ID, out SACAG Value)
        {
            return Index_SACAG_ID.Value.TryGetValue(SACAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SACAG by SACAG_ID field
        /// </summary>
        /// <param name="SACAG_ID">SACAG_ID value used to find SACAG</param>
        /// <returns>Related SACAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SACAG TryFindBySACAG_ID(int SACAG_ID)
        {
            SACAG value;
            if (Index_SACAG_ID.Value.TryGetValue(SACAG_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SACAG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SACAG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SACAG](
        [SACAG_ID] int IDENTITY NOT NULL,
        [BRY] smallint NULL,
        [SCHOOL_YEAR] varchar(2) NULL,
        [SEMESTER] smallint NULL,
        [COHORT] varchar(2) NULL,
        [FTE] float NULL,
        [UNAPPROVED] float NULL,
        [APPROVED] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SACAG_Index_SACAG_ID] PRIMARY KEY CLUSTERED (
            [SACAG_ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SACAGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SACAGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SACAG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SACAG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SACAG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SACAG_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SACAG_ID.Add(entity.SACAG_ID);
            }

            builder.AppendLine("DELETE [dbo].[SACAG] WHERE");


            // Index_SACAG_ID
            builder.Append("[SACAG_ID] IN (");
            for (int index = 0; index < Index_SACAG_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SACAG_ID
                var parameterSACAG_ID = $"@p{parameterIndex++}";
                builder.Append(parameterSACAG_ID);
                command.Parameters.Add(parameterSACAG_ID, SqlDbType.Int).Value = Index_SACAG_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SACAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SACAG data set</returns>
        public override EduHubDataSetDataReader<SACAG> GetDataSetDataReader()
        {
            return new SACAGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SACAG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SACAG data set</returns>
        public override EduHubDataSetDataReader<SACAG> GetDataSetDataReader(List<SACAG> Entities)
        {
            return new SACAGDataReader(new EduHubDataSetLoadedReader<SACAG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SACAGDataReader : EduHubDataSetDataReader<SACAG>
        {
            public SACAGDataReader(IEduHubDataSetReader<SACAG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SACAG_ID
                        return Current.SACAG_ID;
                    case 1: // BRY
                        return Current.BRY;
                    case 2: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR;
                    case 3: // SEMESTER
                        return Current.SEMESTER;
                    case 4: // COHORT
                        return Current.COHORT;
                    case 5: // FTE
                        return Current.FTE;
                    case 6: // UNAPPROVED
                        return Current.UNAPPROVED;
                    case 7: // APPROVED
                        return Current.APPROVED;
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
                    case 1: // BRY
                        return Current.BRY == null;
                    case 2: // SCHOOL_YEAR
                        return Current.SCHOOL_YEAR == null;
                    case 3: // SEMESTER
                        return Current.SEMESTER == null;
                    case 4: // COHORT
                        return Current.COHORT == null;
                    case 5: // FTE
                        return Current.FTE == null;
                    case 6: // UNAPPROVED
                        return Current.UNAPPROVED == null;
                    case 7: // APPROVED
                        return Current.APPROVED == null;
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
                    case 0: // SACAG_ID
                        return "SACAG_ID";
                    case 1: // BRY
                        return "BRY";
                    case 2: // SCHOOL_YEAR
                        return "SCHOOL_YEAR";
                    case 3: // SEMESTER
                        return "SEMESTER";
                    case 4: // COHORT
                        return "COHORT";
                    case 5: // FTE
                        return "FTE";
                    case 6: // UNAPPROVED
                        return "UNAPPROVED";
                    case 7: // APPROVED
                        return "APPROVED";
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
                    case "SACAG_ID":
                        return 0;
                    case "BRY":
                        return 1;
                    case "SCHOOL_YEAR":
                        return 2;
                    case "SEMESTER":
                        return 3;
                    case "COHORT":
                        return 4;
                    case "FTE":
                        return 5;
                    case "UNAPPROVED":
                        return 6;
                    case "APPROVED":
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
