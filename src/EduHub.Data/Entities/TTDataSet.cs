using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Grid Templates Data Set
    /// </summary>
    public sealed partial class TTDataSet : SetBase<TT>
    {
        private Lazy<Dictionary<string, TT>> TTKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_GKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT01KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT02KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT03KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT04KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT05KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT06KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT07KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT08KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT09KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT10KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT11KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT12KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TH>>> TH_TT13KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_GKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTEF>>> TTEF_GKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTEI>>> TTEI_GKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTEP>>> TTEP_GKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTES>>> TTES_GKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTEX>>> TTEX_GKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTTG>>> TTTG_GKEYForeignIndex;

        internal TTDataSet(EduHubContext Context)
            : base(Context)
        {
            TTKEYIndex = new Lazy<Dictionary<string, TT>>(() => this.ToDictionary(e => e.TTKEY));

            TCTQ_GKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.GKEY != null)
                          .GroupBy(e => e.GKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TH_TT01KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT01KEY != null)
                          .GroupBy(e => e.TT01KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT02KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT02KEY != null)
                          .GroupBy(e => e.TT02KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT03KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT03KEY != null)
                          .GroupBy(e => e.TT03KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT04KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT04KEY != null)
                          .GroupBy(e => e.TT04KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT05KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT05KEY != null)
                          .GroupBy(e => e.TT05KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT06KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT06KEY != null)
                          .GroupBy(e => e.TT06KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT07KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT07KEY != null)
                          .GroupBy(e => e.TT07KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT08KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT08KEY != null)
                          .GroupBy(e => e.TT08KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT09KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT09KEY != null)
                          .GroupBy(e => e.TT09KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT10KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT10KEY != null)
                          .GroupBy(e => e.TT10KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT11KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT11KEY != null)
                          .GroupBy(e => e.TT11KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT12KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT12KEY != null)
                          .GroupBy(e => e.TT12KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            TH_TT13KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TH>>>(() =>
                    Context.TH
                          .Where(e => e.TT13KEY != null)
                          .GroupBy(e => e.TT13KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TH>)g.ToList()
                          .AsReadOnly()));

            THTQ_GKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.GKEY != null)
                          .GroupBy(e => e.GKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

            TTEF_GKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTEF>>>(() =>
                    Context.TTEF
                          .Where(e => e.GKEY != null)
                          .GroupBy(e => e.GKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTEF>)g.ToList()
                          .AsReadOnly()));

            TTEI_GKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTEI>>>(() =>
                    Context.TTEI
                          .Where(e => e.GKEY != null)
                          .GroupBy(e => e.GKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTEI>)g.ToList()
                          .AsReadOnly()));

            TTEP_GKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTEP>>>(() =>
                    Context.TTEP
                          .Where(e => e.GKEY != null)
                          .GroupBy(e => e.GKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTEP>)g.ToList()
                          .AsReadOnly()));

            TTES_GKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTES>>>(() =>
                    Context.TTES
                          .Where(e => e.GKEY != null)
                          .GroupBy(e => e.GKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTES>)g.ToList()
                          .AsReadOnly()));

            TTEX_GKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTEX>>>(() =>
                    Context.TTEX
                          .Where(e => e.GKEY != null)
                          .GroupBy(e => e.GKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTEX>)g.ToList()
                          .AsReadOnly()));

            TTTG_GKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTTG>>>(() =>
                    Context.TTTG
                          .Where(e => e.GKEY != null)
                          .GroupBy(e => e.GKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTTG>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TT"; } }

        /// <summary>
        /// Find TT by TTKEY key field
        /// </summary>
        /// <param name="Key">TTKEY value used to find TT</param>
        /// <returns>Related TT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TTKEY value didn't match any TT entities</exception>
        public TT FindByTTKEY(string Key)
        {
            TT result;
            if (TTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TT by TTKEY key field
        /// </summary>
        /// <param name="Key">TTKEY value used to find TT</param>
        /// <param name="Value">Related TT entity</param>
        /// <returns>True if the TT entity is found</returns>
        public bool TryFindByTTKEY(string Key, out TT Value)
        {
            return TTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TT by TTKEY key field
        /// </summary>
        /// <param name="Key">TTKEY value used to find TT</param>
        /// <returns>Related TT entity, or null if not found</returns>
        public TT TryFindByTTKEY(string Key)
        {
            TT result;
            if (TTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByGKEY(string TTKEY)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_GKEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByGKEY(string TTKEY, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_GKEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT01KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT01KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT01KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT01KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT01KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT01KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT02KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT02KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT02KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT02KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT02KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT02KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT03KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT03KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT03KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT03KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT03KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT03KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT04KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT04KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT04KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT04KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT04KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT04KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT05KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT05KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT05KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT05KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT05KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT05KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT06KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT06KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT06KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT06KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT06KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT06KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT07KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT07KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT07KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT07KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT07KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT07KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT08KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT08KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT08KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT08KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT08KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT08KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT09KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT09KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT09KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT09KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT09KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT09KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT10KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT10KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT10KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT10KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT10KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT10KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT11KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT11KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT11KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT11KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT11KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT11KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT12KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT12KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT12KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT12KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT12KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT12KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TH (Timetable Quilt Headers) entities by [TH.TT13KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <returns>A list of related TH entities</returns>
        public IReadOnlyList<TH> FindTHByTT13KEY(string TTKEY)
        {
            IReadOnlyList<TH> result;
            if (TH_TT13KEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TH entities by [TH.TT13KEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TH entities</param>
        /// <param name="Value">A list of related TH entities</param>
        /// <returns>True if any TH entities are found</returns>
        public bool TryFindTHByTT13KEY(string TTKEY, out IReadOnlyList<TH> Value)
        {
            return TH_TT13KEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQByGKEY(string TTKEY)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_GKEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQByGKEY(string TTKEY, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_GKEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TTEF (Exam Staff) entities by [TTEF.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTEF entities</param>
        /// <returns>A list of related TTEF entities</returns>
        public IReadOnlyList<TTEF> FindTTEFByGKEY(string TTKEY)
        {
            IReadOnlyList<TTEF> result;
            if (TTEF_GKEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTEF entities by [TTEF.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTEF entities</param>
        /// <param name="Value">A list of related TTEF entities</param>
        /// <returns>True if any TTEF entities are found</returns>
        public bool TryFindTTEFByGKEY(string TTKEY, out IReadOnlyList<TTEF> Value)
        {
            return TTEF_GKEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TTEI (Exam Details) entities by [TTEI.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTEI entities</param>
        /// <returns>A list of related TTEI entities</returns>
        public IReadOnlyList<TTEI> FindTTEIByGKEY(string TTKEY)
        {
            IReadOnlyList<TTEI> result;
            if (TTEI_GKEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTEI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTEI entities by [TTEI.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTEI entities</param>
        /// <param name="Value">A list of related TTEI entities</param>
        /// <returns>True if any TTEI entities are found</returns>
        public bool TryFindTTEIByGKEY(string TTKEY, out IReadOnlyList<TTEI> Value)
        {
            return TTEI_GKEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TTEP (Exam Periods) entities by [TTEP.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTEP entities</param>
        /// <returns>A list of related TTEP entities</returns>
        public IReadOnlyList<TTEP> FindTTEPByGKEY(string TTKEY)
        {
            IReadOnlyList<TTEP> result;
            if (TTEP_GKEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTEP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTEP entities by [TTEP.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTEP entities</param>
        /// <param name="Value">A list of related TTEP entities</param>
        /// <returns>True if any TTEP entities are found</returns>
        public bool TryFindTTEPByGKEY(string TTKEY, out IReadOnlyList<TTEP> Value)
        {
            return TTEP_GKEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TTES (Exam Subjects) entities by [TTES.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTES entities</param>
        /// <returns>A list of related TTES entities</returns>
        public IReadOnlyList<TTES> FindTTESByGKEY(string TTKEY)
        {
            IReadOnlyList<TTES> result;
            if (TTES_GKEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTES>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTES entities by [TTES.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTES entities</param>
        /// <param name="Value">A list of related TTES entities</param>
        /// <returns>True if any TTES entities are found</returns>
        public bool TryFindTTESByGKEY(string TTKEY, out IReadOnlyList<TTES> Value)
        {
            return TTES_GKEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TTEX (Exam Grid) entities by [TTEX.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTEX entities</param>
        /// <returns>A list of related TTEX entities</returns>
        public IReadOnlyList<TTEX> FindTTEXByGKEY(string TTKEY)
        {
            IReadOnlyList<TTEX> result;
            if (TTEX_GKEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTEX>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTEX entities by [TTEX.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTEX entities</param>
        /// <param name="Value">A list of related TTEX entities</param>
        /// <returns>True if any TTEX entities are found</returns>
        public bool TryFindTTEXByGKEY(string TTKEY, out IReadOnlyList<TTEX> Value)
        {
            return TTEX_GKEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }

        /// <summary>
        /// Find all TTTG (Grid Subjects) entities by [TTTG.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTTG entities</param>
        /// <returns>A list of related TTTG entities</returns>
        public IReadOnlyList<TTTG> FindTTTGByGKEY(string TTKEY)
        {
            IReadOnlyList<TTTG> result;
            if (TTTG_GKEYForeignIndex.Value.TryGetValue(TTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTTG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTTG entities by [TTTG.GKEY]-&gt;[TT.TTKEY]
        /// </summary>
        /// <param name="TTKEY">TTKEY value used to find TTTG entities</param>
        /// <param name="Value">A list of related TTTG entities</param>
        /// <returns>True if any TTTG entities are found</returns>
        public bool TryFindTTTGByGKEY(string TTKEY, out IReadOnlyList<TTTG> Value)
        {
            return TTTG_GKEYForeignIndex.Value.TryGetValue(TTKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TT" /> fields for each CSV column header</returns>
        protected override Action<TT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TTKEY":
                        mapper[i] = (e, v) => e.TTKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SELECTABLE":
                        mapper[i] = (e, v) => e.SELECTABLE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TAG01":
                        mapper[i] = (e, v) => e.TAG01 = v;
                        break;
                    case "TAG02":
                        mapper[i] = (e, v) => e.TAG02 = v;
                        break;
                    case "TAG03":
                        mapper[i] = (e, v) => e.TAG03 = v;
                        break;
                    case "TAG04":
                        mapper[i] = (e, v) => e.TAG04 = v;
                        break;
                    case "TAG05":
                        mapper[i] = (e, v) => e.TAG05 = v;
                        break;
                    case "TAG06":
                        mapper[i] = (e, v) => e.TAG06 = v;
                        break;
                    case "TAG07":
                        mapper[i] = (e, v) => e.TAG07 = v;
                        break;
                    case "TAG08":
                        mapper[i] = (e, v) => e.TAG08 = v;
                        break;
                    case "TAG09":
                        mapper[i] = (e, v) => e.TAG09 = v;
                        break;
                    case "TRPERIOD":
                        mapper[i] = (e, v) => e.TRPERIOD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TTPERIOD":
                        mapper[i] = (e, v) => e.TTPERIOD = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR01":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR01 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR02":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR02 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR03":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR03 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR04":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR04 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR05":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR05 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR06":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR06 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR07":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR07 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR08":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR08 = v;
                        break;
                    case "SUBJECT_ACADEMIC_YEAR09":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR09 = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RESERVE":
                        mapper[i] = (e, v) => e.RESERVE = v;
                        break;
                    case "COSET":
                        mapper[i] = (e, v) => e.COSET = v;
                        break;
                    case "MAXROW":
                        mapper[i] = (e, v) => e.MAXROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXCOL":
                        mapper[i] = (e, v) => e.MAXCOL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RELAX":
                        mapper[i] = (e, v) => e.RELAX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXDROP":
                        mapper[i] = (e, v) => e.MAXDROP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXSTORE":
                        mapper[i] = (e, v) => e.MAXSTORE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "UTEACH":
                        mapper[i] = (e, v) => e.UTEACH = v;
                        break;
                    case "UROOM":
                        mapper[i] = (e, v) => e.UROOM = v;
                        break;
                    case "URESOURCES":
                        mapper[i] = (e, v) => e.URESOURCES = v;
                        break;
                    case "UFIXED":
                        mapper[i] = (e, v) => e.UFIXED = v;
                        break;
                    case "ULINKS":
                        mapper[i] = (e, v) => e.ULINKS = v;
                        break;
                    case "UTIED":
                        mapper[i] = (e, v) => e.UTIED = v;
                        break;
                    case "URANGE":
                        mapper[i] = (e, v) => e.URANGE = v;
                        break;
                    case "STRATEGY":
                        mapper[i] = (e, v) => e.STRATEGY = v;
                        break;
                    case "GRIDSORT":
                        mapper[i] = (e, v) => e.GRIDSORT = v;
                        break;
                    case "SHARE":
                        mapper[i] = (e, v) => e.SHARE = v;
                        break;
                    case "SHUFFLE":
                        mapper[i] = (e, v) => e.SHUFFLE = v;
                        break;
                    case "UUNITS":
                        mapper[i] = (e, v) => e.UUNITS = v;
                        break;
                    case "GSOLS":
                        mapper[i] = (e, v) => e.GSOLS = null; // eduHub is not encoding byte arrays
                        break;
                    case "HOMEGRID":
                        mapper[i] = (e, v) => e.HOMEGRID = v;
                        break;
                    case "TEACHER_CLASH_FACTOR":
                        mapper[i] = (e, v) => e.TEACHER_CLASH_FACTOR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROOM_CLASH_FACTOR":
                        mapper[i] = (e, v) => e.ROOM_CLASH_FACTOR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "RESOURCE_CLASH_FACTOR":
                        mapper[i] = (e, v) => e.RESOURCE_CLASH_FACTOR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STUDENT_DROP_FACTOR":
                        mapper[i] = (e, v) => e.STUDENT_DROP_FACTOR = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAX_CLASS_SIZE":
                        mapper[i] = (e, v) => e.MAX_CLASS_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXTCLASH":
                        mapper[i] = (e, v) => e.MAXTCLASH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXRCLASH":
                        mapper[i] = (e, v) => e.MAXRCLASH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXXCLASH":
                        mapper[i] = (e, v) => e.MAXXCLASH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAXBALANCE":
                        mapper[i] = (e, v) => e.MAXBALANCE = v == null ? (short?)null : short.Parse(v);
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
