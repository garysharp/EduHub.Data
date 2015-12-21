using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLDataSet : EduHubDataSet<GL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GL"; } }

        internal GLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, GL>>(() => this.ToDictionary(i => i.CODE));
            Index_GL_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<GL>>>(() => this.ToGroupedNullDictionary(i => i.GL_TYPE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GL" /> fields for each CSV column header</returns>
        protected override Action<GL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LYROPBAL":
                        mapper[i] = (e, v) => e.LYROPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR01":
                        mapper[i] = (e, v) => e.LASTYR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR02":
                        mapper[i] = (e, v) => e.LASTYR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR03":
                        mapper[i] = (e, v) => e.LASTYR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR04":
                        mapper[i] = (e, v) => e.LASTYR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR05":
                        mapper[i] = (e, v) => e.LASTYR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR06":
                        mapper[i] = (e, v) => e.LASTYR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR07":
                        mapper[i] = (e, v) => e.LASTYR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR08":
                        mapper[i] = (e, v) => e.LASTYR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR09":
                        mapper[i] = (e, v) => e.LASTYR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR10":
                        mapper[i] = (e, v) => e.LASTYR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR11":
                        mapper[i] = (e, v) => e.LASTYR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR12":
                        mapper[i] = (e, v) => e.LASTYR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR01":
                        mapper[i] = (e, v) => e.CURR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR02":
                        mapper[i] = (e, v) => e.CURR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR03":
                        mapper[i] = (e, v) => e.CURR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR04":
                        mapper[i] = (e, v) => e.CURR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR05":
                        mapper[i] = (e, v) => e.CURR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR06":
                        mapper[i] = (e, v) => e.CURR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR07":
                        mapper[i] = (e, v) => e.CURR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR08":
                        mapper[i] = (e, v) => e.CURR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR09":
                        mapper[i] = (e, v) => e.CURR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR10":
                        mapper[i] = (e, v) => e.CURR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR11":
                        mapper[i] = (e, v) => e.CURR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR12":
                        mapper[i] = (e, v) => e.CURR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG01":
                        mapper[i] = (e, v) => e.BUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG02":
                        mapper[i] = (e, v) => e.BUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG03":
                        mapper[i] = (e, v) => e.BUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG04":
                        mapper[i] = (e, v) => e.BUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG05":
                        mapper[i] = (e, v) => e.BUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG06":
                        mapper[i] = (e, v) => e.BUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG07":
                        mapper[i] = (e, v) => e.BUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG08":
                        mapper[i] = (e, v) => e.BUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG09":
                        mapper[i] = (e, v) => e.BUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG10":
                        mapper[i] = (e, v) => e.BUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG11":
                        mapper[i] = (e, v) => e.BUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG12":
                        mapper[i] = (e, v) => e.BUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG01":
                        mapper[i] = (e, v) => e.NEXTBUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG02":
                        mapper[i] = (e, v) => e.NEXTBUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG03":
                        mapper[i] = (e, v) => e.NEXTBUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG04":
                        mapper[i] = (e, v) => e.NEXTBUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG05":
                        mapper[i] = (e, v) => e.NEXTBUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG06":
                        mapper[i] = (e, v) => e.NEXTBUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG07":
                        mapper[i] = (e, v) => e.NEXTBUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG08":
                        mapper[i] = (e, v) => e.NEXTBUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG09":
                        mapper[i] = (e, v) => e.NEXTBUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG10":
                        mapper[i] = (e, v) => e.NEXTBUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG11":
                        mapper[i] = (e, v) => e.NEXTBUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG12":
                        mapper[i] = (e, v) => e.NEXTBUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ANNUALBUDG":
                        mapper[i] = (e, v) => e.ANNUALBUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXT_ANN_BUDG":
                        mapper[i] = (e, v) => e.NEXT_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_ANN_BUDG":
                        mapper[i] = (e, v) => e.REV_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG01":
                        mapper[i] = (e, v) => e.REV_BUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG02":
                        mapper[i] = (e, v) => e.REV_BUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG03":
                        mapper[i] = (e, v) => e.REV_BUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG04":
                        mapper[i] = (e, v) => e.REV_BUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG05":
                        mapper[i] = (e, v) => e.REV_BUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG06":
                        mapper[i] = (e, v) => e.REV_BUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG07":
                        mapper[i] = (e, v) => e.REV_BUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG08":
                        mapper[i] = (e, v) => e.REV_BUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG09":
                        mapper[i] = (e, v) => e.REV_BUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG10":
                        mapper[i] = (e, v) => e.REV_BUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG11":
                        mapper[i] = (e, v) => e.REV_BUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG12":
                        mapper[i] = (e, v) => e.REV_BUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG01":
                        mapper[i] = (e, v) => e.LASTBUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG02":
                        mapper[i] = (e, v) => e.LASTBUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG03":
                        mapper[i] = (e, v) => e.LASTBUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG04":
                        mapper[i] = (e, v) => e.LASTBUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG05":
                        mapper[i] = (e, v) => e.LASTBUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG06":
                        mapper[i] = (e, v) => e.LASTBUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG07":
                        mapper[i] = (e, v) => e.LASTBUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG08":
                        mapper[i] = (e, v) => e.LASTBUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG09":
                        mapper[i] = (e, v) => e.LASTBUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG10":
                        mapper[i] = (e, v) => e.LASTBUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG11":
                        mapper[i] = (e, v) => e.LASTBUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG12":
                        mapper[i] = (e, v) => e.LASTBUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LAST_ANN_BUDG":
                        mapper[i] = (e, v) => e.LAST_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT01":
                        mapper[i] = (e, v) => e.COMMITMENT01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT02":
                        mapper[i] = (e, v) => e.COMMITMENT02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT03":
                        mapper[i] = (e, v) => e.COMMITMENT03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT04":
                        mapper[i] = (e, v) => e.COMMITMENT04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT05":
                        mapper[i] = (e, v) => e.COMMITMENT05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT06":
                        mapper[i] = (e, v) => e.COMMITMENT06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT07":
                        mapper[i] = (e, v) => e.COMMITMENT07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT08":
                        mapper[i] = (e, v) => e.COMMITMENT08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT09":
                        mapper[i] = (e, v) => e.COMMITMENT09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT10":
                        mapper[i] = (e, v) => e.COMMITMENT10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT11":
                        mapper[i] = (e, v) => e.COMMITMENT11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT12":
                        mapper[i] = (e, v) => e.COMMITMENT12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HIDATE":
                        mapper[i] = (e, v) => e.HIDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GL_TYPE":
                        mapper[i] = (e, v) => e.GL_TYPE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "USER_DEFINABLE":
                        mapper[i] = (e, v) => e.USER_DEFINABLE = v;
                        break;
                    case "FBT":
                        mapper[i] = (e, v) => e.FBT = v;
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
        /// Merges <see cref="GL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GL" /> items to added or update the base <see cref="GL" /> items</param>
        /// <returns>A merged list of <see cref="GL" /> items</returns>
        protected override List<GL> ApplyDeltaItems(List<GL> Items, List<GL> DeltaItems)
        {
            Dictionary<string, int> Index_CODE = Items.ToIndexDictionary(i => i.CODE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GL deltaItem in DeltaItems)
            {
                int index;

                if (Index_CODE.TryGetValue(deltaItem.CODE, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CODE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, GL>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GL>>> Index_GL_TYPE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GL by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GL</param>
        /// <returns>Related GL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GL FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GL by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GL</param>
        /// <param name="Value">Related GL entity</param>
        /// <returns>True if the related GL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out GL Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GL by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GL</param>
        /// <returns>Related GL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GL TryFindByCODE(string CODE)
        {
            GL value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GL by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GL</param>
        /// <returns>List of related GL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GL> FindByGL_TYPE(string GL_TYPE)
        {
            return Index_GL_TYPE.Value[GL_TYPE];
        }

        /// <summary>
        /// Attempt to find GL by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GL</param>
        /// <param name="Value">List of related GL entities</param>
        /// <returns>True if the list of related GL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_TYPE(string GL_TYPE, out IReadOnlyList<GL> Value)
        {
            return Index_GL_TYPE.Value.TryGetValue(GL_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find GL by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GL</param>
        /// <returns>List of related GL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GL> TryFindByGL_TYPE(string GL_TYPE)
        {
            IReadOnlyList<GL> value;
            if (Index_GL_TYPE.Value.TryGetValue(GL_TYPE, out value))
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
        /// Returns SQL which checks for the existence of a GL table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[GL](
        [CODE] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [OPBAL] money NULL,
        [LYROPBAL] money NULL,
        [LASTYR01] money NULL,
        [LASTYR02] money NULL,
        [LASTYR03] money NULL,
        [LASTYR04] money NULL,
        [LASTYR05] money NULL,
        [LASTYR06] money NULL,
        [LASTYR07] money NULL,
        [LASTYR08] money NULL,
        [LASTYR09] money NULL,
        [LASTYR10] money NULL,
        [LASTYR11] money NULL,
        [LASTYR12] money NULL,
        [CURR01] money NULL,
        [CURR02] money NULL,
        [CURR03] money NULL,
        [CURR04] money NULL,
        [CURR05] money NULL,
        [CURR06] money NULL,
        [CURR07] money NULL,
        [CURR08] money NULL,
        [CURR09] money NULL,
        [CURR10] money NULL,
        [CURR11] money NULL,
        [CURR12] money NULL,
        [BUDG01] money NULL,
        [BUDG02] money NULL,
        [BUDG03] money NULL,
        [BUDG04] money NULL,
        [BUDG05] money NULL,
        [BUDG06] money NULL,
        [BUDG07] money NULL,
        [BUDG08] money NULL,
        [BUDG09] money NULL,
        [BUDG10] money NULL,
        [BUDG11] money NULL,
        [BUDG12] money NULL,
        [NEXTBUDG01] money NULL,
        [NEXTBUDG02] money NULL,
        [NEXTBUDG03] money NULL,
        [NEXTBUDG04] money NULL,
        [NEXTBUDG05] money NULL,
        [NEXTBUDG06] money NULL,
        [NEXTBUDG07] money NULL,
        [NEXTBUDG08] money NULL,
        [NEXTBUDG09] money NULL,
        [NEXTBUDG10] money NULL,
        [NEXTBUDG11] money NULL,
        [NEXTBUDG12] money NULL,
        [ANNUALBUDG] money NULL,
        [NEXT_ANN_BUDG] money NULL,
        [REV_ANN_BUDG] money NULL,
        [REV_BUDG01] money NULL,
        [REV_BUDG02] money NULL,
        [REV_BUDG03] money NULL,
        [REV_BUDG04] money NULL,
        [REV_BUDG05] money NULL,
        [REV_BUDG06] money NULL,
        [REV_BUDG07] money NULL,
        [REV_BUDG08] money NULL,
        [REV_BUDG09] money NULL,
        [REV_BUDG10] money NULL,
        [REV_BUDG11] money NULL,
        [REV_BUDG12] money NULL,
        [LASTBUDG01] money NULL,
        [LASTBUDG02] money NULL,
        [LASTBUDG03] money NULL,
        [LASTBUDG04] money NULL,
        [LASTBUDG05] money NULL,
        [LASTBUDG06] money NULL,
        [LASTBUDG07] money NULL,
        [LASTBUDG08] money NULL,
        [LASTBUDG09] money NULL,
        [LASTBUDG10] money NULL,
        [LASTBUDG11] money NULL,
        [LASTBUDG12] money NULL,
        [LAST_ANN_BUDG] money NULL,
        [COMMITMENT01] money NULL,
        [COMMITMENT02] money NULL,
        [COMMITMENT03] money NULL,
        [COMMITMENT04] money NULL,
        [COMMITMENT05] money NULL,
        [COMMITMENT06] money NULL,
        [COMMITMENT07] money NULL,
        [COMMITMENT08] money NULL,
        [COMMITMENT09] money NULL,
        [COMMITMENT10] money NULL,
        [COMMITMENT11] money NULL,
        [COMMITMENT12] money NULL,
        [HIDATE] datetime NULL,
        [GL_TYPE] varchar(10) NULL,
        [ACTIVE] varchar(1) NULL,
        [USER_DEFINABLE] varchar(1) NULL,
        [FBT] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [GL_Index_CODE] PRIMARY KEY CLUSTERED (
            [CODE] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [GL_Index_GL_TYPE] ON [dbo].[GL]
    (
            [GL_TYPE] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the GL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the GL data set</returns>
        public override IDataReader GetDataReader()
        {
            return new GLDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class GLDataReader : IDataReader, IDataRecord
        {
            private List<GL> Items;
            private int CurrentIndex;
            private GL CurrentItem;

            public GLDataReader(List<GL> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 100; } }
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
                    case 0: // CODE
                        return CurrentItem.CODE;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // OPBAL
                        return CurrentItem.OPBAL;
                    case 3: // LYROPBAL
                        return CurrentItem.LYROPBAL;
                    case 4: // LASTYR01
                        return CurrentItem.LASTYR01;
                    case 5: // LASTYR02
                        return CurrentItem.LASTYR02;
                    case 6: // LASTYR03
                        return CurrentItem.LASTYR03;
                    case 7: // LASTYR04
                        return CurrentItem.LASTYR04;
                    case 8: // LASTYR05
                        return CurrentItem.LASTYR05;
                    case 9: // LASTYR06
                        return CurrentItem.LASTYR06;
                    case 10: // LASTYR07
                        return CurrentItem.LASTYR07;
                    case 11: // LASTYR08
                        return CurrentItem.LASTYR08;
                    case 12: // LASTYR09
                        return CurrentItem.LASTYR09;
                    case 13: // LASTYR10
                        return CurrentItem.LASTYR10;
                    case 14: // LASTYR11
                        return CurrentItem.LASTYR11;
                    case 15: // LASTYR12
                        return CurrentItem.LASTYR12;
                    case 16: // CURR01
                        return CurrentItem.CURR01;
                    case 17: // CURR02
                        return CurrentItem.CURR02;
                    case 18: // CURR03
                        return CurrentItem.CURR03;
                    case 19: // CURR04
                        return CurrentItem.CURR04;
                    case 20: // CURR05
                        return CurrentItem.CURR05;
                    case 21: // CURR06
                        return CurrentItem.CURR06;
                    case 22: // CURR07
                        return CurrentItem.CURR07;
                    case 23: // CURR08
                        return CurrentItem.CURR08;
                    case 24: // CURR09
                        return CurrentItem.CURR09;
                    case 25: // CURR10
                        return CurrentItem.CURR10;
                    case 26: // CURR11
                        return CurrentItem.CURR11;
                    case 27: // CURR12
                        return CurrentItem.CURR12;
                    case 28: // BUDG01
                        return CurrentItem.BUDG01;
                    case 29: // BUDG02
                        return CurrentItem.BUDG02;
                    case 30: // BUDG03
                        return CurrentItem.BUDG03;
                    case 31: // BUDG04
                        return CurrentItem.BUDG04;
                    case 32: // BUDG05
                        return CurrentItem.BUDG05;
                    case 33: // BUDG06
                        return CurrentItem.BUDG06;
                    case 34: // BUDG07
                        return CurrentItem.BUDG07;
                    case 35: // BUDG08
                        return CurrentItem.BUDG08;
                    case 36: // BUDG09
                        return CurrentItem.BUDG09;
                    case 37: // BUDG10
                        return CurrentItem.BUDG10;
                    case 38: // BUDG11
                        return CurrentItem.BUDG11;
                    case 39: // BUDG12
                        return CurrentItem.BUDG12;
                    case 40: // NEXTBUDG01
                        return CurrentItem.NEXTBUDG01;
                    case 41: // NEXTBUDG02
                        return CurrentItem.NEXTBUDG02;
                    case 42: // NEXTBUDG03
                        return CurrentItem.NEXTBUDG03;
                    case 43: // NEXTBUDG04
                        return CurrentItem.NEXTBUDG04;
                    case 44: // NEXTBUDG05
                        return CurrentItem.NEXTBUDG05;
                    case 45: // NEXTBUDG06
                        return CurrentItem.NEXTBUDG06;
                    case 46: // NEXTBUDG07
                        return CurrentItem.NEXTBUDG07;
                    case 47: // NEXTBUDG08
                        return CurrentItem.NEXTBUDG08;
                    case 48: // NEXTBUDG09
                        return CurrentItem.NEXTBUDG09;
                    case 49: // NEXTBUDG10
                        return CurrentItem.NEXTBUDG10;
                    case 50: // NEXTBUDG11
                        return CurrentItem.NEXTBUDG11;
                    case 51: // NEXTBUDG12
                        return CurrentItem.NEXTBUDG12;
                    case 52: // ANNUALBUDG
                        return CurrentItem.ANNUALBUDG;
                    case 53: // NEXT_ANN_BUDG
                        return CurrentItem.NEXT_ANN_BUDG;
                    case 54: // REV_ANN_BUDG
                        return CurrentItem.REV_ANN_BUDG;
                    case 55: // REV_BUDG01
                        return CurrentItem.REV_BUDG01;
                    case 56: // REV_BUDG02
                        return CurrentItem.REV_BUDG02;
                    case 57: // REV_BUDG03
                        return CurrentItem.REV_BUDG03;
                    case 58: // REV_BUDG04
                        return CurrentItem.REV_BUDG04;
                    case 59: // REV_BUDG05
                        return CurrentItem.REV_BUDG05;
                    case 60: // REV_BUDG06
                        return CurrentItem.REV_BUDG06;
                    case 61: // REV_BUDG07
                        return CurrentItem.REV_BUDG07;
                    case 62: // REV_BUDG08
                        return CurrentItem.REV_BUDG08;
                    case 63: // REV_BUDG09
                        return CurrentItem.REV_BUDG09;
                    case 64: // REV_BUDG10
                        return CurrentItem.REV_BUDG10;
                    case 65: // REV_BUDG11
                        return CurrentItem.REV_BUDG11;
                    case 66: // REV_BUDG12
                        return CurrentItem.REV_BUDG12;
                    case 67: // LASTBUDG01
                        return CurrentItem.LASTBUDG01;
                    case 68: // LASTBUDG02
                        return CurrentItem.LASTBUDG02;
                    case 69: // LASTBUDG03
                        return CurrentItem.LASTBUDG03;
                    case 70: // LASTBUDG04
                        return CurrentItem.LASTBUDG04;
                    case 71: // LASTBUDG05
                        return CurrentItem.LASTBUDG05;
                    case 72: // LASTBUDG06
                        return CurrentItem.LASTBUDG06;
                    case 73: // LASTBUDG07
                        return CurrentItem.LASTBUDG07;
                    case 74: // LASTBUDG08
                        return CurrentItem.LASTBUDG08;
                    case 75: // LASTBUDG09
                        return CurrentItem.LASTBUDG09;
                    case 76: // LASTBUDG10
                        return CurrentItem.LASTBUDG10;
                    case 77: // LASTBUDG11
                        return CurrentItem.LASTBUDG11;
                    case 78: // LASTBUDG12
                        return CurrentItem.LASTBUDG12;
                    case 79: // LAST_ANN_BUDG
                        return CurrentItem.LAST_ANN_BUDG;
                    case 80: // COMMITMENT01
                        return CurrentItem.COMMITMENT01;
                    case 81: // COMMITMENT02
                        return CurrentItem.COMMITMENT02;
                    case 82: // COMMITMENT03
                        return CurrentItem.COMMITMENT03;
                    case 83: // COMMITMENT04
                        return CurrentItem.COMMITMENT04;
                    case 84: // COMMITMENT05
                        return CurrentItem.COMMITMENT05;
                    case 85: // COMMITMENT06
                        return CurrentItem.COMMITMENT06;
                    case 86: // COMMITMENT07
                        return CurrentItem.COMMITMENT07;
                    case 87: // COMMITMENT08
                        return CurrentItem.COMMITMENT08;
                    case 88: // COMMITMENT09
                        return CurrentItem.COMMITMENT09;
                    case 89: // COMMITMENT10
                        return CurrentItem.COMMITMENT10;
                    case 90: // COMMITMENT11
                        return CurrentItem.COMMITMENT11;
                    case 91: // COMMITMENT12
                        return CurrentItem.COMMITMENT12;
                    case 92: // HIDATE
                        return CurrentItem.HIDATE;
                    case 93: // GL_TYPE
                        return CurrentItem.GL_TYPE;
                    case 94: // ACTIVE
                        return CurrentItem.ACTIVE;
                    case 95: // USER_DEFINABLE
                        return CurrentItem.USER_DEFINABLE;
                    case 96: // FBT
                        return CurrentItem.FBT;
                    case 97: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 98: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 99: // LW_USER
                        return CurrentItem.LW_USER;
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
                    case 2: // OPBAL
                        return CurrentItem.OPBAL == null;
                    case 3: // LYROPBAL
                        return CurrentItem.LYROPBAL == null;
                    case 4: // LASTYR01
                        return CurrentItem.LASTYR01 == null;
                    case 5: // LASTYR02
                        return CurrentItem.LASTYR02 == null;
                    case 6: // LASTYR03
                        return CurrentItem.LASTYR03 == null;
                    case 7: // LASTYR04
                        return CurrentItem.LASTYR04 == null;
                    case 8: // LASTYR05
                        return CurrentItem.LASTYR05 == null;
                    case 9: // LASTYR06
                        return CurrentItem.LASTYR06 == null;
                    case 10: // LASTYR07
                        return CurrentItem.LASTYR07 == null;
                    case 11: // LASTYR08
                        return CurrentItem.LASTYR08 == null;
                    case 12: // LASTYR09
                        return CurrentItem.LASTYR09 == null;
                    case 13: // LASTYR10
                        return CurrentItem.LASTYR10 == null;
                    case 14: // LASTYR11
                        return CurrentItem.LASTYR11 == null;
                    case 15: // LASTYR12
                        return CurrentItem.LASTYR12 == null;
                    case 16: // CURR01
                        return CurrentItem.CURR01 == null;
                    case 17: // CURR02
                        return CurrentItem.CURR02 == null;
                    case 18: // CURR03
                        return CurrentItem.CURR03 == null;
                    case 19: // CURR04
                        return CurrentItem.CURR04 == null;
                    case 20: // CURR05
                        return CurrentItem.CURR05 == null;
                    case 21: // CURR06
                        return CurrentItem.CURR06 == null;
                    case 22: // CURR07
                        return CurrentItem.CURR07 == null;
                    case 23: // CURR08
                        return CurrentItem.CURR08 == null;
                    case 24: // CURR09
                        return CurrentItem.CURR09 == null;
                    case 25: // CURR10
                        return CurrentItem.CURR10 == null;
                    case 26: // CURR11
                        return CurrentItem.CURR11 == null;
                    case 27: // CURR12
                        return CurrentItem.CURR12 == null;
                    case 28: // BUDG01
                        return CurrentItem.BUDG01 == null;
                    case 29: // BUDG02
                        return CurrentItem.BUDG02 == null;
                    case 30: // BUDG03
                        return CurrentItem.BUDG03 == null;
                    case 31: // BUDG04
                        return CurrentItem.BUDG04 == null;
                    case 32: // BUDG05
                        return CurrentItem.BUDG05 == null;
                    case 33: // BUDG06
                        return CurrentItem.BUDG06 == null;
                    case 34: // BUDG07
                        return CurrentItem.BUDG07 == null;
                    case 35: // BUDG08
                        return CurrentItem.BUDG08 == null;
                    case 36: // BUDG09
                        return CurrentItem.BUDG09 == null;
                    case 37: // BUDG10
                        return CurrentItem.BUDG10 == null;
                    case 38: // BUDG11
                        return CurrentItem.BUDG11 == null;
                    case 39: // BUDG12
                        return CurrentItem.BUDG12 == null;
                    case 40: // NEXTBUDG01
                        return CurrentItem.NEXTBUDG01 == null;
                    case 41: // NEXTBUDG02
                        return CurrentItem.NEXTBUDG02 == null;
                    case 42: // NEXTBUDG03
                        return CurrentItem.NEXTBUDG03 == null;
                    case 43: // NEXTBUDG04
                        return CurrentItem.NEXTBUDG04 == null;
                    case 44: // NEXTBUDG05
                        return CurrentItem.NEXTBUDG05 == null;
                    case 45: // NEXTBUDG06
                        return CurrentItem.NEXTBUDG06 == null;
                    case 46: // NEXTBUDG07
                        return CurrentItem.NEXTBUDG07 == null;
                    case 47: // NEXTBUDG08
                        return CurrentItem.NEXTBUDG08 == null;
                    case 48: // NEXTBUDG09
                        return CurrentItem.NEXTBUDG09 == null;
                    case 49: // NEXTBUDG10
                        return CurrentItem.NEXTBUDG10 == null;
                    case 50: // NEXTBUDG11
                        return CurrentItem.NEXTBUDG11 == null;
                    case 51: // NEXTBUDG12
                        return CurrentItem.NEXTBUDG12 == null;
                    case 52: // ANNUALBUDG
                        return CurrentItem.ANNUALBUDG == null;
                    case 53: // NEXT_ANN_BUDG
                        return CurrentItem.NEXT_ANN_BUDG == null;
                    case 54: // REV_ANN_BUDG
                        return CurrentItem.REV_ANN_BUDG == null;
                    case 55: // REV_BUDG01
                        return CurrentItem.REV_BUDG01 == null;
                    case 56: // REV_BUDG02
                        return CurrentItem.REV_BUDG02 == null;
                    case 57: // REV_BUDG03
                        return CurrentItem.REV_BUDG03 == null;
                    case 58: // REV_BUDG04
                        return CurrentItem.REV_BUDG04 == null;
                    case 59: // REV_BUDG05
                        return CurrentItem.REV_BUDG05 == null;
                    case 60: // REV_BUDG06
                        return CurrentItem.REV_BUDG06 == null;
                    case 61: // REV_BUDG07
                        return CurrentItem.REV_BUDG07 == null;
                    case 62: // REV_BUDG08
                        return CurrentItem.REV_BUDG08 == null;
                    case 63: // REV_BUDG09
                        return CurrentItem.REV_BUDG09 == null;
                    case 64: // REV_BUDG10
                        return CurrentItem.REV_BUDG10 == null;
                    case 65: // REV_BUDG11
                        return CurrentItem.REV_BUDG11 == null;
                    case 66: // REV_BUDG12
                        return CurrentItem.REV_BUDG12 == null;
                    case 67: // LASTBUDG01
                        return CurrentItem.LASTBUDG01 == null;
                    case 68: // LASTBUDG02
                        return CurrentItem.LASTBUDG02 == null;
                    case 69: // LASTBUDG03
                        return CurrentItem.LASTBUDG03 == null;
                    case 70: // LASTBUDG04
                        return CurrentItem.LASTBUDG04 == null;
                    case 71: // LASTBUDG05
                        return CurrentItem.LASTBUDG05 == null;
                    case 72: // LASTBUDG06
                        return CurrentItem.LASTBUDG06 == null;
                    case 73: // LASTBUDG07
                        return CurrentItem.LASTBUDG07 == null;
                    case 74: // LASTBUDG08
                        return CurrentItem.LASTBUDG08 == null;
                    case 75: // LASTBUDG09
                        return CurrentItem.LASTBUDG09 == null;
                    case 76: // LASTBUDG10
                        return CurrentItem.LASTBUDG10 == null;
                    case 77: // LASTBUDG11
                        return CurrentItem.LASTBUDG11 == null;
                    case 78: // LASTBUDG12
                        return CurrentItem.LASTBUDG12 == null;
                    case 79: // LAST_ANN_BUDG
                        return CurrentItem.LAST_ANN_BUDG == null;
                    case 80: // COMMITMENT01
                        return CurrentItem.COMMITMENT01 == null;
                    case 81: // COMMITMENT02
                        return CurrentItem.COMMITMENT02 == null;
                    case 82: // COMMITMENT03
                        return CurrentItem.COMMITMENT03 == null;
                    case 83: // COMMITMENT04
                        return CurrentItem.COMMITMENT04 == null;
                    case 84: // COMMITMENT05
                        return CurrentItem.COMMITMENT05 == null;
                    case 85: // COMMITMENT06
                        return CurrentItem.COMMITMENT06 == null;
                    case 86: // COMMITMENT07
                        return CurrentItem.COMMITMENT07 == null;
                    case 87: // COMMITMENT08
                        return CurrentItem.COMMITMENT08 == null;
                    case 88: // COMMITMENT09
                        return CurrentItem.COMMITMENT09 == null;
                    case 89: // COMMITMENT10
                        return CurrentItem.COMMITMENT10 == null;
                    case 90: // COMMITMENT11
                        return CurrentItem.COMMITMENT11 == null;
                    case 91: // COMMITMENT12
                        return CurrentItem.COMMITMENT12 == null;
                    case 92: // HIDATE
                        return CurrentItem.HIDATE == null;
                    case 93: // GL_TYPE
                        return CurrentItem.GL_TYPE == null;
                    case 94: // ACTIVE
                        return CurrentItem.ACTIVE == null;
                    case 95: // USER_DEFINABLE
                        return CurrentItem.USER_DEFINABLE == null;
                    case 96: // FBT
                        return CurrentItem.FBT == null;
                    case 97: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 98: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 99: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // CODE
                        return "CODE";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // OPBAL
                        return "OPBAL";
                    case 3: // LYROPBAL
                        return "LYROPBAL";
                    case 4: // LASTYR01
                        return "LASTYR01";
                    case 5: // LASTYR02
                        return "LASTYR02";
                    case 6: // LASTYR03
                        return "LASTYR03";
                    case 7: // LASTYR04
                        return "LASTYR04";
                    case 8: // LASTYR05
                        return "LASTYR05";
                    case 9: // LASTYR06
                        return "LASTYR06";
                    case 10: // LASTYR07
                        return "LASTYR07";
                    case 11: // LASTYR08
                        return "LASTYR08";
                    case 12: // LASTYR09
                        return "LASTYR09";
                    case 13: // LASTYR10
                        return "LASTYR10";
                    case 14: // LASTYR11
                        return "LASTYR11";
                    case 15: // LASTYR12
                        return "LASTYR12";
                    case 16: // CURR01
                        return "CURR01";
                    case 17: // CURR02
                        return "CURR02";
                    case 18: // CURR03
                        return "CURR03";
                    case 19: // CURR04
                        return "CURR04";
                    case 20: // CURR05
                        return "CURR05";
                    case 21: // CURR06
                        return "CURR06";
                    case 22: // CURR07
                        return "CURR07";
                    case 23: // CURR08
                        return "CURR08";
                    case 24: // CURR09
                        return "CURR09";
                    case 25: // CURR10
                        return "CURR10";
                    case 26: // CURR11
                        return "CURR11";
                    case 27: // CURR12
                        return "CURR12";
                    case 28: // BUDG01
                        return "BUDG01";
                    case 29: // BUDG02
                        return "BUDG02";
                    case 30: // BUDG03
                        return "BUDG03";
                    case 31: // BUDG04
                        return "BUDG04";
                    case 32: // BUDG05
                        return "BUDG05";
                    case 33: // BUDG06
                        return "BUDG06";
                    case 34: // BUDG07
                        return "BUDG07";
                    case 35: // BUDG08
                        return "BUDG08";
                    case 36: // BUDG09
                        return "BUDG09";
                    case 37: // BUDG10
                        return "BUDG10";
                    case 38: // BUDG11
                        return "BUDG11";
                    case 39: // BUDG12
                        return "BUDG12";
                    case 40: // NEXTBUDG01
                        return "NEXTBUDG01";
                    case 41: // NEXTBUDG02
                        return "NEXTBUDG02";
                    case 42: // NEXTBUDG03
                        return "NEXTBUDG03";
                    case 43: // NEXTBUDG04
                        return "NEXTBUDG04";
                    case 44: // NEXTBUDG05
                        return "NEXTBUDG05";
                    case 45: // NEXTBUDG06
                        return "NEXTBUDG06";
                    case 46: // NEXTBUDG07
                        return "NEXTBUDG07";
                    case 47: // NEXTBUDG08
                        return "NEXTBUDG08";
                    case 48: // NEXTBUDG09
                        return "NEXTBUDG09";
                    case 49: // NEXTBUDG10
                        return "NEXTBUDG10";
                    case 50: // NEXTBUDG11
                        return "NEXTBUDG11";
                    case 51: // NEXTBUDG12
                        return "NEXTBUDG12";
                    case 52: // ANNUALBUDG
                        return "ANNUALBUDG";
                    case 53: // NEXT_ANN_BUDG
                        return "NEXT_ANN_BUDG";
                    case 54: // REV_ANN_BUDG
                        return "REV_ANN_BUDG";
                    case 55: // REV_BUDG01
                        return "REV_BUDG01";
                    case 56: // REV_BUDG02
                        return "REV_BUDG02";
                    case 57: // REV_BUDG03
                        return "REV_BUDG03";
                    case 58: // REV_BUDG04
                        return "REV_BUDG04";
                    case 59: // REV_BUDG05
                        return "REV_BUDG05";
                    case 60: // REV_BUDG06
                        return "REV_BUDG06";
                    case 61: // REV_BUDG07
                        return "REV_BUDG07";
                    case 62: // REV_BUDG08
                        return "REV_BUDG08";
                    case 63: // REV_BUDG09
                        return "REV_BUDG09";
                    case 64: // REV_BUDG10
                        return "REV_BUDG10";
                    case 65: // REV_BUDG11
                        return "REV_BUDG11";
                    case 66: // REV_BUDG12
                        return "REV_BUDG12";
                    case 67: // LASTBUDG01
                        return "LASTBUDG01";
                    case 68: // LASTBUDG02
                        return "LASTBUDG02";
                    case 69: // LASTBUDG03
                        return "LASTBUDG03";
                    case 70: // LASTBUDG04
                        return "LASTBUDG04";
                    case 71: // LASTBUDG05
                        return "LASTBUDG05";
                    case 72: // LASTBUDG06
                        return "LASTBUDG06";
                    case 73: // LASTBUDG07
                        return "LASTBUDG07";
                    case 74: // LASTBUDG08
                        return "LASTBUDG08";
                    case 75: // LASTBUDG09
                        return "LASTBUDG09";
                    case 76: // LASTBUDG10
                        return "LASTBUDG10";
                    case 77: // LASTBUDG11
                        return "LASTBUDG11";
                    case 78: // LASTBUDG12
                        return "LASTBUDG12";
                    case 79: // LAST_ANN_BUDG
                        return "LAST_ANN_BUDG";
                    case 80: // COMMITMENT01
                        return "COMMITMENT01";
                    case 81: // COMMITMENT02
                        return "COMMITMENT02";
                    case 82: // COMMITMENT03
                        return "COMMITMENT03";
                    case 83: // COMMITMENT04
                        return "COMMITMENT04";
                    case 84: // COMMITMENT05
                        return "COMMITMENT05";
                    case 85: // COMMITMENT06
                        return "COMMITMENT06";
                    case 86: // COMMITMENT07
                        return "COMMITMENT07";
                    case 87: // COMMITMENT08
                        return "COMMITMENT08";
                    case 88: // COMMITMENT09
                        return "COMMITMENT09";
                    case 89: // COMMITMENT10
                        return "COMMITMENT10";
                    case 90: // COMMITMENT11
                        return "COMMITMENT11";
                    case 91: // COMMITMENT12
                        return "COMMITMENT12";
                    case 92: // HIDATE
                        return "HIDATE";
                    case 93: // GL_TYPE
                        return "GL_TYPE";
                    case 94: // ACTIVE
                        return "ACTIVE";
                    case 95: // USER_DEFINABLE
                        return "USER_DEFINABLE";
                    case 96: // FBT
                        return "FBT";
                    case 97: // LW_DATE
                        return "LW_DATE";
                    case 98: // LW_TIME
                        return "LW_TIME";
                    case 99: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "CODE":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "OPBAL":
                        return 2;
                    case "LYROPBAL":
                        return 3;
                    case "LASTYR01":
                        return 4;
                    case "LASTYR02":
                        return 5;
                    case "LASTYR03":
                        return 6;
                    case "LASTYR04":
                        return 7;
                    case "LASTYR05":
                        return 8;
                    case "LASTYR06":
                        return 9;
                    case "LASTYR07":
                        return 10;
                    case "LASTYR08":
                        return 11;
                    case "LASTYR09":
                        return 12;
                    case "LASTYR10":
                        return 13;
                    case "LASTYR11":
                        return 14;
                    case "LASTYR12":
                        return 15;
                    case "CURR01":
                        return 16;
                    case "CURR02":
                        return 17;
                    case "CURR03":
                        return 18;
                    case "CURR04":
                        return 19;
                    case "CURR05":
                        return 20;
                    case "CURR06":
                        return 21;
                    case "CURR07":
                        return 22;
                    case "CURR08":
                        return 23;
                    case "CURR09":
                        return 24;
                    case "CURR10":
                        return 25;
                    case "CURR11":
                        return 26;
                    case "CURR12":
                        return 27;
                    case "BUDG01":
                        return 28;
                    case "BUDG02":
                        return 29;
                    case "BUDG03":
                        return 30;
                    case "BUDG04":
                        return 31;
                    case "BUDG05":
                        return 32;
                    case "BUDG06":
                        return 33;
                    case "BUDG07":
                        return 34;
                    case "BUDG08":
                        return 35;
                    case "BUDG09":
                        return 36;
                    case "BUDG10":
                        return 37;
                    case "BUDG11":
                        return 38;
                    case "BUDG12":
                        return 39;
                    case "NEXTBUDG01":
                        return 40;
                    case "NEXTBUDG02":
                        return 41;
                    case "NEXTBUDG03":
                        return 42;
                    case "NEXTBUDG04":
                        return 43;
                    case "NEXTBUDG05":
                        return 44;
                    case "NEXTBUDG06":
                        return 45;
                    case "NEXTBUDG07":
                        return 46;
                    case "NEXTBUDG08":
                        return 47;
                    case "NEXTBUDG09":
                        return 48;
                    case "NEXTBUDG10":
                        return 49;
                    case "NEXTBUDG11":
                        return 50;
                    case "NEXTBUDG12":
                        return 51;
                    case "ANNUALBUDG":
                        return 52;
                    case "NEXT_ANN_BUDG":
                        return 53;
                    case "REV_ANN_BUDG":
                        return 54;
                    case "REV_BUDG01":
                        return 55;
                    case "REV_BUDG02":
                        return 56;
                    case "REV_BUDG03":
                        return 57;
                    case "REV_BUDG04":
                        return 58;
                    case "REV_BUDG05":
                        return 59;
                    case "REV_BUDG06":
                        return 60;
                    case "REV_BUDG07":
                        return 61;
                    case "REV_BUDG08":
                        return 62;
                    case "REV_BUDG09":
                        return 63;
                    case "REV_BUDG10":
                        return 64;
                    case "REV_BUDG11":
                        return 65;
                    case "REV_BUDG12":
                        return 66;
                    case "LASTBUDG01":
                        return 67;
                    case "LASTBUDG02":
                        return 68;
                    case "LASTBUDG03":
                        return 69;
                    case "LASTBUDG04":
                        return 70;
                    case "LASTBUDG05":
                        return 71;
                    case "LASTBUDG06":
                        return 72;
                    case "LASTBUDG07":
                        return 73;
                    case "LASTBUDG08":
                        return 74;
                    case "LASTBUDG09":
                        return 75;
                    case "LASTBUDG10":
                        return 76;
                    case "LASTBUDG11":
                        return 77;
                    case "LASTBUDG12":
                        return 78;
                    case "LAST_ANN_BUDG":
                        return 79;
                    case "COMMITMENT01":
                        return 80;
                    case "COMMITMENT02":
                        return 81;
                    case "COMMITMENT03":
                        return 82;
                    case "COMMITMENT04":
                        return 83;
                    case "COMMITMENT05":
                        return 84;
                    case "COMMITMENT06":
                        return 85;
                    case "COMMITMENT07":
                        return 86;
                    case "COMMITMENT08":
                        return 87;
                    case "COMMITMENT09":
                        return 88;
                    case "COMMITMENT10":
                        return 89;
                    case "COMMITMENT11":
                        return 90;
                    case "COMMITMENT12":
                        return 91;
                    case "HIDATE":
                        return 92;
                    case "GL_TYPE":
                        return 93;
                    case "ACTIVE":
                        return 94;
                    case "USER_DEFINABLE":
                        return 95;
                    case "FBT":
                        return 96;
                    case "LW_DATE":
                        return 97;
                    case "LW_TIME":
                        return 98;
                    case "LW_USER":
                        return 99;
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
