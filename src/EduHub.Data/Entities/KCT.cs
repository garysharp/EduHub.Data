using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SG> Cache_KCTKEY_SG_ABS_TYPE;
        private IReadOnlyList<ST> Cache_KCTKEY_ST_INAC_ABS_CODE;
#if !EduHubScoped
        private IReadOnlyList<STRA> Cache_KCTKEY_STRA_ABS_TYPE;
#endif
        private IReadOnlyList<SXAB> Cache_KCTKEY_SXAB_AM_EXP_TYPE;
        private IReadOnlyList<SXAB> Cache_KCTKEY_SXAB_AM_ACT_TYPE;
        private IReadOnlyList<SXAB> Cache_KCTKEY_SXAB_PM_EXP_TYPE;
        private IReadOnlyList<SXAB> Cache_KCTKEY_SXAB_PM_ACT_TYPE;
        private IReadOnlyList<SXABCONV> Cache_KCTKEY_SXABCONV_AM_TYPE;
        private IReadOnlyList<SXABCONV> Cache_KCTKEY_SXABCONV_PM_TYPE;
        private IReadOnlyList<SXAS> Cache_KCTKEY_SXAS_EXP_ABS_TYPE;
        private IReadOnlyList<SXAS> Cache_KCTKEY_SXAS_ACT_ABS_TYPE;

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
        /// Absence type code
        /// </summary>
        public short KCTKEY { get; internal set; }

        /// <summary>
        /// Description of absence type
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Abbreviated description of absence type
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string ABBREV_DESC { get; internal set; }

        /// <summary>
        /// Is absence type curriculum-related? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CURRICULUM { get; internal set; }

        /// <summary>
        /// Corresponding DEET absence type code for statistics purposes
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DOE_TYPE { get; internal set; }

        /// <summary>
        /// Has this absence type been enabled by the school? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ENABLED { get; internal set; }

        /// <summary>
        /// Is this absence type pre-approved? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRE_APPROVED { get; internal set; }

        /// <summary>
        /// Value of Absence Rate, Negative or Positive Integer
        /// </summary>
        public short? ABS_RATE { get; internal set; }

        /// <summary>
        /// Allow SMS to be generated for this type
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SMS { get; internal set; }

        /// <summary>
        /// SMS message for this absence type
        /// [Alphanumeric (160)]
        /// </summary>
        public string SMS_MESSAGE { get; internal set; }

        /// <summary>
        /// Allow emails to be generated for this type
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string EMAIL { get; internal set; }

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

        #region Foreign Navigation Properties

        /// <summary>
        /// SG (Student Groupings) related entities by [KCT.KCTKEY]-&gt;[SG.ABS_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SG> KCTKEY_SG_ABS_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SG_ABS_TYPE == null &&
                    !Context.SG.TryFindByABS_TYPE(KCTKEY, out Cache_KCTKEY_SG_ABS_TYPE))
                {
                    Cache_KCTKEY_SG_ABS_TYPE = new List<SG>().AsReadOnly();
                }

                return Cache_KCTKEY_SG_ABS_TYPE;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KCT.KCTKEY]-&gt;[ST.INAC_ABS_CODE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<ST> KCTKEY_ST_INAC_ABS_CODE
        {
            get
            {
                if (Cache_KCTKEY_ST_INAC_ABS_CODE == null &&
                    !Context.ST.TryFindByINAC_ABS_CODE(KCTKEY, out Cache_KCTKEY_ST_INAC_ABS_CODE))
                {
                    Cache_KCTKEY_ST_INAC_ABS_CODE = new List<ST>().AsReadOnly();
                }

                return Cache_KCTKEY_ST_INAC_ABS_CODE;
            }
        }

#if !EduHubScoped
        /// <summary>
        /// STRA (Multiple Day Absences) related entities by [KCT.KCTKEY]-&gt;[STRA.ABS_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<STRA> KCTKEY_STRA_ABS_TYPE
        {
            get
            {
                if (Cache_KCTKEY_STRA_ABS_TYPE == null &&
                    !Context.STRA.TryFindByABS_TYPE(KCTKEY, out Cache_KCTKEY_STRA_ABS_TYPE))
                {
                    Cache_KCTKEY_STRA_ABS_TYPE = new List<STRA>().AsReadOnly();
                }

                return Cache_KCTKEY_STRA_ABS_TYPE;
            }
        }

#endif
        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [KCT.KCTKEY]-&gt;[SXAB.AM_EXP_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SXAB> KCTKEY_SXAB_AM_EXP_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SXAB_AM_EXP_TYPE == null &&
                    !Context.SXAB.TryFindByAM_EXP_TYPE(KCTKEY, out Cache_KCTKEY_SXAB_AM_EXP_TYPE))
                {
                    Cache_KCTKEY_SXAB_AM_EXP_TYPE = new List<SXAB>().AsReadOnly();
                }

                return Cache_KCTKEY_SXAB_AM_EXP_TYPE;
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [KCT.KCTKEY]-&gt;[SXAB.AM_ACT_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SXAB> KCTKEY_SXAB_AM_ACT_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SXAB_AM_ACT_TYPE == null &&
                    !Context.SXAB.TryFindByAM_ACT_TYPE(KCTKEY, out Cache_KCTKEY_SXAB_AM_ACT_TYPE))
                {
                    Cache_KCTKEY_SXAB_AM_ACT_TYPE = new List<SXAB>().AsReadOnly();
                }

                return Cache_KCTKEY_SXAB_AM_ACT_TYPE;
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [KCT.KCTKEY]-&gt;[SXAB.PM_EXP_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SXAB> KCTKEY_SXAB_PM_EXP_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SXAB_PM_EXP_TYPE == null &&
                    !Context.SXAB.TryFindByPM_EXP_TYPE(KCTKEY, out Cache_KCTKEY_SXAB_PM_EXP_TYPE))
                {
                    Cache_KCTKEY_SXAB_PM_EXP_TYPE = new List<SXAB>().AsReadOnly();
                }

                return Cache_KCTKEY_SXAB_PM_EXP_TYPE;
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [KCT.KCTKEY]-&gt;[SXAB.PM_ACT_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SXAB> KCTKEY_SXAB_PM_ACT_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SXAB_PM_ACT_TYPE == null &&
                    !Context.SXAB.TryFindByPM_ACT_TYPE(KCTKEY, out Cache_KCTKEY_SXAB_PM_ACT_TYPE))
                {
                    Cache_KCTKEY_SXAB_PM_ACT_TYPE = new List<SXAB>().AsReadOnly();
                }

                return Cache_KCTKEY_SXAB_PM_ACT_TYPE;
            }
        }

        /// <summary>
        /// SXABCONV (Converted Student Half-Day Absences) related entities by [KCT.KCTKEY]-&gt;[SXABCONV.AM_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SXABCONV> KCTKEY_SXABCONV_AM_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SXABCONV_AM_TYPE == null &&
                    !Context.SXABCONV.TryFindByAM_TYPE(KCTKEY, out Cache_KCTKEY_SXABCONV_AM_TYPE))
                {
                    Cache_KCTKEY_SXABCONV_AM_TYPE = new List<SXABCONV>().AsReadOnly();
                }

                return Cache_KCTKEY_SXABCONV_AM_TYPE;
            }
        }

        /// <summary>
        /// SXABCONV (Converted Student Half-Day Absences) related entities by [KCT.KCTKEY]-&gt;[SXABCONV.PM_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SXABCONV> KCTKEY_SXABCONV_PM_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SXABCONV_PM_TYPE == null &&
                    !Context.SXABCONV.TryFindByPM_TYPE(KCTKEY, out Cache_KCTKEY_SXABCONV_PM_TYPE))
                {
                    Cache_KCTKEY_SXABCONV_PM_TYPE = new List<SXABCONV>().AsReadOnly();
                }

                return Cache_KCTKEY_SXABCONV_PM_TYPE;
            }
        }

        /// <summary>
        /// SXAS (Student Scheduled Sessions) related entities by [KCT.KCTKEY]-&gt;[SXAS.EXP_ABS_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SXAS> KCTKEY_SXAS_EXP_ABS_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SXAS_EXP_ABS_TYPE == null &&
                    !Context.SXAS.TryFindByEXP_ABS_TYPE(KCTKEY, out Cache_KCTKEY_SXAS_EXP_ABS_TYPE))
                {
                    Cache_KCTKEY_SXAS_EXP_ABS_TYPE = new List<SXAS>().AsReadOnly();
                }

                return Cache_KCTKEY_SXAS_EXP_ABS_TYPE;
            }
        }

        /// <summary>
        /// SXAS (Student Scheduled Sessions) related entities by [KCT.KCTKEY]-&gt;[SXAS.ACT_ABS_TYPE]
        /// Absence type code
        /// </summary>
        public IReadOnlyList<SXAS> KCTKEY_SXAS_ACT_ABS_TYPE
        {
            get
            {
                if (Cache_KCTKEY_SXAS_ACT_ABS_TYPE == null &&
                    !Context.SXAS.TryFindByACT_ABS_TYPE(KCTKEY, out Cache_KCTKEY_SXAS_ACT_ABS_TYPE))
                {
                    Cache_KCTKEY_SXAS_ACT_ABS_TYPE = new List<SXAS>().AsReadOnly();
                }

                return Cache_KCTKEY_SXAS_ACT_ABS_TYPE;
            }
        }

        #endregion

    }
}
