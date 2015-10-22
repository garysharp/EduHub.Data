using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// GST Percentages Data Set
    /// </summary>
    public sealed partial class KGSTDataSet : SetBase<KGST>
    {
        private Lazy<Dictionary<string, KGST>> KGSTKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<ARF>>> ARF_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> CRF_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<CRF>>> CRF_INVOICEGSTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFVT>>> DFVT_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DRF>>> DRF_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLCF>>> GLCF_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLCFPREV>>> GLCFPREV_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLF>>> GLF_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>> GLFPREV_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SA>>> SA_GST_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SDFC>>> SDFC_GST_TYPEForeignIndex;

        internal KGSTDataSet(EduHubContext Context)
            : base(Context)
        {
            KGSTKEYIndex = new Lazy<Dictionary<string, KGST>>(() => this.ToDictionary(e => e.KGSTKEY));

            ARF_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ARF>>>(() =>
                    Context.ARF
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ARF>)g.ToList()
                          .AsReadOnly()));

            CRF_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() =>
                    Context.CRF
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<CRF>)g.ToList()
                          .AsReadOnly()));

            CRF_INVOICEGSTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<CRF>>>(() =>
                    Context.CRF
                          .Where(e => e.INVOICEGST != null)
                          .GroupBy(e => e.INVOICEGST)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<CRF>)g.ToList()
                          .AsReadOnly()));

            DFF_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            DFVT_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFVT>>>(() =>
                    Context.DFVT
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFVT>)g.ToList()
                          .AsReadOnly()));

            DRF_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DRF>>>(() =>
                    Context.DRF
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DRF>)g.ToList()
                          .AsReadOnly()));

            GLCF_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLCF>>>(() =>
                    Context.GLCF
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLCF>)g.ToList()
                          .AsReadOnly()));

            GLCFPREV_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLCFPREV>>>(() =>
                    Context.GLCFPREV
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLCFPREV>)g.ToList()
                          .AsReadOnly()));

            GLF_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLF>>>(() =>
                    Context.GLF
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLF>)g.ToList()
                          .AsReadOnly()));

            GLFPREV_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>>(() =>
                    Context.GLFPREV
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLFPREV>)g.ToList()
                          .AsReadOnly()));

            SA_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SA>>>(() =>
                    Context.SA
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SA>)g.ToList()
                          .AsReadOnly()));

            SDFC_GST_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SDFC>>>(() =>
                    Context.SDFC
                          .Where(e => e.GST_TYPE != null)
                          .GroupBy(e => e.GST_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SDFC>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGST"; } }

        /// <summary>
        /// Find KGST by KGSTKEY key field
        /// </summary>
        /// <param name="Key">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGSTKEY value didn't match any KGST entities</exception>
        public KGST FindByKGSTKEY(string Key)
        {
            KGST result;
            if (KGSTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY key field
        /// </summary>
        /// <param name="Key">KGSTKEY value used to find KGST</param>
        /// <param name="Value">Related KGST entity</param>
        /// <returns>True if the KGST entity is found</returns>
        public bool TryFindByKGSTKEY(string Key, out KGST Value)
        {
            return KGSTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGST by KGSTKEY key field
        /// </summary>
        /// <param name="Key">KGSTKEY value used to find KGST</param>
        /// <returns>Related KGST entity, or null if not found</returns>
        public KGST TryFindByKGSTKEY(string Key)
        {
            KGST result;
            if (KGSTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all ARF (Asset Financial Transactions) entities by [ARF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find ARF entities</param>
        /// <returns>A list of related ARF entities</returns>
        public IReadOnlyList<ARF> FindARFByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<ARF> result;
            if (ARF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ARF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ARF entities by [ARF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find ARF entities</param>
        /// <param name="Value">A list of related ARF entities</param>
        /// <returns>True if any ARF entities are found</returns>
        public bool TryFindARFByGST_TYPE(string KGSTKEY, out IReadOnlyList<ARF> Value)
        {
            return ARF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all CRF (Creditor Financial Transaction) entities by [CRF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find CRF entities</param>
        /// <returns>A list of related CRF entities</returns>
        public IReadOnlyList<CRF> FindCRFByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<CRF> result;
            if (CRF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<CRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all CRF entities by [CRF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find CRF entities</param>
        /// <param name="Value">A list of related CRF entities</param>
        /// <returns>True if any CRF entities are found</returns>
        public bool TryFindCRFByGST_TYPE(string KGSTKEY, out IReadOnlyList<CRF> Value)
        {
            return CRF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all CRF (Creditor Financial Transaction) entities by [CRF.INVOICEGST]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find CRF entities</param>
        /// <returns>A list of related CRF entities</returns>
        public IReadOnlyList<CRF> FindCRFByINVOICEGST(string KGSTKEY)
        {
            IReadOnlyList<CRF> result;
            if (CRF_INVOICEGSTForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<CRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all CRF entities by [CRF.INVOICEGST]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find CRF entities</param>
        /// <param name="Value">A list of related CRF entities</param>
        /// <returns>True if any CRF entities are found</returns>
        public bool TryFindCRFByINVOICEGST(string KGSTKEY, out IReadOnlyList<CRF> Value)
        {
            return CRF_INVOICEGSTForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<DFF> result;
            if (DFF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFByGST_TYPE(string KGSTKEY, out IReadOnlyList<DFF> Value)
        {
            return DFF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all DFVT (Family Voluntary Transactions) entities by [DFVT.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find DFVT entities</param>
        /// <returns>A list of related DFVT entities</returns>
        public IReadOnlyList<DFVT> FindDFVTByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<DFVT> result;
            if (DFVT_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFVT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFVT entities by [DFVT.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find DFVT entities</param>
        /// <param name="Value">A list of related DFVT entities</param>
        /// <returns>True if any DFVT entities are found</returns>
        public bool TryFindDFVTByGST_TYPE(string KGSTKEY, out IReadOnlyList<DFVT> Value)
        {
            return DFVT_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all DRF (DR Transactions) entities by [DRF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find DRF entities</param>
        /// <returns>A list of related DRF entities</returns>
        public IReadOnlyList<DRF> FindDRFByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<DRF> result;
            if (DRF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DRF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DRF entities by [DRF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find DRF entities</param>
        /// <param name="Value">A list of related DRF entities</param>
        /// <returns>True if any DRF entities are found</returns>
        public bool TryFindDRFByGST_TYPE(string KGSTKEY, out IReadOnlyList<DRF> Value)
        {
            return DRF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all GLCF (GL Combined Financial Trans) entities by [GLCF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find GLCF entities</param>
        /// <returns>A list of related GLCF entities</returns>
        public IReadOnlyList<GLCF> FindGLCFByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<GLCF> result;
            if (GLCF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<GLCF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLCF entities by [GLCF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find GLCF entities</param>
        /// <param name="Value">A list of related GLCF entities</param>
        /// <returns>True if any GLCF entities are found</returns>
        public bool TryFindGLCFByGST_TYPE(string KGSTKEY, out IReadOnlyList<GLCF> Value)
        {
            return GLCF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all GLCFPREV (Last Years GL Combined Financial Trans) entities by [GLCFPREV.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find GLCFPREV entities</param>
        /// <returns>A list of related GLCFPREV entities</returns>
        public IReadOnlyList<GLCFPREV> FindGLCFPREVByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<GLCFPREV> result;
            if (GLCFPREV_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<GLCFPREV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLCFPREV entities by [GLCFPREV.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find GLCFPREV entities</param>
        /// <param name="Value">A list of related GLCFPREV entities</param>
        /// <returns>True if any GLCFPREV entities are found</returns>
        public bool TryFindGLCFPREVByGST_TYPE(string KGSTKEY, out IReadOnlyList<GLCFPREV> Value)
        {
            return GLCFPREV_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all GLF (General Ledger Transactions) entities by [GLF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find GLF entities</param>
        /// <returns>A list of related GLF entities</returns>
        public IReadOnlyList<GLF> FindGLFByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<GLF> result;
            if (GLF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<GLF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLF entities by [GLF.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find GLF entities</param>
        /// <param name="Value">A list of related GLF entities</param>
        /// <returns>True if any GLF entities are found</returns>
        public bool TryFindGLFByGST_TYPE(string KGSTKEY, out IReadOnlyList<GLF> Value)
        {
            return GLF_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all GLFPREV (Last Years GL Financial Trans) entities by [GLFPREV.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find GLFPREV entities</param>
        /// <returns>A list of related GLFPREV entities</returns>
        public IReadOnlyList<GLFPREV> FindGLFPREVByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<GLFPREV> result;
            if (GLFPREV_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<GLFPREV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLFPREV entities by [GLFPREV.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find GLFPREV entities</param>
        /// <param name="Value">A list of related GLFPREV entities</param>
        /// <returns>True if any GLFPREV entities are found</returns>
        public bool TryFindGLFPREVByGST_TYPE(string KGSTKEY, out IReadOnlyList<GLFPREV> Value)
        {
            return GLFPREV_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all SA (Fees) entities by [SA.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find SA entities</param>
        /// <returns>A list of related SA entities</returns>
        public IReadOnlyList<SA> FindSAByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<SA> result;
            if (SA_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SA entities by [SA.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find SA entities</param>
        /// <param name="Value">A list of related SA entities</param>
        /// <returns>True if any SA entities are found</returns>
        public bool TryFindSAByGST_TYPE(string KGSTKEY, out IReadOnlyList<SA> Value)
        {
            return SA_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }

        /// <summary>
        /// Find all SDFC (Sundry Debtor Fees) entities by [SDFC.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find SDFC entities</param>
        /// <returns>A list of related SDFC entities</returns>
        public IReadOnlyList<SDFC> FindSDFCByGST_TYPE(string KGSTKEY)
        {
            IReadOnlyList<SDFC> result;
            if (SDFC_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SDFC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SDFC entities by [SDFC.GST_TYPE]-&gt;[KGST.KGSTKEY]
        /// </summary>
        /// <param name="KGSTKEY">KGSTKEY value used to find SDFC entities</param>
        /// <param name="Value">A list of related SDFC entities</param>
        /// <returns>True if any SDFC entities are found</returns>
        public bool TryFindSDFCByGST_TYPE(string KGSTKEY, out IReadOnlyList<SDFC> Value)
        {
            return SDFC_GST_TYPEForeignIndex.Value.TryGetValue(KGSTKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGST" /> fields for each CSV column header</returns>
        protected override Action<KGST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGSTKEY":
                        mapper[i] = (e, v) => e.KGSTKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SALE_PURCH":
                        mapper[i] = (e, v) => e.SALE_PURCH = v;
                        break;
                    case "GST_RATE":
                        mapper[i] = (e, v) => e.GST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "GST_BOX":
                        mapper[i] = (e, v) => e.GST_BOX = v;
                        break;
                    case "GLGST_CODE":
                        mapper[i] = (e, v) => e.GLGST_CODE = v;
                        break;
                    case "GST_RECLAIM":
                        mapper[i] = (e, v) => e.GST_RECLAIM = v;
                        break;
                    case "PRIOR_PERIOD_GST":
                        mapper[i] = (e, v) => e.PRIOR_PERIOD_GST = v;
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
