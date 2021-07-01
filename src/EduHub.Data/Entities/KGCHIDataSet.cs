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
    /// Home Group History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGCHIDataSet : EduHubDataSet<KGCHI>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGCHI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal KGCHIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGCHIKEY = new Lazy<Dictionary<int, KGCHI>>(() => this.ToDictionary(i => i.KGCHIKEY));
            Index_KGCKEY = new Lazy<NullDictionary<string, IReadOnlyList<KGCHI>>>(() => this.ToGroupedNullDictionary(i => i.KGCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGCHI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGCHI" /> fields for each CSV column header</returns>
        internal override Action<KGCHI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGCHI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCHIKEY":
                        mapper[i] = (e, v) => e.KGCHIKEY = int.Parse(v);
                        break;
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KGCHI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGCHI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGCHI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGCHI}"/> of entities</returns>
        internal override IEnumerable<KGCHI> ApplyDeltaEntities(IEnumerable<KGCHI> Entities, List<KGCHI> DeltaEntities)
        {
            HashSet<int> Index_KGCHIKEY = new HashSet<int>(DeltaEntities.Select(i => i.KGCHIKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KGCHIKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KGCHIKEY.Remove(entity.KGCHIKEY);
                            
                            if (entity.KGCHIKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KGCHI>> Index_KGCHIKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KGCHI>>> Index_KGCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <returns>Related KGCHI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGCHI FindByKGCHIKEY(int KGCHIKEY)
        {
            return Index_KGCHIKEY.Value[KGCHIKEY];
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <param name="Value">Related KGCHI entity</param>
        /// <returns>True if the related KGCHI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCHIKEY(int KGCHIKEY, out KGCHI Value)
        {
            return Index_KGCHIKEY.Value.TryGetValue(KGCHIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCHIKEY field
        /// </summary>
        /// <param name="KGCHIKEY">KGCHIKEY value used to find KGCHI</param>
        /// <returns>Related KGCHI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGCHI TryFindByKGCHIKEY(int KGCHIKEY)
        {
            KGCHI value;
            if (Index_KGCHIKEY.Value.TryGetValue(KGCHIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <returns>List of related KGCHI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGCHI> FindByKGCKEY(string KGCKEY)
        {
            return Index_KGCKEY.Value[KGCKEY];
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <param name="Value">List of related KGCHI entities</param>
        /// <returns>True if the list of related KGCHI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGCKEY(string KGCKEY, out IReadOnlyList<KGCHI> Value)
        {
            return Index_KGCKEY.Value.TryGetValue(KGCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCKEY field
        /// </summary>
        /// <param name="KGCKEY">KGCKEY value used to find KGCHI</param>
        /// <returns>List of related KGCHI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGCHI> TryFindByKGCKEY(string KGCKEY)
        {
            IReadOnlyList<KGCHI> value;
            if (Index_KGCKEY.Value.TryGetValue(KGCKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGCHI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGCHI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGCHI](
        [KGCHIKEY] int IDENTITY NOT NULL,
        [KGCKEY] varchar(3) NULL,
        [CREATION_USER] varchar(128) NULL,
        [CREATION_DATE] datetime NULL,
        [CREATION_TIME] smallint NULL,
        [OBSOLETE_USER] varchar(128) NULL,
        [OBSOLETE_DATE] datetime NULL,
        [OBSOLETE_TIME] smallint NULL,
        [CAMPUS] varchar(45) NULL,
        [TEACHER] varchar(35) NULL,
        [TEACHER_B] varchar(35) NULL,
        [ROOM] varchar(30) NULL,
        [CHANGE_MADE] varchar(40) NULL,
        CONSTRAINT [KGCHI_Index_KGCHIKEY] PRIMARY KEY CLUSTERED (
            [KGCHIKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGCHI_Index_KGCKEY] ON [dbo].[KGCHI]
    (
            [KGCKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGCHI]') AND name = N'Index_KGCKEY')
    ALTER INDEX [Index_KGCKEY] ON [dbo].[KGCHI] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGCHI]') AND name = N'Index_KGCKEY')
    ALTER INDEX [Index_KGCKEY] ON [dbo].[KGCHI] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGCHI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGCHI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGCHI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_KGCHIKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KGCHIKEY.Add(entity.KGCHIKEY);
            }

            builder.AppendLine("DELETE [dbo].[KGCHI] WHERE");


            // Index_KGCHIKEY
            builder.Append("[KGCHIKEY] IN (");
            for (int index = 0; index < Index_KGCHIKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KGCHIKEY
                var parameterKGCHIKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKGCHIKEY);
                command.Parameters.Add(parameterKGCHIKEY, SqlDbType.Int).Value = Index_KGCHIKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGCHI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGCHI data set</returns>
        public override EduHubDataSetDataReader<KGCHI> GetDataSetDataReader()
        {
            return new KGCHIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGCHI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGCHI data set</returns>
        public override EduHubDataSetDataReader<KGCHI> GetDataSetDataReader(List<KGCHI> Entities)
        {
            return new KGCHIDataReader(new EduHubDataSetLoadedReader<KGCHI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGCHIDataReader : EduHubDataSetDataReader<KGCHI>
        {
            public KGCHIDataReader(IEduHubDataSetReader<KGCHI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 13; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KGCHIKEY
                        return Current.KGCHIKEY;
                    case 1: // KGCKEY
                        return Current.KGCKEY;
                    case 2: // CREATION_USER
                        return Current.CREATION_USER;
                    case 3: // CREATION_DATE
                        return Current.CREATION_DATE;
                    case 4: // CREATION_TIME
                        return Current.CREATION_TIME;
                    case 5: // OBSOLETE_USER
                        return Current.OBSOLETE_USER;
                    case 6: // OBSOLETE_DATE
                        return Current.OBSOLETE_DATE;
                    case 7: // OBSOLETE_TIME
                        return Current.OBSOLETE_TIME;
                    case 8: // CAMPUS
                        return Current.CAMPUS;
                    case 9: // TEACHER
                        return Current.TEACHER;
                    case 10: // TEACHER_B
                        return Current.TEACHER_B;
                    case 11: // ROOM
                        return Current.ROOM;
                    case 12: // CHANGE_MADE
                        return Current.CHANGE_MADE;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // KGCKEY
                        return Current.KGCKEY == null;
                    case 2: // CREATION_USER
                        return Current.CREATION_USER == null;
                    case 3: // CREATION_DATE
                        return Current.CREATION_DATE == null;
                    case 4: // CREATION_TIME
                        return Current.CREATION_TIME == null;
                    case 5: // OBSOLETE_USER
                        return Current.OBSOLETE_USER == null;
                    case 6: // OBSOLETE_DATE
                        return Current.OBSOLETE_DATE == null;
                    case 7: // OBSOLETE_TIME
                        return Current.OBSOLETE_TIME == null;
                    case 8: // CAMPUS
                        return Current.CAMPUS == null;
                    case 9: // TEACHER
                        return Current.TEACHER == null;
                    case 10: // TEACHER_B
                        return Current.TEACHER_B == null;
                    case 11: // ROOM
                        return Current.ROOM == null;
                    case 12: // CHANGE_MADE
                        return Current.CHANGE_MADE == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KGCHIKEY
                        return "KGCHIKEY";
                    case 1: // KGCKEY
                        return "KGCKEY";
                    case 2: // CREATION_USER
                        return "CREATION_USER";
                    case 3: // CREATION_DATE
                        return "CREATION_DATE";
                    case 4: // CREATION_TIME
                        return "CREATION_TIME";
                    case 5: // OBSOLETE_USER
                        return "OBSOLETE_USER";
                    case 6: // OBSOLETE_DATE
                        return "OBSOLETE_DATE";
                    case 7: // OBSOLETE_TIME
                        return "OBSOLETE_TIME";
                    case 8: // CAMPUS
                        return "CAMPUS";
                    case 9: // TEACHER
                        return "TEACHER";
                    case 10: // TEACHER_B
                        return "TEACHER_B";
                    case 11: // ROOM
                        return "ROOM";
                    case 12: // CHANGE_MADE
                        return "CHANGE_MADE";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KGCHIKEY":
                        return 0;
                    case "KGCKEY":
                        return 1;
                    case "CREATION_USER":
                        return 2;
                    case "CREATION_DATE":
                        return 3;
                    case "CREATION_TIME":
                        return 4;
                    case "OBSOLETE_USER":
                        return 5;
                    case "OBSOLETE_DATE":
                        return 6;
                    case "OBSOLETE_TIME":
                        return 7;
                    case "CAMPUS":
                        return 8;
                    case "TEACHER":
                        return 9;
                    case "TEACHER_B":
                        return 10;
                    case "ROOM":
                        return 11;
                    case "CHANGE_MADE":
                        return 12;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
