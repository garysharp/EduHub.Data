using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Sub Programs Data Set
    /// </summary>
    public sealed partial class KGLSUBDataSet : SetBase<KGLSUB>
    {
        private Lazy<Dictionary<string, KGLSUB>> SUBPROGRAMIndex;

        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> ARF_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> CRF_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DRF>>> DRF_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLCF>>> GLCF_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLCFPREV>>> GLCFPREV_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLF>>> GLF_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>> GLFPREV_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PC>>> PC_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PD>>> PD_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEF>>> PEF_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEFH>>> PEFH_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPS>>> PEPS_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPU>>> PEPU_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PEPUH>>> PEPUH_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PI>>> PI_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PN>>> PN_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SA>>> SA_SUBPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SDFC>>> SDFC_SUBPROGRAMForeignIndex;

        internal KGLSUBDataSet(EduHubContext Context)
            : base(Context)
        {
            SUBPROGRAMIndex = new Lazy<Dictionary<string, KGLSUB>>(() => this.ToDictionary(e => e.SUBPROGRAM));

            ARF_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() =>
                    Context.ARF
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ARF>)g.ToList()
                          .AsReadOnly()));

            CRF_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() =>
                    Context.CRF
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<CRF>)g.ToList()
                          .AsReadOnly()));

            DFF_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            DRF_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DRF>>>(() =>
                    Context.DRF
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DRF>)g.ToList()
                          .AsReadOnly()));

            GLCF_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLCF>>>(() =>
                    Context.GLCF
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLCF>)g.ToList()
                          .AsReadOnly()));

            GLCFPREV_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLCFPREV>>>(() =>
                    Context.GLCFPREV
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLCFPREV>)g.ToList()
                          .AsReadOnly()));

            GLF_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLF>>>(() =>
                    Context.GLF
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLF>)g.ToList()
                          .AsReadOnly()));

            GLFPREV_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>>(() =>
                    Context.GLFPREV
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLFPREV>)g.ToList()
                          .AsReadOnly()));

            PC_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PC>>>(() =>
                    Context.PC
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PC>)g.ToList()
                          .AsReadOnly()));

            PD_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PD>>>(() =>
                    Context.PD
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PD>)g.ToList()
                          .AsReadOnly()));

            PEF_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEF>>>(() =>
                    Context.PEF
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEF>)g.ToList()
                          .AsReadOnly()));

            PEFH_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEFH>>>(() =>
                    Context.PEFH
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEFH>)g.ToList()
                          .AsReadOnly()));

            PEPS_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPS>>>(() =>
                    Context.PEPS
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPS>)g.ToList()
                          .AsReadOnly()));

            PEPU_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPU>>>(() =>
                    Context.PEPU
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPU>)g.ToList()
                          .AsReadOnly()));

            PEPUH_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPUH>>>(() =>
                    Context.PEPUH
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPUH>)g.ToList()
                          .AsReadOnly()));

            PI_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PI>>>(() =>
                    Context.PI
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PI>)g.ToList()
                          .AsReadOnly()));

            PN_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PN>>>(() =>
                    Context.PN
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PN>)g.ToList()
                          .AsReadOnly()));

            SA_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SA>>>(() =>
                    Context.SA
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SA>)g.ToList()
                          .AsReadOnly()));

            SDFC_SUBPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SDFC>>>(() =>
                    Context.SDFC
                          .Where(e => e.SUBPROGRAM != null)
                          .GroupBy(e => e.SUBPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SDFC>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLSUB"; } }

        /// <summary>
        /// Find KGLSUB by SUBPROGRAM key field
        /// </summary>
        /// <param name="Key">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SUBPROGRAM value didn't match any KGLSUB entities</exception>
        public KGLSUB FindBySUBPROGRAM(string Key)
        {
            KGLSUB result;
            if (SUBPROGRAMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM key field
        /// </summary>
        /// <param name="Key">SUBPROGRAM value used to find KGLSUB</param>
        /// <param name="Value">Related KGLSUB entity</param>
        /// <returns>True if the KGLSUB entity is found</returns>
        public bool TryFindBySUBPROGRAM(string Key, out KGLSUB Value)
        {
            return SUBPROGRAMIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM key field
        /// </summary>
        /// <param name="Key">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity, or null if not found</returns>
        public KGLSUB TryFindBySUBPROGRAM(string Key)
        {
            KGLSUB result;
            if (SUBPROGRAMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all ARF (Asset Financial Transactions) entities by [ARF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find ARF entities</param>
        /// <returns>A list of related ARF entities</returns>
        public IReadOnlyList<ARF> FindARFBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<ARF> result;
            if (ARF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<ARF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ARF entities by [ARF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find ARF entities</param>
        /// <param name="Value">A list of related ARF entities</param>
        /// <returns>True if any ARF entities are found</returns>
        public bool TryFindARFBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<ARF> Value)
        {
            return ARF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all CRF (Creditor Financial Transaction) entities by [CRF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find CRF entities</param>
        /// <returns>A list of related CRF entities</returns>
        public IReadOnlyList<CRF> FindCRFBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<CRF> result;
            if (CRF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<CRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all CRF entities by [CRF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find CRF entities</param>
        /// <param name="Value">A list of related CRF entities</param>
        /// <returns>True if any CRF entities are found</returns>
        public bool TryFindCRFBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<CRF> Value)
        {
            return CRF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<DFF> result;
            if (DFF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<DFF> Value)
        {
            return DFF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all DRF (DR Transactions) entities by [DRF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DRF entities</param>
        /// <returns>A list of related DRF entities</returns>
        public IReadOnlyList<DRF> FindDRFBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<DRF> result;
            if (DRF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<DRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DRF entities by [DRF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find DRF entities</param>
        /// <param name="Value">A list of related DRF entities</param>
        /// <returns>True if any DRF entities are found</returns>
        public bool TryFindDRFBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<DRF> Value)
        {
            return DRF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all GLCF (GL Combined Financial Trans) entities by [GLCF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCF entities</param>
        /// <returns>A list of related GLCF entities</returns>
        public IReadOnlyList<GLCF> FindGLCFBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<GLCF> result;
            if (GLCF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<GLCF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLCF entities by [GLCF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCF entities</param>
        /// <param name="Value">A list of related GLCF entities</param>
        /// <returns>True if any GLCF entities are found</returns>
        public bool TryFindGLCFBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<GLCF> Value)
        {
            return GLCF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all GLCFPREV (Last Years GL Combined Financial Trans) entities by [GLCFPREV.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCFPREV entities</param>
        /// <returns>A list of related GLCFPREV entities</returns>
        public IReadOnlyList<GLCFPREV> FindGLCFPREVBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<GLCFPREV> result;
            if (GLCFPREV_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<GLCFPREV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLCFPREV entities by [GLCFPREV.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLCFPREV entities</param>
        /// <param name="Value">A list of related GLCFPREV entities</param>
        /// <returns>True if any GLCFPREV entities are found</returns>
        public bool TryFindGLCFPREVBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<GLCFPREV> Value)
        {
            return GLCFPREV_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all GLF (General Ledger Transactions) entities by [GLF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLF entities</param>
        /// <returns>A list of related GLF entities</returns>
        public IReadOnlyList<GLF> FindGLFBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<GLF> result;
            if (GLF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<GLF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLF entities by [GLF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLF entities</param>
        /// <param name="Value">A list of related GLF entities</param>
        /// <returns>True if any GLF entities are found</returns>
        public bool TryFindGLFBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<GLF> Value)
        {
            return GLF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all GLFPREV (Last Years GL Financial Trans) entities by [GLFPREV.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLFPREV entities</param>
        /// <returns>A list of related GLFPREV entities</returns>
        public IReadOnlyList<GLFPREV> FindGLFPREVBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<GLFPREV> result;
            if (GLFPREV_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<GLFPREV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLFPREV entities by [GLFPREV.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find GLFPREV entities</param>
        /// <param name="Value">A list of related GLFPREV entities</param>
        /// <returns>True if any GLFPREV entities are found</returns>
        public bool TryFindGLFPREVBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<GLFPREV> Value)
        {
            return GLFPREV_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PC (Cost Centres) entities by [PC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC entities</param>
        /// <returns>A list of related PC entities</returns>
        public IReadOnlyList<PC> FindPCBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PC> result;
            if (PC_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PC entities by [PC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC entities</param>
        /// <param name="Value">A list of related PC entities</param>
        /// <returns>True if any PC entities are found</returns>
        public bool TryFindPCBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PC> Value)
        {
            return PC_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PD (Departments) entities by [PD.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD entities</param>
        /// <returns>A list of related PD entities</returns>
        public IReadOnlyList<PD> FindPDBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PD> result;
            if (PD_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PD entities by [PD.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD entities</param>
        /// <param name="Value">A list of related PD entities</param>
        /// <returns>True if any PD entities are found</returns>
        public bool TryFindPDBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PD> Value)
        {
            return PD_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PEF (Payroll Transactions) entities by [PEF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEF entities</param>
        /// <returns>A list of related PEF entities</returns>
        public IReadOnlyList<PEF> FindPEFBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEF> result;
            if (PEF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEF entities by [PEF.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEF entities</param>
        /// <param name="Value">A list of related PEF entities</param>
        /// <returns>True if any PEF entities are found</returns>
        public bool TryFindPEFBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEF> Value)
        {
            return PEF_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PEFH (Payroll Transaction History) entities by [PEFH.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEFH entities</param>
        /// <returns>A list of related PEFH entities</returns>
        public IReadOnlyList<PEFH> FindPEFHBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEFH> result;
            if (PEFH_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PEFH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEFH entities by [PEFH.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEFH entities</param>
        /// <param name="Value">A list of related PEFH entities</param>
        /// <returns>True if any PEFH entities are found</returns>
        public bool TryFindPEFHBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEFH> Value)
        {
            return PEFH_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PEPS (Standard and Last Pays) entities by [PEPS.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPS entities</param>
        /// <returns>A list of related PEPS entities</returns>
        public IReadOnlyList<PEPS> FindPEPSBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEPS> result;
            if (PEPS_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPS entities by [PEPS.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPS entities</param>
        /// <param name="Value">A list of related PEPS entities</param>
        /// <returns>True if any PEPS entities are found</returns>
        public bool TryFindPEPSBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEPS> Value)
        {
            return PEPS_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PEPU (Super (SGL and Employee) YTD Transactions) entities by [PEPU.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPU entities</param>
        /// <returns>A list of related PEPU entities</returns>
        public IReadOnlyList<PEPU> FindPEPUBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEPU> result;
            if (PEPU_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPU entities by [PEPU.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPU entities</param>
        /// <param name="Value">A list of related PEPU entities</param>
        /// <returns>True if any PEPU entities are found</returns>
        public bool TryFindPEPUBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEPU> Value)
        {
            return PEPU_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PEPUH (Super (SGL and Employee) History YTD Transactions) entities by [PEPUH.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPUH entities</param>
        /// <returns>A list of related PEPUH entities</returns>
        public IReadOnlyList<PEPUH> FindPEPUHBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEPUH> result;
            if (PEPUH_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPUH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPUH entities by [PEPUH.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPUH entities</param>
        /// <param name="Value">A list of related PEPUH entities</param>
        /// <returns>True if any PEPUH entities are found</returns>
        public bool TryFindPEPUHBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEPUH> Value)
        {
            return PEPUH_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PI (Pay Items) entities by [PI.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PI entities</param>
        /// <returns>A list of related PI entities</returns>
        public IReadOnlyList<PI> FindPIBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PI> result;
            if (PI_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PI entities by [PI.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PI entities</param>
        /// <param name="Value">A list of related PI entities</param>
        /// <returns>True if any PI entities are found</returns>
        public bool TryFindPIBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PI> Value)
        {
            return PI_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all PN (Payroll Groups) entities by [PN.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PN entities</param>
        /// <returns>A list of related PN entities</returns>
        public IReadOnlyList<PN> FindPNBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PN> result;
            if (PN_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<PN>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PN entities by [PN.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PN entities</param>
        /// <param name="Value">A list of related PN entities</param>
        /// <returns>True if any PN entities are found</returns>
        public bool TryFindPNBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PN> Value)
        {
            return PN_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all SA (Fees) entities by [SA.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SA entities</param>
        /// <returns>A list of related SA entities</returns>
        public IReadOnlyList<SA> FindSABySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<SA> result;
            if (SA_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<SA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SA entities by [SA.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SA entities</param>
        /// <param name="Value">A list of related SA entities</param>
        /// <returns>True if any SA entities are found</returns>
        public bool TryFindSABySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<SA> Value)
        {
            return SA_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Find all SDFC (Sundry Debtor Fees) entities by [SDFC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SDFC entities</param>
        /// <returns>A list of related SDFC entities</returns>
        public IReadOnlyList<SDFC> FindSDFCBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<SDFC> result;
            if (SDFC_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<SDFC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SDFC entities by [SDFC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find SDFC entities</param>
        /// <param name="Value">A list of related SDFC entities</param>
        /// <returns>True if any SDFC entities are found</returns>
        public bool TryFindSDFCBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<SDFC> Value)
        {
            return SDFC_SUBPROGRAMForeignIndex.Value.TryGetValue(SUBPROGRAM, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLSUB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLSUB" /> fields for each CSV column header</returns>
        protected override Action<KGLSUB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLSUB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "GL_PROGRAM":
                        mapper[i] = (e, v) => e.GL_PROGRAM = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "USER_DEFINABLE":
                        mapper[i] = (e, v) => e.USER_DEFINABLE = v;
                        break;
                    case "RESERVED":
                        mapper[i] = (e, v) => e.RESERVED = v;
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
