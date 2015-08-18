using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Book List
    /// </summary>
    public class SUBL : EntityBase
    {
#region Navigation Property Cache
        private SU _BLKEY_SU;
        private BKH _BOOK_BKH;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int? TID { get; internal set; }
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
        /// Navigation property for [BLKEY] => [SU].[SUKEY]
        /// Subject code
        /// </summary>
        public SU BLKEY_SU {
            get
            {
                if (BLKEY != null)
                {
                    if (_BLKEY_SU == null)
                    {
                        _BLKEY_SU = Context.SU.FindBySUKEY(BLKEY);
                    }
                    return _BLKEY_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [BOOK] => [BKH].[BKHKEY]
        /// Book ISBN identifier
        /// </summary>
        public BKH BOOK_BKH {
            get
            {
                if (BOOK != null)
                {
                    if (_BOOK_BKH == null)
                    {
                        _BOOK_BKH = Context.BKH.FindByBKHKEY(BOOK);
                    }
                    return _BOOK_BKH;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
