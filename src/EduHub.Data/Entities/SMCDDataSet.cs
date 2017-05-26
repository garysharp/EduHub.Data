﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medication Doses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMCDDataSet : EduHubDataSet<SMCD>
    {
        /// <inheritdoc />
        public override string Name { get { return "SMCD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SMCDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SMCDKEY = new Lazy<Dictionary<int, IReadOnlyList<SMCD>>>(() => this.ToGroupedDictionary(i => i.SMCDKEY));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<SMCD>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, SMCD>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SMCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SMCD" /> fields for each CSV column header</returns>
        internal override Action<SMCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SMCD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SMCDKEY":
                        mapper[i] = (e, v) => e.SMCDKEY = int.Parse(v);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ADMIN_DATE":
                        mapper[i] = (e, v) => e.ADMIN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ADMIN_TIME":
                        mapper[i] = (e, v) => e.ADMIN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DOSE":
                        mapper[i] = (e, v) => e.DOSE = v;
                        break;
                    case "ADMIN_BY_OTHER":
                        mapper[i] = (e, v) => e.ADMIN_BY_OTHER = v;
                        break;
                    case "ADMIN_NOTES":
                        mapper[i] = (e, v) => e.ADMIN_NOTES = v;
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
        /// Merges <see cref="SMCD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SMCD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SMCD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SMCD}"/> of entities</returns>
        internal override IEnumerable<SMCD> ApplyDeltaEntities(IEnumerable<SMCD> Entities, List<SMCD> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SMCDKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SMCDKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, IReadOnlyList<SMCD>>> Index_SMCDKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SMCD>>> Index_STAFF;
        private Lazy<Dictionary<int, SMCD>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SMCD by SMCDKEY field
        /// </summary>
        /// <param name="SMCDKEY">SMCDKEY value used to find SMCD</param>
        /// <returns>List of related SMCD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMCD> FindBySMCDKEY(int SMCDKEY)
        {
            return Index_SMCDKEY.Value[SMCDKEY];
        }

        /// <summary>
        /// Attempt to find SMCD by SMCDKEY field
        /// </summary>
        /// <param name="SMCDKEY">SMCDKEY value used to find SMCD</param>
        /// <param name="Value">List of related SMCD entities</param>
        /// <returns>True if the list of related SMCD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySMCDKEY(int SMCDKEY, out IReadOnlyList<SMCD> Value)
        {
            return Index_SMCDKEY.Value.TryGetValue(SMCDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SMCD by SMCDKEY field
        /// </summary>
        /// <param name="SMCDKEY">SMCDKEY value used to find SMCD</param>
        /// <returns>List of related SMCD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMCD> TryFindBySMCDKEY(int SMCDKEY)
        {
            IReadOnlyList<SMCD> value;
            if (Index_SMCDKEY.Value.TryGetValue(SMCDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SMCD by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SMCD</param>
        /// <returns>List of related SMCD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMCD> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find SMCD by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SMCD</param>
        /// <param name="Value">List of related SMCD entities</param>
        /// <returns>True if the list of related SMCD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<SMCD> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find SMCD by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SMCD</param>
        /// <returns>List of related SMCD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SMCD> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<SMCD> value;
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
        /// Find SMCD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMCD</param>
        /// <returns>Related SMCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMCD FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SMCD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMCD</param>
        /// <param name="Value">Related SMCD entity</param>
        /// <returns>True if the related SMCD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SMCD Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SMCD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SMCD</param>
        /// <returns>Related SMCD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SMCD TryFindByTID(int TID)
        {
            SMCD value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SMCD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SMCD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SMCD](
        [TID] int IDENTITY NOT NULL,
        [SMCDKEY] int NOT NULL,
        [STAFF] varchar(4) NULL,
        [ADMIN_DATE] datetime NULL,
        [ADMIN_TIME] smallint NULL,
        [DOSE] varchar(30) NULL,
        [ADMIN_BY_OTHER] varchar(30) NULL,
        [ADMIN_NOTES] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SMCD_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SMCD_Index_SMCDKEY] ON [dbo].[SMCD]
    (
            [SMCDKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [SMCD_Index_STAFF] ON [dbo].[SMCD]
    (
            [STAFF] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMCD]') AND name = N'Index_STAFF')
    ALTER INDEX [Index_STAFF] ON [dbo].[SMCD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMCD]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SMCD] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMCD]') AND name = N'Index_STAFF')
    ALTER INDEX [Index_STAFF] ON [dbo].[SMCD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SMCD]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SMCD] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SMCD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SMCD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SMCD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SMCD] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SMCD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMCD data set</returns>
        public override EduHubDataSetDataReader<SMCD> GetDataSetDataReader()
        {
            return new SMCDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SMCD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SMCD data set</returns>
        public override EduHubDataSetDataReader<SMCD> GetDataSetDataReader(List<SMCD> Entities)
        {
            return new SMCDDataReader(new EduHubDataSetLoadedReader<SMCD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SMCDDataReader : EduHubDataSetDataReader<SMCD>
        {
            public SMCDDataReader(IEduHubDataSetReader<SMCD> Reader)
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
                    case 1: // SMCDKEY
                        return Current.SMCDKEY;
                    case 2: // STAFF
                        return Current.STAFF;
                    case 3: // ADMIN_DATE
                        return Current.ADMIN_DATE;
                    case 4: // ADMIN_TIME
                        return Current.ADMIN_TIME;
                    case 5: // DOSE
                        return Current.DOSE;
                    case 6: // ADMIN_BY_OTHER
                        return Current.ADMIN_BY_OTHER;
                    case 7: // ADMIN_NOTES
                        return Current.ADMIN_NOTES;
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
                    case 2: // STAFF
                        return Current.STAFF == null;
                    case 3: // ADMIN_DATE
                        return Current.ADMIN_DATE == null;
                    case 4: // ADMIN_TIME
                        return Current.ADMIN_TIME == null;
                    case 5: // DOSE
                        return Current.DOSE == null;
                    case 6: // ADMIN_BY_OTHER
                        return Current.ADMIN_BY_OTHER == null;
                    case 7: // ADMIN_NOTES
                        return Current.ADMIN_NOTES == null;
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
                    case 1: // SMCDKEY
                        return "SMCDKEY";
                    case 2: // STAFF
                        return "STAFF";
                    case 3: // ADMIN_DATE
                        return "ADMIN_DATE";
                    case 4: // ADMIN_TIME
                        return "ADMIN_TIME";
                    case 5: // DOSE
                        return "DOSE";
                    case 6: // ADMIN_BY_OTHER
                        return "ADMIN_BY_OTHER";
                    case 7: // ADMIN_NOTES
                        return "ADMIN_NOTES";
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
                    case "SMCDKEY":
                        return 1;
                    case "STAFF":
                        return 2;
                    case "ADMIN_DATE":
                        return 3;
                    case "ADMIN_TIME":
                        return 4;
                    case "DOSE":
                        return 5;
                    case "ADMIN_BY_OTHER":
                        return 6;
                    case "ADMIN_NOTES":
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
