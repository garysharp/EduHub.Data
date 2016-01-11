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
    /// Leave Management Group Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLGDataSet : EduHubDataSet<PLG>
    {
        /// <inheritdoc />
        public override string Name { get { return "PLG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PLGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LEAVE_GROUP = new Lazy<Dictionary<string, PLG>>(() => this.ToDictionary(i => i.LEAVE_GROUP));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLG" /> fields for each CSV column header</returns>
        internal override Action<PLG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LEAVE_GROUP":
                        mapper[i] = (e, v) => e.LEAVE_GROUP = v;
                        break;
                    case "LEAVE_GROUP_DESC":
                        mapper[i] = (e, v) => e.LEAVE_GROUP_DESC = v;
                        break;
                    case "WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.WEEKLY_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DAILY_HOURS":
                        mapper[i] = (e, v) => e.DAILY_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="PLG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PLG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PLG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PLG}"/> of entities</returns>
        internal override IEnumerable<PLG> ApplyDeltaEntities(IEnumerable<PLG> Entities, List<PLG> DeltaEntities)
        {
            HashSet<string> Index_LEAVE_GROUP = new HashSet<string>(DeltaEntities.Select(i => i.LEAVE_GROUP));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.LEAVE_GROUP;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_LEAVE_GROUP.Remove(entity.LEAVE_GROUP);
                            
                            if (entity.LEAVE_GROUP.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, PLG>> Index_LEAVE_GROUP;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLG FindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            return Index_LEAVE_GROUP.Value[LEAVE_GROUP];
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <param name="Value">Related PLG entity</param>
        /// <returns>True if the related PLG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_GROUP(string LEAVE_GROUP, out PLG Value)
        {
            return Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out Value);
        }

        /// <summary>
        /// Attempt to find PLG by LEAVE_GROUP field
        /// </summary>
        /// <param name="LEAVE_GROUP">LEAVE_GROUP value used to find PLG</param>
        /// <returns>Related PLG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLG TryFindByLEAVE_GROUP(string LEAVE_GROUP)
        {
            PLG value;
            if (Index_LEAVE_GROUP.Value.TryGetValue(LEAVE_GROUP, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PLG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PLG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PLG](
        [LEAVE_GROUP] varchar(8) NOT NULL,
        [LEAVE_GROUP_DESC] varchar(30) NULL,
        [WEEKLY_HOURS] float NULL,
        [DAILY_HOURS] float NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PLG_Index_LEAVE_GROUP] PRIMARY KEY CLUSTERED (
            [LEAVE_GROUP] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="PLGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="PLGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PLG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PLG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PLG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_LEAVE_GROUP = new List<string>();

            foreach (var entity in Entities)
            {
                Index_LEAVE_GROUP.Add(entity.LEAVE_GROUP);
            }

            builder.AppendLine("DELETE [dbo].[PLG] WHERE");


            // Index_LEAVE_GROUP
            builder.Append("[LEAVE_GROUP] IN (");
            for (int index = 0; index < Index_LEAVE_GROUP.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // LEAVE_GROUP
                var parameterLEAVE_GROUP = $"@p{parameterIndex++}";
                builder.Append(parameterLEAVE_GROUP);
                command.Parameters.Add(parameterLEAVE_GROUP, SqlDbType.VarChar, 8).Value = Index_LEAVE_GROUP[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PLG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PLG data set</returns>
        public override EduHubDataSetDataReader<PLG> GetDataSetDataReader()
        {
            return new PLGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PLG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PLG data set</returns>
        public override EduHubDataSetDataReader<PLG> GetDataSetDataReader(List<PLG> Entities)
        {
            return new PLGDataReader(new EduHubDataSetLoadedReader<PLG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PLGDataReader : EduHubDataSetDataReader<PLG>
        {
            public PLGDataReader(IEduHubDataSetReader<PLG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // LEAVE_GROUP
                        return Current.LEAVE_GROUP;
                    case 1: // LEAVE_GROUP_DESC
                        return Current.LEAVE_GROUP_DESC;
                    case 2: // WEEKLY_HOURS
                        return Current.WEEKLY_HOURS;
                    case 3: // DAILY_HOURS
                        return Current.DAILY_HOURS;
                    case 4: // ACTIVE
                        return Current.ACTIVE;
                    case 5: // LW_DATE
                        return Current.LW_DATE;
                    case 6: // LW_TIME
                        return Current.LW_TIME;
                    case 7: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LEAVE_GROUP_DESC
                        return Current.LEAVE_GROUP_DESC == null;
                    case 2: // WEEKLY_HOURS
                        return Current.WEEKLY_HOURS == null;
                    case 3: // DAILY_HOURS
                        return Current.DAILY_HOURS == null;
                    case 4: // ACTIVE
                        return Current.ACTIVE == null;
                    case 5: // LW_DATE
                        return Current.LW_DATE == null;
                    case 6: // LW_TIME
                        return Current.LW_TIME == null;
                    case 7: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // LEAVE_GROUP
                        return "LEAVE_GROUP";
                    case 1: // LEAVE_GROUP_DESC
                        return "LEAVE_GROUP_DESC";
                    case 2: // WEEKLY_HOURS
                        return "WEEKLY_HOURS";
                    case 3: // DAILY_HOURS
                        return "DAILY_HOURS";
                    case 4: // ACTIVE
                        return "ACTIVE";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "LEAVE_GROUP":
                        return 0;
                    case "LEAVE_GROUP_DESC":
                        return 1;
                    case "WEEKLY_HOURS":
                        return 2;
                    case "DAILY_HOURS":
                        return 3;
                    case "ACTIVE":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
