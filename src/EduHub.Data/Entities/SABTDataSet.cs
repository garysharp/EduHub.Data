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
    /// Billing Template Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SABTDataSet : EduHubDataSet<SABT>
    {
        /// <inheritdoc />
        public override string Name { get { return "SABT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SABTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SABT>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
            Index_SABTKEY = new Lazy<Dictionary<string, IReadOnlyList<SABT>>>(() => this.ToGroupedDictionary(i => i.SABTKEY));
            Index_TID = new Lazy<Dictionary<int, SABT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SABT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SABT" /> fields for each CSV column header</returns>
        internal override Action<SABT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SABT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SABTKEY":
                        mapper[i] = (e, v) => e.SABTKEY = v;
                        break;
                    case "LINKKEY":
                        mapper[i] = (e, v) => e.LINKKEY = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="SABT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SABT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SABT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SABT}"/> of entities</returns>
        internal override IEnumerable<SABT> ApplyDeltaEntities(IEnumerable<SABT> Entities, List<SABT> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SABTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SABTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SABT>>> Index_FEE_CODE;
        private Lazy<Dictionary<string, IReadOnlyList<SABT>>> Index_SABTKEY;
        private Lazy<Dictionary<int, SABT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <returns>List of related SABT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> FindByFEE_CODE(string FEE_CODE)
        {
            return Index_FEE_CODE.Value[FEE_CODE];
        }

        /// <summary>
        /// Attempt to find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <param name="Value">List of related SABT entities</param>
        /// <returns>True if the list of related SABT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE(string FEE_CODE, out IReadOnlyList<SABT> Value)
        {
            return Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <returns>List of related SABT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> TryFindByFEE_CODE(string FEE_CODE)
        {
            IReadOnlyList<SABT> value;
            if (Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <returns>List of related SABT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> FindBySABTKEY(string SABTKEY)
        {
            return Index_SABTKEY.Value[SABTKEY];
        }

        /// <summary>
        /// Attempt to find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <param name="Value">List of related SABT entities</param>
        /// <returns>True if the list of related SABT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySABTKEY(string SABTKEY, out IReadOnlyList<SABT> Value)
        {
            return Index_SABTKEY.Value.TryGetValue(SABTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <returns>List of related SABT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> TryFindBySABTKEY(string SABTKEY)
        {
            IReadOnlyList<SABT> value;
            if (Index_SABTKEY.Value.TryGetValue(SABTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <returns>Related SABT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SABT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <param name="Value">Related SABT entity</param>
        /// <returns>True if the related SABT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SABT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <returns>Related SABT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SABT TryFindByTID(int TID)
        {
            SABT value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SABT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SABT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SABT](
        [TID] int IDENTITY NOT NULL,
        [SABTKEY] varchar(10) NOT NULL,
        [LINKKEY] varchar(10) NULL,
        [FEE_CODE] varchar(10) NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SABT_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SABT_Index_FEE_CODE] ON [dbo].[SABT]
    (
            [FEE_CODE] ASC
    );
    CREATE CLUSTERED INDEX [SABT_Index_SABTKEY] ON [dbo].[SABT]
    (
            [SABTKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SABT]') AND name = N'Index_FEE_CODE')
    ALTER INDEX [Index_FEE_CODE] ON [dbo].[SABT] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SABT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SABT] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SABT]') AND name = N'Index_FEE_CODE')
    ALTER INDEX [Index_FEE_CODE] ON [dbo].[SABT] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SABT]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SABT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SABT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SABT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SABT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SABT] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SABT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SABT data set</returns>
        public override EduHubDataSetDataReader<SABT> GetDataSetDataReader()
        {
            return new SABTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SABT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SABT data set</returns>
        public override EduHubDataSetDataReader<SABT> GetDataSetDataReader(List<SABT> Entities)
        {
            return new SABTDataReader(new EduHubDataSetLoadedReader<SABT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SABTDataReader : EduHubDataSetDataReader<SABT>
        {
            public SABTDataReader(IEduHubDataSetReader<SABT> Reader)
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
                    case 1: // SABTKEY
                        return Current.SABTKEY;
                    case 2: // LINKKEY
                        return Current.LINKKEY;
                    case 3: // FEE_CODE
                        return Current.FEE_CODE;
                    case 4: // DESCRIPTION
                        return Current.DESCRIPTION;
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
                    case 2: // LINKKEY
                        return Current.LINKKEY == null;
                    case 3: // FEE_CODE
                        return Current.FEE_CODE == null;
                    case 4: // DESCRIPTION
                        return Current.DESCRIPTION == null;
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
                    case 1: // SABTKEY
                        return "SABTKEY";
                    case 2: // LINKKEY
                        return "LINKKEY";
                    case 3: // FEE_CODE
                        return "FEE_CODE";
                    case 4: // DESCRIPTION
                        return "DESCRIPTION";
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
                    case "SABTKEY":
                        return 1;
                    case "LINKKEY":
                        return 2;
                    case "FEE_CODE":
                        return 3;
                    case "DESCRIPTION":
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
