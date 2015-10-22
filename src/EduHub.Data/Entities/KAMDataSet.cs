using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard Disciplinary Actions Data Set
    /// </summary>
    public sealed partial class KAMDataSet : SetBase<KAM>
    {
        private Lazy<Dictionary<string, KAM>> KAMKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SDPA>>> SDPA_ACTION_TAKENForeignIndex;

        internal KAMDataSet(EduHubContext Context)
            : base(Context)
        {
            KAMKEYIndex = new Lazy<Dictionary<string, KAM>>(() => this.ToDictionary(e => e.KAMKEY));

            SDPA_ACTION_TAKENForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SDPA>>>(() =>
                    Context.SDPA
                          .Where(e => e.ACTION_TAKEN != null)
                          .GroupBy(e => e.ACTION_TAKEN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SDPA>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAM"; } }

        /// <summary>
        /// Find KAM by KAMKEY key field
        /// </summary>
        /// <param name="Key">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KAMKEY value didn't match any KAM entities</exception>
        public KAM FindByKAMKEY(string Key)
        {
            KAM result;
            if (KAMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY key field
        /// </summary>
        /// <param name="Key">KAMKEY value used to find KAM</param>
        /// <param name="Value">Related KAM entity</param>
        /// <returns>True if the KAM entity is found</returns>
        public bool TryFindByKAMKEY(string Key, out KAM Value)
        {
            return KAMKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY key field
        /// </summary>
        /// <param name="Key">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity, or null if not found</returns>
        public KAM TryFindByKAMKEY(string Key)
        {
            KAM result;
            if (KAMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SDPA (Disciplinary Actions) entities by [SDPA.ACTION_TAKEN]-&gt;[KAM.KAMKEY]
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find SDPA entities</param>
        /// <returns>A list of related SDPA entities</returns>
        public IReadOnlyList<SDPA> FindSDPAByACTION_TAKEN(string KAMKEY)
        {
            IReadOnlyList<SDPA> result;
            if (SDPA_ACTION_TAKENForeignIndex.Value.TryGetValue(KAMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SDPA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SDPA entities by [SDPA.ACTION_TAKEN]-&gt;[KAM.KAMKEY]
        /// </summary>
        /// <param name="KAMKEY">KAMKEY value used to find SDPA entities</param>
        /// <param name="Value">A list of related SDPA entities</param>
        /// <returns>True if any SDPA entities are found</returns>
        public bool TryFindSDPAByACTION_TAKEN(string KAMKEY, out IReadOnlyList<SDPA> Value)
        {
            return SDPA_ACTION_TAKENForeignIndex.Value.TryGetValue(KAMKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAM" /> fields for each CSV column header</returns>
        protected override Action<KAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAMKEY":
                        mapper[i] = (e, v) => e.KAMKEY = v;
                        break;
                    case "BRIEF":
                        mapper[i] = (e, v) => e.BRIEF = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
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
    }
}
