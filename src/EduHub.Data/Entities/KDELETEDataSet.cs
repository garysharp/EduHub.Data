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
    /// Data deleted from DataMirror monitored tables Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDELETEDataSet : EduHubDataSet<KDELETE>
    {
        /// <inheritdoc />
        public override string Name { get { return "KDELETE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KDELETEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, KDELETE>>(() => this.ToDictionary(i => i.ID));
            Index_LW_DATE = new Lazy<NullDictionary<DateTime?, IReadOnlyList<KDELETE>>>(() => this.ToGroupedNullDictionary(i => i.LW_DATE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDELETE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDELETE" /> fields for each CSV column header</returns>
        internal override Action<KDELETE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDELETE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TABLENAME":
                        mapper[i] = (e, v) => e.TABLENAME = v;
                        break;
                    case "IDVALUE":
                        mapper[i] = (e, v) => e.IDVALUE = v;
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
        /// Merges <see cref="KDELETE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KDELETE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KDELETE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KDELETE}"/> of entities</returns>
        internal override IEnumerable<KDELETE> ApplyDeltaEntities(IEnumerable<KDELETE> Entities, List<KDELETE> DeltaEntities)
        {
            HashSet<int> Index_ID = new HashSet<int>(DeltaEntities.Select(i => i.ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ID.Remove(entity.ID);
                            
                            if (entity.ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KDELETE>> Index_ID;
        private Lazy<NullDictionary<DateTime?, IReadOnlyList<KDELETE>>> Index_LW_DATE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDELETE FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <param name="Value">Related KDELETE entity</param>
        /// <returns>True if the related KDELETE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out KDELETE Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find KDELETE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDELETE TryFindByID(int ID)
        {
            KDELETE value;
            if (Index_ID.Value.TryGetValue(ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <returns>List of related KDELETE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KDELETE> FindByLW_DATE(DateTime? LW_DATE)
        {
            return Index_LW_DATE.Value[LW_DATE];
        }

        /// <summary>
        /// Attempt to find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <param name="Value">List of related KDELETE entities</param>
        /// <returns>True if the list of related KDELETE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLW_DATE(DateTime? LW_DATE, out IReadOnlyList<KDELETE> Value)
        {
            return Index_LW_DATE.Value.TryGetValue(LW_DATE, out Value);
        }

        /// <summary>
        /// Attempt to find KDELETE by LW_DATE field
        /// </summary>
        /// <param name="LW_DATE">LW_DATE value used to find KDELETE</param>
        /// <returns>List of related KDELETE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KDELETE> TryFindByLW_DATE(DateTime? LW_DATE)
        {
            IReadOnlyList<KDELETE> value;
            if (Index_LW_DATE.Value.TryGetValue(LW_DATE, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KDELETE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KDELETE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KDELETE](
        [ID] int IDENTITY NOT NULL,
        [TABLENAME] varchar(10) NULL,
        [IDVALUE] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KDELETE_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KDELETE_Index_LW_DATE] ON [dbo].[KDELETE]
    (
            [LW_DATE] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KDELETE]') AND name = N'KDELETE_Index_LW_DATE')
    ALTER INDEX [KDELETE_Index_LW_DATE] ON [dbo].[KDELETE] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KDELETE]') AND name = N'KDELETE_Index_LW_DATE')
    ALTER INDEX [KDELETE_Index_LW_DATE] ON [dbo].[KDELETE] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KDELETE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KDELETE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KDELETE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[KDELETE] WHERE");


            // Index_ID
            builder.Append("[ID] IN (");
            for (int index = 0; index < Index_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ID
                var parameterID = $"@p{parameterIndex++}";
                builder.Append(parameterID);
                command.Parameters.Add(parameterID, SqlDbType.Int).Value = Index_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDELETE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDELETE data set</returns>
        public override EduHubDataSetDataReader<KDELETE> GetDataSetDataReader()
        {
            return new KDELETEDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDELETE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDELETE data set</returns>
        public override EduHubDataSetDataReader<KDELETE> GetDataSetDataReader(List<KDELETE> Entities)
        {
            return new KDELETEDataReader(new EduHubDataSetLoadedReader<KDELETE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KDELETEDataReader : EduHubDataSetDataReader<KDELETE>
        {
            public KDELETEDataReader(IEduHubDataSetReader<KDELETE> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // TABLENAME
                        return Current.TABLENAME;
                    case 2: // IDVALUE
                        return Current.IDVALUE;
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
                    case 1: // TABLENAME
                        return Current.TABLENAME == null;
                    case 2: // IDVALUE
                        return Current.IDVALUE == null;
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
                    case 0: // ID
                        return "ID";
                    case 1: // TABLENAME
                        return "TABLENAME";
                    case 2: // IDVALUE
                        return "IDVALUE";
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
                    case "ID":
                        return 0;
                    case "TABLENAME":
                        return 1;
                    case "IDVALUE":
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
