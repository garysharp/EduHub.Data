using System;
using System.Collections.Generic;
using EduHub.Data.Entities;

namespace EduHub.Data
{
    /// <summary>
    /// eduHub Data Context
    /// </summary>
    public class EduHubContext : EduHubContextBase
    {
#region Set Fields
        private A_DECRYP_DataSet _A_DECRYP;
        private AKB_DataSet _AKB;
        private AKC_DataSet _AKC;
        private AKCT_DataSet _AKCT;
        private AKD_DataSet _AKD;
        private AKK_DataSet _AKK;
        private AKL_DataSet _AKL;
        private AKR_DataSet _AKR;
        private AKT_DataSet _AKT;
        private AR_DataSet _AR;
        private ARF_DataSet _ARF;
        private BKH_DataSet _BKH;
        private BKHR_DataSet _BKHR;
        private BPAY_DAT_DataSet _BPAY_DAT;
        private CR_DataSet _CR;
        private CRF_DataSet _CRF;
        private CRFTC_DataSet _CRFTC;
        private DF_DataSet _DF;
        private DF_TFR_DataSet _DF_TFR;
        private DFB_DataSet _DFB;
        private DFF_DataSet _DFF;
        private DFHI_DataSet _DFHI;
        private DFVT_DataSet _DFVT;
        private DR_DataSet _DR;
        private DRF_DataSet _DRF;
        private FDT_EXP_DataSet _FDT_EXP;
        private FDT_IMP_DataSet _FDT_IMP;
        private FER_FDT_DataSet _FER_FDT;
        private FINHIST_DataSet _FINHIST;
        private GL_DataSet _GL;
        private GLBANK_DataSet _GLBANK;
        private GLBUDG_DataSet _GLBUDG;
        private GLCF_DataSet _GLCF;
        private GLCFPREV_DataSet _GLCFPREV;
        private GLF_DataSet _GLF;
        private GLFBANK_DataSet _GLFBANK;
        private GLFBUDG_DataSet _GLFBUDG;
        private GLFPREV_DataSet _GLFPREV;
        private GLPREV_DataSet _GLPREV;
        private KAB_DataSet _KAB;
        private KAD_DataSet _KAD;
        private KADM_DataSet _KADM;
        private KAM_DataSet _KAM;
        private KAP_DataSet _KAP;
        private KBANK_DataSet _KBANK;
        private KBP_DataSet _KBP;
        private KBPT_DataSet _KBPT;
        private KCB_DataSet _KCB;
        private KCC_DataSet _KCC;
        private KCD_DataSet _KCD;
        private KCD_TFR_DataSet _KCD_TFR;
        private KCI_DataSet _KCI;
        private KCM_DataSet _KCM;
        private KCM_TFR_DataSet _KCM_TFR;
        private KCOHORT_DataSet _KCOHORT;
        private KCR_DataSet _KCR;
        private KCT_DataSet _KCT;
        private KCV_DataSet _KCV;
        private KCY_DataSet _KCY;
        private KDELETE_DataSet _KDELETE;
        private KDI_DataSet _KDI;
        private KDO_DataSet _KDO;
        private KEMA_DataSet _KEMA;
        private KERROR_DataSet _KERROR;
        private KFTC_DataSet _KFTC;
        private KGC_DataSet _KGC;
        private KGCHI_DataSet _KGCHI;
        private KGD_DataSet _KGD;
        private KGG_DataSet _KGG;
        private KGH_DataSet _KGH;
        private KGL_DataSet _KGL;
        private KGLINIT_DataSet _KGLINIT;
        private KGLPROG_DataSet _KGLPROG;
        private KGLSUB_DataSet _KGLSUB;
        private KGLT_DataSet _KGLT;
        private KGR_DataSet _KGR;
        private KGST_DataSet _KGST;
        private KGT_DataSet _KGT;
        private KGW_DataSet _KGW;
        private KLOG_DataSet _KLOG;
        private KN_DataSet _KN;
        private KNFS_DataSet _KNFS;
        private KPC_DataSet _KPC;
        private KPCL_DataSet _KPCL;
        private KPCR_DataSet _KPCR;
        private KPEC_DataSet _KPEC;
        private KPN_DataSet _KPN;
        private KPRMS_DataSet _KPRMS;
        private KREPORT_DataSet _KREPORT;
        private KROLE_DataSet _KROLE;
        private KSA_DataSet _KSA;
        private KSC_DataSet _KSC;
        private KSF_DataSet _KSF;
        private KSI_DataSet _KSI;
        private KSQ_DataSet _KSQ;
        private KTIE_DataSet _KTIE;
        private KTRCMP_DataSet _KTRCMP;
        private OSCS_DataSet _OSCS;
        private PC_DataSet _PC;
        private PD_DataSet _PD;
        private PE_DataSet _PE;
        private PEF_DataSet _PEF;
        private PEFH_DataSet _PEFH;
        private PELA_DataSet _PELA;
        private PELD_DataSet _PELD;
        private PEM_DataSet _PEM;
        private PEPM_DataSet _PEPM;
        private PEPS_DataSet _PEPS;
        private PEPU_DataSet _PEPU;
        private PEPUH_DataSet _PEPUH;
        private PEPY_DataSet _PEPY;
        private PESH_DataSet _PESH;
        private PESP_DataSet _PESP;
        private PETP_DataSet _PETP;
        private PF_DataSet _PF;
        private PG_DataSet _PG;
        private PI_DataSet _PI;
        private PILI_DataSet _PILI;
        private PLC_DataSet _PLC;
        private PLG_DataSet _PLG;
        private PLT_DataSet _PLT;
        private PML_DataSet _PML;
        private PML_NEW_DataSet _PML_NEW;
        private PN_DataSet _PN;
        private PPD_DataSet _PPD;
        private PPS_DataSet _PPS;
        private PS_DataSet _PS;
        private PSA_DataSet _PSA;
        private PSF_DataSet _PSF;
        private PX_DataSet _PX;
        private PX_NEW_DataSet _PX_NEW;
        private QB_DataSet _QB;
        private QS_DataSet _QS;
        private SA_DataSet _SA;
        private SAB_DataSet _SAB;
        private SABT_DataSet _SABT;
        private SACAG_DataSet _SACAG;
        private SAD_DataSet _SAD;
        private SADAG_DataSet _SADAG;
        private SADP_DataSet _SADP;
        private SADW_DataSet _SADW;
        private SAI_DataSet _SAI;
        private SAII_DataSet _SAII;
        private SAIM_DataSet _SAIM;
        private SAM_DataSet _SAM;
        private SAMA_DataSet _SAMA;
        private SAP_DataSet _SAP;
        private SC_DataSet _SC;
        private SCA_DataSet _SCA;
        private SCAM_DataSet _SCAM;
        private SCEN_ACL_DataSet _SCEN_ACL;
        private SCEN_ACV_DataSet _SCEN_ACV;
        private SCEN_APP_DataSet _SCEN_APP;
        private SCEN_ASE_DataSet _SCEN_ASE;
        private SCEN_AST_DataSet _SCEN_AST;
        private SCEN_ASV_DataSet _SCEN_ASV;
        private SCEN_CL_DataSet _SCEN_CL;
        private SCEN_CLV_DataSet _SCEN_CLV;
        private SCEN_CVT_DataSet _SCEN_CVT;
        private SCEN_RFD_DataSet _SCEN_RFD;
        private SCEN_RPT_DataSet _SCEN_RPT;
        private SCEN_RTN_DataSet _SCEN_RTN;
        private SCEN_SCD_DataSet _SCEN_SCD;
        private SCEN_ST_DataSet _SCEN_ST;
        private SCEN_STE_DataSet _SCEN_STE;
        private SCEN_STV_DataSet _SCEN_STV;
        private SCEN_SVT_DataSet _SCEN_SVT;
        private SCI_DataSet _SCI;
        private SCL_DataSet _SCL;
        private SCSF_DataSet _SCSF;
        private SCSFAG_DataSet _SCSFAG;
        private SDFC_DataSet _SDFC;
        private SDG_DataSet _SDG;
        private SDGM_DataSet _SDGM;
        private SDP_DataSet _SDP;
        private SDPA_DataSet _SDPA;
        private SEC_ELOG_DataSet _SEC_ELOG;
        private SEC_LLOG_DataSet _SEC_LLOG;
        private SEC_MSG_DataSet _SEC_MSG;
        private SEC_URL_DataSet _SEC_URL;
        private SEC_USR_DataSet _SEC_USR;
        private SF_DataSet _SF;
        private SFAQ_DataSet _SFAQ;
        private SFAV_DataSet _SFAV;
        private SFQA_DataSet _SFQA;
        private SG_DataSet _SG;
        private SGAM_DataSet _SGAM;
        private SGHG_DataSet _SGHG;
        private SGM_DataSet _SGM;
        private SGMA_DataSet _SGMA;
        private SGSC_DataSet _SGSC;
        private SGSG_DataSet _SGSG;
        private SGTRX_DataSet _SGTRX;
        private SID_DataSet _SID;
        private SIDV_DataSet _SIDV;
        private SIRH_DataSet _SIRH;
        private SK_HRMS_DataSet _SK_HRMS;
        private SK_HRMST_DataSet _SK_HRMST;
        private SKGS_DataSet _SKGS;
        private SM_DataSet _SM;
        private SMAQ_DataSet _SMAQ;
        private SMAV_DataSet _SMAV;
        private SMC_DataSet _SMC;
        private SMC_TFR_DataSet _SMC_TFR;
        private SMCD_DataSet _SMCD;
        private SMGROUP_DataSet _SMGROUP;
        private SPEMAIL_DataSet _SPEMAIL;
        private SPEPRINT_DataSet _SPEPRINT;
        private SPOUT_DataSet _SPOUT;
        private SPU_DataSet _SPU;
        private SRAG_DataSet _SRAG;
        private SS_DataSet _SS;
        private SSHG_DataSet _SSHG;
        private ST_DataSet _ST;
        private ST_TFR_DataSet _ST_TFR;
        private ST_TFRIO_DataSet _ST_TFRIO;
        private STBT_DataSet _STBT;
        private STMA_DataSet _STMA;
        private STMB_DataSet _STMB;
        private STPO_DataSet _STPO;
        private STPT_DataSet _STPT;
        private STRA_DataSet _STRA;
        private STRE_DataSet _STRE;
        private STSB_DataSet _STSB;
        private STSP_DataSet _STSP;
        private STTRIPS_DataSet _STTRIPS;
        private STVDI_DataSet _STVDI;
        private STVDO_DataSet _STVDO;
        private SU_DataSet _SU;
        private SUBL_DataSet _SUBL;
        private SUPR_DataSet _SUPR;
        private SVAG_DataSet _SVAG;
        private SXAB_DataSet _SXAB;
        private SXABCONV_DataSet _SXABCONV;
        private SXAS_DataSet _SXAS;
        private SXHI_DataSet _SXHI;
        private TC_DataSet _TC;
        private TCAT_DataSet _TCAT;
        private TCTB_DataSet _TCTB;
        private TCTD_DataSet _TCTD;
        private TCTQ_DataSet _TCTQ;
        private TCTR_DataSet _TCTR;
        private TE_DataSet _TE;
        private TEC_DataSet _TEC;
        private TETE_DataSet _TETE;
        private TETN_DataSet _TETN;
        private TH_DataSet _TH;
        private THTN_DataSet _THTN;
        private THTQ_DataSet _THTQ;
        private TRPMODE_DataSet _TRPMODE;
        private TRPROUT_DataSet _TRPROUT;
        private TRSTACC_DataSet _TRSTACC;
        private TT_DataSet _TT;
        private TTEF_DataSet _TTEF;
        private TTEI_DataSet _TTEI;
        private TTEP_DataSet _TTEP;
        private TTES_DataSet _TTES;
        private TTEX_DataSet _TTEX;
        private TTTG_DataSet _TTTG;
        private TXAS_DataSet _TXAS;
        private TXHG_DataSet _TXHG;
        private UM_DataSet _UM;
        private UM_TFR_DataSet _UM_TFR;
#endregion

