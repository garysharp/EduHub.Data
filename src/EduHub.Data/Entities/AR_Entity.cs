using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets
    /// </summary>
    public class AR_Entity : EntityBase
    {
#region Navigation Property Cache
        private AKC_Entity _CATEGORY_AKC;
        private AKT_Entity _ASSET_TYPE_AKT;
        private AKR_Entity _RELEASE_TYPE_AKR;
        private AKCT_Entity _TAX_CATEGORY_AKCT;
        private AKL_Entity _LOCATION_AKL;
        private AKD_Entity _DEPARTMENT_AKD;
        private AKB_Entity _BRANCH_AKB;
        private CR_Entity _ORIG_SUPPLIER_CR;
        private CR_Entity _CURR_SUPPLIER_CR;
        private GL_Entity _PTE_GLCODE_GL;
        private KADM_Entity _AMETHOD_KADM;
        private KADM_Entity _TMETHOD_KADM;
        private AR_Entity _COMPONENT_OF_AR;
        private SCI_Entity _CAMPUS_SCI;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string ARKEY { get; internal set; }
        /// <summary>
        /// Numeric SAMS number for DE&T export [Integer (32bit signed nullable): l]
        /// </summary>
        public int? ARNUMBER { get; internal set; }
        /// <summary>
        /// Title (Primary description) [Alphanumeric: a40]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Extra description of the asset [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION01 { get; internal set; }
        /// <summary>
        /// Extra description of the asset [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION02 { get; internal set; }
        /// <summary>
        /// Asset category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Asset type [Uppercase Alphanumeric: u2]
        /// </summary>
        public string ASSET_TYPE { get; internal set; }
        /// <summary>
        /// Asset Release Type [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RELEASE_TYPE { get; internal set; }
        /// <summary>
        /// Asset tax category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TAX_CATEGORY { get; internal set; }
        /// <summary>
        /// Asset locations [Uppercase Alphanumeric: u10]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Departments [Uppercase Alphanumeric: u10]
        /// </summary>
        public string DEPARTMENT { get; internal set; }
        /// <summary>
        /// Sub Category [Uppercase Alphanumeric: u10]
        /// </summary>
        public string BRANCH { get; internal set; }
        /// <summary>
        /// Lease start date [Date Time nullable: d]
        /// </summary>
        public DateTime? LEASE_START_DATE { get; internal set; }
        /// <summary>
        /// Lease end date [Date Time nullable: d]
        /// </summary>
        public DateTime? LEASE_END_DATE { get; internal set; }
        /// <summary>
        /// For leased items [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? LEASE_COST_MONTH { get; internal set; }
        /// <summary>
        /// Supplier [Uppercase Alphanumeric: u10]
        /// </summary>
        public string ORIG_SUPPLIER { get; internal set; }
        /// <summary>
        /// Default repairer [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CURR_SUPPLIER { get; internal set; }
        /// <summary>
        /// Invoice number of original acquisition [Alphanumeric: a10]
        /// </summary>
        public string ORIG_INVOICE_NO { get; internal set; }
        /// <summary>
        /// Invoice number of most recent purchase/addition [Alphanumeric: a10]
        /// </summary>
        public string LAST_INVOICE_NO { get; internal set; }
        /// <summary>
        /// Initial Purchase date [Date Time nullable: d]
        /// </summary>
        public DateTime? PURDATE { get; internal set; }
        /// <summary>
        /// Last addition date [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_ADDN_DATE { get; internal set; }
        /// <summary>
        /// Disposal date [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_DISP_DATE { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_GST_RECLAIM { get; internal set; }
        /// <summary>
        /// Last revaluation date [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_REVAL_DATE { get; internal set; }
        /// <summary>
        /// GL acct where pte use % of depn will be posted [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PTE_GLCODE { get; internal set; }
        /// <summary>
        /// Percentage of private use for accounting [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? PTE_USE_RATE { get; internal set; }
        /// <summary>
        /// Actuals:Open Bal - Cost ex GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_COST { get; internal set; }
        /// <summary>
        /// Actuals:Open Bal - Revaluations [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_REVALS { get; internal set; }
        /// <summary>
        /// Actual Disposals:Open Bal - Reductions in
        /// Original Cost ex GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_DISP_COST { get; internal set; }
        /// <summary>
        /// Actual Disposals:Open Bal - Reductions in
        /// Revaluation Adjustments [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_DISP_REVALS { get; internal set; }
        /// <summary>
        /// This year's additions [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_COST { get; internal set; }
        /// <summary>
        /// Actuals:This Year - Revaluation Adjustments [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_REVALS { get; internal set; }
        /// <summary>
        /// Actual Disposals:This Year - Reductions in [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_DISP_REVALS { get; internal set; }
        /// <summary>
        /// This Year - Reductions in Original Cost ex GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_DISP_COST { get; internal set; }
        /// <summary>
        /// ADep:Open Bal - Accum Depreciation [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_DEPN { get; internal set; }
        /// <summary>
        /// Private % of depn charged in prior years [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_PTE_DEPN { get; internal set; }
        /// <summary>
        /// ADep Disposals:Open bal -
        /// - Reductions in Accum Depreciation [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_DISP_DEPN { get; internal set; }
        /// <summary>
        /// ADep Disposals:Open Bal
        /// - Profit or Loss on Disposals [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_DISP_PROF { get; internal set; }
        /// <summary>
        /// ADep:This Year - Accum [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_DEPN { get; internal set; }
        /// <summary>
        /// Private % of depn charged this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_PTE_DEPN { get; internal set; }
        /// <summary>
        /// ADep Disposals:This Year
        /// - Reductions in Accum [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_DISP_DEPN { get; internal set; }
        /// <summary>
        /// ADep Disposals:This Year
        /// - Profit or Loss on Disposals [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_DISP_PROF { get; internal set; }
        /// <summary>
        /// Account  rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ARATE { get; internal set; }
        /// <summary>
        /// method [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AMETHOD { get; internal set; }
        /// <summary>
        /// Estimated Life in Units [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AEST_LIFE_UNITS { get; internal set; }
        /// <summary>
        /// Description of type of units used [Alphanumeric: a30]
        /// </summary>
        public string AUNITS_DESC { get; internal set; }
        /// <summary>
        /// Units used to date [Integer (32bit signed nullable): l]
        /// </summary>
        public int? AUNITS_TO_DATE { get; internal set; }
        /// <summary>
        /// indicator [Uppercase Alphanumeric: u1]
        /// </summary>
        public string AFLAG { get; internal set; }
        /// <summary>
        /// Start date for [Date Time nullable: d]
        /// </summary>
        public DateTime? ADEPN_START { get; internal set; }
        /// <summary>
        /// Date last depreciated for accounting [Date Time nullable: d]
        /// </summary>
        public DateTime? ADEPN_LAST_DATE { get; internal set; }
        /// <summary>
        /// Open Bal - Original GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_ORIG_GST { get; internal set; }
        /// <summary>
        /// Open Bal - Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_UNCL_GST { get; internal set; }
        /// <summary>
        /// Disposals:Open Bal-Reductions in Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_DISP_UNCL_GST { get; internal set; }
        /// <summary>
        /// Disposals:Open Bal-Reductions in Original GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? AOB_DISP_ORIG_GST { get; internal set; }
        /// <summary>
        /// This Year - Original GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_ORIG_GST { get; internal set; }
        /// <summary>
        /// This Year - Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_UNCL_GST { get; internal set; }
        /// <summary>
        /// Disposals:This Year Reductions in Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_DISP_UNCL_GST { get; internal set; }
        /// <summary>
        /// Disposals:This Year Reductions in Original GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? ATY_DISP_ORIG_GST { get; internal set; }
        /// <summary>
        /// TDep: Open Bal - Cost ex GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_COST { get; internal set; }
        /// <summary>
        /// TDep: Open Bal - Accum [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_DEPN { get; internal set; }
        /// <summary>
        /// Private % of tax depn charged in prior years [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_PTE_DEPN { get; internal set; }
        /// <summary>
        /// TDep: Open Bal - Reductions in Original Cost ex GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_DISP_COST { get; internal set; }
        /// <summary>
        /// TDep: Open Bal - Reductions in Accum [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_DISP_DEPN { get; internal set; }
        /// <summary>
        /// TDep: Open Bal - Profit/Loss on Disposals [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_DISP_PROF { get; internal set; }
        /// <summary>
        /// TDep: Open Bal - Gain on Disposals [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_DISP_GAIN { get; internal set; }
        /// <summary>
        /// TDep: This Year - Cost ex GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_COST { get; internal set; }
        /// <summary>
        /// TDep: This Year - Accum [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_DEPN { get; internal set; }
        /// <summary>
        /// Private % of depn charged this year [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_PTE_DEPN { get; internal set; }
        /// <summary>
        /// TDep: This Year - Reductions in Original Cost ex GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_DISP_COST { get; internal set; }
        /// <summary>
        /// TDep: This Year-Reductions in Accum [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_DISP_DEPN { get; internal set; }
        /// <summary>
        /// TDep: This Year - Profit/Loss on Disposals [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_DISP_PROF { get; internal set; }
        /// <summary>
        /// TDep: This Year - Gain on Disposals [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_DISP_GAIN { get; internal set; }
        /// <summary>
        /// Tax  rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRATE { get; internal set; }
        /// <summary>
        /// Depreciation method [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TMETHOD { get; internal set; }
        /// <summary>
        /// Depreciation indicator [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TFLAG { get; internal set; }
        /// <summary>
        /// Start date for depreciation [Date Time nullable: d]
        /// </summary>
        public DateTime? TDEPN_START { get; internal set; }
        /// <summary>
        /// Date last depreciated for tax [Date Time nullable: d]
        /// </summary>
        public DateTime? TDEPN_LAST_DATE { get; internal set; }
        /// <summary>
        /// Open Bal - Original GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_ORIG_GST { get; internal set; }
        /// <summary>
        /// Open Bal - Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_UNCL_GST { get; internal set; }
        /// <summary>
        /// Disposals:Open Bal-Reductions in Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_DISP_UNCL_GST { get; internal set; }
        /// <summary>
        /// Disposals:Open Bal-Reductions in Original GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TOB_DISP_ORIG_GST { get; internal set; }
        /// <summary>
        /// This Year - Original GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_ORIG_GST { get; internal set; }
        /// <summary>
        /// This Year - Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_UNCL_GST { get; internal set; }
        /// <summary>
        /// Disposals:This Year Reductions in Unclaimed GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_DISP_UNCL_GST { get; internal set; }
        /// <summary>
        /// Disposals:This Year Reductions in Original GST [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TTY_DISP_ORIG_GST { get; internal set; }
        /// <summary>
        /// Actuals:Open Bal - Quantity [Integer (16bit signed nullable): i]
        /// </summary>
        public short? OB_QTY { get; internal set; }
        /// <summary>
        /// Actual Disposals:Open Bal - Quantity [Integer (16bit signed nullable): i]
        /// </summary>
        public short? OB_DISP_QTY { get; internal set; }
        /// <summary>
        /// Actuals:This Year - Quantity [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TY_QTY { get; internal set; }
        /// <summary>
        /// Actual Disposals:This Year - Quantity [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TY_DISP_QTY { get; internal set; }
        /// <summary>
        /// Actuals:Open Bal - Proceeds on Disposal [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? OB_DISP_PROC { get; internal set; }
        /// <summary>
        /// Disposal price [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TY_DISP_PROC { get; internal set; }
        /// <summary>
        /// Last stocktake date [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_ST_DATE { get; internal set; }
        /// <summary>
        /// Last Date this asset was serviced [Date Time nullable: d]
        /// </summary>
        public DateTime? LAST_SVC_DATE { get; internal set; }
        /// <summary>
        /// Date for next service [Date Time nullable: d]
        /// </summary>
        public DateTime? NEXT_SVC_DATE { get; internal set; }
        /// <summary>
        /// Comments from last service [Memo: m]
        /// </summary>
        public string LAST_SVC_DETAILS { get; internal set; }
        /// <summary>
        /// Owner [Alphanumeric: a30]
        /// </summary>
        public string OWNER { get; internal set; }
        /// <summary>
        /// Expected life [Integer (16bit signed nullable): i]
        /// </summary>
        public short? EXPECTED_LIFE { get; internal set; }
        /// <summary>
        /// Warranty in months [Integer (16bit signed nullable): i]
        /// </summary>
        public short? WARRANTY { get; internal set; }
        /// <summary>
        /// Expiry date of warranty [Date Time nullable: d]
        /// </summary>
        public DateTime? WARRANTYEXP { get; internal set; }
        /// <summary>
        /// Serial number/Reg. number [Alphanumeric: a20]
        /// </summary>
        public string SERIAL { get; internal set; }
        /// <summary>
        /// Cleaning memo [Memo: m]
        /// </summary>
        public string CLEANING { get; internal set; }
        /// <summary>
        /// Hazard memo [Memo: m]
        /// </summary>
        public string HAZARD { get; internal set; }
        /// <summary>
        /// Site reference [Alphanumeric: a20]
        /// </summary>
        public string SITE_REFERENCE { get; internal set; }
        /// <summary>
        /// Extra details [Memo: m]
        /// </summary>
        public string EXTRA_DETAILS { get; internal set; }
        /// <summary>
        /// Asset that this is a component of, or related to [Uppercase Alphanumeric: u10]
        /// </summary>
        public string COMPONENT_OF { get; internal set; }
        /// <summary>
        /// Picture of asset [Picture (byte array): bp]
        /// </summary>
        public byte[] ASSET_PIC { get; internal set; }
        /// <summary>
        /// Campus number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CATEGORY] => [AKC_Entity].[CATEGORY]
        /// Asset category
        /// </summary>
        public AKC_Entity CATEGORY_AKC {
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
        /// Navigation property for [ASSET_TYPE] => [AKT_Entity].[AKTKEY]
        /// Asset type
        /// </summary>
        public AKT_Entity ASSET_TYPE_AKT {
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
        /// Navigation property for [RELEASE_TYPE] => [AKR_Entity].[AKRKEY]
        /// Asset Release Type
        /// </summary>
        public AKR_Entity RELEASE_TYPE_AKR {
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
        /// Navigation property for [TAX_CATEGORY] => [AKCT_Entity].[CATEGORY]
        /// Asset tax category
        /// </summary>
        public AKCT_Entity TAX_CATEGORY_AKCT {
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
        /// Navigation property for [LOCATION] => [AKL_Entity].[LOCATION]
        /// Asset locations
        /// </summary>
        public AKL_Entity LOCATION_AKL {
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
        /// Navigation property for [DEPARTMENT] => [AKD_Entity].[DEPARTMENT]
        /// Departments
        /// </summary>
        public AKD_Entity DEPARTMENT_AKD {
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
        /// Navigation property for [BRANCH] => [AKB_Entity].[BRANCH]
        /// Sub Category
        /// </summary>
        public AKB_Entity BRANCH_AKB {
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
        /// Navigation property for [ORIG_SUPPLIER] => [CR_Entity].[CRKEY]
        /// Supplier
        /// </summary>
        public CR_Entity ORIG_SUPPLIER_CR {
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
        /// Navigation property for [CURR_SUPPLIER] => [CR_Entity].[CRKEY]
        /// Default repairer
        /// </summary>
        public CR_Entity CURR_SUPPLIER_CR {
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
        /// Navigation property for [PTE_GLCODE] => [GL_Entity].[CODE]
        /// GL acct where pte use % of depn will be posted
        /// </summary>
        public GL_Entity PTE_GLCODE_GL {
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
        /// Navigation property for [AMETHOD] => [KADM_Entity].[KADMKEY]
        /// method
        /// </summary>
        public KADM_Entity AMETHOD_KADM {
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
        /// Navigation property for [TMETHOD] => [KADM_Entity].[KADMKEY]
        /// Depreciation method
        /// </summary>
        public KADM_Entity TMETHOD_KADM {
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
        /// Navigation property for [COMPONENT_OF] => [AR_Entity].[ARKEY]
        /// Asset that this is a component of, or related to
        /// </summary>
        public AR_Entity COMPONENT_OF_AR {
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
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus number
        /// </summary>
        public SCI_Entity CAMPUS_SCI {
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
#endregion
    }
}
