using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year Levels
    /// </summary>
    public class KCY : EntityBase
    {
#region Navigation Property Cache
        private SF _TEACHER_SF;
        private SF _TEACHER_B_SF;
        private KCY _NEXT_YR_KCY;
#endregion

#region Field Properties
        /// <summary>
        /// Year level code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string KCYKEY { get; internal set; }
        /// <summary>
        /// Year level title
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Numeric year level value that supports array indexing and age validation
        /// </summary>
        public short? NUM_EQVT { get; internal set; }
        /// <summary>
        /// Short description
        /// [Alphanumeric (10)]
        /// </summary>
        public string SHORT_DESC { get; internal set; }
        /// <summary>
        /// Staff code of first or only year level Coordinator
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Staff code of second year level Coordinator (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER_B { get; internal set; }
        /// <summary>
        /// Year level to which promoted from this year level
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string NEXT_YR { get; internal set; }
        /// <summary>
        /// This year level is final year level at school? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string FINAL_YR { get; internal set; }
        /// <summary>
        /// Are CSF results required for this year level? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CSF_REQUIRED { get; internal set; }
        /// <summary>
        /// Are Half day absences recorded for this year? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string HALF_DAY_ABS { get; internal set; }
        /// <summary>
        /// Are Period absences recorded for this year? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERIOD_ABS { get; internal set; }
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
        /// Navigation property for [TEACHER] => [SF].[SFKEY]
        /// Staff code of first or only year level Coordinator
        /// </summary>
        public SF TEACHER_SF {
            get
            {
                if (TEACHER != null)
                {
                    if (_TEACHER_SF == null)
                    {
                        _TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                    }
                    return _TEACHER_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TEACHER_B] => [SF].[SFKEY]
        /// Staff code of second year level Coordinator (if any)
        /// </summary>
        public SF TEACHER_B_SF {
            get
            {
                if (TEACHER_B != null)
                {
                    if (_TEACHER_B_SF == null)
                    {
                        _TEACHER_B_SF = Context.SF.FindBySFKEY(TEACHER_B);
                    }
                    return _TEACHER_B_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [NEXT_YR] => [KCY].[KCYKEY]
        /// Year level to which promoted from this year level
        /// </summary>
        public KCY NEXT_YR_KCY {
            get
            {
                if (NEXT_YR != null)
                {
                    if (_NEXT_YR_KCY == null)
                    {
                        _NEXT_YR_KCY = Context.KCY.FindByKCYKEY(NEXT_YR);
                    }
                    return _NEXT_YR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