        /// <summary>
        /// Creates an EduHubContext
        /// </summary>
        /// <param name="EduHubDirectory">Directory which contains the eduHub .csv data sets.</param>
        /// <param name="EduHubSiteIdentifier">Data set suffix for each .csv file</param>
        /// <exception cref="ArgumentException">eduHub Directory does not exist or has no valid data sets</exception>
        public EduHubContext(string EduHubDirectory, string EduHubSiteIdentifier)
            : base (EduHubDirectory, EduHubSiteIdentifier)
        {
            _A_DECRYP = new A_DECRYP_DataSet(this);
            _AKB = new AKB_DataSet(this);
            _AKC = new AKC_DataSet(this);
            _AKCT = new AKCT_DataSet(this);
            _AKD = new AKD_DataSet(this);
            _AKK = new AKK_DataSet(this);
            _AKL = new AKL_DataSet(this);
            _AKR = new AKR_DataSet(this);
            _AKT = new AKT_DataSet(this);
            _AR = new AR_DataSet(this);
            _ARF = new ARF_DataSet(this);
            _BKH = new BKH_DataSet(this);
            _BKHR = new BKHR_DataSet(this);
            _BPAY_DAT = new BPAY_DAT_DataSet(this);
            _CR = new CR_DataSet(this);
            _CRF = new CRF_DataSet(this);
            _CRFTC = new CRFTC_DataSet(this);
            _DF = new DF_DataSet(this);
            _DF_TFR = new DF_TFR_DataSet(this);
            _DFB = new DFB_DataSet(this);
            _DFF = new DFF_DataSet(this);
            _DFHI = new DFHI_DataSet(this);
            _DFVT = new DFVT_DataSet(this);
            _DR = new DR_DataSet(this);
            _DRF = new DRF_DataSet(this);
            _FDT_EXP = new FDT_EXP_DataSet(this);
            _FDT_IMP = new FDT_IMP_DataSet(this);
            _FER_FDT = new FER_FDT_DataSet(this);
            _FINHIST = new FINHIST_DataSet(this);
            _GL = new GL_DataSet(this);
            _GLBANK = new GLBANK_DataSet(this);
            _GLBUDG = new GLBUDG_DataSet(this);
            _GLCF = new GLCF_DataSet(this);
            _GLCFPREV = new GLCFPREV_DataSet(this);
            _GLF = new GLF_DataSet(this);
            _GLFBANK = new GLFBANK_DataSet(this);
            _GLFBUDG = new GLFBUDG_DataSet(this);
            _GLFPREV = new GLFPREV_DataSet(this);
            _GLPREV = new GLPREV_DataSet(this);
            _KAB = new KAB_DataSet(this);
            _KAD = new KAD_DataSet(this);
            _KADM = new KADM_DataSet(this);
            _KAM = new KAM_DataSet(this);
            _KAP = new KAP_DataSet(this);
            _KBANK = new KBANK_DataSet(this);
            _KBP = new KBP_DataSet(this);
            _KBPT = new KBPT_DataSet(this);
            _KCB = new KCB_DataSet(this);
            _KCC = new KCC_DataSet(this);
            _KCD = new KCD_DataSet(this);
            _KCD_TFR = new KCD_TFR_DataSet(this);
            _KCI = new KCI_DataSet(this);
            _KCM = new KCM_DataSet(this);
            _KCM_TFR = new KCM_TFR_DataSet(this);
            _KCOHORT = new KCOHORT_DataSet(this);
            _KCR = new KCR_DataSet(this);
            _KCT = new KCT_DataSet(this);
            _KCV = new KCV_DataSet(this);
            _KCY = new KCY_DataSet(this);
            _KDELETE = new KDELETE_DataSet(this);
            _KDI = new KDI_DataSet(this);
            _KDO = new KDO_DataSet(this);
            _KEMA = new KEMA_DataSet(this);
            _KERROR = new KERROR_DataSet(this);
            _KFTC = new KFTC_DataSet(this);
            _KGC = new KGC_DataSet(this);
            _KGCHI = new KGCHI_DataSet(this);
            _KGD = new KGD_DataSet(this);
            _KGG = new KGG_DataSet(this);
            _KGH = new KGH_DataSet(this);
            _KGL = new KGL_DataSet(this);
            _KGLINIT = new KGLINIT_DataSet(this);
            _KGLPROG = new KGLPROG_DataSet(this);
            _KGLSUB = new KGLSUB_DataSet(this);
            _KGLT = new KGLT_DataSet(this);
            _KGR = new KGR_DataSet(this);
            _KGST = new KGST_DataSet(this);
            _KGT = new KGT_DataSet(this);
            _KGW = new KGW_DataSet(this);
            _KLOG = new KLOG_DataSet(this);
            _KN = new KN_DataSet(this);
            _KNFS = new KNFS_DataSet(this);
            _KPC = new KPC_DataSet(this);
            _KPCL = new KPCL_DataSet(this);
            _KPCR = new KPCR_DataSet(this);
            _KPEC = new KPEC_DataSet(this);
            _KPN = new KPN_DataSet(this);
            _KPRMS = new KPRMS_DataSet(this);
            _KREPORT = new KREPORT_DataSet(this);
            _KROLE = new KROLE_DataSet(this);
            _KSA = new KSA_DataSet(this);
            _KSC = new KSC_DataSet(this);
            _KSF = new KSF_DataSet(this);
            _KSI = new KSI_DataSet(this);
            _KSQ = new KSQ_DataSet(this);
            _KTIE = new KTIE_DataSet(this);
            _KTRCMP = new KTRCMP_DataSet(this);
            _OSCS = new OSCS_DataSet(this);
            _PC = new PC_DataSet(this);
            _PD = new PD_DataSet(this);
            _PE = new PE_DataSet(this);
            _PEF = new PEF_DataSet(this);
            _PEFH = new PEFH_DataSet(this);
            _PELA = new PELA_DataSet(this);
            _PELD = new PELD_DataSet(this);
            _PEM = new PEM_DataSet(this);
            _PEPM = new PEPM_DataSet(this);
            _PEPS = new PEPS_DataSet(this);
            _PEPU = new PEPU_DataSet(this);
            _PEPUH = new PEPUH_DataSet(this);
            _PEPY = new PEPY_DataSet(this);
            _PESH = new PESH_DataSet(this);
            _PESP = new PESP_DataSet(this);
            _PETP = new PETP_DataSet(this);
            _PF = new PF_DataSet(this);
            _PG = new PG_DataSet(this);
            _PI = new PI_DataSet(this);
            _PILI = new PILI_DataSet(this);
            _PLC = new PLC_DataSet(this);
            _PLG = new PLG_DataSet(this);
            _PLT = new PLT_DataSet(this);
            _PML = new PML_DataSet(this);
            _PML_NEW = new PML_NEW_DataSet(this);
            _PN = new PN_DataSet(this);
            _PPD = new PPD_DataSet(this);
            _PPS = new PPS_DataSet(this);
            _PS = new PS_DataSet(this);
            _PSA = new PSA_DataSet(this);
            _PSF = new PSF_DataSet(this);
            _PX = new PX_DataSet(this);
            _PX_NEW = new PX_NEW_DataSet(this);
            _QB = new QB_DataSet(this);
            _QS = new QS_DataSet(this);
            _SA = new SA_DataSet(this);
            _SAB = new SAB_DataSet(this);
            _SABT = new SABT_DataSet(this);
            _SACAG = new SACAG_DataSet(this);
            _SAD = new SAD_DataSet(this);
            _SADAG = new SADAG_DataSet(this);
            _SADP = new SADP_DataSet(this);
            _SADW = new SADW_DataSet(this);
            _SAI = new SAI_DataSet(this);
            _SAII = new SAII_DataSet(this);
            _SAIM = new SAIM_DataSet(this);
            _SAM = new SAM_DataSet(this);
            _SAMA = new SAMA_DataSet(this);
            _SAP = new SAP_DataSet(this);
            _SC = new SC_DataSet(this);
            _SCA = new SCA_DataSet(this);
            _SCAM = new SCAM_DataSet(this);
            _SCEN_ACL = new SCEN_ACL_DataSet(this);
            _SCEN_ACV = new SCEN_ACV_DataSet(this);
            _SCEN_APP = new SCEN_APP_DataSet(this);
            _SCEN_ASE = new SCEN_ASE_DataSet(this);
            _SCEN_AST = new SCEN_AST_DataSet(this);
            _SCEN_ASV = new SCEN_ASV_DataSet(this);
            _SCEN_CL = new SCEN_CL_DataSet(this);
            _SCEN_CLV = new SCEN_CLV_DataSet(this);
            _SCEN_CVT = new SCEN_CVT_DataSet(this);
            _SCEN_RFD = new SCEN_RFD_DataSet(this);
            _SCEN_RPT = new SCEN_RPT_DataSet(this);
            _SCEN_RTN = new SCEN_RTN_DataSet(this);
            _SCEN_SCD = new SCEN_SCD_DataSet(this);
            _SCEN_ST = new SCEN_ST_DataSet(this);
            _SCEN_STE = new SCEN_STE_DataSet(this);
            _SCEN_STV = new SCEN_STV_DataSet(this);
            _SCEN_SVT = new SCEN_SVT_DataSet(this);
            _SCI = new SCI_DataSet(this);
            _SCL = new SCL_DataSet(this);
            _SCSF = new SCSF_DataSet(this);
            _SCSFAG = new SCSFAG_DataSet(this);
            _SDFC = new SDFC_DataSet(this);
            _SDG = new SDG_DataSet(this);
            _SDGM = new SDGM_DataSet(this);
            _SDP = new SDP_DataSet(this);
            _SDPA = new SDPA_DataSet(this);
            _SEC_ELOG = new SEC_ELOG_DataSet(this);
            _SEC_LLOG = new SEC_LLOG_DataSet(this);
            _SEC_MSG = new SEC_MSG_DataSet(this);
            _SEC_URL = new SEC_URL_DataSet(this);
            _SEC_USR = new SEC_USR_DataSet(this);
            _SF = new SF_DataSet(this);
            _SFAQ = new SFAQ_DataSet(this);
            _SFAV = new SFAV_DataSet(this);
            _SFQA = new SFQA_DataSet(this);
            _SG = new SG_DataSet(this);
            _SGAM = new SGAM_DataSet(this);
            _SGHG = new SGHG_DataSet(this);
            _SGM = new SGM_DataSet(this);
            _SGMA = new SGMA_DataSet(this);
            _SGSC = new SGSC_DataSet(this);
            _SGSG = new SGSG_DataSet(this);
            _SGTRX = new SGTRX_DataSet(this);
            _SID = new SID_DataSet(this);
            _SIDV = new SIDV_DataSet(this);
            _SIRH = new SIRH_DataSet(this);
            _SK_HRMS = new SK_HRMS_DataSet(this);
            _SK_HRMST = new SK_HRMST_DataSet(this);
            _SKGS = new SKGS_DataSet(this);
            _SM = new SM_DataSet(this);
            _SMAQ = new SMAQ_DataSet(this);
            _SMAV = new SMAV_DataSet(this);
            _SMC = new SMC_DataSet(this);
            _SMC_TFR = new SMC_TFR_DataSet(this);
            _SMCD = new SMCD_DataSet(this);
            _SMGROUP = new SMGROUP_DataSet(this);
            _SPEMAIL = new SPEMAIL_DataSet(this);
            _SPEPRINT = new SPEPRINT_DataSet(this);
            _SPOUT = new SPOUT_DataSet(this);
            _SPU = new SPU_DataSet(this);
            _SRAG = new SRAG_DataSet(this);
            _SS = new SS_DataSet(this);
            _SSHG = new SSHG_DataSet(this);
            _ST = new ST_DataSet(this);
            _ST_TFR = new ST_TFR_DataSet(this);
            _ST_TFRIO = new ST_TFRIO_DataSet(this);
            _STBT = new STBT_DataSet(this);
            _STMA = new STMA_DataSet(this);
            _STMB = new STMB_DataSet(this);
            _STPO = new STPO_DataSet(this);
            _STPT = new STPT_DataSet(this);
            _STRA = new STRA_DataSet(this);
            _STRE = new STRE_DataSet(this);
            _STSB = new STSB_DataSet(this);
            _STSP = new STSP_DataSet(this);
            _STTRIPS = new STTRIPS_DataSet(this);
            _STVDI = new STVDI_DataSet(this);
            _STVDO = new STVDO_DataSet(this);
            _SU = new SU_DataSet(this);
            _SUBL = new SUBL_DataSet(this);
            _SUPR = new SUPR_DataSet(this);
            _SVAG = new SVAG_DataSet(this);
            _SXAB = new SXAB_DataSet(this);
            _SXABCONV = new SXABCONV_DataSet(this);
            _SXAS = new SXAS_DataSet(this);
            _SXHI = new SXHI_DataSet(this);
            _TC = new TC_DataSet(this);
            _TCAT = new TCAT_DataSet(this);
            _TCTB = new TCTB_DataSet(this);
            _TCTD = new TCTD_DataSet(this);
            _TCTQ = new TCTQ_DataSet(this);
            _TCTR = new TCTR_DataSet(this);
            _TE = new TE_DataSet(this);
            _TEC = new TEC_DataSet(this);
            _TETE = new TETE_DataSet(this);
            _TETN = new TETN_DataSet(this);
            _TH = new TH_DataSet(this);
            _THTN = new THTN_DataSet(this);
            _THTQ = new THTQ_DataSet(this);
            _TRPMODE = new TRPMODE_DataSet(this);
            _TRPROUT = new TRPROUT_DataSet(this);
            _TRSTACC = new TRSTACC_DataSet(this);
            _TT = new TT_DataSet(this);
            _TTEF = new TTEF_DataSet(this);
            _TTEI = new TTEI_DataSet(this);
            _TTEP = new TTEP_DataSet(this);
            _TTES = new TTES_DataSet(this);
            _TTEX = new TTEX_DataSet(this);
            _TTTG = new TTTG_DataSet(this);
            _TXAS = new TXAS_DataSet(this);
            _TXHG = new TXHG_DataSet(this);
            _UM = new UM_DataSet(this);
            _UM_TFR = new UM_TFR_DataSet(this);
        }

