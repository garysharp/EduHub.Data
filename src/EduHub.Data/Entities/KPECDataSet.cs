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
    /// Employee Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPECDataSet : EduHubDataSet<KPEC>
    {
        /// <inheritdoc />
        public override string Name { get { return "KPEC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KPECDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPECKEY = new Lazy<Dictionary<string, KPEC>>(() => this.ToDictionary(i => i.KPECKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPEC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPEC" /> fields for each CSV column header</returns>
        internal override Action<KPEC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPEC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPECKEY":
                        mapper[i] = (e, v) => e.KPECKEY = v;
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
        /// Merges <see cref="KPEC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KPEC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KPEC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KPEC}"/> of entities</returns>
        internal override IEnumerable<KPEC> ApplyDeltaEntities(IEnumerable<KPEC> Entities, List<KPEC> DeltaEntities)
        {
            HashSet<string> Index_KPECKEY = new HashSet<string>(DeltaEntities.Select(i => i.KPECKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KPECKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KPECKEY.Remove(entity.KPECKEY);
                            
                            if (entity.KPECKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KPEC>> Index_KPECKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPEC by KPECKEY field
        /// </summary>
        /// <param name="KPECKEY">KPECKEY value used to find KPEC</param>
        /// <returns>Related KPEC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPEC FindByKPECKEY(string KPECKEY)
        {
            return Index_KPECKEY.Value[KPECKEY];
        }

        /// <summary>
        /// Attempt to find KPEC by KPECKEY field
        /// </summary>
        /// <param name="KPECKEY">KPECKEY value used to find KPEC</param>
        /// <param name="Value">Related KPEC entity</param>
        /// <returns>True if the related KPEC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPECKEY(string KPECKEY, out KPEC Value)
        {
            return Index_KPECKEY.Value.TryGetValue(KPECKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPEC by KPECKEY field
        /// </summary>
        /// <param name="KPECKEY">KPECKEY value used to find KPEC</param>
        /// <returns>Related KPEC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPEC TryFindByKPECKEY(string KPECKEY)
        {
            KPEC value;
            if (Index_KPECKEY.Value.TryGetValue(KPECKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KPEC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPEC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPEC](
        [KPECKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPEC_Index_KPECKEY] PRIMARY KEY CLUSTERED (
            [KPECKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KPECDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KPECDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KPEC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KPEC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KPEC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KPECKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KPECKEY.Add(entity.KPECKEY);
            }

            builder.AppendLine("DELETE [dbo].[KPEC] WHERE");


            // Index_KPECKEY
            builder.Append("[KPECKEY] IN (");
            for (int index = 0; index < Index_KPECKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KPECKEY
                var parameterKPECKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKPECKEY);
                command.Parameters.Add(parameterKPECKEY, SqlDbType.VarChar, 10).Value = Index_KPECKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPEC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPEC data set</returns>
        public override EduHubDataSetDataReader<KPEC> GetDataSetDataReader()
        {
            return new KPECDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPEC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPEC data set</returns>
        public override EduHubDataSetDataReader<KPEC> GetDataSetDataReader(List<KPEC> Entities)
        {
            return new KPECDataReader(new EduHubDataSetLoadedReader<KPEC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPECDataReader : EduHubDataSetDataReader<KPEC>
        {
            public KPECDataReader(IEduHubDataSetReader<KPEC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KPECKEY
                        return Current.KPECKEY;
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
                    case 0: // KPECKEY
                        return "KPECKEY";
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
                    case "KPECKEY":
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
