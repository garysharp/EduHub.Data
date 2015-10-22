using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups
    /// </summary>
    public partial class KGC : EntityBase
    {
#region Navigation Property Cache
        private SCI _CAMPUS_SCI;
        private SF _TEACHER_SF;
        private SF _TEACHER_B_SF;
        private SM _ROOM_SM;
        private KCY _MIN_AC_YR_KCY;
        private KCY _MAX_AC_YR_KCY;
        private KGC _NEXT_HG_KGC;
#endregion

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
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
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
                if (TEACHER != null)
                {
                    if (_TEACHER_SF == null)
                    {
                        _TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                    }
                    return _TEACHER_SF;
                }
                else
                {
                    return null;
                }
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
                if (TEACHER_B != null)
                {
                    if (_TEACHER_B_SF == null)
                    {
                        _TEACHER_B_SF = Context.SF.FindBySFKEY(TEACHER_B);
                    }
                    return _TEACHER_B_SF;
                }
                else
                {
                    return null;
                }
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
                if (ROOM != null)
                {
                    if (_ROOM_SM == null)
                    {
                        _ROOM_SM = Context.SM.FindByROOM(ROOM);
                    }
                    return _ROOM_SM;
                }
                else
                {
                    return null;
                }
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
                if (MIN_AC_YR != null)
                {
                    if (_MIN_AC_YR_KCY == null)
                    {
                        _MIN_AC_YR_KCY = Context.KCY.FindByKCYKEY(MIN_AC_YR);
                    }
                    return _MIN_AC_YR_KCY;
                }
                else
                {
                    return null;
                }
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
                if (MAX_AC_YR != null)
                {
                    if (_MAX_AC_YR_KCY == null)
                    {
                        _MAX_AC_YR_KCY = Context.KCY.FindByKCYKEY(MAX_AC_YR);
                    }
                    return _MAX_AC_YR_KCY;
                }
                else
                {
                    return null;
                }
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
                if (NEXT_HG != null)
                {
                    if (_NEXT_HG_KGC == null)
                    {
                        _NEXT_HG_KGC = Context.KGC.FindByKGCKEY(NEXT_HG);
                    }
                    return _NEXT_HG_KGC;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [KGC.NEXT_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<KGC> KGC_NEXT_HG
        {
            get
            {
                return Context.KGC.FindKGCByNEXT_HG(KGCKEY);
            }
        }

        /// <summary>
        /// KGCHI (Home Group History) related entities by [KGCHI.KGCKEY]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<KGCHI> KGCHI_KGCKEY
        {
            get
            {
                return Context.KGC.FindKGCHIByKGCKEY(KGCKEY);
            }
        }

        /// <summary>
        /// SGHG (Home Group Eligibility Criteria) related entities by [SGHG.KGCLINK]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<SGHG> SGHG_KGCLINK
        {
            get
            {
                return Context.KGC.FindSGHGByKGCLINK(KGCKEY);
            }
        }

        /// <summary>
        /// SS (Specialist Subjects) related entities by [SS.FROM_HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<SS> SS_FROM_HOMEGROUP
        {
            get
            {
                return Context.KGC.FindSSByFROM_HOMEGROUP(KGCKEY);
            }
        }

        /// <summary>
        /// SS (Specialist Subjects) related entities by [SS.TO_HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<SS> SS_TO_HOMEGROUP
        {
            get
            {
                return Context.KGC.FindSSByTO_HOMEGROUP(KGCKEY);
            }
        }

        /// <summary>
        /// SSHG (Specialist Subjects per Home Group) related entities by [SSHG.HOMEGROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<SSHG> SSHG_HOMEGROUP
        {
            get
            {
                return Context.KGC.FindSSHGByHOMEGROUP(KGCKEY);
            }
        }

        /// <summary>
        /// SSHG (Specialist Subjects per Home Group) related entities by [SSHG.TEACHING_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<SSHG> SSHG_TEACHING_HG
        {
            get
            {
                return Context.KGC.FindSSHGByTEACHING_HG(KGCKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_HOME_GROUP
        {
            get
            {
                return Context.KGC.FindSTByHOME_GROUP(KGCKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.NEXT_HG]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_NEXT_HG
        {
            get
            {
                return Context.KGC.FindSTByNEXT_HG(KGCKEY);
            }
        }

        /// <summary>
        /// ST_TFR (ST Transfer) related entities by [ST_TFR.HOME_GROUP_NEW]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<ST_TFR> ST_TFR_HOME_GROUP_NEW
        {
            get
            {
                return Context.KGC.FindST_TFRByHOME_GROUP_NEW(KGCKEY);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.ST_HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<STRE> STRE_ST_HOME_GROUP
        {
            get
            {
                return Context.KGC.FindSTREByST_HOME_GROUP(KGCKEY);
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [TE.START_FORM]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<TE> TE_START_FORM
        {
            get
            {
                return Context.KGC.FindTEBySTART_FORM(KGCKEY);
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [TE.END_FORM]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<TE> TE_END_FORM
        {
            get
            {
                return Context.KGC.FindTEByEND_FORM(KGCKEY);
            }
        }

        /// <summary>
        /// TXHG (Home Group Daily Attendance Records) related entities by [TXHG.HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// </summary>
        public IReadOnlyList<TXHG> TXHG_HOME_GROUP
        {
            get
            {
                return Context.KGC.FindTXHGByHOME_GROUP(KGCKEY);
            }
        }
#endregion
    }
}