        /// <summary>
        /// Creates an EduHubContext with a dynamically determined site identifier
        /// </summary>
        /// <param name="EduHubDirectory">Directory which contains the eduHub .csv data sets.</param>
        /// <exception cref="ArgumentException">eduHub Directory does not exist, has no valid data sets or contains multiple data sets</exception>
        public EduHubContext(string EduHubDirectory)
            : this(EduHubDirectory, null)
        {
        }

        /// <summary>
        /// Creates an EduHubContext with the default directory and dynamically determined site identifier
        /// </summary>
        /// <exception cref="ArgumentException">Default eduHub Directory does not exist, has no valid data sets or contains multiple data sets</exception>
        public EduHubContext()
            : this(null, null)
        {
        }

        /// <summary>
        /// Names of all Data Sets
        /// </summary>
        public override IEnumerable<string> SetNames
        {
            get
            {
                yield return "A_DECRYP";
                yield return "AKB";
                yield return "AKC";
                yield return "AKCT";
                yield return "AKD";
                yield return "AKK";
                yield return "AKL";
                yield return "AKR";
                yield return "AKT";
                yield return "AR";
                yield return "ARF";
                yield return "BKH";
                yield return "BKHR";
                yield return "BPAY_DAT";
                yield return "CR";
                yield return "CRF";
                yield return "CRFTC";
                yield return "DF";
                yield return "DF_TFR";
                yield return "DFB";
                yield return "DFF";
                yield return "DFHI";
                yield return "DFVT";
                yield return "DR";
                yield return "DRF";
                yield return "FDT_EXP";
                yield return "FDT_IMP";
                yield return "FER_FDT";
                yield return "FINHIST";
                yield return "GL";
                yield return "GLBANK";
                yield return "GLBUDG";
                yield return "GLCF";
                yield return "GLCFPREV";
                yield return "GLF";
                yield return "GLFBANK";
                yield return "GLFBUDG";
                yield return "GLFPREV";
                yield return "GLPREV";
                yield return "KAB";
                yield return "KAD";
                yield return "KADM";
                yield return "KAM";
                yield return "KAP";
                yield return "KBANK";
                yield return "KBP";
                yield return "KBPT";
                yield return "KCB";
                yield return "KCC";
                yield return "KCD";
                yield return "KCD_TFR";
                yield return "KCI";
                yield return "KCM";
                yield return "KCM_TFR";
                yield return "KCOHORT";
                yield return "KCR";
                yield return "KCT";
                yield return "KCV";
                yield return "KCY";
                yield return "KDELETE";
                yield return "KDI";
                yield return "KDO";
                yield return "KEMA";
                yield return "KERROR";
                yield return "KFTC";
                yield return "KGC";
                yield return "KGCHI";
                yield return "KGD";
                yield return "KGG";
                yield return "KGH";
                yield return "KGL";
                yield return "KGLINIT";
                yield return "KGLPROG";
                yield return "KGLSUB";
                yield return "KGLT";
                yield return "KGR";
                yield return "KGST";
                yield return "KGT";
                yield return "KGW";
                yield return "KLOG";
                yield return "KN";
                yield return "KNFS";
                yield return "KPC";
                yield return "KPCL";
                yield return "KPCR";
                yield return "KPEC";
                yield return "KPN";
                yield return "KPRMS";
                yield return "KREPORT";
                yield return "KROLE";
                yield return "KSA";
                yield return "KSC";
                yield return "KSF";
                yield return "KSI";
                yield return "KSQ";
                yield return "KTIE";
                yield return "KTRCMP";
                yield return "OSCS";
                yield return "PC";
                yield return "PD";
                yield return "PE";
                yield return "PEF";
                yield return "PEFH";
                yield return "PELA";
                yield return "PELD";
                yield return "PEM";
                yield return "PEPM";
                yield return "PEPS";
                yield return "PEPU";
                yield return "PEPUH";
                yield return "PEPY";
                yield return "PESH";
                yield return "PESP";
                yield return "PETP";
                yield return "PF";
                yield return "PG";
                yield return "PI";
                yield return "PILI";
                yield return "PLC";
                yield return "PLG";
                yield return "PLT";
                yield return "PML";
                yield return "PML_NEW";
                yield return "PN";
                yield return "PPD";
                yield return "PPS";
                yield return "PS";
                yield return "PSA";
                yield return "PSF";
                yield return "PX";
                yield return "PX_NEW";
                yield return "QB";
                yield return "QS";
                yield return "SA";
                yield return "SAB";
                yield return "SABT";
                yield return "SACAG";
                yield return "SAD";
                yield return "SADAG";
                yield return "SADP";
                yield return "SADW";
                yield return "SAI";
                yield return "SAII";
                yield return "SAIM";
                yield return "SAM";
                yield return "SAMA";
                yield return "SAP";
                yield return "SC";
                yield return "SCA";
                yield return "SCAM";
                yield return "SCEN_ACL";
                yield return "SCEN_ACV";
                yield return "SCEN_APP";
                yield return "SCEN_ASE";
                yield return "SCEN_AST";
                yield return "SCEN_ASV";
                yield return "SCEN_CL";
                yield return "SCEN_CLV";
                yield return "SCEN_CVT";
                yield return "SCEN_RFD";
                yield return "SCEN_RPT";
                yield return "SCEN_RTN";
                yield return "SCEN_SCD";
                yield return "SCEN_ST";
                yield return "SCEN_STE";
                yield return "SCEN_STV";
                yield return "SCEN_SVT";
                yield return "SCI";
                yield return "SCL";
                yield return "SCSF";
                yield return "SCSFAG";
                yield return "SDFC";
                yield return "SDG";
                yield return "SDGM";
                yield return "SDP";
                yield return "SDPA";
                yield return "SEC_ELOG";
                yield return "SEC_LLOG";
                yield return "SEC_MSG";
                yield return "SEC_URL";
                yield return "SEC_USR";
                yield return "SF";
                yield return "SFAQ";
                yield return "SFAV";
                yield return "SFQA";
                yield return "SG";
                yield return "SGAM";
                yield return "SGHG";
                yield return "SGM";
                yield return "SGMA";
                yield return "SGSC";
                yield return "SGSG";
                yield return "SGTRX";
                yield return "SID";
                yield return "SIDV";
                yield return "SIRH";
                yield return "SK_HRMS";
                yield return "SK_HRMST";
                yield return "SKGS";
                yield return "SM";
                yield return "SMAQ";
                yield return "SMAV";
                yield return "SMC";
                yield return "SMC_TFR";
                yield return "SMCD";
                yield return "SMGROUP";
                yield return "SPEMAIL";
                yield return "SPEPRINT";
                yield return "SPOUT";
                yield return "SPU";
                yield return "SRAG";
                yield return "SS";
                yield return "SSHG";
                yield return "ST";
                yield return "ST_TFR";
                yield return "ST_TFRIO";
                yield return "STBT";
                yield return "STMA";
                yield return "STMB";
                yield return "STPO";
                yield return "STPT";
                yield return "STRA";
                yield return "STRE";
                yield return "STSB";
                yield return "STSP";
                yield return "STTRIPS";
                yield return "STVDI";
                yield return "STVDO";
                yield return "SU";
                yield return "SUBL";
                yield return "SUPR";
                yield return "SVAG";
                yield return "SXAB";
                yield return "SXABCONV";
                yield return "SXAS";
                yield return "SXHI";
                yield return "TC";
                yield return "TCAT";
                yield return "TCTB";
                yield return "TCTD";
                yield return "TCTQ";
                yield return "TCTR";
                yield return "TE";
                yield return "TEC";
                yield return "TETE";
                yield return "TETN";
                yield return "TH";
                yield return "THTN";
                yield return "THTQ";
                yield return "TRPMODE";
                yield return "TRPROUT";
                yield return "TRSTACC";
                yield return "TT";
                yield return "TTEF";
                yield return "TTEI";
                yield return "TTEP";
                yield return "TTES";
                yield return "TTEX";
                yield return "TTTG";
                yield return "TXAS";
                yield return "TXHG";
                yield return "UM";
                yield return "UM_TFR";
            }
        }

