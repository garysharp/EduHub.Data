using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Groups Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PNDataSet : EduHubDataSet<PN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PN"; } }

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
        protected override Action<PN, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
                        mapper[i] = (e, v) => e.FIRSTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NEXTDATE":
                        mapper[i] = (e, v) => e.NEXTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// <param name="Items">Base <see cref="PN" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PN" /> items to added or update the base <see cref="PN" /> items</param>
        /// <returns>A merged list of <see cref="PN" /> items</returns>
        protected override List<PN> ApplyDeltaItems(List<PN> Items, List<PN> DeltaItems)
        {
            Dictionary<short, int> Index_PNKEY = Items.ToIndexDictionary(i => i.PNKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PN deltaItem in DeltaItems)
            {
                int index;

                if (Index_PNKEY.TryGetValue(deltaItem.PNKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PNKEY)
                .ToList();
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
        /// Returns SQL which checks for the existence of a PN table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
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
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PN data set</returns>
        public override IDataReader GetDataReader()
        {
            return new PNDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PNDataReader : IDataReader, IDataRecord
        {
            private List<PN> Items;
            private int CurrentIndex;
            private PN CurrentItem;

            public PNDataReader(List<PN> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 21; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PNKEY
                        return CurrentItem.PNKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // TRANSTYPE
                        return CurrentItem.TRANSTYPE;
                    case 3: // FIRSTDATE
                        return CurrentItem.FIRSTDATE;
                    case 4: // NEXTDATE
                        return CurrentItem.NEXTDATE;
                    case 5: // NO_PAYS
                        return CurrentItem.NO_PAYS;
                    case 6: // ROUNDOFF
                        return CurrentItem.ROUNDOFF;
                    case 7: // PPDKEY
                        return CurrentItem.PPDKEY;
                    case 8: // PAY_TYPE
                        return CurrentItem.PAY_TYPE;
                    case 9: // ACN
                        return CurrentItem.ACN;
                    case 10: // ABN
                        return CurrentItem.ABN;
                    case 11: // DD_GLCODE
                        return CurrentItem.DD_GLCODE;
                    case 12: // GLCODE
                        return CurrentItem.GLCODE;
                    case 13: // GLBANK
                        return CurrentItem.GLBANK;
                    case 14: // GLTAX
                        return CurrentItem.GLTAX;
                    case 15: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 16: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 17: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 20: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // TRANSTYPE
                        return CurrentItem.TRANSTYPE == null;
                    case 3: // FIRSTDATE
                        return CurrentItem.FIRSTDATE == null;
                    case 4: // NEXTDATE
                        return CurrentItem.NEXTDATE == null;
                    case 5: // NO_PAYS
                        return CurrentItem.NO_PAYS == null;
                    case 6: // ROUNDOFF
                        return CurrentItem.ROUNDOFF == null;
                    case 7: // PPDKEY
                        return CurrentItem.PPDKEY == null;
                    case 8: // PAY_TYPE
                        return CurrentItem.PAY_TYPE == null;
                    case 9: // ACN
                        return CurrentItem.ACN == null;
                    case 10: // ABN
                        return CurrentItem.ABN == null;
                    case 11: // DD_GLCODE
                        return CurrentItem.DD_GLCODE == null;
                    case 12: // GLCODE
                        return CurrentItem.GLCODE == null;
                    case 13: // GLBANK
                        return CurrentItem.GLBANK == null;
                    case 14: // GLTAX
                        return CurrentItem.GLTAX == null;
                    case 15: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 16: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 17: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 18: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 19: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 20: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
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

            public int GetOrdinal(string name)
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

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
