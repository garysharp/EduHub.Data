#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Books for Hire
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BKH : EduHubEntity
    {

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<BKHR> Cache_BKHKEY_BKHR_BKHRKEY;
        private IReadOnlyList<SUBL> Cache_BKHKEY_SUBL_BOOK;
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
        /// Book code
        /// [Uppercase Alphanumeric (13)]
        /// </summary>
        public string BKHKEY { get; internal set; }

        /// <summary>
        /// Book title
        /// [Alphanumeric (40)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Edition
        /// [Alphanumeric (20)]
        /// </summary>
        public string EDITION { get; internal set; }

        /// <summary>
        /// Book's author
        /// [Alphanumeric (20)]
        /// </summary>
        public string AUTHOR { get; internal set; }

        /// <summary>
        /// Published by
        /// [Alphanumeric (30)]
        /// </summary>
        public string PUBLISHER { get; internal set; }

        /// <summary>
        /// Cost for student course
        /// </summary>
        public decimal? PRICE { get; internal set; }

        /// <summary>
        /// Item type: B=Book, S=Stationery
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ITEM_TYPE { get; internal set; }

        /// <summary>
        /// Number of copies available
        /// </summary>
        public short? NO_COPIES { get; internal set; }

        /// <summary>
        /// Starting no for Txn ID
        /// </summary>
        public short? SEEDED_NUM { get; internal set; }

        /// <summary>
        /// Copies not on hire
        /// </summary>
        public short? AVAIL_COPIES { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (13)]
        /// </summary>
        public string ISBN { get; internal set; }

        /// <summary>
        /// Any generic comments
        /// [Memo]
        /// </summary>
        public string ANNOTATIONS { get; internal set; }

        /// <summary>
        /// Date purchased
        /// </summary>
        public DateTime? PURCHASE_DATE { get; internal set; }

        /// <summary>
        /// Purchase price
        /// </summary>
        public decimal? PURCHASE_PRICE { get; internal set; }

        /// <summary>
        /// Hire fee
        /// </summary>
        public decimal? HIRE_FEE { get; internal set; }

        /// <summary>
        /// Whether to remove from stock
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REMOVE { get; internal set; }

        /// <summary>
        /// Movie
        /// </summary>
        public byte[] BOOK_MOVIE { get; internal set; }

        /// <summary>
        /// Sound
        /// </summary>
        public byte[] BOOK_SOUND { get; internal set; }

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
        /// BKHR (Book Hire Records) related entities by [BKH.BKHKEY]-&gt;[BKHR.BKHRKEY]
        /// Book code
        /// </summary>
        public IReadOnlyList<BKHR> BKHKEY_BKHR_BKHRKEY
        {
            get
            {
                if (Cache_BKHKEY_BKHR_BKHRKEY == null &&
                    !Context.BKHR.TryFindByBKHRKEY(BKHKEY, out Cache_BKHKEY_BKHR_BKHRKEY))
                {
                    Cache_BKHKEY_BKHR_BKHRKEY = new List<BKHR>().AsReadOnly();
                }

                return Cache_BKHKEY_BKHR_BKHRKEY;
            }
        }

        /// <summary>
        /// SUBL (Subject Book List) related entities by [BKH.BKHKEY]-&gt;[SUBL.BOOK]
        /// Book code
        /// </summary>
        public IReadOnlyList<SUBL> BKHKEY_SUBL_BOOK
        {
            get
            {
                if (Cache_BKHKEY_SUBL_BOOK == null &&
                    !Context.SUBL.TryFindByBOOK(BKHKEY, out Cache_BKHKEY_SUBL_BOOK))
                {
                    Cache_BKHKEY_SUBL_BOOK = new List<SUBL>().AsReadOnly();
                }

                return Cache_BKHKEY_SUBL_BOOK;
            }
        }

#endif
        #endregion

    }
}
#endif
