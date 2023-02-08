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
    /// Holding Table for Incorrect Schools Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KSKGSDataSet : EduHubDataSet<KSKGS>
    {
        /// <inheritdoc />
        public override string Name { get { return "KSKGS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KSKGSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KSKGSKEY = new Lazy<Dictionary<int, KSKGS>>(() => this.ToDictionary(i => i.KSKGSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSKGS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSKGS" /> fields for each CSV column header</returns>
        internal override Action<KSKGS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSKGS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSKGSKEY":
                        mapper[i] = (e, v) => e.KSKGSKEY = int.Parse(v);
                        break;
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "TABLE_NAME":
                        mapper[i] = (e, v) => e.TABLE_NAME = v;
                        break;
                    case "FIELD_NAME":
                        mapper[i] = (e, v) => e.FIELD_NAME = v;
                        break;
                    case "RECORD_KEY":
                        mapper[i] = (e, v) => e.RECORD_KEY = v;
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
        /// Merges <see cref="KSKGS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KSKGS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KSKGS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KSKGS}"/> of entities</returns>
        internal override IEnumerable<KSKGS> ApplyDeltaEntities(IEnumerable<KSKGS> Entities, List<KSKGS> DeltaEntities)
        {
            HashSet<int> Index_KSKGSKEY = new HashSet<int>(DeltaEntities.Select(i => i.KSKGSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KSKGSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KSKGSKEY.Remove(entity.KSKGSKEY);
                            
                            if (entity.KSKGSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KSKGS>> Index_KSKGSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KSKGS by KSKGSKEY field
        /// </summary>
        /// <param name="KSKGSKEY">KSKGSKEY value used to find KSKGS</param>
        /// <returns>Related KSKGS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSKGS FindByKSKGSKEY(int KSKGSKEY)
        {
            return Index_KSKGSKEY.Value[KSKGSKEY];
        }

        /// <summary>
        /// Attempt to find KSKGS by KSKGSKEY field
        /// </summary>
        /// <param name="KSKGSKEY">KSKGSKEY value used to find KSKGS</param>
        /// <param name="Value">Related KSKGS entity</param>
        /// <returns>True if the related KSKGS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKSKGSKEY(int KSKGSKEY, out KSKGS Value)
        {
            return Index_KSKGSKEY.Value.TryGetValue(KSKGSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KSKGS by KSKGSKEY field
        /// </summary>
        /// <param name="KSKGSKEY">KSKGSKEY value used to find KSKGS</param>
        /// <returns>Related KSKGS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KSKGS TryFindByKSKGSKEY(int KSKGSKEY)
        {
            KSKGS value;
            if (Index_KSKGSKEY.Value.TryGetValue(KSKGSKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KSKGS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KSKGS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KSKGS](
        [KSKGSKEY] int IDENTITY NOT NULL,
        [SCHOOL] varchar(8) NULL,
        [NAME] varchar(40) NULL,
        [TABLE_NAME] varchar(10) NULL,
        [FIELD_NAME] varchar(30) NULL,
        [RECORD_KEY] varchar(20) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KSKGS_Index_KSKGSKEY] PRIMARY KEY CLUSTERED (
            [KSKGSKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KSKGSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KSKGSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KSKGS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KSKGS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KSKGS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_KSKGSKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KSKGSKEY.Add(entity.KSKGSKEY);
            }

            builder.AppendLine("DELETE [dbo].[KSKGS] WHERE");


            // Index_KSKGSKEY
            builder.Append("[KSKGSKEY] IN (");
            for (int index = 0; index < Index_KSKGSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KSKGSKEY
                var parameterKSKGSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKSKGSKEY);
                command.Parameters.Add(parameterKSKGSKEY, SqlDbType.Int).Value = Index_KSKGSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSKGS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSKGS data set</returns>
        public override EduHubDataSetDataReader<KSKGS> GetDataSetDataReader()
        {
            return new KSKGSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KSKGS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KSKGS data set</returns>
        public override EduHubDataSetDataReader<KSKGS> GetDataSetDataReader(List<KSKGS> Entities)
        {
            return new KSKGSDataReader(new EduHubDataSetLoadedReader<KSKGS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KSKGSDataReader : EduHubDataSetDataReader<KSKGS>
        {
            public KSKGSDataReader(IEduHubDataSetReader<KSKGS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KSKGSKEY
                        return Current.KSKGSKEY;
                    case 1: // SCHOOL
                        return Current.SCHOOL;
                    case 2: // NAME
                        return Current.NAME;
                    case 3: // TABLE_NAME
                        return Current.TABLE_NAME;
                    case 4: // FIELD_NAME
                        return Current.FIELD_NAME;
                    case 5: // RECORD_KEY
                        return Current.RECORD_KEY;
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
                    case 1: // SCHOOL
                        return Current.SCHOOL == null;
                    case 2: // NAME
                        return Current.NAME == null;
                    case 3: // TABLE_NAME
                        return Current.TABLE_NAME == null;
                    case 4: // FIELD_NAME
                        return Current.FIELD_NAME == null;
                    case 5: // RECORD_KEY
                        return Current.RECORD_KEY == null;
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
                    case 0: // KSKGSKEY
                        return "KSKGSKEY";
                    case 1: // SCHOOL
                        return "SCHOOL";
                    case 2: // NAME
                        return "NAME";
                    case 3: // TABLE_NAME
                        return "TABLE_NAME";
                    case 4: // FIELD_NAME
                        return "FIELD_NAME";
                    case 5: // RECORD_KEY
                        return "RECORD_KEY";
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
                    case "KSKGSKEY":
                        return 0;
                    case "SCHOOL":
                        return 1;
                    case "NAME":
                        return 2;
                    case "TABLE_NAME":
                        return 3;
                    case "FIELD_NAME":
                        return 4;
                    case "RECORD_KEY":
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
