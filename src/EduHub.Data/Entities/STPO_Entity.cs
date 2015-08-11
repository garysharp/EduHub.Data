﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Position or Group Memberships
    /// </summary>
    public class STPO_Entity : EntityBase
    {
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Student ID [Uppercase Alphanumeric: u10]
        /// </summary>
        public string STPOKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [STPOKEY] => [ST_Entity].[STKEY]
        /// Student ID
        /// </summary>
        public ST_Entity STPOKEY_ST { get { return STPOKEY == null ? null : Context.ST.FindBySTKEY(STPOKEY); } }
        /// <summary>
        /// Position or Group code [Uppercase Alphanumeric: u12]
        /// </summary>
        public string SGLINK { get; internal set; }
        /// <summary>
        /// Navigation property for [SGLINK] => [SG_Entity].[SGKEY]
        /// Position or Group code
        /// </summary>
        public SG_Entity SGLINK_SG { get { return SGLINK == null ? null : Context.SG.FindBySGKEY(SGLINK); } }
        /// <summary>
        /// Date of joining group [Date Time nullable: d]
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Date of leaving group [Date Time nullable: d]
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Performance notes [Memo: m]
        /// </summary>
        public string PERFORMANCE { get; internal set; }
        /// <summary>
        /// Role of this person in this group [Alphanumeric: a30]
        /// </summary>
        public string GROUP_ROLE { get; internal set; }
        /// <summary>
        /// Action [Memo: m]
        /// </summary>
        public string OTHER { get; internal set; }
        /// <summary>
        /// Group type of Position or Group: S=Special, E=Excursion, P=Position [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SG_TYPE { get; internal set; }
        /// <summary>
        /// House or Home group [Uppercase Alphanumeric: u10]
        /// </summary>
        public string HOUSE_HG { get; internal set; }
        /// <summary>
        /// Parental permission? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PERMISSION { get; internal set; }
        /// <summary>
        /// School permission? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SCH_PERMISSION { get; internal set; }
        /// <summary>
        /// Payment received in full? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string FULLY_PAID { get; internal set; }
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