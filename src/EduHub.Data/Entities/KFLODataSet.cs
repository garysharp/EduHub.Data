#if !EduHubScoped
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
    /// FLO Placement information Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KFLODataSet : EduHubDataSet<KFLO>
    {
        /// <inheritdoc />
        public override string Name { get { return "KFLO"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KFLODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KFLOKEY = new Lazy<Dictionary<int, KFLO>>(() => this.ToDictionary(i => i.KFLOKEY));
            Index_SCHOOL = new Lazy<NullDictionary<string, IReadOnlyList<KFLO>>>(() => this.ToGroupedNullDictionary(i => i.SCHOOL));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KFLO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KFLO" /> fields for each CSV column header</returns>
        internal override Action<KFLO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KFLO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KFLOKEY":
                        mapper[i] = (e, v) => e.KFLOKEY = int.Parse(v);
                        break;
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "SCHOOL_NUMBER":
                        mapper[i] = (e, v) => e.SCHOOL_NUMBER = v;
                        break;
                    case "PROGRAM":
                        mapper[i] = (e, v) => e.PROGRAM = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="KFLO" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KFLO" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KFLO" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KFLO}"/> of entities</returns>
        internal override IEnumerable<KFLO> ApplyDeltaEntities(IEnumerable<KFLO> Entities, List<KFLO> DeltaEntities)
        {
            HashSet<int> Index_KFLOKEY = new HashSet<int>(DeltaEntities.Select(i => i.KFLOKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KFLOKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KFLOKEY.Remove(entity.KFLOKEY);
                            
                            if (entity.KFLOKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, KFLO>> Index_KFLOKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KFLO>>> Index_SCHOOL;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KFLO by KFLOKEY field
        /// </summary>
        /// <param name="KFLOKEY">KFLOKEY value used to find KFLO</param>
        /// <returns>Related KFLO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFLO FindByKFLOKEY(int KFLOKEY)
        {
            return Index_KFLOKEY.Value[KFLOKEY];
        }

        /// <summary>
        /// Attempt to find KFLO by KFLOKEY field
        /// </summary>
        /// <param name="KFLOKEY">KFLOKEY value used to find KFLO</param>
        /// <param name="Value">Related KFLO entity</param>
        /// <returns>True if the related KFLO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKFLOKEY(int KFLOKEY, out KFLO Value)
        {
            return Index_KFLOKEY.Value.TryGetValue(KFLOKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KFLO by KFLOKEY field
        /// </summary>
        /// <param name="KFLOKEY">KFLOKEY value used to find KFLO</param>
        /// <returns>Related KFLO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFLO TryFindByKFLOKEY(int KFLOKEY)
        {
            KFLO value;
            if (Index_KFLOKEY.Value.TryGetValue(KFLOKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KFLO by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find KFLO</param>
        /// <returns>List of related KFLO entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KFLO> FindBySCHOOL(string SCHOOL)
        {
            return Index_SCHOOL.Value[SCHOOL];
        }

        /// <summary>
        /// Attempt to find KFLO by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find KFLO</param>
        /// <param name="Value">List of related KFLO entities</param>
        /// <returns>True if the list of related KFLO entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCHOOL(string SCHOOL, out IReadOnlyList<KFLO> Value)
        {
            return Index_SCHOOL.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Attempt to find KFLO by SCHOOL field
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find KFLO</param>
        /// <returns>List of related KFLO entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KFLO> TryFindBySCHOOL(string SCHOOL)
        {
            IReadOnlyList<KFLO> value;
            if (Index_SCHOOL.Value.TryGetValue(SCHOOL, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KFLO table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KFLO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KFLO](
        [KFLOKEY] int IDENTITY NOT NULL,
        [SCHOOL] varchar(8) NULL,
        [SCHOOL_ID] varchar(4) NULL,
        [SCHOOL_NUMBER] varchar(2) NULL,
        [PROGRAM] varchar(50) NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KFLO_Index_KFLOKEY] PRIMARY KEY CLUSTERED (
            [KFLOKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KFLO_Index_SCHOOL] ON [dbo].[KFLO]
    (
            [SCHOOL] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KFLO]') AND name = N'KFLO_Index_SCHOOL')
    ALTER INDEX [KFLO_Index_SCHOOL] ON [dbo].[KFLO] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KFLO]') AND name = N'KFLO_Index_SCHOOL')
    ALTER INDEX [KFLO_Index_SCHOOL] ON [dbo].[KFLO] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KFLO"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KFLO"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KFLO> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_KFLOKEY = new List<int>();

            foreach (var entity in Entities)
            {
                Index_KFLOKEY.Add(entity.KFLOKEY);
            }

            builder.AppendLine("DELETE [dbo].[KFLO] WHERE");


            // Index_KFLOKEY
            builder.Append("[KFLOKEY] IN (");
            for (int index = 0; index < Index_KFLOKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KFLOKEY
                var parameterKFLOKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKFLOKEY);
                command.Parameters.Add(parameterKFLOKEY, SqlDbType.Int).Value = Index_KFLOKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KFLO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KFLO data set</returns>
        public override EduHubDataSetDataReader<KFLO> GetDataSetDataReader()
        {
            return new KFLODataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KFLO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KFLO data set</returns>
        public override EduHubDataSetDataReader<KFLO> GetDataSetDataReader(List<KFLO> Entities)
        {
            return new KFLODataReader(new EduHubDataSetLoadedReader<KFLO>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KFLODataReader : EduHubDataSetDataReader<KFLO>
        {
            public KFLODataReader(IEduHubDataSetReader<KFLO> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KFLOKEY
                        return Current.KFLOKEY;
                    case 1: // SCHOOL
                        return Current.SCHOOL;
                    case 2: // SCHOOL_ID
                        return Current.SCHOOL_ID;
                    case 3: // SCHOOL_NUMBER
                        return Current.SCHOOL_NUMBER;
                    case 4: // PROGRAM
                        return Current.PROGRAM;
                    case 5: // ACTIVE
                        return Current.ACTIVE;
                    case 6: // LW_DATE
                        return Current.LW_DATE;
                    case 7: // LW_TIME
                        return Current.LW_TIME;
                    case 8: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SCHOOL
                        return Current.SCHOOL == null;
                    case 2: // SCHOOL_ID
                        return Current.SCHOOL_ID == null;
                    case 3: // SCHOOL_NUMBER
                        return Current.SCHOOL_NUMBER == null;
                    case 4: // PROGRAM
                        return Current.PROGRAM == null;
                    case 5: // ACTIVE
                        return Current.ACTIVE == null;
                    case 6: // LW_DATE
                        return Current.LW_DATE == null;
                    case 7: // LW_TIME
                        return Current.LW_TIME == null;
                    case 8: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KFLOKEY
                        return "KFLOKEY";
                    case 1: // SCHOOL
                        return "SCHOOL";
                    case 2: // SCHOOL_ID
                        return "SCHOOL_ID";
                    case 3: // SCHOOL_NUMBER
                        return "SCHOOL_NUMBER";
                    case 4: // PROGRAM
                        return "PROGRAM";
                    case 5: // ACTIVE
                        return "ACTIVE";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KFLOKEY":
                        return 0;
                    case "SCHOOL":
                        return 1;
                    case "SCHOOL_ID":
                        return 2;
                    case "SCHOOL_NUMBER":
                        return 3;
                    case "PROGRAM":
                        return 4;
                    case "ACTIVE":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
