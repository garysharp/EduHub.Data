using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Modes
    /// </summary>
    public partial class TRPMODE : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [STTRIPS.AM_TRANSPORT_MODE]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        public IReadOnlyList<STTRIPS> STTRIPS_AM_TRANSPORT_MODE
        {
            get
            {
                return Context.TRPMODE.FindSTTRIPSByAM_TRANSPORT_MODE(TRANSPORT_MODE_ID);
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [STTRIPS.PM_TRANSPORT_MODE]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        public IReadOnlyList<STTRIPS> STTRIPS_PM_TRANSPORT_MODE
        {
            get
            {
                return Context.TRPMODE.FindSTTRIPSByPM_TRANSPORT_MODE(TRANSPORT_MODE_ID);
            }
        }

        /// <summary>
        /// TRPROUT (Student Transport Routes) related entities by [TRPROUT.TRANSPORT_MODE_ID]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// </summary>
        public IReadOnlyList<TRPROUT> TRPROUT_TRANSPORT_MODE_ID
        {
            get
            {
                return Context.TRPMODE.FindTRPROUTByTRANSPORT_MODE_ID(TRANSPORT_MODE_ID);
            }
        }
#endregion
    }
}
