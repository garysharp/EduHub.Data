using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Initiatives Data Set
    /// </summary>
    public sealed partial class KGLINITDataSet : SetBase<KGLINIT>
    {
        private Lazy<Dictionary<string, KGLINIT>> INITIATIVEIndex;

        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> ARF_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> CRF_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DRF>>> DRF_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLBUDG>>> GLBUDG_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLCF>>> GLCF_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLCFPREV>>> GLCFPREV_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLF>>> GLF_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>> GLFPREV_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PC>>> PC_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PD>>> PD_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEF>>> PEF_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEFH>>> PEFH_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPS>>> PEPS_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPU>>> PEPU_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPUH>>> PEPUH_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PI>>> PI_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PN>>> PN_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SA>>> SA_INITIATIVEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SDFC>>> SDFC_INITIATIVEForeignIndex;

        internal KGLINITDataSet(EduHubContext Context)
            : base(Context)
        {
            INITIATIVEIndex = new Lazy<Dictionary<string, KGLINIT>>(() => this.ToDictionary(e => e.INITIATIVE));

            ARF_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() =>
                    Context.ARF
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ARF>)g.ToList()
                          .AsReadOnly()));

            CRF_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() =>
                    Context.CRF
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<CRF>)g.ToList()
                          .AsReadOnly()));

            DFF_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            DRF_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DRF>>>(() =>
                    Context.DRF
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DRF>)g.ToList()
                          .AsReadOnly()));

            GLBUDG_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLBUDG>>>(() =>
                    Context.GLBUDG
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLBUDG>)g.ToList()
                          .AsReadOnly()));

            GLCF_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLCF>>>(() =>
                    Context.GLCF
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLCF>)g.ToList()
                          .AsReadOnly()));

            GLCFPREV_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLCFPREV>>>(() =>
                    Context.GLCFPREV
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLCFPREV>)g.ToList()
                          .AsReadOnly()));

            GLF_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLF>>>(() =>
                    Context.GLF
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLF>)g.ToList()
                          .AsReadOnly()));

            GLFPREV_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>>(() =>
                    Context.GLFPREV
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLFPREV>)g.ToList()
                          .AsReadOnly()));

            PC_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PC>>>(() =>
                    Context.PC
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PC>)g.ToList()
                          .AsReadOnly()));

            PD_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PD>>>(() =>
                    Context.PD
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PD>)g.ToList()
                          .AsReadOnly()));

            PEF_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEF>>>(() =>
                    Context.PEF
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEF>)g.ToList()
                          .AsReadOnly()));

            PEFH_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEFH>>>(() =>
                    Context.PEFH
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEFH>)g.ToList()
                          .AsReadOnly()));

            PEPS_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPS>>>(() =>
                    Context.PEPS
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPS>)g.ToList()
                          .AsReadOnly()));

            PEPU_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPU>>>(() =>
                    Context.PEPU
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPU>)g.ToList()
                          .AsReadOnly()));

            PEPUH_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPUH>>>(() =>
                    Context.PEPUH
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPUH>)g.ToList()
                          .AsReadOnly()));

            PI_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PI>>>(() =>
                    Context.PI
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PI>)g.ToList()
                          .AsReadOnly()));

            PN_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PN>>>(() =>
                    Context.PN
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PN>)g.ToList()
                          .AsReadOnly()));

            SA_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SA>>>(() =>
                    Context.SA
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SA>)g.ToList()
                          .AsReadOnly()));

            SDFC_INITIATIVEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SDFC>>>(() =>
                    Context.SDFC
                          .Where(e => e.INITIATIVE != null)
                          .GroupBy(e => e.INITIATIVE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SDFC>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLINIT"; } }

        /// <summary>
        /// Find KGLINIT by INITIATIVE key field
        /// </summary>
        /// <param name="Key">INITIATIVE value used to find KGLINIT</param>
        /// <returns>Related KGLINIT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">INITIATIVE value didn't match any KGLINIT entities</exception>
        public KGLINIT FindByINITIATIVE(string Key)
        {
            KGLINIT result;
            if (INITIATIVEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGLINIT by INITIATIVE key field
        /// </summary>
        /// <param name="Key">INITIATIVE value used to find KGLINIT</param>
        /// <param name="Value">Related KGLINIT entity</param>
        /// <returns>True if the KGLINIT entity is found</returns>
        public bool TryFindByINITIATIVE(string Key, out KGLINIT Value)
        {
            return INITIATIVEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGLINIT by INITIATIVE key field
        /// </summary>
        /// <param name="Key">INITIATIVE value used to find KGLINIT</param>
        /// <returns>Related KGLINIT entity, or null if not found</returns>
        public KGLINIT TryFindByINITIATIVE(string Key)
        {
            KGLINIT result;
            if (INITIATIVEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all ARF (Asset Financial Transactions) entities by [ARF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find ARF entities</param>
        /// <returns>A list of related ARF entities</returns>
        public IReadOnlyList<ARF> FindARFByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<ARF> result;
            if (ARF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<ARF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ARF entities by [ARF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find ARF entities</param>
        /// <param name="Value">A list of related ARF entities</param>
        /// <returns>True if any ARF entities are found</returns>
        public bool TryFindARFByINITIATIVE(string INITIATIVE, out IReadOnlyList<ARF> Value)
        {
            return ARF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all CRF (Creditor Financial Transaction) entities by [CRF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find CRF entities</param>
        /// <returns>A list of related CRF entities</returns>
        public IReadOnlyList<CRF> FindCRFByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<CRF> result;
            if (CRF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<CRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all CRF entities by [CRF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find CRF entities</param>
        /// <param name="Value">A list of related CRF entities</param>
        /// <returns>True if any CRF entities are found</returns>
        public bool TryFindCRFByINITIATIVE(string INITIATIVE, out IReadOnlyList<CRF> Value)
        {
            return CRF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<DFF> result;
            if (DFF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFByINITIATIVE(string INITIATIVE, out IReadOnlyList<DFF> Value)
        {
            return DFF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all DRF (DR Transactions) entities by [DRF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DRF entities</param>
        /// <returns>A list of related DRF entities</returns>
        public IReadOnlyList<DRF> FindDRFByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<DRF> result;
            if (DRF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<DRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DRF entities by [DRF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find DRF entities</param>
        /// <param name="Value">A list of related DRF entities</param>
        /// <returns>True if any DRF entities are found</returns>
        public bool TryFindDRFByINITIATIVE(string INITIATIVE, out IReadOnlyList<DRF> Value)
        {
            return DRF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all GLBUDG (General Ledger Budgets) entities by [GLBUDG.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLBUDG entities</param>
        /// <returns>A list of related GLBUDG entities</returns>
        public IReadOnlyList<GLBUDG> FindGLBUDGByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLBUDG> result;
            if (GLBUDG_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLBUDG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLBUDG entities by [GLBUDG.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLBUDG entities</param>
        /// <param name="Value">A list of related GLBUDG entities</param>
        /// <returns>True if any GLBUDG entities are found</returns>
        public bool TryFindGLBUDGByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLBUDG> Value)
        {
            return GLBUDG_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all GLCF (GL Combined Financial Trans) entities by [GLCF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCF entities</param>
        /// <returns>A list of related GLCF entities</returns>
        public IReadOnlyList<GLCF> FindGLCFByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLCF> result;
            if (GLCF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLCF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLCF entities by [GLCF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCF entities</param>
        /// <param name="Value">A list of related GLCF entities</param>
        /// <returns>True if any GLCF entities are found</returns>
        public bool TryFindGLCFByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLCF> Value)
        {
            return GLCF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all GLCFPREV (Last Years GL Combined Financial Trans) entities by [GLCFPREV.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCFPREV entities</param>
        /// <returns>A list of related GLCFPREV entities</returns>
        public IReadOnlyList<GLCFPREV> FindGLCFPREVByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLCFPREV> result;
            if (GLCFPREV_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLCFPREV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLCFPREV entities by [GLCFPREV.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLCFPREV entities</param>
        /// <param name="Value">A list of related GLCFPREV entities</param>
        /// <returns>True if any GLCFPREV entities are found</returns>
        public bool TryFindGLCFPREVByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLCFPREV> Value)
        {
            return GLCFPREV_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all GLF (General Ledger Transactions) entities by [GLF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLF entities</param>
        /// <returns>A list of related GLF entities</returns>
        public IReadOnlyList<GLF> FindGLFByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLF> result;
            if (GLF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLF entities by [GLF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLF entities</param>
        /// <param name="Value">A list of related GLF entities</param>
        /// <returns>True if any GLF entities are found</returns>
        public bool TryFindGLFByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLF> Value)
        {
            return GLF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all GLFPREV (Last Years GL Financial Trans) entities by [GLFPREV.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLFPREV entities</param>
        /// <returns>A list of related GLFPREV entities</returns>
        public IReadOnlyList<GLFPREV> FindGLFPREVByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<GLFPREV> result;
            if (GLFPREV_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLFPREV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLFPREV entities by [GLFPREV.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find GLFPREV entities</param>
        /// <param name="Value">A list of related GLFPREV entities</param>
        /// <returns>True if any GLFPREV entities are found</returns>
        public bool TryFindGLFPREVByINITIATIVE(string INITIATIVE, out IReadOnlyList<GLFPREV> Value)
        {
            return GLFPREV_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PC (Cost Centres) entities by [PC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC entities</param>
        /// <returns>A list of related PC entities</returns>
        public IReadOnlyList<PC> FindPCByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PC> result;
            if (PC_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PC entities by [PC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC entities</param>
        /// <param name="Value">A list of related PC entities</param>
        /// <returns>True if any PC entities are found</returns>
        public bool TryFindPCByINITIATIVE(string INITIATIVE, out IReadOnlyList<PC> Value)
        {
            return PC_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PD (Departments) entities by [PD.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD entities</param>
        /// <returns>A list of related PD entities</returns>
        public IReadOnlyList<PD> FindPDByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PD> result;
            if (PD_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PD entities by [PD.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD entities</param>
        /// <param name="Value">A list of related PD entities</param>
        /// <returns>True if any PD entities are found</returns>
        public bool TryFindPDByINITIATIVE(string INITIATIVE, out IReadOnlyList<PD> Value)
        {
            return PD_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PEF (Payroll Transactions) entities by [PEF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEF entities</param>
        /// <returns>A list of related PEF entities</returns>
        public IReadOnlyList<PEF> FindPEFByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEF> result;
            if (PEF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEF entities by [PEF.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEF entities</param>
        /// <param name="Value">A list of related PEF entities</param>
        /// <returns>True if any PEF entities are found</returns>
        public bool TryFindPEFByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEF> Value)
        {
            return PEF_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PEFH (Payroll Transaction History) entities by [PEFH.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEFH entities</param>
        /// <returns>A list of related PEFH entities</returns>
        public IReadOnlyList<PEFH> FindPEFHByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEFH> result;
            if (PEFH_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PEFH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEFH entities by [PEFH.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEFH entities</param>
        /// <param name="Value">A list of related PEFH entities</param>
        /// <returns>True if any PEFH entities are found</returns>
        public bool TryFindPEFHByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEFH> Value)
        {
            return PEFH_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PEPS (Standard and Last Pays) entities by [PEPS.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPS entities</param>
        /// <returns>A list of related PEPS entities</returns>
        public IReadOnlyList<PEPS> FindPEPSByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEPS> result;
            if (PEPS_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPS entities by [PEPS.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPS entities</param>
        /// <param name="Value">A list of related PEPS entities</param>
        /// <returns>True if any PEPS entities are found</returns>
        public bool TryFindPEPSByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEPS> Value)
        {
            return PEPS_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PEPU (Super (SGL and Employee) YTD Transactions) entities by [PEPU.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPU entities</param>
        /// <returns>A list of related PEPU entities</returns>
        public IReadOnlyList<PEPU> FindPEPUByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEPU> result;
            if (PEPU_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPU entities by [PEPU.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPU entities</param>
        /// <param name="Value">A list of related PEPU entities</param>
        /// <returns>True if any PEPU entities are found</returns>
        public bool TryFindPEPUByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEPU> Value)
        {
            return PEPU_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PEPUH (Super (SGL and Employee) History YTD Transactions) entities by [PEPUH.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPUH entities</param>
        /// <returns>A list of related PEPUH entities</returns>
        public IReadOnlyList<PEPUH> FindPEPUHByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEPUH> result;
            if (PEPUH_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPUH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPUH entities by [PEPUH.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPUH entities</param>
        /// <param name="Value">A list of related PEPUH entities</param>
        /// <returns>True if any PEPUH entities are found</returns>
        public bool TryFindPEPUHByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEPUH> Value)
        {
            return PEPUH_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PI (Pay Items) entities by [PI.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PI entities</param>
        /// <returns>A list of related PI entities</returns>
        public IReadOnlyList<PI> FindPIByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PI> result;
            if (PI_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PI entities by [PI.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PI entities</param>
        /// <param name="Value">A list of related PI entities</param>
        /// <returns>True if any PI entities are found</returns>
        public bool TryFindPIByINITIATIVE(string INITIATIVE, out IReadOnlyList<PI> Value)
        {
            return PI_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all PN (Payroll Groups) entities by [PN.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PN entities</param>
        /// <returns>A list of related PN entities</returns>
        public IReadOnlyList<PN> FindPNByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PN> result;
            if (PN_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<PN>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PN entities by [PN.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PN entities</param>
        /// <param name="Value">A list of related PN entities</param>
        /// <returns>True if any PN entities are found</returns>
        public bool TryFindPNByINITIATIVE(string INITIATIVE, out IReadOnlyList<PN> Value)
        {
            return PN_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all SA (Fees) entities by [SA.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SA entities</param>
        /// <returns>A list of related SA entities</returns>
        public IReadOnlyList<SA> FindSAByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<SA> result;
            if (SA_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<SA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SA entities by [SA.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SA entities</param>
        /// <param name="Value">A list of related SA entities</param>
        /// <returns>True if any SA entities are found</returns>
        public bool TryFindSAByINITIATIVE(string INITIATIVE, out IReadOnlyList<SA> Value)
        {
            return SA_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Find all SDFC (Sundry Debtor Fees) entities by [SDFC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SDFC entities</param>
        /// <returns>A list of related SDFC entities</returns>
        public IReadOnlyList<SDFC> FindSDFCByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<SDFC> result;
            if (SDFC_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out result))
            {
                return result;
            }
            else
            {
                return new List<SDFC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SDFC entities by [SDFC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find SDFC entities</param>
        /// <param name="Value">A list of related SDFC entities</param>
        /// <returns>True if any SDFC entities are found</returns>
        public bool TryFindSDFCByINITIATIVE(string INITIATIVE, out IReadOnlyList<SDFC> Value)
        {
            return SDFC_INITIATIVEForeignIndex.Value.TryGetValue(INITIATIVE, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLINIT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLINIT" /> fields for each CSV column header</returns>
        protected override Action<KGLINIT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLINIT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
