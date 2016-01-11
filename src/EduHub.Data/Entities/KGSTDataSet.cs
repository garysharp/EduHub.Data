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
    /// GST Percentages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGSTDataSet : EduHubDataSet<KGST>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGST"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGSTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLGST_CODE = new Lazy<NullDictionary<string, IReadOnlyList<KGST>>>(() => this.ToGroupedNullDictionary(i => i.GLGST_CODE));
            Index_KGSTKEY = new Lazy<Dictionary<string, KGST>>(() => this.ToDictionary(i => i.KGSTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGST" /> fields for each CSV column header</returns>
        internal override Action<KGST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGSTKEY":
                        mapper[i] = (e, v) => e.KGSTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SALE_PURCH":
                        mapper[i] = (e, v) => e.SALE_PURCH = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_BOX":
                        mapper[i] = (e, v) => e.GST_BOX = v;
                        break;
                    case "GLGST_CODE":
                        mapper[i] = (e, v) => e.GLGST_CODE = v;
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "PRIOR_PERIOD_GST":
                        mapper[i] = (e, v) => e.PRIOR_PERIOD_GST = v;
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
        /// Merges <see cref="KGST" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGST" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGST" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGST}"/> of entities</returns>
        internal override IEnumerable<KGST> ApplyDeltaEntities(IEnumerable<KGST> Entities, List<KGST> DeltaEntities)
        {
            HashSet<string> Index_KGSTKEY = new HashSet<string>(DeltaEntities.Select(i => i.KGSTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KGSTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KGSTKEY.Remove(entity.KGSTKEY);
                            
                            if (entity.KGSTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<KGST>>> Index_GLGST_CODE;
        private Lazy<Dictionary<string, KGST>> Index_KGSTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <returns>List of related KGST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGST> FindByGLGST_CODE(string GLGST_CODE)
        {
            return Index_GLGST_CODE.Value[GLGST_CODE];
        }

        /// <summary>
        /// Attempt to find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <param name="Value">List of related KGST entities</param>
        /// <returns>True if the list of related KGST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLGST_CODE(string GLGST_CODE, out IReadOnlyList<KGST> Value)
        {
            return Index_GLGST_CODE.Value.TryGetValue(GLGST_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <returns>List of related KGST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGST> TryFindByGLGST_CODE(string GLGST_CODE)
        {
            IReadOnlyList<KGST> value;
            if (Index_GLGST_CODE.Value.TryGetValue(GLGST_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGST FindByKGSTKEY(string KGSTKEY)
        {
            return Index_KGSTKEY.Value[KGSTKEY];
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <param name="Value">Related KGST entity</param>
        /// <returns>True if the related KGST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGSTKEY(string KGSTKEY, out KGST Value)
        {
            return Index_KGSTKEY.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGST TryFindByKGSTKEY(string KGSTKEY)
        {
            KGST value;
            if (Index_KGSTKEY.Value.TryGetValue(KGSTKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGST table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGST]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGST](
        [KGSTKEY] varchar(4) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [SALE_PURCH] varchar(2) NULL,
        [GST_RATE] float NULL,
        [GST_BOX] varchar(3) NULL,
        [GLGST_CODE] varchar(10) NULL,
        [GST_RECLAIM] varchar(1) NULL,
        [PRIOR_PERIOD_GST] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGST_Index_KGSTKEY] PRIMARY KEY CLUSTERED (
            [KGSTKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGST_Index_GLGST_CODE] ON [dbo].[KGST]
    (
            [GLGST_CODE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGST]') AND name = N'Index_GLGST_CODE')
    ALTER INDEX [Index_GLGST_CODE] ON [dbo].[KGST] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGST]') AND name = N'Index_GLGST_CODE')
    ALTER INDEX [Index_GLGST_CODE] ON [dbo].[KGST] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGST"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGST"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGST> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KGSTKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KGSTKEY.Add(entity.KGSTKEY);
            }

            builder.AppendLine("DELETE [dbo].[KGST] WHERE");


            // Index_KGSTKEY
            builder.Append("[KGSTKEY] IN (");
            for (int index = 0; index < Index_KGSTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KGSTKEY
                var parameterKGSTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKGSTKEY);
                command.Parameters.Add(parameterKGSTKEY, SqlDbType.VarChar, 4).Value = Index_KGSTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGST data set</returns>
        public override EduHubDataSetDataReader<KGST> GetDataSetDataReader()
        {
            return new KGSTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGST data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGST data set</returns>
        public override EduHubDataSetDataReader<KGST> GetDataSetDataReader(List<KGST> Entities)
        {
            return new KGSTDataReader(new EduHubDataSetLoadedReader<KGST>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGSTDataReader : EduHubDataSetDataReader<KGST>
        {
            public KGSTDataReader(IEduHubDataSetReader<KGST> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KGSTKEY
                        return Current.KGSTKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // SALE_PURCH
                        return Current.SALE_PURCH;
                    case 3: // GST_RATE
                        return Current.GST_RATE;
                    case 4: // GST_BOX
                        return Current.GST_BOX;
                    case 5: // GLGST_CODE
                        return Current.GLGST_CODE;
                    case 6: // GST_RECLAIM
                        return Current.GST_RECLAIM;
                    case 7: // PRIOR_PERIOD_GST
                        return Current.PRIOR_PERIOD_GST;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // SALE_PURCH
                        return Current.SALE_PURCH == null;
                    case 3: // GST_RATE
                        return Current.GST_RATE == null;
                    case 4: // GST_BOX
                        return Current.GST_BOX == null;
                    case 5: // GLGST_CODE
                        return Current.GLGST_CODE == null;
                    case 6: // GST_RECLAIM
                        return Current.GST_RECLAIM == null;
                    case 7: // PRIOR_PERIOD_GST
                        return Current.PRIOR_PERIOD_GST == null;
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
                    case 0: // KGSTKEY
                        return "KGSTKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // SALE_PURCH
                        return "SALE_PURCH";
                    case 3: // GST_RATE
                        return "GST_RATE";
                    case 4: // GST_BOX
                        return "GST_BOX";
                    case 5: // GLGST_CODE
                        return "GLGST_CODE";
                    case 6: // GST_RECLAIM
                        return "GST_RECLAIM";
                    case 7: // PRIOR_PERIOD_GST
                        return "PRIOR_PERIOD_GST";
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
                    case "KGSTKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "SALE_PURCH":
                        return 2;
                    case "GST_RATE":
                        return 3;
                    case "GST_BOX":
                        return 4;
                    case "GLGST_CODE":
                        return 5;
                    case "GST_RECLAIM":
                        return 6;
                    case "PRIOR_PERIOD_GST":
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
