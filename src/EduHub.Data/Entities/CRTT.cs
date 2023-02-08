#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Trade Types
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRTT : EduHubEntity
    {

        #region Navigation Property Cache

        private CR Cache_CRKEY_CR;
#if !EduHubScoped
        private KTT Cache_TRADE_TYPE_KTT;
#endif
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
        /// System transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Creditor key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CRKEY { get; internal set; }

        /// <summary>
        /// Trade type key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRADE_TYPE { get; internal set; }

        /// <summary>
        /// Staff member adding record
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STAFF { get; internal set; }

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
        /// CR (Accounts Payable) related entity by [CRTT.CRKEY]-&gt;[CR.CRKEY]
        /// Creditor key
        /// </summary>
        public CR CRKEY_CR
        {
            get
            {
                if (Cache_CRKEY_CR == null)
                {
                    Cache_CRKEY_CR = Context.CR.FindByCRKEY(CRKEY);
                }

                return Cache_CRKEY_CR;
            }
        }

#if !EduHubScoped
        /// <summary>
        /// KTT (Trade Type) related entity by [CRTT.TRADE_TYPE]-&gt;[KTT.KTTKEY]
        /// Trade type key
        /// </summary>
        public KTT TRADE_TYPE_KTT
        {
            get
            {
                if (TRADE_TYPE == null)
                {
                    return null;
                }
                if (Cache_TRADE_TYPE_KTT == null)
                {
                    Cache_TRADE_TYPE_KTT = Context.KTT.FindByKTTKEY(TRADE_TYPE);
                }

                return Cache_TRADE_TYPE_KTT;
            }
        }

#endif
        /// <summary>
        /// SF (Staff) related entity by [CRTT.STAFF]-&gt;[SF.SFKEY]
        /// Staff member adding record
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
#endif
