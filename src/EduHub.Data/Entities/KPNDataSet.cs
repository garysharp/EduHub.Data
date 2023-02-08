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
    /// Note Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPNDataSet : EduHubDataSet<KPN>
    {
        /// <inheritdoc />
        public override string Name { get { return "KPN"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KPNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPNKEY = new Lazy<Dictionary<string, KPN>>(() => this.ToDictionary(i => i.KPNKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPN" /> fields for each CSV column header</returns>
        internal override Action<KPN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPNKEY":
                        mapper[i] = (e, v) => e.KPNKEY = v;
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
        /// Merges <see cref="KPN" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KPN" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KPN" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KPN}"/> of entities</returns>
        internal override IEnumerable<KPN> ApplyDeltaEntities(IEnumerable<KPN> Entities, List<KPN> DeltaEntities)
        {
            HashSet<string> Index_KPNKEY = new HashSet<string>(DeltaEntities.Select(i => i.KPNKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KPNKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KPNKEY.Remove(entity.KPNKEY);
                            
                            if (entity.KPNKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KPN>> Index_KPNKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPN by KPNKEY field
        /// </summary>
        /// <param name="KPNKEY">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPN FindByKPNKEY(string KPNKEY)
        {
            return Index_KPNKEY.Value[KPNKEY];
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY field
        /// </summary>
        /// <param name="KPNKEY">KPNKEY value used to find KPN</param>
        /// <param name="Value">Related KPN entity</param>
        /// <returns>True if the related KPN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPNKEY(string KPNKEY, out KPN Value)
        {
            return Index_KPNKEY.Value.TryGetValue(KPNKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY field
        /// </summary>
        /// <param name="KPNKEY">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPN TryFindByKPNKEY(string KPNKEY)
        {
            KPN value;
            if (Index_KPNKEY.Value.TryGetValue(KPNKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KPN table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPN](
        [KPNKEY] varchar(6) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPN_Index_KPNKEY] PRIMARY KEY CLUSTERED (
            [KPNKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KPNDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KPNDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KPN"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KPN"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KPN> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KPNKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KPNKEY.Add(entity.KPNKEY);
            }

            builder.AppendLine("DELETE [dbo].[KPN] WHERE");


            // Index_KPNKEY
            builder.Append("[KPNKEY] IN (");
            for (int index = 0; index < Index_KPNKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KPNKEY
                var parameterKPNKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKPNKEY);
                command.Parameters.Add(parameterKPNKEY, SqlDbType.VarChar, 6).Value = Index_KPNKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPN data set</returns>
        public override EduHubDataSetDataReader<KPN> GetDataSetDataReader()
        {
            return new KPNDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPN data set</returns>
        public override EduHubDataSetDataReader<KPN> GetDataSetDataReader(List<KPN> Entities)
        {
            return new KPNDataReader(new EduHubDataSetLoadedReader<KPN>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPNDataReader : EduHubDataSetDataReader<KPN>
        {
            public KPNDataReader(IEduHubDataSetReader<KPN> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KPNKEY
                        return Current.KPNKEY;
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
                    case 0: // KPNKEY
                        return "KPNKEY";
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
                    case "KPNKEY":
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
#endif
