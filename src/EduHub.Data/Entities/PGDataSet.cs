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
    /// PAYG Payment Summary Box Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PGDataSet : EduHubDataSet<PG>
    {
        /// <inheritdoc />
        public override string Name { get { return "PG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PAYG_BOX = new Lazy<Dictionary<short, PG>>(() => this.ToDictionary(i => i.PAYG_BOX));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PG" /> fields for each CSV column header</returns>
        internal override Action<PG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PAYG_BOX":
                        mapper[i] = (e, v) => e.PAYG_BOX = short.Parse(v);
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
        /// Merges <see cref="PG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PG}"/> of entities</returns>
        internal override IEnumerable<PG> ApplyDeltaEntities(IEnumerable<PG> Entities, List<PG> DeltaEntities)
        {
            HashSet<short> Index_PAYG_BOX = new HashSet<short>(DeltaEntities.Select(i => i.PAYG_BOX));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PAYG_BOX;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PAYG_BOX.Remove(entity.PAYG_BOX);
                            
                            if (entity.PAYG_BOX.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<short, PG>> Index_PAYG_BOX;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <returns>Related PG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PG FindByPAYG_BOX(short PAYG_BOX)
        {
            return Index_PAYG_BOX.Value[PAYG_BOX];
        }

        /// <summary>
        /// Attempt to find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <param name="Value">Related PG entity</param>
        /// <returns>True if the related PG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYG_BOX(short PAYG_BOX, out PG Value)
        {
            return Index_PAYG_BOX.Value.TryGetValue(PAYG_BOX, out Value);
        }

        /// <summary>
        /// Attempt to find PG by PAYG_BOX field
        /// </summary>
        /// <param name="PAYG_BOX">PAYG_BOX value used to find PG</param>
        /// <returns>Related PG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PG TryFindByPAYG_BOX(short PAYG_BOX)
        {
            PG value;
            if (Index_PAYG_BOX.Value.TryGetValue(PAYG_BOX, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PG](
        [PAYG_BOX] smallint NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PG_Index_PAYG_BOX] PRIMARY KEY CLUSTERED (
            [PAYG_BOX] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="PGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="PGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short> Index_PAYG_BOX = new List<short>();

            foreach (var entity in Entities)
            {
                Index_PAYG_BOX.Add(entity.PAYG_BOX);
            }

            builder.AppendLine("DELETE [dbo].[PG] WHERE");


            // Index_PAYG_BOX
            builder.Append("[PAYG_BOX] IN (");
            for (int index = 0; index < Index_PAYG_BOX.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PAYG_BOX
                var parameterPAYG_BOX = $"@p{parameterIndex++}";
                builder.Append(parameterPAYG_BOX);
                command.Parameters.Add(parameterPAYG_BOX, SqlDbType.SmallInt).Value = Index_PAYG_BOX[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PG data set</returns>
        public override EduHubDataSetDataReader<PG> GetDataSetDataReader()
        {
            return new PGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PG data set</returns>
        public override EduHubDataSetDataReader<PG> GetDataSetDataReader(List<PG> Entities)
        {
            return new PGDataReader(new EduHubDataSetLoadedReader<PG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PGDataReader : EduHubDataSetDataReader<PG>
        {
            public PGDataReader(IEduHubDataSetReader<PG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PAYG_BOX
                        return Current.PAYG_BOX;
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
                    case 0: // PAYG_BOX
                        return "PAYG_BOX";
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
                    case "PAYG_BOX":
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
