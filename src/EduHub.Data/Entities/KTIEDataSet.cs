using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Import Errors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTIEDataSet : SetBase<KTIE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KTIE"; } }

        internal KTIEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_RECORD_ID = new Lazy<Dictionary<int, KTIE>>(() => this.ToDictionary(i => i.RECORD_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTIE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTIE" /> fields for each CSV column header</returns>
        protected override Action<KTIE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTIE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RECORD_ID":
                        mapper[i] = (e, v) => e.RECORD_ID = int.Parse(v);
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KTIE" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KTIE" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KTIE" /> items to added or update the base <see cref="KTIE" /> items</param>
        /// <returns>A merged list of <see cref="KTIE" /> items</returns>
        protected override List<KTIE> ApplyDeltaItems(List<KTIE> Items, List<KTIE> DeltaItems)
        {
            Dictionary<int, int> Index_RECORD_ID = Items.ToIndexDictionary(i => i.RECORD_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KTIE deltaItem in DeltaItems)
            {
                int index;

                if (Index_RECORD_ID.TryGetValue(deltaItem.RECORD_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.RECORD_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KTIE>> Index_RECORD_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTIE FindByRECORD_ID(int RECORD_ID)
        {
            return Index_RECORD_ID.Value[RECORD_ID];
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <param name="Value">Related KTIE entity</param>
        /// <returns>True if the related KTIE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByRECORD_ID(int RECORD_ID, out KTIE Value)
        {
            return Index_RECORD_ID.Value.TryGetValue(RECORD_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID field
        /// </summary>
        /// <param name="RECORD_ID">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTIE TryFindByRECORD_ID(int RECORD_ID)
        {
            KTIE value;
            if (Index_RECORD_ID.Value.TryGetValue(RECORD_ID, out value))
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
