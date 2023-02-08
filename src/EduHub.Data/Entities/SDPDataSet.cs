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
    /// Incident Instigators Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDPDataSet : EduHubDataSet<SDP>
    {
        /// <inheritdoc />
        public override string Name { get { return "SDP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SDPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INCIDENT_KEY = new Lazy<NullDictionary<int?, IReadOnlyList<SDP>>>(() => this.ToGroupedNullDictionary(i => i.INCIDENT_KEY));
            Index_SDPKEY = new Lazy<Dictionary<int, SDP>>(() => this.ToDictionary(i => i.SDPKEY));
            Index_STUDENT_KEY = new Lazy<NullDictionary<string, IReadOnlyList<SDP>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT_KEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDP" /> fields for each CSV column header</returns>
        internal override Action<SDP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDPKEY":
                        mapper[i] = (e, v) => e.SDPKEY = int.Parse(v);
                        break;
                    case "INCIDENT_KEY":
                        mapper[i] = (e, v) => e.INCIDENT_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INCIDENT_TYPE":
                        mapper[i] = (e, v) => e.INCIDENT_TYPE = v;
                        break;
                    case "INCIDENT_DATE":
                        mapper[i] = (e, v) => e.INCIDENT_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "STUDENT_KEY":
                        mapper[i] = (e, v) => e.STUDENT_KEY = v;
                        break;
                    case "INVOLVEMENT_DESC":
                        mapper[i] = (e, v) => e.INVOLVEMENT_DESC = v;
                        break;
                    case "FOLLOW_UP_DATE":
                        mapper[i] = (e, v) => e.FOLLOW_UP_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "FOLLOW_UP_DETAILS":
                        mapper[i] = (e, v) => e.FOLLOW_UP_DETAILS = v;
                        break;
                    case "FOLLOW_UP_OUTCOME":
                        mapper[i] = (e, v) => e.FOLLOW_UP_OUTCOME = v;
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
        /// Merges <see cref="SDP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SDP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SDP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SDP}"/> of entities</returns>
        internal override IEnumerable<SDP> ApplyDeltaEntities(IEnumerable<SDP> Entities, List<SDP> DeltaEntities)
        {
            HashSet<int> Index_SDPKEY = new HashSet<int>(DeltaEntities.Select(i => i.SDPKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SDPKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SDPKEY.Remove(entity.SDPKEY);
                            
                            if (entity.SDPKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<SDP>>> Index_INCIDENT_KEY;
        private Lazy<Dictionary<int, SDP>> Index_SDPKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SDP>>> Index_STUDENT_KEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> FindByINCIDENT_KEY(int? INCIDENT_KEY)
        {
            return Index_INCIDENT_KEY.Value[INCIDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <param name="Value">List of related SDP entities</param>
        /// <returns>True if the list of related SDP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_KEY(int? INCIDENT_KEY, out IReadOnlyList<SDP> Value)
        {
            return Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> TryFindByINCIDENT_KEY(int? INCIDENT_KEY)
        {
            IReadOnlyList<SDP> value;
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
        /// Find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <returns>Related SDP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDP FindBySDPKEY(int SDPKEY)
        {
            return Index_SDPKEY.Value[SDPKEY];
        }

        /// <summary>
        /// Attempt to find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <param name="Value">Related SDP entity</param>
        /// <returns>True if the related SDP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDPKEY(int SDPKEY, out SDP Value)
        {
            return Index_SDPKEY.Value.TryGetValue(SDPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by SDPKEY field
        /// </summary>
        /// <param name="SDPKEY">SDPKEY value used to find SDP</param>
        /// <returns>Related SDP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDP TryFindBySDPKEY(int SDPKEY)
        {
            SDP value;
            if (Index_SDPKEY.Value.TryGetValue(SDPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> FindBySTUDENT_KEY(string STUDENT_KEY)
        {
            return Index_STUDENT_KEY.Value[STUDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <param name="Value">List of related SDP entities</param>
        /// <returns>True if the list of related SDP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT_KEY(string STUDENT_KEY, out IReadOnlyList<SDP> Value)
        {
            return Index_STUDENT_KEY.Value.TryGetValue(STUDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDP by STUDENT_KEY field
        /// </summary>
        /// <param name="STUDENT_KEY">STUDENT_KEY value used to find SDP</param>
        /// <returns>List of related SDP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SDP> TryFindBySTUDENT_KEY(string STUDENT_KEY)
        {
            IReadOnlyList<SDP> value;
            if (Index_STUDENT_KEY.Value.TryGetValue(STUDENT_KEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SDP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SDP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SDP](
        [SDPKEY] int IDENTITY NOT NULL,
        [INCIDENT_KEY] int NULL,
        [INCIDENT_TYPE] varchar(5) NULL,
        [INCIDENT_DATE] datetime NULL,
        [STUDENT_KEY] varchar(10) NULL,
        [INVOLVEMENT_DESC] varchar(MAX) NULL,
        [FOLLOW_UP_DATE] datetime NULL,
        [FOLLOW_UP_DETAILS] varchar(MAX) NULL,
        [FOLLOW_UP_OUTCOME] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SDP_Index_SDPKEY] PRIMARY KEY CLUSTERED (
            [SDPKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SDP_Index_INCIDENT_KEY] ON [dbo].[SDP]
    (
            [INCIDENT_KEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SDP_Index_STUDENT_KEY] ON [dbo].[SDP]
    (
            [STUDENT_KEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDP]') AND name = N'SDP_Index_INCIDENT_KEY')
    ALTER INDEX [SDP_Index_INCIDENT_KEY] ON [dbo].[SDP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDP]') AND name = N'SDP_Index_STUDENT_KEY')
    ALTER INDEX [SDP_Index_STUDENT_KEY] ON [dbo].[SDP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDP]') AND name = N'SDP_Index_INCIDENT_KEY')
    ALTER INDEX [SDP_Index_INCIDENT_KEY] ON [dbo].[SDP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SDP]') AND name = N'SDP_Index_STUDENT_KEY')
    ALTER INDEX [SDP_Index_STUDENT_KEY] ON [dbo].[SDP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SDP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SDP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SDP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SDPKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SDPKEY.Add(entity.SDPKEY);
            }

            builder.AppendLine("DELETE [dbo].[SDP] WHERE");


            // Index_SDPKEY
            builder.Append("[SDPKEY] IN (");
            for (int index = 0; index < Index_SDPKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SDPKEY
                var parameterSDPKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSDPKEY);
                command.Parameters.Add(parameterSDPKEY, SqlDbType.Int).Value = Index_SDPKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDP data set</returns>
        public override EduHubDataSetDataReader<SDP> GetDataSetDataReader()
        {
            return new SDPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDP data set</returns>
        public override EduHubDataSetDataReader<SDP> GetDataSetDataReader(List<SDP> Entities)
        {
            return new SDPDataReader(new EduHubDataSetLoadedReader<SDP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SDPDataReader : EduHubDataSetDataReader<SDP>
        {
            public SDPDataReader(IEduHubDataSetReader<SDP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 12; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SDPKEY
                        return Current.SDPKEY;
                    case 1: // INCIDENT_KEY
                        return Current.INCIDENT_KEY;
                    case 2: // INCIDENT_TYPE
                        return Current.INCIDENT_TYPE;
                    case 3: // INCIDENT_DATE
                        return Current.INCIDENT_DATE;
                    case 4: // STUDENT_KEY
                        return Current.STUDENT_KEY;
                    case 5: // INVOLVEMENT_DESC
                        return Current.INVOLVEMENT_DESC;
                    case 6: // FOLLOW_UP_DATE
                        return Current.FOLLOW_UP_DATE;
                    case 7: // FOLLOW_UP_DETAILS
                        return Current.FOLLOW_UP_DETAILS;
                    case 8: // FOLLOW_UP_OUTCOME
                        return Current.FOLLOW_UP_OUTCOME;
                    case 9: // LW_DATE
                        return Current.LW_DATE;
                    case 10: // LW_TIME
                        return Current.LW_TIME;
                    case 11: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // INCIDENT_KEY
                        return Current.INCIDENT_KEY == null;
                    case 2: // INCIDENT_TYPE
                        return Current.INCIDENT_TYPE == null;
                    case 3: // INCIDENT_DATE
                        return Current.INCIDENT_DATE == null;
                    case 4: // STUDENT_KEY
                        return Current.STUDENT_KEY == null;
                    case 5: // INVOLVEMENT_DESC
                        return Current.INVOLVEMENT_DESC == null;
                    case 6: // FOLLOW_UP_DATE
                        return Current.FOLLOW_UP_DATE == null;
                    case 7: // FOLLOW_UP_DETAILS
                        return Current.FOLLOW_UP_DETAILS == null;
                    case 8: // FOLLOW_UP_OUTCOME
                        return Current.FOLLOW_UP_OUTCOME == null;
                    case 9: // LW_DATE
                        return Current.LW_DATE == null;
                    case 10: // LW_TIME
                        return Current.LW_TIME == null;
                    case 11: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SDPKEY
                        return "SDPKEY";
                    case 1: // INCIDENT_KEY
                        return "INCIDENT_KEY";
                    case 2: // INCIDENT_TYPE
                        return "INCIDENT_TYPE";
                    case 3: // INCIDENT_DATE
                        return "INCIDENT_DATE";
                    case 4: // STUDENT_KEY
                        return "STUDENT_KEY";
                    case 5: // INVOLVEMENT_DESC
                        return "INVOLVEMENT_DESC";
                    case 6: // FOLLOW_UP_DATE
                        return "FOLLOW_UP_DATE";
                    case 7: // FOLLOW_UP_DETAILS
                        return "FOLLOW_UP_DETAILS";
                    case 8: // FOLLOW_UP_OUTCOME
                        return "FOLLOW_UP_OUTCOME";
                    case 9: // LW_DATE
                        return "LW_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SDPKEY":
                        return 0;
                    case "INCIDENT_KEY":
                        return 1;
                    case "INCIDENT_TYPE":
                        return 2;
                    case "INCIDENT_DATE":
                        return 3;
                    case "STUDENT_KEY":
                        return 4;
                    case "INVOLVEMENT_DESC":
                        return 5;
                    case "FOLLOW_UP_DATE":
                        return 6;
                    case "FOLLOW_UP_DETAILS":
                        return 7;
                    case "FOLLOW_UP_OUTCOME":
                        return 8;
                    case "LW_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_USER":
                        return 11;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
