using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Categories Data Set
    /// </summary>
    public sealed partial class KGGDataSet : SetBase<KGG>
    {
        private Lazy<Dictionary<string, KGG>> KGGKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<OSCS>>> OSCS_ZEROMTH_CATForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<OSCS>>> OSCS_SIXMTH_CATForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_EXIT_CAT01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_EXIT_CAT02ForeignIndex;

        internal KGGDataSet(EduHubContext Context)
            : base(Context)
        {
            KGGKEYIndex = new Lazy<Dictionary<string, KGG>>(() => this.ToDictionary(e => e.KGGKEY));

            OSCS_ZEROMTH_CATForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<OSCS>>>(() =>
                    Context.OSCS
                          .Where(e => e.ZEROMTH_CAT != null)
                          .GroupBy(e => e.ZEROMTH_CAT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<OSCS>)g.ToList()
                          .AsReadOnly()));

            OSCS_SIXMTH_CATForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<OSCS>>>(() =>
                    Context.OSCS
                          .Where(e => e.SIXMTH_CAT != null)
                          .GroupBy(e => e.SIXMTH_CAT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<OSCS>)g.ToList()
                          .AsReadOnly()));

            ST_EXIT_CAT01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.EXIT_CAT01 != null)
                          .GroupBy(e => e.EXIT_CAT01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_EXIT_CAT02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.EXIT_CAT02 != null)
                          .GroupBy(e => e.EXIT_CAT02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGG"; } }

        /// <summary>
        /// Find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGGKEY value didn't match any KGG entities</exception>
        public KGG FindByKGGKEY(string Key)
        {
            KGG result;
            if (KGGKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <param name="Value">Related KGG entity</param>
        /// <returns>True if the KGG entity is found</returns>
        public bool TryFindByKGGKEY(string Key, out KGG Value)
        {
            return KGGKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity, or null if not found</returns>
        public KGG TryFindByKGGKEY(string Key)
        {
            KGG result;
            if (KGGKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all OSCS (CASES Past Students) entities by [OSCS.ZEROMTH_CAT]-&gt;[KGG.KGGKEY]
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find OSCS entities</param>
        /// <returns>A list of related OSCS entities</returns>
        public IReadOnlyList<OSCS> FindOSCSByZEROMTH_CAT(string KGGKEY)
        {
            IReadOnlyList<OSCS> result;
            if (OSCS_ZEROMTH_CATForeignIndex.Value.TryGetValue(KGGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<OSCS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all OSCS entities by [OSCS.ZEROMTH_CAT]-&gt;[KGG.KGGKEY]
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find OSCS entities</param>
        /// <param name="Value">A list of related OSCS entities</param>
        /// <returns>True if any OSCS entities are found</returns>
        public bool TryFindOSCSByZEROMTH_CAT(string KGGKEY, out IReadOnlyList<OSCS> Value)
        {
            return OSCS_ZEROMTH_CATForeignIndex.Value.TryGetValue(KGGKEY, out Value);
        }

        /// <summary>
        /// Find all OSCS (CASES Past Students) entities by [OSCS.SIXMTH_CAT]-&gt;[KGG.KGGKEY]
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find OSCS entities</param>
        /// <returns>A list of related OSCS entities</returns>
        public IReadOnlyList<OSCS> FindOSCSBySIXMTH_CAT(string KGGKEY)
        {
            IReadOnlyList<OSCS> result;
            if (OSCS_SIXMTH_CATForeignIndex.Value.TryGetValue(KGGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<OSCS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all OSCS entities by [OSCS.SIXMTH_CAT]-&gt;[KGG.KGGKEY]
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find OSCS entities</param>
        /// <param name="Value">A list of related OSCS entities</param>
        /// <returns>True if any OSCS entities are found</returns>
        public bool TryFindOSCSBySIXMTH_CAT(string KGGKEY, out IReadOnlyList<OSCS> Value)
        {
            return OSCS_SIXMTH_CATForeignIndex.Value.TryGetValue(KGGKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.EXIT_CAT01]-&gt;[KGG.KGGKEY]
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByEXIT_CAT01(string KGGKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_EXIT_CAT01ForeignIndex.Value.TryGetValue(KGGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.EXIT_CAT01]-&gt;[KGG.KGGKEY]
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByEXIT_CAT01(string KGGKEY, out IReadOnlyList<ST> Value)
        {
            return ST_EXIT_CAT01ForeignIndex.Value.TryGetValue(KGGKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.EXIT_CAT02]-&gt;[KGG.KGGKEY]
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByEXIT_CAT02(string KGGKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_EXIT_CAT02ForeignIndex.Value.TryGetValue(KGGKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.EXIT_CAT02]-&gt;[KGG.KGGKEY]
        /// </summary>
        /// <param name="KGGKEY">KGGKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByEXIT_CAT02(string KGGKEY, out IReadOnlyList<ST> Value)
        {
            return ST_EXIT_CAT02ForeignIndex.Value.TryGetValue(KGGKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGG" /> fields for each CSV column header</returns>
        protected override Action<KGG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGGKEY":
                        mapper[i] = (e, v) => e.KGGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "EDFLAG_ORDER":
                        mapper[i] = (e, v) => e.EDFLAG_ORDER = v;
                        break;
                    case "OPEN_CLOSED":
                        mapper[i] = (e, v) => e.OPEN_CLOSED = v;
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
