using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Return Summary Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_RTNDataSet : DataSetBase<SCEN_RTN>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_RTN"; } }

        internal SCEN_RTNDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_RTN>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_RTN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_RTN" /> fields for each CSV column header</returns>
        protected override Action<SCEN_RTN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_RTN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "RN_SCHOOLNUMBER":
                        mapper[i] = (e, v) => e.RN_SCHOOLNUMBER = v;
                        break;
                    case "RN_SCHOOLNAME":
                        mapper[i] = (e, v) => e.RN_SCHOOLNAME = v;
                        break;
                    case "RN_SCHOOLTYPE":
                        mapper[i] = (e, v) => e.RN_SCHOOLTYPE = v;
                        break;
                    case "RN_MONTH":
                        mapper[i] = (e, v) => e.RN_MONTH = v;
                        break;
                    case "RN_YEAR":
                        mapper[i] = (e, v) => e.RN_YEAR = v;
                        break;
                    case "RN_STATUS":
                        mapper[i] = (e, v) => e.RN_STATUS = v;
                        break;
                    case "RN_CREATED":
                        mapper[i] = (e, v) => e.RN_CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RN_CREATEUSER":
                        mapper[i] = (e, v) => e.RN_CREATEUSER = v;
                        break;
                    case "RN_LUPDATED":
                        mapper[i] = (e, v) => e.RN_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RN_LUPDATEUSER":
                        mapper[i] = (e, v) => e.RN_LUPDATEUSER = v;
                        break;
                    case "SD_LREFRESHED":
                        mapper[i] = (e, v) => e.SD_LREFRESHED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SD_LVALIDATED":
                        mapper[i] = (e, v) => e.SD_LVALIDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SD_SRPFUNDEDFTE":
                        mapper[i] = (e, v) => e.SD_SRPFUNDEDFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_NOTSRPFUNDEDFTE":
                        mapper[i] = (e, v) => e.SD_NOTSRPFUNDEDFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_TOTALFTE":
                        mapper[i] = (e, v) => e.SD_TOTALFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SD_INCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_INCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_SYSTEMEXCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_SYSTEMEXCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_MANUALLYEXCLUDEDHC":
                        mapper[i] = (e, v) => e.SD_MANUALLYEXCLUDEDHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_TOTALHC":
                        mapper[i] = (e, v) => e.SD_TOTALHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_ERRORCOUNT":
                        mapper[i] = (e, v) => e.SD_ERRORCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_UNPROCESSEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.SD_UNPROCESSEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SD_ACKNOWLEDGEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.SD_ACKNOWLEDGEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_LHMGREFRESHED":
                        mapper[i] = (e, v) => e.CSD_LHMGREFRESHED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_LUPDATED":
                        mapper[i] = (e, v) => e.CSD_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_LUPDATEUSER":
                        mapper[i] = (e, v) => e.CSD_LUPDATEUSER = v;
                        break;
                    case "CSD_LVALIDATED":
                        mapper[i] = (e, v) => e.CSD_LVALIDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CSD_CLASSCOUNT":
                        mapper[i] = (e, v) => e.CSD_CLASSCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_STUDENTHC":
                        mapper[i] = (e, v) => e.CSD_STUDENTHC = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_TEACHERFTE":
                        mapper[i] = (e, v) => e.CSD_TEACHERFTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CSD_ERRORCOUNT":
                        mapper[i] = (e, v) => e.CSD_ERRORCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_UNPROCESSEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.CSD_UNPROCESSEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CSD_ACKNOWLEDGEDWARNINGCOUNT":
                        mapper[i] = (e, v) => e.CSD_ACKNOWLEDGEDWARNINGCOUNT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LD_CONTACTNAME":
                        mapper[i] = (e, v) => e.LD_CONTACTNAME = v;
                        break;
                    case "LD_CONTACTPHONE":
                        mapper[i] = (e, v) => e.LD_CONTACTPHONE = v;
                        break;
                    case "LD_PRINCIPALNAME":
                        mapper[i] = (e, v) => e.LD_PRINCIPALNAME = v;
                        break;
                    case "LD_PRINCIPALPHONE":
                        mapper[i] = (e, v) => e.LD_PRINCIPALPHONE = v;
                        break;
                    case "LD_COMMENTS":
                        mapper[i] = (e, v) => e.LD_COMMENTS = v;
                        break;
                    case "LD_USERCERTIFICATION":
                        mapper[i] = (e, v) => e.LD_USERCERTIFICATION = v;
                        break;
                    case "LD_FINALREPORTLOCATION":
                        mapper[i] = (e, v) => e.LD_FINALREPORTLOCATION = v;
                        break;
                    case "LD_STATUS":
                        mapper[i] = (e, v) => e.LD_STATUS = v;
                        break;
                    case "LD_CREATED":
                        mapper[i] = (e, v) => e.LD_CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LODGED":
                        mapper[i] = (e, v) => e.LD_LODGED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LUPDATEUSER":
                        mapper[i] = (e, v) => e.LD_LUPDATEUSER = v;
                        break;
                    case "LD_LUPDATED":
                        mapper[i] = (e, v) => e.LD_LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_RTN" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_RTN" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_RTN" /> items to added or update the base <see cref="SCEN_RTN" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_RTN" /> items</returns>
        protected override List<SCEN_RTN> ApplyDeltaItems(List<SCEN_RTN> Items, List<SCEN_RTN> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_RTN deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_RTN>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_RTN by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RTN</param>
        /// <returns>Related SCEN_RTN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RTN FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_RTN by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RTN</param>
        /// <param name="Value">Related SCEN_RTN entity</param>
        /// <returns>True if the related SCEN_RTN entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_RTN Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RTN by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RTN</param>
        /// <returns>Related SCEN_RTN entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RTN TryFindByID(int ID)
        {
            SCEN_RTN value;
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
        /// Returns SQL which checks for the existence of a SCEN_RTN table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_RTN]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_RTN](
        [ID] int IDENTITY NOT NULL,
        [RN_SCHOOLNUMBER] varchar(4) NULL,
        [RN_SCHOOLNAME] varchar(40) NULL,
        [RN_SCHOOLTYPE] varchar(40) NULL,
        [RN_MONTH] varchar(10) NULL,
        [RN_YEAR] varchar(4) NULL,
        [RN_STATUS] varchar(1) NULL,
        [RN_CREATED] datetime NULL,
        [RN_CREATEUSER] varchar(128) NULL,
        [RN_LUPDATED] datetime NULL,
        [RN_LUPDATEUSER] varchar(128) NULL,
        [SD_LREFRESHED] datetime NULL,
        [SD_LVALIDATED] datetime NULL,
        [SD_SRPFUNDEDFTE] float NULL,
        [SD_NOTSRPFUNDEDFTE] float NULL,
        [SD_TOTALFTE] float NULL,
        [SD_INCLUDEDHC] smallint NULL,
        [SD_SYSTEMEXCLUDEDHC] smallint NULL,
        [SD_MANUALLYEXCLUDEDHC] smallint NULL,
        [SD_TOTALHC] smallint NULL,
        [SD_ERRORCOUNT] smallint NULL,
        [SD_UNPROCESSEDWARNINGCOUNT] smallint NULL,
        [SD_ACKNOWLEDGEDWARNINGCOUNT] smallint NULL,
        [CSD_LHMGREFRESHED] datetime NULL,
        [CSD_LUPDATED] datetime NULL,
        [CSD_LUPDATEUSER] varchar(128) NULL,
        [CSD_LVALIDATED] datetime NULL,
        [CSD_CLASSCOUNT] smallint NULL,
        [CSD_STUDENTHC] smallint NULL,
        [CSD_TEACHERFTE] float NULL,
        [CSD_ERRORCOUNT] smallint NULL,
        [CSD_UNPROCESSEDWARNINGCOUNT] smallint NULL,
        [CSD_ACKNOWLEDGEDWARNINGCOUNT] smallint NULL,
        [LD_CONTACTNAME] varchar(80) NULL,
        [LD_CONTACTPHONE] varchar(20) NULL,
        [LD_PRINCIPALNAME] varchar(80) NULL,
        [LD_PRINCIPALPHONE] varchar(20) NULL,
        [LD_COMMENTS] varchar(255) NULL,
        [LD_USERCERTIFICATION] varchar(1) NULL,
        [LD_FINALREPORTLOCATION] varchar(255) NULL,
        [LD_STATUS] varchar(1) NULL,
        [LD_CREATED] datetime NULL,
        [LD_LODGED] datetime NULL,
        [LD_LUPDATEUSER] varchar(128) NULL,
        [LD_LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_RTN_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_RTN data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_RTN data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SCEN_RTNDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_RTNDataReader : IDataReader, IDataRecord
        {
            private List<SCEN_RTN> Items;
            private int CurrentIndex;
            private SCEN_RTN CurrentItem;

            public SCEN_RTNDataReader(List<SCEN_RTN> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 45; } }
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
                    case 1: // RN_SCHOOLNUMBER
                        return CurrentItem.RN_SCHOOLNUMBER;
                    case 2: // RN_SCHOOLNAME
                        return CurrentItem.RN_SCHOOLNAME;
                    case 3: // RN_SCHOOLTYPE
                        return CurrentItem.RN_SCHOOLTYPE;
                    case 4: // RN_MONTH
                        return CurrentItem.RN_MONTH;
                    case 5: // RN_YEAR
                        return CurrentItem.RN_YEAR;
                    case 6: // RN_STATUS
                        return CurrentItem.RN_STATUS;
                    case 7: // RN_CREATED
                        return CurrentItem.RN_CREATED;
                    case 8: // RN_CREATEUSER
                        return CurrentItem.RN_CREATEUSER;
                    case 9: // RN_LUPDATED
                        return CurrentItem.RN_LUPDATED;
                    case 10: // RN_LUPDATEUSER
                        return CurrentItem.RN_LUPDATEUSER;
                    case 11: // SD_LREFRESHED
                        return CurrentItem.SD_LREFRESHED;
                    case 12: // SD_LVALIDATED
                        return CurrentItem.SD_LVALIDATED;
                    case 13: // SD_SRPFUNDEDFTE
                        return CurrentItem.SD_SRPFUNDEDFTE;
                    case 14: // SD_NOTSRPFUNDEDFTE
                        return CurrentItem.SD_NOTSRPFUNDEDFTE;
                    case 15: // SD_TOTALFTE
                        return CurrentItem.SD_TOTALFTE;
                    case 16: // SD_INCLUDEDHC
                        return CurrentItem.SD_INCLUDEDHC;
                    case 17: // SD_SYSTEMEXCLUDEDHC
                        return CurrentItem.SD_SYSTEMEXCLUDEDHC;
                    case 18: // SD_MANUALLYEXCLUDEDHC
                        return CurrentItem.SD_MANUALLYEXCLUDEDHC;
                    case 19: // SD_TOTALHC
                        return CurrentItem.SD_TOTALHC;
                    case 20: // SD_ERRORCOUNT
                        return CurrentItem.SD_ERRORCOUNT;
                    case 21: // SD_UNPROCESSEDWARNINGCOUNT
                        return CurrentItem.SD_UNPROCESSEDWARNINGCOUNT;
                    case 22: // SD_ACKNOWLEDGEDWARNINGCOUNT
                        return CurrentItem.SD_ACKNOWLEDGEDWARNINGCOUNT;
                    case 23: // CSD_LHMGREFRESHED
                        return CurrentItem.CSD_LHMGREFRESHED;
                    case 24: // CSD_LUPDATED
                        return CurrentItem.CSD_LUPDATED;
                    case 25: // CSD_LUPDATEUSER
                        return CurrentItem.CSD_LUPDATEUSER;
                    case 26: // CSD_LVALIDATED
                        return CurrentItem.CSD_LVALIDATED;
                    case 27: // CSD_CLASSCOUNT
                        return CurrentItem.CSD_CLASSCOUNT;
                    case 28: // CSD_STUDENTHC
                        return CurrentItem.CSD_STUDENTHC;
                    case 29: // CSD_TEACHERFTE
                        return CurrentItem.CSD_TEACHERFTE;
                    case 30: // CSD_ERRORCOUNT
                        return CurrentItem.CSD_ERRORCOUNT;
                    case 31: // CSD_UNPROCESSEDWARNINGCOUNT
                        return CurrentItem.CSD_UNPROCESSEDWARNINGCOUNT;
                    case 32: // CSD_ACKNOWLEDGEDWARNINGCOUNT
                        return CurrentItem.CSD_ACKNOWLEDGEDWARNINGCOUNT;
                    case 33: // LD_CONTACTNAME
                        return CurrentItem.LD_CONTACTNAME;
                    case 34: // LD_CONTACTPHONE
                        return CurrentItem.LD_CONTACTPHONE;
                    case 35: // LD_PRINCIPALNAME
                        return CurrentItem.LD_PRINCIPALNAME;
                    case 36: // LD_PRINCIPALPHONE
                        return CurrentItem.LD_PRINCIPALPHONE;
                    case 37: // LD_COMMENTS
                        return CurrentItem.LD_COMMENTS;
                    case 38: // LD_USERCERTIFICATION
                        return CurrentItem.LD_USERCERTIFICATION;
                    case 39: // LD_FINALREPORTLOCATION
                        return CurrentItem.LD_FINALREPORTLOCATION;
                    case 40: // LD_STATUS
                        return CurrentItem.LD_STATUS;
                    case 41: // LD_CREATED
                        return CurrentItem.LD_CREATED;
                    case 42: // LD_LODGED
                        return CurrentItem.LD_LODGED;
                    case 43: // LD_LUPDATEUSER
                        return CurrentItem.LD_LUPDATEUSER;
                    case 44: // LD_LUPDATED
                        return CurrentItem.LD_LUPDATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // RN_SCHOOLNUMBER
                        return CurrentItem.RN_SCHOOLNUMBER == null;
                    case 2: // RN_SCHOOLNAME
                        return CurrentItem.RN_SCHOOLNAME == null;
                    case 3: // RN_SCHOOLTYPE
                        return CurrentItem.RN_SCHOOLTYPE == null;
                    case 4: // RN_MONTH
                        return CurrentItem.RN_MONTH == null;
                    case 5: // RN_YEAR
                        return CurrentItem.RN_YEAR == null;
                    case 6: // RN_STATUS
                        return CurrentItem.RN_STATUS == null;
                    case 7: // RN_CREATED
                        return CurrentItem.RN_CREATED == null;
                    case 8: // RN_CREATEUSER
                        return CurrentItem.RN_CREATEUSER == null;
                    case 9: // RN_LUPDATED
                        return CurrentItem.RN_LUPDATED == null;
                    case 10: // RN_LUPDATEUSER
                        return CurrentItem.RN_LUPDATEUSER == null;
                    case 11: // SD_LREFRESHED
                        return CurrentItem.SD_LREFRESHED == null;
                    case 12: // SD_LVALIDATED
                        return CurrentItem.SD_LVALIDATED == null;
                    case 13: // SD_SRPFUNDEDFTE
                        return CurrentItem.SD_SRPFUNDEDFTE == null;
                    case 14: // SD_NOTSRPFUNDEDFTE
                        return CurrentItem.SD_NOTSRPFUNDEDFTE == null;
                    case 15: // SD_TOTALFTE
                        return CurrentItem.SD_TOTALFTE == null;
                    case 16: // SD_INCLUDEDHC
                        return CurrentItem.SD_INCLUDEDHC == null;
                    case 17: // SD_SYSTEMEXCLUDEDHC
                        return CurrentItem.SD_SYSTEMEXCLUDEDHC == null;
                    case 18: // SD_MANUALLYEXCLUDEDHC
                        return CurrentItem.SD_MANUALLYEXCLUDEDHC == null;
                    case 19: // SD_TOTALHC
                        return CurrentItem.SD_TOTALHC == null;
                    case 20: // SD_ERRORCOUNT
                        return CurrentItem.SD_ERRORCOUNT == null;
                    case 21: // SD_UNPROCESSEDWARNINGCOUNT
                        return CurrentItem.SD_UNPROCESSEDWARNINGCOUNT == null;
                    case 22: // SD_ACKNOWLEDGEDWARNINGCOUNT
                        return CurrentItem.SD_ACKNOWLEDGEDWARNINGCOUNT == null;
                    case 23: // CSD_LHMGREFRESHED
                        return CurrentItem.CSD_LHMGREFRESHED == null;
                    case 24: // CSD_LUPDATED
                        return CurrentItem.CSD_LUPDATED == null;
                    case 25: // CSD_LUPDATEUSER
                        return CurrentItem.CSD_LUPDATEUSER == null;
                    case 26: // CSD_LVALIDATED
                        return CurrentItem.CSD_LVALIDATED == null;
                    case 27: // CSD_CLASSCOUNT
                        return CurrentItem.CSD_CLASSCOUNT == null;
                    case 28: // CSD_STUDENTHC
                        return CurrentItem.CSD_STUDENTHC == null;
                    case 29: // CSD_TEACHERFTE
                        return CurrentItem.CSD_TEACHERFTE == null;
                    case 30: // CSD_ERRORCOUNT
                        return CurrentItem.CSD_ERRORCOUNT == null;
                    case 31: // CSD_UNPROCESSEDWARNINGCOUNT
                        return CurrentItem.CSD_UNPROCESSEDWARNINGCOUNT == null;
                    case 32: // CSD_ACKNOWLEDGEDWARNINGCOUNT
                        return CurrentItem.CSD_ACKNOWLEDGEDWARNINGCOUNT == null;
                    case 33: // LD_CONTACTNAME
                        return CurrentItem.LD_CONTACTNAME == null;
                    case 34: // LD_CONTACTPHONE
                        return CurrentItem.LD_CONTACTPHONE == null;
                    case 35: // LD_PRINCIPALNAME
                        return CurrentItem.LD_PRINCIPALNAME == null;
                    case 36: // LD_PRINCIPALPHONE
                        return CurrentItem.LD_PRINCIPALPHONE == null;
                    case 37: // LD_COMMENTS
                        return CurrentItem.LD_COMMENTS == null;
                    case 38: // LD_USERCERTIFICATION
                        return CurrentItem.LD_USERCERTIFICATION == null;
                    case 39: // LD_FINALREPORTLOCATION
                        return CurrentItem.LD_FINALREPORTLOCATION == null;
                    case 40: // LD_STATUS
                        return CurrentItem.LD_STATUS == null;
                    case 41: // LD_CREATED
                        return CurrentItem.LD_CREATED == null;
                    case 42: // LD_LODGED
                        return CurrentItem.LD_LODGED == null;
                    case 43: // LD_LUPDATEUSER
                        return CurrentItem.LD_LUPDATEUSER == null;
                    case 44: // LD_LUPDATED
                        return CurrentItem.LD_LUPDATED == null;
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
                    case 1: // RN_SCHOOLNUMBER
                        return "RN_SCHOOLNUMBER";
                    case 2: // RN_SCHOOLNAME
                        return "RN_SCHOOLNAME";
                    case 3: // RN_SCHOOLTYPE
                        return "RN_SCHOOLTYPE";
                    case 4: // RN_MONTH
                        return "RN_MONTH";
                    case 5: // RN_YEAR
                        return "RN_YEAR";
                    case 6: // RN_STATUS
                        return "RN_STATUS";
                    case 7: // RN_CREATED
                        return "RN_CREATED";
                    case 8: // RN_CREATEUSER
                        return "RN_CREATEUSER";
                    case 9: // RN_LUPDATED
                        return "RN_LUPDATED";
                    case 10: // RN_LUPDATEUSER
                        return "RN_LUPDATEUSER";
                    case 11: // SD_LREFRESHED
                        return "SD_LREFRESHED";
                    case 12: // SD_LVALIDATED
                        return "SD_LVALIDATED";
                    case 13: // SD_SRPFUNDEDFTE
                        return "SD_SRPFUNDEDFTE";
                    case 14: // SD_NOTSRPFUNDEDFTE
                        return "SD_NOTSRPFUNDEDFTE";
                    case 15: // SD_TOTALFTE
                        return "SD_TOTALFTE";
                    case 16: // SD_INCLUDEDHC
                        return "SD_INCLUDEDHC";
                    case 17: // SD_SYSTEMEXCLUDEDHC
                        return "SD_SYSTEMEXCLUDEDHC";
                    case 18: // SD_MANUALLYEXCLUDEDHC
                        return "SD_MANUALLYEXCLUDEDHC";
                    case 19: // SD_TOTALHC
                        return "SD_TOTALHC";
                    case 20: // SD_ERRORCOUNT
                        return "SD_ERRORCOUNT";
                    case 21: // SD_UNPROCESSEDWARNINGCOUNT
                        return "SD_UNPROCESSEDWARNINGCOUNT";
                    case 22: // SD_ACKNOWLEDGEDWARNINGCOUNT
                        return "SD_ACKNOWLEDGEDWARNINGCOUNT";
                    case 23: // CSD_LHMGREFRESHED
                        return "CSD_LHMGREFRESHED";
                    case 24: // CSD_LUPDATED
                        return "CSD_LUPDATED";
                    case 25: // CSD_LUPDATEUSER
                        return "CSD_LUPDATEUSER";
                    case 26: // CSD_LVALIDATED
                        return "CSD_LVALIDATED";
                    case 27: // CSD_CLASSCOUNT
                        return "CSD_CLASSCOUNT";
                    case 28: // CSD_STUDENTHC
                        return "CSD_STUDENTHC";
                    case 29: // CSD_TEACHERFTE
                        return "CSD_TEACHERFTE";
                    case 30: // CSD_ERRORCOUNT
                        return "CSD_ERRORCOUNT";
                    case 31: // CSD_UNPROCESSEDWARNINGCOUNT
                        return "CSD_UNPROCESSEDWARNINGCOUNT";
                    case 32: // CSD_ACKNOWLEDGEDWARNINGCOUNT
                        return "CSD_ACKNOWLEDGEDWARNINGCOUNT";
                    case 33: // LD_CONTACTNAME
                        return "LD_CONTACTNAME";
                    case 34: // LD_CONTACTPHONE
                        return "LD_CONTACTPHONE";
                    case 35: // LD_PRINCIPALNAME
                        return "LD_PRINCIPALNAME";
                    case 36: // LD_PRINCIPALPHONE
                        return "LD_PRINCIPALPHONE";
                    case 37: // LD_COMMENTS
                        return "LD_COMMENTS";
                    case 38: // LD_USERCERTIFICATION
                        return "LD_USERCERTIFICATION";
                    case 39: // LD_FINALREPORTLOCATION
                        return "LD_FINALREPORTLOCATION";
                    case 40: // LD_STATUS
                        return "LD_STATUS";
                    case 41: // LD_CREATED
                        return "LD_CREATED";
                    case 42: // LD_LODGED
                        return "LD_LODGED";
                    case 43: // LD_LUPDATEUSER
                        return "LD_LUPDATEUSER";
                    case 44: // LD_LUPDATED
                        return "LD_LUPDATED";
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
                    case "RN_SCHOOLNUMBER":
                        return 1;
                    case "RN_SCHOOLNAME":
                        return 2;
                    case "RN_SCHOOLTYPE":
                        return 3;
                    case "RN_MONTH":
                        return 4;
                    case "RN_YEAR":
                        return 5;
                    case "RN_STATUS":
                        return 6;
                    case "RN_CREATED":
                        return 7;
                    case "RN_CREATEUSER":
                        return 8;
                    case "RN_LUPDATED":
                        return 9;
                    case "RN_LUPDATEUSER":
                        return 10;
                    case "SD_LREFRESHED":
                        return 11;
                    case "SD_LVALIDATED":
                        return 12;
                    case "SD_SRPFUNDEDFTE":
                        return 13;
                    case "SD_NOTSRPFUNDEDFTE":
                        return 14;
                    case "SD_TOTALFTE":
                        return 15;
                    case "SD_INCLUDEDHC":
                        return 16;
                    case "SD_SYSTEMEXCLUDEDHC":
                        return 17;
                    case "SD_MANUALLYEXCLUDEDHC":
                        return 18;
                    case "SD_TOTALHC":
                        return 19;
                    case "SD_ERRORCOUNT":
                        return 20;
                    case "SD_UNPROCESSEDWARNINGCOUNT":
                        return 21;
                    case "SD_ACKNOWLEDGEDWARNINGCOUNT":
                        return 22;
                    case "CSD_LHMGREFRESHED":
                        return 23;
                    case "CSD_LUPDATED":
                        return 24;
                    case "CSD_LUPDATEUSER":
                        return 25;
                    case "CSD_LVALIDATED":
                        return 26;
                    case "CSD_CLASSCOUNT":
                        return 27;
                    case "CSD_STUDENTHC":
                        return 28;
                    case "CSD_TEACHERFTE":
                        return 29;
                    case "CSD_ERRORCOUNT":
                        return 30;
                    case "CSD_UNPROCESSEDWARNINGCOUNT":
                        return 31;
                    case "CSD_ACKNOWLEDGEDWARNINGCOUNT":
                        return 32;
                    case "LD_CONTACTNAME":
                        return 33;
                    case "LD_CONTACTPHONE":
                        return 34;
                    case "LD_PRINCIPALNAME":
                        return 35;
                    case "LD_PRINCIPALPHONE":
                        return 36;
                    case "LD_COMMENTS":
                        return 37;
                    case "LD_USERCERTIFICATION":
                        return 38;
                    case "LD_FINALREPORTLOCATION":
                        return 39;
                    case "LD_STATUS":
                        return 40;
                    case "LD_CREATED":
                        return 41;
                    case "LD_LODGED":
                        return 42;
                    case "LD_LUPDATEUSER":
                        return 43;
                    case "LD_LUPDATED":
                        return 44;
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
