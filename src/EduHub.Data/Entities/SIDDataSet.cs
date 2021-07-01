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
    /// Disciplinary Incidents Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIDDataSet : EduHubDataSet<SID>
    {
        /// <inheritdoc />
        public override string Name { get { return "SID"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SIDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SID>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_INCIDENT_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<SID>>>(() => this.ToGroupedNullDictionary(i => i.INCIDENT_TYPE));
            Index_SIDKEY = new Lazy<Dictionary<int, SID>>(() => this.ToDictionary(i => i.SIDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SID" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SID" /> fields for each CSV column header</returns>
        internal override Action<SID, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SID, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SIDKEY":
                        mapper[i] = (e, v) => e.SIDKEY = int.Parse(v);
                        break;
                    case "SID_DATE":
                        mapper[i] = (e, v) => e.SID_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SID_TIME":
                        mapper[i] = (e, v) => e.SID_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INCIDENT_TYPE":
                        mapper[i] = (e, v) => e.INCIDENT_TYPE = v;
                        break;
                    case "INCIDENT_DESC":
                        mapper[i] = (e, v) => e.INCIDENT_DESC = v;
                        break;
                    case "OFFICE_USE_ONLY":
                        mapper[i] = (e, v) => e.OFFICE_USE_ONLY = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EXT_ADDRESS":
                        mapper[i] = (e, v) => e.EXT_ADDRESS = v;
                        break;
                    case "RESP_PERSON_TYPE":
                        mapper[i] = (e, v) => e.RESP_PERSON_TYPE = v;
                        break;
                    case "RESP_PERSON":
                        mapper[i] = (e, v) => e.RESP_PERSON = v;
                        break;
                    case "RESP_PERSON_NAME":
                        mapper[i] = (e, v) => e.RESP_PERSON_NAME = v;
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
        /// Merges <see cref="SID" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SID" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SID" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SID}"/> of entities</returns>
        internal override IEnumerable<SID> ApplyDeltaEntities(IEnumerable<SID> Entities, List<SID> DeltaEntities)
        {
            HashSet<int> Index_SIDKEY = new HashSet<int>(DeltaEntities.Select(i => i.SIDKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SIDKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SIDKEY.Remove(entity.SIDKEY);
                            
                            if (entity.SIDKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<int?, IReadOnlyList<SID>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SID>>> Index_INCIDENT_TYPE;
        private Lazy<Dictionary<int, SID>> Index_SIDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <returns>List of related SID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <param name="Value">List of related SID entities</param>
        /// <returns>True if the list of related SID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<SID> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SID by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find SID</param>
        /// <returns>List of related SID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<SID> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <returns>List of related SID entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> FindByINCIDENT_TYPE(string INCIDENT_TYPE)
        {
            return Index_INCIDENT_TYPE.Value[INCIDENT_TYPE];
        }

        /// <summary>
        /// Attempt to find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <param name="Value">List of related SID entities</param>
        /// <returns>True if the list of related SID entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_TYPE(string INCIDENT_TYPE, out IReadOnlyList<SID> Value)
        {
            return Index_INCIDENT_TYPE.Value.TryGetValue(INCIDENT_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SID by INCIDENT_TYPE field
        /// </summary>
        /// <param name="INCIDENT_TYPE">INCIDENT_TYPE value used to find SID</param>
        /// <returns>List of related SID entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SID> TryFindByINCIDENT_TYPE(string INCIDENT_TYPE)
        {
            IReadOnlyList<SID> value;
            if (Index_INCIDENT_TYPE.Value.TryGetValue(INCIDENT_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SID FindBySIDKEY(int SIDKEY)
        {
            return Index_SIDKEY.Value[SIDKEY];
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <param name="Value">Related SID entity</param>
        /// <returns>True if the related SID entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySIDKEY(int SIDKEY, out SID Value)
        {
            return Index_SIDKEY.Value.TryGetValue(SIDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SID by SIDKEY field
        /// </summary>
        /// <param name="SIDKEY">SIDKEY value used to find SID</param>
        /// <returns>Related SID entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SID TryFindBySIDKEY(int SIDKEY)
        {
            SID value;
            if (Index_SIDKEY.Value.TryGetValue(SIDKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SID table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SID]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SID](
        [SIDKEY] int IDENTITY NOT NULL,
        [SID_DATE] datetime NULL,
        [SID_TIME] smallint NULL,
        [INCIDENT_TYPE] varchar(10) NULL,
        [INCIDENT_DESC] varchar(MAX) NULL,
        [OFFICE_USE_ONLY] varchar(MAX) NULL,
        [CAMPUS] int NULL,
        [EXT_ADDRESS] varchar(MAX) NULL,
        [RESP_PERSON_TYPE] varchar(2) NULL,
        [RESP_PERSON] varchar(10) NULL,
        [RESP_PERSON_NAME] varchar(64) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SID_Index_SIDKEY] PRIMARY KEY CLUSTERED (
            [SIDKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SID_Index_CAMPUS] ON [dbo].[SID]
    (
            [CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SID_Index_INCIDENT_TYPE] ON [dbo].[SID]
    (
            [INCIDENT_TYPE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SID]') AND name = N'SID_Index_CAMPUS')
    ALTER INDEX [SID_Index_CAMPUS] ON [dbo].[SID] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SID]') AND name = N'SID_Index_INCIDENT_TYPE')
    ALTER INDEX [SID_Index_INCIDENT_TYPE] ON [dbo].[SID] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SID]') AND name = N'SID_Index_CAMPUS')
    ALTER INDEX [SID_Index_CAMPUS] ON [dbo].[SID] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SID]') AND name = N'SID_Index_INCIDENT_TYPE')
    ALTER INDEX [SID_Index_INCIDENT_TYPE] ON [dbo].[SID] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SID"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SID"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SID> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SIDKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SIDKEY.Add(entity.SIDKEY);
            }

            builder.AppendLine("DELETE [dbo].[SID] WHERE");


            // Index_SIDKEY
            builder.Append("[SIDKEY] IN (");
            for (int index = 0; index < Index_SIDKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SIDKEY
                var parameterSIDKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSIDKEY);
                command.Parameters.Add(parameterSIDKEY, SqlDbType.Int).Value = Index_SIDKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SID data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SID data set</returns>
        public override EduHubDataSetDataReader<SID> GetDataSetDataReader()
        {
            return new SIDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SID data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SID data set</returns>
        public override EduHubDataSetDataReader<SID> GetDataSetDataReader(List<SID> Entities)
        {
            return new SIDDataReader(new EduHubDataSetLoadedReader<SID>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SIDDataReader : EduHubDataSetDataReader<SID>
        {
            public SIDDataReader(IEduHubDataSetReader<SID> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SIDKEY
                        return Current.SIDKEY;
                    case 1: // SID_DATE
                        return Current.SID_DATE;
                    case 2: // SID_TIME
                        return Current.SID_TIME;
                    case 3: // INCIDENT_TYPE
                        return Current.INCIDENT_TYPE;
                    case 4: // INCIDENT_DESC
                        return Current.INCIDENT_DESC;
                    case 5: // OFFICE_USE_ONLY
                        return Current.OFFICE_USE_ONLY;
                    case 6: // CAMPUS
                        return Current.CAMPUS;
                    case 7: // EXT_ADDRESS
                        return Current.EXT_ADDRESS;
                    case 8: // RESP_PERSON_TYPE
                        return Current.RESP_PERSON_TYPE;
                    case 9: // RESP_PERSON
                        return Current.RESP_PERSON;
                    case 10: // RESP_PERSON_NAME
                        return Current.RESP_PERSON_NAME;
                    case 11: // LW_DATE
                        return Current.LW_DATE;
                    case 12: // LW_TIME
                        return Current.LW_TIME;
                    case 13: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SID_DATE
                        return Current.SID_DATE == null;
                    case 2: // SID_TIME
                        return Current.SID_TIME == null;
                    case 3: // INCIDENT_TYPE
                        return Current.INCIDENT_TYPE == null;
                    case 4: // INCIDENT_DESC
                        return Current.INCIDENT_DESC == null;
                    case 5: // OFFICE_USE_ONLY
                        return Current.OFFICE_USE_ONLY == null;
                    case 6: // CAMPUS
                        return Current.CAMPUS == null;
                    case 7: // EXT_ADDRESS
                        return Current.EXT_ADDRESS == null;
                    case 8: // RESP_PERSON_TYPE
                        return Current.RESP_PERSON_TYPE == null;
                    case 9: // RESP_PERSON
                        return Current.RESP_PERSON == null;
                    case 10: // RESP_PERSON_NAME
                        return Current.RESP_PERSON_NAME == null;
                    case 11: // LW_DATE
                        return Current.LW_DATE == null;
                    case 12: // LW_TIME
                        return Current.LW_TIME == null;
                    case 13: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SIDKEY
                        return "SIDKEY";
                    case 1: // SID_DATE
                        return "SID_DATE";
                    case 2: // SID_TIME
                        return "SID_TIME";
                    case 3: // INCIDENT_TYPE
                        return "INCIDENT_TYPE";
                    case 4: // INCIDENT_DESC
                        return "INCIDENT_DESC";
                    case 5: // OFFICE_USE_ONLY
                        return "OFFICE_USE_ONLY";
                    case 6: // CAMPUS
                        return "CAMPUS";
                    case 7: // EXT_ADDRESS
                        return "EXT_ADDRESS";
                    case 8: // RESP_PERSON_TYPE
                        return "RESP_PERSON_TYPE";
                    case 9: // RESP_PERSON
                        return "RESP_PERSON";
                    case 10: // RESP_PERSON_NAME
                        return "RESP_PERSON_NAME";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SIDKEY":
                        return 0;
                    case "SID_DATE":
                        return 1;
                    case "SID_TIME":
                        return 2;
                    case "INCIDENT_TYPE":
                        return 3;
                    case "INCIDENT_DESC":
                        return 4;
                    case "OFFICE_USE_ONLY":
                        return 5;
                    case "CAMPUS":
                        return 6;
                    case "EXT_ADDRESS":
                        return 7;
                    case "RESP_PERSON_TYPE":
                        return 8;
                    case "RESP_PERSON":
                        return 9;
                    case "RESP_PERSON_NAME":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
