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
    /// CSEF Receipt details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KEMADataSet : EduHubDataSet<KEMA>
    {
        /// <inheritdoc />
        public override string Name { get { return "KEMA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KEMADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TID = new Lazy<Dictionary<int, KEMA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KEMA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KEMA" /> fields for each CSV column header</returns>
        internal override Action<KEMA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KEMA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FAMILY_KEY":
                        mapper[i] = (e, v) => e.FAMILY_KEY = v;
                        break;
                    case "STREGISTRATION":
                        mapper[i] = (e, v) => e.STREGISTRATION = v;
                        break;
                    case "EMA_PERIOD":
                        mapper[i] = (e, v) => e.EMA_PERIOD = v;
                        break;
                    case "EMA_TRAMT":
                        mapper[i] = (e, v) => e.EMA_TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
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
        /// Merges <see cref="KEMA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KEMA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KEMA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KEMA}"/> of entities</returns>
        internal override IEnumerable<KEMA> ApplyDeltaEntities(IEnumerable<KEMA> Entities, List<KEMA> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KEMA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <returns>Related KEMA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KEMA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <param name="Value">Related KEMA entity</param>
        /// <returns>True if the related KEMA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KEMA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KEMA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KEMA</param>
        /// <returns>Related KEMA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KEMA TryFindByTID(int TID)
        {
            KEMA value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KEMA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KEMA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KEMA](
        [TID] int IDENTITY NOT NULL,
        [FAMILY_KEY] varchar(10) NULL,
        [STREGISTRATION] varchar(15) NULL,
        [EMA_PERIOD] varchar(1) NULL,
        [EMA_TRAMT] money NULL,
        [DELETE_FLAG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KEMA_Index_TID] PRIMARY KEY CLUSTERED (
            [TID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KEMADataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KEMADataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KEMA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KEMA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KEMA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KEMA] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KEMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KEMA data set</returns>
        public override EduHubDataSetDataReader<KEMA> GetDataSetDataReader()
        {
            return new KEMADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KEMA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KEMA data set</returns>
        public override EduHubDataSetDataReader<KEMA> GetDataSetDataReader(List<KEMA> Entities)
        {
            return new KEMADataReader(new EduHubDataSetLoadedReader<KEMA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KEMADataReader : EduHubDataSetDataReader<KEMA>
        {
            public KEMADataReader(IEduHubDataSetReader<KEMA> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // FAMILY_KEY
                        return Current.FAMILY_KEY;
                    case 2: // STREGISTRATION
                        return Current.STREGISTRATION;
                    case 3: // EMA_PERIOD
                        return Current.EMA_PERIOD;
                    case 4: // EMA_TRAMT
                        return Current.EMA_TRAMT;
                    case 5: // DELETE_FLAG
                        return Current.DELETE_FLAG;
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
                    case 1: // FAMILY_KEY
                        return Current.FAMILY_KEY == null;
                    case 2: // STREGISTRATION
                        return Current.STREGISTRATION == null;
                    case 3: // EMA_PERIOD
                        return Current.EMA_PERIOD == null;
                    case 4: // EMA_TRAMT
                        return Current.EMA_TRAMT == null;
                    case 5: // DELETE_FLAG
                        return Current.DELETE_FLAG == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // FAMILY_KEY
                        return "FAMILY_KEY";
                    case 2: // STREGISTRATION
                        return "STREGISTRATION";
                    case 3: // EMA_PERIOD
                        return "EMA_PERIOD";
                    case 4: // EMA_TRAMT
                        return "EMA_TRAMT";
                    case 5: // DELETE_FLAG
                        return "DELETE_FLAG";
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
                    case "TID":
                        return 0;
                    case "FAMILY_KEY":
                        return 1;
                    case "STREGISTRATION":
                        return 2;
                    case "EMA_PERIOD":
                        return 3;
                    case "EMA_TRAMT":
                        return 4;
                    case "DELETE_FLAG":
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
