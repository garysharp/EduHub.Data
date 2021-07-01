using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Links
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCL : EduHubEntity
    {

        #region Navigation Property Cache

        private KPC Cache_CONTACT_KPC;
        private KPCR Cache_CONTACT_TYPE_KPCR;

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
        public int KPCLKEY { get; internal set; }

        /// <summary>
        /// PE Link
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string LINK { get; internal set; }

        /// <summary>
        /// Link type (eg:PE,DH)
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string SOURCE { get; internal set; }

        /// <summary>
        /// Link code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CONTACT { get; internal set; }

        /// <summary>
        /// Contact description eg:Parents, Manager
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CONTACT_TYPE { get; internal set; }

        /// <summary>
        /// Order of contact
        /// </summary>
        public short? CONTACT_PREFERENCE { get; internal set; }

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
        /// KPC (Contacts) related entity by [KPCL.CONTACT]-&gt;[KPC.KPCKEY]
        /// Link code
        /// </summary>
        public KPC CONTACT_KPC
        {
            get
            {
                if (CONTACT == null)
                {
                    return null;
                }
                if (Cache_CONTACT_KPC == null)
                {
                    Cache_CONTACT_KPC = Context.KPC.FindByKPCKEY(CONTACT);
                }

                return Cache_CONTACT_KPC;
            }
        }

        /// <summary>
        /// KPCR (Contact Relationship) related entity by [KPCL.CONTACT_TYPE]-&gt;[KPCR.KPCRKEY]
        /// Contact description eg:Parents, Manager
        /// </summary>
        public KPCR CONTACT_TYPE_KPCR
        {
            get
            {
                if (CONTACT_TYPE == null)
                {
                    return null;
                }
                if (Cache_CONTACT_TYPE_KPCR == null)
                {
                    Cache_CONTACT_TYPE_KPCR = Context.KPCR.FindByKPCRKEY(CONTACT_TYPE);
                }

                return Cache_CONTACT_TYPE_KPCR;
            }
        }

        #endregion

    }
}
