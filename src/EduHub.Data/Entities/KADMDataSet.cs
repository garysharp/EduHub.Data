using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Depreciation Methods Data Set
    /// </summary>
    public sealed partial class KADMDataSet : SetBase<KADM>
    {
        private Lazy<Dictionary<string, KADM>> KADMKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_DEPN_AMETHODForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_DEPN_TMETHODForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKCT>>> AKCT_DEPN_TMETHODForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_AMETHODForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_TMETHODForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> ARF_AMETHODForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> ARF_TMETHODForeignIndex;

        internal KADMDataSet(EduHubContext Context)
            : base(Context)
        {
            KADMKEYIndex = new Lazy<Dictionary<string, KADM>>(() => this.ToDictionary(e => e.KADMKEY));

            AKC_DEPN_AMETHODForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.DEPN_AMETHOD != null)
                          .GroupBy(e => e.DEPN_AMETHOD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_DEPN_TMETHODForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.DEPN_TMETHOD != null)
                          .GroupBy(e => e.DEPN_TMETHOD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKCT_DEPN_TMETHODForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKCT>>>(() =>
                    Context.AKCT
                          .Where(e => e.DEPN_TMETHOD != null)
                          .GroupBy(e => e.DEPN_TMETHOD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKCT>)g.ToList()
                          .AsReadOnly()));

            AR_AMETHODForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.AMETHOD != null)
                          .GroupBy(e => e.AMETHOD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

            AR_TMETHODForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.TMETHOD != null)
                          .GroupBy(e => e.TMETHOD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

            ARF_AMETHODForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() =>
                    Context.ARF
                          .Where(e => e.AMETHOD != null)
                          .GroupBy(e => e.AMETHOD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ARF>)g.ToList()
                          .AsReadOnly()));

            ARF_TMETHODForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() =>
                    Context.ARF
                          .Where(e => e.TMETHOD != null)
                          .GroupBy(e => e.TMETHOD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ARF>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KADM"; } }

        /// <summary>
        /// Find KADM by KADMKEY key field
        /// </summary>
        /// <param name="Key">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KADMKEY value didn't match any KADM entities</exception>
        public KADM FindByKADMKEY(string Key)
        {
            KADM result;
            if (KADMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY key field
        /// </summary>
        /// <param name="Key">KADMKEY value used to find KADM</param>
        /// <param name="Value">Related KADM entity</param>
        /// <returns>True if the KADM entity is found</returns>
        public bool TryFindByKADMKEY(string Key, out KADM Value)
        {
            return KADMKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KADM by KADMKEY key field
        /// </summary>
        /// <param name="Key">KADMKEY value used to find KADM</param>
        /// <returns>Related KADM entity, or null if not found</returns>
        public KADM TryFindByKADMKEY(string Key)
        {
            KADM result;
            if (KADMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.DEPN_AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByDEPN_AMETHOD(string KADMKEY)
        {
            IReadOnlyList<AKC> result;
            if (AKC_DEPN_AMETHODForeignIndex.Value.TryGetValue(KADMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.DEPN_AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByDEPN_AMETHOD(string KADMKEY, out IReadOnlyList<AKC> Value)
        {
            return AKC_DEPN_AMETHODForeignIndex.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByDEPN_TMETHOD(string KADMKEY)
        {
            IReadOnlyList<AKC> result;
            if (AKC_DEPN_TMETHODForeignIndex.Value.TryGetValue(KADMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByDEPN_TMETHOD(string KADMKEY, out IReadOnlyList<AKC> Value)
        {
            return AKC_DEPN_TMETHODForeignIndex.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Find all AKCT (Assets - Categories Tax) entities by [AKCT.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AKCT entities</param>
        /// <returns>A list of related AKCT entities</returns>
        public IReadOnlyList<AKCT> FindAKCTByDEPN_TMETHOD(string KADMKEY)
        {
            IReadOnlyList<AKCT> result;
            if (AKCT_DEPN_TMETHODForeignIndex.Value.TryGetValue(KADMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AKCT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKCT entities by [AKCT.DEPN_TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AKCT entities</param>
        /// <param name="Value">A list of related AKCT entities</param>
        /// <returns>True if any AKCT entities are found</returns>
        public bool TryFindAKCTByDEPN_TMETHOD(string KADMKEY, out IReadOnlyList<AKCT> Value)
        {
            return AKCT_DEPN_TMETHODForeignIndex.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByAMETHOD(string KADMKEY)
        {
            IReadOnlyList<AR> result;
            if (AR_AMETHODForeignIndex.Value.TryGetValue(KADMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByAMETHOD(string KADMKEY, out IReadOnlyList<AR> Value)
        {
            return AR_AMETHODForeignIndex.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByTMETHOD(string KADMKEY)
        {
            IReadOnlyList<AR> result;
            if (AR_TMETHODForeignIndex.Value.TryGetValue(KADMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByTMETHOD(string KADMKEY, out IReadOnlyList<AR> Value)
        {
            return AR_TMETHODForeignIndex.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Find all ARF (Asset Financial Transactions) entities by [ARF.AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find ARF entities</param>
        /// <returns>A list of related ARF entities</returns>
        public IReadOnlyList<ARF> FindARFByAMETHOD(string KADMKEY)
        {
            IReadOnlyList<ARF> result;
            if (ARF_AMETHODForeignIndex.Value.TryGetValue(KADMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ARF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ARF entities by [ARF.AMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find ARF entities</param>
        /// <param name="Value">A list of related ARF entities</param>
        /// <returns>True if any ARF entities are found</returns>
        public bool TryFindARFByAMETHOD(string KADMKEY, out IReadOnlyList<ARF> Value)
        {
            return ARF_AMETHODForeignIndex.Value.TryGetValue(KADMKEY, out Value);
        }

        /// <summary>
        /// Find all ARF (Asset Financial Transactions) entities by [ARF.TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find ARF entities</param>
        /// <returns>A list of related ARF entities</returns>
        public IReadOnlyList<ARF> FindARFByTMETHOD(string KADMKEY)
        {
            IReadOnlyList<ARF> result;
            if (ARF_TMETHODForeignIndex.Value.TryGetValue(KADMKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ARF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ARF entities by [ARF.TMETHOD]-&gt;[KADM.KADMKEY]
        /// </summary>
        /// <param name="KADMKEY">KADMKEY value used to find ARF entities</param>
        /// <param name="Value">A list of related ARF entities</param>
        /// <returns>True if any ARF entities are found</returns>
        public bool TryFindARFByTMETHOD(string KADMKEY, out IReadOnlyList<ARF> Value)
        {
            return ARF_TMETHODForeignIndex.Value.TryGetValue(KADMKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KADM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KADM" /> fields for each CSV column header</returns>
        protected override Action<KADM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KADM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KADMKEY":
                        mapper[i] = (e, v) => e.KADMKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "DATE_BASED":
                        mapper[i] = (e, v) => e.DATE_BASED = v;
                        break;
                    case "TAX":
                        mapper[i] = (e, v) => e.TAX = v;
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
