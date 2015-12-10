using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Field-Display Metadata for Census Return Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_RFDDataSet : DataSetBase<SCEN_RFD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_RFD"; } }

        internal SCEN_RFDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_RFD>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_RFD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_RFD" /> fields for each CSV column header</returns>
        protected override Action<SCEN_RFD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_RFD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "COLUMNNAME":
                        mapper[i] = (e, v) => e.COLUMNNAME = v;
                        break;
                    case "COLUMNDISPLAYNAME":
                        mapper[i] = (e, v) => e.COLUMNDISPLAYNAME = v;
                        break;
                    case "RFD_TYPE":
                        mapper[i] = (e, v) => e.RFD_TYPE = v;
                        break;
                    case "TYPEORDER":
                        mapper[i] = (e, v) => e.TYPEORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEFAULTCOLUMNDISPLAYORDER":
                        mapper[i] = (e, v) => e.DEFAULTCOLUMNDISPLAYORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_RFD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_RFD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_RFD" /> items to added or update the base <see cref="SCEN_RFD" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_RFD" /> items</returns>
        protected override List<SCEN_RFD> ApplyDeltaItems(List<SCEN_RFD> Items, List<SCEN_RFD> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_RFD deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_RFD>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_RFD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RFD</param>
        /// <returns>Related SCEN_RFD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RFD FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_RFD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RFD</param>
        /// <param name="Value">Related SCEN_RFD entity</param>
        /// <returns>True if the related SCEN_RFD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_RFD Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RFD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RFD</param>
        /// <returns>Related SCEN_RFD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RFD TryFindByID(int ID)
        {
            SCEN_RFD value;
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
        /// Returns SQL which checks for the existence of a SCEN_RFD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_RFD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_RFD](
        [ID] int IDENTITY NOT NULL,
        [COLUMNNAME] varchar(255) NULL,
        [COLUMNDISPLAYNAME] varchar(255) NULL,
        [RFD_TYPE] varchar(255) NULL,
        [TYPEORDER] smallint NULL,
        [DEFAULTCOLUMNDISPLAYORDER] smallint NULL,
        CONSTRAINT [SCEN_RFD_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_RFD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_RFD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_RFDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_RFDDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_RFD> Items;
            private int CurrentIndex;
            private SCEN_RFD CurrentItem;

            public SCEN_RFDDataReader(List<SCEN_RFD> Items)
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
                    case 1: // COLUMNNAME
                        return CurrentItem.COLUMNNAME;
                    case 2: // COLUMNDISPLAYNAME
                        return CurrentItem.COLUMNDISPLAYNAME;
                    case 3: // RFD_TYPE
                        return CurrentItem.RFD_TYPE;
                    case 4: // TYPEORDER
                        return CurrentItem.TYPEORDER;
                    case 5: // DEFAULTCOLUMNDISPLAYORDER
                        return CurrentItem.DEFAULTCOLUMNDISPLAYORDER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // COLUMNNAME
                        return CurrentItem.COLUMNNAME == null;
                    case 2: // COLUMNDISPLAYNAME
                        return CurrentItem.COLUMNDISPLAYNAME == null;
                    case 3: // RFD_TYPE
                        return CurrentItem.RFD_TYPE == null;
                    case 4: // TYPEORDER
                        return CurrentItem.TYPEORDER == null;
                    case 5: // DEFAULTCOLUMNDISPLAYORDER
                        return CurrentItem.DEFAULTCOLUMNDISPLAYORDER == null;
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
                    case 1: // COLUMNNAME
                        return "COLUMNNAME";
                    case 2: // COLUMNDISPLAYNAME
                        return "COLUMNDISPLAYNAME";
                    case 3: // RFD_TYPE
                        return "RFD_TYPE";
                    case 4: // TYPEORDER
                        return "TYPEORDER";
                    case 5: // DEFAULTCOLUMNDISPLAYORDER
                        return "DEFAULTCOLUMNDISPLAYORDER";
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
                    case "COLUMNNAME":
                        return 1;
                    case "COLUMNDISPLAYNAME":
                        return 2;
                    case "RFD_TYPE":
                        return 3;
                    case "TYPEORDER":
                        return 4;
                    case "DEFAULTCOLUMNDISPLAYORDER":
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
