using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Courses
    /// </summary>
    public class SC_Entity : EntityBase
    {
#region Navigation Property Cache
        private SU_Entity _SUBJ01_SU;
        private SU_Entity _SUBJ02_SU;
        private SU_Entity _SUBJ03_SU;
        private SU_Entity _SUBJ04_SU;
        private SU_Entity _SUBJ05_SU;
        private SU_Entity _SUBJ06_SU;
        private SU_Entity _SUBJ07_SU;
        private SU_Entity _SUBJ08_SU;
        private SU_Entity _SUBJ09_SU;
        private SU_Entity _SUBJ10_SU;
        private SU_Entity _SUBJ11_SU;
        private SU_Entity _SUBJ12_SU;
        private SU_Entity _SUBJ13_SU;
        private SU_Entity _SUBJ14_SU;
        private SU_Entity _SUBJ15_SU;
        private SU_Entity _SUBJ16_SU;
        private SU_Entity _SUBJ17_SU;
        private SU_Entity _SUBJ18_SU;
        private SU_Entity _SUBJ19_SU;
        private SU_Entity _SUBJ20_SU;
        private KCY_Entity _SUBJECT_ACADEMIC_YEAR_KCY;
#endregion

#region Field Properties
        /// <summary>
        /// Course code (same type as SU) [Uppercase Alphanumeric: u5]
        /// </summary>
        public string COURSE { get; internal set; }
        /// <summary>
        /// Course name [Alphanumeric: a30]
        /// </summary>
        public string NAME { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ01 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ02 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ03 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ04 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ05 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ06 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ07 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ08 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ09 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ10 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ11 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ12 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ13 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ14 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ15 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ16 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ17 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ18 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ19 { get; internal set; }
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUBJ20 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS01 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS02 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS03 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS04 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS05 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS06 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS07 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS08 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS09 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS10 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS11 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS12 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS13 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS14 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS15 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS16 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS17 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS18 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS19 { get; internal set; }
        /// <summary>
        /// Class set [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CLASS20 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK01 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK02 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK03 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK04 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK05 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK06 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK07 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK08 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK09 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK10 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK11 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK12 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK13 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK14 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK15 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK16 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK17 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK18 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK19 { get; internal set; }
        /// <summary>
        /// Whether a student is locked into the class [Uppercase Alphanumeric: u1]
        /// </summary>
        public string LOCK20 { get; internal set; }
        /// <summary>
        /// Default academic year of subjects [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR { get; internal set; }
        /// <summary>
        /// Default semester of subjsects [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEMESTER { get; internal set; }
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
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SUBJ01] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ01_SU {
            get
            {
                if (SUBJ01 != null)
                {
                    if (_SUBJ01_SU == null)
                    {
                        _SUBJ01_SU = Context.SU.FindBySUKEY(SUBJ01);
                    }
                    return _SUBJ01_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ02] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ02_SU {
            get
            {
                if (SUBJ02 != null)
                {
                    if (_SUBJ02_SU == null)
                    {
                        _SUBJ02_SU = Context.SU.FindBySUKEY(SUBJ02);
                    }
                    return _SUBJ02_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ03] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ03_SU {
            get
            {
                if (SUBJ03 != null)
                {
                    if (_SUBJ03_SU == null)
                    {
                        _SUBJ03_SU = Context.SU.FindBySUKEY(SUBJ03);
                    }
                    return _SUBJ03_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ04] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ04_SU {
            get
            {
                if (SUBJ04 != null)
                {
                    if (_SUBJ04_SU == null)
                    {
                        _SUBJ04_SU = Context.SU.FindBySUKEY(SUBJ04);
                    }
                    return _SUBJ04_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ05] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ05_SU {
            get
            {
                if (SUBJ05 != null)
                {
                    if (_SUBJ05_SU == null)
                    {
                        _SUBJ05_SU = Context.SU.FindBySUKEY(SUBJ05);
                    }
                    return _SUBJ05_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ06] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ06_SU {
            get
            {
                if (SUBJ06 != null)
                {
                    if (_SUBJ06_SU == null)
                    {
                        _SUBJ06_SU = Context.SU.FindBySUKEY(SUBJ06);
                    }
                    return _SUBJ06_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ07] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ07_SU {
            get
            {
                if (SUBJ07 != null)
                {
                    if (_SUBJ07_SU == null)
                    {
                        _SUBJ07_SU = Context.SU.FindBySUKEY(SUBJ07);
                    }
                    return _SUBJ07_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ08] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ08_SU {
            get
            {
                if (SUBJ08 != null)
                {
                    if (_SUBJ08_SU == null)
                    {
                        _SUBJ08_SU = Context.SU.FindBySUKEY(SUBJ08);
                    }
                    return _SUBJ08_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ09] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ09_SU {
            get
            {
                if (SUBJ09 != null)
                {
                    if (_SUBJ09_SU == null)
                    {
                        _SUBJ09_SU = Context.SU.FindBySUKEY(SUBJ09);
                    }
                    return _SUBJ09_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ10] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ10_SU {
            get
            {
                if (SUBJ10 != null)
                {
                    if (_SUBJ10_SU == null)
                    {
                        _SUBJ10_SU = Context.SU.FindBySUKEY(SUBJ10);
                    }
                    return _SUBJ10_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ11] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ11_SU {
            get
            {
                if (SUBJ11 != null)
                {
                    if (_SUBJ11_SU == null)
                    {
                        _SUBJ11_SU = Context.SU.FindBySUKEY(SUBJ11);
                    }
                    return _SUBJ11_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ12] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ12_SU {
            get
            {
                if (SUBJ12 != null)
                {
                    if (_SUBJ12_SU == null)
                    {
                        _SUBJ12_SU = Context.SU.FindBySUKEY(SUBJ12);
                    }
                    return _SUBJ12_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ13] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ13_SU {
            get
            {
                if (SUBJ13 != null)
                {
                    if (_SUBJ13_SU == null)
                    {
                        _SUBJ13_SU = Context.SU.FindBySUKEY(SUBJ13);
                    }
                    return _SUBJ13_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ14] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ14_SU {
            get
            {
                if (SUBJ14 != null)
                {
                    if (_SUBJ14_SU == null)
                    {
                        _SUBJ14_SU = Context.SU.FindBySUKEY(SUBJ14);
                    }
                    return _SUBJ14_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ15] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ15_SU {
            get
            {
                if (SUBJ15 != null)
                {
                    if (_SUBJ15_SU == null)
                    {
                        _SUBJ15_SU = Context.SU.FindBySUKEY(SUBJ15);
                    }
                    return _SUBJ15_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ16] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ16_SU {
            get
            {
                if (SUBJ16 != null)
                {
                    if (_SUBJ16_SU == null)
                    {
                        _SUBJ16_SU = Context.SU.FindBySUKEY(SUBJ16);
                    }
                    return _SUBJ16_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ17] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ17_SU {
            get
            {
                if (SUBJ17 != null)
                {
                    if (_SUBJ17_SU == null)
                    {
                        _SUBJ17_SU = Context.SU.FindBySUKEY(SUBJ17);
                    }
                    return _SUBJ17_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ18] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ18_SU {
            get
            {
                if (SUBJ18 != null)
                {
                    if (_SUBJ18_SU == null)
                    {
                        _SUBJ18_SU = Context.SU.FindBySUKEY(SUBJ18);
                    }
                    return _SUBJ18_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ19] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ19_SU {
            get
            {
                if (SUBJ19 != null)
                {
                    if (_SUBJ19_SU == null)
                    {
                        _SUBJ19_SU = Context.SU.FindBySUKEY(SUBJ19);
                    }
                    return _SUBJ19_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ20] => [SU_Entity].[SUKEY]
        /// Subject code
        /// </summary>
        public SU_Entity SUBJ20_SU {
            get
            {
                if (SUBJ20 != null)
                {
                    if (_SUBJ20_SU == null)
                    {
                        _SUBJ20_SU = Context.SU.FindBySUKEY(SUBJ20);
                    }
                    return _SUBJ20_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR] => [KCY_Entity].[KCYKEY]
        /// Default academic year of subjects
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR_KCY {
            get
            {
                if (SUBJECT_ACADEMIC_YEAR != null)
                {
                    if (_SUBJECT_ACADEMIC_YEAR_KCY == null)
                    {
                        _SUBJECT_ACADEMIC_YEAR_KCY = Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR);
                    }
                    return _SUBJECT_ACADEMIC_YEAR_KCY;
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
