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
    /// Book Hire Records Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BKHRDataSet : EduHubDataSet<BKHR>
    {
        /// <inheritdoc />
        public override string Name { get { return "BKHR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal BKHRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKHRKEY = new Lazy<Dictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedDictionary(i => i.BKHRKEY));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_STUDENT = new Lazy<NullDictionary<string, IReadOnlyList<BKHR>>>(() => this.ToGroupedNullDictionary(i => i.STUDENT));
            Index_TID = new Lazy<Dictionary<int, BKHR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BKHR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BKHR" /> fields for each CSV column header</returns>
        internal override Action<BKHR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BKHR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "BKHRKEY":
                        mapper[i] = (e, v) => e.BKHRKEY = v;
                        break;
                    case "REF_NUMBER":
                        mapper[i] = (e, v) => e.REF_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STUDENT":
                        mapper[i] = (e, v) => e.STUDENT = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ISSUE_DATE":
                        mapper[i] = (e, v) => e.ISSUE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "DUE_DATE":
                        mapper[i] = (e, v) => e.DUE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "RETURNED_DATE":
                        mapper[i] = (e, v) => e.RETURNED_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CONDITION":
                        mapper[i] = (e, v) => e.CONDITION = v;
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
        /// Merges <see cref="BKHR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="BKHR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="BKHR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{BKHR}"/> of entities</returns>
        internal override IEnumerable<BKHR> ApplyDeltaEntities(IEnumerable<BKHR> Entities, List<BKHR> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.BKHRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.BKHRKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<BKHR>>> Index_BKHRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<BKHR>>> Index_STAFF;
        private Lazy<NullDictionary<string, IReadOnlyList<BKHR>>> Index_STUDENT;
        private Lazy<Dictionary<int, BKHR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindByBKHRKEY(string BKHRKEY)
        {
            return Index_BKHRKEY.Value[BKHRKEY];
        }

        /// <summary>
        /// Attempt to find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKHRKEY(string BKHRKEY, out IReadOnlyList<BKHR> Value)
        {
            return Index_BKHRKEY.Value.TryGetValue(BKHRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by BKHRKEY field
        /// </summary>
        /// <param name="BKHRKEY">BKHRKEY value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindByBKHRKEY(string BKHRKEY)
        {
            IReadOnlyList<BKHR> value;
            if (Index_BKHRKEY.Value.TryGetValue(BKHRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<BKHR> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<BKHR> value;
            if (Index_STAFF.Value.TryGetValue(STAFF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <returns>List of related BKHR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> FindBySTUDENT(string STUDENT)
        {
            return Index_STUDENT.Value[STUDENT];
        }

        /// <summary>
        /// Attempt to find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <param name="Value">List of related BKHR entities</param>
        /// <returns>True if the list of related BKHR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTUDENT(string STUDENT, out IReadOnlyList<BKHR> Value)
        {
            return Index_STUDENT.Value.TryGetValue(STUDENT, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by STUDENT field
        /// </summary>
        /// <param name="STUDENT">STUDENT value used to find BKHR</param>
        /// <returns>List of related BKHR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<BKHR> TryFindBySTUDENT(string STUDENT)
        {
            IReadOnlyList<BKHR> value;
            if (Index_STUDENT.Value.TryGetValue(STUDENT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <returns>Related BKHR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKHR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <param name="Value">Related BKHR entity</param>
        /// <returns>True if the related BKHR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out BKHR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find BKHR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find BKHR</param>
        /// <returns>Related BKHR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKHR TryFindByTID(int TID)
        {
            BKHR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a BKHR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[BKHR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[BKHR](
        [TID] int IDENTITY NOT NULL,
        [BKHRKEY] varchar(13) NOT NULL,
        [REF_NUMBER] smallint NULL,
        [STUDENT] varchar(10) NULL,
        [STAFF] varchar(4) NULL,
        [ISSUE_DATE] datetime NULL,
        [DUE_DATE] datetime NULL,
        [RETURNED_DATE] datetime NULL,
        [CONDITION] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [BKHR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [BKHR_Index_BKHRKEY] ON [dbo].[BKHR]
    (
            [BKHRKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [BKHR_Index_STAFF] ON [dbo].[BKHR]
    (
            [STAFF] ASC
    );
    CREATE NONCLUSTERED INDEX [BKHR_Index_STUDENT] ON [dbo].[BKHR]
    (
            [STUDENT] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[BKHR]') AND name = N'BKHR_Index_STAFF')
    ALTER INDEX [BKHR_Index_STAFF] ON [dbo].[BKHR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[BKHR]') AND name = N'BKHR_Index_STUDENT')
    ALTER INDEX [BKHR_Index_STUDENT] ON [dbo].[BKHR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[BKHR]') AND name = N'BKHR_Index_TID')
    ALTER INDEX [BKHR_Index_TID] ON [dbo].[BKHR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[BKHR]') AND name = N'BKHR_Index_STAFF')
    ALTER INDEX [BKHR_Index_STAFF] ON [dbo].[BKHR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[BKHR]') AND name = N'BKHR_Index_STUDENT')
    ALTER INDEX [BKHR_Index_STUDENT] ON [dbo].[BKHR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[BKHR]') AND name = N'BKHR_Index_TID')
    ALTER INDEX [BKHR_Index_TID] ON [dbo].[BKHR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="BKHR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="BKHR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<BKHR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[BKHR] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the BKHR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BKHR data set</returns>
        public override EduHubDataSetDataReader<BKHR> GetDataSetDataReader()
        {
            return new BKHRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the BKHR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the BKHR data set</returns>
        public override EduHubDataSetDataReader<BKHR> GetDataSetDataReader(List<BKHR> Entities)
        {
            return new BKHRDataReader(new EduHubDataSetLoadedReader<BKHR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class BKHRDataReader : EduHubDataSetDataReader<BKHR>
        {
            public BKHRDataReader(IEduHubDataSetReader<BKHR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 12; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // BKHRKEY
                        return Current.BKHRKEY;
                    case 2: // REF_NUMBER
                        return Current.REF_NUMBER;
                    case 3: // STUDENT
                        return Current.STUDENT;
                    case 4: // STAFF
                        return Current.STAFF;
                    case 5: // ISSUE_DATE
                        return Current.ISSUE_DATE;
                    case 6: // DUE_DATE
                        return Current.DUE_DATE;
                    case 7: // RETURNED_DATE
                        return Current.RETURNED_DATE;
                    case 8: // CONDITION
                        return Current.CONDITION;
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
                    case 2: // REF_NUMBER
                        return Current.REF_NUMBER == null;
                    case 3: // STUDENT
                        return Current.STUDENT == null;
                    case 4: // STAFF
                        return Current.STAFF == null;
                    case 5: // ISSUE_DATE
                        return Current.ISSUE_DATE == null;
                    case 6: // DUE_DATE
                        return Current.DUE_DATE == null;
                    case 7: // RETURNED_DATE
                        return Current.RETURNED_DATE == null;
                    case 8: // CONDITION
                        return Current.CONDITION == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // BKHRKEY
                        return "BKHRKEY";
                    case 2: // REF_NUMBER
                        return "REF_NUMBER";
                    case 3: // STUDENT
                        return "STUDENT";
                    case 4: // STAFF
                        return "STAFF";
                    case 5: // ISSUE_DATE
                        return "ISSUE_DATE";
                    case 6: // DUE_DATE
                        return "DUE_DATE";
                    case 7: // RETURNED_DATE
                        return "RETURNED_DATE";
                    case 8: // CONDITION
                        return "CONDITION";
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
                    case "TID":
                        return 0;
                    case "BKHRKEY":
                        return 1;
                    case "REF_NUMBER":
                        return 2;
                    case "STUDENT":
                        return 3;
                    case "STAFF":
                        return 4;
                    case "ISSUE_DATE":
                        return 5;
                    case "DUE_DATE":
                        return 6;
                    case "RETURNED_DATE":
                        return 7;
                    case "CONDITION":
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
