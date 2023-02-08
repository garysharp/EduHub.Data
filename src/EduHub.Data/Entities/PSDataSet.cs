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
    /// Pay Steps or Pay Class Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSDataSet : EduHubDataSet<PS>
    {
        /// <inheritdoc />
        public override string Name { get { return "PS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSKEY = new Lazy<Dictionary<short, PS>>(() => this.ToDictionary(i => i.PSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PS" /> fields for each CSV column header</returns>
        internal override Action<PS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "EFFECTIVE_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MONTHLY_RATE":
                        mapper[i] = (e, v) => e.MONTHLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FORTNIGHTLY_RATE":
                        mapper[i] = (e, v) => e.FORTNIGHTLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_RATE":
                        mapper[i] = (e, v) => e.WEEKLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.STD_WEEKLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_MONTHLY_HOURS":
                        mapper[i] = (e, v) => e.STD_MONTHLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="PS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PS}"/> of entities</returns>
        internal override IEnumerable<PS> ApplyDeltaEntities(IEnumerable<PS> Entities, List<PS> DeltaEntities)
        {
            HashSet<short> Index_PSKEY = new HashSet<short>(DeltaEntities.Select(i => i.PSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PSKEY.Remove(entity.PSKEY);
                            
                            if (entity.PSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<short, PS>> Index_PSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <returns>Related PS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PS FindByPSKEY(short PSKEY)
        {
            return Index_PSKEY.Value[PSKEY];
        }

        /// <summary>
        /// Attempt to find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <param name="Value">Related PS entity</param>
        /// <returns>True if the related PS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSKEY(short PSKEY, out PS Value)
        {
            return Index_PSKEY.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PS by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PS</param>
        /// <returns>Related PS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PS TryFindByPSKEY(short PSKEY)
        {
            PS value;
            if (Index_PSKEY.Value.TryGetValue(PSKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PS](
        [PSKEY] smallint NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [PAY_TYPE] varchar(1) NULL,
        [EFFECTIVE_DATE] datetime NULL,
        [ANNUAL_RATE] money NULL,
        [MONTHLY_RATE] money NULL,
        [FORTNIGHTLY_RATE] money NULL,
        [WEEKLY_RATE] money NULL,
        [HOURLY_RATE] money NULL,
        [STD_WEEKLY_HOURS] money NULL,
        [STD_MONTHLY_HOURS] money NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PS_Index_PSKEY] PRIMARY KEY CLUSTERED (
            [PSKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="PSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="PSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short> Index_PSKEY = new List<short>();

            foreach (var entity in Entities)
            {
                Index_PSKEY.Add(entity.PSKEY);
            }

            builder.AppendLine("DELETE [dbo].[PS] WHERE");


            // Index_PSKEY
            builder.Append("[PSKEY] IN (");
            for (int index = 0; index < Index_PSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PSKEY
                var parameterPSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPSKEY);
                command.Parameters.Add(parameterPSKEY, SqlDbType.SmallInt).Value = Index_PSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PS data set</returns>
        public override EduHubDataSetDataReader<PS> GetDataSetDataReader()
        {
            return new PSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PS data set</returns>
        public override EduHubDataSetDataReader<PS> GetDataSetDataReader(List<PS> Entities)
        {
            return new PSDataReader(new EduHubDataSetLoadedReader<PS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PSDataReader : EduHubDataSetDataReader<PS>
        {
            public PSDataReader(IEduHubDataSetReader<PS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 15; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PSKEY
                        return Current.PSKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // PAY_TYPE
                        return Current.PAY_TYPE;
                    case 3: // EFFECTIVE_DATE
                        return Current.EFFECTIVE_DATE;
                    case 4: // ANNUAL_RATE
                        return Current.ANNUAL_RATE;
                    case 5: // MONTHLY_RATE
                        return Current.MONTHLY_RATE;
                    case 6: // FORTNIGHTLY_RATE
                        return Current.FORTNIGHTLY_RATE;
                    case 7: // WEEKLY_RATE
                        return Current.WEEKLY_RATE;
                    case 8: // HOURLY_RATE
                        return Current.HOURLY_RATE;
                    case 9: // STD_WEEKLY_HOURS
                        return Current.STD_WEEKLY_HOURS;
                    case 10: // STD_MONTHLY_HOURS
                        return Current.STD_MONTHLY_HOURS;
                    case 11: // ACTIVE
                        return Current.ACTIVE;
                    case 12: // LW_DATE
                        return Current.LW_DATE;
                    case 13: // LW_TIME
                        return Current.LW_TIME;
                    case 14: // LW_USER
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
                    case 2: // PAY_TYPE
                        return Current.PAY_TYPE == null;
                    case 3: // EFFECTIVE_DATE
                        return Current.EFFECTIVE_DATE == null;
                    case 4: // ANNUAL_RATE
                        return Current.ANNUAL_RATE == null;
                    case 5: // MONTHLY_RATE
                        return Current.MONTHLY_RATE == null;
                    case 6: // FORTNIGHTLY_RATE
                        return Current.FORTNIGHTLY_RATE == null;
                    case 7: // WEEKLY_RATE
                        return Current.WEEKLY_RATE == null;
                    case 8: // HOURLY_RATE
                        return Current.HOURLY_RATE == null;
                    case 9: // STD_WEEKLY_HOURS
                        return Current.STD_WEEKLY_HOURS == null;
                    case 10: // STD_MONTHLY_HOURS
                        return Current.STD_MONTHLY_HOURS == null;
                    case 11: // ACTIVE
                        return Current.ACTIVE == null;
                    case 12: // LW_DATE
                        return Current.LW_DATE == null;
                    case 13: // LW_TIME
                        return Current.LW_TIME == null;
                    case 14: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PSKEY
                        return "PSKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // PAY_TYPE
                        return "PAY_TYPE";
                    case 3: // EFFECTIVE_DATE
                        return "EFFECTIVE_DATE";
                    case 4: // ANNUAL_RATE
                        return "ANNUAL_RATE";
                    case 5: // MONTHLY_RATE
                        return "MONTHLY_RATE";
                    case 6: // FORTNIGHTLY_RATE
                        return "FORTNIGHTLY_RATE";
                    case 7: // WEEKLY_RATE
                        return "WEEKLY_RATE";
                    case 8: // HOURLY_RATE
                        return "HOURLY_RATE";
                    case 9: // STD_WEEKLY_HOURS
                        return "STD_WEEKLY_HOURS";
                    case 10: // STD_MONTHLY_HOURS
                        return "STD_MONTHLY_HOURS";
                    case 11: // ACTIVE
                        return "ACTIVE";
                    case 12: // LW_DATE
                        return "LW_DATE";
                    case 13: // LW_TIME
                        return "LW_TIME";
                    case 14: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PSKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "PAY_TYPE":
                        return 2;
                    case "EFFECTIVE_DATE":
                        return 3;
                    case "ANNUAL_RATE":
                        return 4;
                    case "MONTHLY_RATE":
                        return 5;
                    case "FORTNIGHTLY_RATE":
                        return 6;
                    case "WEEKLY_RATE":
                        return 7;
                    case "HOURLY_RATE":
                        return 8;
                    case "STD_WEEKLY_HOURS":
                        return 9;
                    case "STD_MONTHLY_HOURS":
                        return 10;
                    case "ACTIVE":
                        return 11;
                    case "LW_DATE":
                        return 12;
                    case "LW_TIME":
                        return 13;
                    case "LW_USER":
                        return 14;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
