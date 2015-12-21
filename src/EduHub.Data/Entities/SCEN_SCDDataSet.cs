using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Column-Display Metadata for displaying Student Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_SCDDataSet : EduHubDataSet<SCEN_SCD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_SCD"; } }

        internal SCEN_SCDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_SCD>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_SCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_SCD" /> fields for each CSV column header</returns>
        protected override Action<SCEN_SCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_SCD, string>[Headers.Count];

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
                    case "DEFAULTCOLUMNDISPLAYWIDTH":
                        mapper[i] = (e, v) => e.DEFAULTCOLUMNDISPLAYWIDTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEFAULTCOLUMNDISPLAYORDER":
                        mapper[i] = (e, v) => e.DEFAULTCOLUMNDISPLAYORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREFERREDCOLUMNDISPLAYWIDTH":
                        mapper[i] = (e, v) => e.PREFERREDCOLUMNDISPLAYWIDTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREFERREDCOLUMNDISPLAYORDER":
                        mapper[i] = (e, v) => e.PREFERREDCOLUMNDISPLAYORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_SCD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_SCD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_SCD" /> items to added or update the base <see cref="SCEN_SCD" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_SCD" /> items</returns>
        protected override List<SCEN_SCD> ApplyDeltaItems(List<SCEN_SCD> Items, List<SCEN_SCD> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_SCD deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_SCD>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <returns>Related SCEN_SCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_SCD FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <param name="Value">Related SCEN_SCD entity</param>
        /// <returns>True if the related SCEN_SCD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_SCD Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <returns>Related SCEN_SCD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_SCD TryFindByID(int ID)
        {
            SCEN_SCD value;
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
        /// Returns SQL which checks for the existence of a SCEN_SCD table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_SCD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_SCD](
        [ID] int IDENTITY NOT NULL,
        [COLUMNNAME] varchar(255) NULL,
        [COLUMNDISPLAYNAME] varchar(255) NULL,
        [DEFAULTCOLUMNDISPLAYWIDTH] smallint NULL,
        [DEFAULTCOLUMNDISPLAYORDER] smallint NULL,
        [PREFERREDCOLUMNDISPLAYWIDTH] smallint NULL,
        [PREFERREDCOLUMNDISPLAYORDER] smallint NULL,
        CONSTRAINT [SCEN_SCD_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_SCD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_SCD data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_SCDDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_SCDDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_SCD> Items;
            private int CurrentIndex;
            private SCEN_SCD CurrentItem;

            public SCEN_SCDDataReader(List<SCEN_SCD> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 7; } }
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
                    case 3: // DEFAULTCOLUMNDISPLAYWIDTH
                        return CurrentItem.DEFAULTCOLUMNDISPLAYWIDTH;
                    case 4: // DEFAULTCOLUMNDISPLAYORDER
                        return CurrentItem.DEFAULTCOLUMNDISPLAYORDER;
                    case 5: // PREFERREDCOLUMNDISPLAYWIDTH
                        return CurrentItem.PREFERREDCOLUMNDISPLAYWIDTH;
                    case 6: // PREFERREDCOLUMNDISPLAYORDER
                        return CurrentItem.PREFERREDCOLUMNDISPLAYORDER;
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
                    case 3: // DEFAULTCOLUMNDISPLAYWIDTH
                        return CurrentItem.DEFAULTCOLUMNDISPLAYWIDTH == null;
                    case 4: // DEFAULTCOLUMNDISPLAYORDER
                        return CurrentItem.DEFAULTCOLUMNDISPLAYORDER == null;
                    case 5: // PREFERREDCOLUMNDISPLAYWIDTH
                        return CurrentItem.PREFERREDCOLUMNDISPLAYWIDTH == null;
                    case 6: // PREFERREDCOLUMNDISPLAYORDER
                        return CurrentItem.PREFERREDCOLUMNDISPLAYORDER == null;
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
                    case 3: // DEFAULTCOLUMNDISPLAYWIDTH
                        return "DEFAULTCOLUMNDISPLAYWIDTH";
                    case 4: // DEFAULTCOLUMNDISPLAYORDER
                        return "DEFAULTCOLUMNDISPLAYORDER";
                    case 5: // PREFERREDCOLUMNDISPLAYWIDTH
                        return "PREFERREDCOLUMNDISPLAYWIDTH";
                    case 6: // PREFERREDCOLUMNDISPLAYORDER
                        return "PREFERREDCOLUMNDISPLAYORDER";
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
                    case "DEFAULTCOLUMNDISPLAYWIDTH":
                        return 3;
                    case "DEFAULTCOLUMNDISPLAYORDER":
                        return 4;
                    case "PREFERREDCOLUMNDISPLAYWIDTH":
                        return 5;
                    case "PREFERREDCOLUMNDISPLAYORDER":
                        return 6;
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
