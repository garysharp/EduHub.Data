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
    /// Restricted ABN Numbers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KABNDataSet : EduHubDataSet<KABN>
    {
        /// <inheritdoc />
        public override string Name { get { return "KABN"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KABNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ABN = new Lazy<Dictionary<string, KABN>>(() => this.ToDictionary(i => i.ABN));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KABN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KABN" /> fields for each CSV column header</returns>
        internal override Action<KABN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KABN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
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
        /// Merges <see cref="KABN" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KABN" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KABN" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KABN}"/> of entities</returns>
        internal override IEnumerable<KABN> ApplyDeltaEntities(IEnumerable<KABN> Entities, List<KABN> DeltaEntities)
        {
            HashSet<string> Index_ABN = new HashSet<string>(DeltaEntities.Select(i => i.ABN));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ABN;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ABN.Remove(entity.ABN);
                            
                            if (entity.ABN.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KABN>> Index_ABN;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KABN by ABN field
        /// </summary>
        /// <param name="ABN">ABN value used to find KABN</param>
        /// <returns>Related KABN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KABN FindByABN(string ABN)
        {
            return Index_ABN.Value[ABN];
        }

        /// <summary>
        /// Attempt to find KABN by ABN field
        /// </summary>
        /// <param name="ABN">ABN value used to find KABN</param>
        /// <param name="Value">Related KABN entity</param>
        /// <returns>True if the related KABN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByABN(string ABN, out KABN Value)
        {
            return Index_ABN.Value.TryGetValue(ABN, out Value);
        }

        /// <summary>
        /// Attempt to find KABN by ABN field
        /// </summary>
        /// <param name="ABN">ABN value used to find KABN</param>
        /// <returns>Related KABN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KABN TryFindByABN(string ABN)
        {
            KABN value;
            if (Index_ABN.Value.TryGetValue(ABN, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KABN table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KABN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KABN](
        [ABN] varchar(15) NOT NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KABN_Index_ABN] PRIMARY KEY CLUSTERED (
            [ABN] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KABNDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KABNDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KABN"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KABN"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KABN> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_ABN = new List<string>();

            foreach (var entity in Entities)
            {
                Index_ABN.Add(entity.ABN);
            }

            builder.AppendLine("DELETE [dbo].[KABN] WHERE");


            // Index_ABN
            builder.Append("[ABN] IN (");
            for (int index = 0; index < Index_ABN.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ABN
                var parameterABN = $"@p{parameterIndex++}";
                builder.Append(parameterABN);
                command.Parameters.Add(parameterABN, SqlDbType.VarChar, 15).Value = Index_ABN[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KABN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KABN data set</returns>
        public override EduHubDataSetDataReader<KABN> GetDataSetDataReader()
        {
            return new KABNDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KABN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KABN data set</returns>
        public override EduHubDataSetDataReader<KABN> GetDataSetDataReader(List<KABN> Entities)
        {
            return new KABNDataReader(new EduHubDataSetLoadedReader<KABN>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KABNDataReader : EduHubDataSetDataReader<KABN>
        {
            public KABNDataReader(IEduHubDataSetReader<KABN> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 4; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ABN
                        return Current.ABN;
                    case 1: // LW_DATE
                        return Current.LW_DATE;
                    case 2: // LW_TIME
                        return Current.LW_TIME;
                    case 3: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // LW_DATE
                        return Current.LW_DATE == null;
                    case 2: // LW_TIME
                        return Current.LW_TIME == null;
                    case 3: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ABN
                        return "ABN";
                    case 1: // LW_DATE
                        return "LW_DATE";
                    case 2: // LW_TIME
                        return "LW_TIME";
                    case 3: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ABN":
                        return 0;
                    case "LW_DATE":
                        return 1;
                    case "LW_TIME":
                        return 2;
                    case "LW_USER":
                        return 3;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
