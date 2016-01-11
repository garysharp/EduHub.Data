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
    /// Staff Absence Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCATDataSet : EduHubDataSet<TCAT>
    {
        /// <inheritdoc />
        public override string Name { get { return "TCAT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal TCATDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TCATKEY = new Lazy<Dictionary<string, TCAT>>(() => this.ToDictionary(i => i.TCATKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCAT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCAT" /> fields for each CSV column header</returns>
        internal override Action<TCAT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCAT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCATKEY":
                        mapper[i] = (e, v) => e.TCATKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
        /// Merges <see cref="TCAT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="TCAT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="TCAT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{TCAT}"/> of entities</returns>
        internal override IEnumerable<TCAT> ApplyDeltaEntities(IEnumerable<TCAT> Entities, List<TCAT> DeltaEntities)
        {
            HashSet<string> Index_TCATKEY = new HashSet<string>(DeltaEntities.Select(i => i.TCATKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TCATKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TCATKEY.Remove(entity.TCATKEY);
                            
                            if (entity.TCATKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, TCAT>> Index_TCATKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCAT FindByTCATKEY(string TCATKEY)
        {
            return Index_TCATKEY.Value[TCATKEY];
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <param name="Value">Related TCAT entity</param>
        /// <returns>True if the related TCAT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTCATKEY(string TCATKEY, out TCAT Value)
        {
            return Index_TCATKEY.Value.TryGetValue(TCATKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY field
        /// </summary>
        /// <param name="TCATKEY">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TCAT TryFindByTCATKEY(string TCATKEY)
        {
            TCAT value;
            if (Index_TCATKEY.Value.TryGetValue(TCATKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a TCAT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TCAT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TCAT](
        [TCATKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TCAT_Index_TCATKEY] PRIMARY KEY CLUSTERED (
            [TCATKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="TCATDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="TCATDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="TCAT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="TCAT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<TCAT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_TCATKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_TCATKEY.Add(entity.TCATKEY);
            }

            builder.AppendLine("DELETE [dbo].[TCAT] WHERE");


            // Index_TCATKEY
            builder.Append("[TCATKEY] IN (");
            for (int index = 0; index < Index_TCATKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TCATKEY
                var parameterTCATKEY = $"@p{parameterIndex++}";
                builder.Append(parameterTCATKEY);
                command.Parameters.Add(parameterTCATKEY, SqlDbType.VarChar, 10).Value = Index_TCATKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCAT data set</returns>
        public override EduHubDataSetDataReader<TCAT> GetDataSetDataReader()
        {
            return new TCATDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TCAT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TCAT data set</returns>
        public override EduHubDataSetDataReader<TCAT> GetDataSetDataReader(List<TCAT> Entities)
        {
            return new TCATDataReader(new EduHubDataSetLoadedReader<TCAT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TCATDataReader : EduHubDataSetDataReader<TCAT>
        {
            public TCATDataReader(IEduHubDataSetReader<TCAT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TCATKEY
                        return Current.TCATKEY;
                    case 1: // TITLE
                        return Current.TITLE;
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
                    case 1: // TITLE
                        return Current.TITLE == null;
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
                    case 0: // TCATKEY
                        return "TCATKEY";
                    case 1: // TITLE
                        return "TITLE";
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
                    case "TCATKEY":
                        return 0;
                    case "TITLE":
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
