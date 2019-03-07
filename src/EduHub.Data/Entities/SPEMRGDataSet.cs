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
    /// SMS Emergency Templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPEMRGDataSet : EduHubDataSet<SPEMRG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SPEMRG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SPEMRGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DESCRIPTION = new Lazy<Dictionary<string, IReadOnlyList<SPEMRG>>>(() => this.ToGroupedDictionary(i => i.DESCRIPTION));
            Index_SPEMRG = new Lazy<Dictionary<string, SPEMRG>>(() => this.ToDictionary(i => i._SPEMRG));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPEMRG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPEMRG" /> fields for each CSV column header</returns>
        internal override Action<SPEMRG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPEMRG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPEMRG":
                        mapper[i] = (e, v) => e._SPEMRG = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
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
        /// Merges <see cref="SPEMRG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SPEMRG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SPEMRG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SPEMRG}"/> of entities</returns>
        internal override IEnumerable<SPEMRG> ApplyDeltaEntities(IEnumerable<SPEMRG> Entities, List<SPEMRG> DeltaEntities)
        {
            HashSet<string> Index_SPEMRG = new HashSet<string>(DeltaEntities.Select(i => i._SPEMRG));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current._SPEMRG;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SPEMRG.Remove(entity._SPEMRG);
                            
                            if (entity._SPEMRG.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SPEMRG>>> Index_DESCRIPTION;
        private Lazy<Dictionary<string, SPEMRG>> Index_SPEMRG;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPEMRG by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find SPEMRG</param>
        /// <returns>List of related SPEMRG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEMRG> FindByDESCRIPTION(string DESCRIPTION)
        {
            return Index_DESCRIPTION.Value[DESCRIPTION];
        }

        /// <summary>
        /// Attempt to find SPEMRG by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find SPEMRG</param>
        /// <param name="Value">List of related SPEMRG entities</param>
        /// <returns>True if the list of related SPEMRG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDESCRIPTION(string DESCRIPTION, out IReadOnlyList<SPEMRG> Value)
        {
            return Index_DESCRIPTION.Value.TryGetValue(DESCRIPTION, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMRG by DESCRIPTION field
        /// </summary>
        /// <param name="DESCRIPTION">DESCRIPTION value used to find SPEMRG</param>
        /// <returns>List of related SPEMRG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEMRG> TryFindByDESCRIPTION(string DESCRIPTION)
        {
            IReadOnlyList<SPEMRG> value;
            if (Index_DESCRIPTION.Value.TryGetValue(DESCRIPTION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPEMRG by SPEMRG field
        /// </summary>
        /// <param name="SPEMRG">SPEMRG value used to find SPEMRG</param>
        /// <returns>Related SPEMRG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEMRG FindBySPEMRG(string SPEMRG)
        {
            return Index_SPEMRG.Value[SPEMRG];
        }

        /// <summary>
        /// Attempt to find SPEMRG by SPEMRG field
        /// </summary>
        /// <param name="SPEMRG">SPEMRG value used to find SPEMRG</param>
        /// <param name="Value">Related SPEMRG entity</param>
        /// <returns>True if the related SPEMRG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPEMRG(string SPEMRG, out SPEMRG Value)
        {
            return Index_SPEMRG.Value.TryGetValue(SPEMRG, out Value);
        }

        /// <summary>
        /// Attempt to find SPEMRG by SPEMRG field
        /// </summary>
        /// <param name="SPEMRG">SPEMRG value used to find SPEMRG</param>
        /// <returns>Related SPEMRG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEMRG TryFindBySPEMRG(string SPEMRG)
        {
            SPEMRG value;
            if (Index_SPEMRG.Value.TryGetValue(SPEMRG, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SPEMRG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPEMRG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPEMRG](
        [SPEMRG] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(50) NOT NULL,
        [MESSAGE] varchar(160) NOT NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPEMRG_Index_SPEMRG] PRIMARY KEY CLUSTERED (
            [SPEMRG] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SPEMRG_Index_DESCRIPTION] ON [dbo].[SPEMRG]
    (
            [DESCRIPTION] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPEMRG]') AND name = N'Index_DESCRIPTION')
    ALTER INDEX [Index_DESCRIPTION] ON [dbo].[SPEMRG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SPEMRG]') AND name = N'Index_DESCRIPTION')
    ALTER INDEX [Index_DESCRIPTION] ON [dbo].[SPEMRG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SPEMRG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SPEMRG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SPEMRG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SPEMRG = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SPEMRG.Add(entity._SPEMRG);
            }

            builder.AppendLine("DELETE [dbo].[SPEMRG] WHERE");


            // Index_SPEMRG
            builder.Append("[SPEMRG] IN (");
            for (int index = 0; index < Index_SPEMRG.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SPEMRG
                var parameterSPEMRG = $"@p{parameterIndex++}";
                builder.Append(parameterSPEMRG);
                command.Parameters.Add(parameterSPEMRG, SqlDbType.VarChar, 10).Value = Index_SPEMRG[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPEMRG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPEMRG data set</returns>
        public override EduHubDataSetDataReader<SPEMRG> GetDataSetDataReader()
        {
            return new SPEMRGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPEMRG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPEMRG data set</returns>
        public override EduHubDataSetDataReader<SPEMRG> GetDataSetDataReader(List<SPEMRG> Entities)
        {
            return new SPEMRGDataReader(new EduHubDataSetLoadedReader<SPEMRG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPEMRGDataReader : EduHubDataSetDataReader<SPEMRG>
        {
            public SPEMRGDataReader(IEduHubDataSetReader<SPEMRG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // _SPEMRG
                        return Current._SPEMRG;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // MESSAGE
                        return Current.MESSAGE;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SPEMRG
                        return "SPEMRG";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // MESSAGE
                        return "MESSAGE";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SPEMRG":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "MESSAGE":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
