using EduHub.Data.Entities;
using System;
using System.Linq;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Risk
    /// </summary>
    public class V_RISK : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _FIRST_REG_NO;
        private readonly string _STKEY;
        private readonly string _ENTRY;
        private readonly string _SCHOOL_YEAR;
        private readonly string _HOME_GROUP;
        private readonly string _STUDENT;
        private readonly decimal _UNAPPROVED;
        private readonly decimal? _ATTEND_PERCENT;
        private readonly string _ENGREA;
        private readonly string _ENGWRI;
        private readonly string _MATNUM;
        private readonly string _MATSTR;
        private readonly decimal _INTERNAL_SUSPENSION;
        private readonly decimal _EXTERNAL_SUSPENSION;
        private readonly string _OCCUPATION_CODE;
        private readonly string _ALERTS;
        private readonly string _GENDER;
        private readonly string _LIVING_ARR;
        private readonly string _EXIT_DATE;
        private readonly string _EXIT_0;
        private readonly string _EXIT_6;

        #endregion

        internal V_RISK(SeamlessViewsContext Context, ST ST, bool KGDAvailable, bool KGGAvailable)
            : base(Context)
        {
            var year = DateTime.Now.Year;
            var eslCutOff = new DateTime(year, 1, 1);

            _FIRST_REG_NO = ST.FIRST_REG_NO;
            _STKEY = ST.STKEY;
            _ENTRY = ST.ENTRY?.ToString("MM/dd/yyyy");
            _SCHOOL_YEAR = ST.SCHOOL_YEAR;
            _HOME_GROUP = ST.HOME_GROUP;
            _STUDENT = $"{ST.SURNAME}, {ST.FIRST_NAME}";

            var attendance = ST.
                STKEY_SXAB_STKEY
                    .Where(sxab => sxab.ABSENCE_DATE.Value.Year == year)
                    .Select(sxab => new
                    {
                        sxab.STKEY,
                        sxab.ABSENCE_DATE,
                        AM = sxab.AM_ACT_TYPE_KCT,
                        PM = sxab.PM_ACT_TYPE_KCT,
                        Source = 0 // SXAB
                    })
                    .Concat(
                        ST.STKEY_SXABCONV_STKEY
                            .Where(conv => conv.ABSENCE_DATE.Value.Year == year)
                            .Select(conv => new
                            {
                                conv.STKEY,
                                conv.ABSENCE_DATE,
                                AM = conv.AM_TYPE_KCT,
                                PM = conv.PM_TYPE_KCT,
                                Source = 1 // SXABCONV
                            }))
                    .GroupBy(
                        r => new { r.STKEY, r.ABSENCE_DATE },
                        (k, g) => new
                        {
                            k.STKEY,
                            k.ABSENCE_DATE,
                            AM = g.Aggregate((r1, r2) => r2.AM.KCTKEY > 0 && (r1.Source == 1 && (r2.Source == 0 || r2.AM.KCTKEY > r1.AM.KCTKEY)) || (r1.Source == 0 && r2.Source == 0 && r2.AM.KCTKEY > r1.AM.KCTKEY) ? r2 : r1).AM,
                            PM = g.Aggregate((r1, r2) => r2.PM.KCTKEY > 0 && (r1.Source == 1 && (r2.Source == 0 || r2.PM.KCTKEY > r1.PM.KCTKEY)) || (r1.Source == 0 && r2.Source == 0 && r2.PM.KCTKEY > r1.PM.KCTKEY) ? r2 : r1).PM
                        }).ToList();
            var absences = attendance.Aggregate(0m, (v, r) => (r.AM.KCTKEY >= 200 && r.AM.CURRICULUM == "N" ? .5m : 0m) + (r.PM.KCTKEY >= 200 && r.PM.CURRICULUM == "N" ? .5m : 0m));
            var daysMarked = attendance.Aggregate(0m, (v, r) => (r.AM.KCTKEY > 0 ? .5m : 0m) + (r.PM.KCTKEY > 0 ? .5m : 0m));

            _UNAPPROVED = attendance.Aggregate(0m, (v, r) => (r.AM.KCTKEY == 208 || r.AM.KCTKEY == 300 || r.AM.KCTKEY == 500 ? .5m : 0m) + (r.PM.KCTKEY == 208 || r.PM.KCTKEY == 300 || r.PM.KCTKEY == 500 ? .5m : 0m));
            _ATTEND_PERCENT = daysMarked > 0m
                ? (daysMarked - absences) / daysMarked * 100m
                : 0m;
            _ENGREA = ST.STKEY_STVDI_SKEY.Where(r => r.VDIMENSION == "ENGREA" && r.SCORE != "NA").Aggregate((STVDI)null, (a, r) => a == null || r.YEAR_SEMESTER.CompareTo(a.YEAR_SEMESTER) > 0 ? r : a)?.SCORE ?? "";
            _ENGWRI = ST.STKEY_STVDI_SKEY.Where(r => r.VDIMENSION == "ENGWRI" && r.SCORE != "NA").Aggregate((STVDI)null, (a, r) => a == null || r.YEAR_SEMESTER.CompareTo(a.YEAR_SEMESTER) > 0 ? r : a)?.SCORE ?? "";
            _MATNUM = ST.STKEY_STVDI_SKEY.Where(r => r.VDIMENSION == "MATNUM" && r.SCORE != "NA").Aggregate((STVDI)null, (a, r) => a == null || r.YEAR_SEMESTER.CompareTo(a.YEAR_SEMESTER) > 0 ? r : a)?.SCORE ?? "";
            _MATSTR = ST.STKEY_STVDI_SKEY.Where(r => r.VDIMENSION == "MATSTR" && r.SCORE != "NA").Aggregate((STVDI)null, (a, r) => a == null || r.YEAR_SEMESTER.CompareTo(a.YEAR_SEMESTER) > 0 ? r : a)?.SCORE ?? "";
            _INTERNAL_SUSPENSION = attendance.Aggregate(0m, (v, r) => (r.AM.KCTKEY == 400 ? .5m : 0m) + (r.PM.KCTKEY == 400 ? .5m : 0m));
            _EXTERNAL_SUSPENSION = attendance.Aggregate(0m, (v, r) => (r.AM.KCTKEY == 401 ? .5m : 0m) + (r.PM.KCTKEY == 401 ? .5m : 0m));
            _OCCUPATION_CODE = ST.FAMILY_OCCUPATION;
            _ALERTS = $"{ST.KOORIE ?? "N"}{(ST.BIRTH_COUNTRY_KGT?.REFUGEE == "Y" ? "Y" : (ST.ESL(eslCutOff, 7) == "Y" && ST.VISA_SUBCLASS_KCV?.REFUGEE == "Y" ? "Y" : "N"))}{ST.DISABILITY ?? "N"}{ST.INTEGRATION ?? "N"}{ST.YOUTH_ALLOW ?? "N"}{ST.ACCESS_ALERT ?? "N"}{ST.RISK_ALERT ?? "N"}{ST.MEDICAL_ALERT ?? "N"}";
            _GENDER = ST.GENDER;
            _LIVING_ARR = ST.LIVING_ARR;
            _EXIT_DATE = ST.EXIT_DATE?.ToString("dd/MM/yyyy");

            // KGD isn't currently included in any typical eduHub services
            if (KGDAvailable)
            {
                _EXIT_0 = ST.STATUS == "LEFT"
                    ? (ST.SCHOOL_YEAR.CompareTo("09") < 0 || ST.SCHOOL_YEAR == "UG"
                        ? ST.NEXT_SCHOOL_SKGS?.NAME ?? ""
                        : ST.EXIT_DEST01_KGD?.DESCRIPTION ?? "")
                    : "";
            }
            else
            {
                _EXIT_0 = ST.STATUS == "LEFT"
                    ? ST.NEXT_SCHOOL_SKGS?.NAME ?? ""
                    : "";
            }

            // KGG isn't currently included in any typical eduHub services
            if (KGGAvailable)
            {
                _EXIT_6 = ST.EXIT_CAT01_KGG?.DESCRIPTION;
            }
            else
            {
                _EXIT_6 = null;
            }
        }

        /// <summary>
        /// Unique ID across state (School ID+REGISTRATION)
        /// </summary>
        public string FIRST_REG_NO { get { return _FIRST_REG_NO; } }
        /// <summary>
        /// Student ID
        /// </summary>
        public string STKEY { get { return _STKEY; } }
        /// <summary>
        /// Date of entry to school
        /// </summary>
        public string ENTRY { get { return _ENTRY; } }
        /// <summary>
        /// Year level
        /// </summary>
        public string SCHOOL_YEAR { get { return _SCHOOL_YEAR; } }
        /// <summary>
        /// Student's home group
        /// </summary>
        public string HOME_GROUP { get { return _HOME_GROUP; } }
        /// <summary>
        /// Student name
        /// </summary>
        public string STUDENT { get { return _STUDENT; } }
        /// <summary>
        /// Number of days of unapproved absence
        /// </summary>
        public decimal UNAPPROVED { get { return _UNAPPROVED; } }
        /// <summary>
        /// Attendance percentage
        /// </summary>
        public decimal? ATTEND_PERCENT { get { return _ATTEND_PERCENT; } }
        /// <summary>
        /// English Reading Dimension Score
        /// </summary>
        public string ENGREA { get { return _ENGREA; } }
        /// <summary>
        /// English Writing Dimension Score
        /// </summary>
        public string ENGWRI { get { return _ENGWRI; } }
        /// <summary>
        /// Mathematics Number Dimension Score
        /// </summary>
        public string MATNUM { get { return _MATNUM; } }
        /// <summary>
        /// Mathematics Structure Dimension Score
        /// </summary>
        public string MATSTR { get { return _MATSTR; } }
        /// <summary>
        /// Number of days of internal suspension
        /// </summary>
        public decimal INTERNAL_SUSPENSION { get { return _INTERNAL_SUSPENSION; } }
        /// <summary>
        /// Number of days of external suspension
        /// </summary>
        public decimal EXTERNAL_SUSPENSION { get { return _EXTERNAL_SUSPENSION; } }
        /// <summary>
        /// Student's Family Occupation
        /// </summary>
        public string OCCUPATION_CODE { get { return _OCCUPATION_CODE; } }
        /// <summary>
        /// Alerts
        /// </summary>
        public string ALERTS { get { return _ALERTS; } }
        /// <summary>
        /// Student Gender
        /// </summary>
        public string GENDER { get { return _GENDER; } }
        /// <summary>
        /// Student's living arrangement (At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent)
        /// </summary>
        public string LIVING_ARR { get { return _LIVING_ARR; } }
        /// <summary>
        /// Date of exit from school
        /// </summary>
        public string EXIT_DATE { get { return _EXIT_DATE; } }
        /// <summary>
        /// Exit Destination
        /// </summary>
        public string EXIT_0 { get { return _EXIT_0; } }
        /// <summary>
        /// Exit Category
        /// </summary>
        public string EXIT_6 { get { return _EXIT_6; } }
    }
}
