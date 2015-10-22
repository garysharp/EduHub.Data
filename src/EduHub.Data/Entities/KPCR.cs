using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Relationship
    /// </summary>
    public partial class KPCR : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Contact relationship Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KPCRKEY { get; internal set; }
        /// <summary>
        /// Contact Relation description
        /// 
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

#region Navigation Properties

        /// <summary>
        /// KPCL (Contact Links) related entities by [KPCL.CONTACT_TYPE]-&gt;[KPCR.KPCRKEY]
        /// </summary>
        public IReadOnlyList<KPCL> KPCL_CONTACT_TYPE
        {
            get
            {
                return Context.KPCR.FindKPCLByCONTACT_TYPE(KPCRKEY);
            }
        }
#endregion
    }
}
