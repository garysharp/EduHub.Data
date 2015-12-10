using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Class Sizes Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ACLDataSet : DataSetBase<SCEN_ACL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_ACL"; } }

        internal SCEN_ACLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_ACL>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ACL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ACL" /> fields for each CSV column header</returns>
        protected override Action<SCEN_ACL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_ACL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CAMPUSNUMBER":
                        mapper[i] = (e, v) => e.CAMPUSNUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASSCODE":
                        mapper[i] = (e, v) => e.CLASSCODE = v;
                        break;
                    case "CLASSTYPE":
                        mapper[i] = (e, v) => e.CLASSTYPE = v;
                        break;
                    case "FTETEACHERS":
                        mapper[i] = (e, v) => e.FTETEACHERS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PREP":
                        mapper[i] = (e, v) => e.PREP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR01":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR02":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR03":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR04":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR05":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR06":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR07":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR08":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR09":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR10":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR11":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR12":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRIMARYUG":
                        mapper[i] = (e, v) => e.PRIMARYUG = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SENIORUG":
                        mapper[i] = (e, v) => e.SENIORUG = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
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
        /// Merges <see cref="SCEN_ACL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_ACL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_ACL" /> items to added or update the base <see cref="SCEN_ACL" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_ACL" /> items</returns>
        protected override List<SCEN_ACL> ApplyDeltaItems(List<SCEN_ACL> Items, List<SCEN_ACL> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_ACL deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_ACL>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <returns>Related SCEN_ACL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ACL FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <param name="Value">Related SCEN_ACL entity</param>
        /// <returns>True if the related SCEN_ACL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_ACL Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <returns>Related SCEN_ACL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ACL TryFindByID(int ID)
        {
            SCEN_ACL value;
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
        /// Returns SQL which checks for the existence of a SCEN_ACL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_ACL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_ACL](
        [ID] int IDENTITY NOT NULL,
        [ID_RETURN] int NULL,
        [CAMPUSNUMBER] smallint NULL,
        [CLASSCODE] varchar(5) NULL,
        [CLASSTYPE] varchar(3) NULL,
        [FTETEACHERS] float NULL,
        [PREP] smallint NULL,
        [SCHOOL_YEAR01] smallint NULL,
        [SCHOOL_YEAR02] smallint NULL,
        [SCHOOL_YEAR03] smallint NULL,
        [SCHOOL_YEAR04] smallint NULL,
        [SCHOOL_YEAR05] smallint NULL,
        [SCHOOL_YEAR06] smallint NULL,
        [SCHOOL_YEAR07] smallint NULL,
        [SCHOOL_YEAR08] smallint NULL,
        [SCHOOL_YEAR09] smallint NULL,
        [SCHOOL_YEAR10] smallint NULL,
        [SCHOOL_YEAR11] smallint NULL,
        [SCHOOL_YEAR12] smallint NULL,
        [PRIMARYUG] smallint NULL,
        [SENIORUG] smallint NULL,
        [CREATED] datetime NULL,
        [CREATEUSER] varchar(128) NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_ACL_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_ACL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ACL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_ACLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_ACLDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_ACL> Items;
            private int CurrentIndex;
            private SCEN_ACL CurrentItem;

            public SCEN_ACLDataReader(List<SCEN_ACL> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 25; } }
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
                    case 2: // CAMPUSNUMBER
                        return CurrentItem.CAMPUSNUMBER;
                    case 3: // CLASSCODE
                        return CurrentItem.CLASSCODE;
                    case 4: // CLASSTYPE
                        return CurrentItem.CLASSTYPE;
                    case 5: // FTETEACHERS
                        return CurrentItem.FTETEACHERS;
                    case 6: // PREP
                        return CurrentItem.PREP;
                    case 7: // SCHOOL_YEAR01
                        return CurrentItem.SCHOOL_YEAR01;
                    case 8: // SCHOOL_YEAR02
                        return CurrentItem.SCHOOL_YEAR02;
                    case 9: // SCHOOL_YEAR03
                        return CurrentItem.SCHOOL_YEAR03;
                    case 10: // SCHOOL_YEAR04
                        return CurrentItem.SCHOOL_YEAR04;
                    case 11: // SCHOOL_YEAR05
                        return CurrentItem.SCHOOL_YEAR05;
                    case 12: // SCHOOL_YEAR06
                        return CurrentItem.SCHOOL_YEAR06;
                    case 13: // SCHOOL_YEAR07
                        return CurrentItem.SCHOOL_YEAR07;
                    case 14: // SCHOOL_YEAR08
                        return CurrentItem.SCHOOL_YEAR08;
                    case 15: // SCHOOL_YEAR09
                        return CurrentItem.SCHOOL_YEAR09;
                    case 16: // SCHOOL_YEAR10
                        return CurrentItem.SCHOOL_YEAR10;
                    case 17: // SCHOOL_YEAR11
                        return CurrentItem.SCHOOL_YEAR11;
                    case 18: // SCHOOL_YEAR12
                        return CurrentItem.SCHOOL_YEAR12;
                    case 19: // PRIMARYUG
                        return CurrentItem.PRIMARYUG;
                    case 20: // SENIORUG
                        return CurrentItem.SENIORUG;
                    case 21: // CREATED
                        return CurrentItem.CREATED;
                    case 22: // CREATEUSER
                        return CurrentItem.CREATEUSER;
                    case 23: // LUPDATEUSER
                        return CurrentItem.LUPDATEUSER;
                    case 24: // LUPDATED
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
                    case 2: // CAMPUSNUMBER
                        return CurrentItem.CAMPUSNUMBER == null;
                    case 3: // CLASSCODE
                        return CurrentItem.CLASSCODE == null;
                    case 4: // CLASSTYPE
                        return CurrentItem.CLASSTYPE == null;
                    case 5: // FTETEACHERS
                        return CurrentItem.FTETEACHERS == null;
                    case 6: // PREP
                        return CurrentItem.PREP == null;
                    case 7: // SCHOOL_YEAR01
                        return CurrentItem.SCHOOL_YEAR01 == null;
                    case 8: // SCHOOL_YEAR02
                        return CurrentItem.SCHOOL_YEAR02 == null;
                    case 9: // SCHOOL_YEAR03
                        return CurrentItem.SCHOOL_YEAR03 == null;
                    case 10: // SCHOOL_YEAR04
                        return CurrentItem.SCHOOL_YEAR04 == null;
                    case 11: // SCHOOL_YEAR05
                        return CurrentItem.SCHOOL_YEAR05 == null;
                    case 12: // SCHOOL_YEAR06
                        return CurrentItem.SCHOOL_YEAR06 == null;
                    case 13: // SCHOOL_YEAR07
                        return CurrentItem.SCHOOL_YEAR07 == null;
                    case 14: // SCHOOL_YEAR08
                        return CurrentItem.SCHOOL_YEAR08 == null;
                    case 15: // SCHOOL_YEAR09
                        return CurrentItem.SCHOOL_YEAR09 == null;
                    case 16: // SCHOOL_YEAR10
                        return CurrentItem.SCHOOL_YEAR10 == null;
                    case 17: // SCHOOL_YEAR11
                        return CurrentItem.SCHOOL_YEAR11 == null;
                    case 18: // SCHOOL_YEAR12
                        return CurrentItem.SCHOOL_YEAR12 == null;
                    case 19: // PRIMARYUG
                        return CurrentItem.PRIMARYUG == null;
                    case 20: // SENIORUG
                        return CurrentItem.SENIORUG == null;
                    case 21: // CREATED
                        return CurrentItem.CREATED == null;
                    case 22: // CREATEUSER
                        return CurrentItem.CREATEUSER == null;
                    case 23: // LUPDATEUSER
                        return CurrentItem.LUPDATEUSER == null;
                    case 24: // LUPDATED
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
                    case 2: // CAMPUSNUMBER
                        return "CAMPUSNUMBER";
                    case 3: // CLASSCODE
                        return "CLASSCODE";
                    case 4: // CLASSTYPE
                        return "CLASSTYPE";
                    case 5: // FTETEACHERS
                        return "FTETEACHERS";
                    case 6: // PREP
                        return "PREP";
                    case 7: // SCHOOL_YEAR01
                        return "SCHOOL_YEAR01";
                    case 8: // SCHOOL_YEAR02
                        return "SCHOOL_YEAR02";
                    case 9: // SCHOOL_YEAR03
                        return "SCHOOL_YEAR03";
                    case 10: // SCHOOL_YEAR04
                        return "SCHOOL_YEAR04";
                    case 11: // SCHOOL_YEAR05
                        return "SCHOOL_YEAR05";
                    case 12: // SCHOOL_YEAR06
                        return "SCHOOL_YEAR06";
                    case 13: // SCHOOL_YEAR07
                        return "SCHOOL_YEAR07";
                    case 14: // SCHOOL_YEAR08
                        return "SCHOOL_YEAR08";
                    case 15: // SCHOOL_YEAR09
                        return "SCHOOL_YEAR09";
                    case 16: // SCHOOL_YEAR10
                        return "SCHOOL_YEAR10";
                    case 17: // SCHOOL_YEAR11
                        return "SCHOOL_YEAR11";
                    case 18: // SCHOOL_YEAR12
                        return "SCHOOL_YEAR12";
                    case 19: // PRIMARYUG
                        return "PRIMARYUG";
                    case 20: // SENIORUG
                        return "SENIORUG";
                    case 21: // CREATED
                        return "CREATED";
                    case 22: // CREATEUSER
                        return "CREATEUSER";
                    case 23: // LUPDATEUSER
                        return "LUPDATEUSER";
                    case 24: // LUPDATED
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
                    case "CAMPUSNUMBER":
                        return 2;
                    case "CLASSCODE":
                        return 3;
                    case "CLASSTYPE":
                        return 4;
                    case "FTETEACHERS":
                        return 5;
                    case "PREP":
                        return 6;
                    case "SCHOOL_YEAR01":
                        return 7;
                    case "SCHOOL_YEAR02":
                        return 8;
                    case "SCHOOL_YEAR03":
                        return 9;
                    case "SCHOOL_YEAR04":
                        return 10;
                    case "SCHOOL_YEAR05":
                        return 11;
                    case "SCHOOL_YEAR06":
                        return 12;
                    case "SCHOOL_YEAR07":
                        return 13;
                    case "SCHOOL_YEAR08":
                        return 14;
                    case "SCHOOL_YEAR09":
                        return 15;
                    case "SCHOOL_YEAR10":
                        return 16;
                    case "SCHOOL_YEAR11":
                        return 17;
                    case "SCHOOL_YEAR12":
                        return 18;
                    case "PRIMARYUG":
                        return 19;
                    case "SENIORUG":
                        return 20;
                    case "CREATED":
                        return 21;
                    case "CREATEUSER":
                        return 22;
                    case "LUPDATEUSER":
                        return 23;
                    case "LUPDATED":
                        return 24;
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
