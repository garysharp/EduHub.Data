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
    /// SMS Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPREPLYDataSet : EduHubDataSet<SPREPLY>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPREPLY"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPREPLYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<int, IReadOnlyList<SPREPLY>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPREPLY>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPREPLY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPREPLY" /> fields for each CSV column header</returns>
        internal override Action<SPREPLY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPREPLY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = int.Parse(v);
                        break;
                    case "SPRECIP_TID":
                        mapper[i] = (e, v) => e.SPRECIP_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "PHONE_NUMBER":
                        mapper[i] = (e, v) => e.PHONE_NUMBER = v;
                        break;
                    case "RECEIVED_DATE":
                        mapper[i] = (e, v) => e.RECEIVED_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SPREPLY" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPREPLY" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPREPLY" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPREPLY}"/> of entities</returns>
        internal override IEnumerable<SPREPLY> ApplyDeltaEntities(IEnumerable<SPREPLY> Entities, List<SPREPLY> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, IReadOnlyList<SPREPLY>>> Index_CODE;
        private Lazy<Dictionary<int, SPREPLY>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <returns>List of related SPREPLY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPREPLY> FindByCODE(int CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <param name="Value">List of related SPREPLY entities</param>
        /// <returns>True if the list of related SPREPLY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(int CODE, out IReadOnlyList<SPREPLY> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <returns>List of related SPREPLY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPREPLY> TryFindByCODE(int CODE)
        {
            IReadOnlyList<SPREPLY> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <returns>Related SPREPLY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPREPLY FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <param name="Value">Related SPREPLY entity</param>
        /// <returns>True if the related SPREPLY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPREPLY Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <returns>Related SPREPLY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPREPLY TryFindByTID(int TID)
        {
            SPREPLY value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPREPLY table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPREPLY]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPREPLY](
        [TID] int IDENTITY NOT NULL,
        [CODE] int NOT NULL,
        [SPRECIP_TID] int NULL,
        [MESSAGE] varchar(255) NULL,
        [PHONE_NUMBER] varchar(15) NULL,
        [RECEIVED_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPREPLY_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SPREPLY_Index_CODE] ON [dbo].[SPREPLY]
    (
            [CODE] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPREPLY]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SPREPLY] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPREPLY]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SPREPLY] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPREPLY"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPREPLY"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPREPLY> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SPREPLY] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SPREPLY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPREPLY data set</returns>
        public override EduHubDataSetDataReader<SPREPLY> GetDataSetDataReader()
        {
            return new SPREPLYDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPREPLY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPREPLY data set</returns>
        public override EduHubDataSetDataReader<SPREPLY> GetDataSetDataReader(List<SPREPLY> Entities)
        {
            return new SPREPLYDataReader(new EduHubDataSetLoadedReader<SPREPLY>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPREPLYDataReader : EduHubDataSetDataReader<SPREPLY>
        {
            public SPREPLYDataReader(IEduHubDataSetReader<SPREPLY> Reader)
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
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // SPRECIP_TID
                        return Current.SPRECIP_TID;
                    case 3: // MESSAGE
                        return Current.MESSAGE;
                    case 4: // PHONE_NUMBER
                        return Current.PHONE_NUMBER;
                    case 5: // RECEIVED_DATE
                        return Current.RECEIVED_DATE;
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
                    case 2: // SPRECIP_TID
                        return Current.SPRECIP_TID == null;
                    case 3: // MESSAGE
                        return Current.MESSAGE == null;
                    case 4: // PHONE_NUMBER
                        return Current.PHONE_NUMBER == null;
                    case 5: // RECEIVED_DATE
                        return Current.RECEIVED_DATE == null;
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // SPRECIP_TID
                        return "SPRECIP_TID";
                    case 3: // MESSAGE
                        return "MESSAGE";
                    case 4: // PHONE_NUMBER
                        return "PHONE_NUMBER";
                    case 5: // RECEIVED_DATE
                        return "RECEIVED_DATE";
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
                    case "CODE":
                        return 1;
                    case "SPRECIP_TID":
                        return 2;
                    case "MESSAGE":
                        return 3;
                    case "PHONE_NUMBER":
                        return 4;
                    case "RECEIVED_DATE":
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
