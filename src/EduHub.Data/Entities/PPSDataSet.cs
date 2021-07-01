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
    /// PAYG Supplier Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PPSDataSet : EduHubDataSet<PPS>
    {
        /// <inheritdoc />
        public override string Name { get { return "PPS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PPSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPS>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_POSTAL_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPS>>>(() => this.ToGroupedNullDictionary(i => i.POSTAL_COUNTRY));
            Index_PPSKEY = new Lazy<Dictionary<string, PPS>>(() => this.ToDictionary(i => i.PPSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PPS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PPS" /> fields for each CSV column header</returns>
        internal override Action<PPS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PPS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PPSKEY":
                        mapper[i] = (e, v) => e.PPSKEY = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "CONTACT_NAME":
                        mapper[i] = (e, v) => e.CONTACT_NAME = v;
                        break;
                    case "CONTACT_PHONE":
                        mapper[i] = (e, v) => e.CONTACT_PHONE = v;
                        break;
                    case "FACSIMILE":
                        mapper[i] = (e, v) => e.FACSIMILE = v;
                        break;
                    case "FILE_REFERENCE":
                        mapper[i] = (e, v) => e.FILE_REFERENCE = v;
                        break;
                    case "L1_ADDRESS":
                        mapper[i] = (e, v) => e.L1_ADDRESS = v;
                        break;
                    case "L2_ADDRESS":
                        mapper[i] = (e, v) => e.L2_ADDRESS = v;
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
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "POSTAL_L1_ADD":
                        mapper[i] = (e, v) => e.POSTAL_L1_ADD = v;
                        break;
                    case "POSTAL_L2_ADD":
                        mapper[i] = (e, v) => e.POSTAL_L2_ADD = v;
                        break;
                    case "POSTAL_SUBURB":
                        mapper[i] = (e, v) => e.POSTAL_SUBURB = v;
                        break;
                    case "POSTAL_STATE":
                        mapper[i] = (e, v) => e.POSTAL_STATE = v;
                        break;
                    case "POSTAL_POSTCODE":
                        mapper[i] = (e, v) => e.POSTAL_POSTCODE = v;
                        break;
                    case "POSTAL_COUNTRY":
                        mapper[i] = (e, v) => e.POSTAL_COUNTRY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
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
        /// Merges <see cref="PPS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PPS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PPS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PPS}"/> of entities</returns>
        internal override IEnumerable<PPS> ApplyDeltaEntities(IEnumerable<PPS> Entities, List<PPS> DeltaEntities)
        {
            HashSet<string> Index_PPSKEY = new HashSet<string>(DeltaEntities.Select(i => i.PPSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PPSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PPSKEY.Remove(entity.PPSKEY);
                            
                            if (entity.PPSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PPS>>> Index_COUNTRY;
        private Lazy<NullDictionary<string, IReadOnlyList<PPS>>> Index_POSTAL_COUNTRY;
        private Lazy<Dictionary<string, PPS>> Index_PPSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <param name="Value">List of related PPS entities</param>
        /// <returns>True if the list of related PPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<PPS> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPS> value;
            if (Index_COUNTRY.Value.TryGetValue(COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> FindByPOSTAL_COUNTRY(string POSTAL_COUNTRY)
        {
            return Index_POSTAL_COUNTRY.Value[POSTAL_COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <param name="Value">List of related PPS entities</param>
        /// <returns>True if the list of related PPS entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPOSTAL_COUNTRY(string POSTAL_COUNTRY, out IReadOnlyList<PPS> Value)
        {
            return Index_POSTAL_COUNTRY.Value.TryGetValue(POSTAL_COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by POSTAL_COUNTRY field
        /// </summary>
        /// <param name="POSTAL_COUNTRY">POSTAL_COUNTRY value used to find PPS</param>
        /// <returns>List of related PPS entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPS> TryFindByPOSTAL_COUNTRY(string POSTAL_COUNTRY)
        {
            IReadOnlyList<PPS> value;
            if (Index_POSTAL_COUNTRY.Value.TryGetValue(POSTAL_COUNTRY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <returns>Related PPS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPS FindByPPSKEY(string PPSKEY)
        {
            return Index_PPSKEY.Value[PPSKEY];
        }

        /// <summary>
        /// Attempt to find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <param name="Value">Related PPS entity</param>
        /// <returns>True if the related PPS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPSKEY(string PPSKEY, out PPS Value)
        {
            return Index_PPSKEY.Value.TryGetValue(PPSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PPS by PPSKEY field
        /// </summary>
        /// <param name="PPSKEY">PPSKEY value used to find PPS</param>
        /// <returns>Related PPS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPS TryFindByPPSKEY(string PPSKEY)
        {
            PPS value;
            if (Index_PPSKEY.Value.TryGetValue(PPSKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PPS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PPS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PPS](
        [PPSKEY] varchar(10) NOT NULL,
        [ABN] varchar(11) NULL,
        [NAME] varchar(76) NULL,
        [CONTACT_NAME] varchar(38) NULL,
        [CONTACT_PHONE] varchar(20) NULL,
        [FACSIMILE] varchar(20) NULL,
        [FILE_REFERENCE] varchar(16) NULL,
        [L1_ADDRESS] varchar(38) NULL,
        [L2_ADDRESS] varchar(38) NULL,
        [SUBURB] varchar(27) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [COUNTRY] varchar(6) NULL,
        [POSTAL_L1_ADD] varchar(38) NULL,
        [POSTAL_L2_ADD] varchar(38) NULL,
        [POSTAL_SUBURB] varchar(27) NULL,
        [POSTAL_STATE] varchar(3) NULL,
        [POSTAL_POSTCODE] varchar(4) NULL,
        [POSTAL_COUNTRY] varchar(6) NULL,
        [EMAIL_ADDRESS] varchar(76) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PPS_Index_PPSKEY] PRIMARY KEY CLUSTERED (
            [PPSKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PPS_Index_COUNTRY] ON [dbo].[PPS]
    (
            [COUNTRY] ASC
    );
    CREATE NONCLUSTERED INDEX [PPS_Index_POSTAL_COUNTRY] ON [dbo].[PPS]
    (
            [POSTAL_COUNTRY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PPS]') AND name = N'Index_COUNTRY')
    ALTER INDEX [Index_COUNTRY] ON [dbo].[PPS] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PPS]') AND name = N'Index_POSTAL_COUNTRY')
    ALTER INDEX [Index_POSTAL_COUNTRY] ON [dbo].[PPS] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PPS]') AND name = N'Index_COUNTRY')
    ALTER INDEX [Index_COUNTRY] ON [dbo].[PPS] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PPS]') AND name = N'Index_POSTAL_COUNTRY')
    ALTER INDEX [Index_POSTAL_COUNTRY] ON [dbo].[PPS] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PPS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PPS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PPS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_PPSKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_PPSKEY.Add(entity.PPSKEY);
            }

            builder.AppendLine("DELETE [dbo].[PPS] WHERE");


            // Index_PPSKEY
            builder.Append("[PPSKEY] IN (");
            for (int index = 0; index < Index_PPSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PPSKEY
                var parameterPPSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPPSKEY);
                command.Parameters.Add(parameterPPSKEY, SqlDbType.VarChar, 10).Value = Index_PPSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PPS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PPS data set</returns>
        public override EduHubDataSetDataReader<PPS> GetDataSetDataReader()
        {
            return new PPSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PPS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PPS data set</returns>
        public override EduHubDataSetDataReader<PPS> GetDataSetDataReader(List<PPS> Entities)
        {
            return new PPSDataReader(new EduHubDataSetLoadedReader<PPS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PPSDataReader : EduHubDataSetDataReader<PPS>
        {
            public PPSDataReader(IEduHubDataSetReader<PPS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 23; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PPSKEY
                        return Current.PPSKEY;
                    case 1: // ABN
                        return Current.ABN;
                    case 2: // NAME
                        return Current.NAME;
                    case 3: // CONTACT_NAME
                        return Current.CONTACT_NAME;
                    case 4: // CONTACT_PHONE
                        return Current.CONTACT_PHONE;
                    case 5: // FACSIMILE
                        return Current.FACSIMILE;
                    case 6: // FILE_REFERENCE
                        return Current.FILE_REFERENCE;
                    case 7: // L1_ADDRESS
                        return Current.L1_ADDRESS;
                    case 8: // L2_ADDRESS
                        return Current.L2_ADDRESS;
                    case 9: // SUBURB
                        return Current.SUBURB;
                    case 10: // STATE
                        return Current.STATE;
                    case 11: // POSTCODE
                        return Current.POSTCODE;
                    case 12: // COUNTRY
                        return Current.COUNTRY;
                    case 13: // POSTAL_L1_ADD
                        return Current.POSTAL_L1_ADD;
                    case 14: // POSTAL_L2_ADD
                        return Current.POSTAL_L2_ADD;
                    case 15: // POSTAL_SUBURB
                        return Current.POSTAL_SUBURB;
                    case 16: // POSTAL_STATE
                        return Current.POSTAL_STATE;
                    case 17: // POSTAL_POSTCODE
                        return Current.POSTAL_POSTCODE;
                    case 18: // POSTAL_COUNTRY
                        return Current.POSTAL_COUNTRY;
                    case 19: // EMAIL_ADDRESS
                        return Current.EMAIL_ADDRESS;
                    case 20: // LW_DATE
                        return Current.LW_DATE;
                    case 21: // LW_TIME
                        return Current.LW_TIME;
                    case 22: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ABN
                        return Current.ABN == null;
                    case 2: // NAME
                        return Current.NAME == null;
                    case 3: // CONTACT_NAME
                        return Current.CONTACT_NAME == null;
                    case 4: // CONTACT_PHONE
                        return Current.CONTACT_PHONE == null;
                    case 5: // FACSIMILE
                        return Current.FACSIMILE == null;
                    case 6: // FILE_REFERENCE
                        return Current.FILE_REFERENCE == null;
                    case 7: // L1_ADDRESS
                        return Current.L1_ADDRESS == null;
                    case 8: // L2_ADDRESS
                        return Current.L2_ADDRESS == null;
                    case 9: // SUBURB
                        return Current.SUBURB == null;
                    case 10: // STATE
                        return Current.STATE == null;
                    case 11: // POSTCODE
                        return Current.POSTCODE == null;
                    case 12: // COUNTRY
                        return Current.COUNTRY == null;
                    case 13: // POSTAL_L1_ADD
                        return Current.POSTAL_L1_ADD == null;
                    case 14: // POSTAL_L2_ADD
                        return Current.POSTAL_L2_ADD == null;
                    case 15: // POSTAL_SUBURB
                        return Current.POSTAL_SUBURB == null;
                    case 16: // POSTAL_STATE
                        return Current.POSTAL_STATE == null;
                    case 17: // POSTAL_POSTCODE
                        return Current.POSTAL_POSTCODE == null;
                    case 18: // POSTAL_COUNTRY
                        return Current.POSTAL_COUNTRY == null;
                    case 19: // EMAIL_ADDRESS
                        return Current.EMAIL_ADDRESS == null;
                    case 20: // LW_DATE
                        return Current.LW_DATE == null;
                    case 21: // LW_TIME
                        return Current.LW_TIME == null;
                    case 22: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PPSKEY
                        return "PPSKEY";
                    case 1: // ABN
                        return "ABN";
                    case 2: // NAME
                        return "NAME";
                    case 3: // CONTACT_NAME
                        return "CONTACT_NAME";
                    case 4: // CONTACT_PHONE
                        return "CONTACT_PHONE";
                    case 5: // FACSIMILE
                        return "FACSIMILE";
                    case 6: // FILE_REFERENCE
                        return "FILE_REFERENCE";
                    case 7: // L1_ADDRESS
                        return "L1_ADDRESS";
                    case 8: // L2_ADDRESS
                        return "L2_ADDRESS";
                    case 9: // SUBURB
                        return "SUBURB";
                    case 10: // STATE
                        return "STATE";
                    case 11: // POSTCODE
                        return "POSTCODE";
                    case 12: // COUNTRY
                        return "COUNTRY";
                    case 13: // POSTAL_L1_ADD
                        return "POSTAL_L1_ADD";
                    case 14: // POSTAL_L2_ADD
                        return "POSTAL_L2_ADD";
                    case 15: // POSTAL_SUBURB
                        return "POSTAL_SUBURB";
                    case 16: // POSTAL_STATE
                        return "POSTAL_STATE";
                    case 17: // POSTAL_POSTCODE
                        return "POSTAL_POSTCODE";
                    case 18: // POSTAL_COUNTRY
                        return "POSTAL_COUNTRY";
                    case 19: // EMAIL_ADDRESS
                        return "EMAIL_ADDRESS";
                    case 20: // LW_DATE
                        return "LW_DATE";
                    case 21: // LW_TIME
                        return "LW_TIME";
                    case 22: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PPSKEY":
                        return 0;
                    case "ABN":
                        return 1;
                    case "NAME":
                        return 2;
                    case "CONTACT_NAME":
                        return 3;
                    case "CONTACT_PHONE":
                        return 4;
                    case "FACSIMILE":
                        return 5;
                    case "FILE_REFERENCE":
                        return 6;
                    case "L1_ADDRESS":
                        return 7;
                    case "L2_ADDRESS":
                        return 8;
                    case "SUBURB":
                        return 9;
                    case "STATE":
                        return 10;
                    case "POSTCODE":
                        return 11;
                    case "COUNTRY":
                        return 12;
                    case "POSTAL_L1_ADD":
                        return 13;
                    case "POSTAL_L2_ADD":
                        return 14;
                    case "POSTAL_SUBURB":
                        return 15;
                    case "POSTAL_STATE":
                        return 16;
                    case "POSTAL_POSTCODE":
                        return 17;
                    case "POSTAL_COUNTRY":
                        return 18;
                    case "EMAIL_ADDRESS":
                        return 19;
                    case "LW_DATE":
                        return 20;
                    case "LW_TIME":
                        return 21;
                    case "LW_USER":
                        return 22;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
