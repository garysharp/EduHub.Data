using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family Invoice Allocations
    /// </summary>
    public class STSB_Entity : EntityBase
    {
#region Navigation Property Cache
        private ST_Entity _SKEY_ST;
        private DF_Entity _FAMILY_DF;
        private SA_Entity _SPLIT_ITEM_SA;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SKEY { get; internal set; }
        /// <summary>
        /// Family key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FAMILY { get; internal set; }
        /// <summary>
        /// Percentage of transaction amount to split for family [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PERCENTAGE { get; internal set; }
        /// <summary>
        /// Item that the family pays [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SPLIT_ITEM { get; internal set; }
        /// <summary>
        /// only F - Fee code [Alphanumeric: a1]
        /// </summary>
        public string ITEM_TYPE { get; internal set; }
        /// <summary>
        /// Used to relate the subject code. Not used in CASES21.
        ///  [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SPLIT_ITEM_SU { get; internal set; }
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
        /// Navigation property for [SKEY] => [ST_Entity].[STKEY]
        /// Student key
        /// </summary>
        public ST_Entity SKEY_ST {
            get
            {
                if (SKEY != null)
                {
                    if (_SKEY_ST == null)
                    {
                        _SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                    }
                    return _SKEY_ST;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FAMILY] => [DF_Entity].[DFKEY]
        /// Family key
        /// </summary>
        public DF_Entity FAMILY_DF {
            get
            {
                if (FAMILY != null)
                {
                    if (_FAMILY_DF == null)
                    {
                        _FAMILY_DF = Context.DF.FindByDFKEY(FAMILY);
                    }
                    return _FAMILY_DF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SPLIT_ITEM] => [SA_Entity].[SAKEY]
        /// Item that the family pays
        /// </summary>
        public SA_Entity SPLIT_ITEM_SA {
            get
            {
                if (SPLIT_ITEM != null)
                {
                    if (_SPLIT_ITEM_SA == null)
                    {
                        _SPLIT_ITEM_SA = Context.SA.FindBySAKEY(SPLIT_ITEM);
                    }
                    return _SPLIT_ITEM_SA;
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
