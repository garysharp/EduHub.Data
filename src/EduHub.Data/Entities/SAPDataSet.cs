using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Positions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAPDataSet : EduHubDataSet<SAP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAP"; } }

        internal SAPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SAPKEY = new Lazy<Dictionary<string, SAP>>(() => this.ToDictionary(i => i.SAPKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAP" /> fields for each CSV column header</returns>
        protected override Action<SAP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAPKEY":
                        mapper[i] = (e, v) => e.SAPKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SORT_CODE":
                        mapper[i] = (e, v) => e.SORT_CODE = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="SAP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAP" /> items to added or update the base <see cref="SAP" /> items</param>
        /// <returns>A merged list of <see cref="SAP" /> items</returns>
        protected override List<SAP> ApplyDeltaItems(List<SAP> Items, List<SAP> DeltaItems)
        {
            Dictionary<string, int> Index_SAPKEY = Items.ToIndexDictionary(i => i.SAPKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAP deltaItem in DeltaItems)
            {
                int index;

                if (Index_SAPKEY.TryGetValue(deltaItem.SAPKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SAPKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, SAP>> Index_SAPKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <returns>Related SAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAP FindBySAPKEY(string SAPKEY)
        {
            return Index_SAPKEY.Value[SAPKEY];
        }

        /// <summary>
        /// Attempt to find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <param name="Value">Related SAP entity</param>
        /// <returns>True if the related SAP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAPKEY(string SAPKEY, out SAP Value)
        {
            return Index_SAPKEY.Value.TryGetValue(SAPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAP by SAPKEY field
        /// </summary>
        /// <param name="SAPKEY">SAPKEY value used to find SAP</param>
        /// <returns>Related SAP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAP TryFindBySAPKEY(string SAPKEY)
        {
            SAP value;
            if (Index_SAPKEY.Value.TryGetValue(SAPKEY, out value))
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
        /// Returns SQL which checks for the existence of a SAP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAP](
        [SAPKEY] varchar(25) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [SORT_CODE] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAP_Index_SAPKEY] PRIMARY KEY CLUSTERED (
            [SAPKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SAPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SAPDataReader : IDataReader, IDataRecord
        {
            private List<SAP> Items;
            private int CurrentIndex;
            private SAP CurrentItem;

            public SAPDataReader(List<SAP> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 6; } }
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
                    case 0: // SAPKEY
                        return CurrentItem.SAPKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // SORT_CODE
                        return CurrentItem.SORT_CODE;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 5: // LW_USER
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
                    case 2: // SORT_CODE
                        return CurrentItem.SORT_CODE == null;
                    case 3: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 4: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 5: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SAPKEY
                        return "SAPKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // SORT_CODE
                        return "SORT_CODE";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SAPKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "SORT_CODE":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
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
