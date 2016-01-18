using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Superannuation Funds
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PF : EduHubEntity
    {

        #region Navigation Property Cache

        private GL Cache_GLCODE_GL;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<PEPS> Cache_PFKEY_PEPS_SUPER_FUND;
        private IReadOnlyList<PEPU> Cache_PFKEY_PEPU_SUPER_FUND;
        private IReadOnlyList<PEPUH> Cache_PFKEY_PEPUH_SUPER_FUND;

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
                if (GLCODE == null)
                {
                    return null;
                }
                if (Cache_GLCODE_GL == null)
                {
                    Cache_GLCODE_GL = Context.GL.FindByCODE(GLCODE);
                }

                return Cache_GLCODE_GL;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PF.PFKEY]-&gt;[PEPS.SUPER_FUND]
        /// Super fund key
        /// </summary>
        public IReadOnlyList<PEPS> PFKEY_PEPS_SUPER_FUND
        {
            get
            {
                if (Cache_PFKEY_PEPS_SUPER_FUND == null &&
                    !Context.PEPS.TryFindBySUPER_FUND(PFKEY, out Cache_PFKEY_PEPS_SUPER_FUND))
                {
                    Cache_PFKEY_PEPS_SUPER_FUND = new List<PEPS>().AsReadOnly();
                }

                return Cache_PFKEY_PEPS_SUPER_FUND;
            }
        }

        /// <summary>
        /// PEPU (Super (SGL and Employee) YTD Transactions) related entities by [PF.PFKEY]-&gt;[PEPU.SUPER_FUND]
        /// Super fund key
        /// </summary>
        public IReadOnlyList<PEPU> PFKEY_PEPU_SUPER_FUND
        {
            get
            {
                if (Cache_PFKEY_PEPU_SUPER_FUND == null &&
                    !Context.PEPU.TryFindBySUPER_FUND(PFKEY, out Cache_PFKEY_PEPU_SUPER_FUND))
                {
                    Cache_PFKEY_PEPU_SUPER_FUND = new List<PEPU>().AsReadOnly();
                }

                return Cache_PFKEY_PEPU_SUPER_FUND;
            }
        }

        /// <summary>
        /// PEPUH (Super (SGL and Employee) History YTD Transactions) related entities by [PF.PFKEY]-&gt;[PEPUH.SUPER_FUND]
        /// Super fund key
        /// </summary>
        public IReadOnlyList<PEPUH> PFKEY_PEPUH_SUPER_FUND
        {
            get
            {
                if (Cache_PFKEY_PEPUH_SUPER_FUND == null &&
                    !Context.PEPUH.TryFindBySUPER_FUND(PFKEY, out Cache_PFKEY_PEPUH_SUPER_FUND))
                {
                    Cache_PFKEY_PEPUH_SUPER_FUND = new List<PEPUH>().AsReadOnly();
                }

                return Cache_PFKEY_PEPUH_SUPER_FUND;
            }
        }

        #endregion

    }
}
