using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Commitments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLFBANKDataSet : SetBase<GLFBANK>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLFBANK"; } }

        internal GLFBANKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<GLFBANK>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_FUND_ID = new Lazy<NullDictionary<short?, GLFBANK>>(() => this.ToNullDictionary(i => i.FUND_ID));
            Index_TID = new Lazy<Dictionary<int, GLFBANK>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLFBANK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLFBANK" /> fields for each CSV column header</returns>
        protected override Action<GLFBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLFBANK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "FUND_ID":
                        mapper[i] = (e, v) => e.FUND_ID = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TIME_FRAME":
                        mapper[i] = (e, v) => e.TIME_FRAME = v;
                        break;
                    case "LY_AMOUNT":
                        mapper[i] = (e, v) => e.LY_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_TIME_FRAME":
                        mapper[i] = (e, v) => e.LY_TIME_FRAME = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="GLFBANK" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="GLFBANK" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="GLFBANK" /> items to added or update the base <see cref="GLFBANK" /> items</param>
        /// <returns>A merged list of <see cref="GLFBANK" /> items</returns>
        protected override List<GLFBANK> ApplyDeltaItems(List<GLFBANK> Items, List<GLFBANK> DeltaItems)
        {
            NullDictionary<short?, int> Index_FUND_ID = Items.ToIndexNullDictionary(i => i.FUND_ID);
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (GLFBANK deltaItem in DeltaItems)
            {
                int index;

                if (Index_FUND_ID.TryGetValue(deltaItem.FUND_ID, out index))
                {
                    removeIndexes.Add(index);
                }
                if (Index_TID.TryGetValue(deltaItem.TID, out index))
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

        private Lazy<Dictionary<string, IReadOnlyList<GLFBANK>>> Index_CODE;
        private Lazy<NullDictionary<short?, GLFBANK>> Index_FUND_ID;
        private Lazy<Dictionary<int, GLFBANK>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <returns>List of related GLFBANK entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBANK> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <param name="Value">List of related GLFBANK entities</param>
        /// <returns>True if the list of related GLFBANK entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<GLFBANK> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLFBANK</param>
        /// <returns>List of related GLFBANK entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLFBANK> TryFindByCODE(string CODE)
        {
            IReadOnlyList<GLFBANK> value;
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
        /// Find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK FindByFUND_ID(short? FUND_ID)
        {
            return Index_FUND_ID.Value[FUND_ID];
        }

        /// <summary>
        /// Attempt to find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <param name="Value">Related GLFBANK entity</param>
        /// <returns>True if the related GLFBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFUND_ID(short? FUND_ID, out GLFBANK Value)
        {
            return Index_FUND_ID.Value.TryGetValue(FUND_ID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by FUND_ID field
        /// </summary>
        /// <param name="FUND_ID">FUND_ID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK TryFindByFUND_ID(short? FUND_ID)
        {
            GLFBANK value;
            if (Index_FUND_ID.Value.TryGetValue(FUND_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <param name="Value">Related GLFBANK entity</param>
        /// <returns>True if the related GLFBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out GLFBANK Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find GLFBANK by TID field
        /// </summary>
        /// <param name="TID">TID value used to find GLFBANK</param>
        /// <returns>Related GLFBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLFBANK TryFindByTID(int TID)
        {
            GLFBANK value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
