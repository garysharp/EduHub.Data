using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SADAGDataSet : SetBase<SADAG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SADAG"; } }

        internal SADAGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SADAG_ID = new Lazy<Dictionary<int, SADAG>>(() => this.ToDictionary(i => i.SADAG_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SADAG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SADAG" /> fields for each CSV column header</returns>
        protected override Action<SADAG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SADAG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SADAG_ID":
                        mapper[i] = (e, v) => e.SADAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ABS_CODE":
                        mapper[i] = (e, v) => e.ABS_CODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAYS":
                        mapper[i] = (e, v) => e.DAYS = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="SADAG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SADAG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SADAG" /> items to added or update the base <see cref="SADAG" /> items</param>
        /// <returns>A merged list of <see cref="SADAG" /> items</returns>
        protected override List<SADAG> ApplyDeltaItems(List<SADAG> Items, List<SADAG> DeltaItems)
        {
            Dictionary<int, int> Index_SADAG_ID = Items.ToIndexDictionary(i => i.SADAG_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SADAG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SADAG_ID.TryGetValue(deltaItem.SADAG_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SADAG_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SADAG>> Index_SADAG_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <returns>Related SADAG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADAG FindBySADAG_ID(int SADAG_ID)
        {
            return Index_SADAG_ID.Value[SADAG_ID];
        }

        /// <summary>
        /// Attempt to find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <param name="Value">Related SADAG entity</param>
        /// <returns>True if the related SADAG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySADAG_ID(int SADAG_ID, out SADAG Value)
        {
            return Index_SADAG_ID.Value.TryGetValue(SADAG_ID, out Value);
        }

        /// <summary>
        /// Attempt to find SADAG by SADAG_ID field
        /// </summary>
        /// <param name="SADAG_ID">SADAG_ID value used to find SADAG</param>
        /// <returns>Related SADAG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SADAG TryFindBySADAG_ID(int SADAG_ID)
        {
            SADAG value;
            if (Index_SADAG_ID.Value.TryGetValue(SADAG_ID, out value))
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
