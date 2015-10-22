using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subjects Data Set
    /// </summary>
    public sealed partial class SUDataSet : SetBase<SU>
    {
        private Lazy<Dictionary<string, SU>> SUKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_SUBJECTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ03ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ04ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ05ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ06ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ07ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ08ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ09ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ10ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ11ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ12ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ13ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ14ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ15ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ16ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ17ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ18ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ19ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJ20ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCL>>> SCL_SUBJECTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT03ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT04ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT05ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT06ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT07ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT08ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT09ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_SUBJECT10ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SGSC>>> SGSC_SULINKForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STMA>>> STMA_MKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SU>>> SU_PROMOTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SUBL>>> SUBL_BLKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SUPR>>> SUPR_SUPRKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SUPR>>> SUPR_PREREQUISITEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTB>>> TCTB_SUBJForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_SUBJForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TE>>> TE_SUBJForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_SUBJForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTES>>> TTES_SUBJForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTTG>>> TTTG_SUBJForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TXAS>>> TXAS_SUBJECTForeignIndex;

        internal SUDataSet(EduHubContext Context)
            : base(Context)
        {
            SUKEYIndex = new Lazy<Dictionary<string, SU>>(() => this.ToDictionary(e => e.SUKEY));

            DFF_SUBJECTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.SUBJECT != null)
                          .GroupBy(e => e.SUBJECT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ01 != null)
                          .GroupBy(e => e.SUBJ01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ02 != null)
                          .GroupBy(e => e.SUBJ02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ03ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ03 != null)
                          .GroupBy(e => e.SUBJ03)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ04ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ04 != null)
                          .GroupBy(e => e.SUBJ04)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ05ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ05 != null)
                          .GroupBy(e => e.SUBJ05)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ06ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ06 != null)
                          .GroupBy(e => e.SUBJ06)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ07ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ07 != null)
                          .GroupBy(e => e.SUBJ07)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ08ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ08 != null)
                          .GroupBy(e => e.SUBJ08)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ09ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ09 != null)
                          .GroupBy(e => e.SUBJ09)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ10ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ10 != null)
                          .GroupBy(e => e.SUBJ10)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ11ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ11 != null)
                          .GroupBy(e => e.SUBJ11)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ12ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ12 != null)
                          .GroupBy(e => e.SUBJ12)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ13ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ13 != null)
                          .GroupBy(e => e.SUBJ13)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ14ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ14 != null)
                          .GroupBy(e => e.SUBJ14)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ15ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ15 != null)
                          .GroupBy(e => e.SUBJ15)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ16ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ16 != null)
                          .GroupBy(e => e.SUBJ16)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ17ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ17 != null)
                          .GroupBy(e => e.SUBJ17)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ18ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ18 != null)
                          .GroupBy(e => e.SUBJ18)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ19ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ19 != null)
                          .GroupBy(e => e.SUBJ19)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJ20ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJ20 != null)
                          .GroupBy(e => e.SUBJ20)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SCL_SUBJECTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCL>>>(() =>
                    Context.SCL
                          .Where(e => e.SUBJECT != null)
                          .GroupBy(e => e.SUBJECT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCL>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT01 != null)
                          .GroupBy(e => e.SUBJECT01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT02 != null)
                          .GroupBy(e => e.SUBJECT02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT03ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT03 != null)
                          .GroupBy(e => e.SUBJECT03)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT04ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT04 != null)
                          .GroupBy(e => e.SUBJECT04)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT05ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT05 != null)
                          .GroupBy(e => e.SUBJECT05)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT06ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT06 != null)
                          .GroupBy(e => e.SUBJECT06)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT07ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT07 != null)
                          .GroupBy(e => e.SUBJECT07)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT08ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT08 != null)
                          .GroupBy(e => e.SUBJECT08)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT09ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT09 != null)
                          .GroupBy(e => e.SUBJECT09)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_SUBJECT10ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.SUBJECT10 != null)
                          .GroupBy(e => e.SUBJECT10)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SGSC_SULINKForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SGSC>>>(() =>
                    Context.SGSC
                          .Where(e => e.SULINK != null)
                          .GroupBy(e => e.SULINK)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SGSC>)g.ToList()
                          .AsReadOnly()));

            STMA_MKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STMA>>>(() =>
                    Context.STMA
                          .Where(e => e.MKEY != null)
                          .GroupBy(e => e.MKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STMA>)g.ToList()
                          .AsReadOnly()));

            SU_PROMOTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SU>>>(() =>
                    Context.SU
                          .Where(e => e.PROMOTE != null)
                          .GroupBy(e => e.PROMOTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SU>)g.ToList()
                          .AsReadOnly()));

            SUBL_BLKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SUBL>>>(() =>
                    Context.SUBL
                          .Where(e => e.BLKEY != null)
                          .GroupBy(e => e.BLKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SUBL>)g.ToList()
                          .AsReadOnly()));

            SUPR_SUPRKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SUPR>>>(() =>
                    Context.SUPR
                          .Where(e => e.SUPRKEY != null)
                          .GroupBy(e => e.SUPRKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SUPR>)g.ToList()
                          .AsReadOnly()));

            SUPR_PREREQUISITEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SUPR>>>(() =>
                    Context.SUPR
                          .Where(e => e.PREREQUISITE != null)
                          .GroupBy(e => e.PREREQUISITE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SUPR>)g.ToList()
                          .AsReadOnly()));

            TCTB_SUBJForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTB>>>(() =>
                    Context.TCTB
                          .Where(e => e.SUBJ != null)
                          .GroupBy(e => e.SUBJ)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTB>)g.ToList()
                          .AsReadOnly()));

            TCTQ_SUBJForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.SUBJ != null)
                          .GroupBy(e => e.SUBJ)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TE_SUBJForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TE>>>(() =>
                    Context.TE
                          .Where(e => e.SUBJ != null)
                          .GroupBy(e => e.SUBJ)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TE>)g.ToList()
                          .AsReadOnly()));

            THTQ_SUBJForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.SUBJ != null)
                          .GroupBy(e => e.SUBJ)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

            TTES_SUBJForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTES>>>(() =>
                    Context.TTES
                          .Where(e => e.SUBJ != null)
                          .GroupBy(e => e.SUBJ)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTES>)g.ToList()
                          .AsReadOnly()));

            TTTG_SUBJForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTTG>>>(() =>
                    Context.TTTG
                          .Where(e => e.SUBJ != null)
                          .GroupBy(e => e.SUBJ)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTTG>)g.ToList()
                          .AsReadOnly()));

            TXAS_SUBJECTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TXAS>>>(() =>
                    Context.TXAS
                          .Where(e => e.SUBJECT != null)
                          .GroupBy(e => e.SUBJECT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TXAS>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SU"; } }

        /// <summary>
        /// Find SU by SUKEY key field
        /// </summary>
        /// <param name="Key">SUKEY value used to find SU</param>
        /// <returns>Related SU entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SUKEY value didn't match any SU entities</exception>
        public SU FindBySUKEY(string Key)
        {
            SU result;
            if (SUKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SU by SUKEY key field
        /// </summary>
        /// <param name="Key">SUKEY value used to find SU</param>
        /// <param name="Value">Related SU entity</param>
        /// <returns>True if the SU entity is found</returns>
        public bool TryFindBySUKEY(string Key, out SU Value)
        {
            return SUKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SU by SUKEY key field
        /// </summary>
        /// <param name="Key">SUKEY value used to find SU</param>
        /// <returns>Related SU entity, or null if not found</returns>
        public SU TryFindBySUKEY(string Key)
        {
            SU result;
            if (SUKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFBySUBJECT(string SUKEY)
        {
            IReadOnlyList<DFF> result;
            if (DFF_SUBJECTForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFBySUBJECT(string SUKEY, out IReadOnlyList<DFF> Value)
        {
            return DFF_SUBJECTForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ01]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ01(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ01ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ01]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ01(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ01ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ02]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ02(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ02ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ02]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ02(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ02ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ03]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ03(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ03ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ03]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ03(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ03ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ04]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ04(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ04ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ04]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ04(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ04ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ05]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ05(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ05ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ05]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ05(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ05ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ06]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ06(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ06ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ06]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ06(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ06ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ07]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ07(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ07ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ07]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ07(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ07ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ08]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ08(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ08ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ08]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ08(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ08ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ09]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ09(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ09ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ09]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ09(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ09ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ10]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ10(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ10ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ10]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ10(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ10ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ11]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ11(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ11ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ11]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ11(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ11ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ12]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ12(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ12ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ12]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ12(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ12ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ13]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ13(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ13ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ13]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ13(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ13ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ14]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ14(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ14ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ14]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ14(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ14ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ15]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ15(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ15ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ15]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ15(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ15ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ16]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ16(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ16ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ16]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ16(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ16ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ17]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ17(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ17ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ17]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ17(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ17ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ18]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ18(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ18ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ18]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ18(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ18ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ19]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ19(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ19ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ19]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ19(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ19ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJ20]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJ20(string SUKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJ20ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJ20]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJ20(string SUKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJ20ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SCL (Subject Classes) entities by [SCL.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SCL entities</param>
        /// <returns>A list of related SCL entities</returns>
        public IReadOnlyList<SCL> FindSCLBySUBJECT(string SUKEY)
        {
            IReadOnlyList<SCL> result;
            if (SCL_SUBJECTForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCL entities by [SCL.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SCL entities</param>
        /// <param name="Value">A list of related SCL entities</param>
        /// <returns>True if any SCL entities are found</returns>
        public bool TryFindSCLBySUBJECT(string SUKEY, out IReadOnlyList<SCL> Value)
        {
            return SCL_SUBJECTForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT01]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT01(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT01ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT01]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT01(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT01ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT02]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT02(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT02ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT02]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT02(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT02ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT03]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT03(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT03ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT03]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT03(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT03ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT04]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT04(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT04ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT04]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT04(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT04ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT05]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT05(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT05ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT05]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT05(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT05ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT06]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT06(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT06ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT06]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT06(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT06ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT07]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT07(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT07ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT07]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT07(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT07ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT08]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT08(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT08ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT08]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT08(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT08ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT09]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT09(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT09ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT09]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT09(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT09ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.SUBJECT10]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFBySUBJECT10(string SUKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_SUBJECT10ForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.SUBJECT10]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFBySUBJECT10(string SUKEY, out IReadOnlyList<SF> Value)
        {
            return SF_SUBJECT10ForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SGSC (Subject/Class Eligibility Criteria) entities by [SGSC.SULINK]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SGSC entities</param>
        /// <returns>A list of related SGSC entities</returns>
        public IReadOnlyList<SGSC> FindSGSCBySULINK(string SUKEY)
        {
            IReadOnlyList<SGSC> result;
            if (SGSC_SULINKForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SGSC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SGSC entities by [SGSC.SULINK]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SGSC entities</param>
        /// <param name="Value">A list of related SGSC entities</param>
        /// <returns>True if any SGSC entities are found</returns>
        public bool TryFindSGSCBySULINK(string SUKEY, out IReadOnlyList<SGSC> Value)
        {
            return SGSC_SULINKForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all STMA (Subject Selections &amp; Marks) entities by [STMA.MKEY]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find STMA entities</param>
        /// <returns>A list of related STMA entities</returns>
        public IReadOnlyList<STMA> FindSTMAByMKEY(string SUKEY)
        {
            IReadOnlyList<STMA> result;
            if (STMA_MKEYForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STMA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STMA entities by [STMA.MKEY]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find STMA entities</param>
        /// <param name="Value">A list of related STMA entities</param>
        /// <returns>True if any STMA entities are found</returns>
        public bool TryFindSTMAByMKEY(string SUKEY, out IReadOnlyList<STMA> Value)
        {
            return STMA_MKEYForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SU (Subjects) entities by [SU.PROMOTE]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SU entities</param>
        /// <returns>A list of related SU entities</returns>
        public IReadOnlyList<SU> FindSUByPROMOTE(string SUKEY)
        {
            IReadOnlyList<SU> result;
            if (SU_PROMOTEForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SU entities by [SU.PROMOTE]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SU entities</param>
        /// <param name="Value">A list of related SU entities</param>
        /// <returns>True if any SU entities are found</returns>
        public bool TryFindSUByPROMOTE(string SUKEY, out IReadOnlyList<SU> Value)
        {
            return SU_PROMOTEForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SUBL (Subject Book List) entities by [SUBL.BLKEY]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SUBL entities</param>
        /// <returns>A list of related SUBL entities</returns>
        public IReadOnlyList<SUBL> FindSUBLByBLKEY(string SUKEY)
        {
            IReadOnlyList<SUBL> result;
            if (SUBL_BLKEYForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SUBL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SUBL entities by [SUBL.BLKEY]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SUBL entities</param>
        /// <param name="Value">A list of related SUBL entities</param>
        /// <returns>True if any SUBL entities are found</returns>
        public bool TryFindSUBLByBLKEY(string SUKEY, out IReadOnlyList<SUBL> Value)
        {
            return SUBL_BLKEYForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SUPR (Subject Prerequisites) entities by [SUPR.SUPRKEY]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SUPR entities</param>
        /// <returns>A list of related SUPR entities</returns>
        public IReadOnlyList<SUPR> FindSUPRBySUPRKEY(string SUKEY)
        {
            IReadOnlyList<SUPR> result;
            if (SUPR_SUPRKEYForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SUPR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SUPR entities by [SUPR.SUPRKEY]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SUPR entities</param>
        /// <param name="Value">A list of related SUPR entities</param>
        /// <returns>True if any SUPR entities are found</returns>
        public bool TryFindSUPRBySUPRKEY(string SUKEY, out IReadOnlyList<SUPR> Value)
        {
            return SUPR_SUPRKEYForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all SUPR (Subject Prerequisites) entities by [SUPR.PREREQUISITE]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SUPR entities</param>
        /// <returns>A list of related SUPR entities</returns>
        public IReadOnlyList<SUPR> FindSUPRByPREREQUISITE(string SUKEY)
        {
            IReadOnlyList<SUPR> result;
            if (SUPR_PREREQUISITEForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SUPR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SUPR entities by [SUPR.PREREQUISITE]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find SUPR entities</param>
        /// <param name="Value">A list of related SUPR entities</param>
        /// <returns>True if any SUPR entities are found</returns>
        public bool TryFindSUPRByPREREQUISITE(string SUKEY, out IReadOnlyList<SUPR> Value)
        {
            return SUPR_PREREQUISITEForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all TCTB (Teacher Absences) entities by [TCTB.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TCTB entities</param>
        /// <returns>A list of related TCTB entities</returns>
        public IReadOnlyList<TCTB> FindTCTBBySUBJ(string SUKEY)
        {
            IReadOnlyList<TCTB> result;
            if (TCTB_SUBJForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTB entities by [TCTB.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TCTB entities</param>
        /// <param name="Value">A list of related TCTB entities</param>
        /// <returns>True if any TCTB entities are found</returns>
        public bool TryFindTCTBBySUBJ(string SUKEY, out IReadOnlyList<TCTB> Value)
        {
            return TCTB_SUBJForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQBySUBJ(string SUKEY)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_SUBJForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQBySUBJ(string SUKEY, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_SUBJForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all TE (Calendar Events) entities by [TE.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TE entities</param>
        /// <returns>A list of related TE entities</returns>
        public IReadOnlyList<TE> FindTEBySUBJ(string SUKEY)
        {
            IReadOnlyList<TE> result;
            if (TE_SUBJForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TE entities by [TE.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TE entities</param>
        /// <param name="Value">A list of related TE entities</param>
        /// <returns>True if any TE entities are found</returns>
        public bool TryFindTEBySUBJ(string SUKEY, out IReadOnlyList<TE> Value)
        {
            return TE_SUBJForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQBySUBJ(string SUKEY)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_SUBJForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQBySUBJ(string SUKEY, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_SUBJForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all TTES (Exam Subjects) entities by [TTES.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TTES entities</param>
        /// <returns>A list of related TTES entities</returns>
        public IReadOnlyList<TTES> FindTTESBySUBJ(string SUKEY)
        {
            IReadOnlyList<TTES> result;
            if (TTES_SUBJForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTES>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTES entities by [TTES.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TTES entities</param>
        /// <param name="Value">A list of related TTES entities</param>
        /// <returns>True if any TTES entities are found</returns>
        public bool TryFindTTESBySUBJ(string SUKEY, out IReadOnlyList<TTES> Value)
        {
            return TTES_SUBJForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all TTTG (Grid Subjects) entities by [TTTG.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TTTG entities</param>
        /// <returns>A list of related TTTG entities</returns>
        public IReadOnlyList<TTTG> FindTTTGBySUBJ(string SUKEY)
        {
            IReadOnlyList<TTTG> result;
            if (TTTG_SUBJForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTTG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTTG entities by [TTTG.SUBJ]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TTTG entities</param>
        /// <param name="Value">A list of related TTTG entities</param>
        /// <returns>True if any TTTG entities are found</returns>
        public bool TryFindTTTGBySUBJ(string SUKEY, out IReadOnlyList<TTTG> Value)
        {
            return TTTG_SUBJForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }

        /// <summary>
        /// Find all TXAS (Actual Sessions) entities by [TXAS.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TXAS entities</param>
        /// <returns>A list of related TXAS entities</returns>
        public IReadOnlyList<TXAS> FindTXASBySUBJECT(string SUKEY)
        {
            IReadOnlyList<TXAS> result;
            if (TXAS_SUBJECTForeignIndex.Value.TryGetValue(SUKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TXAS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TXAS entities by [TXAS.SUBJECT]-&gt;[SU.SUKEY]
        /// </summary>
        /// <param name="SUKEY">SUKEY value used to find TXAS entities</param>
        /// <param name="Value">A list of related TXAS entities</param>
        /// <returns>True if any TXAS entities are found</returns>
        public bool TryFindTXASBySUBJECT(string SUKEY, out IReadOnlyList<TXAS> Value)
        {
            return TXAS_SUBJECTForeignIndex.Value.TryGetValue(SUKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SU" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SU" /> fields for each CSV column header</returns>
        protected override Action<SU, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SU, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SUKEY":
                        mapper[i] = (e, v) => e.SUKEY = v;
                        break;
                    case "FULLNAME":
                        mapper[i] = (e, v) => e.FULLNAME = v;
                        break;
                    case "SHORTNAME":
                        mapper[i] = (e, v) => e.SHORTNAME = v;
                        break;
                    case "FACULTY":
                        mapper[i] = (e, v) => e.FACULTY = v;
                        break;
                    case "PROMOTE":
                        mapper[i] = (e, v) => e.PROMOTE = v;
                        break;
                    case "OVERVIEW":
                        mapper[i] = (e, v) => e.OVERVIEW = v;
                        break;
                    case "PRIORITY":
                        mapper[i] = (e, v) => e.PRIORITY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SUBJECT_ACADEMIC_YEAR":
                        mapper[i] = (e, v) => e.SUBJECT_ACADEMIC_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DURATION":
                        mapper[i] = (e, v) => e.DURATION = v;
                        break;
                    case "SUBJECT_TYPE":
                        mapper[i] = (e, v) => e.SUBJECT_TYPE = v;
                        break;
                    case "PRINT_SEQ_NO":
                        mapper[i] = (e, v) => e.PRINT_SEQ_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ELECTIVE":
                        mapper[i] = (e, v) => e.ELECTIVE = v;
                        break;
                    case "VCAA_ID":
                        mapper[i] = (e, v) => e.VCAA_ID = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
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
