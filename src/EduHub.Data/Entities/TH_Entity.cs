using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Headers
    /// </summary>
    public class TH_Entity : EntityBase
    {
        /// <summary>
        /// Quilt code [Uppercase Alphanumeric: u8]
        /// </summary>
        public string THKEY { get; internal set; }
        /// <summary>
        /// Quilt title [Alphanumeric: a30]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Can this template be selected by general users [Alphanumeric: a1]
        /// </summary>
        public string SELECTABLE { get; internal set; }
        /// <summary>
        /// Number of rows [Integer (16bit signed nullable): i]
        /// </summary>
        public short? THROWS { get; internal set; }
        /// <summary>
        /// Number of columns [Integer (16bit signed nullable): i]
        /// </summary>
        public short? THCOLS { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL01 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL02 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL03 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL04 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL05 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL06 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL07 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL08 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL09 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL10 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL11 { get; internal set; }
        /// <summary>
        /// Labels for rows (periods) [Alphanumeric: a10]
        /// </summary>
        public string TH_RLABEL12 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL01 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL02 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL03 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL04 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL05 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL06 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL07 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL08 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL09 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL10 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL11 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL12 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL13 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL14 { get; internal set; }
        /// <summary>
        /// Labels for columns (days) [Alphanumeric: a10]
        /// </summary>
        public string TH_CLABEL15 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD01 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD02 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD03 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD04 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD05 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD06 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD07 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD08 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD09 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD10 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD11 { get; internal set; }
        /// <summary>
        /// Teaching period for student absence [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TEACHING_PERIOD12 { get; internal set; }
        /// <summary>
        /// Link to 1st template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT01KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT01KEY] => [TT_Entity].[TTKEY]
        /// Link to 1st template in timetable
        /// </summary>
        public TT_Entity TT01KEY_TT { get { return TT01KEY == null ? null : Context.TT.FindByTTKEY(TT01KEY); } }
        /// <summary>
        /// Link to 2nd template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT02KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT02KEY] => [TT_Entity].[TTKEY]
        /// Link to 2nd template in timetable
        /// </summary>
        public TT_Entity TT02KEY_TT { get { return TT02KEY == null ? null : Context.TT.FindByTTKEY(TT02KEY); } }
        /// <summary>
        /// Link to 3rd template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT03KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT03KEY] => [TT_Entity].[TTKEY]
        /// Link to 3rd template in timetable
        /// </summary>
        public TT_Entity TT03KEY_TT { get { return TT03KEY == null ? null : Context.TT.FindByTTKEY(TT03KEY); } }
        /// <summary>
        /// Link to 4th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT04KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT04KEY] => [TT_Entity].[TTKEY]
        /// Link to 4th template in timetable
        /// </summary>
        public TT_Entity TT04KEY_TT { get { return TT04KEY == null ? null : Context.TT.FindByTTKEY(TT04KEY); } }
        /// <summary>
        /// Link to 5th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT05KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT05KEY] => [TT_Entity].[TTKEY]
        /// Link to 5th template in timetable
        /// </summary>
        public TT_Entity TT05KEY_TT { get { return TT05KEY == null ? null : Context.TT.FindByTTKEY(TT05KEY); } }
        /// <summary>
        /// Link to 6th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT06KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT06KEY] => [TT_Entity].[TTKEY]
        /// Link to 6th template in timetable
        /// </summary>
        public TT_Entity TT06KEY_TT { get { return TT06KEY == null ? null : Context.TT.FindByTTKEY(TT06KEY); } }
        /// <summary>
        /// Link to 7th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT07KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT07KEY] => [TT_Entity].[TTKEY]
        /// Link to 7th template in timetable
        /// </summary>
        public TT_Entity TT07KEY_TT { get { return TT07KEY == null ? null : Context.TT.FindByTTKEY(TT07KEY); } }
        /// <summary>
        /// Link to 8th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT08KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT08KEY] => [TT_Entity].[TTKEY]
        /// Link to 8th template in timetable
        /// </summary>
        public TT_Entity TT08KEY_TT { get { return TT08KEY == null ? null : Context.TT.FindByTTKEY(TT08KEY); } }
        /// <summary>
        /// Link to 9th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT09KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT09KEY] => [TT_Entity].[TTKEY]
        /// Link to 9th template in timetable
        /// </summary>
        public TT_Entity TT09KEY_TT { get { return TT09KEY == null ? null : Context.TT.FindByTTKEY(TT09KEY); } }
        /// <summary>
        /// Link to 10th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT10KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT10KEY] => [TT_Entity].[TTKEY]
        /// Link to 10th template in timetable
        /// </summary>
        public TT_Entity TT10KEY_TT { get { return TT10KEY == null ? null : Context.TT.FindByTTKEY(TT10KEY); } }
        /// <summary>
        /// Link to 11th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT11KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT11KEY] => [TT_Entity].[TTKEY]
        /// Link to 11th template in timetable
        /// </summary>
        public TT_Entity TT11KEY_TT { get { return TT11KEY == null ? null : Context.TT.FindByTTKEY(TT11KEY); } }
        /// <summary>
        /// Link to 12th template in timetable [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT12KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT12KEY] => [TT_Entity].[TTKEY]
        /// Link to 12th template in timetable
        /// </summary>
        public TT_Entity TT12KEY_TT { get { return TT12KEY == null ? null : Context.TT.FindByTTKEY(TT12KEY); } }
        /// <summary>
        /// Link to 13th template in timetable (maximum) [Uppercase Alphanumeric: u8]
        /// </summary>
        public string TT13KEY { get; internal set; }
        /// <summary>
        /// Navigation property for [TT13KEY] => [TT_Entity].[TTKEY]
        /// Link to 13th template in timetable (maximum)
        /// </summary>
        public TT_Entity TT13KEY_TT { get { return TT13KEY == null ? null : Context.TT.FindByTTKEY(TT13KEY); } }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT01 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT02 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT03 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT04 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT05 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT06 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT07 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT08 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT09 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT10 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT11 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT12 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Quilts [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_QUILT13 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA01 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA02 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA03 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA04 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA05 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA06 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA07 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA08 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA09 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA10 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA11 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA12 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Extras [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXTRA13 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM01 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM02 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM03 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM04 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM05 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM06 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM07 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM08 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM09 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM10 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM11 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM12 { get; internal set; }
        /// <summary>
        /// Which templates displayed when editing in Exams [Uppercase Alphanumeric: u1]
        /// </summary>
        public string THVIEW_EXAM13 { get; internal set; }
        /// <summary>
        /// First day in the calendar [Date Time nullable: d]
        /// </summary>
        public DateTime? CALENDAR_START01 { get; internal set; }
        /// <summary>
        /// First day in the calendar [Date Time nullable: d]
        /// </summary>
        public DateTime? CALENDAR_START02 { get; internal set; }
        /// <summary>
        /// First day in the calendar [Date Time nullable: d]
        /// </summary>
        public DateTime? CALENDAR_START03 { get; internal set; }
        /// <summary>
        /// First day in the calendar [Date Time nullable: d]
        /// </summary>
        public DateTime? CALENDAR_START04 { get; internal set; }
        /// <summary>
        /// Last Day in calendar [Date Time nullable: d]
        /// </summary>
        public DateTime? CALENDAR_END01 { get; internal set; }
        /// <summary>
        /// Last Day in calendar [Date Time nullable: d]
        /// </summary>
        public DateTime? CALENDAR_END02 { get; internal set; }
        /// <summary>
        /// Last Day in calendar [Date Time nullable: d]
        /// </summary>
        public DateTime? CALENDAR_END03 { get; internal set; }
        /// <summary>
        /// Last Day in calendar [Date Time nullable: d]
        /// </summary>
        public DateTime? CALENDAR_END04 { get; internal set; }
        /// <summary>
        /// Display colour [Integer (32bit signed nullable): l]
        /// </summary>
        public int? CALENDAR_COLOUR { get; internal set; }
        /// <summary>
        /// Placement method R=rotate M=Day match [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_PLACE_METHOD { get; internal set; }
        /// <summary>
        /// Days quilt may be on the calendar [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_DAYS01 { get; internal set; }
        /// <summary>
        /// Days quilt may be on the calendar [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_DAYS02 { get; internal set; }
        /// <summary>
        /// Days quilt may be on the calendar [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_DAYS03 { get; internal set; }
        /// <summary>
        /// Days quilt may be on the calendar [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_DAYS04 { get; internal set; }
        /// <summary>
        /// Days quilt may be on the calendar [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_DAYS05 { get; internal set; }
        /// <summary>
        /// Days quilt may be on the calendar [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_DAYS06 { get; internal set; }
        /// <summary>
        /// Days quilt may be on the calendar [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_DAYS07 { get; internal set; }
        /// <summary>
        /// Row to place the quilt on [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CALENDAR_ROW { get; internal set; }
        /// <summary>
        /// View this quilt in the calendar [Uppercase Alphanumeric: u1]
        /// </summary>
        public string CALENDAR_VIEW { get; internal set; }
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
