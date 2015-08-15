using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Events
    /// </summary>
    public class TE_Entity : EntityBase
    {
#region Navigation Property Cache
        private SCI_Entity _CAMPUS_SCI;
        private SM_Entity _LOCATION_SM;
        private TEC_Entity _CATEGORY_TEC;
        private KCY_Entity _START_YEAR_KCY;
        private KCY_Entity _END_YEAR_KCY;
        private KGC_Entity _START_FORM_KGC;
        private KGC_Entity _END_FORM_KGC;
        private SU_Entity _SUBJ_SU;
#endregion

#region Field Properties
        /// <summary>
        /// Key [Integer (32bit signed): l]
        /// </summary>
        public int TEKEY { get; internal set; }
        /// <summary>
        /// Event name [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Extra comments [Memo: m]
        /// </summary>
        public string COMMENTS { get; internal set; }
        /// <summary>
        /// First date of event [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Last date of event [Date Time nullable: d]
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Recurring event [Uppercase Alphanumeric: u1]
        /// </summary>
        public string RECURRENCE { get; internal set; }
        /// <summary>
        /// eg nth Monday of month [Integer (16bit signed nullable): i]
        /// </summary>
        public short? RECUR_DAYS { get; internal set; }
        /// <summary>
        /// Start time of event [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_FROM { get; internal set; }
        /// <summary>
        /// End time of event [Date Time nullable: d]
        /// </summary>
        public DateTime? TIME_TO { get; internal set; }
        /// <summary>
        /// Person responible for the event [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CONVENOR { get; internal set; }
        /// <summary>
        /// Convenor table name [Uppercase Alphanumeric: u8]
        /// </summary>
        public string CONVENOR_TYPE { get; internal set; }
        /// <summary>
        /// Location of the event [Uppercase Alphanumeric: u4]
        /// </summary>
        public string LOCATION { get; internal set; }
        /// <summary>
        /// Group attending the event [Uppercase Alphanumeric: u12]
        /// </summary>
        public string EVENT_GROUP { get; internal set; }
        /// <summary>
        /// Category of event [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Display colour for the event [Integer (32bit signed nullable): l]
        /// </summary>
        public int? COLOUR { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u4]
        /// </summary>
        public string EVENT_CODE { get; internal set; }
        /// <summary>
        /// First Year for event [Uppercase Alphanumeric: u4]
        /// </summary>
        public string START_YEAR { get; internal set; }
        /// <summary>
        /// Last Year for event [Uppercase Alphanumeric: u4]
        /// </summary>
        public string END_YEAR { get; internal set; }
        /// <summary>
        /// First Form for event [Uppercase Alphanumeric: u3]
        /// </summary>
        public string START_FORM { get; internal set; }
        /// <summary>
        /// Last Form for event [Uppercase Alphanumeric: u3]
        /// </summary>
        public string END_FORM { get; internal set; }
        /// <summary>
        /// Subject involved in an event [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ { get; internal set; }
        /// <summary>
        /// First class number for this subject [Integer (16bit signed nullable): i]
        /// </summary>
        public short? START_CLASS_NUM { get; internal set; }
        /// <summary>
        /// Last class number for this subject [Integer (16bit signed nullable): i]
        /// </summary>
        public short? END_CLASS_NUM { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus
        /// </summary>
        public SCI_Entity CAMPUS_SCI {
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
        /// Navigation property for [LOCATION] => [SM_Entity].[ROOM]
        /// Location of the event
        /// </summary>
        public SM_Entity LOCATION_SM {
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
        /// Navigation property for [CATEGORY] => [TEC_Entity].[CATEGORY]
        /// Category of event
        /// </summary>
        public TEC_Entity CATEGORY_TEC {
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
        /// Navigation property for [START_YEAR] => [KCY_Entity].[KCYKEY]
        /// First Year for event
        /// </summary>
        public KCY_Entity START_YEAR_KCY {
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
        /// Navigation property for [END_YEAR] => [KCY_Entity].[KCYKEY]
        /// Last Year for event
        /// </summary>
        public KCY_Entity END_YEAR_KCY {
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
        /// Navigation property for [START_FORM] => [KGC_Entity].[KGCKEY]
        /// First Form for event
        /// </summary>
        public KGC_Entity START_FORM_KGC {
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
        /// Navigation property for [END_FORM] => [KGC_Entity].[KGCKEY]
        /// Last Form for event
        /// </summary>
        public KGC_Entity END_FORM_KGC {
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
        /// Navigation property for [SUBJ] => [SU_Entity].[SUKEY]
        /// Subject involved in an event
        /// </summary>
        public SU_Entity SUBJ_SU {
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
#endregion
    }
}
