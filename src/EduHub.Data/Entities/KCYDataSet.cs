using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year Levels Data Set
    /// </summary>
    public sealed partial class KCYDataSet : SetBase<KCY>
    {
        private Lazy<Dictionary<string, KCY>> KCYKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<KCY>>> KCY_NEXT_YRForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KGC>>> KGC_MIN_AC_YRForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KGC>>> KGC_MAX_AC_YRForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SC>>> SC_SUBJECT_ACADEMIC_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>> SCSFAG_ST_YEAR_LEVELForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SG>>> SG_CAND_FIRST_YRForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SG>>> SG_CAND_LAST_YRForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SG>>> SG_FUT_FIRST_YRForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SG>>> SG_FUT_LAST_YRForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_SCHOOL_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>> ST_TFR_SCHOOL_YEAR_NEWForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STMA>>> STMA_SCHOOL_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STRE>>> STRE_ST_SCHOOL_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STVDI>>> STVDI_SCHOOL_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STVDO>>> STVDO_SCHOOL_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SU>>> SU_SUBJECT_ACADEMIC_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SVAG>>> SVAG_SCHOOL_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SXAB>>> SXAB_ST_YEAR_LEVELForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SXABCONV>>> SXABCONV_ST_YEAR_LEVELForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SXAS>>> SXAS_ST_YEAR_LEVELForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TE>>> TE_START_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TE>>> TE_END_YEARForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR01ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR02ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR03ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR04ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR05ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR06ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR07ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR08ForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<TT>>> TT_SUBJECT_ACADEMIC_YEAR09ForeignIndex;

        internal KCYDataSet(EduHubContext Context)
            : base(Context)
        {
            KCYKEYIndex = new Lazy<Dictionary<string, KCY>>(() => this.ToDictionary(e => e.KCYKEY));

            KCY_NEXT_YRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KCY>>>(() =>
                    Context.KCY
                          .Where(e => e.NEXT_YR != null)
                          .GroupBy(e => e.NEXT_YR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KCY>)g.ToList()
                          .AsReadOnly()));

            KGC_MIN_AC_YRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGC>>>(() =>
                    Context.KGC
                          .Where(e => e.MIN_AC_YR != null)
                          .GroupBy(e => e.MIN_AC_YR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGC>)g.ToList()
                          .AsReadOnly()));

            KGC_MAX_AC_YRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGC>>>(() =>
                    Context.KGC
                          .Where(e => e.MAX_AC_YR != null)
                          .GroupBy(e => e.MAX_AC_YR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGC>)g.ToList()
                          .AsReadOnly()));

            SC_SUBJECT_ACADEMIC_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SC>>>(() =>
                    Context.SC
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SC>)g.ToList()
                          .AsReadOnly()));

            SCSFAG_ST_YEAR_LEVELForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>>(() =>
                    Context.SCSFAG
                          .Where(e => e.ST_YEAR_LEVEL != null)
                          .GroupBy(e => e.ST_YEAR_LEVEL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCSFAG>)g.ToList()
                          .AsReadOnly()));

            SG_CAND_FIRST_YRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SG>>>(() =>
                    Context.SG
                          .Where(e => e.CAND_FIRST_YR != null)
                          .GroupBy(e => e.CAND_FIRST_YR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SG>)g.ToList()
                          .AsReadOnly()));

            SG_CAND_LAST_YRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SG>>>(() =>
                    Context.SG
                          .Where(e => e.CAND_LAST_YR != null)
                          .GroupBy(e => e.CAND_LAST_YR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SG>)g.ToList()
                          .AsReadOnly()));

            SG_FUT_FIRST_YRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SG>>>(() =>
                    Context.SG
                          .Where(e => e.FUT_FIRST_YR != null)
                          .GroupBy(e => e.FUT_FIRST_YR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SG>)g.ToList()
                          .AsReadOnly()));

            SG_FUT_LAST_YRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SG>>>(() =>
                    Context.SG
                          .Where(e => e.FUT_LAST_YR != null)
                          .GroupBy(e => e.FUT_LAST_YR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SG>)g.ToList()
                          .AsReadOnly()));

            ST_SCHOOL_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.SCHOOL_YEAR != null)
                          .GroupBy(e => e.SCHOOL_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            ST_TFR_SCHOOL_YEAR_NEWForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST_TFR>>>(() =>
                    Context.ST_TFR
                          .Where(e => e.SCHOOL_YEAR_NEW != null)
                          .GroupBy(e => e.SCHOOL_YEAR_NEW)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST_TFR>)g.ToList()
                          .AsReadOnly()));

            STMA_SCHOOL_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STMA>>>(() =>
                    Context.STMA
                          .Where(e => e.SCHOOL_YEAR != null)
                          .GroupBy(e => e.SCHOOL_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STMA>)g.ToList()
                          .AsReadOnly()));

            STRE_ST_SCHOOL_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STRE>>>(() =>
                    Context.STRE
                          .Where(e => e.ST_SCHOOL_YEAR != null)
                          .GroupBy(e => e.ST_SCHOOL_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRE>)g.ToList()
                          .AsReadOnly()));

            STVDI_SCHOOL_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STVDI>>>(() =>
                    Context.STVDI
                          .Where(e => e.SCHOOL_YEAR != null)
                          .GroupBy(e => e.SCHOOL_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDI>)g.ToList()
                          .AsReadOnly()));

            STVDO_SCHOOL_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STVDO>>>(() =>
                    Context.STVDO
                          .Where(e => e.SCHOOL_YEAR != null)
                          .GroupBy(e => e.SCHOOL_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STVDO>)g.ToList()
                          .AsReadOnly()));

            SU_SUBJECT_ACADEMIC_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SU>>>(() =>
                    Context.SU
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SU>)g.ToList()
                          .AsReadOnly()));

            SVAG_SCHOOL_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SVAG>>>(() =>
                    Context.SVAG
                          .Where(e => e.SCHOOL_YEAR != null)
                          .GroupBy(e => e.SCHOOL_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SVAG>)g.ToList()
                          .AsReadOnly()));

            SXAB_ST_YEAR_LEVELForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SXAB>>>(() =>
                    Context.SXAB
                          .Where(e => e.ST_YEAR_LEVEL != null)
                          .GroupBy(e => e.ST_YEAR_LEVEL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAB>)g.ToList()
                          .AsReadOnly()));

            SXABCONV_ST_YEAR_LEVELForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SXABCONV>>>(() =>
                    Context.SXABCONV
                          .Where(e => e.ST_YEAR_LEVEL != null)
                          .GroupBy(e => e.ST_YEAR_LEVEL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXABCONV>)g.ToList()
                          .AsReadOnly()));

            SXAS_ST_YEAR_LEVELForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SXAS>>>(() =>
                    Context.SXAS
                          .Where(e => e.ST_YEAR_LEVEL != null)
                          .GroupBy(e => e.ST_YEAR_LEVEL)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAS>)g.ToList()
                          .AsReadOnly()));

            TE_START_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TE>>>(() =>
                    Context.TE
                          .Where(e => e.START_YEAR != null)
                          .GroupBy(e => e.START_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TE>)g.ToList()
                          .AsReadOnly()));

            TE_END_YEARForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TE>>>(() =>
                    Context.TE
                          .Where(e => e.END_YEAR != null)
                          .GroupBy(e => e.END_YEAR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TE>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR01ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR01 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR01)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR02ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR02 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR02)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR03ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR03 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR03)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR04ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR04 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR04)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR05ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR05 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR05)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR06ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR06 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR06)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR07ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR07 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR07)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR08ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR08 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR08)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

            TT_SUBJECT_ACADEMIC_YEAR09ForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<TT>>>(() =>
                    Context.TT
                          .Where(e => e.SUBJECT_ACADEMIC_YEAR09 != null)
                          .GroupBy(e => e.SUBJECT_ACADEMIC_YEAR09)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<TT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCY"; } }

        /// <summary>
        /// Find KCY by KCYKEY key field
        /// </summary>
        /// <param name="Key">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCYKEY value didn't match any KCY entities</exception>
        public KCY FindByKCYKEY(string Key)
        {
            KCY result;
            if (KCYKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY key field
        /// </summary>
        /// <param name="Key">KCYKEY value used to find KCY</param>
        /// <param name="Value">Related KCY entity</param>
        /// <returns>True if the KCY entity is found</returns>
        public bool TryFindByKCYKEY(string Key, out KCY Value)
        {
            return KCYKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCY by KCYKEY key field
        /// </summary>
        /// <param name="Key">KCYKEY value used to find KCY</param>
        /// <returns>Related KCY entity, or null if not found</returns>
        public KCY TryFindByKCYKEY(string Key)
        {
            KCY result;
            if (KCYKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all KCY (Year Levels) entities by [KCY.NEXT_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY entities</param>
        /// <returns>A list of related KCY entities</returns>
        public IReadOnlyList<KCY> FindKCYByNEXT_YR(string KCYKEY)
        {
            IReadOnlyList<KCY> result;
            if (KCY_NEXT_YRForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KCY>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KCY entities by [KCY.NEXT_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KCY entities</param>
        /// <param name="Value">A list of related KCY entities</param>
        /// <returns>True if any KCY entities are found</returns>
        public bool TryFindKCYByNEXT_YR(string KCYKEY, out IReadOnlyList<KCY> Value)
        {
            return KCY_NEXT_YRForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all KGC (Home Groups) entities by [KGC.MIN_AC_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KGC entities</param>
        /// <returns>A list of related KGC entities</returns>
        public IReadOnlyList<KGC> FindKGCByMIN_AC_YR(string KCYKEY)
        {
            IReadOnlyList<KGC> result;
            if (KGC_MIN_AC_YRForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KGC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGC entities by [KGC.MIN_AC_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KGC entities</param>
        /// <param name="Value">A list of related KGC entities</param>
        /// <returns>True if any KGC entities are found</returns>
        public bool TryFindKGCByMIN_AC_YR(string KCYKEY, out IReadOnlyList<KGC> Value)
        {
            return KGC_MIN_AC_YRForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all KGC (Home Groups) entities by [KGC.MAX_AC_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KGC entities</param>
        /// <returns>A list of related KGC entities</returns>
        public IReadOnlyList<KGC> FindKGCByMAX_AC_YR(string KCYKEY)
        {
            IReadOnlyList<KGC> result;
            if (KGC_MAX_AC_YRForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<KGC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGC entities by [KGC.MAX_AC_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find KGC entities</param>
        /// <param name="Value">A list of related KGC entities</param>
        /// <returns>True if any KGC entities are found</returns>
        public bool TryFindKGCByMAX_AC_YR(string KCYKEY, out IReadOnlyList<KGC> Value)
        {
            return KGC_MAX_AC_YRForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SC (Courses) entities by [SC.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SC entities</param>
        /// <returns>A list of related SC entities</returns>
        public IReadOnlyList<SC> FindSCBySUBJECT_ACADEMIC_YEAR(string KCYKEY)
        {
            IReadOnlyList<SC> result;
            if (SC_SUBJECT_ACADEMIC_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SC>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SC entities by [SC.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SC entities</param>
        /// <param name="Value">A list of related SC entities</param>
        /// <returns>True if any SC entities are found</returns>
        public bool TryFindSCBySUBJECT_ACADEMIC_YEAR(string KCYKEY, out IReadOnlyList<SC> Value)
        {
            return SC_SUBJECT_ACADEMIC_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SCSFAG (CSF Data Aggregates) entities by [SCSFAG.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SCSFAG entities</param>
        /// <returns>A list of related SCSFAG entities</returns>
        public IReadOnlyList<SCSFAG> FindSCSFAGByST_YEAR_LEVEL(string KCYKEY)
        {
            IReadOnlyList<SCSFAG> result;
            if (SCSFAG_ST_YEAR_LEVELForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCSFAG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCSFAG entities by [SCSFAG.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SCSFAG entities</param>
        /// <param name="Value">A list of related SCSFAG entities</param>
        /// <returns>True if any SCSFAG entities are found</returns>
        public bool TryFindSCSFAGByST_YEAR_LEVEL(string KCYKEY, out IReadOnlyList<SCSFAG> Value)
        {
            return SCSFAG_ST_YEAR_LEVELForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SG (Student Groupings) entities by [SG.CAND_FIRST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SG entities</param>
        /// <returns>A list of related SG entities</returns>
        public IReadOnlyList<SG> FindSGByCAND_FIRST_YR(string KCYKEY)
        {
            IReadOnlyList<SG> result;
            if (SG_CAND_FIRST_YRForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SG entities by [SG.CAND_FIRST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SG entities</param>
        /// <param name="Value">A list of related SG entities</param>
        /// <returns>True if any SG entities are found</returns>
        public bool TryFindSGByCAND_FIRST_YR(string KCYKEY, out IReadOnlyList<SG> Value)
        {
            return SG_CAND_FIRST_YRForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SG (Student Groupings) entities by [SG.CAND_LAST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SG entities</param>
        /// <returns>A list of related SG entities</returns>
        public IReadOnlyList<SG> FindSGByCAND_LAST_YR(string KCYKEY)
        {
            IReadOnlyList<SG> result;
            if (SG_CAND_LAST_YRForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SG entities by [SG.CAND_LAST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SG entities</param>
        /// <param name="Value">A list of related SG entities</param>
        /// <returns>True if any SG entities are found</returns>
        public bool TryFindSGByCAND_LAST_YR(string KCYKEY, out IReadOnlyList<SG> Value)
        {
            return SG_CAND_LAST_YRForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SG (Student Groupings) entities by [SG.FUT_FIRST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SG entities</param>
        /// <returns>A list of related SG entities</returns>
        public IReadOnlyList<SG> FindSGByFUT_FIRST_YR(string KCYKEY)
        {
            IReadOnlyList<SG> result;
            if (SG_FUT_FIRST_YRForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SG entities by [SG.FUT_FIRST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SG entities</param>
        /// <param name="Value">A list of related SG entities</param>
        /// <returns>True if any SG entities are found</returns>
        public bool TryFindSGByFUT_FIRST_YR(string KCYKEY, out IReadOnlyList<SG> Value)
        {
            return SG_FUT_FIRST_YRForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SG (Student Groupings) entities by [SG.FUT_LAST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SG entities</param>
        /// <returns>A list of related SG entities</returns>
        public IReadOnlyList<SG> FindSGByFUT_LAST_YR(string KCYKEY)
        {
            IReadOnlyList<SG> result;
            if (SG_FUT_LAST_YRForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SG entities by [SG.FUT_LAST_YR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SG entities</param>
        /// <param name="Value">A list of related SG entities</param>
        /// <returns>True if any SG entities are found</returns>
        public bool TryFindSGByFUT_LAST_YR(string KCYKEY, out IReadOnlyList<SG> Value)
        {
            return SG_FUT_LAST_YRForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTBySCHOOL_YEAR(string KCYKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTBySCHOOL_YEAR(string KCYKEY, out IReadOnlyList<ST> Value)
        {
            return ST_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all ST_TFR (ST Transfer) entities by [ST_TFR.SCHOOL_YEAR_NEW]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find ST_TFR entities</param>
        /// <returns>A list of related ST_TFR entities</returns>
        public IReadOnlyList<ST_TFR> FindST_TFRBySCHOOL_YEAR_NEW(string KCYKEY)
        {
            IReadOnlyList<ST_TFR> result;
            if (ST_TFR_SCHOOL_YEAR_NEWForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST_TFR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST_TFR entities by [ST_TFR.SCHOOL_YEAR_NEW]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find ST_TFR entities</param>
        /// <param name="Value">A list of related ST_TFR entities</param>
        /// <returns>True if any ST_TFR entities are found</returns>
        public bool TryFindST_TFRBySCHOOL_YEAR_NEW(string KCYKEY, out IReadOnlyList<ST_TFR> Value)
        {
            return ST_TFR_SCHOOL_YEAR_NEWForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all STMA (Subject Selections &amp; Marks) entities by [STMA.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find STMA entities</param>
        /// <returns>A list of related STMA entities</returns>
        public IReadOnlyList<STMA> FindSTMABySCHOOL_YEAR(string KCYKEY)
        {
            IReadOnlyList<STMA> result;
            if (STMA_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STMA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STMA entities by [STMA.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find STMA entities</param>
        /// <param name="Value">A list of related STMA entities</param>
        /// <returns>True if any STMA entities are found</returns>
        public bool TryFindSTMABySCHOOL_YEAR(string KCYKEY, out IReadOnlyList<STMA> Value)
        {
            return STMA_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all STRE (Student Re-Enrolment) entities by [STRE.ST_SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find STRE entities</param>
        /// <returns>A list of related STRE entities</returns>
        public IReadOnlyList<STRE> FindSTREByST_SCHOOL_YEAR(string KCYKEY)
        {
            IReadOnlyList<STRE> result;
            if (STRE_ST_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRE entities by [STRE.ST_SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find STRE entities</param>
        /// <param name="Value">A list of related STRE entities</param>
        /// <returns>True if any STRE entities are found</returns>
        public bool TryFindSTREByST_SCHOOL_YEAR(string KCYKEY, out IReadOnlyList<STRE> Value)
        {
            return STRE_ST_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all STVDI (VELS Dimension Results) entities by [STVDI.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find STVDI entities</param>
        /// <returns>A list of related STVDI entities</returns>
        public IReadOnlyList<STVDI> FindSTVDIBySCHOOL_YEAR(string KCYKEY)
        {
            IReadOnlyList<STVDI> result;
            if (STVDI_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDI entities by [STVDI.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find STVDI entities</param>
        /// <param name="Value">A list of related STVDI entities</param>
        /// <returns>True if any STVDI entities are found</returns>
        public bool TryFindSTVDIBySCHOOL_YEAR(string KCYKEY, out IReadOnlyList<STVDI> Value)
        {
            return STVDI_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all STVDO (VELS Domain Results) entities by [STVDO.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find STVDO entities</param>
        /// <returns>A list of related STVDO entities</returns>
        public IReadOnlyList<STVDO> FindSTVDOBySCHOOL_YEAR(string KCYKEY)
        {
            IReadOnlyList<STVDO> result;
            if (STVDO_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STVDO>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STVDO entities by [STVDO.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find STVDO entities</param>
        /// <param name="Value">A list of related STVDO entities</param>
        /// <returns>True if any STVDO entities are found</returns>
        public bool TryFindSTVDOBySCHOOL_YEAR(string KCYKEY, out IReadOnlyList<STVDO> Value)
        {
            return STVDO_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SU (Subjects) entities by [SU.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SU entities</param>
        /// <returns>A list of related SU entities</returns>
        public IReadOnlyList<SU> FindSUBySUBJECT_ACADEMIC_YEAR(string KCYKEY)
        {
            IReadOnlyList<SU> result;
            if (SU_SUBJECT_ACADEMIC_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SU>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SU entities by [SU.SUBJECT_ACADEMIC_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SU entities</param>
        /// <param name="Value">A list of related SU entities</param>
        /// <returns>True if any SU entities are found</returns>
        public bool TryFindSUBySUBJECT_ACADEMIC_YEAR(string KCYKEY, out IReadOnlyList<SU> Value)
        {
            return SU_SUBJECT_ACADEMIC_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SVAG (VELS Aggregated Dimensions) entities by [SVAG.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SVAG entities</param>
        /// <returns>A list of related SVAG entities</returns>
        public IReadOnlyList<SVAG> FindSVAGBySCHOOL_YEAR(string KCYKEY)
        {
            IReadOnlyList<SVAG> result;
            if (SVAG_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SVAG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SVAG entities by [SVAG.SCHOOL_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SVAG entities</param>
        /// <param name="Value">A list of related SVAG entities</param>
        /// <returns>True if any SVAG entities are found</returns>
        public bool TryFindSVAGBySCHOOL_YEAR(string KCYKEY, out IReadOnlyList<SVAG> Value)
        {
            return SVAG_SCHOOL_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SXAB (Student Half-Day Absences) entities by [SXAB.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SXAB entities</param>
        /// <returns>A list of related SXAB entities</returns>
        public IReadOnlyList<SXAB> FindSXABByST_YEAR_LEVEL(string KCYKEY)
        {
            IReadOnlyList<SXAB> result;
            if (SXAB_ST_YEAR_LEVELForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAB entities by [SXAB.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SXAB entities</param>
        /// <param name="Value">A list of related SXAB entities</param>
        /// <returns>True if any SXAB entities are found</returns>
        public bool TryFindSXABByST_YEAR_LEVEL(string KCYKEY, out IReadOnlyList<SXAB> Value)
        {
            return SXAB_ST_YEAR_LEVELForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SXABCONV (Converted Student Half-Day Absences) entities by [SXABCONV.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SXABCONV entities</param>
        /// <returns>A list of related SXABCONV entities</returns>
        public IReadOnlyList<SXABCONV> FindSXABCONVByST_YEAR_LEVEL(string KCYKEY)
        {
            IReadOnlyList<SXABCONV> result;
            if (SXABCONV_ST_YEAR_LEVELForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXABCONV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXABCONV entities by [SXABCONV.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SXABCONV entities</param>
        /// <param name="Value">A list of related SXABCONV entities</param>
        /// <returns>True if any SXABCONV entities are found</returns>
        public bool TryFindSXABCONVByST_YEAR_LEVEL(string KCYKEY, out IReadOnlyList<SXABCONV> Value)
        {
            return SXABCONV_ST_YEAR_LEVELForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all SXAS (Student Scheduled Sessions) entities by [SXAS.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SXAS entities</param>
        /// <returns>A list of related SXAS entities</returns>
        public IReadOnlyList<SXAS> FindSXASByST_YEAR_LEVEL(string KCYKEY)
        {
            IReadOnlyList<SXAS> result;
            if (SXAS_ST_YEAR_LEVELForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAS entities by [SXAS.ST_YEAR_LEVEL]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find SXAS entities</param>
        /// <param name="Value">A list of related SXAS entities</param>
        /// <returns>True if any SXAS entities are found</returns>
        public bool TryFindSXASByST_YEAR_LEVEL(string KCYKEY, out IReadOnlyList<SXAS> Value)
        {
            return SXAS_ST_YEAR_LEVELForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TE (Calendar Events) entities by [TE.START_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TE entities</param>
        /// <returns>A list of related TE entities</returns>
        public IReadOnlyList<TE> FindTEBySTART_YEAR(string KCYKEY)
        {
            IReadOnlyList<TE> result;
            if (TE_START_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TE entities by [TE.START_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TE entities</param>
        /// <param name="Value">A list of related TE entities</param>
        /// <returns>True if any TE entities are found</returns>
        public bool TryFindTEBySTART_YEAR(string KCYKEY, out IReadOnlyList<TE> Value)
        {
            return TE_START_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TE (Calendar Events) entities by [TE.END_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TE entities</param>
        /// <returns>A list of related TE entities</returns>
        public IReadOnlyList<TE> FindTEByEND_YEAR(string KCYKEY)
        {
            IReadOnlyList<TE> result;
            if (TE_END_YEARForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TE>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TE entities by [TE.END_YEAR]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TE entities</param>
        /// <param name="Value">A list of related TE entities</param>
        /// <returns>True if any TE entities are found</returns>
        public bool TryFindTEByEND_YEAR(string KCYKEY, out IReadOnlyList<TE> Value)
        {
            return TE_END_YEARForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR01]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR01(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR01ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR01]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR01(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR01ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR02]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR02(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR02ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR02]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR02(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR02ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR03]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR03(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR03ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR03]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR03(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR03ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR04]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR04(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR04ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR04]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR04(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR04ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR05]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR05(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR05ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR05]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR05(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR05ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR06]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR06(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR06ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR06]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR06(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR06ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR07]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR07(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR07ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR07]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR07(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR07ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR08]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR08(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR08ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR08]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR08(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR08ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }

        /// <summary>
        /// Find all TT (Timetable Grid Templates) entities by [TT.SUBJECT_ACADEMIC_YEAR09]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <returns>A list of related TT entities</returns>
        public IReadOnlyList<TT> FindTTBySUBJECT_ACADEMIC_YEAR09(string KCYKEY)
        {
            IReadOnlyList<TT> result;
            if (TT_SUBJECT_ACADEMIC_YEAR09ForeignIndex.Value.TryGetValue(KCYKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<TT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all TT entities by [TT.SUBJECT_ACADEMIC_YEAR09]-&gt;[KCY.KCYKEY]
        /// </summary>
        /// <param name="KCYKEY">KCYKEY value used to find TT entities</param>
        /// <param name="Value">A list of related TT entities</param>
        /// <returns>True if any TT entities are found</returns>
        public bool TryFindTTBySUBJECT_ACADEMIC_YEAR09(string KCYKEY, out IReadOnlyList<TT> Value)
        {
            return TT_SUBJECT_ACADEMIC_YEAR09ForeignIndex.Value.TryGetValue(KCYKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCY" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCY" /> fields for each CSV column header</returns>
        protected override Action<KCY, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCY, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCYKEY":
                        mapper[i] = (e, v) => e.KCYKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NUM_EQVT":
                        mapper[i] = (e, v) => e.NUM_EQVT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SHORT_DESC":
                        mapper[i] = (e, v) => e.SHORT_DESC = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "NEXT_YR":
                        mapper[i] = (e, v) => e.NEXT_YR = v;
                        break;
                    case "FINAL_YR":
                        mapper[i] = (e, v) => e.FINAL_YR = v;
                        break;
                    case "CSF_REQUIRED":
                        mapper[i] = (e, v) => e.CSF_REQUIRED = v;
                        break;
                    case "HALF_DAY_ABS":
                        mapper[i] = (e, v) => e.HALF_DAY_ABS = v;
                        break;
                    case "PERIOD_ABS":
                        mapper[i] = (e, v) => e.PERIOD_ABS = v;
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
