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
    /// Subject Book List Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUBLDataSet : EduHubDataSet<SUBL>
    {
        /// <inheritdoc />
        public override string Name { get { return "SUBL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SUBLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BLKEY = new Lazy<Dictionary<string, IReadOnlyList<SUBL>>>(() => this.ToGroupedDictionary(i => i.BLKEY));
            Index_BOOK = new Lazy<NullDictionary<string, IReadOnlyList<SUBL>>>(() => this.ToGroupedNullDictionary(i => i.BOOK));
            Index_TID = new Lazy<Dictionary<int, SUBL>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SUBL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SUBL" /> fields for each CSV column header</returns>
        internal override Action<SUBL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SUBL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BLKEY":
                        mapper[i] = (e, v) => e.BLKEY = v;
                        break;
                    case "BOOK":
                        mapper[i] = (e, v) => e.BOOK = v;
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "TAG":
                        mapper[i] = (e, v) => e.TAG = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NUMBER_REQUIRED":
                        mapper[i] = (e, v) => e.NUMBER_REQUIRED = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SUBL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SUBL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SUBL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SUBL}"/> of entities</returns>
        internal override IEnumerable<SUBL> ApplyDeltaEntities(IEnumerable<SUBL> Entities, List<SUBL> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.BLKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.BLKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SUBL>>> Index_BLKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SUBL>>> Index_BOOK;
        private Lazy<Dictionary<int, SUBL>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <returns>List of related SUBL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> FindByBLKEY(string BLKEY)
        {
            return Index_BLKEY.Value[BLKEY];
        }

        /// <summary>
        /// Attempt to find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <param name="Value">List of related SUBL entities</param>
        /// <returns>True if the list of related SUBL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBLKEY(string BLKEY, out IReadOnlyList<SUBL> Value)
        {
            return Index_BLKEY.Value.TryGetValue(BLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by BLKEY field
        /// </summary>
        /// <param name="BLKEY">BLKEY value used to find SUBL</param>
        /// <returns>List of related SUBL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> TryFindByBLKEY(string BLKEY)
        {
            IReadOnlyList<SUBL> value;
            if (Index_BLKEY.Value.TryGetValue(BLKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <returns>List of related SUBL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> FindByBOOK(string BOOK)
        {
            return Index_BOOK.Value[BOOK];
        }

        /// <summary>
        /// Attempt to find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <param name="Value">List of related SUBL entities</param>
        /// <returns>True if the list of related SUBL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBOOK(string BOOK, out IReadOnlyList<SUBL> Value)
        {
            return Index_BOOK.Value.TryGetValue(BOOK, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by BOOK field
        /// </summary>
        /// <param name="BOOK">BOOK value used to find SUBL</param>
        /// <returns>List of related SUBL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SUBL> TryFindByBOOK(string BOOK)
        {
            IReadOnlyList<SUBL> value;
            if (Index_BOOK.Value.TryGetValue(BOOK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <returns>Related SUBL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUBL FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <param name="Value">Related SUBL entity</param>
        /// <returns>True if the related SUBL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SUBL Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SUBL by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SUBL</param>
        /// <returns>Related SUBL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SUBL TryFindByTID(int TID)
        {
            SUBL value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SUBL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SUBL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SUBL](
        [TID] int IDENTITY NOT NULL,
        [BLKEY] varchar(5) NOT NULL,
        [BOOK] varchar(13) NULL,
        [TTPERIOD] varchar(6) NULL,
        [TAG] varchar(4) NULL,
        [SEMESTER] smallint NULL,
        [NUMBER_REQUIRED] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SUBL_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SUBL_Index_BLKEY] ON [dbo].[SUBL]
    (
            [BLKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SUBL_Index_BOOK] ON [dbo].[SUBL]
    (
            [BOOK] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SUBL]') AND name = N'SUBL_Index_BOOK')
    ALTER INDEX [SUBL_Index_BOOK] ON [dbo].[SUBL] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SUBL]') AND name = N'SUBL_Index_TID')
    ALTER INDEX [SUBL_Index_TID] ON [dbo].[SUBL] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SUBL]') AND name = N'SUBL_Index_BOOK')
    ALTER INDEX [SUBL_Index_BOOK] ON [dbo].[SUBL] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SUBL]') AND name = N'SUBL_Index_TID')
    ALTER INDEX [SUBL_Index_TID] ON [dbo].[SUBL] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SUBL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SUBL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SUBL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SUBL] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SUBL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SUBL data set</returns>
        public override EduHubDataSetDataReader<SUBL> GetDataSetDataReader()
        {
            return new SUBLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SUBL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SUBL data set</returns>
        public override EduHubDataSetDataReader<SUBL> GetDataSetDataReader(List<SUBL> Entities)
        {
            return new SUBLDataReader(new EduHubDataSetLoadedReader<SUBL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SUBLDataReader : EduHubDataSetDataReader<SUBL>
        {
            public SUBLDataReader(IEduHubDataSetReader<SUBL> Reader)
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
                    case 1: // BLKEY
                        return Current.BLKEY;
                    case 2: // BOOK
                        return Current.BOOK;
                    case 3: // TTPERIOD
                        return Current.TTPERIOD;
                    case 4: // TAG
                        return Current.TAG;
                    case 5: // SEMESTER
                        return Current.SEMESTER;
                    case 6: // NUMBER_REQUIRED
                        return Current.NUMBER_REQUIRED;
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
                    case 2: // BOOK
                        return Current.BOOK == null;
                    case 3: // TTPERIOD
                        return Current.TTPERIOD == null;
                    case 4: // TAG
                        return Current.TAG == null;
                    case 5: // SEMESTER
                        return Current.SEMESTER == null;
                    case 6: // NUMBER_REQUIRED
                        return Current.NUMBER_REQUIRED == null;
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
                    case 1: // BLKEY
                        return "BLKEY";
                    case 2: // BOOK
                        return "BOOK";
                    case 3: // TTPERIOD
                        return "TTPERIOD";
                    case 4: // TAG
                        return "TAG";
                    case 5: // SEMESTER
                        return "SEMESTER";
                    case 6: // NUMBER_REQUIRED
                        return "NUMBER_REQUIRED";
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
                    case "BLKEY":
                        return 1;
                    case "BOOK":
                        return 2;
                    case "TTPERIOD":
                        return 3;
                    case "TAG":
                        return 4;
                    case "SEMESTER":
                        return 5;
                    case "NUMBER_REQUIRED":
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
