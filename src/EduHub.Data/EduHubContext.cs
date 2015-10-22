﻿using System;
using System.Collections.Generic;
using EduHub.Data.Entities;

namespace EduHub.Data
{
    /// <summary>
    /// eduHub Data Context
    /// </summary>
    public partial class EduHubContext
    {
#region Set Fields
        private A_DECRYPDataSet _A_DECRYP;
        private AKBDataSet _AKB;
        private AKCDataSet _AKC;
        private AKCTDataSet _AKCT;
        private AKDDataSet _AKD;
        private AKKDataSet _AKK;
        private AKLDataSet _AKL;
        private AKRDataSet _AKR;
        private AKTDataSet _AKT;
        private ARDataSet _AR;
        private ARFDataSet _ARF;
        private BKHDataSet _BKH;
        private BKHRDataSet _BKHR;
        private BPAY_DATDataSet _BPAY_DAT;
        private CRDataSet _CR;
        private CRFDataSet _CRF;
        private CRFTCDataSet _CRFTC;
        private DFDataSet _DF;
        private DF_TFRDataSet _DF_TFR;
        private DFBDataSet _DFB;
        private DFFDataSet _DFF;
        private DFHIDataSet _DFHI;
        private DFVTDataSet _DFVT;
        private DRDataSet _DR;
        private DRBDataSet _DRB;
        private DRFDataSet _DRF;
        private FDT_EXPDataSet _FDT_EXP;
        private FDT_IMPDataSet _FDT_IMP;
        private FER_FDTDataSet _FER_FDT;
        private FINHISTDataSet _FINHIST;
        private GLDataSet _GL;
        private GLBANKDataSet _GLBANK;
        private GLBUDGDataSet _GLBUDG;
        private GLCFDataSet _GLCF;
        private GLCFPREVDataSet _GLCFPREV;
        private GLFDataSet _GLF;
        private GLFBANKDataSet _GLFBANK;
        private GLFBUDGDataSet _GLFBUDG;
        private GLFPREVDataSet _GLFPREV;
        private GLPREVDataSet _GLPREV;
        private KABDataSet _KAB;
        private KADDataSet _KAD;
        private KADMDataSet _KADM;
        private KAMDataSet _KAM;
        private KAPDataSet _KAP;
        private KBANKDataSet _KBANK;
        private KBPDataSet _KBP;
        private KBPTDataSet _KBPT;
        private KCBDataSet _KCB;
        private KCCDataSet _KCC;
        private KCDDataSet _KCD;
        private KCD_TFRDataSet _KCD_TFR;
        private KCIDataSet _KCI;
        private KCMDataSet _KCM;
        private KCM_TFRDataSet _KCM_TFR;
        private KCOHORTDataSet _KCOHORT;
        private KCRDataSet _KCR;
        private KCTDataSet _KCT;
        private KCVDataSet _KCV;
        private KCYDataSet _KCY;
        private KDELETEDataSet _KDELETE;
        private KDIDataSet _KDI;
        private KDODataSet _KDO;
        private KEMADataSet _KEMA;
        private KERRORDataSet _KERROR;
        private KFTCDataSet _KFTC;
        private KGCDataSet _KGC;
        private KGCHIDataSet _KGCHI;
        private KGDDataSet _KGD;
        private KGGDataSet _KGG;
        private KGHDataSet _KGH;
        private KGLDataSet _KGL;
        private KGLINITDataSet _KGLINIT;
        private KGLPROGDataSet _KGLPROG;
        private KGLSUBDataSet _KGLSUB;
        private KGLTDataSet _KGLT;
        private KGRDataSet _KGR;
        private KGSTDataSet _KGST;
        private KGTDataSet _KGT;
        private KGWDataSet _KGW;
        private KLOGDataSet _KLOG;
        private KNDataSet _KN;
        private KNFSDataSet _KNFS;
        private KPCDataSet _KPC;
        private KPCLDataSet _KPCL;
        private KPCRDataSet _KPCR;
        private KPECDataSet _KPEC;
        private KPNDataSet _KPN;
        private KPRMSDataSet _KPRMS;
        private KREPORTDataSet _KREPORT;
        private KROLEDataSet _KROLE;
        private KSADataSet _KSA;
        private KSCDataSet _KSC;
        private KSFDataSet _KSF;
        private KSIDataSet _KSI;
        private KSQDataSet _KSQ;
        private KTIEDataSet _KTIE;
        private KTMDataSet _KTM;
        private KTRCMPDataSet _KTRCMP;
        private OSCSDataSet _OSCS;
        private PCDataSet _PC;
        private PDDataSet _PD;
        private PEDataSet _PE;
        private PEFDataSet _PEF;
        private PEFHDataSet _PEFH;
        private PELADataSet _PELA;
        private PELDDataSet _PELD;
        private PEMDataSet _PEM;
        private PEPMDataSet _PEPM;
        private PEPSDataSet _PEPS;
        private PEPUDataSet _PEPU;
        private PEPUHDataSet _PEPUH;
        private PEPYDataSet _PEPY;
        private PESHDataSet _PESH;
        private PESPDataSet _PESP;
        private PETPDataSet _PETP;
        private PFDataSet _PF;
        private PGDataSet _PG;
        private PIDataSet _PI;
        private PILIDataSet _PILI;
        private PLCDataSet _PLC;
        private PLGDataSet _PLG;
        private PLTDataSet _PLT;
        private PMLDataSet _PML;
        private PML_NEWDataSet _PML_NEW;
        private PNDataSet _PN;
        private PPDDataSet _PPD;
        private PPSDataSet _PPS;
        private PSDataSet _PS;
        private PSADataSet _PSA;
        private PSFDataSet _PSF;
        private PXDataSet _PX;
        private PX_NEWDataSet _PX_NEW;
        private QBDataSet _QB;
        private QSDataSet _QS;
        private SADataSet _SA;
        private SABDataSet _SAB;
        private SABTDataSet _SABT;
        private SACAGDataSet _SACAG;
        private SADDataSet _SAD;
        private SADAGDataSet _SADAG;
        private SADPDataSet _SADP;
        private SADWDataSet _SADW;
        private SAIDataSet _SAI;
        private SAIIDataSet _SAII;
        private SAIMDataSet _SAIM;
        private SAMDataSet _SAM;
        private SAMADataSet _SAMA;
        private SAPDataSet _SAP;
        private SCDataSet _SC;
        private SCADataSet _SCA;
        private SCAMDataSet _SCAM;
        private SCEN_ACLDataSet _SCEN_ACL;
        private SCEN_ACVDataSet _SCEN_ACV;
        private SCEN_APPDataSet _SCEN_APP;
        private SCEN_ASEDataSet _SCEN_ASE;
        private SCEN_ASTDataSet _SCEN_AST;
        private SCEN_ASVDataSet _SCEN_ASV;
        private SCEN_CLDataSet _SCEN_CL;
        private SCEN_CLVDataSet _SCEN_CLV;
        private SCEN_CVTDataSet _SCEN_CVT;
        private SCEN_RFDDataSet _SCEN_RFD;
        private SCEN_RPTDataSet _SCEN_RPT;
        private SCEN_RTNDataSet _SCEN_RTN;
        private SCEN_SCDDataSet _SCEN_SCD;
        private SCEN_STDataSet _SCEN_ST;
        private SCEN_STEDataSet _SCEN_STE;
        private SCEN_STVDataSet _SCEN_STV;
        private SCEN_SVTDataSet _SCEN_SVT;
        private SCIDataSet _SCI;
        private SCLDataSet _SCL;
        private SCSFDataSet _SCSF;
        private SCSFAGDataSet _SCSFAG;
        private SDFCDataSet _SDFC;
        private SDGDataSet _SDG;
        private SDGMDataSet _SDGM;
        private SDPDataSet _SDP;
        private SDPADataSet _SDPA;
        private SEC_ELOGDataSet _SEC_ELOG;
        private SEC_LLOGDataSet _SEC_LLOG;
        private SEC_MSGDataSet _SEC_MSG;
        private SEC_URLDataSet _SEC_URL;
        private SEC_USRDataSet _SEC_USR;
        private SFDataSet _SF;
        private SFAQDataSet _SFAQ;
        private SFAVDataSet _SFAV;
        private SFQADataSet _SFQA;
        private SGDataSet _SG;
        private SGAMDataSet _SGAM;
        private SGHGDataSet _SGHG;
        private SGMDataSet _SGM;
        private SGMADataSet _SGMA;
        private SGSCDataSet _SGSC;
        private SGSGDataSet _SGSG;
        private SGTRXDataSet _SGTRX;
        private SIDDataSet _SID;
        private SIDVDataSet _SIDV;
        private SIRHDataSet _SIRH;
        private SK_HRMSDataSet _SK_HRMS;
        private SK_HRMSTDataSet _SK_HRMST;
        private SKGSDataSet _SKGS;
        private SMDataSet _SM;
        private SMAQDataSet _SMAQ;
        private SMAVDataSet _SMAV;
        private SMCDataSet _SMC;
        private SMC_TFRDataSet _SMC_TFR;
        private SMCDDataSet _SMCD;
        private SMGROUPDataSet _SMGROUP;
        private SPEMAILDataSet _SPEMAIL;
        private SPEPRINTDataSet _SPEPRINT;
        private SPOUTDataSet _SPOUT;
        private SPRECIPDataSet _SPRECIP;
        private SPREPLYDataSet _SPREPLY;
        private SPSMSDataSet _SPSMS;
        private SPUDataSet _SPU;
        private SRAGDataSet _SRAG;
        private SSDataSet _SS;
        private SSHGDataSet _SSHG;
        private STDataSet _ST;
        private ST_TFRDataSet _ST_TFR;
        private ST_TFRIODataSet _ST_TFRIO;
        private STBTDataSet _STBT;
        private STMADataSet _STMA;
        private STMBDataSet _STMB;
        private STPODataSet _STPO;
        private STPTDataSet _STPT;
        private STRADataSet _STRA;
        private STREDataSet _STRE;
        private STSBDataSet _STSB;
        private STSPDataSet _STSP;
        private STTRIPSDataSet _STTRIPS;
        private STVDIDataSet _STVDI;
        private STVDODataSet _STVDO;
        private SUDataSet _SU;
        private SUBLDataSet _SUBL;
        private SUPRDataSet _SUPR;
        private SVAGDataSet _SVAG;
        private SXABDataSet _SXAB;
        private SXABCONVDataSet _SXABCONV;
        private SXASDataSet _SXAS;
        private SXHIDataSet _SXHI;
        private TCDataSet _TC;
        private TCATDataSet _TCAT;
        private TCTBDataSet _TCTB;
        private TCTDDataSet _TCTD;
        private TCTQDataSet _TCTQ;
        private TCTRDataSet _TCTR;
        private TEDataSet _TE;
        private TECDataSet _TEC;
        private TETEDataSet _TETE;
        private TETNDataSet _TETN;
        private THDataSet _TH;
        private THTNDataSet _THTN;
        private THTQDataSet _THTQ;
        private TRPMODEDataSet _TRPMODE;
        private TRPROUTDataSet _TRPROUT;
        private TRSTACCDataSet _TRSTACC;
        private TTDataSet _TT;
        private TTEFDataSet _TTEF;
        private TTEIDataSet _TTEI;
        private TTEPDataSet _TTEP;
        private TTESDataSet _TTES;
        private TTEXDataSet _TTEX;
        private TTTGDataSet _TTTG;
        private TXASDataSet _TXAS;
        private TXHGDataSet _TXHG;
        private UMDataSet _UM;
        private UM_TFRDataSet _UM_TFR;
#endregion

