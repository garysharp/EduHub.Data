using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Quilt Headers
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TH : EduHubEntity
    {

        #region Navigation Property Cache

        private TT Cache_TT01KEY_TT;
        private TT Cache_TT02KEY_TT;
        private TT Cache_TT03KEY_TT;
        private TT Cache_TT04KEY_TT;
        private TT Cache_TT05KEY_TT;
        private TT Cache_TT06KEY_TT;
        private TT Cache_TT07KEY_TT;
        private TT Cache_TT08KEY_TT;
        private TT Cache_TT09KEY_TT;
        private TT Cache_TT10KEY_TT;
        private TT Cache_TT11KEY_TT;
        private TT Cache_TT12KEY_TT;
        private TT Cache_TT13KEY_TT;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<KCC> Cache_THKEY_KCC_CURRENT_QUILT;
        private IReadOnlyList<SCI> Cache_THKEY_SCI_CURRENT_QUILT;
        private IReadOnlyList<SCL> Cache_THKEY_SCL_QUILT;
        private IReadOnlyList<SFAQ> Cache_THKEY_SFAQ_QKEY;
        private IReadOnlyList<SMAQ> Cache_THKEY_SMAQ_QKEY;
        private IReadOnlyList<TCTD> Cache_THKEY_TCTD_QKEY;
        private IReadOnlyList<TCTQ> Cache_THKEY_TCTQ_QKEY;
        private IReadOnlyList<THTN> Cache_THKEY_THTN_QKEY;
        private IReadOnlyList<THTQ> Cache_THKEY_THTQ_QKEY;

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
        /// Quilt code
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string THKEY { get; internal set; }

        /// <summary>
        /// Quilt title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Can this template be selected by general users
        /// [Alphanumeric (1)]
        /// </summary>
        public string SELECTABLE { get; internal set; }

        /// <summary>
        /// Number of rows
        /// </summary>
        public short? THROWS { get; internal set; }

        /// <summary>
        /// Number of columns
        /// </summary>
        public short? THCOLS { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL01 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL02 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL03 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL04 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL05 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL06 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL07 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL08 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL09 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL10 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL11 { get; internal set; }

        /// <summary>
        /// Labels for rows (periods)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_RLABEL12 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL01 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL02 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL03 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL04 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL05 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL06 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL07 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL08 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL09 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL10 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL11 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL12 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL13 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL14 { get; internal set; }

        /// <summary>
        /// Labels for columns (days)
        /// [Alphanumeric (10)]
        /// </summary>
        public string TH_CLABEL15 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD01 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD02 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD03 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD04 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD05 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD06 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD07 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD08 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD09 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD10 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD11 { get; internal set; }

        /// <summary>
        /// Teaching period for student absence
        /// </summary>
        public short? TEACHING_PERIOD12 { get; internal set; }

        /// <summary>
        /// Link to 1st template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT01KEY { get; internal set; }

        /// <summary>
        /// Link to 2nd template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT02KEY { get; internal set; }

        /// <summary>
        /// Link to 3rd template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT03KEY { get; internal set; }

        /// <summary>
        /// Link to 4th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT04KEY { get; internal set; }

        /// <summary>
        /// Link to 5th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT05KEY { get; internal set; }

        /// <summary>
        /// Link to 6th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT06KEY { get; internal set; }

        /// <summary>
        /// Link to 7th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT07KEY { get; internal set; }

        /// <summary>
        /// Link to 8th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT08KEY { get; internal set; }

        /// <summary>
        /// Link to 9th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT09KEY { get; internal set; }

        /// <summary>
        /// Link to 10th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT10KEY { get; internal set; }

        /// <summary>
        /// Link to 11th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT11KEY { get; internal set; }

        /// <summary>
        /// Link to 12th template in timetable
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT12KEY { get; internal set; }

        /// <summary>
        /// Link to 13th template in timetable (maximum)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TT13KEY { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT01 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT02 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT03 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT04 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT05 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT06 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT07 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT08 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT09 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT10 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT11 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT12 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Quilts
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_QUILT13 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA01 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA02 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA03 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA04 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA05 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA06 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA07 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA08 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA09 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA10 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA11 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA12 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Extras
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXTRA13 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM01 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM02 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM03 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM04 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM05 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM06 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM07 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM08 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM09 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM10 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM11 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM12 { get; internal set; }

        /// <summary>
        /// Which templates displayed when editing in Exams
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string THVIEW_EXAM13 { get; internal set; }

        /// <summary>
        /// First day in the calendar
        /// </summary>
        public DateTime? CALENDAR_START01 { get; internal set; }

        /// <summary>
        /// First day in the calendar
        /// </summary>
        public DateTime? CALENDAR_START02 { get; internal set; }

        /// <summary>
        /// First day in the calendar
        /// </summary>
        public DateTime? CALENDAR_START03 { get; internal set; }

        /// <summary>
        /// First day in the calendar
        /// </summary>
        public DateTime? CALENDAR_START04 { get; internal set; }

        /// <summary>
        /// Last Day in calendar
        /// </summary>
        public DateTime? CALENDAR_END01 { get; internal set; }

        /// <summary>
        /// Last Day in calendar
        /// </summary>
        public DateTime? CALENDAR_END02 { get; internal set; }

        /// <summary>
        /// Last Day in calendar
        /// </summary>
        public DateTime? CALENDAR_END03 { get; internal set; }

        /// <summary>
        /// Last Day in calendar
        /// </summary>
        public DateTime? CALENDAR_END04 { get; internal set; }

        /// <summary>
        /// Display colour
        /// </summary>
        public int? CALENDAR_COLOUR { get; internal set; }

        /// <summary>
        /// Placement method R=rotate M=Day match
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_PLACE_METHOD { get; internal set; }

        /// <summary>
        /// Days quilt may be on the calendar
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_DAYS01 { get; internal set; }

        /// <summary>
        /// Days quilt may be on the calendar
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_DAYS02 { get; internal set; }

        /// <summary>
        /// Days quilt may be on the calendar
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_DAYS03 { get; internal set; }

        /// <summary>
        /// Days quilt may be on the calendar
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_DAYS04 { get; internal set; }

        /// <summary>
        /// Days quilt may be on the calendar
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_DAYS05 { get; internal set; }

        /// <summary>
        /// Days quilt may be on the calendar
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_DAYS06 { get; internal set; }

        /// <summary>
        /// Days quilt may be on the calendar
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_DAYS07 { get; internal set; }

        /// <summary>
        /// Row to place the quilt on
        /// </summary>
        public short? CALENDAR_ROW { get; internal set; }

        /// <summary>
        /// View this quilt in the calendar
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CALENDAR_VIEW { get; internal set; }

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
        /// TT (Timetable Grid Templates) related entity by [TH.TT01KEY]-&gt;[TT.TTKEY]
        /// Link to 1st template in timetable
        /// </summary>
        public TT TT01KEY_TT
        {
            get
            {
                if (TT01KEY == null)
                {
                    return null;
                }
                if (Cache_TT01KEY_TT == null)
                {
                    Cache_TT01KEY_TT = Context.TT.FindByTTKEY(TT01KEY);
                }

                return Cache_TT01KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT02KEY]-&gt;[TT.TTKEY]
        /// Link to 2nd template in timetable
        /// </summary>
        public TT TT02KEY_TT
        {
            get
            {
                if (TT02KEY == null)
                {
                    return null;
                }
                if (Cache_TT02KEY_TT == null)
                {
                    Cache_TT02KEY_TT = Context.TT.FindByTTKEY(TT02KEY);
                }

                return Cache_TT02KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT03KEY]-&gt;[TT.TTKEY]
        /// Link to 3rd template in timetable
        /// </summary>
        public TT TT03KEY_TT
        {
            get
            {
                if (TT03KEY == null)
                {
                    return null;
                }
                if (Cache_TT03KEY_TT == null)
                {
                    Cache_TT03KEY_TT = Context.TT.FindByTTKEY(TT03KEY);
                }

                return Cache_TT03KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT04KEY]-&gt;[TT.TTKEY]
        /// Link to 4th template in timetable
        /// </summary>
        public TT TT04KEY_TT
        {
            get
            {
                if (TT04KEY == null)
                {
                    return null;
                }
                if (Cache_TT04KEY_TT == null)
                {
                    Cache_TT04KEY_TT = Context.TT.FindByTTKEY(TT04KEY);
                }

                return Cache_TT04KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT05KEY]-&gt;[TT.TTKEY]
        /// Link to 5th template in timetable
        /// </summary>
        public TT TT05KEY_TT
        {
            get
            {
                if (TT05KEY == null)
                {
                    return null;
                }
                if (Cache_TT05KEY_TT == null)
                {
                    Cache_TT05KEY_TT = Context.TT.FindByTTKEY(TT05KEY);
                }

                return Cache_TT05KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT06KEY]-&gt;[TT.TTKEY]
        /// Link to 6th template in timetable
        /// </summary>
        public TT TT06KEY_TT
        {
            get
            {
                if (TT06KEY == null)
                {
                    return null;
                }
                if (Cache_TT06KEY_TT == null)
                {
                    Cache_TT06KEY_TT = Context.TT.FindByTTKEY(TT06KEY);
                }

                return Cache_TT06KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT07KEY]-&gt;[TT.TTKEY]
        /// Link to 7th template in timetable
        /// </summary>
        public TT TT07KEY_TT
        {
            get
            {
                if (TT07KEY == null)
                {
                    return null;
                }
                if (Cache_TT07KEY_TT == null)
                {
                    Cache_TT07KEY_TT = Context.TT.FindByTTKEY(TT07KEY);
                }

                return Cache_TT07KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT08KEY]-&gt;[TT.TTKEY]
        /// Link to 8th template in timetable
        /// </summary>
        public TT TT08KEY_TT
        {
            get
            {
                if (TT08KEY == null)
                {
                    return null;
                }
                if (Cache_TT08KEY_TT == null)
                {
                    Cache_TT08KEY_TT = Context.TT.FindByTTKEY(TT08KEY);
                }

                return Cache_TT08KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT09KEY]-&gt;[TT.TTKEY]
        /// Link to 9th template in timetable
        /// </summary>
        public TT TT09KEY_TT
        {
            get
            {
                if (TT09KEY == null)
                {
                    return null;
                }
                if (Cache_TT09KEY_TT == null)
                {
                    Cache_TT09KEY_TT = Context.TT.FindByTTKEY(TT09KEY);
                }

                return Cache_TT09KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT10KEY]-&gt;[TT.TTKEY]
        /// Link to 10th template in timetable
        /// </summary>
        public TT TT10KEY_TT
        {
            get
            {
                if (TT10KEY == null)
                {
                    return null;
                }
                if (Cache_TT10KEY_TT == null)
                {
                    Cache_TT10KEY_TT = Context.TT.FindByTTKEY(TT10KEY);
                }

                return Cache_TT10KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT11KEY]-&gt;[TT.TTKEY]
        /// Link to 11th template in timetable
        /// </summary>
        public TT TT11KEY_TT
        {
            get
            {
                if (TT11KEY == null)
                {
                    return null;
                }
                if (Cache_TT11KEY_TT == null)
                {
                    Cache_TT11KEY_TT = Context.TT.FindByTTKEY(TT11KEY);
                }

                return Cache_TT11KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT12KEY]-&gt;[TT.TTKEY]
        /// Link to 12th template in timetable
        /// </summary>
        public TT TT12KEY_TT
        {
            get
            {
                if (TT12KEY == null)
                {
                    return null;
                }
                if (Cache_TT12KEY_TT == null)
                {
                    Cache_TT12KEY_TT = Context.TT.FindByTTKEY(TT12KEY);
                }

                return Cache_TT12KEY_TT;
            }
        }

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TH.TT13KEY]-&gt;[TT.TTKEY]
        /// Link to 13th template in timetable (maximum)
        /// </summary>
        public TT TT13KEY_TT
        {
            get
            {
                if (TT13KEY == null)
                {
                    return null;
                }
                if (Cache_TT13KEY_TT == null)
                {
                    Cache_TT13KEY_TT = Context.TT.FindByTTKEY(TT13KEY);
                }

                return Cache_TT13KEY_TT;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// KCC (Calendar Dates for Absences) related entities by [TH.THKEY]-&gt;[KCC.CURRENT_QUILT]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<KCC> THKEY_KCC_CURRENT_QUILT
        {
            get
            {
                if (Cache_THKEY_KCC_CURRENT_QUILT == null &&
                    !Context.KCC.TryFindByCURRENT_QUILT(THKEY, out Cache_THKEY_KCC_CURRENT_QUILT))
                {
                    Cache_THKEY_KCC_CURRENT_QUILT = new List<KCC>().AsReadOnly();
                }

                return Cache_THKEY_KCC_CURRENT_QUILT;
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [TH.THKEY]-&gt;[SCI.CURRENT_QUILT]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<SCI> THKEY_SCI_CURRENT_QUILT
        {
            get
            {
                if (Cache_THKEY_SCI_CURRENT_QUILT == null &&
                    !Context.SCI.TryFindByCURRENT_QUILT(THKEY, out Cache_THKEY_SCI_CURRENT_QUILT))
                {
                    Cache_THKEY_SCI_CURRENT_QUILT = new List<SCI>().AsReadOnly();
                }

                return Cache_THKEY_SCI_CURRENT_QUILT;
            }
        }

        /// <summary>
        /// SCL (Subject Classes) related entities by [TH.THKEY]-&gt;[SCL.QUILT]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<SCL> THKEY_SCL_QUILT
        {
            get
            {
                if (Cache_THKEY_SCL_QUILT == null &&
                    !Context.SCL.TryFindByQUILT(THKEY, out Cache_THKEY_SCL_QUILT))
                {
                    Cache_THKEY_SCL_QUILT = new List<SCL>().AsReadOnly();
                }

                return Cache_THKEY_SCL_QUILT;
            }
        }

        /// <summary>
        /// SFAQ (Staff Availability in Quilt) related entities by [TH.THKEY]-&gt;[SFAQ.QKEY]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<SFAQ> THKEY_SFAQ_QKEY
        {
            get
            {
                if (Cache_THKEY_SFAQ_QKEY == null &&
                    !Context.SFAQ.TryFindByQKEY(THKEY, out Cache_THKEY_SFAQ_QKEY))
                {
                    Cache_THKEY_SFAQ_QKEY = new List<SFAQ>().AsReadOnly();
                }

                return Cache_THKEY_SFAQ_QKEY;
            }
        }

        /// <summary>
        /// SMAQ (Room Availability in Quilt) related entities by [TH.THKEY]-&gt;[SMAQ.QKEY]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<SMAQ> THKEY_SMAQ_QKEY
        {
            get
            {
                if (Cache_THKEY_SMAQ_QKEY == null &&
                    !Context.SMAQ.TryFindByQKEY(THKEY, out Cache_THKEY_SMAQ_QKEY))
                {
                    Cache_THKEY_SMAQ_QKEY = new List<SMAQ>().AsReadOnly();
                }

                return Cache_THKEY_SMAQ_QKEY;
            }
        }

        /// <summary>
        /// TCTD (Calendar Period Information) related entities by [TH.THKEY]-&gt;[TCTD.QKEY]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<TCTD> THKEY_TCTD_QKEY
        {
            get
            {
                if (Cache_THKEY_TCTD_QKEY == null &&
                    !Context.TCTD.TryFindByQKEY(THKEY, out Cache_THKEY_TCTD_QKEY))
                {
                    Cache_THKEY_TCTD_QKEY = new List<TCTD>().AsReadOnly();
                }

                return Cache_THKEY_TCTD_QKEY;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TH.THKEY]-&gt;[TCTQ.QKEY]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<TCTQ> THKEY_TCTQ_QKEY
        {
            get
            {
                if (Cache_THKEY_TCTQ_QKEY == null &&
                    !Context.TCTQ.TryFindByQKEY(THKEY, out Cache_THKEY_TCTQ_QKEY))
                {
                    Cache_THKEY_TCTQ_QKEY = new List<TCTQ>().AsReadOnly();
                }

                return Cache_THKEY_TCTQ_QKEY;
            }
        }

        /// <summary>
        /// THTN (Timetable Labels) related entities by [TH.THKEY]-&gt;[THTN.QKEY]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<THTN> THKEY_THTN_QKEY
        {
            get
            {
                if (Cache_THKEY_THTN_QKEY == null &&
                    !Context.THTN.TryFindByQKEY(THKEY, out Cache_THKEY_THTN_QKEY))
                {
                    Cache_THKEY_THTN_QKEY = new List<THTN>().AsReadOnly();
                }

                return Cache_THKEY_THTN_QKEY;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [TH.THKEY]-&gt;[THTQ.QKEY]
        /// Quilt code
        /// </summary>
        public IReadOnlyList<THTQ> THKEY_THTQ_QKEY
        {
            get
            {
                if (Cache_THKEY_THTQ_QKEY == null &&
                    !Context.THTQ.TryFindByQKEY(THKEY, out Cache_THKEY_THTQ_QKEY))
                {
                    Cache_THKEY_THTQ_QKEY = new List<THTQ>().AsReadOnly();
                }

                return Cache_THKEY_THTQ_QKEY;
            }
        }

        #endregion

    }
}
