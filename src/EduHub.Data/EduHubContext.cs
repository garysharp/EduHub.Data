﻿using EduHub.Data.Entities;
using EduHub.Data.SeamlessViews;
using EduHub.Data.WriteBack;
using System;
using System.Collections.Generic;
using System.IO;

namespace EduHub.Data
{
    /// <summary>
    /// eduHub Data Context
    /// </summary>
    public partial class EduHubContext
    {
#region Set Fields
#if !EduHubScoped
        private readonly A_DECRYPDataSet _A_DECRYP;
        private readonly AIMSDataSet _AIMS;
        private readonly AKBDataSet _AKB;
#endif
        private readonly AKCDataSet _AKC;
#if !EduHubScoped
        private readonly AKCTDataSet _AKCT;
        private readonly AKDDataSet _AKD;
        private readonly AKKDataSet _AKK;
        private readonly AKLDataSet _AKL;
        private readonly AKRDataSet _AKR;
        private readonly AKTDataSet _AKT;
#endif
        private readonly ARDataSet _AR;
#if !EduHubScoped
        private readonly ARFDataSet _ARF;
        private readonly BANKSIGDataSet _BANKSIG;
        private readonly BKHDataSet _BKH;
        private readonly BKHRDataSet _BKHR;
        private readonly BPAY_DATDataSet _BPAY_DAT;
#endif
        private readonly CRDataSet _CR;
        private readonly CRFDataSet _CRF;
#if !EduHubScoped
        private readonly CRFTCDataSet _CRFTC;
        private readonly CRPRDataSet _CRPR;
        private readonly CRTTDataSet _CRTT;
#endif
        private readonly DFDataSet _DF;
#if !EduHubScoped
        private readonly DF_TFRDataSet _DF_TFR;
        private readonly DFBDataSet _DFB;
#endif
        private readonly DFFDataSet _DFF;
#if !EduHubScoped
        private readonly DFHIDataSet _DFHI;
#endif
        private readonly DFVTDataSet _DFVT;
        private readonly DRDataSet _DR;
#if !EduHubScoped
        private readonly DRBDataSet _DRB;
        private readonly DRFDataSet _DRF;
        private readonly FDT_EXPDataSet _FDT_EXP;
        private readonly FDT_IMPDataSet _FDT_IMP;
        private readonly FER_FDTDataSet _FER_FDT;
        private readonly FINHISTDataSet _FINHIST;
#endif
        private readonly GLDataSet _GL;
#if !EduHubScoped
        private readonly GLBANKDataSet _GLBANK;
#endif
        private readonly GLBUDGDataSet _GLBUDG;
#if !EduHubScoped
        private readonly GLCFDataSet _GLCF;
        private readonly GLCFPREVDataSet _GLCFPREV;
#endif
        private readonly GLFDataSet _GLF;
#if !EduHubScoped
        private readonly GLFBANKDataSet _GLFBANK;
        private readonly GLFBUDGDataSet _GLFBUDG;
        private readonly GLFPREVDataSet _GLFPREV;
        private readonly GLPREVDataSet _GLPREV;
#endif
        private readonly KABDataSet _KAB;
#if !EduHubScoped
        private readonly KABNDataSet _KABN;
#endif
        private readonly KADDataSet _KAD;
#if !EduHubScoped
        private readonly KADMDataSet _KADM;
        private readonly KAMDataSet _KAM;
        private readonly KAPDataSet _KAP;
        private readonly KBANKDataSet _KBANK;
        private readonly KBPDataSet _KBP;
        private readonly KBPTDataSet _KBPT;
        private readonly KCBDataSet _KCB;
#endif
        private readonly KCCDataSet _KCC;
        private readonly KCDDataSet _KCD;
#if !EduHubScoped
        private readonly KCD_TFRDataSet _KCD_TFR;
#endif
        private readonly KCIDataSet _KCI;
        private readonly KCMDataSet _KCM;
#if !EduHubScoped
        private readonly KCM_TFRDataSet _KCM_TFR;
        private readonly KCOHORTDataSet _KCOHORT;
        private readonly KCPCDataSet _KCPC;
        private readonly KCRDataSet _KCR;
#endif
        private readonly KCTDataSet _KCT;
        private readonly KCVDataSet _KCV;
        private readonly KCYDataSet _KCY;
#if !EduHubScoped
        private readonly KDELETEDataSet _KDELETE;
#endif
        private readonly KDIDataSet _KDI;
        private readonly KDODataSet _KDO;
#if !EduHubScoped
        private readonly KEMADataSet _KEMA;
        private readonly KEMAILDataSet _KEMAIL;
        private readonly KERRORDataSet _KERROR;
        private readonly KFLODataSet _KFLO;
        private readonly KFTCDataSet _KFTC;
        private readonly KFUNDDataSet _KFUND;
#endif
        private readonly KGCDataSet _KGC;
#if !EduHubScoped
        private readonly KGCHIDataSet _KGCHI;
        private readonly KGCVDataSet _KGCV;
#endif
        private readonly KGDDataSet _KGD;
        private readonly KGGDataSet _KGG;
        private readonly KGHDataSet _KGH;
        private readonly KGLDataSet _KGL;
        private readonly KGLINITDataSet _KGLINIT;
        private readonly KGLPROGDataSet _KGLPROG;
        private readonly KGLSUBDataSet _KGLSUB;
        private readonly KGLTDataSet _KGLT;
        private readonly KGODataSet _KGO;
#if !EduHubScoped
        private readonly KGO_TFRDataSet _KGO_TFR;
#endif
        private readonly KGRDataSet _KGR;
        private readonly KGSTDataSet _KGST;
        private readonly KGTDataSet _KGT;
#if !EduHubScoped
        private readonly KGWDataSet _KGW;
        private readonly KLOGDataSet _KLOG;
        private readonly KMSGDataSet _KMSG;
        private readonly KNDataSet _KN;
#endif
        private readonly KNATTDataSet _KNATT;
#if !EduHubScoped
        private readonly KNFSDataSet _KNFS;
        private readonly KNOTE_CRDataSet _KNOTE_CR;
        private readonly KNOTE_DRDataSet _KNOTE_DR;
        private readonly KPCDataSet _KPC;
        private readonly KPCLDataSet _KPCL;
        private readonly KPCRDataSet _KPCR;
        private readonly KPECDataSet _KPEC;
        private readonly KPHDataSet _KPH;
        private readonly KPNDataSet _KPN;
        private readonly KPRMSDataSet _KPRMS;
        private readonly KREPORTDataSet _KREPORT;
        private readonly KROLEDataSet _KROLE;
#endif
        private readonly KSADataSet _KSA;
        private readonly KSCDataSet _KSC;
#if !EduHubScoped
        private readonly KSCOREDataSet _KSCORE;
#endif
        private readonly KSFDataSet _KSF;
#if !EduHubScoped
        private readonly KSKGSDataSet _KSKGS;
        private readonly KSQDataSet _KSQ;
        private readonly KSTREETDataSet _KSTREET;
        private readonly KTIEDataSet _KTIE;
        private readonly KTMDataSet _KTM;
        private readonly KTRCMPDataSet _KTRCMP;
        private readonly KTTDataSet _KTT;
        private readonly KUPCDataSet _KUPC;
        private readonly OSCSDataSet _OSCS;
        private readonly PCDataSet _PC;
        private readonly PDDataSet _PD;
        private readonly PEDataSet _PE;
        private readonly PEFDataSet _PEF;
        private readonly PEFHDataSet _PEFH;
        private readonly PELADataSet _PELA;
        private readonly PELDDataSet _PELD;
        private readonly PEMDataSet _PEM;
        private readonly PEPMDataSet _PEPM;
        private readonly PEPSDataSet _PEPS;
        private readonly PEPUDataSet _PEPU;
        private readonly PEPUHDataSet _PEPUH;
        private readonly PEPYDataSet _PEPY;
        private readonly PESHDataSet _PESH;
        private readonly PESPDataSet _PESP;
        private readonly PETPDataSet _PETP;
        private readonly PFDataSet _PF;
        private readonly PGDataSet _PG;
        private readonly PGIDDataSet _PGID;
        private readonly PGLIDataSet _PGLI;
        private readonly PIDataSet _PI;
        private readonly PILIDataSet _PILI;
        private readonly PLCDataSet _PLC;
        private readonly PLGDataSet _PLG;
        private readonly PLTDataSet _PLT;
        private readonly PMLDataSet _PML;
        private readonly PML_NEWDataSet _PML_NEW;
        private readonly PNDataSet _PN;
#endif
        private readonly PPDDataSet _PPD;
#if !EduHubScoped
        private readonly PPSDataSet _PPS;
        private readonly PSDataSet _PS;
        private readonly PSADataSet _PSA;
        private readonly PSFDataSet _PSF;
        private readonly PXDataSet _PX;
        private readonly PX_NEWDataSet _PX_NEW;
        private readonly QBDataSet _QB;
        private readonly QSDataSet _QS;
        private readonly QSACDataSet _QSAC;
        private readonly QSADDataSet _QSAD;
        private readonly QSAGDataSet _QSAG;
        private readonly QSATDataSet _QSAT;
        private readonly RQDataSet _RQ;
        private readonly RQGLDataSet _RQGL;
        private readonly RQPGDataSet _RQPG;
        private readonly RQRELDataSet _RQREL;
        private readonly RQTDataSet _RQT;
#endif
        private readonly SADataSet _SA;
#if !EduHubScoped
        private readonly SABDataSet _SAB;
        private readonly SABTDataSet _SABT;
        private readonly SACAGDataSet _SACAG;
        private readonly SADDataSet _SAD;
        private readonly SADAGDataSet _SADAG;
        private readonly SADPDataSet _SADP;
        private readonly SADWDataSet _SADW;
        private readonly SAIDataSet _SAI;
        private readonly SAIIDataSet _SAII;
        private readonly SAIMDataSet _SAIM;
#endif
        private readonly SAMDataSet _SAM;
#if !EduHubScoped
        private readonly SAMADataSet _SAMA;
        private readonly SAPDataSet _SAP;
#endif
        private readonly SCDataSet _SC;
#if !EduHubScoped
        private readonly SCADataSet _SCA;
        private readonly SCAMDataSet _SCAM;
        private readonly SCEN_ACLDataSet _SCEN_ACL;
        private readonly SCEN_ACVDataSet _SCEN_ACV;
        private readonly SCEN_APPDataSet _SCEN_APP;
        private readonly SCEN_ASEDataSet _SCEN_ASE;
        private readonly SCEN_ASTDataSet _SCEN_AST;
        private readonly SCEN_ASVDataSet _SCEN_ASV;
        private readonly SCEN_CLDataSet _SCEN_CL;
        private readonly SCEN_CLVDataSet _SCEN_CLV;
        private readonly SCEN_CVTDataSet _SCEN_CVT;
        private readonly SCEN_RFDDataSet _SCEN_RFD;
        private readonly SCEN_RPTDataSet _SCEN_RPT;
        private readonly SCEN_RTNDataSet _SCEN_RTN;
        private readonly SCEN_SCDDataSet _SCEN_SCD;
        private readonly SCEN_STDataSet _SCEN_ST;
        private readonly SCEN_STEDataSet _SCEN_STE;
        private readonly SCEN_STVDataSet _SCEN_STV;
        private readonly SCEN_SVTDataSet _SCEN_SVT;
#endif
        private readonly SCIDataSet _SCI;
        private readonly SCLDataSet _SCL;
#if !EduHubScoped
        private readonly SCSFDataSet _SCSF;
        private readonly SCSFAGDataSet _SCSFAG;
        private readonly SDFCDataSet _SDFC;
        private readonly SDGDataSet _SDG;
        private readonly SDGMDataSet _SDGM;
        private readonly SDPDataSet _SDP;
        private readonly SDPADataSet _SDPA;
        private readonly SEC_ELOGDataSet _SEC_ELOG;
        private readonly SEC_LLOGDataSet _SEC_LLOG;
        private readonly SEC_MSGDataSet _SEC_MSG;
        private readonly SEC_URLDataSet _SEC_URL;
        private readonly SEC_USRDataSet _SEC_USR;
        private readonly SECMSGDataSet _SECMSG;
#endif
        private readonly SFDataSet _SF;
#if !EduHubScoped
        private readonly SFAQDataSet _SFAQ;
        private readonly SFAVDataSet _SFAV;
        private readonly SFQADataSet _SFQA;
#endif
        private readonly SGDataSet _SG;
#if !EduHubScoped
        private readonly SGAMDataSet _SGAM;
        private readonly SGFCDataSet _SGFC;
        private readonly SGHGDataSet _SGHG;
        private readonly SGMDataSet _SGM;
        private readonly SGMADataSet _SGMA;
        private readonly SGSCDataSet _SGSC;
        private readonly SGSGDataSet _SGSG;
        private readonly SGTRXDataSet _SGTRX;
        private readonly SIDDataSet _SID;
        private readonly SIDVDataSet _SIDV;
        private readonly SIRHDataSet _SIRH;
        private readonly SK_HRMSDataSet _SK_HRMS;
        private readonly SK_HRMSTDataSet _SK_HRMST;
#endif
        private readonly SKGSDataSet _SKGS;
#if !EduHubScoped
        private readonly SKGS_OLDDataSet _SKGS_OLD;
#endif
        private readonly SMDataSet _SM;
#if !EduHubScoped
        private readonly SMAQDataSet _SMAQ;
        private readonly SMAVDataSet _SMAV;
#endif
        private readonly SMCDataSet _SMC;
#if !EduHubScoped
        private readonly SMC_TFRDataSet _SMC_TFR;
        private readonly SMCDDataSet _SMCD;
        private readonly SMGROUPDataSet _SMGROUP;
        private readonly SP_RECIPDataSet _SP_RECIP;
        private readonly SP_REPLYDataSet _SP_REPLY;
        private readonly SPEMAILDataSet _SPEMAIL;
        private readonly SPEMRGDataSet _SPEMRG;
        private readonly SPEPRINTDataSet _SPEPRINT;
        private readonly SPFSHAREDataSet _SPFSHARE;
        private readonly SPFSTOREDataSet _SPFSTORE;
        private readonly SPOUTDataSet _SPOUT;
        private readonly SPRECIPDataSet _SPRECIP;
        private readonly SPREPLYDataSet _SPREPLY;
        private readonly SPRETRYDataSet _SPRETRY;
        private readonly SPSMSDataSet _SPSMS;
        private readonly SPUDataSet _SPU;
        private readonly SPWWWDataSet _SPWWW;
        private readonly SRAGDataSet _SRAG;
        private readonly SSDataSet _SS;
        private readonly SSHGDataSet _SSHG;
#endif
        private readonly STDataSet _ST;
#if !EduHubScoped
        private readonly ST_TFRDataSet _ST_TFR;
        private readonly ST_TFRIODataSet _ST_TFRIO;
#endif
        private readonly STARDataSet _STAR;
#if !EduHubScoped
        private readonly STAR_TFRDataSet _STAR_TFR;
        private readonly STBTDataSet _STBT;
        private readonly STFLODataSet _STFLO;
#endif
        private readonly STMADataSet _STMA;
#if !EduHubScoped
        private readonly STMBDataSet _STMB;
#endif
        private readonly STNATDataSet _STNAT;
#if !EduHubScoped
        private readonly STNAT_TRDataSet _STNAT_TR;
#endif
        private readonly STPODataSet _STPO;
        private readonly STPSDataSet _STPS;
#if !EduHubScoped
        private readonly STPS_TFRDataSet _STPS_TFR;
        private readonly STPTDataSet _STPT;
        private readonly STRADataSet _STRA;
        private readonly STREDataSet _STRE;
        private readonly STSBDataSet _STSB;
        private readonly STSPDataSet _STSP;
#endif
        private readonly STSUPDataSet _STSUP;
#if !EduHubScoped
        private readonly STSUP_TRDataSet _STSUP_TR;
        private readonly STTRIPSDataSet _STTRIPS;
#endif
        private readonly STVDIDataSet _STVDI;
#if !EduHubScoped
        private readonly STVDI_TRDataSet _STVDI_TR;
#endif
        private readonly STVDODataSet _STVDO;
#if !EduHubScoped
        private readonly STVDO_TRDataSet _STVDO_TR;
#endif
        private readonly SUDataSet _SU;
#if !EduHubScoped
        private readonly SUBLDataSet _SUBL;
        private readonly SUPRDataSet _SUPR;
        private readonly SVAGDataSet _SVAG;
#endif
        private readonly SXABDataSet _SXAB;
        private readonly SXABCONVDataSet _SXABCONV;
        private readonly SXASDataSet _SXAS;
#if !EduHubScoped
        private readonly SXHIDataSet _SXHI;
#endif
        private readonly TCDataSet _TC;
        private readonly TCATDataSet _TCAT;
        private readonly TCTBDataSet _TCTB;
        private readonly TCTDDataSet _TCTD;
        private readonly TCTQDataSet _TCTQ;
        private readonly TCTRDataSet _TCTR;
        private readonly TEDataSet _TE;
        private readonly TECDataSet _TEC;
#if !EduHubScoped
        private readonly TETEDataSet _TETE;
        private readonly TETNDataSet _TETN;
#endif
        private readonly THDataSet _TH;
        private readonly THTNDataSet _THTN;
        private readonly THTQDataSet _THTQ;
#if !EduHubScoped
        private readonly TRPMODEDataSet _TRPMODE;
        private readonly TRPROUTDataSet _TRPROUT;
        private readonly TRSTACCDataSet _TRSTACC;
#endif
        private readonly TTDataSet _TT;
#if !EduHubScoped
        private readonly TTEFDataSet _TTEF;
        private readonly TTEIDataSet _TTEI;
        private readonly TTEPDataSet _TTEP;
        private readonly TTESDataSet _TTES;
        private readonly TTEXDataSet _TTEX;
#endif
        private readonly TTTGDataSet _TTTG;
        private readonly TXASDataSet _TXAS;
        private readonly TXHGDataSet _TXHG;
        private readonly UMDataSet _UM;
#if !EduHubScoped
        private readonly UM_TFRDataSet _UM_TFR;
#endif
#endregion