        /// <summary>
        /// Decrypted data IMPORT
        /// </summary>
        public A_DECRYP_DataSet A_DECRYP { get { return _A_DECRYP; } }

        /// <summary>
        /// Assets - Sub-Category
        /// </summary>
        public AKB_DataSet AKB { get { return _AKB; } }

        /// <summary>
        /// Assets - Categories
        /// </summary>
        public AKC_DataSet AKC { get { return _AKC; } }

        /// <summary>
        /// Assets - Categories Tax
        /// </summary>
        public AKCT_DataSet AKCT { get { return _AKCT; } }

        /// <summary>
        /// Assets - Departments
        /// </summary>
        public AKD_DataSet AKD { get { return _AKD; } }

        /// <summary>
        /// Asset Key Holders
        /// </summary>
        public AKK_DataSet AKK { get { return _AKK; } }

        /// <summary>
        /// Assets - Locations
        /// </summary>
        public AKL_DataSet AKL { get { return _AKL; } }

        /// <summary>
        /// Asset Release Types
        /// </summary>
        public AKR_DataSet AKR { get { return _AKR; } }

        /// <summary>
        /// Asset Types
        /// </summary>
        public AKT_DataSet AKT { get { return _AKT; } }

        /// <summary>
        /// Assets
        /// </summary>
        public AR_DataSet AR { get { return _AR; } }

