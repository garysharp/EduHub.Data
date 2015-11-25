using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Termination Payment Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PETPDataSet : SetBase<PETP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PETP"; } }

        internal PETPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PETP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PETP>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_TID = new Lazy<Dictionary<int, PETP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PETP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PETP" /> fields for each CSV column header</returns>
        protected override Action<PETP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PETP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PAYITEM":
                        mapper[i] = (e, v) => e.PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PEFTID":
                        mapper[i] = (e, v) => e.PEFTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "DEATH_BENEFIT":
                        mapper[i] = (e, v) => e.DEATH_BENEFIT = v;
                        break;
                    case "BENEFIT_TYPE":
                        mapper[i] = (e, v) => e.BENEFIT_TYPE = v;
                        break;
                    case "TRANSITIONAL":
                        mapper[i] = (e, v) => e.TRANSITIONAL = v;
                        break;
                    case "RELATED":
                        mapper[i] = (e, v) => e.RELATED = v;
                        break;
                    case "ETP_CODE":
                        mapper[i] = (e, v) => e.ETP_CODE = v;
                        break;
                    case "TAX_RATE":
                        mapper[i] = (e, v) => e.TAX_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PATCH_RECORD":
                        mapper[i] = (e, v) => e.PATCH_RECORD = v;
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
        /// Merges <see cref="PETP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PETP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PETP" /> items to added or update the base <see cref="PETP" /> items</param>
        /// <returns>A merged list of <see cref="PETP" /> items</returns>
        protected override List<PETP> ApplyDeltaItems(List<PETP> Items, List<PETP> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PETP deltaItem in DeltaItems)
            {
                int index;

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

        private Lazy<Dictionary<string, IReadOnlyList<PETP>>> Index_CODE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PETP>>> Index_PAYITEM;
        private Lazy<Dictionary<int, PETP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PETP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PETP</param>
        /// <returns>List of related PETP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PETP> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PETP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PETP</param>
        /// <param name="Value">List of related PETP entities</param>
        /// <returns>True if the list of related PETP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PETP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PETP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PETP</param>
        /// <returns>List of related PETP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PETP> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PETP> value;
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
        /// Find PETP by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PETP</param>
        /// <returns>List of related PETP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PETP> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PETP by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PETP</param>
        /// <param name="Value">List of related PETP entities</param>
        /// <returns>True if the list of related PETP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PETP> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PETP by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PETP</param>
        /// <returns>List of related PETP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PETP> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PETP> value;
            if (Index_PAYITEM.Value.TryGetValue(PAYITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PETP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PETP</param>
        /// <returns>Related PETP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PETP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PETP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PETP</param>
        /// <param name="Value">Related PETP entity</param>
        /// <returns>True if the related PETP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PETP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PETP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PETP</param>
        /// <returns>Related PETP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PETP TryFindByTID(int TID)
        {
            PETP value;
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
