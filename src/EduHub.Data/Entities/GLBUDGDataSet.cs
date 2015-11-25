using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Budgets Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLBUDGDataSet : SetBase<GLBUDG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLBUDG"; } }

        internal GLBUDGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BUDGETKEY = new Lazy<Dictionary<string, GLBUDG>>(() => this.ToDictionary(i => i.BUDGETKEY));
            Index_CODE = new Lazy<NullDictionary<string, IReadOnlyList<GLBUDG>>>(() => this.ToGroupedNullDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<GLBUDG>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLBUDG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLBUDG" /> fields for each CSV column header</returns>
        protected override Action<GLBUDG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLBUDG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BUDGETKEY":
                        mapper[i] = (e, v) => e.BUDGETKEY = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "GL_PROGRAM":
                        mapper[i] = (e, v) => e.GL_PROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
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
                    case "IMPORTED":
                        mapper[i] = (e, v) => e.IMPORTED = v;
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
        /// Merges <see cref="GLBUDG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLBUDG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLBUDG" /> items to added or update the base <see cref="GLBUDG" /> items</param>
        /// <returns>A merged list of <see cref="GLBUDG" /> items</returns>
        protected override List<GLBUDG> ApplyDeltaItems(List<GLBUDG> Items, List<GLBUDG> DeltaItems)
        {
            Dictionary<string, int> Index_BUDGETKEY = Items.ToIndexDictionary(i => i.BUDGETKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLBUDG deltaItem in DeltaItems)
            {
                int index;

                if (Index_BUDGETKEY.TryGetValue(deltaItem.BUDGETKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.BUDGETKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, GLBUDG>> Index_BUDGETKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<GLBUDG>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLBUDG>>> Index_INITIATIVE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLBUDG by BUDGETKEY field
        /// </summary>
        /// <param name="BUDGETKEY">BUDGETKEY value used to find GLBUDG</param>
        /// <returns>Related GLBUDG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBUDG FindByBUDGETKEY(string BUDGETKEY)
        {
            return Index_BUDGETKEY.Value[BUDGETKEY];
        }

        /// <summary>
        /// Attempt to find GLBUDG by BUDGETKEY field
        /// </summary>
        /// <param name="BUDGETKEY">BUDGETKEY value used to find GLBUDG</param>
        /// <param name="Value">Related GLBUDG entity</param>
        /// <returns>True if the related GLBUDG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBUDGETKEY(string BUDGETKEY, out GLBUDG Value)
        {
            return Index_BUDGETKEY.Value.TryGetValue(BUDGETKEY, out Value);
        }

        /// <summary>
        /// Attempt to find GLBUDG by BUDGETKEY field
        /// </summary>
        /// <param name="BUDGETKEY">BUDGETKEY value used to find GLBUDG</param>
        /// <returns>Related GLBUDG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLBUDG TryFindByBUDGETKEY(string BUDGETKEY)
        {
            GLBUDG value;
            if (Index_BUDGETKEY.Value.TryGetValue(BUDGETKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLBUDG by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLBUDG</param>
        /// <returns>List of related GLBUDG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLBUDG> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLBUDG by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLBUDG</param>
        /// <param name="Value">List of related GLBUDG entities</param>
        /// <returns>True if the list of related GLBUDG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLBUDG> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLBUDG by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLBUDG</param>
        /// <returns>List of related GLBUDG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLBUDG> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLBUDG> value;
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
        /// Find GLBUDG by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLBUDG</param>
        /// <returns>List of related GLBUDG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLBUDG> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find GLBUDG by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLBUDG</param>
        /// <param name="Value">List of related GLBUDG entities</param>
        /// <returns>True if the list of related GLBUDG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLBUDG> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find GLBUDG by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLBUDG</param>
        /// <returns>List of related GLBUDG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLBUDG> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLBUDG> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
