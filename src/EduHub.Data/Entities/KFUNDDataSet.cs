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
    /// GL Bank Fund Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KFUNDDataSet : EduHubDataSet<KFUND>
    {
        /// <inheritdoc />
        public override string Name { get { return "KFUND"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KFUNDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FUND_ID = new Lazy<Dictionary<short, KFUND>>(() => this.ToDictionary(i => i.FUND_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KFUND" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KFUND" /> fields for each CSV column header</returns>
        internal override Action<KFUND, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KFUND, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "FUND_ID":
                        mapper[i] = (e, v) => e.FUND_ID = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="KFUND" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KFUND" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KFUND" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KFUND}"/> of entities</returns>
        internal override IEnumerable<KFUND> ApplyDeltaEntities(IEnumerable<KFUND> Entities, List<KFUND> DeltaEntities)
        {
            HashSet<short> Index_FUND_ID = new HashSet<short>(DeltaEntities.Select(i => i.FUND_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.FUND_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_FUND_ID.Remove(entity.FUND_ID);
                            
                            if (entity.FUND_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<short, KFUND>> Index_FUND_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KFUND by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find KFUND</param>
        /// <returns>Related KFUND entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFUND FindByFUND_ID(short FUND_ID)
        {
            return Index_FUND_ID.Value[FUND_ID];
        }

        /// <summary>
        /// Attempt to find KFUND by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find KFUND</param>
        /// <param name="Value">Related KFUND entity</param>
        /// <returns>True if the related KFUND entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFUND_ID(short FUND_ID, out KFUND Value)
        {
            return Index_FUND_ID.Value.TryGetValue(FUND_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KFUND by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find KFUND</param>
        /// <returns>Related KFUND entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFUND TryFindByFUND_ID(short FUND_ID)
        {
            KFUND value;
            if (Index_FUND_ID.Value.TryGetValue(FUND_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KFUND table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KFUND]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KFUND](
        [FUND_ID] smallint NOT NULL,
        [DESCRIPTION] varchar(50) NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KFUND_Index_FUND_ID] PRIMARY KEY CLUSTERED (
            [FUND_ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KFUNDDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KFUNDDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KFUND"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KFUND"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KFUND> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short> Index_FUND_ID = new List<short>();

            foreach (var entity in Entities)
            {
                Index_FUND_ID.Add(entity.FUND_ID);
            }

            builder.AppendLine("DELETE [dbo].[KFUND] WHERE");


            // Index_FUND_ID
            builder.Append("[FUND_ID] IN (");
            for (int index = 0; index < Index_FUND_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // FUND_ID
                var parameterFUND_ID = $"@p{parameterIndex++}";
                builder.Append(parameterFUND_ID);
                command.Parameters.Add(parameterFUND_ID, SqlDbType.SmallInt).Value = Index_FUND_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KFUND data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KFUND data set</returns>
        public override EduHubDataSetDataReader<KFUND> GetDataSetDataReader()
        {
            return new KFUNDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KFUND data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KFUND data set</returns>
        public override EduHubDataSetDataReader<KFUND> GetDataSetDataReader(List<KFUND> Entities)
        {
            return new KFUNDDataReader(new EduHubDataSetLoadedReader<KFUND>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KFUNDDataReader : EduHubDataSetDataReader<KFUND>
        {
            public KFUNDDataReader(IEduHubDataSetReader<KFUND> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // FUND_ID
                        return Current.FUND_ID;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
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
                    case 0: // FUND_ID
                        return "FUND_ID";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
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
                    case "FUND_ID":
                        return 0;
                    case "DESCRIPTION":
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
