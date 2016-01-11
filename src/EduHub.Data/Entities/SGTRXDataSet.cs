using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Temporary Group Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGTRXDataSet : EduHubDataSet<SGTRX>
    {
        /// <inheritdoc />
        public override string Name { get { return "SGTRX"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SGTRXDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGTRXKEY = new Lazy<Dictionary<string, IReadOnlyList<SGTRX>>>(() => this.ToGroupedDictionary(i => i.SGTRXKEY));
            Index_TID = new Lazy<Dictionary<int, SGTRX>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGTRX" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGTRX" /> fields for each CSV column header</returns>
        internal override Action<SGTRX, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGTRX, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGTRXKEY":
                        mapper[i] = (e, v) => e.SGTRXKEY = v;
                        break;
                    case "TRXTYPE":
                        mapper[i] = (e, v) => e.TRXTYPE = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
                        break;
                    case "KGCLINK":
                        mapper[i] = (e, v) => e.KGCLINK = v;
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
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SGTRX" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SGTRX" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SGTRX" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SGTRX}"/> of entities</returns>
        internal override IEnumerable<SGTRX> ApplyDeltaEntities(IEnumerable<SGTRX> Entities, List<SGTRX> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SGTRXKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SGTRXKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SGTRX>>> Index_SGTRXKEY;
        private Lazy<Dictionary<int, SGTRX>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <returns>List of related SGTRX entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGTRX> FindBySGTRXKEY(string SGTRXKEY)
        {
            return Index_SGTRXKEY.Value[SGTRXKEY];
        }

        /// <summary>
        /// Attempt to find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <param name="Value">List of related SGTRX entities</param>
        /// <returns>True if the list of related SGTRX entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGTRXKEY(string SGTRXKEY, out IReadOnlyList<SGTRX> Value)
        {
            return Index_SGTRXKEY.Value.TryGetValue(SGTRXKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGTRX by SGTRXKEY field
        /// </summary>
        /// <param name="SGTRXKEY">SGTRXKEY value used to find SGTRX</param>
        /// <returns>List of related SGTRX entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGTRX> TryFindBySGTRXKEY(string SGTRXKEY)
        {
            IReadOnlyList<SGTRX> value;
            if (Index_SGTRXKEY.Value.TryGetValue(SGTRXKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <returns>Related SGTRX entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGTRX FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <param name="Value">Related SGTRX entity</param>
        /// <returns>True if the related SGTRX entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGTRX Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGTRX by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGTRX</param>
        /// <returns>Related SGTRX entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGTRX TryFindByTID(int TID)
        {
            SGTRX value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SGTRX table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGTRX]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGTRX](
        [TID] int IDENTITY NOT NULL,
        [SGTRXKEY] varchar(12) NOT NULL,
        [TRXTYPE] varchar(4) NULL,
        [SGLINK] varchar(10) NULL,
        [KGCLINK] varchar(10) NULL,
        [SULINK] varchar(5) NULL,
        [CLASS] smallint NULL,
        [TTPERIOD] varchar(6) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGTRX_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SGTRX_Index_SGTRXKEY] ON [dbo].[SGTRX]
    (
            [SGTRXKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGTRX]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGTRX] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGTRX]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGTRX] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SGTRX"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SGTRX"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SGTRX> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SGTRX] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SGTRX data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGTRX data set</returns>
        public override EduHubDataSetDataReader<SGTRX> GetDataSetDataReader()
        {
            return new SGTRXDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGTRX data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGTRX data set</returns>
        public override EduHubDataSetDataReader<SGTRX> GetDataSetDataReader(List<SGTRX> Entities)
        {
            return new SGTRXDataReader(new EduHubDataSetLoadedReader<SGTRX>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGTRXDataReader : EduHubDataSetDataReader<SGTRX>
        {
            public SGTRXDataReader(IEduHubDataSetReader<SGTRX> Reader)
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
                    case 1: // SGTRXKEY
                        return Current.SGTRXKEY;
                    case 2: // TRXTYPE
                        return Current.TRXTYPE;
                    case 3: // SGLINK
                        return Current.SGLINK;
                    case 4: // KGCLINK
                        return Current.KGCLINK;
                    case 5: // SULINK
                        return Current.SULINK;
                    case 6: // CLASS
                        return Current.CLASS;
                    case 7: // TTPERIOD
                        return Current.TTPERIOD;
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
                    case 2: // TRXTYPE
                        return Current.TRXTYPE == null;
                    case 3: // SGLINK
                        return Current.SGLINK == null;
                    case 4: // KGCLINK
                        return Current.KGCLINK == null;
                    case 5: // SULINK
                        return Current.SULINK == null;
                    case 6: // CLASS
                        return Current.CLASS == null;
                    case 7: // TTPERIOD
                        return Current.TTPERIOD == null;
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
                    case 1: // SGTRXKEY
                        return "SGTRXKEY";
                    case 2: // TRXTYPE
                        return "TRXTYPE";
                    case 3: // SGLINK
                        return "SGLINK";
                    case 4: // KGCLINK
                        return "KGCLINK";
                    case 5: // SULINK
                        return "SULINK";
                    case 6: // CLASS
                        return "CLASS";
                    case 7: // TTPERIOD
                        return "TTPERIOD";
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
                    case "SGTRXKEY":
                        return 1;
                    case "TRXTYPE":
                        return 2;
                    case "SGLINK":
                        return 3;
                    case "KGCLINK":
                        return 4;
                    case "SULINK":
                        return 5;
                    case "CLASS":
                        return 6;
                    case "TTPERIOD":
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
