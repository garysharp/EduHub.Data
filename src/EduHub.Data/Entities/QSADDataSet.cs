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
    /// Audit Data Changes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class QSADDataSet : EduHubDataSet<QSAD>
    {
        /// <inheritdoc />
        public override string Name { get { return "QSAD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal QSADDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_QSADKEY = new Lazy<Dictionary<int, QSAD>>(() => this.ToDictionary(i => i.QSADKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="QSAD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="QSAD" /> fields for each CSV column header</returns>
        internal override Action<QSAD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<QSAD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "QSADKEY":
                        mapper[i] = (e, v) => e.QSADKEY = int.Parse(v);
                        break;
                    case "TABLE_NAME":
                        mapper[i] = (e, v) => e.TABLE_NAME = v;
                        break;
                    case "COLUMN_NAME":
                        mapper[i] = (e, v) => e.COLUMN_NAME = v;
                        break;
                    case "CHANGE_TYPE":
                        mapper[i] = (e, v) => e.CHANGE_TYPE = v;
                        break;
                    case "RECORD_KEY_VALUE":
                        mapper[i] = (e, v) => e.RECORD_KEY_VALUE = v;
                        break;
                    case "RECORD_DESCRIPTION":
                        mapper[i] = (e, v) => e.RECORD_DESCRIPTION = v;
                        break;
                    case "BEFORE_VALUE":
                        mapper[i] = (e, v) => e.BEFORE_VALUE = v;
                        break;
                    case "AFTER_VALUE":
                        mapper[i] = (e, v) => e.AFTER_VALUE = v;
                        break;
                    case "USER_NAME":
                        mapper[i] = (e, v) => e.USER_NAME = v;
                        break;
                    case "CHANGE_TIMESTAMP":
                        mapper[i] = (e, v) => e.CHANGE_TIMESTAMP = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="QSAD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="QSAD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="QSAD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{QSAD}"/> of entities</returns>
        internal override IEnumerable<QSAD> ApplyDeltaEntities(IEnumerable<QSAD> Entities, List<QSAD> DeltaEntities)
        {
            HashSet<int> Index_QSADKEY = new HashSet<int>(DeltaEntities.Select(i => i.QSADKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.QSADKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_QSADKEY.Remove(entity.QSADKEY);
                            
                            if (entity.QSADKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, QSAD>> Index_QSADKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find QSAD by QSADKEY field
        /// </summary>
        /// <param name="QSADKEY">QSADKEY value used to find QSAD</param>
        /// <returns>Related QSAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAD FindByQSADKEY(int QSADKEY)
        {
            return Index_QSADKEY.Value[QSADKEY];
        }

        /// <summary>
        /// Attempt to find QSAD by QSADKEY field
        /// </summary>
        /// <param name="QSADKEY">QSADKEY value used to find QSAD</param>
        /// <param name="Value">Related QSAD entity</param>
        /// <returns>True if the related QSAD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByQSADKEY(int QSADKEY, out QSAD Value)
        {
            return Index_QSADKEY.Value.TryGetValue(QSADKEY, out Value);
        }

        /// <summary>
        /// Attempt to find QSAD by QSADKEY field
        /// </summary>
        /// <param name="QSADKEY">QSADKEY value used to find QSAD</param>
        /// <returns>Related QSAD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public QSAD TryFindByQSADKEY(int QSADKEY)
        {
            QSAD value;
            if (Index_QSADKEY.Value.TryGetValue(QSADKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a QSAD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[QSAD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[QSAD](
        [QSADKEY] int IDENTITY NOT NULL,
        [TABLE_NAME] varchar(10) NULL,
        [COLUMN_NAME] varchar(32) NULL,
        [CHANGE_TYPE] varchar(1) NULL,
        [RECORD_KEY_VALUE] varchar(20) NULL,
        [RECORD_DESCRIPTION] varchar(60) NULL,
        [BEFORE_VALUE] varchar(255) NULL,
        [AFTER_VALUE] varchar(255) NULL,
        [USER_NAME] varchar(128) NULL,
        [CHANGE_TIMESTAMP] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [QSAD_Index_QSADKEY] PRIMARY KEY CLUSTERED (
            [QSADKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="QSADDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="QSADDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="QSAD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="QSAD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<QSAD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_QSADKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_QSADKEY.Add(entity.QSADKEY);
            }

            builder.AppendLine("DELETE [dbo].[QSAD] WHERE");


            // Index_QSADKEY
            builder.Append("[QSADKEY] IN (");
            for (int index = 0; index < Index_QSADKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // QSADKEY
                var parameterQSADKEY = $"@p{parameterIndex++}";
                builder.Append(parameterQSADKEY);
                command.Parameters.Add(parameterQSADKEY, SqlDbType.Int).Value = Index_QSADKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QSAD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QSAD data set</returns>
        public override EduHubDataSetDataReader<QSAD> GetDataSetDataReader()
        {
            return new QSADDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the QSAD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the QSAD data set</returns>
        public override EduHubDataSetDataReader<QSAD> GetDataSetDataReader(List<QSAD> Entities)
        {
            return new QSADDataReader(new EduHubDataSetLoadedReader<QSAD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class QSADDataReader : EduHubDataSetDataReader<QSAD>
        {
            public QSADDataReader(IEduHubDataSetReader<QSAD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // QSADKEY
                        return Current.QSADKEY;
                    case 1: // TABLE_NAME
                        return Current.TABLE_NAME;
                    case 2: // COLUMN_NAME
                        return Current.COLUMN_NAME;
                    case 3: // CHANGE_TYPE
                        return Current.CHANGE_TYPE;
                    case 4: // RECORD_KEY_VALUE
                        return Current.RECORD_KEY_VALUE;
                    case 5: // RECORD_DESCRIPTION
                        return Current.RECORD_DESCRIPTION;
                    case 6: // BEFORE_VALUE
                        return Current.BEFORE_VALUE;
                    case 7: // AFTER_VALUE
                        return Current.AFTER_VALUE;
                    case 8: // USER_NAME
                        return Current.USER_NAME;
                    case 9: // CHANGE_TIMESTAMP
                        return Current.CHANGE_TIMESTAMP;
                    case 10: // LW_DATE
                        return Current.LW_DATE;
                    case 11: // LW_TIME
                        return Current.LW_TIME;
                    case 12: // LW_USER
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
                    case 2: // COLUMN_NAME
                        return Current.COLUMN_NAME == null;
                    case 3: // CHANGE_TYPE
                        return Current.CHANGE_TYPE == null;
                    case 4: // RECORD_KEY_VALUE
                        return Current.RECORD_KEY_VALUE == null;
                    case 5: // RECORD_DESCRIPTION
                        return Current.RECORD_DESCRIPTION == null;
                    case 6: // BEFORE_VALUE
                        return Current.BEFORE_VALUE == null;
                    case 7: // AFTER_VALUE
                        return Current.AFTER_VALUE == null;
                    case 8: // USER_NAME
                        return Current.USER_NAME == null;
                    case 9: // CHANGE_TIMESTAMP
                        return Current.CHANGE_TIMESTAMP == null;
                    case 10: // LW_DATE
                        return Current.LW_DATE == null;
                    case 11: // LW_TIME
                        return Current.LW_TIME == null;
                    case 12: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // QSADKEY
                        return "QSADKEY";
                    case 1: // TABLE_NAME
                        return "TABLE_NAME";
                    case 2: // COLUMN_NAME
                        return "COLUMN_NAME";
                    case 3: // CHANGE_TYPE
                        return "CHANGE_TYPE";
                    case 4: // RECORD_KEY_VALUE
                        return "RECORD_KEY_VALUE";
                    case 5: // RECORD_DESCRIPTION
                        return "RECORD_DESCRIPTION";
                    case 6: // BEFORE_VALUE
                        return "BEFORE_VALUE";
                    case 7: // AFTER_VALUE
                        return "AFTER_VALUE";
                    case 8: // USER_NAME
                        return "USER_NAME";
                    case 9: // CHANGE_TIMESTAMP
                        return "CHANGE_TIMESTAMP";
                    case 10: // LW_DATE
                        return "LW_DATE";
                    case 11: // LW_TIME
                        return "LW_TIME";
                    case 12: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "QSADKEY":
                        return 0;
                    case "TABLE_NAME":
                        return 1;
                    case "COLUMN_NAME":
                        return 2;
                    case "CHANGE_TYPE":
                        return 3;
                    case "RECORD_KEY_VALUE":
                        return 4;
                    case "RECORD_DESCRIPTION":
                        return 5;
                    case "BEFORE_VALUE":
                        return 6;
                    case "AFTER_VALUE":
                        return 7;
                    case "USER_NAME":
                        return 8;
                    case "CHANGE_TIMESTAMP":
                        return 9;
                    case "LW_DATE":
                        return 10;
                    case "LW_TIME":
                        return 11;
                    case "LW_USER":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