        /// <summary>
        /// Creates an EduHubContextBase
        /// </summary>
        /// <param name="EduHubDirectory">Directory which contains the eduHub CSV Data Sets</param>
        /// <param name="EduHubSiteIdentifier">Data Set Suffix for each CSV file</param>
        /// <exception cref="ArgumentException">eduHub Directory does not exist, has no valid data sets or contains multiple data sets</exception>
        public EduHubContext(string EduHubDirectory, string EduHubSiteIdentifier)
        {
            // Use default directory if none provided
            if (string.IsNullOrWhiteSpace(EduHubDirectory))
            {
                EduHubDirectory = DefaultEduHubDirectory;
            }

            // Use default identifier if none provided
            if (string.IsNullOrWhiteSpace(EduHubSiteIdentifier))
            {
                if (DefaultEduHubSiteIdentifier == null)
                {
                    DefaultEduHubSiteIdentifier = GetSiteIdentifier(EduHubDirectory);
                }
                EduHubSiteIdentifier = DefaultEduHubSiteIdentifier;
            }

            // Ensure directory exists
            if (!Directory.Exists(EduHubDirectory))
                throw new ArgumentException($"EduHub Directory [{EduHubDirectory}] does not exist");

            this.EduHubDirectory = EduHubDirectory;
            this.EduHubSiteIdentifier = EduHubSiteIdentifier;

#if !EduHubScoped
            _A_DECRYP = new A_DECRYPDataSet(this);
            _AIMS = new AIMSDataSet(this);
            _AKB = new AKBDataSet(this);
#endif
            _AKC = new AKCDataSet(this);
#if !EduHubScoped
            _AKCT = new AKCTDataSet(this);
            _AKD = new AKDDataSet(this);
            _AKK = new AKKDataSet(this);
            _AKL = new AKLDataSet(this);
            _AKR = new AKRDataSet(this);
            _AKT = new AKTDataSet(this);
#endif
            _AR = new ARDataSet(this);
#if !EduHubScoped
            _ARF = new ARFDataSet(this);
            _BANKSIG = new BANKSIGDataSet(this);
            _BKH = new BKHDataSet(this);
            _BKHR = new BKHRDataSet(this);
            _BPAY_DAT = new BPAY_DATDataSet(this);
#endif
            _CR = new CRDataSet(this);
            _CRF = new CRFDataSet(this);
#if !EduHubScoped
            _CRFTC = new CRFTCDataSet(this);
            _CRPR = new CRPRDataSet(this);
            _CRTT = new CRTTDataSet(this);
#endif
            _DF = new DFDataSet(this);
#if !EduHubScoped
            _DF_TFR = new DF_TFRDataSet(this);
            _DFB = new DFBDataSet(this);
#endif
            _DFF = new DFFDataSet(this);
#if !EduHubScoped
            _DFHI = new DFHIDataSet(this);
#endif
            _DFVT = new DFVTDataSet(this);
            _DR = new DRDataSet(this);
#if !EduHubScoped
            _DRB = new DRBDataSet(this);
            _DRF = new DRFDataSet(this);
            _FDT_EXP = new FDT_EXPDataSet(this);
            _FDT_IMP = new FDT_IMPDataSet(this);
            _FER_FDT = new FER_FDTDataSet(this);
            _FINHIST = new FINHISTDataSet(this);
#endif
            _GL = new GLDataSet(this);
#if !EduHubScoped
            _GLBANK = new GLBANKDataSet(this);
#endif
            _GLBUDG = new GLBUDGDataSet(this);
#if !EduHubScoped
            _GLCF = new GLCFDataSet(this);
            _GLCFPREV = new GLCFPREVDataSet(this);
#endif
            _GLF = new GLFDataSet(this);
#if !EduHubScoped
            _GLFBANK = new GLFBANKDataSet(this);
            _GLFBUDG = new GLFBUDGDataSet(this);
            _GLFPREV = new GLFPREVDataSet(this);
            _GLPREV = new GLPREVDataSet(this);
#endif
            _KAB = new KABDataSet(this);
#if !EduHubScoped
            _KABN = new KABNDataSet(this);
#endif
            _KAD = new KADDataSet(this);
#if !EduHubScoped
            _KADM = new KADMDataSet(this);
            _KAM = new KAMDataSet(this);
            _KAP = new KAPDataSet(this);
            _KBANK = new KBANKDataSet(this);
            _KBP = new KBPDataSet(this);
            _KBPT = new KBPTDataSet(this);
            _KCB = new KCBDataSet(this);
#endif
            _KCC = new KCCDataSet(this);
            _KCD = new KCDDataSet(this);
#if !EduHubScoped
            _KCD_TFR = new KCD_TFRDataSet(this);
#endif
            _KCI = new KCIDataSet(this);
            _KCM = new KCMDataSet(this);
#if !EduHubScoped
            _KCM_TFR = new KCM_TFRDataSet(this);
            _KCOHORT = new KCOHORTDataSet(this);
            _KCPC = new KCPCDataSet(this);
            _KCR = new KCRDataSet(this);
#endif
            _KCT = new KCTDataSet(this);
            _KCV = new KCVDataSet(this);
            _KCY = new KCYDataSet(this);
#if !EduHubScoped
            _KDELETE = new KDELETEDataSet(this);
#endif
            _KDI = new KDIDataSet(this);
            _KDO = new KDODataSet(this);
#if !EduHubScoped
            _KEMA = new KEMADataSet(this);
            _KEMAIL = new KEMAILDataSet(this);
            _KERROR = new KERRORDataSet(this);
            _KFLO = new KFLODataSet(this);
            _KFTC = new KFTCDataSet(this);
            _KFUND = new KFUNDDataSet(this);
#endif
            _KGC = new KGCDataSet(this);
#if !EduHubScoped
            _KGCHI = new KGCHIDataSet(this);
            _KGCV = new KGCVDataSet(this);
#endif
            _KGD = new KGDDataSet(this);
            _KGG = new KGGDataSet(this);
            _KGH = new KGHDataSet(this);
            _KGL = new KGLDataSet(this);
            _KGLINIT = new KGLINITDataSet(this);
            _KGLPROG = new KGLPROGDataSet(this);
            _KGLSUB = new KGLSUBDataSet(this);
            _KGLT = new KGLTDataSet(this);
            _KGO = new KGODataSet(this);
#if !EduHubScoped
            _KGO_TFR = new KGO_TFRDataSet(this);
#endif
            _KGR = new KGRDataSet(this);
            _KGST = new KGSTDataSet(this);
            _KGT = new KGTDataSet(this);
#if !EduHubScoped
            _KGW = new KGWDataSet(this);
            _KLOG = new KLOGDataSet(this);
            _KMSG = new KMSGDataSet(this);
            _KN = new KNDataSet(this);
#endif
            _KNATT = new KNATTDataSet(this);
#if !EduHubScoped
            _KNFS = new KNFSDataSet(this);
            _KNOTE_CR = new KNOTE_CRDataSet(this);
            _KNOTE_DR = new KNOTE_DRDataSet(this);
            _KPC = new KPCDataSet(this);
            _KPCL = new KPCLDataSet(this);
            _KPCR = new KPCRDataSet(this);
            _KPEC = new KPECDataSet(this);
            _KPH = new KPHDataSet(this);
            _KPN = new KPNDataSet(this);
            _KPRMS = new KPRMSDataSet(this);
            _KREPORT = new KREPORTDataSet(this);
            _KROLE = new KROLEDataSet(this);
#endif
            _KSA = new KSADataSet(this);
            _KSC = new KSCDataSet(this);
#if !EduHubScoped
            _KSCORE = new KSCOREDataSet(this);
#endif
            _KSF = new KSFDataSet(this);
#if !EduHubScoped
            _KSKGS = new KSKGSDataSet(this);
            _KSQ = new KSQDataSet(this);
            _KSTREET = new KSTREETDataSet(this);
            _KTIE = new KTIEDataSet(this);
            _KTM = new KTMDataSet(this);
            _KTRCMP = new KTRCMPDataSet(this);
            _KTT = new KTTDataSet(this);
            _KUPC = new KUPCDataSet(this);
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
            _PGID = new PGIDDataSet(this);
            _PGLI = new PGLIDataSet(this);
            _PI = new PIDataSet(this);
            _PILI = new PILIDataSet(this);
            _PLC = new PLCDataSet(this);
            _PLG = new PLGDataSet(this);
            _PLT = new PLTDataSet(this);
            _PML = new PMLDataSet(this);
            _PML_NEW = new PML_NEWDataSet(this);
            _PN = new PNDataSet(this);
#endif
            _PPD = new PPDDataSet(this);
#if !EduHubScoped
            _PPS = new PPSDataSet(this);
            _PS = new PSDataSet(this);
            _PSA = new PSADataSet(this);
            _PSF = new PSFDataSet(this);
            _PX = new PXDataSet(this);
            _PX_NEW = new PX_NEWDataSet(this);
            _QB = new QBDataSet(this);
            _QS = new QSDataSet(this);
            _QSAC = new QSACDataSet(this);
            _QSAD = new QSADDataSet(this);
            _QSAG = new QSAGDataSet(this);
            _QSAT = new QSATDataSet(this);
            _RQ = new RQDataSet(this);
            _RQGL = new RQGLDataSet(this);
            _RQPG = new RQPGDataSet(this);
            _RQREL = new RQRELDataSet(this);
            _RQT = new RQTDataSet(this);
#endif
            _SA = new SADataSet(this);
#if !EduHubScoped
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
#endif
            _SAM = new SAMDataSet(this);
#if !EduHubScoped
            _SAMA = new SAMADataSet(this);
            _SAP = new SAPDataSet(this);
#endif
            _SC = new SCDataSet(this);
#if !EduHubScoped
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
#endif
            _SCI = new SCIDataSet(this);
            _SCL = new SCLDataSet(this);
#if !EduHubScoped
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
            _SECMSG = new SECMSGDataSet(this);
#endif
            _SF = new SFDataSet(this);
#if !EduHubScoped
            _SFAQ = new SFAQDataSet(this);
            _SFAV = new SFAVDataSet(this);
            _SFQA = new SFQADataSet(this);
#endif
            _SG = new SGDataSet(this);
#if !EduHubScoped
            _SGAM = new SGAMDataSet(this);
            _SGFC = new SGFCDataSet(this);
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
#endif
            _SKGS = new SKGSDataSet(this);
#if !EduHubScoped
            _SKGS_OLD = new SKGS_OLDDataSet(this);
#endif
            _SM = new SMDataSet(this);
#if !EduHubScoped
            _SMAQ = new SMAQDataSet(this);
            _SMAV = new SMAVDataSet(this);
#endif
            _SMC = new SMCDataSet(this);
#if !EduHubScoped
            _SMC_TFR = new SMC_TFRDataSet(this);
            _SMCD = new SMCDDataSet(this);
            _SMGROUP = new SMGROUPDataSet(this);
            _SP_RECIP = new SP_RECIPDataSet(this);
            _SP_REPLY = new SP_REPLYDataSet(this);
            _SPEMAIL = new SPEMAILDataSet(this);
            _SPEMRG = new SPEMRGDataSet(this);
            _SPEPRINT = new SPEPRINTDataSet(this);
            _SPFSHARE = new SPFSHAREDataSet(this);
            _SPFSTORE = new SPFSTOREDataSet(this);
            _SPOUT = new SPOUTDataSet(this);
            _SPRECIP = new SPRECIPDataSet(this);
            _SPREPLY = new SPREPLYDataSet(this);
            _SPRETRY = new SPRETRYDataSet(this);
            _SPSMS = new SPSMSDataSet(this);
            _SPU = new SPUDataSet(this);
            _SPWWW = new SPWWWDataSet(this);
            _SRAG = new SRAGDataSet(this);
            _SS = new SSDataSet(this);
            _SSHG = new SSHGDataSet(this);
#endif
            _ST = new STDataSet(this);
#if !EduHubScoped
            _ST_TFR = new ST_TFRDataSet(this);
            _ST_TFRIO = new ST_TFRIODataSet(this);
#endif
            _STAR = new STARDataSet(this);
#if !EduHubScoped
            _STAR_TFR = new STAR_TFRDataSet(this);
            _STBT = new STBTDataSet(this);
            _STFLO = new STFLODataSet(this);
#endif
            _STMA = new STMADataSet(this);
#if !EduHubScoped
            _STMB = new STMBDataSet(this);
#endif
            _STNAT = new STNATDataSet(this);
#if !EduHubScoped
            _STNAT_TR = new STNAT_TRDataSet(this);
#endif
            _STPO = new STPODataSet(this);
            _STPS = new STPSDataSet(this);
#if !EduHubScoped
            _STPS_TFR = new STPS_TFRDataSet(this);
            _STPT = new STPTDataSet(this);
            _STRA = new STRADataSet(this);
            _STRE = new STREDataSet(this);
            _STSB = new STSBDataSet(this);
            _STSP = new STSPDataSet(this);
#endif
            _STSUP = new STSUPDataSet(this);
#if !EduHubScoped
            _STSUP_TR = new STSUP_TRDataSet(this);
            _STTRIPS = new STTRIPSDataSet(this);
#endif
            _STVDI = new STVDIDataSet(this);
#if !EduHubScoped
            _STVDI_TR = new STVDI_TRDataSet(this);
#endif
            _STVDO = new STVDODataSet(this);
#if !EduHubScoped
            _STVDO_TR = new STVDO_TRDataSet(this);
#endif
            _SU = new SUDataSet(this);
#if !EduHubScoped
            _SUBL = new SUBLDataSet(this);
            _SUPR = new SUPRDataSet(this);
            _SVAG = new SVAGDataSet(this);
#endif
            _SXAB = new SXABDataSet(this);
            _SXABCONV = new SXABCONVDataSet(this);
            _SXAS = new SXASDataSet(this);
#if !EduHubScoped
            _SXHI = new SXHIDataSet(this);
#endif
            _TC = new TCDataSet(this);
            _TCAT = new TCATDataSet(this);
            _TCTB = new TCTBDataSet(this);
            _TCTD = new TCTDDataSet(this);
            _TCTQ = new TCTQDataSet(this);
            _TCTR = new TCTRDataSet(this);
            _TE = new TEDataSet(this);
            _TEC = new TECDataSet(this);
#if !EduHubScoped
            _TETE = new TETEDataSet(this);
            _TETN = new TETNDataSet(this);
#endif
            _TH = new THDataSet(this);
            _THTN = new THTNDataSet(this);
            _THTQ = new THTQDataSet(this);
#if !EduHubScoped
            _TRPMODE = new TRPMODEDataSet(this);
            _TRPROUT = new TRPROUTDataSet(this);
            _TRSTACC = new TRSTACCDataSet(this);
#endif
            _TT = new TTDataSet(this);
#if !EduHubScoped
            _TTEF = new TTEFDataSet(this);
            _TTEI = new TTEIDataSet(this);
            _TTEP = new TTEPDataSet(this);
            _TTES = new TTESDataSet(this);
            _TTEX = new TTEXDataSet(this);
#endif
            _TTTG = new TTTGDataSet(this);
            _TXAS = new TXASDataSet(this);
            _TXHG = new TXHGDataSet(this);
            _UM = new UMDataSet(this);
#if !EduHubScoped
            _UM_TFR = new UM_TFRDataSet(this);
#endif

            SeamlessViews = new SeamlessViewsContext(this);
            WriteBack = new WriteBackContext(this);
        }

