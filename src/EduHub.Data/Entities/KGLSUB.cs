using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Sub Programs
    /// </summary>
    public class KGLSUB : EntityBase
    {
#region Navigation Property Cache
        private KGLPROG _GL_PROGRAM_KGLPROG;
#endregion

#region Field Properties
        /// <summary>
        /// Type key, eg I
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// eg, INCOME
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Each subprogram belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GL_PROGRAM { get; internal set; }
        /// <summary>
        /// Allow account to be used(Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// To allow editing of the description
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string USER_DEFINABLE { get; internal set; }
        /// <summary>
        /// To prevent re-activation of old codes
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESERVED { get; internal set; }
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
        /// Navigation property for [GL_PROGRAM] => [KGLPROG].[GLPROGRAM]
        /// Each subprogram belongs to a program
        /// </summary>
        public KGLPROG GL_PROGRAM_KGLPROG {
            get
            {
                if (GL_PROGRAM != null)
                {
                    if (_GL_PROGRAM_KGLPROG == null)
                    {
                        _GL_PROGRAM_KGLPROG = Context.KGLPROG.FindByGLPROGRAM(GL_PROGRAM);
                    }
                    return _GL_PROGRAM_KGLPROG;
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
