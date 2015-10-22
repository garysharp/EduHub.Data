using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cost Centres
    /// </summary>
    public partial class PC : EntityBase
    {
#region Navigation Property Cache
        private GL _GLCODE_GL;
        private KGLSUB _SUBPROGRAM_KGLSUB;
        private KGLINIT _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        /// Cost centre key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PCKEY { get; internal set; }
        /// <summary>
        /// Cost centre name
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// GL Salary expense code
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string GLCODE { get; internal set; }
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
        /// GL (General Ledger) related entity by [PC.GLCODE]-&gt;[GL.CODE]
        /// GL Salary expense code
        /// 
        /// </summary>
        public GL GLCODE_GL
        {
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
        /// KGLSUB (General Ledger Sub Programs) related entity by [PC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB SUBPROGRAM_KGLSUB
        {
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
        /// KGLINIT (General Ledger Initiatives) related entity by [PC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT INITIATIVE_KGLINIT
        {
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

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [PEF.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        public IReadOnlyList<PEF> PEF_TRCENTRE
        {
            get
            {
                return Context.PC.FindPEFByTRCENTRE(PCKEY);
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PEFH.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        public IReadOnlyList<PEFH> PEFH_TRCENTRE
        {
            get
            {
                return Context.PC.FindPEFHByTRCENTRE(PCKEY);
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PEPS.TRCENTRE]-&gt;[PC.PCKEY]
        /// </summary>
        public IReadOnlyList<PEPS> PEPS_TRCENTRE
        {
            get
            {
                return Context.PC.FindPEPSByTRCENTRE(PCKEY);
            }
        }
#endregion
    }
}
