using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Visa Subclasses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCVDataSet : SetBase<KCV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCV"; } }

        internal KCVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_VISA_SUBCLASS = new Lazy<Dictionary<string, KCV>>(() => this.ToDictionary(i => i.VISA_SUBCLASS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCV" /> fields for each CSV column header</returns>
        protected override Action<KCV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "VISA_RESIDENCY":
                        mapper[i] = (e, v) => e.VISA_RESIDENCY = v;
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "CHECK_STAT_CODE":
                        mapper[i] = (e, v) => e.CHECK_STAT_CODE = v;
                        break;
                    case "CHECK_EXPIRY_DATE":
                        mapper[i] = (e, v) => e.CHECK_EXPIRY_DATE = v;
                        break;
                    case "CHECK_ISID":
                        mapper[i] = (e, v) => e.CHECK_ISID = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
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
        /// Merges <see cref="KCV" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCV" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCV" /> items to added or update the base <see cref="KCV" /> items</param>
        /// <returns>A merged list of <see cref="KCV" /> items</returns>
        protected override List<KCV> ApplyDeltaItems(List<KCV> Items, List<KCV> DeltaItems)
        {
            Dictionary<string, int> Index_VISA_SUBCLASS = Items.ToIndexDictionary(i => i.VISA_SUBCLASS);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCV deltaItem in DeltaItems)
            {
                int index;

                if (Index_VISA_SUBCLASS.TryGetValue(deltaItem.VISA_SUBCLASS, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.VISA_SUBCLASS)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCV>> Index_VISA_SUBCLASS;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <returns>Related KCV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCV FindByVISA_SUBCLASS(string VISA_SUBCLASS)
        {
            return Index_VISA_SUBCLASS.Value[VISA_SUBCLASS];
        }

        /// <summary>
        /// Attempt to find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <param name="Value">Related KCV entity</param>
        /// <returns>True if the related KCV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVISA_SUBCLASS(string VISA_SUBCLASS, out KCV Value)
        {
            return Index_VISA_SUBCLASS.Value.TryGetValue(VISA_SUBCLASS, out Value);
        }

        /// <summary>
        /// Attempt to find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <returns>Related KCV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCV TryFindByVISA_SUBCLASS(string VISA_SUBCLASS)
        {
            KCV value;
            if (Index_VISA_SUBCLASS.Value.TryGetValue(VISA_SUBCLASS, out value))
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
