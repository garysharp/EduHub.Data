﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Houses
    /// </summary>
    public class KGH_Entity : EntityBase
    {
        /// <summary>
        /// (Was HOUSE) House code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string KGHKEY { get; internal set; }
        /// <summary>
        /// House description [Alphanumeric: a30]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Campus [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI_Entity].[SCIKEY]
        /// Campus
        /// </summary>
        public SCI_Entity CAMPUS_SCI { get { return CAMPUS.HasValue ? Context.SCI.FindBySCIKEY(CAMPUS.Value) : null; } }
        /// <summary>
        /// Active house? (Y/N) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// Number of current students in the house [Integer (16bit signed nullable): i]
        /// </summary>
        public short? HOUSE_SIZE { get; internal set; }
        /// <summary>
        /// Number of current males in the house [Integer (16bit signed nullable): i]
        /// </summary>
        public short? MALES { get; internal set; }
        /// <summary>
        /// Number of current females in the house [Integer (16bit signed nullable): i]
        /// </summary>
        public short? FEMALES { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F01 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F02 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F03 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F04 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F05 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F06 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F07 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F08 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F09 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F10 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F11 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F12 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F13 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F14 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F15 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F16 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F17 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F18 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F19 { get; internal set; }
        /// <summary>
        /// Number of females aged x as at 31st Dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_F20 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M01 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M02 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M03 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M04 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M05 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M06 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M07 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M08 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M09 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M10 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M11 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M12 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M13 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M14 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M15 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M16 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M17 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M18 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M19 { get; internal set; }
        /// <summary>
        /// Number of males aged x as at 31 dec [Integer (16bit signed nullable): i]
        /// </summary>
        public short? AGE_M20 { get; internal set; }
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