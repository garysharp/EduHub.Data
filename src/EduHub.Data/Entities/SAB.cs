﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees - Billing Templates
    /// </summary>
    public class SAB : EntityBase
    {
#region Navigation Property Cache
        private SA _FEE_CODE_1ST_SA;
        private SA _FEE_CODE_2ND_SA;
        private SA _FEE_CODE_3RD_SA;
        private SA _FEE_CODE_4TH_SA;
        private SA _FEE_CODE_KG_SA;
#endregion

#region Field Properties
        /// <summary>
        /// Billing key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SABKEY { get; internal set; }
        /// <summary>
        /// Billing title
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Billing type: Student, Class, Family
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string BILL_TYPE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string FROM_CLASS { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TO_CLASS { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string FROM_YEAR { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TO_YEAR { get; internal set; }
        /// <summary>
        /// Non-overseas(N) or Overseas(O)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RES_STATUS { get; internal set; }
        /// <summary>
        /// Fee code for the 1st child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_1ST { get; internal set; }
        /// <summary>
        /// Fee code for the 2nd child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_2ND { get; internal set; }
        /// <summary>
        /// Fee code for the 3rd child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_3RD { get; internal set; }
        /// <summary>
        /// Fee code for the 4th child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_4TH { get; internal set; }
        /// <summary>
        /// Fee code for the Kindergarten child
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FEE_CODE_KG { get; internal set; }
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
        /// Navigation property for [FEE_CODE_1ST] => [SA].[SAKEY]
        /// Fee code for the 1st child
        /// </summary>
        public SA FEE_CODE_1ST_SA {
            get
            {
                if (FEE_CODE_1ST != null)
                {
                    if (_FEE_CODE_1ST_SA == null)
                    {
                        _FEE_CODE_1ST_SA = Context.SA.FindBySAKEY(FEE_CODE_1ST);
                    }
                    return _FEE_CODE_1ST_SA;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FEE_CODE_2ND] => [SA].[SAKEY]
        /// Fee code for the 2nd child
        /// </summary>
        public SA FEE_CODE_2ND_SA {
            get
            {
                if (FEE_CODE_2ND != null)
                {
                    if (_FEE_CODE_2ND_SA == null)
                    {
                        _FEE_CODE_2ND_SA = Context.SA.FindBySAKEY(FEE_CODE_2ND);
                    }
                    return _FEE_CODE_2ND_SA;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FEE_CODE_3RD] => [SA].[SAKEY]
        /// Fee code for the 3rd child
        /// </summary>
        public SA FEE_CODE_3RD_SA {
            get
            {
                if (FEE_CODE_3RD != null)
                {
                    if (_FEE_CODE_3RD_SA == null)
                    {
                        _FEE_CODE_3RD_SA = Context.SA.FindBySAKEY(FEE_CODE_3RD);
                    }
                    return _FEE_CODE_3RD_SA;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FEE_CODE_4TH] => [SA].[SAKEY]
        /// Fee code for the 4th child
        /// </summary>
        public SA FEE_CODE_4TH_SA {
            get
            {
                if (FEE_CODE_4TH != null)
                {
                    if (_FEE_CODE_4TH_SA == null)
                    {
                        _FEE_CODE_4TH_SA = Context.SA.FindBySAKEY(FEE_CODE_4TH);
                    }
                    return _FEE_CODE_4TH_SA;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [FEE_CODE_KG] => [SA].[SAKEY]
        /// Fee code for the Kindergarten child
        /// </summary>
        public SA FEE_CODE_KG_SA {
            get
            {
                if (FEE_CODE_KG != null)
                {
                    if (_FEE_CODE_KG_SA == null)
                    {
                        _FEE_CODE_KG_SA = Context.SA.FindBySAKEY(FEE_CODE_KG);
                    }
                    return _FEE_CODE_KG_SA;
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