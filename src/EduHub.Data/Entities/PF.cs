using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Superannuation Funds
    /// </summary>
    public partial class PF : EntityBase
    {
#region Navigation Property Cache
        private GL _GLCODE_GL;
#endregion

#region Field Properties
        /// <summary>
        /// Super fund key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PFKEY { get; internal set; }
        /// <summary>
        /// Super fund name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Super GL clearing account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Create Export File (AEGIS 7247)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CREATE_EXPORT_FILE { get; internal set; }
        /// <summary>
        /// Payer Australian Business Number (Aegis 9080)
        /// [Alphanumeric (11)]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// Unique Superfund Identifier (Aegis 9080)
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string USI { get; internal set; }
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
        /// GL (General Ledger) related entity by [PF.GLCODE]-&gt;[GL.CODE]
        /// Super GL clearing account
        /// </summary>
        public GL GLCODE_GL
        {
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

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PEPS.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        public IReadOnlyList<PEPS> PEPS_SUPER_FUND
        {
            get
            {
                return Context.PF.FindPEPSBySUPER_FUND(PFKEY);
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [PEPU.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        public IReadOnlyList<PEPU> PEPU_SUPER_FUND
        {
            get
            {
                return Context.PF.FindPEPUBySUPER_FUND(PFKEY);
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [PEPUH.SUPER_FUND]-&gt;[PF.PFKEY]
        /// </summary>
        public IReadOnlyList<PEPUH> PEPUH_SUPER_FUND
        {
            get
            {
                return Context.PF.FindPEPUHBySUPER_FUND(PFKEY);
            }
        }
#endregion
    }
}
