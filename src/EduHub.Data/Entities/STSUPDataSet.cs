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
    /// Support Persons Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSUPDataSet : EduHubDataSet<STSUP>
    {
        /// <inheritdoc />
        public override string Name { get { return "STSUP"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal STSUPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SKEY = new Lazy<Dictionary<string, IReadOnlyList<STSUP>>>(() => this.ToGroupedDictionary(i => i.SKEY));
            Index_SUPPORT_ROLE = new Lazy<NullDictionary<string, IReadOnlyList<STSUP>>>(() => this.ToGroupedNullDictionary(i => i.SUPPORT_ROLE));
            Index_TID = new Lazy<Dictionary<int, STSUP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSUP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSUP" /> fields for each CSV column header</returns>
        internal override Action<STSUP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSUP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SKEY":
                        mapper[i] = (e, v) => e.SKEY = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "SUPPORT_ROLE":
                        mapper[i] = (e, v) => e.SUPPORT_ROLE = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
                        break;
                    case "BUS_PHONE":
                        mapper[i] = (e, v) => e.BUS_PHONE = v;
                        break;
                    case "BUS_EMAIL":
                        mapper[i] = (e, v) => e.BUS_EMAIL = v;
                        break;
                    case "ADDED_BY":
                        mapper[i] = (e, v) => e.ADDED_BY = v;
                        break;
                    case "SUPPORT_SERVICES":
                        mapper[i] = (e, v) => e.SUPPORT_SERVICES = v;
                        break;
                    case "STUDENT_SUPPORT":
                        mapper[i] = (e, v) => e.STUDENT_SUPPORT = v;
                        break;
                    case "STUDENT_OTHER_SUPPORT":
                        mapper[i] = (e, v) => e.STUDENT_OTHER_SUPPORT = v;
                        break;
                    case "CHILD_PROTECTION":
                        mapper[i] = (e, v) => e.CHILD_PROTECTION = v;
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
        /// Merges <see cref="STSUP" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="STSUP" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="STSUP" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{STSUP}"/> of entities</returns>
        internal override IEnumerable<STSUP> ApplyDeltaEntities(IEnumerable<STSUP> Entities, List<STSUP> DeltaEntities)
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

        private Lazy<Dictionary<string, IReadOnlyList<STSUP>>> Index_SKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<STSUP>>> Index_SUPPORT_ROLE;
        private Lazy<Dictionary<int, STSUP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STSUP by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSUP</param>
        /// <returns>List of related STSUP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSUP> FindBySKEY(string SKEY)
        {
            return Index_SKEY.Value[SKEY];
        }

        /// <summary>
        /// Attempt to find STSUP by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSUP</param>
        /// <param name="Value">List of related STSUP entities</param>
        /// <returns>True if the list of related STSUP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySKEY(string SKEY, out IReadOnlyList<STSUP> Value)
        {
            return Index_SKEY.Value.TryGetValue(SKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STSUP by SKEY field
        /// </summary>
        /// <param name="SKEY">SKEY value used to find STSUP</param>
        /// <returns>List of related STSUP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSUP> TryFindBySKEY(string SKEY)
        {
            IReadOnlyList<STSUP> value;
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
        /// Find STSUP by SUPPORT_ROLE field
        /// </summary>
        /// <param name="SUPPORT_ROLE">SUPPORT_ROLE value used to find STSUP</param>
        /// <returns>List of related STSUP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSUP> FindBySUPPORT_ROLE(string SUPPORT_ROLE)
        {
            return Index_SUPPORT_ROLE.Value[SUPPORT_ROLE];
        }

        /// <summary>
        /// Attempt to find STSUP by SUPPORT_ROLE field
        /// </summary>
        /// <param name="SUPPORT_ROLE">SUPPORT_ROLE value used to find STSUP</param>
        /// <param name="Value">List of related STSUP entities</param>
        /// <returns>True if the list of related STSUP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPPORT_ROLE(string SUPPORT_ROLE, out IReadOnlyList<STSUP> Value)
        {
            return Index_SUPPORT_ROLE.Value.TryGetValue(SUPPORT_ROLE, out Value);
        }

        /// <summary>
        /// Attempt to find STSUP by SUPPORT_ROLE field
        /// </summary>
        /// <param name="SUPPORT_ROLE">SUPPORT_ROLE value used to find STSUP</param>
        /// <returns>List of related STSUP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSUP> TryFindBySUPPORT_ROLE(string SUPPORT_ROLE)
        {
            IReadOnlyList<STSUP> value;
            if (Index_SUPPORT_ROLE.Value.TryGetValue(SUPPORT_ROLE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSUP</param>
        /// <returns>Related STSUP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSUP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STSUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSUP</param>
        /// <param name="Value">Related STSUP entity</param>
        /// <returns>True if the related STSUP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STSUP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STSUP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSUP</param>
        /// <returns>Related STSUP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSUP TryFindByTID(int TID)
        {
            STSUP value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a STSUP table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[STSUP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[STSUP](
        [TID] int IDENTITY NOT NULL,
        [SKEY] varchar(10) NOT NULL,
        [FIRST_NAME] varchar(30) NULL,
        [SURNAME] varchar(30) NULL,
        [SUPPORT_ROLE] varchar(10) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [SUBURB] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [KAP_LINK] varchar(34) NULL,
        [BUS_PHONE] varchar(20) NULL,
        [BUS_EMAIL] varchar(60) NULL,
        [ADDED_BY] varchar(128) NULL,
        [SUPPORT_SERVICES] varchar(1) NULL,
        [STUDENT_SUPPORT] varchar(1) NULL,
        [STUDENT_OTHER_SUPPORT] varchar(1) NULL,
        [CHILD_PROTECTION] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [STSUP_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [STSUP_Index_SKEY] ON [dbo].[STSUP]
    (
            [SKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [STSUP_Index_SUPPORT_ROLE] ON [dbo].[STSUP]
    (
            [SUPPORT_ROLE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSUP]') AND name = N'STSUP_Index_SUPPORT_ROLE')
    ALTER INDEX [STSUP_Index_SUPPORT_ROLE] ON [dbo].[STSUP] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSUP]') AND name = N'STSUP_Index_TID')
    ALTER INDEX [STSUP_Index_TID] ON [dbo].[STSUP] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSUP]') AND name = N'STSUP_Index_SUPPORT_ROLE')
    ALTER INDEX [STSUP_Index_SUPPORT_ROLE] ON [dbo].[STSUP] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[STSUP]') AND name = N'STSUP_Index_TID')
    ALTER INDEX [STSUP_Index_TID] ON [dbo].[STSUP] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="STSUP"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="STSUP"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<STSUP> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[STSUP] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the STSUP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSUP data set</returns>
        public override EduHubDataSetDataReader<STSUP> GetDataSetDataReader()
        {
            return new STSUPDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the STSUP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the STSUP data set</returns>
        public override EduHubDataSetDataReader<STSUP> GetDataSetDataReader(List<STSUP> Entities)
        {
            return new STSUPDataReader(new EduHubDataSetLoadedReader<STSUP>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class STSUPDataReader : EduHubDataSetDataReader<STSUP>
        {
            public STSUPDataReader(IEduHubDataSetReader<STSUP> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 21; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SKEY
                        return Current.SKEY;
                    case 2: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 3: // SURNAME
                        return Current.SURNAME;
                    case 4: // SUPPORT_ROLE
                        return Current.SUPPORT_ROLE;
                    case 5: // ADDRESS01
                        return Current.ADDRESS01;
                    case 6: // ADDRESS02
                        return Current.ADDRESS02;
                    case 7: // SUBURB
                        return Current.SUBURB;
                    case 8: // STATE
                        return Current.STATE;
                    case 9: // POSTCODE
                        return Current.POSTCODE;
                    case 10: // KAP_LINK
                        return Current.KAP_LINK;
                    case 11: // BUS_PHONE
                        return Current.BUS_PHONE;
                    case 12: // BUS_EMAIL
                        return Current.BUS_EMAIL;
                    case 13: // ADDED_BY
                        return Current.ADDED_BY;
                    case 14: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES;
                    case 15: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT;
                    case 16: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT;
                    case 17: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION;
                    case 18: // LW_DATE
                        return Current.LW_DATE;
                    case 19: // LW_TIME
                        return Current.LW_TIME;
                    case 20: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 3: // SURNAME
                        return Current.SURNAME == null;
                    case 4: // SUPPORT_ROLE
                        return Current.SUPPORT_ROLE == null;
                    case 5: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 6: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 7: // SUBURB
                        return Current.SUBURB == null;
                    case 8: // STATE
                        return Current.STATE == null;
                    case 9: // POSTCODE
                        return Current.POSTCODE == null;
                    case 10: // KAP_LINK
                        return Current.KAP_LINK == null;
                    case 11: // BUS_PHONE
                        return Current.BUS_PHONE == null;
                    case 12: // BUS_EMAIL
                        return Current.BUS_EMAIL == null;
                    case 13: // ADDED_BY
                        return Current.ADDED_BY == null;
                    case 14: // SUPPORT_SERVICES
                        return Current.SUPPORT_SERVICES == null;
                    case 15: // STUDENT_SUPPORT
                        return Current.STUDENT_SUPPORT == null;
                    case 16: // STUDENT_OTHER_SUPPORT
                        return Current.STUDENT_OTHER_SUPPORT == null;
                    case 17: // CHILD_PROTECTION
                        return Current.CHILD_PROTECTION == null;
                    case 18: // LW_DATE
                        return Current.LW_DATE == null;
                    case 19: // LW_TIME
                        return Current.LW_TIME == null;
                    case 20: // LW_USER
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
                    case 2: // FIRST_NAME
                        return "FIRST_NAME";
                    case 3: // SURNAME
                        return "SURNAME";
                    case 4: // SUPPORT_ROLE
                        return "SUPPORT_ROLE";
                    case 5: // ADDRESS01
                        return "ADDRESS01";
                    case 6: // ADDRESS02
                        return "ADDRESS02";
                    case 7: // SUBURB
                        return "SUBURB";
                    case 8: // STATE
                        return "STATE";
                    case 9: // POSTCODE
                        return "POSTCODE";
                    case 10: // KAP_LINK
                        return "KAP_LINK";
                    case 11: // BUS_PHONE
                        return "BUS_PHONE";
                    case 12: // BUS_EMAIL
                        return "BUS_EMAIL";
                    case 13: // ADDED_BY
                        return "ADDED_BY";
                    case 14: // SUPPORT_SERVICES
                        return "SUPPORT_SERVICES";
                    case 15: // STUDENT_SUPPORT
                        return "STUDENT_SUPPORT";
                    case 16: // STUDENT_OTHER_SUPPORT
                        return "STUDENT_OTHER_SUPPORT";
                    case 17: // CHILD_PROTECTION
                        return "CHILD_PROTECTION";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
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
                    case "FIRST_NAME":
                        return 2;
                    case "SURNAME":
                        return 3;
                    case "SUPPORT_ROLE":
                        return 4;
                    case "ADDRESS01":
                        return 5;
                    case "ADDRESS02":
                        return 6;
                    case "SUBURB":
                        return 7;
                    case "STATE":
                        return 8;
                    case "POSTCODE":
                        return 9;
                    case "KAP_LINK":
                        return 10;
                    case "BUS_PHONE":
                        return 11;
                    case "BUS_EMAIL":
                        return 12;
                    case "ADDED_BY":
                        return 13;
                    case "SUPPORT_SERVICES":
                        return 14;
                    case "STUDENT_SUPPORT":
                        return 15;
                    case "STUDENT_OTHER_SUPPORT":
                        return 16;
                    case "CHILD_PROTECTION":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
