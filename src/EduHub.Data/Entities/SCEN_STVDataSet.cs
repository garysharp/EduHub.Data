using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Validation Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_STVDataSet : SetBase<SCEN_STV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_STV"; } }

        internal SCEN_STVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_STV>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_STV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_STV" /> fields for each CSV column header</returns>
        protected override Action<SCEN_STV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_STV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ID_STUDENTVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_STUDENTVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FIELDVALUES":
                        mapper[i] = (e, v) => e.FIELDVALUES = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_STV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SCEN_STV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SCEN_STV" /> items to added or update the base <see cref="SCEN_STV" /> items</param>
        /// <returns>A merged list of <see cref="SCEN_STV" /> items</returns>
        protected override List<SCEN_STV> ApplyDeltaItems(List<SCEN_STV> Items, List<SCEN_STV> DeltaItems)
        {
            Dictionary<int, int> Index_ID = Items.ToIndexDictionary(i => i.ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SCEN_STV deltaItem in DeltaItems)
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

        private Lazy<Dictionary<int, SCEN_STV>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_STV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_STV</param>
        /// <returns>Related SCEN_STV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_STV FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_STV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_STV</param>
        /// <param name="Value">Related SCEN_STV entity</param>
        /// <returns>True if the related SCEN_STV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_STV Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_STV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_STV</param>
        /// <returns>Related SCEN_STV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_STV TryFindByID(int ID)
        {
            SCEN_STV value;
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
