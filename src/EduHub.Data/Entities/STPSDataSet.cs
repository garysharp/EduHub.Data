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
    /// Student Previous School Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STPSDataSet : EduHubDataSet<STPS>
    {
        /// <inheritdoc />
        public override string Name { get { return "STPS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STPSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<STPS>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STPS>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_TID = new Lazy<Dictionary<int, STPS>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STPS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STPS" /> fields for each CSV column header</returns>
        internal override Action<STPS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STPS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "ENROL_DATE":
                        mapper[i] = (e, v) => e.ENROL_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DEPART_DATE":
                        mapper[i] = (e, v) => e.DEPART_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "REASON_LEFT":
                        mapper[i] = (e, v) => e.REASON_LEFT = v;
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
        /// Merges <see cref="STPS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STPS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STPS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STPS}"/> of entities</returns>
        internal override IEnumerable<STPS> ApplyDeltaEntities(IEnumerable<STPS> Entities, List<STPS> DeltaEntities)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STPS>>> Index_SCHOOL;
        private Lazy<Dictionary<string, IReadOnlyList<STPS>>> Index_SKEY;
        private Lazy<Dictionary<int, STPS>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STPS by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STPS</param>
        /// <returns>List of related STPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPS> FindBySCHOOL(string SCHOOL)
        {
            return Index_SCHOOL.Value[SCHOOL];
        }

        /// <summary>
        /// Attempt to find STPS by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STPS</param>
        /// <param name="Value">List of related STPS entities</param>
        /// <returns>True if the list of related STPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL(string SCHOOL, out IReadOnlyList<STPS> Value)
        {
            return Index_SCHOOL.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find STPS by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STPS</param>
        /// <returns>List of related STPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPS> TryFindBySCHOOL(string SCHOOL)
        {
            IReadOnlyList<STPS> value;
            if (Index_SCHOOL.Value.TryGetValue(SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STPS by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STPS</param>
        /// <returns>List of related STPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPS> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STPS by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STPS</param>
        /// <param name="Value">List of related STPS entities</param>
        /// <returns>True if the list of related STPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STPS> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STPS by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STPS</param>
        /// <returns>List of related STPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STPS> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STPS> value;
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
        /// Find STPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPS</param>
        /// <returns>Related STPS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPS FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPS</param>
        /// <param name="Value">Related STPS entity</param>
        /// <returns>True if the related STPS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STPS Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STPS by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STPS</param>
        /// <returns>Related STPS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STPS TryFindByTID(int TID)
        {
            STPS value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STPS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STPS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STPS](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [SCHOOL] varchar(8) NULL,
        [ENROL_DATE] datetime NULL,
        [DEPART_DATE] datetime NULL,
        [REASON_LEFT] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STPS_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STPS_Index_SCHOOL] ON [dbo].[STPS]
    (
            [SCHOOL] ASC
    );
    CREATE CLUSTERED INDEX [STPS_Index_SKEY] ON [dbo].[STPS]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPS]') AND name = N'Index_SCHOOL')
    ALTER INDEX [Index_SCHOOL] ON [dbo].[STPS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPS]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STPS] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPS]') AND name = N'Index_SCHOOL')
    ALTER INDEX [Index_SCHOOL] ON [dbo].[STPS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STPS]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STPS] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STPS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STPS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STPS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STPS] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STPS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STPS data set</returns>
        public override EduHubDataSetDataReader<STPS> GetDataSetDataReader()
        {
            return new STPSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STPS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STPS data set</returns>
        public override EduHubDataSetDataReader<STPS> GetDataSetDataReader(List<STPS> Entities)
        {
            return new STPSDataReader(new EduHubDataSetLoadedReader<STPS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STPSDataReader : EduHubDataSetDataReader<STPS>
        {
            public STPSDataReader(IEduHubDataSetReader<STPS> Reader)
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
                    case 2: // SCHOOL
                        return Current.SCHOOL;
                    case 3: // ENROL_DATE
                        return Current.ENROL_DATE;
                    case 4: // DEPART_DATE
                        return Current.DEPART_DATE;
                    case 5: // REASON_LEFT
                        return Current.REASON_LEFT;
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
                    case 2: // SCHOOL
                        return Current.SCHOOL == null;
                    case 3: // ENROL_DATE
                        return Current.ENROL_DATE == null;
                    case 4: // DEPART_DATE
                        return Current.DEPART_DATE == null;
                    case 5: // REASON_LEFT
                        return Current.REASON_LEFT == null;
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
                    case 2: // SCHOOL
                        return "SCHOOL";
                    case 3: // ENROL_DATE
                        return "ENROL_DATE";
                    case 4: // DEPART_DATE
                        return "DEPART_DATE";
                    case 5: // REASON_LEFT
                        return "REASON_LEFT";
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
                    case "SCHOOL":
                        return 2;
                    case "ENROL_DATE":
                        return 3;
                    case "DEPART_DATE":
                        return 4;
                    case "REASON_LEFT":
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
