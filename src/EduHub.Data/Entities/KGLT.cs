using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Account Types
    /// </summary>
    public partial class KGLT : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// GL (General Ledger) related entities by [GL.GL_TYPE]-&gt;[KGLT.GL_TYPE]
        /// </summary>
        public IReadOnlyList<GL> GL_GL_TYPE
        {
            get
            {
                return Context.KGLT.FindGLByGL_TYPE(GL_TYPE);
            }
        }

        /// <summary>
        /// GLPREV (Last Years General Ledger) related entities by [GLPREV.GL_TYPE]-&gt;[KGLT.GL_TYPE]
        /// </summary>
        public IReadOnlyList<GLPREV> GLPREV_GL_TYPE
        {
            get
            {
                return Context.KGLT.FindGLPREVByGL_TYPE(GL_TYPE);
            }
        }
#endregion
    }
}
