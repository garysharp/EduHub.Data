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
    /// Asset Release Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKRDataSet : EduHubDataSet<AKR>
    {
        /// <inheritdoc />
        public override string Name { get { return "AKR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal AKRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AKRKEY = new Lazy<Dictionary<string, AKR>>(() => this.ToDictionary(i => i.AKRKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKR" /> fields for each CSV column header</returns>
        internal override Action<AKR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKRKEY":
                        mapper[i] = (e, v) => e.AKRKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="AKR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AKR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AKR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AKR}"/> of entities</returns>
        internal override IEnumerable<AKR> ApplyDeltaEntities(IEnumerable<AKR> Entities, List<AKR> DeltaEntities)
        {
            HashSet<string> Index_AKRKEY = new HashSet<string>(DeltaEntities.Select(i => i.AKRKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.AKRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_AKRKEY.Remove(entity.AKRKEY);
                            
                            if (entity.AKRKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, AKR>> Index_AKRKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKR FindByAKRKEY(string AKRKEY)
        {
            return Index_AKRKEY.Value[AKRKEY];
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <param name="Value">Related AKR entity</param>
        /// <returns>True if the related AKR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAKRKEY(string AKRKEY, out AKR Value)
        {
            return Index_AKRKEY.Value.TryGetValue(AKRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKR TryFindByAKRKEY(string AKRKEY)
        {
            AKR value;
            if (Index_AKRKEY.Value.TryGetValue(AKRKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AKR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKR](
        [AKRKEY] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(40) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKR_Index_AKRKEY] PRIMARY KEY CLUSTERED (
            [AKRKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="AKRDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="AKRDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AKR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AKR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AKR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_AKRKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_AKRKEY.Add(entity.AKRKEY);
            }

            builder.AppendLine("DELETE [dbo].[AKR] WHERE");


            // Index_AKRKEY
            builder.Append("[AKRKEY] IN (");
            for (int index = 0; index < Index_AKRKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // AKRKEY
                var parameterAKRKEY = $"@p{parameterIndex++}";
                builder.Append(parameterAKRKEY);
                command.Parameters.Add(parameterAKRKEY, SqlDbType.VarChar, 2).Value = Index_AKRKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKR data set</returns>
        public override EduHubDataSetDataReader<AKR> GetDataSetDataReader()
        {
            return new AKRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKR data set</returns>
        public override EduHubDataSetDataReader<AKR> GetDataSetDataReader(List<AKR> Entities)
        {
            return new AKRDataReader(new EduHubDataSetLoadedReader<AKR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKRDataReader : EduHubDataSetDataReader<AKR>
        {
            public AKRDataReader(IEduHubDataSetReader<AKR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // AKRKEY
                        return Current.AKRKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // LW_DATE
                        return Current.LW_DATE;
                    case 3: // LW_TIME
                        return Current.LW_TIME;
                    case 4: // LW_USER
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
                    case 2: // LW_DATE
                        return Current.LW_DATE == null;
                    case 3: // LW_TIME
                        return Current.LW_TIME == null;
                    case 4: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // AKRKEY
                        return "AKRKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "AKRKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
