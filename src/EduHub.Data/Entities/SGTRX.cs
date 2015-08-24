﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Temporary Group Transactions
    /// </summary>
    public class SGTRX : EntityBase
    {
#region Navigation Property Cache
        private SG _SGTRXKEY_SG;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
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
        /// Navigation property for [SGTRXKEY] => [SG].[SGKEY]
        /// Code of new group
        /// </summary>
        public SG SGTRXKEY_SG {
            get
            {
                if (SGTRXKEY != null)
                {
                    if (_SGTRXKEY_SG == null)
                    {
                        _SGTRXKEY_SG = Context.SG.FindBySGKEY(SGTRXKEY);
                    }
                    return _SGTRXKEY_SG;
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