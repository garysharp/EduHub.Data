using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Group Membership Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGSGDataSet : SetBase<SGSG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGSG"; } }

        internal SGSGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGLINK = new Lazy<NullDictionary<string, IReadOnlyList<SGSG>>>(() => this.ToGroupedNullDictionary(i => i.SGLINK));
            Index_SGSGKEY = new Lazy<Dictionary<string, IReadOnlyList<SGSG>>>(() => this.ToGroupedDictionary(i => i.SGSGKEY));
            Index_TID = new Lazy<Dictionary<int, SGSG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGSG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGSG" /> fields for each CSV column header</returns>
        protected override Action<SGSG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGSG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGSGKEY":
                        mapper[i] = (e, v) => e.SGSGKEY = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
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
        /// Merges <see cref="SGSG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGSG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGSG" /> items to added or update the base <see cref="SGSG" /> items</param>
        /// <returns>A merged list of <see cref="SGSG" /> items</returns>
        protected override List<SGSG> ApplyDeltaItems(List<SGSG> Items, List<SGSG> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGSG deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGSGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SGSG>>> Index_SGLINK;
        private Lazy<Dictionary<string, IReadOnlyList<SGSG>>> Index_SGSGKEY;
        private Lazy<Dictionary<int, SGSG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <returns>List of related SGSG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> FindBySGLINK(string SGLINK)
        {
            return Index_SGLINK.Value[SGLINK];
        }

        /// <summary>
        /// Attempt to find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <param name="Value">List of related SGSG entities</param>
        /// <returns>True if the list of related SGSG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGLINK(string SGLINK, out IReadOnlyList<SGSG> Value)
        {
            return Index_SGLINK.Value.TryGetValue(SGLINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <returns>List of related SGSG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> TryFindBySGLINK(string SGLINK)
        {
            IReadOnlyList<SGSG> value;
            if (Index_SGLINK.Value.TryGetValue(SGLINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <returns>List of related SGSG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> FindBySGSGKEY(string SGSGKEY)
        {
            return Index_SGSGKEY.Value[SGSGKEY];
        }

        /// <summary>
        /// Attempt to find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <param name="Value">List of related SGSG entities</param>
        /// <returns>True if the list of related SGSG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGSGKEY(string SGSGKEY, out IReadOnlyList<SGSG> Value)
        {
            return Index_SGSGKEY.Value.TryGetValue(SGSGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <returns>List of related SGSG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> TryFindBySGSGKEY(string SGSGKEY)
        {
            IReadOnlyList<SGSG> value;
            if (Index_SGSGKEY.Value.TryGetValue(SGSGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <returns>Related SGSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <param name="Value">Related SGSG entity</param>
        /// <returns>True if the related SGSG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGSG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <returns>Related SGSG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSG TryFindByTID(int TID)
        {
            SGSG value;
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
