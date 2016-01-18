using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Sickbay Medication Administrations
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIM : EduHubEntity
    {

        #region Navigation Property Cache

        private SAI Cache_INVOLVEMENTID_SAI;
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
        /// Sequence no of accident involvement
        /// </summary>
        public int INVOLVEMENTID { get; internal set; }

        /// <summary>
        /// Medication administered
        /// [Alphanumeric (30)]
        /// </summary>
        public string MEDICATION { get; internal set; }

        /// <summary>
        /// Staff code of staff member administering medication (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF { get; internal set; }

        /// <summary>
        /// Name of person administering medication (if not staff member)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADMIN_BY_OTHER { get; internal set; }

        /// <summary>
        /// Time medication administered
        /// </summary>
        public short? ADMIN_TIME { get; internal set; }

        /// <summary>
        /// Dose administered
        /// [Alphanumeric (30)]
        /// </summary>
        public string DOSE { get; internal set; }

        /// <summary>
        /// Ad hoc notes, response to medication
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
        /// SAI (Accident Involvements/Sickbay Visits) related entity by [SAIM.INVOLVEMENTID]-&gt;[SAI.SAIKEY]
        /// Sequence no of accident involvement
        /// </summary>
        public SAI INVOLVEMENTID_SAI
        {
            get
            {
                if (Cache_INVOLVEMENTID_SAI == null)
                {
                    Cache_INVOLVEMENTID_SAI = Context.SAI.FindBySAIKEY(INVOLVEMENTID);
                }

                return Cache_INVOLVEMENTID_SAI;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SAIM.STAFF]-&gt;[SF.SFKEY]
        /// Staff code of staff member administering medication (if any)
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
