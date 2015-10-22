using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Programs
    /// </summary>
    public partial class KGLPROG : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Type key, eg I
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// eg, INCOME
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Allow account to be used(Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
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
        /// GLF (General Ledger Transactions) related entities by [GLF.GLPROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        public IReadOnlyList<GLF> GLF_GLPROGRAM
        {
            get
            {
                return Context.KGLPROG.FindGLFByGLPROGRAM(GLPROGRAM);
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [GLFPREV.GLPROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        public IReadOnlyList<GLFPREV> GLFPREV_GLPROGRAM
        {
            get
            {
                return Context.KGLPROG.FindGLFPREVByGLPROGRAM(GLPROGRAM);
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entities by [KGLSUB.GL_PROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        public IReadOnlyList<KGLSUB> KGLSUB_GL_PROGRAM
        {
            get
            {
                return Context.KGLPROG.FindKGLSUBByGL_PROGRAM(GLPROGRAM);
            }
        }
#endregion
    }
}
