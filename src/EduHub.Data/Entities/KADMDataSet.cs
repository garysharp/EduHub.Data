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
    /// Asset Depreciation Methods Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KADMDataSet : EduHubDataSet<KADM>
    {
        /// <inheritdoc />
        public override string Name { get { return "KADM"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KADMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KADMKEY = new Lazy<Dictionary<string, KADM>>(() => this.ToDictionary(i => i.KADMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KADM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KADM" /> fields for each CSV column header</returns>
        internal override Action<KADM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KADM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADMKEY":
                        mapper[i] = (e, v) => e.KADMKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "DATE_BASED":
                        mapper[i] = (e, v) => e.DATE_BASED = v;
                        break;
                    case "TAX":
                        mapper[i] = (e, v) => e.TAX = v;
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
        /// Merges <see cref="KADM" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KADM" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KADM" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KADM}"/> of entities</returns>
        internal override IEnumerable<KADM> ApplyDeltaEntities(IEnumerable<KADM> Entities, List<KADM> DeltaEntities)
        {
            HashSet<string> Index_KADMKEY = new HashSet<string>(DeltaEntities.Select(i => i.KADMKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KADMKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KADMKEY.Remove(entity.KADMKEY);
                            
                            if (entity.KADMKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KADM>> Index_KADMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KADM FindByKADMKEY(string KADMKEY)
        {
            return Index_KADMKEY.Value[KADMKEY];
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <param name="Value">Related KADM entity</param>
        /// <returns>True if the related KADM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKADMKEY(string KADMKEY, out KADM Value)
        {
            return Index_KADMKEY.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY field
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KADM TryFindByKADMKEY(string KADMKEY)
        {
            KADM value;
            if (Index_KADMKEY.Value.TryGetValue(KADMKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KADM table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KADM]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KADM](
        [KADMKEY] varchar(1) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [DETAIL] text NULL,
        [DATE_BASED] varchar(1) NULL,
        [TAX] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KADM_Index_KADMKEY] PRIMARY KEY CLUSTERED (
            [KADMKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KADMDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KADMDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KADM"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KADM"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KADM> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KADMKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KADMKEY.Add(entity.KADMKEY);
            }

            builder.AppendLine("DELETE [dbo].[KADM] WHERE");


            // Index_KADMKEY
            builder.Append("[KADMKEY] IN (");
            for (int index = 0; index < Index_KADMKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KADMKEY
                var parameterKADMKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKADMKEY);
                command.Parameters.Add(parameterKADMKEY, SqlDbType.VarChar, 1).Value = Index_KADMKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KADM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KADM data set</returns>
        public override EduHubDataSetDataReader<KADM> GetDataSetDataReader()
        {
            return new KADMDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KADM data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KADM data set</returns>
        public override EduHubDataSetDataReader<KADM> GetDataSetDataReader(List<KADM> Entities)
        {
            return new KADMDataReader(new EduHubDataSetLoadedReader<KADM>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KADMDataReader : EduHubDataSetDataReader<KADM>
        {
            public KADMDataReader(IEduHubDataSetReader<KADM> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KADMKEY
                        return Current.KADMKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // DETAIL
                        return Current.DETAIL;
                    case 3: // DATE_BASED
                        return Current.DATE_BASED;
                    case 4: // TAX
                        return Current.TAX;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // DETAIL
                        return Current.DETAIL == null;
                    case 3: // DATE_BASED
                        return Current.DATE_BASED == null;
                    case 4: // TAX
                        return Current.TAX == null;
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
                    case 0: // KADMKEY
                        return "KADMKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // DETAIL
                        return "DETAIL";
                    case 3: // DATE_BASED
                        return "DATE_BASED";
                    case 4: // TAX
                        return "TAX";
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
                    case "KADMKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "DETAIL":
                        return 2;
                    case "DATE_BASED":
                        return 3;
                    case "TAX":
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
