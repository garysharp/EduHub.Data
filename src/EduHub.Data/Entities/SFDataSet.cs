using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Data Set
    /// </summary>
    public sealed partial class SFDataSet : SetBase<SF>
    {
        private Lazy<Dictionary<string, SF>> SFKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<AKK>>> AKK_STAFFForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<BKHR>>> BKHR_STAFFForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KCY>>> KCY_TEACHERForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KCY>>> KCY_TEACHER_BForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KGC>>> KGC_TEACHERForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KGC>>> KGC_TEACHER_BForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KSF>>> KSF_COORDINATORForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SAD>>> SAD_AREA_DUTY_TEACHERForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SAIM>>> SAIM_STAFFForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SCH_PRINCIPALForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SF_OICForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SF_VPRINForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SF_2VPRINForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SF_3VPRINForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SF_APRINForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SF_BMANAGERForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SF_VAC_CONTACTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SF_EMERG_CONTACTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SCH_AOICForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SCH_VPRINForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SCH_BMANAGERForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SCH_VAC_CONTACTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_SCH_EMERG_CONTACTForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCL>>> SCL_TEACHER01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCL>>> SCL_TEACHER02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SDPA>>> SDPA_TAKEN_BYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SFAQ>>> SFAQ_SFAQKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SFAV>>> SFAV_TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SFQA>>> SFQA_TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SM>>> SM_STAFF_CODEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SMCD>>> SMCD_STAFFForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SS>>> SS_DEFAULT_TEACHERForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SSHG>>> SSHG_TEACHERForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STSP>>> STSP_REF_TEACHERAForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STSP>>> STSP_REF_TEACHERBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTB>>> TCTB_TEACHERForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_T1TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_T2TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTQ>>> TCTQ_EXTRA_TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TCTR>>> TCTR_TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_T1TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_T2TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<THTQ>>> THTQ_EXTRA_TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTEF>>> TTEF_STAFFForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTTG>>> TTTG_T1TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TTTG>>> TTTG_T2TEACHForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TXAS>>> TXAS_TEACHERForeignIndex;

        internal SFDataSet(EduHubContext Context)
            : base(Context)
        {
            SFKEYIndex = new Lazy<Dictionary<string, SF>>(() => this.ToDictionary(e => e.SFKEY));

            AKK_STAFFForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<AKK>>>(() =>
                    Context.AKK
                          .Where(e => e.STAFF != null)
                          .GroupBy(e => e.STAFF)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<AKK>)g.ToList()
                          .AsReadOnly()));

            BKHR_STAFFForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<BKHR>>>(() =>
                    Context.BKHR
                          .Where(e => e.STAFF != null)
                          .GroupBy(e => e.STAFF)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<BKHR>)g.ToList()
                          .AsReadOnly()));

            KCY_TEACHERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KCY>>>(() =>
                    Context.KCY
                          .Where(e => e.TEACHER != null)
                          .GroupBy(e => e.TEACHER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KCY>)g.ToList()
                          .AsReadOnly()));

            KCY_TEACHER_BForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KCY>>>(() =>
                    Context.KCY
                          .Where(e => e.TEACHER_B != null)
                          .GroupBy(e => e.TEACHER_B)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KCY>)g.ToList()
                          .AsReadOnly()));

            KGC_TEACHERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGC>>>(() =>
                    Context.KGC
                          .Where(e => e.TEACHER != null)
                          .GroupBy(e => e.TEACHER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGC>)g.ToList()
                          .AsReadOnly()));

            KGC_TEACHER_BForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGC>>>(() =>
                    Context.KGC
                          .Where(e => e.TEACHER_B != null)
                          .GroupBy(e => e.TEACHER_B)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGC>)g.ToList()
                          .AsReadOnly()));

            KSF_COORDINATORForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KSF>>>(() =>
                    Context.KSF
                          .Where(e => e.COORDINATOR != null)
                          .GroupBy(e => e.COORDINATOR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KSF>)g.ToList()
                          .AsReadOnly()));

            SAD_AREA_DUTY_TEACHERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAD>>>(() =>
                    Context.SAD
                          .Where(e => e.AREA_DUTY_TEACHER != null)
                          .GroupBy(e => e.AREA_DUTY_TEACHER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAD>)g.ToList()
                          .AsReadOnly()));

            SAIM_STAFFForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SAIM>>>(() =>
                    Context.SAIM
                          .Where(e => e.STAFF != null)
                          .GroupBy(e => e.STAFF)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SAIM>)g.ToList()
                          .AsReadOnly()));

            SCI_SCH_PRINCIPALForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SCH_PRINCIPAL != null)
                          .GroupBy(e => e.SCH_PRINCIPAL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SF_OICForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SF_OIC != null)
                          .GroupBy(e => e.SF_OIC)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SF_VPRINForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SF_VPRIN != null)
                          .GroupBy(e => e.SF_VPRIN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SF_2VPRINForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SF_2VPRIN != null)
                          .GroupBy(e => e.SF_2VPRIN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SF_3VPRINForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SF_3VPRIN != null)
                          .GroupBy(e => e.SF_3VPRIN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SF_APRINForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SF_APRIN != null)
                          .GroupBy(e => e.SF_APRIN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SF_BMANAGERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SF_BMANAGER != null)
                          .GroupBy(e => e.SF_BMANAGER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SF_VAC_CONTACTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SF_VAC_CONTACT != null)
                          .GroupBy(e => e.SF_VAC_CONTACT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SF_EMERG_CONTACTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SF_EMERG_CONTACT != null)
                          .GroupBy(e => e.SF_EMERG_CONTACT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SCH_AOICForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SCH_AOIC != null)
                          .GroupBy(e => e.SCH_AOIC)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SCH_VPRINForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SCH_VPRIN != null)
                          .GroupBy(e => e.SCH_VPRIN)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SCH_BMANAGERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SCH_BMANAGER != null)
                          .GroupBy(e => e.SCH_BMANAGER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SCH_VAC_CONTACTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SCH_VAC_CONTACT != null)
                          .GroupBy(e => e.SCH_VAC_CONTACT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCI_SCH_EMERG_CONTACTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.SCH_EMERG_CONTACT != null)
                          .GroupBy(e => e.SCH_EMERG_CONTACT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            SCL_TEACHER01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCL>>>(() =>
                    Context.SCL
                          .Where(e => e.TEACHER01 != null)
                          .GroupBy(e => e.TEACHER01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCL>)g.ToList()
                          .AsReadOnly()));

            SCL_TEACHER02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCL>>>(() =>
                    Context.SCL
                          .Where(e => e.TEACHER02 != null)
                          .GroupBy(e => e.TEACHER02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCL>)g.ToList()
                          .AsReadOnly()));

            SDPA_TAKEN_BYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SDPA>>>(() =>
                    Context.SDPA
                          .Where(e => e.TAKEN_BY != null)
                          .GroupBy(e => e.TAKEN_BY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SDPA>)g.ToList()
                          .AsReadOnly()));

            SFAQ_SFAQKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SFAQ>>>(() =>
                    Context.SFAQ
                          .Where(e => e.SFAQKEY != null)
                          .GroupBy(e => e.SFAQKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SFAQ>)g.ToList()
                          .AsReadOnly()));

            SFAV_TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SFAV>>>(() =>
                    Context.SFAV
                          .Where(e => e.TEACH != null)
                          .GroupBy(e => e.TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SFAV>)g.ToList()
                          .AsReadOnly()));

            SFQA_TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SFQA>>>(() =>
                    Context.SFQA
                          .Where(e => e.TEACH != null)
                          .GroupBy(e => e.TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SFQA>)g.ToList()
                          .AsReadOnly()));

            SM_STAFF_CODEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SM>>>(() =>
                    Context.SM
                          .Where(e => e.STAFF_CODE != null)
                          .GroupBy(e => e.STAFF_CODE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SM>)g.ToList()
                          .AsReadOnly()));

            SMCD_STAFFForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SMCD>>>(() =>
                    Context.SMCD
                          .Where(e => e.STAFF != null)
                          .GroupBy(e => e.STAFF)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SMCD>)g.ToList()
                          .AsReadOnly()));

            SS_DEFAULT_TEACHERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SS>>>(() =>
                    Context.SS
                          .Where(e => e.DEFAULT_TEACHER != null)
                          .GroupBy(e => e.DEFAULT_TEACHER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SS>)g.ToList()
                          .AsReadOnly()));

            SSHG_TEACHERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SSHG>>>(() =>
                    Context.SSHG
                          .Where(e => e.TEACHER != null)
                          .GroupBy(e => e.TEACHER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SSHG>)g.ToList()
                          .AsReadOnly()));

            STSP_REF_TEACHERAForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STSP>>>(() =>
                    Context.STSP
                          .Where(e => e.REF_TEACHERA != null)
                          .GroupBy(e => e.REF_TEACHERA)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STSP>)g.ToList()
                          .AsReadOnly()));

            STSP_REF_TEACHERBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STSP>>>(() =>
                    Context.STSP
                          .Where(e => e.REF_TEACHERB != null)
                          .GroupBy(e => e.REF_TEACHERB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STSP>)g.ToList()
                          .AsReadOnly()));

            TCTB_TEACHERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTB>>>(() =>
                    Context.TCTB
                          .Where(e => e.TEACHER != null)
                          .GroupBy(e => e.TEACHER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTB>)g.ToList()
                          .AsReadOnly()));

            TCTQ_T1TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.T1TEACH != null)
                          .GroupBy(e => e.T1TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TCTQ_T2TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.T2TEACH != null)
                          .GroupBy(e => e.T2TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TCTQ_EXTRA_TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTQ>>>(() =>
                    Context.TCTQ
                          .Where(e => e.EXTRA_TEACH != null)
                          .GroupBy(e => e.EXTRA_TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTQ>)g.ToList()
                          .AsReadOnly()));

            TCTR_TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TCTR>>>(() =>
                    Context.TCTR
                          .Where(e => e.TEACH != null)
                          .GroupBy(e => e.TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TCTR>)g.ToList()
                          .AsReadOnly()));

            THTQ_T1TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.T1TEACH != null)
                          .GroupBy(e => e.T1TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

            THTQ_T2TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.T2TEACH != null)
                          .GroupBy(e => e.T2TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

            THTQ_EXTRA_TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<THTQ>>>(() =>
                    Context.THTQ
                          .Where(e => e.EXTRA_TEACH != null)
                          .GroupBy(e => e.EXTRA_TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<THTQ>)g.ToList()
                          .AsReadOnly()));

            TTEF_STAFFForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTEF>>>(() =>
                    Context.TTEF
                          .Where(e => e.STAFF != null)
                          .GroupBy(e => e.STAFF)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTEF>)g.ToList()
                          .AsReadOnly()));

            TTTG_T1TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTTG>>>(() =>
                    Context.TTTG
                          .Where(e => e.T1TEACH != null)
                          .GroupBy(e => e.T1TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTTG>)g.ToList()
                          .AsReadOnly()));

            TTTG_T2TEACHForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TTTG>>>(() =>
                    Context.TTTG
                          .Where(e => e.T2TEACH != null)
                          .GroupBy(e => e.T2TEACH)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TTTG>)g.ToList()
                          .AsReadOnly()));

            TXAS_TEACHERForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TXAS>>>(() =>
                    Context.TXAS
                          .Where(e => e.TEACHER != null)
                          .GroupBy(e => e.TEACHER)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TXAS>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SF"; } }

        /// <summary>
        /// Find SF by SFKEY key field
        /// </summary>
        /// <param name="Key">SFKEY value used to find SF</param>
        /// <returns>Related SF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SFKEY value didn't match any SF entities</exception>
        public SF FindBySFKEY(string Key)
        {
            SF result;
            if (SFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SF by SFKEY key field
        /// </summary>
        /// <param name="Key">SFKEY value used to find SF</param>
        /// <param name="Value">Related SF entity</param>
        /// <returns>True if the SF entity is found</returns>
        public bool TryFindBySFKEY(string Key, out SF Value)
        {
            return SFKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SF by SFKEY key field
        /// </summary>
        /// <param name="Key">SFKEY value used to find SF</param>
        /// <returns>Related SF entity, or null if not found</returns>
        public SF TryFindBySFKEY(string Key)
        {
            SF result;
            if (SFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all AKK (Asset Key Holders) entities by [AKK.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find AKK entities</param>
        /// <returns>A list of related AKK entities</returns>
        public IReadOnlyList<AKK> FindAKKBySTAFF(string SFKEY)
        {
            IReadOnlyList<AKK> result;
            if (AKK_STAFFForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<AKK>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all AKK entities by [AKK.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find AKK entities</param>
        /// <param name="Value">A list of related AKK entities</param>
        /// <returns>True if any AKK entities are found</returns>
        public bool TryFindAKKBySTAFF(string SFKEY, out IReadOnlyList<AKK> Value)
        {
            return AKK_STAFFForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all BKHR (Book Hire Records) entities by [BKHR.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find BKHR entities</param>
        /// <returns>A list of related BKHR entities</returns>
        public IReadOnlyList<BKHR> FindBKHRBySTAFF(string SFKEY)
        {
            IReadOnlyList<BKHR> result;
            if (BKHR_STAFFForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<BKHR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all BKHR entities by [BKHR.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find BKHR entities</param>
        /// <param name="Value">A list of related BKHR entities</param>
        /// <returns>True if any BKHR entities are found</returns>
        public bool TryFindBKHRBySTAFF(string SFKEY, out IReadOnlyList<BKHR> Value)
        {
            return BKHR_STAFFForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all KCY (Year Levels) entities by [KCY.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KCY entities</param>
        /// <returns>A list of related KCY entities</returns>
        public IReadOnlyList<KCY> FindKCYByTEACHER(string SFKEY)
        {
            IReadOnlyList<KCY> result;
            if (KCY_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KCY>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KCY entities by [KCY.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KCY entities</param>
        /// <param name="Value">A list of related KCY entities</param>
        /// <returns>True if any KCY entities are found</returns>
        public bool TryFindKCYByTEACHER(string SFKEY, out IReadOnlyList<KCY> Value)
        {
            return KCY_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all KCY (Year Levels) entities by [KCY.TEACHER_B]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KCY entities</param>
        /// <returns>A list of related KCY entities</returns>
        public IReadOnlyList<KCY> FindKCYByTEACHER_B(string SFKEY)
        {
            IReadOnlyList<KCY> result;
            if (KCY_TEACHER_BForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KCY>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KCY entities by [KCY.TEACHER_B]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KCY entities</param>
        /// <param name="Value">A list of related KCY entities</param>
        /// <returns>True if any KCY entities are found</returns>
        public bool TryFindKCYByTEACHER_B(string SFKEY, out IReadOnlyList<KCY> Value)
        {
            return KCY_TEACHER_BForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all KGC (Home Groups) entities by [KGC.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KGC entities</param>
        /// <returns>A list of related KGC entities</returns>
        public IReadOnlyList<KGC> FindKGCByTEACHER(string SFKEY)
        {
            IReadOnlyList<KGC> result;
            if (KGC_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KGC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGC entities by [KGC.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KGC entities</param>
        /// <param name="Value">A list of related KGC entities</param>
        /// <returns>True if any KGC entities are found</returns>
        public bool TryFindKGCByTEACHER(string SFKEY, out IReadOnlyList<KGC> Value)
        {
            return KGC_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all KGC (Home Groups) entities by [KGC.TEACHER_B]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KGC entities</param>
        /// <returns>A list of related KGC entities</returns>
        public IReadOnlyList<KGC> FindKGCByTEACHER_B(string SFKEY)
        {
            IReadOnlyList<KGC> result;
            if (KGC_TEACHER_BForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KGC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGC entities by [KGC.TEACHER_B]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KGC entities</param>
        /// <param name="Value">A list of related KGC entities</param>
        /// <returns>True if any KGC entities are found</returns>
        public bool TryFindKGCByTEACHER_B(string SFKEY, out IReadOnlyList<KGC> Value)
        {
            return KGC_TEACHER_BForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all KSF (Faculties) entities by [KSF.COORDINATOR]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KSF entities</param>
        /// <returns>A list of related KSF entities</returns>
        public IReadOnlyList<KSF> FindKSFByCOORDINATOR(string SFKEY)
        {
            IReadOnlyList<KSF> result;
            if (KSF_COORDINATORForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KSF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KSF entities by [KSF.COORDINATOR]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find KSF entities</param>
        /// <param name="Value">A list of related KSF entities</param>
        /// <returns>True if any KSF entities are found</returns>
        public bool TryFindKSFByCOORDINATOR(string SFKEY, out IReadOnlyList<KSF> Value)
        {
            return KSF_COORDINATORForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SAD (Accidents) entities by [SAD.AREA_DUTY_TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SAD entities</param>
        /// <returns>A list of related SAD entities</returns>
        public IReadOnlyList<SAD> FindSADByAREA_DUTY_TEACHER(string SFKEY)
        {
            IReadOnlyList<SAD> result;
            if (SAD_AREA_DUTY_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAD entities by [SAD.AREA_DUTY_TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SAD entities</param>
        /// <param name="Value">A list of related SAD entities</param>
        /// <returns>True if any SAD entities are found</returns>
        public bool TryFindSADByAREA_DUTY_TEACHER(string SFKEY, out IReadOnlyList<SAD> Value)
        {
            return SAD_AREA_DUTY_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SAIM (Sickbay Medication Administrations) entities by [SAIM.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SAIM entities</param>
        /// <returns>A list of related SAIM entities</returns>
        public IReadOnlyList<SAIM> FindSAIMBySTAFF(string SFKEY)
        {
            IReadOnlyList<SAIM> result;
            if (SAIM_STAFFForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SAIM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SAIM entities by [SAIM.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SAIM entities</param>
        /// <param name="Value">A list of related SAIM entities</param>
        /// <returns>True if any SAIM entities are found</returns>
        public bool TryFindSAIMBySTAFF(string SFKEY, out IReadOnlyList<SAIM> Value)
        {
            return SAIM_STAFFForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SCH_PRINCIPAL]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySCH_PRINCIPAL(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SCH_PRINCIPALForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SCH_PRINCIPAL]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySCH_PRINCIPAL(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SCH_PRINCIPALForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SF_OIC]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySF_OIC(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SF_OICForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SF_OIC]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySF_OIC(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SF_OICForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SF_VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySF_VPRIN(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SF_VPRINForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SF_VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySF_VPRIN(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SF_VPRINForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SF_2VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySF_2VPRIN(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SF_2VPRINForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SF_2VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySF_2VPRIN(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SF_2VPRINForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SF_3VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySF_3VPRIN(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SF_3VPRINForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SF_3VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySF_3VPRIN(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SF_3VPRINForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SF_APRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySF_APRIN(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SF_APRINForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SF_APRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySF_APRIN(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SF_APRINForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SF_BMANAGER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySF_BMANAGER(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SF_BMANAGERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SF_BMANAGER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySF_BMANAGER(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SF_BMANAGERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SF_VAC_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySF_VAC_CONTACT(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SF_VAC_CONTACTForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SF_VAC_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySF_VAC_CONTACT(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SF_VAC_CONTACTForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SF_EMERG_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySF_EMERG_CONTACT(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SF_EMERG_CONTACTForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SF_EMERG_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySF_EMERG_CONTACT(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SF_EMERG_CONTACTForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SCH_AOIC]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySCH_AOIC(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SCH_AOICForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SCH_AOIC]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySCH_AOIC(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SCH_AOICForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SCH_VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySCH_VPRIN(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SCH_VPRINForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SCH_VPRIN]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySCH_VPRIN(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SCH_VPRINForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SCH_BMANAGER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySCH_BMANAGER(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SCH_BMANAGERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SCH_BMANAGER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySCH_BMANAGER(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SCH_BMANAGERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SCH_VAC_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySCH_VAC_CONTACT(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SCH_VAC_CONTACTForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SCH_VAC_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySCH_VAC_CONTACT(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SCH_VAC_CONTACTForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCI (School Information) entities by [SCI.SCH_EMERG_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIBySCH_EMERG_CONTACT(string SFKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_SCH_EMERG_CONTACTForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.SCH_EMERG_CONTACT]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIBySCH_EMERG_CONTACT(string SFKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_SCH_EMERG_CONTACTForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCL (Subject Classes) entities by [SCL.TEACHER01]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCL entities</param>
        /// <returns>A list of related SCL entities</returns>
        public IReadOnlyList<SCL> FindSCLByTEACHER01(string SFKEY)
        {
            IReadOnlyList<SCL> result;
            if (SCL_TEACHER01ForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCL entities by [SCL.TEACHER01]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCL entities</param>
        /// <param name="Value">A list of related SCL entities</param>
        /// <returns>True if any SCL entities are found</returns>
        public bool TryFindSCLByTEACHER01(string SFKEY, out IReadOnlyList<SCL> Value)
        {
            return SCL_TEACHER01ForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SCL (Subject Classes) entities by [SCL.TEACHER02]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCL entities</param>
        /// <returns>A list of related SCL entities</returns>
        public IReadOnlyList<SCL> FindSCLByTEACHER02(string SFKEY)
        {
            IReadOnlyList<SCL> result;
            if (SCL_TEACHER02ForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCL entities by [SCL.TEACHER02]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SCL entities</param>
        /// <param name="Value">A list of related SCL entities</param>
        /// <returns>True if any SCL entities are found</returns>
        public bool TryFindSCLByTEACHER02(string SFKEY, out IReadOnlyList<SCL> Value)
        {
            return SCL_TEACHER02ForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SDPA (Disciplinary Actions) entities by [SDPA.TAKEN_BY]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SDPA entities</param>
        /// <returns>A list of related SDPA entities</returns>
        public IReadOnlyList<SDPA> FindSDPAByTAKEN_BY(string SFKEY)
        {
            IReadOnlyList<SDPA> result;
            if (SDPA_TAKEN_BYForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SDPA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SDPA entities by [SDPA.TAKEN_BY]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SDPA entities</param>
        /// <param name="Value">A list of related SDPA entities</param>
        /// <returns>True if any SDPA entities are found</returns>
        public bool TryFindSDPAByTAKEN_BY(string SFKEY, out IReadOnlyList<SDPA> Value)
        {
            return SDPA_TAKEN_BYForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SFAQ (Staff Availability in Quilt) entities by [SFAQ.SFAQKEY]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SFAQ entities</param>
        /// <returns>A list of related SFAQ entities</returns>
        public IReadOnlyList<SFAQ> FindSFAQBySFAQKEY(string SFKEY)
        {
            IReadOnlyList<SFAQ> result;
            if (SFAQ_SFAQKEYForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SFAQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SFAQ entities by [SFAQ.SFAQKEY]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SFAQ entities</param>
        /// <param name="Value">A list of related SFAQ entities</param>
        /// <returns>True if any SFAQ entities are found</returns>
        public bool TryFindSFAQBySFAQKEY(string SFKEY, out IReadOnlyList<SFAQ> Value)
        {
            return SFAQ_SFAQKEYForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SFAV (Staff Availability for Calendar Extras) entities by [SFAV.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SFAV entities</param>
        /// <returns>A list of related SFAV entities</returns>
        public IReadOnlyList<SFAV> FindSFAVByTEACH(string SFKEY)
        {
            IReadOnlyList<SFAV> result;
            if (SFAV_TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SFAV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SFAV entities by [SFAV.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SFAV entities</param>
        /// <param name="Value">A list of related SFAV entities</param>
        /// <returns>True if any SFAV entities are found</returns>
        public bool TryFindSFAVByTEACH(string SFKEY, out IReadOnlyList<SFAV> Value)
        {
            return SFAV_TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SFQA (Staff Qualifications) entities by [SFQA.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SFQA entities</param>
        /// <returns>A list of related SFQA entities</returns>
        public IReadOnlyList<SFQA> FindSFQAByTEACH(string SFKEY)
        {
            IReadOnlyList<SFQA> result;
            if (SFQA_TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SFQA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SFQA entities by [SFQA.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SFQA entities</param>
        /// <param name="Value">A list of related SFQA entities</param>
        /// <returns>True if any SFQA entities are found</returns>
        public bool TryFindSFQAByTEACH(string SFKEY, out IReadOnlyList<SFQA> Value)
        {
            return SFQA_TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SM (Rooms) entities by [SM.STAFF_CODE]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SM entities</param>
        /// <returns>A list of related SM entities</returns>
        public IReadOnlyList<SM> FindSMBySTAFF_CODE(string SFKEY)
        {
            IReadOnlyList<SM> result;
            if (SM_STAFF_CODEForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SM>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SM entities by [SM.STAFF_CODE]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SM entities</param>
        /// <param name="Value">A list of related SM entities</param>
        /// <returns>True if any SM entities are found</returns>
        public bool TryFindSMBySTAFF_CODE(string SFKEY, out IReadOnlyList<SM> Value)
        {
            return SM_STAFF_CODEForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SMCD (Student Medication Doses) entities by [SMCD.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SMCD entities</param>
        /// <returns>A list of related SMCD entities</returns>
        public IReadOnlyList<SMCD> FindSMCDBySTAFF(string SFKEY)
        {
            IReadOnlyList<SMCD> result;
            if (SMCD_STAFFForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SMCD>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SMCD entities by [SMCD.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SMCD entities</param>
        /// <param name="Value">A list of related SMCD entities</param>
        /// <returns>True if any SMCD entities are found</returns>
        public bool TryFindSMCDBySTAFF(string SFKEY, out IReadOnlyList<SMCD> Value)
        {
            return SMCD_STAFFForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SS (Specialist Subjects) entities by [SS.DEFAULT_TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SS entities</param>
        /// <returns>A list of related SS entities</returns>
        public IReadOnlyList<SS> FindSSByDEFAULT_TEACHER(string SFKEY)
        {
            IReadOnlyList<SS> result;
            if (SS_DEFAULT_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SS entities by [SS.DEFAULT_TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SS entities</param>
        /// <param name="Value">A list of related SS entities</param>
        /// <returns>True if any SS entities are found</returns>
        public bool TryFindSSByDEFAULT_TEACHER(string SFKEY, out IReadOnlyList<SS> Value)
        {
            return SS_DEFAULT_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all SSHG (Specialist Subjects per Home Group) entities by [SSHG.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SSHG entities</param>
        /// <returns>A list of related SSHG entities</returns>
        public IReadOnlyList<SSHG> FindSSHGByTEACHER(string SFKEY)
        {
            IReadOnlyList<SSHG> result;
            if (SSHG_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SSHG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SSHG entities by [SSHG.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find SSHG entities</param>
        /// <param name="Value">A list of related SSHG entities</param>
        /// <returns>True if any SSHG entities are found</returns>
        public bool TryFindSSHGByTEACHER(string SFKEY, out IReadOnlyList<SSHG> Value)
        {
            return SSHG_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all STSP (Suspension Details) entities by [STSP.REF_TEACHERA]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find STSP entities</param>
        /// <returns>A list of related STSP entities</returns>
        public IReadOnlyList<STSP> FindSTSPByREF_TEACHERA(string SFKEY)
        {
            IReadOnlyList<STSP> result;
            if (STSP_REF_TEACHERAForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STSP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STSP entities by [STSP.REF_TEACHERA]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find STSP entities</param>
        /// <param name="Value">A list of related STSP entities</param>
        /// <returns>True if any STSP entities are found</returns>
        public bool TryFindSTSPByREF_TEACHERA(string SFKEY, out IReadOnlyList<STSP> Value)
        {
            return STSP_REF_TEACHERAForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all STSP (Suspension Details) entities by [STSP.REF_TEACHERB]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find STSP entities</param>
        /// <returns>A list of related STSP entities</returns>
        public IReadOnlyList<STSP> FindSTSPByREF_TEACHERB(string SFKEY)
        {
            IReadOnlyList<STSP> result;
            if (STSP_REF_TEACHERBForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STSP>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STSP entities by [STSP.REF_TEACHERB]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find STSP entities</param>
        /// <param name="Value">A list of related STSP entities</param>
        /// <returns>True if any STSP entities are found</returns>
        public bool TryFindSTSPByREF_TEACHERB(string SFKEY, out IReadOnlyList<STSP> Value)
        {
            return STSP_REF_TEACHERBForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TCTB (Teacher Absences) entities by [TCTB.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTB entities</param>
        /// <returns>A list of related TCTB entities</returns>
        public IReadOnlyList<TCTB> FindTCTBByTEACHER(string SFKEY)
        {
            IReadOnlyList<TCTB> result;
            if (TCTB_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTB entities by [TCTB.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTB entities</param>
        /// <param name="Value">A list of related TCTB entities</param>
        /// <returns>True if any TCTB entities are found</returns>
        public bool TryFindTCTBByTEACHER(string SFKEY, out IReadOnlyList<TCTB> Value)
        {
            return TCTB_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByT1TEACH(string SFKEY)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_T1TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByT1TEACH(string SFKEY, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_T1TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByT2TEACH(string SFKEY)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_T2TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByT2TEACH(string SFKEY, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_T2TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TCTQ (Calendar Class Information) entities by [TCTQ.EXTRA_TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTQ entities</param>
        /// <returns>A list of related TCTQ entities</returns>
        public IReadOnlyList<TCTQ> FindTCTQByEXTRA_TEACH(string SFKEY)
        {
            IReadOnlyList<TCTQ> result;
            if (TCTQ_EXTRA_TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTQ entities by [TCTQ.EXTRA_TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTQ entities</param>
        /// <param name="Value">A list of related TCTQ entities</param>
        /// <returns>True if any TCTQ entities are found</returns>
        public bool TryFindTCTQByEXTRA_TEACH(string SFKEY, out IReadOnlyList<TCTQ> Value)
        {
            return TCTQ_EXTRA_TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TCTR (Teacher Replacements) entities by [TCTR.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTR entities</param>
        /// <returns>A list of related TCTR entities</returns>
        public IReadOnlyList<TCTR> FindTCTRByTEACH(string SFKEY)
        {
            IReadOnlyList<TCTR> result;
            if (TCTR_TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TCTR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TCTR entities by [TCTR.TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TCTR entities</param>
        /// <param name="Value">A list of related TCTR entities</param>
        /// <returns>True if any TCTR entities are found</returns>
        public bool TryFindTCTRByTEACH(string SFKEY, out IReadOnlyList<TCTR> Value)
        {
            return TCTR_TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQByT1TEACH(string SFKEY)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_T1TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQByT1TEACH(string SFKEY, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_T1TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQByT2TEACH(string SFKEY)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_T2TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQByT2TEACH(string SFKEY, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_T2TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all THTQ (Timetable Quilt Entries) entities by [THTQ.EXTRA_TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find THTQ entities</param>
        /// <returns>A list of related THTQ entities</returns>
        public IReadOnlyList<THTQ> FindTHTQByEXTRA_TEACH(string SFKEY)
        {
            IReadOnlyList<THTQ> result;
            if (THTQ_EXTRA_TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<THTQ>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all THTQ entities by [THTQ.EXTRA_TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find THTQ entities</param>
        /// <param name="Value">A list of related THTQ entities</param>
        /// <returns>True if any THTQ entities are found</returns>
        public bool TryFindTHTQByEXTRA_TEACH(string SFKEY, out IReadOnlyList<THTQ> Value)
        {
            return THTQ_EXTRA_TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TTEF (Exam Staff) entities by [TTEF.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TTEF entities</param>
        /// <returns>A list of related TTEF entities</returns>
        public IReadOnlyList<TTEF> FindTTEFBySTAFF(string SFKEY)
        {
            IReadOnlyList<TTEF> result;
            if (TTEF_STAFFForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTEF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTEF entities by [TTEF.STAFF]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TTEF entities</param>
        /// <param name="Value">A list of related TTEF entities</param>
        /// <returns>True if any TTEF entities are found</returns>
        public bool TryFindTTEFBySTAFF(string SFKEY, out IReadOnlyList<TTEF> Value)
        {
            return TTEF_STAFFForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TTTG (Grid Subjects) entities by [TTTG.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TTTG entities</param>
        /// <returns>A list of related TTTG entities</returns>
        public IReadOnlyList<TTTG> FindTTTGByT1TEACH(string SFKEY)
        {
            IReadOnlyList<TTTG> result;
            if (TTTG_T1TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTTG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTTG entities by [TTTG.T1TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TTTG entities</param>
        /// <param name="Value">A list of related TTTG entities</param>
        /// <returns>True if any TTTG entities are found</returns>
        public bool TryFindTTTGByT1TEACH(string SFKEY, out IReadOnlyList<TTTG> Value)
        {
            return TTTG_T1TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TTTG (Grid Subjects) entities by [TTTG.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TTTG entities</param>
        /// <returns>A list of related TTTG entities</returns>
        public IReadOnlyList<TTTG> FindTTTGByT2TEACH(string SFKEY)
        {
            IReadOnlyList<TTTG> result;
            if (TTTG_T2TEACHForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TTTG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TTTG entities by [TTTG.T2TEACH]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TTTG entities</param>
        /// <param name="Value">A list of related TTTG entities</param>
        /// <returns>True if any TTTG entities are found</returns>
        public bool TryFindTTTGByT2TEACH(string SFKEY, out IReadOnlyList<TTTG> Value)
        {
            return TTTG_T2TEACHForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }

        /// <summary>
        /// Find all TXAS (Actual Sessions) entities by [TXAS.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TXAS entities</param>
        /// <returns>A list of related TXAS entities</returns>
        public IReadOnlyList<TXAS> FindTXASByTEACHER(string SFKEY)
        {
            IReadOnlyList<TXAS> result;
            if (TXAS_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TXAS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TXAS entities by [TXAS.TEACHER]-&gt;[SF.SFKEY]
        /// </summary>
        /// <param name="SFKEY">SFKEY value used to find TXAS entities</param>
        /// <param name="Value">A list of related TXAS entities</param>
        /// <returns>True if any TXAS entities are found</returns>
        public bool TryFindTXASByTEACHER(string SFKEY, out IReadOnlyList<TXAS> Value)
        {
            return TXAS_TEACHERForeignIndex.Value.TryGetValue(SFKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SF" /> fields for each CSV column header</returns>
        protected override Action<SF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SFKEY":
                        mapper[i] = (e, v) => e.SFKEY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
                    case "PREVIOUS_NAME":
                        mapper[i] = (e, v) => e.PREVIOUS_NAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOMEKEY":
                        mapper[i] = (e, v) => e.HOMEKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "VIT_NO":
                        mapper[i] = (e, v) => e.VIT_NO = v;
                        break;
                    case "START":
                        mapper[i] = (e, v) => e.START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FINISH":
                        mapper[i] = (e, v) => e.FINISH = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FACULTY01":
                        mapper[i] = (e, v) => e.FACULTY01 = v;
                        break;
                    case "FACULTY02":
                        mapper[i] = (e, v) => e.FACULTY02 = v;
                        break;
                    case "FACULTY03":
                        mapper[i] = (e, v) => e.FACULTY03 = v;
                        break;
                    case "FACULTY04":
                        mapper[i] = (e, v) => e.FACULTY04 = v;
                        break;
                    case "SUBJECT01":
                        mapper[i] = (e, v) => e.SUBJECT01 = v;
                        break;
                    case "SUBJECT02":
                        mapper[i] = (e, v) => e.SUBJECT02 = v;
                        break;
                    case "SUBJECT03":
                        mapper[i] = (e, v) => e.SUBJECT03 = v;
                        break;
                    case "SUBJECT04":
                        mapper[i] = (e, v) => e.SUBJECT04 = v;
                        break;
                    case "SUBJECT05":
                        mapper[i] = (e, v) => e.SUBJECT05 = v;
                        break;
                    case "SUBJECT06":
                        mapper[i] = (e, v) => e.SUBJECT06 = v;
                        break;
                    case "SUBJECT07":
                        mapper[i] = (e, v) => e.SUBJECT07 = v;
                        break;
                    case "SUBJECT08":
                        mapper[i] = (e, v) => e.SUBJECT08 = v;
                        break;
                    case "SUBJECT09":
                        mapper[i] = (e, v) => e.SUBJECT09 = v;
                        break;
                    case "SUBJECT10":
                        mapper[i] = (e, v) => e.SUBJECT10 = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "AVAILABILITY01":
                        mapper[i] = (e, v) => e.AVAILABILITY01 = v;
                        break;
                    case "AVAILABILITY02":
                        mapper[i] = (e, v) => e.AVAILABILITY02 = v;
                        break;
                    case "AVAILABILITY03":
                        mapper[i] = (e, v) => e.AVAILABILITY03 = v;
                        break;
                    case "AVAILABILITY04":
                        mapper[i] = (e, v) => e.AVAILABILITY04 = v;
                        break;
                    case "AVAILABILITY05":
                        mapper[i] = (e, v) => e.AVAILABILITY05 = v;
                        break;
                    case "RANK":
                        mapper[i] = (e, v) => e.RANK = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOUSE":
                        mapper[i] = (e, v) => e.HOUSE = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "OTHER_LOCATION":
                        mapper[i] = (e, v) => e.OTHER_LOCATION = v;
                        break;
                    case "CAR_REGO":
                        mapper[i] = (e, v) => e.CAR_REGO = v;
                        break;
                    case "STAFF_TYPE":
                        mapper[i] = (e, v) => e.STAFF_TYPE = v;
                        break;
                    case "POS_CODE_A":
                        mapper[i] = (e, v) => e.POS_CODE_A = v;
                        break;
                    case "POS_CODE_B":
                        mapper[i] = (e, v) => e.POS_CODE_B = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "STAFF_STATUS":
                        mapper[i] = (e, v) => e.STAFF_STATUS = v;
                        break;
                    case "MAJORA":
                        mapper[i] = (e, v) => e.MAJORA = v;
                        break;
                    case "MAJORB":
                        mapper[i] = (e, v) => e.MAJORB = v;
                        break;
                    case "MAJORC":
                        mapper[i] = (e, v) => e.MAJORC = v;
                        break;
                    case "SKILL_QUALIFICATION":
                        mapper[i] = (e, v) => e.SKILL_QUALIFICATION = v;
                        break;
                    case "PAYROLL_REC_NO":
                        mapper[i] = (e, v) => e.PAYROLL_REC_NO = v;
                        break;
                    case "PAYROLL_CLASS":
                        mapper[i] = (e, v) => e.PAYROLL_CLASS = v;
                        break;
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "REPORT_NAME":
                        mapper[i] = (e, v) => e.REPORT_NAME = v;
                        break;
                    case "POLICE_CLEARANCE":
                        mapper[i] = (e, v) => e.POLICE_CLEARANCE = v;
                        break;
                    case "CLEARANCE_DATE":
                        mapper[i] = (e, v) => e.CLEARANCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "STAFF_PIC":
                        mapper[i] = (e, v) => e.STAFF_PIC = null; // eduHub is not encoding byte arrays
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
                    case "AVAILABLE":
                        mapper[i] = (e, v) => e.AVAILABLE = null; // eduHub is not encoding byte arrays
                        break;
                    case "MAX_EXTRAS":
                        mapper[i] = (e, v) => e.MAX_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ACC_EXTRAS":
                        mapper[i] = (e, v) => e.ACC_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WEEK_EXTRAS":
                        mapper[i] = (e, v) => e.WEEK_EXTRAS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LAST_EXTRAS":
                        mapper[i] = (e, v) => e.LAST_EXTRAS = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "BIRTH_COUNTRY":
                        mapper[i] = (e, v) => e.BIRTH_COUNTRY = v;
                        break;
                    case "LANG01":
                        mapper[i] = (e, v) => e.LANG01 = v;
                        break;
                    case "LANG02":
                        mapper[i] = (e, v) => e.LANG02 = v;
                        break;
                    case "INTERPRETER01":
                        mapper[i] = (e, v) => e.INTERPRETER01 = v;
                        break;
                    case "INTERPRETER02":
                        mapper[i] = (e, v) => e.INTERPRETER02 = v;
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
                    case "GROUP_AVAILABILITY":
                        mapper[i] = (e, v) => e.GROUP_AVAILABILITY = v;
                        break;
                    case "NORMAL_ALLOTMENT":
                        mapper[i] = (e, v) => e.NORMAL_ALLOTMENT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HRMS_UPDATE":
                        mapper[i] = (e, v) => e.HRMS_UPDATE = v;
                        break;
                    case "HRMS_DATETIME":
                        mapper[i] = (e, v) => e.HRMS_DATETIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DEBTOR_ID":
                        mapper[i] = (e, v) => e.DEBTOR_ID = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
