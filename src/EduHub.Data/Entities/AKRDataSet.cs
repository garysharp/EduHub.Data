using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Release Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKRDataSet : SetBase<AKR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKR"; } }

        internal AKRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_AKRKEY = new Lazy<Dictionary<string, AKR>>(() => this.ToDictionary(i => i.AKRKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKR" /> fields for each CSV column header</returns>
        protected override Action<AKR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKRKEY":
                        mapper[i] = (e, v) => e.AKRKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
        /// Merges <see cref="AKR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="AKR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="AKR" /> items to added or update the base <see cref="AKR" /> items</param>
        /// <returns>A merged list of <see cref="AKR" /> items</returns>
        protected override List<AKR> ApplyDeltaItems(List<AKR> Items, List<AKR> DeltaItems)
        {
            Dictionary<string, int> Index_AKRKEY = Items.ToIndexDictionary(i => i.AKRKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (AKR deltaItem in DeltaItems)
            {
                int index;

                if (Index_AKRKEY.TryGetValue(deltaItem.AKRKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.AKRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, AKR>> Index_AKRKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKR FindByAKRKEY(string AKRKEY)
        {
            return Index_AKRKEY.Value[AKRKEY];
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <param name="Value">Related AKR entity</param>
        /// <returns>True if the related AKR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAKRKEY(string AKRKEY, out AKR Value)
        {
            return Index_AKRKEY.Value.TryGetValue(AKRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY field
        /// </summary>
        /// <param name="AKRKEY">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKR TryFindByAKRKEY(string AKRKEY)
        {
            AKR value;
            if (Index_AKRKEY.Value.TryGetValue(AKRKEY, out value))
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
