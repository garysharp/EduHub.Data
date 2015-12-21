using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Validation Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_CLVDataSet : EduHubDataSet<SCEN_CLV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_CLV"; } }

        internal SCEN_CLVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_CLV>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_CLV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_CLV" /> fields for each CSV column header</returns>
        protected override Action<SCEN_CLV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_CLV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "CLASSCODE":
                        mapper[i] = (e, v) => e.CLASSCODE = v;
                        break;
                    case "ID_CLASSVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_CLASSVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_CLV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_CLV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_CLV" /> items to added or update the base <see cref="SCEN_CLV" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_CLV" /> items</returns>
        protected override List<SCEN_CLV> ApplyDeltaItems(List<SCEN_CLV> Items, List<SCEN_CLV> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_CLV deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_CLV>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_CLV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CLV</param>
        /// <returns>Related SCEN_CLV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_CLV FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_CLV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CLV</param>
        /// <param name="Value">Related SCEN_CLV entity</param>
        /// <returns>True if the related SCEN_CLV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_CLV Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_CLV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CLV</param>
        /// <returns>Related SCEN_CLV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_CLV TryFindByID(int ID)
        {
            SCEN_CLV value;
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
        /// Returns SQL which checks for the existence of a SCEN_CLV table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_CLV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_CLV](
        [ID] int IDENTITY NOT NULL,
        [CLASSCODE] varchar(5) NULL,
        [ID_CLASSVALIDATIONTYPE] smallint NULL,
        [STATUS] varchar(1) NULL,
        [CREATEUSER] varchar(128) NULL,
        [CREATED] datetime NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_CLV_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_CLV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_CLV data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_CLVDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_CLVDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_CLV> Items;
            private int CurrentIndex;
            private SCEN_CLV CurrentItem;

            public SCEN_CLVDataReader(List<SCEN_CLV> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 8; } }
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
                    case 1: // CLASSCODE
                        return CurrentItem.CLASSCODE;
                    case 2: // ID_CLASSVALIDATIONTYPE
                        return CurrentItem.ID_CLASSVALIDATIONTYPE;
                    case 3: // STATUS
                        return CurrentItem.STATUS;
                    case 4: // CREATEUSER
                        return CurrentItem.CREATEUSER;
                    case 5: // CREATED
                        return CurrentItem.CREATED;
                    case 6: // LUPDATEUSER
                        return CurrentItem.LUPDATEUSER;
                    case 7: // LUPDATED
                        return CurrentItem.LUPDATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // CLASSCODE
                        return CurrentItem.CLASSCODE == null;
                    case 2: // ID_CLASSVALIDATIONTYPE
                        return CurrentItem.ID_CLASSVALIDATIONTYPE == null;
                    case 3: // STATUS
                        return CurrentItem.STATUS == null;
                    case 4: // CREATEUSER
                        return CurrentItem.CREATEUSER == null;
                    case 5: // CREATED
                        return CurrentItem.CREATED == null;
                    case 6: // LUPDATEUSER
                        return CurrentItem.LUPDATEUSER == null;
                    case 7: // LUPDATED
                        return CurrentItem.LUPDATED == null;
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
                    case 1: // CLASSCODE
                        return "CLASSCODE";
                    case 2: // ID_CLASSVALIDATIONTYPE
                        return "ID_CLASSVALIDATIONTYPE";
                    case 3: // STATUS
                        return "STATUS";
                    case 4: // CREATEUSER
                        return "CREATEUSER";
                    case 5: // CREATED
                        return "CREATED";
                    case 6: // LUPDATEUSER
                        return "LUPDATEUSER";
                    case 7: // LUPDATED
                        return "LUPDATED";
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
                    case "CLASSCODE":
                        return 1;
                    case "ID_CLASSVALIDATIONTYPE":
                        return 2;
                    case "STATUS":
                        return 3;
                    case "CREATEUSER":
                        return 4;
                    case "CREATED":
                        return 5;
                    case "LUPDATEUSER":
                        return 6;
                    case "LUPDATED":
                        return 7;
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
