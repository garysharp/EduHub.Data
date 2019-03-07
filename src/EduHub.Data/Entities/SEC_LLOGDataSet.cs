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
    /// eCASES21 Login Log Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_LLOGDataSet : EduHubDataSet<SEC_LLOG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SEC_LLOG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SEC_LLOGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOGINLOGID = new Lazy<Dictionary<int, SEC_LLOG>>(() => this.ToDictionary(i => i.LOGINLOGID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_LLOG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_LLOG" /> fields for each CSV column header</returns>
        internal override Action<SEC_LLOG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_LLOG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOGINLOGID":
                        mapper[i] = (e, v) => e.LOGINLOGID = int.Parse(v);
                        break;
                    case "SERVER":
                        mapper[i] = (e, v) => e.SERVER = v;
                        break;
                    case "VERSION":
                        mapper[i] = (e, v) => e.VERSION = v;
                        break;
                    case "USERID":
                        mapper[i] = (e, v) => e.USERID = v;
                        break;
                    case "USERNAME":
                        mapper[i] = (e, v) => e.USERNAME = v;
                        break;
                    case "BROWSER":
                        mapper[i] = (e, v) => e.BROWSER = v;
                        break;
                    case "SCREENSIZE":
                        mapper[i] = (e, v) => e.SCREENSIZE = v;
                        break;
                    case "RESULT":
                        mapper[i] = (e, v) => e.RESULT = v;
                        break;
                    case "IPADDRESS":
                        mapper[i] = (e, v) => e.IPADDRESS = v;
                        break;
                    case "SESSIONID":
                        mapper[i] = (e, v) => e.SESSIONID = v;
                        break;
                    case "LOGGEDOUT":
                        mapper[i] = (e, v) => e.LOGGEDOUT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LOGINTIME":
                        mapper[i] = (e, v) => e.LOGINTIME = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LOGOUTTIME":
                        mapper[i] = (e, v) => e.LOGOUTTIME = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LOGGEDPERIOD":
                        mapper[i] = (e, v) => e.LOGGEDPERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_LLOG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SEC_LLOG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SEC_LLOG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SEC_LLOG}"/> of entities</returns>
        internal override IEnumerable<SEC_LLOG> ApplyDeltaEntities(IEnumerable<SEC_LLOG> Entities, List<SEC_LLOG> DeltaEntities)
        {
            HashSet<int> Index_LOGINLOGID = new HashSet<int>(DeltaEntities.Select(i => i.LOGINLOGID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.LOGINLOGID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_LOGINLOGID.Remove(entity.LOGINLOGID);
                            
                            if (entity.LOGINLOGID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SEC_LLOG>> Index_LOGINLOGID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_LLOG FindByLOGINLOGID(int LOGINLOGID)
        {
            return Index_LOGINLOGID.Value[LOGINLOGID];
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <param name="Value">Related SEC_LLOG entity</param>
        /// <returns>True if the related SEC_LLOG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOGINLOGID(int LOGINLOGID, out SEC_LLOG Value)
        {
            return Index_LOGINLOGID.Value.TryGetValue(LOGINLOGID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID field
        /// </summary>
        /// <param name="LOGINLOGID">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_LLOG TryFindByLOGINLOGID(int LOGINLOGID)
        {
            SEC_LLOG value;
            if (Index_LOGINLOGID.Value.TryGetValue(LOGINLOGID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SEC_LLOG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_LLOG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_LLOG](
        [LOGINLOGID] int IDENTITY NOT NULL,
        [SERVER] varchar(50) NULL,
        [VERSION] varchar(10) NULL,
        [USERID] varchar(50) NULL,
        [USERNAME] varchar(150) NULL,
        [BROWSER] varchar(100) NULL,
        [SCREENSIZE] varchar(10) NULL,
        [RESULT] varchar(20) NULL,
        [IPADDRESS] varchar(16) NULL,
        [SESSIONID] varchar(50) NULL,
        [LOGGEDOUT] smallint NULL,
        [LOGINTIME] datetime NULL,
        [LOGOUTTIME] datetime NULL,
        [LOGGEDPERIOD] smallint NULL,
        CONSTRAINT [SEC_LLOG_Index_LOGINLOGID] PRIMARY KEY CLUSTERED (
            [LOGINLOGID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SEC_LLOGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SEC_LLOGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SEC_LLOG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SEC_LLOG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SEC_LLOG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_LOGINLOGID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_LOGINLOGID.Add(entity.LOGINLOGID);
            }

            builder.AppendLine("DELETE [dbo].[SEC_LLOG] WHERE");


            // Index_LOGINLOGID
            builder.Append("[LOGINLOGID] IN (");
            for (int index = 0; index < Index_LOGINLOGID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // LOGINLOGID
                var parameterLOGINLOGID = $"@p{parameterIndex++}";
                builder.Append(parameterLOGINLOGID);
                command.Parameters.Add(parameterLOGINLOGID, SqlDbType.Int).Value = Index_LOGINLOGID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_LLOG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_LLOG data set</returns>
        public override EduHubDataSetDataReader<SEC_LLOG> GetDataSetDataReader()
        {
            return new SEC_LLOGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_LLOG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_LLOG data set</returns>
        public override EduHubDataSetDataReader<SEC_LLOG> GetDataSetDataReader(List<SEC_LLOG> Entities)
        {
            return new SEC_LLOGDataReader(new EduHubDataSetLoadedReader<SEC_LLOG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_LLOGDataReader : EduHubDataSetDataReader<SEC_LLOG>
        {
            public SEC_LLOGDataReader(IEduHubDataSetReader<SEC_LLOG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // LOGINLOGID
                        return Current.LOGINLOGID;
                    case 1: // SERVER
                        return Current.SERVER;
                    case 2: // VERSION
                        return Current.VERSION;
                    case 3: // USERID
                        return Current.USERID;
                    case 4: // USERNAME
                        return Current.USERNAME;
                    case 5: // BROWSER
                        return Current.BROWSER;
                    case 6: // SCREENSIZE
                        return Current.SCREENSIZE;
                    case 7: // RESULT
                        return Current.RESULT;
                    case 8: // IPADDRESS
                        return Current.IPADDRESS;
                    case 9: // SESSIONID
                        return Current.SESSIONID;
                    case 10: // LOGGEDOUT
                        return Current.LOGGEDOUT;
                    case 11: // LOGINTIME
                        return Current.LOGINTIME;
                    case 12: // LOGOUTTIME
                        return Current.LOGOUTTIME;
                    case 13: // LOGGEDPERIOD
                        return Current.LOGGEDPERIOD;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SERVER
                        return Current.SERVER == null;
                    case 2: // VERSION
                        return Current.VERSION == null;
                    case 3: // USERID
                        return Current.USERID == null;
                    case 4: // USERNAME
                        return Current.USERNAME == null;
                    case 5: // BROWSER
                        return Current.BROWSER == null;
                    case 6: // SCREENSIZE
                        return Current.SCREENSIZE == null;
                    case 7: // RESULT
                        return Current.RESULT == null;
                    case 8: // IPADDRESS
                        return Current.IPADDRESS == null;
                    case 9: // SESSIONID
                        return Current.SESSIONID == null;
                    case 10: // LOGGEDOUT
                        return Current.LOGGEDOUT == null;
                    case 11: // LOGINTIME
                        return Current.LOGINTIME == null;
                    case 12: // LOGOUTTIME
                        return Current.LOGOUTTIME == null;
                    case 13: // LOGGEDPERIOD
                        return Current.LOGGEDPERIOD == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // LOGINLOGID
                        return "LOGINLOGID";
                    case 1: // SERVER
                        return "SERVER";
                    case 2: // VERSION
                        return "VERSION";
                    case 3: // USERID
                        return "USERID";
                    case 4: // USERNAME
                        return "USERNAME";
                    case 5: // BROWSER
                        return "BROWSER";
                    case 6: // SCREENSIZE
                        return "SCREENSIZE";
                    case 7: // RESULT
                        return "RESULT";
                    case 8: // IPADDRESS
                        return "IPADDRESS";
                    case 9: // SESSIONID
                        return "SESSIONID";
                    case 10: // LOGGEDOUT
                        return "LOGGEDOUT";
                    case 11: // LOGINTIME
                        return "LOGINTIME";
                    case 12: // LOGOUTTIME
                        return "LOGOUTTIME";
                    case 13: // LOGGEDPERIOD
                        return "LOGGEDPERIOD";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "LOGINLOGID":
                        return 0;
                    case "SERVER":
                        return 1;
                    case "VERSION":
                        return 2;
                    case "USERID":
                        return 3;
                    case "USERNAME":
                        return 4;
                    case "BROWSER":
                        return 5;
                    case "SCREENSIZE":
                        return 6;
                    case "RESULT":
                        return 7;
                    case "IPADDRESS":
                        return 8;
                    case "SESSIONID":
                        return 9;
                    case "LOGGEDOUT":
                        return 10;
                    case "LOGINTIME":
                        return 11;
                    case "LOGOUTTIME":
                        return 12;
                    case "LOGGEDPERIOD":
                        return 13;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
