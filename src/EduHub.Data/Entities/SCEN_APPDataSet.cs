using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Application Message Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_APPDataSet : SetBase<SCEN_APP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_APP"; } }

        internal SCEN_APPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_APP>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_APP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_APP" /> fields for each CSV column header</returns>
        protected override Action<SCEN_APP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_APP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ITEMNAME":
                        mapper[i] = (e, v) => e.ITEMNAME = v;
                        break;
                    case "ITEMVALUE":
                        mapper[i] = (e, v) => e.ITEMVALUE = v;
                        break;
                    case "ITEMTYPE":
                        mapper[i] = (e, v) => e.ITEMTYPE = v;
                        break;
                    case "ITEMMINITYPE":
                        mapper[i] = (e, v) => e.ITEMMINITYPE = v;
                        break;
                    case "ITEMCOMMENTS":
                        mapper[i] = (e, v) => e.ITEMCOMMENTS = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_APP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_APP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_APP" /> items to added or update the base <see cref="SCEN_APP" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_APP" /> items</returns>
        protected override List<SCEN_APP> ApplyDeltaItems(List<SCEN_APP> Items, List<SCEN_APP> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_APP deltaItem in DeltaItems)
            {
                int index;

                if (Index_ID.TryGetValue(deltaItem.ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, SCEN_APP>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <returns>Related SCEN_APP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_APP FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <param name="Value">Related SCEN_APP entity</param>
        /// <returns>True if the related SCEN_APP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_APP Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_APP by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_APP</param>
        /// <returns>Related SCEN_APP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_APP TryFindByID(int ID)
        {
            SCEN_APP value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
