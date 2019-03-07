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
    /// eCASES21 Error Log Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SEC_ELOGDataSet : EduHubDataSet<SEC_ELOG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SEC_ELOG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SEC_ELOGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ERRORCOUNT = new Lazy<Dictionary<int, SEC_ELOG>>(() => this.ToDictionary(i => i.ERRORCOUNT));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SEC_ELOG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SEC_ELOG" /> fields for each CSV column header</returns>
        internal override Action<SEC_ELOG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SEC_ELOG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ERRORCOUNT":
                        mapper[i] = (e, v) => e.ERRORCOUNT = int.Parse(v);
                        break;
                    case "ERRORDESCRIPTION":
                        mapper[i] = (e, v) => e.ERRORDESCRIPTION = v;
                        break;
                    case "ERRORTYPE":
                        mapper[i] = (e, v) => e.ERRORTYPE = v;
                        break;
                    case "ERRORTIME":
                        mapper[i] = (e, v) => e.ERRORTIME = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SEC_ELOG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SEC_ELOG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SEC_ELOG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SEC_ELOG}"/> of entities</returns>
        internal override IEnumerable<SEC_ELOG> ApplyDeltaEntities(IEnumerable<SEC_ELOG> Entities, List<SEC_ELOG> DeltaEntities)
        {
            HashSet<int> Index_ERRORCOUNT = new HashSet<int>(DeltaEntities.Select(i => i.ERRORCOUNT));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ERRORCOUNT;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ERRORCOUNT.Remove(entity.ERRORCOUNT);
                            
                            if (entity.ERRORCOUNT.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SEC_ELOG>> Index_ERRORCOUNT;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <returns>Related SEC_ELOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_ELOG FindByERRORCOUNT(int ERRORCOUNT)
        {
            return Index_ERRORCOUNT.Value[ERRORCOUNT];
        }

        /// <summary>
        /// Attempt to find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <param name="Value">Related SEC_ELOG entity</param>
        /// <returns>True if the related SEC_ELOG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByERRORCOUNT(int ERRORCOUNT, out SEC_ELOG Value)
        {
            return Index_ERRORCOUNT.Value.TryGetValue(ERRORCOUNT, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_ELOG by ERRORCOUNT field
        /// </summary>
        /// <param name="ERRORCOUNT">ERRORCOUNT value used to find SEC_ELOG</param>
        /// <returns>Related SEC_ELOG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SEC_ELOG TryFindByERRORCOUNT(int ERRORCOUNT)
        {
            SEC_ELOG value;
            if (Index_ERRORCOUNT.Value.TryGetValue(ERRORCOUNT, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SEC_ELOG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SEC_ELOG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SEC_ELOG](
        [ERRORCOUNT] int IDENTITY NOT NULL,
        [ERRORDESCRIPTION] varchar(255) NULL,
        [ERRORTYPE] varchar(50) NULL,
        [ERRORTIME] datetime NULL,
        CONSTRAINT [SEC_ELOG_Index_ERRORCOUNT] PRIMARY KEY CLUSTERED (
            [ERRORCOUNT] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SEC_ELOGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SEC_ELOGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SEC_ELOG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SEC_ELOG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SEC_ELOG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ERRORCOUNT = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ERRORCOUNT.Add(entity.ERRORCOUNT);
            }

            builder.AppendLine("DELETE [dbo].[SEC_ELOG] WHERE");


            // Index_ERRORCOUNT
            builder.Append("[ERRORCOUNT] IN (");
            for (int index = 0; index < Index_ERRORCOUNT.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ERRORCOUNT
                var parameterERRORCOUNT = $"@p{parameterIndex++}";
                builder.Append(parameterERRORCOUNT);
                command.Parameters.Add(parameterERRORCOUNT, SqlDbType.Int).Value = Index_ERRORCOUNT[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_ELOG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_ELOG data set</returns>
        public override EduHubDataSetDataReader<SEC_ELOG> GetDataSetDataReader()
        {
            return new SEC_ELOGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SEC_ELOG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SEC_ELOG data set</returns>
        public override EduHubDataSetDataReader<SEC_ELOG> GetDataSetDataReader(List<SEC_ELOG> Entities)
        {
            return new SEC_ELOGDataReader(new EduHubDataSetLoadedReader<SEC_ELOG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SEC_ELOGDataReader : EduHubDataSetDataReader<SEC_ELOG>
        {
            public SEC_ELOGDataReader(IEduHubDataSetReader<SEC_ELOG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ERRORCOUNT
                        return Current.ERRORCOUNT;
                    case 1: // ERRORDESCRIPTION
                        return Current.ERRORDESCRIPTION;
                    case 2: // ERRORTYPE
                        return Current.ERRORTYPE;
                    case 3: // ERRORTIME
                        return Current.ERRORTIME;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ERRORDESCRIPTION
                        return Current.ERRORDESCRIPTION == null;
                    case 2: // ERRORTYPE
                        return Current.ERRORTYPE == null;
                    case 3: // ERRORTIME
                        return Current.ERRORTIME == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ERRORCOUNT
                        return "ERRORCOUNT";
                    case 1: // ERRORDESCRIPTION
                        return "ERRORDESCRIPTION";
                    case 2: // ERRORTYPE
                        return "ERRORTYPE";
                    case 3: // ERRORTIME
                        return "ERRORTIME";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ERRORCOUNT":
                        return 0;
                    case "ERRORDESCRIPTION":
                        return 1;
                    case "ERRORTYPE":
                        return 2;
                    case "ERRORTIME":
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
