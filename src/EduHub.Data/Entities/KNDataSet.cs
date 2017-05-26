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
    /// General Ledger Notes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNDataSet : EduHubDataSet<KN>
    {
        /// <inheritdoc />
        public override string Name { get { return "KN"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_NOTE_ID = new Lazy<Dictionary<string, KN>>(() => this.ToDictionary(i => i.NOTE_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KN" /> fields for each CSV column header</returns>
        internal override Action<KN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "NOTE_ID":
                        mapper[i] = (e, v) => e.NOTE_ID = v;
                        break;
                    case "CONTENTS":
                        mapper[i] = (e, v) => e.CONTENTS = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "SCOPE":
                        mapper[i] = (e, v) => e.SCOPE = v;
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
        /// Merges <see cref="KN" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KN" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KN" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KN}"/> of entities</returns>
        internal override IEnumerable<KN> ApplyDeltaEntities(IEnumerable<KN> Entities, List<KN> DeltaEntities)
        {
            HashSet<string> Index_NOTE_ID = new HashSet<string>(DeltaEntities.Select(i => i.NOTE_ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.NOTE_ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_NOTE_ID.Remove(entity.NOTE_ID);
                            
                            if (entity.NOTE_ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KN>> Index_NOTE_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <returns>Related KN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KN FindByNOTE_ID(string NOTE_ID)
        {
            return Index_NOTE_ID.Value[NOTE_ID];
        }

        /// <summary>
        /// Attempt to find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <param name="Value">Related KN entity</param>
        /// <returns>True if the related KN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByNOTE_ID(string NOTE_ID, out KN Value)
        {
            return Index_NOTE_ID.Value.TryGetValue(NOTE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KN by NOTE_ID field
        /// </summary>
        /// <param name="NOTE_ID">NOTE_ID value used to find KN</param>
        /// <returns>Related KN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KN TryFindByNOTE_ID(string NOTE_ID)
        {
            KN value;
            if (Index_NOTE_ID.Value.TryGetValue(NOTE_ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KN table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KN](
        [NOTE_ID] varchar(4) NOT NULL,
        [CONTENTS] varchar(MAX) NULL,
        [ACTIVE] varchar(1) NULL,
        [SCOPE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KN_Index_NOTE_ID] PRIMARY KEY CLUSTERED (
            [NOTE_ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KNDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KNDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KN"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KN"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KN> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_NOTE_ID = new List<string>();

            foreach (var entity in Entities)
            {
                Index_NOTE_ID.Add(entity.NOTE_ID);
            }

            builder.AppendLine("DELETE [dbo].[KN] WHERE");


            // Index_NOTE_ID
            builder.Append("[NOTE_ID] IN (");
            for (int index = 0; index < Index_NOTE_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // NOTE_ID
                var parameterNOTE_ID = $"@p{parameterIndex++}";
                builder.Append(parameterNOTE_ID);
                command.Parameters.Add(parameterNOTE_ID, SqlDbType.VarChar, 4).Value = Index_NOTE_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KN data set</returns>
        public override EduHubDataSetDataReader<KN> GetDataSetDataReader()
        {
            return new KNDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KN data set</returns>
        public override EduHubDataSetDataReader<KN> GetDataSetDataReader(List<KN> Entities)
        {
            return new KNDataReader(new EduHubDataSetLoadedReader<KN>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KNDataReader : EduHubDataSetDataReader<KN>
        {
            public KNDataReader(IEduHubDataSetReader<KN> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // NOTE_ID
                        return Current.NOTE_ID;
                    case 1: // CONTENTS
                        return Current.CONTENTS;
                    case 2: // ACTIVE
                        return Current.ACTIVE;
                    case 3: // SCOPE
                        return Current.SCOPE;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // CONTENTS
                        return Current.CONTENTS == null;
                    case 2: // ACTIVE
                        return Current.ACTIVE == null;
                    case 3: // SCOPE
                        return Current.SCOPE == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // NOTE_ID
                        return "NOTE_ID";
                    case 1: // CONTENTS
                        return "CONTENTS";
                    case 2: // ACTIVE
                        return "ACTIVE";
                    case 3: // SCOPE
                        return "SCOPE";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "NOTE_ID":
                        return 0;
                    case "CONTENTS":
                        return 1;
                    case "ACTIVE":
                        return 2;
                    case "SCOPE":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
