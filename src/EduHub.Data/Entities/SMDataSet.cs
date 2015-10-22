using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms Data Set
    /// </summary>
    public sealed partial class SMDataSet : SetBase<SM>
    {
        private Lazy<Dictionary<string, SM>> ROOMIndex;

        private Lazy<Dictionary<string, IReadOnlyList<KGC>>> KGC_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SAD>>> SAD_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCAM>>> SCAM_MEETING_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCL>>> SCL_ROOM01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCL>>> SCL_ROOM02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_OTHER_LOCATIONForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGM>>> SGM_MEETING_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SMAQ>>> SMAQ_SMAQKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SMAV>>> SMAV_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>> SMGROUP_GROUPKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>> SMGROUP_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTB>>> TCTB_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_R1ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_R2ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_EXTRA_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTR>>> TCTR_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TE>>> TE_LOCATIONForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TETE>>> TETE_LOCATIONForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_R1ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_R2ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_EXTRA_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTEF>>> TTEF_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTEX>>> TTEX_EXAM_ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTTG>>> TTTG_R1ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTTG>>> TTTG_R2ROOMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TXAS>>> TXAS_LOCATIONForeignIndex;

        internal SMDataSet(EduHubContext Context)
            : base(Context)
        {
            ROOMIndex = new Lazy<Dictionary<string, SM>>(() => this.ToDictionary(e => e.ROOM));

            KGC_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGC>>>(() =>
                    Context.KGC
                          .Where(e => e.ROOM != null)
                          .GroupBy(e => e.ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGC>)g.ToList()
                          .AsReadOnly()));

            SAD_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAD>>>(() =>
                    Context.SAD
                          .Where(e => e.ROOM != null)
                          .GroupBy(e => e.ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAD>)g.ToList()
                          .AsReadOnly()));

            SCAM_MEETING_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCAM>>>(() =>
                    Context.SCAM
                          .Where(e => e.MEETING_ROOM != null)
                          .GroupBy(e => e.MEETING_ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCAM>)g.ToList()
                          .AsReadOnly()));

            SCL_ROOM01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCL>>>(() =>
                    Context.SCL
                          .Where(e => e.ROOM01 != null)
                          .GroupBy(e => e.ROOM01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCL>)g.ToList()
                          .AsReadOnly()));

            SCL_ROOM02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCL>>>(() =>
                    Context.SCL
                          .Where(e => e.ROOM02 != null)
                          .GroupBy(e => e.ROOM02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCL>)g.ToList()
                          .AsReadOnly()));

            SF_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.ROOM != null)
                          .GroupBy(e => e.ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_OTHER_LOCATIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.OTHER_LOCATION != null)
                          .GroupBy(e => e.OTHER_LOCATION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SGM_MEETING_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGM>>>(() =>
                    Context.SGM
                          .Where(e => e.MEETING_ROOM != null)
                          .GroupBy(e => e.MEETING_ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGM>)g.ToList()
                          .AsReadOnly()));

            SMAQ_SMAQKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SMAQ>>>(() =>
                    Context.SMAQ
                          .Where(e => e.SMAQKEY != null)
                          .GroupBy(e => e.SMAQKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMAQ>)g.ToList()
                          .AsReadOnly()));

            SMAV_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SMAV>>>(() =>
                    Context.SMAV
                          .Where(e => e.ROOM != null)
                          .GroupBy(e => e.ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMAV>)g.ToList()
                          .AsReadOnly()));

            SMGROUP_GROUPKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>>(() =>
                    Context.SMGROUP
                          .Where(e => e.GROUPKEY != null)
                          .GroupBy(e => e.GROUPKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMGROUP>)g.ToList()
                          .AsReadOnly()));

            SMGROUP_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SMGROUP>>>(() =>
                    Context.SMGROUP
                          .Where(e => e.ROOM != null)
                          .GroupBy(e => e.ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMGROUP>)g.ToList()
                          .AsReadOnly()));

            TCTB_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTB>>>(() =>
                    Context.TCTB
                          .Where(e => e.ROOM != null)
                          .GroupBy(e => e.ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTB>)g.ToList()
                          .AsReadOnly()));

            TCTQ_R1ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.R1ROOM != null)
                          .GroupBy(e => e.R1ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TCTQ_R2ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.R2ROOM != null)
                          .GroupBy(e => e.R2ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TCTQ_EXTRA_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.EXTRA_ROOM != null)
                          .GroupBy(e => e.EXTRA_ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TCTR_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTR>>>(() =>
                    Context.TCTR
                          .Where(e => e.ROOM != null)
                          .GroupBy(e => e.ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTR>)g.ToList()
                          .AsReadOnly()));

            TE_LOCATIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TE>>>(() =>
                    Context.TE
                          .Where(e => e.LOCATION != null)
                          .GroupBy(e => e.LOCATION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TE>)g.ToList()
                          .AsReadOnly()));

            TETE_LOCATIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TETE>>>(() =>
                    Context.TETE
                          .Where(e => e.LOCATION != null)
                          .GroupBy(e => e.LOCATION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TETE>)g.ToList()
                          .AsReadOnly()));

            THTQ_R1ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.R1ROOM != null)
                          .GroupBy(e => e.R1ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

            THTQ_R2ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.R2ROOM != null)
                          .GroupBy(e => e.R2ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

            THTQ_EXTRA_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.EXTRA_ROOM != null)
                          .GroupBy(e => e.EXTRA_ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

            TTEF_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTEF>>>(() =>
                    Context.TTEF
                          .Where(e => e.ROOM != null)
                          .GroupBy(e => e.ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTEF>)g.ToList()
                          .AsReadOnly()));

            TTEX_EXAM_ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTEX>>>(() =>
                    Context.TTEX
                          .Where(e => e.EXAM_ROOM != null)
                          .GroupBy(e => e.EXAM_ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTEX>)g.ToList()
                          .AsReadOnly()));

            TTTG_R1ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTTG>>>(() =>
                    Context.TTTG
                          .Where(e => e.R1ROOM != null)
                          .GroupBy(e => e.R1ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTTG>)g.ToList()
                          .AsReadOnly()));

            TTTG_R2ROOMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTTG>>>(() =>
                    Context.TTTG
                          .Where(e => e.R2ROOM != null)
                          .GroupBy(e => e.R2ROOM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTTG>)g.ToList()
                          .AsReadOnly()));

            TXAS_LOCATIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TXAS>>>(() =>
                    Context.TXAS
                          .Where(e => e.LOCATION != null)
                          .GroupBy(e => e.LOCATION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TXAS>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SM"; } }

        /// <summary>
        /// Find SM by ROOM key field
        /// </summary>
        /// <param name="Key">ROOM value used to find SM</param>
        /// <returns>Related SM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ROOM value didn't match any SM entities</exception>
        public SM FindByROOM(string Key)
        {
            SM result;
            if (ROOMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SM by ROOM key field
        /// </summary>
        /// <param name="Key">ROOM value used to find SM</param>
        /// <param name="Value">Related SM entity</param>
        /// <returns>True if the SM entity is found</returns>
        public bool TryFindByROOM(string Key, out SM Value)
        {
            return ROOMIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SM by ROOM key field
        /// </summary>
        /// <param name="Key">ROOM value used to find SM</param>
        /// <returns>Related SM entity, or null if not found</returns>
        public SM TryFindByROOM(string Key)
        {
            SM result;
            if (ROOMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all KGC (Home Groups) entities by [KGC.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find KGC entities</param>
        /// <returns>A list of related KGC entities</returns>
        public IReadOnlyList<KGC> FindKGCByROOM(string ROOM)
        {
            IReadOnlyList<KGC> result;
            if (KGC_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<KGC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGC entities by [KGC.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find KGC entities</param>
        /// <param name="Value">A list of related KGC entities</param>
        /// <returns>True if any KGC entities are found</returns>
        public bool TryFindKGCByROOM(string ROOM, out IReadOnlyList<KGC> Value)
        {
            return KGC_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SAD (Accidents) entities by [SAD.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SAD entities</param>
        /// <returns>A list of related SAD entities</returns>
        public IReadOnlyList<SAD> FindSADByROOM(string ROOM)
        {
            IReadOnlyList<SAD> result;
            if (SAD_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SAD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAD entities by [SAD.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SAD entities</param>
        /// <param name="Value">A list of related SAD entities</param>
        /// <returns>True if any SAD entities are found</returns>
        public bool TryFindSADByROOM(string ROOM, out IReadOnlyList<SAD> Value)
        {
            return SAD_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SCAM (School Association Meetings) entities by [SCAM.MEETING_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SCAM entities</param>
        /// <returns>A list of related SCAM entities</returns>
        public IReadOnlyList<SCAM> FindSCAMByMEETING_ROOM(string ROOM)
        {
            IReadOnlyList<SCAM> result;
            if (SCAM_MEETING_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SCAM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCAM entities by [SCAM.MEETING_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SCAM entities</param>
        /// <param name="Value">A list of related SCAM entities</param>
        /// <returns>True if any SCAM entities are found</returns>
        public bool TryFindSCAMByMEETING_ROOM(string ROOM, out IReadOnlyList<SCAM> Value)
        {
            return SCAM_MEETING_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SCL (Subject Classes) entities by [SCL.ROOM01]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SCL entities</param>
        /// <returns>A list of related SCL entities</returns>
        public IReadOnlyList<SCL> FindSCLByROOM01(string ROOM)
        {
            IReadOnlyList<SCL> result;
            if (SCL_ROOM01ForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SCL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCL entities by [SCL.ROOM01]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SCL entities</param>
        /// <param name="Value">A list of related SCL entities</param>
        /// <returns>True if any SCL entities are found</returns>
        public bool TryFindSCLByROOM01(string ROOM, out IReadOnlyList<SCL> Value)
        {
            return SCL_ROOM01ForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SCL (Subject Classes) entities by [SCL.ROOM02]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SCL entities</param>
        /// <returns>A list of related SCL entities</returns>
        public IReadOnlyList<SCL> FindSCLByROOM02(string ROOM)
        {
            IReadOnlyList<SCL> result;
            if (SCL_ROOM02ForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SCL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCL entities by [SCL.ROOM02]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SCL entities</param>
        /// <param name="Value">A list of related SCL entities</param>
        /// <returns>True if any SCL entities are found</returns>
        public bool TryFindSCLByROOM02(string ROOM, out IReadOnlyList<SCL> Value)
        {
            return SCL_ROOM02ForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByROOM(string ROOM)
        {
            IReadOnlyList<SF> result;
            if (SF_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByROOM(string ROOM, out IReadOnlyList<SF> Value)
        {
            return SF_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.OTHER_LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByOTHER_LOCATION(string ROOM)
        {
            IReadOnlyList<SF> result;
            if (SF_OTHER_LOCATIONForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.OTHER_LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByOTHER_LOCATION(string ROOM, out IReadOnlyList<SF> Value)
        {
            return SF_OTHER_LOCATIONForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SGM (Special Group Meetings) entities by [SGM.MEETING_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SGM entities</param>
        /// <returns>A list of related SGM entities</returns>
        public IReadOnlyList<SGM> FindSGMByMEETING_ROOM(string ROOM)
        {
            IReadOnlyList<SGM> result;
            if (SGM_MEETING_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SGM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGM entities by [SGM.MEETING_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SGM entities</param>
        /// <param name="Value">A list of related SGM entities</param>
        /// <returns>True if any SGM entities are found</returns>
        public bool TryFindSGMByMEETING_ROOM(string ROOM, out IReadOnlyList<SGM> Value)
        {
            return SGM_MEETING_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SMAQ (Room Availability in Quilt) entities by [SMAQ.SMAQKEY]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAQ entities</param>
        /// <returns>A list of related SMAQ entities</returns>
        public IReadOnlyList<SMAQ> FindSMAQBySMAQKEY(string ROOM)
        {
            IReadOnlyList<SMAQ> result;
            if (SMAQ_SMAQKEYForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SMAQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMAQ entities by [SMAQ.SMAQKEY]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAQ entities</param>
        /// <param name="Value">A list of related SMAQ entities</param>
        /// <returns>True if any SMAQ entities are found</returns>
        public bool TryFindSMAQBySMAQKEY(string ROOM, out IReadOnlyList<SMAQ> Value)
        {
            return SMAQ_SMAQKEYForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SMAV (Room Availablity Extras) entities by [SMAV.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV entities</param>
        /// <returns>A list of related SMAV entities</returns>
        public IReadOnlyList<SMAV> FindSMAVByROOM(string ROOM)
        {
            IReadOnlyList<SMAV> result;
            if (SMAV_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SMAV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMAV entities by [SMAV.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMAV entities</param>
        /// <param name="Value">A list of related SMAV entities</param>
        /// <returns>True if any SMAV entities are found</returns>
        public bool TryFindSMAVByROOM(string ROOM, out IReadOnlyList<SMAV> Value)
        {
            return SMAV_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SMGROUP (Rooms group) entities by [SMGROUP.GROUPKEY]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP entities</param>
        /// <returns>A list of related SMGROUP entities</returns>
        public IReadOnlyList<SMGROUP> FindSMGROUPByGROUPKEY(string ROOM)
        {
            IReadOnlyList<SMGROUP> result;
            if (SMGROUP_GROUPKEYForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SMGROUP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMGROUP entities by [SMGROUP.GROUPKEY]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP entities</param>
        /// <param name="Value">A list of related SMGROUP entities</param>
        /// <returns>True if any SMGROUP entities are found</returns>
        public bool TryFindSMGROUPByGROUPKEY(string ROOM, out IReadOnlyList<SMGROUP> Value)
        {
            return SMGROUP_GROUPKEYForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all SMGROUP (Rooms group) entities by [SMGROUP.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP entities</param>
        /// <returns>A list of related SMGROUP entities</returns>
        public IReadOnlyList<SMGROUP> FindSMGROUPByROOM(string ROOM)
        {
            IReadOnlyList<SMGROUP> result;
            if (SMGROUP_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<SMGROUP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMGROUP entities by [SMGROUP.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find SMGROUP entities</param>
        /// <param name="Value">A list of related SMGROUP entities</param>
        /// <returns>True if any SMGROUP entities are found</returns>
        public bool TryFindSMGROUPByROOM(string ROOM, out IReadOnlyList<SMGROUP> Value)
        {
            return SMGROUP_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TCTB (Teacher Absences) entities by [TCTB.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTB entities</param>
        /// <returns>A list of related TCTB entities</returns>
        public IReadOnlyList<TCTB> FindTCTBByROOM(string ROOM)
        {
            IReadOnlyList<TCTB> result;
            if (TCTB_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTB entities by [TCTB.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTB entities</param>
        /// <param name="Value">A list of related TCTB entities</param>
        /// <returns>True if any TCTB entities are found</returns>
        public bool TryFindTCTBByROOM(string ROOM, out IReadOnlyList<TCTB> Value)
        {
            return TCTB_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByR1ROOM(string ROOM)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_R1ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByR1ROOM(string ROOM, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_R1ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByR2ROOM(string ROOM)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_R2ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByR2ROOM(string ROOM, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_R2ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.EXTRA_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByEXTRA_ROOM(string ROOM)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_EXTRA_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.EXTRA_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByEXTRA_ROOM(string ROOM, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_EXTRA_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TCTR (Teacher Replacements) entities by [TCTR.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR entities</param>
        /// <returns>A list of related TCTR entities</returns>
        public IReadOnlyList<TCTR> FindTCTRByROOM(string ROOM)
        {
            IReadOnlyList<TCTR> result;
            if (TCTR_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTR entities by [TCTR.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TCTR entities</param>
        /// <param name="Value">A list of related TCTR entities</param>
        /// <returns>True if any TCTR entities are found</returns>
        public bool TryFindTCTRByROOM(string ROOM, out IReadOnlyList<TCTR> Value)
        {
            return TCTR_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TE (Calendar Events) entities by [TE.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TE entities</param>
        /// <returns>A list of related TE entities</returns>
        public IReadOnlyList<TE> FindTEByLOCATION(string ROOM)
        {
            IReadOnlyList<TE> result;
            if (TE_LOCATIONForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TE entities by [TE.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TE entities</param>
        /// <param name="Value">A list of related TE entities</param>
        /// <returns>True if any TE entities are found</returns>
        public bool TryFindTEByLOCATION(string ROOM, out IReadOnlyList<TE> Value)
        {
            return TE_LOCATIONForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TETE (Event Instances) entities by [TETE.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TETE entities</param>
        /// <returns>A list of related TETE entities</returns>
        public IReadOnlyList<TETE> FindTETEByLOCATION(string ROOM)
        {
            IReadOnlyList<TETE> result;
            if (TETE_LOCATIONForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TETE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TETE entities by [TETE.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TETE entities</param>
        /// <param name="Value">A list of related TETE entities</param>
        /// <returns>True if any TETE entities are found</returns>
        public bool TryFindTETEByLOCATION(string ROOM, out IReadOnlyList<TETE> Value)
        {
            return TETE_LOCATIONForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQByR1ROOM(string ROOM)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_R1ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQByR1ROOM(string ROOM, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_R1ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQByR2ROOM(string ROOM)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_R2ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQByR2ROOM(string ROOM, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_R2ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.EXTRA_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQByEXTRA_ROOM(string ROOM)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_EXTRA_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.EXTRA_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQByEXTRA_ROOM(string ROOM, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_EXTRA_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TTEF (Exam Staff) entities by [TTEF.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF entities</param>
        /// <returns>A list of related TTEF entities</returns>
        public IReadOnlyList<TTEF> FindTTEFByROOM(string ROOM)
        {
            IReadOnlyList<TTEF> result;
            if (TTEF_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TTEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTEF entities by [TTEF.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEF entities</param>
        /// <param name="Value">A list of related TTEF entities</param>
        /// <returns>True if any TTEF entities are found</returns>
        public bool TryFindTTEFByROOM(string ROOM, out IReadOnlyList<TTEF> Value)
        {
            return TTEF_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TTEX (Exam Grid) entities by [TTEX.EXAM_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEX entities</param>
        /// <returns>A list of related TTEX entities</returns>
        public IReadOnlyList<TTEX> FindTTEXByEXAM_ROOM(string ROOM)
        {
            IReadOnlyList<TTEX> result;
            if (TTEX_EXAM_ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TTEX>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTEX entities by [TTEX.EXAM_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTEX entities</param>
        /// <param name="Value">A list of related TTEX entities</param>
        /// <returns>True if any TTEX entities are found</returns>
        public bool TryFindTTEXByEXAM_ROOM(string ROOM, out IReadOnlyList<TTEX> Value)
        {
            return TTEX_EXAM_ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TTTG (Grid Subjects) entities by [TTTG.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTTG entities</param>
        /// <returns>A list of related TTTG entities</returns>
        public IReadOnlyList<TTTG> FindTTTGByR1ROOM(string ROOM)
        {
            IReadOnlyList<TTTG> result;
            if (TTTG_R1ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TTTG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTTG entities by [TTTG.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTTG entities</param>
        /// <param name="Value">A list of related TTTG entities</param>
        /// <returns>True if any TTTG entities are found</returns>
        public bool TryFindTTTGByR1ROOM(string ROOM, out IReadOnlyList<TTTG> Value)
        {
            return TTTG_R1ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TTTG (Grid Subjects) entities by [TTTG.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTTG entities</param>
        /// <returns>A list of related TTTG entities</returns>
        public IReadOnlyList<TTTG> FindTTTGByR2ROOM(string ROOM)
        {
            IReadOnlyList<TTTG> result;
            if (TTTG_R2ROOMForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TTTG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTTG entities by [TTTG.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TTTG entities</param>
        /// <param name="Value">A list of related TTTG entities</param>
        /// <returns>True if any TTTG entities are found</returns>
        public bool TryFindTTTGByR2ROOM(string ROOM, out IReadOnlyList<TTTG> Value)
        {
            return TTTG_R2ROOMForeignIndex.Value.TryGetValue(ROOM, out Value);
        }

        /// <summary>
        /// Find all TXAS (Actual Sessions) entities by [TXAS.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TXAS entities</param>
        /// <returns>A list of related TXAS entities</returns>
        public IReadOnlyList<TXAS> FindTXASByLOCATION(string ROOM)
        {
            IReadOnlyList<TXAS> result;
            if (TXAS_LOCATIONForeignIndex.Value.TryGetValue(ROOM, out result))
            {
                return result;
            }
            else
            {
                return new List<TXAS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TXAS entities by [TXAS.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        /// <param name="ROOM">ROOM value used to find TXAS entities</param>
        /// <param name="Value">A list of related TXAS entities</param>
        /// <returns>True if any TXAS entities are found</returns>
        public bool TryFindTXASByLOCATION(string ROOM, out IReadOnlyList<TXAS> Value)
        {
            return TXAS_LOCATIONForeignIndex.Value.TryGetValue(ROOM, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SM" /> fields for each CSV column header</returns>
        protected override Action<SM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "SEATING":
                        mapper[i] = (e, v) => e.SEATING = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROOM_TYPE":
                        mapper[i] = (e, v) => e.ROOM_TYPE = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "AREA_CODE":
                        mapper[i] = (e, v) => e.AREA_CODE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STAFF_CODE":
                        mapper[i] = (e, v) => e.STAFF_CODE = v;
                        break;
                    case "COMMENTA":
                        mapper[i] = (e, v) => e.COMMENTA = v;
                        break;
                    case "BOARD":
                        mapper[i] = (e, v) => e.BOARD = v;
                        break;
                    case "BLACKOUT":
                        mapper[i] = (e, v) => e.BLACKOUT = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GROUP_INDICATOR":
                        mapper[i] = (e, v) => e.GROUP_INDICATOR = v;
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
