using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees - Billing Templates Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SABDataSet : DataSetBase<SAB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAB"; } }

        internal SABDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_FEE_CODE_1ST = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_1ST));
            Index_FEE_CODE_2ND = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_2ND));
            Index_FEE_CODE_3RD = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_3RD));
            Index_FEE_CODE_4TH = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_4TH));
            Index_FEE_CODE_KG = new Lazy<NullDictionary<string, IReadOnlyList<SAB>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE_KG));
            Index_SABKEY = new Lazy<Dictionary<string, SAB>>(() => this.ToDictionary(i => i.SABKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAB" /> fields for each CSV column header</returns>
        protected override Action<SAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SABKEY":
                        mapper[i] = (e, v) => e.SABKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "BILL_TYPE":
                        mapper[i] = (e, v) => e.BILL_TYPE = v;
                        break;
                    case "FROM_CLASS":
                        mapper[i] = (e, v) => e.FROM_CLASS = v;
                        break;
                    case "TO_CLASS":
                        mapper[i] = (e, v) => e.TO_CLASS = v;
                        break;
                    case "FROM_YEAR":
                        mapper[i] = (e, v) => e.FROM_YEAR = v;
                        break;
                    case "TO_YEAR":
                        mapper[i] = (e, v) => e.TO_YEAR = v;
                        break;
                    case "RES_STATUS":
                        mapper[i] = (e, v) => e.RES_STATUS = v;
                        break;
                    case "FEE_CODE_1ST":
                        mapper[i] = (e, v) => e.FEE_CODE_1ST = v;
                        break;
                    case "FEE_CODE_2ND":
                        mapper[i] = (e, v) => e.FEE_CODE_2ND = v;
                        break;
                    case "FEE_CODE_3RD":
                        mapper[i] = (e, v) => e.FEE_CODE_3RD = v;
                        break;
                    case "FEE_CODE_4TH":
                        mapper[i] = (e, v) => e.FEE_CODE_4TH = v;
                        break;
                    case "FEE_CODE_KG":
                        mapper[i] = (e, v) => e.FEE_CODE_KG = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SAB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAB" /> items to added or update the base <see cref="SAB" /> items</param>
        /// <returns>A merged list of <see cref="SAB" /> items</returns>
        protected override List<SAB> ApplyDeltaItems(List<SAB> Items, List<SAB> DeltaItems)
        {
            Dictionary<string, int> Index_SABKEY = Items.ToIndexDictionary(i => i.SABKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAB deltaItem in DeltaItems)
            {
                int index;

                if (Index_SABKEY.TryGetValue(deltaItem.SABKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SABKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_1ST;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_2ND;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_3RD;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_4TH;
        private Lazy<NullDictionary<string, IReadOnlyList<SAB>>> Index_FEE_CODE_KG;
        private Lazy<Dictionary<string, SAB>> Index_SABKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_1ST(string FEE_CODE_1ST)
        {
            return Index_FEE_CODE_1ST.Value[FEE_CODE_1ST];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_1ST(string FEE_CODE_1ST, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_1ST.Value.TryGetValue(FEE_CODE_1ST, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_1ST field
        /// </summary>
        /// <param name="FEE_CODE_1ST">FEE_CODE_1ST value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_1ST(string FEE_CODE_1ST)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_1ST.Value.TryGetValue(FEE_CODE_1ST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_2ND(string FEE_CODE_2ND)
        {
            return Index_FEE_CODE_2ND.Value[FEE_CODE_2ND];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_2ND(string FEE_CODE_2ND, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_2ND.Value.TryGetValue(FEE_CODE_2ND, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_2ND field
        /// </summary>
        /// <param name="FEE_CODE_2ND">FEE_CODE_2ND value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_2ND(string FEE_CODE_2ND)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_2ND.Value.TryGetValue(FEE_CODE_2ND, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_3RD(string FEE_CODE_3RD)
        {
            return Index_FEE_CODE_3RD.Value[FEE_CODE_3RD];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_3RD(string FEE_CODE_3RD, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_3RD.Value.TryGetValue(FEE_CODE_3RD, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_3RD field
        /// </summary>
        /// <param name="FEE_CODE_3RD">FEE_CODE_3RD value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_3RD(string FEE_CODE_3RD)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_3RD.Value.TryGetValue(FEE_CODE_3RD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_4TH(string FEE_CODE_4TH)
        {
            return Index_FEE_CODE_4TH.Value[FEE_CODE_4TH];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_4TH(string FEE_CODE_4TH, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_4TH.Value.TryGetValue(FEE_CODE_4TH, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_4TH field
        /// </summary>
        /// <param name="FEE_CODE_4TH">FEE_CODE_4TH value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_4TH(string FEE_CODE_4TH)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_4TH.Value.TryGetValue(FEE_CODE_4TH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <returns>List of related SAB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> FindByFEE_CODE_KG(string FEE_CODE_KG)
        {
            return Index_FEE_CODE_KG.Value[FEE_CODE_KG];
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <param name="Value">List of related SAB entities</param>
        /// <returns>True if the list of related SAB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE_KG(string FEE_CODE_KG, out IReadOnlyList<SAB> Value)
        {
            return Index_FEE_CODE_KG.Value.TryGetValue(FEE_CODE_KG, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by FEE_CODE_KG field
        /// </summary>
        /// <param name="FEE_CODE_KG">FEE_CODE_KG value used to find SAB</param>
        /// <returns>List of related SAB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAB> TryFindByFEE_CODE_KG(string FEE_CODE_KG)
        {
            IReadOnlyList<SAB> value;
            if (Index_FEE_CODE_KG.Value.TryGetValue(FEE_CODE_KG, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <returns>Related SAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAB FindBySABKEY(string SABKEY)
        {
            return Index_SABKEY.Value[SABKEY];
        }

        /// <summary>
        /// Attempt to find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <param name="Value">Related SAB entity</param>
        /// <returns>True if the related SAB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySABKEY(string SABKEY, out SAB Value)
        {
            return Index_SABKEY.Value.TryGetValue(SABKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by SABKEY field
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SAB</param>
        /// <returns>Related SAB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAB TryFindBySABKEY(string SABKEY)
        {
            SAB value;
            if (Index_SABKEY.Value.TryGetValue(SABKEY, out value))
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
        /// Returns SQL which checks for the existence of a SAB table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SAB]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SAB](
        [SABKEY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [BILL_TYPE] varchar(10) NULL,
        [FROM_CLASS] varchar(4) NULL,
        [TO_CLASS] varchar(4) NULL,
        [FROM_YEAR] varchar(4) NULL,
        [TO_YEAR] varchar(4) NULL,
        [RES_STATUS] varchar(1) NULL,
        [FEE_CODE_1ST] varchar(10) NULL,
        [FEE_CODE_2ND] varchar(10) NULL,
        [FEE_CODE_3RD] varchar(10) NULL,
        [FEE_CODE_4TH] varchar(10) NULL,
        [FEE_CODE_KG] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SAB_Index_SABKEY] PRIMARY KEY CLUSTERED (
            [SABKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_1ST] ON [dbo].[SAB]
    (
            [FEE_CODE_1ST] ASC
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_2ND] ON [dbo].[SAB]
    (
            [FEE_CODE_2ND] ASC
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_3RD] ON [dbo].[SAB]
    (
            [FEE_CODE_3RD] ASC
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_4TH] ON [dbo].[SAB]
    (
            [FEE_CODE_4TH] ASC
    );
    CREATE NONCLUSTERED INDEX [SAB_Index_FEE_CODE_KG] ON [dbo].[SAB]
    (
            [FEE_CODE_KG] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SAB data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SAB data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SABDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SABDataReader : IDataReader, IDataRecord
        {
            private List<SAB> Items;
            private int CurrentIndex;
            private SAB CurrentItem;

            public SABDataReader(List<SAB> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 16; } }
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
                    case 0: // SABKEY
                        return CurrentItem.SABKEY;
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 2: // BILL_TYPE
                        return CurrentItem.BILL_TYPE;
                    case 3: // FROM_CLASS
                        return CurrentItem.FROM_CLASS;
                    case 4: // TO_CLASS
                        return CurrentItem.TO_CLASS;
                    case 5: // FROM_YEAR
                        return CurrentItem.FROM_YEAR;
                    case 6: // TO_YEAR
                        return CurrentItem.TO_YEAR;
                    case 7: // RES_STATUS
                        return CurrentItem.RES_STATUS;
                    case 8: // FEE_CODE_1ST
                        return CurrentItem.FEE_CODE_1ST;
                    case 9: // FEE_CODE_2ND
                        return CurrentItem.FEE_CODE_2ND;
                    case 10: // FEE_CODE_3RD
                        return CurrentItem.FEE_CODE_3RD;
                    case 11: // FEE_CODE_4TH
                        return CurrentItem.FEE_CODE_4TH;
                    case 12: // FEE_CODE_KG
                        return CurrentItem.FEE_CODE_KG;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 15: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 2: // BILL_TYPE
                        return CurrentItem.BILL_TYPE == null;
                    case 3: // FROM_CLASS
                        return CurrentItem.FROM_CLASS == null;
                    case 4: // TO_CLASS
                        return CurrentItem.TO_CLASS == null;
                    case 5: // FROM_YEAR
                        return CurrentItem.FROM_YEAR == null;
                    case 6: // TO_YEAR
                        return CurrentItem.TO_YEAR == null;
                    case 7: // RES_STATUS
                        return CurrentItem.RES_STATUS == null;
                    case 8: // FEE_CODE_1ST
                        return CurrentItem.FEE_CODE_1ST == null;
                    case 9: // FEE_CODE_2ND
                        return CurrentItem.FEE_CODE_2ND == null;
                    case 10: // FEE_CODE_3RD
                        return CurrentItem.FEE_CODE_3RD == null;
                    case 11: // FEE_CODE_4TH
                        return CurrentItem.FEE_CODE_4TH == null;
                    case 12: // FEE_CODE_KG
                        return CurrentItem.FEE_CODE_KG == null;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 15: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SABKEY
                        return "SABKEY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // BILL_TYPE
                        return "BILL_TYPE";
                    case 3: // FROM_CLASS
                        return "FROM_CLASS";
                    case 4: // TO_CLASS
                        return "TO_CLASS";
                    case 5: // FROM_YEAR
                        return "FROM_YEAR";
                    case 6: // TO_YEAR
                        return "TO_YEAR";
                    case 7: // RES_STATUS
                        return "RES_STATUS";
                    case 8: // FEE_CODE_1ST
                        return "FEE_CODE_1ST";
                    case 9: // FEE_CODE_2ND
                        return "FEE_CODE_2ND";
                    case 10: // FEE_CODE_3RD
                        return "FEE_CODE_3RD";
                    case 11: // FEE_CODE_4TH
                        return "FEE_CODE_4TH";
                    case 12: // FEE_CODE_KG
                        return "FEE_CODE_KG";
                    case 13: // LW_DATE
                        return "LW_DATE";
                    case 14: // LW_TIME
                        return "LW_TIME";
                    case 15: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SABKEY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "BILL_TYPE":
                        return 2;
                    case "FROM_CLASS":
                        return 3;
                    case "TO_CLASS":
                        return 4;
                    case "FROM_YEAR":
                        return 5;
                    case "TO_YEAR":
                        return 6;
                    case "RES_STATUS":
                        return 7;
                    case "FEE_CODE_1ST":
                        return 8;
                    case "FEE_CODE_2ND":
                        return 9;
                    case "FEE_CODE_3RD":
                        return 10;
                    case "FEE_CODE_4TH":
                        return 11;
                    case "FEE_CODE_KG":
                        return 12;
                    case "LW_DATE":
                        return 13;
                    case "LW_TIME":
                        return 14;
                    case "LW_USER":
                        return 15;
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
