using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject/Class Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGSCDataSet : SetBase<SGSC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SGSC"; } }

        internal SGSCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGSCKEY = new Lazy<Dictionary<string, IReadOnlyList<SGSC>>>(() => this.ToGroupedDictionary(i => i.SGSCKEY));
            Index_SULINK = new Lazy<NullDictionary<string, IReadOnlyList<SGSC>>>(() => this.ToGroupedNullDictionary(i => i.SULINK));
            Index_TID = new Lazy<Dictionary<int, SGSC>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGSC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGSC" /> fields for each CSV column header</returns>
        protected override Action<SGSC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGSC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGSCKEY":
                        mapper[i] = (e, v) => e.SGSCKEY = v;
                        break;
                    case "SULINK":
                        mapper[i] = (e, v) => e.SULINK = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
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
        /// Merges <see cref="SGSC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SGSC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SGSC" /> items to added or update the base <see cref="SGSC" /> items</param>
        /// <returns>A merged list of <see cref="SGSC" /> items</returns>
        protected override List<SGSC> ApplyDeltaItems(List<SGSC> Items, List<SGSC> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SGSC deltaItem in DeltaItems)
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
                .OrderBy(i => i.SGSCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<SGSC>>> Index_SGSCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SGSC>>> Index_SULINK;
        private Lazy<Dictionary<int, SGSC>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <returns>List of related SGSC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> FindBySGSCKEY(string SGSCKEY)
        {
            return Index_SGSCKEY.Value[SGSCKEY];
        }

        /// <summary>
        /// Attempt to find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <param name="Value">List of related SGSC entities</param>
        /// <returns>True if the list of related SGSC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGSCKEY(string SGSCKEY, out IReadOnlyList<SGSC> Value)
        {
            return Index_SGSCKEY.Value.TryGetValue(SGSCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by SGSCKEY field
        /// </summary>
        /// <param name="SGSCKEY">SGSCKEY value used to find SGSC</param>
        /// <returns>List of related SGSC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> TryFindBySGSCKEY(string SGSCKEY)
        {
            IReadOnlyList<SGSC> value;
            if (Index_SGSCKEY.Value.TryGetValue(SGSCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <returns>List of related SGSC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> FindBySULINK(string SULINK)
        {
            return Index_SULINK.Value[SULINK];
        }

        /// <summary>
        /// Attempt to find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <param name="Value">List of related SGSC entities</param>
        /// <returns>True if the list of related SGSC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySULINK(string SULINK, out IReadOnlyList<SGSC> Value)
        {
            return Index_SULINK.Value.TryGetValue(SULINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by SULINK field
        /// </summary>
        /// <param name="SULINK">SULINK value used to find SGSC</param>
        /// <returns>List of related SGSC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSC> TryFindBySULINK(string SULINK)
        {
            IReadOnlyList<SGSC> value;
            if (Index_SULINK.Value.TryGetValue(SULINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <returns>Related SGSC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSC FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <param name="Value">Related SGSC entity</param>
        /// <returns>True if the related SGSC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGSC Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGSC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSC</param>
        /// <returns>Related SGSC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSC TryFindByTID(int TID)
        {
            SGSC value;
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