        /// <summary>
        /// All EduHub Data Sets
        /// </summary>
        public IEnumerable<IEduHubDataSet> GetDataSets()
        {
#if !EduHubScoped
            yield return A_DECRYP;
            yield return AIMS;
            yield return AKB;
#endif
            yield return AKC;
#if !EduHubScoped
            yield return AKCT;
            yield return AKD;
            yield return AKK;
            yield return AKL;
            yield return AKR;
            yield return AKT;
#endif
            yield return AR;
#if !EduHubScoped
            yield return ARF;
            yield return BANKSIG;
            yield return BKH;
            yield return BKHR;
            yield return BPAY_DAT;
#endif
            yield return CR;
            yield return CRF;
#if !EduHubScoped
            yield return CRFTC;
            yield return CRPR;
            yield return CRTT;
#endif
            yield return DF;
#if !EduHubScoped
            yield return DF_TFR;
            yield return DFB;
#endif
            yield return DFF;
#if !EduHubScoped
            yield return DFHI;
#endif
            yield return DFVT;
            yield return DR;
#if !EduHubScoped
            yield return DRB;
            yield return DRF;
            yield return FDT_EXP;
            yield return FDT_IMP;
            yield return FER_FDT;
            yield return FINHIST;
#endif
            yield return GL;
#if !EduHubScoped
            yield return GLBANK;
#endif
            yield return GLBUDG;
#if !EduHubScoped
            yield return GLCF;
            yield return GLCFPREV;
#endif
            yield return GLF;
#if !EduHubScoped
            yield return GLFBANK;
            yield return GLFBUDG;
            yield return GLFPREV;
            yield return GLPREV;
#endif
            yield return KAB;
#if !EduHubScoped
            yield return KABN;
#endif
            yield return KAD;
#if !EduHubScoped
            yield return KADM;
            yield return KAM;
            yield return KAP;
            yield return KBANK;
            yield return KBP;
            yield return KBPT;
            yield return KCB;
#endif
            yield return KCC;
            yield return KCD;
#if !EduHubScoped
            yield return KCD_TFR;
#endif
            yield return KCI;
            yield return KCM;
#if !EduHubScoped
            yield return KCM_TFR;
            yield return KCOHORT;
            yield return KCPC;
            yield return KCR;
#endif
            yield return KCT;
            yield return KCV;
            yield return KCY;
#if !EduHubScoped
            yield return KDELETE;
#endif
            yield return KDI;
            yield return KDO;
#if !EduHubScoped
            yield return KEMA;
            yield return KEMAIL;
            yield return KERROR;
            yield return KFLO;
            yield return KFTC;
            yield return KFUND;
#endif
            yield return KGC;
#if !EduHubScoped
            yield return KGCHI;
            yield return KGCV;
#endif
            yield return KGD;
            yield return KGG;
            yield return KGH;
            yield return KGL;
            yield return KGLINIT;
            yield return KGLPROG;
            yield return KGLSUB;
            yield return KGLT;
            yield return KGO;
#if !EduHubScoped
            yield return KGO_TFR;
#endif
            yield return KGR;
            yield return KGST;
            yield return KGT;
#if !EduHubScoped
            yield return KGW;
            yield return KLOG;
            yield return KMSG;
            yield return KN;
#endif
            yield return KNATT;
#if !EduHubScoped
            yield return KNFS;
            yield return KNOTE_CR;
            yield return KNOTE_DR;
            yield return KPC;
            yield return KPCL;
            yield return KPCR;
            yield return KPEC;
            yield return KPH;
            yield return KPN;
            yield return KPRMS;
            yield return KREPORT;
            yield return KROLE;
#endif
            yield return KSA;
            yield return KSC;
#if !EduHubScoped
            yield return KSCORE;
#endif
            yield return KSF;
#if !EduHubScoped
            yield return KSKGS;
            yield return KSQ;
            yield return KSTREET;
            yield return KTIE;
            yield return KTM;
            yield return KTRCMP;
            yield return KTT;
            yield return KUPC;
            yield return OSCS;
            yield return PC;
            yield return PD;
            yield return PE;
            yield return PEF;
            yield return PEFH;
            yield return PELA;
            yield return PELD;
            yield return PEM;
            yield return PEPM;
            yield return PEPS;
            yield return PEPU;
            yield return PEPUH;
            yield return PEPY;
            yield return PESH;
            yield return PESP;
            yield return PETP;
            yield return PF;
            yield return PG;
            yield return PGID;
            yield return PGLI;
            yield return PI;
            yield return PILI;
            yield return PLC;
            yield return PLG;
            yield return PLT;
            yield return PML;
            yield return PML_NEW;
            yield return PN;
#endif
            yield return PPD;
#if !EduHubScoped
            yield return PPS;
            yield return PS;
            yield return PSA;
            yield return PSF;
            yield return PX;
            yield return PX_NEW;
            yield return QB;
            yield return QS;
            yield return QSAC;
            yield return QSAD;
            yield return QSAG;
            yield return QSAT;
            yield return RQ;
            yield return RQGL;
            yield return RQPG;
            yield return RQREL;
            yield return RQT;
#endif
            yield return SA;
#if !EduHubScoped
            yield return SAB;
            yield return SABT;
            yield return SACAG;
            yield return SAD;
            yield return SADAG;
            yield return SADP;
            yield return SADW;
            yield return SAI;
            yield return SAII;
            yield return SAIM;
#endif
            yield return SAM;
#if !EduHubScoped
            yield return SAMA;
            yield return SAP;
#endif
            yield return SC;
#if !EduHubScoped
            yield return SCA;
            yield return SCAM;
            yield return SCEN_ACL;
            yield return SCEN_ACV;
            yield return SCEN_APP;
            yield return SCEN_ASE;
            yield return SCEN_AST;
            yield return SCEN_ASV;
            yield return SCEN_CL;
            yield return SCEN_CLV;
            yield return SCEN_CVT;
            yield return SCEN_RFD;
            yield return SCEN_RPT;
            yield return SCEN_RTN;
            yield return SCEN_SCD;
            yield return SCEN_ST;
            yield return SCEN_STE;
            yield return SCEN_STV;
            yield return SCEN_SVT;
#endif
            yield return SCI;
            yield return SCL;
#if !EduHubScoped
            yield return SCSF;
            yield return SCSFAG;
            yield return SDFC;
            yield return SDG;
            yield return SDGM;
            yield return SDP;
            yield return SDPA;
            yield return SEC_ELOG;
            yield return SEC_LLOG;
            yield return SEC_MSG;
            yield return SEC_URL;
            yield return SEC_USR;
            yield return SECMSG;
#endif
            yield return SF;
#if !EduHubScoped
            yield return SFAQ;
            yield return SFAV;
            yield return SFQA;
#endif
            yield return SG;
#if !EduHubScoped
            yield return SGAM;
            yield return SGFC;
            yield return SGHG;
            yield return SGM;
            yield return SGMA;
            yield return SGSC;
            yield return SGSG;
            yield return SGTRX;
            yield return SID;
            yield return SIDV;
            yield return SIRH;
            yield return SK_HRMS;
            yield return SK_HRMST;
#endif
            yield return SKGS;
#if !EduHubScoped
            yield return SKGS_OLD;
#endif
            yield return SM;
#if !EduHubScoped
            yield return SMAQ;
            yield return SMAV;
#endif
            yield return SMC;
#if !EduHubScoped
            yield return SMC_TFR;
            yield return SMCD;
            yield return SMGROUP;
            yield return SP_RECIP;
            yield return SP_REPLY;
            yield return SPEMAIL;
            yield return SPEMRG;
            yield return SPEPRINT;
            yield return SPFSHARE;
            yield return SPFSTORE;
            yield return SPOUT;
            yield return SPRECIP;
            yield return SPREPLY;
            yield return SPRETRY;
            yield return SPSMS;
            yield return SPU;
            yield return SPWWW;
            yield return SRAG;
            yield return SS;
            yield return SSHG;
#endif
            yield return ST;
#if !EduHubScoped
            yield return ST_TFR;
            yield return ST_TFRIO;
#endif
            yield return STAR;
#if !EduHubScoped
            yield return STAR_TFR;
            yield return STBT;
            yield return STFLO;
#endif
            yield return STMA;
#if !EduHubScoped
            yield return STMB;
#endif
            yield return STNAT;
#if !EduHubScoped
            yield return STNAT_TR;
#endif
            yield return STPO;
            yield return STPS;
#if !EduHubScoped
            yield return STPS_TFR;
            yield return STPT;
            yield return STRA;
            yield return STRE;
            yield return STSB;
            yield return STSP;
#endif
            yield return STSUP;
#if !EduHubScoped
            yield return STSUP_TR;
            yield return STTRIPS;
#endif
            yield return STVDI;
#if !EduHubScoped
            yield return STVDI_TR;
#endif
            yield return STVDO;
#if !EduHubScoped
            yield return STVDO_TR;
#endif
            yield return SU;
#if !EduHubScoped
            yield return SUBL;
            yield return SUPR;
            yield return SVAG;
#endif
            yield return SXAB;
            yield return SXABCONV;
            yield return SXAS;
#if !EduHubScoped
            yield return SXHI;
#endif
            yield return TC;
            yield return TCAT;
            yield return TCTB;
            yield return TCTD;
            yield return TCTQ;
            yield return TCTR;
            yield return TE;
            yield return TEC;
#if !EduHubScoped
            yield return TETE;
            yield return TETN;
#endif
            yield return TH;
            yield return THTN;
            yield return THTQ;
#if !EduHubScoped
            yield return TRPMODE;
            yield return TRPROUT;
            yield return TRSTACC;
#endif
            yield return TT;
#if !EduHubScoped
            yield return TTEF;
            yield return TTEI;
            yield return TTEP;
            yield return TTES;
            yield return TTEX;
#endif
            yield return TTTG;
            yield return TXAS;
            yield return TXHG;
            yield return UM;
#if !EduHubScoped
            yield return UM_TFR;
#endif
        }
#if !EduHubScoped

