using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Modes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TRPMODEDataSet : SetBase<TRPMODE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TRPMODE"; } }

        internal TRPMODEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TRANSPORT_MODE_ID = new Lazy<Dictionary<int, TRPMODE>>(() => this.ToDictionary(i => i.TRANSPORT_MODE_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TRPMODE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TRPMODE" /> fields for each CSV column header</returns>
        protected override Action<TRPMODE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TRPMODE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TRANSPORT_MODE_ID":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_ID = int.Parse(v);
                        break;
                    case "TRANSPORT_MODE_DESC":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_DESC = v;
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
        /// Merges <see cref="TRPMODE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TRPMODE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TRPMODE" /> items to added or update the base <see cref="TRPMODE" /> items</param>
        /// <returns>A merged list of <see cref="TRPMODE" /> items</returns>
        protected override List<TRPMODE> ApplyDeltaItems(List<TRPMODE> Items, List<TRPMODE> DeltaItems)
        {
            Dictionary<int, int> Index_TRANSPORT_MODE_ID = Items.ToIndexDictionary(i => i.TRANSPORT_MODE_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TRPMODE deltaItem in DeltaItems)
            {
                int index;

                if (Index_TRANSPORT_MODE_ID.TryGetValue(deltaItem.TRANSPORT_MODE_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.TRANSPORT_MODE_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, TRPMODE>> Index_TRANSPORT_MODE_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TRPMODE by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRPMODE FindByTRANSPORT_MODE_ID(int TRANSPORT_MODE_ID)
        {
            return Index_TRANSPORT_MODE_ID.Value[TRANSPORT_MODE_ID];
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <param name="Value">Related TRPMODE entity</param>
        /// <returns>True if the related TRPMODE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRANSPORT_MODE_ID(int TRANSPORT_MODE_ID, out TRPMODE Value)
        {
            return Index_TRANSPORT_MODE_ID.Value.TryGetValue(TRANSPORT_MODE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TRPMODE by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPMODE</param>
        /// <returns>Related TRPMODE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRPMODE TryFindByTRANSPORT_MODE_ID(int TRANSPORT_MODE_ID)
        {
            TRPMODE value;
            if (Index_TRANSPORT_MODE_ID.Value.TryGetValue(TRANSPORT_MODE_ID, out value))
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
