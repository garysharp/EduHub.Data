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
    /// Holding Table for Reformatting phone numbers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPHDataSet : EduHubDataSet<KPH>
    {
        /// <inheritdoc />
        public override string Name { get { return "KPH"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KPHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPHKEY = new Lazy<Dictionary<int, KPH>>(() => this.ToDictionary(i => i.KPHKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPH" /> fields for each CSV column header</returns>
        internal override Action<KPH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPHKEY":
                        mapper[i] = (e, v) => e.KPHKEY = int.Parse(v);
                        break;
                    case "TABLE_NAME":
                        mapper[i] = (e, v) => e.TABLE_NAME = v;
                        break;
                    case "FIELD_NAME":
                        mapper[i] = (e, v) => e.FIELD_NAME = v;
                        break;
                    case "FIELD_TYPE":
                        mapper[i] = (e, v) => e.FIELD_TYPE = v;
                        break;
                    case "KEY_FIELD":
                        mapper[i] = (e, v) => e.KEY_FIELD = v;
                        break;
                    case "KEY_VALUE":
                        mapper[i] = (e, v) => e.KEY_VALUE = v;
                        break;
                    case "OLD_VALUE":
                        mapper[i] = (e, v) => e.OLD_VALUE = v;
                        break;
                    case "NEW_VALUE":
                        mapper[i] = (e, v) => e.NEW_VALUE = v;
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
        /// Merges <see cref="KPH" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KPH" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KPH" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KPH}"/> of entities</returns>
        internal override IEnumerable<KPH> ApplyDeltaEntities(IEnumerable<KPH> Entities, List<KPH> DeltaEntities)
        {
            HashSet<int> Index_KPHKEY = new HashSet<int>(DeltaEntities.Select(i => i.KPHKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KPHKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KPHKEY.Remove(entity.KPHKEY);
                            
                            if (entity.KPHKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KPH>> Index_KPHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPH by KPHKEY field
        /// </summary>
        /// <param name="KPHKEY">KPHKEY value used to find KPH</param>
        /// <returns>Related KPH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPH FindByKPHKEY(int KPHKEY)
        {
            return Index_KPHKEY.Value[KPHKEY];
        }

        /// <summary>
        /// Attempt to find KPH by KPHKEY field
        /// </summary>
        /// <param name="KPHKEY">KPHKEY value used to find KPH</param>
        /// <param name="Value">Related KPH entity</param>
        /// <returns>True if the related KPH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPHKEY(int KPHKEY, out KPH Value)
        {
            return Index_KPHKEY.Value.TryGetValue(KPHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPH by KPHKEY field
        /// </summary>
        /// <param name="KPHKEY">KPHKEY value used to find KPH</param>
        /// <returns>Related KPH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPH TryFindByKPHKEY(int KPHKEY)
        {
            KPH value;
            if (Index_KPHKEY.Value.TryGetValue(KPHKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KPH table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPH]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPH](
        [KPHKEY] int IDENTITY NOT NULL,
        [TABLE_NAME] varchar(15) NULL,
        [FIELD_NAME] varchar(50) NULL,
        [FIELD_TYPE] varchar(10) NULL,
        [KEY_FIELD] varchar(30) NULL,
        [KEY_VALUE] varchar(30) NULL,
        [OLD_VALUE] varchar(31) NULL,
        [NEW_VALUE] varchar(31) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPH_Index_KPHKEY] PRIMARY KEY CLUSTERED (
            [KPHKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KPHDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KPHDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KPH"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KPH"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KPH> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_KPHKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KPHKEY.Add(entity.KPHKEY);
            }

            builder.AppendLine("DELETE [dbo].[KPH] WHERE");


            // Index_KPHKEY
            builder.Append("[KPHKEY] IN (");
            for (int index = 0; index < Index_KPHKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KPHKEY
                var parameterKPHKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKPHKEY);
                command.Parameters.Add(parameterKPHKEY, SqlDbType.Int).Value = Index_KPHKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPH data set</returns>
        public override EduHubDataSetDataReader<KPH> GetDataSetDataReader()
        {
            return new KPHDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPH data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPH data set</returns>
        public override EduHubDataSetDataReader<KPH> GetDataSetDataReader(List<KPH> Entities)
        {
            return new KPHDataReader(new EduHubDataSetLoadedReader<KPH>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPHDataReader : EduHubDataSetDataReader<KPH>
        {
            public KPHDataReader(IEduHubDataSetReader<KPH> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KPHKEY
                        return Current.KPHKEY;
                    case 1: // TABLE_NAME
                        return Current.TABLE_NAME;
                    case 2: // FIELD_NAME
                        return Current.FIELD_NAME;
                    case 3: // FIELD_TYPE
                        return Current.FIELD_TYPE;
                    case 4: // KEY_FIELD
                        return Current.KEY_FIELD;
                    case 5: // KEY_VALUE
                        return Current.KEY_VALUE;
                    case 6: // OLD_VALUE
                        return Current.OLD_VALUE;
                    case 7: // NEW_VALUE
                        return Current.NEW_VALUE;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TABLE_NAME
                        return Current.TABLE_NAME == null;
                    case 2: // FIELD_NAME
                        return Current.FIELD_NAME == null;
                    case 3: // FIELD_TYPE
                        return Current.FIELD_TYPE == null;
                    case 4: // KEY_FIELD
                        return Current.KEY_FIELD == null;
                    case 5: // KEY_VALUE
                        return Current.KEY_VALUE == null;
                    case 6: // OLD_VALUE
                        return Current.OLD_VALUE == null;
                    case 7: // NEW_VALUE
                        return Current.NEW_VALUE == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
                    case 10: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KPHKEY
                        return "KPHKEY";
                    case 1: // TABLE_NAME
                        return "TABLE_NAME";
                    case 2: // FIELD_NAME
                        return "FIELD_NAME";
                    case 3: // FIELD_TYPE
                        return "FIELD_TYPE";
                    case 4: // KEY_FIELD
                        return "KEY_FIELD";
                    case 5: // KEY_VALUE
                        return "KEY_VALUE";
                    case 6: // OLD_VALUE
                        return "OLD_VALUE";
                    case 7: // NEW_VALUE
                        return "NEW_VALUE";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KPHKEY":
                        return 0;
                    case "TABLE_NAME":
                        return 1;
                    case "FIELD_NAME":
                        return 2;
                    case "FIELD_TYPE":
                        return 3;
                    case "KEY_FIELD":
                        return 4;
                    case "KEY_VALUE":
                        return 5;
                    case "OLD_VALUE":
                        return 6;
                    case "NEW_VALUE":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
