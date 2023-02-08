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
    /// Student Flexible Learning Options Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STFLODataSet : EduHubDataSet<STFLO>
    {
        /// <inheritdoc />
        public override string Name { get { return "STFLO"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STFLODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PROGRAM = new Lazy<NullDictionary<int?, IReadOnlyList<STFLO>>>(() => this.ToGroupedNullDictionary(i => i.PROGRAM));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STFLO>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STFLO>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STFLO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STFLO" /> fields for each CSV column header</returns>
        internal override Action<STFLO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STFLO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "FROM_DATE":
                        mapper[i] = (e, v) => e.FROM_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "FLO":
                        mapper[i] = (e, v) => e.FLO = v;
                        break;
                    case "EXIT_DATE":
                        mapper[i] = (e, v) => e.EXIT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "PROGRAM":
                        mapper[i] = (e, v) => e.PROGRAM = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="STFLO" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STFLO" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STFLO" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STFLO}"/> of entities</returns>
        internal override IEnumerable<STFLO> ApplyDeltaEntities(IEnumerable<STFLO> Entities, List<STFLO> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<STFLO>>> Index_PROGRAM;
        private Lazy<Dictionary<string, IReadOnlyList<STFLO>>> Index_SKEY;
        private Lazy<Dictionary<int, STFLO>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STFLO by PROGRAM field
        /// </summary>
        /// <param name="PROGRAM">PROGRAM value used to find STFLO</param>
        /// <returns>List of related STFLO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STFLO> FindByPROGRAM(int? PROGRAM)
        {
            return Index_PROGRAM.Value[PROGRAM];
        }

        /// <summary>
        /// Attempt to find STFLO by PROGRAM field
        /// </summary>
        /// <param name="PROGRAM">PROGRAM value used to find STFLO</param>
        /// <param name="Value">List of related STFLO entities</param>
        /// <returns>True if the list of related STFLO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPROGRAM(int? PROGRAM, out IReadOnlyList<STFLO> Value)
        {
            return Index_PROGRAM.Value.TryGetValue(PROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find STFLO by PROGRAM field
        /// </summary>
        /// <param name="PROGRAM">PROGRAM value used to find STFLO</param>
        /// <returns>List of related STFLO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STFLO> TryFindByPROGRAM(int? PROGRAM)
        {
            IReadOnlyList<STFLO> value;
            if (Index_PROGRAM.Value.TryGetValue(PROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STFLO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STFLO</param>
        /// <returns>List of related STFLO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STFLO> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STFLO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STFLO</param>
        /// <param name="Value">List of related STFLO entities</param>
        /// <returns>True if the list of related STFLO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STFLO> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STFLO by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STFLO</param>
        /// <returns>List of related STFLO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STFLO> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STFLO> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STFLO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STFLO</param>
        /// <returns>Related STFLO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STFLO FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STFLO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STFLO</param>
        /// <param name="Value">Related STFLO entity</param>
        /// <returns>True if the related STFLO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STFLO Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STFLO by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STFLO</param>
        /// <returns>Related STFLO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STFLO TryFindByTID(int TID)
        {
            STFLO value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STFLO table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STFLO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STFLO](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [FROM_DATE] datetime NULL,
        [FLO] varchar(50) NULL,
        [EXIT_DATE] datetime NULL,
        [PROGRAM] int NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STFLO_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STFLO_Index_PROGRAM] ON [dbo].[STFLO]
    (
            [PROGRAM] ASC
    );
    CREATE CLUSTERED INDEX [STFLO_Index_SKEY] ON [dbo].[STFLO]
    (
            [SKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STFLO]') AND name = N'STFLO_Index_PROGRAM')
    ALTER INDEX [STFLO_Index_PROGRAM] ON [dbo].[STFLO] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STFLO]') AND name = N'STFLO_Index_TID')
    ALTER INDEX [STFLO_Index_TID] ON [dbo].[STFLO] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STFLO]') AND name = N'STFLO_Index_PROGRAM')
    ALTER INDEX [STFLO_Index_PROGRAM] ON [dbo].[STFLO] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STFLO]') AND name = N'STFLO_Index_TID')
    ALTER INDEX [STFLO_Index_TID] ON [dbo].[STFLO] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STFLO"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STFLO"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STFLO> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STFLO] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STFLO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STFLO data set</returns>
        public override EduHubDataSetDataReader<STFLO> GetDataSetDataReader()
        {
            return new STFLODataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STFLO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STFLO data set</returns>
        public override EduHubDataSetDataReader<STFLO> GetDataSetDataReader(List<STFLO> Entities)
        {
            return new STFLODataReader(new EduHubDataSetLoadedReader<STFLO>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STFLODataReader : EduHubDataSetDataReader<STFLO>
        {
            public STFLODataReader(IEduHubDataSetReader<STFLO> Reader)
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
                    case 1: // SKEY
                        return Current.SKEY;
                    case 2: // FROM_DATE
                        return Current.FROM_DATE;
                    case 3: // FLO
                        return Current.FLO;
                    case 4: // EXIT_DATE
                        return Current.EXIT_DATE;
                    case 5: // PROGRAM
                        return Current.PROGRAM;
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
                    case 2: // FROM_DATE
                        return Current.FROM_DATE == null;
                    case 3: // FLO
                        return Current.FLO == null;
                    case 4: // EXIT_DATE
                        return Current.EXIT_DATE == null;
                    case 5: // PROGRAM
                        return Current.PROGRAM == null;
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
                    case 1: // SKEY
                        return "SKEY";
                    case 2: // FROM_DATE
                        return "FROM_DATE";
                    case 3: // FLO
                        return "FLO";
                    case 4: // EXIT_DATE
                        return "EXIT_DATE";
                    case 5: // PROGRAM
                        return "PROGRAM";
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
                    case "SKEY":
                        return 1;
                    case "FROM_DATE":
                        return 2;
                    case "FLO":
                        return 3;
                    case "EXIT_DATE":
                        return 4;
                    case "PROGRAM":
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
