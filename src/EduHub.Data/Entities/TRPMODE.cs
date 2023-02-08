#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Modes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TRPMODE : EduHubEntity
    {

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<STTRIPS> Cache_TRANSPORT_MODE_ID_STTRIPS_AM_TRANSPORT_MODE;
        private IReadOnlyList<STTRIPS> Cache_TRANSPORT_MODE_ID_STTRIPS_PM_TRANSPORT_MODE;
        private IReadOnlyList<TRPROUT> Cache_TRANSPORT_MODE_ID_TRPROUT_TRANSPORT_MODE_ID;
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
        /// Transport Modes
        /// </summary>
        public int TRANSPORT_MODE_ID { get; internal set; }

        /// <summary>
        /// Transport Desc
        /// [Alphanumeric (60)]
        /// </summary>
        public string TRANSPORT_MODE_DESC { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// STTRIPS (Student Trips) related entities by [TRPMODE.TRANSPORT_MODE_ID]-&gt;[STTRIPS.AM_TRANSPORT_MODE]
        /// Transport Modes
        /// </summary>
        public IReadOnlyList<STTRIPS> TRANSPORT_MODE_ID_STTRIPS_AM_TRANSPORT_MODE
        {
            get
            {
                if (Cache_TRANSPORT_MODE_ID_STTRIPS_AM_TRANSPORT_MODE == null &&
                    !Context.STTRIPS.TryFindByAM_TRANSPORT_MODE(TRANSPORT_MODE_ID, out Cache_TRANSPORT_MODE_ID_STTRIPS_AM_TRANSPORT_MODE))
                {
                    Cache_TRANSPORT_MODE_ID_STTRIPS_AM_TRANSPORT_MODE = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_TRANSPORT_MODE_ID_STTRIPS_AM_TRANSPORT_MODE;
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [TRPMODE.TRANSPORT_MODE_ID]-&gt;[STTRIPS.PM_TRANSPORT_MODE]
        /// Transport Modes
        /// </summary>
        public IReadOnlyList<STTRIPS> TRANSPORT_MODE_ID_STTRIPS_PM_TRANSPORT_MODE
        {
            get
            {
                if (Cache_TRANSPORT_MODE_ID_STTRIPS_PM_TRANSPORT_MODE == null &&
                    !Context.STTRIPS.TryFindByPM_TRANSPORT_MODE(TRANSPORT_MODE_ID, out Cache_TRANSPORT_MODE_ID_STTRIPS_PM_TRANSPORT_MODE))
                {
                    Cache_TRANSPORT_MODE_ID_STTRIPS_PM_TRANSPORT_MODE = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_TRANSPORT_MODE_ID_STTRIPS_PM_TRANSPORT_MODE;
            }
        }

        /// <summary>
        /// TRPROUT (Student Transport Routes) related entities by [TRPMODE.TRANSPORT_MODE_ID]-&gt;[TRPROUT.TRANSPORT_MODE_ID]
        /// Transport Modes
        /// </summary>
        public IReadOnlyList<TRPROUT> TRANSPORT_MODE_ID_TRPROUT_TRANSPORT_MODE_ID
        {
            get
            {
                if (Cache_TRANSPORT_MODE_ID_TRPROUT_TRANSPORT_MODE_ID == null &&
                    !Context.TRPROUT.TryFindByTRANSPORT_MODE_ID(TRANSPORT_MODE_ID, out Cache_TRANSPORT_MODE_ID_TRPROUT_TRANSPORT_MODE_ID))
                {
                    Cache_TRANSPORT_MODE_ID_TRPROUT_TRANSPORT_MODE_ID = new List<TRPROUT>().AsReadOnly();
                }

                return Cache_TRANSPORT_MODE_ID_TRPROUT_TRANSPORT_MODE_ID;
            }
        }

#endif
        #endregion

    }
}
#endif
