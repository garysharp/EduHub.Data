using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Links Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCLDataSet : SetBase<KPCL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPCL"; } }

        internal KPCLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CONTACT = new Lazy<NullDictionary<string, IReadOnlyList<KPCL>>>(() => this.ToGroupedNullDictionary(i => i.CONTACT));
            Index_CONTACT_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<KPCL>>>(() => this.ToGroupedNullDictionary(i => i.CONTACT_TYPE));
            Index_KPCLKEY = new Lazy<Dictionary<int, KPCL>>(() => this.ToDictionary(i => i.KPCLKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPCL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPCL" /> fields for each CSV column header</returns>
        protected override Action<KPCL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPCL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCLKEY":
                        mapper[i] = (e, v) => e.KPCLKEY = int.Parse(v);
                        break;
                    case "LINK":
                        mapper[i] = (e, v) => e.LINK = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "CONTACT_TYPE":
                        mapper[i] = (e, v) => e.CONTACT_TYPE = v;
                        break;
                    case "CONTACT_PREFERENCE":
                        mapper[i] = (e, v) => e.CONTACT_PREFERENCE = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="KPCL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPCL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPCL" /> items to added or update the base <see cref="KPCL" /> items</param>
        /// <returns>A merged list of <see cref="KPCL" /> items</returns>
        protected override List<KPCL> ApplyDeltaItems(List<KPCL> Items, List<KPCL> DeltaItems)
        {
            Dictionary<int, int> Index_KPCLKEY = Items.ToIndexDictionary(i => i.KPCLKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPCL deltaItem in DeltaItems)
            {
                int index;

                if (Index_KPCLKEY.TryGetValue(deltaItem.KPCLKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KPCLKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<KPCL>>> Index_CONTACT;
        private Lazy<NullDictionary<string, IReadOnlyList<KPCL>>> Index_CONTACT_TYPE;
        private Lazy<Dictionary<int, KPCL>> Index_KPCLKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <returns>List of related KPCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> FindByCONTACT(string CONTACT)
        {
            return Index_CONTACT.Value[CONTACT];
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <param name="Value">List of related KPCL entities</param>
        /// <returns>True if the list of related KPCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCONTACT(string CONTACT, out IReadOnlyList<KPCL> Value)
        {
            return Index_CONTACT.Value.TryGetValue(CONTACT, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT field
        /// </summary>
        /// <param name="CONTACT">CONTACT value used to find KPCL</param>
        /// <returns>List of related KPCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> TryFindByCONTACT(string CONTACT)
        {
            IReadOnlyList<KPCL> value;
            if (Index_CONTACT.Value.TryGetValue(CONTACT, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <returns>List of related KPCL entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> FindByCONTACT_TYPE(string CONTACT_TYPE)
        {
            return Index_CONTACT_TYPE.Value[CONTACT_TYPE];
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <param name="Value">List of related KPCL entities</param>
        /// <returns>True if the list of related KPCL entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCONTACT_TYPE(string CONTACT_TYPE, out IReadOnlyList<KPCL> Value)
        {
            return Index_CONTACT_TYPE.Value.TryGetValue(CONTACT_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by CONTACT_TYPE field
        /// </summary>
        /// <param name="CONTACT_TYPE">CONTACT_TYPE value used to find KPCL</param>
        /// <returns>List of related KPCL entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KPCL> TryFindByCONTACT_TYPE(string CONTACT_TYPE)
        {
            IReadOnlyList<KPCL> value;
            if (Index_CONTACT_TYPE.Value.TryGetValue(CONTACT_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCL FindByKPCLKEY(int KPCLKEY)
        {
            return Index_KPCLKEY.Value[KPCLKEY];
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <param name="Value">Related KPCL entity</param>
        /// <returns>True if the related KPCL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCLKEY(int KPCLKEY, out KPCL Value)
        {
            return Index_KPCLKEY.Value.TryGetValue(KPCLKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPCL by KPCLKEY field
        /// </summary>
        /// <param name="KPCLKEY">KPCLKEY value used to find KPCL</param>
        /// <returns>Related KPCL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPCL TryFindByKPCLKEY(int KPCLKEY)
        {
            KPCL value;
            if (Index_KPCLKEY.Value.TryGetValue(KPCLKEY, out value))
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