        /// <summary>
        /// Asset Financial Transactions
        /// </summary>
        public ARF_DataSet ARF { get { return _ARF; } }

        /// <summary>
        /// Books for Hire
        /// </summary>
        public BKH_DataSet BKH { get { return _BKH; } }

        /// <summary>
        /// Book Hire Records
        /// </summary>
        public BKHR_DataSet BKHR { get { return _BKHR; } }

        /// <summary>
        /// BPay Data
        /// </summary>
        public BPAY_DAT_DataSet BPAY_DAT { get { return _BPAY_DAT; } }

        /// <summary>
        /// Accounts Payable
        /// </summary>
        public CR_DataSet CR { get { return _CR; } }

        /// <summary>
        /// Creditor Financial Transaction
        /// </summary>
        public CRF_DataSet CRF { get { return _CRF; } }

        /// <summary>
        /// Creditor Fuel Tax Credits
        /// </summary>
        public CRFTC_DataSet CRFTC { get { return _CRFTC; } }

        /// <summary>
        /// Families
        /// </summary>
        public DF_DataSet DF { get { return _DF; } }

        /// <summary>
        /// DF Transfer
        /// </summary>
        public DF_TFR_DataSet DF_TFR { get { return _DF_TFR; } }

        /// <summary>
        /// BPAY Receipts
        /// </summary>
        public DFB_DataSet DFB { get { return _DFB; } }

        /// <summary>
        /// Family Financial Transactions
        /// </summary>
        public DFF_DataSet DFF { get { return _DFF; } }

        /// <summary>
        /// Family History
        /// </summary>
        public DFHI_DataSet DFHI { get { return _DFHI; } }

        /// <summary>
        /// Family Voluntary Transactions
        /// </summary>
        public DFVT_DataSet DFVT { get { return _DFVT; } }

        /// <summary>
        /// Accounts Receivable
        /// </summary>
        public DR_DataSet DR { get { return _DR; } }

        /// <summary>
        /// DR Transactions
        /// </summary>
        public DRF_DataSet DRF { get { return _DRF; } }

        /// <summary>
        /// Financial Data Export
        /// </summary>
        public FDT_EXP_DataSet FDT_EXP { get { return _FDT_EXP; } }

        /// <summary>
        /// FDT Financial Raw Import Table
        /// </summary>
        public FDT_IMP_DataSet FDT_IMP { get { return _FDT_IMP; } }

        /// <summary>
        /// FDT Financal Holding Table
        /// </summary>
        public FER_FDT_DataSet FER_FDT { get { return _FER_FDT; } }

        /// <summary>
        /// Financial History
        /// </summary>
        public FINHIST_DataSet FINHIST { get { return _FINHIST; } }

        /// <summary>
        /// General Ledger
        /// </summary>
        public GL_DataSet GL { get { return _GL; } }

        /// <summary>
        /// Bank Account Details
        /// </summary>
        public GLBANK_DataSet GLBANK { get { return _GLBANK; } }

        /// <summary>
        /// General Ledger Budgets
        /// </summary>
        public GLBUDG_DataSet GLBUDG { get { return _GLBUDG; } }

        /// <summary>
        /// GL Combined Financial Trans
        /// </summary>
        public GLCF_DataSet GLCF { get { return _GLCF; } }

        /// <summary>
        /// Last Years GL Combined Financial Trans
        /// </summary>
        public GLCFPREV_DataSet GLCFPREV { get { return _GLCFPREV; } }

        /// <summary>
        /// General Ledger Transactions
        /// </summary>
        public GLF_DataSet GLF { get { return _GLF; } }

        /// <summary>
        /// Financial Commitments
        /// </summary>
        public GLFBANK_DataSet GLFBANK { get { return _GLFBANK; } }

        /// <summary>
        /// SP2 dummy table
        /// </summary>
        public GLFBUDG_DataSet GLFBUDG { get { return _GLFBUDG; } }

        /// <summary>
        /// Last Years GL Financial Trans
        /// </summary>
        public GLFPREV_DataSet GLFPREV { get { return _GLFPREV; } }

        /// <summary>
        /// Last Years General Ledger
        /// </summary>
        public GLPREV_DataSet GLPREV { get { return _GLPREV; } }

        /// <summary>
        /// BSB Numbers
        /// </summary>
        public KAB_DataSet KAB { get { return _KAB; } }

        /// <summary>
        /// Delivery Addresses
        /// </summary>
        public KAD_DataSet KAD { get { return _KAD; } }

        /// <summary>
        /// Asset Depreciation Methods
        /// </summary>
        public KADM_DataSet KADM { get { return _KADM; } }

        /// <summary>
        /// Standard Disciplinary Actions
        /// </summary>
        public KAM_DataSet KAM { get { return _KAM; } }

        /// <summary>
        /// Australian Postcodes
        /// </summary>
        public KAP_DataSet KAP { get { return _KAP; } }

        /// <summary>
        /// Bank Account
        /// </summary>
        public KBANK_DataSet KBANK { get { return _KBANK; } }

        /// <summary>
        /// BPAY Receipts Import
        /// </summary>
        public KBP_DataSet KBP { get { return _KBP; } }

        /// <summary>
        /// BPAY Temp Receipts Import
        /// </summary>
        public KBPT_DataSet KBPT { get { return _KBPT; } }

        /// <summary>
        /// Behaviour Classifications
        /// </summary>
        public KCB_DataSet KCB { get { return _KCB; } }

        /// <summary>
        /// Calendar Dates for Absences
        /// </summary>
        public KCC_DataSet KCC { get { return _KCC; } }

        /// <summary>
        /// Doctors
        /// </summary>
        public KCD_DataSet KCD { get { return _KCD; } }

        /// <summary>
        /// KCD Transfer
        /// </summary>
        public KCD_TFR_DataSet KCD_TFR { get { return _KCD_TFR; } }

        /// <summary>
        /// Religious Instruction Curricula
        /// </summary>
        public KCI_DataSet KCI { get { return _KCI; } }

        /// <summary>
        /// Medical Conditions
        /// </summary>
        public KCM_DataSet KCM { get { return _KCM; } }

        /// <summary>
        /// KCM Transfer
        /// </summary>
        public KCM_TFR_DataSet KCM_TFR { get { return _KCM_TFR; } }

        /// <summary>
        /// Cohorts for data aggregation
        /// </summary>
        public KCOHORT_DataSet KCOHORT { get { return _KCOHORT; } }

        /// <summary>
        /// Transport Routes/Stops
        /// </summary>
        public KCR_DataSet KCR { get { return _KCR; } }

        /// <summary>
        /// Absence Types
        /// </summary>
        public KCT_DataSet KCT { get { return _KCT; } }

        /// <summary>
        /// Visa Subclasses
        /// </summary>
        public KCV_DataSet KCV { get { return _KCV; } }

        /// <summary>
        /// Year Levels
        /// </summary>
        public KCY_DataSet KCY { get { return _KCY; } }

        /// <summary>
        /// Data deleted from DataMirror monitored tables
        /// </summary>
        public KDELETE_DataSet KDELETE { get { return _KDELETE; } }

        /// <summary>
        /// VELS Dimensions
        /// </summary>
        public KDI_DataSet KDI { get { return _KDI; } }

        /// <summary>
        /// VELS Domains
        /// </summary>
        public KDO_DataSet KDO { get { return _KDO; } }

        /// <summary>
        /// EMA Receipt details
        /// </summary>
        public KEMA_DataSet KEMA { get { return _KEMA; } }

        /// <summary>
        /// Import or Update Errors
        /// </summary>
        public KERROR_DataSet KERROR { get { return _KERROR; } }

        /// <summary>
        /// Fuel Tax Credit Rates
        /// </summary>
        public KFTC_DataSet KFTC { get { return _KFTC; } }

        /// <summary>
        /// Home Groups
        /// </summary>
        public KGC_DataSet KGC { get { return _KGC; } }

        /// <summary>
        /// Home Group History
        /// </summary>
        public KGCHI_DataSet KGCHI { get { return _KGCHI; } }

        /// <summary>
        /// Year 9-12 Exit Destinations
        /// </summary>
        public KGD_DataSet KGD { get { return _KGD; } }

        /// <summary>
        /// Year 9-12 Exit Categories
        /// </summary>
        public KGG_DataSet KGG { get { return _KGG; } }

        /// <summary>
        /// Houses
        /// </summary>
        public KGH_DataSet KGH { get { return _KGH; } }

        /// <summary>
        /// Languages
        /// </summary>
        public KGL_DataSet KGL { get { return _KGL; } }

        /// <summary>
        /// General Ledger Initiatives
        /// </summary>
        public KGLINIT_DataSet KGLINIT { get { return _KGLINIT; } }

        /// <summary>
        /// General Ledger Programs
        /// </summary>
        public KGLPROG_DataSet KGLPROG { get { return _KGLPROG; } }

