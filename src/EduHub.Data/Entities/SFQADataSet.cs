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
    /// Staff Qualifications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFQADataSet : EduHubDataSet<SFQA>
    {
        /// <inheritdoc />
        public override string Name { get { return "SFQA"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SFQADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TEACH = new Lazy<Dictionary<string, IReadOnlyList<SFQA>>>(() => this.ToGroupedDictionary(i => i.TEACH));
            Index_TID = new Lazy<Dictionary<int, SFQA>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFQA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFQA" /> fields for each CSV column header</returns>
        internal override Action<SFQA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFQA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "QUALIFICATION":
                        mapper[i] = (e, v) => e.QUALIFICATION = v;
                        break;
                    case "YEAR_COMPLETED":
                        mapper[i] = (e, v) => e.YEAR_COMPLETED = v;
                        break;
                    case "INSTITUTION":
                        mapper[i] = (e, v) => e.INSTITUTION = v;
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
        /// Merges <see cref="SFQA" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SFQA" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SFQA" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SFQA}"/> of entities</returns>
        internal override IEnumerable<SFQA> ApplyDeltaEntities(IEnumerable<SFQA> Entities, List<SFQA> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.TEACH;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.TEACH.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, IReadOnlyList<SFQA>>> Index_TEACH;
        private Lazy<Dictionary<int, SFQA>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <returns>List of related SFQA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFQA> FindByTEACH(string TEACH)
        {
            return Index_TEACH.Value[TEACH];
        }

        /// <summary>
        /// Attempt to find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <param name="Value">List of related SFQA entities</param>
        /// <returns>True if the list of related SFQA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACH(string TEACH, out IReadOnlyList<SFQA> Value)
        {
            return Index_TEACH.Value.TryGetValue(TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find SFQA by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFQA</param>
        /// <returns>List of related SFQA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFQA> TryFindByTEACH(string TEACH)
        {
            IReadOnlyList<SFQA> value;
            if (Index_TEACH.Value.TryGetValue(TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <returns>Related SFQA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFQA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <param name="Value">Related SFQA entity</param>
        /// <returns>True if the related SFQA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SFQA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SFQA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFQA</param>
        /// <returns>Related SFQA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFQA TryFindByTID(int TID)
        {
            SFQA value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SFQA table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SFQA]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SFQA](
        [TID] int IDENTITY NOT NULL,
        [TEACH] varchar(4) NOT NULL,
        [QUALIFICATION] varchar(30) NULL,
        [YEAR_COMPLETED] varchar(4) NULL,
        [INSTITUTION] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SFQA_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [SFQA_Index_TEACH] ON [dbo].[SFQA]
    (
            [TEACH] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SFQA]') AND name = N'SFQA_Index_TID')
    ALTER INDEX [SFQA_Index_TID] ON [dbo].[SFQA] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SFQA]') AND name = N'SFQA_Index_TID')
    ALTER INDEX [SFQA_Index_TID] ON [dbo].[SFQA] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SFQA"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SFQA"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SFQA> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SFQA] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SFQA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SFQA data set</returns>
        public override EduHubDataSetDataReader<SFQA> GetDataSetDataReader()
        {
            return new SFQADataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SFQA data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SFQA data set</returns>
        public override EduHubDataSetDataReader<SFQA> GetDataSetDataReader(List<SFQA> Entities)
        {
            return new SFQADataReader(new EduHubDataSetLoadedReader<SFQA>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SFQADataReader : EduHubDataSetDataReader<SFQA>
        {
            public SFQADataReader(IEduHubDataSetReader<SFQA> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // TEACH
                        return Current.TEACH;
                    case 2: // QUALIFICATION
                        return Current.QUALIFICATION;
                    case 3: // YEAR_COMPLETED
                        return Current.YEAR_COMPLETED;
                    case 4: // INSTITUTION
                        return Current.INSTITUTION;
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
                    case 2: // QUALIFICATION
                        return Current.QUALIFICATION == null;
                    case 3: // YEAR_COMPLETED
                        return Current.YEAR_COMPLETED == null;
                    case 4: // INSTITUTION
                        return Current.INSTITUTION == null;
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
                    case 0: // TID
                        return "TID";
                    case 1: // TEACH
                        return "TEACH";
                    case 2: // QUALIFICATION
                        return "QUALIFICATION";
                    case 3: // YEAR_COMPLETED
                        return "YEAR_COMPLETED";
                    case 4: // INSTITUTION
                        return "INSTITUTION";
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
                    case "TID":
                        return 0;
                    case "TEACH":
                        return 1;
                    case "QUALIFICATION":
                        return 2;
                    case "YEAR_COMPLETED":
                        return 3;
                    case "INSTITUTION":
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
