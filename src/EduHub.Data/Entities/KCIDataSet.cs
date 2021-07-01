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
    /// Religious Instruction Curricula Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCIDataSet : EduHubDataSet<KCI>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCIKEY = new Lazy<Dictionary<string, KCI>>(() => this.ToDictionary(i => i.KCIKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCI" /> fields for each CSV column header</returns>
        internal override Action<KCI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCIKEY":
                        mapper[i] = (e, v) => e.KCIKEY = v;
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
        /// Merges <see cref="KCI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCI}"/> of entities</returns>
        internal override IEnumerable<KCI> ApplyDeltaEntities(IEnumerable<KCI> Entities, List<KCI> DeltaEntities)
        {
            HashSet<string> Index_KCIKEY = new HashSet<string>(DeltaEntities.Select(i => i.KCIKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KCIKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KCIKEY.Remove(entity.KCIKEY);
                            
                            if (entity.KCIKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KCI>> Index_KCIKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCI by KCIKEY field
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find KCI</param>
        /// <returns>Related KCI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCI FindByKCIKEY(string KCIKEY)
        {
            return Index_KCIKEY.Value[KCIKEY];
        }

        /// <summary>
        /// Attempt to find KCI by KCIKEY field
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find KCI</param>
        /// <param name="Value">Related KCI entity</param>
        /// <returns>True if the related KCI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCIKEY(string KCIKEY, out KCI Value)
        {
            return Index_KCIKEY.Value.TryGetValue(KCIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCI by KCIKEY field
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find KCI</param>
        /// <returns>Related KCI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCI TryFindByKCIKEY(string KCIKEY)
        {
            KCI value;
            if (Index_KCIKEY.Value.TryGetValue(KCIKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCI](
        [KCIKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCI_Index_KCIKEY] PRIMARY KEY CLUSTERED (
            [KCIKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KCIDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KCIDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KCIKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KCIKEY.Add(entity.KCIKEY);
            }

            builder.AppendLine("DELETE [dbo].[KCI] WHERE");


            // Index_KCIKEY
            builder.Append("[KCIKEY] IN (");
            for (int index = 0; index < Index_KCIKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KCIKEY
                var parameterKCIKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKCIKEY);
                command.Parameters.Add(parameterKCIKEY, SqlDbType.VarChar, 10).Value = Index_KCIKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCI data set</returns>
        public override EduHubDataSetDataReader<KCI> GetDataSetDataReader()
        {
            return new KCIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCI data set</returns>
        public override EduHubDataSetDataReader<KCI> GetDataSetDataReader(List<KCI> Entities)
        {
            return new KCIDataReader(new EduHubDataSetLoadedReader<KCI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCIDataReader : EduHubDataSetDataReader<KCI>
        {
            public KCIDataReader(IEduHubDataSetReader<KCI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KCIKEY
                        return Current.KCIKEY;
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
                    case 0: // KCIKEY
                        return "KCIKEY";
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
                    case "KCIKEY":
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
