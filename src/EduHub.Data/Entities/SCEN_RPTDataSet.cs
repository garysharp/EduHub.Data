using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Report Usage Metadata Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_RPTDataSet : DataSetBase<SCEN_RPT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_RPT"; } }

        internal SCEN_RPTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_RPT>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_RPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_RPT" /> fields for each CSV column header</returns>
        protected override Action<SCEN_RPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_RPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "PROG":
                        mapper[i] = (e, v) => e.PROG = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "REQUIREDPRINCIPALFIELD":
                        mapper[i] = (e, v) => e.REQUIREDPRINCIPALFIELD = v;
                        break;
                    case "ISPRIMARY":
                        mapper[i] = (e, v) => e.ISPRIMARY = v;
                        break;
                    case "ISPRIMARYSECONDARY":
                        mapper[i] = (e, v) => e.ISPRIMARYSECONDARY = v;
                        break;
                    case "ISSECONDARY":
                        mapper[i] = (e, v) => e.ISSECONDARY = v;
                        break;
                    case "ISLANGUAGE":
                        mapper[i] = (e, v) => e.ISLANGUAGE = v;
                        break;
                    case "ISSPECIAL":
                        mapper[i] = (e, v) => e.ISSPECIAL = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_RPT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_RPT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_RPT" /> items to added or update the base <see cref="SCEN_RPT" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_RPT" /> items</returns>
        protected override List<SCEN_RPT> ApplyDeltaItems(List<SCEN_RPT> Items, List<SCEN_RPT> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_RPT deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_RPT>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RPT FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <param name="Value">Related SCEN_RPT entity</param>
        /// <returns>True if the related SCEN_RPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_RPT Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RPT TryFindByID(int ID)
        {
            SCEN_RPT value;
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
        /// Returns SQL which checks for the existence of a SCEN_RPT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_RPT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_RPT](
        [ID] int IDENTITY NOT NULL,
        [TITLE] varchar(255) NULL,
        [PROG] varchar(10) NULL,
        [PERIOD] varchar(1) NULL,
        [REQUIREDPRINCIPALFIELD] varchar(1) NULL,
        [ISPRIMARY] varchar(1) NULL,
        [ISPRIMARYSECONDARY] varchar(1) NULL,
        [ISSECONDARY] varchar(1) NULL,
        [ISLANGUAGE] varchar(1) NULL,
        [ISSPECIAL] varchar(1) NULL,
        CONSTRAINT [SCEN_RPT_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_RPT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_RPT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_RPTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_RPTDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_RPT> Items;
            private int CurrentIndex;
            private SCEN_RPT CurrentItem;

            public SCEN_RPTDataReader(List<SCEN_RPT> Items)
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
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // PROG
                        return CurrentItem.PROG;
                    case 3: // PERIOD
                        return CurrentItem.PERIOD;
                    case 4: // REQUIREDPRINCIPALFIELD
                        return CurrentItem.REQUIREDPRINCIPALFIELD;
                    case 5: // ISPRIMARY
                        return CurrentItem.ISPRIMARY;
                    case 6: // ISPRIMARYSECONDARY
                        return CurrentItem.ISPRIMARYSECONDARY;
                    case 7: // ISSECONDARY
                        return CurrentItem.ISSECONDARY;
                    case 8: // ISLANGUAGE
                        return CurrentItem.ISLANGUAGE;
                    case 9: // ISSPECIAL
                        return CurrentItem.ISSPECIAL;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // PROG
                        return CurrentItem.PROG == null;
                    case 3: // PERIOD
                        return CurrentItem.PERIOD == null;
                    case 4: // REQUIREDPRINCIPALFIELD
                        return CurrentItem.REQUIREDPRINCIPALFIELD == null;
                    case 5: // ISPRIMARY
                        return CurrentItem.ISPRIMARY == null;
                    case 6: // ISPRIMARYSECONDARY
                        return CurrentItem.ISPRIMARYSECONDARY == null;
                    case 7: // ISSECONDARY
                        return CurrentItem.ISSECONDARY == null;
                    case 8: // ISLANGUAGE
                        return CurrentItem.ISLANGUAGE == null;
                    case 9: // ISSPECIAL
                        return CurrentItem.ISSPECIAL == null;
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
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // PROG
                        return "PROG";
                    case 3: // PERIOD
                        return "PERIOD";
                    case 4: // REQUIREDPRINCIPALFIELD
                        return "REQUIREDPRINCIPALFIELD";
                    case 5: // ISPRIMARY
                        return "ISPRIMARY";
                    case 6: // ISPRIMARYSECONDARY
                        return "ISPRIMARYSECONDARY";
                    case 7: // ISSECONDARY
                        return "ISSECONDARY";
                    case 8: // ISLANGUAGE
                        return "ISLANGUAGE";
                    case 9: // ISSPECIAL
                        return "ISSPECIAL";
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
                    case "TITLE":
                        return 1;
                    case "PROG":
                        return 2;
                    case "PERIOD":
                        return 3;
                    case "REQUIREDPRINCIPALFIELD":
                        return 4;
                    case "ISPRIMARY":
                        return 5;
                    case "ISPRIMARYSECONDARY":
                        return 6;
                    case "ISSECONDARY":
                        return 7;
                    case "ISLANGUAGE":
                        return 8;
                    case "ISSPECIAL":
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
