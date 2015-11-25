using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contacts Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCDataSet : SetBase<KPC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPC"; } }

        internal KPCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPCKEY = new Lazy<Dictionary<string, KPC>>(() => this.ToDictionary(i => i.KPCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPC" /> fields for each CSV column header</returns>
        protected override Action<KPC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCKEY":
                        mapper[i] = (e, v) => e.KPCKEY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POST":
                        mapper[i] = (e, v) => e.POST = v;
                        break;
                    case "BUS_PHONE":
                        mapper[i] = (e, v) => e.BUS_PHONE = v;
                        break;
                    case "HOME_PHONE":
                        mapper[i] = (e, v) => e.HOME_PHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
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
        /// Merges <see cref="KPC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KPC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KPC" /> items to added or update the base <see cref="KPC" /> items</param>
        /// <returns>A merged list of <see cref="KPC" /> items</returns>
        protected override List<KPC> ApplyDeltaItems(List<KPC> Items, List<KPC> DeltaItems)
        {
            Dictionary<string, int> Index_KPCKEY = Items.ToIndexDictionary(i => i.KPCKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KPC deltaItem in DeltaItems)
            {
                int index;

                if (Index_KPCKEY.TryGetValue(deltaItem.KPCKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KPCKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KPC>> Index_KPCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <returns>Related KPC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPC FindByKPCKEY(string KPCKEY)
        {
            return Index_KPCKEY.Value[KPCKEY];
        }

        /// <summary>
        /// Attempt to find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <param name="Value">Related KPC entity</param>
        /// <returns>True if the related KPC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCKEY(string KPCKEY, out KPC Value)
        {
            return Index_KPCKEY.Value.TryGetValue(KPCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <returns>Related KPC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPC TryFindByKPCKEY(string KPCKEY)
        {
            KPC value;
            if (Index_KPCKEY.Value.TryGetValue(KPCKEY, out value))
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
