using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cost Centres
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PC : EntityBase
    {

        #region Navigation Property Cache

        private GL Cache_GLCODE_GL;
        private KGLSUB Cache_SUBPROGRAM_KGLSUB;
        private KGLINIT Cache_INITIATIVE_KGLINIT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<PEF> Cache_PCKEY_PEF_TRCENTRE;
        private IReadOnlyList<PEFH> Cache_PCKEY_PEFH_TRCENTRE;
        private IReadOnlyList<PEPS> Cache_PCKEY_PEPS_TRCENTRE;

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
        /// KGLSUB (General Ledger Sub Programs) related entity by [PC.SUBPROGRAM]-&gt;[KGLSUB.SUBPROGRAM]
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
        /// KGLINIT (General Ledger Initiatives) related entity by [PC.INITIATIVE]-&gt;[KGLINIT.INITIATIVE]
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

        /// <summary>
        /// PEF (Payroll Transactions) related entities by [PC.PCKEY]-&gt;[PEF.TRCENTRE]
        /// Cost centre key
        /// </summary>
        public IReadOnlyList<PEF> PCKEY_PEF_TRCENTRE
        {
            get
            {
                if (Cache_PCKEY_PEF_TRCENTRE == null &&
                    !Context.PEF.TryFindByTRCENTRE(PCKEY, out Cache_PCKEY_PEF_TRCENTRE))
                {
                    Cache_PCKEY_PEF_TRCENTRE = new List<PEF>().AsReadOnly();
                }

                return Cache_PCKEY_PEF_TRCENTRE;
            }
        }

        /// <summary>
        /// PEFH (Payroll Transaction History) related entities by [PC.PCKEY]-&gt;[PEFH.TRCENTRE]
        /// Cost centre key
        /// </summary>
        public IReadOnlyList<PEFH> PCKEY_PEFH_TRCENTRE
        {
            get
            {
                if (Cache_PCKEY_PEFH_TRCENTRE == null &&
                    !Context.PEFH.TryFindByTRCENTRE(PCKEY, out Cache_PCKEY_PEFH_TRCENTRE))
                {
                    Cache_PCKEY_PEFH_TRCENTRE = new List<PEFH>().AsReadOnly();
                }

                return Cache_PCKEY_PEFH_TRCENTRE;
            }
        }

        /// <summary>
        /// PEPS (Standard and Last Pays) related entities by [PC.PCKEY]-&gt;[PEPS.TRCENTRE]
        /// Cost centre key
        /// </summary>
        public IReadOnlyList<PEPS> PCKEY_PEPS_TRCENTRE
        {
            get
            {
                if (Cache_PCKEY_PEPS_TRCENTRE == null &&
                    !Context.PEPS.TryFindByTRCENTRE(PCKEY, out Cache_PCKEY_PEPS_TRCENTRE))
                {
                    Cache_PCKEY_PEPS_TRCENTRE = new List<PEPS>().AsReadOnly();
                }

                return Cache_PCKEY_PEPS_TRCENTRE;
            }
        }

        #endregion

    }
}
