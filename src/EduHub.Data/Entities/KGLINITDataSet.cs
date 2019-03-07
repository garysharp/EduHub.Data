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
    /// General Ledger Initiatives Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLINITDataSet : EduHubDataSet<KGLINIT>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGLINIT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGLINITDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INITIATIVE = new Lazy<Dictionary<string, KGLINIT>>(() => this.ToDictionary(i => i.INITIATIVE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLINIT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLINIT" /> fields for each CSV column header</returns>
        internal override Action<KGLINIT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLINIT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="KGLINIT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGLINIT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGLINIT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGLINIT}"/> of entities</returns>
        internal override IEnumerable<KGLINIT> ApplyDeltaEntities(IEnumerable<KGLINIT> Entities, List<KGLINIT> DeltaEntities)
        {
            HashSet<string> Index_INITIATIVE = new HashSet<string>(DeltaEntities.Select(i => i.INITIATIVE));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.INITIATIVE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_INITIATIVE.Remove(entity.INITIATIVE);
                            
                            if (entity.INITIATIVE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGLINIT>> Index_INITIATIVE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLINIT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find KGLINIT</param>
        /// <returns>Related KGLINIT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLINIT FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find KGLINIT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find KGLINIT</param>
        /// <param name="Value">Related KGLINIT entity</param>
        /// <returns>True if the related KGLINIT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out KGLINIT Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find KGLINIT by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find KGLINIT</param>
        /// <returns>Related KGLINIT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLINIT TryFindByINITIATIVE(string INITIATIVE)
        {
            KGLINIT value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGLINIT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGLINIT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGLINIT](
        [INITIATIVE] varchar(3) NOT NULL,
        [TITLE] varchar(50) NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGLINIT_Index_INITIATIVE] PRIMARY KEY CLUSTERED (
            [INITIATIVE] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KGLINITDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KGLINITDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGLINIT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGLINIT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGLINIT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_INITIATIVE = new List<string>();

            foreach (var entity in Entities)
            {
                Index_INITIATIVE.Add(entity.INITIATIVE);
            }

            builder.AppendLine("DELETE [dbo].[KGLINIT] WHERE");


            // Index_INITIATIVE
            builder.Append("[INITIATIVE] IN (");
            for (int index = 0; index < Index_INITIATIVE.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // INITIATIVE
                var parameterINITIATIVE = $"@p{parameterIndex++}";
                builder.Append(parameterINITIATIVE);
                command.Parameters.Add(parameterINITIATIVE, SqlDbType.VarChar, 3).Value = Index_INITIATIVE[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLINIT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLINIT data set</returns>
        public override EduHubDataSetDataReader<KGLINIT> GetDataSetDataReader()
        {
            return new KGLINITDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLINIT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLINIT data set</returns>
        public override EduHubDataSetDataReader<KGLINIT> GetDataSetDataReader(List<KGLINIT> Entities)
        {
            return new KGLINITDataReader(new EduHubDataSetLoadedReader<KGLINIT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGLINITDataReader : EduHubDataSetDataReader<KGLINIT>
        {
            public KGLINITDataReader(IEduHubDataSetReader<KGLINIT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // INITIATIVE
                        return Current.INITIATIVE;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // ACTIVE
                        return Current.ACTIVE;
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
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // ACTIVE
                        return Current.ACTIVE == null;
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
                    case 0: // INITIATIVE
                        return "INITIATIVE";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // ACTIVE
                        return "ACTIVE";
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
                    case "INITIATIVE":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "ACTIVE":
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
