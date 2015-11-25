using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPREPLYDataSet : SetBase<SPREPLY>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPREPLY"; } }

        internal SPREPLYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<int, IReadOnlyList<SPREPLY>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPREPLY>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPREPLY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPREPLY" /> fields for each CSV column header</returns>
        protected override Action<SPREPLY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPREPLY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = int.Parse(v);
                        break;
                    case "SPRECIP_TID":
                        mapper[i] = (e, v) => e.SPRECIP_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "PHONE_NUMBER":
                        mapper[i] = (e, v) => e.PHONE_NUMBER = v;
                        break;
                    case "RECEIVED_DATE":
                        mapper[i] = (e, v) => e.RECEIVED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SPREPLY" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPREPLY" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPREPLY" /> items to added or update the base <see cref="SPREPLY" /> items</param>
        /// <returns>A merged list of <see cref="SPREPLY" /> items</returns>
        protected override List<SPREPLY> ApplyDeltaItems(List<SPREPLY> Items, List<SPREPLY> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPREPLY deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, IReadOnlyList<SPREPLY>>> Index_CODE;
        private Lazy<Dictionary<int, SPREPLY>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <returns>List of related SPREPLY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPREPLY> FindByCODE(int CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <param name="Value">List of related SPREPLY entities</param>
        /// <returns>True if the list of related SPREPLY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(int CODE, out IReadOnlyList<SPREPLY> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPREPLY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPREPLY</param>
        /// <returns>List of related SPREPLY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPREPLY> TryFindByCODE(int CODE)
        {
            IReadOnlyList<SPREPLY> value;
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
        /// Find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <returns>Related SPREPLY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPREPLY FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <param name="Value">Related SPREPLY entity</param>
        /// <returns>True if the related SPREPLY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPREPLY Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPREPLY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPREPLY</param>
        /// <returns>Related SPREPLY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPREPLY TryFindByTID(int TID)
        {
            SPREPLY value;
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
