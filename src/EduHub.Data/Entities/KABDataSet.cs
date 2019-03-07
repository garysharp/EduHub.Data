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
    /// BSB Numbers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KABDataSet : EduHubDataSet<KAB>
    {
        /// <inheritdoc />
        public override string Name { get { return "KAB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KABDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<Dictionary<string, KAB>>(() => this.ToDictionary(i => i.BSB));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAB" /> fields for each CSV column header</returns>
        internal override Action<KAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
        /// Merges <see cref="KAB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KAB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KAB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KAB}"/> of entities</returns>
        internal override IEnumerable<KAB> ApplyDeltaEntities(IEnumerable<KAB> Entities, List<KAB> DeltaEntities)
        {
            HashSet<string> Index_BSB = new HashSet<string>(DeltaEntities.Select(i => i.BSB));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.BSB;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_BSB.Remove(entity.BSB);
                            
                            if (entity.BSB.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KAB>> Index_BSB;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <returns>Related KAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAB FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <param name="Value">Related KAB entity</param>
        /// <returns>True if the related KAB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out KAB Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find KAB by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find KAB</param>
        /// <returns>Related KAB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAB TryFindByBSB(string BSB)
        {
            KAB value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KAB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KAB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KAB](
        [BSB] varchar(6) NOT NULL,
        [BANK] varchar(10) NULL,
        [ADDRESS] varchar(50) NULL,
        [SUBURB] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KAB_Index_BSB] PRIMARY KEY CLUSTERED (
            [BSB] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KABDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KABDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KAB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KAB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KAB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_BSB = new List<string>();

            foreach (var entity in Entities)
            {
                Index_BSB.Add(entity.BSB);
            }

            builder.AppendLine("DELETE [dbo].[KAB] WHERE");


            // Index_BSB
            builder.Append("[BSB] IN (");
            for (int index = 0; index < Index_BSB.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // BSB
                var parameterBSB = $"@p{parameterIndex++}";
                builder.Append(parameterBSB);
                command.Parameters.Add(parameterBSB, SqlDbType.VarChar, 6).Value = Index_BSB[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAB data set</returns>
        public override EduHubDataSetDataReader<KAB> GetDataSetDataReader()
        {
            return new KABDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAB data set</returns>
        public override EduHubDataSetDataReader<KAB> GetDataSetDataReader(List<KAB> Entities)
        {
            return new KABDataReader(new EduHubDataSetLoadedReader<KAB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KABDataReader : EduHubDataSetDataReader<KAB>
        {
            public KABDataReader(IEduHubDataSetReader<KAB> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // BSB
                        return Current.BSB;
                    case 1: // BANK
                        return Current.BANK;
                    case 2: // ADDRESS
                        return Current.ADDRESS;
                    case 3: // SUBURB
                        return Current.SUBURB;
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
                    case 1: // BANK
                        return Current.BANK == null;
                    case 2: // ADDRESS
                        return Current.ADDRESS == null;
                    case 3: // SUBURB
                        return Current.SUBURB == null;
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
                    case 0: // BSB
                        return "BSB";
                    case 1: // BANK
                        return "BANK";
                    case 2: // ADDRESS
                        return "ADDRESS";
                    case 3: // SUBURB
                        return "SUBURB";
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
                    case "BSB":
                        return 0;
                    case "BANK":
                        return 1;
                    case "ADDRESS":
                        return 2;
                    case "SUBURB":
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
