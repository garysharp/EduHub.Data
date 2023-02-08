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
    /// Staff Availability for Calendar Extras Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFAVDataSet : EduHubDataSet<SFAV>
    {
        /// <inheritdoc />
        public override string Name { get { return "SFAV"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SFAVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TEACH = new Lazy<Dictionary<string, IReadOnlyList<SFAV>>>(() => this.ToGroupedDictionary(i => i.TEACH));
            Index_TID = new Lazy<Dictionary<int, SFAV>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFAV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFAV" /> fields for each CSV column header</returns>
        internal override Action<SFAV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFAV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "END_TIME":
                        mapper[i] = (e, v) => e.END_TIME = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "AVAILABLE_DATE":
                        mapper[i] = (e, v) => e.AVAILABLE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="SFAV" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SFAV" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SFAV" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SFAV}"/> of entities</returns>
        internal override IEnumerable<SFAV> ApplyDeltaEntities(IEnumerable<SFAV> Entities, List<SFAV> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TEACH;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TEACH.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SFAV>>> Index_TEACH;
        private Lazy<Dictionary<int, SFAV>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SFAV by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFAV</param>
        /// <returns>List of related SFAV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAV> FindByTEACH(string TEACH)
        {
            return Index_TEACH.Value[TEACH];
        }

        /// <summary>
        /// Attempt to find SFAV by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFAV</param>
        /// <param name="Value">List of related SFAV entities</param>
        /// <returns>True if the list of related SFAV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACH(string TEACH, out IReadOnlyList<SFAV> Value)
        {
            return Index_TEACH.Value.TryGetValue(TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find SFAV by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFAV</param>
        /// <returns>List of related SFAV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAV> TryFindByTEACH(string TEACH)
        {
            IReadOnlyList<SFAV> value;
            if (Index_TEACH.Value.TryGetValue(TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAV</param>
        /// <returns>Related SFAV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SFAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAV</param>
        /// <param name="Value">Related SFAV entity</param>
        /// <returns>True if the related SFAV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SFAV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SFAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAV</param>
        /// <returns>Related SFAV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAV TryFindByTID(int TID)
        {
            SFAV value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SFAV table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SFAV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SFAV](
        [TID] int IDENTITY NOT NULL,
        [TEACH] varchar(4) NOT NULL,
        [DAY_NUMBER] smallint NULL,
        [START_TIME] datetime NULL,
        [END_TIME] datetime NULL,
        [AVAILABLE_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SFAV_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SFAV_Index_TEACH] ON [dbo].[SFAV]
    (
            [TEACH] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SFAV]') AND name = N'SFAV_Index_TID')
    ALTER INDEX [SFAV_Index_TID] ON [dbo].[SFAV] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SFAV]') AND name = N'SFAV_Index_TID')
    ALTER INDEX [SFAV_Index_TID] ON [dbo].[SFAV] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SFAV"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SFAV"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SFAV> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SFAV] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SFAV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SFAV data set</returns>
        public override EduHubDataSetDataReader<SFAV> GetDataSetDataReader()
        {
            return new SFAVDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SFAV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SFAV data set</returns>
        public override EduHubDataSetDataReader<SFAV> GetDataSetDataReader(List<SFAV> Entities)
        {
            return new SFAVDataReader(new EduHubDataSetLoadedReader<SFAV>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SFAVDataReader : EduHubDataSetDataReader<SFAV>
        {
            public SFAVDataReader(IEduHubDataSetReader<SFAV> Reader)
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
                    case 1: // TEACH
                        return Current.TEACH;
                    case 2: // DAY_NUMBER
                        return Current.DAY_NUMBER;
                    case 3: // START_TIME
                        return Current.START_TIME;
                    case 4: // END_TIME
                        return Current.END_TIME;
                    case 5: // AVAILABLE_DATE
                        return Current.AVAILABLE_DATE;
                    case 6: // LW_TIME
                        return Current.LW_TIME;
                    case 7: // LW_DATE
                        return Current.LW_DATE;
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
                    case 2: // DAY_NUMBER
                        return Current.DAY_NUMBER == null;
                    case 3: // START_TIME
                        return Current.START_TIME == null;
                    case 4: // END_TIME
                        return Current.END_TIME == null;
                    case 5: // AVAILABLE_DATE
                        return Current.AVAILABLE_DATE == null;
                    case 6: // LW_TIME
                        return Current.LW_TIME == null;
                    case 7: // LW_DATE
                        return Current.LW_DATE == null;
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
                    case 1: // TEACH
                        return "TEACH";
                    case 2: // DAY_NUMBER
                        return "DAY_NUMBER";
                    case 3: // START_TIME
                        return "START_TIME";
                    case 4: // END_TIME
                        return "END_TIME";
                    case 5: // AVAILABLE_DATE
                        return "AVAILABLE_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_DATE
                        return "LW_DATE";
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
                    case "TEACH":
                        return 1;
                    case "DAY_NUMBER":
                        return 2;
                    case "START_TIME":
                        return 3;
                    case "END_TIME":
                        return 4;
                    case "AVAILABLE_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_DATE":
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
#endif
