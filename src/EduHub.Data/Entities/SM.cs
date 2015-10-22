using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms
    /// </summary>
    public partial class SM : EntityBase
    {
#region Navigation Property Cache
        private KSF _FACULTY_KSF;
        private SCI _CAMPUS_SCI;
        private SF _STAFF_CODE_SF;
#endregion

#region Field Properties
        /// <summary>
        /// Room code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Room name
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Maximum capacity
        /// </summary>
        public short? SEATING { get; internal set; }
        /// <summary>
        /// Description of room
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Is this room available for timetabled activities? R=available, otherwise not
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROOM_TYPE { get; internal set; }
        /// <summary>
        /// Code of the faculty responsible for this room
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FACULTY { get; internal set; }
        /// <summary>
        /// (V) (NRM) &lt;&lt; What exactly is this field for?
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string AREA_CODE { get; internal set; }
        /// <summary>
        /// ID of the campus on which this room is located
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Code of the staff member responsible for this room (V) (NRM)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF_CODE { get; internal set; }
        /// <summary>
        /// 
        /// [Memo]
        /// </summary>
        public string COMMENTA { get; internal set; }
        /// <summary>
        /// Type of board provided (blackboard, whiteboard, etc.)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string BOARD { get; internal set; }
        /// <summary>
        /// Does this room have blackout provision? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string BLACKOUT { get; internal set; }
        /// <summary>
        /// Normal load for this room
        /// </summary>
        public short? NORMAL_ALLOTMENT { get; internal set; }
        /// <summary>
        /// Flag indicating if this is a single room or a group of rooms
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GROUP_INDICATOR { get; internal set; }
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
        /// KSF (Faculties) related entity by [SM.FACULTY]-&gt;[KSF.KSFKEY]
        /// Code of the faculty responsible for this room
        /// </summary>
        public KSF FACULTY_KSF
        {
            get
            {
                if (FACULTY != null)
                {
                    if (_FACULTY_KSF == null)
                    {
                        _FACULTY_KSF = Context.KSF.FindByKSFKEY(FACULTY);
                    }
                    return _FACULTY_KSF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [SM.CAMPUS]-&gt;[SCI.SCIKEY]
        /// ID of the campus on which this room is located
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
        /// SF (Staff) related entity by [SM.STAFF_CODE]-&gt;[SF.SFKEY]
        /// Code of the staff member responsible for this room (V) (NRM)
        /// </summary>
        public SF STAFF_CODE_SF
        {
            get
            {
                if (STAFF_CODE != null)
                {
                    if (_STAFF_CODE_SF == null)
                    {
                        _STAFF_CODE_SF = Context.SF.FindBySFKEY(STAFF_CODE);
                    }
                    return _STAFF_CODE_SF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entities by [KGC.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<KGC> KGC_ROOM
        {
            get
            {
                return Context.SM.FindKGCByROOM(ROOM);
            }
        }

        /// <summary>
        /// SAD (Accidents) related entities by [SAD.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SAD> SAD_ROOM
        {
            get
            {
                return Context.SM.FindSADByROOM(ROOM);
            }
        }

        /// <summary>
        /// SCAM (School Association Meetings) related entities by [SCAM.MEETING_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SCAM> SCAM_MEETING_ROOM
        {
            get
            {
                return Context.SM.FindSCAMByMEETING_ROOM(ROOM);
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SCL.ROOM01]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SCL> SCL_ROOM01
        {
            get
            {
                return Context.SM.FindSCLByROOM01(ROOM);
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SCL.ROOM02]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SCL> SCL_ROOM02
        {
            get
            {
                return Context.SM.FindSCLByROOM02(ROOM);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SF> SF_ROOM
        {
            get
            {
                return Context.SM.FindSFByROOM(ROOM);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.OTHER_LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SF> SF_OTHER_LOCATION
        {
            get
            {
                return Context.SM.FindSFByOTHER_LOCATION(ROOM);
            }
        }

        /// <summary>
        /// SGM (Special Group Meetings) related entities by [SGM.MEETING_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SGM> SGM_MEETING_ROOM
        {
            get
            {
                return Context.SM.FindSGMByMEETING_ROOM(ROOM);
            }
        }

        /// <summary>
        /// SMAQ (Room Availability in Quilt) related entities by [SMAQ.SMAQKEY]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SMAQ> SMAQ_SMAQKEY
        {
            get
            {
                return Context.SM.FindSMAQBySMAQKEY(ROOM);
            }
        }

        /// <summary>
        /// SMAV (Room Availablity Extras) related entities by [SMAV.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SMAV> SMAV_ROOM
        {
            get
            {
                return Context.SM.FindSMAVByROOM(ROOM);
            }
        }

        /// <summary>
        /// SMGROUP (Rooms group) related entities by [SMGROUP.GROUPKEY]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SMGROUP> SMGROUP_GROUPKEY
        {
            get
            {
                return Context.SM.FindSMGROUPByGROUPKEY(ROOM);
            }
        }

        /// <summary>
        /// SMGROUP (Rooms group) related entities by [SMGROUP.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<SMGROUP> SMGROUP_ROOM
        {
            get
            {
                return Context.SM.FindSMGROUPByROOM(ROOM);
            }
        }

        /// <summary>
        /// TCTB (Teacher Absences) related entities by [TCTB.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TCTB> TCTB_ROOM
        {
            get
            {
                return Context.SM.FindTCTBByROOM(ROOM);
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TCTQ.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TCTQ> TCTQ_R1ROOM
        {
            get
            {
                return Context.SM.FindTCTQByR1ROOM(ROOM);
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TCTQ.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TCTQ> TCTQ_R2ROOM
        {
            get
            {
                return Context.SM.FindTCTQByR2ROOM(ROOM);
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TCTQ.EXTRA_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TCTQ> TCTQ_EXTRA_ROOM
        {
            get
            {
                return Context.SM.FindTCTQByEXTRA_ROOM(ROOM);
            }
        }

        /// <summary>
        /// TCTR (Teacher Replacements) related entities by [TCTR.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TCTR> TCTR_ROOM
        {
            get
            {
                return Context.SM.FindTCTRByROOM(ROOM);
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [TE.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TE> TE_LOCATION
        {
            get
            {
                return Context.SM.FindTEByLOCATION(ROOM);
            }
        }

        /// <summary>
        /// TETE (Event Instances) related entities by [TETE.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TETE> TETE_LOCATION
        {
            get
            {
                return Context.SM.FindTETEByLOCATION(ROOM);
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [THTQ.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<THTQ> THTQ_R1ROOM
        {
            get
            {
                return Context.SM.FindTHTQByR1ROOM(ROOM);
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [THTQ.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<THTQ> THTQ_R2ROOM
        {
            get
            {
                return Context.SM.FindTHTQByR2ROOM(ROOM);
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [THTQ.EXTRA_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<THTQ> THTQ_EXTRA_ROOM
        {
            get
            {
                return Context.SM.FindTHTQByEXTRA_ROOM(ROOM);
            }
        }

        /// <summary>
        /// TTEF (Exam Staff) related entities by [TTEF.ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TTEF> TTEF_ROOM
        {
            get
            {
                return Context.SM.FindTTEFByROOM(ROOM);
            }
        }

        /// <summary>
        /// TTEX (Exam Grid) related entities by [TTEX.EXAM_ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TTEX> TTEX_EXAM_ROOM
        {
            get
            {
                return Context.SM.FindTTEXByEXAM_ROOM(ROOM);
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [TTTG.R1ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TTTG> TTTG_R1ROOM
        {
            get
            {
                return Context.SM.FindTTTGByR1ROOM(ROOM);
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [TTTG.R2ROOM]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TTTG> TTTG_R2ROOM
        {
            get
            {
                return Context.SM.FindTTTGByR2ROOM(ROOM);
            }
        }

        /// <summary>
        /// TXAS (Actual Sessions) related entities by [TXAS.LOCATION]-&gt;[SM.ROOM]
        /// </summary>
        public IReadOnlyList<TXAS> TXAS_LOCATION
        {
            get
            {
                return Context.SM.FindTXASByLOCATION(ROOM);
            }
        }
#endregion
    }
}