        /// <summary>
        /// General Ledger Sub Programs
        /// </summary>
        public KGLSUB_DataSet KGLSUB { get { return _KGLSUB; } }

        /// <summary>
        /// General Ledger Account Types
        /// </summary>
        public KGLT_DataSet KGLT { get { return _KGLT; } }

        /// <summary>
        /// Religions
        /// </summary>
        public KGR_DataSet KGR { get { return _KGR; } }

        /// <summary>
        /// GST Percentages
        /// </summary>
        public KGST_DataSet KGST { get { return _KGST; } }

        /// <summary>
        /// Countries
        /// </summary>
        public KGT_DataSet KGT { get { return _KGT; } }

        /// <summary>
        /// Awards and Prizes
        /// </summary>
        public KGW_DataSet KGW { get { return _KGW; } }

        /// <summary>
        /// Trace log for finance import and export
        /// </summary>
        public KLOG_DataSet KLOG { get { return _KLOG; } }

        /// <summary>
        /// General Ledger Notes
        /// </summary>
        public KN_DataSet KN { get { return _KN; } }

        /// <summary>
        /// Family/Student ID Sequence Numbers
        /// </summary>
        public KNFS_DataSet KNFS { get { return _KNFS; } }

        /// <summary>
        /// Contacts
        /// </summary>
        public KPC_DataSet KPC { get { return _KPC; } }

        /// <summary>
        /// Contact Links
        /// </summary>
        public KPCL_DataSet KPCL { get { return _KPCL; } }

        /// <summary>
        /// Contact Relationship
        /// </summary>
        public KPCR_DataSet KPCR { get { return _KPCR; } }

        /// <summary>
        /// Employee Categories
        /// </summary>
        public KPEC_DataSet KPEC { get { return _KPEC; } }

        /// <summary>
        /// Note Categories
        /// </summary>
        public KPN_DataSet KPN { get { return _KPN; } }

        /// <summary>
        /// PRMS Order Details
        /// </summary>
        public KPRMS_DataSet KPRMS { get { return _KPRMS; } }

        /// <summary>
        /// Reports for emailing
        /// </summary>
        public KREPORT_DataSet KREPORT { get { return _KREPORT; } }

        /// <summary>
        /// Role Codes
        /// </summary>
        public KROLE_DataSet KROLE { get { return _KROLE; } }

        /// <summary>
        /// Areas of Teaching
        /// </summary>
        public KSA_DataSet KSA { get { return _KSA; } }

        /// <summary>
        /// Staff Positions
        /// </summary>
        public KSC_DataSet KSC { get { return _KSC; } }

        /// <summary>
        /// Faculties
        /// </summary>
        public KSF_DataSet KSF { get { return _KSF; } }

        /// <summary>
        /// Institutions
        /// </summary>
        public KSI_DataSet KSI { get { return _KSI; } }

        /// <summary>
        /// Available Qualifications
        /// </summary>
        public KSQ_DataSet KSQ { get { return _KSQ; } }

        /// <summary>
        /// Timetable Import Errors
        /// </summary>
        public KTIE_DataSet KTIE { get { return _KTIE; } }

        /// <summary>
        /// Student Transport Company
        /// </summary>
        public KTRCMP_DataSet KTRCMP { get { return _KTRCMP; } }

        /// <summary>
        /// CASES Past Students
        /// </summary>
        public OSCS_DataSet OSCS { get { return _OSCS; } }

        /// <summary>
        /// Cost Centres
        /// </summary>
        public PC_DataSet PC { get { return _PC; } }

        /// <summary>
        /// Departments
        /// </summary>
        public PD_DataSet PD { get { return _PD; } }

        /// <summary>
        /// Employees
        /// </summary>
        public PE_DataSet PE { get { return _PE; } }

        /// <summary>
        /// Payroll Transactions
        /// </summary>
        public PEF_DataSet PEF { get { return _PEF; } }

        /// <summary>
        /// Payroll Transaction History
        /// </summary>
        public PEFH_DataSet PEFH { get { return _PEFH; } }

        /// <summary>
        /// Employee Leave Audit
        /// </summary>
        public PELA_DataSet PELA { get { return _PELA; } }

        /// <summary>
        /// Employee Leave Details
        /// </summary>
        public PELD_DataSet PELD { get { return _PELD; } }

        /// <summary>
        /// Pay Advice Slip Message
        /// </summary>
        public PEM_DataSet PEM { get { return _PEM; } }

        /// <summary>
        /// Pay Methods
        /// </summary>
        public PEPM_DataSet PEPM { get { return _PEPM; } }

        /// <summary>
        /// Standard and Last Pays
        /// </summary>
        public PEPS_DataSet PEPS { get { return _PEPS; } }

        /// <summary>
        /// Super (SGL and Employee) YTD Transactions
        /// </summary>
        public PEPU_DataSet PEPU { get { return _PEPU; } }

        /// <summary>
        /// Super (SGL and Employee) History YTD Transactions
        /// </summary>
        public PEPUH_DataSet PEPUH { get { return _PEPUH; } }

        /// <summary>
        /// Employee History
        /// </summary>
        public PEPY_DataSet PEPY { get { return _PEPY; } }

        /// <summary>
        /// Employee Super LTD History
        /// </summary>
        public PESH_DataSet PESH { get { return _PESH; } }

        /// <summary>
        /// Employee Super Payment Transactions
        /// </summary>
        public PESP_DataSet PESP { get { return _PESP; } }

        /// <summary>
        /// Termination Payment
        /// </summary>
        public PETP_DataSet PETP { get { return _PETP; } }

        /// <summary>
        /// Superannuation Funds
        /// </summary>
        public PF_DataSet PF { get { return _PF; } }

        /// <summary>
        /// PAYG Payment Summary Box
        /// </summary>
        public PG_DataSet PG { get { return _PG; } }

        /// <summary>
        /// Pay Items
        /// </summary>
        public PI_DataSet PI { get { return _PI; } }

        /// <summary>
        /// Pay Item Leave Items
        /// </summary>
        public PILI_DataSet PILI { get { return _PILI; } }

        /// <summary>
        /// Leave Code Description
        /// </summary>
        public PLC_DataSet PLC { get { return _PLC; } }

        /// <summary>
        /// Leave Management Group
        /// </summary>
        public PLG_DataSet PLG { get { return _PLG; } }

        /// <summary>
        /// Leave Group Types
        /// </summary>
        public PLT_DataSet PLT { get { return _PLT; } }

        /// <summary>
        /// Medicare Levy Parameters
        /// </summary>
        public PML_DataSet PML { get { return _PML; } }

        /// <summary>
        /// Future Medicare Levy Parameters
        /// </summary>
        public PML_NEW_DataSet PML_NEW { get { return _PML_NEW; } }

        /// <summary>
        /// Payroll Groups
        /// </summary>
        public PN_DataSet PN { get { return _PN; } }

        /// <summary>
        /// PAYG Payer Details
        /// </summary>
        public PPD_DataSet PPD { get { return _PPD; } }

        /// <summary>
        /// PAYG Supplier Details
        /// </summary>
        public PPS_DataSet PPS { get { return _PPS; } }

        /// <summary>
        /// Pay Steps or Pay Class
        /// </summary>
        public PS_DataSet PS { get { return _PS; } }

        /// <summary>
        /// Award Details
        /// </summary>
        public PSA_DataSet PSA { get { return _PSA; } }

        /// <summary>
        /// Future Pay Steps or Pay Class
        /// </summary>
        public PSF_DataSet PSF { get { return _PSF; } }

        /// <summary>
        /// Tax Scales
        /// </summary>
        public PX_DataSet PX { get { return _PX; } }

        /// <summary>
        /// Future Tax Scales
        /// </summary>
        public PX_NEW_DataSet PX_NEW { get { return _PX_NEW; } }

        /// <summary>
        /// Batch Headers
        /// </summary>
        public QB_DataSet QB { get { return _QB; } }

        /// <summary>
        /// Stored SQL
        /// </summary>
        public QS_DataSet QS { get { return _QS; } }

        /// <summary>
        /// Fees
        /// </summary>
        public SA_DataSet SA { get { return _SA; } }

        /// <summary>
        /// Fees - Billing Templates
        /// </summary>
        public SAB_DataSet SAB { get { return _SAB; } }

        /// <summary>
        /// Billing Template Transactions
        /// </summary>
        public SABT_DataSet SABT { get { return _SABT; } }

        /// <summary>
        /// Absence by Cohort Aggregations
        /// </summary>
        public SACAG_DataSet SACAG { get { return _SACAG; } }

        /// <summary>
        /// Accidents
        /// </summary>
        public SAD_DataSet SAD { get { return _SAD; } }

        /// <summary>
        /// Absence by Cohort Aggregations
        /// </summary>
        public SADAG_DataSet SADAG { get { return _SADAG; } }

