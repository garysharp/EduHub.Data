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
    /// User Program Codes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KUPCDataSet : EduHubDataSet<KUPC>
    {
        /// <inheritdoc />
        public override string Name { get { return "KUPC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KUPCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GL_CODE = new Lazy<NullDictionary<string, IReadOnlyList<KUPC>>>(() => this.ToGroupedNullDictionary(i => i.GL_CODE));
            Index_GLPROGRAM01 = new Lazy<NullDictionary<string, IReadOnlyList<KUPC>>>(() => this.ToGroupedNullDictionary(i => i.GLPROGRAM01));
            Index_GLPROGRAM02 = new Lazy<NullDictionary<string, IReadOnlyList<KUPC>>>(() => this.ToGroupedNullDictionary(i => i.GLPROGRAM02));
            Index_KUPCKEY = new Lazy<Dictionary<string, KUPC>>(() => this.ToDictionary(i => i.KUPCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KUPC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KUPC" /> fields for each CSV column header</returns>
        internal override Action<KUPC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KUPC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KUPCKEY":
                        mapper[i] = (e, v) => e.KUPCKEY = v;
                        break;
                    case "GLPROGRAM01":
                        mapper[i] = (e, v) => e.GLPROGRAM01 = v;
                        break;
                    case "GLPROGRAM02":
                        mapper[i] = (e, v) => e.GLPROGRAM02 = v;
                        break;
                    case "GL_CODE":
                        mapper[i] = (e, v) => e.GL_CODE = v;
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
        /// Merges <see cref="KUPC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KUPC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KUPC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KUPC}"/> of entities</returns>
        internal override IEnumerable<KUPC> ApplyDeltaEntities(IEnumerable<KUPC> Entities, List<KUPC> DeltaEntities)
        {
            HashSet<string> Index_KUPCKEY = new HashSet<string>(DeltaEntities.Select(i => i.KUPCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KUPCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KUPCKEY.Remove(entity.KUPCKEY);
                            
                            if (entity.KUPCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<KUPC>>> Index_GL_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<KUPC>>> Index_GLPROGRAM01;
        private Lazy<NullDictionary<string, IReadOnlyList<KUPC>>> Index_GLPROGRAM02;
        private Lazy<Dictionary<string, KUPC>> Index_KUPCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KUPC by GL_CODE field
        /// </summary>
        /// <param name="GL_CODE">GL_CODE value used to find KUPC</param>
        /// <returns>List of related KUPC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KUPC> FindByGL_CODE(string GL_CODE)
        {
            return Index_GL_CODE.Value[GL_CODE];
        }

        /// <summary>
        /// Attempt to find KUPC by GL_CODE field
        /// </summary>
        /// <param name="GL_CODE">GL_CODE value used to find KUPC</param>
        /// <param name="Value">List of related KUPC entities</param>
        /// <returns>True if the list of related KUPC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_CODE(string GL_CODE, out IReadOnlyList<KUPC> Value)
        {
            return Index_GL_CODE.Value.TryGetValue(GL_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KUPC by GL_CODE field
        /// </summary>
        /// <param name="GL_CODE">GL_CODE value used to find KUPC</param>
        /// <returns>List of related KUPC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KUPC> TryFindByGL_CODE(string GL_CODE)
        {
            IReadOnlyList<KUPC> value;
            if (Index_GL_CODE.Value.TryGetValue(GL_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KUPC by GLPROGRAM01 field
        /// </summary>
        /// <param name="GLPROGRAM01">GLPROGRAM01 value used to find KUPC</param>
        /// <returns>List of related KUPC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KUPC> FindByGLPROGRAM01(string GLPROGRAM01)
        {
            return Index_GLPROGRAM01.Value[GLPROGRAM01];
        }

        /// <summary>
        /// Attempt to find KUPC by GLPROGRAM01 field
        /// </summary>
        /// <param name="GLPROGRAM01">GLPROGRAM01 value used to find KUPC</param>
        /// <param name="Value">List of related KUPC entities</param>
        /// <returns>True if the list of related KUPC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLPROGRAM01(string GLPROGRAM01, out IReadOnlyList<KUPC> Value)
        {
            return Index_GLPROGRAM01.Value.TryGetValue(GLPROGRAM01, out Value);
        }

        /// <summary>
        /// Attempt to find KUPC by GLPROGRAM01 field
        /// </summary>
        /// <param name="GLPROGRAM01">GLPROGRAM01 value used to find KUPC</param>
        /// <returns>List of related KUPC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KUPC> TryFindByGLPROGRAM01(string GLPROGRAM01)
        {
            IReadOnlyList<KUPC> value;
            if (Index_GLPROGRAM01.Value.TryGetValue(GLPROGRAM01, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KUPC by GLPROGRAM02 field
        /// </summary>
        /// <param name="GLPROGRAM02">GLPROGRAM02 value used to find KUPC</param>
        /// <returns>List of related KUPC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KUPC> FindByGLPROGRAM02(string GLPROGRAM02)
        {
            return Index_GLPROGRAM02.Value[GLPROGRAM02];
        }

        /// <summary>
        /// Attempt to find KUPC by GLPROGRAM02 field
        /// </summary>
        /// <param name="GLPROGRAM02">GLPROGRAM02 value used to find KUPC</param>
        /// <param name="Value">List of related KUPC entities</param>
        /// <returns>True if the list of related KUPC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLPROGRAM02(string GLPROGRAM02, out IReadOnlyList<KUPC> Value)
        {
            return Index_GLPROGRAM02.Value.TryGetValue(GLPROGRAM02, out Value);
        }

        /// <summary>
        /// Attempt to find KUPC by GLPROGRAM02 field
        /// </summary>
        /// <param name="GLPROGRAM02">GLPROGRAM02 value used to find KUPC</param>
        /// <returns>List of related KUPC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KUPC> TryFindByGLPROGRAM02(string GLPROGRAM02)
        {
            IReadOnlyList<KUPC> value;
            if (Index_GLPROGRAM02.Value.TryGetValue(GLPROGRAM02, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KUPC by KUPCKEY field
        /// </summary>
        /// <param name="KUPCKEY">KUPCKEY value used to find KUPC</param>
        /// <returns>Related KUPC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KUPC FindByKUPCKEY(string KUPCKEY)
        {
            return Index_KUPCKEY.Value[KUPCKEY];
        }

        /// <summary>
        /// Attempt to find KUPC by KUPCKEY field
        /// </summary>
        /// <param name="KUPCKEY">KUPCKEY value used to find KUPC</param>
        /// <param name="Value">Related KUPC entity</param>
        /// <returns>True if the related KUPC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKUPCKEY(string KUPCKEY, out KUPC Value)
        {
            return Index_KUPCKEY.Value.TryGetValue(KUPCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KUPC by KUPCKEY field
        /// </summary>
        /// <param name="KUPCKEY">KUPCKEY value used to find KUPC</param>
        /// <returns>Related KUPC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KUPC TryFindByKUPCKEY(string KUPCKEY)
        {
            KUPC value;
            if (Index_KUPCKEY.Value.TryGetValue(KUPCKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KUPC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KUPC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KUPC](
        [KUPCKEY] varchar(10) NOT NULL,
        [GLPROGRAM01] varchar(3) NULL,
        [GLPROGRAM02] varchar(3) NULL,
        [GL_CODE] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KUPC_Index_KUPCKEY] PRIMARY KEY CLUSTERED (
            [KUPCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [KUPC_Index_GL_CODE] ON [dbo].[KUPC]
    (
            [GL_CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [KUPC_Index_GLPROGRAM01] ON [dbo].[KUPC]
    (
            [GLPROGRAM01] ASC
    );
    CREATE NONCLUSTERED INDEX [KUPC_Index_GLPROGRAM02] ON [dbo].[KUPC]
    (
            [GLPROGRAM02] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KUPC]') AND name = N'Index_GL_CODE')
    ALTER INDEX [Index_GL_CODE] ON [dbo].[KUPC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KUPC]') AND name = N'Index_GLPROGRAM01')
    ALTER INDEX [Index_GLPROGRAM01] ON [dbo].[KUPC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KUPC]') AND name = N'Index_GLPROGRAM02')
    ALTER INDEX [Index_GLPROGRAM02] ON [dbo].[KUPC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KUPC]') AND name = N'Index_GL_CODE')
    ALTER INDEX [Index_GL_CODE] ON [dbo].[KUPC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KUPC]') AND name = N'Index_GLPROGRAM01')
    ALTER INDEX [Index_GLPROGRAM01] ON [dbo].[KUPC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[KUPC]') AND name = N'Index_GLPROGRAM02')
    ALTER INDEX [Index_GLPROGRAM02] ON [dbo].[KUPC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KUPC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KUPC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KUPC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KUPCKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KUPCKEY.Add(entity.KUPCKEY);
            }

            builder.AppendLine("DELETE [dbo].[KUPC] WHERE");


            // Index_KUPCKEY
            builder.Append("[KUPCKEY] IN (");
            for (int index = 0; index < Index_KUPCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KUPCKEY
                var parameterKUPCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKUPCKEY);
                command.Parameters.Add(parameterKUPCKEY, SqlDbType.VarChar, 10).Value = Index_KUPCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KUPC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KUPC data set</returns>
        public override EduHubDataSetDataReader<KUPC> GetDataSetDataReader()
        {
            return new KUPCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KUPC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KUPC data set</returns>
        public override EduHubDataSetDataReader<KUPC> GetDataSetDataReader(List<KUPC> Entities)
        {
            return new KUPCDataReader(new EduHubDataSetLoadedReader<KUPC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KUPCDataReader : EduHubDataSetDataReader<KUPC>
        {
            public KUPCDataReader(IEduHubDataSetReader<KUPC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KUPCKEY
                        return Current.KUPCKEY;
                    case 1: // GLPROGRAM01
                        return Current.GLPROGRAM01;
                    case 2: // GLPROGRAM02
                        return Current.GLPROGRAM02;
                    case 3: // GL_CODE
                        return Current.GL_CODE;
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
                    case 1: // GLPROGRAM01
                        return Current.GLPROGRAM01 == null;
                    case 2: // GLPROGRAM02
                        return Current.GLPROGRAM02 == null;
                    case 3: // GL_CODE
                        return Current.GL_CODE == null;
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
                    case 0: // KUPCKEY
                        return "KUPCKEY";
                    case 1: // GLPROGRAM01
                        return "GLPROGRAM01";
                    case 2: // GLPROGRAM02
                        return "GLPROGRAM02";
                    case 3: // GL_CODE
                        return "GL_CODE";
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
                    case "KUPCKEY":
                        return 0;
                    case "GLPROGRAM01":
                        return 1;
                    case "GLPROGRAM02":
                        return 2;
                    case "GL_CODE":
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
