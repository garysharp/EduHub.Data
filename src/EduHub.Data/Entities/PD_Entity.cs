using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Departments
    /// </summary>
    public class PD_Entity : EntityBase
    {
#region Navigation Property Cache
        private GL_Entity _GLCODE_GL;
        private GL_Entity _GLBANK_GL;
        private GL_Entity _GLTAX_GL;
        private KGLSUB_Entity _SUBPROGRAM_KGLSUB;
        private KGLINIT_Entity _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Department code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string PDKEY { get; internal set; }
        /// <summary>
        /// Description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Salary expense code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLCODE { get; internal set; }
        /// <summary>
        /// Bank account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLBANK { get; internal set; }
        /// <summary>
        /// Group tax clearing
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLTAX { get; internal set; }
        /// <summary>
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
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
        /// Salary expense code
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
        /// <summary>
        /// Navigation property for [GLBANK] => [GL_Entity].[CODE]
        /// Bank account
        /// </summary>
        public GL_Entity GLBANK_GL {
            get
            {
                if (GLBANK != null)
                {
                    if (_GLBANK_GL == null)
                    {
                        _GLBANK_GL = Context.GL.FindByCODE(GLBANK);
                    }
                    return _GLBANK_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GLTAX] => [GL_Entity].[CODE]
        /// Group tax clearing
        /// 
        /// </summary>
        public GL_Entity GLTAX_GL {
            get
            {
                if (GLTAX != null)
                {
                    if (_GLTAX_GL == null)
                    {
                        _GLTAX_GL = Context.GL.FindByCODE(GLTAX);
                    }
                    return _GLTAX_GL;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB {
            get
            {
                if (SUBPROGRAM != null)
                {
                    if (_SUBPROGRAM_KGLSUB == null)
                    {
                        _SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                    }
                    return _SUBPROGRAM_KGLSUB;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT {
            get
            {
                if (INITIATIVE != null)
                {
                    if (_INITIATIVE_KGLINIT == null)
                    {
                        _INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                    }
                    return _INITIATIVE_KGLINIT;
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
