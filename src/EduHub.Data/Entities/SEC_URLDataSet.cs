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
    /// eCASES21 School Links URL Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_URLDataSet : EduHubDataSet<SEC_URL>
    {
        /// <inheritdoc />
        public override string Name { get { return "SEC_URL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SEC_URLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHOOLURLID = new Lazy<Dictionary<int, SEC_URL>>(() => this.ToDictionary(i => i.SCHOOLURLID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_URL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_URL" /> fields for each CSV column header</returns>
        internal override Action<SEC_URL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_URL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOLURLID":
                        mapper[i] = (e, v) => e.SCHOOLURLID = int.Parse(v);
                        break;
                    case "LINKNAME":
                        mapper[i] = (e, v) => e.LINKNAME = v;
                        break;
                    case "MAINURL":
                        mapper[i] = (e, v) => e.MAINURL = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_URL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SEC_URL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SEC_URL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SEC_URL}"/> of entities</returns>
        internal override IEnumerable<SEC_URL> ApplyDeltaEntities(IEnumerable<SEC_URL> Entities, List<SEC_URL> DeltaEntities)
        {
            HashSet<int> Index_SCHOOLURLID = new HashSet<int>(DeltaEntities.Select(i => i.SCHOOLURLID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCHOOLURLID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SCHOOLURLID.Remove(entity.SCHOOLURLID);
                            
                            if (entity.SCHOOLURLID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SEC_URL>> Index_SCHOOLURLID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_URL FindBySCHOOLURLID(int SCHOOLURLID)
        {
            return Index_SCHOOLURLID.Value[SCHOOLURLID];
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <param name="Value">Related SEC_URL entity</param>
        /// <returns>True if the related SEC_URL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOLURLID(int SCHOOLURLID, out SEC_URL Value)
        {
            return Index_SCHOOLURLID.Value.TryGetValue(SCHOOLURLID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_URL by SCHOOLURLID field
        /// </summary>
        /// <param name="SCHOOLURLID">SCHOOLURLID value used to find SEC_URL</param>
        /// <returns>Related SEC_URL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_URL TryFindBySCHOOLURLID(int SCHOOLURLID)
        {
            SEC_URL value;
            if (Index_SCHOOLURLID.Value.TryGetValue(SCHOOLURLID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SEC_URL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_URL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_URL](
        [SCHOOLURLID] int IDENTITY NOT NULL,
        [LINKNAME] varchar(50) NULL,
        [MAINURL] varchar(200) NULL,
        CONSTRAINT [SEC_URL_Index_SCHOOLURLID] PRIMARY KEY CLUSTERED (
            [SCHOOLURLID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SEC_URLDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SEC_URLDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SEC_URL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SEC_URL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SEC_URL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SCHOOLURLID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SCHOOLURLID.Add(entity.SCHOOLURLID);
            }

            builder.AppendLine("DELETE [dbo].[SEC_URL] WHERE");


            // Index_SCHOOLURLID
            builder.Append("[SCHOOLURLID] IN (");
            for (int index = 0; index < Index_SCHOOLURLID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCHOOLURLID
                var parameterSCHOOLURLID = $"@p{parameterIndex++}";
                builder.Append(parameterSCHOOLURLID);
                command.Parameters.Add(parameterSCHOOLURLID, SqlDbType.Int).Value = Index_SCHOOLURLID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_URL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_URL data set</returns>
        public override EduHubDataSetDataReader<SEC_URL> GetDataSetDataReader()
        {
            return new SEC_URLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_URL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_URL data set</returns>
        public override EduHubDataSetDataReader<SEC_URL> GetDataSetDataReader(List<SEC_URL> Entities)
        {
            return new SEC_URLDataReader(new EduHubDataSetLoadedReader<SEC_URL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_URLDataReader : EduHubDataSetDataReader<SEC_URL>
        {
            public SEC_URLDataReader(IEduHubDataSetReader<SEC_URL> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 3; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCHOOLURLID
                        return Current.SCHOOLURLID;
                    case 1: // LINKNAME
                        return Current.LINKNAME;
                    case 2: // MAINURL
                        return Current.MAINURL;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LINKNAME
                        return Current.LINKNAME == null;
                    case 2: // MAINURL
                        return Current.MAINURL == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCHOOLURLID
                        return "SCHOOLURLID";
                    case 1: // LINKNAME
                        return "LINKNAME";
                    case 2: // MAINURL
                        return "MAINURL";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCHOOLURLID":
                        return 0;
                    case "LINKNAME":
                        return 1;
                    case "MAINURL":
                        return 2;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
