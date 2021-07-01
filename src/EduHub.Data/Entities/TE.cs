using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Events
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TE : EduHubEntity
    {

        #region Navigation Property Cache

        private SCI Cache_CAMPUS_SCI;
        private SM Cache_LOCATION_SM;
        private TEC Cache_CATEGORY_TEC;
        private KCY Cache_START_YEAR_KCY;
        private KCY Cache_END_YEAR_KCY;
        private KGC Cache_START_FORM_KGC;
        private KGC Cache_END_FORM_KGC;
        private SU Cache_SUBJ_SU;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<TETE> Cache_TEKEY_TETE_TETEKEY;
        private IReadOnlyList<TETN> Cache_TEKEY_TETN_TETNKEY;

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
        /// &lt;No documentation available&gt;
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
        /// SM (Rooms) related entity by [TE.LOCATION]-&gt;[SM.ROOM]
        /// Location of the event
        /// </summary>
        public SM LOCATION_SM
        {
            get
            {
                if (LOCATION == null)
                {
                    return null;
                }
                if (Cache_LOCATION_SM == null)
                {
                    Cache_LOCATION_SM = Context.SM.FindByROOM(LOCATION);
                }

                return Cache_LOCATION_SM;
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
                if (CATEGORY == null)
                {
                    return null;
                }
                if (Cache_CATEGORY_TEC == null)
                {
                    Cache_CATEGORY_TEC = Context.TEC.FindByCATEGORY(CATEGORY);
                }

                return Cache_CATEGORY_TEC;
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
                if (START_YEAR == null)
                {
                    return null;
                }
                if (Cache_START_YEAR_KCY == null)
                {
                    Cache_START_YEAR_KCY = Context.KCY.FindByKCYKEY(START_YEAR);
                }

                return Cache_START_YEAR_KCY;
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
                if (END_YEAR == null)
                {
                    return null;
                }
                if (Cache_END_YEAR_KCY == null)
                {
                    Cache_END_YEAR_KCY = Context.KCY.FindByKCYKEY(END_YEAR);
                }

                return Cache_END_YEAR_KCY;
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
                if (START_FORM == null)
                {
                    return null;
                }
                if (Cache_START_FORM_KGC == null)
                {
                    Cache_START_FORM_KGC = Context.KGC.FindByKGCKEY(START_FORM);
                }

                return Cache_START_FORM_KGC;
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
                if (END_FORM == null)
                {
                    return null;
                }
                if (Cache_END_FORM_KGC == null)
                {
                    Cache_END_FORM_KGC = Context.KGC.FindByKGCKEY(END_FORM);
                }

                return Cache_END_FORM_KGC;
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
                if (SUBJ == null)
                {
                    return null;
                }
                if (Cache_SUBJ_SU == null)
                {
                    Cache_SUBJ_SU = Context.SU.FindBySUKEY(SUBJ);
                }

                return Cache_SUBJ_SU;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// TETE (Event Instances) related entities by [TE.TEKEY]-&gt;[TETE.TETEKEY]
        /// Key
        /// </summary>
        public IReadOnlyList<TETE> TEKEY_TETE_TETEKEY
        {
            get
            {
                if (Cache_TEKEY_TETE_TETEKEY == null &&
                    !Context.TETE.TryFindByTETEKEY(TEKEY, out Cache_TEKEY_TETE_TETEKEY))
                {
                    Cache_TEKEY_TETE_TETEKEY = new List<TETE>().AsReadOnly();
                }

                return Cache_TEKEY_TETE_TETEKEY;
            }
        }

        /// <summary>
        /// TETN (Event Attendees) related entities by [TE.TEKEY]-&gt;[TETN.TETNKEY]
        /// Key
        /// </summary>
        public IReadOnlyList<TETN> TEKEY_TETN_TETNKEY
        {
            get
            {
                if (Cache_TEKEY_TETN_TETNKEY == null &&
                    !Context.TETN.TryFindByTETNKEY(TEKEY, out Cache_TEKEY_TETN_TETNKEY))
                {
                    Cache_TEKEY_TETN_TETNKEY = new List<TETN>().AsReadOnly();
                }

                return Cache_TEKEY_TETN_TETNKEY;
            }
        }

        #endregion

    }
}
