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
    /// General Ledger Sub Programs Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLSUBDataSet : EduHubDataSet<KGLSUB>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGLSUB"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGLSUBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GL_PROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<KGLSUB>>>(() => this.ToGroupedNullDictionary(i => i.GL_PROGRAM));
            Index_SUBPROGRAM = new Lazy<Dictionary<string, KGLSUB>>(() => this.ToDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLSUB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLSUB" /> fields for each CSV column header</returns>
        internal override Action<KGLSUB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLSUB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "GL_PROGRAM":
                        mapper[i] = (e, v) => e.GL_PROGRAM = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "USER_DEFINABLE":
                        mapper[i] = (e, v) => e.USER_DEFINABLE = v;
                        break;
                    case "RESERVED":
                        mapper[i] = (e, v) => e.RESERVED = v;
                        break;
                    case "BATCHABLE":
                        mapper[i] = (e, v) => e.BATCHABLE = v;
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
        /// Merges <see cref="KGLSUB" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGLSUB" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGLSUB" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGLSUB}"/> of entities</returns>
        internal override IEnumerable<KGLSUB> ApplyDeltaEntities(IEnumerable<KGLSUB> Entities, List<KGLSUB> DeltaEntities)
        {
            HashSet<string> Index_SUBPROGRAM = new HashSet<string>(DeltaEntities.Select(i => i.SUBPROGRAM));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SUBPROGRAM;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_SUBPROGRAM.Remove(entity.SUBPROGRAM);
                            
                            if (entity.SUBPROGRAM.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<KGLSUB>>> Index_GL_PROGRAM;
        private Lazy<Dictionary<string, KGLSUB>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <returns>List of related KGLSUB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGLSUB> FindByGL_PROGRAM(string GL_PROGRAM)
        {
            return Index_GL_PROGRAM.Value[GL_PROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <param name="Value">List of related KGLSUB entities</param>
        /// <returns>True if the list of related KGLSUB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_PROGRAM(string GL_PROGRAM, out IReadOnlyList<KGLSUB> Value)
        {
            return Index_GL_PROGRAM.Value.TryGetValue(GL_PROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <returns>List of related KGLSUB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGLSUB> TryFindByGL_PROGRAM(string GL_PROGRAM)
        {
            IReadOnlyList<KGLSUB> value;
            if (Index_GL_PROGRAM.Value.TryGetValue(GL_PROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLSUB FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <param name="Value">Related KGLSUB entity</param>
        /// <returns>True if the related KGLSUB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out KGLSUB Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLSUB TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            KGLSUB value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGLSUB table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGLSUB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGLSUB](
        [SUBPROGRAM] varchar(4) NOT NULL,
        [TITLE] varchar(30) NULL,
        [GL_PROGRAM] varchar(3) NULL,
        [ACTIVE] varchar(1) NULL,
        [USER_DEFINABLE] varchar(1) NULL,
        [RESERVED] varchar(1) NULL,
        [BATCHABLE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGLSUB_Index_SUBPROGRAM] PRIMARY KEY CLUSTERED (
            [SUBPROGRAM] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KGLSUB_Index_GL_PROGRAM] ON [dbo].[KGLSUB]
    (
            [GL_PROGRAM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGLSUB]') AND name = N'Index_GL_PROGRAM')
    ALTER INDEX [Index_GL_PROGRAM] ON [dbo].[KGLSUB] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KGLSUB]') AND name = N'Index_GL_PROGRAM')
    ALTER INDEX [Index_GL_PROGRAM] ON [dbo].[KGLSUB] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGLSUB"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGLSUB"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGLSUB> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_SUBPROGRAM = new List<string>();

            foreach (var entity in Entities)
            {
                Index_SUBPROGRAM.Add(entity.SUBPROGRAM);
            }

            builder.AppendLine("DELETE [dbo].[KGLSUB] WHERE");


            // Index_SUBPROGRAM
            builder.Append("[SUBPROGRAM] IN (");
            for (int index = 0; index < Index_SUBPROGRAM.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // SUBPROGRAM
                var parameterSUBPROGRAM = $"@p{parameterIndex++}";
                builder.Append(parameterSUBPROGRAM);
                command.Parameters.Add(parameterSUBPROGRAM, SqlDbType.VarChar, 4).Value = Index_SUBPROGRAM[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLSUB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLSUB data set</returns>
        public override EduHubDataSetDataReader<KGLSUB> GetDataSetDataReader()
        {
            return new KGLSUBDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLSUB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLSUB data set</returns>
        public override EduHubDataSetDataReader<KGLSUB> GetDataSetDataReader(List<KGLSUB> Entities)
        {
            return new KGLSUBDataReader(new EduHubDataSetLoadedReader<KGLSUB>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGLSUBDataReader : EduHubDataSetDataReader<KGLSUB>
        {
            public KGLSUBDataReader(IEduHubDataSetReader<KGLSUB> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 10; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // GL_PROGRAM
                        return Current.GL_PROGRAM;
                    case 3: // ACTIVE
                        return Current.ACTIVE;
                    case 4: // USER_DEFINABLE
                        return Current.USER_DEFINABLE;
                    case 5: // RESERVED
                        return Current.RESERVED;
                    case 6: // BATCHABLE
                        return Current.BATCHABLE;
                    case 7: // LW_DATE
                        return Current.LW_DATE;
                    case 8: // LW_TIME
                        return Current.LW_TIME;
                    case 9: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // GL_PROGRAM
                        return Current.GL_PROGRAM == null;
                    case 3: // ACTIVE
                        return Current.ACTIVE == null;
                    case 4: // USER_DEFINABLE
                        return Current.USER_DEFINABLE == null;
                    case 5: // RESERVED
                        return Current.RESERVED == null;
                    case 6: // BATCHABLE
                        return Current.BATCHABLE == null;
                    case 7: // LW_DATE
                        return Current.LW_DATE == null;
                    case 8: // LW_TIME
                        return Current.LW_TIME == null;
                    case 9: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // GL_PROGRAM
                        return "GL_PROGRAM";
                    case 3: // ACTIVE
                        return "ACTIVE";
                    case 4: // USER_DEFINABLE
                        return "USER_DEFINABLE";
                    case 5: // RESERVED
                        return "RESERVED";
                    case 6: // BATCHABLE
                        return "BATCHABLE";
                    case 7: // LW_DATE
                        return "LW_DATE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SUBPROGRAM":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "GL_PROGRAM":
                        return 2;
                    case "ACTIVE":
                        return 3;
                    case "USER_DEFINABLE":
                        return 4;
                    case "RESERVED":
                        return 5;
                    case "BATCHABLE":
                        return 6;
                    case "LW_DATE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_USER":
                        return 9;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
