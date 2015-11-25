using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCTDataSet : SetBase<KCT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCT"; } }

        internal KCTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCTKEY = new Lazy<Dictionary<short, KCT>>(() => this.ToDictionary(i => i.KCTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCT" /> fields for each CSV column header</returns>
        protected override Action<KCT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCTKEY":
                        mapper[i] = (e, v) => e.KCTKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABBREV_DESC":
                        mapper[i] = (e, v) => e.ABBREV_DESC = v;
                        break;
                    case "CURRICULUM":
                        mapper[i] = (e, v) => e.CURRICULUM = v;
                        break;
                    case "DOE_TYPE":
                        mapper[i] = (e, v) => e.DOE_TYPE = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "PRE_APPROVED":
                        mapper[i] = (e, v) => e.PRE_APPROVED = v;
                        break;
                    case "ABS_RATE":
                        mapper[i] = (e, v) => e.ABS_RATE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SMS":
                        mapper[i] = (e, v) => e.SMS = v;
                        break;
                    case "SMS_MESSAGE":
                        mapper[i] = (e, v) => e.SMS_MESSAGE = v;
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
        /// Merges <see cref="KCT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCT" /> items to added or update the base <see cref="KCT" /> items</param>
        /// <returns>A merged list of <see cref="KCT" /> items</returns>
        protected override List<KCT> ApplyDeltaItems(List<KCT> Items, List<KCT> DeltaItems)
        {
            Dictionary<short, int> Index_KCTKEY = Items.ToIndexDictionary(i => i.KCTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCT deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCTKEY.TryGetValue(deltaItem.KCTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, KCT>> Index_KCTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCT FindByKCTKEY(short KCTKEY)
        {
            return Index_KCTKEY.Value[KCTKEY];
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <param name="Value">Related KCT entity</param>
        /// <returns>True if the related KCT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCTKEY(short KCTKEY, out KCT Value)
        {
            return Index_KCTKEY.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY field
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCT TryFindByKCTKEY(short KCTKEY)
        {
            KCT value;
            if (Index_KCTKEY.Value.TryGetValue(KCTKEY, out value))
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
