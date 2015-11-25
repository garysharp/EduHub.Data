using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Pay Steps or Pay Class Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PSFDataSet : SetBase<PSF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PSF"; } }

        internal PSFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PSKEY = new Lazy<Dictionary<short, IReadOnlyList<PSF>>>(() => this.ToGroupedDictionary(i => i.PSKEY));
            Index_TID = new Lazy<Dictionary<int, PSF>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PSF" /> fields for each CSV column header</returns>
        protected override Action<PSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = short.Parse(v);
                        break;
                    case "EFFECTIVE_FROM_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EFFECTIVE_TO_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
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
        /// Merges <see cref="PSF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PSF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PSF" /> items to added or update the base <see cref="PSF" /> items</param>
        /// <returns>A merged list of <see cref="PSF" /> items</returns>
        protected override List<PSF> ApplyDeltaItems(List<PSF> Items, List<PSF> DeltaItems)
        {
            Dictionary<int, int> Index_TID = Items.ToIndexDictionary(i => i.TID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PSF deltaItem in DeltaItems)
            {
                int index;

                if (Index_TID.TryGetValue(deltaItem.TID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PSKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<short, IReadOnlyList<PSF>>> Index_PSKEY;
        private Lazy<Dictionary<int, PSF>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <returns>List of related PSF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PSF> FindByPSKEY(short PSKEY)
        {
            return Index_PSKEY.Value[PSKEY];
        }

        /// <summary>
        /// Attempt to find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <param name="Value">List of related PSF entities</param>
        /// <returns>True if the list of related PSF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPSKEY(short PSKEY, out IReadOnlyList<PSF> Value)
        {
            return Index_PSKEY.Value.TryGetValue(PSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PSF by PSKEY field
        /// </summary>
        /// <param name="PSKEY">PSKEY value used to find PSF</param>
        /// <returns>List of related PSF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PSF> TryFindByPSKEY(short PSKEY)
        {
            IReadOnlyList<PSF> value;
            if (Index_PSKEY.Value.TryGetValue(PSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <returns>Related PSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSF FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <param name="Value">Related PSF entity</param>
        /// <returns>True if the related PSF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PSF Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PSF by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PSF</param>
        /// <returns>Related PSF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PSF TryFindByTID(int TID)
        {
            PSF value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
