using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Account Types
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<GL> Cache_GL_TYPE_GL_GL_TYPE;
        private IReadOnlyList<GLPREV> Cache_GL_TYPE_GLPREV_GL_TYPE;

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
        /// Type key, eg I
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GL_TYPE { get; internal set; }

        /// <summary>
        /// eg, INCOME
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

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
        /// GL (General Ledger) related entities by [KGLT.GL_TYPE]-&gt;[GL.GL_TYPE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GL> GL_TYPE_GL_GL_TYPE
        {
            get
            {
                if (Cache_GL_TYPE_GL_GL_TYPE == null &&
                    !Context.GL.TryFindByGL_TYPE(GL_TYPE, out Cache_GL_TYPE_GL_GL_TYPE))
                {
                    Cache_GL_TYPE_GL_GL_TYPE = new List<GL>().AsReadOnly();
                }

                return Cache_GL_TYPE_GL_GL_TYPE;
            }
        }

        /// <summary>
        /// GLPREV (Last Years General Ledger) related entities by [KGLT.GL_TYPE]-&gt;[GLPREV.GL_TYPE]
        /// Type key, eg I
        /// </summary>
        public IReadOnlyList<GLPREV> GL_TYPE_GLPREV_GL_TYPE
        {
            get
            {
                if (Cache_GL_TYPE_GLPREV_GL_TYPE == null &&
                    !Context.GLPREV.TryFindByGL_TYPE(GL_TYPE, out Cache_GL_TYPE_GLPREV_GL_TYPE))
                {
                    Cache_GL_TYPE_GLPREV_GL_TYPE = new List<GLPREV>().AsReadOnly();
                }

                return Cache_GL_TYPE_GLPREV_GL_TYPE;
            }
        }

        #endregion

    }
}
