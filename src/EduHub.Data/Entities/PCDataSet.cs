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
    /// Cost Centres Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PCDataSet : EduHubDataSet<PC>
    {
        /// <inheritdoc />
        public override string Name { get { return "PC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PCKEY = new Lazy<Dictionary<string, PC>>(() => this.ToDictionary(i => i.PCKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PC" /> fields for each CSV column header</returns>
        internal override Action<PC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PCKEY":
                        mapper[i] = (e, v) => e.PCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
        /// Merges <see cref="PC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PC}"/> of entities</returns>
        internal override IEnumerable<PC> ApplyDeltaEntities(IEnumerable<PC> Entities, List<PC> DeltaEntities)
        {
            HashSet<string> Index_PCKEY = new HashSet<string>(DeltaEntities.Select(i => i.PCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PCKEY.Remove(entity.PCKEY);
                            
                            if (entity.PCKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, PC>> Index_PCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PC> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PC> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PC> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PC> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <returns>Related PC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PC FindByPCKEY(string PCKEY)
        {
            return Index_PCKEY.Value[PCKEY];
        }

        /// <summary>
        /// Attempt to find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <param name="Value">Related PC entity</param>
        /// <returns>True if the related PC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPCKEY(string PCKEY, out PC Value)
        {
            return Index_PCKEY.Value.TryGetValue(PCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <returns>Related PC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PC TryFindByPCKEY(string PCKEY)
        {
            PC value;
            if (Index_PCKEY.Value.TryGetValue(PCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PC> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PC> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PC](
        [PCKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PC_Index_PCKEY] PRIMARY KEY CLUSTERED (
            [PCKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PC_Index_GLCODE] ON [dbo].[PC]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PC_Index_INITIATIVE] ON [dbo].[PC]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PC_Index_SUBPROGRAM] ON [dbo].[PC]
    (
            [SUBPROGRAM] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PC]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[PC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PC]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PC]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PC] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PC]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[PC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PC]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PC]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_PCKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_PCKEY.Add(entity.PCKEY);
            }

            builder.AppendLine("DELETE [dbo].[PC] WHERE");


            // Index_PCKEY
            builder.Append("[PCKEY] IN (");
            for (int index = 0; index < Index_PCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PCKEY
                var parameterPCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPCKEY);
                command.Parameters.Add(parameterPCKEY, SqlDbType.VarChar, 10).Value = Index_PCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PC data set</returns>
        public override EduHubDataSetDataReader<PC> GetDataSetDataReader()
        {
            return new PCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PC data set</returns>
        public override EduHubDataSetDataReader<PC> GetDataSetDataReader(List<PC> Entities)
        {
            return new PCDataReader(new EduHubDataSetLoadedReader<PC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PCDataReader : EduHubDataSetDataReader<PC>
        {
            public PCDataReader(IEduHubDataSetReader<PC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PCKEY
                        return Current.PCKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // GLCODE
                        return Current.GLCODE;
                    case 3: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 4: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 5: // INITIATIVE
                        return Current.INITIATIVE;
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
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // GLCODE
                        return Current.GLCODE == null;
                    case 3: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 4: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 5: // INITIATIVE
                        return Current.INITIATIVE == null;
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
                    case 0: // PCKEY
                        return "PCKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // GLCODE
                        return "GLCODE";
                    case 3: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 4: // GLPROGRAM
                        return "GLPROGRAM";
                    case 5: // INITIATIVE
                        return "INITIATIVE";
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
                    case "PCKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "GLCODE":
                        return 2;
                    case "SUBPROGRAM":
                        return 3;
                    case "GLPROGRAM":
                        return 4;
                    case "INITIATIVE":
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