        private void Initialize()
        {
            _A_DECRYP = new A_DECRYPDataSet(this);
            _AKB = new AKBDataSet(this);
            _AKC = new AKCDataSet(this);
            _AKCT = new AKCTDataSet(this);
            _AKD = new AKDDataSet(this);
            _AKK = new AKKDataSet(this);
            _AKL = new AKLDataSet(this);
            _AKR = new AKRDataSet(this);
            _AKT = new AKTDataSet(this);
            _AR = new ARDataSet(this);
            _ARF = new ARFDataSet(this);
            _BKH = new BKHDataSet(this);
            _BKHR = new BKHRDataSet(this);
            _BPAY_DAT = new BPAY_DATDataSet(this);
            _CR = new CRDataSet(this);
            _CRF = new CRFDataSet(this);
            _CRFTC = new CRFTCDataSet(this);
            _DF = new DFDataSet(this);
            _DF_TFR = new DF_TFRDataSet(this);
            _DFB = new DFBDataSet(this);
            _DFF = new DFFDataSet(this);
            _DFHI = new DFHIDataSet(this);
            _DFVT = new DFVTDataSet(this);
            _DR = new DRDataSet(this);
            _DRB = new DRBDataSet(this);
            _DRF = new DRFDataSet(this);
            _FDT_EXP = new FDT_EXPDataSet(this);
            _FDT_IMP = new FDT_IMPDataSet(this);
            _FER_FDT = new FER_FDTDataSet(this);
            _FINHIST = new FINHISTDataSet(this);
            _GL = new GLDataSet(this);
            _GLBANK = new GLBANKDataSet(this);
            _GLBUDG = new GLBUDGDataSet(this);
            _GLCF = new GLCFDataSet(this);
            _GLCFPREV = new GLCFPREVDataSet(this);
            _GLF = new GLFDataSet(this);
            _GLFBANK = new GLFBANKDataSet(this);
            _GLFBUDG = new GLFBUDGDataSet(this);
            _GLFPREV = new GLFPREVDataSet(this);
            _GLPREV = new GLPREVDataSet(this);
            _KAB = new KABDataSet(this);
            _KAD = new KADDataSet(this);
            _KADM = new KADMDataSet(this);
            _KAM = new KAMDataSet(this);
            _KAP = new KAPDataSet(this);
            _KBANK = new KBANKDataSet(this);
            _KBP = new KBPDataSet(this);
            _KBPT = new KBPTDataSet(this);
            _KCB = new KCBDataSet(this);
            _KCC = new KCCDataSet(this);
            _KCD = new KCDDataSet(this);
            _KCD_TFR = new KCD_TFRDataSet(this);
            _KCI = new KCIDataSet(this);
            _KCM = new KCMDataSet(this);
            _KCM_TFR = new KCM_TFRDataSet(this);
            _KCOHORT = new KCOHORTDataSet(this);
            _KCR = new KCRDataSet(this);
            _KCT = new KCTDataSet(this);
            _KCV = new KCVDataSet(this);
            _KCY = new KCYDataSet(this);
            _KDELETE = new KDELETEDataSet(this);
            _KDI = new KDIDataSet(this);
            _KDO = new KDODataSet(this);
            _KEMA = new KEMADataSet(this);
            _KERROR = new KERRORDataSet(this);
            _KFTC = new KFTCDataSet(this);
            _KGC = new KGCDataSet(this);
            _KGCHI = new KGCHIDataSet(this);
            _KGD = new KGDDataSet(this);
            _KGG = new KGGDataSet(this);
            _KGH = new KGHDataSet(this);
            _KGL = new KGLDataSet(this);
            _KGLINIT = new KGLINITDataSet(this);
            _KGLPROG = new KGLPROGDataSet(this);
            _KGLSUB = new KGLSUBDataSet(this);
            _KGLT = new KGLTDataSet(this);
            _KGR = new KGRDataSet(this);
            _KGST = new KGSTDataSet(this);
            _KGT = new KGTDataSet(this);
            _KGW = new KGWDataSet(this);
            _KLOG = new KLOGDataSet(this);
            _KN = new KNDataSet(this);
            _KNFS = new KNFSDataSet(this);
            _KPC = new KPCDataSet(this);
            _KPCL = new KPCLDataSet(this);
            _KPCR = new KPCRDataSet(this);
            _KPEC = new KPECDataSet(this);
            _KPN = new KPNDataSet(this);
            _KPRMS = new KPRMSDataSet(this);
            _KREPORT = new KREPORTDataSet(this);
            _KROLE = new KROLEDataSet(this);
            _KSA = new KSADataSet(this);
            _KSC = new KSCDataSet(this);
            _KSF = new KSFDataSet(this);
            _KSI = new KSIDataSet(this);
            _KSQ = new KSQDataSet(this);
            _KTIE = new KTIEDataSet(this);
            _KTM = new KTMDataSet(this);
            _KTRCMP = new KTRCMPDataSet(this);
            _OSCS = new OSCSDataSet(this);
            _PC = new PCDataSet(this);
            _PD = new PDDataSet(this);
            _PE = new PEDataSet(this);
            _PEF = new PEFDataSet(this);
            _PEFH = new PEFHDataSet(this);
            _PELA = new PELADataSet(this);
            _PELD = new PELDDataSet(this);
            _PEM = new PEMDataSet(this);
            _PEPM = new PEPMDataSet(this);
            _PEPS = new PEPSDataSet(this);
            _PEPU = new PEPUDataSet(this);
            _PEPUH = new PEPUHDataSet(this);
            _PEPY = new PEPYDataSet(this);
            _PESH = new PESHDataSet(this);
            _PESP = new PESPDataSet(this);
            _PETP = new PETPDataSet(this);
            _PF = new PFDataSet(this);
            _PG = new PGDataSet(this);
            _PI = new PIDataSet(this);
            _PILI = new PILIDataSet(this);
            _PLC = new PLCDataSet(this);
            _PLG = new PLGDataSet(this);
            _PLT = new PLTDataSet(this);
            _PML = new PMLDataSet(this);
            _PML_NEW = new PML_NEWDataSet(this);
            _PN = new PNDataSet(this);
            _PPD = new PPDDataSet(this);
            _PPS = new PPSDataSet(this);
            _PS = new PSDataSet(this);
            _PSA = new PSADataSet(this);
            _PSF = new PSFDataSet(this);
            _PX = new PXDataSet(this);
            _PX_NEW = new PX_NEWDataSet(this);
            _QB = new QBDataSet(this);
            _QS = new QSDataSet(this);
            _SA = new SADataSet(this);
            _SAB = new SABDataSet(this);
            _SABT = new SABTDataSet(this);
            _SACAG = new SACAGDataSet(this);
            _SAD = new SADDataSet(this);
            _SADAG = new SADAGDataSet(this);
            _SADP = new SADPDataSet(this);
            _SADW = new SADWDataSet(this);
            _SAI = new SAIDataSet(this);
            _SAII = new SAIIDataSet(this);
            _SAIM = new SAIMDataSet(this);
            _SAM = new SAMDataSet(this);
            _SAMA = new SAMADataSet(this);
            _SAP = new SAPDataSet(this);
            _SC = new SCDataSet(this);
            _SCA = new SCADataSet(this);
            _SCAM = new SCAMDataSet(this);
            _SCEN_ACL = new SCEN_ACLDataSet(this);
            _SCEN_ACV = new SCEN_ACVDataSet(this);
            _SCEN_APP = new SCEN_APPDataSet(this);
            _SCEN_ASE = new SCEN_ASEDataSet(this);
            _SCEN_AST = new SCEN_ASTDataSet(this);
            _SCEN_ASV = new SCEN_ASVDataSet(this);
            _SCEN_CL = new SCEN_CLDataSet(this);
            _SCEN_CLV = new SCEN_CLVDataSet(this);
            _SCEN_CVT = new SCEN_CVTDataSet(this);
            _SCEN_RFD = new SCEN_RFDDataSet(this);
            _SCEN_RPT = new SCEN_RPTDataSet(this);
            _SCEN_RTN = new SCEN_RTNDataSet(this);
            _SCEN_SCD = new SCEN_SCDDataSet(this);
            _SCEN_ST = new SCEN_STDataSet(this);
            _SCEN_STE = new SCEN_STEDataSet(this);
            _SCEN_STV = new SCEN_STVDataSet(this);
            _SCEN_SVT = new SCEN_SVTDataSet(this);
            _SCI = new SCIDataSet(this);
            _SCL = new SCLDataSet(this);
            _SCSF = new SCSFDataSet(this);
            _SCSFAG = new SCSFAGDataSet(this);
            _SDFC = new SDFCDataSet(this);
            _SDG = new SDGDataSet(this);
            _SDGM = new SDGMDataSet(this);
            _SDP = new SDPDataSet(this);
            _SDPA = new SDPADataSet(this);
            _SEC_ELOG = new SEC_ELOGDataSet(this);
            _SEC_LLOG = new SEC_LLOGDataSet(this);
            _SEC_MSG = new SEC_MSGDataSet(this);
            _SEC_URL = new SEC_URLDataSet(this);
            _SEC_USR = new SEC_USRDataSet(this);
            _SF = new SFDataSet(this);
            _SFAQ = new SFAQDataSet(this);
            _SFAV = new SFAVDataSet(this);
            _SFQA = new SFQADataSet(this);
            _SG = new SGDataSet(this);
            _SGAM = new SGAMDataSet(this);
            _SGHG = new SGHGDataSet(this);
            _SGM = new SGMDataSet(this);
            _SGMA = new SGMADataSet(this);
            _SGSC = new SGSCDataSet(this);
            _SGSG = new SGSGDataSet(this);
            _SGTRX = new SGTRXDataSet(this);
            _SID = new SIDDataSet(this);
            _SIDV = new SIDVDataSet(this);
            _SIRH = new SIRHDataSet(this);
            _SK_HRMS = new SK_HRMSDataSet(this);
            _SK_HRMST = new SK_HRMSTDataSet(this);
            _SKGS = new SKGSDataSet(this);
            _SM = new SMDataSet(this);
            _SMAQ = new SMAQDataSet(this);
            _SMAV = new SMAVDataSet(this);
            _SMC = new SMCDataSet(this);
            _SMC_TFR = new SMC_TFRDataSet(this);
            _SMCD = new SMCDDataSet(this);
            _SMGROUP = new SMGROUPDataSet(this);
            _SPEMAIL = new SPEMAILDataSet(this);
            _SPEPRINT = new SPEPRINTDataSet(this);
            _SPOUT = new SPOUTDataSet(this);
            _SPRECIP = new SPRECIPDataSet(this);
            _SPREPLY = new SPREPLYDataSet(this);
            _SPSMS = new SPSMSDataSet(this);
            _SPU = new SPUDataSet(this);
            _SRAG = new SRAGDataSet(this);
            _SS = new SSDataSet(this);
            _SSHG = new SSHGDataSet(this);
            _ST = new STDataSet(this);
            _ST_TFR = new ST_TFRDataSet(this);
            _ST_TFRIO = new ST_TFRIODataSet(this);
            _STBT = new STBTDataSet(this);
            _STMA = new STMADataSet(this);
            _STMB = new STMBDataSet(this);
            _STPO = new STPODataSet(this);
            _STPT = new STPTDataSet(this);
            _STRA = new STRADataSet(this);
            _STRE = new STREDataSet(this);
            _STSB = new STSBDataSet(this);
            _STSP = new STSPDataSet(this);
            _STTRIPS = new STTRIPSDataSet(this);
            _STVDI = new STVDIDataSet(this);
            _STVDO = new STVDODataSet(this);
            _SU = new SUDataSet(this);
            _SUBL = new SUBLDataSet(this);
            _SUPR = new SUPRDataSet(this);
            _SVAG = new SVAGDataSet(this);
            _SXAB = new SXABDataSet(this);
            _SXABCONV = new SXABCONVDataSet(this);
            _SXAS = new SXASDataSet(this);
            _SXHI = new SXHIDataSet(this);
            _TC = new TCDataSet(this);
            _TCAT = new TCATDataSet(this);
            _TCTB = new TCTBDataSet(this);
            _TCTD = new TCTDDataSet(this);
            _TCTQ = new TCTQDataSet(this);
            _TCTR = new TCTRDataSet(this);
            _TE = new TEDataSet(this);
            _TEC = new TECDataSet(this);
            _TETE = new TETEDataSet(this);
            _TETN = new TETNDataSet(this);
            _TH = new THDataSet(this);
            _THTN = new THTNDataSet(this);
            _THTQ = new THTQDataSet(this);
            _TRPMODE = new TRPMODEDataSet(this);
            _TRPROUT = new TRPROUTDataSet(this);
            _TRSTACC = new TRSTACCDataSet(this);
            _TT = new TTDataSet(this);
            _TTEF = new TTEFDataSet(this);
            _TTEI = new TTEIDataSet(this);
            _TTEP = new TTEPDataSet(this);
            _TTES = new TTESDataSet(this);
            _TTEX = new TTEXDataSet(this);
            _TTTG = new TTTGDataSet(this);
            _TXAS = new TXASDataSet(this);
            _TXHG = new TXHGDataSet(this);
            _UM = new UMDataSet(this);
            _UM_TFR = new UM_TFRDataSet(this);
        }

