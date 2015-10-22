using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Headers Data Set
    /// </summary>
    public sealed partial class THDataSet : SetBase<TH>
    {
        private Lazy<Dictionary<string, TH>> THKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<KCC>>> KCC_CURRENT_QUILTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_CURRENT_QUILTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCL>>> SCL_QUILTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SFAQ>>> SFAQ_QKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SMAQ>>> SMAQ_QKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTD>>> TCTD_QKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_QKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTN>>> THTN_QKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_QKEYForeignIndex;

        internal THDataSet(EduHubContext Context)
            : base(Context)
        {
            THKEYIndex = new Lazy<Dictionary<string, TH>>(() => this.ToDictionary(e => e.THKEY));

            KCC_CURRENT_QUILTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KCC>>>(() =>
                    Context.KCC
                          .Where(e => e.CURRENT_QUILT != null)
                          .GroupBy(e => e.CURRENT_QUILT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KCC>)g.ToList()
                          .AsReadOnly()));

            SCI_CURRENT_QUILTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.CURRENT_QUILT != null)
                          .GroupBy(e => e.CURRENT_QUILT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCL_QUILTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCL>>>(() =>
                    Context.SCL
                          .Where(e => e.QUILT != null)
                          .GroupBy(e => e.QUILT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCL>)g.ToList()
                          .AsReadOnly()));

            SFAQ_QKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SFAQ>>>(() =>
                    Context.SFAQ
                          .Where(e => e.QKEY != null)
                          .GroupBy(e => e.QKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SFAQ>)g.ToList()
                          .AsReadOnly()));

            SMAQ_QKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SMAQ>>>(() =>
                    Context.SMAQ
                          .Where(e => e.QKEY != null)
                          .GroupBy(e => e.QKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMAQ>)g.ToList()
                          .AsReadOnly()));

            TCTD_QKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTD>>>(() =>
                    Context.TCTD
                          .Where(e => e.QKEY != null)
                          .GroupBy(e => e.QKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTD>)g.ToList()
                          .AsReadOnly()));

            TCTQ_QKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.QKEY != null)
                          .GroupBy(e => e.QKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            THTN_QKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTN>>>(() =>
                    Context.THTN
                          .Where(e => e.QKEY != null)
                          .GroupBy(e => e.QKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTN>)g.ToList()
                          .AsReadOnly()));

            THTQ_QKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.QKEY != null)
                          .GroupBy(e => e.QKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TH"; } }

        /// <summary>
        /// Find TH by THKEY key field
        /// </summary>
        /// <param name="Key">THKEY value used to find TH</param>
        /// <returns>Related TH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">THKEY value didn't match any TH entities</exception>
        public TH FindByTHKEY(string Key)
        {
            TH result;
            if (THKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TH by THKEY key field
        /// </summary>
        /// <param name="Key">THKEY value used to find TH</param>
        /// <param name="Value">Related TH entity</param>
        /// <returns>True if the TH entity is found</returns>
        public bool TryFindByTHKEY(string Key, out TH Value)
        {
            return THKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TH by THKEY key field
        /// </summary>
        /// <param name="Key">THKEY value used to find TH</param>
        /// <returns>Related TH entity, or null if not found</returns>
        public TH TryFindByTHKEY(string Key)
        {
            TH result;
            if (THKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all KCC (Calendar Dates for Absences) entities by [KCC.CURRENT_QUILT]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find KCC entities</param>
        /// <returns>A list of related KCC entities</returns>
        public IReadOnlyList<KCC> FindKCCByCURRENT_QUILT(string THKEY)
        {
            IReadOnlyList<KCC> result;
            if (KCC_CURRENT_QUILTForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KCC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KCC entities by [KCC.CURRENT_QUILT]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find KCC entities</param>
        /// <param name="Value">A list of related KCC entities</param>
        /// <returns>True if any KCC entities are found</returns>
        public bool TryFindKCCByCURRENT_QUILT(string THKEY, out IReadOnlyList<KCC> Value)
        {
            return KCC_CURRENT_QUILTForeignIndex.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.CURRENT_QUILT]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIByCURRENT_QUILT(string THKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_CURRENT_QUILTForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.CURRENT_QUILT]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIByCURRENT_QUILT(string THKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_CURRENT_QUILTForeignIndex.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Find all SCL (Subject Classes) entities by [SCL.QUILT]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find SCL entities</param>
        /// <returns>A list of related SCL entities</returns>
        public IReadOnlyList<SCL> FindSCLByQUILT(string THKEY)
        {
            IReadOnlyList<SCL> result;
            if (SCL_QUILTForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCL entities by [SCL.QUILT]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find SCL entities</param>
        /// <param name="Value">A list of related SCL entities</param>
        /// <returns>True if any SCL entities are found</returns>
        public bool TryFindSCLByQUILT(string THKEY, out IReadOnlyList<SCL> Value)
        {
            return SCL_QUILTForeignIndex.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Find all SFAQ (Staff Availability in Quilt) entities by [SFAQ.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find SFAQ entities</param>
        /// <returns>A list of related SFAQ entities</returns>
        public IReadOnlyList<SFAQ> FindSFAQByQKEY(string THKEY)
        {
            IReadOnlyList<SFAQ> result;
            if (SFAQ_QKEYForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SFAQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SFAQ entities by [SFAQ.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find SFAQ entities</param>
        /// <param name="Value">A list of related SFAQ entities</param>
        /// <returns>True if any SFAQ entities are found</returns>
        public bool TryFindSFAQByQKEY(string THKEY, out IReadOnlyList<SFAQ> Value)
        {
            return SFAQ_QKEYForeignIndex.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Find all SMAQ (Room Availability in Quilt) entities by [SMAQ.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find SMAQ entities</param>
        /// <returns>A list of related SMAQ entities</returns>
        public IReadOnlyList<SMAQ> FindSMAQByQKEY(string THKEY)
        {
            IReadOnlyList<SMAQ> result;
            if (SMAQ_QKEYForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SMAQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMAQ entities by [SMAQ.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find SMAQ entities</param>
        /// <param name="Value">A list of related SMAQ entities</param>
        /// <returns>True if any SMAQ entities are found</returns>
        public bool TryFindSMAQByQKEY(string THKEY, out IReadOnlyList<SMAQ> Value)
        {
            return SMAQ_QKEYForeignIndex.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Find all TCTD (Calendar Period Information) entities by [TCTD.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find TCTD entities</param>
        /// <returns>A list of related TCTD entities</returns>
        public IReadOnlyList<TCTD> FindTCTDByQKEY(string THKEY)
        {
            IReadOnlyList<TCTD> result;
            if (TCTD_QKEYForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTD entities by [TCTD.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find TCTD entities</param>
        /// <param name="Value">A list of related TCTD entities</param>
        /// <returns>True if any TCTD entities are found</returns>
        public bool TryFindTCTDByQKEY(string THKEY, out IReadOnlyList<TCTD> Value)
        {
            return TCTD_QKEYForeignIndex.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByQKEY(string THKEY)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_QKEYForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByQKEY(string THKEY, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_QKEYForeignIndex.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Find all THTN (Timetable Labels) entities by [THTN.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find THTN entities</param>
        /// <returns>A list of related THTN entities</returns>
        public IReadOnlyList<THTN> FindTHTNByQKEY(string THKEY)
        {
            IReadOnlyList<THTN> result;
            if (THTN_QKEYForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<THTN>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTN entities by [THTN.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find THTN entities</param>
        /// <param name="Value">A list of related THTN entities</param>
        /// <returns>True if any THTN entities are found</returns>
        public bool TryFindTHTNByQKEY(string THKEY, out IReadOnlyList<THTN> Value)
        {
            return THTN_QKEYForeignIndex.Value.TryGetValue(THKEY, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQByQKEY(string THKEY)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_QKEYForeignIndex.Value.TryGetValue(THKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.QKEY]-&gt;[TH.THKEY]
        /// </summary>
        /// <param name="THKEY">THKEY value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQByQKEY(string THKEY, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_QKEYForeignIndex.Value.TryGetValue(THKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TH" /> fields for each CSV column header</returns>
        protected override Action<TH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "THKEY":
                        mapper[i] = (e, v) => e.THKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SELECTABLE":
                        mapper[i] = (e, v) => e.SELECTABLE = v;
                        break;
                    case "THROWS":
                        mapper[i] = (e, v) => e.THROWS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "THCOLS":
                        mapper[i] = (e, v) => e.THCOLS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TH_RLABEL01":
                        mapper[i] = (e, v) => e.TH_RLABEL01 = v;
                        break;
                    case "TH_RLABEL02":
                        mapper[i] = (e, v) => e.TH_RLABEL02 = v;
                        break;
                    case "TH_RLABEL03":
                        mapper[i] = (e, v) => e.TH_RLABEL03 = v;
                        break;
                    case "TH_RLABEL04":
                        mapper[i] = (e, v) => e.TH_RLABEL04 = v;
                        break;
                    case "TH_RLABEL05":
                        mapper[i] = (e, v) => e.TH_RLABEL05 = v;
                        break;
                    case "TH_RLABEL06":
                        mapper[i] = (e, v) => e.TH_RLABEL06 = v;
                        break;
                    case "TH_RLABEL07":
                        mapper[i] = (e, v) => e.TH_RLABEL07 = v;
                        break;
                    case "TH_RLABEL08":
                        mapper[i] = (e, v) => e.TH_RLABEL08 = v;
                        break;
                    case "TH_RLABEL09":
                        mapper[i] = (e, v) => e.TH_RLABEL09 = v;
                        break;
                    case "TH_RLABEL10":
                        mapper[i] = (e, v) => e.TH_RLABEL10 = v;
                        break;
                    case "TH_RLABEL11":
                        mapper[i] = (e, v) => e.TH_RLABEL11 = v;
                        break;
                    case "TH_RLABEL12":
                        mapper[i] = (e, v) => e.TH_RLABEL12 = v;
                        break;
                    case "TH_CLABEL01":
                        mapper[i] = (e, v) => e.TH_CLABEL01 = v;
                        break;
                    case "TH_CLABEL02":
                        mapper[i] = (e, v) => e.TH_CLABEL02 = v;
                        break;
                    case "TH_CLABEL03":
                        mapper[i] = (e, v) => e.TH_CLABEL03 = v;
                        break;
                    case "TH_CLABEL04":
                        mapper[i] = (e, v) => e.TH_CLABEL04 = v;
                        break;
                    case "TH_CLABEL05":
                        mapper[i] = (e, v) => e.TH_CLABEL05 = v;
                        break;
                    case "TH_CLABEL06":
                        mapper[i] = (e, v) => e.TH_CLABEL06 = v;
                        break;
                    case "TH_CLABEL07":
                        mapper[i] = (e, v) => e.TH_CLABEL07 = v;
                        break;
                    case "TH_CLABEL08":
                        mapper[i] = (e, v) => e.TH_CLABEL08 = v;
                        break;
                    case "TH_CLABEL09":
                        mapper[i] = (e, v) => e.TH_CLABEL09 = v;
                        break;
                    case "TH_CLABEL10":
                        mapper[i] = (e, v) => e.TH_CLABEL10 = v;
                        break;
                    case "TH_CLABEL11":
                        mapper[i] = (e, v) => e.TH_CLABEL11 = v;
                        break;
                    case "TH_CLABEL12":
                        mapper[i] = (e, v) => e.TH_CLABEL12 = v;
                        break;
                    case "TH_CLABEL13":
                        mapper[i] = (e, v) => e.TH_CLABEL13 = v;
                        break;
                    case "TH_CLABEL14":
                        mapper[i] = (e, v) => e.TH_CLABEL14 = v;
                        break;
                    case "TH_CLABEL15":
                        mapper[i] = (e, v) => e.TH_CLABEL15 = v;
                        break;
                    case "TEACHING_PERIOD01":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD02":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD03":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD04":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD05":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD06":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD07":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD08":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD09":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD10":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD11":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHING_PERIOD12":
                        mapper[i] = (e, v) => e.TEACHING_PERIOD12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TT01KEY":
                        mapper[i] = (e, v) => e.TT01KEY = v;
                        break;
                    case "TT02KEY":
                        mapper[i] = (e, v) => e.TT02KEY = v;
                        break;
                    case "TT03KEY":
                        mapper[i] = (e, v) => e.TT03KEY = v;
                        break;
                    case "TT04KEY":
                        mapper[i] = (e, v) => e.TT04KEY = v;
                        break;
                    case "TT05KEY":
                        mapper[i] = (e, v) => e.TT05KEY = v;
                        break;
                    case "TT06KEY":
                        mapper[i] = (e, v) => e.TT06KEY = v;
                        break;
                    case "TT07KEY":
                        mapper[i] = (e, v) => e.TT07KEY = v;
                        break;
                    case "TT08KEY":
                        mapper[i] = (e, v) => e.TT08KEY = v;
                        break;
                    case "TT09KEY":
                        mapper[i] = (e, v) => e.TT09KEY = v;
                        break;
                    case "TT10KEY":
                        mapper[i] = (e, v) => e.TT10KEY = v;
                        break;
                    case "TT11KEY":
                        mapper[i] = (e, v) => e.TT11KEY = v;
                        break;
                    case "TT12KEY":
                        mapper[i] = (e, v) => e.TT12KEY = v;
                        break;
                    case "TT13KEY":
                        mapper[i] = (e, v) => e.TT13KEY = v;
                        break;
                    case "THVIEW_QUILT01":
                        mapper[i] = (e, v) => e.THVIEW_QUILT01 = v;
                        break;
                    case "THVIEW_QUILT02":
                        mapper[i] = (e, v) => e.THVIEW_QUILT02 = v;
                        break;
                    case "THVIEW_QUILT03":
                        mapper[i] = (e, v) => e.THVIEW_QUILT03 = v;
                        break;
                    case "THVIEW_QUILT04":
                        mapper[i] = (e, v) => e.THVIEW_QUILT04 = v;
                        break;
                    case "THVIEW_QUILT05":
                        mapper[i] = (e, v) => e.THVIEW_QUILT05 = v;
                        break;
                    case "THVIEW_QUILT06":
                        mapper[i] = (e, v) => e.THVIEW_QUILT06 = v;
                        break;
                    case "THVIEW_QUILT07":
                        mapper[i] = (e, v) => e.THVIEW_QUILT07 = v;
                        break;
                    case "THVIEW_QUILT08":
                        mapper[i] = (e, v) => e.THVIEW_QUILT08 = v;
                        break;
                    case "THVIEW_QUILT09":
                        mapper[i] = (e, v) => e.THVIEW_QUILT09 = v;
                        break;
                    case "THVIEW_QUILT10":
                        mapper[i] = (e, v) => e.THVIEW_QUILT10 = v;
                        break;
                    case "THVIEW_QUILT11":
                        mapper[i] = (e, v) => e.THVIEW_QUILT11 = v;
                        break;
                    case "THVIEW_QUILT12":
                        mapper[i] = (e, v) => e.THVIEW_QUILT12 = v;
                        break;
                    case "THVIEW_QUILT13":
                        mapper[i] = (e, v) => e.THVIEW_QUILT13 = v;
                        break;
                    case "THVIEW_EXTRA01":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA01 = v;
                        break;
                    case "THVIEW_EXTRA02":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA02 = v;
                        break;
                    case "THVIEW_EXTRA03":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA03 = v;
                        break;
                    case "THVIEW_EXTRA04":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA04 = v;
                        break;
                    case "THVIEW_EXTRA05":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA05 = v;
                        break;
                    case "THVIEW_EXTRA06":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA06 = v;
                        break;
                    case "THVIEW_EXTRA07":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA07 = v;
                        break;
                    case "THVIEW_EXTRA08":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA08 = v;
                        break;
                    case "THVIEW_EXTRA09":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA09 = v;
                        break;
                    case "THVIEW_EXTRA10":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA10 = v;
                        break;
                    case "THVIEW_EXTRA11":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA11 = v;
                        break;
                    case "THVIEW_EXTRA12":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA12 = v;
                        break;
                    case "THVIEW_EXTRA13":
                        mapper[i] = (e, v) => e.THVIEW_EXTRA13 = v;
                        break;
                    case "THVIEW_EXAM01":
                        mapper[i] = (e, v) => e.THVIEW_EXAM01 = v;
                        break;
                    case "THVIEW_EXAM02":
                        mapper[i] = (e, v) => e.THVIEW_EXAM02 = v;
                        break;
                    case "THVIEW_EXAM03":
                        mapper[i] = (e, v) => e.THVIEW_EXAM03 = v;
                        break;
                    case "THVIEW_EXAM04":
                        mapper[i] = (e, v) => e.THVIEW_EXAM04 = v;
                        break;
                    case "THVIEW_EXAM05":
                        mapper[i] = (e, v) => e.THVIEW_EXAM05 = v;
                        break;
                    case "THVIEW_EXAM06":
                        mapper[i] = (e, v) => e.THVIEW_EXAM06 = v;
                        break;
                    case "THVIEW_EXAM07":
                        mapper[i] = (e, v) => e.THVIEW_EXAM07 = v;
                        break;
                    case "THVIEW_EXAM08":
                        mapper[i] = (e, v) => e.THVIEW_EXAM08 = v;
                        break;
                    case "THVIEW_EXAM09":
                        mapper[i] = (e, v) => e.THVIEW_EXAM09 = v;
                        break;
                    case "THVIEW_EXAM10":
                        mapper[i] = (e, v) => e.THVIEW_EXAM10 = v;
                        break;
                    case "THVIEW_EXAM11":
                        mapper[i] = (e, v) => e.THVIEW_EXAM11 = v;
                        break;
                    case "THVIEW_EXAM12":
                        mapper[i] = (e, v) => e.THVIEW_EXAM12 = v;
                        break;
                    case "THVIEW_EXAM13":
                        mapper[i] = (e, v) => e.THVIEW_EXAM13 = v;
                        break;
                    case "CALENDAR_START01":
                        mapper[i] = (e, v) => e.CALENDAR_START01 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_START02":
                        mapper[i] = (e, v) => e.CALENDAR_START02 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_START03":
                        mapper[i] = (e, v) => e.CALENDAR_START03 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_START04":
                        mapper[i] = (e, v) => e.CALENDAR_START04 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_END01":
                        mapper[i] = (e, v) => e.CALENDAR_END01 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_END02":
                        mapper[i] = (e, v) => e.CALENDAR_END02 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_END03":
                        mapper[i] = (e, v) => e.CALENDAR_END03 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_END04":
                        mapper[i] = (e, v) => e.CALENDAR_END04 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CALENDAR_COLOUR":
                        mapper[i] = (e, v) => e.CALENDAR_COLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CALENDAR_PLACE_METHOD":
                        mapper[i] = (e, v) => e.CALENDAR_PLACE_METHOD = v;
                        break;
                    case "CALENDAR_DAYS01":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS01 = v;
                        break;
                    case "CALENDAR_DAYS02":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS02 = v;
                        break;
                    case "CALENDAR_DAYS03":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS03 = v;
                        break;
                    case "CALENDAR_DAYS04":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS04 = v;
                        break;
                    case "CALENDAR_DAYS05":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS05 = v;
                        break;
                    case "CALENDAR_DAYS06":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS06 = v;
                        break;
                    case "CALENDAR_DAYS07":
                        mapper[i] = (e, v) => e.CALENDAR_DAYS07 = v;
                        break;
                    case "CALENDAR_ROW":
                        mapper[i] = (e, v) => e.CALENDAR_ROW = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CALENDAR_VIEW":
                        mapper[i] = (e, v) => e.CALENDAR_VIEW = v;
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
