using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Books for Hire
    /// </summary>
    public class BKH_Entity : EntityBase
    {
        /// <summary>
        /// Book code [Uppercase Alphanumeric: u13]
        /// </summary>
        public string BKHKEY { get; internal set; }
        /// <summary>
        /// Book title [Alphanumeric: a40]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Edition [Alphanumeric: a20]
        /// </summary>
        public string EDITION { get; internal set; }
        /// <summary>
        /// Book's author [Alphanumeric: a20]
        /// </summary>
        public string AUTHOR { get; internal set; }
        /// <summary>
        /// Published by [Alphanumeric: a30]
        /// </summary>
        public string PUBLISHER { get; internal set; }
        /// <summary>
        /// Cost for student course [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PRICE { get; internal set; }
        /// <summary>
        /// Item type: B=Book, S=Stationery [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ITEM_TYPE { get; internal set; }
        /// <summary>
        /// Number of copies available [Integer (16bit signed nullable): i]
        /// </summary>
        public short? NO_COPIES { get; internal set; }
        /// <summary>
        /// Starting no for Txn ID [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEEDED_NUM { get; internal set; }
        /// <summary>
        /// Copies not on hire [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AVAIL_COPIES { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u13]
        /// </summary>
        public string ISBN { get; internal set; }
        /// <summary>
        /// Any generic comments [Memo: m]
        /// </summary>
        public string ANNOTATIONS { get; internal set; }
        /// <summary>
        /// Date purchased [Date Time nullable: d]
        /// </summary>
        public DateTime? PURCHASE_DATE { get; internal set; }
        /// <summary>
        /// Purchase price [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? PURCHASE_PRICE { get; internal set; }
        /// <summary>
        /// Hire fee [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? HIRE_FEE { get; internal set; }
        /// <summary>
        /// Whether to remove from stock [Uppercase Alphanumeric: u1]
        /// </summary>
        public string REMOVE { get; internal set; }
        /// <summary>
        /// Movie [OLE Controls (byte array): bo]
        /// </summary>
        public byte[] BOOK_MOVIE { get; internal set; }
        /// <summary>
        /// Sound [OLE Controls (byte array): bo]
        /// </summary>
        public byte[] BOOK_SOUND { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