        /// <summary>
        /// Accident Prevention Measures
        /// </summary>
        public SADP_DataSet SADP { get { return _SADP; } }

        /// <summary>
        /// Accident Witnesses
        /// </summary>
        public SADW_DataSet SADW { get { return _SADW; } }

        /// <summary>
        /// Accident Involvements/Sickbay Visits
        /// </summary>
        public SAI_DataSet SAI { get { return _SAI; } }

        /// <summary>
        /// Accident Involvement Injuries
        /// </summary>
        public SAII_DataSet SAII { get { return _SAII; } }

        /// <summary>
        /// Sickbay Medication Administrations
        /// </summary>
        public SAIM_DataSet SAIM { get { return _SAIM; } }

        /// <summary>
        /// School Association Members
        /// </summary>
        public SAM_DataSet SAM { get { return _SAM; } }

        /// <summary>
        /// Association Member Attendances
        /// </summary>
        public SAMA_DataSet SAMA { get { return _SAMA; } }

        /// <summary>
        /// School Association Positions
        /// </summary>
        public SAP_DataSet SAP { get { return _SAP; } }

        /// <summary>
        /// Courses
        /// </summary>
        public SC_DataSet SC { get { return _SC; } }

        /// <summary>
        /// School Associations
        /// </summary>
        public SCA_DataSet SCA { get { return _SCA; } }

        /// <summary>
        /// School Association Meetings
        /// </summary>
        public SCAM_DataSet SCAM { get { return _SCAM; } }

        /// <summary>
        /// Archived Census Class Sizes Data
        /// </summary>
        public SCEN_ACL_DataSet SCEN_ACL { get { return _SCEN_ACL; } }

        /// <summary>
        /// Archived Census Class Sizes Validation Data
        /// </summary>
        public SCEN_ACV_DataSet SCEN_ACV { get { return _SCEN_ACV; } }

        /// <summary>
        /// Census Application Message Data
        /// </summary>
        public SCEN_APP_DataSet SCEN_APP { get { return _SCEN_APP; } }

        /// <summary>
        /// Archived Census Student Excluded Data
        /// </summary>
        public SCEN_ASE_DataSet SCEN_ASE { get { return _SCEN_ASE; } }

        /// <summary>
        /// Archived Census Student Data
        /// </summary>
        public SCEN_AST_DataSet SCEN_AST { get { return _SCEN_AST; } }

        /// <summary>
        /// Archived Census Student Validation Data
        /// </summary>
        public SCEN_ASV_DataSet SCEN_ASV { get { return _SCEN_ASV; } }

        /// <summary>
        /// Census Class Sizes Data
        /// </summary>
        public SCEN_CL_DataSet SCEN_CL { get { return _SCEN_CL; } }

        /// <summary>
        /// Census Class Sizes Validation Data
        /// </summary>
        public SCEN_CLV_DataSet SCEN_CLV { get { return _SCEN_CLV; } }

        /// <summary>
        /// Census Class Sizes Validation Type
        /// </summary>
        public SCEN_CVT_DataSet SCEN_CVT { get { return _SCEN_CVT; } }

        /// <summary>
        /// Field-Display Metadata for Census Return Data
        /// </summary>
        public SCEN_RFD_DataSet SCEN_RFD { get { return _SCEN_RFD; } }

        /// <summary>
        /// Census Report Usage Metadata
        /// </summary>
        public SCEN_RPT_DataSet SCEN_RPT { get { return _SCEN_RPT; } }

        /// <summary>
        /// Census Return Summary Data
        /// </summary>
        public SCEN_RTN_DataSet SCEN_RTN { get { return _SCEN_RTN; } }

        /// <summary>
        /// Column-Display Metadata for displaying Student Data
        /// </summary>
        public SCEN_SCD_DataSet SCEN_SCD { get { return _SCEN_SCD; } }

        /// <summary>
        /// Census Student Data
        /// </summary>
        public SCEN_ST_DataSet SCEN_ST { get { return _SCEN_ST; } }

        /// <summary>
        /// Census Student Excluded Data
        /// </summary>
        public SCEN_STE_DataSet SCEN_STE { get { return _SCEN_STE; } }

        /// <summary>
        /// Census Student Validation Data
        /// </summary>
        public SCEN_STV_DataSet SCEN_STV { get { return _SCEN_STV; } }

        /// <summary>
        /// Census Student Validation Type Data
        /// </summary>
        public SCEN_SVT_DataSet SCEN_SVT { get { return _SCEN_SVT; } }

        /// <summary>
        /// School Information
        /// </summary>
        public SCI_DataSet SCI { get { return _SCI; } }

        /// <summary>
        /// Subject Classes
        /// </summary>
        public SCL_DataSet SCL { get { return _SCL; } }

        /// <summary>
        /// CSF Strands
        /// </summary>
        public SCSF_DataSet SCSF { get { return _SCSF; } }

        /// <summary>
        /// CSF Data Aggregates
        /// </summary>
        public SCSFAG_DataSet SCSFAG { get { return _SCSFAG; } }

        /// <summary>
        /// Sundry Debtor Fees
        /// </summary>
        public SDFC_DataSet SDFC { get { return _SDFC; } }

        /// <summary>
        /// Sundry Debtor Fee Groups
        /// </summary>
        public SDG_DataSet SDG { get { return _SDG; } }

        /// <summary>
        /// Adult Group Members
        /// </summary>
        public SDGM_DataSet SDGM { get { return _SDGM; } }

        /// <summary>
        /// Incident Instigators
        /// </summary>
        public SDP_DataSet SDP { get { return _SDP; } }

        /// <summary>
        /// Disciplinary Actions
        /// </summary>
        public SDPA_DataSet SDPA { get { return _SDPA; } }

        /// <summary>
        /// eCASES21 Error Log
        /// </summary>
        public SEC_ELOG_DataSet SEC_ELOG { get { return _SEC_ELOG; } }

        /// <summary>
        /// eCASES21 Login Log
        /// </summary>
        public SEC_LLOG_DataSet SEC_LLOG { get { return _SEC_LLOG; } }

        /// <summary>
        /// eCASES21 School Message
        /// </summary>
        public SEC_MSG_DataSet SEC_MSG { get { return _SEC_MSG; } }

        /// <summary>
        /// eCASES21 School Links URL
        /// </summary>
        public SEC_URL_DataSet SEC_URL { get { return _SEC_URL; } }

        /// <summary>
        /// eCASES21 User Sessions
        /// </summary>
        public SEC_USR_DataSet SEC_USR { get { return _SEC_USR; } }

        /// <summary>
        /// Staff
        /// </summary>
        public SF_DataSet SF { get { return _SF; } }

        /// <summary>
        /// Staff Availability in Quilt
        /// </summary>
        public SFAQ_DataSet SFAQ { get { return _SFAQ; } }

        /// <summary>
        /// Staff Availability for Calendar Extras
        /// </summary>
        public SFAV_DataSet SFAV { get { return _SFAV; } }

        /// <summary>
        /// Staff Qualifications
        /// </summary>
        public SFQA_DataSet SFQA { get { return _SFQA; } }

        /// <summary>
        /// Student Groupings
        /// </summary>
        public SG_DataSet SG { get { return _SG; } }

        /// <summary>
        /// Adult Group Members
        /// </summary>
        public SGAM_DataSet SGAM { get { return _SGAM; } }

        /// <summary>
        /// Home Group Eligibility Criteria
        /// </summary>
        public SGHG_DataSet SGHG { get { return _SGHG; } }

        /// <summary>
        /// Special Group Meetings
        /// </summary>
        public SGM_DataSet SGM { get { return _SGM; } }

        /// <summary>
        /// Group Meeting Attendance
        /// </summary>
        public SGMA_DataSet SGMA { get { return _SGMA; } }

        /// <summary>
        /// Subject/Class Eligibility Criteria
        /// </summary>
        public SGSC_DataSet SGSC { get { return _SGSC; } }

        /// <summary>
        /// Group Membership Eligibility Criteria
        /// </summary>
        public SGSG_DataSet SGSG { get { return _SGSG; } }

        /// <summary>
        /// Temporary Group Transactions
        /// </summary>
        public SGTRX_DataSet SGTRX { get { return _SGTRX; } }

        /// <summary>
        /// Disciplinary Incidents
        /// </summary>
        public SID_DataSet SID { get { return _SID; } }

        /// <summary>
        /// Incident Victims/Recipients
        /// </summary>
        public SIDV_DataSet SIDV { get { return _SIDV; } }

        /// <summary>
        /// On line receipt history
        /// </summary>
        public SIRH_DataSet SIRH { get { return _SIRH; } }

        /// <summary>
        /// HRMS Import Table
        /// </summary>
        public SK_HRMS_DataSet SK_HRMS { get { return _SK_HRMS; } }

        /// <summary>
        /// HRMS Temp Import Table
        /// </summary>
        public SK_HRMST_DataSet SK_HRMST { get { return _SK_HRMST; } }

