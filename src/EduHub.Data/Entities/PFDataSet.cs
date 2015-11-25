using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Superannuation Funds Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PFDataSet : SetBase<PF>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PF"; } }

        internal PFDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PF>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_PFKEY = new Lazy<Dictionary<string, PF>>(() => this.ToDictionary(i => i.PFKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PF" /> fields for each CSV column header</returns>
        protected override Action<PF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PFKEY":
                        mapper[i] = (e, v) => e.PFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "CREATE_EXPORT_FILE":
                        mapper[i] = (e, v) => e.CREATE_EXPORT_FILE = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "USI":
                        mapper[i] = (e, v) => e.USI = v;
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
        /// Merges <see cref="PF" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PF" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PF" /> items to added or update the base <see cref="PF" /> items</param>
        /// <returns>A merged list of <see cref="PF" /> items</returns>
        protected override List<PF> ApplyDeltaItems(List<PF> Items, List<PF> DeltaItems)
        {
            Dictionary<string, int> Index_PFKEY = Items.ToIndexDictionary(i => i.PFKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PF deltaItem in DeltaItems)
            {
                int index;

                if (Index_PFKEY.TryGetValue(deltaItem.PFKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PFKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PF>>> Index_GLCODE;
        private Lazy<Dictionary<string, PF>> Index_PFKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <returns>List of related PF entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PF> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <param name="Value">List of related PF entities</param>
        /// <returns>True if the list of related PF entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PF> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PF by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PF</param>
        /// <returns>List of related PF entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PF> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PF> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <returns>Related PF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PF FindByPFKEY(string PFKEY)
        {
            return Index_PFKEY.Value[PFKEY];
        }

        /// <summary>
        /// Attempt to find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <param name="Value">Related PF entity</param>
        /// <returns>True if the related PF entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPFKEY(string PFKEY, out PF Value)
        {
            return Index_PFKEY.Value.TryGetValue(PFKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PF by PFKEY field
        /// </summary>
        /// <param name="PFKEY">PFKEY value used to find PF</param>
        /// <returns>Related PF entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PF TryFindByPFKEY(string PFKEY)
        {
            PF value;
            if (Index_PFKEY.Value.TryGetValue(PFKEY, out value))
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
