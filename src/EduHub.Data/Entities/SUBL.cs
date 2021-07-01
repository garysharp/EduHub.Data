using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Book List
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SUBL : EduHubEntity
    {

        #region Navigation Property Cache

        private SU Cache_BLKEY_SU;
        private BKH Cache_BOOK_BKH;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string BLKEY { get; internal set; }

        /// <summary>
        /// Book ISBN identifier
        /// [Uppercase Alphanumeric (13)]
        /// </summary>
        public string BOOK { get; internal set; }

        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TTPERIOD { get; internal set; }

        /// <summary>
        /// Tag required
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TAG { get; internal set; }

        /// <summary>
        /// Semester required
        /// </summary>
        public short? SEMESTER { get; internal set; }

        /// <summary>
        /// Number of items required
        /// </summary>
        public short? NUMBER_REQUIRED { get; internal set; }

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
        /// SU (Subjects) related entity by [SUBL.BLKEY]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU BLKEY_SU
        {
            get
            {
                if (Cache_BLKEY_SU == null)
                {
                    Cache_BLKEY_SU = Context.SU.FindBySUKEY(BLKEY);
                }

                return Cache_BLKEY_SU;
            }
        }

        /// <summary>
        /// BKH (Books for Hire) related entity by [SUBL.BOOK]-&gt;[BKH.BKHKEY]
        /// Book ISBN identifier
        /// </summary>
        public BKH BOOK_BKH
        {
            get
            {
                if (BOOK == null)
                {
                    return null;
                }
                if (Cache_BOOK_BKH == null)
                {
                    Cache_BOOK_BKH = Context.BKH.FindByBKHKEY(BOOK);
                }

                return Cache_BOOK_BKH;
            }
        }

        #endregion

    }
}
