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
    /// eCASES21 User Sessions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_USRDataSet : EduHubDataSet<SEC_USR>
    {
        /// <inheritdoc />
        public override string Name { get { return "SEC_USR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SEC_USRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROWID = new Lazy<Dictionary<int, SEC_USR>>(() => this.ToDictionary(i => i.ROWID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_USR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_USR" /> fields for each CSV column header</returns>
        internal override Action<SEC_USR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_USR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROWID":
                        mapper[i] = (e, v) => e.ROWID = int.Parse(v);
                        break;
                    case "SESSIONID":
                        mapper[i] = (e, v) => e.SESSIONID = v;
                        break;
                    case "USERID":
                        mapper[i] = (e, v) => e.USERID = v;
                        break;
                    case "DATECREATED":
                        mapper[i] = (e, v) => e.DATECREATED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_USR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SEC_USR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SEC_USR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SEC_USR}"/> of entities</returns>
        internal override IEnumerable<SEC_USR> ApplyDeltaEntities(IEnumerable<SEC_USR> Entities, List<SEC_USR> DeltaEntities)
        {
            HashSet<int> Index_ROWID = new HashSet<int>(DeltaEntities.Select(i => i.ROWID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ROWID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ROWID.Remove(entity.ROWID);
                            
                            if (entity.ROWID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SEC_USR>> Index_ROWID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_USR FindByROWID(int ROWID)
        {
            return Index_ROWID.Value[ROWID];
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <param name="Value">Related SEC_USR entity</param>
        /// <returns>True if the related SEC_USR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROWID(int ROWID, out SEC_USR Value)
        {
            return Index_ROWID.Value.TryGetValue(ROWID, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_USR by ROWID field
        /// </summary>
        /// <param name="ROWID">ROWID value used to find SEC_USR</param>
        /// <returns>Related SEC_USR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_USR TryFindByROWID(int ROWID)
        {
            SEC_USR value;
            if (Index_ROWID.Value.TryGetValue(ROWID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SEC_USR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_USR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_USR](
        [ROWID] int IDENTITY NOT NULL,
        [SESSIONID] varchar(255) NULL,
        [USERID] varchar(50) NULL,
        [DATECREATED] datetime NULL,
        CONSTRAINT [SEC_USR_Index_ROWID] PRIMARY KEY CLUSTERED (
            [ROWID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SEC_USRDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SEC_USRDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SEC_USR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SEC_USR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SEC_USR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ROWID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ROWID.Add(entity.ROWID);
            }

            builder.AppendLine("DELETE [dbo].[SEC_USR] WHERE");


            // Index_ROWID
            builder.Append("[ROWID] IN (");
            for (int index = 0; index < Index_ROWID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ROWID
                var parameterROWID = $"@p{parameterIndex++}";
                builder.Append(parameterROWID);
                command.Parameters.Add(parameterROWID, SqlDbType.Int).Value = Index_ROWID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_USR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_USR data set</returns>
        public override EduHubDataSetDataReader<SEC_USR> GetDataSetDataReader()
        {
            return new SEC_USRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_USR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_USR data set</returns>
        public override EduHubDataSetDataReader<SEC_USR> GetDataSetDataReader(List<SEC_USR> Entities)
        {
            return new SEC_USRDataReader(new EduHubDataSetLoadedReader<SEC_USR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_USRDataReader : EduHubDataSetDataReader<SEC_USR>
        {
            public SEC_USRDataReader(IEduHubDataSetReader<SEC_USR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ROWID
                        return Current.ROWID;
                    case 1: // SESSIONID
                        return Current.SESSIONID;
                    case 2: // USERID
                        return Current.USERID;
                    case 3: // DATECREATED
                        return Current.DATECREATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SESSIONID
                        return Current.SESSIONID == null;
                    case 2: // USERID
                        return Current.USERID == null;
                    case 3: // DATECREATED
                        return Current.DATECREATED == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ROWID
                        return "ROWID";
                    case 1: // SESSIONID
                        return "SESSIONID";
                    case 2: // USERID
                        return "USERID";
                    case 3: // DATECREATED
                        return "DATECREATED";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ROWID":
                        return 0;
                    case "SESSIONID":
                        return 1;
                    case "USERID":
                        return 2;
                    case "DATECREATED":
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
