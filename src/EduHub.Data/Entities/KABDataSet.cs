using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers Data Set
    /// </summary>
    public sealed partial class KABDataSet : SetBase<KAB>
    {
        private Lazy<Dictionary<string, KAB>> BSBIndex;

        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> ARF_BSBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<CR>>> CR_BSBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> CRF_BSBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_BSBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DRF>>> DRF_BSBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLCF>>> GLCF_BSBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLF>>> GLF_BSBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPM>>> PEPM_BSBForeignIndex;

        internal KABDataSet(EduHubContext Context)
            : base(Context)
        {
            BSBIndex = new Lazy<Dictionary<string, KAB>>(() => this.ToDictionary(e => e.BSB));

            ARF_BSBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() =>
                    Context.ARF
                          .Where(e => e.BSB != null)
                          .GroupBy(e => e.BSB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ARF>)g.ToList()
                          .AsReadOnly()));

            CR_BSBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<CR>>>(() =>
                    Context.CR
                          .Where(e => e.BSB != null)
                          .GroupBy(e => e.BSB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<CR>)g.ToList()
                          .AsReadOnly()));

            CRF_BSBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() =>
                    Context.CRF
                          .Where(e => e.BSB != null)
                          .GroupBy(e => e.BSB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<CRF>)g.ToList()
                          .AsReadOnly()));

            DFF_BSBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.BSB != null)
                          .GroupBy(e => e.BSB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            DRF_BSBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DRF>>>(() =>
                    Context.DRF
                          .Where(e => e.BSB != null)
                          .GroupBy(e => e.BSB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DRF>)g.ToList()
                          .AsReadOnly()));

            GLCF_BSBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLCF>>>(() =>
                    Context.GLCF
                          .Where(e => e.BSB != null)
                          .GroupBy(e => e.BSB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLCF>)g.ToList()
                          .AsReadOnly()));

            GLF_BSBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLF>>>(() =>
                    Context.GLF
                          .Where(e => e.BSB != null)
                          .GroupBy(e => e.BSB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLF>)g.ToList()
                          .AsReadOnly()));

            PEPM_BSBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPM>>>(() =>
                    Context.PEPM
                          .Where(e => e.BSB != null)
                          .GroupBy(e => e.BSB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPM>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAB"; } }

        /// <summary>
        /// Find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <returns>Related KAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">BSB value didn't match any KAB entities</exception>
        public KAB FindByBSB(string Key)
        {
            KAB result;
            if (BSBIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <param name="Value">Related KAB entity</param>
        /// <returns>True if the KAB entity is found</returns>
        public bool TryFindByBSB(string Key, out KAB Value)
        {
            return BSBIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <returns>Related KAB entity, or null if not found</returns>
        public KAB TryFindByBSB(string Key)
        {
            KAB result;
            if (BSBIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all ARF (Asset Financial Transactions) entities by [ARF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find ARF entities</param>
        /// <returns>A list of related ARF entities</returns>
        public IReadOnlyList<ARF> FindARFByBSB(string BSB)
        {
            IReadOnlyList<ARF> result;
            if (ARF_BSBForeignIndex.Value.TryGetValue(BSB, out result))
            {
                return result;
            }
            else
            {
                return new List<ARF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ARF entities by [ARF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find ARF entities</param>
        /// <param name="Value">A list of related ARF entities</param>
        /// <returns>True if any ARF entities are found</returns>
        public bool TryFindARFByBSB(string BSB, out IReadOnlyList<ARF> Value)
        {
            return ARF_BSBForeignIndex.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Find all CR (Accounts Payable) entities by [CR.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find CR entities</param>
        /// <returns>A list of related CR entities</returns>
        public IReadOnlyList<CR> FindCRByBSB(string BSB)
        {
            IReadOnlyList<CR> result;
            if (CR_BSBForeignIndex.Value.TryGetValue(BSB, out result))
            {
                return result;
            }
            else
            {
                return new List<CR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all CR entities by [CR.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find CR entities</param>
        /// <param name="Value">A list of related CR entities</param>
        /// <returns>True if any CR entities are found</returns>
        public bool TryFindCRByBSB(string BSB, out IReadOnlyList<CR> Value)
        {
            return CR_BSBForeignIndex.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Find all CRF (Creditor Financial Transaction) entities by [CRF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find CRF entities</param>
        /// <returns>A list of related CRF entities</returns>
        public IReadOnlyList<CRF> FindCRFByBSB(string BSB)
        {
            IReadOnlyList<CRF> result;
            if (CRF_BSBForeignIndex.Value.TryGetValue(BSB, out result))
            {
                return result;
            }
            else
            {
                return new List<CRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all CRF entities by [CRF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find CRF entities</param>
        /// <param name="Value">A list of related CRF entities</param>
        /// <returns>True if any CRF entities are found</returns>
        public bool TryFindCRFByBSB(string BSB, out IReadOnlyList<CRF> Value)
        {
            return CRF_BSBForeignIndex.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFByBSB(string BSB)
        {
            IReadOnlyList<DFF> result;
            if (DFF_BSBForeignIndex.Value.TryGetValue(BSB, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFByBSB(string BSB, out IReadOnlyList<DFF> Value)
        {
            return DFF_BSBForeignIndex.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Find all DRF (DR Transactions) entities by [DRF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find DRF entities</param>
        /// <returns>A list of related DRF entities</returns>
        public IReadOnlyList<DRF> FindDRFByBSB(string BSB)
        {
            IReadOnlyList<DRF> result;
            if (DRF_BSBForeignIndex.Value.TryGetValue(BSB, out result))
            {
                return result;
            }
            else
            {
                return new List<DRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DRF entities by [DRF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find DRF entities</param>
        /// <param name="Value">A list of related DRF entities</param>
        /// <returns>True if any DRF entities are found</returns>
        public bool TryFindDRFByBSB(string BSB, out IReadOnlyList<DRF> Value)
        {
            return DRF_BSBForeignIndex.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Find all GLCF (GL Combined Financial Trans) entities by [GLCF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find GLCF entities</param>
        /// <returns>A list of related GLCF entities</returns>
        public IReadOnlyList<GLCF> FindGLCFByBSB(string BSB)
        {
            IReadOnlyList<GLCF> result;
            if (GLCF_BSBForeignIndex.Value.TryGetValue(BSB, out result))
            {
                return result;
            }
            else
            {
                return new List<GLCF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLCF entities by [GLCF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find GLCF entities</param>
        /// <param name="Value">A list of related GLCF entities</param>
        /// <returns>True if any GLCF entities are found</returns>
        public bool TryFindGLCFByBSB(string BSB, out IReadOnlyList<GLCF> Value)
        {
            return GLCF_BSBForeignIndex.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Find all GLF (General Ledger Transactions) entities by [GLF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find GLF entities</param>
        /// <returns>A list of related GLF entities</returns>
        public IReadOnlyList<GLF> FindGLFByBSB(string BSB)
        {
            IReadOnlyList<GLF> result;
            if (GLF_BSBForeignIndex.Value.TryGetValue(BSB, out result))
            {
                return result;
            }
            else
            {
                return new List<GLF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLF entities by [GLF.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find GLF entities</param>
        /// <param name="Value">A list of related GLF entities</param>
        /// <returns>True if any GLF entities are found</returns>
        public bool TryFindGLFByBSB(string BSB, out IReadOnlyList<GLF> Value)
        {
            return GLF_BSBForeignIndex.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Find all PEPM (Pay Methods) entities by [PEPM.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM entities</param>
        /// <returns>A list of related PEPM entities</returns>
        public IReadOnlyList<PEPM> FindPEPMByBSB(string BSB)
        {
            IReadOnlyList<PEPM> result;
            if (PEPM_BSBForeignIndex.Value.TryGetValue(BSB, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPM entities by [PEPM.BSB]-&gt;[KAB.BSB]
        /// </summary>
        /// <param name="BSB">BSB value used to find PEPM entities</param>
        /// <param name="Value">A list of related PEPM entities</param>
        /// <returns>True if any PEPM entities are found</returns>
        public bool TryFindPEPMByBSB(string BSB, out IReadOnlyList<PEPM> Value)
        {
            return PEPM_BSBForeignIndex.Value.TryGetValue(BSB, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAB" /> fields for each CSV column header</returns>
        protected override Action<KAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