        /// <summary>
        /// Decrypted data IMPORT
        /// </summary>
        public A_DECRYPDataSet A_DECRYP { get { return _A_DECRYP; } }

        /// <summary>
        /// AIMS Data
        /// </summary>
        public AIMSDataSet AIMS { get { return _AIMS; } }

        /// <summary>
        /// Assets - Sub-Category
        /// </summary>
        public AKBDataSet AKB { get { return _AKB; } }
#endif

        /// <summary>
        /// Assets - Categories
        /// </summary>
        public AKCDataSet AKC { get { return _AKC; } }
#if !EduHubScoped

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
#endif

        /// <summary>
        /// Assets
        /// </summary>
        public ARDataSet AR { get { return _AR; } }
#if !EduHubScoped

        /// <summary>
        /// Asset Financial Transactions
        /// </summary>
        public ARFDataSet ARF { get { return _ARF; } }

        /// <summary>
        /// Bank Signatories
        /// </summary>
        public BANKSIGDataSet BANKSIG { get { return _BANKSIG; } }

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
#endif

        /// <summary>
        /// Accounts Payable
        /// </summary>
        public CRDataSet CR { get { return _CR; } }

        /// <summary>
        /// Creditor Financial Transaction
        /// </summary>
        public CRFDataSet CRF { get { return _CRF; } }
#if !EduHubScoped

