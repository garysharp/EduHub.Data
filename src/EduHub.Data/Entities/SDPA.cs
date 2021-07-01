using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Actions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SDPA : EduHubEntity
    {

        #region Navigation Property Cache

        private SDP Cache_SDP_STUDENT_SDP;
        private SF Cache_TAKEN_BY_SF;
        private KAM Cache_ACTION_TAKEN_KAM;

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
        /// Sequence no
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Number of the relevant Incident Instigator record
        /// </summary>
        public int SDP_STUDENT { get; internal set; }

        /// <summary>
        /// Staff code of staff member responsible for this disciplinary action
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TAKEN_BY { get; internal set; }

        /// <summary>
        /// Code identifying type of disciplinary action
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string ACTION_TAKEN { get; internal set; }

        /// <summary>
        /// Details of any disciplinary action
        /// [Memo]
        /// </summary>
        public string OTHER_ACTION { get; internal set; }

        /// <summary>
        /// Did the student comply with the disciplinary action? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string COMPLIED { get; internal set; }

        /// <summary>
        /// Have the student's parent(s) been informed? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PARENT_INFORMED { get; internal set; }

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
        /// SDP (Incident Instigators) related entity by [SDPA.SDP_STUDENT]-&gt;[SDP.SDPKEY]
        /// Number of the relevant Incident Instigator record
        /// </summary>
        public SDP SDP_STUDENT_SDP
        {
            get
            {
                if (Cache_SDP_STUDENT_SDP == null)
                {
                    Cache_SDP_STUDENT_SDP = Context.SDP.FindBySDPKEY(SDP_STUDENT);
                }

                return Cache_SDP_STUDENT_SDP;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SDPA.TAKEN_BY]-&gt;[SF.SFKEY]
        /// Staff code of staff member responsible for this disciplinary action
        /// </summary>
        public SF TAKEN_BY_SF
        {
            get
            {
                if (TAKEN_BY == null)
                {
                    return null;
                }
                if (Cache_TAKEN_BY_SF == null)
                {
                    Cache_TAKEN_BY_SF = Context.SF.FindBySFKEY(TAKEN_BY);
                }

                return Cache_TAKEN_BY_SF;
            }
        }

        /// <summary>
        /// KAM (Standard Disciplinary Actions) related entity by [SDPA.ACTION_TAKEN]-&gt;[KAM.KAMKEY]
        /// Code identifying type of disciplinary action
        /// </summary>
        public KAM ACTION_TAKEN_KAM
        {
            get
            {
                if (ACTION_TAKEN == null)
                {
                    return null;
                }
                if (Cache_ACTION_TAKEN_KAM == null)
                {
                    Cache_ACTION_TAKEN_KAM = Context.KAM.FindByKAMKEY(ACTION_TAKEN);
                }

                return Cache_ACTION_TAKEN_KAM;
            }
        }

        #endregion

    }
}
