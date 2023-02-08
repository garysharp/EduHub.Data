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
    /// Financial History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FINHISTDataSet : EduHubDataSet<FINHIST>
    {
        /// <inheritdoc />
        public override string Name { get { return "FINHIST"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal FINHISTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, FINHIST>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FINHIST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FINHIST" /> fields for each CSV column header</returns>
        internal override Action<FINHIST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FINHIST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "LEDGER":
                        mapper[i] = (e, v) => e.LEDGER = v;
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "TRANSACTION_ID":
                        mapper[i] = (e, v) => e.TRANSACTION_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.ACCOUNT_NAME = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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
        /// Merges <see cref="FINHIST" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="FINHIST" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="FINHIST" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{FINHIST}"/> of entities</returns>
        internal override IEnumerable<FINHIST> ApplyDeltaEntities(IEnumerable<FINHIST> Entities, List<FINHIST> DeltaEntities)
        {
            HashSet<int> Index_ID = new HashSet<int>(DeltaEntities.Select(i => i.ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ID.Remove(entity.ID);
                            
                            if (entity.ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, FINHIST>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <returns>Related FINHIST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FINHIST FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <param name="Value">Related FINHIST entity</param>
        /// <returns>True if the related FINHIST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out FINHIST Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <returns>Related FINHIST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FINHIST TryFindByID(int ID)
        {
            FINHIST value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a FINHIST table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FINHIST]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[FINHIST](
        [ID] int IDENTITY NOT NULL,
        [LEDGER] varchar(10) NULL,
        [ENTITY] varchar(10) NULL,
        [TRANSACTION_ID] int NULL,
        [BSB] varchar(6) NULL,
        [ACCOUNT_NO] varchar(15) NULL,
        [ACCOUNT_NAME] varchar(60) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [CREATION_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [FINHIST_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="FINHISTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="FINHISTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="FINHIST"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="FINHIST"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<FINHIST> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[FINHIST] WHERE");


            // Index_ID
            builder.Append("[ID] IN (");
            for (int index = 0; index < Index_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ID
                var parameterID = $"@p{parameterIndex++}";
                builder.Append(parameterID);
                command.Parameters.Add(parameterID, SqlDbType.Int).Value = Index_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the FINHIST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FINHIST data set</returns>
        public override EduHubDataSetDataReader<FINHIST> GetDataSetDataReader()
        {
            return new FINHISTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the FINHIST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FINHIST data set</returns>
        public override EduHubDataSetDataReader<FINHIST> GetDataSetDataReader(List<FINHIST> Entities)
        {
            return new FINHISTDataReader(new EduHubDataSetLoadedReader<FINHIST>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class FINHISTDataReader : EduHubDataSetDataReader<FINHIST>
        {
            public FINHISTDataReader(IEduHubDataSetReader<FINHIST> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // LEDGER
                        return Current.LEDGER;
                    case 2: // ENTITY
                        return Current.ENTITY;
                    case 3: // TRANSACTION_ID
                        return Current.TRANSACTION_ID;
                    case 4: // BSB
                        return Current.BSB;
                    case 5: // ACCOUNT_NO
                        return Current.ACCOUNT_NO;
                    case 6: // ACCOUNT_NAME
                        return Current.ACCOUNT_NAME;
                    case 7: // BILLER_CODE
                        return Current.BILLER_CODE;
                    case 8: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE;
                    case 9: // CREATION_DATE
                        return Current.CREATION_DATE;
                    case 10: // LW_TIME
                        return Current.LW_TIME;
                    case 11: // LW_DATE
                        return Current.LW_DATE;
                    case 12: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LEDGER
                        return Current.LEDGER == null;
                    case 2: // ENTITY
                        return Current.ENTITY == null;
                    case 3: // TRANSACTION_ID
                        return Current.TRANSACTION_ID == null;
                    case 4: // BSB
                        return Current.BSB == null;
                    case 5: // ACCOUNT_NO
                        return Current.ACCOUNT_NO == null;
                    case 6: // ACCOUNT_NAME
                        return Current.ACCOUNT_NAME == null;
                    case 7: // BILLER_CODE
                        return Current.BILLER_CODE == null;
                    case 8: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE == null;
                    case 9: // CREATION_DATE
                        return Current.CREATION_DATE == null;
                    case 10: // LW_TIME
                        return Current.LW_TIME == null;
                    case 11: // LW_DATE
                        return Current.LW_DATE == null;
                    case 12: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // LEDGER
                        return "LEDGER";
                    case 2: // ENTITY
                        return "ENTITY";
                    case 3: // TRANSACTION_ID
                        return "TRANSACTION_ID";
                    case 4: // BSB
                        return "BSB";
                    case 5: // ACCOUNT_NO
                        return "ACCOUNT_NO";
                    case 6: // ACCOUNT_NAME
                        return "ACCOUNT_NAME";
                    case 7: // BILLER_CODE
                        return "BILLER_CODE";
                    case 8: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 9: // CREATION_DATE
                        return "CREATION_DATE";
                    case 10: // LW_TIME
                        return "LW_TIME";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "LEDGER":
                        return 1;
                    case "ENTITY":
                        return 2;
                    case "TRANSACTION_ID":
                        return 3;
                    case "BSB":
                        return 4;
                    case "ACCOUNT_NO":
                        return 5;
                    case "ACCOUNT_NAME":
                        return 6;
                    case "BILLER_CODE":
                        return 7;
                    case "BPAY_REFERENCE":
                        return 8;
                    case "CREATION_DATE":
                        return 9;
                    case "LW_TIME":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_USER":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
