using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Students Data Set
    /// </summary>
    public sealed partial class STDataSet : SetBase<ST>
    {
        private Lazy<Dictionary<string, ST>> STKEYIndex;
        private Lazy<Dictionary<int, ST>> REGISTRATIONIndex;
        private Lazy<Dictionary<string, ST>> TAGIndex;

        private Lazy<Dictionary<string, IReadOnlyList<BKHR>>> BKHR_STUDENTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_TRSTUDForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<DFF>>> DFF_STUDENTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SDP>>> SDP_STUDENT_KEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SMC>>> SMC_STUDENTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SSHG>>> SSHG_STUDENTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_STBTKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STMA>>> STMA_SKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STMB>>> STMB_SKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STPO>>> STPO_STPOKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STPT>>> STPT_STPTKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRA>>> STRA_STKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_SKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STSB>>> STSB_SKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STSP>>> STSP_SPKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STTRIPS>>> STTRIPS_STUDENT_IDForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STVDI>>> STVDI_SKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STVDO>>> STVDO_SKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SXAB>>> SXAB_STKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SXABCONV>>> SXABCONV_STKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SXAS>>> SXAS_STKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SXHI>>> SXHI_SKEYForeignIndex;

        internal STDataSet(EduHubContext Context)
            : base(Context)
        {
            STKEYIndex = new Lazy<Dictionary<string, ST>>(() => this.ToDictionary(e => e.STKEY));
            REGISTRATIONIndex = new Lazy<Dictionary<int, ST>>(() => this.ToDictionary(e => e.REGISTRATION));
            TAGIndex = new Lazy<Dictionary<string, ST>>(() => this.ToDictionary(e => e.TAG));

            BKHR_STUDENTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<BKHR>>>(() =>
                    Context.BKHR
                          .Where(e => e.STUDENT != null)
                          .GroupBy(e => e.STUDENT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<BKHR>)g.ToList()
                          .AsReadOnly()));

            DFF_TRSTUDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.TRSTUD != null)
                          .GroupBy(e => e.TRSTUD)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            DFF_STUDENTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<DFF>>>(() =>
                    Context.DFF
                          .Where(e => e.STUDENT != null)
                          .GroupBy(e => e.STUDENT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<DFF>)g.ToList()
                          .AsReadOnly()));

            SDP_STUDENT_KEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SDP>>>(() =>
                    Context.SDP
                          .Where(e => e.STUDENT_KEY != null)
                          .GroupBy(e => e.STUDENT_KEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SDP>)g.ToList()
                          .AsReadOnly()));

            SMC_STUDENTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SMC>>>(() =>
                    Context.SMC
                          .Where(e => e.STUDENT != null)
                          .GroupBy(e => e.STUDENT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMC>)g.ToList()
                          .AsReadOnly()));

            SSHG_STUDENTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SSHG>>>(() =>
                    Context.SSHG
                          .Where(e => e.STUDENT != null)
                          .GroupBy(e => e.STUDENT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SSHG>)g.ToList()
                          .AsReadOnly()));

            STBT_STBTKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.STBTKEY != null)
                          .GroupBy(e => e.STBTKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STMA_SKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STMA>>>(() =>
                    Context.STMA
                          .Where(e => e.SKEY != null)
                          .GroupBy(e => e.SKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STMA>)g.ToList()
                          .AsReadOnly()));

            STMB_SKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STMB>>>(() =>
                    Context.STMB
                          .Where(e => e.SKEY != null)
                          .GroupBy(e => e.SKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STMB>)g.ToList()
                          .AsReadOnly()));

            STPO_STPOKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STPO>>>(() =>
                    Context.STPO
                          .Where(e => e.STPOKEY != null)
                          .GroupBy(e => e.STPOKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STPO>)g.ToList()
                          .AsReadOnly()));

            STPT_STPTKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STPT>>>(() =>
                    Context.STPT
                          .Where(e => e.STPTKEY != null)
                          .GroupBy(e => e.STPTKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STPT>)g.ToList()
                          .AsReadOnly()));

            STRA_STKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRA>>>(() =>
                    Context.STRA
                          .Where(e => e.STKEY != null)
                          .GroupBy(e => e.STKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRA>)g.ToList()
                          .AsReadOnly()));

            STRE_SKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.SKEY != null)
                          .GroupBy(e => e.SKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STSB_SKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STSB>>>(() =>
                    Context.STSB
                          .Where(e => e.SKEY != null)
                          .GroupBy(e => e.SKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STSB>)g.ToList()
                          .AsReadOnly()));

            STSP_SPKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STSP>>>(() =>
                    Context.STSP
                          .Where(e => e.SPKEY != null)
                          .GroupBy(e => e.SPKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STSP>)g.ToList()
                          .AsReadOnly()));

            STTRIPS_STUDENT_IDForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STTRIPS>>>(() =>
                    Context.STTRIPS
                          .Where(e => e.STUDENT_ID != null)
                          .GroupBy(e => e.STUDENT_ID)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STTRIPS>)g.ToList()
                          .AsReadOnly()));

            STVDI_SKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STVDI>>>(() =>
                    Context.STVDI
                          .Where(e => e.SKEY != null)
                          .GroupBy(e => e.SKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDI>)g.ToList()
                          .AsReadOnly()));

            STVDO_SKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STVDO>>>(() =>
                    Context.STVDO
                          .Where(e => e.SKEY != null)
                          .GroupBy(e => e.SKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDO>)g.ToList()
                          .AsReadOnly()));

            SXAB_STKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SXAB>>>(() =>
                    Context.SXAB
                          .Where(e => e.STKEY != null)
                          .GroupBy(e => e.STKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAB>)g.ToList()
                          .AsReadOnly()));

            SXABCONV_STKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SXABCONV>>>(() =>
                    Context.SXABCONV
                          .Where(e => e.STKEY != null)
                          .GroupBy(e => e.STKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXABCONV>)g.ToList()
                          .AsReadOnly()));

            SXAS_STKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SXAS>>>(() =>
                    Context.SXAS
                          .Where(e => e.STKEY != null)
                          .GroupBy(e => e.STKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAS>)g.ToList()
                          .AsReadOnly()));

            SXHI_SKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SXHI>>>(() =>
                    Context.SXHI
                          .Where(e => e.SKEY != null)
                          .GroupBy(e => e.SKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXHI>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "ST"; } }

        /// <summary>
        /// Find ST by STKEY key field
        /// </summary>
        /// <param name="Key">STKEY value used to find ST</param>
        /// <returns>Related ST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">STKEY value didn't match any ST entities</exception>
        public ST FindBySTKEY(string Key)
        {
            ST result;
            if (STKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find ST by STKEY key field
        /// </summary>
        /// <param name="Key">STKEY value used to find ST</param>
        /// <param name="Value">Related ST entity</param>
        /// <returns>True if the ST entity is found</returns>
        public bool TryFindBySTKEY(string Key, out ST Value)
        {
            return STKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find ST by STKEY key field
        /// </summary>
        /// <param name="Key">STKEY value used to find ST</param>
        /// <returns>Related ST entity, or null if not found</returns>
        public ST TryFindBySTKEY(string Key)
        {
            ST result;
            if (STKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by REGISTRATION key field
        /// </summary>
        /// <param name="Key">REGISTRATION value used to find ST</param>
        /// <returns>Related ST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">REGISTRATION value didn't match any ST entities</exception>
        public ST FindByREGISTRATION(int Key)
        {
            ST result;
            if (REGISTRATIONIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find ST by REGISTRATION key field
        /// </summary>
        /// <param name="Key">REGISTRATION value used to find ST</param>
        /// <param name="Value">Related ST entity</param>
        /// <returns>True if the ST entity is found</returns>
        public bool TryFindByREGISTRATION(int Key, out ST Value)
        {
            return REGISTRATIONIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find ST by REGISTRATION key field
        /// </summary>
        /// <param name="Key">REGISTRATION value used to find ST</param>
        /// <returns>Related ST entity, or null if not found</returns>
        public ST TryFindByREGISTRATION(int Key)
        {
            ST result;
            if (REGISTRATIONIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find ST by TAG key field
        /// </summary>
        /// <param name="Key">TAG value used to find ST</param>
        /// <returns>Related ST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TAG value didn't match any ST entities</exception>
        public ST FindByTAG(string Key)
        {
            ST result;
            if (TAGIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find ST by TAG key field
        /// </summary>
        /// <param name="Key">TAG value used to find ST</param>
        /// <param name="Value">Related ST entity</param>
        /// <returns>True if the ST entity is found</returns>
        public bool TryFindByTAG(string Key, out ST Value)
        {
            return TAGIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find ST by TAG key field
        /// </summary>
        /// <param name="Key">TAG value used to find ST</param>
        /// <returns>Related ST entity, or null if not found</returns>
        public ST TryFindByTAG(string Key)
        {
            ST result;
            if (TAGIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all BKHR (Book Hire Records) entities by [BKHR.STUDENT]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find BKHR entities</param>
        /// <returns>A list of related BKHR entities</returns>
        public IReadOnlyList<BKHR> FindBKHRBySTUDENT(string STKEY)
        {
            IReadOnlyList<BKHR> result;
            if (BKHR_STUDENTForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<BKHR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all BKHR entities by [BKHR.STUDENT]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find BKHR entities</param>
        /// <param name="Value">A list of related BKHR entities</param>
        /// <returns>True if any BKHR entities are found</returns>
        public bool TryFindBKHRBySTUDENT(string STKEY, out IReadOnlyList<BKHR> Value)
        {
            return BKHR_STUDENTForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.TRSTUD]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFByTRSTUD(string STKEY)
        {
            IReadOnlyList<DFF> result;
            if (DFF_TRSTUDForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.TRSTUD]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFByTRSTUD(string STKEY, out IReadOnlyList<DFF> Value)
        {
            return DFF_TRSTUDForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all DFF (Family Financial Transactions) entities by [DFF.STUDENT]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find DFF entities</param>
        /// <returns>A list of related DFF entities</returns>
        public IReadOnlyList<DFF> FindDFFBySTUDENT(string STKEY)
        {
            IReadOnlyList<DFF> result;
            if (DFF_STUDENTForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<DFF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all DFF entities by [DFF.STUDENT]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find DFF entities</param>
        /// <param name="Value">A list of related DFF entities</param>
        /// <returns>True if any DFF entities are found</returns>
        public bool TryFindDFFBySTUDENT(string STKEY, out IReadOnlyList<DFF> Value)
        {
            return DFF_STUDENTForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all SDP (Incident Instigators) entities by [SDP.STUDENT_KEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SDP entities</param>
        /// <returns>A list of related SDP entities</returns>
        public IReadOnlyList<SDP> FindSDPBySTUDENT_KEY(string STKEY)
        {
            IReadOnlyList<SDP> result;
            if (SDP_STUDENT_KEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SDP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SDP entities by [SDP.STUDENT_KEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SDP entities</param>
        /// <param name="Value">A list of related SDP entities</param>
        /// <returns>True if any SDP entities are found</returns>
        public bool TryFindSDPBySTUDENT_KEY(string STKEY, out IReadOnlyList<SDP> Value)
        {
            return SDP_STUDENT_KEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all SMC (Student Medical Conditions) entities by [SMC.STUDENT]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SMC entities</param>
        /// <returns>A list of related SMC entities</returns>
        public IReadOnlyList<SMC> FindSMCBySTUDENT(string STKEY)
        {
            IReadOnlyList<SMC> result;
            if (SMC_STUDENTForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SMC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMC entities by [SMC.STUDENT]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SMC entities</param>
        /// <param name="Value">A list of related SMC entities</param>
        /// <returns>True if any SMC entities are found</returns>
        public bool TryFindSMCBySTUDENT(string STKEY, out IReadOnlyList<SMC> Value)
        {
            return SMC_STUDENTForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all SSHG (Specialist Subjects per Home Group) entities by [SSHG.STUDENT]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SSHG entities</param>
        /// <returns>A list of related SSHG entities</returns>
        public IReadOnlyList<SSHG> FindSSHGBySTUDENT(string STKEY)
        {
            IReadOnlyList<SSHG> result;
            if (SSHG_STUDENTForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SSHG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SSHG entities by [SSHG.STUDENT]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SSHG entities</param>
        /// <param name="Value">A list of related SSHG entities</param>
        /// <returns>True if any SSHG entities are found</returns>
        public bool TryFindSSHGBySTUDENT(string STKEY, out IReadOnlyList<SSHG> Value)
        {
            return SSHG_STUDENTForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.STBTKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTBySTBTKEY(string STKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_STBTKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.STBTKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTBySTBTKEY(string STKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_STBTKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STMA (Subject Selections &amp; Marks) entities by [STMA.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STMA entities</param>
        /// <returns>A list of related STMA entities</returns>
        public IReadOnlyList<STMA> FindSTMABySKEY(string STKEY)
        {
            IReadOnlyList<STMA> result;
            if (STMA_SKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STMA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STMA entities by [STMA.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STMA entities</param>
        /// <param name="Value">A list of related STMA entities</param>
        /// <returns>True if any STMA entities are found</returns>
        public bool TryFindSTMABySKEY(string STKEY, out IReadOnlyList<STMA> Value)
        {
            return STMA_SKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STMB (Student Merit Behaviour Details) entities by [STMB.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STMB entities</param>
        /// <returns>A list of related STMB entities</returns>
        public IReadOnlyList<STMB> FindSTMBBySKEY(string STKEY)
        {
            IReadOnlyList<STMB> result;
            if (STMB_SKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STMB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STMB entities by [STMB.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STMB entities</param>
        /// <param name="Value">A list of related STMB entities</param>
        /// <returns>True if any STMB entities are found</returns>
        public bool TryFindSTMBBySKEY(string STKEY, out IReadOnlyList<STMB> Value)
        {
            return STMB_SKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STPO (Position or Group Memberships) entities by [STPO.STPOKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STPO entities</param>
        /// <returns>A list of related STPO entities</returns>
        public IReadOnlyList<STPO> FindSTPOBySTPOKEY(string STKEY)
        {
            IReadOnlyList<STPO> result;
            if (STPO_STPOKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STPO>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STPO entities by [STPO.STPOKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STPO entities</param>
        /// <param name="Value">A list of related STPO entities</param>
        /// <returns>True if any STPO entities are found</returns>
        public bool TryFindSTPOBySTPOKEY(string STKEY, out IReadOnlyList<STPO> Value)
        {
            return STPO_STPOKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STPT (Student Part-Time Enrolments) entities by [STPT.STPTKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STPT entities</param>
        /// <returns>A list of related STPT entities</returns>
        public IReadOnlyList<STPT> FindSTPTBySTPTKEY(string STKEY)
        {
            IReadOnlyList<STPT> result;
            if (STPT_STPTKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STPT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STPT entities by [STPT.STPTKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STPT entities</param>
        /// <param name="Value">A list of related STPT entities</param>
        /// <returns>True if any STPT entities are found</returns>
        public bool TryFindSTPTBySTPTKEY(string STKEY, out IReadOnlyList<STPT> Value)
        {
            return STPT_STPTKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STRA (Multiple Day Absences) entities by [STRA.STKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA entities</param>
        /// <returns>A list of related STRA entities</returns>
        public IReadOnlyList<STRA> FindSTRABySTKEY(string STKEY)
        {
            IReadOnlyList<STRA> result;
            if (STRA_STKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRA entities by [STRA.STKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA entities</param>
        /// <param name="Value">A list of related STRA entities</param>
        /// <returns>True if any STRA entities are found</returns>
        public bool TryFindSTRABySTKEY(string STKEY, out IReadOnlyList<STRA> Value)
        {
            return STRA_STKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREBySKEY(string STKEY)
        {
            IReadOnlyList<STRE> result;
            if (STRE_SKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREBySKEY(string STKEY, out IReadOnlyList<STRE> Value)
        {
            return STRE_SKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STSB (Family Invoice Allocations) entities by [STSB.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STSB entities</param>
        /// <returns>A list of related STSB entities</returns>
        public IReadOnlyList<STSB> FindSTSBBySKEY(string STKEY)
        {
            IReadOnlyList<STSB> result;
            if (STSB_SKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STSB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STSB entities by [STSB.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STSB entities</param>
        /// <param name="Value">A list of related STSB entities</param>
        /// <returns>True if any STSB entities are found</returns>
        public bool TryFindSTSBBySKEY(string STKEY, out IReadOnlyList<STSB> Value)
        {
            return STSB_SKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STSP (Suspension Details) entities by [STSP.SPKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STSP entities</param>
        /// <returns>A list of related STSP entities</returns>
        public IReadOnlyList<STSP> FindSTSPBySPKEY(string STKEY)
        {
            IReadOnlyList<STSP> result;
            if (STSP_SPKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STSP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STSP entities by [STSP.SPKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STSP entities</param>
        /// <param name="Value">A list of related STSP entities</param>
        /// <returns>True if any STSP entities are found</returns>
        public bool TryFindSTSPBySPKEY(string STKEY, out IReadOnlyList<STSP> Value)
        {
            return STSP_SPKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STTRIPS (Student Trips) entities by [STTRIPS.STUDENT_ID]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STTRIPS entities</param>
        /// <returns>A list of related STTRIPS entities</returns>
        public IReadOnlyList<STTRIPS> FindSTTRIPSBySTUDENT_ID(string STKEY)
        {
            IReadOnlyList<STTRIPS> result;
            if (STTRIPS_STUDENT_IDForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STTRIPS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STTRIPS entities by [STTRIPS.STUDENT_ID]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STTRIPS entities</param>
        /// <param name="Value">A list of related STTRIPS entities</param>
        /// <returns>True if any STTRIPS entities are found</returns>
        public bool TryFindSTTRIPSBySTUDENT_ID(string STKEY, out IReadOnlyList<STTRIPS> Value)
        {
            return STTRIPS_STUDENT_IDForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STVDI (VELS Dimension Results) entities by [STVDI.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STVDI entities</param>
        /// <returns>A list of related STVDI entities</returns>
        public IReadOnlyList<STVDI> FindSTVDIBySKEY(string STKEY)
        {
            IReadOnlyList<STVDI> result;
            if (STVDI_SKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDI entities by [STVDI.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STVDI entities</param>
        /// <param name="Value">A list of related STVDI entities</param>
        /// <returns>True if any STVDI entities are found</returns>
        public bool TryFindSTVDIBySKEY(string STKEY, out IReadOnlyList<STVDI> Value)
        {
            return STVDI_SKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all STVDO (VELS Domain Results) entities by [STVDO.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STVDO entities</param>
        /// <returns>A list of related STVDO entities</returns>
        public IReadOnlyList<STVDO> FindSTVDOBySKEY(string STKEY)
        {
            IReadOnlyList<STVDO> result;
            if (STVDO_SKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDO>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDO entities by [STVDO.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STVDO entities</param>
        /// <param name="Value">A list of related STVDO entities</param>
        /// <returns>True if any STVDO entities are found</returns>
        public bool TryFindSTVDOBySKEY(string STKEY, out IReadOnlyList<STVDO> Value)
        {
            return STVDO_SKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all SXAB (Student Half-Day Absences) entities by [SXAB.STKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAB entities</param>
        /// <returns>A list of related SXAB entities</returns>
        public IReadOnlyList<SXAB> FindSXABBySTKEY(string STKEY)
        {
            IReadOnlyList<SXAB> result;
            if (SXAB_STKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAB entities by [SXAB.STKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAB entities</param>
        /// <param name="Value">A list of related SXAB entities</param>
        /// <returns>True if any SXAB entities are found</returns>
        public bool TryFindSXABBySTKEY(string STKEY, out IReadOnlyList<SXAB> Value)
        {
            return SXAB_STKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all SXABCONV (Converted Student Half-Day Absences) entities by [SXABCONV.STKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV entities</param>
        /// <returns>A list of related SXABCONV entities</returns>
        public IReadOnlyList<SXABCONV> FindSXABCONVBySTKEY(string STKEY)
        {
            IReadOnlyList<SXABCONV> result;
            if (SXABCONV_STKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXABCONV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXABCONV entities by [SXABCONV.STKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXABCONV entities</param>
        /// <param name="Value">A list of related SXABCONV entities</param>
        /// <returns>True if any SXABCONV entities are found</returns>
        public bool TryFindSXABCONVBySTKEY(string STKEY, out IReadOnlyList<SXABCONV> Value)
        {
            return SXABCONV_STKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all SXAS (Student Scheduled Sessions) entities by [SXAS.STKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAS entities</param>
        /// <returns>A list of related SXAS entities</returns>
        public IReadOnlyList<SXAS> FindSXASBySTKEY(string STKEY)
        {
            IReadOnlyList<SXAS> result;
            if (SXAS_STKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAS entities by [SXAS.STKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXAS entities</param>
        /// <param name="Value">A list of related SXAS entities</param>
        /// <returns>True if any SXAS entities are found</returns>
        public bool TryFindSXASBySTKEY(string STKEY, out IReadOnlyList<SXAS> Value)
        {
            return SXAS_STKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Find all SXHI (Student History) entities by [SXHI.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXHI entities</param>
        /// <returns>A list of related SXHI entities</returns>
        public IReadOnlyList<SXHI> FindSXHIBySKEY(string STKEY)
        {
            IReadOnlyList<SXHI> result;
            if (SXHI_SKEYForeignIndex.Value.TryGetValue(STKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXHI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXHI entities by [SXHI.SKEY]-&gt;[ST.STKEY]
        /// </summary>
        /// <param name="STKEY">STKEY value used to find SXHI entities</param>
        /// <param name="Value">A list of related SXHI entities</param>
        /// <returns>True if any SXHI entities are found</returns>
        public bool TryFindSXHIBySKEY(string STKEY, out IReadOnlyList<SXHI> Value)
        {
            return SXHI_SKEYForeignIndex.Value.TryGetValue(STKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="ST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="ST" /> fields for each CSV column header</returns>
        protected override Action<ST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<ST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "PREF_NAME":
                        mapper[i] = (e, v) => e.PREF_NAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "FAMILY":
                        mapper[i] = (e, v) => e.FAMILY = v;
                        break;
                    case "ACADEMIC_A":
                        mapper[i] = (e, v) => e.ACADEMIC_A = v;
                        break;
                    case "LIVING_A":
                        mapper[i] = (e, v) => e.LIVING_A = v;
                        break;
                    case "RELATION_A01":
                        mapper[i] = (e, v) => e.RELATION_A01 = v;
                        break;
                    case "RELATION_A02":
                        mapper[i] = (e, v) => e.RELATION_A02 = v;
                        break;
                    case "CONTACT_A":
                        mapper[i] = (e, v) => e.CONTACT_A = v;
                        break;
                    case "FAMB":
                        mapper[i] = (e, v) => e.FAMB = v;
                        break;
                    case "ACADEMIC_B":
                        mapper[i] = (e, v) => e.ACADEMIC_B = v;
                        break;
                    case "LIVING_B":
                        mapper[i] = (e, v) => e.LIVING_B = v;
                        break;
                    case "RELATION_B01":
                        mapper[i] = (e, v) => e.RELATION_B01 = v;
                        break;
                    case "RELATION_B02":
                        mapper[i] = (e, v) => e.RELATION_B02 = v;
                        break;
                    case "CONTACT_B":
                        mapper[i] = (e, v) => e.CONTACT_B = v;
                        break;
                    case "FAMC":
                        mapper[i] = (e, v) => e.FAMC = v;
                        break;
                    case "ACADEMIC_C":
                        mapper[i] = (e, v) => e.ACADEMIC_C = v;
                        break;
                    case "LIVING_C":
                        mapper[i] = (e, v) => e.LIVING_C = v;
                        break;
                    case "RELATION_C01":
                        mapper[i] = (e, v) => e.RELATION_C01 = v;
                        break;
                    case "RELATION_C02":
                        mapper[i] = (e, v) => e.RELATION_C02 = v;
                        break;
                    case "CONTACT_C":
                        mapper[i] = (e, v) => e.CONTACT_C = v;
                        break;
                    case "LIVING_ARR":
                        mapper[i] = (e, v) => e.LIVING_ARR = v;
                        break;
                    case "DIST_SCHL":
                        mapper[i] = (e, v) => e.DIST_SCHL = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRANSPORT":
                        mapper[i] = (e, v) => e.TRANSPORT = v;
                        break;
                    case "CAR_REGO":
                        mapper[i] = (e, v) => e.CAR_REGO = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
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
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = int.Parse(v);
                        break;
                    case "FIRST_REG_NO":
                        mapper[i] = (e, v) => e.FIRST_REG_NO = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PROOF_DOB":
                        mapper[i] = (e, v) => e.PROOF_DOB = v;
                        break;
                    case "RESIDENT_STATUS":
                        mapper[i] = (e, v) => e.RESIDENT_STATUS = v;
                        break;
                    case "PERMANENT_BASIS":
                        mapper[i] = (e, v) => e.PERMANENT_BASIS = v;
                        break;
                    case "ENTRY":
                        mapper[i] = (e, v) => e.ENTRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXIT_DATE":
                        mapper[i] = (e, v) => e.EXIT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ARRIVAL":
                        mapper[i] = (e, v) => e.ARRIVAL = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "AUSSIE_SCHOOL":
                        mapper[i] = (e, v) => e.AUSSIE_SCHOOL = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "INTEGRATION":
                        mapper[i] = (e, v) => e.INTEGRATION = v;
                        break;
                    case "DATELEFT":
                        mapper[i] = (e, v) => e.DATELEFT = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXPIRY_DATE":
                        mapper[i] = (e, v) => e.EXPIRY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ID_CARD_VALID":
                        mapper[i] = (e, v) => e.ID_CARD_VALID = v;
                        break;
                    case "PREVIOUS_SCHOOL":
                        mapper[i] = (e, v) => e.PREVIOUS_SCHOOL = v;
                        break;
                    case "FAM_ORDER":
                        mapper[i] = (e, v) => e.FAM_ORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "ED_ALLOW":
                        mapper[i] = (e, v) => e.ED_ALLOW = v;
                        break;
                    case "EMA_AMT1P":
                        mapper[i] = (e, v) => e.EMA_AMT1P = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "EMA_AMT2P":
                        mapper[i] = (e, v) => e.EMA_AMT2P = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CASES_EMA_ID":
                        mapper[i] = (e, v) => e.CASES_EMA_ID = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "TAG":
                        mapper[i] = (e, v) => e.TAG = v;
                        break;
                    case "ENROLMENT_YEAR":
                        mapper[i] = (e, v) => e.ENROLMENT_YEAR = v;
                        break;
                    case "ADV_SCHL_YR":
                        mapper[i] = (e, v) => e.ADV_SCHL_YR = v;
                        break;
                    case "HOME_GROUP":
                        mapper[i] = (e, v) => e.HOME_GROUP = v;
                        break;
                    case "NEXT_HG":
                        mapper[i] = (e, v) => e.NEXT_HG = v;
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "HOUSE":
                        mapper[i] = (e, v) => e.HOUSE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LOCKER_NUM":
                        mapper[i] = (e, v) => e.LOCKER_NUM = v;
                        break;
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "REL_INSTR":
                        mapper[i] = (e, v) => e.REL_INSTR = v;
                        break;
                    case "VCE_ID":
                        mapper[i] = (e, v) => e.VCE_ID = v;
                        break;
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "VISA_STAT_CODE":
                        mapper[i] = (e, v) => e.VISA_STAT_CODE = v;
                        break;
                    case "VISA_EXPIRY":
                        mapper[i] = (e, v) => e.VISA_EXPIRY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "REPEAT":
                        mapper[i] = (e, v) => e.REPEAT = v;
                        break;
                    case "BIRTH_COUNTRY":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY = v;
                        break;
                    case "ENG_SPEAK":
                        mapper[i] = (e, v) => e.ENG_SPEAK = v;
                        break;
                    case "HOME_LANG":
                        mapper[i] = (e, v) => e.HOME_LANG = v;
                        break;
                    case "OVERSEAS":
                        mapper[i] = (e, v) => e.OVERSEAS = v;
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "YOUTH_ALLOW":
                        mapper[i] = (e, v) => e.YOUTH_ALLOW = v;
                        break;
                    case "AB_STUDY":
                        mapper[i] = (e, v) => e.AB_STUDY = v;
                        break;
                    case "ACCESS":
                        mapper[i] = (e, v) => e.ACCESS = v;
                        break;
                    case "ACCESS_TYPE":
                        mapper[i] = (e, v) => e.ACCESS_TYPE = v;
                        break;
                    case "ACCESS_ALERT":
                        mapper[i] = (e, v) => e.ACCESS_ALERT = v;
                        break;
                    case "RISK_ALERT":
                        mapper[i] = (e, v) => e.RISK_ALERT = v;
                        break;
                    case "RISK_MEMO":
                        mapper[i] = (e, v) => e.RISK_MEMO = v;
                        break;
                    case "DOCTOR":
                        mapper[i] = (e, v) => e.DOCTOR = v;
                        break;
                    case "EMERG_NAME01":
                        mapper[i] = (e, v) => e.EMERG_NAME01 = v;
                        break;
                    case "EMERG_NAME02":
                        mapper[i] = (e, v) => e.EMERG_NAME02 = v;
                        break;
                    case "EMERG_LANG01":
                        mapper[i] = (e, v) => e.EMERG_LANG01 = v;
                        break;
                    case "EMERG_LANG02":
                        mapper[i] = (e, v) => e.EMERG_LANG02 = v;
                        break;
                    case "EMERG_RELATION01":
                        mapper[i] = (e, v) => e.EMERG_RELATION01 = v;
                        break;
                    case "EMERG_RELATION02":
                        mapper[i] = (e, v) => e.EMERG_RELATION02 = v;
                        break;
                    case "EMERG_CONTACT01":
                        mapper[i] = (e, v) => e.EMERG_CONTACT01 = v;
                        break;
                    case "EMERG_CONTACT02":
                        mapper[i] = (e, v) => e.EMERG_CONTACT02 = v;
                        break;
                    case "ACC_DECLARATION":
                        mapper[i] = (e, v) => e.ACC_DECLARATION = v;
                        break;
                    case "AMBULANCE_SUBSCRIBER":
                        mapper[i] = (e, v) => e.AMBULANCE_SUBSCRIBER = v;
                        break;
                    case "MEDICARE_NO":
                        mapper[i] = (e, v) => e.MEDICARE_NO = v;
                        break;
                    case "INTERNATIONAL_ST_ID":
                        mapper[i] = (e, v) => e.INTERNATIONAL_ST_ID = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "DISABILITY_ID":
                        mapper[i] = (e, v) => e.DISABILITY_ID = v;
                        break;
                    case "PSDREQ":
                        mapper[i] = (e, v) => e.PSDREQ = v;
                        break;
                    case "HEARING_IMPAIR":
                        mapper[i] = (e, v) => e.HEARING_IMPAIR = v;
                        break;
                    case "VISUAL_IMPAIR":
                        mapper[i] = (e, v) => e.VISUAL_IMPAIR = v;
                        break;
                    case "SPEECH_IMPAIR":
                        mapper[i] = (e, v) => e.SPEECH_IMPAIR = v;
                        break;
                    case "PHYSICAL_IMPAIR":
                        mapper[i] = (e, v) => e.PHYSICAL_IMPAIR = v;
                        break;
                    case "MEDICAL_ALERT":
                        mapper[i] = (e, v) => e.MEDICAL_ALERT = v;
                        break;
                    case "MEDICAL_CONDITION":
                        mapper[i] = (e, v) => e.MEDICAL_CONDITION = v;
                        break;
                    case "ACTIVITY_RESTRICTION":
                        mapper[i] = (e, v) => e.ACTIVITY_RESTRICTION = v;
                        break;
                    case "IMMUNISE_CERT_STATUS":
                        mapper[i] = (e, v) => e.IMMUNISE_CERT_STATUS = v;
                        break;
                    case "IMMUN_CERT_SIGHTED":
                        mapper[i] = (e, v) => e.IMMUN_CERT_SIGHTED = v;
                        break;
                    case "IMMUNISE_PERMISSION":
                        mapper[i] = (e, v) => e.IMMUNISE_PERMISSION = v;
                        break;
                    case "IMMUNIZE":
                        mapper[i] = (e, v) => e.IMMUNIZE = v;
                        break;
                    case "DISABILITY_ADJUSTMENT_ASSESSED":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT_ASSESSED = v;
                        break;
                    case "DISABILITY_ADJUSTMENT":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT = v;
                        break;
                    case "DISABILITY_TYPE":
                        mapper[i] = (e, v) => e.DISABILITY_TYPE = v;
                        break;
                    case "DISABILITY_ADJUSTMENT_LEVEL":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT_LEVEL = v;
                        break;
                    case "DISABILITY_ADJUSTMENT_LW_DATE":
                        mapper[i] = (e, v) => e.DISABILITY_ADJUSTMENT_LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HEAD_LICE_CHECK":
                        mapper[i] = (e, v) => e.HEAD_LICE_CHECK = v;
                        break;
                    case "ANNUAL_TOT":
                        mapper[i] = (e, v) => e.ANNUAL_TOT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STUDENT_PIC":
                        mapper[i] = (e, v) => e.STUDENT_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "PUBLISH_PHOTO_MEDIA":
                        mapper[i] = (e, v) => e.PUBLISH_PHOTO_MEDIA = v;
                        break;
                    case "OK_TO_PUBLISH":
                        mapper[i] = (e, v) => e.OK_TO_PUBLISH = v;
                        break;
                    case "PIC_LW_DATE":
                        mapper[i] = (e, v) => e.PIC_LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PIC_STATUS":
                        mapper[i] = (e, v) => e.PIC_STATUS = v;
                        break;
                    case "LIBRARY_FLAG":
                        mapper[i] = (e, v) => e.LIBRARY_FLAG = v;
                        break;
                    case "REGISTRAR_FLAG":
                        mapper[i] = (e, v) => e.REGISTRAR_FLAG = v;
                        break;
                    case "CLEAR1_FLAG":
                        mapper[i] = (e, v) => e.CLEAR1_FLAG = v;
                        break;
                    case "CLEAR2_FLAG":
                        mapper[i] = (e, v) => e.CLEAR2_FLAG = v;
                        break;
                    case "CLEAR3_FLAG":
                        mapper[i] = (e, v) => e.CLEAR3_FLAG = v;
                        break;
                    case "CLEAR4_FLAG":
                        mapper[i] = (e, v) => e.CLEAR4_FLAG = v;
                        break;
                    case "CLEAR5_FLAG":
                        mapper[i] = (e, v) => e.CLEAR5_FLAG = v;
                        break;
                    case "CLEAR6_FLAG":
                        mapper[i] = (e, v) => e.CLEAR6_FLAG = v;
                        break;
                    case "AR_STATUS":
                        mapper[i] = (e, v) => e.AR_STATUS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "YEARS_PREVIOUS_EDUCATION":
                        mapper[i] = (e, v) => e.YEARS_PREVIOUS_EDUCATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "YEARS_INTERRUPTION_EDUCATION":
                        mapper[i] = (e, v) => e.YEARS_INTERRUPTION_EDUCATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LANGUAGE_PREVIOUS_SCHOOLING":
                        mapper[i] = (e, v) => e.LANGUAGE_PREVIOUS_SCHOOLING = v;
                        break;
                    case "NEXT_SCHOOL":
                        mapper[i] = (e, v) => e.NEXT_SCHOOL = v;
                        break;
                    case "EXIT_CAT01":
                        mapper[i] = (e, v) => e.EXIT_CAT01 = v;
                        break;
                    case "EXIT_CAT02":
                        mapper[i] = (e, v) => e.EXIT_CAT02 = v;
                        break;
                    case "EXIT_DEST01":
                        mapper[i] = (e, v) => e.EXIT_DEST01 = v;
                        break;
                    case "EXIT_DEST02":
                        mapper[i] = (e, v) => e.EXIT_DEST02 = v;
                        break;
                    case "EXIT_MODIFY_DATE01":
                        mapper[i] = (e, v) => e.EXIT_MODIFY_DATE01 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXIT_MODIFY_DATE02":
                        mapper[i] = (e, v) => e.EXIT_MODIFY_DATE02 = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FULLTIME":
                        mapper[i] = (e, v) => e.FULLTIME = v;
                        break;
                    case "SGB_TIME_FRACTION":
                        mapper[i] = (e, v) => e.SGB_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "ACTUAL_TIME_FRACTION":
                        mapper[i] = (e, v) => e.ACTUAL_TIME_FRACTION = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DEST_ARRIVAL_DATE":
                        mapper[i] = (e, v) => e.DEST_ARRIVAL_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DEPARTURE_DATE":
                        mapper[i] = (e, v) => e.DEPARTURE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ARRIVED_DESTINATION":
                        mapper[i] = (e, v) => e.ARRIVED_DESTINATION = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NOTIFIED_DESTINATION":
                        mapper[i] = (e, v) => e.NOTIFIED_DESTINATION = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "VCE_NOTIFIED":
                        mapper[i] = (e, v) => e.VCE_NOTIFIED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXIT_FORM":
                        mapper[i] = (e, v) => e.EXIT_FORM = v;
                        break;
                    case "TRANSFER_FORM":
                        mapper[i] = (e, v) => e.TRANSFER_FORM = v;
                        break;
                    case "PARENTAL_APPROVAL_DATE":
                        mapper[i] = (e, v) => e.PARENTAL_APPROVAL_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PARENTAL_APPROVAL_NOTE":
                        mapper[i] = (e, v) => e.PARENTAL_APPROVAL_NOTE = v;
                        break;
                    case "DISASTER_EXIT_REASON":
                        mapper[i] = (e, v) => e.DISASTER_EXIT_REASON = v;
                        break;
                    case "ATTENDANCE_MEMO":
                        mapper[i] = (e, v) => e.ATTENDANCE_MEMO = v;
                        break;
                    case "ABS_HDAY_PERIOD":
                        mapper[i] = (e, v) => e.ABS_HDAY_PERIOD = v;
                        break;
                    case "STRE_FLAG":
                        mapper[i] = (e, v) => e.STRE_FLAG = v;
                        break;
                    case "PROMOTED":
                        mapper[i] = (e, v) => e.PROMOTED = v;
                        break;
                    case "INAC_ABS_CODE":
                        mapper[i] = (e, v) => e.INAC_ABS_CODE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LOTE_HOME_CODE":
                        mapper[i] = (e, v) => e.LOTE_HOME_CODE = v;
                        break;
                    case "VSN":
                        mapper[i] = (e, v) => e.VSN = v;
                        break;
                    case "SPEC_CURR":
                        mapper[i] = (e, v) => e.SPEC_CURR = v;
                        break;
                    case "TRANSITION_STATEMENT":
                        mapper[i] = (e, v) => e.TRANSITION_STATEMENT = v;
                        break;
                    case "TFR_PERMISSION":
                        mapper[i] = (e, v) => e.TFR_PERMISSION = v;
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
