using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Medicare Levy Parameters Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PML_NEWDataSet : SetBase<PML_NEW>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PML_NEW"; } }

        internal PML_NEWDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCALE = new Lazy<Dictionary<short, PML_NEW>>(() => this.ToDictionary(i => i.SCALE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PML_NEW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PML_NEW" /> fields for each CSV column header</returns>
        protected override Action<PML_NEW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PML_NEW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCALE":
                        mapper[i] = (e, v) => e.SCALE = short.Parse(v);
                        break;
                    case "WEEKLY_EARNING_THRESHOLD":
                        mapper[i] = (e, v) => e.WEEKLY_EARNING_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_SHADEIN_THRESHOLD":
                        mapper[i] = (e, v) => e.WEEKLY_SHADEIN_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MEDLEVY_FAMILY_THRESHOLD":
                        mapper[i] = (e, v) => e.MEDLEVY_FAMILY_THRESHOLD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WFT_DIVISOR":
                        mapper[i] = (e, v) => e.WFT_DIVISOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ADDITIONAL_CHILD":
                        mapper[i] = (e, v) => e.ADDITIONAL_CHILD = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SOP_MULTIPLIER":
                        mapper[i] = (e, v) => e.SOP_MULTIPLIER = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "SOP_DIVISOR":
                        mapper[i] = (e, v) => e.SOP_DIVISOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "WLA_FALCTOR":
                        mapper[i] = (e, v) => e.WLA_FALCTOR = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MEDICARE_LEVY":
                        mapper[i] = (e, v) => e.MEDICARE_LEVY = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="PML_NEW" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PML_NEW" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PML_NEW" /> items to added or update the base <see cref="PML_NEW" /> items</param>
        /// <returns>A merged list of <see cref="PML_NEW" /> items</returns>
        protected override List<PML_NEW> ApplyDeltaItems(List<PML_NEW> Items, List<PML_NEW> DeltaItems)
        {
            Dictionary<short, int> Index_SCALE = Items.ToIndexDictionary(i => i.SCALE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PML_NEW deltaItem in DeltaItems)
            {
                int index;

                if (Index_SCALE.TryGetValue(deltaItem.SCALE, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SCALE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, PML_NEW>> Index_SCALE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PML_NEW by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML_NEW</param>
        /// <returns>Related PML_NEW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PML_NEW FindBySCALE(short SCALE)
        {
            return Index_SCALE.Value[SCALE];
        }

        /// <summary>
        /// Attempt to find PML_NEW by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML_NEW</param>
        /// <param name="Value">Related PML_NEW entity</param>
        /// <returns>True if the related PML_NEW entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCALE(short SCALE, out PML_NEW Value)
        {
            return Index_SCALE.Value.TryGetValue(SCALE, out Value);
        }

        /// <summary>
        /// Attempt to find PML_NEW by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML_NEW</param>
        /// <returns>Related PML_NEW entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PML_NEW TryFindBySCALE(short SCALE)
        {
            PML_NEW value;
            if (Index_SCALE.Value.TryGetValue(SCALE, out value))
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
