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
    /// KCM Transfer Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCM_TFRDataSet : EduHubDataSet<KCM_TFR>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCM_TFR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCM_TFRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCM_TRANS_ID = new Lazy<NullDictionary<string, KCM_TFR>>(() => this.ToNullDictionary(i => i.KCM_TRANS_ID));
            Index_ORIG_SCHOOL = new Lazy<Dictionary<string, IReadOnlyList<KCM_TFR>>>(() => this.ToGroupedDictionary(i => i.ORIG_SCHOOL));
            Index_TID = new Lazy<Dictionary<int, KCM_TFR>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCM_TFR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCM_TFR" /> fields for each CSV column header</returns>
        internal override Action<KCM_TFR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCM_TFR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "ORIG_SCHOOL":
                        mapper[i] = (e, v) => e.ORIG_SCHOOL = v;
                        break;
                    case "KCM_TRANS_ID":
                        mapper[i] = (e, v) => e.KCM_TRANS_ID = v;
                        break;
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
                        break;
                    case "KCMKEY_NEW":
                        mapper[i] = (e, v) => e.KCMKEY_NEW = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "IMP_STATUS":
                        mapper[i] = (e, v) => e.IMP_STATUS = v;
                        break;
                    case "IMP_DATE":
                        mapper[i] = (e, v) => e.IMP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="KCM_TFR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCM_TFR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCM_TFR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCM_TFR}"/> of entities</returns>
        internal override IEnumerable<KCM_TFR> ApplyDeltaEntities(IEnumerable<KCM_TFR> Entities, List<KCM_TFR> DeltaEntities)
        {
            HashSet<string> Index_KCM_TRANS_ID = new HashSet<string>(DeltaEntities.Select(i => i.KCM_TRANS_ID));
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ORIG_SCHOOL;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = false;
                            overwritten = overwritten || Index_KCM_TRANS_ID.Remove(entity.KCM_TRANS_ID);
                            overwritten = overwritten || Index_TID.Remove(entity.TID);
                            
                            if (entity.ORIG_SCHOOL.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, KCM_TFR>> Index_KCM_TRANS_ID;
        private Lazy<Dictionary<string, IReadOnlyList<KCM_TFR>>> Index_ORIG_SCHOOL;
        private Lazy<Dictionary<int, KCM_TFR>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR FindByKCM_TRANS_ID(string KCM_TRANS_ID)
        {
            return Index_KCM_TRANS_ID.Value[KCM_TRANS_ID];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <param name="Value">Related KCM_TFR entity</param>
        /// <returns>True if the related KCM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCM_TRANS_ID(string KCM_TRANS_ID, out KCM_TFR Value)
        {
            return Index_KCM_TRANS_ID.Value.TryGetValue(KCM_TRANS_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by KCM_TRANS_ID field
        /// </summary>
        /// <param name="KCM_TRANS_ID">KCM_TRANS_ID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR TryFindByKCM_TRANS_ID(string KCM_TRANS_ID)
        {
            KCM_TFR value;
            if (Index_KCM_TRANS_ID.Value.TryGetValue(KCM_TRANS_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <returns>List of related KCM_TFR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM_TFR> FindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            return Index_ORIG_SCHOOL.Value[ORIG_SCHOOL];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <param name="Value">List of related KCM_TFR entities</param>
        /// <returns>True if the list of related KCM_TFR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByORIG_SCHOOL(string ORIG_SCHOOL, out IReadOnlyList<KCM_TFR> Value)
        {
            return Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by ORIG_SCHOOL field
        /// </summary>
        /// <param name="ORIG_SCHOOL">ORIG_SCHOOL value used to find KCM_TFR</param>
        /// <returns>List of related KCM_TFR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KCM_TFR> TryFindByORIG_SCHOOL(string ORIG_SCHOOL)
        {
            IReadOnlyList<KCM_TFR> value;
            if (Index_ORIG_SCHOOL.Value.TryGetValue(ORIG_SCHOOL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <param name="Value">Related KCM_TFR entity</param>
        /// <returns>True if the related KCM_TFR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out KCM_TFR Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find KCM_TFR by TID field
        /// </summary>
        /// <param name="TID">TID value used to find KCM_TFR</param>
        /// <returns>Related KCM_TFR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCM_TFR TryFindByTID(int TID)
        {
            KCM_TFR value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCM_TFR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCM_TFR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCM_TFR](
        [TID] int IDENTITY NOT NULL,
        [ORIG_SCHOOL] varchar(8) NOT NULL,
        [KCM_TRANS_ID] varchar(30) NULL,
        [KCMKEY] varchar(10) NULL,
        [KCMKEY_NEW] varchar(10) NULL,
        [DESCRIPTION] varchar(30) NULL,
        [DISABILITY] varchar(1) NULL,
        [IMP_STATUS] varchar(15) NULL,
        [IMP_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCM_TFR_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KCM_TFR_Index_KCM_TRANS_ID] ON [dbo].[KCM_TFR]
    (
            [KCM_TRANS_ID] ASC
    );
    CREATE CLUSTERED INDEX [KCM_TFR_Index_ORIG_SCHOOL] ON [dbo].[KCM_TFR]
    (
            [ORIG_SCHOOL] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCM_TFR]') AND name = N'Index_KCM_TRANS_ID')
    ALTER INDEX [Index_KCM_TRANS_ID] ON [dbo].[KCM_TFR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCM_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[KCM_TFR] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCM_TFR]') AND name = N'Index_KCM_TRANS_ID')
    ALTER INDEX [Index_KCM_TRANS_ID] ON [dbo].[KCM_TFR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KCM_TFR]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[KCM_TFR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCM_TFR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCM_TFR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCM_TFR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KCM_TRANS_ID = new List<string>();
            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KCM_TRANS_ID.Add(entity.KCM_TRANS_ID);
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[KCM_TFR] WHERE");


            // Index_KCM_TRANS_ID
            builder.Append("[KCM_TRANS_ID] IN (");
            for (int index = 0; index < Index_KCM_TRANS_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KCM_TRANS_ID
                var parameterKCM_TRANS_ID = $"@p{parameterIndex++}";
                builder.Append(parameterKCM_TRANS_ID);
                command.Parameters.Add(parameterKCM_TRANS_ID, SqlDbType.VarChar, 30).Value = (object)Index_KCM_TRANS_ID[index] ?? DBNull.Value;
            }
            builder.AppendLine(") OR");

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
        /// Provides a <see cref="IDataReader"/> for the KCM_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCM_TFR data set</returns>
        public override EduHubDataSetDataReader<KCM_TFR> GetDataSetDataReader()
        {
            return new KCM_TFRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCM_TFR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCM_TFR data set</returns>
        public override EduHubDataSetDataReader<KCM_TFR> GetDataSetDataReader(List<KCM_TFR> Entities)
        {
            return new KCM_TFRDataReader(new EduHubDataSetLoadedReader<KCM_TFR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCM_TFRDataReader : EduHubDataSetDataReader<KCM_TFR>
        {
            public KCM_TFRDataReader(IEduHubDataSetReader<KCM_TFR> Reader)
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
                    case 1: // ORIG_SCHOOL
                        return Current.ORIG_SCHOOL;
                    case 2: // KCM_TRANS_ID
                        return Current.KCM_TRANS_ID;
                    case 3: // KCMKEY
                        return Current.KCMKEY;
                    case 4: // KCMKEY_NEW
                        return Current.KCMKEY_NEW;
                    case 5: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 6: // DISABILITY
                        return Current.DISABILITY;
                    case 7: // IMP_STATUS
                        return Current.IMP_STATUS;
                    case 8: // IMP_DATE
                        return Current.IMP_DATE;
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
                    case 2: // KCM_TRANS_ID
                        return Current.KCM_TRANS_ID == null;
                    case 3: // KCMKEY
                        return Current.KCMKEY == null;
                    case 4: // KCMKEY_NEW
                        return Current.KCMKEY_NEW == null;
                    case 5: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 6: // DISABILITY
                        return Current.DISABILITY == null;
                    case 7: // IMP_STATUS
                        return Current.IMP_STATUS == null;
                    case 8: // IMP_DATE
                        return Current.IMP_DATE == null;
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
                    case 1: // ORIG_SCHOOL
                        return "ORIG_SCHOOL";
                    case 2: // KCM_TRANS_ID
                        return "KCM_TRANS_ID";
                    case 3: // KCMKEY
                        return "KCMKEY";
                    case 4: // KCMKEY_NEW
                        return "KCMKEY_NEW";
                    case 5: // DESCRIPTION
                        return "DESCRIPTION";
                    case 6: // DISABILITY
                        return "DISABILITY";
                    case 7: // IMP_STATUS
                        return "IMP_STATUS";
                    case 8: // IMP_DATE
                        return "IMP_DATE";
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
                    case "ORIG_SCHOOL":
                        return 1;
                    case "KCM_TRANS_ID":
                        return 2;
                    case "KCMKEY":
                        return 3;
                    case "KCMKEY_NEW":
                        return 4;
                    case "DESCRIPTION":
                        return 5;
                    case "DISABILITY":
                        return 6;
                    case "IMP_STATUS":
                        return 7;
                    case "IMP_DATE":
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
