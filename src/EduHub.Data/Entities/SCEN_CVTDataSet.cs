using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Validation Type Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_CVTDataSet : DataSetBase<SCEN_CVT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_CVT"; } }

        internal SCEN_CVTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_CVT>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_CVT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_CVT" /> fields for each CSV column header</returns>
        protected override Action<SCEN_CVT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_CVT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "VCODE":
                        mapper[i] = (e, v) => e.VCODE = v;
                        break;
                    case "VALIDATIONMESSAGE":
                        mapper[i] = (e, v) => e.VALIDATIONMESSAGE = v;
                        break;
                    case "WARNING":
                        mapper[i] = (e, v) => e.WARNING = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "DETAILEDMESSAGE":
                        mapper[i] = (e, v) => e.DETAILEDMESSAGE = v;
                        break;
                    case "CVT_TYPE":
                        mapper[i] = (e, v) => e.CVT_TYPE = v;
                        break;
                    case "COMMANDNAME":
                        mapper[i] = (e, v) => e.COMMANDNAME = v;
                        break;
                    case "ISENABLED":
                        mapper[i] = (e, v) => e.ISENABLED = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_CVT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_CVT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_CVT" /> items to added or update the base <see cref="SCEN_CVT" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_CVT" /> items</returns>
        protected override List<SCEN_CVT> ApplyDeltaItems(List<SCEN_CVT> Items, List<SCEN_CVT> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_CVT deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_CVT>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_CVT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CVT</param>
        /// <returns>Related SCEN_CVT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_CVT FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_CVT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CVT</param>
        /// <param name="Value">Related SCEN_CVT entity</param>
        /// <returns>True if the related SCEN_CVT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_CVT Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_CVT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CVT</param>
        /// <returns>Related SCEN_CVT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_CVT TryFindByID(int ID)
        {
            SCEN_CVT value;
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
        /// Returns SQL which checks for the existence of a SCEN_CVT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_CVT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_CVT](
        [ID] int IDENTITY NOT NULL,
        [VCODE] varchar(15) NULL,
        [VALIDATIONMESSAGE] text NULL,
        [WARNING] varchar(1) NULL,
        [PERIOD] varchar(1) NULL,
        [DETAILEDMESSAGE] text NULL,
        [CVT_TYPE] varchar(3) NULL,
        [COMMANDNAME] varchar(255) NULL,
        [ISENABLED] varchar(1) NULL,
        CONSTRAINT [SCEN_CVT_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_CVT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_CVT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_CVTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_CVTDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_CVT> Items;
            private int CurrentIndex;
            private SCEN_CVT CurrentItem;

            public SCEN_CVTDataReader(List<SCEN_CVT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 9; } }
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
                    case 1: // VCODE
                        return CurrentItem.VCODE;
                    case 2: // VALIDATIONMESSAGE
                        return CurrentItem.VALIDATIONMESSAGE;
                    case 3: // WARNING
                        return CurrentItem.WARNING;
                    case 4: // PERIOD
                        return CurrentItem.PERIOD;
                    case 5: // DETAILEDMESSAGE
                        return CurrentItem.DETAILEDMESSAGE;
                    case 6: // CVT_TYPE
                        return CurrentItem.CVT_TYPE;
                    case 7: // COMMANDNAME
                        return CurrentItem.COMMANDNAME;
                    case 8: // ISENABLED
                        return CurrentItem.ISENABLED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // VCODE
                        return CurrentItem.VCODE == null;
                    case 2: // VALIDATIONMESSAGE
                        return CurrentItem.VALIDATIONMESSAGE == null;
                    case 3: // WARNING
                        return CurrentItem.WARNING == null;
                    case 4: // PERIOD
                        return CurrentItem.PERIOD == null;
                    case 5: // DETAILEDMESSAGE
                        return CurrentItem.DETAILEDMESSAGE == null;
                    case 6: // CVT_TYPE
                        return CurrentItem.CVT_TYPE == null;
                    case 7: // COMMANDNAME
                        return CurrentItem.COMMANDNAME == null;
                    case 8: // ISENABLED
                        return CurrentItem.ISENABLED == null;
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
                    case 1: // VCODE
                        return "VCODE";
                    case 2: // VALIDATIONMESSAGE
                        return "VALIDATIONMESSAGE";
                    case 3: // WARNING
                        return "WARNING";
                    case 4: // PERIOD
                        return "PERIOD";
                    case 5: // DETAILEDMESSAGE
                        return "DETAILEDMESSAGE";
                    case 6: // CVT_TYPE
                        return "CVT_TYPE";
                    case 7: // COMMANDNAME
                        return "COMMANDNAME";
                    case 8: // ISENABLED
                        return "ISENABLED";
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
                    case "VCODE":
                        return 1;
                    case "VALIDATIONMESSAGE":
                        return 2;
                    case "WARNING":
                        return 3;
                    case "PERIOD":
                        return 4;
                    case "DETAILEDMESSAGE":
                        return 5;
                    case "CVT_TYPE":
                        return 6;
                    case "COMMANDNAME":
                        return 7;
                    case "ISENABLED":
                        return 8;
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
