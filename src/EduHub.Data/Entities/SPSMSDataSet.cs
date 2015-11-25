using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS messages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPSMSDataSet : SetBase<SPSMS>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPSMS"; } }

        internal SPSMSDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SPSMSKEY = new Lazy<Dictionary<int, SPSMS>>(() => this.ToDictionary(i => i.SPSMSKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPSMS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPSMS" /> fields for each CSV column header</returns>
        protected override Action<SPSMS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPSMS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPSMSKEY":
                        mapper[i] = (e, v) => e.SPSMSKEY = int.Parse(v);
                        break;
                    case "MESSAGE":
                        mapper[i] = (e, v) => e.MESSAGE = v;
                        break;
                    case "CREATED_DATE":
                        mapper[i] = (e, v) => e.CREATED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATED_BY":
                        mapper[i] = (e, v) => e.CREATED_BY = v;
                        break;
                    case "NOTIFY_REPLIES":
                        mapper[i] = (e, v) => e.NOTIFY_REPLIES = v;
                        break;
                    case "AUTO_MESSAGE":
                        mapper[i] = (e, v) => e.AUTO_MESSAGE = v;
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
        /// Merges <see cref="SPSMS" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPSMS" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPSMS" /> items to added or update the base <see cref="SPSMS" /> items</param>
        /// <returns>A merged list of <see cref="SPSMS" /> items</returns>
        protected override List<SPSMS> ApplyDeltaItems(List<SPSMS> Items, List<SPSMS> DeltaItems)
        {
            Dictionary<int, int> Index_SPSMSKEY = Items.ToIndexDictionary(i => i.SPSMSKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPSMS deltaItem in DeltaItems)
            {
                int index;

                if (Index_SPSMSKEY.TryGetValue(deltaItem.SPSMSKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SPSMSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SPSMS>> Index_SPSMSKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPSMS FindBySPSMSKEY(int SPSMSKEY)
        {
            return Index_SPSMSKEY.Value[SPSMSKEY];
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <param name="Value">Related SPSMS entity</param>
        /// <returns>True if the related SPSMS entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPSMSKEY(int SPSMSKEY, out SPSMS Value)
        {
            return Index_SPSMSKEY.Value.TryGetValue(SPSMSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPSMS by SPSMSKEY field
        /// </summary>
        /// <param name="SPSMSKEY">SPSMSKEY value used to find SPSMS</param>
        /// <returns>Related SPSMS entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPSMS TryFindBySPSMSKEY(int SPSMSKEY)
        {
            SPSMS value;
            if (Index_SPSMSKEY.Value.TryGetValue(SPSMSKEY, out value))
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
