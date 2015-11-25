using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Import or Update Errors Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KERRORDataSet : SetBase<KERROR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KERROR"; } }

        internal KERRORDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KERROR_ID = new Lazy<Dictionary<int, KERROR>>(() => this.ToDictionary(i => i.KERROR_ID));
            Index_SPOUTKEY = new Lazy<NullDictionary<string, IReadOnlyList<KERROR>>>(() => this.ToGroupedNullDictionary(i => i.SPOUTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KERROR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KERROR" /> fields for each CSV column header</returns>
        protected override Action<KERROR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KERROR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KERROR_ID":
                        mapper[i] = (e, v) => e.KERROR_ID = int.Parse(v);
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "TEXT01":
                        mapper[i] = (e, v) => e.TEXT01 = v;
                        break;
                    case "TEXT02":
                        mapper[i] = (e, v) => e.TEXT02 = v;
                        break;
                    case "TEXT03":
                        mapper[i] = (e, v) => e.TEXT03 = v;
                        break;
                    case "TEXT04":
                        mapper[i] = (e, v) => e.TEXT04 = v;
                        break;
                    case "TEXT05":
                        mapper[i] = (e, v) => e.TEXT05 = v;
                        break;
                    case "TEXT06":
                        mapper[i] = (e, v) => e.TEXT06 = v;
                        break;
                    case "TEXT07":
                        mapper[i] = (e, v) => e.TEXT07 = v;
                        break;
                    case "TEXT08":
                        mapper[i] = (e, v) => e.TEXT08 = v;
                        break;
                    case "TEXT09":
                        mapper[i] = (e, v) => e.TEXT09 = v;
                        break;
                    case "VALIDATION":
                        mapper[i] = (e, v) => e.VALIDATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PROCESSED":
                        mapper[i] = (e, v) => e.PROCESSED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
                        break;
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KERROR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KERROR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KERROR" /> items to added or update the base <see cref="KERROR" /> items</param>
        /// <returns>A merged list of <see cref="KERROR" /> items</returns>
        protected override List<KERROR> ApplyDeltaItems(List<KERROR> Items, List<KERROR> DeltaItems)
        {
            Dictionary<int, int> Index_KERROR_ID = Items.ToIndexDictionary(i => i.KERROR_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KERROR deltaItem in DeltaItems)
            {
                int index;

                if (Index_KERROR_ID.TryGetValue(deltaItem.KERROR_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KERROR_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, KERROR>> Index_KERROR_ID;
        private Lazy<NullDictionary<string, IReadOnlyList<KERROR>>> Index_SPOUTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <returns>Related KERROR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KERROR FindByKERROR_ID(int KERROR_ID)
        {
            return Index_KERROR_ID.Value[KERROR_ID];
        }

        /// <summary>
        /// Attempt to find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <param name="Value">Related KERROR entity</param>
        /// <returns>True if the related KERROR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKERROR_ID(int KERROR_ID, out KERROR Value)
        {
            return Index_KERROR_ID.Value.TryGetValue(KERROR_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KERROR by KERROR_ID field
        /// </summary>
        /// <param name="KERROR_ID">KERROR_ID value used to find KERROR</param>
        /// <returns>Related KERROR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KERROR TryFindByKERROR_ID(int KERROR_ID)
        {
            KERROR value;
            if (Index_KERROR_ID.Value.TryGetValue(KERROR_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <returns>List of related KERROR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KERROR> FindBySPOUTKEY(string SPOUTKEY)
        {
            return Index_SPOUTKEY.Value[SPOUTKEY];
        }

        /// <summary>
        /// Attempt to find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <param name="Value">List of related KERROR entities</param>
        /// <returns>True if the list of related KERROR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPOUTKEY(string SPOUTKEY, out IReadOnlyList<KERROR> Value)
        {
            return Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KERROR by SPOUTKEY field
        /// </summary>
        /// <param name="SPOUTKEY">SPOUTKEY value used to find KERROR</param>
        /// <returns>List of related KERROR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KERROR> TryFindBySPOUTKEY(string SPOUTKEY)
        {
            IReadOnlyList<KERROR> value;
            if (Index_SPOUTKEY.Value.TryGetValue(SPOUTKEY, out value))
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
