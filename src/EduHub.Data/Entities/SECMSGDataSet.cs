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
    /// eCases Messages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SECMSGDataSet : EduHubDataSet<SECMSG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SECMSG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SECMSGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SECMSG>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SECMSG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SECMSG" /> fields for each CSV column header</returns>
        internal override Action<SECMSG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SECMSG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "LAST_EDITED":
                        mapper[i] = (e, v) => e.LAST_EDITED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATOR":
                        mapper[i] = (e, v) => e.CREATOR = v;
                        break;
                    case "EXPIRY":
                        mapper[i] = (e, v) => e.EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SECMSG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SECMSG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SECMSG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SECMSG}"/> of entities</returns>
        internal override IEnumerable<SECMSG> ApplyDeltaEntities(IEnumerable<SECMSG> Entities, List<SECMSG> DeltaEntities)
        {
            HashSet<int> Index_ID = new HashSet<int>(DeltaEntities.Select(i => i.ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ID.Remove(entity.ID);
                            
                            if (entity.ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SECMSG>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SECMSG by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SECMSG</param>
        /// <returns>Related SECMSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SECMSG FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SECMSG by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SECMSG</param>
        /// <param name="Value">Related SECMSG entity</param>
        /// <returns>True if the related SECMSG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SECMSG Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SECMSG by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SECMSG</param>
        /// <returns>Related SECMSG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SECMSG TryFindByID(int ID)
        {
            SECMSG value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SECMSG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SECMSG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SECMSG](
        [ID] int IDENTITY NOT NULL,
        [MESSAGE] varchar(180) NULL,
        [LAST_EDITED] datetime NULL,
        [CREATOR] varchar(128) NULL,
        [EXPIRY] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SECMSG_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SECMSGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SECMSGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SECMSG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SECMSG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SECMSG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SECMSG] WHERE");


            // Index_ID
            builder.Append("[ID] IN (");
            for (int index = 0; index < Index_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ID
                var parameterID = $"@p{parameterIndex++}";
                builder.Append(parameterID);
                command.Parameters.Add(parameterID, SqlDbType.Int).Value = Index_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SECMSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SECMSG data set</returns>
        public override EduHubDataSetDataReader<SECMSG> GetDataSetDataReader()
        {
            return new SECMSGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SECMSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SECMSG data set</returns>
        public override EduHubDataSetDataReader<SECMSG> GetDataSetDataReader(List<SECMSG> Entities)
        {
            return new SECMSGDataReader(new EduHubDataSetLoadedReader<SECMSG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SECMSGDataReader : EduHubDataSetDataReader<SECMSG>
        {
            public SECMSGDataReader(IEduHubDataSetReader<SECMSG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // MESSAGE
                        return Current.MESSAGE;
                    case 2: // LAST_EDITED
                        return Current.LAST_EDITED;
                    case 3: // CREATOR
                        return Current.CREATOR;
                    case 4: // EXPIRY
                        return Current.EXPIRY;
                    case 5: // LW_DATE
                        return Current.LW_DATE;
                    case 6: // LW_TIME
                        return Current.LW_TIME;
                    case 7: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // MESSAGE
                        return Current.MESSAGE == null;
                    case 2: // LAST_EDITED
                        return Current.LAST_EDITED == null;
                    case 3: // CREATOR
                        return Current.CREATOR == null;
                    case 4: // EXPIRY
                        return Current.EXPIRY == null;
                    case 5: // LW_DATE
                        return Current.LW_DATE == null;
                    case 6: // LW_TIME
                        return Current.LW_TIME == null;
                    case 7: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // MESSAGE
                        return "MESSAGE";
                    case 2: // LAST_EDITED
                        return "LAST_EDITED";
                    case 3: // CREATOR
                        return "CREATOR";
                    case 4: // EXPIRY
                        return "EXPIRY";
                    case 5: // LW_DATE
                        return "LW_DATE";
                    case 6: // LW_TIME
                        return "LW_TIME";
                    case 7: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "MESSAGE":
                        return 1;
                    case "LAST_EDITED":
                        return 2;
                    case "CREATOR":
                        return 3;
                    case "EXPIRY":
                        return 4;
                    case "LW_DATE":
                        return 5;
                    case "LW_TIME":
                        return 6;
                    case "LW_USER":
                        return 7;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
