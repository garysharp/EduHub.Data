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
    /// Superannuation Funds Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PFDataSet : EduHubDataSet<PF>
    {
        /// <inheritdoc />
        public override string Name { get { return "PF"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PF>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_PFKEY = new Lazy<Dictionary<string, PF>>(() => this.ToDictionary(i => i.PFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PF" /> fields for each CSV column header</returns>
        internal override Action<PF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PFKEY":
                        mapper[i] = (e, v) => e.PFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "CREATE_EXPORT_FILE":
                        mapper[i] = (e, v) => e.CREATE_EXPORT_FILE = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "USI":
                        mapper[i] = (e, v) => e.USI = v;
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
        /// Merges <see cref="PF" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PF" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PF" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PF}"/> of entities</returns>
        internal override IEnumerable<PF> ApplyDeltaEntities(IEnumerable<PF> Entities, List<PF> DeltaEntities)
        {
            HashSet<string> Index_PFKEY = new HashSet<string>(DeltaEntities.Select(i => i.PFKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PFKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PFKEY.Remove(entity.PFKEY);
                            
                            if (entity.PFKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PF>>> Index_GLCODE;
        private Lazy<Dictionary<string, PF>> Index_PFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <returns>List of related PF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PF> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <param name="Value">List of related PF entities</param>
        /// <returns>True if the list of related PF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PF> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <returns>List of related PF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PF> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PF> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <returns>Related PF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PF FindByPFKEY(string PFKEY)
        {
            return Index_PFKEY.Value[PFKEY];
        }

        /// <summary>
        /// Attempt to find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <param name="Value">Related PF entity</param>
        /// <returns>True if the related PF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPFKEY(string PFKEY, out PF Value)
        {
            return Index_PFKEY.Value.TryGetValue(PFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <returns>Related PF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PF TryFindByPFKEY(string PFKEY)
        {
            PF value;
            if (Index_PFKEY.Value.TryGetValue(PFKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PF table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PF]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PF](
        [PFKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [CREATE_EXPORT_FILE] varchar(1) NULL,
        [ABN] varchar(11) NULL,
        [USI] varchar(15) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PF_Index_PFKEY] PRIMARY KEY CLUSTERED (
            [PFKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PF_Index_GLCODE] ON [dbo].[PF]
    (
            [GLCODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PF]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[PF] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PF]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[PF] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PF"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PF"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PF> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_PFKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_PFKEY.Add(entity.PFKEY);
            }

            builder.AppendLine("DELETE [dbo].[PF] WHERE");


            // Index_PFKEY
            builder.Append("[PFKEY] IN (");
            for (int index = 0; index < Index_PFKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PFKEY
                var parameterPFKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPFKEY);
                command.Parameters.Add(parameterPFKEY, SqlDbType.VarChar, 10).Value = Index_PFKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PF data set</returns>
        public override EduHubDataSetDataReader<PF> GetDataSetDataReader()
        {
            return new PFDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PF data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PF data set</returns>
        public override EduHubDataSetDataReader<PF> GetDataSetDataReader(List<PF> Entities)
        {
            return new PFDataReader(new EduHubDataSetLoadedReader<PF>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PFDataReader : EduHubDataSetDataReader<PF>
        {
            public PFDataReader(IEduHubDataSetReader<PF> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PFKEY
                        return Current.PFKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // GLCODE
                        return Current.GLCODE;
                    case 3: // CREATE_EXPORT_FILE
                        return Current.CREATE_EXPORT_FILE;
                    case 4: // ABN
                        return Current.ABN;
                    case 5: // USI
                        return Current.USI;
                    case 6: // LW_DATE
                        return Current.LW_DATE;
                    case 7: // LW_TIME
                        return Current.LW_TIME;
                    case 8: // LW_USER
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
                    case 2: // GLCODE
                        return Current.GLCODE == null;
                    case 3: // CREATE_EXPORT_FILE
                        return Current.CREATE_EXPORT_FILE == null;
                    case 4: // ABN
                        return Current.ABN == null;
                    case 5: // USI
                        return Current.USI == null;
                    case 6: // LW_DATE
                        return Current.LW_DATE == null;
                    case 7: // LW_TIME
                        return Current.LW_TIME == null;
                    case 8: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PFKEY
                        return "PFKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // GLCODE
                        return "GLCODE";
                    case 3: // CREATE_EXPORT_FILE
                        return "CREATE_EXPORT_FILE";
                    case 4: // ABN
                        return "ABN";
                    case 5: // USI
                        return "USI";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PFKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "GLCODE":
                        return 2;
                    case "CREATE_EXPORT_FILE":
                        return 3;
                    case "ABN":
                        return 4;
                    case "USI":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
