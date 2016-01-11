using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// UM Transfer
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class UM_TFR : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_ORIG_SCHOOL_SKGS;

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Orignating School
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ORIG_SCHOOL { get; internal set; }

        /// <summary>
        /// Unique UM Transfer ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string UM_TRANS_ID { get; internal set; }

        /// <summary>
        /// Address ID
        /// </summary>
        public int? UMKEY { get; internal set; }

        /// <summary>
        /// New UMKEY
        /// </summary>
        public int? UMKEY_NEW { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }

        /// <summary>
        /// State code (if Australian address)
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Postcode (if Australian address)
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Phone no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE { get; internal set; }

        /// <summary>
        /// Home Mobile no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }

        /// <summary>
        /// This phone no is silent? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SILENT { get; internal set; }

        /// <summary>
        /// Fax no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Link to KAP to allow for access to postcodes when entering an address: NOTE this should NOT be a foreign key to KAP as the user is free to enter different data in ADDRESS03 and POSTCODE
        /// [Alphanumeric (34)]
        /// </summary>
        public string KAP_LINK { get; internal set; }

        /// <summary>
        /// Country (default '1101' code for Australia)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string COUNTRY { get; internal set; }

        /// <summary>
        /// Australia Post address identifier
        /// </summary>
        public int? DPID { get; internal set; }

        /// <summary>
        /// Australia Post barcode numbers
        /// [Alphanumeric (37)]
        /// </summary>
        public string BARCODE { get; internal set; }

        /// <summary>
        /// Current Status of Import
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string IMP_STATUS { get; internal set; }

        /// <summary>
        /// Actual Date data transfered into live table
        /// </summary>
        public DateTime? IMP_DATE { get; internal set; }

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
        /// SKGS (Schools) related entity by [UM_TFR.ORIG_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// Orignating School
        /// </summary>
        public SKGS ORIG_SCHOOL_SKGS
        {
            get
            {
                if (Cache_ORIG_SCHOOL_SKGS == null)
                {
                    Cache_ORIG_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(ORIG_SCHOOL);
                }

                return Cache_ORIG_SCHOOL_SKGS;
            }
        }

        #endregion

    }
}
