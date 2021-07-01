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
    /// Fees - Billing Templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SABDataSet : EduHubDataSet<SAB>
    {
        /// <inheritdoc />
        public override string Name { get { return "SAB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SABDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FEE_CODE_1ST = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_1ST));
            Index_FEE_CODE_2ND = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_2ND));
            Index_FEE_CODE_3RD = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_3RD));
            Index_FEE_CODE_4TH = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_4TH));
            Index_FEE_CODE_KG = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_KG));
            Index_SABKEY = new Lazy<Dictionary<string, SAB>>(() => this.ToDictionary(i => i.SABKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAB" /> fields for each CSV column header</returns>
        internal override Action<SAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SABKEY":
                        mapper[i] = (e, v) => e.SABKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "BILL_TYPE":
                        mapper[i] = (e, v) => e.BILL_TYPE = v;
                        break;
                    case "FROM_CLASS":
                        mapper[i] = (e, v) => e.FROM_CLASS = v;
                        break;
                    case "TO_CLASS":
                        mapper[i] = (e, v) => e.TO_CLASS = v;
                        break;
                    case "FROM_YEAR":
                        mapper[i] = (e, v) => e.FROM_YEAR = v;
                        break;
                    case "TO_YEAR":
                        mapper[i] = (e, v) => e.TO_YEAR = v;
                        break;
                    case "RES_STATUS":
                        mapper[i] = (e, v) => e.RES_STATUS = v;
                        break;
                    case "FEE_CODE_1ST":
                        mapper[i] = (e, v) => e.FEE_CODE_1ST = v;
                        break;
                    case "FEE_CODE_2ND":
                        mapper[i] = (e, v) => e.FEE_CODE_2ND = v;
                        break;
                    case "FEE_CODE_3RD":
                        mapper[i] = (e, v) => e.FEE_CODE_3RD = v;
                        break;
                    case "FEE_CODE_4TH":
                        mapper[i] = (e, v) => e.FEE_CODE_4TH = v;
                        break;
                    case "FEE_CODE_KG":
                        mapper[i] = (e, v) => e.FEE_CODE_KG = v;
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
        /// Merges <see cref="SAB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SAB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SAB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SAB}"/> of entities</returns>
        internal override IEnumerable<SAB> ApplyDeltaEntities(IEnumerable<SAB> Entities, List<SAB> DeltaEntities)
        {
            HashSet<string> Index_SABKEY = new HashSet<string>(DeltaEntities.Select(i => i.SABKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SABKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SABKEY.Remove(entity.SABKEY);
                            
                            if (entity.SABKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_1ST;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_2ND;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_3RD;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_4TH;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_KG;
        private Lazy<Dictionary<string, SAB>> Index_SABKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_1ST(string FEE_CODE_1ST)
        {
            return Index_FEE_CODE_1ST.Value[FEE_CODE_1ST];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_1ST(string FEE_CODE_1ST, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_1ST.Value.TryGetValue(FEE_CODE_1ST, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_1ST(string FEE_CODE_1ST)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_1ST.Value.TryGetValue(FEE_CODE_1ST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_2ND(string FEE_CODE_2ND)
        {
            return Index_FEE_CODE_2ND.Value[FEE_CODE_2ND];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_2ND(string FEE_CODE_2ND, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_2ND.Value.TryGetValue(FEE_CODE_2ND, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_2ND(string FEE_CODE_2ND)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_2ND.Value.TryGetValue(FEE_CODE_2ND, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_3RD(string FEE_CODE_3RD)
        {
            return Index_FEE_CODE_3RD.Value[FEE_CODE_3RD];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_3RD(string FEE_CODE_3RD, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_3RD.Value.TryGetValue(FEE_CODE_3RD, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_3RD(string FEE_CODE_3RD)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_3RD.Value.TryGetValue(FEE_CODE_3RD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_4TH(string FEE_CODE_4TH)
        {
            return Index_FEE_CODE_4TH.Value[FEE_CODE_4TH];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_4TH(string FEE_CODE_4TH, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_4TH.Value.TryGetValue(FEE_CODE_4TH, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_4TH(string FEE_CODE_4TH)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_4TH.Value.TryGetValue(FEE_CODE_4TH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_KG(string FEE_CODE_KG)
        {
            return Index_FEE_CODE_KG.Value[FEE_CODE_KG];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_KG(string FEE_CODE_KG, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_KG.Value.TryGetValue(FEE_CODE_KG, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_KG(string FEE_CODE_KG)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_KG.Value.TryGetValue(FEE_CODE_KG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <returns>Related SAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAB FindBySABKEY(string SABKEY)
        {
            return Index_SABKEY.Value[SABKEY];
        }

        /// <summary>
        /// Attempt to find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <param name="Value">Related SAB entity</param>
        /// <returns>True if the related SAB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySABKEY(string SABKEY, out SAB Value)
        {
            return Index_SABKEY.Value.TryGetValue(SABKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <returns>Related SAB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAB TryFindBySABKEY(string SABKEY)
        {
            SAB value;
            if (Index_SABKEY.Value.TryGetValue(SABKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SAB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAB](
        [SABKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [BILL_TYPE] varchar(10) NULL,
        [FROM_CLASS] varchar(4) NULL,
        [TO_CLASS] varchar(4) NULL,
        [FROM_YEAR] varchar(4) NULL,
        [TO_YEAR] varchar(4) NULL,
        [RES_STATUS] varchar(1) NULL,
        [FEE_CODE_1ST] varchar(10) NULL,
        [FEE_CODE_2ND] varchar(10) NULL,
        [FEE_CODE_3RD] varchar(10) NULL,
        [FEE_CODE_4TH] varchar(10) NULL,
        [FEE_CODE_KG] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAB_Index_SABKEY] PRIMARY KEY CLUSTERED (
            [SABKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_1ST] ON [dbo].[SAB]
    (
            [FEE_CODE_1ST] ASC
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_2ND] ON [dbo].[SAB]
    (
            [FEE_CODE_2ND] ASC
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_3RD] ON [dbo].[SAB]
    (
            [FEE_CODE_3RD] ASC
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_4TH] ON [dbo].[SAB]
    (
            [FEE_CODE_4TH] ASC
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_KG] ON [dbo].[SAB]
    (
            [FEE_CODE_KG] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_1ST')
    ALTER INDEX [Index_FEE_CODE_1ST] ON [dbo].[SAB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_2ND')
    ALTER INDEX [Index_FEE_CODE_2ND] ON [dbo].[SAB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_3RD')
    ALTER INDEX [Index_FEE_CODE_3RD] ON [dbo].[SAB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_4TH')
    ALTER INDEX [Index_FEE_CODE_4TH] ON [dbo].[SAB] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_KG')
    ALTER INDEX [Index_FEE_CODE_KG] ON [dbo].[SAB] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_1ST')
    ALTER INDEX [Index_FEE_CODE_1ST] ON [dbo].[SAB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_2ND')
    ALTER INDEX [Index_FEE_CODE_2ND] ON [dbo].[SAB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_3RD')
    ALTER INDEX [Index_FEE_CODE_3RD] ON [dbo].[SAB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_4TH')
    ALTER INDEX [Index_FEE_CODE_4TH] ON [dbo].[SAB] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND name = N'Index_FEE_CODE_KG')
    ALTER INDEX [Index_FEE_CODE_KG] ON [dbo].[SAB] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SAB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SAB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SAB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SABKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SABKEY.Add(entity.SABKEY);
            }

            builder.AppendLine("DELETE [dbo].[SAB] WHERE");


            // Index_SABKEY
            builder.Append("[SABKEY] IN (");
            for (int index = 0; index < Index_SABKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SABKEY
                var parameterSABKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSABKEY);
                command.Parameters.Add(parameterSABKEY, SqlDbType.VarChar, 10).Value = Index_SABKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAB data set</returns>
        public override EduHubDataSetDataReader<SAB> GetDataSetDataReader()
        {
            return new SABDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAB data set</returns>
        public override EduHubDataSetDataReader<SAB> GetDataSetDataReader(List<SAB> Entities)
        {
            return new SABDataReader(new EduHubDataSetLoadedReader<SAB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SABDataReader : EduHubDataSetDataReader<SAB>
        {
            public SABDataReader(IEduHubDataSetReader<SAB> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 16; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SABKEY
                        return Current.SABKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // BILL_TYPE
                        return Current.BILL_TYPE;
                    case 3: // FROM_CLASS
                        return Current.FROM_CLASS;
                    case 4: // TO_CLASS
                        return Current.TO_CLASS;
                    case 5: // FROM_YEAR
                        return Current.FROM_YEAR;
                    case 6: // TO_YEAR
                        return Current.TO_YEAR;
                    case 7: // RES_STATUS
                        return Current.RES_STATUS;
                    case 8: // FEE_CODE_1ST
                        return Current.FEE_CODE_1ST;
                    case 9: // FEE_CODE_2ND
                        return Current.FEE_CODE_2ND;
                    case 10: // FEE_CODE_3RD
                        return Current.FEE_CODE_3RD;
                    case 11: // FEE_CODE_4TH
                        return Current.FEE_CODE_4TH;
                    case 12: // FEE_CODE_KG
                        return Current.FEE_CODE_KG;
                    case 13: // LW_DATE
                        return Current.LW_DATE;
                    case 14: // LW_TIME
                        return Current.LW_TIME;
                    case 15: // LW_USER
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
                    case 2: // BILL_TYPE
                        return Current.BILL_TYPE == null;
                    case 3: // FROM_CLASS
                        return Current.FROM_CLASS == null;
                    case 4: // TO_CLASS
                        return Current.TO_CLASS == null;
                    case 5: // FROM_YEAR
                        return Current.FROM_YEAR == null;
                    case 6: // TO_YEAR
                        return Current.TO_YEAR == null;
                    case 7: // RES_STATUS
                        return Current.RES_STATUS == null;
                    case 8: // FEE_CODE_1ST
                        return Current.FEE_CODE_1ST == null;
                    case 9: // FEE_CODE_2ND
                        return Current.FEE_CODE_2ND == null;
                    case 10: // FEE_CODE_3RD
                        return Current.FEE_CODE_3RD == null;
                    case 11: // FEE_CODE_4TH
                        return Current.FEE_CODE_4TH == null;
                    case 12: // FEE_CODE_KG
                        return Current.FEE_CODE_KG == null;
                    case 13: // LW_DATE
                        return Current.LW_DATE == null;
                    case 14: // LW_TIME
                        return Current.LW_TIME == null;
                    case 15: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SABKEY
                        return "SABKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // BILL_TYPE
                        return "BILL_TYPE";
                    case 3: // FROM_CLASS
                        return "FROM_CLASS";
                    case 4: // TO_CLASS
                        return "TO_CLASS";
                    case 5: // FROM_YEAR
                        return "FROM_YEAR";
                    case 6: // TO_YEAR
                        return "TO_YEAR";
                    case 7: // RES_STATUS
                        return "RES_STATUS";
                    case 8: // FEE_CODE_1ST
                        return "FEE_CODE_1ST";
                    case 9: // FEE_CODE_2ND
                        return "FEE_CODE_2ND";
                    case 10: // FEE_CODE_3RD
                        return "FEE_CODE_3RD";
                    case 11: // FEE_CODE_4TH
                        return "FEE_CODE_4TH";
                    case 12: // FEE_CODE_KG
                        return "FEE_CODE_KG";
                    case 13: // LW_DATE
                        return "LW_DATE";
                    case 14: // LW_TIME
                        return "LW_TIME";
                    case 15: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SABKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "BILL_TYPE":
                        return 2;
                    case "FROM_CLASS":
                        return 3;
                    case "TO_CLASS":
                        return 4;
                    case "FROM_YEAR":
                        return 5;
                    case "TO_YEAR":
                        return 6;
                    case "RES_STATUS":
                        return 7;
                    case "FEE_CODE_1ST":
                        return 8;
                    case "FEE_CODE_2ND":
                        return 9;
                    case "FEE_CODE_3RD":
                        return 10;
                    case "FEE_CODE_4TH":
                        return 11;
                    case "FEE_CODE_KG":
                        return 12;
                    case "LW_DATE":
                        return 13;
                    case "LW_TIME":
                        return 14;
                    case "LW_USER":
                        return 15;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
