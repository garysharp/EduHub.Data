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
    /// Incident Victims/Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIDVDataSet : EduHubDataSet<SIDV>
    {
        /// <inheritdoc />
        public override string Name { get { return "SIDV"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SIDVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INCIDENT_KEY = new Lazy<Dictionary<int, IReadOnlyList<SIDV>>>(() => this.ToGroupedDictionary(i => i.INCIDENT_KEY));
            Index_TID = new Lazy<Dictionary<int, SIDV>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SIDV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SIDV" /> fields for each CSV column header</returns>
        internal override Action<SIDV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SIDV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INCIDENT_KEY":
                        mapper[i] = (e, v) => e.INCIDENT_KEY = int.Parse(v);
                        break;
                    case "RECIPIENT_TYPE":
                        mapper[i] = (e, v) => e.RECIPIENT_TYPE = v;
                        break;
                    case "RECIPIENT":
                        mapper[i] = (e, v) => e.RECIPIENT = v;
                        break;
                    case "RECIPIENT_NAME":
                        mapper[i] = (e, v) => e.RECIPIENT_NAME = v;
                        break;
                    case "RECIPIENT_ADDRESS":
                        mapper[i] = (e, v) => e.RECIPIENT_ADDRESS = v;
                        break;
                    case "RECIPIENT_PHONE":
                        mapper[i] = (e, v) => e.RECIPIENT_PHONE = v;
                        break;
                    case "HOW_AFFECTED":
                        mapper[i] = (e, v) => e.HOW_AFFECTED = v;
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
        /// Merges <see cref="SIDV" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SIDV" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SIDV" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SIDV}"/> of entities</returns>
        internal override IEnumerable<SIDV> ApplyDeltaEntities(IEnumerable<SIDV> Entities, List<SIDV> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.INCIDENT_KEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.INCIDENT_KEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, IReadOnlyList<SIDV>>> Index_INCIDENT_KEY;
        private Lazy<Dictionary<int, SIDV>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <returns>List of related SIDV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SIDV> FindByINCIDENT_KEY(int INCIDENT_KEY)
        {
            return Index_INCIDENT_KEY.Value[INCIDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <param name="Value">List of related SIDV entities</param>
        /// <returns>True if the list of related SIDV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_KEY(int INCIDENT_KEY, out IReadOnlyList<SIDV> Value)
        {
            return Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <returns>List of related SIDV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SIDV> TryFindByINCIDENT_KEY(int INCIDENT_KEY)
        {
            IReadOnlyList<SIDV> value;
            if (Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <returns>Related SIDV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIDV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <param name="Value">Related SIDV entity</param>
        /// <returns>True if the related SIDV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SIDV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <returns>Related SIDV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIDV TryFindByTID(int TID)
        {
            SIDV value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SIDV table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SIDV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SIDV](
        [TID] int IDENTITY NOT NULL,
        [INCIDENT_KEY] int NOT NULL,
        [RECIPIENT_TYPE] varchar(2) NULL,
        [RECIPIENT] varchar(10) NULL,
        [RECIPIENT_NAME] varchar(64) NULL,
        [RECIPIENT_ADDRESS] varchar(MAX) NULL,
        [RECIPIENT_PHONE] varchar(20) NULL,
        [HOW_AFFECTED] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SIDV_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SIDV_Index_INCIDENT_KEY] ON [dbo].[SIDV]
    (
            [INCIDENT_KEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SIDV]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SIDV] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SIDV]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SIDV] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SIDV"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SIDV"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SIDV> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SIDV] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SIDV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SIDV data set</returns>
        public override EduHubDataSetDataReader<SIDV> GetDataSetDataReader()
        {
            return new SIDVDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SIDV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SIDV data set</returns>
        public override EduHubDataSetDataReader<SIDV> GetDataSetDataReader(List<SIDV> Entities)
        {
            return new SIDVDataReader(new EduHubDataSetLoadedReader<SIDV>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SIDVDataReader : EduHubDataSetDataReader<SIDV>
        {
            public SIDVDataReader(IEduHubDataSetReader<SIDV> Reader)
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
                    case 1: // INCIDENT_KEY
                        return Current.INCIDENT_KEY;
                    case 2: // RECIPIENT_TYPE
                        return Current.RECIPIENT_TYPE;
                    case 3: // RECIPIENT
                        return Current.RECIPIENT;
                    case 4: // RECIPIENT_NAME
                        return Current.RECIPIENT_NAME;
                    case 5: // RECIPIENT_ADDRESS
                        return Current.RECIPIENT_ADDRESS;
                    case 6: // RECIPIENT_PHONE
                        return Current.RECIPIENT_PHONE;
                    case 7: // HOW_AFFECTED
                        return Current.HOW_AFFECTED;
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
                    case 2: // RECIPIENT_TYPE
                        return Current.RECIPIENT_TYPE == null;
                    case 3: // RECIPIENT
                        return Current.RECIPIENT == null;
                    case 4: // RECIPIENT_NAME
                        return Current.RECIPIENT_NAME == null;
                    case 5: // RECIPIENT_ADDRESS
                        return Current.RECIPIENT_ADDRESS == null;
                    case 6: // RECIPIENT_PHONE
                        return Current.RECIPIENT_PHONE == null;
                    case 7: // HOW_AFFECTED
                        return Current.HOW_AFFECTED == null;
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
                    case 1: // INCIDENT_KEY
                        return "INCIDENT_KEY";
                    case 2: // RECIPIENT_TYPE
                        return "RECIPIENT_TYPE";
                    case 3: // RECIPIENT
                        return "RECIPIENT";
                    case 4: // RECIPIENT_NAME
                        return "RECIPIENT_NAME";
                    case 5: // RECIPIENT_ADDRESS
                        return "RECIPIENT_ADDRESS";
                    case 6: // RECIPIENT_PHONE
                        return "RECIPIENT_PHONE";
                    case 7: // HOW_AFFECTED
                        return "HOW_AFFECTED";
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
                    case "INCIDENT_KEY":
                        return 1;
                    case "RECIPIENT_TYPE":
                        return 2;
                    case "RECIPIENT":
                        return 3;
                    case "RECIPIENT_NAME":
                        return 4;
                    case "RECIPIENT_ADDRESS":
                        return 5;
                    case "RECIPIENT_PHONE":
                        return 6;
                    case "HOW_AFFECTED":
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
