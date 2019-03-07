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
    /// Delivery Addresses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KADDataSet : EduHubDataSet<KAD>
    {
        /// <inheritdoc />
        public override string Name { get { return "KAD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KADDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KADKEY = new Lazy<Dictionary<string, KAD>>(() => this.ToDictionary(i => i.KADKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAD" /> fields for each CSV column header</returns>
        internal override Action<KAD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADKEY":
                        mapper[i] = (e, v) => e.KADKEY = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
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
        /// Merges <see cref="KAD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KAD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KAD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KAD}"/> of entities</returns>
        internal override IEnumerable<KAD> ApplyDeltaEntities(IEnumerable<KAD> Entities, List<KAD> DeltaEntities)
        {
            HashSet<string> Index_KADKEY = new HashSet<string>(DeltaEntities.Select(i => i.KADKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KADKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KADKEY.Remove(entity.KADKEY);
                            
                            if (entity.KADKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KAD>> Index_KADKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAD FindByKADKEY(string KADKEY)
        {
            return Index_KADKEY.Value[KADKEY];
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <param name="Value">Related KAD entity</param>
        /// <returns>True if the related KAD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKADKEY(string KADKEY, out KAD Value)
        {
            return Index_KADKEY.Value.TryGetValue(KADKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAD by KADKEY field
        /// </summary>
        /// <param name="KADKEY">KADKEY value used to find KAD</param>
        /// <returns>Related KAD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAD TryFindByKADKEY(string KADKEY)
        {
            KAD value;
            if (Index_KADKEY.Value.TryGetValue(KADKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KAD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KAD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KAD](
        [KADKEY] varchar(10) NOT NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KAD_Index_KADKEY] PRIMARY KEY CLUSTERED (
            [KADKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KADDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KADDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KAD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KAD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KAD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KADKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KADKEY.Add(entity.KADKEY);
            }

            builder.AppendLine("DELETE [dbo].[KAD] WHERE");


            // Index_KADKEY
            builder.Append("[KADKEY] IN (");
            for (int index = 0; index < Index_KADKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KADKEY
                var parameterKADKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKADKEY);
                command.Parameters.Add(parameterKADKEY, SqlDbType.VarChar, 10).Value = Index_KADKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAD data set</returns>
        public override EduHubDataSetDataReader<KAD> GetDataSetDataReader()
        {
            return new KADDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KAD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KAD data set</returns>
        public override EduHubDataSetDataReader<KAD> GetDataSetDataReader(List<KAD> Entities)
        {
            return new KADDataReader(new EduHubDataSetLoadedReader<KAD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KADDataReader : EduHubDataSetDataReader<KAD>
        {
            public KADDataReader(IEduHubDataSetReader<KAD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KADKEY
                        return Current.KADKEY;
                    case 1: // ADDRESS01
                        return Current.ADDRESS01;
                    case 2: // ADDRESS02
                        return Current.ADDRESS02;
                    case 3: // ADDRESS03
                        return Current.ADDRESS03;
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
                    case 1: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 2: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 3: // ADDRESS03
                        return Current.ADDRESS03 == null;
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
                    case 0: // KADKEY
                        return "KADKEY";
                    case 1: // ADDRESS01
                        return "ADDRESS01";
                    case 2: // ADDRESS02
                        return "ADDRESS02";
                    case 3: // ADDRESS03
                        return "ADDRESS03";
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
                    case "KADKEY":
                        return 0;
                    case "ADDRESS01":
                        return 1;
                    case "ADDRESS02":
                        return 2;
                    case "ADDRESS03":
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
