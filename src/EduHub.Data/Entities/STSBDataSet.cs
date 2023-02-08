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
    /// Family Invoice Allocations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSBDataSet : EduHubDataSet<STSB>
    {
        /// <inheritdoc />
        public override string Name { get { return "STSB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STSBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FAMILY = new Lazy<NullDictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedNullDictionary(i => i.FAMILY));
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_SPLIT_ITEM = new Lazy<NullDictionary<string, IReadOnlyList<STSB>>>(() => this.ToGroupedNullDictionary(i => i.SPLIT_ITEM));
            Index_TID = new Lazy<Dictionary<int, STSB>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSB" /> fields for each CSV column header</returns>
        internal override Action<STSB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "PERCENTAGE":
                        mapper[i] = (e, v) => e.PERCENTAGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SPLIT_ITEM":
                        mapper[i] = (e, v) => e.SPLIT_ITEM = v;
                        break;
                    case "ITEM_TYPE":
                        mapper[i] = (e, v) => e.ITEM_TYPE = v;
                        break;
                    case "SPLIT_ITEM_SU":
                        mapper[i] = (e, v) => e.SPLIT_ITEM_SU = v;
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
        /// Merges <see cref="STSB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STSB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STSB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STSB}"/> of entities</returns>
        internal override IEnumerable<STSB> ApplyDeltaEntities(IEnumerable<STSB> Entities, List<STSB> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<STSB>>> Index_FAMILY;
        private Lazy<Dictionary<string, IReadOnlyList<STSB>>> Index_SKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<STSB>>> Index_SPLIT_ITEM;
        private Lazy<Dictionary<int, STSB>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindByFAMILY(string FAMILY)
        {
            return Index_FAMILY.Value[FAMILY];
        }

        /// <summary>
        /// Attempt to find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFAMILY(string FAMILY, out IReadOnlyList<STSB> Value)
        {
            return Index_FAMILY.Value.TryGetValue(FAMILY, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by FAMILY field
        /// </summary>
        /// <param name="FAMILY">FAMILY value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindByFAMILY(string FAMILY)
        {
            IReadOnlyList<STSB> value;
            if (Index_FAMILY.Value.TryGetValue(FAMILY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STSB> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STSB> value;
            if (Index_SKEY.Value.TryGetValue(SKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <returns>List of related STSB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> FindBySPLIT_ITEM(string SPLIT_ITEM)
        {
            return Index_SPLIT_ITEM.Value[SPLIT_ITEM];
        }

        /// <summary>
        /// Attempt to find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <param name="Value">List of related STSB entities</param>
        /// <returns>True if the list of related STSB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPLIT_ITEM(string SPLIT_ITEM, out IReadOnlyList<STSB> Value)
        {
            return Index_SPLIT_ITEM.Value.TryGetValue(SPLIT_ITEM, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by SPLIT_ITEM field
        /// </summary>
        /// <param name="SPLIT_ITEM">SPLIT_ITEM value used to find STSB</param>
        /// <returns>List of related STSB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSB> TryFindBySPLIT_ITEM(string SPLIT_ITEM)
        {
            IReadOnlyList<STSB> value;
            if (Index_SPLIT_ITEM.Value.TryGetValue(SPLIT_ITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <returns>Related STSB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSB FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <param name="Value">Related STSB entity</param>
        /// <returns>True if the related STSB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STSB Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STSB by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSB</param>
        /// <returns>Related STSB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSB TryFindByTID(int TID)
        {
            STSB value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STSB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STSB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STSB](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [FAMILY] varchar(10) NULL,
        [PERCENTAGE] smallint NULL,
        [SPLIT_ITEM] varchar(10) NULL,
        [ITEM_TYPE] varchar(1) NULL,
        [SPLIT_ITEM_SU] varchar(5) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STSB_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [STSB_Index_FAMILY] ON [dbo].[STSB]
    (
            [FAMILY] ASC
    );
    CREATE CLUSTERED INDEX [STSB_Index_SKEY] ON [dbo].[STSB]
    (
            [SKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STSB_Index_SPLIT_ITEM] ON [dbo].[STSB]
    (
            [SPLIT_ITEM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSB]') AND name = N'STSB_Index_FAMILY')
    ALTER INDEX [STSB_Index_FAMILY] ON [dbo].[STSB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSB]') AND name = N'STSB_Index_SPLIT_ITEM')
    ALTER INDEX [STSB_Index_SPLIT_ITEM] ON [dbo].[STSB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSB]') AND name = N'STSB_Index_TID')
    ALTER INDEX [STSB_Index_TID] ON [dbo].[STSB] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSB]') AND name = N'STSB_Index_FAMILY')
    ALTER INDEX [STSB_Index_FAMILY] ON [dbo].[STSB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSB]') AND name = N'STSB_Index_SPLIT_ITEM')
    ALTER INDEX [STSB_Index_SPLIT_ITEM] ON [dbo].[STSB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSB]') AND name = N'STSB_Index_TID')
    ALTER INDEX [STSB_Index_TID] ON [dbo].[STSB] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STSB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STSB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STSB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STSB] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STSB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSB data set</returns>
        public override EduHubDataSetDataReader<STSB> GetDataSetDataReader()
        {
            return new STSBDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STSB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSB data set</returns>
        public override EduHubDataSetDataReader<STSB> GetDataSetDataReader(List<STSB> Entities)
        {
            return new STSBDataReader(new EduHubDataSetLoadedReader<STSB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STSBDataReader : EduHubDataSetDataReader<STSB>
        {
            public STSBDataReader(IEduHubDataSetReader<STSB> Reader)
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
                    case 1: // SKEY
                        return Current.SKEY;
                    case 2: // FAMILY
                        return Current.FAMILY;
                    case 3: // PERCENTAGE
                        return Current.PERCENTAGE;
                    case 4: // SPLIT_ITEM
                        return Current.SPLIT_ITEM;
                    case 5: // ITEM_TYPE
                        return Current.ITEM_TYPE;
                    case 6: // SPLIT_ITEM_SU
                        return Current.SPLIT_ITEM_SU;
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
                    case 2: // FAMILY
                        return Current.FAMILY == null;
                    case 3: // PERCENTAGE
                        return Current.PERCENTAGE == null;
                    case 4: // SPLIT_ITEM
                        return Current.SPLIT_ITEM == null;
                    case 5: // ITEM_TYPE
                        return Current.ITEM_TYPE == null;
                    case 6: // SPLIT_ITEM_SU
                        return Current.SPLIT_ITEM_SU == null;
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
                    case 1: // SKEY
                        return "SKEY";
                    case 2: // FAMILY
                        return "FAMILY";
                    case 3: // PERCENTAGE
                        return "PERCENTAGE";
                    case 4: // SPLIT_ITEM
                        return "SPLIT_ITEM";
                    case 5: // ITEM_TYPE
                        return "ITEM_TYPE";
                    case 6: // SPLIT_ITEM_SU
                        return "SPLIT_ITEM_SU";
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
                    case "SKEY":
                        return 1;
                    case "FAMILY":
                        return 2;
                    case "PERCENTAGE":
                        return 3;
                    case "SPLIT_ITEM":
                        return 4;
                    case "ITEM_TYPE":
                        return 5;
                    case "SPLIT_ITEM_SU":
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
