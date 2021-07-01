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
    /// Pay Advice Slip Message Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEMDataSet : EduHubDataSet<PEM>
    {
        /// <inheritdoc />
        public override string Name { get { return "PEM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PEMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEM>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, PEM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEM" /> fields for each CSV column header</returns>
        internal override Action<PEM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "START_TRPAYPERD":
                        mapper[i] = (e, v) => e.START_TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "END_TRPAYPERD":
                        mapper[i] = (e, v) => e.END_TRPAYPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMP_MESSAGE":
                        mapper[i] = (e, v) => e.EMP_MESSAGE = v;
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
        /// Merges <see cref="PEM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PEM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PEM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PEM}"/> of entities</returns>
        internal override IEnumerable<PEM> ApplyDeltaEntities(IEnumerable<PEM> Entities, List<PEM> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEM>>> Index_CODE;
        private Lazy<Dictionary<int, PEM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <returns>List of related PEM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEM> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <param name="Value">List of related PEM entities</param>
        /// <returns>True if the list of related PEM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEM> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEM by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEM</param>
        /// <returns>List of related PEM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEM> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEM> value;
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
        /// Find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <returns>Related PEM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <param name="Value">Related PEM entity</param>
        /// <returns>True if the related PEM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEM</param>
        /// <returns>Related PEM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEM TryFindByTID(int TID)
        {
            PEM value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PEM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEM](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [START_TRPAYPERD] int NULL,
        [END_TRPAYPERD] int NULL,
        [EMP_MESSAGE] varchar(90) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEM_Index_CODE] ON [dbo].[PEM]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEM]') AND name = N'PEM_Index_TID')
    ALTER INDEX [PEM_Index_TID] ON [dbo].[PEM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEM]') AND name = N'PEM_Index_TID')
    ALTER INDEX [PEM_Index_TID] ON [dbo].[PEM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PEM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PEM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PEM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PEM] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PEM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEM data set</returns>
        public override EduHubDataSetDataReader<PEM> GetDataSetDataReader()
        {
            return new PEMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEM data set</returns>
        public override EduHubDataSetDataReader<PEM> GetDataSetDataReader(List<PEM> Entities)
        {
            return new PEMDataReader(new EduHubDataSetLoadedReader<PEM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEMDataReader : EduHubDataSetDataReader<PEM>
        {
            public PEMDataReader(IEduHubDataSetReader<PEM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // START_TRPAYPERD
                        return Current.START_TRPAYPERD;
                    case 3: // END_TRPAYPERD
                        return Current.END_TRPAYPERD;
                    case 4: // EMP_MESSAGE
                        return Current.EMP_MESSAGE;
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
                    case 2: // START_TRPAYPERD
                        return Current.START_TRPAYPERD == null;
                    case 3: // END_TRPAYPERD
                        return Current.END_TRPAYPERD == null;
                    case 4: // EMP_MESSAGE
                        return Current.EMP_MESSAGE == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // START_TRPAYPERD
                        return "START_TRPAYPERD";
                    case 3: // END_TRPAYPERD
                        return "END_TRPAYPERD";
                    case 4: // EMP_MESSAGE
                        return "EMP_MESSAGE";
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
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "START_TRPAYPERD":
                        return 2;
                    case "END_TRPAYPERD":
                        return 3;
                    case "EMP_MESSAGE":
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
