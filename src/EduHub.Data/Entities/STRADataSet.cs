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
    /// Multiple Day Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STRADataSet : EduHubDataSet<STRA>
    {
        /// <inheritdoc />
        public override string Name { get { return "STRA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STRADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ABS_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<STRA>>>(() => this.ToGroupedNullDictionary(i => i.ABS_TYPE));
            Index_STKEY = new Lazy<Dictionary<string, IReadOnlyList<STRA>>>(() => this.ToGroupedDictionary(i => i.STKEY));
            Index_TID = new Lazy<Dictionary<int, STRA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STRA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STRA" /> fields for each CSV column header</returns>
        internal override Action<STRA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STRA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "START_AM_PM":
                        mapper[i] = (e, v) => e.START_AM_PM = v;
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "END_AM_PM":
                        mapper[i] = (e, v) => e.END_AM_PM = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "ABS_TYPE":
                        mapper[i] = (e, v) => e.ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_PERIOD":
                        mapper[i] = (e, v) => e.START_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_PERIOD":
                        mapper[i] = (e, v) => e.END_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v;
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
        /// Merges <see cref="STRA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STRA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STRA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STRA}"/> of entities</returns>
        internal override IEnumerable<STRA> ApplyDeltaEntities(IEnumerable<STRA> Entities, List<STRA> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.STKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.STKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<short?, IReadOnlyList<STRA>>> Index_ABS_TYPE;
        private Lazy<Dictionary<string, IReadOnlyList<STRA>>> Index_STKEY;
        private Lazy<Dictionary<int, STRA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <returns>List of related STRA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> FindByABS_TYPE(short? ABS_TYPE)
        {
            return Index_ABS_TYPE.Value[ABS_TYPE];
        }

        /// <summary>
        /// Attempt to find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <param name="Value">List of related STRA entities</param>
        /// <returns>True if the list of related STRA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByABS_TYPE(short? ABS_TYPE, out IReadOnlyList<STRA> Value)
        {
            return Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <returns>List of related STRA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> TryFindByABS_TYPE(short? ABS_TYPE)
        {
            IReadOnlyList<STRA> value;
            if (Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <returns>List of related STRA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> FindBySTKEY(string STKEY)
        {
            return Index_STKEY.Value[STKEY];
        }

        /// <summary>
        /// Attempt to find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <param name="Value">List of related STRA entities</param>
        /// <returns>True if the list of related STRA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY(string STKEY, out IReadOnlyList<STRA> Value)
        {
            return Index_STKEY.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <returns>List of related STRA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> TryFindBySTKEY(string STKEY)
        {
            IReadOnlyList<STRA> value;
            if (Index_STKEY.Value.TryGetValue(STKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <returns>Related STRA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STRA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <param name="Value">Related STRA entity</param>
        /// <returns>True if the related STRA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STRA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <returns>Related STRA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STRA TryFindByTID(int TID)
        {
            STRA value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STRA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STRA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STRA](
        [TID] int IDENTITY NOT NULL,
        [STKEY] varchar(10) NOT NULL,
        [START_DATE] datetime NULL,
        [START_AM_PM] varchar(1) NULL,
        [END_DATE] datetime NULL,
        [END_AM_PM] varchar(1) NULL,
        [COMMENTS] varchar(30) NULL,
        [ABS_TYPE] smallint NULL,
        [START_PERIOD] smallint NULL,
        [END_PERIOD] smallint NULL,
        [FREQUENCY] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STRA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STRA_Index_ABS_TYPE] ON [dbo].[STRA]
    (
            [ABS_TYPE] ASC
    );
    CREATE CLUSTERED INDEX [STRA_Index_STKEY] ON [dbo].[STRA]
    (
            [STKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRA]') AND name = N'Index_ABS_TYPE')
    ALTER INDEX [Index_ABS_TYPE] ON [dbo].[STRA] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRA]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STRA] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRA]') AND name = N'Index_ABS_TYPE')
    ALTER INDEX [Index_ABS_TYPE] ON [dbo].[STRA] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STRA]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[STRA] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STRA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STRA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STRA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STRA] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STRA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STRA data set</returns>
        public override EduHubDataSetDataReader<STRA> GetDataSetDataReader()
        {
            return new STRADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STRA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STRA data set</returns>
        public override EduHubDataSetDataReader<STRA> GetDataSetDataReader(List<STRA> Entities)
        {
            return new STRADataReader(new EduHubDataSetLoadedReader<STRA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STRADataReader : EduHubDataSetDataReader<STRA>
        {
            public STRADataReader(IEduHubDataSetReader<STRA> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // STKEY
                        return Current.STKEY;
                    case 2: // START_DATE
                        return Current.START_DATE;
                    case 3: // START_AM_PM
                        return Current.START_AM_PM;
                    case 4: // END_DATE
                        return Current.END_DATE;
                    case 5: // END_AM_PM
                        return Current.END_AM_PM;
                    case 6: // COMMENTS
                        return Current.COMMENTS;
                    case 7: // ABS_TYPE
                        return Current.ABS_TYPE;
                    case 8: // START_PERIOD
                        return Current.START_PERIOD;
                    case 9: // END_PERIOD
                        return Current.END_PERIOD;
                    case 10: // FREQUENCY
                        return Current.FREQUENCY;
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
                    case 2: // START_DATE
                        return Current.START_DATE == null;
                    case 3: // START_AM_PM
                        return Current.START_AM_PM == null;
                    case 4: // END_DATE
                        return Current.END_DATE == null;
                    case 5: // END_AM_PM
                        return Current.END_AM_PM == null;
                    case 6: // COMMENTS
                        return Current.COMMENTS == null;
                    case 7: // ABS_TYPE
                        return Current.ABS_TYPE == null;
                    case 8: // START_PERIOD
                        return Current.START_PERIOD == null;
                    case 9: // END_PERIOD
                        return Current.END_PERIOD == null;
                    case 10: // FREQUENCY
                        return Current.FREQUENCY == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // STKEY
                        return "STKEY";
                    case 2: // START_DATE
                        return "START_DATE";
                    case 3: // START_AM_PM
                        return "START_AM_PM";
                    case 4: // END_DATE
                        return "END_DATE";
                    case 5: // END_AM_PM
                        return "END_AM_PM";
                    case 6: // COMMENTS
                        return "COMMENTS";
                    case 7: // ABS_TYPE
                        return "ABS_TYPE";
                    case 8: // START_PERIOD
                        return "START_PERIOD";
                    case 9: // END_PERIOD
                        return "END_PERIOD";
                    case 10: // FREQUENCY
                        return "FREQUENCY";
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
                    case "TID":
                        return 0;
                    case "STKEY":
                        return 1;
                    case "START_DATE":
                        return 2;
                    case "START_AM_PM":
                        return 3;
                    case "END_DATE":
                        return 4;
                    case "END_AM_PM":
                        return 5;
                    case "COMMENTS":
                        return 6;
                    case "ABS_TYPE":
                        return 7;
                    case "START_PERIOD":
                        return 8;
                    case "END_PERIOD":
                        return 9;
                    case "FREQUENCY":
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