        /// <summary>
        /// Names of all Data Sets
        /// </summary>
        public IEnumerable<string> GetNames()
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
            yield return "DRB";
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
            yield return "KTM";
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
            yield return "SPRECIP";
            yield return "SPREPLY";
            yield return "SPSMS";
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

        /// <summary>
        /// Decrypted data IMPORT
        /// </summary>
        public A_DECRYPDataSet A_DECRYP { get { return _A_DECRYP; } }

        /// <summary>
        /// Assets - Sub-Category
        /// </summary>
        public AKBDataSet AKB { get { return _AKB; } }

        /// <summary>
        /// Assets - Categories
        /// </summary>
        public AKCDataSet AKC { get { return _AKC; } }

        /// <summary>
        /// Assets - Categories Tax
        /// </summary>
        public AKCTDataSet AKCT { get { return _AKCT; } }

        /// <summary>
        /// Assets - Departments
        /// </summary>
        public AKDDataSet AKD { get { return _AKD; } }

        /// <summary>
        /// Asset Key Holders
        /// </summary>
        public AKKDataSet AKK { get { return _AKK; } }

        /// <summary>
        /// Assets - Locations
        /// </summary>
        public AKLDataSet AKL { get { return _AKL; } }

        /// <summary>
        /// Asset Release Types
        /// </summary>
        public AKRDataSet AKR { get { return _AKR; } }

