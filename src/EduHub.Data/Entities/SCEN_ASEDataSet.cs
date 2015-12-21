using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Student Excluded Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ASEDataSet : EduHubDataSet<SCEN_ASE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_ASE"; } }

        internal SCEN_ASEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_ASE>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ASE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ASE" /> fields for each CSV column header</returns>
        protected override Action<SCEN_ASE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_ASE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ASE_TYPE":
                        mapper[i] = (e, v) => e.ASE_TYPE = v;
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
        /// Merges <see cref="SCEN_ASE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_ASE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_ASE" /> items to added or update the base <see cref="SCEN_ASE" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_ASE" /> items</returns>
        protected override List<SCEN_ASE> ApplyDeltaItems(List<SCEN_ASE> Items, List<SCEN_ASE> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_ASE deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_ASE>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_ASE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASE</param>
        /// <returns>Related SCEN_ASE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ASE FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_ASE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASE</param>
        /// <param name="Value">Related SCEN_ASE entity</param>
        /// <returns>True if the related SCEN_ASE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_ASE Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ASE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASE</param>
        /// <returns>Related SCEN_ASE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ASE TryFindByID(int ID)
        {
            SCEN_ASE value;
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
        /// Returns SQL which checks for the existence of a SCEN_ASE table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_ASE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_ASE](
        [ID] int IDENTITY NOT NULL,
        [ID_RETURN] smallint NULL,
        [REGISTRATION] smallint NULL,
        [ASE_TYPE] varchar(1) NULL,
        [CREATEUSER] varchar(128) NULL,
        [CREATED] datetime NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_ASE_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_ASE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ASE data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_ASEDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_ASEDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_ASE> Items;
            private int CurrentIndex;
            private SCEN_ASE CurrentItem;

            public SCEN_ASEDataReader(List<SCEN_ASE> Items)
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
                    case 1: // ID_RETURN
                        return CurrentItem.ID_RETURN;
                    case 2: // REGISTRATION
                        return CurrentItem.REGISTRATION;
                    case 3: // ASE_TYPE
                        return CurrentItem.ASE_TYPE;
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
                    case 1: // ID_RETURN
                        return CurrentItem.ID_RETURN == null;
                    case 2: // REGISTRATION
                        return CurrentItem.REGISTRATION == null;
                    case 3: // ASE_TYPE
                        return CurrentItem.ASE_TYPE == null;
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
                    case 1: // ID_RETURN
                        return "ID_RETURN";
                    case 2: // REGISTRATION
                        return "REGISTRATION";
                    case 3: // ASE_TYPE
                        return "ASE_TYPE";
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
                    case "ID_RETURN":
                        return 1;
                    case "REGISTRATION":
                        return 2;
                    case "ASE_TYPE":
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
