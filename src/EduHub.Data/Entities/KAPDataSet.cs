using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Australian Postcodes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KAPDataSet : SetBase<KAP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAP"; } }

        internal KAPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KAPKEY = new Lazy<Dictionary<string, KAP>>(() => this.ToDictionary(i => i.KAPKEY));
            Index_PLACE_NAME = new Lazy<NullDictionary<string, IReadOnlyList<KAP>>>(() => this.ToGroupedNullDictionary(i => i.PLACE_NAME));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAP" /> fields for each CSV column header</returns>
        protected override Action<KAP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAPKEY":
                        mapper[i] = (e, v) => e.KAPKEY = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "PLACE_NAME":
                        mapper[i] = (e, v) => e.PLACE_NAME = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "DISCRIMINATOR":
                        mapper[i] = (e, v) => e.DISCRIMINATOR = v;
                        break;
                    case "STREET_ADD":
                        mapper[i] = (e, v) => e.STREET_ADD = v;
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
        /// Merges <see cref="KAP" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KAP" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KAP" /> items to added or update the base <see cref="KAP" /> items</param>
        /// <returns>A merged list of <see cref="KAP" /> items</returns>
        protected override List<KAP> ApplyDeltaItems(List<KAP> Items, List<KAP> DeltaItems)
        {
            Dictionary<string, int> Index_KAPKEY = Items.ToIndexDictionary(i => i.KAPKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KAP deltaItem in DeltaItems)
            {
                int index;

                if (Index_KAPKEY.TryGetValue(deltaItem.KAPKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KAPKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KAP>> Index_KAPKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<KAP>>> Index_PLACE_NAME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <returns>Related KAP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAP FindByKAPKEY(string KAPKEY)
        {
            return Index_KAPKEY.Value[KAPKEY];
        }

        /// <summary>
        /// Attempt to find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <param name="Value">Related KAP entity</param>
        /// <returns>True if the related KAP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKAPKEY(string KAPKEY, out KAP Value)
        {
            return Index_KAPKEY.Value.TryGetValue(KAPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KAP by KAPKEY field
        /// </summary>
        /// <param name="KAPKEY">KAPKEY value used to find KAP</param>
        /// <returns>Related KAP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KAP TryFindByKAPKEY(string KAPKEY)
        {
            KAP value;
            if (Index_KAPKEY.Value.TryGetValue(KAPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <returns>List of related KAP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KAP> FindByPLACE_NAME(string PLACE_NAME)
        {
            return Index_PLACE_NAME.Value[PLACE_NAME];
        }

        /// <summary>
        /// Attempt to find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <param name="Value">List of related KAP entities</param>
        /// <returns>True if the list of related KAP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLACE_NAME(string PLACE_NAME, out IReadOnlyList<KAP> Value)
        {
            return Index_PLACE_NAME.Value.TryGetValue(PLACE_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find KAP by PLACE_NAME field
        /// </summary>
        /// <param name="PLACE_NAME">PLACE_NAME value used to find KAP</param>
        /// <returns>List of related KAP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KAP> TryFindByPLACE_NAME(string PLACE_NAME)
        {
            IReadOnlyList<KAP> value;
            if (Index_PLACE_NAME.Value.TryGetValue(PLACE_NAME, out value))
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
