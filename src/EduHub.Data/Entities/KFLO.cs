#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FLO Placement information
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KFLO : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_SCHOOL_SKGS;

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<STFLO> Cache_KFLOKEY_STFLO_PROGRAM;
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
        /// Prime key
        /// </summary>
        public int KFLOKEY { get; internal set; }

        /// <summary>
        /// School/campus ID.
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SCHOOL { get; internal set; }

        /// <summary>
        /// DEET-defined school ID
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_ID { get; internal set; }

        /// <summary>
        /// Campus number
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string SCHOOL_NUMBER { get; internal set; }

        /// <summary>
        /// Program name
        /// [Alphanumeric (50)]
        /// </summary>
        public string PROGRAM { get; internal set; }

        /// <summary>
        /// Active/Inactive (Y/N)
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
        /// Last write user
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// SKGS (Schools) related entity by [KFLO.SCHOOL]-&gt;[SKGS.SCHOOL]
        /// School/campus ID.
        /// </summary>
        public SKGS SCHOOL_SKGS
        {
            get
            {
                if (SCHOOL == null)
                {
                    return null;
                }
                if (Cache_SCHOOL_SKGS == null)
                {
                    Cache_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(SCHOOL);
                }

                return Cache_SCHOOL_SKGS;
            }
        }

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// STFLO (Student Flexible Learning Options) related entities by [KFLO.KFLOKEY]-&gt;[STFLO.PROGRAM]
        /// Prime key
        /// </summary>
        public IReadOnlyList<STFLO> KFLOKEY_STFLO_PROGRAM
        {
            get
            {
                if (Cache_KFLOKEY_STFLO_PROGRAM == null &&
                    !Context.STFLO.TryFindByPROGRAM(KFLOKEY, out Cache_KFLOKEY_STFLO_PROGRAM))
                {
                    Cache_KFLOKEY_STFLO_PROGRAM = new List<STFLO>().AsReadOnly();
                }

                return Cache_KFLOKEY_STFLO_PROGRAM;
            }
        }

#endif
        #endregion

    }
}
#endif
