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
    /// Asset Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKTDataSet : EduHubDataSet<AKT>
    {
        /// <inheritdoc />
        public override string Name { get { return "AKT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal AKTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AKTKEY = new Lazy<Dictionary<string, AKT>>(() => this.ToDictionary(i => i.AKTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKT" /> fields for each CSV column header</returns>
        internal override Action<AKT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKTKEY":
                        mapper[i] = (e, v) => e.AKTKEY = v;
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
        /// Merges <see cref="AKT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AKT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AKT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AKT}"/> of entities</returns>
        internal override IEnumerable<AKT> ApplyDeltaEntities(IEnumerable<AKT> Entities, List<AKT> DeltaEntities)
        {
            HashSet<string> Index_AKTKEY = new HashSet<string>(DeltaEntities.Select(i => i.AKTKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.AKTKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_AKTKEY.Remove(entity.AKTKEY);
                            
                            if (entity.AKTKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, AKT>> Index_AKTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <returns>Related AKT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKT FindByAKTKEY(string AKTKEY)
        {
            return Index_AKTKEY.Value[AKTKEY];
        }

        /// <summary>
        /// Attempt to find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <param name="Value">Related AKT entity</param>
        /// <returns>True if the related AKT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAKTKEY(string AKTKEY, out AKT Value)
        {
            return Index_AKTKEY.Value.TryGetValue(AKTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find AKT by AKTKEY field
        /// </summary>
        /// <param name="AKTKEY">AKTKEY value used to find AKT</param>
        /// <returns>Related AKT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKT TryFindByAKTKEY(string AKTKEY)
        {
            AKT value;
            if (Index_AKTKEY.Value.TryGetValue(AKTKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AKT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKT](
        [AKTKEY] varchar(2) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKT_Index_AKTKEY] PRIMARY KEY CLUSTERED (
            [AKTKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="AKTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="AKTDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AKT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AKT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AKT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_AKTKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_AKTKEY.Add(entity.AKTKEY);
            }

            builder.AppendLine("DELETE [dbo].[AKT] WHERE");


            // Index_AKTKEY
            builder.Append("[AKTKEY] IN (");
            for (int index = 0; index < Index_AKTKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // AKTKEY
                var parameterAKTKEY = $"@p{parameterIndex++}";
                builder.Append(parameterAKTKEY);
                command.Parameters.Add(parameterAKTKEY, SqlDbType.VarChar, 2).Value = Index_AKTKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKT data set</returns>
        public override EduHubDataSetDataReader<AKT> GetDataSetDataReader()
        {
            return new AKTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKT data set</returns>
        public override EduHubDataSetDataReader<AKT> GetDataSetDataReader(List<AKT> Entities)
        {
            return new AKTDataReader(new EduHubDataSetLoadedReader<AKT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKTDataReader : EduHubDataSetDataReader<AKT>
        {
            public AKTDataReader(IEduHubDataSetReader<AKT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // AKTKEY
                        return Current.AKTKEY;
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
                    case 0: // AKTKEY
                        return "AKTKEY";
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
                    case "AKTKEY":
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
