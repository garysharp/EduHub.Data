using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contact Links
    /// </summary>
    public class KPCL_Entity : EntityBase
    {
#region Navigation Property Cache
        private KPC_Entity _CONTACT_KPC;
        private KPCR_Entity _CONTACT_TYPE_KPCR;
#endregion

#region Field Properties
        /// <summary>
        /// Key [Integer (32bit signed): l]
        /// </summary>
        public int KPCLKEY { get; internal set; }
        /// <summary>
        /// PE Link [Uppercase Alphanumeric: u10]
        /// </summary>
        public string LINK { get; internal set; }
        /// <summary>
        /// Link type (eg:PE,DH) [Uppercase Alphanumeric: u3]
        /// </summary>
        public string SOURCE { get; internal set; }
        /// <summary>
        /// Link code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CONTACT { get; internal set; }
        /// <summary>
        /// Contact description eg:Parents, Manager [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CONTACT_TYPE { get; internal set; }
        /// <summary>
        /// Order of contact
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CONTACT_PREFERENCE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CONTACT] => [KPC_Entity].[KPCKEY]
        /// Link code
        /// </summary>
        public KPC_Entity CONTACT_KPC {
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
        /// Navigation property for [CONTACT_TYPE] => [KPCR_Entity].[KPCRKEY]
        /// Contact description eg:Parents, Manager
        /// </summary>
        public KPCR_Entity CONTACT_TYPE_KPCR {
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
