using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations Data Set
    /// </summary>
    public sealed partial class KGDDataSet : SetBase<KGD>
    {
        private Lazy<Dictionary<string, KGD>> KGDKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<OSCS>>> OSCS_ZEROMTH_CAT_DESTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<OSCS>>> OSCS_SIXMTH_CAT_DESTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_EXIT_DEST01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_EXIT_DEST02ForeignIndex;

        internal KGDDataSet(EduHubContext Context)
            : base(Context)
        {
            KGDKEYIndex = new Lazy<Dictionary<string, KGD>>(() => this.ToDictionary(e => e.KGDKEY));

            OSCS_ZEROMTH_CAT_DESTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<OSCS>>>(() =>
                    Context.OSCS
                          .Where(e => e.ZEROMTH_CAT_DEST != null)
                          .GroupBy(e => e.ZEROMTH_CAT_DEST)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<OSCS>)g.ToList()
                          .AsReadOnly()));

            OSCS_SIXMTH_CAT_DESTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<OSCS>>>(() =>
                    Context.OSCS
                          .Where(e => e.SIXMTH_CAT_DEST != null)
                          .GroupBy(e => e.SIXMTH_CAT_DEST)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<OSCS>)g.ToList()
                          .AsReadOnly()));

            ST_EXIT_DEST01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.EXIT_DEST01 != null)
                          .GroupBy(e => e.EXIT_DEST01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_EXIT_DEST02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.EXIT_DEST02 != null)
                          .GroupBy(e => e.EXIT_DEST02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGD"; } }

        /// <summary>
        /// Find KGD by KGDKEY key field
        /// </summary>
        /// <param name="Key">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGDKEY value didn't match any KGD entities</exception>
        public KGD FindByKGDKEY(string Key)
        {
            KGD result;
            if (KGDKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY key field
        /// </summary>
        /// <param name="Key">KGDKEY value used to find KGD</param>
        /// <param name="Value">Related KGD entity</param>
        /// <returns>True if the KGD entity is found</returns>
        public bool TryFindByKGDKEY(string Key, out KGD Value)
        {
            return KGDKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY key field
        /// </summary>
        /// <param name="Key">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity, or null if not found</returns>
        public KGD TryFindByKGDKEY(string Key)
        {
            KGD result;
            if (KGDKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all OSCS (CASES Past Students) entities by [OSCS.ZEROMTH_CAT_DEST]-&gt;[KGD.KGDKEY]
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find OSCS entities</param>
        /// <returns>A list of related OSCS entities</returns>
        public IReadOnlyList<OSCS> FindOSCSByZEROMTH_CAT_DEST(string KGDKEY)
        {
            IReadOnlyList<OSCS> result;
            if (OSCS_ZEROMTH_CAT_DESTForeignIndex.Value.TryGetValue(KGDKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<OSCS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all OSCS entities by [OSCS.ZEROMTH_CAT_DEST]-&gt;[KGD.KGDKEY]
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find OSCS entities</param>
        /// <param name="Value">A list of related OSCS entities</param>
        /// <returns>True if any OSCS entities are found</returns>
        public bool TryFindOSCSByZEROMTH_CAT_DEST(string KGDKEY, out IReadOnlyList<OSCS> Value)
        {
            return OSCS_ZEROMTH_CAT_DESTForeignIndex.Value.TryGetValue(KGDKEY, out Value);
        }

        /// <summary>
        /// Find all OSCS (CASES Past Students) entities by [OSCS.SIXMTH_CAT_DEST]-&gt;[KGD.KGDKEY]
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find OSCS entities</param>
        /// <returns>A list of related OSCS entities</returns>
        public IReadOnlyList<OSCS> FindOSCSBySIXMTH_CAT_DEST(string KGDKEY)
        {
            IReadOnlyList<OSCS> result;
            if (OSCS_SIXMTH_CAT_DESTForeignIndex.Value.TryGetValue(KGDKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<OSCS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all OSCS entities by [OSCS.SIXMTH_CAT_DEST]-&gt;[KGD.KGDKEY]
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find OSCS entities</param>
        /// <param name="Value">A list of related OSCS entities</param>
        /// <returns>True if any OSCS entities are found</returns>
        public bool TryFindOSCSBySIXMTH_CAT_DEST(string KGDKEY, out IReadOnlyList<OSCS> Value)
        {
            return OSCS_SIXMTH_CAT_DESTForeignIndex.Value.TryGetValue(KGDKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.EXIT_DEST01]-&gt;[KGD.KGDKEY]
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByEXIT_DEST01(string KGDKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_EXIT_DEST01ForeignIndex.Value.TryGetValue(KGDKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.EXIT_DEST01]-&gt;[KGD.KGDKEY]
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByEXIT_DEST01(string KGDKEY, out IReadOnlyList<ST> Value)
        {
            return ST_EXIT_DEST01ForeignIndex.Value.TryGetValue(KGDKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.EXIT_DEST02]-&gt;[KGD.KGDKEY]
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByEXIT_DEST02(string KGDKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_EXIT_DEST02ForeignIndex.Value.TryGetValue(KGDKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.EXIT_DEST02]-&gt;[KGD.KGDKEY]
        /// </summary>
        /// <param name="KGDKEY">KGDKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByEXIT_DEST02(string KGDKEY, out IReadOnlyList<ST> Value)
        {
            return ST_EXIT_DEST02ForeignIndex.Value.TryGetValue(KGDKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGD" /> fields for each CSV column header</returns>
        protected override Action<KGD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGDKEY":
                        mapper[i] = (e, v) => e.KGDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
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
