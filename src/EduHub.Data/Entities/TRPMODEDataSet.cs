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
    /// Transport Modes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TRPMODEDataSet : EduHubDataSet<TRPMODE>
    {
        /// <inheritdoc />
        public override string Name { get { return "TRPMODE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TRPMODEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TRANSPORT_MODE_ID = new Lazy<Dictionary<int, TRPMODE>>(() => this.ToDictionary(i => i.TRANSPORT_MODE_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TRPMODE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TRPMODE" /> fields for each CSV column header</returns>
        internal override Action<TRPMODE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TRPMODE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TRANSPORT_MODE_ID":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_ID = int.Parse(v);
                        break;
                    case "TRANSPORT_MODE_DESC":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_DESC = v;
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
        /// Merges <see cref="TRPMODE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TRPMODE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TRPMODE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TRPMODE}"/> of entities</returns>
        internal override IEnumerable<TRPMODE> ApplyDeltaEntities(IEnumerable<TRPMODE> Entities, List<TRPMODE> DeltaEntities)
        {
            HashSet<int> Index_TRANSPORT_MODE_ID = new HashSet<int>(DeltaEntities.Select(i => i.TRANSPORT_MODE_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TRANSPORT_MODE_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TRANSPORT_MODE_ID.Remove(entity.TRANSPORT_MODE_ID);
                            
                            if (entity.TRANSPORT_MODE_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, TRPMODE>> Index_TRANSPORT_MODE_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TRPMODE by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRPMODE FindByTRANSPORT_MODE_ID(int TRANSPORT_MODE_ID)
        {
            return Index_TRANSPORT_MODE_ID.Value[TRANSPORT_MODE_ID];
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <param name="Value">Related TRPMODE entity</param>
        /// <returns>True if the related TRPMODE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRANSPORT_MODE_ID(int TRANSPORT_MODE_ID, out TRPMODE Value)
        {
            return Index_TRANSPORT_MODE_ID.Value.TryGetValue(TRANSPORT_MODE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRPMODE TryFindByTRANSPORT_MODE_ID(int TRANSPORT_MODE_ID)
        {
            TRPMODE value;
            if (Index_TRANSPORT_MODE_ID.Value.TryGetValue(TRANSPORT_MODE_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TRPMODE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TRPMODE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TRPMODE](
        [TRANSPORT_MODE_ID] int IDENTITY NOT NULL,
        [TRANSPORT_MODE_DESC] varchar(60) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TRPMODE_Index_TRANSPORT_MODE_ID] PRIMARY KEY CLUSTERED (
            [TRANSPORT_MODE_ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="TRPMODEDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="TRPMODEDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TRPMODE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TRPMODE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TRPMODE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TRANSPORT_MODE_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TRANSPORT_MODE_ID.Add(entity.TRANSPORT_MODE_ID);
            }

            builder.AppendLine("DELETE [dbo].[TRPMODE] WHERE");


            // Index_TRANSPORT_MODE_ID
            builder.Append("[TRANSPORT_MODE_ID] IN (");
            for (int index = 0; index < Index_TRANSPORT_MODE_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TRANSPORT_MODE_ID
                var parameterTRANSPORT_MODE_ID = $"@p{parameterIndex++}";
                builder.Append(parameterTRANSPORT_MODE_ID);
                command.Parameters.Add(parameterTRANSPORT_MODE_ID, SqlDbType.Int).Value = Index_TRANSPORT_MODE_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TRPMODE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TRPMODE data set</returns>
        public override EduHubDataSetDataReader<TRPMODE> GetDataSetDataReader()
        {
            return new TRPMODEDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TRPMODE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TRPMODE data set</returns>
        public override EduHubDataSetDataReader<TRPMODE> GetDataSetDataReader(List<TRPMODE> Entities)
        {
            return new TRPMODEDataReader(new EduHubDataSetLoadedReader<TRPMODE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TRPMODEDataReader : EduHubDataSetDataReader<TRPMODE>
        {
            public TRPMODEDataReader(IEduHubDataSetReader<TRPMODE> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TRANSPORT_MODE_ID
                        return Current.TRANSPORT_MODE_ID;
                    case 1: // TRANSPORT_MODE_DESC
                        return Current.TRANSPORT_MODE_DESC;
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
                    case 1: // TRANSPORT_MODE_DESC
                        return Current.TRANSPORT_MODE_DESC == null;
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
                    case 0: // TRANSPORT_MODE_ID
                        return "TRANSPORT_MODE_ID";
                    case 1: // TRANSPORT_MODE_DESC
                        return "TRANSPORT_MODE_DESC";
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
                    case "TRANSPORT_MODE_ID":
                        return 0;
                    case "TRANSPORT_MODE_DESC":
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
