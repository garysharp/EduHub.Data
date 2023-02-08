#if !EduHubScoped
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
    /// CASES21 MESSAGES Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KMSGDataSet : EduHubDataSet<KMSG>
    {
        /// <inheritdoc />
        public override string Name { get { return "KMSG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KMSGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KMSGKEY = new Lazy<Dictionary<int, KMSG>>(() => this.ToDictionary(i => i.KMSGKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KMSG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KMSG" /> fields for each CSV column header</returns>
        internal override Action<KMSG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KMSG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KMSGKEY":
                        mapper[i] = (e, v) => e.KMSGKEY = int.Parse(v);
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "EXPIRY":
                        mapper[i] = (e, v) => e.EXPIRY = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="KMSG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KMSG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KMSG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KMSG}"/> of entities</returns>
        internal override IEnumerable<KMSG> ApplyDeltaEntities(IEnumerable<KMSG> Entities, List<KMSG> DeltaEntities)
        {
            HashSet<int> Index_KMSGKEY = new HashSet<int>(DeltaEntities.Select(i => i.KMSGKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KMSGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KMSGKEY.Remove(entity.KMSGKEY);
                            
                            if (entity.KMSGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KMSG>> Index_KMSGKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KMSG by KMSGKEY field
        /// </summary>
        /// <param name="KMSGKEY">KMSGKEY value used to find KMSG</param>
        /// <returns>Related KMSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KMSG FindByKMSGKEY(int KMSGKEY)
        {
            return Index_KMSGKEY.Value[KMSGKEY];
        }

        /// <summary>
        /// Attempt to find KMSG by KMSGKEY field
        /// </summary>
        /// <param name="KMSGKEY">KMSGKEY value used to find KMSG</param>
        /// <param name="Value">Related KMSG entity</param>
        /// <returns>True if the related KMSG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKMSGKEY(int KMSGKEY, out KMSG Value)
        {
            return Index_KMSGKEY.Value.TryGetValue(KMSGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KMSG by KMSGKEY field
        /// </summary>
        /// <param name="KMSGKEY">KMSGKEY value used to find KMSG</param>
        /// <returns>Related KMSG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KMSG TryFindByKMSGKEY(int KMSGKEY)
        {
            KMSG value;
            if (Index_KMSGKEY.Value.TryGetValue(KMSGKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KMSG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KMSG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KMSG](
        [KMSGKEY] int IDENTITY NOT NULL,
        [SEND_DATE] datetime NULL,
        [SUBJECT] varchar(100) NULL,
        [MESSAGE] varchar(MAX) NULL,
        [EXPIRY] datetime NULL,
        [FREQUENCY] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KMSG_Index_KMSGKEY] PRIMARY KEY CLUSTERED (
            [KMSGKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KMSGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KMSGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KMSG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KMSG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KMSG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_KMSGKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KMSGKEY.Add(entity.KMSGKEY);
            }

            builder.AppendLine("DELETE [dbo].[KMSG] WHERE");


            // Index_KMSGKEY
            builder.Append("[KMSGKEY] IN (");
            for (int index = 0; index < Index_KMSGKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KMSGKEY
                var parameterKMSGKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKMSGKEY);
                command.Parameters.Add(parameterKMSGKEY, SqlDbType.Int).Value = Index_KMSGKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KMSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KMSG data set</returns>
        public override EduHubDataSetDataReader<KMSG> GetDataSetDataReader()
        {
            return new KMSGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KMSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KMSG data set</returns>
        public override EduHubDataSetDataReader<KMSG> GetDataSetDataReader(List<KMSG> Entities)
        {
            return new KMSGDataReader(new EduHubDataSetLoadedReader<KMSG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KMSGDataReader : EduHubDataSetDataReader<KMSG>
        {
            public KMSGDataReader(IEduHubDataSetReader<KMSG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KMSGKEY
                        return Current.KMSGKEY;
                    case 1: // SEND_DATE
                        return Current.SEND_DATE;
                    case 2: // SUBJECT
                        return Current.SUBJECT;
                    case 3: // MESSAGE
                        return Current.MESSAGE;
                    case 4: // EXPIRY
                        return Current.EXPIRY;
                    case 5: // FREQUENCY
                        return Current.FREQUENCY;
                    case 6: // LW_DATE
                        return Current.LW_DATE;
                    case 7: // LW_TIME
                        return Current.LW_TIME;
                    case 8: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SEND_DATE
                        return Current.SEND_DATE == null;
                    case 2: // SUBJECT
                        return Current.SUBJECT == null;
                    case 3: // MESSAGE
                        return Current.MESSAGE == null;
                    case 4: // EXPIRY
                        return Current.EXPIRY == null;
                    case 5: // FREQUENCY
                        return Current.FREQUENCY == null;
                    case 6: // LW_DATE
                        return Current.LW_DATE == null;
                    case 7: // LW_TIME
                        return Current.LW_TIME == null;
                    case 8: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KMSGKEY
                        return "KMSGKEY";
                    case 1: // SEND_DATE
                        return "SEND_DATE";
                    case 2: // SUBJECT
                        return "SUBJECT";
                    case 3: // MESSAGE
                        return "MESSAGE";
                    case 4: // EXPIRY
                        return "EXPIRY";
                    case 5: // FREQUENCY
                        return "FREQUENCY";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KMSGKEY":
                        return 0;
                    case "SEND_DATE":
                        return 1;
                    case "SUBJECT":
                        return 2;
                    case "MESSAGE":
                        return 3;
                    case "EXPIRY":
                        return 4;
                    case "FREQUENCY":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
