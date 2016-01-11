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
    /// Family/Student ID Sequence Numbers Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KNFSDataSet : EduHubDataSet<KNFS>
    {
        /// <inheritdoc />
        public override string Name { get { return "KNFS"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KNFSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KNFSKEY = new Lazy<Dictionary<string, KNFS>>(() => this.ToDictionary(i => i.KNFSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KNFS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KNFS" /> fields for each CSV column header</returns>
        internal override Action<KNFS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KNFS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KNFSKEY":
                        mapper[i] = (e, v) => e.KNFSKEY = v;
                        break;
                    case "NEXT_NUMBER":
                        mapper[i] = (e, v) => e.NEXT_NUMBER = v;
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
        /// Merges <see cref="KNFS" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KNFS" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KNFS" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KNFS}"/> of entities</returns>
        internal override IEnumerable<KNFS> ApplyDeltaEntities(IEnumerable<KNFS> Entities, List<KNFS> DeltaEntities)
        {
            HashSet<string> Index_KNFSKEY = new HashSet<string>(DeltaEntities.Select(i => i.KNFSKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KNFSKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KNFSKEY.Remove(entity.KNFSKEY);
                            
                            if (entity.KNFSKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KNFS>> Index_KNFSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <returns>Related KNFS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNFS FindByKNFSKEY(string KNFSKEY)
        {
            return Index_KNFSKEY.Value[KNFSKEY];
        }

        /// <summary>
        /// Attempt to find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <param name="Value">Related KNFS entity</param>
        /// <returns>True if the related KNFS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKNFSKEY(string KNFSKEY, out KNFS Value)
        {
            return Index_KNFSKEY.Value.TryGetValue(KNFSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KNFS by KNFSKEY field
        /// </summary>
        /// <param name="KNFSKEY">KNFSKEY value used to find KNFS</param>
        /// <returns>Related KNFS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KNFS TryFindByKNFSKEY(string KNFSKEY)
        {
            KNFS value;
            if (Index_KNFSKEY.Value.TryGetValue(KNFSKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KNFS table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KNFS]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KNFS](
        [KNFSKEY] varchar(3) NOT NULL,
        [NEXT_NUMBER] varchar(4) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KNFS_Index_KNFSKEY] PRIMARY KEY CLUSTERED (
            [KNFSKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KNFSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KNFSDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KNFS"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KNFS"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KNFS> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KNFSKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KNFSKEY.Add(entity.KNFSKEY);
            }

            builder.AppendLine("DELETE [dbo].[KNFS] WHERE");


            // Index_KNFSKEY
            builder.Append("[KNFSKEY] IN (");
            for (int index = 0; index < Index_KNFSKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KNFSKEY
                var parameterKNFSKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKNFSKEY);
                command.Parameters.Add(parameterKNFSKEY, SqlDbType.VarChar, 3).Value = Index_KNFSKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KNFS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KNFS data set</returns>
        public override EduHubDataSetDataReader<KNFS> GetDataSetDataReader()
        {
            return new KNFSDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KNFS data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KNFS data set</returns>
        public override EduHubDataSetDataReader<KNFS> GetDataSetDataReader(List<KNFS> Entities)
        {
            return new KNFSDataReader(new EduHubDataSetLoadedReader<KNFS>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KNFSDataReader : EduHubDataSetDataReader<KNFS>
        {
            public KNFSDataReader(IEduHubDataSetReader<KNFS> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KNFSKEY
                        return Current.KNFSKEY;
                    case 1: // NEXT_NUMBER
                        return Current.NEXT_NUMBER;
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
                    case 1: // NEXT_NUMBER
                        return Current.NEXT_NUMBER == null;
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
                    case 0: // KNFSKEY
                        return "KNFSKEY";
                    case 1: // NEXT_NUMBER
                        return "NEXT_NUMBER";
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
                    case "KNFSKEY":
                        return 0;
                    case "NEXT_NUMBER":
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
