using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Incident Victims/Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SIDVDataSet : SetBase<SIDV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SIDV"; } }

        internal SIDVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_INCIDENT_KEY = new Lazy<Dictionary<int, IReadOnlyList<SIDV>>>(() => this.ToGroupedDictionary(i => i.INCIDENT_KEY));
            Index_TID = new Lazy<Dictionary<int, SIDV>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SIDV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SIDV" /> fields for each CSV column header</returns>
        protected override Action<SIDV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SIDV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "INCIDENT_KEY":
                        mapper[i] = (e, v) => e.INCIDENT_KEY = int.Parse(v);
                        break;
                    case "RECIPIENT_TYPE":
                        mapper[i] = (e, v) => e.RECIPIENT_TYPE = v;
                        break;
                    case "RECIPIENT":
                        mapper[i] = (e, v) => e.RECIPIENT = v;
                        break;
                    case "RECIPIENT_NAME":
                        mapper[i] = (e, v) => e.RECIPIENT_NAME = v;
                        break;
                    case "RECIPIENT_ADDRESS":
                        mapper[i] = (e, v) => e.RECIPIENT_ADDRESS = v;
                        break;
                    case "RECIPIENT_PHONE":
                        mapper[i] = (e, v) => e.RECIPIENT_PHONE = v;
                        break;
                    case "HOW_AFFECTED":
                        mapper[i] = (e, v) => e.HOW_AFFECTED = v;
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
        /// Merges <see cref="SIDV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SIDV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SIDV" /> items to added or update the base <see cref="SIDV" /> items</param>
        /// <returns>A merged list of <see cref="SIDV" /> items</returns>
        protected override List<SIDV> ApplyDeltaItems(List<SIDV> Items, List<SIDV> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SIDV deltaItem in DeltaItems)
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
                .OrderBy(i => i.INCIDENT_KEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, IReadOnlyList<SIDV>>> Index_INCIDENT_KEY;
        private Lazy<Dictionary<int, SIDV>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <returns>List of related SIDV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SIDV> FindByINCIDENT_KEY(int INCIDENT_KEY)
        {
            return Index_INCIDENT_KEY.Value[INCIDENT_KEY];
        }

        /// <summary>
        /// Attempt to find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <param name="Value">List of related SIDV entities</param>
        /// <returns>True if the list of related SIDV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINCIDENT_KEY(int INCIDENT_KEY, out IReadOnlyList<SIDV> Value)
        {
            return Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out Value);
        }

        /// <summary>
        /// Attempt to find SIDV by INCIDENT_KEY field
        /// </summary>
        /// <param name="INCIDENT_KEY">INCIDENT_KEY value used to find SIDV</param>
        /// <returns>List of related SIDV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SIDV> TryFindByINCIDENT_KEY(int INCIDENT_KEY)
        {
            IReadOnlyList<SIDV> value;
            if (Index_INCIDENT_KEY.Value.TryGetValue(INCIDENT_KEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <returns>Related SIDV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIDV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <param name="Value">Related SIDV entity</param>
        /// <returns>True if the related SIDV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SIDV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SIDV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SIDV</param>
        /// <returns>Related SIDV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SIDV TryFindByTID(int TID)
        {
            SIDV value;
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
