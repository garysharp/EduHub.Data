using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AR : EduHubEntity
    {

        #region Navigation Property Cache

        private AKC Cache_CATEGORY_AKC;
        private AKT Cache_ASSET_TYPE_AKT;
        private AKR Cache_RELEASE_TYPE_AKR;
        private AKCT Cache_TAX_CATEGORY_AKCT;
        private AKL Cache_LOCATION_AKL;
        private AKD Cache_DEPARTMENT_AKD;
        private AKB Cache_BRANCH_AKB;
        private CR Cache_ORIG_SUPPLIER_CR;
        private CR Cache_CURR_SUPPLIER_CR;
        private GL Cache_PTE_GLCODE_GL;
        private KADM Cache_AMETHOD_KADM;
        private KADM Cache_TMETHOD_KADM;
        private AR Cache_COMPONENT_OF_AR;
        private SCI Cache_CAMPUS_SCI;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<AKK> Cache_ARKEY_AKK_CODE;
        private IReadOnlyList<AR> Cache_ARKEY_AR_COMPONENT_OF;
        private IReadOnlyList<ARF> Cache_ARKEY_ARF_CODE;
        private IReadOnlyList<CRF> Cache_ARKEY_CRF_ATKEY;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ARKEY { get; internal set; }

        /// <summary>
        /// Numeric SAMS number for DE&amp;T export
        /// </summary>
        public int ARNUMBER { get; internal set; }

        /// <summary>
        /// Title (Primary description)
        /// [Alphanumeric (40)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Extra description of the asset
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION01 { get; internal set; }

        /// <summary>
        /// Extra description of the asset
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION02 { get; internal set; }

        /// <summary>
        /// Asset category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CATEGORY { get; internal set; }

        /// <summary>
        /// Asset type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string ASSET_TYPE { get; internal set; }

        /// <summary>
        /// Asset Release Type
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string RELEASE_TYPE { get; internal set; }

        /// <summary>
        /// Asset tax category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TAX_CATEGORY { get; internal set; }

        /// <summary>
        /// Asset locations
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string LOCATION { get; internal set; }

        /// <summary>
        /// Departments
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEPARTMENT { get; internal set; }

        /// <summary>
        /// Sub Category
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string BRANCH { get; internal set; }

        /// <summary>
        /// Lease start date
        /// </summary>
        public DateTime? LEASE_START_DATE { get; internal set; }

        /// <summary>
        /// Lease end date
        /// </summary>
        public DateTime? LEASE_END_DATE { get; internal set; }

        /// <summary>
        /// For leased items
        /// </summary>
        public decimal? LEASE_COST_MONTH { get; internal set; }

        /// <summary>
        /// Supplier
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ORIG_SUPPLIER { get; internal set; }

        /// <summary>
        /// Default repairer
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CURR_SUPPLIER { get; internal set; }

        /// <summary>
        /// Invoice number of original acquisition
        /// [Alphanumeric (10)]
        /// </summary>
        public string ORIG_INVOICE_NO { get; internal set; }

        /// <summary>
        /// Invoice number of most recent purchase/addition
        /// [Alphanumeric (10)]
        /// </summary>
        public string LAST_INVOICE_NO { get; internal set; }

        /// <summary>
        /// Initial Purchase date
        /// </summary>
        public DateTime? PURDATE { get; internal set; }

        /// <summary>
        /// Last addition date
        /// </summary>
        public DateTime? LAST_ADDN_DATE { get; internal set; }

        /// <summary>
        /// Disposal date
        /// </summary>
        public DateTime? LAST_DISP_DATE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? LAST_GST_RECLAIM { get; internal set; }

        /// <summary>
        /// Last revaluation date
        /// </summary>
        public DateTime? LAST_REVAL_DATE { get; internal set; }

        /// <summary>
        /// GL acct where pte use % of depn will be posted
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PTE_GLCODE { get; internal set; }

        /// <summary>
        /// Percentage of private use for accounting
        /// </summary>
        public double? PTE_USE_RATE { get; internal set; }

        /// <summary>
        /// Actuals:Open Bal - Cost ex GST
        /// </summary>
        public decimal? AOB_COST { get; internal set; }

        /// <summary>
        /// Actuals:Open Bal - Revaluations
        /// </summary>
        public decimal? AOB_REVALS { get; internal set; }

        /// <summary>
        /// Actual Disposals:Open Bal - Reductions in
        ///  Original Cost ex GST
        /// </summary>
        public decimal? AOB_DISP_COST { get; internal set; }

        /// <summary>
        /// Actual Disposals:Open Bal - Reductions in
        ///  Revaluation Adjustments
        /// </summary>
        public decimal? AOB_DISP_REVALS { get; internal set; }

        /// <summary>
        /// This year's additions
        /// </summary>
        public decimal? ATY_COST { get; internal set; }

        /// <summary>
        /// Actuals:This Year - Revaluation Adjustments
        /// </summary>
        public decimal? ATY_REVALS { get; internal set; }

        /// <summary>
        /// Actual Disposals:This Year - Reductions in
        /// </summary>
        public decimal? ATY_DISP_REVALS { get; internal set; }

        /// <summary>
        /// This Year - Reductions in Original Cost ex GST
        /// </summary>
        public decimal? ATY_DISP_COST { get; internal set; }

        /// <summary>
        /// ADep:Open Bal - Accum Depreciation
        /// </summary>
        public decimal? AOB_DEPN { get; internal set; }

        /// <summary>
        /// Private % of depn charged in prior years
        /// </summary>
        public decimal? AOB_PTE_DEPN { get; internal set; }

        /// <summary>
        /// ADep Disposals:Open bal -
        ///  - Reductions in Accum Depreciation
        /// </summary>
        public decimal? AOB_DISP_DEPN { get; internal set; }

        /// <summary>
        /// ADep Disposals:Open Bal
        ///  - Profit or Loss on Disposals
        /// </summary>
        public decimal? AOB_DISP_PROF { get; internal set; }

        /// <summary>
        /// ADep:This Year - Accum
        /// </summary>
        public decimal? ATY_DEPN { get; internal set; }

        /// <summary>
        /// Private % of depn charged this year
        /// </summary>
        public decimal? ATY_PTE_DEPN { get; internal set; }

        /// <summary>
        /// ADep Disposals:This Year
        ///  - Reductions in Accum
        /// </summary>
        public decimal? ATY_DISP_DEPN { get; internal set; }

        /// <summary>
        /// ADep Disposals:This Year
        ///  - Profit or Loss on Disposals
        /// </summary>
        public decimal? ATY_DISP_PROF { get; internal set; }

        /// <summary>
        /// Account  rate
        /// </summary>
        public double? ARATE { get; internal set; }

        /// <summary>
        /// method
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AMETHOD { get; internal set; }

        /// <summary>
        /// Estimated Life in Units
        /// </summary>
        public int? AEST_LIFE_UNITS { get; internal set; }

        /// <summary>
        /// Description of type of units used
        /// [Alphanumeric (30)]
        /// </summary>
        public string AUNITS_DESC { get; internal set; }

        /// <summary>
        /// Units used to date
        /// </summary>
        public int? AUNITS_TO_DATE { get; internal set; }

        /// <summary>
        /// indicator
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AFLAG { get; internal set; }

        /// <summary>
        /// Start date for
        /// </summary>
        public DateTime? ADEPN_START { get; internal set; }

        /// <summary>
        /// Date last depreciated for accounting
        /// </summary>
        public DateTime? ADEPN_LAST_DATE { get; internal set; }

        /// <summary>
        /// Open Bal - Original GST
        /// </summary>
        public decimal? AOB_ORIG_GST { get; internal set; }

        /// <summary>
        /// Open Bal - Unclaimed GST
        /// </summary>
        public decimal? AOB_UNCL_GST { get; internal set; }

        /// <summary>
        /// Disposals:Open Bal-Reductions in Unclaimed GST
        /// </summary>
        public decimal? AOB_DISP_UNCL_GST { get; internal set; }

        /// <summary>
        /// Disposals:Open Bal-Reductions in Original GST
        /// </summary>
        public decimal? AOB_DISP_ORIG_GST { get; internal set; }

        /// <summary>
        /// This Year - Original GST
        /// </summary>
        public decimal? ATY_ORIG_GST { get; internal set; }

        /// <summary>
        /// This Year - Unclaimed GST
        /// </summary>
        public decimal? ATY_UNCL_GST { get; internal set; }

        /// <summary>
        /// Disposals:This Year Reductions in Unclaimed GST
        /// </summary>
        public decimal? ATY_DISP_UNCL_GST { get; internal set; }

        /// <summary>
        /// Disposals:This Year Reductions in Original GST
        /// </summary>
        public decimal? ATY_DISP_ORIG_GST { get; internal set; }

        /// <summary>
        /// TDep: Open Bal - Cost ex GST
        /// </summary>
        public decimal? TOB_COST { get; internal set; }

        /// <summary>
        /// TDep: Open Bal - Accum
        /// </summary>
        public decimal? TOB_DEPN { get; internal set; }

        /// <summary>
        /// Private % of tax depn charged in prior years
        /// </summary>
        public decimal? TOB_PTE_DEPN { get; internal set; }

        /// <summary>
        /// TDep: Open Bal - Reductions in Original Cost ex GST
        /// </summary>
        public decimal? TOB_DISP_COST { get; internal set; }

        /// <summary>
        /// TDep: Open Bal - Reductions in Accum
        /// </summary>
        public decimal? TOB_DISP_DEPN { get; internal set; }

        /// <summary>
        /// TDep: Open Bal - Profit/Loss on Disposals
        /// </summary>
        public decimal? TOB_DISP_PROF { get; internal set; }

        /// <summary>
        /// TDep: Open Bal - Gain on Disposals
        /// </summary>
        public decimal? TOB_DISP_GAIN { get; internal set; }

        /// <summary>
        /// TDep: This Year - Cost ex GST
        /// </summary>
        public decimal? TTY_COST { get; internal set; }

        /// <summary>
        /// TDep: This Year - Accum
        /// </summary>
        public decimal? TTY_DEPN { get; internal set; }

        /// <summary>
        /// Private % of depn charged this year
        /// </summary>
        public decimal? TTY_PTE_DEPN { get; internal set; }

        /// <summary>
        /// TDep: This Year - Reductions in Original Cost ex GST
        /// </summary>
        public decimal? TTY_DISP_COST { get; internal set; }

        /// <summary>
        /// TDep: This Year-Reductions in Accum
        /// </summary>
        public decimal? TTY_DISP_DEPN { get; internal set; }

        /// <summary>
        /// TDep: This Year - Profit/Loss on Disposals
        /// </summary>
        public decimal? TTY_DISP_PROF { get; internal set; }

        /// <summary>
        /// TDep: This Year - Gain on Disposals
        /// </summary>
        public decimal? TTY_DISP_GAIN { get; internal set; }

        /// <summary>
        /// Tax  rate
        /// </summary>
        public double? TRATE { get; internal set; }

        /// <summary>
        /// Depreciation method
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TMETHOD { get; internal set; }

        /// <summary>
        /// Depreciation indicator
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TFLAG { get; internal set; }

        /// <summary>
        /// Start date for depreciation
        /// </summary>
        public DateTime? TDEPN_START { get; internal set; }

        /// <summary>
        /// Date last depreciated for tax
        /// </summary>
        public DateTime? TDEPN_LAST_DATE { get; internal set; }

        /// <summary>
        /// Open Bal - Original GST
        /// </summary>
        public decimal? TOB_ORIG_GST { get; internal set; }

        /// <summary>
        /// Open Bal - Unclaimed GST
        /// </summary>
        public decimal? TOB_UNCL_GST { get; internal set; }

        /// <summary>
        /// Disposals:Open Bal-Reductions in Unclaimed GST
        /// </summary>
        public decimal? TOB_DISP_UNCL_GST { get; internal set; }

        /// <summary>
        /// Disposals:Open Bal-Reductions in Original GST
        /// </summary>
        public decimal? TOB_DISP_ORIG_GST { get; internal set; }

        /// <summary>
        /// This Year - Original GST
        /// </summary>
        public decimal? TTY_ORIG_GST { get; internal set; }

        /// <summary>
        /// This Year - Unclaimed GST
        /// </summary>
        public decimal? TTY_UNCL_GST { get; internal set; }

        /// <summary>
        /// Disposals:This Year Reductions in Unclaimed GST
        /// </summary>
        public decimal? TTY_DISP_UNCL_GST { get; internal set; }

        /// <summary>
        /// Disposals:This Year Reductions in Original GST
        /// </summary>
        public decimal? TTY_DISP_ORIG_GST { get; internal set; }

        /// <summary>
        /// Actuals:Open Bal - Quantity
        /// </summary>
        public short? OB_QTY { get; internal set; }

        /// <summary>
        /// Actual Disposals:Open Bal - Quantity
        /// </summary>
        public short? OB_DISP_QTY { get; internal set; }

        /// <summary>
        /// Actuals:This Year - Quantity
        /// </summary>
        public short? TY_QTY { get; internal set; }

        /// <summary>
        /// Actual Disposals:This Year - Quantity
        /// </summary>
        public short? TY_DISP_QTY { get; internal set; }

        /// <summary>
        /// Actuals:Open Bal - Proceeds on Disposal
        /// </summary>
        public decimal? OB_DISP_PROC { get; internal set; }

        /// <summary>
        /// Disposal price
        /// </summary>
        public decimal? TY_DISP_PROC { get; internal set; }

        /// <summary>
        /// Last stocktake date
        /// </summary>
        public DateTime? LAST_ST_DATE { get; internal set; }

        /// <summary>
        /// Last Date this asset was serviced
        /// </summary>
        public DateTime? LAST_SVC_DATE { get; internal set; }

        /// <summary>
        /// Date for next service
        /// </summary>
        public DateTime? NEXT_SVC_DATE { get; internal set; }

        /// <summary>
        /// Comments from last service
        /// [Memo]
        /// </summary>
        public string LAST_SVC_DETAILS { get; internal set; }

        /// <summary>
        /// Owner
        /// [Alphanumeric (30)]
        /// </summary>
        public string OWNER { get; internal set; }

        /// <summary>
        /// Expected life
        /// </summary>
        public short? EXPECTED_LIFE { get; internal set; }

        /// <summary>
        /// Warranty in months
        /// </summary>
        public short? WARRANTY { get; internal set; }

        /// <summary>
        /// Expiry date of warranty
        /// </summary>
        public DateTime? WARRANTYEXP { get; internal set; }

        /// <summary>
        /// Serial number/Reg. number
        /// [Alphanumeric (20)]
        /// </summary>
        public string SERIAL { get; internal set; }

        /// <summary>
        /// Cleaning memo
        /// [Memo]
        /// </summary>
        public string CLEANING { get; internal set; }

        /// <summary>
        /// Hazard memo
        /// [Memo]
        /// </summary>
        public string HAZARD { get; internal set; }

        /// <summary>
        /// Site reference
        /// [Alphanumeric (20)]
        /// </summary>
        public string SITE_REFERENCE { get; internal set; }

        /// <summary>
        /// Extra details
        /// [Memo]
        /// </summary>
        public string EXTRA_DETAILS { get; internal set; }

        /// <summary>
        /// Asset that this is a component of, or related to
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string COMPONENT_OF { get; internal set; }

        /// <summary>
        /// Picture of asset
        /// </summary>
        public byte[] ASSET_PIC { get; internal set; }

        /// <summary>
        /// Campus number
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// AKC (Assets - Categories) related entity by [AR.CATEGORY]-&gt;[AKC.CATEGORY]
        /// Asset category
        /// </summary>
        public AKC CATEGORY_AKC
        {
            get
            {
                if (CATEGORY == null)
                {
                    return null;
                }
                if (Cache_CATEGORY_AKC == null)
                {
                    Cache_CATEGORY_AKC = Context.AKC.FindByCATEGORY(CATEGORY);
                }

                return Cache_CATEGORY_AKC;
            }
        }

        /// <summary>
        /// AKT (Asset Types) related entity by [AR.ASSET_TYPE]-&gt;[AKT.AKTKEY]
        /// Asset type
        /// </summary>
        public AKT ASSET_TYPE_AKT
        {
            get
            {
                if (ASSET_TYPE == null)
                {
                    return null;
                }
                if (Cache_ASSET_TYPE_AKT == null)
                {
                    Cache_ASSET_TYPE_AKT = Context.AKT.FindByAKTKEY(ASSET_TYPE);
                }

                return Cache_ASSET_TYPE_AKT;
            }
        }

        /// <summary>
        /// AKR (Asset Release Types) related entity by [AR.RELEASE_TYPE]-&gt;[AKR.AKRKEY]
        /// Asset Release Type
        /// </summary>
        public AKR RELEASE_TYPE_AKR
        {
            get
            {
                if (RELEASE_TYPE == null)
                {
                    return null;
                }
                if (Cache_RELEASE_TYPE_AKR == null)
                {
                    Cache_RELEASE_TYPE_AKR = Context.AKR.FindByAKRKEY(RELEASE_TYPE);
                }

                return Cache_RELEASE_TYPE_AKR;
            }
        }

        /// <summary>
        /// AKCT (Assets - Categories Tax) related entity by [AR.TAX_CATEGORY]-&gt;[AKCT.CATEGORY]
        /// Asset tax category
        /// </summary>
        public AKCT TAX_CATEGORY_AKCT
        {
            get
            {
                if (TAX_CATEGORY == null)
                {
                    return null;
                }
                if (Cache_TAX_CATEGORY_AKCT == null)
                {
                    Cache_TAX_CATEGORY_AKCT = Context.AKCT.FindByCATEGORY(TAX_CATEGORY);
                }

                return Cache_TAX_CATEGORY_AKCT;
            }
        }

        /// <summary>
        /// AKL (Assets - Locations) related entity by [AR.LOCATION]-&gt;[AKL.LOCATION]
        /// Asset locations
        /// </summary>
        public AKL LOCATION_AKL
        {
            get
            {
                if (LOCATION == null)
                {
                    return null;
                }
                if (Cache_LOCATION_AKL == null)
                {
                    Cache_LOCATION_AKL = Context.AKL.FindByLOCATION(LOCATION);
                }

                return Cache_LOCATION_AKL;
            }
        }

        /// <summary>
        /// AKD (Assets - Departments) related entity by [AR.DEPARTMENT]-&gt;[AKD.DEPARTMENT]
        /// Departments
        /// </summary>
        public AKD DEPARTMENT_AKD
        {
            get
            {
                if (DEPARTMENT == null)
                {
                    return null;
                }
                if (Cache_DEPARTMENT_AKD == null)
                {
                    Cache_DEPARTMENT_AKD = Context.AKD.FindByDEPARTMENT(DEPARTMENT);
                }

                return Cache_DEPARTMENT_AKD;
            }
        }

        /// <summary>
        /// AKB (Assets - Sub-Category) related entity by [AR.BRANCH]-&gt;[AKB.BRANCH]
        /// Sub Category
        /// </summary>
        public AKB BRANCH_AKB
        {
            get
            {
                if (BRANCH == null)
                {
                    return null;
                }
                if (Cache_BRANCH_AKB == null)
                {
                    Cache_BRANCH_AKB = Context.AKB.FindByBRANCH(BRANCH);
                }

                return Cache_BRANCH_AKB;
            }
        }

        /// <summary>
        /// CR (Accounts Payable) related entity by [AR.ORIG_SUPPLIER]-&gt;[CR.CRKEY]
        /// Supplier
        /// </summary>
        public CR ORIG_SUPPLIER_CR
        {
            get
            {
                if (ORIG_SUPPLIER == null)
                {
                    return null;
                }
                if (Cache_ORIG_SUPPLIER_CR == null)
                {
                    Cache_ORIG_SUPPLIER_CR = Context.CR.FindByCRKEY(ORIG_SUPPLIER);
                }

                return Cache_ORIG_SUPPLIER_CR;
            }
        }

        /// <summary>
        /// CR (Accounts Payable) related entity by [AR.CURR_SUPPLIER]-&gt;[CR.CRKEY]
        /// Default repairer
        /// </summary>
        public CR CURR_SUPPLIER_CR
        {
            get
            {
                if (CURR_SUPPLIER == null)
                {
                    return null;
                }
                if (Cache_CURR_SUPPLIER_CR == null)
                {
                    Cache_CURR_SUPPLIER_CR = Context.CR.FindByCRKEY(CURR_SUPPLIER);
                }

                return Cache_CURR_SUPPLIER_CR;
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [AR.PTE_GLCODE]-&gt;[GL.CODE]
        /// GL acct where pte use % of depn will be posted
        /// </summary>
        public GL PTE_GLCODE_GL
        {
            get
            {
                if (PTE_GLCODE == null)
                {
                    return null;
                }
                if (Cache_PTE_GLCODE_GL == null)
                {
                    Cache_PTE_GLCODE_GL = Context.GL.FindByCODE(PTE_GLCODE);
                }

                return Cache_PTE_GLCODE_GL;
            }
        }

        /// <summary>
        /// KADM (Asset Depreciation Methods) related entity by [AR.AMETHOD]-&gt;[KADM.KADMKEY]
        /// method
        /// </summary>
        public KADM AMETHOD_KADM
        {
            get
            {
                if (AMETHOD == null)
                {
                    return null;
                }
                if (Cache_AMETHOD_KADM == null)
                {
                    Cache_AMETHOD_KADM = Context.KADM.FindByKADMKEY(AMETHOD);
                }

                return Cache_AMETHOD_KADM;
            }
        }

        /// <summary>
        /// KADM (Asset Depreciation Methods) related entity by [AR.TMETHOD]-&gt;[KADM.KADMKEY]
        /// Depreciation method
        /// </summary>
        public KADM TMETHOD_KADM
        {
            get
            {
                if (TMETHOD == null)
                {
                    return null;
                }
                if (Cache_TMETHOD_KADM == null)
                {
                    Cache_TMETHOD_KADM = Context.KADM.FindByKADMKEY(TMETHOD);
                }

                return Cache_TMETHOD_KADM;
            }
        }

        /// <summary>
        /// AR (Assets) related entity by [AR.COMPONENT_OF]-&gt;[AR.ARKEY]
        /// Asset that this is a component of, or related to
        /// </summary>
        public AR COMPONENT_OF_AR
        {
            get
            {
                if (COMPONENT_OF == null)
                {
                    return null;
                }
                if (Cache_COMPONENT_OF_AR == null)
                {
                    Cache_COMPONENT_OF_AR = Context.AR.FindByARKEY(COMPONENT_OF);
                }

                return Cache_COMPONENT_OF_AR;
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [AR.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Campus number
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// AKK (Asset Key Holders) related entities by [AR.ARKEY]-&gt;[AKK.CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<AKK> ARKEY_AKK_CODE
        {
            get
            {
                if (Cache_ARKEY_AKK_CODE == null &&
                    !Context.AKK.TryFindByCODE(ARKEY, out Cache_ARKEY_AKK_CODE))
                {
                    Cache_ARKEY_AKK_CODE = new List<AKK>().AsReadOnly();
                }

                return Cache_ARKEY_AKK_CODE;
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [AR.ARKEY]-&gt;[AR.COMPONENT_OF]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<AR> ARKEY_AR_COMPONENT_OF
        {
            get
            {
                if (Cache_ARKEY_AR_COMPONENT_OF == null &&
                    !Context.AR.TryFindByCOMPONENT_OF(ARKEY, out Cache_ARKEY_AR_COMPONENT_OF))
                {
                    Cache_ARKEY_AR_COMPONENT_OF = new List<AR>().AsReadOnly();
                }

                return Cache_ARKEY_AR_COMPONENT_OF;
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [AR.ARKEY]-&gt;[ARF.CODE]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<ARF> ARKEY_ARF_CODE
        {
            get
            {
                if (Cache_ARKEY_ARF_CODE == null &&
                    !Context.ARF.TryFindByCODE(ARKEY, out Cache_ARKEY_ARF_CODE))
                {
                    Cache_ARKEY_ARF_CODE = new List<ARF>().AsReadOnly();
                }

                return Cache_ARKEY_ARF_CODE;
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [AR.ARKEY]-&gt;[CRF.ATKEY]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<CRF> ARKEY_CRF_ATKEY
        {
            get
            {
                if (Cache_ARKEY_CRF_ATKEY == null &&
                    !Context.CRF.TryFindByATKEY(ARKEY, out Cache_ARKEY_CRF_ATKEY))
                {
                    Cache_ARKEY_CRF_ATKEY = new List<CRF>().AsReadOnly();
                }

                return Cache_ARKEY_CRF_ATKEY;
            }
        }

        #endregion

    }
}
