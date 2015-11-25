using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Daily Attendance Records
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TXHG : EntityBase
    {

        #region Navigation Property Cache

        private KGC Cache_HOME_GROUP_KGC;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SXAB> Cache_TXHG_ID_SXAB_TXHG_TID;

        #endregion

        #region Field Properties

        /// <summary>
        /// Unique ID for this record
        /// </summary>
        public int TXHG_ID { get; internal set; }

        /// <summary>
        /// The date to which this record applies
        /// </summary>
        public DateTime? TXHG_DATE { get; internal set; }

        /// <summary>
        /// The home group to which this record applies
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string HOME_GROUP { get; internal set; }

        /// <summary>
        /// Has the AM roll been marked? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string AM_ROLL_MARKED { get; internal set; }

        /// <summary>
        /// Has the PM roll been marked? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PM_ROLL_MARKED { get; internal set; }

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
        /// KGC (Home Groups) related entity by [TXHG.HOME_GROUP]-&gt;[KGC.KGCKEY]
        /// The home group to which this record applies
        /// </summary>
        public KGC HOME_GROUP_KGC
        {
            get
            {
                if (HOME_GROUP == null)
                {
                    return null;
                }
                if (Cache_HOME_GROUP_KGC == null)
                {
                    Cache_HOME_GROUP_KGC = Context.KGC.FindByKGCKEY(HOME_GROUP);
                }

                return Cache_HOME_GROUP_KGC;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [TXHG.TXHG_ID]-&gt;[SXAB.TXHG_TID]
        /// Unique ID for this record
        /// </summary>
        public IReadOnlyList<SXAB> TXHG_ID_SXAB_TXHG_TID
        {
            get
            {
                if (Cache_TXHG_ID_SXAB_TXHG_TID == null &&
                    !Context.SXAB.TryFindByTXHG_TID(TXHG_ID, out Cache_TXHG_ID_SXAB_TXHG_TID))
                {
                    Cache_TXHG_ID_SXAB_TXHG_TID = new List<SXAB>().AsReadOnly();
                }

                return Cache_TXHG_ID_SXAB_TXHG_TID;
            }
        }

        #endregion

    }
}