        /// <summary>
        /// Schools
        /// </summary>
        public SKGS_DataSet SKGS { get { return _SKGS; } }

        /// <summary>
        /// Rooms
        /// </summary>
        public SM_DataSet SM { get { return _SM; } }

        /// <summary>
        /// Room Availability in Quilt
        /// </summary>
        public SMAQ_DataSet SMAQ { get { return _SMAQ; } }

        /// <summary>
        /// Room Availablity Extras
        /// </summary>
        public SMAV_DataSet SMAV { get { return _SMAV; } }

        /// <summary>
        /// Student Medical Conditions
        /// </summary>
        public SMC_DataSet SMC { get { return _SMC; } }

        /// <summary>
        /// SMC Transfer
        /// </summary>
        public SMC_TFR_DataSet SMC_TFR { get { return _SMC_TFR; } }

        /// <summary>
        /// Student Medication Doses
        /// </summary>
        public SMCD_DataSet SMCD { get { return _SMCD; } }

        /// <summary>
        /// Rooms group
        /// </summary>
        public SMGROUP_DataSet SMGROUP { get { return _SMGROUP; } }

        /// <summary>
        /// Report email templates
        /// </summary>
        public SPEMAIL_DataSet SPEMAIL { get { return _SPEMAIL; } }

        /// <summary>
        /// Report file audit
        /// </summary>
        public SPEPRINT_DataSet SPEPRINT { get { return _SPEPRINT; } }

        /// <summary>
        /// Stored Procedure Return Values
        /// </summary>
        public SPOUT_DataSet SPOUT { get { return _SPOUT; } }

        /// <summary>
        /// Publications
        /// </summary>
        public SPU_DataSet SPU { get { return _SPU; } }

        /// <summary>
        /// FTE Student Retentions
        /// </summary>
        public SRAG_DataSet SRAG { get { return _SRAG; } }

        /// <summary>
        /// Specialist Subjects
        /// </summary>
        public SS_DataSet SS { get { return _SS; } }

        /// <summary>
        /// Specialist Subjects per Home Group
        /// </summary>
        public SSHG_DataSet SSHG { get { return _SSHG; } }

        /// <summary>
        /// Students
        /// </summary>
        public ST_DataSet ST { get { return _ST; } }

        /// <summary>
        /// ST Transfer
        /// </summary>
        public ST_TFR_DataSet ST_TFR { get { return _ST_TFR; } }

        /// <summary>
        /// Student Data Transfer Table
        /// </summary>
        public ST_TFRIO_DataSet ST_TFRIO { get { return _ST_TFRIO; } }

        /// <summary>
        /// Student Transport Usage
        /// </summary>
        public STBT_DataSet STBT { get { return _STBT; } }

        /// <summary>
        /// Subject Selections & Marks
        /// </summary>
        public STMA_DataSet STMA { get { return _STMA; } }

        /// <summary>
        /// Student Merit Behaviour Details
        /// </summary>
        public STMB_DataSet STMB { get { return _STMB; } }

        /// <summary>
        /// Position or Group Memberships
        /// </summary>
        public STPO_DataSet STPO { get { return _STPO; } }

        /// <summary>
        /// Student Part-Time Enrolments
        /// </summary>
        public STPT_DataSet STPT { get { return _STPT; } }

        /// <summary>
        /// Multiple Day Absences
        /// </summary>
        public STRA_DataSet STRA { get { return _STRA; } }

        /// <summary>
        /// Student Re-Enrolment
        /// </summary>
        public STRE_DataSet STRE { get { return _STRE; } }

        /// <summary>
        /// Family Invoice Allocations
        /// </summary>
        public STSB_DataSet STSB { get { return _STSB; } }

        /// <summary>
        /// Suspension Details
        /// </summary>
        public STSP_DataSet STSP { get { return _STSP; } }

        /// <summary>
        /// Student Trips
        /// </summary>
        public STTRIPS_DataSet STTRIPS { get { return _STTRIPS; } }

        /// <summary>
        /// VELS Dimension Results
        /// </summary>
        public STVDI_DataSet STVDI { get { return _STVDI; } }

        /// <summary>
        /// VELS Domain Results
        /// </summary>
        public STVDO_DataSet STVDO { get { return _STVDO; } }

        /// <summary>
        /// Subjects
        /// </summary>
        public SU_DataSet SU { get { return _SU; } }

        /// <summary>
        /// Subject Book List
        /// </summary>
        public SUBL_DataSet SUBL { get { return _SUBL; } }

        /// <summary>
        /// Subject Prerequisites
        /// </summary>
        public SUPR_DataSet SUPR { get { return _SUPR; } }

        /// <summary>
        /// VELS Aggregated Dimensions
        /// </summary>
        public SVAG_DataSet SVAG { get { return _SVAG; } }

        /// <summary>
        /// Student Half-Day Absences
        /// </summary>
        public SXAB_DataSet SXAB { get { return _SXAB; } }

        /// <summary>
        /// Converted Student Half-Day Absences
        /// </summary>
        public SXABCONV_DataSet SXABCONV { get { return _SXABCONV; } }

        /// <summary>
        /// Student Scheduled Sessions
        /// </summary>
        public SXAS_DataSet SXAS { get { return _SXAS; } }

        /// <summary>
        /// Student History
        /// </summary>
        public SXHI_DataSet SXHI { get { return _SXHI; } }

        /// <summary>
        /// Calendar
        /// </summary>
        public TC_DataSet TC { get { return _TC; } }

        /// <summary>
        /// Staff Absence Types
        /// </summary>
        public TCAT_DataSet TCAT { get { return _TCAT; } }

        /// <summary>
        /// Teacher Absences
        /// </summary>
        public TCTB_DataSet TCTB { get { return _TCTB; } }

        /// <summary>
        /// Calendar Period Information
        /// </summary>
        public TCTD_DataSet TCTD { get { return _TCTD; } }

        /// <summary>
        /// Calendar Class Information
        /// </summary>
        public TCTQ_DataSet TCTQ { get { return _TCTQ; } }

        /// <summary>
        /// Teacher Replacements
        /// </summary>
        public TCTR_DataSet TCTR { get { return _TCTR; } }

        /// <summary>
        /// Calendar Events
        /// </summary>
        public TE_DataSet TE { get { return _TE; } }

        /// <summary>
        /// Event Categories
        /// </summary>
        public TEC_DataSet TEC { get { return _TEC; } }

        /// <summary>
        /// Event Instances
        /// </summary>
        public TETE_DataSet TETE { get { return _TETE; } }

        /// <summary>
        /// Event Attendees
        /// </summary>
        public TETN_DataSet TETN { get { return _TETN; } }

        /// <summary>
        /// Timetable Quilt Headers
        /// </summary>
        public TH_DataSet TH { get { return _TH; } }

        /// <summary>
        /// Timetable Labels
        /// </summary>
        public THTN_DataSet THTN { get { return _THTN; } }

        /// <summary>
        /// Timetable Quilt Entries
        /// </summary>
        public THTQ_DataSet THTQ { get { return _THTQ; } }

        /// <summary>
        /// Transport Modes
        /// </summary>
        public TRPMODE_DataSet TRPMODE { get { return _TRPMODE; } }

        /// <summary>
        /// Student Transport Routes
        /// </summary>
        public TRPROUT_DataSet TRPROUT { get { return _TRPROUT; } }

        /// <summary>
        /// STACC Holding Table
        /// </summary>
        public TRSTACC_DataSet TRSTACC { get { return _TRSTACC; } }

        /// <summary>
        /// Timetable Grid Templates
        /// </summary>
        public TT_DataSet TT { get { return _TT; } }

        /// <summary>
        /// Exam Staff
        /// </summary>
        public TTEF_DataSet TTEF { get { return _TTEF; } }

        /// <summary>
        /// Exam Details
        /// </summary>
        public TTEI_DataSet TTEI { get { return _TTEI; } }

        /// <summary>
        /// Exam Periods
        /// </summary>
        public TTEP_DataSet TTEP { get { return _TTEP; } }

        /// <summary>
        /// Exam Subjects
        /// </summary>
        public TTES_DataSet TTES { get { return _TTES; } }

        /// <summary>
        /// Exam Grid
        /// </summary>
        public TTEX_DataSet TTEX { get { return _TTEX; } }

        /// <summary>
        /// Grid Subjects
        /// </summary>
        public TTTG_DataSet TTTG { get { return _TTTG; } }

        /// <summary>
        /// Actual Sessions
        /// </summary>
        public TXAS_DataSet TXAS { get { return _TXAS; } }

        /// <summary>
        /// Home Group Daily Attendance Records
        /// </summary>
        public TXHG_DataSet TXHG { get { return _TXHG; } }

        /// <summary>
        /// Addresses
        /// </summary>
        public UM_DataSet UM { get { return _UM; } }

        /// <summary>
        /// UM Transfer
        /// </summary>
        public UM_TFR_DataSet UM_TFR { get { return _UM_TFR; } }
    }
}
