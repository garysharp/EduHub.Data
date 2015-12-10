using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Application Message Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_APPDataSet : DataSetBase<SCEN_APP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_APP"; } }

        internal SCEN_APPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_APP>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_APP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_APP" /> fields for each CSV column header</returns>
        protected override Action<SCEN_APP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_APP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ITEMNAME":
                        mapper[i] = (e, v) => e.ITEMNAME = v;
                        break;
                    case "ITEMVALUE":
                        mapper[i] = (e, v) => e.ITEMVALUE = v;
                        break;
                    case "ITEMTYPE":
                        mapper[i] = (e, v) => e.ITEMTYPE = v;
                        break;
                    case "ITEMMINITYPE":
                        mapper[i] = (e, v) => e.ITEMMINITYPE = v;
                        break;
                    case "ITEMCOMMENTS":
                        mapper[i] = (e, v) => e.ITEMCOMMENTS = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_APP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_APP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_APP" /> items to added or update the base <see cref="SCEN_APP" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_APP" /> items</returns>
        protected override List<SCEN_APP> ApplyDeltaItems(List<SCEN_APP> Items, List<SCEN_APP> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_APP deltaItem in DeltaItems)
            {
                int index;

                if (Index_ID.TryGetValue(deltaItem.ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SCEN_APP>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <returns>Related SCEN_APP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_APP FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <param name="Value">Related SCEN_APP entity</param>
        /// <returns>True if the related SCEN_APP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_APP Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <returns>Related SCEN_APP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_APP TryFindByID(int ID)
        {
            SCEN_APP value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns SQL which checks for the existence of a SCEN_APP table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_APP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_APP](
        [ID] int IDENTITY NOT NULL,
        [ITEMNAME] varchar(255) NULL,
        [ITEMVALUE] varchar(255) NULL,
        [ITEMTYPE] varchar(255) NULL,
        [ITEMMINITYPE] varchar(255) NULL,
        [ITEMCOMMENTS] varchar(255) NULL,
        CONSTRAINT [SCEN_APP_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_APP data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_APP data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_APPDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_APPDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_APP> Items;
            private int CurrentIndex;
            private SCEN_APP CurrentItem;

            public SCEN_APPDataReader(List<SCEN_APP> Items)
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
                    case 0: // ID
                        return CurrentItem.ID;
                    case 1: // ITEMNAME
                        return CurrentItem.ITEMNAME;
                    case 2: // ITEMVALUE
                        return CurrentItem.ITEMVALUE;
                    case 3: // ITEMTYPE
                        return CurrentItem.ITEMTYPE;
                    case 4: // ITEMMINITYPE
                        return CurrentItem.ITEMMINITYPE;
                    case 5: // ITEMCOMMENTS
                        return CurrentItem.ITEMCOMMENTS;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ITEMNAME
                        return CurrentItem.ITEMNAME == null;
                    case 2: // ITEMVALUE
                        return CurrentItem.ITEMVALUE == null;
                    case 3: // ITEMTYPE
                        return CurrentItem.ITEMTYPE == null;
                    case 4: // ITEMMINITYPE
                        return CurrentItem.ITEMMINITYPE == null;
                    case 5: // ITEMCOMMENTS
                        return CurrentItem.ITEMCOMMENTS == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // ITEMNAME
                        return "ITEMNAME";
                    case 2: // ITEMVALUE
                        return "ITEMVALUE";
                    case 3: // ITEMTYPE
                        return "ITEMTYPE";
                    case 4: // ITEMMINITYPE
                        return "ITEMMINITYPE";
                    case 5: // ITEMCOMMENTS
                        return "ITEMCOMMENTS";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "ITEMNAME":
                        return 1;
                    case "ITEMVALUE":
                        return 2;
                    case "ITEMTYPE":
                        return 3;
                    case "ITEMMINITYPE":
                        return 4;
                    case "ITEMCOMMENTS":
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
