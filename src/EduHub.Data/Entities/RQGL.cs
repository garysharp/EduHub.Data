using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Purchasing Group GL Codes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQGL : EduHubEntity
    {

        #region Navigation Property Cache

        private RQPG Cache_RQPGKEY_RQPG;
        private GL Cache_GLCODE_GL;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

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
        /// &lt;No documentation available&gt;
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Purchasing Group
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string RQPGKEY { get; internal set; }

        /// <summary>
        /// GL Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }

        /// <summary>
        /// Must already exist as a SUBPROGRAM
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// Not mandatory
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

        /// <summary>
        /// Group PR approval limit
        /// </summary>
        public decimal? PR_LIMIT { get; internal set; }

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
        /// RQPG (Purchasing Group) related entity by [RQGL.RQPGKEY]-&gt;[RQPG.RQPGKEY]
        /// Purchasing Group
        /// </summary>
        public RQPG RQPGKEY_RQPG
        {
            get
            {
                if (Cache_RQPGKEY_RQPG == null)
                {
                    Cache_RQPGKEY_RQPG = Context.RQPG.FindByRQPGKEY(RQPGKEY);
                }

                return Cache_RQPGKEY_RQPG;
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [RQGL.GLCODE]-&gt;[GL.CODE]
        /// GL Code
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

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [RQGL.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// Must already exist as a SUBPROGRAM
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB
        {
            get
            {
                if (SUBPROGRAM == null)
                {
                    return null;
                }
                if (Cache_SUBPROGRAM_KGLSUB == null)
                {
                    Cache_SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                }

                return Cache_SUBPROGRAM_KGLSUB;
            }
        }

        /// <summary>
        /// KGLINIT (General Ledger Initiatives) related entity by [RQGL.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Not mandatory
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT
        {
            get
            {
                if (INITIATIVE == null)
                {
                    return null;
                }
                if (Cache_INITIATIVE_KGLINIT == null)
                {
                    Cache_INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                }

                return Cache_INITIATIVE_KGLINIT;
            }
        }

        #endregion

    }
}
