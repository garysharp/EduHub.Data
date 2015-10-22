using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Data Set
    /// </summary>
    public sealed partial class TCDataSet : SetBase<TC>
    {
        private Lazy<Dictionary<DateTime, TC>> TCKEYIndex;

        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTB>>> TCTB_TCTBKEYForeignIndex;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTD>>> TCTD_TCTDKEYForeignIndex;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTQ>>> TCTQ_TCTQKEYForeignIndex;
        private Lazy<Dictionary<DateTime, IReadOnlyList<TCTR>>> TCTR_TCTRKEYForeignIndex;

        internal TCDataSet(EduHubContext Context)
            : base(Context)
        {
            TCKEYIndex = new Lazy<Dictionary<DateTime, TC>>(() => this.ToDictionary(e => e.TCKEY));

            TCTB_TCTBKEYForeignIndex =
                new Lazy<Dictionary<DateTime, IReadOnlyList<TCTB>>>(() =>
                    Context.TCTB
                          .Where(e => e.TCTBKEY != null)
                          .GroupBy(e => e.TCTBKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTB>)g.ToList()
                          .AsReadOnly()));

            TCTD_TCTDKEYForeignIndex =
                new Lazy<Dictionary<DateTime, IReadOnlyList<TCTD>>>(() =>
                    Context.TCTD
                          .Where(e => e.TCTDKEY != null)
                          .GroupBy(e => e.TCTDKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTD>)g.ToList()
                          .AsReadOnly()));

            TCTQ_TCTQKEYForeignIndex =
                new Lazy<Dictionary<DateTime, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.TCTQKEY != null)
                          .GroupBy(e => e.TCTQKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TCTR_TCTRKEYForeignIndex =
                new Lazy<Dictionary<DateTime, IReadOnlyList<TCTR>>>(() =>
                    Context.TCTR
                          .Where(e => e.TCTRKEY != null)
                          .GroupBy(e => e.TCTRKEY.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTR>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TC"; } }

        /// <summary>
        /// Find TC by TCKEY key field
        /// </summary>
        /// <param name="Key">TCKEY value used to find TC</param>
        /// <returns>Related TC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TCKEY value didn't match any TC entities</exception>
        public TC FindByTCKEY(DateTime Key)
        {
            TC result;
            if (TCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TC by TCKEY key field
        /// </summary>
        /// <param name="Key">TCKEY value used to find TC</param>
        /// <param name="Value">Related TC entity</param>
        /// <returns>True if the TC entity is found</returns>
        public bool TryFindByTCKEY(DateTime Key, out TC Value)
        {
            return TCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TC by TCKEY key field
        /// </summary>
        /// <param name="Key">TCKEY value used to find TC</param>
        /// <returns>Related TC entity, or null if not found</returns>
        public TC TryFindByTCKEY(DateTime Key)
        {
            TC result;
            if (TCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all TCTB (Teacher Absences) entities by [TCTB.TCTBKEY]-&gt;[TC.TCKEY]
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TCTB entities</param>
        /// <returns>A list of related TCTB entities</returns>
        public IReadOnlyList<TCTB> FindTCTBByTCTBKEY(DateTime TCKEY)
        {
            IReadOnlyList<TCTB> result;
            if (TCTB_TCTBKEYForeignIndex.Value.TryGetValue(TCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTB entities by [TCTB.TCTBKEY]-&gt;[TC.TCKEY]
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TCTB entities</param>
        /// <param name="Value">A list of related TCTB entities</param>
        /// <returns>True if any TCTB entities are found</returns>
        public bool TryFindTCTBByTCTBKEY(DateTime TCKEY, out IReadOnlyList<TCTB> Value)
        {
            return TCTB_TCTBKEYForeignIndex.Value.TryGetValue(TCKEY, out Value);
        }

        /// <summary>
        /// Find all TCTD (Calendar Period Information) entities by [TCTD.TCTDKEY]-&gt;[TC.TCKEY]
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TCTD entities</param>
        /// <returns>A list of related TCTD entities</returns>
        public IReadOnlyList<TCTD> FindTCTDByTCTDKEY(DateTime TCKEY)
        {
            IReadOnlyList<TCTD> result;
            if (TCTD_TCTDKEYForeignIndex.Value.TryGetValue(TCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTD entities by [TCTD.TCTDKEY]-&gt;[TC.TCKEY]
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TCTD entities</param>
        /// <param name="Value">A list of related TCTD entities</param>
        /// <returns>True if any TCTD entities are found</returns>
        public bool TryFindTCTDByTCTDKEY(DateTime TCKEY, out IReadOnlyList<TCTD> Value)
        {
            return TCTD_TCTDKEYForeignIndex.Value.TryGetValue(TCKEY, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.TCTQKEY]-&gt;[TC.TCKEY]
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByTCTQKEY(DateTime TCKEY)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_TCTQKEYForeignIndex.Value.TryGetValue(TCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.TCTQKEY]-&gt;[TC.TCKEY]
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByTCTQKEY(DateTime TCKEY, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_TCTQKEYForeignIndex.Value.TryGetValue(TCKEY, out Value);
        }

        /// <summary>
        /// Find all TCTR (Teacher Replacements) entities by [TCTR.TCTRKEY]-&gt;[TC.TCKEY]
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TCTR entities</param>
        /// <returns>A list of related TCTR entities</returns>
        public IReadOnlyList<TCTR> FindTCTRByTCTRKEY(DateTime TCKEY)
        {
            IReadOnlyList<TCTR> result;
            if (TCTR_TCTRKEYForeignIndex.Value.TryGetValue(TCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTR entities by [TCTR.TCTRKEY]-&gt;[TC.TCKEY]
        /// </summary>
        /// <param name="TCKEY">TCKEY value used to find TCTR entities</param>
        /// <param name="Value">A list of related TCTR entities</param>
        /// <returns>True if any TCTR entities are found</returns>
        public bool TryFindTCTRByTCTRKEY(DateTime TCKEY, out IReadOnlyList<TCTR> Value)
        {
            return TCTR_TCTRKEYForeignIndex.Value.TryGetValue(TCKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TC" /> fields for each CSV column header</returns>
        protected override Action<TC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCKEY":
                        mapper[i] = (e, v) => e.TCKEY = DateTime.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DAY_COMMENT":
                        mapper[i] = (e, v) => e.DAY_COMMENT = v;
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
