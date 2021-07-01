using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCL : EduHubEntity
    {

        #region Navigation Property Cache

        private TH Cache_QUILT_TH;
        private SU Cache_SUBJECT_SU;
        private SF Cache_TEACHER01_SF;
        private SF Cache_TEACHER02_SF;
        private SM Cache_ROOM01_SM;
        private SM Cache_ROOM02_SM;
        private SCI Cache_CAMPUS_SCI;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<TXAS> Cache_SCLKEY_TXAS_SCL_LINK;

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
                if (QUILT == null)
                {
                    return null;
                }
                if (Cache_QUILT_TH == null)
                {
                    Cache_QUILT_TH = Context.TH.FindByTHKEY(QUILT);
                }

                return Cache_QUILT_TH;
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
                if (SUBJECT == null)
                {
                    return null;
                }
                if (Cache_SUBJECT_SU == null)
                {
                    Cache_SUBJECT_SU = Context.SU.FindBySUKEY(SUBJECT);
                }

                return Cache_SUBJECT_SU;
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
                if (TEACHER01 == null)
                {
                    return null;
                }
                if (Cache_TEACHER01_SF == null)
                {
                    Cache_TEACHER01_SF = Context.SF.FindBySFKEY(TEACHER01);
                }

                return Cache_TEACHER01_SF;
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
                if (TEACHER02 == null)
                {
                    return null;
                }
                if (Cache_TEACHER02_SF == null)
                {
                    Cache_TEACHER02_SF = Context.SF.FindBySFKEY(TEACHER02);
                }

                return Cache_TEACHER02_SF;
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
                if (ROOM01 == null)
                {
                    return null;
                }
                if (Cache_ROOM01_SM == null)
                {
                    Cache_ROOM01_SM = Context.SM.FindByROOM(ROOM01);
                }

                return Cache_ROOM01_SM;
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
                if (ROOM02 == null)
                {
                    return null;
                }
                if (Cache_ROOM02_SM == null)
                {
                    Cache_ROOM02_SM = Context.SM.FindByROOM(ROOM02);
                }

                return Cache_ROOM02_SM;
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

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// TXAS (Actual Sessions) related entities by [SCL.SCLKEY]-&gt;[TXAS.SCL_LINK]
        /// Class code
        /// </summary>
        public IReadOnlyList<TXAS> SCLKEY_TXAS_SCL_LINK
        {
            get
            {
                if (Cache_SCLKEY_TXAS_SCL_LINK == null &&
                    !Context.TXAS.TryFindBySCL_LINK(SCLKEY, out Cache_SCLKEY_TXAS_SCL_LINK))
                {
                    Cache_SCLKEY_TXAS_SCL_LINK = new List<TXAS>().AsReadOnly();
                }

                return Cache_SCLKEY_TXAS_SCL_LINK;
            }
        }

        #endregion

    }
}
