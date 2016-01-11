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
    /// Absence Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCTDataSet : EduHubDataSet<KCT>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCTKEY = new Lazy<Dictionary<short, KCT>>(() => this.ToDictionary(i => i.KCTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCT" /> fields for each CSV column header</returns>
        internal override Action<KCT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCTKEY":
                        mapper[i] = (e, v) => e.KCTKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABBREV_DESC":
                        mapper[i] = (e, v) => e.ABBREV_DESC = v;
                        break;
                    case "CURRICULUM":
                        mapper[i] = (e, v) => e.CURRICULUM = v;
                        break;
                    case "DOE_TYPE":
                        mapper[i] = (e, v) => e.DOE_TYPE = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "PRE_APPROVED":
                        mapper[i] = (e, v) => e.PRE_APPROVED = v;
                        break;
                    case "ABS_RATE":
                        mapper[i] = (e, v) => e.ABS_RATE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SMS":
                        mapper[i] = (e, v) => e.SMS = v;
                        break;
                    case "SMS_MESSAGE":
                        mapper[i] = (e, v) => e.SMS_MESSAGE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
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
        /// Merges <see cref="KCT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCT}"/> of entities</returns>
        internal override IEnumerable<KCT> ApplyDeltaEntities(IEnumerable<KCT> Entities, List<KCT> DeltaEntities)
        {
            HashSet<short> Index_KCTKEY = new HashSet<short>(DeltaEntities.Select(i => i.KCTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KCTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KCTKEY.Remove(entity.KCTKEY);
                            
                            if (entity.KCTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<short, KCT>> Index_KCTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCT FindByKCTKEY(short KCTKEY)
        {
            return Index_KCTKEY.Value[KCTKEY];
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <param name="Value">Related KCT entity</param>
        /// <returns>True if the related KCT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCTKEY(short KCTKEY, out KCT Value)
        {
            return Index_KCTKEY.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCT TryFindByKCTKEY(short KCTKEY)
        {
            KCT value;
            if (Index_KCTKEY.Value.TryGetValue(KCTKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCT](
        [KCTKEY] smallint NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [ABBREV_DESC] varchar(8) NULL,
        [CURRICULUM] varchar(1) NULL,
        [DOE_TYPE] varchar(1) NULL,
        [ENABLED] varchar(1) NULL,
        [PRE_APPROVED] varchar(1) NULL,
        [ABS_RATE] smallint NULL,
        [SMS] varchar(1) NULL,
        [SMS_MESSAGE] varchar(160) NULL,
        [EMAIL] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCT_Index_KCTKEY] PRIMARY KEY CLUSTERED (
            [KCTKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KCTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KCTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short> Index_KCTKEY = new List<short>();

            foreach (var entity in Entities)
            {
                Index_KCTKEY.Add(entity.KCTKEY);
            }

            builder.AppendLine("DELETE [dbo].[KCT] WHERE");


            // Index_KCTKEY
            builder.Append("[KCTKEY] IN (");
            for (int index = 0; index < Index_KCTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KCTKEY
                var parameterKCTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKCTKEY);
                command.Parameters.Add(parameterKCTKEY, SqlDbType.SmallInt).Value = Index_KCTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCT data set</returns>
        public override EduHubDataSetDataReader<KCT> GetDataSetDataReader()
        {
            return new KCTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCT data set</returns>
        public override EduHubDataSetDataReader<KCT> GetDataSetDataReader(List<KCT> Entities)
        {
            return new KCTDataReader(new EduHubDataSetLoadedReader<KCT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCTDataReader : EduHubDataSetDataReader<KCT>
        {
            public KCTDataReader(IEduHubDataSetReader<KCT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 14; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KCTKEY
                        return Current.KCTKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // ABBREV_DESC
                        return Current.ABBREV_DESC;
                    case 3: // CURRICULUM
                        return Current.CURRICULUM;
                    case 4: // DOE_TYPE
                        return Current.DOE_TYPE;
                    case 5: // ENABLED
                        return Current.ENABLED;
                    case 6: // PRE_APPROVED
                        return Current.PRE_APPROVED;
                    case 7: // ABS_RATE
                        return Current.ABS_RATE;
                    case 8: // SMS
                        return Current.SMS;
                    case 9: // SMS_MESSAGE
                        return Current.SMS_MESSAGE;
                    case 10: // EMAIL
                        return Current.EMAIL;
                    case 11: // LW_DATE
                        return Current.LW_DATE;
                    case 12: // LW_TIME
                        return Current.LW_TIME;
                    case 13: // LW_USER
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
                    case 2: // ABBREV_DESC
                        return Current.ABBREV_DESC == null;
                    case 3: // CURRICULUM
                        return Current.CURRICULUM == null;
                    case 4: // DOE_TYPE
                        return Current.DOE_TYPE == null;
                    case 5: // ENABLED
                        return Current.ENABLED == null;
                    case 6: // PRE_APPROVED
                        return Current.PRE_APPROVED == null;
                    case 7: // ABS_RATE
                        return Current.ABS_RATE == null;
                    case 8: // SMS
                        return Current.SMS == null;
                    case 9: // SMS_MESSAGE
                        return Current.SMS_MESSAGE == null;
                    case 10: // EMAIL
                        return Current.EMAIL == null;
                    case 11: // LW_DATE
                        return Current.LW_DATE == null;
                    case 12: // LW_TIME
                        return Current.LW_TIME == null;
                    case 13: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCTKEY
                        return "KCTKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // ABBREV_DESC
                        return "ABBREV_DESC";
                    case 3: // CURRICULUM
                        return "CURRICULUM";
                    case 4: // DOE_TYPE
                        return "DOE_TYPE";
                    case 5: // ENABLED
                        return "ENABLED";
                    case 6: // PRE_APPROVED
                        return "PRE_APPROVED";
                    case 7: // ABS_RATE
                        return "ABS_RATE";
                    case 8: // SMS
                        return "SMS";
                    case 9: // SMS_MESSAGE
                        return "SMS_MESSAGE";
                    case 10: // EMAIL
                        return "EMAIL";
                    case 11: // LW_DATE
                        return "LW_DATE";
                    case 12: // LW_TIME
                        return "LW_TIME";
                    case 13: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCTKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "ABBREV_DESC":
                        return 2;
                    case "CURRICULUM":
                        return 3;
                    case "DOE_TYPE":
                        return 4;
                    case "ENABLED":
                        return 5;
                    case "PRE_APPROVED":
                        return 6;
                    case "ABS_RATE":
                        return 7;
                    case "SMS":
                        return 8;
                    case "SMS_MESSAGE":
                        return 9;
                    case "EMAIL":
                        return 10;
                    case "LW_DATE":
                        return 11;
                    case "LW_TIME":
                        return 12;
                    case "LW_USER":
                        return 13;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
