using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Routes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TRPROUT : EduHubEntity
    {

        #region Navigation Property Cache

        private TRPMODE Cache_TRANSPORT_MODE_ID_TRPMODE;
        private KTRCMP Cache_TRANSPORT_COMPANY_ID_KTRCMP;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<STTRIPS> Cache_ROUTE_ID_STTRIPS_AM_ROUTE_ID;
        private IReadOnlyList<STTRIPS> Cache_ROUTE_ID_STTRIPS_PM_ROUTE_ID;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE.Value;
            }
        }

        #region Field Properties

        /// <summary>
        /// Route_ID - System Generated
        /// </summary>
        public int ROUTE_ID { get; internal set; }

        /// <summary>
        /// Route Name
        /// [Alphanumeric (40)]
        /// </summary>
        public string ROUTE_NAME { get; internal set; }

        /// <summary>
        /// Transport Modes
        /// </summary>
        public int? TRANSPORT_MODE_ID { get; internal set; }

        /// <summary>
        /// Company ID
        /// </summary>
        public int? TRANSPORT_COMPANY_ID { get; internal set; }

        /// <summary>
        /// Contract No
        /// [Alphanumeric (20)]
        /// </summary>
        public string ROUTE_CONTRACT_NO { get; internal set; }

        /// <summary>
        /// Contact 1 Given
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT1_FIRST_NAME { get; internal set; }

        /// <summary>
        /// Contact 1 Surname
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT1_LAST_NAME { get; internal set; }

        /// <summary>
        /// Contact 1 Phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT1_PHONE { get; internal set; }

        /// <summary>
        /// Contact 2 Given
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT2_FIRST_NAME { get; internal set; }

        /// <summary>
        /// Contact 2 Surname
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT2_LAST_NAME { get; internal set; }

        /// <summary>
        /// Contact 2 Phone
        /// [Alphanumeric (20)]
        /// </summary>
        public string CONTACT2_PHONE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? AM_SETDOWN_TIME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? PM_PICKUP_TIME { get; internal set; }

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
        /// TRPMODE (Transport Modes) related entity by [TRPROUT.TRANSPORT_MODE_ID]-&gt;[TRPMODE.TRANSPORT_MODE_ID]
        /// Transport Modes
        /// </summary>
        public TRPMODE TRANSPORT_MODE_ID_TRPMODE
        {
            get
            {
                if (TRANSPORT_MODE_ID == null)
                {
                    return null;
                }
                if (Cache_TRANSPORT_MODE_ID_TRPMODE == null)
                {
                    Cache_TRANSPORT_MODE_ID_TRPMODE = Context.TRPMODE.FindByTRANSPORT_MODE_ID(TRANSPORT_MODE_ID.Value);
                }

                return Cache_TRANSPORT_MODE_ID_TRPMODE;
            }
        }

        /// <summary>
        /// KTRCMP (Student Transport Company) related entity by [TRPROUT.TRANSPORT_COMPANY_ID]-&gt;[KTRCMP.COMPANY_ID]
        /// Company ID
        /// </summary>
        public KTRCMP TRANSPORT_COMPANY_ID_KTRCMP
        {
            get
            {
                if (TRANSPORT_COMPANY_ID == null)
                {
                    return null;
                }
                if (Cache_TRANSPORT_COMPANY_ID_KTRCMP == null)
                {
                    Cache_TRANSPORT_COMPANY_ID_KTRCMP = Context.KTRCMP.FindByCOMPANY_ID(TRANSPORT_COMPANY_ID.Value);
                }

                return Cache_TRANSPORT_COMPANY_ID_KTRCMP;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [TRPROUT.ROUTE_ID]-&gt;[STTRIPS.AM_ROUTE_ID]
        /// Route_ID - System Generated
        /// </summary>
        public IReadOnlyList<STTRIPS> ROUTE_ID_STTRIPS_AM_ROUTE_ID
        {
            get
            {
                if (Cache_ROUTE_ID_STTRIPS_AM_ROUTE_ID == null &&
                    !Context.STTRIPS.TryFindByAM_ROUTE_ID(ROUTE_ID, out Cache_ROUTE_ID_STTRIPS_AM_ROUTE_ID))
                {
                    Cache_ROUTE_ID_STTRIPS_AM_ROUTE_ID = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_ROUTE_ID_STTRIPS_AM_ROUTE_ID;
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [TRPROUT.ROUTE_ID]-&gt;[STTRIPS.PM_ROUTE_ID]
        /// Route_ID - System Generated
        /// </summary>
        public IReadOnlyList<STTRIPS> ROUTE_ID_STTRIPS_PM_ROUTE_ID
        {
            get
            {
                if (Cache_ROUTE_ID_STTRIPS_PM_ROUTE_ID == null &&
                    !Context.STTRIPS.TryFindByPM_ROUTE_ID(ROUTE_ID, out Cache_ROUTE_ID_STTRIPS_PM_ROUTE_ID))
                {
                    Cache_ROUTE_ID_STTRIPS_PM_ROUTE_ID = new List<STTRIPS>().AsReadOnly();
                }

                return Cache_ROUTE_ID_STTRIPS_PM_ROUTE_ID;
            }
        }

        #endregion

    }
}
