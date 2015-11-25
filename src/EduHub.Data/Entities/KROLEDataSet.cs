using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Role Codes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KROLEDataSet : SetBase<KROLE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KROLE"; } }

        internal KROLEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KROLEKEY = new Lazy<Dictionary<string, KROLE>>(() => this.ToDictionary(i => i.KROLEKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KROLE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KROLE" /> fields for each CSV column header</returns>
        protected override Action<KROLE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KROLE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KROLEKEY":
                        mapper[i] = (e, v) => e.KROLEKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_NAME":
                        mapper[i] = (e, v) => e.ROLE_NAME = v;
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
        /// Merges <see cref="KROLE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KROLE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KROLE" /> items to added or update the base <see cref="KROLE" /> items</param>
        /// <returns>A merged list of <see cref="KROLE" /> items</returns>
        protected override List<KROLE> ApplyDeltaItems(List<KROLE> Items, List<KROLE> DeltaItems)
        {
            Dictionary<string, int> Index_KROLEKEY = Items.ToIndexDictionary(i => i.KROLEKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KROLE deltaItem in DeltaItems)
            {
                int index;

                if (Index_KROLEKEY.TryGetValue(deltaItem.KROLEKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KROLEKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KROLE>> Index_KROLEKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <returns>Related KROLE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KROLE FindByKROLEKEY(string KROLEKEY)
        {
            return Index_KROLEKEY.Value[KROLEKEY];
        }

        /// <summary>
        /// Attempt to find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <param name="Value">Related KROLE entity</param>
        /// <returns>True if the related KROLE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKROLEKEY(string KROLEKEY, out KROLE Value)
        {
            return Index_KROLEKEY.Value.TryGetValue(KROLEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KROLE by KROLEKEY field
        /// </summary>
        /// <param name="KROLEKEY">KROLEKEY value used to find KROLE</param>
        /// <returns>Related KROLE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KROLE TryFindByKROLEKEY(string KROLEKEY)
        {
            KROLE value;
            if (Index_KROLEKEY.Value.TryGetValue(KROLEKEY, out value))
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
