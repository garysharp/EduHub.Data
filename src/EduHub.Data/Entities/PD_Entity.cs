using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Departments
    /// </summary>
    public class PD_Entity : EntityBase
    {
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
        /// Navigation property for [GLCODE] => [GL_Entity].[CODE]
        /// Salary expense code
        /// </summary>
        public GL_Entity GLCODE_GL { get { return GLCODE == null ? null : Context.GL.FindByCODE(GLCODE); } }
        /// <summary>
        /// Bank account [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLBANK { get; internal set; }
        /// <summary>
        /// Navigation property for [GLBANK] => [GL_Entity].[CODE]
        /// Bank account
        /// </summary>
        public GL_Entity GLBANK_GL { get { return GLBANK == null ? null : Context.GL.FindByCODE(GLBANK); } }
        /// <summary>
        /// Group tax clearing
        ///  [Uppercase Alphanumeric: u10]
        /// </summary>
        public string GLTAX { get; internal set; }
        /// <summary>
        /// Navigation property for [GLTAX] => [GL_Entity].[CODE]
        /// Group tax clearing
        /// 
        /// </summary>
        public GL_Entity GLTAX_GL { get { return GLTAX == null ? null : Context.GL.FindByCODE(GLTAX); } }
        /// <summary>
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB { get { return SUBPROGRAM == null ? null : Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM); } }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT { get { return INITIATIVE == null ? null : Context.KGLINIT.FindByINITIATIVE(INITIATIVE); } }
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
        
        
    }
}
