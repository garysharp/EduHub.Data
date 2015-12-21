using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Student Validation Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ASVDataSet : EduHubDataSet<SCEN_ASV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_ASV"; } }

        internal SCEN_ASVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_ASV>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ASV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ASV" /> fields for each CSV column header</returns>
        protected override Action<SCEN_ASV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_ASV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="SCEN_ASV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_ASV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_ASV" /> items to added or update the base <see cref="SCEN_ASV" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_ASV" /> items</returns>
        protected override List<SCEN_ASV> ApplyDeltaItems(List<SCEN_ASV> Items, List<SCEN_ASV> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_ASV deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_ASV>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_ASV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASV</param>
        /// <returns>Related SCEN_ASV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ASV FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_ASV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASV</param>
        /// <param name="Value">Related SCEN_ASV entity</param>
        /// <returns>True if the related SCEN_ASV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_ASV Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ASV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASV</param>
        /// <returns>Related SCEN_ASV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ASV TryFindByID(int ID)
        {
            SCEN_ASV value;
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
        /// Returns SQL which checks for the existence of a SCEN_ASV table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_ASV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_ASV](
        [ID] int IDENTITY NOT NULL,
        [ID_RETURN] int NULL,
        [STKEY] varchar(10) NULL,
        [REGISTRATION] smallint NULL,
        [ID_STUDENTVALIDATIONTYPE] smallint NULL,
        [FIELDVALUES] varchar(255) NULL,
        [STATUS] varchar(1) NULL,
        [CREATEUSER] varchar(128) NULL,
        [CREATED] datetime NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_ASV_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_ASV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ASV data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_ASVDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_ASVDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_ASV> Items;
            private int CurrentIndex;
            private SCEN_ASV CurrentItem;

            public SCEN_ASVDataReader(List<SCEN_ASV> Items)
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
                    case 0: // ID
                        return CurrentItem.ID;
                    case 1: // ID_RETURN
                        return CurrentItem.ID_RETURN;
                    case 2: // STKEY
                        return CurrentItem.STKEY;
                    case 3: // REGISTRATION
                        return CurrentItem.REGISTRATION;
                    case 4: // ID_STUDENTVALIDATIONTYPE
                        return CurrentItem.ID_STUDENTVALIDATIONTYPE;
                    case 5: // FIELDVALUES
                        return CurrentItem.FIELDVALUES;
                    case 6: // STATUS
                        return CurrentItem.STATUS;
                    case 7: // CREATEUSER
                        return CurrentItem.CREATEUSER;
                    case 8: // CREATED
                        return CurrentItem.CREATED;
                    case 9: // LUPDATEUSER
                        return CurrentItem.LUPDATEUSER;
                    case 10: // LUPDATED
                        return CurrentItem.LUPDATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ID_RETURN
                        return CurrentItem.ID_RETURN == null;
                    case 2: // STKEY
                        return CurrentItem.STKEY == null;
                    case 3: // REGISTRATION
                        return CurrentItem.REGISTRATION == null;
                    case 4: // ID_STUDENTVALIDATIONTYPE
                        return CurrentItem.ID_STUDENTVALIDATIONTYPE == null;
                    case 5: // FIELDVALUES
                        return CurrentItem.FIELDVALUES == null;
                    case 6: // STATUS
                        return CurrentItem.STATUS == null;
                    case 7: // CREATEUSER
                        return CurrentItem.CREATEUSER == null;
                    case 8: // CREATED
                        return CurrentItem.CREATED == null;
                    case 9: // LUPDATEUSER
                        return CurrentItem.LUPDATEUSER == null;
                    case 10: // LUPDATED
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
                    case 1: // ID_RETURN
                        return "ID_RETURN";
                    case 2: // STKEY
                        return "STKEY";
                    case 3: // REGISTRATION
                        return "REGISTRATION";
                    case 4: // ID_STUDENTVALIDATIONTYPE
                        return "ID_STUDENTVALIDATIONTYPE";
                    case 5: // FIELDVALUES
                        return "FIELDVALUES";
                    case 6: // STATUS
                        return "STATUS";
                    case 7: // CREATEUSER
                        return "CREATEUSER";
                    case 8: // CREATED
                        return "CREATED";
                    case 9: // LUPDATEUSER
                        return "LUPDATEUSER";
                    case 10: // LUPDATED
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
                    case "ID_RETURN":
                        return 1;
                    case "STKEY":
                        return 2;
                    case "REGISTRATION":
                        return 3;
                    case "ID_STUDENTVALIDATIONTYPE":
                        return 4;
                    case "FIELDVALUES":
                        return 5;
                    case "STATUS":
                        return 6;
                    case "CREATEUSER":
                        return 7;
                    case "CREATED":
                        return 8;
                    case "LUPDATEUSER":
                        return 9;
                    case "LUPDATED":
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
