using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Report Usage Metadata Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_RPTDataSet : SetBase<SCEN_RPT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_RPT"; } }

        internal SCEN_RPTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_RPT>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_RPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_RPT" /> fields for each CSV column header</returns>
        protected override Action<SCEN_RPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_RPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "PROG":
                        mapper[i] = (e, v) => e.PROG = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "REQUIREDPRINCIPALFIELD":
                        mapper[i] = (e, v) => e.REQUIREDPRINCIPALFIELD = v;
                        break;
                    case "ISPRIMARY":
                        mapper[i] = (e, v) => e.ISPRIMARY = v;
                        break;
                    case "ISPRIMARYSECONDARY":
                        mapper[i] = (e, v) => e.ISPRIMARYSECONDARY = v;
                        break;
                    case "ISSECONDARY":
                        mapper[i] = (e, v) => e.ISSECONDARY = v;
                        break;
                    case "ISLANGUAGE":
                        mapper[i] = (e, v) => e.ISLANGUAGE = v;
                        break;
                    case "ISSPECIAL":
                        mapper[i] = (e, v) => e.ISSPECIAL = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_RPT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_RPT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_RPT" /> items to added or update the base <see cref="SCEN_RPT" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_RPT" /> items</returns>
        protected override List<SCEN_RPT> ApplyDeltaItems(List<SCEN_RPT> Items, List<SCEN_RPT> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_RPT deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_RPT>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RPT FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <param name="Value">Related SCEN_RPT entity</param>
        /// <returns>True if the related SCEN_RPT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_RPT Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_RPT TryFindByID(int ID)
        {
            SCEN_RPT value;
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
