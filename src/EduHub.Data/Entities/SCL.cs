using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes
    /// </summary>
    public partial class SCL : EntityBase
    {
#region Navigation Property Cache
        private TH _QUILT_TH;
        private SU _SUBJECT_SU;
        private SF _TEACHER01_SF;
        private SF _TEACHER02_SF;
        private SM _ROOM01_SM;
        private SM _ROOM02_SM;
        private SCI _CAMPUS_SCI;
#endregion

#region Field Properties
        /// <summary>
        /// Class code
        /// [Uppercase Alphanumeric (17)]
        /// </summary>
        public string SCLKEY { get; internal set; }
        /// <summary>
        /// Applicable quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QUILT { get; internal set; }
        /// <summary>
        /// Subject code
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJECT { get; internal set; }
        /// <summary>
        /// Class number
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Teachers
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER01 { get; internal set; }
        /// <summary>
        /// Teachers
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER02 { get; internal set; }
        /// <summary>
        /// Rooms
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM01 { get; internal set; }
        /// <summary>
        /// Rooms
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM02 { get; internal set; }
        /// <summary>
        /// Number of sessions per timetable cycle
        /// </summary>
        public short? FREQUENCY { get; internal set; }
        /// <summary>
        /// Report print flags
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRINT_FLAGS01 { get; internal set; }
        /// <summary>
        /// Report print flags
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRINT_FLAGS02 { get; internal set; }
        /// <summary>
        /// Report print flags
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRINT_FLAGS03 { get; internal set; }
        /// <summary>
        /// Will period absences be recorded (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERIOD_ABSENCES { get; internal set; }
        /// <summary>
        /// Campus where the class is held
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Optional alias name eg 7A Eng, 7B Maths
        /// [Alphanumeric (10)]
        /// </summary>
        public string ALIAS { get; internal set; }
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
        /// TH (Timetable Quilt Headers) related entity by [SCL.QUILT]-&gt;[TH.THKEY]
        /// Applicable quilt
        /// </summary>
        public TH QUILT_TH
        {
            get
            {
                if (QUILT != null)
                {
                    if (_QUILT_TH == null)
                    {
                        _QUILT_TH = Context.TH.FindByTHKEY(QUILT);
                    }
                    return _QUILT_TH;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SU (Subjects) related entity by [SCL.SUBJECT]-&gt;[SU.SUKEY]
        /// Subject code
        /// </summary>
        public SU SUBJECT_SU
        {
            get
            {
                if (SUBJECT != null)
                {
                    if (_SUBJECT_SU == null)
                    {
                        _SUBJECT_SU = Context.SU.FindBySUKEY(SUBJECT);
                    }
                    return _SUBJECT_SU;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCL.TEACHER01]-&gt;[SF.SFKEY]
        /// Teachers
        /// </summary>
        public SF TEACHER01_SF
        {
            get
            {
                if (TEACHER01 != null)
                {
                    if (_TEACHER01_SF == null)
                    {
                        _TEACHER01_SF = Context.SF.FindBySFKEY(TEACHER01);
                    }
                    return _TEACHER01_SF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SCL.TEACHER02]-&gt;[SF.SFKEY]
        /// Teachers
        /// </summary>
        public SF TEACHER02_SF
        {
            get
            {
                if (TEACHER02 != null)
                {
                    if (_TEACHER02_SF == null)
                    {
                        _TEACHER02_SF = Context.SF.FindBySFKEY(TEACHER02);
                    }
                    return _TEACHER02_SF;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [SCL.ROOM01]-&gt;[SM.ROOM]
        /// Rooms
        /// </summary>
        public SM ROOM01_SM
        {
            get
            {
                if (ROOM01 != null)
                {
                    if (_ROOM01_SM == null)
                    {
                        _ROOM01_SM = Context.SM.FindByROOM(ROOM01);
                    }
                    return _ROOM01_SM;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SM (Rooms) related entity by [SCL.ROOM02]-&gt;[SM.ROOM]
        /// Rooms
        /// </summary>
        public SM ROOM02_SM
        {
            get
            {
                if (ROOM02 != null)
                {
                    if (_ROOM02_SM == null)
                    {
                        _ROOM02_SM = Context.SM.FindByROOM(ROOM02);
                    }
                    return _ROOM02_SM;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SCI (School Information) related entity by [SCL.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Campus where the class is held
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// TXAS (Actual Sessions) related entities by [TXAS.SCL_LINK]-&gt;[SCL.SCLKEY]
        /// </summary>
        public IReadOnlyList<TXAS> TXAS_SCL_LINK
        {
            get
            {
                return Context.SCL.FindTXASBySCL_LINK(SCLKEY);
            }
        }
#endregion
    }
}
