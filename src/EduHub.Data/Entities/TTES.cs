using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Exam Subjects
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TTES : EduHubEntity
    {

        #region Navigation Property Cache

        private TT Cache_GKEY_TT;
        private SU Cache_SUBJ_SU;

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
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Grid involved in exam
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string GKEY { get; internal set; }

        /// <summary>
        /// Exam grid to which this subject belongs
        /// </summary>
        public int? TTEI_TID { get; internal set; }

        /// <summary>
        /// Subject
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ { get; internal set; }

        /// <summary>
        /// Number of times examined
        /// </summary>
        public short? UNITS { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE01 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE02 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE03 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE04 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE05 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE06 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE07 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE08 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE09 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE10 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE11 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE12 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE13 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE14 { get; internal set; }

        /// <summary>
        /// Include up to 15 classes (INLIST)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string INCLUDE15 { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// TT (Timetable Grid Templates) related entity by [TTES.GKEY]-&gt;[TT.TTKEY]
        /// Grid involved in exam
        /// </summary>
        public TT GKEY_TT
        {
            get
            {
                if (Cache_GKEY_TT == null)
                {
                    Cache_GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                }

                return Cache_GKEY_TT;
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [TTES.SUBJ]-&gt;[SU.SUKEY]
        /// Subject
        /// </summary>
        public SU SUBJ_SU
        {
            get
            {
                if (SUBJ == null)
                {
                    return null;
                }
                if (Cache_SUBJ_SU == null)
                {
                    Cache_SUBJ_SU = Context.SU.FindBySUKEY(SUBJ);
                }

                return Cache_SUBJ_SU;
            }
        }

        #endregion

    }
}
