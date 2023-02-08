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
    /// Financial Data Export Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FDT_EXPDataSet : EduHubDataSet<FDT_EXP>
    {
        /// <inheritdoc />
        public override string Name { get { return "FDT_EXP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal FDT_EXPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DEST = new Lazy<Dictionary<string, IReadOnlyList<FDT_EXP>>>(() => this.ToGroupedDictionary(i => i.DEST));
            Index_TID = new Lazy<Dictionary<int, FDT_EXP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FDT_EXP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FDT_EXP" /> fields for each CSV column header</returns>
        internal override Action<FDT_EXP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FDT_EXP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "DEST":
                        mapper[i] = (e, v) => e.DEST = v;
                        break;
                    case "DEST_ID":
                        mapper[i] = (e, v) => e.DEST_ID = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "EXP_DATE":
                        mapper[i] = (e, v) => e.EXP_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "EXP_TIME":
                        mapper[i] = (e, v) => e.EXP_TIME = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="FDT_EXP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="FDT_EXP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="FDT_EXP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{FDT_EXP}"/> of entities</returns>
        internal override IEnumerable<FDT_EXP> ApplyDeltaEntities(IEnumerable<FDT_EXP> Entities, List<FDT_EXP> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.DEST;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.DEST.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<FDT_EXP>>> Index_DEST;
        private Lazy<Dictionary<int, FDT_EXP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <returns>List of related FDT_EXP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<FDT_EXP> FindByDEST(string DEST)
        {
            return Index_DEST.Value[DEST];
        }

        /// <summary>
        /// Attempt to find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <param name="Value">List of related FDT_EXP entities</param>
        /// <returns>True if the list of related FDT_EXP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEST(string DEST, out IReadOnlyList<FDT_EXP> Value)
        {
            return Index_DEST.Value.TryGetValue(DEST, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_EXP by DEST field
        /// </summary>
        /// <param name="DEST">DEST value used to find FDT_EXP</param>
        /// <returns>List of related FDT_EXP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<FDT_EXP> TryFindByDEST(string DEST)
        {
            IReadOnlyList<FDT_EXP> value;
            if (Index_DEST.Value.TryGetValue(DEST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <returns>Related FDT_EXP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FDT_EXP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <param name="Value">Related FDT_EXP entity</param>
        /// <returns>True if the related FDT_EXP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out FDT_EXP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_EXP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find FDT_EXP</param>
        /// <returns>Related FDT_EXP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FDT_EXP TryFindByTID(int TID)
        {
            FDT_EXP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a FDT_EXP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FDT_EXP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[FDT_EXP](
        [TID] int IDENTITY NOT NULL,
        [DEST] varchar(8) NOT NULL,
        [DEST_ID] varchar(8) NULL,
        [SOURCE] varchar(5) NULL,
        [SOURCE_KEY] varchar(15) NULL,
        [NOTES] varchar(MAX) NULL,
        [EXP_DATE] datetime NULL,
        [EXP_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [FDT_EXP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [FDT_EXP_Index_DEST] ON [dbo].[FDT_EXP]
    (
            [DEST] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[FDT_EXP]') AND name = N'FDT_EXP_Index_TID')
    ALTER INDEX [FDT_EXP_Index_TID] ON [dbo].[FDT_EXP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[FDT_EXP]') AND name = N'FDT_EXP_Index_TID')
    ALTER INDEX [FDT_EXP_Index_TID] ON [dbo].[FDT_EXP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="FDT_EXP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="FDT_EXP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<FDT_EXP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[FDT_EXP] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the FDT_EXP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FDT_EXP data set</returns>
        public override EduHubDataSetDataReader<FDT_EXP> GetDataSetDataReader()
        {
            return new FDT_EXPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the FDT_EXP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FDT_EXP data set</returns>
        public override EduHubDataSetDataReader<FDT_EXP> GetDataSetDataReader(List<FDT_EXP> Entities)
        {
            return new FDT_EXPDataReader(new EduHubDataSetLoadedReader<FDT_EXP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class FDT_EXPDataReader : EduHubDataSetDataReader<FDT_EXP>
        {
            public FDT_EXPDataReader(IEduHubDataSetReader<FDT_EXP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // DEST
                        return Current.DEST;
                    case 2: // DEST_ID
                        return Current.DEST_ID;
                    case 3: // SOURCE
                        return Current.SOURCE;
                    case 4: // SOURCE_KEY
                        return Current.SOURCE_KEY;
                    case 5: // NOTES
                        return Current.NOTES;
                    case 6: // EXP_DATE
                        return Current.EXP_DATE;
                    case 7: // EXP_TIME
                        return Current.EXP_TIME;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // DEST_ID
                        return Current.DEST_ID == null;
                    case 3: // SOURCE
                        return Current.SOURCE == null;
                    case 4: // SOURCE_KEY
                        return Current.SOURCE_KEY == null;
                    case 5: // NOTES
                        return Current.NOTES == null;
                    case 6: // EXP_DATE
                        return Current.EXP_DATE == null;
                    case 7: // EXP_TIME
                        return Current.EXP_TIME == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
                    case 10: // LW_USER
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
                    case 1: // DEST
                        return "DEST";
                    case 2: // DEST_ID
                        return "DEST_ID";
                    case 3: // SOURCE
                        return "SOURCE";
                    case 4: // SOURCE_KEY
                        return "SOURCE_KEY";
                    case 5: // NOTES
                        return "NOTES";
                    case 6: // EXP_DATE
                        return "EXP_DATE";
                    case 7: // EXP_TIME
                        return "EXP_TIME";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
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
                    case "DEST":
                        return 1;
                    case "DEST_ID":
                        return 2;
                    case "SOURCE":
                        return 3;
                    case "SOURCE_KEY":
                        return 4;
                    case "NOTES":
                        return 5;
                    case "EXP_DATE":
                        return 6;
                    case "EXP_TIME":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
