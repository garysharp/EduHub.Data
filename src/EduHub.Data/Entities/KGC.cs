using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGC : EduHubEntity
    {

        #region Navigation Property Cache

        private SCI Cache_CAMPUS_SCI;
        private SF Cache_TEACHER_SF;
        private SF Cache_TEACHER_B_SF;
        private SM Cache_ROOM_SM;
        private KCY Cache_MIN_AC_YR_KCY;
        private KCY Cache_MAX_AC_YR_KCY;
        private KGC Cache_NEXT_HG_KGC;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<KGC> Cache_KGCKEY_KGC_NEXT_HG;
        private IReadOnlyList<KGCHI> Cache_KGCKEY_KGCHI_KGCKEY;
        private IReadOnlyList<SGHG> Cache_KGCKEY_SGHG_KGCLINK;
        private IReadOnlyList<SS> Cache_KGCKEY_SS_FROM_HOMEGROUP;
        private IReadOnlyList<SS> Cache_KGCKEY_SS_TO_HOMEGROUP;
        private IReadOnlyList<SSHG> Cache_KGCKEY_SSHG_HOMEGROUP;
        private IReadOnlyList<SSHG> Cache_KGCKEY_SSHG_TEACHING_HG;
        private IReadOnlyList<ST> Cache_KGCKEY_ST_HOME_GROUP;
        private IReadOnlyList<ST> Cache_KGCKEY_ST_NEXT_HG;
        private IReadOnlyList<ST_TFR> Cache_KGCKEY_ST_TFR_HOME_GROUP_NEW;
        private IReadOnlyList<STRE> Cache_KGCKEY_STRE_ST_HOME_GROUP;
        private IReadOnlyList<TE> Cache_KGCKEY_TE_START_FORM;
        private IReadOnlyList<TE> Cache_KGCKEY_TE_END_FORM;
        private IReadOnlyList<TXHG> Cache_KGCKEY_TXHG_HOME_GROUP;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// (Was FORM) Home Group code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string KGCKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Campus
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// Staff code of first or only home group teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }

        /// <summary>
        /// Staff code of second home group teacher (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER_B { get; internal set; }

        /// <summary>
        /// Active Home Group? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }

        /// <summary>
        /// Home group room
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }

        /// <summary>
        /// (Was FORM_SIZE) Home group population
        /// </summary>
        public short? HG_SIZE { get; internal set; }

        /// <summary>
        /// Number of male students in home group
        /// </summary>
        public short? MALES { get; internal set; }

        /// <summary>
        /// Number of female students in home group
        /// </summary>
        public short? FEMALES { get; internal set; }

        /// <summary>
        /// (Was AC_YR) Minimum year level covered by home group
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MIN_AC_YR { get; internal set; }

        /// <summary>
        /// Maximum year level covered by home group
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAX_AC_YR { get; internal set; }

        /// <summary>
        /// Assumed next home group (eg 8.1 is the group to which 7.1 is promoted)
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string NEXT_HG { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// SCI (School Information) related entity by [KGC.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Campus
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [KGC.TEACHER]-&gt;[SF.SFKEY]
        /// Staff code of first or only home group teacher
        /// </summary>
        public SF TEACHER_SF
        {
            get
            {
                if (TEACHER == null)
                {
                    return null;
                }
                if (Cache_TEACHER_SF == null)
                {
                    Cache_TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                }

                return Cache_TEACHER_SF;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [KGC.TEACHER_B]-&gt;[SF.SFKEY]
        /// Staff code of second home group teacher (if any)
        /// </summary>
        public SF TEACHER_B_SF
        {
            get
            {
                if (TEACHER_B == null)
                {
                    return null;
                }
                if (Cache_TEACHER_B_SF == null)
                {
                    Cache_TEACHER_B_SF = Context.SF.FindBySFKEY(TEACHER_B);
                }

                return Cache_TEACHER_B_SF;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [KGC.ROOM]-&gt;[SM.ROOM]
        /// Home group room
        /// </summary>
        public SM ROOM_SM
        {
            get
            {
                if (ROOM == null)
                {
                    return null;
                }
                if (Cache_ROOM_SM == null)
                {
                    Cache_ROOM_SM = Context.SM.FindByROOM(ROOM);
                }

                return Cache_ROOM_SM;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [KGC.MIN_AC_YR]-&gt;[KCY.KCYKEY]
        /// (Was AC_YR) Minimum year level covered by home group
        /// </summary>
        public KCY MIN_AC_YR_KCY
        {
            get
            {
                if (MIN_AC_YR == null)
                {
                    return null;
                }
                if (Cache_MIN_AC_YR_KCY == null)
                {
                    Cache_MIN_AC_YR_KCY = Context.KCY.FindByKCYKEY(MIN_AC_YR);
                }

                return Cache_MIN_AC_YR_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [KGC.MAX_AC_YR]-&gt;[KCY.KCYKEY]
        /// Maximum year level covered by home group
        /// </summary>
        public KCY MAX_AC_YR_KCY
        {
            get
            {
                if (MAX_AC_YR == null)
                {
                    return null;
                }
                if (Cache_MAX_AC_YR_KCY == null)
                {
                    Cache_MAX_AC_YR_KCY = Context.KCY.FindByKCYKEY(MAX_AC_YR);
                }

                return Cache_MAX_AC_YR_KCY;
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entity by [KGC.NEXT_HG]-&gt;[KGC.KGCKEY]
        /// Assumed next home group (eg 8.1 is the group to which 7.1 is promoted)
        /// </summary>
        public KGC NEXT_HG_KGC
        {
            get
            {
                if (NEXT_HG == null)
                {
                    return null;
                }
                if (Cache_NEXT_HG_KGC == null)
                {
                    Cache_NEXT_HG_KGC = Context.KGC.FindByKGCKEY(NEXT_HG);
                }

                return Cache_NEXT_HG_KGC;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// KGC (Home Groups) related entities by [KGC.KGCKEY]-&gt;[KGC.NEXT_HG]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<KGC> KGCKEY_KGC_NEXT_HG
        {
            get
            {
                if (Cache_KGCKEY_KGC_NEXT_HG == null &&
                    !Context.KGC.TryFindByNEXT_HG(KGCKEY, out Cache_KGCKEY_KGC_NEXT_HG))
                {
                    Cache_KGCKEY_KGC_NEXT_HG = new List<KGC>().AsReadOnly();
                }

                return Cache_KGCKEY_KGC_NEXT_HG;
            }
        }

        /// <summary>
        /// KGCHI (Home Group History) related entities by [KGC.KGCKEY]-&gt;[KGCHI.KGCKEY]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<KGCHI> KGCKEY_KGCHI_KGCKEY
        {
            get
            {
                if (Cache_KGCKEY_KGCHI_KGCKEY == null &&
                    !Context.KGCHI.TryFindByKGCKEY(KGCKEY, out Cache_KGCKEY_KGCHI_KGCKEY))
                {
                    Cache_KGCKEY_KGCHI_KGCKEY = new List<KGCHI>().AsReadOnly();
                }

                return Cache_KGCKEY_KGCHI_KGCKEY;
            }
        }

        /// <summary>
        /// SGHG (Home Group Eligibility Criteria) related entities by [KGC.KGCKEY]-&gt;[SGHG.KGCLINK]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<SGHG> KGCKEY_SGHG_KGCLINK
        {
            get
            {
                if (Cache_KGCKEY_SGHG_KGCLINK == null &&
                    !Context.SGHG.TryFindByKGCLINK(KGCKEY, out Cache_KGCKEY_SGHG_KGCLINK))
                {
                    Cache_KGCKEY_SGHG_KGCLINK = new List<SGHG>().AsReadOnly();
                }

                return Cache_KGCKEY_SGHG_KGCLINK;
            }
        }

        /// <summary>
        /// SS (Specialist Subjects) related entities by [KGC.KGCKEY]-&gt;[SS.FROM_HOMEGROUP]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<SS> KGCKEY_SS_FROM_HOMEGROUP
        {
            get
            {
                if (Cache_KGCKEY_SS_FROM_HOMEGROUP == null &&
                    !Context.SS.TryFindByFROM_HOMEGROUP(KGCKEY, out Cache_KGCKEY_SS_FROM_HOMEGROUP))
                {
                    Cache_KGCKEY_SS_FROM_HOMEGROUP = new List<SS>().AsReadOnly();
                }

                return Cache_KGCKEY_SS_FROM_HOMEGROUP;
            }
        }

        /// <summary>
        /// SS (Specialist Subjects) related entities by [KGC.KGCKEY]-&gt;[SS.TO_HOMEGROUP]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<SS> KGCKEY_SS_TO_HOMEGROUP
        {
            get
            {
                if (Cache_KGCKEY_SS_TO_HOMEGROUP == null &&
                    !Context.SS.TryFindByTO_HOMEGROUP(KGCKEY, out Cache_KGCKEY_SS_TO_HOMEGROUP))
                {
                    Cache_KGCKEY_SS_TO_HOMEGROUP = new List<SS>().AsReadOnly();
                }

                return Cache_KGCKEY_SS_TO_HOMEGROUP;
            }
        }

        /// <summary>
        /// SSHG (Specialist Subjects per Home Group) related entities by [KGC.KGCKEY]-&gt;[SSHG.HOMEGROUP]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<SSHG> KGCKEY_SSHG_HOMEGROUP
        {
            get
            {
                if (Cache_KGCKEY_SSHG_HOMEGROUP == null &&
                    !Context.SSHG.TryFindByHOMEGROUP(KGCKEY, out Cache_KGCKEY_SSHG_HOMEGROUP))
                {
                    Cache_KGCKEY_SSHG_HOMEGROUP = new List<SSHG>().AsReadOnly();
                }

                return Cache_KGCKEY_SSHG_HOMEGROUP;
            }
        }

        /// <summary>
        /// SSHG (Specialist Subjects per Home Group) related entities by [KGC.KGCKEY]-&gt;[SSHG.TEACHING_HG]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<SSHG> KGCKEY_SSHG_TEACHING_HG
        {
            get
            {
                if (Cache_KGCKEY_SSHG_TEACHING_HG == null &&
                    !Context.SSHG.TryFindByTEACHING_HG(KGCKEY, out Cache_KGCKEY_SSHG_TEACHING_HG))
                {
                    Cache_KGCKEY_SSHG_TEACHING_HG = new List<SSHG>().AsReadOnly();
                }

                return Cache_KGCKEY_SSHG_TEACHING_HG;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGC.KGCKEY]-&gt;[ST.HOME_GROUP]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<ST> KGCKEY_ST_HOME_GROUP
        {
            get
            {
                if (Cache_KGCKEY_ST_HOME_GROUP == null &&
                    !Context.ST.TryFindByHOME_GROUP(KGCKEY, out Cache_KGCKEY_ST_HOME_GROUP))
                {
                    Cache_KGCKEY_ST_HOME_GROUP = new List<ST>().AsReadOnly();
                }

                return Cache_KGCKEY_ST_HOME_GROUP;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGC.KGCKEY]-&gt;[ST.NEXT_HG]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<ST> KGCKEY_ST_NEXT_HG
        {
            get
            {
                if (Cache_KGCKEY_ST_NEXT_HG == null &&
                    !Context.ST.TryFindByNEXT_HG(KGCKEY, out Cache_KGCKEY_ST_NEXT_HG))
                {
                    Cache_KGCKEY_ST_NEXT_HG = new List<ST>().AsReadOnly();
                }

                return Cache_KGCKEY_ST_NEXT_HG;
            }
        }

        /// <summary>
        /// ST_TFR (ST Transfer) related entities by [KGC.KGCKEY]-&gt;[ST_TFR.HOME_GROUP_NEW]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<ST_TFR> KGCKEY_ST_TFR_HOME_GROUP_NEW
        {
            get
            {
                if (Cache_KGCKEY_ST_TFR_HOME_GROUP_NEW == null &&
                    !Context.ST_TFR.TryFindByHOME_GROUP_NEW(KGCKEY, out Cache_KGCKEY_ST_TFR_HOME_GROUP_NEW))
                {
                    Cache_KGCKEY_ST_TFR_HOME_GROUP_NEW = new List<ST_TFR>().AsReadOnly();
                }

                return Cache_KGCKEY_ST_TFR_HOME_GROUP_NEW;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [KGC.KGCKEY]-&gt;[STRE.ST_HOME_GROUP]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<STRE> KGCKEY_STRE_ST_HOME_GROUP
        {
            get
            {
                if (Cache_KGCKEY_STRE_ST_HOME_GROUP == null &&
                    !Context.STRE.TryFindByST_HOME_GROUP(KGCKEY, out Cache_KGCKEY_STRE_ST_HOME_GROUP))
                {
                    Cache_KGCKEY_STRE_ST_HOME_GROUP = new List<STRE>().AsReadOnly();
                }

                return Cache_KGCKEY_STRE_ST_HOME_GROUP;
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [KGC.KGCKEY]-&gt;[TE.START_FORM]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<TE> KGCKEY_TE_START_FORM
        {
            get
            {
                if (Cache_KGCKEY_TE_START_FORM == null &&
                    !Context.TE.TryFindBySTART_FORM(KGCKEY, out Cache_KGCKEY_TE_START_FORM))
                {
                    Cache_KGCKEY_TE_START_FORM = new List<TE>().AsReadOnly();
                }

                return Cache_KGCKEY_TE_START_FORM;
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [KGC.KGCKEY]-&gt;[TE.END_FORM]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<TE> KGCKEY_TE_END_FORM
        {
            get
            {
                if (Cache_KGCKEY_TE_END_FORM == null &&
                    !Context.TE.TryFindByEND_FORM(KGCKEY, out Cache_KGCKEY_TE_END_FORM))
                {
                    Cache_KGCKEY_TE_END_FORM = new List<TE>().AsReadOnly();
                }

                return Cache_KGCKEY_TE_END_FORM;
            }
        }

        /// <summary>
        /// TXHG (Home Group Daily Attendance Records) related entities by [KGC.KGCKEY]-&gt;[TXHG.HOME_GROUP]
        /// (Was FORM) Home Group code
        /// </summary>
        public IReadOnlyList<TXHG> KGCKEY_TXHG_HOME_GROUP
        {
            get
            {
                if (Cache_KGCKEY_TXHG_HOME_GROUP == null &&
                    !Context.TXHG.TryFindByHOME_GROUP(KGCKEY, out Cache_KGCKEY_TXHG_HOME_GROUP))
                {
                    Cache_KGCKEY_TXHG_HOME_GROUP = new List<TXHG>().AsReadOnly();
                }

                return Cache_KGCKEY_TXHG_HOME_GROUP;
            }
        }

        #endregion

    }
}
