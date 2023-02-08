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
    /// Sickbay Medication Administrations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIMDataSet : EduHubDataSet<SAIM>
    {
        /// <inheritdoc />
        public override string Name { get { return "SAIM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SAIMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INVOLVEMENTID = new Lazy<Dictionary<int, IReadOnlyList<SAIM>>>(() => this.ToGroupedDictionary(i => i.INVOLVEMENTID));
            Index_STAFF = new Lazy<NullDictionary<string, IReadOnlyList<SAIM>>>(() => this.ToGroupedNullDictionary(i => i.STAFF));
            Index_TID = new Lazy<Dictionary<int, SAIM>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAIM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAIM" /> fields for each CSV column header</returns>
        internal override Action<SAIM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAIM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INVOLVEMENTID":
                        mapper[i] = (e, v) => e.INVOLVEMENTID = int.Parse(v);
                        break;
                    case "MEDICATION":
                        mapper[i] = (e, v) => e.MEDICATION = v;
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "ADMIN_BY_OTHER":
                        mapper[i] = (e, v) => e.ADMIN_BY_OTHER = v;
                        break;
                    case "ADMIN_TIME":
                        mapper[i] = (e, v) => e.ADMIN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DOSE":
                        mapper[i] = (e, v) => e.DOSE = v;
                        break;
                    case "ADMIN_NOTES":
                        mapper[i] = (e, v) => e.ADMIN_NOTES = v;
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
        /// Merges <see cref="SAIM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SAIM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SAIM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SAIM}"/> of entities</returns>
        internal override IEnumerable<SAIM> ApplyDeltaEntities(IEnumerable<SAIM> Entities, List<SAIM> DeltaEntities)
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

        private Lazy<Dictionary<int, IReadOnlyList<SAIM>>> Index_INVOLVEMENTID;
        private Lazy<NullDictionary<string, IReadOnlyList<SAIM>>> Index_STAFF;
        private Lazy<Dictionary<int, SAIM>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <returns>List of related SAIM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> FindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            return Index_INVOLVEMENTID.Value[INVOLVEMENTID];
        }

        /// <summary>
        /// Attempt to find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <param name="Value">List of related SAIM entities</param>
        /// <returns>True if the list of related SAIM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINVOLVEMENTID(int INVOLVEMENTID, out IReadOnlyList<SAIM> Value)
        {
            return Index_INVOLVEMENTID.Value.TryGetValue(INVOLVEMENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by INVOLVEMENTID field
        /// </summary>
        /// <param name="INVOLVEMENTID">INVOLVEMENTID value used to find SAIM</param>
        /// <returns>List of related SAIM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> TryFindByINVOLVEMENTID(int INVOLVEMENTID)
        {
            IReadOnlyList<SAIM> value;
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
        /// Find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <returns>List of related SAIM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> FindBySTAFF(string STAFF)
        {
            return Index_STAFF.Value[STAFF];
        }

        /// <summary>
        /// Attempt to find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <param name="Value">List of related SAIM entities</param>
        /// <returns>True if the list of related SAIM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTAFF(string STAFF, out IReadOnlyList<SAIM> Value)
        {
            return Index_STAFF.Value.TryGetValue(STAFF, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by STAFF field
        /// </summary>
        /// <param name="STAFF">STAFF value used to find SAIM</param>
        /// <returns>List of related SAIM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAIM> TryFindBySTAFF(string STAFF)
        {
            IReadOnlyList<SAIM> value;
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
        /// Find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <returns>Related SAIM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAIM FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <param name="Value">Related SAIM entity</param>
        /// <returns>True if the related SAIM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SAIM Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SAIM by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SAIM</param>
        /// <returns>Related SAIM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAIM TryFindByTID(int TID)
        {
            SAIM value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SAIM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAIM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAIM](
        [TID] int IDENTITY NOT NULL,
        [INVOLVEMENTID] int NOT NULL,
        [MEDICATION] varchar(30) NULL,
        [STAFF] varchar(4) NULL,
        [ADMIN_BY_OTHER] varchar(30) NULL,
        [ADMIN_TIME] smallint NULL,
        [DOSE] varchar(30) NULL,
        [ADMIN_NOTES] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAIM_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SAIM_Index_INVOLVEMENTID] ON [dbo].[SAIM]
    (
            [INVOLVEMENTID] ASC
    );
    CREATE NONCLUSTERED INDEX [SAIM_Index_STAFF] ON [dbo].[SAIM]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAIM]') AND name = N'SAIM_Index_STAFF')
    ALTER INDEX [SAIM_Index_STAFF] ON [dbo].[SAIM] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAIM]') AND name = N'SAIM_Index_TID')
    ALTER INDEX [SAIM_Index_TID] ON [dbo].[SAIM] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAIM]') AND name = N'SAIM_Index_STAFF')
    ALTER INDEX [SAIM_Index_STAFF] ON [dbo].[SAIM] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAIM]') AND name = N'SAIM_Index_TID')
    ALTER INDEX [SAIM_Index_TID] ON [dbo].[SAIM] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SAIM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SAIM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SAIM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SAIM] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SAIM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAIM data set</returns>
        public override EduHubDataSetDataReader<SAIM> GetDataSetDataReader()
        {
            return new SAIMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAIM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAIM data set</returns>
        public override EduHubDataSetDataReader<SAIM> GetDataSetDataReader(List<SAIM> Entities)
        {
            return new SAIMDataReader(new EduHubDataSetLoadedReader<SAIM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAIMDataReader : EduHubDataSetDataReader<SAIM>
        {
            public SAIMDataReader(IEduHubDataSetReader<SAIM> Reader)
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
                    case 1: // INVOLVEMENTID
                        return Current.INVOLVEMENTID;
                    case 2: // MEDICATION
                        return Current.MEDICATION;
                    case 3: // STAFF
                        return Current.STAFF;
                    case 4: // ADMIN_BY_OTHER
                        return Current.ADMIN_BY_OTHER;
                    case 5: // ADMIN_TIME
                        return Current.ADMIN_TIME;
                    case 6: // DOSE
                        return Current.DOSE;
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
                    case 2: // MEDICATION
                        return Current.MEDICATION == null;
                    case 3: // STAFF
                        return Current.STAFF == null;
                    case 4: // ADMIN_BY_OTHER
                        return Current.ADMIN_BY_OTHER == null;
                    case 5: // ADMIN_TIME
                        return Current.ADMIN_TIME == null;
                    case 6: // DOSE
                        return Current.DOSE == null;
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
                    case 1: // INVOLVEMENTID
                        return "INVOLVEMENTID";
                    case 2: // MEDICATION
                        return "MEDICATION";
                    case 3: // STAFF
                        return "STAFF";
                    case 4: // ADMIN_BY_OTHER
                        return "ADMIN_BY_OTHER";
                    case 5: // ADMIN_TIME
                        return "ADMIN_TIME";
                    case 6: // DOSE
                        return "DOSE";
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
                    case "INVOLVEMENTID":
                        return 1;
                    case "MEDICATION":
                        return 2;
                    case "STAFF":
                        return 3;
                    case "ADMIN_BY_OTHER":
                        return 4;
                    case "ADMIN_TIME":
                        return 5;
                    case "DOSE":
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
#endif