        /// <summary>
        /// Asset Types
        /// </summary>
        public AKTDataSet AKT { get { return _AKT; } }

        /// <summary>
        /// Assets
        /// </summary>
        public ARDataSet AR { get { return _AR; } }

        /// <summary>
        /// Asset Financial Transactions
        /// </summary>
        public ARFDataSet ARF { get { return _ARF; } }

        /// <summary>
        /// Books for Hire
        /// </summary>
        public BKHDataSet BKH { get { return _BKH; } }

        /// <summary>
        /// Book Hire Records
        /// </summary>
        public BKHRDataSet BKHR { get { return _BKHR; } }

        /// <summary>
        /// BPay Data
        /// </summary>
        public BPAY_DATDataSet BPAY_DAT { get { return _BPAY_DAT; } }

        /// <summary>
        /// Accounts Payable
        /// </summary>
        public CRDataSet CR { get { return _CR; } }

        /// <summary>
        /// Creditor Financial Transaction
        /// </summary>
        public CRFDataSet CRF { get { return _CRF; } }

        /// <summary>
        /// Creditor Fuel Tax Credits
        /// </summary>
        public CRFTCDataSet CRFTC { get { return _CRFTC; } }

        /// <summary>
        /// Families
        /// </summary>
        public DFDataSet DF { get { return _DF; } }

        /// <summary>
        /// DF Transfer
        /// </summary>
        public DF_TFRDataSet DF_TFR { get { return _DF_TFR; } }

        /// <summary>
        /// BPAY Receipts
        /// </summary>
        public DFBDataSet DFB { get { return _DFB; } }

        /// <summary>
        /// Family Financial Transactions
        /// </summary>
        public DFFDataSet DFF { get { return _DFF; } }

        /// <summary>
        /// Family History
        /// </summary>
        public DFHIDataSet DFHI { get { return _DFHI; } }

        /// <summary>
        /// Family Voluntary Transactions
        /// </summary>
        public DFVTDataSet DFVT { get { return _DFVT; } }

        /// <summary>
        /// Accounts Receivable
        /// </summary>
        public DRDataSet DR { get { return _DR; } }

        /// <summary>
        /// BPAY Receipts for Sundry Debtors
        /// </summary>
        public DRBDataSet DRB { get { return _DRB; } }

        /// <summary>
        /// DR Transactions
        /// </summary>
        public DRFDataSet DRF { get { return _DRF; } }

        /// <summary>
        /// Financial Data Export
        /// </summary>
        public FDT_EXPDataSet FDT_EXP { get { return _FDT_EXP; } }

        /// <summary>
        /// FDT Financial Raw Import Table
        /// </summary>
        public FDT_IMPDataSet FDT_IMP { get { return _FDT_IMP; } }

        /// <summary>
        /// FDT Financal Holding Table
        /// </summary>
        public FER_FDTDataSet FER_FDT { get { return _FER_FDT; } }

        /// <summary>
        /// Financial History
        /// </summary>
        public FINHISTDataSet FINHIST { get { return _FINHIST; } }

        /// <summary>
        /// General Ledger
        /// </summary>
        public GLDataSet GL { get { return _GL; } }

        /// <summary>
        /// Bank Account Details
        /// </summary>
        public GLBANKDataSet GLBANK { get { return _GLBANK; } }

        /// <summary>
        /// General Ledger Budgets
        /// </summary>
        public GLBUDGDataSet GLBUDG { get { return _GLBUDG; } }

        /// <summary>
        /// GL Combined Financial Trans
        /// </summary>
        public GLCFDataSet GLCF { get { return _GLCF; } }

        /// <summary>
        /// Last Years GL Combined Financial Trans
        /// </summary>
        public GLCFPREVDataSet GLCFPREV { get { return _GLCFPREV; } }

        /// <summary>
        /// General Ledger Transactions
        /// </summary>
        public GLFDataSet GLF { get { return _GLF; } }

        /// <summary>
        /// Financial Commitments
        /// </summary>
        public GLFBANKDataSet GLFBANK { get { return _GLFBANK; } }

        /// <summary>
        /// SP2 dummy table
        /// </summary>
        public GLFBUDGDataSet GLFBUDG { get { return _GLFBUDG; } }

        /// <summary>
        /// Last Years GL Financial Trans
        /// </summary>
        public GLFPREVDataSet GLFPREV { get { return _GLFPREV; } }

        /// <summary>
        /// Last Years General Ledger
        /// </summary>
        public GLPREVDataSet GLPREV { get { return _GLPREV; } }

        /// <summary>
        /// BSB Numbers
        /// </summary>
        public KABDataSet KAB { get { return _KAB; } }

        /// <summary>
        /// Delivery Addresses
        /// </summary>
        public KADDataSet KAD { get { return _KAD; } }

