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
    /// Payroll Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PNDataSet : EduHubDataSet<PN>
    {
        /// <inheritdoc />
        public override string Name { get { return "PN"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_DD_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.DD_GLCODE));
            Index_GLBANK = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.GLBANK));
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GLTAX = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.GLTAX));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PNKEY = new Lazy<Dictionary<short, PN>>(() => this.ToDictionary(i => i.PNKEY));
            Index_PPDKEY = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.PPDKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PN>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PN" /> fields for each CSV column header</returns>
        internal override Action<PN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PNKEY":
                        mapper[i] = (e, v) => e.PNKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "FIRSTDATE":
                        mapper[i] = (e, v) => e.FIRSTDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "NEXTDATE":
                        mapper[i] = (e, v) => e.NEXTDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "NO_PAYS":
                        mapper[i] = (e, v) => e.NO_PAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROUNDOFF":
                        mapper[i] = (e, v) => e.ROUNDOFF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "ACN":
                        mapper[i] = (e, v) => e.ACN = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "DD_GLCODE":
                        mapper[i] = (e, v) => e.DD_GLCODE = v;
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
        /// Merges <see cref="PN" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PN" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PN" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PN}"/> of entities</returns>
        internal override IEnumerable<PN> ApplyDeltaEntities(IEnumerable<PN> Entities, List<PN> DeltaEntities)
        {
            HashSet<short> Index_PNKEY = new HashSet<short>(DeltaEntities.Select(i => i.PNKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PNKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PNKEY.Remove(entity.PNKEY);
                            
                            if (entity.PNKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_DD_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_GLBANK;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_GLTAX;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_INITIATIVE;
        private Lazy<Dictionary<short, PN>> Index_PNKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_PPDKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PN>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PN by DD_GLCODE field
        /// </summary>
        /// <param name="DD_GLCODE">DD_GLCODE value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByDD_GLCODE(string DD_GLCODE)
        {
            return Index_DD_GLCODE.Value[DD_GLCODE];
        }

        /// <summary>
        /// Attempt to find PN by DD_GLCODE field
        /// </summary>
        /// <param name="DD_GLCODE">DD_GLCODE value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDD_GLCODE(string DD_GLCODE, out IReadOnlyList<PN> Value)
        {
            return Index_DD_GLCODE.Value.TryGetValue(DD_GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PN by DD_GLCODE field
        /// </summary>
        /// <param name="DD_GLCODE">DD_GLCODE value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByDD_GLCODE(string DD_GLCODE)
        {
            IReadOnlyList<PN> value;
            if (Index_DD_GLCODE.Value.TryGetValue(DD_GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByGLBANK(string GLBANK)
        {
            return Index_GLBANK.Value[GLBANK];
        }

        /// <summary>
        /// Attempt to find PN by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLBANK(string GLBANK, out IReadOnlyList<PN> Value)
        {
            return Index_GLBANK.Value.TryGetValue(GLBANK, out Value);
        }

        /// <summary>
        /// Attempt to find PN by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByGLBANK(string GLBANK)
        {
            IReadOnlyList<PN> value;
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
        /// Find PN by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PN by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PN> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PN by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PN> value;
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
        /// Find PN by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByGLTAX(string GLTAX)
        {
            return Index_GLTAX.Value[GLTAX];
        }

        /// <summary>
        /// Attempt to find PN by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLTAX(string GLTAX, out IReadOnlyList<PN> Value)
        {
            return Index_GLTAX.Value.TryGetValue(GLTAX, out Value);
        }

        /// <summary>
        /// Attempt to find PN by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByGLTAX(string GLTAX)
        {
            IReadOnlyList<PN> value;
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
        /// Find PN by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PN by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PN> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PN by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PN> value;
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
        /// Find PN by PNKEY field
        /// </summary>
        /// <param name="PNKEY">PNKEY value used to find PN</param>
        /// <returns>Related PN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PN FindByPNKEY(short PNKEY)
        {
            return Index_PNKEY.Value[PNKEY];
        }

        /// <summary>
        /// Attempt to find PN by PNKEY field
        /// </summary>
        /// <param name="PNKEY">PNKEY value used to find PN</param>
        /// <param name="Value">Related PN entity</param>
        /// <returns>True if the related PN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPNKEY(short PNKEY, out PN Value)
        {
            return Index_PNKEY.Value.TryGetValue(PNKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PN by PNKEY field
        /// </summary>
        /// <param name="PNKEY">PNKEY value used to find PN</param>
        /// <returns>Related PN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PN TryFindByPNKEY(short PNKEY)
        {
            PN value;
            if (Index_PNKEY.Value.TryGetValue(PNKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find PN by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out IReadOnlyList<PN> Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PN by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindByPPDKEY(string PPDKEY)
        {
            IReadOnlyList<PN> value;
            if (Index_PPDKEY.Value.TryGetValue(PPDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PN by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PN</param>
        /// <returns>List of related PN entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PN by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PN</param>
        /// <param name="Value">List of related PN entities</param>
        /// <returns>True if the list of related PN entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PN> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PN by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PN</param>
        /// <returns>List of related PN entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PN> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PN> value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PN table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PN](
        [PNKEY] smallint NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [TRANSTYPE] varchar(1) NULL,
        [FIRSTDATE] datetime NULL,
        [NEXTDATE] datetime NULL,
        [NO_PAYS] smallint NULL,
        [ROUNDOFF] money NULL,
        [PPDKEY] varchar(10) NULL,
        [PAY_TYPE] varchar(1) NULL,
        [ACN] varchar(12) NULL,
        [ABN] varchar(16) NULL,
        [DD_GLCODE] varchar(10) NULL,
        [GLCODE] varchar(10) NULL,
        [GLBANK] varchar(10) NULL,
        [GLTAX] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PN_Index_PNKEY] PRIMARY KEY CLUSTERED (
            [PNKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [PN_Index_DD_GLCODE] ON [dbo].[PN]
    (
            [DD_GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PN_Index_GLBANK] ON [dbo].[PN]
    (
            [GLBANK] ASC
    );
    CREATE NONCLUSTERED INDEX [PN_Index_GLCODE] ON [dbo].[PN]
    (
            [GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PN_Index_GLTAX] ON [dbo].[PN]
    (
            [GLTAX] ASC
    );
    CREATE NONCLUSTERED INDEX [PN_Index_INITIATIVE] ON [dbo].[PN]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PN_Index_PPDKEY] ON [dbo].[PN]
    (
            [PPDKEY] ASC
    );
    CREATE NONCLUSTERED INDEX [PN_Index_SUBPROGRAM] ON [dbo].[PN]
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_DD_GLCODE')
    ALTER INDEX [Index_DD_GLCODE] ON [dbo].[PN] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_GLBANK')
    ALTER INDEX [Index_GLBANK] ON [dbo].[PN] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[PN] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_GLTAX')
    ALTER INDEX [Index_GLTAX] ON [dbo].[PN] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PN] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_PPDKEY')
    ALTER INDEX [Index_PPDKEY] ON [dbo].[PN] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PN] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_DD_GLCODE')
    ALTER INDEX [Index_DD_GLCODE] ON [dbo].[PN] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_GLBANK')
    ALTER INDEX [Index_GLBANK] ON [dbo].[PN] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_GLCODE')
    ALTER INDEX [Index_GLCODE] ON [dbo].[PN] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_GLTAX')
    ALTER INDEX [Index_GLTAX] ON [dbo].[PN] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PN] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_PPDKEY')
    ALTER INDEX [Index_PPDKEY] ON [dbo].[PN] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PN]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PN] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PN"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PN"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PN> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short> Index_PNKEY = new List<short>();

            foreach (var entity in Entities)
            {
                Index_PNKEY.Add(entity.PNKEY);
            }

            builder.AppendLine("DELETE [dbo].[PN] WHERE");


            // Index_PNKEY
            builder.Append("[PNKEY] IN (");
            for (int index = 0; index < Index_PNKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PNKEY
                var parameterPNKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPNKEY);
                command.Parameters.Add(parameterPNKEY, SqlDbType.SmallInt).Value = Index_PNKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PN data set</returns>
        public override EduHubDataSetDataReader<PN> GetDataSetDataReader()
        {
            return new PNDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PN data set</returns>
        public override EduHubDataSetDataReader<PN> GetDataSetDataReader(List<PN> Entities)
        {
            return new PNDataReader(new EduHubDataSetLoadedReader<PN>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PNDataReader : EduHubDataSetDataReader<PN>
        {
            public PNDataReader(IEduHubDataSetReader<PN> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 21; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PNKEY
                        return Current.PNKEY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // TRANSTYPE
                        return Current.TRANSTYPE;
                    case 3: // FIRSTDATE
                        return Current.FIRSTDATE;
                    case 4: // NEXTDATE
                        return Current.NEXTDATE;
                    case 5: // NO_PAYS
                        return Current.NO_PAYS;
                    case 6: // ROUNDOFF
                        return Current.ROUNDOFF;
                    case 7: // PPDKEY
                        return Current.PPDKEY;
                    case 8: // PAY_TYPE
                        return Current.PAY_TYPE;
                    case 9: // ACN
                        return Current.ACN;
                    case 10: // ABN
                        return Current.ABN;
                    case 11: // DD_GLCODE
                        return Current.DD_GLCODE;
                    case 12: // GLCODE
                        return Current.GLCODE;
                    case 13: // GLBANK
                        return Current.GLBANK;
                    case 14: // GLTAX
                        return Current.GLTAX;
                    case 15: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 16: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 17: // INITIATIVE
                        return Current.INITIATIVE;
                    case 18: // LW_DATE
                        return Current.LW_DATE;
                    case 19: // LW_TIME
                        return Current.LW_TIME;
                    case 20: // LW_USER
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
                    case 2: // TRANSTYPE
                        return Current.TRANSTYPE == null;
                    case 3: // FIRSTDATE
                        return Current.FIRSTDATE == null;
                    case 4: // NEXTDATE
                        return Current.NEXTDATE == null;
                    case 5: // NO_PAYS
                        return Current.NO_PAYS == null;
                    case 6: // ROUNDOFF
                        return Current.ROUNDOFF == null;
                    case 7: // PPDKEY
                        return Current.PPDKEY == null;
                    case 8: // PAY_TYPE
                        return Current.PAY_TYPE == null;
                    case 9: // ACN
                        return Current.ACN == null;
                    case 10: // ABN
                        return Current.ABN == null;
                    case 11: // DD_GLCODE
                        return Current.DD_GLCODE == null;
                    case 12: // GLCODE
                        return Current.GLCODE == null;
                    case 13: // GLBANK
                        return Current.GLBANK == null;
                    case 14: // GLTAX
                        return Current.GLTAX == null;
                    case 15: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 16: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 17: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 18: // LW_DATE
                        return Current.LW_DATE == null;
                    case 19: // LW_TIME
                        return Current.LW_TIME == null;
                    case 20: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PNKEY
                        return "PNKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // TRANSTYPE
                        return "TRANSTYPE";
                    case 3: // FIRSTDATE
                        return "FIRSTDATE";
                    case 4: // NEXTDATE
                        return "NEXTDATE";
                    case 5: // NO_PAYS
                        return "NO_PAYS";
                    case 6: // ROUNDOFF
                        return "ROUNDOFF";
                    case 7: // PPDKEY
                        return "PPDKEY";
                    case 8: // PAY_TYPE
                        return "PAY_TYPE";
                    case 9: // ACN
                        return "ACN";
                    case 10: // ABN
                        return "ABN";
                    case 11: // DD_GLCODE
                        return "DD_GLCODE";
                    case 12: // GLCODE
                        return "GLCODE";
                    case 13: // GLBANK
                        return "GLBANK";
                    case 14: // GLTAX
                        return "GLTAX";
                    case 15: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 16: // GLPROGRAM
                        return "GLPROGRAM";
                    case 17: // INITIATIVE
                        return "INITIATIVE";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PNKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "TRANSTYPE":
                        return 2;
                    case "FIRSTDATE":
                        return 3;
                    case "NEXTDATE":
                        return 4;
                    case "NO_PAYS":
                        return 5;
                    case "ROUNDOFF":
                        return 6;
                    case "PPDKEY":
                        return 7;
                    case "PAY_TYPE":
                        return 8;
                    case "ACN":
                        return 9;
                    case "ABN":
                        return 10;
                    case "DD_GLCODE":
                        return 11;
                    case "GLCODE":
                        return 12;
                    case "GLBANK":
                        return 13;
                    case "GLTAX":
                        return 14;
                    case "SUBPROGRAM":
                        return 15;
                    case "GLPROGRAM":
                        return 16;
                    case "INITIATIVE":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
