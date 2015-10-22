using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets
    /// </summary>
    public partial class AR : EntityBase
    {
#region Navigation Property Cache
        private AKC _CATEGORY_AKC;
        private AKT _ASSET_TYPE_AKT;
        private AKR _RELEASE_TYPE_AKR;
        private AKCT _TAX_CATEGORY_AKCT;
        private AKL _LOCATION_AKL;
        private AKD _DEPARTMENT_AKD;
        private AKB _BRANCH_AKB;
        private CR _ORIG_SUPPLIER_CR;
        private CR _CURR_SUPPLIER_CR;
        private GL _PTE_GLCODE_GL;
        private KADM _AMETHOD_KADM;
        private KADM _TMETHOD_KADM;
        private AR _COMPONENT_OF_AR;
        private SCI _CAMPUS_SCI;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string ARKEY { get; internal set; }
        /// <summary>
        /// Numeric SAMS number for DE&amp;T export
        /// </summary>
        public int? ARNUMBER { get; internal set; }
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
        /// 
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
        /// Original Cost ex GST
        /// </summary>
        public decimal? AOB_DISP_COST { get; internal set; }
        /// <summary>
        /// Actual Disposals:Open Bal - Reductions in
        /// Revaluation Adjustments
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
        /// - Reductions in Accum Depreciation
        /// </summary>
        public decimal? AOB_DISP_DEPN { get; internal set; }
        /// <summary>
        /// ADep Disposals:Open Bal
        /// - Profit or Loss on Disposals
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
        /// - Reductions in Accum
        /// </summary>
        public decimal? ATY_DISP_DEPN { get; internal set; }
        /// <summary>
        /// ADep Disposals:This Year
        /// - Profit or Loss on Disposals
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
                if (CATEGORY != null)
                {
                    if (_CATEGORY_AKC == null)
                    {
                        _CATEGORY_AKC = Context.AKC.FindByCATEGORY(CATEGORY);
                    }
                    return _CATEGORY_AKC;
                }
                else
                {
                    return null;
                }
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
                if (ASSET_TYPE != null)
                {
                    if (_ASSET_TYPE_AKT == null)
                    {
                        _ASSET_TYPE_AKT = Context.AKT.FindByAKTKEY(ASSET_TYPE);
                    }
                    return _ASSET_TYPE_AKT;
                }
                else
                {
                    return null;
                }
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
                if (RELEASE_TYPE != null)
                {
                    if (_RELEASE_TYPE_AKR == null)
                    {
                        _RELEASE_TYPE_AKR = Context.AKR.FindByAKRKEY(RELEASE_TYPE);
                    }
                    return _RELEASE_TYPE_AKR;
                }
                else
                {
                    return null;
                }
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
                if (TAX_CATEGORY != null)
                {
                    if (_TAX_CATEGORY_AKCT == null)
                    {
                        _TAX_CATEGORY_AKCT = Context.AKCT.FindByCATEGORY(TAX_CATEGORY);
                    }
                    return _TAX_CATEGORY_AKCT;
                }
                else
                {
                    return null;
                }
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
                if (LOCATION != null)
                {
                    if (_LOCATION_AKL == null)
                    {
                        _LOCATION_AKL = Context.AKL.FindByLOCATION(LOCATION);
                    }
                    return _LOCATION_AKL;
                }
                else
                {
                    return null;
                }
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
                if (DEPARTMENT != null)
                {
                    if (_DEPARTMENT_AKD == null)
                    {
                        _DEPARTMENT_AKD = Context.AKD.FindByDEPARTMENT(DEPARTMENT);
                    }
                    return _DEPARTMENT_AKD;
                }
                else
                {
                    return null;
                }
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
                if (BRANCH != null)
                {
                    if (_BRANCH_AKB == null)
                    {
                        _BRANCH_AKB = Context.AKB.FindByBRANCH(BRANCH);
                    }
                    return _BRANCH_AKB;
                }
                else
                {
                    return null;
                }
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
                if (ORIG_SUPPLIER != null)
                {
                    if (_ORIG_SUPPLIER_CR == null)
                    {
                        _ORIG_SUPPLIER_CR = Context.CR.FindByCRKEY(ORIG_SUPPLIER);
                    }
                    return _ORIG_SUPPLIER_CR;
                }
                else
                {
                    return null;
                }
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
                if (CURR_SUPPLIER != null)
                {
                    if (_CURR_SUPPLIER_CR == null)
                    {
                        _CURR_SUPPLIER_CR = Context.CR.FindByCRKEY(CURR_SUPPLIER);
                    }
                    return _CURR_SUPPLIER_CR;
                }
                else
                {
                    return null;
                }
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
                if (PTE_GLCODE != null)
                {
                    if (_PTE_GLCODE_GL == null)
                    {
                        _PTE_GLCODE_GL = Context.GL.FindByCODE(PTE_GLCODE);
                    }
                    return _PTE_GLCODE_GL;
                }
                else
                {
                    return null;
                }
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
                if (AMETHOD != null)
                {
                    if (_AMETHOD_KADM == null)
                    {
                        _AMETHOD_KADM = Context.KADM.FindByKADMKEY(AMETHOD);
                    }
                    return _AMETHOD_KADM;
                }
                else
                {
                    return null;
                }
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
                if (TMETHOD != null)
                {
                    if (_TMETHOD_KADM == null)
                    {
                        _TMETHOD_KADM = Context.KADM.FindByKADMKEY(TMETHOD);
                    }
                    return _TMETHOD_KADM;
                }
                else
                {
                    return null;
                }
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
                if (COMPONENT_OF != null)
                {
                    if (_COMPONENT_OF_AR == null)
                    {
                        _COMPONENT_OF_AR = Context.AR.FindByARKEY(COMPONENT_OF);
                    }
                    return _COMPONENT_OF_AR;
                }
                else
                {
                    return null;
                }
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
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// AKK (Asset Key Holders) related entities by [AKK.CODE]-&gt;[AR.ARKEY]
        /// </summary>
        public IReadOnlyList<AKK> AKK_CODE
        {
            get
            {
                return Context.AR.FindAKKByCODE(ARKEY);
            }
        }

        /// <summary>
        /// AR (Assets) related entities by [AR.COMPONENT_OF]-&gt;[AR.ARKEY]
        /// </summary>
        public IReadOnlyList<AR> AR_COMPONENT_OF
        {
            get
            {
                return Context.AR.FindARByCOMPONENT_OF(ARKEY);
            }
        }

        /// <summary>
        /// ARF (Asset Financial Transactions) related entities by [ARF.CODE]-&gt;[AR.ARKEY]
        /// </summary>
        public IReadOnlyList<ARF> ARF_CODE
        {
            get
            {
                return Context.AR.FindARFByCODE(ARKEY);
            }
        }

        /// <summary>
        /// CRF (Creditor Financial Transaction) related entities by [CRF.ATKEY]-&gt;[AR.ARKEY]
        /// </summary>
        public IReadOnlyList<CRF> CRF_ATKEY
        {
            get
            {
                return Context.AR.FindCRFByATKEY(ARKEY);
            }
        }
#endregion
    }
}
