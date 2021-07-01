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
    /// Subject/Class Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGSCDataSet : EduHubDataSet<SGSC>
    {
        /// <inheritdoc />
        public override string Name { get { return "SGSC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SGSCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGSCKEY = new Lazy<Dictionary<string, IReadOnlyList<SGSC>>>(() => this.ToGroupedDictionary(i => i.SGSCKEY));
            Index_SULINK = new Lazy<NullDictionary<string, IReadOnlyList<SGSC>>>(() => this.ToGroupedNullDictionary(i => i.SULINK));
            Index_TID = new Lazy<Dictionary<int, SGSC>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGSC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGSC" /> fields for each CSV column header</returns>
        internal override Action<SGSC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGSC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGSCKEY":
                        mapper[i] = (e, v) => e.SGSCKEY = v;
                        break;
                    case "SULINK":
                        mapper[i] = (e, v) => e.SULINK = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
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
        /// Merges <see cref="SGSC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SGSC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SGSC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SGSC}"/> of entities</returns>
        internal override IEnumerable<SGSC> ApplyDeltaEntities(IEnumerable<SGSC> Entities, List<SGSC> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SGSCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SGSCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SGSC>>> Index_SGSCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SGSC>>> Index_SULINK;
        private Lazy<Dictionary<int, SGSC>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <returns>List of related SGSC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> FindBySGSCKEY(string SGSCKEY)
        {
            return Index_SGSCKEY.Value[SGSCKEY];
        }

        /// <summary>
        /// Attempt to find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <param name="Value">List of related SGSC entities</param>
        /// <returns>True if the list of related SGSC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGSCKEY(string SGSCKEY, out IReadOnlyList<SGSC> Value)
        {
            return Index_SGSCKEY.Value.TryGetValue(SGSCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <returns>List of related SGSC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> TryFindBySGSCKEY(string SGSCKEY)
        {
            IReadOnlyList<SGSC> value;
            if (Index_SGSCKEY.Value.TryGetValue(SGSCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <returns>List of related SGSC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> FindBySULINK(string SULINK)
        {
            return Index_SULINK.Value[SULINK];
        }

        /// <summary>
        /// Attempt to find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <param name="Value">List of related SGSC entities</param>
        /// <returns>True if the list of related SGSC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySULINK(string SULINK, out IReadOnlyList<SGSC> Value)
        {
            return Index_SULINK.Value.TryGetValue(SULINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <returns>List of related SGSC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> TryFindBySULINK(string SULINK)
        {
            IReadOnlyList<SGSC> value;
            if (Index_SULINK.Value.TryGetValue(SULINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <returns>Related SGSC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSC FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <param name="Value">Related SGSC entity</param>
        /// <returns>True if the related SGSC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGSC Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <returns>Related SGSC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSC TryFindByTID(int TID)
        {
            SGSC value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SGSC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGSC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGSC](
        [TID] int IDENTITY NOT NULL,
        [SGSCKEY] varchar(12) NOT NULL,
        [SULINK] varchar(5) NULL,
        [CLASS] smallint NULL,
        [TTPERIOD] varchar(8) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGSC_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SGSC_Index_SGSCKEY] ON [dbo].[SGSC]
    (
            [SGSCKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SGSC_Index_SULINK] ON [dbo].[SGSC]
    (
            [SULINK] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGSC]') AND name = N'Index_SULINK')
    ALTER INDEX [Index_SULINK] ON [dbo].[SGSC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGSC]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGSC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGSC]') AND name = N'Index_SULINK')
    ALTER INDEX [Index_SULINK] ON [dbo].[SGSC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGSC]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGSC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SGSC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SGSC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SGSC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SGSC] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SGSC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGSC data set</returns>
        public override EduHubDataSetDataReader<SGSC> GetDataSetDataReader()
        {
            return new SGSCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGSC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGSC data set</returns>
        public override EduHubDataSetDataReader<SGSC> GetDataSetDataReader(List<SGSC> Entities)
        {
            return new SGSCDataReader(new EduHubDataSetLoadedReader<SGSC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGSCDataReader : EduHubDataSetDataReader<SGSC>
        {
            public SGSCDataReader(IEduHubDataSetReader<SGSC> Reader)
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
                    case 1: // SGSCKEY
                        return Current.SGSCKEY;
                    case 2: // SULINK
                        return Current.SULINK;
                    case 3: // CLASS
                        return Current.CLASS;
                    case 4: // TTPERIOD
                        return Current.TTPERIOD;
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
                    case 2: // SULINK
                        return Current.SULINK == null;
                    case 3: // CLASS
                        return Current.CLASS == null;
                    case 4: // TTPERIOD
                        return Current.TTPERIOD == null;
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
                    case 1: // SGSCKEY
                        return "SGSCKEY";
                    case 2: // SULINK
                        return "SULINK";
                    case 3: // CLASS
                        return "CLASS";
                    case 4: // TTPERIOD
                        return "TTPERIOD";
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
                    case "SGSCKEY":
                        return 1;
                    case "SULINK":
                        return 2;
                    case "CLASS":
                        return 3;
                    case "TTPERIOD":
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
