using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored Procedure Return Values Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPOUTDataSet : EduHubDataSet<SPOUT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPOUT"; } }

        internal SPOUTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SPOUTKEY = new Lazy<Dictionary<string, SPOUT>>(() => this.ToDictionary(i => i.SPOUTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPOUT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPOUT" /> fields for each CSV column header</returns>
        protected override Action<SPOUT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPOUT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
                        break;
                    case "FILE_NAME":
                        mapper[i] = (e, v) => e.FILE_NAME = v;
                        break;
                    case "ENTITYID":
                        mapper[i] = (e, v) => e.ENTITYID = v;
                        break;
                    case "FLAG01":
                        mapper[i] = (e, v) => e.FLAG01 = v;
                        break;
                    case "FLAG02":
                        mapper[i] = (e, v) => e.FLAG02 = v;
                        break;
                    case "FLAG03":
                        mapper[i] = (e, v) => e.FLAG03 = v;
                        break;
                    case "FLAG04":
                        mapper[i] = (e, v) => e.FLAG04 = v;
                        break;
                    case "TXT01":
                        mapper[i] = (e, v) => e.TXT01 = v;
                        break;
                    case "TXT02":
                        mapper[i] = (e, v) => e.TXT02 = v;
                        break;
                    case "TXT03":
                        mapper[i] = (e, v) => e.TXT03 = v;
                        break;
                    case "TXT04":
                        mapper[i] = (e, v) => e.TXT04 = v;
                        break;
                    case "NUM01":
                        mapper[i] = (e, v) => e.NUM01 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM02":
                        mapper[i] = (e, v) => e.NUM02 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM03":
                        mapper[i] = (e, v) => e.NUM03 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM04":
                        mapper[i] = (e, v) => e.NUM04 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
        /// Merges <see cref="SPOUT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPOUT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPOUT" /> items to added or update the base <see cref="SPOUT" /> items</param>
        /// <returns>A merged list of <see cref="SPOUT" /> items</returns>
        protected override List<SPOUT> ApplyDeltaItems(List<SPOUT> Items, List<SPOUT> DeltaItems)
        {
            Dictionary<string, int> Index_SPOUTKEY = Items.ToIndexDictionary(i => i.SPOUTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPOUT deltaItem in DeltaItems)
            {
                int index;

                if (Index_SPOUTKEY.TryGetValue(deltaItem.SPOUTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SPOUTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SPOUT>> Index_SPOUTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <returns>Related SPOUT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPOUT FindBySPOUTKEY(string SPOUTKEY)
        {
            return Index_SPOUTKEY.Value[SPOUTKEY];
        }

        /// <summary>
        /// Attempt to find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <param name="Value">Related SPOUT entity</param>
        /// <returns>True if the related SPOUT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPOUTKEY(string SPOUTKEY, out SPOUT Value)
        {
            return Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPOUT by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find SPOUT</param>
        /// <returns>Related SPOUT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPOUT TryFindBySPOUTKEY(string SPOUTKEY)
        {
            SPOUT value;
            if (Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out value))
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
        /// Returns SQL which checks for the existence of a SPOUT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SPOUT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SPOUT](
        [SPOUTKEY] varchar(100) NOT NULL,
        [FILE_NAME] varchar(200) NULL,
        [ENTITYID] varchar(10) NULL,
        [FLAG01] varchar(1) NULL,
        [FLAG02] varchar(1) NULL,
        [FLAG03] varchar(1) NULL,
        [FLAG04] varchar(1) NULL,
        [TXT01] varchar(40) NULL,
        [TXT02] varchar(40) NULL,
        [TXT03] varchar(40) NULL,
        [TXT04] varchar(40) NULL,
        [NUM01] int NULL,
        [NUM02] int NULL,
        [NUM03] int NULL,
        [NUM04] int NULL,
        [NOTES] text NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SPOUT_Index_SPOUTKEY] PRIMARY KEY CLUSTERED (
            [SPOUTKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SPOUT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SPOUT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SPOUTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SPOUTDataReader : IDataReader, IDataRecord
        {
            private List<SPOUT> Items;
            private int CurrentIndex;
            private SPOUT CurrentItem;

            public SPOUTDataReader(List<SPOUT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 19; } }
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
                    case 0: // SPOUTKEY
                        return CurrentItem.SPOUTKEY;
                    case 1: // FILE_NAME
                        return CurrentItem.FILE_NAME;
                    case 2: // ENTITYID
                        return CurrentItem.ENTITYID;
                    case 3: // FLAG01
                        return CurrentItem.FLAG01;
                    case 4: // FLAG02
                        return CurrentItem.FLAG02;
                    case 5: // FLAG03
                        return CurrentItem.FLAG03;
                    case 6: // FLAG04
                        return CurrentItem.FLAG04;
                    case 7: // TXT01
                        return CurrentItem.TXT01;
                    case 8: // TXT02
                        return CurrentItem.TXT02;
                    case 9: // TXT03
                        return CurrentItem.TXT03;
                    case 10: // TXT04
                        return CurrentItem.TXT04;
                    case 11: // NUM01
                        return CurrentItem.NUM01;
                    case 12: // NUM02
                        return CurrentItem.NUM02;
                    case 13: // NUM03
                        return CurrentItem.NUM03;
                    case 14: // NUM04
                        return CurrentItem.NUM04;
                    case 15: // NOTES
                        return CurrentItem.NOTES;
                    case 16: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 17: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 18: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // FILE_NAME
                        return CurrentItem.FILE_NAME == null;
                    case 2: // ENTITYID
                        return CurrentItem.ENTITYID == null;
                    case 3: // FLAG01
                        return CurrentItem.FLAG01 == null;
                    case 4: // FLAG02
                        return CurrentItem.FLAG02 == null;
                    case 5: // FLAG03
                        return CurrentItem.FLAG03 == null;
                    case 6: // FLAG04
                        return CurrentItem.FLAG04 == null;
                    case 7: // TXT01
                        return CurrentItem.TXT01 == null;
                    case 8: // TXT02
                        return CurrentItem.TXT02 == null;
                    case 9: // TXT03
                        return CurrentItem.TXT03 == null;
                    case 10: // TXT04
                        return CurrentItem.TXT04 == null;
                    case 11: // NUM01
                        return CurrentItem.NUM01 == null;
                    case 12: // NUM02
                        return CurrentItem.NUM02 == null;
                    case 13: // NUM03
                        return CurrentItem.NUM03 == null;
                    case 14: // NUM04
                        return CurrentItem.NUM04 == null;
                    case 15: // NOTES
                        return CurrentItem.NOTES == null;
                    case 16: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 17: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 18: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SPOUTKEY
                        return "SPOUTKEY";
                    case 1: // FILE_NAME
                        return "FILE_NAME";
                    case 2: // ENTITYID
                        return "ENTITYID";
                    case 3: // FLAG01
                        return "FLAG01";
                    case 4: // FLAG02
                        return "FLAG02";
                    case 5: // FLAG03
                        return "FLAG03";
                    case 6: // FLAG04
                        return "FLAG04";
                    case 7: // TXT01
                        return "TXT01";
                    case 8: // TXT02
                        return "TXT02";
                    case 9: // TXT03
                        return "TXT03";
                    case 10: // TXT04
                        return "TXT04";
                    case 11: // NUM01
                        return "NUM01";
                    case 12: // NUM02
                        return "NUM02";
                    case 13: // NUM03
                        return "NUM03";
                    case 14: // NUM04
                        return "NUM04";
                    case 15: // NOTES
                        return "NOTES";
                    case 16: // LW_DATE
                        return "LW_DATE";
                    case 17: // LW_TIME
                        return "LW_TIME";
                    case 18: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SPOUTKEY":
                        return 0;
                    case "FILE_NAME":
                        return 1;
                    case "ENTITYID":
                        return 2;
                    case "FLAG01":
                        return 3;
                    case "FLAG02":
                        return 4;
                    case "FLAG03":
                        return 5;
                    case "FLAG04":
                        return 6;
                    case "TXT01":
                        return 7;
                    case "TXT02":
                        return 8;
                    case "TXT03":
                        return 9;
                    case "TXT04":
                        return 10;
                    case "NUM01":
                        return 11;
                    case "NUM02":
                        return 12;
                    case "NUM03":
                        return 13;
                    case "NUM04":
                        return 14;
                    case "NOTES":
                        return 15;
                    case "LW_DATE":
                        return 16;
                    case "LW_TIME":
                        return 17;
                    case "LW_USER":
                        return 18;
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
