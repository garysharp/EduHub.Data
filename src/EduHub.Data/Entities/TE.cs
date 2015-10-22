using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Events
    /// </summary>
    public partial class TE : EntityBase
    {
#region Navigation Property Cache
        private SCI _CAMPUS_SCI;
        private SM _LOCATION_SM;
        private TEC _CATEGORY_TEC;
        private KCY _START_YEAR_KCY;
        private KCY _END_YEAR_KCY;
        private KGC _START_FORM_KGC;
        private KGC _END_FORM_KGC;
        private SU _SUBJ_SU;
#endregion

#region Field Properties
        /// <summary>
        /// Key
        /// </summary>
        public int TEKEY { get; internal set; }
        /// <summary>
        /// Event name
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Campus
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Extra comments
        /// [Memo]
        /// </summary>
        public string COMMENTS { get; internal set; }
        /// <summary>
        /// First date of event
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Last date of event
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Recurring event
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RECURRENCE { get; internal set; }
        /// <summary>
        /// eg nth Monday of month
        /// </summary>
        public short? RECUR_DAYS { get; internal set; }
        /// <summary>
        /// Start time of event
        /// </summary>
        public DateTime? TIME_FROM { get; internal set; }
        /// <summary>
        /// End time of event
        /// </summary>
        public DateTime? TIME_TO { get; internal set; }
        /// <summary>
        /// Person responible for the event
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CONVENOR { get; internal set; }
        /// <summary>
        /// Convenor table name
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string CONVENOR_TYPE { get; internal set; }
        /// <summary>
        /// Location of the event
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Group attending the event
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string EVENT_GROUP { get; internal set; }
        /// <summary>
        /// Category of event
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Display colour for the event
        /// </summary>
        public int? COLOUR { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string EVENT_CODE { get; internal set; }
        /// <summary>
        /// First Year for event
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string START_YEAR { get; internal set; }
        /// <summary>
        /// Last Year for event
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string END_YEAR { get; internal set; }
        /// <summary>
        /// First Form for event
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string START_FORM { get; internal set; }
        /// <summary>
        /// Last Form for event
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string END_FORM { get; internal set; }
        /// <summary>
        /// Subject involved in an event
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ { get; internal set; }
        /// <summary>
        /// First class number for this subject
        /// </summary>
        public short? START_CLASS_NUM { get; internal set; }
        /// <summary>
        /// Last class number for this subject
        /// </summary>
        public short? END_CLASS_NUM { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// SCI (School Information) related entity by [TE.CAMPUS]-&gt;[SCI.SCIKEY]
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
        /// SM (Rooms) related entity by [TE.LOCATION]-&gt;[SM.ROOM]
        /// Location of the event
        /// </summary>
        public SM LOCATION_SM
        {
            get
            {
                if (LOCATION != null)
                {
                    if (_LOCATION_SM == null)
                    {
                        _LOCATION_SM = Context.SM.FindByROOM(LOCATION);
                    }
                    return _LOCATION_SM;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// TEC (Event Categories) related entity by [TE.CATEGORY]-&gt;[TEC.CATEGORY]
        /// Category of event
        /// </summary>
        public TEC CATEGORY_TEC
        {
            get
            {
                if (CATEGORY != null)
                {
                    if (_CATEGORY_TEC == null)
                    {
                        _CATEGORY_TEC = Context.TEC.FindByCATEGORY(CATEGORY);
                    }
                    return _CATEGORY_TEC;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TE.START_YEAR]-&gt;[KCY.KCYKEY]
        /// First Year for event
        /// </summary>
        public KCY START_YEAR_KCY
        {
            get
            {
                if (START_YEAR != null)
                {
                    if (_START_YEAR_KCY == null)
                    {
                        _START_YEAR_KCY = Context.KCY.FindByKCYKEY(START_YEAR);
                    }
                    return _START_YEAR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TE.END_YEAR]-&gt;[KCY.KCYKEY]
        /// Last Year for event
        /// </summary>
        public KCY END_YEAR_KCY
        {
            get
            {
                if (END_YEAR != null)
                {
                    if (_END_YEAR_KCY == null)
                    {
                        _END_YEAR_KCY = Context.KCY.FindByKCYKEY(END_YEAR);
                    }
                    return _END_YEAR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entity by [TE.START_FORM]-&gt;[KGC.KGCKEY]
        /// First Form for event
        /// </summary>
        public KGC START_FORM_KGC
        {
            get
            {
                if (START_FORM != null)
                {
                    if (_START_FORM_KGC == null)
                    {
                        _START_FORM_KGC = Context.KGC.FindByKGCKEY(START_FORM);
                    }
                    return _START_FORM_KGC;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// KGC (Home Groups) related entity by [TE.END_FORM]-&gt;[KGC.KGCKEY]
        /// Last Form for event
        /// </summary>
        public KGC END_FORM_KGC
        {
            get
            {
                if (END_FORM != null)
                {
                    if (_END_FORM_KGC == null)
                    {
                        _END_FORM_KGC = Context.KGC.FindByKGCKEY(END_FORM);
                    }
                    return _END_FORM_KGC;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [TE.SUBJ]-&gt;[SU.SUKEY]
        /// Subject involved in an event
        /// </summary>
        public SU SUBJ_SU
        {
            get
            {
                if (SUBJ != null)
                {
                    if (_SUBJ_SU == null)
                    {
                        _SUBJ_SU = Context.SU.FindBySUKEY(SUBJ);
                    }
                    return _SUBJ_SU;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// TETE (Event Instances) related entities by [TETE.TETEKEY]-&gt;[TE.TEKEY]
        /// </summary>
        public IReadOnlyList<TETE> TETE_TETEKEY
        {
            get
            {
                return Context.TE.FindTETEByTETEKEY(TEKEY);
            }
        }

        /// <summary>
        /// TETN (Event Attendees) related entities by [TETN.TETNKEY]-&gt;[TE.TEKEY]
        /// </summary>
        public IReadOnlyList<TETN> TETN_TETNKEY
        {
            get
            {
                return Context.TE.FindTETNByTETNKEY(TEKEY);
            }
        }
#endregion
    }
}
