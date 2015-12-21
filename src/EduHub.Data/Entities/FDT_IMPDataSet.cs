using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FDT Financial Raw Import Table Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FDT_IMPDataSet : EduHubDataSet<FDT_IMP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FDT_IMP"; } }

        internal FDT_IMPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FDTKEY = new Lazy<Dictionary<int, FDT_IMP>>(() => this.ToDictionary(i => i.FDTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FDT_IMP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FDT_IMP" /> fields for each CSV column header</returns>
        protected override Action<FDT_IMP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FDT_IMP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "FDTKEY":
                        mapper[i] = (e, v) => e.FDTKEY = int.Parse(v);
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "SOURCE_TABLE":
                        mapper[i] = (e, v) => e.SOURCE_TABLE = v;
                        break;
                    case "FIELD01":
                        mapper[i] = (e, v) => e.FIELD01 = v;
                        break;
                    case "FIELD02":
                        mapper[i] = (e, v) => e.FIELD02 = v;
                        break;
                    case "FIELD03":
                        mapper[i] = (e, v) => e.FIELD03 = v;
                        break;
                    case "FIELD04":
                        mapper[i] = (e, v) => e.FIELD04 = v;
                        break;
                    case "FIELD05":
                        mapper[i] = (e, v) => e.FIELD05 = v;
                        break;
                    case "FIELD06":
                        mapper[i] = (e, v) => e.FIELD06 = v;
                        break;
                    case "FIELD07":
                        mapper[i] = (e, v) => e.FIELD07 = v;
                        break;
                    case "FIELD08":
                        mapper[i] = (e, v) => e.FIELD08 = v;
                        break;
                    case "FIELD09":
                        mapper[i] = (e, v) => e.FIELD09 = v;
                        break;
                    case "FIELD10":
                        mapper[i] = (e, v) => e.FIELD10 = v;
                        break;
                    case "FIELD11":
                        mapper[i] = (e, v) => e.FIELD11 = v;
                        break;
                    case "FIELD12":
                        mapper[i] = (e, v) => e.FIELD12 = v;
                        break;
                    case "FIELD13":
                        mapper[i] = (e, v) => e.FIELD13 = v;
                        break;
                    case "FIELD14":
                        mapper[i] = (e, v) => e.FIELD14 = v;
                        break;
                    case "FIELD15":
                        mapper[i] = (e, v) => e.FIELD15 = v;
                        break;
                    case "FIELD16":
                        mapper[i] = (e, v) => e.FIELD16 = v;
                        break;
                    case "FIELD17":
                        mapper[i] = (e, v) => e.FIELD17 = v;
                        break;
                    case "FIELD18":
                        mapper[i] = (e, v) => e.FIELD18 = v;
                        break;
                    case "FIELD19":
                        mapper[i] = (e, v) => e.FIELD19 = v;
                        break;
                    case "FIELD20":
                        mapper[i] = (e, v) => e.FIELD20 = v;
                        break;
                    case "FIELD21":
                        mapper[i] = (e, v) => e.FIELD21 = v;
                        break;
                    case "FIELD22":
                        mapper[i] = (e, v) => e.FIELD22 = v;
                        break;
                    case "FIELD23":
                        mapper[i] = (e, v) => e.FIELD23 = v;
                        break;
                    case "FIELD24":
                        mapper[i] = (e, v) => e.FIELD24 = v;
                        break;
                    case "FIELD25":
                        mapper[i] = (e, v) => e.FIELD25 = v;
                        break;
                    case "FIELD26":
                        mapper[i] = (e, v) => e.FIELD26 = v;
                        break;
                    case "FIELD27":
                        mapper[i] = (e, v) => e.FIELD27 = v;
                        break;
                    case "FIELD28":
                        mapper[i] = (e, v) => e.FIELD28 = v;
                        break;
                    case "FIELD29":
                        mapper[i] = (e, v) => e.FIELD29 = v;
                        break;
                    case "FIELD30":
                        mapper[i] = (e, v) => e.FIELD30 = v;
                        break;
                    case "FIELD31":
                        mapper[i] = (e, v) => e.FIELD31 = v;
                        break;
                    case "FIELD32":
                        mapper[i] = (e, v) => e.FIELD32 = v;
                        break;
                    case "FIELD33":
                        mapper[i] = (e, v) => e.FIELD33 = v;
                        break;
                    case "FIELD34":
                        mapper[i] = (e, v) => e.FIELD34 = v;
                        break;
                    case "FIELD35":
                        mapper[i] = (e, v) => e.FIELD35 = v;
                        break;
                    case "FIELD36":
                        mapper[i] = (e, v) => e.FIELD36 = v;
                        break;
                    case "FIELD37":
                        mapper[i] = (e, v) => e.FIELD37 = v;
                        break;
                    case "FIELD38":
                        mapper[i] = (e, v) => e.FIELD38 = v;
                        break;
                    case "FIELD39":
                        mapper[i] = (e, v) => e.FIELD39 = v;
                        break;
                    case "FIELD40":
                        mapper[i] = (e, v) => e.FIELD40 = v;
                        break;
                    case "FIELD41":
                        mapper[i] = (e, v) => e.FIELD41 = v;
                        break;
                    case "FIELD42":
                        mapper[i] = (e, v) => e.FIELD42 = v;
                        break;
                    case "FIELD43":
                        mapper[i] = (e, v) => e.FIELD43 = v;
                        break;
                    case "FIELD44":
                        mapper[i] = (e, v) => e.FIELD44 = v;
                        break;
                    case "FIELD45":
                        mapper[i] = (e, v) => e.FIELD45 = v;
                        break;
                    case "FIELD46":
                        mapper[i] = (e, v) => e.FIELD46 = v;
                        break;
                    case "FIELD47":
                        mapper[i] = (e, v) => e.FIELD47 = v;
                        break;
                    case "FIELD48":
                        mapper[i] = (e, v) => e.FIELD48 = v;
                        break;
                    case "FIELD49":
                        mapper[i] = (e, v) => e.FIELD49 = v;
                        break;
                    case "NOTES01":
                        mapper[i] = (e, v) => e.NOTES01 = v;
                        break;
                    case "NOTES02":
                        mapper[i] = (e, v) => e.NOTES02 = v;
                        break;
                    case "NOTES03":
                        mapper[i] = (e, v) => e.NOTES03 = v;
                        break;
                    case "NOTES04":
                        mapper[i] = (e, v) => e.NOTES04 = v;
                        break;
                    case "ITEM_PIC":
                        mapper[i] = (e, v) => e.ITEM_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "FDT_SOURCE":
                        mapper[i] = (e, v) => e.FDT_SOURCE = v;
                        break;
                    case "FDT_DEST":
                        mapper[i] = (e, v) => e.FDT_DEST = v;
                        break;
                    case "FDT_DEST_ID":
                        mapper[i] = (e, v) => e.FDT_DEST_ID = v;
                        break;
                    case "FDT_EXP_DATE":
                        mapper[i] = (e, v) => e.FDT_EXP_DATE = v;
                        break;
                    case "FDT_EXP_TIME":
                        mapper[i] = (e, v) => e.FDT_EXP_TIME = v;
                        break;
                    case "FDT_COMMENT":
                        mapper[i] = (e, v) => e.FDT_COMMENT = v;
                        break;
                    case "CURRENT_VER":
                        mapper[i] = (e, v) => e.CURRENT_VER = v;
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
        /// Merges <see cref="FDT_IMP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="FDT_IMP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="FDT_IMP" /> items to added or update the base <see cref="FDT_IMP" /> items</param>
        /// <returns>A merged list of <see cref="FDT_IMP" /> items</returns>
        protected override List<FDT_IMP> ApplyDeltaItems(List<FDT_IMP> Items, List<FDT_IMP> DeltaItems)
        {
            Dictionary<int, int> Index_FDTKEY = Items.ToIndexDictionary(i => i.FDTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (FDT_IMP deltaItem in DeltaItems)
            {
                int index;

                if (Index_FDTKEY.TryGetValue(deltaItem.FDTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.FDTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, FDT_IMP>> Index_FDTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find FDT_IMP by FDTKEY field
        /// </summary>
        /// <param name="FDTKEY">FDTKEY value used to find FDT_IMP</param>
        /// <returns>Related FDT_IMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FDT_IMP FindByFDTKEY(int FDTKEY)
        {
            return Index_FDTKEY.Value[FDTKEY];
        }

        /// <summary>
        /// Attempt to find FDT_IMP by FDTKEY field
        /// </summary>
        /// <param name="FDTKEY">FDTKEY value used to find FDT_IMP</param>
        /// <param name="Value">Related FDT_IMP entity</param>
        /// <returns>True if the related FDT_IMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFDTKEY(int FDTKEY, out FDT_IMP Value)
        {
            return Index_FDTKEY.Value.TryGetValue(FDTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_IMP by FDTKEY field
        /// </summary>
        /// <param name="FDTKEY">FDTKEY value used to find FDT_IMP</param>
        /// <returns>Related FDT_IMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FDT_IMP TryFindByFDTKEY(int FDTKEY)
        {
            FDT_IMP value;
            if (Index_FDTKEY.Value.TryGetValue(FDTKEY, out value))
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
        /// Returns SQL which checks for the existence of a FDT_IMP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FDT_IMP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[FDT_IMP](
        [FDTKEY] int IDENTITY NOT NULL,
        [SOURCE] varchar(8) NULL,
        [SOURCE_TABLE] varchar(8) NULL,
        [FIELD01] varchar(60) NULL,
        [FIELD02] varchar(60) NULL,
        [FIELD03] varchar(60) NULL,
        [FIELD04] varchar(60) NULL,
        [FIELD05] varchar(60) NULL,
        [FIELD06] varchar(60) NULL,
        [FIELD07] varchar(60) NULL,
        [FIELD08] varchar(60) NULL,
        [FIELD09] varchar(60) NULL,
        [FIELD10] varchar(60) NULL,
        [FIELD11] varchar(60) NULL,
        [FIELD12] varchar(60) NULL,
        [FIELD13] varchar(60) NULL,
        [FIELD14] varchar(60) NULL,
        [FIELD15] varchar(60) NULL,
        [FIELD16] varchar(60) NULL,
        [FIELD17] varchar(60) NULL,
        [FIELD18] varchar(60) NULL,
        [FIELD19] varchar(60) NULL,
        [FIELD20] varchar(60) NULL,
        [FIELD21] varchar(60) NULL,
        [FIELD22] varchar(60) NULL,
        [FIELD23] varchar(60) NULL,
        [FIELD24] varchar(60) NULL,
        [FIELD25] varchar(60) NULL,
        [FIELD26] varchar(60) NULL,
        [FIELD27] varchar(60) NULL,
        [FIELD28] varchar(60) NULL,
        [FIELD29] varchar(60) NULL,
        [FIELD30] varchar(60) NULL,
        [FIELD31] varchar(60) NULL,
        [FIELD32] varchar(60) NULL,
        [FIELD33] varchar(60) NULL,
        [FIELD34] varchar(60) NULL,
        [FIELD35] varchar(60) NULL,
        [FIELD36] varchar(60) NULL,
        [FIELD37] varchar(60) NULL,
        [FIELD38] varchar(60) NULL,
        [FIELD39] varchar(60) NULL,
        [FIELD40] varchar(60) NULL,
        [FIELD41] varchar(60) NULL,
        [FIELD42] varchar(60) NULL,
        [FIELD43] varchar(60) NULL,
        [FIELD44] varchar(60) NULL,
        [FIELD45] varchar(60) NULL,
        [FIELD46] varchar(60) NULL,
        [FIELD47] varchar(60) NULL,
        [FIELD48] varchar(60) NULL,
        [FIELD49] varchar(60) NULL,
        [NOTES01] text NULL,
        [NOTES02] text NULL,
        [NOTES03] text NULL,
        [NOTES04] text NULL,
        [ITEM_PIC] image NULL,
        [FDT_SOURCE] varchar(8) NULL,
        [FDT_DEST] varchar(8) NULL,
        [FDT_DEST_ID] varchar(8) NULL,
        [FDT_EXP_DATE] varchar(20) NULL,
        [FDT_EXP_TIME] varchar(8) NULL,
        [FDT_COMMENT] text NULL,
        [CURRENT_VER] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [FDT_IMP_Index_FDTKEY] PRIMARY KEY CLUSTERED (
            [FDTKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the FDT_IMP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the FDT_IMP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new FDT_IMPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class FDT_IMPDataReader : IDataReader, IDataRecord
        {
            private List<FDT_IMP> Items;
            private int CurrentIndex;
            private FDT_IMP CurrentItem;

            public FDT_IMPDataReader(List<FDT_IMP> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 67; } }
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
                    case 0: // FDTKEY
                        return CurrentItem.FDTKEY;
                    case 1: // SOURCE
                        return CurrentItem.SOURCE;
                    case 2: // SOURCE_TABLE
                        return CurrentItem.SOURCE_TABLE;
                    case 3: // FIELD01
                        return CurrentItem.FIELD01;
                    case 4: // FIELD02
                        return CurrentItem.FIELD02;
                    case 5: // FIELD03
                        return CurrentItem.FIELD03;
                    case 6: // FIELD04
                        return CurrentItem.FIELD04;
                    case 7: // FIELD05
                        return CurrentItem.FIELD05;
                    case 8: // FIELD06
                        return CurrentItem.FIELD06;
                    case 9: // FIELD07
                        return CurrentItem.FIELD07;
                    case 10: // FIELD08
                        return CurrentItem.FIELD08;
                    case 11: // FIELD09
                        return CurrentItem.FIELD09;
                    case 12: // FIELD10
                        return CurrentItem.FIELD10;
                    case 13: // FIELD11
                        return CurrentItem.FIELD11;
                    case 14: // FIELD12
                        return CurrentItem.FIELD12;
                    case 15: // FIELD13
                        return CurrentItem.FIELD13;
                    case 16: // FIELD14
                        return CurrentItem.FIELD14;
                    case 17: // FIELD15
                        return CurrentItem.FIELD15;
                    case 18: // FIELD16
                        return CurrentItem.FIELD16;
                    case 19: // FIELD17
                        return CurrentItem.FIELD17;
                    case 20: // FIELD18
                        return CurrentItem.FIELD18;
                    case 21: // FIELD19
                        return CurrentItem.FIELD19;
                    case 22: // FIELD20
                        return CurrentItem.FIELD20;
                    case 23: // FIELD21
                        return CurrentItem.FIELD21;
                    case 24: // FIELD22
                        return CurrentItem.FIELD22;
                    case 25: // FIELD23
                        return CurrentItem.FIELD23;
                    case 26: // FIELD24
                        return CurrentItem.FIELD24;
                    case 27: // FIELD25
                        return CurrentItem.FIELD25;
                    case 28: // FIELD26
                        return CurrentItem.FIELD26;
                    case 29: // FIELD27
                        return CurrentItem.FIELD27;
                    case 30: // FIELD28
                        return CurrentItem.FIELD28;
                    case 31: // FIELD29
                        return CurrentItem.FIELD29;
                    case 32: // FIELD30
                        return CurrentItem.FIELD30;
                    case 33: // FIELD31
                        return CurrentItem.FIELD31;
                    case 34: // FIELD32
                        return CurrentItem.FIELD32;
                    case 35: // FIELD33
                        return CurrentItem.FIELD33;
                    case 36: // FIELD34
                        return CurrentItem.FIELD34;
                    case 37: // FIELD35
                        return CurrentItem.FIELD35;
                    case 38: // FIELD36
                        return CurrentItem.FIELD36;
                    case 39: // FIELD37
                        return CurrentItem.FIELD37;
                    case 40: // FIELD38
                        return CurrentItem.FIELD38;
                    case 41: // FIELD39
                        return CurrentItem.FIELD39;
                    case 42: // FIELD40
                        return CurrentItem.FIELD40;
                    case 43: // FIELD41
                        return CurrentItem.FIELD41;
                    case 44: // FIELD42
                        return CurrentItem.FIELD42;
                    case 45: // FIELD43
                        return CurrentItem.FIELD43;
                    case 46: // FIELD44
                        return CurrentItem.FIELD44;
                    case 47: // FIELD45
                        return CurrentItem.FIELD45;
                    case 48: // FIELD46
                        return CurrentItem.FIELD46;
                    case 49: // FIELD47
                        return CurrentItem.FIELD47;
                    case 50: // FIELD48
                        return CurrentItem.FIELD48;
                    case 51: // FIELD49
                        return CurrentItem.FIELD49;
                    case 52: // NOTES01
                        return CurrentItem.NOTES01;
                    case 53: // NOTES02
                        return CurrentItem.NOTES02;
                    case 54: // NOTES03
                        return CurrentItem.NOTES03;
                    case 55: // NOTES04
                        return CurrentItem.NOTES04;
                    case 56: // ITEM_PIC
                        return CurrentItem.ITEM_PIC;
                    case 57: // FDT_SOURCE
                        return CurrentItem.FDT_SOURCE;
                    case 58: // FDT_DEST
                        return CurrentItem.FDT_DEST;
                    case 59: // FDT_DEST_ID
                        return CurrentItem.FDT_DEST_ID;
                    case 60: // FDT_EXP_DATE
                        return CurrentItem.FDT_EXP_DATE;
                    case 61: // FDT_EXP_TIME
                        return CurrentItem.FDT_EXP_TIME;
                    case 62: // FDT_COMMENT
                        return CurrentItem.FDT_COMMENT;
                    case 63: // CURRENT_VER
                        return CurrentItem.CURRENT_VER;
                    case 64: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 65: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 66: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SOURCE
                        return CurrentItem.SOURCE == null;
                    case 2: // SOURCE_TABLE
                        return CurrentItem.SOURCE_TABLE == null;
                    case 3: // FIELD01
                        return CurrentItem.FIELD01 == null;
                    case 4: // FIELD02
                        return CurrentItem.FIELD02 == null;
                    case 5: // FIELD03
                        return CurrentItem.FIELD03 == null;
                    case 6: // FIELD04
                        return CurrentItem.FIELD04 == null;
                    case 7: // FIELD05
                        return CurrentItem.FIELD05 == null;
                    case 8: // FIELD06
                        return CurrentItem.FIELD06 == null;
                    case 9: // FIELD07
                        return CurrentItem.FIELD07 == null;
                    case 10: // FIELD08
                        return CurrentItem.FIELD08 == null;
                    case 11: // FIELD09
                        return CurrentItem.FIELD09 == null;
                    case 12: // FIELD10
                        return CurrentItem.FIELD10 == null;
                    case 13: // FIELD11
                        return CurrentItem.FIELD11 == null;
                    case 14: // FIELD12
                        return CurrentItem.FIELD12 == null;
                    case 15: // FIELD13
                        return CurrentItem.FIELD13 == null;
                    case 16: // FIELD14
                        return CurrentItem.FIELD14 == null;
                    case 17: // FIELD15
                        return CurrentItem.FIELD15 == null;
                    case 18: // FIELD16
                        return CurrentItem.FIELD16 == null;
                    case 19: // FIELD17
                        return CurrentItem.FIELD17 == null;
                    case 20: // FIELD18
                        return CurrentItem.FIELD18 == null;
                    case 21: // FIELD19
                        return CurrentItem.FIELD19 == null;
                    case 22: // FIELD20
                        return CurrentItem.FIELD20 == null;
                    case 23: // FIELD21
                        return CurrentItem.FIELD21 == null;
                    case 24: // FIELD22
                        return CurrentItem.FIELD22 == null;
                    case 25: // FIELD23
                        return CurrentItem.FIELD23 == null;
                    case 26: // FIELD24
                        return CurrentItem.FIELD24 == null;
                    case 27: // FIELD25
                        return CurrentItem.FIELD25 == null;
                    case 28: // FIELD26
                        return CurrentItem.FIELD26 == null;
                    case 29: // FIELD27
                        return CurrentItem.FIELD27 == null;
                    case 30: // FIELD28
                        return CurrentItem.FIELD28 == null;
                    case 31: // FIELD29
                        return CurrentItem.FIELD29 == null;
                    case 32: // FIELD30
                        return CurrentItem.FIELD30 == null;
                    case 33: // FIELD31
                        return CurrentItem.FIELD31 == null;
                    case 34: // FIELD32
                        return CurrentItem.FIELD32 == null;
                    case 35: // FIELD33
                        return CurrentItem.FIELD33 == null;
                    case 36: // FIELD34
                        return CurrentItem.FIELD34 == null;
                    case 37: // FIELD35
                        return CurrentItem.FIELD35 == null;
                    case 38: // FIELD36
                        return CurrentItem.FIELD36 == null;
                    case 39: // FIELD37
                        return CurrentItem.FIELD37 == null;
                    case 40: // FIELD38
                        return CurrentItem.FIELD38 == null;
                    case 41: // FIELD39
                        return CurrentItem.FIELD39 == null;
                    case 42: // FIELD40
                        return CurrentItem.FIELD40 == null;
                    case 43: // FIELD41
                        return CurrentItem.FIELD41 == null;
                    case 44: // FIELD42
                        return CurrentItem.FIELD42 == null;
                    case 45: // FIELD43
                        return CurrentItem.FIELD43 == null;
                    case 46: // FIELD44
                        return CurrentItem.FIELD44 == null;
                    case 47: // FIELD45
                        return CurrentItem.FIELD45 == null;
                    case 48: // FIELD46
                        return CurrentItem.FIELD46 == null;
                    case 49: // FIELD47
                        return CurrentItem.FIELD47 == null;
                    case 50: // FIELD48
                        return CurrentItem.FIELD48 == null;
                    case 51: // FIELD49
                        return CurrentItem.FIELD49 == null;
                    case 52: // NOTES01
                        return CurrentItem.NOTES01 == null;
                    case 53: // NOTES02
                        return CurrentItem.NOTES02 == null;
                    case 54: // NOTES03
                        return CurrentItem.NOTES03 == null;
                    case 55: // NOTES04
                        return CurrentItem.NOTES04 == null;
                    case 56: // ITEM_PIC
                        return CurrentItem.ITEM_PIC == null;
                    case 57: // FDT_SOURCE
                        return CurrentItem.FDT_SOURCE == null;
                    case 58: // FDT_DEST
                        return CurrentItem.FDT_DEST == null;
                    case 59: // FDT_DEST_ID
                        return CurrentItem.FDT_DEST_ID == null;
                    case 60: // FDT_EXP_DATE
                        return CurrentItem.FDT_EXP_DATE == null;
                    case 61: // FDT_EXP_TIME
                        return CurrentItem.FDT_EXP_TIME == null;
                    case 62: // FDT_COMMENT
                        return CurrentItem.FDT_COMMENT == null;
                    case 63: // CURRENT_VER
                        return CurrentItem.CURRENT_VER == null;
                    case 64: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 65: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 66: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // FDTKEY
                        return "FDTKEY";
                    case 1: // SOURCE
                        return "SOURCE";
                    case 2: // SOURCE_TABLE
                        return "SOURCE_TABLE";
                    case 3: // FIELD01
                        return "FIELD01";
                    case 4: // FIELD02
                        return "FIELD02";
                    case 5: // FIELD03
                        return "FIELD03";
                    case 6: // FIELD04
                        return "FIELD04";
                    case 7: // FIELD05
                        return "FIELD05";
                    case 8: // FIELD06
                        return "FIELD06";
                    case 9: // FIELD07
                        return "FIELD07";
                    case 10: // FIELD08
                        return "FIELD08";
                    case 11: // FIELD09
                        return "FIELD09";
                    case 12: // FIELD10
                        return "FIELD10";
                    case 13: // FIELD11
                        return "FIELD11";
                    case 14: // FIELD12
                        return "FIELD12";
                    case 15: // FIELD13
                        return "FIELD13";
                    case 16: // FIELD14
                        return "FIELD14";
                    case 17: // FIELD15
                        return "FIELD15";
                    case 18: // FIELD16
                        return "FIELD16";
                    case 19: // FIELD17
                        return "FIELD17";
                    case 20: // FIELD18
                        return "FIELD18";
                    case 21: // FIELD19
                        return "FIELD19";
                    case 22: // FIELD20
                        return "FIELD20";
                    case 23: // FIELD21
                        return "FIELD21";
                    case 24: // FIELD22
                        return "FIELD22";
                    case 25: // FIELD23
                        return "FIELD23";
                    case 26: // FIELD24
                        return "FIELD24";
                    case 27: // FIELD25
                        return "FIELD25";
                    case 28: // FIELD26
                        return "FIELD26";
                    case 29: // FIELD27
                        return "FIELD27";
                    case 30: // FIELD28
                        return "FIELD28";
                    case 31: // FIELD29
                        return "FIELD29";
                    case 32: // FIELD30
                        return "FIELD30";
                    case 33: // FIELD31
                        return "FIELD31";
                    case 34: // FIELD32
                        return "FIELD32";
                    case 35: // FIELD33
                        return "FIELD33";
                    case 36: // FIELD34
                        return "FIELD34";
                    case 37: // FIELD35
                        return "FIELD35";
                    case 38: // FIELD36
                        return "FIELD36";
                    case 39: // FIELD37
                        return "FIELD37";
                    case 40: // FIELD38
                        return "FIELD38";
                    case 41: // FIELD39
                        return "FIELD39";
                    case 42: // FIELD40
                        return "FIELD40";
                    case 43: // FIELD41
                        return "FIELD41";
                    case 44: // FIELD42
                        return "FIELD42";
                    case 45: // FIELD43
                        return "FIELD43";
                    case 46: // FIELD44
                        return "FIELD44";
                    case 47: // FIELD45
                        return "FIELD45";
                    case 48: // FIELD46
                        return "FIELD46";
                    case 49: // FIELD47
                        return "FIELD47";
                    case 50: // FIELD48
                        return "FIELD48";
                    case 51: // FIELD49
                        return "FIELD49";
                    case 52: // NOTES01
                        return "NOTES01";
                    case 53: // NOTES02
                        return "NOTES02";
                    case 54: // NOTES03
                        return "NOTES03";
                    case 55: // NOTES04
                        return "NOTES04";
                    case 56: // ITEM_PIC
                        return "ITEM_PIC";
                    case 57: // FDT_SOURCE
                        return "FDT_SOURCE";
                    case 58: // FDT_DEST
                        return "FDT_DEST";
                    case 59: // FDT_DEST_ID
                        return "FDT_DEST_ID";
                    case 60: // FDT_EXP_DATE
                        return "FDT_EXP_DATE";
                    case 61: // FDT_EXP_TIME
                        return "FDT_EXP_TIME";
                    case 62: // FDT_COMMENT
                        return "FDT_COMMENT";
                    case 63: // CURRENT_VER
                        return "CURRENT_VER";
                    case 64: // LW_DATE
                        return "LW_DATE";
                    case 65: // LW_TIME
                        return "LW_TIME";
                    case 66: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "FDTKEY":
                        return 0;
                    case "SOURCE":
                        return 1;
                    case "SOURCE_TABLE":
                        return 2;
                    case "FIELD01":
                        return 3;
                    case "FIELD02":
                        return 4;
                    case "FIELD03":
                        return 5;
                    case "FIELD04":
                        return 6;
                    case "FIELD05":
                        return 7;
                    case "FIELD06":
                        return 8;
                    case "FIELD07":
                        return 9;
                    case "FIELD08":
                        return 10;
                    case "FIELD09":
                        return 11;
                    case "FIELD10":
                        return 12;
                    case "FIELD11":
                        return 13;
                    case "FIELD12":
                        return 14;
                    case "FIELD13":
                        return 15;
                    case "FIELD14":
                        return 16;
                    case "FIELD15":
                        return 17;
                    case "FIELD16":
                        return 18;
                    case "FIELD17":
                        return 19;
                    case "FIELD18":
                        return 20;
                    case "FIELD19":
                        return 21;
                    case "FIELD20":
                        return 22;
                    case "FIELD21":
                        return 23;
                    case "FIELD22":
                        return 24;
                    case "FIELD23":
                        return 25;
                    case "FIELD24":
                        return 26;
                    case "FIELD25":
                        return 27;
                    case "FIELD26":
                        return 28;
                    case "FIELD27":
                        return 29;
                    case "FIELD28":
                        return 30;
                    case "FIELD29":
                        return 31;
                    case "FIELD30":
                        return 32;
                    case "FIELD31":
                        return 33;
                    case "FIELD32":
                        return 34;
                    case "FIELD33":
                        return 35;
                    case "FIELD34":
                        return 36;
                    case "FIELD35":
                        return 37;
                    case "FIELD36":
                        return 38;
                    case "FIELD37":
                        return 39;
                    case "FIELD38":
                        return 40;
                    case "FIELD39":
                        return 41;
                    case "FIELD40":
                        return 42;
                    case "FIELD41":
                        return 43;
                    case "FIELD42":
                        return 44;
                    case "FIELD43":
                        return 45;
                    case "FIELD44":
                        return 46;
                    case "FIELD45":
                        return 47;
                    case "FIELD46":
                        return 48;
                    case "FIELD47":
                        return 49;
                    case "FIELD48":
                        return 50;
                    case "FIELD49":
                        return 51;
                    case "NOTES01":
                        return 52;
                    case "NOTES02":
                        return 53;
                    case "NOTES03":
                        return 54;
                    case "NOTES04":
                        return 55;
                    case "ITEM_PIC":
                        return 56;
                    case "FDT_SOURCE":
                        return 57;
                    case "FDT_DEST":
                        return 58;
                    case "FDT_DEST_ID":
                        return 59;
                    case "FDT_EXP_DATE":
                        return 60;
                    case "FDT_EXP_TIME":
                        return 61;
                    case "FDT_COMMENT":
                        return 62;
                    case "CURRENT_VER":
                        return 63;
                    case "LW_DATE":
                        return 64;
                    case "LW_TIME":
                        return 65;
                    case "LW_USER":
                        return 66;
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
