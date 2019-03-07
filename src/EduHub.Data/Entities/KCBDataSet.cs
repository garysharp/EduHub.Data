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
    /// Behaviour Classifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCBDataSet : EduHubDataSet<KCB>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCBKEY = new Lazy<Dictionary<string, KCB>>(() => this.ToDictionary(i => i.KCBKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCB" /> fields for each CSV column header</returns>
        internal override Action<KCB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCBKEY":
                        mapper[i] = (e, v) => e.KCBKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "POS_NEG":
                        mapper[i] = (e, v) => e.POS_NEG = v;
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
        /// Merges <see cref="KCB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCB}"/> of entities</returns>
        internal override IEnumerable<KCB> ApplyDeltaEntities(IEnumerable<KCB> Entities, List<KCB> DeltaEntities)
        {
            HashSet<string> Index_KCBKEY = new HashSet<string>(DeltaEntities.Select(i => i.KCBKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KCBKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KCBKEY.Remove(entity.KCBKEY);
                            
                            if (entity.KCBKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KCB>> Index_KCBKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <returns>Related KCB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCB FindByKCBKEY(string KCBKEY)
        {
            return Index_KCBKEY.Value[KCBKEY];
        }

        /// <summary>
        /// Attempt to find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <param name="Value">Related KCB entity</param>
        /// <returns>True if the related KCB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCBKEY(string KCBKEY, out KCB Value)
        {
            return Index_KCBKEY.Value.TryGetValue(KCBKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCB by KCBKEY field
        /// </summary>
        /// <param name="KCBKEY">KCBKEY value used to find KCB</param>
        /// <returns>Related KCB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCB TryFindByKCBKEY(string KCBKEY)
        {
            KCB value;
            if (Index_KCBKEY.Value.TryGetValue(KCBKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCB](
        [KCBKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [POS_NEG] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCB_Index_KCBKEY] PRIMARY KEY CLUSTERED (
            [KCBKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KCBDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KCBDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KCBKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KCBKEY.Add(entity.KCBKEY);
            }

            builder.AppendLine("DELETE [dbo].[KCB] WHERE");


            // Index_KCBKEY
            builder.Append("[KCBKEY] IN (");
            for (int index = 0; index < Index_KCBKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KCBKEY
                var parameterKCBKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKCBKEY);
                command.Parameters.Add(parameterKCBKEY, SqlDbType.VarChar, 10).Value = Index_KCBKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCB data set</returns>
        public override EduHubDataSetDataReader<KCB> GetDataSetDataReader()
        {
            return new KCBDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCB data set</returns>
        public override EduHubDataSetDataReader<KCB> GetDataSetDataReader(List<KCB> Entities)
        {
            return new KCBDataReader(new EduHubDataSetLoadedReader<KCB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCBDataReader : EduHubDataSetDataReader<KCB>
        {
            public KCBDataReader(IEduHubDataSetReader<KCB> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KCBKEY
                        return Current.KCBKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // POS_NEG
                        return Current.POS_NEG;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_USER
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
                    case 2: // POS_NEG
                        return Current.POS_NEG == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCBKEY
                        return "KCBKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // POS_NEG
                        return "POS_NEG";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCBKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "POS_NEG":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
