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
    /// Contact Relationship Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCRDataSet : EduHubDataSet<KPCR>
    {
        /// <inheritdoc />
        public override string Name { get { return "KPCR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KPCRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPCRKEY = new Lazy<Dictionary<string, KPCR>>(() => this.ToDictionary(i => i.KPCRKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPCR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPCR" /> fields for each CSV column header</returns>
        internal override Action<KPCR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPCR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCRKEY":
                        mapper[i] = (e, v) => e.KPCRKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="KPCR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KPCR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KPCR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KPCR}"/> of entities</returns>
        internal override IEnumerable<KPCR> ApplyDeltaEntities(IEnumerable<KPCR> Entities, List<KPCR> DeltaEntities)
        {
            HashSet<string> Index_KPCRKEY = new HashSet<string>(DeltaEntities.Select(i => i.KPCRKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KPCRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KPCRKEY.Remove(entity.KPCRKEY);
                            
                            if (entity.KPCRKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KPCR>> Index_KPCRKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <returns>Related KPCR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCR FindByKPCRKEY(string KPCRKEY)
        {
            return Index_KPCRKEY.Value[KPCRKEY];
        }

        /// <summary>
        /// Attempt to find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <param name="Value">Related KPCR entity</param>
        /// <returns>True if the related KPCR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCRKEY(string KPCRKEY, out KPCR Value)
        {
            return Index_KPCRKEY.Value.TryGetValue(KPCRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPCR by KPCRKEY field
        /// </summary>
        /// <param name="KPCRKEY">KPCRKEY value used to find KPCR</param>
        /// <returns>Related KPCR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCR TryFindByKPCRKEY(string KPCRKEY)
        {
            KPCR value;
            if (Index_KPCRKEY.Value.TryGetValue(KPCRKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KPCR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPCR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPCR](
        [KPCRKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPCR_Index_KPCRKEY] PRIMARY KEY CLUSTERED (
            [KPCRKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KPCRDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KPCRDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KPCR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KPCR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KPCR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KPCRKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KPCRKEY.Add(entity.KPCRKEY);
            }

            builder.AppendLine("DELETE [dbo].[KPCR] WHERE");


            // Index_KPCRKEY
            builder.Append("[KPCRKEY] IN (");
            for (int index = 0; index < Index_KPCRKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KPCRKEY
                var parameterKPCRKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKPCRKEY);
                command.Parameters.Add(parameterKPCRKEY, SqlDbType.VarChar, 10).Value = Index_KPCRKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPCR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPCR data set</returns>
        public override EduHubDataSetDataReader<KPCR> GetDataSetDataReader()
        {
            return new KPCRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPCR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPCR data set</returns>
        public override EduHubDataSetDataReader<KPCR> GetDataSetDataReader(List<KPCR> Entities)
        {
            return new KPCRDataReader(new EduHubDataSetLoadedReader<KPCR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPCRDataReader : EduHubDataSetDataReader<KPCR>
        {
            public KPCRDataReader(IEduHubDataSetReader<KPCR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KPCRKEY
                        return Current.KPCRKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // LW_DATE
                        return Current.LW_DATE;
                    case 3: // LW_TIME
                        return Current.LW_TIME;
                    case 4: // LW_USER
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
                    case 2: // LW_DATE
                        return Current.LW_DATE == null;
                    case 3: // LW_TIME
                        return Current.LW_TIME == null;
                    case 4: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KPCRKEY
                        return "KPCRKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KPCRKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
