using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPYDataSet : SetBase<PEPY>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPY"; } }

        internal PEPYDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPY>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_PURPOSE = new Lazy<NullDictionary<string, IReadOnlyList<PEPY>>>(() => this.ToGroupedNullDictionary(i => i.PURPOSE));
            Index_TID = new Lazy<Dictionary<int, PEPY>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPY" /> fields for each CSV column header</returns>
        protected override Action<PEPY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRANSDATE":
                        mapper[i] = (e, v) => e.TRANSDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STAFF":
                        mapper[i] = (e, v) => e.STAFF = v;
                        break;
                    case "PURPOSE":
                        mapper[i] = (e, v) => e.PURPOSE = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
        /// Merges <see cref="PEPY" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PEPY" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PEPY" /> items to added or update the base <see cref="PEPY" /> items</param>
        /// <returns>A merged list of <see cref="PEPY" /> items</returns>
        protected override List<PEPY> ApplyDeltaItems(List<PEPY> Items, List<PEPY> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PEPY deltaItem in DeltaItems)
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

        private Lazy<Dictionary<string, IReadOnlyList<PEPY>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPY>>> Index_PURPOSE;
        private Lazy<Dictionary<int, PEPY>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <returns>List of related PEPY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <param name="Value">List of related PEPY entities</param>
        /// <returns>True if the list of related PEPY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPY> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPY</param>
        /// <returns>List of related PEPY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPY> value;
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
        /// Find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <returns>List of related PEPY entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> FindByPURPOSE(string PURPOSE)
        {
            return Index_PURPOSE.Value[PURPOSE];
        }

        /// <summary>
        /// Attempt to find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <param name="Value">List of related PEPY entities</param>
        /// <returns>True if the list of related PEPY entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPURPOSE(string PURPOSE, out IReadOnlyList<PEPY> Value)
        {
            return Index_PURPOSE.Value.TryGetValue(PURPOSE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by PURPOSE field
        /// </summary>
        /// <param name="PURPOSE">PURPOSE value used to find PEPY</param>
        /// <returns>List of related PEPY entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPY> TryFindByPURPOSE(string PURPOSE)
        {
            IReadOnlyList<PEPY> value;
            if (Index_PURPOSE.Value.TryGetValue(PURPOSE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <returns>Related PEPY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPY FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <param name="Value">Related PEPY entity</param>
        /// <returns>True if the related PEPY entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPY Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPY by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPY</param>
        /// <returns>Related PEPY entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPY TryFindByTID(int TID)
        {
            PEPY value;
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