        /// <summary>
        /// Asset Depreciation Methods
        /// </summary>
        public KADMDataSet KADM { get { return _KADM; } }

        /// <summary>
        /// Standard Disciplinary Actions
        /// </summary>
        public KAMDataSet KAM { get { return _KAM; } }

        /// <summary>
        /// Australian Postcodes
        /// </summary>
        public KAPDataSet KAP { get { return _KAP; } }

        /// <summary>
        /// Bank Account
        /// </summary>
        public KBANKDataSet KBANK { get { return _KBANK; } }

        /// <summary>
        /// BPAY Receipts Import
        /// </summary>
        public KBPDataSet KBP { get { return _KBP; } }

        /// <summary>
        /// BPAY Temp Receipts Import
        /// </summary>
        public KBPTDataSet KBPT { get { return _KBPT; } }

        /// <summary>
        /// Behaviour Classifications
        /// </summary>
        public KCBDataSet KCB { get { return _KCB; } }

        /// <summary>
        /// Calendar Dates for Absences
        /// </summary>
        public KCCDataSet KCC { get { return _KCC; } }

        /// <summary>
        /// Doctors
        /// </summary>
        public KCDDataSet KCD { get { return _KCD; } }

        /// <summary>
        /// KCD Transfer
        /// </summary>
        public KCD_TFRDataSet KCD_TFR { get { return _KCD_TFR; } }

        /// <summary>
        /// Religious Instruction Curricula
        /// </summary>
        public KCIDataSet KCI { get { return _KCI; } }

        /// <summary>
        /// Medical Conditions
        /// </summary>
        public KCMDataSet KCM { get { return _KCM; } }

        /// <summary>
        /// KCM Transfer
        /// </summary>
        public KCM_TFRDataSet KCM_TFR { get { return _KCM_TFR; } }

        /// <summary>
        /// Cohorts for data aggregation
        /// </summary>
        public KCOHORTDataSet KCOHORT { get { return _KCOHORT; } }

        /// <summary>
        /// Transport Routes/Stops
        /// </summary>
        public KCRDataSet KCR { get { return _KCR; } }

        /// <summary>
        /// Absence Types
        /// </summary>
        public KCTDataSet KCT { get { return _KCT; } }

        /// <summary>
        /// Visa Subclasses
        /// </summary>
        public KCVDataSet KCV { get { return _KCV; } }

        /// <summary>
        /// Year Levels
        /// </summary>
        public KCYDataSet KCY { get { return _KCY; } }

        /// <summary>
        /// Data deleted from DataMirror monitored tables
        /// </summary>
        public KDELETEDataSet KDELETE { get { return _KDELETE; } }

        /// <summary>
        /// VELS Dimensions
        /// </summary>
        public KDIDataSet KDI { get { return _KDI; } }

        /// <summary>
        /// VELS Domains
        /// </summary>
        public KDODataSet KDO { get { return _KDO; } }

        /// <summary>
        /// CSEF Receipt details
        /// </summary>
        public KEMADataSet KEMA { get { return _KEMA; } }

        /// <summary>
        /// Import or Update Errors
        /// </summary>
        public KERRORDataSet KERROR { get { return _KERROR; } }

        /// <summary>
        /// Fuel Tax Credit Rates
        /// </summary>
        public KFTCDataSet KFTC { get { return _KFTC; } }

        /// <summary>
        /// Home Groups
        /// </summary>
        public KGCDataSet KGC { get { return _KGC; } }

        /// <summary>
        /// Home Group History
        /// </summary>
        public KGCHIDataSet KGCHI { get { return _KGCHI; } }

        /// <summary>
        /// Year 9-12 Exit Destinations
        /// </summary>
        public KGDDataSet KGD { get { return _KGD; } }

        /// <summary>
        /// Year 9-12 Exit Categories
        /// </summary>
        public KGGDataSet KGG { get { return _KGG; } }

        /// <summary>
        /// Houses
        /// </summary>
        public KGHDataSet KGH { get { return _KGH; } }

        /// <summary>
        /// Languages
        /// </summary>
        public KGLDataSet KGL { get { return _KGL; } }

        /// <summary>
        /// General Ledger Initiatives
        /// </summary>
        public KGLINITDataSet KGLINIT { get { return _KGLINIT; } }

        /// <summary>
        /// General Ledger Programs
        /// </summary>
        public KGLPROGDataSet KGLPROG { get { return _KGLPROG; } }

        /// <summary>
        /// General Ledger Sub Programs
        /// </summary>
        public KGLSUBDataSet KGLSUB { get { return _KGLSUB; } }

        /// <summary>
        /// General Ledger Account Types
        /// </summary>
        public KGLTDataSet KGLT { get { return _KGLT; } }

        /// <summary>
        /// Religions
        /// </summary>
        public KGRDataSet KGR { get { return _KGR; } }

        /// <summary>
        /// GST Percentages
        /// </summary>
        public KGSTDataSet KGST { get { return _KGST; } }

        /// <summary>
        /// Countries
        /// </summary>
        public KGTDataSet KGT { get { return _KGT; } }

        /// <summary>
        /// Awards and Prizes
        /// </summary>
        public KGWDataSet KGW { get { return _KGW; } }

        /// <summary>
        /// Trace log for finance import and export
        /// </summary>
        public KLOGDataSet KLOG { get { return _KLOG; } }

        /// <summary>
        /// General Ledger Notes
        /// </summary>
        public KNDataSet KN { get { return _KN; } }

        /// <summary>
        /// Family/Student ID Sequence Numbers
        /// </summary>
        public KNFSDataSet KNFS { get { return _KNFS; } }

        /// <summary>
        /// Contacts
        /// </summary>
        public KPCDataSet KPC { get { return _KPC; } }

        /// <summary>
        /// Contact Links
        /// </summary>
        public KPCLDataSet KPCL { get { return _KPCL; } }

        /// <summary>
        /// Contact Relationship
        /// </summary>
        public KPCRDataSet KPCR { get { return _KPCR; } }

        /// <summary>
        /// Employee Categories
        /// </summary>
        public KPECDataSet KPEC { get { return _KPEC; } }

        /// <summary>
        /// Note Categories
        /// </summary>
        public KPNDataSet KPN { get { return _KPN; } }

        /// <summary>
        /// PRMS Order Details
        /// </summary>
        public KPRMSDataSet KPRMS { get { return _KPRMS; } }

        /// <summary>
        /// Reports for emailing
        /// </summary>
        public KREPORTDataSet KREPORT { get { return _KREPORT; } }

        /// <summary>
        /// Role Codes
        /// </summary>
        public KROLEDataSet KROLE { get { return _KROLE; } }

        /// <summary>
        /// Areas of Teaching
        /// </summary>
        public KSADataSet KSA { get { return _KSA; } }

        /// <summary>
        /// Staff Positions
        /// </summary>
        public KSCDataSet KSC { get { return _KSC; } }

        /// <summary>
        /// Faculties
        /// </summary>
        public KSFDataSet KSF { get { return _KSF; } }

        /// <summary>
        /// Institutions
        /// </summary>
        public KSIDataSet KSI { get { return _KSI; } }

        /// <summary>
        /// Available Qualifications
        /// </summary>
        public KSQDataSet KSQ { get { return _KSQ; } }

        /// <summary>
        /// Timetable Import Errors
        /// </summary>
        public KTIEDataSet KTIE { get { return _KTIE; } }

        /// <summary>
        /// Task Message
        /// </summary>
        public KTMDataSet KTM { get { return _KTM; } }

        /// <summary>
        /// Student Transport Company
        /// </summary>
        public KTRCMPDataSet KTRCMP { get { return _KTRCMP; } }

        /// <summary>
        /// CASES Past Students
        /// </summary>
        public OSCSDataSet OSCS { get { return _OSCS; } }

