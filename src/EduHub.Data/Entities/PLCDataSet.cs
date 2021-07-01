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
    /// Leave Code Description Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLCDataSet : EduHubDataSet<PLC>
    {
        /// <inheritdoc />
        public override string Name { get { return "PLC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PLCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PLCKEY = new Lazy<Dictionary<string, PLC>>(() => this.ToDictionary(i => i.PLCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLC" /> fields for each CSV column header</returns>
        internal override Action<PLC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLCKEY":
                        mapper[i] = (e, v) => e.PLCKEY = v;
                        break;
                    case "LEAVE_DESC":
                        mapper[i] = (e, v) => e.LEAVE_DESC = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
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
        /// Merges <see cref="PLC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PLC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PLC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PLC}"/> of entities</returns>
        internal override IEnumerable<PLC> ApplyDeltaEntities(IEnumerable<PLC> Entities, List<PLC> DeltaEntities)
        {
            HashSet<string> Index_PLCKEY = new HashSet<string>(DeltaEntities.Select(i => i.PLCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PLCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PLCKEY.Remove(entity.PLCKEY);
                            
                            if (entity.PLCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, PLC>> Index_PLCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLC FindByPLCKEY(string PLCKEY)
        {
            return Index_PLCKEY.Value[PLCKEY];
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <param name="Value">Related PLC entity</param>
        /// <returns>True if the related PLC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLCKEY(string PLCKEY, out PLC Value)
        {
            return Index_PLCKEY.Value.TryGetValue(PLCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLC TryFindByPLCKEY(string PLCKEY)
        {
            PLC value;
            if (Index_PLCKEY.Value.TryGetValue(PLCKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PLC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PLC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PLC](
        [PLCKEY] varchar(8) NOT NULL,
        [LEAVE_DESC] varchar(30) NULL,
        [CATEGORY] varchar(8) NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PLC_Index_PLCKEY] PRIMARY KEY CLUSTERED (
            [PLCKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="PLCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="PLCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PLC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PLC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PLC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_PLCKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_PLCKEY.Add(entity.PLCKEY);
            }

            builder.AppendLine("DELETE [dbo].[PLC] WHERE");


            // Index_PLCKEY
            builder.Append("[PLCKEY] IN (");
            for (int index = 0; index < Index_PLCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PLCKEY
                var parameterPLCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPLCKEY);
                command.Parameters.Add(parameterPLCKEY, SqlDbType.VarChar, 8).Value = Index_PLCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PLC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PLC data set</returns>
        public override EduHubDataSetDataReader<PLC> GetDataSetDataReader()
        {
            return new PLCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PLC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PLC data set</returns>
        public override EduHubDataSetDataReader<PLC> GetDataSetDataReader(List<PLC> Entities)
        {
            return new PLCDataReader(new EduHubDataSetLoadedReader<PLC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PLCDataReader : EduHubDataSetDataReader<PLC>
        {
            public PLCDataReader(IEduHubDataSetReader<PLC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PLCKEY
                        return Current.PLCKEY;
                    case 1: // LEAVE_DESC
                        return Current.LEAVE_DESC;
                    case 2: // CATEGORY
                        return Current.CATEGORY;
                    case 3: // ACTIVE
                        return Current.ACTIVE;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LEAVE_DESC
                        return Current.LEAVE_DESC == null;
                    case 2: // CATEGORY
                        return Current.CATEGORY == null;
                    case 3: // ACTIVE
                        return Current.ACTIVE == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PLCKEY
                        return "PLCKEY";
                    case 1: // LEAVE_DESC
                        return "LEAVE_DESC";
                    case 2: // CATEGORY
                        return "CATEGORY";
                    case 3: // ACTIVE
                        return "ACTIVE";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PLCKEY":
                        return 0;
                    case "LEAVE_DESC":
                        return 1;
                    case "CATEGORY":
                        return 2;
                    case "ACTIVE":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
