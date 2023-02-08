#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Flexible Learning Options
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STFLO : EduHubEntity
    {

        #region Navigation Property Cache

        private ST Cache_SKEY_ST;
#if !EduHubScoped
        private KFLO Cache_PROGRAM_KFLO;
#endif

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
        /// Student key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }

        /// <summary>
        /// From date
        /// </summary>
        public DateTime? FROM_DATE { get; internal set; }

        /// <summary>
        /// Flo Placement
        /// [Alphanumeric (50)]
        /// </summary>
        public string FLO { get; internal set; }

        /// <summary>
        /// Exit date
        /// </summary>
        public DateTime? EXIT_DATE { get; internal set; }

        /// <summary>
        /// Program from what school
        /// </summary>
        public int? PROGRAM { get; internal set; }

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
        /// ST (Students) related entity by [STFLO.SKEY]-&gt;[ST.STKEY]
        /// Student key
        /// </summary>
        public ST SKEY_ST
        {
            get
            {
                if (Cache_SKEY_ST == null)
                {
                    Cache_SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                }

                return Cache_SKEY_ST;
            }
        }

#if !EduHubScoped
        /// <summary>
        /// KFLO (FLO Placement information) related entity by [STFLO.PROGRAM]-&gt;[KFLO.KFLOKEY]
        /// Program from what school
        /// </summary>
        public KFLO PROGRAM_KFLO
        {
            get
            {
                if (PROGRAM == null)
                {
                    return null;
                }
                if (Cache_PROGRAM_KFLO == null)
                {
                    Cache_PROGRAM_KFLO = Context.KFLO.FindByKFLOKEY(PROGRAM.Value);
                }

                return Cache_PROGRAM_KFLO;
            }
        }

#endif
        #endregion

    }
}
#endif
