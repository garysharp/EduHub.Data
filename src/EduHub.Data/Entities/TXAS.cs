using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Actual Sessions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TXAS : EduHubEntity
    {

        #region Navigation Property Cache

        private SU Cache_SUBJECT_SU;
        private SF Cache_TEACHER_SF;
        private SM Cache_LOCATION_SM;
        private SCL Cache_SCL_LINK_SCL;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SXAS> Cache_TID_SXAS_TXAS_ID;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// TID in corresponding THTQ record
        /// </summary>
        public int? THTQ_TID { get; internal set; }

        /// <summary>
        /// Actual instance of a class / session
        /// [Uppercase Alphanumeric (9)]
        /// </summary>
        public string CLASS_SESSION { get; internal set; }

        /// <summary>
        /// Subject for this session
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT { get; internal set; }

        /// <summary>
        /// Class for this session
        /// </summary>
        public short? CLASS { get; internal set; }

        /// <summary>
        /// Staff code of teacher for this session
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }

        /// <summary>
        /// Room code of room for this session
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string LOCATION { get; internal set; }

        /// <summary>
        /// Period number within the day
        /// </summary>
        public short? PERIOD_NO { get; internal set; }

        /// <summary>
        /// Day number in the current timetable cycle
        /// </summary>
        public short? DAY_NO { get; internal set; }

        /// <summary>
        /// Date of this session
        /// </summary>
        public DateTime? SESSION_DATE { get; internal set; }

        /// <summary>
        /// Actual Period Description from TH
        /// [Alphanumeric (10)]
        /// </summary>
        public string PERIOD_DESC { get; internal set; }

        /// <summary>
        /// Session start time (hh:mm)
        /// </summary>
        public short? START_TIME { get; internal set; }

        /// <summary>
        /// Session finish time (hh:mm)
        /// </summary>
        public short? FINISH_TIME { get; internal set; }

        /// <summary>
        /// Has this roll been marked? (Y/N) Prompted when form closed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ROLL_MARKED { get; internal set; }

        /// <summary>
        /// Class code in SCL
        /// [Uppercase Alphanumeric (17)]
        /// </summary>
        public string SCL_LINK { get; internal set; }

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
        /// SU (Subjects) related entity by [TXAS.SUBJECT]-&gt;[SU.SUKEY]
        /// Subject for this session
        /// </summary>
        public SU SUBJECT_SU
        {
            get
            {
                if (SUBJECT == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_SU == null)
                {
                    Cache_SUBJECT_SU = Context.SU.FindBySUKEY(SUBJECT);
                }

                return Cache_SUBJECT_SU;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [TXAS.TEACHER]-&gt;[SF.SFKEY]
        /// Staff code of teacher for this session
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
        /// SM (Rooms) related entity by [TXAS.LOCATION]-&gt;[SM.ROOM]
        /// Room code of room for this session
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
        /// SCL (Subject Classes) related entity by [TXAS.SCL_LINK]-&gt;[SCL.SCLKEY]
        /// Class code in SCL
        /// </summary>
        public SCL SCL_LINK_SCL
        {
            get
            {
                if (SCL_LINK == null)
                {
                    return null;
                }
                if (Cache_SCL_LINK_SCL == null)
                {
                    Cache_SCL_LINK_SCL = Context.SCL.FindBySCLKEY(SCL_LINK);
                }

                return Cache_SCL_LINK_SCL;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SXAS (Student Scheduled Sessions) related entities by [TXAS.TID]-&gt;[SXAS.TXAS_ID]
        /// Transaction ID (internal)
        /// </summary>
        public IReadOnlyList<SXAS> TID_SXAS_TXAS_ID
        {
            get
            {
                if (Cache_TID_SXAS_TXAS_ID == null &&
                    !Context.SXAS.TryFindByTXAS_ID(TID, out Cache_TID_SXAS_TXAS_ID))
                {
                    Cache_TID_SXAS_TXAS_ID = new List<SXAS>().AsReadOnly();
                }

                return Cache_TID_SXAS_TXAS_ID;
            }
        }

        #endregion

    }
}
