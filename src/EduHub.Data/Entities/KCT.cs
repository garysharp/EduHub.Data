using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types
    /// </summary>
    public partial class KCT : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// SG (Student Groupings) related entities by [SG.ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SG> SG_ABS_TYPE
        {
            get
            {
                return Context.KCT.FindSGByABS_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.INAC_ABS_CODE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_INAC_ABS_CODE
        {
            get
            {
                return Context.KCT.FindSTByINAC_ABS_CODE(KCTKEY);
            }
        }

        /// <summary>
        /// STRA (Multiple Day Absences) related entities by [STRA.ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<STRA> STRA_ABS_TYPE
        {
            get
            {
                return Context.KCT.FindSTRAByABS_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [SXAB.AM_EXP_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SXAB> SXAB_AM_EXP_TYPE
        {
            get
            {
                return Context.KCT.FindSXABByAM_EXP_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [SXAB.AM_ACT_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SXAB> SXAB_AM_ACT_TYPE
        {
            get
            {
                return Context.KCT.FindSXABByAM_ACT_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [SXAB.PM_EXP_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SXAB> SXAB_PM_EXP_TYPE
        {
            get
            {
                return Context.KCT.FindSXABByPM_EXP_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// SXAB (Student Half-Day Absences) related entities by [SXAB.PM_ACT_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SXAB> SXAB_PM_ACT_TYPE
        {
            get
            {
                return Context.KCT.FindSXABByPM_ACT_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// SXABCONV (Converted Student Half-Day Absences) related entities by [SXABCONV.AM_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SXABCONV> SXABCONV_AM_TYPE
        {
            get
            {
                return Context.KCT.FindSXABCONVByAM_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// SXABCONV (Converted Student Half-Day Absences) related entities by [SXABCONV.PM_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SXABCONV> SXABCONV_PM_TYPE
        {
            get
            {
                return Context.KCT.FindSXABCONVByPM_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// SXAS (Student Scheduled Sessions) related entities by [SXAS.EXP_ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SXAS> SXAS_EXP_ABS_TYPE
        {
            get
            {
                return Context.KCT.FindSXASByEXP_ABS_TYPE(KCTKEY);
            }
        }

        /// <summary>
        /// SXAS (Student Scheduled Sessions) related entities by [SXAS.ACT_ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        public IReadOnlyList<SXAS> SXAS_ACT_ABS_TYPE
        {
            get
            {
                return Context.KCT.FindSXASByACT_ABS_TYPE(KCTKEY);
            }
        }
#endregion
    }
}