        /// <summary>
        /// Cost Centres
        /// </summary>
        public PCDataSet PC { get { return _PC; } }

        /// <summary>
        /// Departments
        /// </summary>
        public PDDataSet PD { get { return _PD; } }

        /// <summary>
        /// Employees
        /// </summary>
        public PEDataSet PE { get { return _PE; } }

        /// <summary>
        /// Payroll Transactions
        /// </summary>
        public PEFDataSet PEF { get { return _PEF; } }

        /// <summary>
        /// Payroll Transaction History
        /// </summary>
        public PEFHDataSet PEFH { get { return _PEFH; } }

        /// <summary>
        /// Employee Leave Audit
        /// </summary>
        public PELADataSet PELA { get { return _PELA; } }

        /// <summary>
        /// Employee Leave Details
        /// </summary>
        public PELDDataSet PELD { get { return _PELD; } }

        /// <summary>
        /// Pay Advice Slip Message
        /// </summary>
        public PEMDataSet PEM { get { return _PEM; } }

        /// <summary>
        /// Pay Methods
        /// </summary>
        public PEPMDataSet PEPM { get { return _PEPM; } }

        /// <summary>
        /// Standard and Last Pays
        /// </summary>
        public PEPSDataSet PEPS { get { return _PEPS; } }

        /// <summary>
        /// Super (SGL and Employee) YTD Transactions
        /// </summary>
        public PEPUDataSet PEPU { get { return _PEPU; } }

        /// <summary>
        /// Super (SGL and Employee) History YTD Transactions
        /// </summary>
        public PEPUHDataSet PEPUH { get { return _PEPUH; } }

        /// <summary>
        /// Employee History
        /// </summary>
        public PEPYDataSet PEPY { get { return _PEPY; } }

        /// <summary>
        /// Employee Super LTD History
        /// </summary>
        public PESHDataSet PESH { get { return _PESH; } }

        /// <summary>
        /// Employee Super Payment Transactions
        /// </summary>
        public PESPDataSet PESP { get { return _PESP; } }

        /// <summary>
        /// Termination Payment
        /// </summary>
        public PETPDataSet PETP { get { return _PETP; } }

        /// <summary>
        /// Superannuation Funds
        /// </summary>
        public PFDataSet PF { get { return _PF; } }

        /// <summary>
        /// PAYG Payment Summary Box
        /// </summary>
        public PGDataSet PG { get { return _PG; } }

        /// <summary>
        /// Pay Items
        /// </summary>
        public PIDataSet PI { get { return _PI; } }

        /// <summary>
        /// Pay Item Leave Items
        /// </summary>
        public PILIDataSet PILI { get { return _PILI; } }

        /// <summary>
        /// Leave Code Description
        /// </summary>
        public PLCDataSet PLC { get { return _PLC; } }

        /// <summary>
        /// Leave Management Group
        /// </summary>
        public PLGDataSet PLG { get { return _PLG; } }

        /// <summary>
        /// Leave Group Types
        /// </summary>
        public PLTDataSet PLT { get { return _PLT; } }

        /// <summary>
        /// Medicare Levy Parameters
        /// </summary>
        public PMLDataSet PML { get { return _PML; } }

        /// <summary>
        /// Future Medicare Levy Parameters
        /// </summary>
        public PML_NEWDataSet PML_NEW { get { return _PML_NEW; } }

        /// <summary>
        /// Payroll Groups
        /// </summary>
        public PNDataSet PN { get { return _PN; } }

        /// <summary>
        /// PAYG Payer Details
        /// </summary>
        public PPDDataSet PPD { get { return _PPD; } }

        /// <summary>
        /// PAYG Supplier Details
        /// </summary>
        public PPSDataSet PPS { get { return _PPS; } }

        /// <summary>
        /// Pay Steps or Pay Class
        /// </summary>
        public PSDataSet PS { get { return _PS; } }

        /// <summary>
        /// Award Details
        /// </summary>
        public PSADataSet PSA { get { return _PSA; } }

        /// <summary>
        /// Future Pay Steps or Pay Class
        /// </summary>
        public PSFDataSet PSF { get { return _PSF; } }

        /// <summary>
        /// Tax Scales
        /// </summary>
        public PXDataSet PX { get { return _PX; } }

        /// <summary>
        /// Future Tax Scales
        /// </summary>
        public PX_NEWDataSet PX_NEW { get { return _PX_NEW; } }

        /// <summary>
        /// Batch Headers
        /// </summary>
        public QBDataSet QB { get { return _QB; } }

        /// <summary>
        /// Stored SQL
        /// </summary>
        public QSDataSet QS { get { return _QS; } }

        /// <summary>
        /// Fees
        /// </summary>
        public SADataSet SA { get { return _SA; } }

        /// <summary>
        /// Fees - Billing Templates
        /// </summary>
        public SABDataSet SAB { get { return _SAB; } }

        /// <summary>
        /// Billing Template Transactions
        /// </summary>
        public SABTDataSet SABT { get { return _SABT; } }

        /// <summary>
        /// Absence by Cohort Aggregations
        /// </summary>
        public SACAGDataSet SACAG { get { return _SACAG; } }

        /// <summary>
        /// Accidents
        /// </summary>
        public SADDataSet SAD { get { return _SAD; } }

        /// <summary>
        /// Absence by Cohort Aggregations
        /// </summary>
        public SADAGDataSet SADAG { get { return _SADAG; } }

        /// <summary>
        /// Accident Prevention Measures
        /// </summary>
        public SADPDataSet SADP { get { return _SADP; } }

        /// <summary>
        /// Accident Witnesses
        /// </summary>
        public SADWDataSet SADW { get { return _SADW; } }

        /// <summary>
        /// Accident Involvements/Sickbay Visits
        /// </summary>
        public SAIDataSet SAI { get { return _SAI; } }

        /// <summary>
        /// Accident Involvement Injuries
        /// </summary>
        public SAIIDataSet SAII { get { return _SAII; } }

        /// <summary>
        /// Sickbay Medication Administrations
        /// </summary>
        public SAIMDataSet SAIM { get { return _SAIM; } }

        /// <summary>
        /// School Association Members
        /// </summary>
        public SAMDataSet SAM { get { return _SAM; } }

        /// <summary>
        /// Association Member Attendances
        /// </summary>
        public SAMADataSet SAMA { get { return _SAMA; } }

        /// <summary>
        /// School Association Positions
        /// </summary>
        public SAPDataSet SAP { get { return _SAP; } }

        /// <summary>
        /// Courses
        /// </summary>
        public SCDataSet SC { get { return _SC; } }

        /// <summary>
        /// School Associations
        /// </summary>
        public SCADataSet SCA { get { return _SCA; } }

        /// <summary>
        /// School Association Meetings
        /// </summary>
        public SCAMDataSet SCAM { get { return _SCAM; } }

        /// <summary>
        /// Archived Census Class Sizes Data
        /// </summary>
        public SCEN_ACLDataSet SCEN_ACL { get { return _SCEN_ACL; } }

        /// <summary>
        /// Archived Census Class Sizes Validation Data
        /// </summary>
        public SCEN_ACVDataSet SCEN_ACV { get { return _SCEN_ACV; } }

        /// <summary>
        /// Census Application Message Data
        /// </summary>
        public SCEN_APPDataSet SCEN_APP { get { return _SCEN_APP; } }

        /// <summary>
        /// Archived Census Student Excluded Data
        /// </summary>
        public SCEN_ASEDataSet SCEN_ASE { get { return _SCEN_ASE; } }

        /// <summary>
        /// Archived Census Student Data
        /// </summary>
        public SCEN_ASTDataSet SCEN_AST { get { return _SCEN_AST; } }

        /// <summary>
        /// Archived Census Student Validation Data
        /// </summary>
        public SCEN_ASVDataSet SCEN_ASV { get { return _SCEN_ASV; } }

