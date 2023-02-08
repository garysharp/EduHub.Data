#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Departments
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PD : EduHubEntity
    {

        #region Navigation Property Cache

        private GL Cache_GLCODE_GL;
        private GL Cache_GLBANK_GL;
        private GL Cache_GLTAX_GL;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<PE> Cache_PDKEY_PE_DEPARTMENT;
#endif

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
        /// Department code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PDKEY { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Salary expense code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }

        /// <summary>
        /// Bank account
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLBANK { get; internal set; }

        /// <summary>
        /// Group tax clearing
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLTAX { get; internal set; }

        /// <summary>
        /// For every transaction there is a subprogram
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }

        /// <summary>
        /// Transaction might belong to an Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

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
        /// GL (General Ledger) related entity by [PD.GLCODE]-&gt;[GL.CODE]
        /// Salary expense code
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
        /// GL (General Ledger) related entity by [PD.GLBANK]-&gt;[GL.CODE]
        /// Bank account
        /// </summary>
        public GL GLBANK_GL
        {
            get
            {
                if (GLBANK == null)
                {
                    return null;
                }
                if (Cache_GLBANK_GL == null)
                {
                    Cache_GLBANK_GL = Context.GL.FindByCODE(GLBANK);
                }

                return Cache_GLBANK_GL;
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [PD.GLTAX]-&gt;[GL.CODE]
        /// Group tax clearing
        /// </summary>
        public GL GLTAX_GL
        {
            get
            {
                if (GLTAX == null)
                {
                    return null;
                }
                if (Cache_GLTAX_GL == null)
                {
                    Cache_GLTAX_GL = Context.GL.FindByCODE(GLTAX);
                }

                return Cache_GLTAX_GL;
            }
        }

        /// <summary>
        /// KGLSUB (General Ledger Sub Programs) related entity by [PD.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every transaction there is a subprogram
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
        /// KGLINIT (General Ledger Initiatives) related entity by [PD.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Transaction might belong to an Initiative
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

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// PE (Employees) related entities by [PD.PDKEY]-&gt;[PE.DEPARTMENT]
        /// Department code
        /// </summary>
        public IReadOnlyList<PE> PDKEY_PE_DEPARTMENT
        {
            get
            {
                if (Cache_PDKEY_PE_DEPARTMENT == null &&
                    !Context.PE.TryFindByDEPARTMENT(PDKEY, out Cache_PDKEY_PE_DEPARTMENT))
                {
                    Cache_PDKEY_PE_DEPARTMENT = new List<PE>().AsReadOnly();
                }

                return Cache_PDKEY_PE_DEPARTMENT;
            }
        }

#endif
        #endregion

    }
}
#endif
