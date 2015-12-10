using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Validation Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_STVDataSet : DataSetBase<SCEN_STV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_STV"; } }

        internal SCEN_STVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_STV>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_STV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_STV" /> fields for each CSV column header</returns>
        protected override Action<SCEN_STV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_STV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ID_STUDENTVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_STUDENTVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FIELDVALUES":
                        mapper[i] = (e, v) => e.FIELDVALUES = v;
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
        /// Merges <see cref="SCEN_STV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_STV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_STV" /> items to added or update the base <see cref="SCEN_STV" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_STV" /> items</returns>
        protected override List<SCEN_STV> ApplyDeltaItems(List<SCEN_STV> Items, List<SCEN_STV> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_STV deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_STV>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_STV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_STV</param>
        /// <returns>Related SCEN_STV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_STV FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_STV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_STV</param>
        /// <param name="Value">Related SCEN_STV entity</param>
        /// <returns>True if the related SCEN_STV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_STV Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_STV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_STV</param>
        /// <returns>Related SCEN_STV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_STV TryFindByID(int ID)
        {
            SCEN_STV value;
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
        /// Returns SQL which checks for the existence of a SCEN_STV table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_STV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_STV](
        [ID] int IDENTITY NOT NULL,
        [STKEY] varchar(10) NULL,
        [REGISTRATION] smallint NULL,
        [ID_STUDENTVALIDATIONTYPE] smallint NULL,
        [FIELDVALUES] varchar(255) NULL,
        [STATUS] varchar(1) NULL,
        [CREATEUSER] varchar(128) NULL,
        [CREATED] datetime NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_STV_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_STV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_STV data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_STVDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_STVDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_STV> Items;
            private int CurrentIndex;
            private SCEN_STV CurrentItem;

            public SCEN_STVDataReader(List<SCEN_STV> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 10; } }
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
                    case 1: // STKEY
                        return CurrentItem.STKEY;
                    case 2: // REGISTRATION
                        return CurrentItem.REGISTRATION;
                    case 3: // ID_STUDENTVALIDATIONTYPE
                        return CurrentItem.ID_STUDENTVALIDATIONTYPE;
                    case 4: // FIELDVALUES
                        return CurrentItem.FIELDVALUES;
                    case 5: // STATUS
                        return CurrentItem.STATUS;
                    case 6: // CREATEUSER
                        return CurrentItem.CREATEUSER;
                    case 7: // CREATED
                        return CurrentItem.CREATED;
                    case 8: // LUPDATEUSER
                        return CurrentItem.LUPDATEUSER;
                    case 9: // LUPDATED
                        return CurrentItem.LUPDATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // STKEY
                        return CurrentItem.STKEY == null;
                    case 2: // REGISTRATION
                        return CurrentItem.REGISTRATION == null;
                    case 3: // ID_STUDENTVALIDATIONTYPE
                        return CurrentItem.ID_STUDENTVALIDATIONTYPE == null;
                    case 4: // FIELDVALUES
                        return CurrentItem.FIELDVALUES == null;
                    case 5: // STATUS
                        return CurrentItem.STATUS == null;
                    case 6: // CREATEUSER
                        return CurrentItem.CREATEUSER == null;
                    case 7: // CREATED
                        return CurrentItem.CREATED == null;
                    case 8: // LUPDATEUSER
                        return CurrentItem.LUPDATEUSER == null;
                    case 9: // LUPDATED
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
                    case 1: // STKEY
                        return "STKEY";
                    case 2: // REGISTRATION
                        return "REGISTRATION";
                    case 3: // ID_STUDENTVALIDATIONTYPE
                        return "ID_STUDENTVALIDATIONTYPE";
                    case 4: // FIELDVALUES
                        return "FIELDVALUES";
                    case 5: // STATUS
                        return "STATUS";
                    case 6: // CREATEUSER
                        return "CREATEUSER";
                    case 7: // CREATED
                        return "CREATED";
                    case 8: // LUPDATEUSER
                        return "LUPDATEUSER";
                    case 9: // LUPDATED
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
                    case "STKEY":
                        return 1;
                    case "REGISTRATION":
                        return 2;
                    case "ID_STUDENTVALIDATIONTYPE":
                        return 3;
                    case "FIELDVALUES":
                        return 4;
                    case "STATUS":
                        return 5;
                    case "CREATEUSER":
                        return 6;
                    case "CREATED":
                        return 7;
                    case "LUPDATEUSER":
                        return 8;
                    case "LUPDATED":
                        return 9;
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
