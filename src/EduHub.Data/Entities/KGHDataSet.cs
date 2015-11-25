using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Houses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGHDataSet : SetBase<KGH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGH"; } }

        internal KGHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<KGH>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_KGHKEY = new Lazy<Dictionary<string, KGH>>(() => this.ToDictionary(i => i.KGHKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGH" /> fields for each CSV column header</returns>
        protected override Action<KGH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGHKEY":
                        mapper[i] = (e, v) => e.KGHKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "HOUSE_SIZE":
                        mapper[i] = (e, v) => e.HOUSE_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F01":
                        mapper[i] = (e, v) => e.AGE_F01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F02":
                        mapper[i] = (e, v) => e.AGE_F02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F03":
                        mapper[i] = (e, v) => e.AGE_F03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F04":
                        mapper[i] = (e, v) => e.AGE_F04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F05":
                        mapper[i] = (e, v) => e.AGE_F05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F06":
                        mapper[i] = (e, v) => e.AGE_F06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F07":
                        mapper[i] = (e, v) => e.AGE_F07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F08":
                        mapper[i] = (e, v) => e.AGE_F08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F09":
                        mapper[i] = (e, v) => e.AGE_F09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F10":
                        mapper[i] = (e, v) => e.AGE_F10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F11":
                        mapper[i] = (e, v) => e.AGE_F11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F12":
                        mapper[i] = (e, v) => e.AGE_F12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F13":
                        mapper[i] = (e, v) => e.AGE_F13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F14":
                        mapper[i] = (e, v) => e.AGE_F14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F15":
                        mapper[i] = (e, v) => e.AGE_F15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F16":
                        mapper[i] = (e, v) => e.AGE_F16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F17":
                        mapper[i] = (e, v) => e.AGE_F17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F18":
                        mapper[i] = (e, v) => e.AGE_F18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F19":
                        mapper[i] = (e, v) => e.AGE_F19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F20":
                        mapper[i] = (e, v) => e.AGE_F20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M01":
                        mapper[i] = (e, v) => e.AGE_M01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M02":
                        mapper[i] = (e, v) => e.AGE_M02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M03":
                        mapper[i] = (e, v) => e.AGE_M03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M04":
                        mapper[i] = (e, v) => e.AGE_M04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M05":
                        mapper[i] = (e, v) => e.AGE_M05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M06":
                        mapper[i] = (e, v) => e.AGE_M06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M07":
                        mapper[i] = (e, v) => e.AGE_M07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M08":
                        mapper[i] = (e, v) => e.AGE_M08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M09":
                        mapper[i] = (e, v) => e.AGE_M09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M10":
                        mapper[i] = (e, v) => e.AGE_M10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M11":
                        mapper[i] = (e, v) => e.AGE_M11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M12":
                        mapper[i] = (e, v) => e.AGE_M12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M13":
                        mapper[i] = (e, v) => e.AGE_M13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M14":
                        mapper[i] = (e, v) => e.AGE_M14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M15":
                        mapper[i] = (e, v) => e.AGE_M15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M16":
                        mapper[i] = (e, v) => e.AGE_M16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M17":
                        mapper[i] = (e, v) => e.AGE_M17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M18":
                        mapper[i] = (e, v) => e.AGE_M18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M19":
                        mapper[i] = (e, v) => e.AGE_M19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M20":
                        mapper[i] = (e, v) => e.AGE_M20 = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="KGH" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGH" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGH" /> items to added or update the base <see cref="KGH" /> items</param>
        /// <returns>A merged list of <see cref="KGH" /> items</returns>
        protected override List<KGH> ApplyDeltaItems(List<KGH> Items, List<KGH> DeltaItems)
        {
            Dictionary<string, int> Index_KGHKEY = Items.ToIndexDictionary(i => i.KGHKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGH deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGHKEY.TryGetValue(deltaItem.KGHKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGHKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<KGH>>> Index_CAMPUS;
        private Lazy<Dictionary<string, KGH>> Index_KGHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGH by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGH</param>
        /// <returns>List of related KGH entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGH> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find KGH by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGH</param>
        /// <param name="Value">List of related KGH entities</param>
        /// <returns>True if the list of related KGH entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<KGH> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find KGH by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find KGH</param>
        /// <returns>List of related KGH entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGH> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<KGH> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGH by KGHKEY field
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find KGH</param>
        /// <returns>Related KGH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGH FindByKGHKEY(string KGHKEY)
        {
            return Index_KGHKEY.Value[KGHKEY];
        }

        /// <summary>
        /// Attempt to find KGH by KGHKEY field
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find KGH</param>
        /// <param name="Value">Related KGH entity</param>
        /// <returns>True if the related KGH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGHKEY(string KGHKEY, out KGH Value)
        {
            return Index_KGHKEY.Value.TryGetValue(KGHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGH by KGHKEY field
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find KGH</param>
        /// <returns>Related KGH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGH TryFindByKGHKEY(string KGHKEY)
        {
            KGH value;
            if (Index_KGHKEY.Value.TryGetValue(KGHKEY, out value))
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
