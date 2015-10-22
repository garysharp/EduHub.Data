using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Schools Data Set
    /// </summary>
    public sealed partial class SKGSDataSet : SetBase<SKGS>
    {
        private Lazy<Dictionary<string, SKGS>> SCHOOLIndex;

        private Lazy<Dictionary<string, IReadOnlyList<DF_TFR>>> DF_TFR_ORIG_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<FDT_EXP>>> FDT_EXP_DESTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<FER_FDT>>> FER_FDT_SOURCEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KCD_TFR>>> KCD_TFR_ORIG_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KCM_TFR>>> KCM_TFR_ORIG_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SCHOOL_LINKForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_DESTINATION_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SMC_TFR>>> SMC_TFR_ORIG_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_PREVIOUS_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_NEXT_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>> ST_TFR_ORIG_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST_TFRIO>>> ST_TFRIO_DEST_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STPT>>> STPT_SCHL_NUMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_ST_PREVIOUS_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_STPT_SCHL_NUM01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_STPT_SCHL_NUM02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_STPT_SCHL_NUM03ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_STPT_SCHL_NUM04ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_ST_NEXT_SCHOOLForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<UM_TFR>>> UM_TFR_ORIG_SCHOOLForeignIndex;

        internal SKGSDataSet(EduHubContext Context)
            : base(Context)
        {
            SCHOOLIndex = new Lazy<Dictionary<string, SKGS>>(() => this.ToDictionary(e => e.SCHOOL));

            DF_TFR_ORIG_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DF_TFR>>>(() =>
                    Context.DF_TFR
                          .Where(e => e.ORIG_SCHOOL != null)
                          .GroupBy(e => e.ORIG_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DF_TFR>)g.ToList()
                          .AsReadOnly()));

            FDT_EXP_DESTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<FDT_EXP>>>(() =>
                    Context.FDT_EXP
                          .Where(e => e.DEST != null)
                          .GroupBy(e => e.DEST)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<FDT_EXP>)g.ToList()
                          .AsReadOnly()));

            FER_FDT_SOURCEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<FER_FDT>>>(() =>
                    Context.FER_FDT
                          .Where(e => e.SOURCE != null)
                          .GroupBy(e => e.SOURCE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<FER_FDT>)g.ToList()
                          .AsReadOnly()));

            KCD_TFR_ORIG_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KCD_TFR>>>(() =>
                    Context.KCD_TFR
                          .Where(e => e.ORIG_SCHOOL != null)
                          .GroupBy(e => e.ORIG_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KCD_TFR>)g.ToList()
                          .AsReadOnly()));

            KCM_TFR_ORIG_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KCM_TFR>>>(() =>
                    Context.KCM_TFR
                          .Where(e => e.ORIG_SCHOOL != null)
                          .GroupBy(e => e.ORIG_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KCM_TFR>)g.ToList()
                          .AsReadOnly()));

            SCI_SCHOOL_LINKForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SCHOOL_LINK != null)
                          .GroupBy(e => e.SCHOOL_LINK)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_DESTINATION_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.DESTINATION_SCHOOL != null)
                          .GroupBy(e => e.DESTINATION_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SMC_TFR_ORIG_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SMC_TFR>>>(() =>
                    Context.SMC_TFR
                          .Where(e => e.ORIG_SCHOOL != null)
                          .GroupBy(e => e.ORIG_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMC_TFR>)g.ToList()
                          .AsReadOnly()));

            ST_PREVIOUS_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.PREVIOUS_SCHOOL != null)
                          .GroupBy(e => e.PREVIOUS_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_NEXT_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.NEXT_SCHOOL != null)
                          .GroupBy(e => e.NEXT_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_TFR_ORIG_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>>(() =>
                    Context.ST_TFR
                          .Where(e => e.ORIG_SCHOOL != null)
                          .GroupBy(e => e.ORIG_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST_TFR>)g.ToList()
                          .AsReadOnly()));

            ST_TFRIO_DEST_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST_TFRIO>>>(() =>
                    Context.ST_TFRIO
                          .Where(e => e.DEST_SCHOOL != null)
                          .GroupBy(e => e.DEST_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST_TFRIO>)g.ToList()
                          .AsReadOnly()));

            STPT_SCHL_NUMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STPT>>>(() =>
                    Context.STPT
                          .Where(e => e.SCHL_NUM != null)
                          .GroupBy(e => e.SCHL_NUM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STPT>)g.ToList()
                          .AsReadOnly()));

            STRE_ST_PREVIOUS_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.ST_PREVIOUS_SCHOOL != null)
                          .GroupBy(e => e.ST_PREVIOUS_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STRE_STPT_SCHL_NUM01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.STPT_SCHL_NUM01 != null)
                          .GroupBy(e => e.STPT_SCHL_NUM01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STRE_STPT_SCHL_NUM02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.STPT_SCHL_NUM02 != null)
                          .GroupBy(e => e.STPT_SCHL_NUM02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STRE_STPT_SCHL_NUM03ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.STPT_SCHL_NUM03 != null)
                          .GroupBy(e => e.STPT_SCHL_NUM03)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STRE_STPT_SCHL_NUM04ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.STPT_SCHL_NUM04 != null)
                          .GroupBy(e => e.STPT_SCHL_NUM04)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STRE_ST_NEXT_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.ST_NEXT_SCHOOL != null)
                          .GroupBy(e => e.ST_NEXT_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            UM_TFR_ORIG_SCHOOLForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<UM_TFR>>>(() =>
                    Context.UM_TFR
                          .Where(e => e.ORIG_SCHOOL != null)
                          .GroupBy(e => e.ORIG_SCHOOL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<UM_TFR>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SKGS"; } }

        /// <summary>
        /// Find SKGS by SCHOOL key field
        /// </summary>
        /// <param name="Key">SCHOOL value used to find SKGS</param>
        /// <returns>Related SKGS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCHOOL value didn't match any SKGS entities</exception>
        public SKGS FindBySCHOOL(string Key)
        {
            SKGS result;
            if (SCHOOLIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SKGS by SCHOOL key field
        /// </summary>
        /// <param name="Key">SCHOOL value used to find SKGS</param>
        /// <param name="Value">Related SKGS entity</param>
        /// <returns>True if the SKGS entity is found</returns>
        public bool TryFindBySCHOOL(string Key, out SKGS Value)
        {
            return SCHOOLIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SKGS by SCHOOL key field
        /// </summary>
        /// <param name="Key">SCHOOL value used to find SKGS</param>
        /// <returns>Related SKGS entity, or null if not found</returns>
        public SKGS TryFindBySCHOOL(string Key)
        {
            SKGS result;
            if (SCHOOLIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all DF_TFR (DF Transfer) entities by [DF_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find DF_TFR entities</param>
        /// <returns>A list of related DF_TFR entities</returns>
        public IReadOnlyList<DF_TFR> FindDF_TFRByORIG_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<DF_TFR> result;
            if (DF_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<DF_TFR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DF_TFR entities by [DF_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find DF_TFR entities</param>
        /// <param name="Value">A list of related DF_TFR entities</param>
        /// <returns>True if any DF_TFR entities are found</returns>
        public bool TryFindDF_TFRByORIG_SCHOOL(string SCHOOL, out IReadOnlyList<DF_TFR> Value)
        {
            return DF_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all FDT_EXP (Financial Data Export) entities by [FDT_EXP.DEST]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find FDT_EXP entities</param>
        /// <returns>A list of related FDT_EXP entities</returns>
        public IReadOnlyList<FDT_EXP> FindFDT_EXPByDEST(string SCHOOL)
        {
            IReadOnlyList<FDT_EXP> result;
            if (FDT_EXP_DESTForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<FDT_EXP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all FDT_EXP entities by [FDT_EXP.DEST]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find FDT_EXP entities</param>
        /// <param name="Value">A list of related FDT_EXP entities</param>
        /// <returns>True if any FDT_EXP entities are found</returns>
        public bool TryFindFDT_EXPByDEST(string SCHOOL, out IReadOnlyList<FDT_EXP> Value)
        {
            return FDT_EXP_DESTForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all FER_FDT (FDT Financal Holding Table) entities by [FER_FDT.SOURCE]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find FER_FDT entities</param>
        /// <returns>A list of related FER_FDT entities</returns>
        public IReadOnlyList<FER_FDT> FindFER_FDTBySOURCE(string SCHOOL)
        {
            IReadOnlyList<FER_FDT> result;
            if (FER_FDT_SOURCEForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<FER_FDT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all FER_FDT entities by [FER_FDT.SOURCE]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find FER_FDT entities</param>
        /// <param name="Value">A list of related FER_FDT entities</param>
        /// <returns>True if any FER_FDT entities are found</returns>
        public bool TryFindFER_FDTBySOURCE(string SCHOOL, out IReadOnlyList<FER_FDT> Value)
        {
            return FER_FDT_SOURCEForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all KCD_TFR (KCD Transfer) entities by [KCD_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find KCD_TFR entities</param>
        /// <returns>A list of related KCD_TFR entities</returns>
        public IReadOnlyList<KCD_TFR> FindKCD_TFRByORIG_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<KCD_TFR> result;
            if (KCD_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<KCD_TFR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KCD_TFR entities by [KCD_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find KCD_TFR entities</param>
        /// <param name="Value">A list of related KCD_TFR entities</param>
        /// <returns>True if any KCD_TFR entities are found</returns>
        public bool TryFindKCD_TFRByORIG_SCHOOL(string SCHOOL, out IReadOnlyList<KCD_TFR> Value)
        {
            return KCD_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all KCM_TFR (KCM Transfer) entities by [KCM_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find KCM_TFR entities</param>
        /// <returns>A list of related KCM_TFR entities</returns>
        public IReadOnlyList<KCM_TFR> FindKCM_TFRByORIG_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<KCM_TFR> result;
            if (KCM_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<KCM_TFR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KCM_TFR entities by [KCM_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find KCM_TFR entities</param>
        /// <param name="Value">A list of related KCM_TFR entities</param>
        /// <returns>True if any KCM_TFR entities are found</returns>
        public bool TryFindKCM_TFRByORIG_SCHOOL(string SCHOOL, out IReadOnlyList<KCM_TFR> Value)
        {
            return KCM_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SCHOOL_LINK]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySCHOOL_LINK(string SCHOOL)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SCHOOL_LINKForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SCHOOL_LINK]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySCHOOL_LINK(string SCHOOL, out IReadOnlyList<SCI> Value)
        {
            return SCI_SCHOOL_LINKForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.DESTINATION_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIByDESTINATION_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<SCI> result;
            if (SCI_DESTINATION_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.DESTINATION_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIByDESTINATION_SCHOOL(string SCHOOL, out IReadOnlyList<SCI> Value)
        {
            return SCI_DESTINATION_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all SMC_TFR (SMC Transfer) entities by [SMC_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SMC_TFR entities</param>
        /// <returns>A list of related SMC_TFR entities</returns>
        public IReadOnlyList<SMC_TFR> FindSMC_TFRByORIG_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<SMC_TFR> result;
            if (SMC_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<SMC_TFR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMC_TFR entities by [SMC_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find SMC_TFR entities</param>
        /// <param name="Value">A list of related SMC_TFR entities</param>
        /// <returns>True if any SMC_TFR entities are found</returns>
        public bool TryFindSMC_TFRByORIG_SCHOOL(string SCHOOL, out IReadOnlyList<SMC_TFR> Value)
        {
            return SMC_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.PREVIOUS_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByPREVIOUS_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<ST> result;
            if (ST_PREVIOUS_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.PREVIOUS_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByPREVIOUS_SCHOOL(string SCHOOL, out IReadOnlyList<ST> Value)
        {
            return ST_PREVIOUS_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.NEXT_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByNEXT_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<ST> result;
            if (ST_NEXT_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.NEXT_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByNEXT_SCHOOL(string SCHOOL, out IReadOnlyList<ST> Value)
        {
            return ST_NEXT_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all ST_TFR (ST Transfer) entities by [ST_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find ST_TFR entities</param>
        /// <returns>A list of related ST_TFR entities</returns>
        public IReadOnlyList<ST_TFR> FindST_TFRByORIG_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<ST_TFR> result;
            if (ST_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<ST_TFR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST_TFR entities by [ST_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find ST_TFR entities</param>
        /// <param name="Value">A list of related ST_TFR entities</param>
        /// <returns>True if any ST_TFR entities are found</returns>
        public bool TryFindST_TFRByORIG_SCHOOL(string SCHOOL, out IReadOnlyList<ST_TFR> Value)
        {
            return ST_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all ST_TFRIO (Student Data Transfer Table) entities by [ST_TFRIO.DEST_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find ST_TFRIO entities</param>
        /// <returns>A list of related ST_TFRIO entities</returns>
        public IReadOnlyList<ST_TFRIO> FindST_TFRIOByDEST_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<ST_TFRIO> result;
            if (ST_TFRIO_DEST_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<ST_TFRIO>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST_TFRIO entities by [ST_TFRIO.DEST_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find ST_TFRIO entities</param>
        /// <param name="Value">A list of related ST_TFRIO entities</param>
        /// <returns>True if any ST_TFRIO entities are found</returns>
        public bool TryFindST_TFRIOByDEST_SCHOOL(string SCHOOL, out IReadOnlyList<ST_TFRIO> Value)
        {
            return ST_TFRIO_DEST_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all STPT (Student Part-Time Enrolments) entities by [STPT.SCHL_NUM]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STPT entities</param>
        /// <returns>A list of related STPT entities</returns>
        public IReadOnlyList<STPT> FindSTPTBySCHL_NUM(string SCHOOL)
        {
            IReadOnlyList<STPT> result;
            if (STPT_SCHL_NUMForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<STPT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STPT entities by [STPT.SCHL_NUM]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STPT entities</param>
        /// <param name="Value">A list of related STPT entities</param>
        /// <returns>True if any STPT entities are found</returns>
        public bool TryFindSTPTBySCHL_NUM(string SCHOOL, out IReadOnlyList<STPT> Value)
        {
            return STPT_SCHL_NUMForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.ST_PREVIOUS_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByST_PREVIOUS_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<STRE> result;
            if (STRE_ST_PREVIOUS_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.ST_PREVIOUS_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByST_PREVIOUS_SCHOOL(string SCHOOL, out IReadOnlyList<STRE> Value)
        {
            return STRE_ST_PREVIOUS_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.STPT_SCHL_NUM01]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREBySTPT_SCHL_NUM01(string SCHOOL)
        {
            IReadOnlyList<STRE> result;
            if (STRE_STPT_SCHL_NUM01ForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.STPT_SCHL_NUM01]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREBySTPT_SCHL_NUM01(string SCHOOL, out IReadOnlyList<STRE> Value)
        {
            return STRE_STPT_SCHL_NUM01ForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.STPT_SCHL_NUM02]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREBySTPT_SCHL_NUM02(string SCHOOL)
        {
            IReadOnlyList<STRE> result;
            if (STRE_STPT_SCHL_NUM02ForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.STPT_SCHL_NUM02]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREBySTPT_SCHL_NUM02(string SCHOOL, out IReadOnlyList<STRE> Value)
        {
            return STRE_STPT_SCHL_NUM02ForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.STPT_SCHL_NUM03]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREBySTPT_SCHL_NUM03(string SCHOOL)
        {
            IReadOnlyList<STRE> result;
            if (STRE_STPT_SCHL_NUM03ForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.STPT_SCHL_NUM03]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREBySTPT_SCHL_NUM03(string SCHOOL, out IReadOnlyList<STRE> Value)
        {
            return STRE_STPT_SCHL_NUM03ForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.STPT_SCHL_NUM04]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREBySTPT_SCHL_NUM04(string SCHOOL)
        {
            IReadOnlyList<STRE> result;
            if (STRE_STPT_SCHL_NUM04ForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.STPT_SCHL_NUM04]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREBySTPT_SCHL_NUM04(string SCHOOL, out IReadOnlyList<STRE> Value)
        {
            return STRE_STPT_SCHL_NUM04ForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.ST_NEXT_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByST_NEXT_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<STRE> result;
            if (STRE_ST_NEXT_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.ST_NEXT_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByST_NEXT_SCHOOL(string SCHOOL, out IReadOnlyList<STRE> Value)
        {
            return STRE_ST_NEXT_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }

        /// <summary>
        /// Find all UM_TFR (UM Transfer) entities by [UM_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find UM_TFR entities</param>
        /// <returns>A list of related UM_TFR entities</returns>
        public IReadOnlyList<UM_TFR> FindUM_TFRByORIG_SCHOOL(string SCHOOL)
        {
            IReadOnlyList<UM_TFR> result;
            if (UM_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out result))
            {
                return result;
            }
            else
            {
                return new List<UM_TFR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all UM_TFR entities by [UM_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// </summary>
        /// <param name="SCHOOL">SCHOOL value used to find UM_TFR entities</param>
        /// <param name="Value">A list of related UM_TFR entities</param>
        /// <returns>True if any UM_TFR entities are found</returns>
        public bool TryFindUM_TFRByORIG_SCHOOL(string SCHOOL, out IReadOnlyList<UM_TFR> Value)
        {
            return UM_TFR_ORIG_SCHOOLForeignIndex.Value.TryGetValue(SCHOOL, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SKGS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SKGS" /> fields for each CSV column header</returns>
        protected override Action<SKGS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SKGS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "SCHOOL_TYPE":
                        mapper[i] = (e, v) => e.SCHOOL_TYPE = v;
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "SCHOOL_NUMBER":
                        mapper[i] = (e, v) => e.SCHOOL_NUMBER = v;
                        break;
                    case "CAMPUS_TYPE":
                        mapper[i] = (e, v) => e.CAMPUS_TYPE = v;
                        break;
                    case "CAMPUS_NAME":
                        mapper[i] = (e, v) => e.CAMPUS_NAME = v;
                        break;
                    case "REGION":
                        mapper[i] = (e, v) => e.REGION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REGION_NAME":
                        mapper[i] = (e, v) => e.REGION_NAME = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "MAILING_ADDRESS01":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS01 = v;
                        break;
                    case "MAILING_ADDRESS02":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS02 = v;
                        break;
                    case "MAILING_SUBURB":
                        mapper[i] = (e, v) => e.MAILING_SUBURB = v;
                        break;
                    case "MAILING_STATE":
                        mapper[i] = (e, v) => e.MAILING_STATE = v;
                        break;
                    case "MAILING_POSTCODE":
                        mapper[i] = (e, v) => e.MAILING_POSTCODE = v;
                        break;
                    case "DELIVERY_ADDRESS01":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS01 = v;
                        break;
                    case "DELIVERY_ADDRESS02":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS02 = v;
                        break;
                    case "DELIVERY_SUBURB":
                        mapper[i] = (e, v) => e.DELIVERY_SUBURB = v;
                        break;
                    case "DELIVERY_STATE":
                        mapper[i] = (e, v) => e.DELIVERY_STATE = v;
                        break;
                    case "DELIVERY_POSTCODE":
                        mapper[i] = (e, v) => e.DELIVERY_POSTCODE = v;
                        break;
                    case "DELIVERY_TELEPHONE":
                        mapper[i] = (e, v) => e.DELIVERY_TELEPHONE = v;
                        break;
                    case "DELIVERY_FAX":
                        mapper[i] = (e, v) => e.DELIVERY_FAX = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "INTERNET_ADDRESS":
                        mapper[i] = (e, v) => e.INTERNET_ADDRESS = v;
                        break;
                    case "CASES21_RELEASE":
                        mapper[i] = (e, v) => e.CASES21_RELEASE = v;
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "SCH_PRINCIPAL_SALUTATION":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_SALUTATION = v;
                        break;
                    case "SCH_PRINCIPAL_FIRST_NAME":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_FIRST_NAME = v;
                        break;
                    case "SCH_PRINCIPAL_SURNAME":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_SURNAME = v;
                        break;
                    case "SCH_PRINCIPAL_TELEPHONE":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_TELEPHONE = v;
                        break;
                    case "SALUTATION":
                        mapper[i] = (e, v) => e.SALUTATION = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "CLOSED":
                        mapper[i] = (e, v) => e.CLOSED = v;
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
