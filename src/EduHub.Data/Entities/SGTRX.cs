using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Temporary Group Transactions
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGTRX : EduHubEntity
    {

        #region Navigation Property Cache

        private SG Cache_SGTRXKEY_SG;

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
        /// Code of new group
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SGTRXKEY { get; internal set; }

        /// <summary>
        /// Transaction table: One of SGSC, SGHG or SGSG
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TRXTYPE { get; internal set; }

        /// <summary>
        /// Code of group membership criterion: NOTE this should NOT be a foreign key to SGSG as records in this table are transient
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SGLINK { get; internal set; }

        /// <summary>
        /// Code of home group membership criterion: NOTE this should NOT be a foreign key to SGHG as records in this table are transient
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KGCLINK { get; internal set; }

        /// <summary>
        /// Code of subject membership criterion: NOTE this should NOT be a foreign key to SGSC as records in this table are transient
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SULINK { get; internal set; }

        /// <summary>
        /// Code of class membership criterion
        /// </summary>
        public short? CLASS { get; internal set; }

        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TTPERIOD { get; internal set; }

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
        /// SG (Student Groupings) related entity by [SGTRX.SGTRXKEY]-&gt;[SG.SGKEY]
        /// Code of new group
        /// </summary>
        public SG SGTRXKEY_SG
        {
            get
            {
                if (Cache_SGTRXKEY_SG == null)
                {
                    Cache_SGTRXKEY_SG = Context.SG.FindBySGKEY(SGTRXKEY);
                }

                return Cache_SGTRXKEY_SG;
            }
        }

        #endregion

    }
}
