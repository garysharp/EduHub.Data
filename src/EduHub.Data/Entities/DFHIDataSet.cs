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
    /// Family History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFHIDataSet : EduHubDataSet<DFHI>
    {
        /// <inheritdoc />
        public override string Name { get { return "DFHI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal DFHIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FKEY = new Lazy<Dictionary<string, IReadOnlyList<DFHI>>>(() => this.ToGroupedDictionary(i => i.FKEY));
            Index_TID = new Lazy<Dictionary<int, DFHI>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="DFHI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="DFHI" /> fields for each CSV column header</returns>
        internal override Action<DFHI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<DFHI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "FKEY":
                        mapper[i] = (e, v) => e.FKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HKEY":
                        mapper[i] = (e, v) => e.HKEY = v;
                        break;
                    case "NAME_A":
                        mapper[i] = (e, v) => e.NAME_A = v;
                        break;
                    case "SURNAME_A":
                        mapper[i] = (e, v) => e.SURNAME_A = v;
                        break;
                    case "TITLE_A":
                        mapper[i] = (e, v) => e.TITLE_A = v;
                        break;
                    case "GENDER_A":
                        mapper[i] = (e, v) => e.GENDER_A = v;
                        break;
                    case "NAME_B":
                        mapper[i] = (e, v) => e.NAME_B = v;
                        break;
                    case "SURNAME_B":
                        mapper[i] = (e, v) => e.SURNAME_B = v;
                        break;
                    case "TITLE_B":
                        mapper[i] = (e, v) => e.TITLE_B = v;
                        break;
                    case "GENDER_B":
                        mapper[i] = (e, v) => e.GENDER_B = v;
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
                        break;
                    case "GENDER_DESC_A":
                        mapper[i] = (e, v) => e.GENDER_DESC_A = v;
                        break;
                    case "GENDER_DESC_B":
                        mapper[i] = (e, v) => e.GENDER_DESC_B = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="DFHI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="DFHI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="DFHI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{DFHI}"/> of entities</returns>
        internal override IEnumerable<DFHI> ApplyDeltaEntities(IEnumerable<DFHI> Entities, List<DFHI> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.FKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.FKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<DFHI>>> Index_FKEY;
        private Lazy<Dictionary<int, DFHI>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <returns>List of related DFHI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFHI> FindByFKEY(string FKEY)
        {
            return Index_FKEY.Value[FKEY];
        }

        /// <summary>
        /// Attempt to find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <param name="Value">List of related DFHI entities</param>
        /// <returns>True if the list of related DFHI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFKEY(string FKEY, out IReadOnlyList<DFHI> Value)
        {
            return Index_FKEY.Value.TryGetValue(FKEY, out Value);
        }

        /// <summary>
        /// Attempt to find DFHI by FKEY field
        /// </summary>
        /// <param name="FKEY">FKEY value used to find DFHI</param>
        /// <returns>List of related DFHI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<DFHI> TryFindByFKEY(string FKEY)
        {
            IReadOnlyList<DFHI> value;
            if (Index_FKEY.Value.TryGetValue(FKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <returns>Related DFHI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFHI FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <param name="Value">Related DFHI entity</param>
        /// <returns>True if the related DFHI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out DFHI Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find DFHI by TID field
        /// </summary>
        /// <param name="TID">TID value used to find DFHI</param>
        /// <returns>Related DFHI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public DFHI TryFindByTID(int TID)
        {
            DFHI value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a DFHI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DFHI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[DFHI](
        [TID] int IDENTITY NOT NULL,
        [FKEY] varchar(10) NOT NULL,
        [CREATION_USER] varchar(128) NULL,
        [CREATION_DATE] datetime NULL,
        [CREATION_TIME] smallint NULL,
        [OBSOLETE_USER] varchar(128) NULL,
        [OBSOLETE_DATE] datetime NULL,
        [OBSOLETE_TIME] smallint NULL,
        [HKEY] varchar(10) NULL,
        [NAME_A] varchar(30) NULL,
        [SURNAME_A] varchar(30) NULL,
        [TITLE_A] varchar(4) NULL,
        [GENDER_A] varchar(1) NULL,
        [NAME_B] varchar(30) NULL,
        [SURNAME_B] varchar(30) NULL,
        [TITLE_B] varchar(4) NULL,
        [GENDER_B] varchar(1) NULL,
        [HOMEKEY] int NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(20) NULL,
        [CHANGE_MADE] varchar(230) NULL,
        [GENDER_DESC_A] varchar(100) NULL,
        [GENDER_DESC_B] varchar(100) NULL,
        CONSTRAINT [DFHI_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [DFHI_Index_FKEY] ON [dbo].[DFHI]
    (
            [FKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DFHI]') AND name = N'DFHI_Index_TID')
    ALTER INDEX [DFHI_Index_TID] ON [dbo].[DFHI] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[DFHI]') AND name = N'DFHI_Index_TID')
    ALTER INDEX [DFHI_Index_TID] ON [dbo].[DFHI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="DFHI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="DFHI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<DFHI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[DFHI] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the DFHI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DFHI data set</returns>
        public override EduHubDataSetDataReader<DFHI> GetDataSetDataReader()
        {
            return new DFHIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the DFHI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the DFHI data set</returns>
        public override EduHubDataSetDataReader<DFHI> GetDataSetDataReader(List<DFHI> Entities)
        {
            return new DFHIDataReader(new EduHubDataSetLoadedReader<DFHI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class DFHIDataReader : EduHubDataSetDataReader<DFHI>
        {
            public DFHIDataReader(IEduHubDataSetReader<DFHI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 27; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // FKEY
                        return Current.FKEY;
                    case 2: // CREATION_USER
                        return Current.CREATION_USER;
                    case 3: // CREATION_DATE
                        return Current.CREATION_DATE;
                    case 4: // CREATION_TIME
                        return Current.CREATION_TIME;
                    case 5: // OBSOLETE_USER
                        return Current.OBSOLETE_USER;
                    case 6: // OBSOLETE_DATE
                        return Current.OBSOLETE_DATE;
                    case 7: // OBSOLETE_TIME
                        return Current.OBSOLETE_TIME;
                    case 8: // HKEY
                        return Current.HKEY;
                    case 9: // NAME_A
                        return Current.NAME_A;
                    case 10: // SURNAME_A
                        return Current.SURNAME_A;
                    case 11: // TITLE_A
                        return Current.TITLE_A;
                    case 12: // GENDER_A
                        return Current.GENDER_A;
                    case 13: // NAME_B
                        return Current.NAME_B;
                    case 14: // SURNAME_B
                        return Current.SURNAME_B;
                    case 15: // TITLE_B
                        return Current.TITLE_B;
                    case 16: // GENDER_B
                        return Current.GENDER_B;
                    case 17: // HOMEKEY
                        return Current.HOMEKEY;
                    case 18: // ADDRESS01
                        return Current.ADDRESS01;
                    case 19: // ADDRESS02
                        return Current.ADDRESS02;
                    case 20: // ADDRESS03
                        return Current.ADDRESS03;
                    case 21: // STATE
                        return Current.STATE;
                    case 22: // POSTCODE
                        return Current.POSTCODE;
                    case 23: // TELEPHONE
                        return Current.TELEPHONE;
                    case 24: // CHANGE_MADE
                        return Current.CHANGE_MADE;
                    case 25: // GENDER_DESC_A
                        return Current.GENDER_DESC_A;
                    case 26: // GENDER_DESC_B
                        return Current.GENDER_DESC_B;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // CREATION_USER
                        return Current.CREATION_USER == null;
                    case 3: // CREATION_DATE
                        return Current.CREATION_DATE == null;
                    case 4: // CREATION_TIME
                        return Current.CREATION_TIME == null;
                    case 5: // OBSOLETE_USER
                        return Current.OBSOLETE_USER == null;
                    case 6: // OBSOLETE_DATE
                        return Current.OBSOLETE_DATE == null;
                    case 7: // OBSOLETE_TIME
                        return Current.OBSOLETE_TIME == null;
                    case 8: // HKEY
                        return Current.HKEY == null;
                    case 9: // NAME_A
                        return Current.NAME_A == null;
                    case 10: // SURNAME_A
                        return Current.SURNAME_A == null;
                    case 11: // TITLE_A
                        return Current.TITLE_A == null;
                    case 12: // GENDER_A
                        return Current.GENDER_A == null;
                    case 13: // NAME_B
                        return Current.NAME_B == null;
                    case 14: // SURNAME_B
                        return Current.SURNAME_B == null;
                    case 15: // TITLE_B
                        return Current.TITLE_B == null;
                    case 16: // GENDER_B
                        return Current.GENDER_B == null;
                    case 17: // HOMEKEY
                        return Current.HOMEKEY == null;
                    case 18: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 19: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 20: // ADDRESS03
                        return Current.ADDRESS03 == null;
                    case 21: // STATE
                        return Current.STATE == null;
                    case 22: // POSTCODE
                        return Current.POSTCODE == null;
                    case 23: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 24: // CHANGE_MADE
                        return Current.CHANGE_MADE == null;
                    case 25: // GENDER_DESC_A
                        return Current.GENDER_DESC_A == null;
                    case 26: // GENDER_DESC_B
                        return Current.GENDER_DESC_B == null;
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
                    case 1: // FKEY
                        return "FKEY";
                    case 2: // CREATION_USER
                        return "CREATION_USER";
                    case 3: // CREATION_DATE
                        return "CREATION_DATE";
                    case 4: // CREATION_TIME
                        return "CREATION_TIME";
                    case 5: // OBSOLETE_USER
                        return "OBSOLETE_USER";
                    case 6: // OBSOLETE_DATE
                        return "OBSOLETE_DATE";
                    case 7: // OBSOLETE_TIME
                        return "OBSOLETE_TIME";
                    case 8: // HKEY
                        return "HKEY";
                    case 9: // NAME_A
                        return "NAME_A";
                    case 10: // SURNAME_A
                        return "SURNAME_A";
                    case 11: // TITLE_A
                        return "TITLE_A";
                    case 12: // GENDER_A
                        return "GENDER_A";
                    case 13: // NAME_B
                        return "NAME_B";
                    case 14: // SURNAME_B
                        return "SURNAME_B";
                    case 15: // TITLE_B
                        return "TITLE_B";
                    case 16: // GENDER_B
                        return "GENDER_B";
                    case 17: // HOMEKEY
                        return "HOMEKEY";
                    case 18: // ADDRESS01
                        return "ADDRESS01";
                    case 19: // ADDRESS02
                        return "ADDRESS02";
                    case 20: // ADDRESS03
                        return "ADDRESS03";
                    case 21: // STATE
                        return "STATE";
                    case 22: // POSTCODE
                        return "POSTCODE";
                    case 23: // TELEPHONE
                        return "TELEPHONE";
                    case 24: // CHANGE_MADE
                        return "CHANGE_MADE";
                    case 25: // GENDER_DESC_A
                        return "GENDER_DESC_A";
                    case 26: // GENDER_DESC_B
                        return "GENDER_DESC_B";
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
                    case "FKEY":
                        return 1;
                    case "CREATION_USER":
                        return 2;
                    case "CREATION_DATE":
                        return 3;
                    case "CREATION_TIME":
                        return 4;
                    case "OBSOLETE_USER":
                        return 5;
                    case "OBSOLETE_DATE":
                        return 6;
                    case "OBSOLETE_TIME":
                        return 7;
                    case "HKEY":
                        return 8;
                    case "NAME_A":
                        return 9;
                    case "SURNAME_A":
                        return 10;
                    case "TITLE_A":
                        return 11;
                    case "GENDER_A":
                        return 12;
                    case "NAME_B":
                        return 13;
                    case "SURNAME_B":
                        return 14;
                    case "TITLE_B":
                        return 15;
                    case "GENDER_B":
                        return 16;
                    case "HOMEKEY":
                        return 17;
                    case "ADDRESS01":
                        return 18;
                    case "ADDRESS02":
                        return 19;
                    case "ADDRESS03":
                        return 20;
                    case "STATE":
                        return 21;
                    case "POSTCODE":
                        return 22;
                    case "TELEPHONE":
                        return 23;
                    case "CHANGE_MADE":
                        return 24;
                    case "GENDER_DESC_A":
                        return 25;
                    case "GENDER_DESC_B":
                        return 26;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