        /// <summary>
        /// Creditor Fuel Tax Credits
        /// </summary>
        public CRFTCDataSet CRFTC { get { return _CRFTC; } }

        /// <summary>
        /// Creditor Purchase Requisitions
        /// </summary>
        public CRPRDataSet CRPR { get { return _CRPR; } }

        /// <summary>
        /// Creditor Trade Types
        /// </summary>
        public CRTTDataSet CRTT { get { return _CRTT; } }
#endif

        /// <summary>
        /// Families
        /// </summary>
        public DFDataSet DF { get { return _DF; } }
#if !EduHubScoped

        /// <summary>
        /// DF Transfer
        /// </summary>
        public DF_TFRDataSet DF_TFR { get { return _DF_TFR; } }

        /// <summary>
        /// BPAY Receipts
        /// </summary>
        public DFBDataSet DFB { get { return _DFB; } }
#endif

        /// <summary>
        /// Family Financial Transactions
        /// </summary>
        public DFFDataSet DFF { get { return _DFF; } }
#if !EduHubScoped

        /// <summary>
        /// Family History
        /// </summary>
        public DFHIDataSet DFHI { get { return _DFHI; } }
#endif

        /// <summary>
        /// Family Voluntary Transactions
        /// </summary>
        public DFVTDataSet DFVT { get { return _DFVT; } }

