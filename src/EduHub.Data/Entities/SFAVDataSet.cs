using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Availability for Calendar Extras Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFAVDataSet : SetBase<SFAV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SFAV"; } }

        internal SFAVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TEACH = new Lazy<Dictionary<string, IReadOnlyList<SFAV>>>(() => this.ToGroupedDictionary(i => i.TEACH));
            Index_TID = new Lazy<Dictionary<int, SFAV>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SFAV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SFAV" /> fields for each CSV column header</returns>
        protected override Action<SFAV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SFAV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "TEACH":
                        mapper[i] = (e, v) => e.TEACH = v;
                        break;
                    case "DAY_NUMBER":
                        mapper[i] = (e, v) => e.DAY_NUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_TIME":
                        mapper[i] = (e, v) => e.START_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_TIME":
                        mapper[i] = (e, v) => e.END_TIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AVAILABLE_DATE":
                        mapper[i] = (e, v) => e.AVAILABLE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SFAV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SFAV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SFAV" /> items to added or update the base <see cref="SFAV" /> items</param>
        /// <returns>A merged list of <see cref="SFAV" /> items</returns>
        protected override List<SFAV> ApplyDeltaItems(List<SFAV> Items, List<SFAV> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SFAV deltaItem in DeltaItems)
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
                .OrderBy(i => i.TEACH)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SFAV>>> Index_TEACH;
        private Lazy<Dictionary<int, SFAV>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SFAV by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFAV</param>
        /// <returns>List of related SFAV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAV> FindByTEACH(string TEACH)
        {
            return Index_TEACH.Value[TEACH];
        }

        /// <summary>
        /// Attempt to find SFAV by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFAV</param>
        /// <param name="Value">List of related SFAV entities</param>
        /// <returns>True if the list of related SFAV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEACH(string TEACH, out IReadOnlyList<SFAV> Value)
        {
            return Index_TEACH.Value.TryGetValue(TEACH, out Value);
        }

        /// <summary>
        /// Attempt to find SFAV by TEACH field
        /// </summary>
        /// <param name="TEACH">TEACH value used to find SFAV</param>
        /// <returns>List of related SFAV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SFAV> TryFindByTEACH(string TEACH)
        {
            IReadOnlyList<SFAV> value;
            if (Index_TEACH.Value.TryGetValue(TEACH, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SFAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAV</param>
        /// <returns>Related SFAV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAV FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SFAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAV</param>
        /// <param name="Value">Related SFAV entity</param>
        /// <returns>True if the related SFAV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SFAV Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SFAV by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SFAV</param>
        /// <returns>Related SFAV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SFAV TryFindByTID(int TID)
        {
            SFAV value;
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