        /// <summary>
        /// Census Class Sizes Data
        /// </summary>
        public SCEN_CLDataSet SCEN_CL { get { return _SCEN_CL; } }

        /// <summary>
        /// Census Class Sizes Validation Data
        /// </summary>
        public SCEN_CLVDataSet SCEN_CLV { get { return _SCEN_CLV; } }

        /// <summary>
        /// Census Class Sizes Validation Type
        /// </summary>
        public SCEN_CVTDataSet SCEN_CVT { get { return _SCEN_CVT; } }

        /// <summary>
        /// Field-Display Metadata for Census Return Data
        /// </summary>
        public SCEN_RFDDataSet SCEN_RFD { get { return _SCEN_RFD; } }

        /// <summary>
        /// Census Report Usage Metadata
        /// </summary>
        public SCEN_RPTDataSet SCEN_RPT { get { return _SCEN_RPT; } }

        /// <summary>
        /// Census Return Summary Data
        /// </summary>
        public SCEN_RTNDataSet SCEN_RTN { get { return _SCEN_RTN; } }

        /// <summary>
        /// Column-Display Metadata for displaying Student Data
        /// </summary>
        public SCEN_SCDDataSet SCEN_SCD { get { return _SCEN_SCD; } }

        /// <summary>
        /// Census Student Data
        /// </summary>
        public SCEN_STDataSet SCEN_ST { get { return _SCEN_ST; } }

        /// <summary>
        /// Census Student Excluded Data
        /// </summary>
        public SCEN_STEDataSet SCEN_STE { get { return _SCEN_STE; } }

        /// <summary>
        /// Census Student Validation Data
        /// </summary>
        public SCEN_STVDataSet SCEN_STV { get { return _SCEN_STV; } }

        /// <summary>
        /// Census Student Validation Type Data
        /// </summary>
        public SCEN_SVTDataSet SCEN_SVT { get { return _SCEN_SVT; } }

        /// <summary>
        /// School Information
        /// </summary>
        public SCIDataSet SCI { get { return _SCI; } }

        /// <summary>
        /// Subject Classes
        /// </summary>
        public SCLDataSet SCL { get { return _SCL; } }

        /// <summary>
        /// CSF Strands
        /// </summary>
        public SCSFDataSet SCSF { get { return _SCSF; } }

        /// <summary>
        /// CSF Data Aggregates
        /// </summary>
        public SCSFAGDataSet SCSFAG { get { return _SCSFAG; } }

        /// <summary>
        /// Sundry Debtor Fees
        /// </summary>
        public SDFCDataSet SDFC { get { return _SDFC; } }

        /// <summary>
        /// Sundry Debtor Fee Groups
        /// </summary>
        public SDGDataSet SDG { get { return _SDG; } }

        /// <summary>
        /// Adult Group Members
        /// </summary>
        public SDGMDataSet SDGM { get { return _SDGM; } }

        /// <summary>
        /// Incident Instigators
        /// </summary>
        public SDPDataSet SDP { get { return _SDP; } }

        /// <summary>
        /// Disciplinary Actions
        /// </summary>
        public SDPADataSet SDPA { get { return _SDPA; } }

        /// <summary>
        /// eCASES21 Error Log
        /// </summary>
        public SEC_ELOGDataSet SEC_ELOG { get { return _SEC_ELOG; } }

        /// <summary>
        /// eCASES21 Login Log
        /// </summary>
        public SEC_LLOGDataSet SEC_LLOG { get { return _SEC_LLOG; } }

        /// <summary>
        /// eCASES21 School Message
        /// </summary>
        public SEC_MSGDataSet SEC_MSG { get { return _SEC_MSG; } }

        /// <summary>
        /// eCASES21 School Links URL
        /// </summary>
        public SEC_URLDataSet SEC_URL { get { return _SEC_URL; } }

        /// <summary>
        /// eCASES21 User Sessions
        /// </summary>
        public SEC_USRDataSet SEC_USR { get { return _SEC_USR; } }

        /// <summary>
        /// Staff
        /// </summary>
        public SFDataSet SF { get { return _SF; } }

        /// <summary>
        /// Staff Availability in Quilt
        /// </summary>
        public SFAQDataSet SFAQ { get { return _SFAQ; } }

        /// <summary>
        /// Staff Availability for Calendar Extras
        /// </summary>
        public SFAVDataSet SFAV { get { return _SFAV; } }

        /// <summary>
        /// Staff Qualifications
        /// </summary>
        public SFQADataSet SFQA { get { return _SFQA; } }

        /// <summary>
        /// Student Groupings
        /// </summary>
        public SGDataSet SG { get { return _SG; } }

        /// <summary>
        /// Adult Group Members
        /// </summary>
        public SGAMDataSet SGAM { get { return _SGAM; } }

        /// <summary>
        /// Home Group Eligibility Criteria
        /// </summary>
        public SGHGDataSet SGHG { get { return _SGHG; } }

        /// <summary>
        /// Special Group Meetings
        /// </summary>
        public SGMDataSet SGM { get { return _SGM; } }

        /// <summary>
        /// Group Meeting Attendance
        /// </summary>
        public SGMADataSet SGMA { get { return _SGMA; } }

        /// <summary>
        /// Subject/Class Eligibility Criteria
        /// </summary>
        public SGSCDataSet SGSC { get { return _SGSC; } }

        /// <summary>
        /// Group Membership Eligibility Criteria
        /// </summary>
        public SGSGDataSet SGSG { get { return _SGSG; } }

        /// <summary>
        /// Temporary Group Transactions
        /// </summary>
        public SGTRXDataSet SGTRX { get { return _SGTRX; } }

        /// <summary>
        /// Disciplinary Incidents
        /// </summary>
        public SIDDataSet SID { get { return _SID; } }

        /// <summary>
        /// Incident Victims/Recipients
        /// </summary>
        public SIDVDataSet SIDV { get { return _SIDV; } }

        /// <summary>
        /// On line receipt history
        /// </summary>
        public SIRHDataSet SIRH { get { return _SIRH; } }

        /// <summary>
        /// HRMS Import Table
        /// </summary>
        public SK_HRMSDataSet SK_HRMS { get { return _SK_HRMS; } }

        /// <summary>
        /// HRMS Temp Import Table
        /// </summary>
        public SK_HRMSTDataSet SK_HRMST { get { return _SK_HRMST; } }

        /// <summary>
        /// Schools
        /// </summary>
        public SKGSDataSet SKGS { get { return _SKGS; } }

        /// <summary>
        /// Rooms
        /// </summary>
        public SMDataSet SM { get { return _SM; } }

        /// <summary>
        /// Room Availability in Quilt
        /// </summary>
        public SMAQDataSet SMAQ { get { return _SMAQ; } }

        /// <summary>
        /// Room Availablity Extras
        /// </summary>
        public SMAVDataSet SMAV { get { return _SMAV; } }

        /// <summary>
        /// Student Medical Conditions
        /// </summary>
        public SMCDataSet SMC { get { return _SMC; } }

        /// <summary>
        /// SMC Transfer
        /// </summary>
        public SMC_TFRDataSet SMC_TFR { get { return _SMC_TFR; } }

        /// <summary>
        /// Student Medication Doses
        /// </summary>
        public SMCDDataSet SMCD { get { return _SMCD; } }

        /// <summary>
        /// Rooms group
        /// </summary>
        public SMGROUPDataSet SMGROUP { get { return _SMGROUP; } }

        /// <summary>
        /// Report email templates
        /// </summary>
        public SPEMAILDataSet SPEMAIL { get { return _SPEMAIL; } }

        /// <summary>
        /// Report file audit
        /// </summary>
        public SPEPRINTDataSet SPEPRINT { get { return _SPEPRINT; } }

