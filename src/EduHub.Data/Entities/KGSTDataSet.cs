using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GST Percentages Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGSTDataSet : SetBase<KGST>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGST"; } }

        internal KGSTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLGST_CODE = new Lazy<NullDictionary<string, IReadOnlyList<KGST>>>(() => this.ToGroupedNullDictionary(i => i.GLGST_CODE));
            Index_KGSTKEY = new Lazy<Dictionary<string, KGST>>(() => this.ToDictionary(i => i.KGSTKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGST" /> fields for each CSV column header</returns>
        protected override Action<KGST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGSTKEY":
                        mapper[i] = (e, v) => e.KGSTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SALE_PURCH":
                        mapper[i] = (e, v) => e.SALE_PURCH = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_BOX":
                        mapper[i] = (e, v) => e.GST_BOX = v;
                        break;
                    case "GLGST_CODE":
                        mapper[i] = (e, v) => e.GLGST_CODE = v;
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "PRIOR_PERIOD_GST":
                        mapper[i] = (e, v) => e.PRIOR_PERIOD_GST = v;
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
        /// Merges <see cref="KGST" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGST" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGST" /> items to added or update the base <see cref="KGST" /> items</param>
        /// <returns>A merged list of <see cref="KGST" /> items</returns>
        protected override List<KGST> ApplyDeltaItems(List<KGST> Items, List<KGST> DeltaItems)
        {
            Dictionary<string, int> Index_KGSTKEY = Items.ToIndexDictionary(i => i.KGSTKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGST deltaItem in DeltaItems)
            {
                int index;

                if (Index_KGSTKEY.TryGetValue(deltaItem.KGSTKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KGSTKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<KGST>>> Index_GLGST_CODE;
        private Lazy<Dictionary<string, KGST>> Index_KGSTKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <returns>List of related KGST entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGST> FindByGLGST_CODE(string GLGST_CODE)
        {
            return Index_GLGST_CODE.Value[GLGST_CODE];
        }

        /// <summary>
        /// Attempt to find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <param name="Value">List of related KGST entities</param>
        /// <returns>True if the list of related KGST entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLGST_CODE(string GLGST_CODE, out IReadOnlyList<KGST> Value)
        {
            return Index_GLGST_CODE.Value.TryGetValue(GLGST_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KGST by GLGST_CODE field
        /// </summary>
        /// <param name="GLGST_CODE">GLGST_CODE value used to find KGST</param>
        /// <returns>List of related KGST entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGST> TryFindByGLGST_CODE(string GLGST_CODE)
        {
            IReadOnlyList<KGST> value;
            if (Index_GLGST_CODE.Value.TryGetValue(GLGST_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGST FindByKGSTKEY(string KGSTKEY)
        {
            return Index_KGSTKEY.Value[KGSTKEY];
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <param name="Value">Related KGST entity</param>
        /// <returns>True if the related KGST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGSTKEY(string KGSTKEY, out KGST Value)
        {
            return Index_KGSTKEY.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY field
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGST TryFindByKGSTKEY(string KGSTKEY)
        {
            KGST value;
            if (Index_KGSTKEY.Value.TryGetValue(KGSTKEY, out value))
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
