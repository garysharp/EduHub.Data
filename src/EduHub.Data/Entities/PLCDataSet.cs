using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Leave Code Description Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PLCDataSet : SetBase<PLC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PLC"; } }

        internal PLCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PLCKEY = new Lazy<Dictionary<string, PLC>>(() => this.ToDictionary(i => i.PLCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PLC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PLC" /> fields for each CSV column header</returns>
        protected override Action<PLC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PLC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PLCKEY":
                        mapper[i] = (e, v) => e.PLCKEY = v;
                        break;
                    case "LEAVE_DESC":
                        mapper[i] = (e, v) => e.LEAVE_DESC = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="PLC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PLC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PLC" /> items to added or update the base <see cref="PLC" /> items</param>
        /// <returns>A merged list of <see cref="PLC" /> items</returns>
        protected override List<PLC> ApplyDeltaItems(List<PLC> Items, List<PLC> DeltaItems)
        {
            Dictionary<string, int> Index_PLCKEY = Items.ToIndexDictionary(i => i.PLCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PLC deltaItem in DeltaItems)
            {
                int index;

                if (Index_PLCKEY.TryGetValue(deltaItem.PLCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PLCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, PLC>> Index_PLCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLC FindByPLCKEY(string PLCKEY)
        {
            return Index_PLCKEY.Value[PLCKEY];
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <param name="Value">Related PLC entity</param>
        /// <returns>True if the related PLC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLCKEY(string PLCKEY, out PLC Value)
        {
            return Index_PLCKEY.Value.TryGetValue(PLCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PLC by PLCKEY field
        /// </summary>
        /// <param name="PLCKEY">PLCKEY value used to find PLC</param>
        /// <returns>Related PLC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PLC TryFindByPLCKEY(string PLCKEY)
        {
            PLC value;
            if (Index_PLCKEY.Value.TryGetValue(PLCKEY, out value))
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
