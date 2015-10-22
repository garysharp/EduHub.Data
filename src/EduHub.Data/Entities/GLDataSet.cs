using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Data Set
    /// </summary>
    public sealed partial class GLDataSet : SetBase<GL>
    {
        private Lazy<Dictionary<string, GL>> CODEIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_GLCODE_ASSForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_GLCODE_PRVForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_GLCODE_EXPForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_GL_REVALS_BSForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_GL_REVALS_PLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_GL_REVALS_ASSForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_GL_DISP_PROFForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_GL_DISP_PROCForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AKC>>> AKC_APTE_GLCODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<AR>>> AR_PTE_GLCODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLBUDG>>> GLBUDG_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLCF>>> GLCF_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLF>>> GLF_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KGST>>> KGST_GLGST_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PC>>> PC_GLCODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PD>>> PD_GLCODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PD>>> PD_GLBANKForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PD>>> PD_GLTAXForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PF>>> PF_GLCODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PI>>> PI_CLR_GLCODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PN>>> PN_GLCODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PN>>> PN_GLBANKForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<PN>>> PN_GLTAXForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SA>>> SA_GLCODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SDFC>>> SDFC_GLCODEForeignIndex;

        internal GLDataSet(EduHubContext Context)
            : base(Context)
        {
            CODEIndex = new Lazy<Dictionary<string, GL>>(() => this.ToDictionary(e => e.CODE));

            AKC_GLCODE_ASSForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.GLCODE_ASS != null)
                          .GroupBy(e => e.GLCODE_ASS)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_GLCODE_PRVForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.GLCODE_PRV != null)
                          .GroupBy(e => e.GLCODE_PRV)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_GLCODE_EXPForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.GLCODE_EXP != null)
                          .GroupBy(e => e.GLCODE_EXP)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_GL_REVALS_BSForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.GL_REVALS_BS != null)
                          .GroupBy(e => e.GL_REVALS_BS)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_GL_REVALS_PLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.GL_REVALS_PL != null)
                          .GroupBy(e => e.GL_REVALS_PL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_GL_REVALS_ASSForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.GL_REVALS_ASS != null)
                          .GroupBy(e => e.GL_REVALS_ASS)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_GL_DISP_PROFForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.GL_DISP_PROF != null)
                          .GroupBy(e => e.GL_DISP_PROF)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_GL_DISP_PROCForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.GL_DISP_PROC != null)
                          .GroupBy(e => e.GL_DISP_PROC)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AKC_APTE_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKC>>>(() =>
                    Context.AKC
                          .Where(e => e.APTE_GLCODE != null)
                          .GroupBy(e => e.APTE_GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKC>)g.ToList()
                          .AsReadOnly()));

            AR_PTE_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.PTE_GLCODE != null)
                          .GroupBy(e => e.PTE_GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

            GLBUDG_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLBUDG>>>(() =>
                    Context.GLBUDG
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLBUDG>)g.ToList()
                          .AsReadOnly()));

            GLCF_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLCF>>>(() =>
                    Context.GLCF
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLCF>)g.ToList()
                          .AsReadOnly()));

            GLF_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLF>>>(() =>
                    Context.GLF
                          .Where(e => e.CODE != null)
                          .GroupBy(e => e.CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLF>)g.ToList()
                          .AsReadOnly()));

            KGST_GLGST_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGST>>>(() =>
                    Context.KGST
                          .Where(e => e.GLGST_CODE != null)
                          .GroupBy(e => e.GLGST_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGST>)g.ToList()
                          .AsReadOnly()));

            PC_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PC>>>(() =>
                    Context.PC
                          .Where(e => e.GLCODE != null)
                          .GroupBy(e => e.GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PC>)g.ToList()
                          .AsReadOnly()));

            PD_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PD>>>(() =>
                    Context.PD
                          .Where(e => e.GLCODE != null)
                          .GroupBy(e => e.GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PD>)g.ToList()
                          .AsReadOnly()));

            PD_GLBANKForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PD>>>(() =>
                    Context.PD
                          .Where(e => e.GLBANK != null)
                          .GroupBy(e => e.GLBANK)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PD>)g.ToList()
                          .AsReadOnly()));

            PD_GLTAXForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PD>>>(() =>
                    Context.PD
                          .Where(e => e.GLTAX != null)
                          .GroupBy(e => e.GLTAX)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PD>)g.ToList()
                          .AsReadOnly()));

            PF_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PF>>>(() =>
                    Context.PF
                          .Where(e => e.GLCODE != null)
                          .GroupBy(e => e.GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PF>)g.ToList()
                          .AsReadOnly()));

            PI_CLR_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PI>>>(() =>
                    Context.PI
                          .Where(e => e.CLR_GLCODE != null)
                          .GroupBy(e => e.CLR_GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PI>)g.ToList()
                          .AsReadOnly()));

            PN_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PN>>>(() =>
                    Context.PN
                          .Where(e => e.GLCODE != null)
                          .GroupBy(e => e.GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PN>)g.ToList()
                          .AsReadOnly()));

            PN_GLBANKForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PN>>>(() =>
                    Context.PN
                          .Where(e => e.GLBANK != null)
                          .GroupBy(e => e.GLBANK)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PN>)g.ToList()
                          .AsReadOnly()));

            PN_GLTAXForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PN>>>(() =>
                    Context.PN
                          .Where(e => e.GLTAX != null)
                          .GroupBy(e => e.GLTAX)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PN>)g.ToList()
                          .AsReadOnly()));

            SA_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SA>>>(() =>
                    Context.SA
                          .Where(e => e.GLCODE != null)
                          .GroupBy(e => e.GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SA>)g.ToList()
                          .AsReadOnly()));

            SDFC_GLCODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SDFC>>>(() =>
                    Context.SDFC
                          .Where(e => e.GLCODE != null)
                          .GroupBy(e => e.GLCODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SDFC>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GL"; } }

        /// <summary>
        /// Find GL by CODE key field
        /// </summary>
        /// <param name="Key">CODE value used to find GL</param>
        /// <returns>Related GL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">CODE value didn't match any GL entities</exception>
        public GL FindByCODE(string Key)
        {
            GL result;
            if (CODEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find GL by CODE key field
        /// </summary>
        /// <param name="Key">CODE value used to find GL</param>
        /// <param name="Value">Related GL entity</param>
        /// <returns>True if the GL entity is found</returns>
        public bool TryFindByCODE(string Key, out GL Value)
        {
            return CODEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find GL by CODE key field
        /// </summary>
        /// <param name="Key">CODE value used to find GL</param>
        /// <returns>Related GL entity, or null if not found</returns>
        public GL TryFindByCODE(string Key)
        {
            GL result;
            if (CODEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.GLCODE_ASS]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByGLCODE_ASS(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_GLCODE_ASSForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.GLCODE_ASS]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByGLCODE_ASS(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_GLCODE_ASSForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.GLCODE_PRV]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByGLCODE_PRV(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_GLCODE_PRVForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.GLCODE_PRV]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByGLCODE_PRV(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_GLCODE_PRVForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.GLCODE_EXP]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByGLCODE_EXP(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_GLCODE_EXPForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.GLCODE_EXP]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByGLCODE_EXP(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_GLCODE_EXPForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.GL_REVALS_BS]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByGL_REVALS_BS(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_GL_REVALS_BSForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.GL_REVALS_BS]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByGL_REVALS_BS(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_GL_REVALS_BSForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.GL_REVALS_PL]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByGL_REVALS_PL(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_GL_REVALS_PLForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.GL_REVALS_PL]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByGL_REVALS_PL(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_GL_REVALS_PLForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.GL_REVALS_ASS]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByGL_REVALS_ASS(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_GL_REVALS_ASSForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.GL_REVALS_ASS]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByGL_REVALS_ASS(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_GL_REVALS_ASSForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.GL_DISP_PROF]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByGL_DISP_PROF(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_GL_DISP_PROFForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.GL_DISP_PROF]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByGL_DISP_PROF(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_GL_DISP_PROFForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.GL_DISP_PROC]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByGL_DISP_PROC(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_GL_DISP_PROCForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.GL_DISP_PROC]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByGL_DISP_PROC(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_GL_DISP_PROCForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AKC (Assets - Categories) entities by [AKC.APTE_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <returns>A list of related AKC entities</returns>
        public IReadOnlyList<AKC> FindAKCByAPTE_GLCODE(string CODE)
        {
            IReadOnlyList<AKC> result;
            if (AKC_APTE_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AKC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKC entities by [AKC.APTE_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AKC entities</param>
        /// <param name="Value">A list of related AKC entities</param>
        /// <returns>True if any AKC entities are found</returns>
        public bool TryFindAKCByAPTE_GLCODE(string CODE, out IReadOnlyList<AKC> Value)
        {
            return AKC_APTE_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.PTE_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByPTE_GLCODE(string CODE)
        {
            IReadOnlyList<AR> result;
            if (AR_PTE_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.PTE_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByPTE_GLCODE(string CODE, out IReadOnlyList<AR> Value)
        {
            return AR_PTE_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all GLBUDG (General Ledger Budgets) entities by [GLBUDG.CODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find GLBUDG entities</param>
        /// <returns>A list of related GLBUDG entities</returns>
        public IReadOnlyList<GLBUDG> FindGLBUDGByCODE(string CODE)
        {
            IReadOnlyList<GLBUDG> result;
            if (GLBUDG_CODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLBUDG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLBUDG entities by [GLBUDG.CODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find GLBUDG entities</param>
        /// <param name="Value">A list of related GLBUDG entities</param>
        /// <returns>True if any GLBUDG entities are found</returns>
        public bool TryFindGLBUDGByCODE(string CODE, out IReadOnlyList<GLBUDG> Value)
        {
            return GLBUDG_CODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all GLCF (GL Combined Financial Trans) entities by [GLCF.CODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find GLCF entities</param>
        /// <returns>A list of related GLCF entities</returns>
        public IReadOnlyList<GLCF> FindGLCFByCODE(string CODE)
        {
            IReadOnlyList<GLCF> result;
            if (GLCF_CODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLCF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLCF entities by [GLCF.CODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find GLCF entities</param>
        /// <param name="Value">A list of related GLCF entities</param>
        /// <returns>True if any GLCF entities are found</returns>
        public bool TryFindGLCFByCODE(string CODE, out IReadOnlyList<GLCF> Value)
        {
            return GLCF_CODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all GLF (General Ledger Transactions) entities by [GLF.CODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find GLF entities</param>
        /// <returns>A list of related GLF entities</returns>
        public IReadOnlyList<GLF> FindGLFByCODE(string CODE)
        {
            IReadOnlyList<GLF> result;
            if (GLF_CODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLF entities by [GLF.CODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find GLF entities</param>
        /// <param name="Value">A list of related GLF entities</param>
        /// <returns>True if any GLF entities are found</returns>
        public bool TryFindGLFByCODE(string CODE, out IReadOnlyList<GLF> Value)
        {
            return GLF_CODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all KGST (GST Percentages) entities by [KGST.GLGST_CODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find KGST entities</param>
        /// <returns>A list of related KGST entities</returns>
        public IReadOnlyList<KGST> FindKGSTByGLGST_CODE(string CODE)
        {
            IReadOnlyList<KGST> result;
            if (KGST_GLGST_CODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<KGST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGST entities by [KGST.GLGST_CODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find KGST entities</param>
        /// <param name="Value">A list of related KGST entities</param>
        /// <returns>True if any KGST entities are found</returns>
        public bool TryFindKGSTByGLGST_CODE(string CODE, out IReadOnlyList<KGST> Value)
        {
            return KGST_GLGST_CODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PC (Cost Centres) entities by [PC.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PC entities</param>
        /// <returns>A list of related PC entities</returns>
        public IReadOnlyList<PC> FindPCByGLCODE(string CODE)
        {
            IReadOnlyList<PC> result;
            if (PC_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PC entities by [PC.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PC entities</param>
        /// <param name="Value">A list of related PC entities</param>
        /// <returns>True if any PC entities are found</returns>
        public bool TryFindPCByGLCODE(string CODE, out IReadOnlyList<PC> Value)
        {
            return PC_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PD (Departments) entities by [PD.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PD entities</param>
        /// <returns>A list of related PD entities</returns>
        public IReadOnlyList<PD> FindPDByGLCODE(string CODE)
        {
            IReadOnlyList<PD> result;
            if (PD_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PD entities by [PD.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PD entities</param>
        /// <param name="Value">A list of related PD entities</param>
        /// <returns>True if any PD entities are found</returns>
        public bool TryFindPDByGLCODE(string CODE, out IReadOnlyList<PD> Value)
        {
            return PD_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PD (Departments) entities by [PD.GLBANK]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PD entities</param>
        /// <returns>A list of related PD entities</returns>
        public IReadOnlyList<PD> FindPDByGLBANK(string CODE)
        {
            IReadOnlyList<PD> result;
            if (PD_GLBANKForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PD entities by [PD.GLBANK]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PD entities</param>
        /// <param name="Value">A list of related PD entities</param>
        /// <returns>True if any PD entities are found</returns>
        public bool TryFindPDByGLBANK(string CODE, out IReadOnlyList<PD> Value)
        {
            return PD_GLBANKForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PD (Departments) entities by [PD.GLTAX]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PD entities</param>
        /// <returns>A list of related PD entities</returns>
        public IReadOnlyList<PD> FindPDByGLTAX(string CODE)
        {
            IReadOnlyList<PD> result;
            if (PD_GLTAXForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PD entities by [PD.GLTAX]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PD entities</param>
        /// <param name="Value">A list of related PD entities</param>
        /// <returns>True if any PD entities are found</returns>
        public bool TryFindPDByGLTAX(string CODE, out IReadOnlyList<PD> Value)
        {
            return PD_GLTAXForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PF (Superannuation Funds) entities by [PF.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PF entities</param>
        /// <returns>A list of related PF entities</returns>
        public IReadOnlyList<PF> FindPFByGLCODE(string CODE)
        {
            IReadOnlyList<PF> result;
            if (PF_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PF entities by [PF.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PF entities</param>
        /// <param name="Value">A list of related PF entities</param>
        /// <returns>True if any PF entities are found</returns>
        public bool TryFindPFByGLCODE(string CODE, out IReadOnlyList<PF> Value)
        {
            return PF_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PI (Pay Items) entities by [PI.CLR_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PI entities</param>
        /// <returns>A list of related PI entities</returns>
        public IReadOnlyList<PI> FindPIByCLR_GLCODE(string CODE)
        {
            IReadOnlyList<PI> result;
            if (PI_CLR_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PI entities by [PI.CLR_GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PI entities</param>
        /// <param name="Value">A list of related PI entities</param>
        /// <returns>True if any PI entities are found</returns>
        public bool TryFindPIByCLR_GLCODE(string CODE, out IReadOnlyList<PI> Value)
        {
            return PI_CLR_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PN (Payroll Groups) entities by [PN.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PN entities</param>
        /// <returns>A list of related PN entities</returns>
        public IReadOnlyList<PN> FindPNByGLCODE(string CODE)
        {
            IReadOnlyList<PN> result;
            if (PN_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PN>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PN entities by [PN.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PN entities</param>
        /// <param name="Value">A list of related PN entities</param>
        /// <returns>True if any PN entities are found</returns>
        public bool TryFindPNByGLCODE(string CODE, out IReadOnlyList<PN> Value)
        {
            return PN_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PN (Payroll Groups) entities by [PN.GLBANK]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PN entities</param>
        /// <returns>A list of related PN entities</returns>
        public IReadOnlyList<PN> FindPNByGLBANK(string CODE)
        {
            IReadOnlyList<PN> result;
            if (PN_GLBANKForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PN>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PN entities by [PN.GLBANK]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PN entities</param>
        /// <param name="Value">A list of related PN entities</param>
        /// <returns>True if any PN entities are found</returns>
        public bool TryFindPNByGLBANK(string CODE, out IReadOnlyList<PN> Value)
        {
            return PN_GLBANKForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all PN (Payroll Groups) entities by [PN.GLTAX]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PN entities</param>
        /// <returns>A list of related PN entities</returns>
        public IReadOnlyList<PN> FindPNByGLTAX(string CODE)
        {
            IReadOnlyList<PN> result;
            if (PN_GLTAXForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<PN>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PN entities by [PN.GLTAX]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find PN entities</param>
        /// <param name="Value">A list of related PN entities</param>
        /// <returns>True if any PN entities are found</returns>
        public bool TryFindPNByGLTAX(string CODE, out IReadOnlyList<PN> Value)
        {
            return PN_GLTAXForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all SA (Fees) entities by [SA.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find SA entities</param>
        /// <returns>A list of related SA entities</returns>
        public IReadOnlyList<SA> FindSAByGLCODE(string CODE)
        {
            IReadOnlyList<SA> result;
            if (SA_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<SA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SA entities by [SA.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find SA entities</param>
        /// <param name="Value">A list of related SA entities</param>
        /// <returns>True if any SA entities are found</returns>
        public bool TryFindSAByGLCODE(string CODE, out IReadOnlyList<SA> Value)
        {
            return SA_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Find all SDFC (Sundry Debtor Fees) entities by [SDFC.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find SDFC entities</param>
        /// <returns>A list of related SDFC entities</returns>
        public IReadOnlyList<SDFC> FindSDFCByGLCODE(string CODE)
        {
            IReadOnlyList<SDFC> result;
            if (SDFC_GLCODEForeignIndex.Value.TryGetValue(CODE, out result))
            {
                return result;
            }
            else
            {
                return new List<SDFC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SDFC entities by [SDFC.GLCODE]-&gt;[GL.CODE]
        /// </summary>
        /// <param name="CODE">CODE value used to find SDFC entities</param>
        /// <param name="Value">A list of related SDFC entities</param>
        /// <returns>True if any SDFC entities are found</returns>
        public bool TryFindSDFCByGLCODE(string CODE, out IReadOnlyList<SDFC> Value)
        {
            return SDFC_GLCODEForeignIndex.Value.TryGetValue(CODE, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GL" /> fields for each CSV column header</returns>
        protected override Action<GL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LYROPBAL":
                        mapper[i] = (e, v) => e.LYROPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR01":
                        mapper[i] = (e, v) => e.LASTYR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR02":
                        mapper[i] = (e, v) => e.LASTYR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR03":
                        mapper[i] = (e, v) => e.LASTYR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR04":
                        mapper[i] = (e, v) => e.LASTYR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR05":
                        mapper[i] = (e, v) => e.LASTYR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR06":
                        mapper[i] = (e, v) => e.LASTYR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR07":
                        mapper[i] = (e, v) => e.LASTYR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR08":
                        mapper[i] = (e, v) => e.LASTYR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR09":
                        mapper[i] = (e, v) => e.LASTYR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR10":
                        mapper[i] = (e, v) => e.LASTYR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR11":
                        mapper[i] = (e, v) => e.LASTYR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR12":
                        mapper[i] = (e, v) => e.LASTYR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR01":
                        mapper[i] = (e, v) => e.CURR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR02":
                        mapper[i] = (e, v) => e.CURR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR03":
                        mapper[i] = (e, v) => e.CURR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR04":
                        mapper[i] = (e, v) => e.CURR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR05":
                        mapper[i] = (e, v) => e.CURR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR06":
                        mapper[i] = (e, v) => e.CURR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR07":
                        mapper[i] = (e, v) => e.CURR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR08":
                        mapper[i] = (e, v) => e.CURR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR09":
                        mapper[i] = (e, v) => e.CURR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR10":
                        mapper[i] = (e, v) => e.CURR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR11":
                        mapper[i] = (e, v) => e.CURR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR12":
                        mapper[i] = (e, v) => e.CURR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG01":
                        mapper[i] = (e, v) => e.BUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG02":
                        mapper[i] = (e, v) => e.BUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG03":
                        mapper[i] = (e, v) => e.BUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG04":
                        mapper[i] = (e, v) => e.BUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG05":
                        mapper[i] = (e, v) => e.BUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG06":
                        mapper[i] = (e, v) => e.BUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG07":
                        mapper[i] = (e, v) => e.BUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG08":
                        mapper[i] = (e, v) => e.BUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG09":
                        mapper[i] = (e, v) => e.BUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG10":
                        mapper[i] = (e, v) => e.BUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG11":
                        mapper[i] = (e, v) => e.BUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG12":
                        mapper[i] = (e, v) => e.BUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG01":
                        mapper[i] = (e, v) => e.NEXTBUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG02":
                        mapper[i] = (e, v) => e.NEXTBUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG03":
                        mapper[i] = (e, v) => e.NEXTBUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG04":
                        mapper[i] = (e, v) => e.NEXTBUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG05":
                        mapper[i] = (e, v) => e.NEXTBUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG06":
                        mapper[i] = (e, v) => e.NEXTBUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG07":
                        mapper[i] = (e, v) => e.NEXTBUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG08":
                        mapper[i] = (e, v) => e.NEXTBUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG09":
                        mapper[i] = (e, v) => e.NEXTBUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG10":
                        mapper[i] = (e, v) => e.NEXTBUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG11":
                        mapper[i] = (e, v) => e.NEXTBUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG12":
                        mapper[i] = (e, v) => e.NEXTBUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ANNUALBUDG":
                        mapper[i] = (e, v) => e.ANNUALBUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXT_ANN_BUDG":
                        mapper[i] = (e, v) => e.NEXT_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_ANN_BUDG":
                        mapper[i] = (e, v) => e.REV_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG01":
                        mapper[i] = (e, v) => e.REV_BUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG02":
                        mapper[i] = (e, v) => e.REV_BUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG03":
                        mapper[i] = (e, v) => e.REV_BUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG04":
                        mapper[i] = (e, v) => e.REV_BUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG05":
                        mapper[i] = (e, v) => e.REV_BUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG06":
                        mapper[i] = (e, v) => e.REV_BUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG07":
                        mapper[i] = (e, v) => e.REV_BUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG08":
                        mapper[i] = (e, v) => e.REV_BUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG09":
                        mapper[i] = (e, v) => e.REV_BUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG10":
                        mapper[i] = (e, v) => e.REV_BUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG11":
                        mapper[i] = (e, v) => e.REV_BUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG12":
                        mapper[i] = (e, v) => e.REV_BUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG01":
                        mapper[i] = (e, v) => e.LASTBUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG02":
                        mapper[i] = (e, v) => e.LASTBUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG03":
                        mapper[i] = (e, v) => e.LASTBUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG04":
                        mapper[i] = (e, v) => e.LASTBUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG05":
                        mapper[i] = (e, v) => e.LASTBUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG06":
                        mapper[i] = (e, v) => e.LASTBUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG07":
                        mapper[i] = (e, v) => e.LASTBUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG08":
                        mapper[i] = (e, v) => e.LASTBUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG09":
                        mapper[i] = (e, v) => e.LASTBUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG10":
                        mapper[i] = (e, v) => e.LASTBUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG11":
                        mapper[i] = (e, v) => e.LASTBUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG12":
                        mapper[i] = (e, v) => e.LASTBUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LAST_ANN_BUDG":
                        mapper[i] = (e, v) => e.LAST_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT01":
                        mapper[i] = (e, v) => e.COMMITMENT01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT02":
                        mapper[i] = (e, v) => e.COMMITMENT02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT03":
                        mapper[i] = (e, v) => e.COMMITMENT03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT04":
                        mapper[i] = (e, v) => e.COMMITMENT04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT05":
                        mapper[i] = (e, v) => e.COMMITMENT05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT06":
                        mapper[i] = (e, v) => e.COMMITMENT06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT07":
                        mapper[i] = (e, v) => e.COMMITMENT07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT08":
                        mapper[i] = (e, v) => e.COMMITMENT08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT09":
                        mapper[i] = (e, v) => e.COMMITMENT09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT10":
                        mapper[i] = (e, v) => e.COMMITMENT10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT11":
                        mapper[i] = (e, v) => e.COMMITMENT11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT12":
                        mapper[i] = (e, v) => e.COMMITMENT12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HIDATE":
                        mapper[i] = (e, v) => e.HIDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GL_TYPE":
                        mapper[i] = (e, v) => e.GL_TYPE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "USER_DEFINABLE":
                        mapper[i] = (e, v) => e.USER_DEFINABLE = v;
                        break;
                    case "FBT":
                        mapper[i] = (e, v) => e.FBT = v;
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
