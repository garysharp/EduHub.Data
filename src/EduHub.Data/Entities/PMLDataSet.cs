using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medicare Levy Parameters Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PMLDataSet : SetBase<PML>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PML"; } }

        internal PMLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SCALE = new Lazy<Dictionary<short, PML>>(() => this.ToDictionary(i => i.SCALE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PML" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PML" /> fields for each CSV column header</returns>
        protected override Action<PML, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PML, string>[Headers.Count];

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
        /// Merges <see cref="PML" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PML" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PML" /> items to added or update the base <see cref="PML" /> items</param>
        /// <returns>A merged list of <see cref="PML" /> items</returns>
        protected override List<PML> ApplyDeltaItems(List<PML> Items, List<PML> DeltaItems)
        {
            Dictionary<short, int> Index_SCALE = Items.ToIndexDictionary(i => i.SCALE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PML deltaItem in DeltaItems)
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

        private Lazy<Dictionary<short, PML>> Index_SCALE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <returns>Related PML entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PML FindBySCALE(short SCALE)
        {
            return Index_SCALE.Value[SCALE];
        }

        /// <summary>
        /// Attempt to find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <param name="Value">Related PML entity</param>
        /// <returns>True if the related PML entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySCALE(short SCALE, out PML Value)
        {
            return Index_SCALE.Value.TryGetValue(SCALE, out Value);
        }

        /// <summary>
        /// Attempt to find PML by SCALE field
        /// </summary>
        /// <param name="SCALE">SCALE value used to find PML</param>
        /// <returns>Related PML entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PML TryFindBySCALE(short SCALE)
        {
            PML value;
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
