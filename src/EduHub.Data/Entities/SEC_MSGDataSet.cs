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
    /// eCASES21 School Message Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_MSGDataSet : EduHubDataSet<SEC_MSG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SEC_MSG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SEC_MSGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCHOOLMSGID = new Lazy<Dictionary<int, SEC_MSG>>(() => this.ToDictionary(i => i.SCHOOLMSGID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_MSG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_MSG" /> fields for each CSV column header</returns>
        internal override Action<SEC_MSG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_MSG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOLMSGID":
                        mapper[i] = (e, v) => e.SCHOOLMSGID = int.Parse(v);
                        break;
                    case "MSGTEXT":
                        mapper[i] = (e, v) => e.MSGTEXT = v;
                        break;
                    case "EDITBYUSERID":
                        mapper[i] = (e, v) => e.EDITBYUSERID = v;
                        break;
                    case "EDITDATE":
                        mapper[i] = (e, v) => e.EDITDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_MSG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SEC_MSG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SEC_MSG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SEC_MSG}"/> of entities</returns>
        internal override IEnumerable<SEC_MSG> ApplyDeltaEntities(IEnumerable<SEC_MSG> Entities, List<SEC_MSG> DeltaEntities)
        {
            HashSet<int> Index_SCHOOLMSGID = new HashSet<int>(DeltaEntities.Select(i => i.SCHOOLMSGID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SCHOOLMSGID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SCHOOLMSGID.Remove(entity.SCHOOLMSGID);
                            
                            if (entity.SCHOOLMSGID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SEC_MSG>> Index_SCHOOLMSGID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <returns>Related SEC_MSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_MSG FindBySCHOOLMSGID(int SCHOOLMSGID)
        {
            return Index_SCHOOLMSGID.Value[SCHOOLMSGID];
        }

        /// <summary>
        /// Attempt to find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <param name="Value">Related SEC_MSG entity</param>
        /// <returns>True if the related SEC_MSG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOLMSGID(int SCHOOLMSGID, out SEC_MSG Value)
        {
            return Index_SCHOOLMSGID.Value.TryGetValue(SCHOOLMSGID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_MSG by SCHOOLMSGID field
        /// </summary>
        /// <param name="SCHOOLMSGID">SCHOOLMSGID value used to find SEC_MSG</param>
        /// <returns>Related SEC_MSG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_MSG TryFindBySCHOOLMSGID(int SCHOOLMSGID)
        {
            SEC_MSG value;
            if (Index_SCHOOLMSGID.Value.TryGetValue(SCHOOLMSGID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SEC_MSG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_MSG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_MSG](
        [SCHOOLMSGID] int IDENTITY NOT NULL,
        [MSGTEXT] varchar(MAX) NULL,
        [EDITBYUSERID] varchar(10) NULL,
        [EDITDATE] datetime NULL,
        CONSTRAINT [SEC_MSG_Index_SCHOOLMSGID] PRIMARY KEY CLUSTERED (
            [SCHOOLMSGID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SEC_MSGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SEC_MSGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SEC_MSG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SEC_MSG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SEC_MSG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_SCHOOLMSGID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_SCHOOLMSGID.Add(entity.SCHOOLMSGID);
            }

            builder.AppendLine("DELETE [dbo].[SEC_MSG] WHERE");


            // Index_SCHOOLMSGID
            builder.Append("[SCHOOLMSGID] IN (");
            for (int index = 0; index < Index_SCHOOLMSGID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SCHOOLMSGID
                var parameterSCHOOLMSGID = $"@p{parameterIndex++}";
                builder.Append(parameterSCHOOLMSGID);
                command.Parameters.Add(parameterSCHOOLMSGID, SqlDbType.Int).Value = Index_SCHOOLMSGID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_MSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_MSG data set</returns>
        public override EduHubDataSetDataReader<SEC_MSG> GetDataSetDataReader()
        {
            return new SEC_MSGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_MSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_MSG data set</returns>
        public override EduHubDataSetDataReader<SEC_MSG> GetDataSetDataReader(List<SEC_MSG> Entities)
        {
            return new SEC_MSGDataReader(new EduHubDataSetLoadedReader<SEC_MSG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_MSGDataReader : EduHubDataSetDataReader<SEC_MSG>
        {
            public SEC_MSGDataReader(IEduHubDataSetReader<SEC_MSG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SCHOOLMSGID
                        return Current.SCHOOLMSGID;
                    case 1: // MSGTEXT
                        return Current.MSGTEXT;
                    case 2: // EDITBYUSERID
                        return Current.EDITBYUSERID;
                    case 3: // EDITDATE
                        return Current.EDITDATE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // MSGTEXT
                        return Current.MSGTEXT == null;
                    case 2: // EDITBYUSERID
                        return Current.EDITBYUSERID == null;
                    case 3: // EDITDATE
                        return Current.EDITDATE == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SCHOOLMSGID
                        return "SCHOOLMSGID";
                    case 1: // MSGTEXT
                        return "MSGTEXT";
                    case 2: // EDITBYUSERID
                        return "EDITBYUSERID";
                    case 3: // EDITDATE
                        return "EDITDATE";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SCHOOLMSGID":
                        return 0;
                    case "MSGTEXT":
                        return 1;
                    case "EDITBYUSERID":
                        return 2;
                    case "EDITDATE":
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
