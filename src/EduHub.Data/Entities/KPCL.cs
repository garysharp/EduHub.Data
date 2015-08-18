using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Links
    /// </summary>
    public class KPCL : EntityBase
    {
#region Navigation Property Cache
        private KPC _CONTACT_KPC;
        private KPCR _CONTACT_TYPE_KPCR;
#endregion

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
        /// 
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
        /// Navigation property for [CONTACT] => [KPC].[KPCKEY]
        /// Link code
        /// </summary>
        public KPC CONTACT_KPC {
            get
            {
                if (CONTACT != null)
                {
                    if (_CONTACT_KPC == null)
                    {
                        _CONTACT_KPC = Context.KPC.FindByKPCKEY(CONTACT);
                    }
                    return _CONTACT_KPC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [CONTACT_TYPE] => [KPCR].[KPCRKEY]
        /// Contact description eg:Parents, Manager
        /// </summary>
        public KPCR CONTACT_TYPE_KPCR {
            get
            {
                if (CONTACT_TYPE != null)
                {
                    if (_CONTACT_TYPE_KPCR == null)
                    {
                        _CONTACT_TYPE_KPCR = Context.KPCR.FindByKPCRKEY(CONTACT_TYPE);
                    }
                    return _CONTACT_TYPE_KPCR;
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
