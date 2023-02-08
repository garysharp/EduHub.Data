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
    /// Assets - Departments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKDDataSet : EduHubDataSet<AKD>
    {
        /// <inheritdoc />
        public override string Name { get { return "AKD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal AKDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEPARTMENT = new Lazy<Dictionary<string, AKD>>(() => this.ToDictionary(i => i.DEPARTMENT));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKD" /> fields for each CSV column header</returns>
        internal override Action<AKD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DEPARTMENT":
                        mapper[i] = (e, v) => e.DEPARTMENT = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="AKD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AKD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AKD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AKD}"/> of entities</returns>
        internal override IEnumerable<AKD> ApplyDeltaEntities(IEnumerable<AKD> Entities, List<AKD> DeltaEntities)
        {
            HashSet<string> Index_DEPARTMENT = new HashSet<string>(DeltaEntities.Select(i => i.DEPARTMENT));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.DEPARTMENT;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_DEPARTMENT.Remove(entity.DEPARTMENT);
                            
                            if (entity.DEPARTMENT.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, AKD>> Index_DEPARTMENT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKD by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AKD</param>
        /// <returns>Related AKD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKD FindByDEPARTMENT(string DEPARTMENT)
        {
            return Index_DEPARTMENT.Value[DEPARTMENT];
        }

        /// <summary>
        /// Attempt to find AKD by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AKD</param>
        /// <param name="Value">Related AKD entity</param>
        /// <returns>True if the related AKD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEPARTMENT(string DEPARTMENT, out AKD Value)
        {
            return Index_DEPARTMENT.Value.TryGetValue(DEPARTMENT, out Value);
        }

        /// <summary>
        /// Attempt to find AKD by DEPARTMENT field
        /// </summary>
        /// <param name="DEPARTMENT">DEPARTMENT value used to find AKD</param>
        /// <returns>Related AKD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKD TryFindByDEPARTMENT(string DEPARTMENT)
        {
            AKD value;
            if (Index_DEPARTMENT.Value.TryGetValue(DEPARTMENT, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AKD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKD](
        [DEPARTMENT] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKD_Index_DEPARTMENT] PRIMARY KEY CLUSTERED (
            [DEPARTMENT] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="AKDDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="AKDDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AKD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AKD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AKD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_DEPARTMENT = new List<string>();

            foreach (var entity in Entities)
            {
                Index_DEPARTMENT.Add(entity.DEPARTMENT);
            }

            builder.AppendLine("DELETE [dbo].[AKD] WHERE");


            // Index_DEPARTMENT
            builder.Append("[DEPARTMENT] IN (");
            for (int index = 0; index < Index_DEPARTMENT.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // DEPARTMENT
                var parameterDEPARTMENT = $"@p{parameterIndex++}";
                builder.Append(parameterDEPARTMENT);
                command.Parameters.Add(parameterDEPARTMENT, SqlDbType.VarChar, 10).Value = Index_DEPARTMENT[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKD data set</returns>
        public override EduHubDataSetDataReader<AKD> GetDataSetDataReader()
        {
            return new AKDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKD data set</returns>
        public override EduHubDataSetDataReader<AKD> GetDataSetDataReader(List<AKD> Entities)
        {
            return new AKDDataReader(new EduHubDataSetLoadedReader<AKD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKDDataReader : EduHubDataSetDataReader<AKD>
        {
            public AKDDataReader(IEduHubDataSetReader<AKD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // DEPARTMENT
                        return Current.DEPARTMENT;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // LW_DATE
                        return Current.LW_DATE;
                    case 3: // LW_TIME
                        return Current.LW_TIME;
                    case 4: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // LW_DATE
                        return Current.LW_DATE == null;
                    case 3: // LW_TIME
                        return Current.LW_TIME == null;
                    case 4: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // DEPARTMENT
                        return "DEPARTMENT";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "DEPARTMENT":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
