using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Information Data Set
    /// </summary>
    public sealed partial class SCIDataSet : SetBase<SCI>
    {
        private Lazy<Dictionary<int, SCI>> SCIKEYIndex;

        private Lazy<Dictionary<int, IReadOnlyList<AR>>> AR_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<KGC>>> KGC_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<KGH>>> KGH_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SAD>>> SAD_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SCAM>>> SCAM_MEETING_LOCATIONForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SCL>>> SCL_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SF>>> SF_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SG>>> SG_FROM_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SG>>> SG_TO_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SID>>> SID_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SM>>> SM_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<SMC>>> SMC_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<ST>>> ST_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_AM1_SD_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_PM1_PU_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_AM2_SD_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_PM2_PU_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_AM3_SD_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_PM3_PU_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_AM4_SD_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_PM4_PU_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_AM5_SD_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STBT>>> STBT_PM5_PU_SITEForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STRE>>> STRE_ST_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>> STTRIPS_AM_SETDOWN_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>> STTRIPS_PM_PICKUP_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STVDI>>> STVDI_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<STVDO>>> STVDO_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<TE>>> TE_CAMPUSForeignIndex;
        private Lazy<Dictionary<int, IReadOnlyList<TT>>> TT_CAMPUSForeignIndex;

        internal SCIDataSet(EduHubContext Context)
            : base(Context)
        {
            SCIKEYIndex = new Lazy<Dictionary<int, SCI>>(() => this.ToDictionary(e => e.SCIKEY));

            AR_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<AR>>>(() =>
                    Context.AR
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AR>)g.ToList()
                          .AsReadOnly()));

            KGC_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<KGC>>>(() =>
                    Context.KGC
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGC>)g.ToList()
                          .AsReadOnly()));

            KGH_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<KGH>>>(() =>
                    Context.KGH
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGH>)g.ToList()
                          .AsReadOnly()));

            SAD_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SAD>>>(() =>
                    Context.SAD
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAD>)g.ToList()
                          .AsReadOnly()));

            SCAM_MEETING_LOCATIONForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SCAM>>>(() =>
                    Context.SCAM
                          .Where(e => e.MEETING_LOCATION != null)
                          .GroupBy(e => e.MEETING_LOCATION.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCAM>)g.ToList()
                          .AsReadOnly()));

            SCL_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SCL>>>(() =>
                    Context.SCL
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCL>)g.ToList()
                          .AsReadOnly()));

            SF_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SG_FROM_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SG>>>(() =>
                    Context.SG
                          .Where(e => e.FROM_CAMPUS != null)
                          .GroupBy(e => e.FROM_CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SG>)g.ToList()
                          .AsReadOnly()));

            SG_TO_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SG>>>(() =>
                    Context.SG
                          .Where(e => e.TO_CAMPUS != null)
                          .GroupBy(e => e.TO_CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SG>)g.ToList()
                          .AsReadOnly()));

            SID_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SID>>>(() =>
                    Context.SID
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SID>)g.ToList()
                          .AsReadOnly()));

            SM_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SM>>>(() =>
                    Context.SM
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SM>)g.ToList()
                          .AsReadOnly()));

            SMC_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<SMC>>>(() =>
                    Context.SMC
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMC>)g.ToList()
                          .AsReadOnly()));

            ST_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            STBT_AM1_SD_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM1_SD_SITE != null)
                          .GroupBy(e => e.AM1_SD_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM1_PU_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM1_PU_SITE != null)
                          .GroupBy(e => e.PM1_PU_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM2_SD_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM2_SD_SITE != null)
                          .GroupBy(e => e.AM2_SD_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM2_PU_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM2_PU_SITE != null)
                          .GroupBy(e => e.PM2_PU_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM3_SD_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM3_SD_SITE != null)
                          .GroupBy(e => e.AM3_SD_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM3_PU_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM3_PU_SITE != null)
                          .GroupBy(e => e.PM3_PU_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM4_SD_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM4_SD_SITE != null)
                          .GroupBy(e => e.AM4_SD_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM4_PU_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM4_PU_SITE != null)
                          .GroupBy(e => e.PM4_PU_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM5_SD_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM5_SD_SITE != null)
                          .GroupBy(e => e.AM5_SD_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM5_PU_SITEForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM5_PU_SITE != null)
                          .GroupBy(e => e.PM5_PU_SITE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STRE_ST_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.ST_CAMPUS != null)
                          .GroupBy(e => e.ST_CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STTRIPS_AM_SETDOWN_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>>(() =>
                    Context.STTRIPS
                          .Where(e => e.AM_SETDOWN_CAMPUS != null)
                          .GroupBy(e => e.AM_SETDOWN_CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STTRIPS>)g.ToList()
                          .AsReadOnly()));

            STTRIPS_PM_PICKUP_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STTRIPS>>>(() =>
                    Context.STTRIPS
                          .Where(e => e.PM_PICKUP_CAMPUS != null)
                          .GroupBy(e => e.PM_PICKUP_CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STTRIPS>)g.ToList()
                          .AsReadOnly()));

            STVDI_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STVDI>>>(() =>
                    Context.STVDI
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDI>)g.ToList()
                          .AsReadOnly()));

            STVDO_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<STVDO>>>(() =>
                    Context.STVDO
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDO>)g.ToList()
                          .AsReadOnly()));

            TE_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<TE>>>(() =>
                    Context.TE
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TE>)g.ToList()
                          .AsReadOnly()));

            TT_CAMPUSForeignIndex =
                new Lazy<Dictionary<int, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.CAMPUS != null)
                          .GroupBy(e => e.CAMPUS.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCI"; } }

        /// <summary>
        /// Find SCI by SCIKEY key field
        /// </summary>
        /// <param name="Key">SCIKEY value used to find SCI</param>
        /// <returns>Related SCI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCIKEY value didn't match any SCI entities</exception>
        public SCI FindBySCIKEY(int Key)
        {
            SCI result;
            if (SCIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCI by SCIKEY key field
        /// </summary>
        /// <param name="Key">SCIKEY value used to find SCI</param>
        /// <param name="Value">Related SCI entity</param>
        /// <returns>True if the SCI entity is found</returns>
        public bool TryFindBySCIKEY(int Key, out SCI Value)
        {
            return SCIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCI by SCIKEY key field
        /// </summary>
        /// <param name="Key">SCIKEY value used to find SCI</param>
        /// <returns>Related SCI entity, or null if not found</returns>
        public SCI TryFindBySCIKEY(int Key)
        {
            SCI result;
            if (SCIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AR (Assets) entities by [AR.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find AR entities</param>
        /// <returns>A list of related AR entities</returns>
        public IReadOnlyList<AR> FindARByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<AR> result;
            if (AR_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AR entities by [AR.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find AR entities</param>
        /// <param name="Value">A list of related AR entities</param>
        /// <returns>True if any AR entities are found</returns>
        public bool TryFindARByCAMPUS(int SCIKEY, out IReadOnlyList<AR> Value)
        {
            return AR_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all KGC (Home Groups) entities by [KGC.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find KGC entities</param>
        /// <returns>A list of related KGC entities</returns>
        public IReadOnlyList<KGC> FindKGCByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<KGC> result;
            if (KGC_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KGC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGC entities by [KGC.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find KGC entities</param>
        /// <param name="Value">A list of related KGC entities</param>
        /// <returns>True if any KGC entities are found</returns>
        public bool TryFindKGCByCAMPUS(int SCIKEY, out IReadOnlyList<KGC> Value)
        {
            return KGC_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all KGH (Houses) entities by [KGH.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find KGH entities</param>
        /// <returns>A list of related KGH entities</returns>
        public IReadOnlyList<KGH> FindKGHByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<KGH> result;
            if (KGH_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KGH>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGH entities by [KGH.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find KGH entities</param>
        /// <param name="Value">A list of related KGH entities</param>
        /// <returns>True if any KGH entities are found</returns>
        public bool TryFindKGHByCAMPUS(int SCIKEY, out IReadOnlyList<KGH> Value)
        {
            return KGH_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SAD (Accidents) entities by [SAD.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SAD entities</param>
        /// <returns>A list of related SAD entities</returns>
        public IReadOnlyList<SAD> FindSADByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<SAD> result;
            if (SAD_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAD entities by [SAD.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SAD entities</param>
        /// <param name="Value">A list of related SAD entities</param>
        /// <returns>True if any SAD entities are found</returns>
        public bool TryFindSADByCAMPUS(int SCIKEY, out IReadOnlyList<SAD> Value)
        {
            return SAD_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SCAM (School Association Meetings) entities by [SCAM.MEETING_LOCATION]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SCAM entities</param>
        /// <returns>A list of related SCAM entities</returns>
        public IReadOnlyList<SCAM> FindSCAMByMEETING_LOCATION(int SCIKEY)
        {
            IReadOnlyList<SCAM> result;
            if (SCAM_MEETING_LOCATIONForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCAM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCAM entities by [SCAM.MEETING_LOCATION]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SCAM entities</param>
        /// <param name="Value">A list of related SCAM entities</param>
        /// <returns>True if any SCAM entities are found</returns>
        public bool TryFindSCAMByMEETING_LOCATION(int SCIKEY, out IReadOnlyList<SCAM> Value)
        {
            return SCAM_MEETING_LOCATIONForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SCL (Subject Classes) entities by [SCL.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SCL entities</param>
        /// <returns>A list of related SCL entities</returns>
        public IReadOnlyList<SCL> FindSCLByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<SCL> result;
            if (SCL_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCL entities by [SCL.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SCL entities</param>
        /// <param name="Value">A list of related SCL entities</param>
        /// <returns>True if any SCL entities are found</returns>
        public bool TryFindSCLByCAMPUS(int SCIKEY, out IReadOnlyList<SCL> Value)
        {
            return SCL_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByCAMPUS(int SCIKEY, out IReadOnlyList<SF> Value)
        {
            return SF_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SG (Student Groupings) entities by [SG.FROM_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SG entities</param>
        /// <returns>A list of related SG entities</returns>
        public IReadOnlyList<SG> FindSGByFROM_CAMPUS(int SCIKEY)
        {
            IReadOnlyList<SG> result;
            if (SG_FROM_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SG entities by [SG.FROM_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SG entities</param>
        /// <param name="Value">A list of related SG entities</param>
        /// <returns>True if any SG entities are found</returns>
        public bool TryFindSGByFROM_CAMPUS(int SCIKEY, out IReadOnlyList<SG> Value)
        {
            return SG_FROM_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SG (Student Groupings) entities by [SG.TO_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SG entities</param>
        /// <returns>A list of related SG entities</returns>
        public IReadOnlyList<SG> FindSGByTO_CAMPUS(int SCIKEY)
        {
            IReadOnlyList<SG> result;
            if (SG_TO_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SG entities by [SG.TO_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SG entities</param>
        /// <param name="Value">A list of related SG entities</param>
        /// <returns>True if any SG entities are found</returns>
        public bool TryFindSGByTO_CAMPUS(int SCIKEY, out IReadOnlyList<SG> Value)
        {
            return SG_TO_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SID (Disciplinary Incidents) entities by [SID.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SID entities</param>
        /// <returns>A list of related SID entities</returns>
        public IReadOnlyList<SID> FindSIDByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<SID> result;
            if (SID_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SID>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SID entities by [SID.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SID entities</param>
        /// <param name="Value">A list of related SID entities</param>
        /// <returns>True if any SID entities are found</returns>
        public bool TryFindSIDByCAMPUS(int SCIKEY, out IReadOnlyList<SID> Value)
        {
            return SID_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SM (Rooms) entities by [SM.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SM entities</param>
        /// <returns>A list of related SM entities</returns>
        public IReadOnlyList<SM> FindSMByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<SM> result;
            if (SM_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SM entities by [SM.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SM entities</param>
        /// <param name="Value">A list of related SM entities</param>
        /// <returns>True if any SM entities are found</returns>
        public bool TryFindSMByCAMPUS(int SCIKEY, out IReadOnlyList<SM> Value)
        {
            return SM_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all SMC (Student Medical Conditions) entities by [SMC.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SMC entities</param>
        /// <returns>A list of related SMC entities</returns>
        public IReadOnlyList<SMC> FindSMCByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<SMC> result;
            if (SMC_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SMC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMC entities by [SMC.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find SMC entities</param>
        /// <param name="Value">A list of related SMC entities</param>
        /// <returns>True if any SMC entities are found</returns>
        public bool TryFindSMCByCAMPUS(int SCIKEY, out IReadOnlyList<SMC> Value)
        {
            return SMC_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByCAMPUS(int SCIKEY, out IReadOnlyList<ST> Value)
        {
            return ST_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM1_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM1_SD_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM1_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM1_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM1_SD_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM1_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM1_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM1_PU_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM1_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM1_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM1_PU_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM1_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM2_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM2_SD_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM2_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM2_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM2_SD_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM2_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM2_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM2_PU_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM2_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM2_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM2_PU_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM2_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM3_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM3_SD_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM3_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM3_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM3_SD_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM3_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM3_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM3_PU_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM3_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM3_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM3_PU_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM3_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM4_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM4_SD_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM4_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM4_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM4_SD_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM4_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM4_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM4_PU_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM4_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM4_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM4_PU_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM4_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM5_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM5_SD_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM5_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM5_SD_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM5_SD_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM5_SD_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM5_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM5_PU_SITE(int SCIKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM5_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM5_PU_SITE]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM5_PU_SITE(int SCIKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM5_PU_SITEForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.ST_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByST_CAMPUS(int SCIKEY)
        {
            IReadOnlyList<STRE> result;
            if (STRE_ST_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.ST_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByST_CAMPUS(int SCIKEY, out IReadOnlyList<STRE> Value)
        {
            return STRE_ST_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STTRIPS (Student Trips) entities by [STTRIPS.AM_SETDOWN_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STTRIPS entities</param>
        /// <returns>A list of related STTRIPS entities</returns>
        public IReadOnlyList<STTRIPS> FindSTTRIPSByAM_SETDOWN_CAMPUS(int SCIKEY)
        {
            IReadOnlyList<STTRIPS> result;
            if (STTRIPS_AM_SETDOWN_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STTRIPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STTRIPS entities by [STTRIPS.AM_SETDOWN_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STTRIPS entities</param>
        /// <param name="Value">A list of related STTRIPS entities</param>
        /// <returns>True if any STTRIPS entities are found</returns>
        public bool TryFindSTTRIPSByAM_SETDOWN_CAMPUS(int SCIKEY, out IReadOnlyList<STTRIPS> Value)
        {
            return STTRIPS_AM_SETDOWN_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STTRIPS (Student Trips) entities by [STTRIPS.PM_PICKUP_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STTRIPS entities</param>
        /// <returns>A list of related STTRIPS entities</returns>
        public IReadOnlyList<STTRIPS> FindSTTRIPSByPM_PICKUP_CAMPUS(int SCIKEY)
        {
            IReadOnlyList<STTRIPS> result;
            if (STTRIPS_PM_PICKUP_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STTRIPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STTRIPS entities by [STTRIPS.PM_PICKUP_CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STTRIPS entities</param>
        /// <param name="Value">A list of related STTRIPS entities</param>
        /// <returns>True if any STTRIPS entities are found</returns>
        public bool TryFindSTTRIPSByPM_PICKUP_CAMPUS(int SCIKEY, out IReadOnlyList<STTRIPS> Value)
        {
            return STTRIPS_PM_PICKUP_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STVDI (VELS Dimension Results) entities by [STVDI.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STVDI entities</param>
        /// <returns>A list of related STVDI entities</returns>
        public IReadOnlyList<STVDI> FindSTVDIByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<STVDI> result;
            if (STVDI_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDI entities by [STVDI.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STVDI entities</param>
        /// <param name="Value">A list of related STVDI entities</param>
        /// <returns>True if any STVDI entities are found</returns>
        public bool TryFindSTVDIByCAMPUS(int SCIKEY, out IReadOnlyList<STVDI> Value)
        {
            return STVDI_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all STVDO (VELS Domain Results) entities by [STVDO.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STVDO entities</param>
        /// <returns>A list of related STVDO entities</returns>
        public IReadOnlyList<STVDO> FindSTVDOByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<STVDO> result;
            if (STVDO_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDO>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDO entities by [STVDO.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find STVDO entities</param>
        /// <param name="Value">A list of related STVDO entities</param>
        /// <returns>True if any STVDO entities are found</returns>
        public bool TryFindSTVDOByCAMPUS(int SCIKEY, out IReadOnlyList<STVDO> Value)
        {
            return STVDO_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all TE (Calendar Events) entities by [TE.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find TE entities</param>
        /// <returns>A list of related TE entities</returns>
        public IReadOnlyList<TE> FindTEByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<TE> result;
            if (TE_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TE entities by [TE.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find TE entities</param>
        /// <param name="Value">A list of related TE entities</param>
        /// <returns>True if any TE entities are found</returns>
        public bool TryFindTEByCAMPUS(int SCIKEY, out IReadOnlyList<TE> Value)
        {
            return TE_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTByCAMPUS(int SCIKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.CAMPUS]-&gt;[SCI.SCIKEY]
        /// </summary>
        /// <param name="SCIKEY">SCIKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTByCAMPUS(int SCIKEY, out IReadOnlyList<TT> Value)
        {
            return TT_CAMPUSForeignIndex.Value.TryGetValue(SCIKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCI" /> fields for each CSV column header</returns>
        protected override Action<SCI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCIKEY":
                        mapper[i] = (e, v) => e.SCIKEY = int.Parse(v);
                        break;
                    case "CAMPUS_NAME":
                        mapper[i] = (e, v) => e.CAMPUS_NAME = v;
                        break;
                    case "CAMPUS_TYPE":
                        mapper[i] = (e, v) => e.CAMPUS_TYPE = v;
                        break;
                    case "SCHOOL_LINK":
                        mapper[i] = (e, v) => e.SCHOOL_LINK = v;
                        break;
                    case "SCHOOL_TYPE":
                        mapper[i] = (e, v) => e.SCHOOL_TYPE = v;
                        break;
                    case "SCHOOL_NAME":
                        mapper[i] = (e, v) => e.SCHOOL_NAME = v;
                        break;
                    case "MASTER_KEY":
                        mapper[i] = (e, v) => e.MASTER_KEY = v;
                        break;
                    case "ADMIN_SITE":
                        mapper[i] = (e, v) => e.ADMIN_SITE = v;
                        break;
                    case "SCH_PRINCIPAL":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL = v;
                        break;
                    case "SF_OIC":
                        mapper[i] = (e, v) => e.SF_OIC = v;
                        break;
                    case "SF_VPRIN":
                        mapper[i] = (e, v) => e.SF_VPRIN = v;
                        break;
                    case "SF_2VPRIN":
                        mapper[i] = (e, v) => e.SF_2VPRIN = v;
                        break;
                    case "SF_3VPRIN":
                        mapper[i] = (e, v) => e.SF_3VPRIN = v;
                        break;
                    case "SF_APRIN":
                        mapper[i] = (e, v) => e.SF_APRIN = v;
                        break;
                    case "SF_BMANAGER":
                        mapper[i] = (e, v) => e.SF_BMANAGER = v;
                        break;
                    case "SF_VAC_CONTACT":
                        mapper[i] = (e, v) => e.SF_VAC_CONTACT = v;
                        break;
                    case "SF_EMERG_CONTACT":
                        mapper[i] = (e, v) => e.SF_EMERG_CONTACT = v;
                        break;
                    case "SAM_SCH_COUNCIL":
                        mapper[i] = (e, v) => e.SAM_SCH_COUNCIL = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PLATFORM":
                        mapper[i] = (e, v) => e.PLATFORM = v;
                        break;
                    case "CURRENT_RELEASE":
                        mapper[i] = (e, v) => e.CURRENT_RELEASE = v;
                        break;
                    case "RELEASE_ACTION":
                        mapper[i] = (e, v) => e.RELEASE_ACTION = v;
                        break;
                    case "RELEASE_DATE":
                        mapper[i] = (e, v) => e.RELEASE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SCHEMA_VERIFIED":
                        mapper[i] = (e, v) => e.SCHEMA_VERIFIED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "UPGRADE_VERSION":
                        mapper[i] = (e, v) => e.UPGRADE_VERSION = v;
                        break;
                    case "ECASES21_VERSION":
                        mapper[i] = (e, v) => e.ECASES21_VERSION = v;
                        break;
                    case "DMIRROR_VERSION":
                        mapper[i] = (e, v) => e.DMIRROR_VERSION = v;
                        break;
                    case "CURRENT_QUILT":
                        mapper[i] = (e, v) => e.CURRENT_QUILT = v;
                        break;
                    case "CURRENT_SEMESTER":
                        mapper[i] = (e, v) => e.CURRENT_SEMESTER = v;
                        break;
                    case "LAST_PROMOTION_DATE":
                        mapper[i] = (e, v) => e.LAST_PROMOTION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AGE_CALCULATION_DATE":
                        mapper[i] = (e, v) => e.AGE_CALCULATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NEXT_ENROLMENT_DATE":
                        mapper[i] = (e, v) => e.NEXT_ENROLMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GENDER_DEFAULT":
                        mapper[i] = (e, v) => e.GENDER_DEFAULT = v;
                        break;
                    case "TELEPHONE_PREFIX":
                        mapper[i] = (e, v) => e.TELEPHONE_PREFIX = v;
                        break;
                    case "REL_INSTR":
                        mapper[i] = (e, v) => e.REL_INSTR = v;
                        break;
                    case "CONSECUTIVE_DAYS":
                        mapper[i] = (e, v) => e.CONSECUTIVE_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CUMULATIVE_DAYS":
                        mapper[i] = (e, v) => e.CUMULATIVE_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OVERALL_DAYS":
                        mapper[i] = (e, v) => e.OVERALL_DAYS = v == null ? (short?)null : short.Parse(v);
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
                    case "DESTINATION_SCHOOL":
                        mapper[i] = (e, v) => e.DESTINATION_SCHOOL = v;
                        break;
                    case "CAMPUS_EMAIL_CONTACT":
                        mapper[i] = (e, v) => e.CAMPUS_EMAIL_CONTACT = v;
                        break;
                    case "SCH_AOIC":
                        mapper[i] = (e, v) => e.SCH_AOIC = v;
                        break;
                    case "SCH_VPRIN":
                        mapper[i] = (e, v) => e.SCH_VPRIN = v;
                        break;
                    case "SCH_BMANAGER":
                        mapper[i] = (e, v) => e.SCH_BMANAGER = v;
                        break;
                    case "SCH_VAC_CONTACT":
                        mapper[i] = (e, v) => e.SCH_VAC_CONTACT = v;
                        break;
                    case "SCH_EMERG_CONTACT":
                        mapper[i] = (e, v) => e.SCH_EMERG_CONTACT = v;
                        break;
                    case "SCH_COUNCIL_PRES":
                        mapper[i] = (e, v) => e.SCH_COUNCIL_PRES = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SCH_MASTER_KEY":
                        mapper[i] = (e, v) => e.SCH_MASTER_KEY = v;
                        break;
                    case "PROFILE_UPDATED":
                        mapper[i] = (e, v) => e.PROFILE_UPDATED = v;
                        break;
                    case "CAMPUS_OPEN_IND":
                        mapper[i] = (e, v) => e.CAMPUS_OPEN_IND = v;
                        break;
                    case "PROFILE_SENT":
                        mapper[i] = (e, v) => e.PROFILE_SENT = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SPEC_CURR_IND":
                        mapper[i] = (e, v) => e.SPEC_CURR_IND = v;
                        break;
                    case "GLOBAL_ID":
                        mapper[i] = (e, v) => e.GLOBAL_ID = v == null ? (int?)null : int.Parse(v);
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
