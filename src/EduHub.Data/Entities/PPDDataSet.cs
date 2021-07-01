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
    /// PAYG Payer Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PPDDataSet : EduHubDataSet<PPD>
    {
        /// <inheritdoc />
        public override string Name { get { return "PPD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PPDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COUNTRY = new Lazy<NullDictionary<string, IReadOnlyList<PPD>>>(() => this.ToGroupedNullDictionary(i => i.COUNTRY));
            Index_PPDKEY = new Lazy<Dictionary<string, PPD>>(() => this.ToDictionary(i => i.PPDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PPD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PPD" /> fields for each CSV column header</returns>
        internal override Action<PPD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PPD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABN_OR_WPN":
                        mapper[i] = (e, v) => e.ABN_OR_WPN = v;
                        break;
                    case "NUMBER_TYPE":
                        mapper[i] = (e, v) => e.NUMBER_TYPE = v;
                        break;
                    case "BRANCH_NUMBER":
                        mapper[i] = (e, v) => e.BRANCH_NUMBER = v;
                        break;
                    case "FINANCIAL_YEAR":
                        mapper[i] = (e, v) => e.FINANCIAL_YEAR = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "TRADING_NAME":
                        mapper[i] = (e, v) => e.TRADING_NAME = v;
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
                    case "CONTACT_NAME":
                        mapper[i] = (e, v) => e.CONTACT_NAME = v;
                        break;
                    case "PHONE":
                        mapper[i] = (e, v) => e.PHONE = v;
                        break;
                    case "FACSIMILE":
                        mapper[i] = (e, v) => e.FACSIMILE = v;
                        break;
                    case "SIGNATURE":
                        mapper[i] = (e, v) => e.SIGNATURE = v;
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
        /// Merges <see cref="PPD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PPD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PPD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PPD}"/> of entities</returns>
        internal override IEnumerable<PPD> ApplyDeltaEntities(IEnumerable<PPD> Entities, List<PPD> DeltaEntities)
        {
            HashSet<string> Index_PPDKEY = new HashSet<string>(DeltaEntities.Select(i => i.PPDKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PPDKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PPDKEY.Remove(entity.PPDKEY);
                            
                            if (entity.PPDKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PPD>>> Index_COUNTRY;
        private Lazy<Dictionary<string, PPD>> Index_PPDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <returns>List of related PPD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPD> FindByCOUNTRY(string COUNTRY)
        {
            return Index_COUNTRY.Value[COUNTRY];
        }

        /// <summary>
        /// Attempt to find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <param name="Value">List of related PPD entities</param>
        /// <returns>True if the list of related PPD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOUNTRY(string COUNTRY, out IReadOnlyList<PPD> Value)
        {
            return Index_COUNTRY.Value.TryGetValue(COUNTRY, out Value);
        }

        /// <summary>
        /// Attempt to find PPD by COUNTRY field
        /// </summary>
        /// <param name="COUNTRY">COUNTRY value used to find PPD</param>
        /// <returns>List of related PPD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PPD> TryFindByCOUNTRY(string COUNTRY)
        {
            IReadOnlyList<PPD> value;
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
        /// Find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPD FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <param name="Value">Related PPD entity</param>
        /// <returns>True if the related PPD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out PPD Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PPD TryFindByPPDKEY(string PPDKEY)
        {
            PPD value;
            if (Index_PPDKEY.Value.TryGetValue(PPDKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PPD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PPD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PPD](
        [PPDKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [ABN_OR_WPN] varchar(11) NULL,
        [NUMBER_TYPE] varchar(1) NULL,
        [BRANCH_NUMBER] varchar(3) NULL,
        [FINANCIAL_YEAR] varchar(4) NULL,
        [NAME] varchar(40) NULL,
        [TRADING_NAME] varchar(40) NULL,
        [L1_ADDRESS] varchar(38) NULL,
        [L2_ADDRESS] varchar(38) NULL,
        [SUBURB] varchar(27) NULL,
        [STATE] varchar(3) NULL,
        [POSTCODE] varchar(4) NULL,
        [COUNTRY] varchar(6) NULL,
        [CONTACT_NAME] varchar(25) NULL,
        [PHONE] varchar(15) NULL,
        [FACSIMILE] varchar(15) NULL,
        [SIGNATURE] varchar(25) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PPD_Index_PPDKEY] PRIMARY KEY CLUSTERED (
            [PPDKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PPD_Index_COUNTRY] ON [dbo].[PPD]
    (
            [COUNTRY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PPD]') AND name = N'Index_COUNTRY')
    ALTER INDEX [Index_COUNTRY] ON [dbo].[PPD] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PPD]') AND name = N'Index_COUNTRY')
    ALTER INDEX [Index_COUNTRY] ON [dbo].[PPD] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PPD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PPD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PPD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_PPDKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_PPDKEY.Add(entity.PPDKEY);
            }

            builder.AppendLine("DELETE [dbo].[PPD] WHERE");


            // Index_PPDKEY
            builder.Append("[PPDKEY] IN (");
            for (int index = 0; index < Index_PPDKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PPDKEY
                var parameterPPDKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPPDKEY);
                command.Parameters.Add(parameterPPDKEY, SqlDbType.VarChar, 10).Value = Index_PPDKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PPD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PPD data set</returns>
        public override EduHubDataSetDataReader<PPD> GetDataSetDataReader()
        {
            return new PPDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PPD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PPD data set</returns>
        public override EduHubDataSetDataReader<PPD> GetDataSetDataReader(List<PPD> Entities)
        {
            return new PPDDataReader(new EduHubDataSetLoadedReader<PPD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PPDDataReader : EduHubDataSetDataReader<PPD>
        {
            public PPDDataReader(IEduHubDataSetReader<PPD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 21; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PPDKEY
                        return Current.PPDKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // ABN_OR_WPN
                        return Current.ABN_OR_WPN;
                    case 3: // NUMBER_TYPE
                        return Current.NUMBER_TYPE;
                    case 4: // BRANCH_NUMBER
                        return Current.BRANCH_NUMBER;
                    case 5: // FINANCIAL_YEAR
                        return Current.FINANCIAL_YEAR;
                    case 6: // NAME
                        return Current.NAME;
                    case 7: // TRADING_NAME
                        return Current.TRADING_NAME;
                    case 8: // L1_ADDRESS
                        return Current.L1_ADDRESS;
                    case 9: // L2_ADDRESS
                        return Current.L2_ADDRESS;
                    case 10: // SUBURB
                        return Current.SUBURB;
                    case 11: // STATE
                        return Current.STATE;
                    case 12: // POSTCODE
                        return Current.POSTCODE;
                    case 13: // COUNTRY
                        return Current.COUNTRY;
                    case 14: // CONTACT_NAME
                        return Current.CONTACT_NAME;
                    case 15: // PHONE
                        return Current.PHONE;
                    case 16: // FACSIMILE
                        return Current.FACSIMILE;
                    case 17: // SIGNATURE
                        return Current.SIGNATURE;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // ABN_OR_WPN
                        return Current.ABN_OR_WPN == null;
                    case 3: // NUMBER_TYPE
                        return Current.NUMBER_TYPE == null;
                    case 4: // BRANCH_NUMBER
                        return Current.BRANCH_NUMBER == null;
                    case 5: // FINANCIAL_YEAR
                        return Current.FINANCIAL_YEAR == null;
                    case 6: // NAME
                        return Current.NAME == null;
                    case 7: // TRADING_NAME
                        return Current.TRADING_NAME == null;
                    case 8: // L1_ADDRESS
                        return Current.L1_ADDRESS == null;
                    case 9: // L2_ADDRESS
                        return Current.L2_ADDRESS == null;
                    case 10: // SUBURB
                        return Current.SUBURB == null;
                    case 11: // STATE
                        return Current.STATE == null;
                    case 12: // POSTCODE
                        return Current.POSTCODE == null;
                    case 13: // COUNTRY
                        return Current.COUNTRY == null;
                    case 14: // CONTACT_NAME
                        return Current.CONTACT_NAME == null;
                    case 15: // PHONE
                        return Current.PHONE == null;
                    case 16: // FACSIMILE
                        return Current.FACSIMILE == null;
                    case 17: // SIGNATURE
                        return Current.SIGNATURE == null;
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
                    case 0: // PPDKEY
                        return "PPDKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ABN_OR_WPN
                        return "ABN_OR_WPN";
                    case 3: // NUMBER_TYPE
                        return "NUMBER_TYPE";
                    case 4: // BRANCH_NUMBER
                        return "BRANCH_NUMBER";
                    case 5: // FINANCIAL_YEAR
                        return "FINANCIAL_YEAR";
                    case 6: // NAME
                        return "NAME";
                    case 7: // TRADING_NAME
                        return "TRADING_NAME";
                    case 8: // L1_ADDRESS
                        return "L1_ADDRESS";
                    case 9: // L2_ADDRESS
                        return "L2_ADDRESS";
                    case 10: // SUBURB
                        return "SUBURB";
                    case 11: // STATE
                        return "STATE";
                    case 12: // POSTCODE
                        return "POSTCODE";
                    case 13: // COUNTRY
                        return "COUNTRY";
                    case 14: // CONTACT_NAME
                        return "CONTACT_NAME";
                    case 15: // PHONE
                        return "PHONE";
                    case 16: // FACSIMILE
                        return "FACSIMILE";
                    case 17: // SIGNATURE
                        return "SIGNATURE";
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
                    case "PPDKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ABN_OR_WPN":
                        return 2;
                    case "NUMBER_TYPE":
                        return 3;
                    case "BRANCH_NUMBER":
                        return 4;
                    case "FINANCIAL_YEAR":
                        return 5;
                    case "NAME":
                        return 6;
                    case "TRADING_NAME":
                        return 7;
                    case "L1_ADDRESS":
                        return 8;
                    case "L2_ADDRESS":
                        return 9;
                    case "SUBURB":
                        return 10;
                    case "STATE":
                        return 11;
                    case "POSTCODE":
                        return 12;
                    case "COUNTRY":
                        return 13;
                    case "CONTACT_NAME":
                        return 14;
                    case "PHONE":
                        return 15;
                    case "FACSIMILE":
                        return 16;
                    case "SIGNATURE":
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
