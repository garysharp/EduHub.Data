using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Visa Subclasses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCVDataSet : EduHubDataSet<KCV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCV"; } }

        internal KCVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_VISA_SUBCLASS = new Lazy<Dictionary<string, KCV>>(() => this.ToDictionary(i => i.VISA_SUBCLASS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCV" /> fields for each CSV column header</returns>
        protected override Action<KCV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "VISA_RESIDENCY":
                        mapper[i] = (e, v) => e.VISA_RESIDENCY = v;
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "CHECK_STAT_CODE":
                        mapper[i] = (e, v) => e.CHECK_STAT_CODE = v;
                        break;
                    case "CHECK_EXPIRY_DATE":
                        mapper[i] = (e, v) => e.CHECK_EXPIRY_DATE = v;
                        break;
                    case "CHECK_ISID":
                        mapper[i] = (e, v) => e.CHECK_ISID = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
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
        /// Merges <see cref="KCV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCV" /> items to added or update the base <see cref="KCV" /> items</param>
        /// <returns>A merged list of <see cref="KCV" /> items</returns>
        protected override List<KCV> ApplyDeltaItems(List<KCV> Items, List<KCV> DeltaItems)
        {
            Dictionary<string, int> Index_VISA_SUBCLASS = Items.ToIndexDictionary(i => i.VISA_SUBCLASS);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCV deltaItem in DeltaItems)
            {
                int index;

                if (Index_VISA_SUBCLASS.TryGetValue(deltaItem.VISA_SUBCLASS, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.VISA_SUBCLASS)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCV>> Index_VISA_SUBCLASS;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <returns>Related KCV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCV FindByVISA_SUBCLASS(string VISA_SUBCLASS)
        {
            return Index_VISA_SUBCLASS.Value[VISA_SUBCLASS];
        }

        /// <summary>
        /// Attempt to find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <param name="Value">Related KCV entity</param>
        /// <returns>True if the related KCV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVISA_SUBCLASS(string VISA_SUBCLASS, out KCV Value)
        {
            return Index_VISA_SUBCLASS.Value.TryGetValue(VISA_SUBCLASS, out Value);
        }

        /// <summary>
        /// Attempt to find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <returns>Related KCV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCV TryFindByVISA_SUBCLASS(string VISA_SUBCLASS)
        {
            KCV value;
            if (Index_VISA_SUBCLASS.Value.TryGetValue(VISA_SUBCLASS, out value))
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
        /// Returns SQL which checks for the existence of a KCV table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCV](
        [VISA_SUBCLASS] varchar(3) NOT NULL,
        [DESCRIPTION] varchar(52) NULL,
        [VISA_RESIDENCY] varchar(1) NULL,
        [SGB_FUNDED] varchar(1) NULL,
        [CHECK_STAT_CODE] varchar(1) NULL,
        [CHECK_EXPIRY_DATE] varchar(1) NULL,
        [CHECK_ISID] varchar(1) NULL,
        [REFUGEE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCV_Index_VISA_SUBCLASS] PRIMARY KEY CLUSTERED (
            [VISA_SUBCLASS] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCV data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCVDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCVDataReader : IDataReader, IDataRecord
        {
            private List<KCV> Items;
            private int CurrentIndex;
            private KCV CurrentItem;

            public KCVDataReader(List<KCV> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 11; } }
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
                    case 0: // VISA_SUBCLASS
                        return CurrentItem.VISA_SUBCLASS;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // VISA_RESIDENCY
                        return CurrentItem.VISA_RESIDENCY;
                    case 3: // SGB_FUNDED
                        return CurrentItem.SGB_FUNDED;
                    case 4: // CHECK_STAT_CODE
                        return CurrentItem.CHECK_STAT_CODE;
                    case 5: // CHECK_EXPIRY_DATE
                        return CurrentItem.CHECK_EXPIRY_DATE;
                    case 6: // CHECK_ISID
                        return CurrentItem.CHECK_ISID;
                    case 7: // REFUGEE
                        return CurrentItem.REFUGEE;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 10: // LW_USER
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
                    case 2: // VISA_RESIDENCY
                        return CurrentItem.VISA_RESIDENCY == null;
                    case 3: // SGB_FUNDED
                        return CurrentItem.SGB_FUNDED == null;
                    case 4: // CHECK_STAT_CODE
                        return CurrentItem.CHECK_STAT_CODE == null;
                    case 5: // CHECK_EXPIRY_DATE
                        return CurrentItem.CHECK_EXPIRY_DATE == null;
                    case 6: // CHECK_ISID
                        return CurrentItem.CHECK_ISID == null;
                    case 7: // REFUGEE
                        return CurrentItem.REFUGEE == null;
                    case 8: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 9: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 10: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // VISA_SUBCLASS
                        return "VISA_SUBCLASS";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // VISA_RESIDENCY
                        return "VISA_RESIDENCY";
                    case 3: // SGB_FUNDED
                        return "SGB_FUNDED";
                    case 4: // CHECK_STAT_CODE
                        return "CHECK_STAT_CODE";
                    case 5: // CHECK_EXPIRY_DATE
                        return "CHECK_EXPIRY_DATE";
                    case 6: // CHECK_ISID
                        return "CHECK_ISID";
                    case 7: // REFUGEE
                        return "REFUGEE";
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

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "VISA_SUBCLASS":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "VISA_RESIDENCY":
                        return 2;
                    case "SGB_FUNDED":
                        return 3;
                    case "CHECK_STAT_CODE":
                        return 4;
                    case "CHECK_EXPIRY_DATE":
                        return 5;
                    case "CHECK_ISID":
                        return 6;
                    case "REFUGEE":
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
