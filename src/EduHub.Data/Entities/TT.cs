using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Grid Templates
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TT : EduHubEntity
    {

        #region Navigation Property Cache

        private SCI Cache_CAMPUS_SCI;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR01_KCY;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR02_KCY;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR03_KCY;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR04_KCY;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR05_KCY;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR06_KCY;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR07_KCY;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR08_KCY;
        private KCY Cache_SUBJECT_ACADEMIC_YEAR09_KCY;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<TCTQ> Cache_TTKEY_TCTQ_GKEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT01KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT02KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT03KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT04KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT05KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT06KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT07KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT08KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT09KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT10KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT11KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT12KEY;
        private IReadOnlyList<TH> Cache_TTKEY_TH_TT13KEY;
        private IReadOnlyList<THTQ> Cache_TTKEY_THTQ_GKEY;
        private IReadOnlyList<TTEF> Cache_TTKEY_TTEF_GKEY;
        private IReadOnlyList<TTEI> Cache_TTKEY_TTEI_GKEY;
        private IReadOnlyList<TTEP> Cache_TTKEY_TTEP_GKEY;
        private IReadOnlyList<TTES> Cache_TTKEY_TTES_GKEY;
        private IReadOnlyList<TTEX> Cache_TTKEY_TTEX_GKEY;
        private IReadOnlyList<TTTG> Cache_TTKEY_TTTG_GKEY;

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
        /// Template code
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TTKEY { get; internal set; }

        /// <summary>
        /// Template title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Can this template be selected by general users
        /// [Alphanumeric (1)]
        /// </summary>
        public string SELECTABLE { get; internal set; }

        /// <summary>
        /// Campus
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG01 { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG02 { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG03 { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG04 { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG05 { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG06 { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG07 { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG08 { get; internal set; }

        /// <summary>
        /// Timetable reference tags
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string TAG09 { get; internal set; }

        /// <summary>
        /// Subject levy billing period (eg 199703 represents 97 term 3)
        /// </summary>
        public int? TRPERIOD { get; internal set; }

        /// <summary>
        /// Timetabling year/semester (eg 1998S1, 1998)
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string TTPERIOD { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR01 { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR02 { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR03 { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR04 { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR05 { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR06 { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR07 { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR08 { get; internal set; }

        /// <summary>
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR09 { get; internal set; }

        /// <summary>
        /// Semester/term/quarter: if SEMESTER in an SU record is zero or matches this value, the subject is eligible for this template
        /// </summary>
        public short? SEMESTER { get; internal set; }

        /// <summary>
        /// Timetabling year/semester when this reserve subject should be available
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string RESERVE { get; internal set; }

        /// <summary>
        /// Student course set
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string COSET { get; internal set; }

        /// <summary>
        /// Maximum number of grid rows (lines)
        /// </summary>
        public short? MAXROW { get; internal set; }

        /// <summary>
        /// Maximum number of grid columns
        /// </summary>
        public short? MAXCOL { get; internal set; }

        /// <summary>
        /// Relax value
        /// </summary>
        public short? RELAX { get; internal set; }

        /// <summary>
        /// Maximum number of drop-outs allowed
        /// </summary>
        public short? MAXDROP { get; internal set; }

        /// <summary>
        /// Maximum number of solutions to store
        /// </summary>
        public short? MAXSTORE { get; internal set; }

        /// <summary>
        /// Use teacher clashes? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UTEACH { get; internal set; }

        /// <summary>
        /// Use room clashes? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UROOM { get; internal set; }

        /// <summary>
        /// Use resource clashes? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string URESOURCES { get; internal set; }

        /// <summary>
        /// Use fixed grid? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UFIXED { get; internal set; }

        /// <summary>
        /// Use linked subjects? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ULINKS { get; internal set; }

        /// <summary>
        /// Use tied subjects? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UTIED { get; internal set; }

        /// <summary>
        /// Use min/maxline ranges? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string URANGE { get; internal set; }

        /// <summary>
        /// Strategy: High, Low, Both, All, Exhaustive, Reduction
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STRATEGY { get; internal set; }

        /// <summary>
        /// Sort subjects on grid line? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GRIDSORT { get; internal set; }

        /// <summary>
        /// Student put in smallest available set? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SHARE { get; internal set; }

        /// <summary>
        /// Students rearranged if set allocated to is full? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SHUFFLE { get; internal set; }

        /// <summary>
        /// Method of placing unit subjects into solution grid (don't use units/use units with placement restrictions/use units without placement restrictions)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string UUNITS { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public byte[] GSOLS { get; internal set; }

        /// <summary>
        /// Added Dec 1997
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HOMEGRID { get; internal set; }

        /// <summary>
        /// User value for priority of clash
        /// </summary>
        public short? TEACHER_CLASH_FACTOR { get; internal set; }

        /// <summary>
        /// (The higher the number the less
        /// </summary>
        public short? ROOM_CLASH_FACTOR { get; internal set; }

        /// <summary>
        /// likely that item will clash)
        /// </summary>
        public short? RESOURCE_CLASH_FACTOR { get; internal set; }

        /// <summary>
        /// (Student max 9, rest 999)
        /// </summary>
        public short? STUDENT_DROP_FACTOR { get; internal set; }

        /// <summary>
        /// Default for TTTG.MAXIMUM
        /// </summary>
        public short? MAX_CLASS_SIZE { get; internal set; }

        /// <summary>
        /// Maximum teacher clashes for a quilt generated grid
        /// </summary>
        public short? MAXTCLASH { get; internal set; }

        /// <summary>
        /// Maximum room clashes for a quilt generated grid
        /// </summary>
        public short? MAXRCLASH { get; internal set; }

        /// <summary>
        /// Maximum resource clashes for a quilt generated grid
        /// </summary>
        public short? MAXXCLASH { get; internal set; }

        /// <summary>
        /// Maximum balance factor for a quilt generated grid
        /// </summary>
        public short? MAXBALANCE { get; internal set; }

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
        /// SCI (School Information) related entity by [TT.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Campus
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR01]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR01_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR01 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR01_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR01_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR01);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR01_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR02]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR02_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR02 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR02_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR02_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR02);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR02_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR03]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR03_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR03 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR03_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR03_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR03);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR03_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR04]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR04_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR04 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR04_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR04_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR04);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR04_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR05]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR05_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR05 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR05_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR05_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR05);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR05_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR06]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR06_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR06 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR06_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR06_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR06);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR06_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR07]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR07_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR07 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR07_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR07_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR07);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR07_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR08]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR08_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR08 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR08_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR08_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR08);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR08_KCY;
            }
        }

        /// <summary>
        /// KCY (Year Levels) related entity by [TT.SUBJECT_ACADEMIC_YEAR09]-&gt;[KCY.KCYKEY]
        /// If SUBJECT_ACADEMIC_YEAR in an SU record is blank or matches one of these values, the subject is eligible for this template
        /// </summary>
        public KCY SUBJECT_ACADEMIC_YEAR09_KCY
        {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR09 == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_ACADEMIC_YEAR09_KCY == null)
                {
                    Cache_SUBJECT_ACADEMIC_YEAR09_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR09);
                }

                return Cache_SUBJECT_ACADEMIC_YEAR09_KCY;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TT.TTKEY]-&gt;[TCTQ.GKEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TCTQ> TTKEY_TCTQ_GKEY
        {
            get
            {
                if (Cache_TTKEY_TCTQ_GKEY == null &&
                    !Context.TCTQ.TryFindByGKEY(TTKEY, out Cache_TTKEY_TCTQ_GKEY))
                {
                    Cache_TTKEY_TCTQ_GKEY = new List<TCTQ>().AsReadOnly();
                }

                return Cache_TTKEY_TCTQ_GKEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT01KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT01KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT01KEY == null &&
                    !Context.TH.TryFindByTT01KEY(TTKEY, out Cache_TTKEY_TH_TT01KEY))
                {
                    Cache_TTKEY_TH_TT01KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT01KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT02KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT02KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT02KEY == null &&
                    !Context.TH.TryFindByTT02KEY(TTKEY, out Cache_TTKEY_TH_TT02KEY))
                {
                    Cache_TTKEY_TH_TT02KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT02KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT03KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT03KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT03KEY == null &&
                    !Context.TH.TryFindByTT03KEY(TTKEY, out Cache_TTKEY_TH_TT03KEY))
                {
                    Cache_TTKEY_TH_TT03KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT03KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT04KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT04KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT04KEY == null &&
                    !Context.TH.TryFindByTT04KEY(TTKEY, out Cache_TTKEY_TH_TT04KEY))
                {
                    Cache_TTKEY_TH_TT04KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT04KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT05KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT05KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT05KEY == null &&
                    !Context.TH.TryFindByTT05KEY(TTKEY, out Cache_TTKEY_TH_TT05KEY))
                {
                    Cache_TTKEY_TH_TT05KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT05KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT06KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT06KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT06KEY == null &&
                    !Context.TH.TryFindByTT06KEY(TTKEY, out Cache_TTKEY_TH_TT06KEY))
                {
                    Cache_TTKEY_TH_TT06KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT06KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT07KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT07KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT07KEY == null &&
                    !Context.TH.TryFindByTT07KEY(TTKEY, out Cache_TTKEY_TH_TT07KEY))
                {
                    Cache_TTKEY_TH_TT07KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT07KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT08KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT08KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT08KEY == null &&
                    !Context.TH.TryFindByTT08KEY(TTKEY, out Cache_TTKEY_TH_TT08KEY))
                {
                    Cache_TTKEY_TH_TT08KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT08KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT09KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT09KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT09KEY == null &&
                    !Context.TH.TryFindByTT09KEY(TTKEY, out Cache_TTKEY_TH_TT09KEY))
                {
                    Cache_TTKEY_TH_TT09KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT09KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT10KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT10KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT10KEY == null &&
                    !Context.TH.TryFindByTT10KEY(TTKEY, out Cache_TTKEY_TH_TT10KEY))
                {
                    Cache_TTKEY_TH_TT10KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT10KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT11KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT11KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT11KEY == null &&
                    !Context.TH.TryFindByTT11KEY(TTKEY, out Cache_TTKEY_TH_TT11KEY))
                {
                    Cache_TTKEY_TH_TT11KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT11KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT12KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT12KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT12KEY == null &&
                    !Context.TH.TryFindByTT12KEY(TTKEY, out Cache_TTKEY_TH_TT12KEY))
                {
                    Cache_TTKEY_TH_TT12KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT12KEY;
            }
        }

        /// <summary>
        /// TH (Timetable Quilt Headers) related entities by [TT.TTKEY]-&gt;[TH.TT13KEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TH> TTKEY_TH_TT13KEY
        {
            get
            {
                if (Cache_TTKEY_TH_TT13KEY == null &&
                    !Context.TH.TryFindByTT13KEY(TTKEY, out Cache_TTKEY_TH_TT13KEY))
                {
                    Cache_TTKEY_TH_TT13KEY = new List<TH>().AsReadOnly();
                }

                return Cache_TTKEY_TH_TT13KEY;
            }
        }

        /// <summary>
        /// THTQ (Timetable Quilt Entries) related entities by [TT.TTKEY]-&gt;[THTQ.GKEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<THTQ> TTKEY_THTQ_GKEY
        {
            get
            {
                if (Cache_TTKEY_THTQ_GKEY == null &&
                    !Context.THTQ.TryFindByGKEY(TTKEY, out Cache_TTKEY_THTQ_GKEY))
                {
                    Cache_TTKEY_THTQ_GKEY = new List<THTQ>().AsReadOnly();
                }

                return Cache_TTKEY_THTQ_GKEY;
            }
        }

        /// <summary>
        /// TTEF (Exam Staff) related entities by [TT.TTKEY]-&gt;[TTEF.GKEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TTEF> TTKEY_TTEF_GKEY
        {
            get
            {
                if (Cache_TTKEY_TTEF_GKEY == null &&
                    !Context.TTEF.TryFindByGKEY(TTKEY, out Cache_TTKEY_TTEF_GKEY))
                {
                    Cache_TTKEY_TTEF_GKEY = new List<TTEF>().AsReadOnly();
                }

                return Cache_TTKEY_TTEF_GKEY;
            }
        }

        /// <summary>
        /// TTEI (Exam Details) related entities by [TT.TTKEY]-&gt;[TTEI.GKEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TTEI> TTKEY_TTEI_GKEY
        {
            get
            {
                if (Cache_TTKEY_TTEI_GKEY == null &&
                    !Context.TTEI.TryFindByGKEY(TTKEY, out Cache_TTKEY_TTEI_GKEY))
                {
                    Cache_TTKEY_TTEI_GKEY = new List<TTEI>().AsReadOnly();
                }

                return Cache_TTKEY_TTEI_GKEY;
            }
        }

        /// <summary>
        /// TTEP (Exam Periods) related entities by [TT.TTKEY]-&gt;[TTEP.GKEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TTEP> TTKEY_TTEP_GKEY
        {
            get
            {
                if (Cache_TTKEY_TTEP_GKEY == null &&
                    !Context.TTEP.TryFindByGKEY(TTKEY, out Cache_TTKEY_TTEP_GKEY))
                {
                    Cache_TTKEY_TTEP_GKEY = new List<TTEP>().AsReadOnly();
                }

                return Cache_TTKEY_TTEP_GKEY;
            }
        }

        /// <summary>
        /// TTES (Exam Subjects) related entities by [TT.TTKEY]-&gt;[TTES.GKEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TTES> TTKEY_TTES_GKEY
        {
            get
            {
                if (Cache_TTKEY_TTES_GKEY == null &&
                    !Context.TTES.TryFindByGKEY(TTKEY, out Cache_TTKEY_TTES_GKEY))
                {
                    Cache_TTKEY_TTES_GKEY = new List<TTES>().AsReadOnly();
                }

                return Cache_TTKEY_TTES_GKEY;
            }
        }

        /// <summary>
        /// TTEX (Exam Grid) related entities by [TT.TTKEY]-&gt;[TTEX.GKEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TTEX> TTKEY_TTEX_GKEY
        {
            get
            {
                if (Cache_TTKEY_TTEX_GKEY == null &&
                    !Context.TTEX.TryFindByGKEY(TTKEY, out Cache_TTKEY_TTEX_GKEY))
                {
                    Cache_TTKEY_TTEX_GKEY = new List<TTEX>().AsReadOnly();
                }

                return Cache_TTKEY_TTEX_GKEY;
            }
        }

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [TT.TTKEY]-&gt;[TTTG.GKEY]
        /// Template code
        /// </summary>
        public IReadOnlyList<TTTG> TTKEY_TTTG_GKEY
        {
            get
            {
                if (Cache_TTKEY_TTTG_GKEY == null &&
                    !Context.TTTG.TryFindByGKEY(TTKEY, out Cache_TTKEY_TTTG_GKEY))
                {
                    Cache_TTKEY_TTTG_GKEY = new List<TTTG>().AsReadOnly();
                }

                return Cache_TTKEY_TTTG_GKEY;
            }
        }

        #endregion

    }
}