        /// <summary>
        /// Stored Procedure Return Values
        /// </summary>
        public SPOUTDataSet SPOUT { get { return _SPOUT; } }

        /// <summary>
        /// SMS Recipients
        /// </summary>
        public SPRECIPDataSet SPRECIP { get { return _SPRECIP; } }

        /// <summary>
        /// SMS Recipients
        /// </summary>
        public SPREPLYDataSet SPREPLY { get { return _SPREPLY; } }

        /// <summary>
        /// SMS messages
        /// </summary>
        public SPSMSDataSet SPSMS { get { return _SPSMS; } }

        /// <summary>
        /// Publications
        /// </summary>
        public SPUDataSet SPU { get { return _SPU; } }

        /// <summary>
        /// FTE Student Retentions
        /// </summary>
        public SRAGDataSet SRAG { get { return _SRAG; } }

        /// <summary>
        /// Specialist Subjects
        /// </summary>
        public SSDataSet SS { get { return _SS; } }

        /// <summary>
        /// Specialist Subjects per Home Group
        /// </summary>
        public SSHGDataSet SSHG { get { return _SSHG; } }

        /// <summary>
        /// Students
        /// </summary>
        public STDataSet ST { get { return _ST; } }

        /// <summary>
        /// ST Transfer
        /// </summary>
        public ST_TFRDataSet ST_TFR { get { return _ST_TFR; } }

        /// <summary>
        /// Student Data Transfer Table
        /// </summary>
        public ST_TFRIODataSet ST_TFRIO { get { return _ST_TFRIO; } }

        /// <summary>
        /// Student Transport Usage
        /// </summary>
        public STBTDataSet STBT { get { return _STBT; } }

        /// <summary>
        /// Subject Selections &amp; Marks
        /// </summary>
        public STMADataSet STMA { get { return _STMA; } }

        /// <summary>
        /// Student Merit Behaviour Details
        /// </summary>
        public STMBDataSet STMB { get { return _STMB; } }

        /// <summary>
        /// Position or Group Memberships
        /// </summary>
        public STPODataSet STPO { get { return _STPO; } }

        /// <summary>
        /// Student Part-Time Enrolments
        /// </summary>
        public STPTDataSet STPT { get { return _STPT; } }

        /// <summary>
        /// Multiple Day Absences
        /// </summary>
        public STRADataSet STRA { get { return _STRA; } }

        /// <summary>
        /// Student Re-Enrolment
        /// </summary>
        public STREDataSet STRE { get { return _STRE; } }

        /// <summary>
        /// Family Invoice Allocations
        /// </summary>
        public STSBDataSet STSB { get { return _STSB; } }

        /// <summary>
        /// Suspension Details
        /// </summary>
        public STSPDataSet STSP { get { return _STSP; } }

        /// <summary>
        /// Student Trips
        /// </summary>
        public STTRIPSDataSet STTRIPS { get { return _STTRIPS; } }

        /// <summary>
        /// VELS Dimension Results
        /// </summary>
        public STVDIDataSet STVDI { get { return _STVDI; } }

        /// <summary>
        /// VELS Domain Results
        /// </summary>
        public STVDODataSet STVDO { get { return _STVDO; } }

        /// <summary>
        /// Subjects
        /// </summary>
        public SUDataSet SU { get { return _SU; } }

        /// <summary>
        /// Subject Book List
        /// </summary>
        public SUBLDataSet SUBL { get { return _SUBL; } }

        /// <summary>
        /// Subject Prerequisites
        /// </summary>
        public SUPRDataSet SUPR { get { return _SUPR; } }

        /// <summary>
        /// VELS Aggregated Dimensions
        /// </summary>
        public SVAGDataSet SVAG { get { return _SVAG; } }

        /// <summary>
        /// Student Half-Day Absences
        /// </summary>
        public SXABDataSet SXAB { get { return _SXAB; } }

        /// <summary>
        /// Converted Student Half-Day Absences
        /// </summary>
        public SXABCONVDataSet SXABCONV { get { return _SXABCONV; } }

        /// <summary>
        /// Student Scheduled Sessions
        /// </summary>
        public SXASDataSet SXAS { get { return _SXAS; } }

        /// <summary>
        /// Student History
        /// </summary>
        public SXHIDataSet SXHI { get { return _SXHI; } }

        /// <summary>
        /// Calendar
        /// </summary>
        public TCDataSet TC { get { return _TC; } }

        /// <summary>
        /// Staff Absence Types
        /// </summary>
        public TCATDataSet TCAT { get { return _TCAT; } }

        /// <summary>
        /// Teacher Absences
        /// </summary>
        public TCTBDataSet TCTB { get { return _TCTB; } }

        /// <summary>
        /// Calendar Period Information
        /// </summary>
        public TCTDDataSet TCTD { get { return _TCTD; } }

        /// <summary>
        /// Calendar Class Information
        /// </summary>
        public TCTQDataSet TCTQ { get { return _TCTQ; } }

        /// <summary>
        /// Teacher Replacements
        /// </summary>
        public TCTRDataSet TCTR { get { return _TCTR; } }

        /// <summary>
        /// Calendar Events
        /// </summary>
        public TEDataSet TE { get { return _TE; } }

        /// <summary>
        /// Event Categories
        /// </summary>
        public TECDataSet TEC { get { return _TEC; } }

        /// <summary>
        /// Event Instances
        /// </summary>
        public TETEDataSet TETE { get { return _TETE; } }

        /// <summary>
        /// Event Attendees
        /// </summary>
        public TETNDataSet TETN { get { return _TETN; } }

        /// <summary>
        /// Timetable Quilt Headers
        /// </summary>
        public THDataSet TH { get { return _TH; } }

        /// <summary>
        /// Timetable Labels
        /// </summary>
        public THTNDataSet THTN { get { return _THTN; } }

        /// <summary>
        /// Timetable Quilt Entries
        /// </summary>
        public THTQDataSet THTQ { get { return _THTQ; } }

        /// <summary>
        /// Transport Modes
        /// </summary>
        public TRPMODEDataSet TRPMODE { get { return _TRPMODE; } }

        /// <summary>
        /// Student Transport Routes
        /// </summary>
        public TRPROUTDataSet TRPROUT { get { return _TRPROUT; } }

        /// <summary>
        /// STACC Holding Table
        /// </summary>
        public TRSTACCDataSet TRSTACC { get { return _TRSTACC; } }

        /// <summary>
        /// Timetable Grid Templates
        /// </summary>
        public TTDataSet TT { get { return _TT; } }

        /// <summary>
        /// Exam Staff
        /// </summary>
        public TTEFDataSet TTEF { get { return _TTEF; } }

        /// <summary>
        /// Exam Details
        /// </summary>
        public TTEIDataSet TTEI { get { return _TTEI; } }

        /// <summary>
        /// Exam Periods
        /// </summary>
        public TTEPDataSet TTEP { get { return _TTEP; } }

        /// <summary>
        /// Exam Subjects
        /// </summary>
        public TTESDataSet TTES { get { return _TTES; } }

        /// <summary>
        /// Exam Grid
        /// </summary>
        public TTEXDataSet TTEX { get { return _TTEX; } }

        /// <summary>
        /// Grid Subjects
        /// </summary>
        public TTTGDataSet TTTG { get { return _TTTG; } }

        /// <summary>
        /// Actual Sessions
        /// </summary>
        public TXASDataSet TXAS { get { return _TXAS; } }

        /// <summary>
        /// Home Group Daily Attendance Records
        /// </summary>
        public TXHGDataSet TXHG { get { return _TXHG; } }

        /// <summary>
        /// Addresses
        /// </summary>
        public UMDataSet UM { get { return _UM; } }

        /// <summary>
        /// UM Transfer
        /// </summary>
        public UM_TFRDataSet UM_TFR { get { return _UM_TFR; } }
    }
}
