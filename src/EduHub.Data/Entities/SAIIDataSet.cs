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
    /// Accident Involvement Injuries Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIIDataSet : EduHubDataSet<SAII>
    {
        /// <inheritdoc />
        public override string Name { get { return "SAII"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SAIIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INVOLVEMENTID = new Lazy<Dictionary<int, IReadOnlyList<SAII>>>(() => this.ToGroupedDictionary(i => i.INVOLVEMENTID));
            Index_TID = new Lazy<Dictionary<int, SAII>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAII" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAII" /> fields for each CSV column header</returns>
        internal override Action<SAII, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAII, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INVOLVEMENTID":
                        mapper[i] = (e, v) => e.INVOLVEMENTID = int.Parse(v);
                        break;
                    case "SEVERITY":
                        mapper[i] = (e, v) => e.SEVERITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SRI_TYPE":
                        mapper[i] = (e, v) => e.SRI_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NATURE":
                        mapper[i] = (e, v) => e.NATURE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OTHER_INFO":
                        mapper[i] = (e, v) => e.OTHER_INFO = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SAII" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SAII" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SAII" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SAII}"/> of entities</returns>
        internal override IEnumerable<SAII> ApplyDeltaEntities(IEnumerable<SAII> Entities, List<SAII> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.INVOLVEMENTID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.INVOLVEMENTID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, IReadOnlyList<SAII>>> Index_INVOLVEMENTID;
        private Lazy<Dictionary<int, SAII>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <returns>List of related SAII entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAII> FindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            return Index_INVOLVEMENTID.Value[INVOLVEMENTID];
        }

        /// <summary>
        /// Attempt to find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <param name="Value">List of related SAII entities</param>
        /// <returns>True if the list of related SAII entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINVOLVEMENTID(int INVOLVEMENTID, out IReadOnlyList<SAII> Value)
        {
            return Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SAII by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAII</param>
        /// <returns>List of related SAII entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAII> TryFindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            IReadOnlyList<SAII> value;
            if (Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <returns>Related SAII entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAII FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <param name="Value">Related SAII entity</param>
        /// <returns>True if the related SAII entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAII Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAII by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAII</param>
        /// <returns>Related SAII entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAII TryFindByTID(int TID)
        {
            SAII value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SAII table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAII]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAII](
        [TID] int IDENTITY NOT NULL,
        [INVOLVEMENTID] int NOT NULL,
        [SEVERITY] smallint NULL,
        [SRI_TYPE] smallint NULL,
        [NATURE] smallint NULL,
        [OTHER_INFO] varchar(MAX) NULL,
        [LOCATION] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAII_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SAII_Index_INVOLVEMENTID] ON [dbo].[SAII]
    (
            [INVOLVEMENTID] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAII]') AND name = N'SAII_Index_TID')
    ALTER INDEX [SAII_Index_TID] ON [dbo].[SAII] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAII]') AND name = N'SAII_Index_TID')
    ALTER INDEX [SAII_Index_TID] ON [dbo].[SAII] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SAII"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SAII"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SAII> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SAII] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SAII data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAII data set</returns>
        public override EduHubDataSetDataReader<SAII> GetDataSetDataReader()
        {
            return new SAIIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAII data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAII data set</returns>
        public override EduHubDataSetDataReader<SAII> GetDataSetDataReader(List<SAII> Entities)
        {
            return new SAIIDataReader(new EduHubDataSetLoadedReader<SAII>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAIIDataReader : EduHubDataSetDataReader<SAII>
        {
            public SAIIDataReader(IEduHubDataSetReader<SAII> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 10; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // INVOLVEMENTID
                        return Current.INVOLVEMENTID;
                    case 2: // SEVERITY
                        return Current.SEVERITY;
                    case 3: // SRI_TYPE
                        return Current.SRI_TYPE;
                    case 4: // NATURE
                        return Current.NATURE;
                    case 5: // OTHER_INFO
                        return Current.OTHER_INFO;
                    case 6: // LOCATION
                        return Current.LOCATION;
                    case 7: // LW_DATE
                        return Current.LW_DATE;
                    case 8: // LW_TIME
                        return Current.LW_TIME;
                    case 9: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SEVERITY
                        return Current.SEVERITY == null;
                    case 3: // SRI_TYPE
                        return Current.SRI_TYPE == null;
                    case 4: // NATURE
                        return Current.NATURE == null;
                    case 5: // OTHER_INFO
                        return Current.OTHER_INFO == null;
                    case 6: // LOCATION
                        return Current.LOCATION == null;
                    case 7: // LW_DATE
                        return Current.LW_DATE == null;
                    case 8: // LW_TIME
                        return Current.LW_TIME == null;
                    case 9: // LW_USER
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
                    case 1: // INVOLVEMENTID
                        return "INVOLVEMENTID";
                    case 2: // SEVERITY
                        return "SEVERITY";
                    case 3: // SRI_TYPE
                        return "SRI_TYPE";
                    case 4: // NATURE
                        return "NATURE";
                    case 5: // OTHER_INFO
                        return "OTHER_INFO";
                    case 6: // LOCATION
                        return "LOCATION";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
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
                    case "INVOLVEMENTID":
                        return 1;
                    case "SEVERITY":
                        return 2;
                    case "SRI_TYPE":
                        return 3;
                    case "NATURE":
                        return 4;
                    case "OTHER_INFO":
                        return 5;
                    case "LOCATION":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
