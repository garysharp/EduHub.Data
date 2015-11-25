using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Locations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKLDataSet : SetBase<AKL>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKL"; } }

        internal AKLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_LOCATION = new Lazy<Dictionary<string, AKL>>(() => this.ToDictionary(i => i.LOCATION));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKL" /> fields for each CSV column header</returns>
        protected override Action<AKL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ESTIMATE_UNITS":
                        mapper[i] = (e, v) => e.ESTIMATE_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PERIOD_UNITS":
                        mapper[i] = (e, v) => e.PERIOD_UNITS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "UNITS_TO_DATE":
                        mapper[i] = (e, v) => e.UNITS_TO_DATE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACUTOFF":
                        mapper[i] = (e, v) => e.ACUTOFF = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DATEFU":
                        mapper[i] = (e, v) => e.DATEFU = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PURDATE":
                        mapper[i] = (e, v) => e.PURDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AFLAG":
                        mapper[i] = (e, v) => e.AFLAG = v;
                        break;
                    case "TFLAG":
                        mapper[i] = (e, v) => e.TFLAG = v;
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
        /// Merges <see cref="AKL" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="AKL" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="AKL" /> items to added or update the base <see cref="AKL" /> items</param>
        /// <returns>A merged list of <see cref="AKL" /> items</returns>
        protected override List<AKL> ApplyDeltaItems(List<AKL> Items, List<AKL> DeltaItems)
        {
            Dictionary<string, int> Index_LOCATION = Items.ToIndexDictionary(i => i.LOCATION);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (AKL deltaItem in DeltaItems)
            {
                int index;

                if (Index_LOCATION.TryGetValue(deltaItem.LOCATION, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.LOCATION)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, AKL>> Index_LOCATION;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <returns>Related AKL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKL FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <param name="Value">Related AKL entity</param>
        /// <returns>True if the related AKL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out AKL Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find AKL by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find AKL</param>
        /// <returns>Related AKL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKL TryFindByLOCATION(string LOCATION)
        {
            AKL value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
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