        /// <summary>
        /// Accounts Receivable
        /// </summary>
        public DRDataSet DR { get { return _DR; } }
#if !EduHubScoped

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
#endif

        /// <summary>
        /// General Ledger
        /// </summary>
        public GLDataSet GL { get { return _GL; } }
#if !EduHubScoped

        /// <summary>
        /// Bank Account Details
        /// </summary>
        public GLBANKDataSet GLBANK { get { return _GLBANK; } }
#endif

        /// <summary>
        /// General Ledger Budgets
        /// </summary>
        public GLBUDGDataSet GLBUDG { get { return _GLBUDG; } }
#if !EduHubScoped

        /// <summary>
        /// GL Combined Financial Trans
        /// </summary>
        public GLCFDataSet GLCF { get { return _GLCF; } }

        /// <summary>
        /// Last Years GL Combined Financial Trans
        /// </summary>
        public GLCFPREVDataSet GLCFPREV { get { return _GLCFPREV; } }
#endif

        /// <summary>
        /// General Ledger Transactions
        /// </summary>
        public GLFDataSet GLF { get { return _GLF; } }
#if !EduHubScoped

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
#endif

        /// <summary>
        /// BSB Numbers
        /// </summary>
        public KABDataSet KAB { get { return _KAB; } }
#if !EduHubScoped

        /// <summary>
        /// Restricted ABN Numbers
        /// </summary>
        public KABNDataSet KABN { get { return _KABN; } }
#endif

        /// <summary>
        /// Delivery Addresses
        /// </summary>
        public KADDataSet KAD { get { return _KAD; } }
#if !EduHubScoped

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
#endif

        /// <summary>
        /// Calendar Dates for Absences
        /// </summary>
        public KCCDataSet KCC { get { return _KCC; } }

