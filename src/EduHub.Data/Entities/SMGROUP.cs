using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Rooms group
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SMGROUP : EduHubEntity
    {

        #region Navigation Property Cache

        private SM Cache_GROUPKEY_SM;
        private SM Cache_ROOM_SM;

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Group key in SM
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string GROUPKEY { get; internal set; }

        /// <summary>
        /// Room in the group
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }

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
        /// SM (Rooms) related entity by [SMGROUP.GROUPKEY]-&gt;[SM.ROOM]
        /// Group key in SM
        /// </summary>
        public SM GROUPKEY_SM
        {
            get
            {
                if (Cache_GROUPKEY_SM == null)
                {
                    Cache_GROUPKEY_SM = Context.SM.FindByROOM(GROUPKEY);
                }

                return Cache_GROUPKEY_SM;
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [SMGROUP.ROOM]-&gt;[SM.ROOM]
        /// Room in the group
        /// </summary>
        public SM ROOM_SM
        {
            get
            {
                if (ROOM == null)
                {
                    return null;
                }
                if (Cache_ROOM_SM == null)
                {
                    Cache_ROOM_SM = Context.SM.FindByROOM(ROOM);
                }

                return Cache_ROOM_SM;
            }
        }

        #endregion

    }
}
