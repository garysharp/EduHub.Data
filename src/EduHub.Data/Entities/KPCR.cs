#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Relationship
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCR : EduHubEntity
    {

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<KPCL> Cache_KPCRKEY_KPCL_CONTACT_TYPE;
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
        /// Contact relationship Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCRKEY { get; internal set; }

        /// <summary>
        /// Contact Relation description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

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

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// KPCL (Contact Links) related entities by [KPCR.KPCRKEY]-&gt;[KPCL.CONTACT_TYPE]
        /// Contact relationship Key
        /// </summary>
        public IReadOnlyList<KPCL> KPCRKEY_KPCL_CONTACT_TYPE
        {
            get
            {
                if (Cache_KPCRKEY_KPCL_CONTACT_TYPE == null &&
                    !Context.KPCL.TryFindByCONTACT_TYPE(KPCRKEY, out Cache_KPCRKEY_KPCL_CONTACT_TYPE))
                {
                    Cache_KPCRKEY_KPCL_CONTACT_TYPE = new List<KPCL>().AsReadOnly();
                }

                return Cache_KPCRKEY_KPCL_CONTACT_TYPE;
            }
        }

#endif
        #endregion

    }
}
#endif
