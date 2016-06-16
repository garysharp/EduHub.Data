using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// User Program Codes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KUPC : EduHubEntity
    {

        #region Navigation Property Cache

        private KGLPROG Cache_GLPROGRAM01_KGLPROG;
        private KGLPROG Cache_GLPROGRAM02_KGLPROG;
        private GL Cache_GL_CODE_GL;

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
        /// Prime key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KUPCKEY { get; internal set; }

        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM01 { get; internal set; }

        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM02 { get; internal set; }

        /// <summary>
        /// General Ledger Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_CODE { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write user
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// KGLPROG (General Ledger Programs) related entity by [KUPC.GLPROGRAM01]-&gt;[KGLPROG.GLPROGRAM]
        /// A subprogram always belongs to a program
        /// </summary>
        public KGLPROG GLPROGRAM01_KGLPROG
        {
            get
            {
                if (GLPROGRAM01 == null)
                {
                    return null;
                }
                if (Cache_GLPROGRAM01_KGLPROG == null)
                {
                    Cache_GLPROGRAM01_KGLPROG = Context.KGLPROG.FindByGLPROGRAM(GLPROGRAM01);
                }

                return Cache_GLPROGRAM01_KGLPROG;
            }
        }

        /// <summary>
        /// KGLPROG (General Ledger Programs) related entity by [KUPC.GLPROGRAM02]-&gt;[KGLPROG.GLPROGRAM]
        /// A subprogram always belongs to a program
        /// </summary>
        public KGLPROG GLPROGRAM02_KGLPROG
        {
            get
            {
                if (GLPROGRAM02 == null)
                {
                    return null;
                }
                if (Cache_GLPROGRAM02_KGLPROG == null)
                {
                    Cache_GLPROGRAM02_KGLPROG = Context.KGLPROG.FindByGLPROGRAM(GLPROGRAM02);
                }

                return Cache_GLPROGRAM02_KGLPROG;
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [KUPC.GL_CODE]-&gt;[GL.CODE]
        /// General Ledger Code
        /// </summary>
        public GL GL_CODE_GL
        {
            get
            {
                if (GL_CODE == null)
                {
                    return null;
                }
                if (Cache_GL_CODE_GL == null)
                {
                    Cache_GL_CODE_GL = Context.GL.FindByCODE(GL_CODE);
                }

                return Cache_GL_CODE_GL;
            }
        }

        #endregion

    }
}
