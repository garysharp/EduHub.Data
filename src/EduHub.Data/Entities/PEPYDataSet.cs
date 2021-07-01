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
    /// Employee History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPYDataSet : EduHubDataSet<PEPY>
    {
        /// <inheritdoc />
        public override string Name { get { return "PEPY"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PEPYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPY>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_PURPOSE = new Lazy<NullDictionary<string, IReadOnlyList<PEPY>>>(() => this.ToGroupedNullDictionary(i => i.PURPOSE));
            Index_TID = new Lazy<Dictionary<int, PEPY>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPY" /> fields for each CSV column header</returns>
        internal override Action<PEPY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRANSDATE":
                        mapper[i] = (e, v) => e.TRANSDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "PURPOSE":
                        mapper[i] = (e, v) => e.PURPOSE = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
        /// Merges <see cref="PEPY" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PEPY" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PEPY" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PEPY}"/> of entities</returns>
        internal override IEnumerable<PEPY> ApplyDeltaEntities(IEnumerable<PEPY> Entities, List<PEPY> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEPY>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPY>>> Index_PURPOSE;
        private Lazy<Dictionary<int, PEPY>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <returns>List of related PEPY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <param name="Value">List of related PEPY entities</param>
        /// <returns>True if the list of related PEPY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPY> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <returns>List of related PEPY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPY> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <returns>List of related PEPY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> FindByPURPOSE(string PURPOSE)
        {
            return Index_PURPOSE.Value[PURPOSE];
        }

        /// <summary>
        /// Attempt to find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <param name="Value">List of related PEPY entities</param>
        /// <returns>True if the list of related PEPY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPURPOSE(string PURPOSE, out IReadOnlyList<PEPY> Value)
        {
            return Index_PURPOSE.Value.TryGetValue(PURPOSE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <returns>List of related PEPY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> TryFindByPURPOSE(string PURPOSE)
        {
            IReadOnlyList<PEPY> value;
            if (Index_PURPOSE.Value.TryGetValue(PURPOSE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <returns>Related PEPY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPY FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <param name="Value">Related PEPY entity</param>
        /// <returns>True if the related PEPY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPY Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <returns>Related PEPY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPY TryFindByTID(int TID)
        {
            PEPY value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PEPY table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEPY]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEPY](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [TRANSDATE] datetime NULL,
        [STAFF] varchar(10) NULL,
        [PURPOSE] varchar(6) NULL,
        [NOTES] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEPY_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEPY_Index_CODE] ON [dbo].[PEPY]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPY_Index_PURPOSE] ON [dbo].[PEPY]
    (
            [PURPOSE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPY]') AND name = N'Index_PURPOSE')
    ALTER INDEX [Index_PURPOSE] ON [dbo].[PEPY] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPY]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PEPY] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPY]') AND name = N'Index_PURPOSE')
    ALTER INDEX [Index_PURPOSE] ON [dbo].[PEPY] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPY]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PEPY] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PEPY"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PEPY"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PEPY> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PEPY] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the PEPY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPY data set</returns>
        public override EduHubDataSetDataReader<PEPY> GetDataSetDataReader()
        {
            return new PEPYDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEPY data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPY data set</returns>
        public override EduHubDataSetDataReader<PEPY> GetDataSetDataReader(List<PEPY> Entities)
        {
            return new PEPYDataReader(new EduHubDataSetLoadedReader<PEPY>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEPYDataReader : EduHubDataSetDataReader<PEPY>
        {
            public PEPYDataReader(IEduHubDataSetReader<PEPY> Reader)
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
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // TRANSDATE
                        return Current.TRANSDATE;
                    case 3: // STAFF
                        return Current.STAFF;
                    case 4: // PURPOSE
                        return Current.PURPOSE;
                    case 5: // NOTES
                        return Current.NOTES;
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
                    case 2: // TRANSDATE
                        return Current.TRANSDATE == null;
                    case 3: // STAFF
                        return Current.STAFF == null;
                    case 4: // PURPOSE
                        return Current.PURPOSE == null;
                    case 5: // NOTES
                        return Current.NOTES == null;
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
                    case 1: // CODE
                        return "CODE";
                    case 2: // TRANSDATE
                        return "TRANSDATE";
                    case 3: // STAFF
                        return "STAFF";
                    case 4: // PURPOSE
                        return "PURPOSE";
                    case 5: // NOTES
                        return "NOTES";
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
                    case "CODE":
                        return 1;
                    case "TRANSDATE":
                        return 2;
                    case "STAFF":
                        return 3;
                    case "PURPOSE":
                        return 4;
                    case "NOTES":
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
