using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Medication Doses
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMCD : EduHubEntity
    {

        #region Navigation Property Cache

        private SMC Cache_SMCDKEY_SMC;
        private SF Cache_STAFF_SF;

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
        /// Medical condition ID
        /// </summary>
        public int SMCDKEY { get; internal set; }

        /// <summary>
        /// Staff code of staff member who administered dosage (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF { get; internal set; }

        /// <summary>
        /// Date administered
        /// </summary>
        public DateTime? ADMIN_DATE { get; internal set; }

        /// <summary>
        /// Time administered
        /// </summary>
        public short? ADMIN_TIME { get; internal set; }

        /// <summary>
        /// Dose administered
        /// [Alphanumeric (30)]
        /// </summary>
        public string DOSE { get; internal set; }

        /// <summary>
        /// Person who administered dosage (if not staff)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADMIN_BY_OTHER { get; internal set; }

        /// <summary>
        /// Ad hoc notes
        /// [Memo]
        /// </summary>
        public string ADMIN_NOTES { get; internal set; }

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
        /// SMC (Student Medical Conditions) related entity by [SMCD.SMCDKEY]-&gt;[SMC.SMCKEY]
        /// Medical condition ID
        /// </summary>
        public SMC SMCDKEY_SMC
        {
            get
            {
                if (Cache_SMCDKEY_SMC == null)
                {
                    Cache_SMCDKEY_SMC = Context.SMC.FindBySMCKEY(SMCDKEY);
                }

                return Cache_SMCDKEY_SMC;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SMCD.STAFF]-&gt;[SF.SFKEY]
        /// Staff code of staff member who administered dosage (if any)
        /// </summary>
        public SF STAFF_SF
        {
            get
            {
                if (STAFF == null)
                {
                    return null;
                }
                if (Cache_STAFF_SF == null)
                {
                    Cache_STAFF_SF = Context.SF.FindBySFKEY(STAFF);
                }

                return Cache_STAFF_SF;
            }
        }

        #endregion

    }
}