        /// <summary>
        /// Doctors
        /// </summary>
        public KCDDataSet KCD { get { return _KCD; } }
#if !EduHubScoped

        /// <summary>
        /// KCD Transfer
        /// </summary>
        public KCD_TFRDataSet KCD_TFR { get { return _KCD_TFR; } }
#endif

        /// <summary>
        /// Religious Instruction Curricula
        /// </summary>
        public KCIDataSet KCI { get { return _KCI; } }

        /// <summary>
        /// Medical Conditions
        /// </summary>
        public KCMDataSet KCM { get { return _KCM; } }
#if !EduHubScoped

        /// <summary>
        /// KCM Transfer
        /// </summary>
        public KCM_TFRDataSet KCM_TFR { get { return _KCM_TFR; } }

        /// <summary>
        /// Cohorts for data aggregation
        /// </summary>
        public KCOHORTDataSet KCOHORT { get { return _KCOHORT; } }

        /// <summary>
        /// Creditor Purchasing Card
        /// </summary>
        public KCPCDataSet KCPC { get { return _KCPC; } }

        /// <summary>
        /// Transport Routes/Stops
        /// </summary>
        public KCRDataSet KCR { get { return _KCR; } }
#endif

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
#if !EduHubScoped

        /// <summary>
        /// Data deleted from DataMirror monitored tables
        /// </summary>
        public KDELETEDataSet KDELETE { get { return _KDELETE; } }
#endif

        /// <summary>
        /// Victorian Curriculum Strands
        /// </summary>
        public KDIDataSet KDI { get { return _KDI; } }

        /// <summary>
        /// Curriculum Area
        /// </summary>
        public KDODataSet KDO { get { return _KDO; } }
#if !EduHubScoped

        /// <summary>
        /// CSEF Receipt details
        /// </summary>
        public KEMADataSet KEMA { get { return _KEMA; } }

        /// <summary>
        /// ST EMAIL IMPORT
        /// </summary>
        public KEMAILDataSet KEMAIL { get { return _KEMAIL; } }

        /// <summary>
        /// Import or Update Errors
        /// </summary>
        public KERRORDataSet KERROR { get { return _KERROR; } }

        /// <summary>
        /// FLO Placement information
        /// </summary>
        public KFLODataSet KFLO { get { return _KFLO; } }

        /// <summary>
        /// Fuel Tax Credit Rates
        /// </summary>
        public KFTCDataSet KFTC { get { return _KFTC; } }

        /// <summary>
        /// GL Bank Fund
        /// </summary>
        public KFUNDDataSet KFUND { get { return _KFUND; } }
#endif

        /// <summary>
        /// Home Groups
        /// </summary>
        public KGCDataSet KGC { get { return _KGC; } }
#if !EduHubScoped

        /// <summary>
        /// Home Group History
        /// </summary>
        public KGCHIDataSet KGCHI { get { return _KGCHI; } }

        /// <summary>
        /// eMaze Calendar Framework
        /// </summary>
        public KGCVDataSet KGCV { get { return _KGCV; } }
#endif

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
        /// Occupations
        /// </summary>
        public KGODataSet KGO { get { return _KGO; } }
#if !EduHubScoped

        /// <summary>
        /// KGO Transfer
        /// </summary>
        public KGO_TFRDataSet KGO_TFR { get { return _KGO_TFR; } }
#endif

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
#if !EduHubScoped

        /// <summary>
        /// Awards and Prizes
        /// </summary>
        public KGWDataSet KGW { get { return _KGW; } }

        /// <summary>
        /// Trace log for finance import and export
        /// </summary>
        public KLOGDataSet KLOG { get { return _KLOG; } }

        /// <summary>
        /// CASES21 MESSAGES
        /// </summary>
        public KMSGDataSet KMSG { get { return _KMSG; } }

        /// <summary>
        /// General Ledger Notes
        /// </summary>
        public KNDataSet KN { get { return _KN; } }
#endif

        /// <summary>
        /// Notes and Attachment Type
        /// </summary>
        public KNATTDataSet KNATT { get { return _KNATT; } }
#if !EduHubScoped

        /// <summary>
        /// Family/Student ID Sequence Numbers
        /// </summary>
        public KNFSDataSet KNFS { get { return _KNFS; } }

        /// <summary>
        /// Creditor Notes
        /// </summary>
        public KNOTE_CRDataSet KNOTE_CR { get { return _KNOTE_CR; } }

        /// <summary>
        /// Debtor Notes
        /// </summary>
        public KNOTE_DRDataSet KNOTE_DR { get { return _KNOTE_DR; } }

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
        /// Holding Table for Reformatting phone numbers
        /// </summary>
        public KPHDataSet KPH { get { return _KPH; } }

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
#endif

        /// <summary>
        /// Areas of Teaching
        /// </summary>
        public KSADataSet KSA { get { return _KSA; } }

        /// <summary>
        /// Staff Positions
        /// </summary>
        public KSCDataSet KSC { get { return _KSC; } }
#if !EduHubScoped

        /// <summary>
        /// Scores
        /// </summary>
        public KSCOREDataSet KSCORE { get { return _KSCORE; } }
#endif

        /// <summary>
        /// Faculties
        /// </summary>
        public KSFDataSet KSF { get { return _KSF; } }
#if !EduHubScoped

        /// <summary>
        /// Holding Table for Incorrect Schools
        /// </summary>
        public KSKGSDataSet KSKGS { get { return _KSKGS; } }

        /// <summary>
        /// Available Qualifications
        /// </summary>
        public KSQDataSet KSQ { get { return _KSQ; } }

        /// <summary>
        /// Street Types
        /// </summary>
        public KSTREETDataSet KSTREET { get { return _KSTREET; } }

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
        /// Trade Type
        /// </summary>
        public KTTDataSet KTT { get { return _KTT; } }

        /// <summary>
        /// User Program Codes
        /// </summary>
        public KUPCDataSet KUPC { get { return _KUPC; } }

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
        /// General Ledger Import Details
        /// </summary>
        public PGIDDataSet PGID { get { return _PGID; } }

        /// <summary>
        /// General Ledger Import
        /// </summary>
        public PGLIDataSet PGLI { get { return _PGLI; } }

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
#endif

        /// <summary>
        /// PAYG Payer Details
        /// </summary>
        public PPDDataSet PPD { get { return _PPD; } }
#if !EduHubScoped

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
        /// Audit Control
        /// </summary>
        public QSACDataSet QSAC { get { return _QSAC; } }

        /// <summary>
        /// Audit Data Changes
        /// </summary>
        public QSADDataSet QSAD { get { return _QSAD; } }

        /// <summary>
        /// Audit Group Tables
        /// </summary>
        public QSAGDataSet QSAG { get { return _QSAG; } }

        /// <summary>
        /// Auditable Tables
        /// </summary>
        public QSATDataSet QSAT { get { return _QSAT; } }

        /// <summary>
        /// Purchase Requisition
        /// </summary>
        public RQDataSet RQ { get { return _RQ; } }

        /// <summary>
        /// Purchasing Group GL Codes
        /// </summary>
        public RQGLDataSet RQGL { get { return _RQGL; } }

        /// <summary>
        /// Purchasing Group
        /// </summary>
        public RQPGDataSet RQPG { get { return _RQPG; } }

        /// <summary>
        /// Staff Purchasing Group Link
        /// </summary>
        public RQRELDataSet RQREL { get { return _RQREL; } }

        /// <summary>
        /// Purchase Requisition Transaction
        /// </summary>
        public RQTDataSet RQT { get { return _RQT; } }
#endif

        /// <summary>
        /// Fees
        /// </summary>
        public SADataSet SA { get { return _SA; } }
#if !EduHubScoped

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
#endif

        /// <summary>
        /// School Association Members
        /// </summary>
        public SAMDataSet SAM { get { return _SAM; } }
#if !EduHubScoped

        /// <summary>
        /// Association Member Attendances
        /// </summary>
        public SAMADataSet SAMA { get { return _SAMA; } }

        /// <summary>
        /// School Association Positions
        /// </summary>
        public SAPDataSet SAP { get { return _SAP; } }
#endif

