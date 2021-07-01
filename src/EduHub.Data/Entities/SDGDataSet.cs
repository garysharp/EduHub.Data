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
    /// Sundry Debtor Fee Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDGDataSet : EduHubDataSet<SDG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SDG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SDGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SDGKEY = new Lazy<Dictionary<string, SDG>>(() => this.ToDictionary(i => i.SDGKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SDG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SDG" /> fields for each CSV column header</returns>
        internal override Action<SDG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SDG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SDGKEY":
                        mapper[i] = (e, v) => e.SDGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MEMBER_TYPE":
                        mapper[i] = (e, v) => e.MEMBER_TYPE = v;
                        break;
                    case "SDG_MEMO":
                        mapper[i] = (e, v) => e.SDG_MEMO = v;
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
        /// Merges <see cref="SDG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SDG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SDG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SDG}"/> of entities</returns>
        internal override IEnumerable<SDG> ApplyDeltaEntities(IEnumerable<SDG> Entities, List<SDG> DeltaEntities)
        {
            HashSet<string> Index_SDGKEY = new HashSet<string>(DeltaEntities.Select(i => i.SDGKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SDGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SDGKEY.Remove(entity.SDGKEY);
                            
                            if (entity.SDGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, SDG>> Index_SDGKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <returns>Related SDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDG FindBySDGKEY(string SDGKEY)
        {
            return Index_SDGKEY.Value[SDGKEY];
        }

        /// <summary>
        /// Attempt to find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <param name="Value">Related SDG entity</param>
        /// <returns>True if the related SDG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySDGKEY(string SDGKEY, out SDG Value)
        {
            return Index_SDGKEY.Value.TryGetValue(SDGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SDG by SDGKEY field
        /// </summary>
        /// <param name="SDGKEY">SDGKEY value used to find SDG</param>
        /// <returns>Related SDG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SDG TryFindBySDGKEY(string SDGKEY)
        {
            SDG value;
            if (Index_SDGKEY.Value.TryGetValue(SDGKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SDG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SDG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SDG](
        [SDGKEY] varchar(12) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [MEMBER_TYPE] varchar(1) NULL,
        [SDG_MEMO] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SDG_Index_SDGKEY] PRIMARY KEY CLUSTERED (
            [SDGKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SDGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SDGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SDG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SDG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SDG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SDGKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SDGKEY.Add(entity.SDGKEY);
            }

            builder.AppendLine("DELETE [dbo].[SDG] WHERE");


            // Index_SDGKEY
            builder.Append("[SDGKEY] IN (");
            for (int index = 0; index < Index_SDGKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SDGKEY
                var parameterSDGKEY = $"@p{parameterIndex++}";
                builder.Append(parameterSDGKEY);
                command.Parameters.Add(parameterSDGKEY, SqlDbType.VarChar, 12).Value = Index_SDGKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDG data set</returns>
        public override EduHubDataSetDataReader<SDG> GetDataSetDataReader()
        {
            return new SDGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SDG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SDG data set</returns>
        public override EduHubDataSetDataReader<SDG> GetDataSetDataReader(List<SDG> Entities)
        {
            return new SDGDataReader(new EduHubDataSetLoadedReader<SDG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SDGDataReader : EduHubDataSetDataReader<SDG>
        {
            public SDGDataReader(IEduHubDataSetReader<SDG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SDGKEY
                        return Current.SDGKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // MEMBER_TYPE
                        return Current.MEMBER_TYPE;
                    case 3: // SDG_MEMO
                        return Current.SDG_MEMO;
                    case 4: // LW_DATE
                        return Current.LW_DATE;
                    case 5: // LW_TIME
                        return Current.LW_TIME;
                    case 6: // LW_USER
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
                    case 2: // MEMBER_TYPE
                        return Current.MEMBER_TYPE == null;
                    case 3: // SDG_MEMO
                        return Current.SDG_MEMO == null;
                    case 4: // LW_DATE
                        return Current.LW_DATE == null;
                    case 5: // LW_TIME
                        return Current.LW_TIME == null;
                    case 6: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SDGKEY
                        return "SDGKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // MEMBER_TYPE
                        return "MEMBER_TYPE";
                    case 3: // SDG_MEMO
                        return "SDG_MEMO";
                    case 4: // LW_DATE
                        return "LW_DATE";
                    case 5: // LW_TIME
                        return "LW_TIME";
                    case 6: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SDGKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "MEMBER_TYPE":
                        return 2;
                    case "SDG_MEMO":
                        return 3;
                    case "LW_DATE":
                        return 4;
                    case "LW_TIME":
                        return 5;
                    case "LW_USER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
