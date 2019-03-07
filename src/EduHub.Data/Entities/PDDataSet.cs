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
    /// Departments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PDDataSet : EduHubDataSet<PD>
    {
        /// <inheritdoc />
        public override string Name { get { return "PD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLBANK = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLBANK));
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GLTAX = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLTAX));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PDKEY = new Lazy<Dictionary<string, PD>>(() => this.ToDictionary(i => i.PDKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PD" /> fields for each CSV column header</returns>
        internal override Action<PD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PDKEY":
                        mapper[i] = (e, v) => e.PDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANK":
                        mapper[i] = (e, v) => e.GLBANK = v;
                        break;
                    case "GLTAX":
                        mapper[i] = (e, v) => e.GLTAX = v;
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
        /// Merges <see cref="PD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PD}"/> of entities</returns>
        internal override IEnumerable<PD> ApplyDeltaEntities(IEnumerable<PD> Entities, List<PD> DeltaEntities)
        {
            HashSet<string> Index_PDKEY = new HashSet<string>(DeltaEntities.Select(i => i.PDKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PDKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PDKEY.Remove(entity.PDKEY);
                            
                            if (entity.PDKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLBANK;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLTAX;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, PD>> Index_PDKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLBANK(string GLBANK)
        {
            return Index_GLBANK.Value[GLBANK];
        }

        /// <summary>
        /// Attempt to find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLBANK(string GLBANK, out IReadOnlyList<PD> Value)
        {
            return Index_GLBANK.Value.TryGetValue(GLBANK, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLBANK(string GLBANK)
        {
            IReadOnlyList<PD> value;
            if (Index_GLBANK.Value.TryGetValue(GLBANK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PD> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PD> value;
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
        /// Find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLTAX(string GLTAX)
        {
            return Index_GLTAX.Value[GLTAX];
        }

        /// <summary>
        /// Attempt to find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLTAX(string GLTAX, out IReadOnlyList<PD> Value)
        {
            return Index_GLTAX.Value.TryGetValue(GLTAX, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLTAX(string GLTAX)
        {
            IReadOnlyList<PD> value;
            if (Index_GLTAX.Value.TryGetValue(GLTAX, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PD> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PD> value;
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
        /// Find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <returns>Related PD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PD FindByPDKEY(string PDKEY)
        {
            return Index_PDKEY.Value[PDKEY];
        }

        /// <summary>
        /// Attempt to find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <param name="Value">Related PD entity</param>
        /// <returns>True if the related PD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPDKEY(string PDKEY, out PD Value)
        {
            return Index_PDKEY.Value.TryGetValue(PDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <returns>Related PD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PD TryFindByPDKEY(string PDKEY)
        {
            PD value;
            if (Index_PDKEY.Value.TryGetValue(PDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PD> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PD> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PD](
        [PDKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [GLCODE] varchar(10) NULL,
        [GLBANK] varchar(10) NULL,
        [GLTAX] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PD_Index_PDKEY] PRIMARY KEY CLUSTERED (
            [PDKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PD_Index_GLBANK] ON [dbo].[PD]
    (
            [GLBANK] ASC
    );
    CREATE NONCLUSTERED INDEX [PD_Index_GLCODE] ON [dbo].[PD]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PD_Index_GLTAX] ON [dbo].[PD]
    (
            [GLTAX] ASC
    );
    CREATE NONCLUSTERED INDEX [PD_Index_INITIATIVE] ON [dbo].[PD]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PD_Index_SUBPROGRAM] ON [dbo].[PD]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_GLBANK')
    ALTER INDEX [Index_GLBANK] ON [dbo].[PD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[PD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_GLTAX')
    ALTER INDEX [Index_GLTAX] ON [dbo].[PD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PD] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PD] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_GLBANK')
    ALTER INDEX [Index_GLBANK] ON [dbo].[PD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[PD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_GLTAX')
    ALTER INDEX [Index_GLTAX] ON [dbo].[PD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PD] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PD]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PD] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_PDKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_PDKEY.Add(entity.PDKEY);
            }

            builder.AppendLine("DELETE [dbo].[PD] WHERE");


            // Index_PDKEY
            builder.Append("[PDKEY] IN (");
            for (int index = 0; index < Index_PDKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PDKEY
                var parameterPDKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPDKEY);
                command.Parameters.Add(parameterPDKEY, SqlDbType.VarChar, 10).Value = Index_PDKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PD data set</returns>
        public override EduHubDataSetDataReader<PD> GetDataSetDataReader()
        {
            return new PDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PD data set</returns>
        public override EduHubDataSetDataReader<PD> GetDataSetDataReader(List<PD> Entities)
        {
            return new PDDataReader(new EduHubDataSetLoadedReader<PD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PDDataReader : EduHubDataSetDataReader<PD>
        {
            public PDDataReader(IEduHubDataSetReader<PD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PDKEY
                        return Current.PDKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // GLCODE
                        return Current.GLCODE;
                    case 3: // GLBANK
                        return Current.GLBANK;
                    case 4: // GLTAX
                        return Current.GLTAX;
                    case 5: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 6: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 7: // INITIATIVE
                        return Current.INITIATIVE;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
                    case 10: // LW_USER
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
                    case 3: // GLBANK
                        return Current.GLBANK == null;
                    case 4: // GLTAX
                        return Current.GLTAX == null;
                    case 5: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 6: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 7: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
                    case 10: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PDKEY
                        return "PDKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // GLCODE
                        return "GLCODE";
                    case 3: // GLBANK
                        return "GLBANK";
                    case 4: // GLTAX
                        return "GLTAX";
                    case 5: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 6: // GLPROGRAM
                        return "GLPROGRAM";
                    case 7: // INITIATIVE
                        return "INITIATIVE";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PDKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "GLCODE":
                        return 2;
                    case "GLBANK":
                        return 3;
                    case "GLTAX":
                        return 4;
                    case "SUBPROGRAM":
                        return 5;
                    case "GLPROGRAM":
                        return 6;
                    case "INITIATIVE":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
