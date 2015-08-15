using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Superannuation Funds
    /// </summary>
    public class PF_Entity : EntityBase
    {
#region Navigation Property Cache
        private GL_Entity _GLCODE_GL;
#endregion

#region Field Properties
        /// <summary>
        /// Super fund key [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PFKEY { get; internal set; }
        /// <summary>
        /// Super fund name [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Super GL clearing account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Create Export File (AEGIS 7247) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CREATE_EXPORT_FILE { get; internal set; }
        /// <summary>
        /// Payer Australian Business Number (Aegis 9080) [Alphanumeric: a11]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// Unique Superfund Identifier (Aegis 9080) [Uppercase Alphanumeric: u15]
        /// </summary>
        public string USI { get; internal set; }
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
        /// Navigation property for [GLCODE] => [GL_Entity].[CODE]
        /// Super GL clearing account
        /// </summary>
        public GL_Entity GLCODE_GL {
            get
            {
                if (GLCODE != null)
                {
                    if (_GLCODE_GL == null)
                    {
                        _GLCODE_GL = Context.GL.FindByCODE(GLCODE);
                    }
                    return _GLCODE_GL;
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
