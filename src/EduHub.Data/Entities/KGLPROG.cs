using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Programs
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLPROG : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<GLF> Cache_GLPROGRAM_GLF_GLPROGRAM;
        private IReadOnlyList<GLFPREV> Cache_GLPROGRAM_GLFPREV_GLPROGRAM;
        private IReadOnlyList<KGLSUB> Cache_GLPROGRAM_KGLSUB_GL_PROGRAM;

        #endregion

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

        #region Foreign Navigation Properties

        /// <summary>
        /// GLF (General Ledger Transactions) related entities by [KGLPROG.GLPROGRAM]-&gt;[GLF.GLPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLF> GLPROGRAM_GLF_GLPROGRAM
        {
            get
            {
                if (Cache_GLPROGRAM_GLF_GLPROGRAM == null &&
                    !Context.GLF.TryFindByGLPROGRAM(GLPROGRAM, out Cache_GLPROGRAM_GLF_GLPROGRAM))
                {
                    Cache_GLPROGRAM_GLF_GLPROGRAM = new List<GLF>().AsReadOnly();
                }

                return Cache_GLPROGRAM_GLF_GLPROGRAM;
            }
        }

        /// <summary>
        /// GLFPREV (Last Years GL Financial Trans) related entities by [KGLPROG.GLPROGRAM]-&gt;[GLFPREV.GLPROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLFPREV> GLPROGRAM_GLFPREV_GLPROGRAM
        {
            get
            {
                if (Cache_GLPROGRAM_GLFPREV_GLPROGRAM == null &&
                    !Context.GLFPREV.TryFindByGLPROGRAM(GLPROGRAM, out Cache_GLPROGRAM_GLFPREV_GLPROGRAM))
                {
                    Cache_GLPROGRAM_GLFPREV_GLPROGRAM = new List<GLFPREV>().AsReadOnly();
                }

                return Cache_GLPROGRAM_GLFPREV_GLPROGRAM;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entities by [KGLPROG.GLPROGRAM]-&gt;[KGLSUB.GL_PROGRAM]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<KGLSUB> GLPROGRAM_KGLSUB_GL_PROGRAM
        {
            get
            {
                if (Cache_GLPROGRAM_KGLSUB_GL_PROGRAM == null &&
                    !Context.KGLSUB.TryFindByGL_PROGRAM(GLPROGRAM, out Cache_GLPROGRAM_KGLSUB_GL_PROGRAM))
                {
                    Cache_GLPROGRAM_KGLSUB_GL_PROGRAM = new List<KGLSUB>().AsReadOnly();
                }

                return Cache_GLPROGRAM_KGLSUB_GL_PROGRAM;
            }
        }

        #endregion

    }
}
