using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SM : EntityBase
    {

        #region Navigation Property Cache

        private KSF Cache_FACULTY_KSF;
        private SCI Cache_CAMPUS_SCI;
        private SF Cache_STAFF_CODE_SF;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<KGC> Cache_ROOM_KGC_ROOM;
        private IReadOnlyList<SAD> Cache_ROOM_SAD_ROOM;
        private IReadOnlyList<SCAM> Cache_ROOM_SCAM_MEETING_ROOM;
        private IReadOnlyList<SCL> Cache_ROOM_SCL_ROOM01;
        private IReadOnlyList<SCL> Cache_ROOM_SCL_ROOM02;
        private IReadOnlyList<SF> Cache_ROOM_SF_ROOM;
        private IReadOnlyList<SF> Cache_ROOM_SF_OTHER_LOCATION;
        private IReadOnlyList<SGM> Cache_ROOM_SGM_MEETING_ROOM;
        private IReadOnlyList<SMAQ> Cache_ROOM_SMAQ_SMAQKEY;
        private IReadOnlyList<SMAV> Cache_ROOM_SMAV_ROOM;
        private IReadOnlyList<SMGROUP> Cache_ROOM_SMGROUP_GROUPKEY;
        private IReadOnlyList<SMGROUP> Cache_ROOM_SMGROUP_ROOM;
        private IReadOnlyList<TCTB> Cache_ROOM_TCTB_ROOM;
        private IReadOnlyList<TCTQ> Cache_ROOM_TCTQ_R1ROOM;
        private IReadOnlyList<TCTQ> Cache_ROOM_TCTQ_R2ROOM;
        private IReadOnlyList<TCTQ> Cache_ROOM_TCTQ_EXTRA_ROOM;
        private IReadOnlyList<TCTR> Cache_ROOM_TCTR_ROOM;
        private IReadOnlyList<TE> Cache_ROOM_TE_LOCATION;
        private IReadOnlyList<TETE> Cache_ROOM_TETE_LOCATION;
        private IReadOnlyList<THTQ> Cache_ROOM_THTQ_R1ROOM;
        private IReadOnlyList<THTQ> Cache_ROOM_THTQ_R2ROOM;
        private IReadOnlyList<THTQ> Cache_ROOM_THTQ_EXTRA_ROOM;
        private IReadOnlyList<TTEF> Cache_ROOM_TTEF_ROOM;
        private IReadOnlyList<TTEX> Cache_ROOM_TTEX_EXAM_ROOM;
        private IReadOnlyList<TTTG> Cache_ROOM_TTTG_R1ROOM;
        private IReadOnlyList<TTTG> Cache_ROOM_TTTG_R2ROOM;
        private IReadOnlyList<TXAS> Cache_ROOM_TXAS_LOCATION;

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
        /// &lt;No documentation available&gt;
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
                if (FACULTY == null)
                {
                    return null;
                }
                if (Cache_FACULTY_KSF == null)
                {
                    Cache_FACULTY_KSF = Context.KSF.FindByKSFKEY(FACULTY);
                }

                return Cache_FACULTY_KSF;
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
        /// SF (Staff) related entity by [SM.STAFF_CODE]-&gt;[SF.SFKEY]
        /// Code of the staff member responsible for this room (V) (NRM)
        /// </summary>
        public SF STAFF_CODE_SF
        {
            get
            {
                if (STAFF_CODE == null)
                {
                    return null;
                }
                if (Cache_STAFF_CODE_SF == null)
                {
                    Cache_STAFF_CODE_SF = Context.SF.FindBySFKEY(STAFF_CODE);
                }

                return Cache_STAFF_CODE_SF;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// KGC (Home Groups) related entities by [SM.ROOM]-&gt;[KGC.ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<KGC> ROOM_KGC_ROOM
        {
            get
            {
                if (Cache_ROOM_KGC_ROOM == null &&
                    !Context.KGC.TryFindByROOM(ROOM, out Cache_ROOM_KGC_ROOM))
                {
                    Cache_ROOM_KGC_ROOM = new List<KGC>().AsReadOnly();
                }

                return Cache_ROOM_KGC_ROOM;
            }
        }

        /// <summary>
        /// SAD (Accidents) related entities by [SM.ROOM]-&gt;[SAD.ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<SAD> ROOM_SAD_ROOM
        {
            get
            {
                if (Cache_ROOM_SAD_ROOM == null &&
                    !Context.SAD.TryFindByROOM(ROOM, out Cache_ROOM_SAD_ROOM))
                {
                    Cache_ROOM_SAD_ROOM = new List<SAD>().AsReadOnly();
                }

                return Cache_ROOM_SAD_ROOM;
            }
        }

        /// <summary>
        /// SCAM (School Association Meetings) related entities by [SM.ROOM]-&gt;[SCAM.MEETING_ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<SCAM> ROOM_SCAM_MEETING_ROOM
        {
            get
            {
                if (Cache_ROOM_SCAM_MEETING_ROOM == null &&
                    !Context.SCAM.TryFindByMEETING_ROOM(ROOM, out Cache_ROOM_SCAM_MEETING_ROOM))
                {
                    Cache_ROOM_SCAM_MEETING_ROOM = new List<SCAM>().AsReadOnly();
                }

                return Cache_ROOM_SCAM_MEETING_ROOM;
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SM.ROOM]-&gt;[SCL.ROOM01]
        /// Room code
        /// </summary>
        public IReadOnlyList<SCL> ROOM_SCL_ROOM01
        {
            get
            {
                if (Cache_ROOM_SCL_ROOM01 == null &&
                    !Context.SCL.TryFindByROOM01(ROOM, out Cache_ROOM_SCL_ROOM01))
                {
                    Cache_ROOM_SCL_ROOM01 = new List<SCL>().AsReadOnly();
                }

                return Cache_ROOM_SCL_ROOM01;
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [SM.ROOM]-&gt;[SCL.ROOM02]
        /// Room code
        /// </summary>
        public IReadOnlyList<SCL> ROOM_SCL_ROOM02
        {
            get
            {
                if (Cache_ROOM_SCL_ROOM02 == null &&
                    !Context.SCL.TryFindByROOM02(ROOM, out Cache_ROOM_SCL_ROOM02))
                {
                    Cache_ROOM_SCL_ROOM02 = new List<SCL>().AsReadOnly();
                }

                return Cache_ROOM_SCL_ROOM02;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SM.ROOM]-&gt;[SF.ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<SF> ROOM_SF_ROOM
        {
            get
            {
                if (Cache_ROOM_SF_ROOM == null &&
                    !Context.SF.TryFindByROOM(ROOM, out Cache_ROOM_SF_ROOM))
                {
                    Cache_ROOM_SF_ROOM = new List<SF>().AsReadOnly();
                }

                return Cache_ROOM_SF_ROOM;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SM.ROOM]-&gt;[SF.OTHER_LOCATION]
        /// Room code
        /// </summary>
        public IReadOnlyList<SF> ROOM_SF_OTHER_LOCATION
        {
            get
            {
                if (Cache_ROOM_SF_OTHER_LOCATION == null &&
                    !Context.SF.TryFindByOTHER_LOCATION(ROOM, out Cache_ROOM_SF_OTHER_LOCATION))
                {
                    Cache_ROOM_SF_OTHER_LOCATION = new List<SF>().AsReadOnly();
                }

                return Cache_ROOM_SF_OTHER_LOCATION;
            }
        }

        /// <summary>
        /// SGM (Special Group Meetings) related entities by [SM.ROOM]-&gt;[SGM.MEETING_ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<SGM> ROOM_SGM_MEETING_ROOM
        {
            get
            {
                if (Cache_ROOM_SGM_MEETING_ROOM == null &&
                    !Context.SGM.TryFindByMEETING_ROOM(ROOM, out Cache_ROOM_SGM_MEETING_ROOM))
                {
                    Cache_ROOM_SGM_MEETING_ROOM = new List<SGM>().AsReadOnly();
                }

                return Cache_ROOM_SGM_MEETING_ROOM;
            }
        }

        /// <summary>
        /// SMAQ (Room Availability in Quilt) related entities by [SM.ROOM]-&gt;[SMAQ.SMAQKEY]
        /// Room code
        /// </summary>
        public IReadOnlyList<SMAQ> ROOM_SMAQ_SMAQKEY
        {
            get
            {
                if (Cache_ROOM_SMAQ_SMAQKEY == null &&
                    !Context.SMAQ.TryFindBySMAQKEY(ROOM, out Cache_ROOM_SMAQ_SMAQKEY))
                {
                    Cache_ROOM_SMAQ_SMAQKEY = new List<SMAQ>().AsReadOnly();
                }

                return Cache_ROOM_SMAQ_SMAQKEY;
            }
        }

        /// <summary>
        /// SMAV (Room Availablity Extras) related entities by [SM.ROOM]-&gt;[SMAV.ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<SMAV> ROOM_SMAV_ROOM
        {
            get
            {
                if (Cache_ROOM_SMAV_ROOM == null &&
                    !Context.SMAV.TryFindByROOM(ROOM, out Cache_ROOM_SMAV_ROOM))
                {
                    Cache_ROOM_SMAV_ROOM = new List<SMAV>().AsReadOnly();
                }

                return Cache_ROOM_SMAV_ROOM;
            }
        }

        /// <summary>
        /// SMGROUP (Rooms group) related entities by [SM.ROOM]-&gt;[SMGROUP.GROUPKEY]
        /// Room code
        /// </summary>
        public IReadOnlyList<SMGROUP> ROOM_SMGROUP_GROUPKEY
        {
            get
            {
                if (Cache_ROOM_SMGROUP_GROUPKEY == null &&
                    !Context.SMGROUP.TryFindByGROUPKEY(ROOM, out Cache_ROOM_SMGROUP_GROUPKEY))
                {
                    Cache_ROOM_SMGROUP_GROUPKEY = new List<SMGROUP>().AsReadOnly();
                }

                return Cache_ROOM_SMGROUP_GROUPKEY;
            }
        }

        /// <summary>
        /// SMGROUP (Rooms group) related entities by [SM.ROOM]-&gt;[SMGROUP.ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<SMGROUP> ROOM_SMGROUP_ROOM
        {
            get
            {
                if (Cache_ROOM_SMGROUP_ROOM == null &&
                    !Context.SMGROUP.TryFindByROOM(ROOM, out Cache_ROOM_SMGROUP_ROOM))
                {
                    Cache_ROOM_SMGROUP_ROOM = new List<SMGROUP>().AsReadOnly();
                }

                return Cache_ROOM_SMGROUP_ROOM;
            }
        }

        /// <summary>
        /// TCTB (Teacher Absences) related entities by [SM.ROOM]-&gt;[TCTB.ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TCTB> ROOM_TCTB_ROOM
        {
            get
            {
                if (Cache_ROOM_TCTB_ROOM == null &&
                    !Context.TCTB.TryFindByROOM(ROOM, out Cache_ROOM_TCTB_ROOM))
                {
                    Cache_ROOM_TCTB_ROOM = new List<TCTB>().AsReadOnly();
                }

                return Cache_ROOM_TCTB_ROOM;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [SM.ROOM]-&gt;[TCTQ.R1ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TCTQ> ROOM_TCTQ_R1ROOM
        {
            get
            {
                if (Cache_ROOM_TCTQ_R1ROOM == null &&
                    !Context.TCTQ.TryFindByR1ROOM(ROOM, out Cache_ROOM_TCTQ_R1ROOM))
                {
                    Cache_ROOM_TCTQ_R1ROOM = new List<TCTQ>().AsReadOnly();
                }

                return Cache_ROOM_TCTQ_R1ROOM;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [SM.ROOM]-&gt;[TCTQ.R2ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TCTQ> ROOM_TCTQ_R2ROOM
        {
            get
            {
                if (Cache_ROOM_TCTQ_R2ROOM == null &&
                    !Context.TCTQ.TryFindByR2ROOM(ROOM, out Cache_ROOM_TCTQ_R2ROOM))
                {
                    Cache_ROOM_TCTQ_R2ROOM = new List<TCTQ>().AsReadOnly();
                }

                return Cache_ROOM_TCTQ_R2ROOM;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [SM.ROOM]-&gt;[TCTQ.EXTRA_ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TCTQ> ROOM_TCTQ_EXTRA_ROOM
        {
            get
            {
                if (Cache_ROOM_TCTQ_EXTRA_ROOM == null &&
                    !Context.TCTQ.TryFindByEXTRA_ROOM(ROOM, out Cache_ROOM_TCTQ_EXTRA_ROOM))
                {
                    Cache_ROOM_TCTQ_EXTRA_ROOM = new List<TCTQ>().AsReadOnly();
                }

                return Cache_ROOM_TCTQ_EXTRA_ROOM;
            }
        }

        /// <summary>
        /// TCTR (Teacher Replacements) related entities by [SM.ROOM]-&gt;[TCTR.ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TCTR> ROOM_TCTR_ROOM
        {
            get
            {
                if (Cache_ROOM_TCTR_ROOM == null &&
                    !Context.TCTR.TryFindByROOM(ROOM, out Cache_ROOM_TCTR_ROOM))
                {
                    Cache_ROOM_TCTR_ROOM = new List<TCTR>().AsReadOnly();
                }

                return Cache_ROOM_TCTR_ROOM;
            }
        }

        /// <summary>
        /// TE (Calendar Events) related entities by [SM.ROOM]-&gt;[TE.LOCATION]
        /// Room code
        /// </summary>
        public IReadOnlyList<TE> ROOM_TE_LOCATION
        {
            get
            {
                if (Cache_ROOM_TE_LOCATION == null &&
                    !Context.TE.TryFindByLOCATION(ROOM, out Cache_ROOM_TE_LOCATION))
                {
                    Cache_ROOM_TE_LOCATION = new List<TE>().AsReadOnly();
                }

                return Cache_ROOM_TE_LOCATION;
            }
        }

        /// <summary>
        /// TETE (Event Instances) related entities by [SM.ROOM]-&gt;[TETE.LOCATION]
        /// Room code
        /// </summary>
        public IReadOnlyList<TETE> ROOM_TETE_LOCATION
        {
            get
            {
                if (Cache_ROOM_TETE_LOCATION == null &&
                    !Context.TETE.TryFindByLOCATION(ROOM, out Cache_ROOM_TETE_LOCATION))
                {
                    Cache_ROOM_TETE_LOCATION = new List<TETE>().AsReadOnly();
                }

                return Cache_ROOM_TETE_LOCATION;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [SM.ROOM]-&gt;[THTQ.R1ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<THTQ> ROOM_THTQ_R1ROOM
        {
            get
            {
                if (Cache_ROOM_THTQ_R1ROOM == null &&
                    !Context.THTQ.TryFindByR1ROOM(ROOM, out Cache_ROOM_THTQ_R1ROOM))
                {
                    Cache_ROOM_THTQ_R1ROOM = new List<THTQ>().AsReadOnly();
                }

                return Cache_ROOM_THTQ_R1ROOM;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [SM.ROOM]-&gt;[THTQ.R2ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<THTQ> ROOM_THTQ_R2ROOM
        {
            get
            {
                if (Cache_ROOM_THTQ_R2ROOM == null &&
                    !Context.THTQ.TryFindByR2ROOM(ROOM, out Cache_ROOM_THTQ_R2ROOM))
                {
                    Cache_ROOM_THTQ_R2ROOM = new List<THTQ>().AsReadOnly();
                }

                return Cache_ROOM_THTQ_R2ROOM;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [SM.ROOM]-&gt;[THTQ.EXTRA_ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<THTQ> ROOM_THTQ_EXTRA_ROOM
        {
            get
            {
                if (Cache_ROOM_THTQ_EXTRA_ROOM == null &&
                    !Context.THTQ.TryFindByEXTRA_ROOM(ROOM, out Cache_ROOM_THTQ_EXTRA_ROOM))
                {
                    Cache_ROOM_THTQ_EXTRA_ROOM = new List<THTQ>().AsReadOnly();
                }

                return Cache_ROOM_THTQ_EXTRA_ROOM;
            }
        }

        /// <summary>
        /// TTEF (Exam Staff) related entities by [SM.ROOM]-&gt;[TTEF.ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TTEF> ROOM_TTEF_ROOM
        {
            get
            {
                if (Cache_ROOM_TTEF_ROOM == null &&
                    !Context.TTEF.TryFindByROOM(ROOM, out Cache_ROOM_TTEF_ROOM))
                {
                    Cache_ROOM_TTEF_ROOM = new List<TTEF>().AsReadOnly();
                }

                return Cache_ROOM_TTEF_ROOM;
            }
        }

        /// <summary>
        /// TTEX (Exam Grid) related entities by [SM.ROOM]-&gt;[TTEX.EXAM_ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TTEX> ROOM_TTEX_EXAM_ROOM
        {
            get
            {
                if (Cache_ROOM_TTEX_EXAM_ROOM == null &&
                    !Context.TTEX.TryFindByEXAM_ROOM(ROOM, out Cache_ROOM_TTEX_EXAM_ROOM))
                {
                    Cache_ROOM_TTEX_EXAM_ROOM = new List<TTEX>().AsReadOnly();
                }

                return Cache_ROOM_TTEX_EXAM_ROOM;
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [SM.ROOM]-&gt;[TTTG.R1ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TTTG> ROOM_TTTG_R1ROOM
        {
            get
            {
                if (Cache_ROOM_TTTG_R1ROOM == null &&
                    !Context.TTTG.TryFindByR1ROOM(ROOM, out Cache_ROOM_TTTG_R1ROOM))
                {
                    Cache_ROOM_TTTG_R1ROOM = new List<TTTG>().AsReadOnly();
                }

                return Cache_ROOM_TTTG_R1ROOM;
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [SM.ROOM]-&gt;[TTTG.R2ROOM]
        /// Room code
        /// </summary>
        public IReadOnlyList<TTTG> ROOM_TTTG_R2ROOM
        {
            get
            {
                if (Cache_ROOM_TTTG_R2ROOM == null &&
                    !Context.TTTG.TryFindByR2ROOM(ROOM, out Cache_ROOM_TTTG_R2ROOM))
                {
                    Cache_ROOM_TTTG_R2ROOM = new List<TTTG>().AsReadOnly();
                }

                return Cache_ROOM_TTTG_R2ROOM;
            }
        }

        /// <summary>
        /// TXAS (Actual Sessions) related entities by [SM.ROOM]-&gt;[TXAS.LOCATION]
        /// Room code
        /// </summary>
        public IReadOnlyList<TXAS> ROOM_TXAS_LOCATION
        {
            get
            {
                if (Cache_ROOM_TXAS_LOCATION == null &&
                    !Context.TXAS.TryFindByLOCATION(ROOM, out Cache_ROOM_TXAS_LOCATION))
                {
                    Cache_ROOM_TXAS_LOCATION = new List<TXAS>().AsReadOnly();
                }

                return Cache_ROOM_TXAS_LOCATION;
            }
        }

        #endregion

    }
}
