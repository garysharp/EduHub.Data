﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Disciplinary Incidents
    /// </summary>
    public class SID_Entity : EntityBase
    {
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int SIDKEY { get; internal set; }
        /// <summary>
        /// Date of incident [Date Time nullable: d]
        /// </summary>
        public DateTime? SID_DATE { get; internal set; }
        /// <summary>
        /// Time of incident [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SID_TIME { get; internal set; }
        /// <summary>
        /// Type of incident [Uppercase Alphanumeric: u10]
        /// </summary>
        public string INCIDENT_TYPE { get; internal set; }
        /// <summary>
        /// Navigation property for [INCIDENT_TYPE] => [KCB_Entity].[KCBKEY]
        /// Type of incident
        /// </summary>
        public KCB_Entity INCIDENT_TYPE_KCB { get { return INCIDENT_TYPE == null ? null : Context.KCB.FindByKCBKEY(INCIDENT_TYPE); } }
        /// <summary>
        /// Description of incident [Memo: m]
        /// </summary>
        public string INCIDENT_DESC { get; internal set; }
        /// <summary>
        /// Memo field for office use only and not to be used for reports [Memo: m]
        /// </summary>
        public string OFFICE_USE_ONLY { get; internal set; }
        /// <summary>
        /// School campus at which incident took place [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// School campus at which incident took place
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
        /// <summary>
        /// Address at which incident took place (if not at school) [Memo: m]
        /// </summary>
        public string EXT_ADDRESS { get; internal set; }
        /// <summary>
        /// Type of person reporting incident: ST=Student, SF=Staff member, null=Other [Uppercase Alphanumeric: u2]
        /// </summary>
        public string RESP_PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code identifying person reporting incident (if student or staff member) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string RESP_PERSON { get; internal set; }
        /// <summary>
        /// Name of reporting person (if not student or staff member) [Uppercase Alphanumeric: u64]
        /// </summary>
        public string RESP_PERSON_NAME { get; internal set; }
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