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
    /// Assets - Categories Tax Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKCTDataSet : EduHubDataSet<AKCT>
    {
        /// <inheritdoc />
        public override string Name { get { return "AKCT"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal AKCTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CATEGORY = new Lazy<Dictionary<string, AKCT>>(() => this.ToDictionary(i => i.CATEGORY));
            Index_DEPN_TMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<AKCT>>>(() => this.ToGroupedNullDictionary(i => i.DEPN_TMETHOD));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKCT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKCT" /> fields for each CSV column header</returns>
        internal override Action<AKCT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKCT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DEPN_TMETHOD":
                        mapper[i] = (e, v) => e.DEPN_TMETHOD = v;
                        break;
                    case "DEPN_TRATE":
                        mapper[i] = (e, v) => e.DEPN_TRATE = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="AKCT" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="AKCT" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AKCT" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AKCT}"/> of entities</returns>
        internal override IEnumerable<AKCT> ApplyDeltaEntities(IEnumerable<AKCT> Entities, List<AKCT> DeltaEntities)
        {
            HashSet<string> Index_CATEGORY = new HashSet<string>(DeltaEntities.Select(i => i.CATEGORY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CATEGORY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_CATEGORY.Remove(entity.CATEGORY);
                            
                            if (entity.CATEGORY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, AKCT>> Index_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<AKCT>>> Index_DEPN_TMETHOD;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKCT by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKCT</param>
        /// <returns>Related AKCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKCT FindByCATEGORY(string CATEGORY)
        {
            return Index_CATEGORY.Value[CATEGORY];
        }

        /// <summary>
        /// Attempt to find AKCT by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKCT</param>
        /// <param name="Value">Related AKCT entity</param>
        /// <returns>True if the related AKCT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCATEGORY(string CATEGORY, out AKCT Value)
        {
            return Index_CATEGORY.Value.TryGetValue(CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find AKCT by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKCT</param>
        /// <returns>Related AKCT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKCT TryFindByCATEGORY(string CATEGORY)
        {
            AKCT value;
            if (Index_CATEGORY.Value.TryGetValue(CATEGORY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKCT by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKCT</param>
        /// <returns>List of related AKCT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKCT> FindByDEPN_TMETHOD(string DEPN_TMETHOD)
        {
            return Index_DEPN_TMETHOD.Value[DEPN_TMETHOD];
        }

        /// <summary>
        /// Attempt to find AKCT by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKCT</param>
        /// <param name="Value">List of related AKCT entities</param>
        /// <returns>True if the list of related AKCT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEPN_TMETHOD(string DEPN_TMETHOD, out IReadOnlyList<AKCT> Value)
        {
            return Index_DEPN_TMETHOD.Value.TryGetValue(DEPN_TMETHOD, out Value);
        }

        /// <summary>
        /// Attempt to find AKCT by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKCT</param>
        /// <returns>List of related AKCT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKCT> TryFindByDEPN_TMETHOD(string DEPN_TMETHOD)
        {
            IReadOnlyList<AKCT> value;
            if (Index_DEPN_TMETHOD.Value.TryGetValue(DEPN_TMETHOD, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AKCT table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKCT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKCT](
        [CATEGORY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [DEPN_TMETHOD] varchar(1) NULL,
        [DEPN_TRATE] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKCT_Index_CATEGORY] PRIMARY KEY CLUSTERED (
            [CATEGORY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [AKCT_Index_DEPN_TMETHOD] ON [dbo].[AKCT]
    (
            [DEPN_TMETHOD] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKCT]') AND name = N'Index_DEPN_TMETHOD')
    ALTER INDEX [Index_DEPN_TMETHOD] ON [dbo].[AKCT] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKCT]') AND name = N'Index_DEPN_TMETHOD')
    ALTER INDEX [Index_DEPN_TMETHOD] ON [dbo].[AKCT] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AKCT"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AKCT"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AKCT> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_CATEGORY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_CATEGORY.Add(entity.CATEGORY);
            }

            builder.AppendLine("DELETE [dbo].[AKCT] WHERE");


            // Index_CATEGORY
            builder.Append("[CATEGORY] IN (");
            for (int index = 0; index < Index_CATEGORY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // CATEGORY
                var parameterCATEGORY = $"@p{parameterIndex++}";
                builder.Append(parameterCATEGORY);
                command.Parameters.Add(parameterCATEGORY, SqlDbType.VarChar, 10).Value = Index_CATEGORY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKCT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKCT data set</returns>
        public override EduHubDataSetDataReader<AKCT> GetDataSetDataReader()
        {
            return new AKCTDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKCT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKCT data set</returns>
        public override EduHubDataSetDataReader<AKCT> GetDataSetDataReader(List<AKCT> Entities)
        {
            return new AKCTDataReader(new EduHubDataSetLoadedReader<AKCT>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKCTDataReader : EduHubDataSetDataReader<AKCT>
        {
            public AKCTDataReader(IEduHubDataSetReader<AKCT> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // CATEGORY
                        return Current.CATEGORY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // DEPN_TMETHOD
                        return Current.DEPN_TMETHOD;
                    case 3: // DEPN_TRATE
                        return Current.DEPN_TRATE;
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
                    case 2: // DEPN_TMETHOD
                        return Current.DEPN_TMETHOD == null;
                    case 3: // DEPN_TRATE
                        return Current.DEPN_TRATE == null;
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
                    case 0: // CATEGORY
                        return "CATEGORY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // DEPN_TMETHOD
                        return "DEPN_TMETHOD";
                    case 3: // DEPN_TRATE
                        return "DEPN_TRATE";
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
                    case "CATEGORY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "DEPN_TMETHOD":
                        return 2;
                    case "DEPN_TRATE":
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
