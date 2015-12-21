using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fuel Tax Credit Rates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KFTCDataSet : EduHubDataSet<KFTC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KFTC"; } }

        internal KFTCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KFTCKEY = new Lazy<Dictionary<string, KFTC>>(() => this.ToDictionary(i => i.KFTCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KFTC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KFTC" /> fields for each CSV column header</returns>
        protected override Action<KFTC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KFTC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KFTCKEY":
                        mapper[i] = (e, v) => e.KFTCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FTC_RATE":
                        mapper[i] = (e, v) => e.FTC_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GL_CODE":
                        mapper[i] = (e, v) => e.GL_CODE = v;
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
                    case "INACTIVE":
                        mapper[i] = (e, v) => e.INACTIVE = v;
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="KFTC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KFTC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KFTC" /> items to added or update the base <see cref="KFTC" /> items</param>
        /// <returns>A merged list of <see cref="KFTC" /> items</returns>
        protected override List<KFTC> ApplyDeltaItems(List<KFTC> Items, List<KFTC> DeltaItems)
        {
            Dictionary<string, int> Index_KFTCKEY = Items.ToIndexDictionary(i => i.KFTCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KFTC deltaItem in DeltaItems)
            {
                int index;

                if (Index_KFTCKEY.TryGetValue(deltaItem.KFTCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KFTCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KFTC>> Index_KFTCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <returns>Related KFTC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFTC FindByKFTCKEY(string KFTCKEY)
        {
            return Index_KFTCKEY.Value[KFTCKEY];
        }

        /// <summary>
        /// Attempt to find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <param name="Value">Related KFTC entity</param>
        /// <returns>True if the related KFTC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKFTCKEY(string KFTCKEY, out KFTC Value)
        {
            return Index_KFTCKEY.Value.TryGetValue(KFTCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KFTC by KFTCKEY field
        /// </summary>
        /// <param name="KFTCKEY">KFTCKEY value used to find KFTC</param>
        /// <returns>Related KFTC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KFTC TryFindByKFTCKEY(string KFTCKEY)
        {
            KFTC value;
            if (Index_KFTCKEY.Value.TryGetValue(KFTCKEY, out value))
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
        /// Returns SQL which checks for the existence of a KFTC table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KFTC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KFTC](
        [KFTCKEY] varchar(3) NOT NULL,
        [DESCRIPTION] varchar(80) NULL,
        [FTC_RATE] float NULL,
        [GL_CODE] varchar(10) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [INACTIVE] varchar(1) NULL,
        [LW_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KFTC_Index_KFTCKEY] PRIMARY KEY CLUSTERED (
            [KFTCKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KFTC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KFTC data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KFTCDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KFTCDataReader : IDataReader, IDataRecord
        {
            private List<KFTC> Items;
            private int CurrentIndex;
            private KFTC CurrentItem;

            public KFTCDataReader(List<KFTC> Items)
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
                    case 0: // KFTCKEY
                        return CurrentItem.KFTCKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // FTC_RATE
                        return CurrentItem.FTC_RATE;
                    case 3: // GL_CODE
                        return CurrentItem.GL_CODE;
                    case 4: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM;
                    case 5: // GLPROGRAM
                        return CurrentItem.GLPROGRAM;
                    case 6: // INITIATIVE
                        return CurrentItem.INITIATIVE;
                    case 7: // INACTIVE
                        return CurrentItem.INACTIVE;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE;
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
                    case 2: // FTC_RATE
                        return CurrentItem.FTC_RATE == null;
                    case 3: // GL_CODE
                        return CurrentItem.GL_CODE == null;
                    case 4: // SUBPROGRAM
                        return CurrentItem.SUBPROGRAM == null;
                    case 5: // GLPROGRAM
                        return CurrentItem.GLPROGRAM == null;
                    case 6: // INITIATIVE
                        return CurrentItem.INITIATIVE == null;
                    case 7: // INACTIVE
                        return CurrentItem.INACTIVE == null;
                    case 8: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 9: // LW_DATE
                        return CurrentItem.LW_DATE == null;
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
                    case 0: // KFTCKEY
                        return "KFTCKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // FTC_RATE
                        return "FTC_RATE";
                    case 3: // GL_CODE
                        return "GL_CODE";
                    case 4: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 5: // GLPROGRAM
                        return "GLPROGRAM";
                    case 6: // INITIATIVE
                        return "INITIATIVE";
                    case 7: // INACTIVE
                        return "INACTIVE";
                    case 8: // LW_TIME
                        return "LW_TIME";
                    case 9: // LW_DATE
                        return "LW_DATE";
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
                    case "KFTCKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "FTC_RATE":
                        return 2;
                    case "GL_CODE":
                        return 3;
                    case "SUBPROGRAM":
                        return 4;
                    case "GLPROGRAM":
                        return 5;
                    case "INITIATIVE":
                        return 6;
                    case "INACTIVE":
                        return 7;
                    case "LW_TIME":
                        return 8;
                    case "LW_DATE":
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