        /// <summary>
        /// Courses
        /// </summary>
        public SCDataSet SC { get { return _SC; } }
#if !EduHubScoped

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
#endif

        /// <summary>
        /// School Information
        /// </summary>
        public SCIDataSet SCI { get { return _SCI; } }

        /// <summary>
        /// Subject Classes
        /// </summary>
        public SCLDataSet SCL { get { return _SCL; } }
#if !EduHubScoped

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
        /// eCases Messages
        /// </summary>
        public SECMSGDataSet SECMSG { get { return _SECMSG; } }
#endif

        /// <summary>
        /// Staff
        /// </summary>
        public SFDataSet SF { get { return _SF; } }
#if !EduHubScoped

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
#endif

        /// <summary>
        /// Student Groupings
        /// </summary>
        public SGDataSet SG { get { return _SG; } }
#if !EduHubScoped

        /// <summary>
        /// Adult Group Members
        /// </summary>
        public SGAMDataSet SGAM { get { return _SGAM; } }

        /// <summary>
        /// General Ledger Fees
        /// </summary>
        public SGFCDataSet SGFC { get { return _SGFC; } }

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
#endif

        /// <summary>
        /// Schools
        /// </summary>
        public SKGSDataSet SKGS { get { return _SKGS; } }
#if !EduHubScoped

        /// <summary>
        /// Old SKGS Schools
        /// </summary>
        public SKGS_OLDDataSet SKGS_OLD { get { return _SKGS_OLD; } }
#endif

        /// <summary>
        /// Rooms
        /// </summary>
        public SMDataSet SM { get { return _SM; } }
#if !EduHubScoped

        /// <summary>
        /// Room Availability in Quilt
        /// </summary>
        public SMAQDataSet SMAQ { get { return _SMAQ; } }

        /// <summary>
        /// Room Availablity Extras
        /// </summary>
        public SMAVDataSet SMAV { get { return _SMAV; } }
#endif

        /// <summary>
        /// Student Medical Conditions
        /// </summary>
        public SMCDataSet SMC { get { return _SMC; } }
#if !EduHubScoped

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
        /// SMS Reply Recipients
        /// </summary>
        public SP_RECIPDataSet SP_RECIP { get { return _SP_RECIP; } }

        /// <summary>
        /// SMS Reply Recipient Groups
        /// </summary>
        public SP_REPLYDataSet SP_REPLY { get { return _SP_REPLY; } }

        /// <summary>
        /// Report email templates
        /// </summary>
        public SPEMAILDataSet SPEMAIL { get { return _SPEMAIL; } }

        /// <summary>
        /// SMS Emergency Templates
        /// </summary>
        public SPEMRGDataSet SPEMRG { get { return _SPEMRG; } }

        /// <summary>
        /// Report file audit
        /// </summary>
        public SPEPRINTDataSet SPEPRINT { get { return _SPEPRINT; } }

        /// <summary>
        /// File Sharing
        /// </summary>
        public SPFSHAREDataSet SPFSHARE { get { return _SPFSHARE; } }

        /// <summary>
        /// File Store for streaming files to eMaze
        /// </summary>
        public SPFSTOREDataSet SPFSTORE { get { return _SPFSTORE; } }

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
        /// SMS Retries
        /// </summary>
        public SPRETRYDataSet SPRETRY { get { return _SPRETRY; } }

        /// <summary>
        /// SMS messages
        /// </summary>
        public SPSMSDataSet SPSMS { get { return _SPSMS; } }

        /// <summary>
        /// Publications
        /// </summary>
        public SPUDataSet SPU { get { return _SPU; } }

        /// <summary>
        /// Report WWW templates
        /// </summary>
        public SPWWWDataSet SPWWW { get { return _SPWWW; } }

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
#endif

        /// <summary>
        /// Students
        /// </summary>
        public STDataSet ST { get { return _ST; } }
#if !EduHubScoped

        /// <summary>
        /// ST Transfer
        /// </summary>
        public ST_TFRDataSet ST_TFR { get { return _ST_TFR; } }

        /// <summary>
        /// Student Data Transfer Table
        /// </summary>
        public ST_TFRIODataSet ST_TFRIO { get { return _ST_TFRIO; } }
#endif

        /// <summary>
        /// Student Access Restrictions
        /// </summary>
        public STARDataSet STAR { get { return _STAR; } }
#if !EduHubScoped

        /// <summary>
        /// STAR Transfer
        /// </summary>
        public STAR_TFRDataSet STAR_TFR { get { return _STAR_TFR; } }

        /// <summary>
        /// Student Transport Usage
        /// </summary>
        public STBTDataSet STBT { get { return _STBT; } }

        /// <summary>
        /// Student Flexible Learning Options
        /// </summary>
        public STFLODataSet STFLO { get { return _STFLO; } }
#endif

        /// <summary>
        /// Subject Selections &amp; Marks
        /// </summary>
        public STMADataSet STMA { get { return _STMA; } }
#if !EduHubScoped

        /// <summary>
        /// Student Merit Behaviour Details
        /// </summary>
        public STMBDataSet STMB { get { return _STMB; } }
#endif

        /// <summary>
        /// Student Notes and Attachments
        /// </summary>
        public STNATDataSet STNAT { get { return _STNAT; } }
#if !EduHubScoped

        /// <summary>
        /// STNAT Transfer
        /// </summary>
        public STNAT_TRDataSet STNAT_TR { get { return _STNAT_TR; } }
#endif

        /// <summary>
        /// Position or Group Memberships
        /// </summary>
        public STPODataSet STPO { get { return _STPO; } }

        /// <summary>
        /// Student Previous School
        /// </summary>
        public STPSDataSet STPS { get { return _STPS; } }
#if !EduHubScoped

        /// <summary>
        /// STPS Transfer
        /// </summary>
        public STPS_TFRDataSet STPS_TFR { get { return _STPS_TFR; } }

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
#endif

        /// <summary>
        /// Support Persons
        /// </summary>
        public STSUPDataSet STSUP { get { return _STSUP; } }
#if !EduHubScoped

        /// <summary>
        /// STSUP Transfer
        /// </summary>
        public STSUP_TRDataSet STSUP_TR { get { return _STSUP_TR; } }

        /// <summary>
        /// Student Trips
        /// </summary>
        public STTRIPSDataSet STTRIPS { get { return _STTRIPS; } }
#endif

        /// <summary>
        /// VELS Dimension Results
        /// </summary>
        public STVDIDataSet STVDI { get { return _STVDI; } }
#if !EduHubScoped

        /// <summary>
        /// STVDI Transfer
        /// </summary>
        public STVDI_TRDataSet STVDI_TR { get { return _STVDI_TR; } }
#endif

        /// <summary>
        /// VELS Domain Results
        /// </summary>
        public STVDODataSet STVDO { get { return _STVDO; } }
#if !EduHubScoped

        /// <summary>
        /// STVDO Transfer
        /// </summary>
        public STVDO_TRDataSet STVDO_TR { get { return _STVDO_TR; } }
#endif

        /// <summary>
        /// Subjects
        /// </summary>
        public SUDataSet SU { get { return _SU; } }
#if !EduHubScoped

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
#endif

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
#if !EduHubScoped

        /// <summary>
        /// Student History
        /// </summary>
        public SXHIDataSet SXHI { get { return _SXHI; } }
#endif

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
#if !EduHubScoped

        /// <summary>
        /// Event Instances
        /// </summary>
        public TETEDataSet TETE { get { return _TETE; } }

        /// <summary>
        /// Event Attendees
        /// </summary>
        public TETNDataSet TETN { get { return _TETN; } }
#endif

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
#if !EduHubScoped

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
#endif

        /// <summary>
        /// Timetable Grid Templates
        /// </summary>
        public TTDataSet TT { get { return _TT; } }
#if !EduHubScoped

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
#endif

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
#if !EduHubScoped

        /// <summary>
        /// UM Transfer
        /// </summary>
        public UM_TFRDataSet UM_TFR { get { return _UM_TFR; } }
#endif
    }
}
