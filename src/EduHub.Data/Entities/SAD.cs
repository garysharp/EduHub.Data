using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accidents
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAD : EduHubEntity
    {

        #region Navigation Property Cache

        private SCI Cache_CAMPUS_SCI;
        private SM Cache_ROOM_SM;
        private SF Cache_AREA_DUTY_TEACHER_SF;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SADP> Cache_SADKEY_SADP_ACCIDENTID;
        private IReadOnlyList<SADW> Cache_SADKEY_SADW_ACCIDENTID;
        private IReadOnlyList<SAI> Cache_SADKEY_SAI_ACCIDENTID;

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
        /// Sequence no
        /// </summary>
        public int SADKEY { get; internal set; }

        /// <summary>
        /// Detailed description of accident
        /// [Memo]
        /// </summary>
        public string DETAIL_OUTLINE { get; internal set; }

        /// <summary>
        /// Date of accident
        /// </summary>
        public DateTime? ACCIDENT_DATE { get; internal set; }

        /// <summary>
        /// Time of accident
        /// </summary>
        public short? ACCIDENT_TIME { get; internal set; }

        /// <summary>
        /// Code identifying general activity at time of accident
        /// </summary>
        public short? GENERAL_ACTIVITY { get; internal set; }

        /// <summary>
        /// Code identifying more specific activity at time of accident
        /// </summary>
        public short? DETAILED_ACTIVITY { get; internal set; }

        /// <summary>
        /// Further details of activity at time of accident
        /// [Memo]
        /// </summary>
        public string OTHER_ACTIVITY_INFO { get; internal set; }

        /// <summary>
        /// Code identifying type of accident
        /// </summary>
        public short? DESCRIPTION { get; internal set; }

        /// <summary>
        /// Further details of type of accident
        /// [Memo]
        /// </summary>
        public string OTHER_DESC_INFO { get; internal set; }

        /// <summary>
        /// Code identifying area of school in which accident occurred
        /// </summary>
        public short? ACCIDENT_SITE { get; internal set; }

        /// <summary>
        /// Campus on which accident occured
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// Location of accident if not on campus
        /// [Memo]
        /// </summary>
        public string EXTERNAL_ADDRESS { get; internal set; }

        /// <summary>
        /// Room where accident occurred (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }

        /// <summary>
        /// Staff code of senior duty teacher in area of accident at the time
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string AREA_DUTY_TEACHER { get; internal set; }

        /// <summary>
        /// Full name of senior duty teacher in area of accident at the time
        /// [Alphanumeric (64)]
        /// </summary>
        public string DUTY_TEACHER_FULL_NAME { get; internal set; }

        /// <summary>
        /// Number of teachers on duty in area of accident at the time
        /// </summary>
        public short? TEACHERS_ON_DUTY { get; internal set; }

        /// <summary>
        /// Date on which this record was originally created
        /// </summary>
        public DateTime? CREATION_DATE { get; internal set; }

        /// <summary>
        /// Has the report of this accident been mailed to Department? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MAILED { get; internal set; }

        /// <summary>
        /// Full name of first or only person involved
        /// [Alphanumeric (64)]
        /// </summary>
        public string FIRST_INJURED_PARTY { get; internal set; }

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
        /// SCI (School Information) related entity by [SAD.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Campus on which accident occured
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
        /// SM (Rooms) related entity by [SAD.ROOM]-&gt;[SM.ROOM]
        /// Room where accident occurred (if any)
        /// </summary>
        public SM ROOM_SM
        {
            get
            {
                if (ROOM == null)
                {
                    return null;
                }
                if (Cache_ROOM_SM == null)
                {
                    Cache_ROOM_SM = Context.SM.FindByROOM(ROOM);
                }

                return Cache_ROOM_SM;
            }
        }

        /// <summary>
        /// SF (Staff) related entity by [SAD.AREA_DUTY_TEACHER]-&gt;[SF.SFKEY]
        /// Staff code of senior duty teacher in area of accident at the time
        /// </summary>
        public SF AREA_DUTY_TEACHER_SF
        {
            get
            {
                if (AREA_DUTY_TEACHER == null)
                {
                    return null;
                }
                if (Cache_AREA_DUTY_TEACHER_SF == null)
                {
                    Cache_AREA_DUTY_TEACHER_SF = Context.SF.FindBySFKEY(AREA_DUTY_TEACHER);
                }

                return Cache_AREA_DUTY_TEACHER_SF;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SADP (Accident Prevention Measures) related entities by [SAD.SADKEY]-&gt;[SADP.ACCIDENTID]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SADP> SADKEY_SADP_ACCIDENTID
        {
            get
            {
                if (Cache_SADKEY_SADP_ACCIDENTID == null &&
                    !Context.SADP.TryFindByACCIDENTID(SADKEY, out Cache_SADKEY_SADP_ACCIDENTID))
                {
                    Cache_SADKEY_SADP_ACCIDENTID = new List<SADP>().AsReadOnly();
                }

                return Cache_SADKEY_SADP_ACCIDENTID;
            }
        }

        /// <summary>
        /// SADW (Accident Witnesses) related entities by [SAD.SADKEY]-&gt;[SADW.ACCIDENTID]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SADW> SADKEY_SADW_ACCIDENTID
        {
            get
            {
                if (Cache_SADKEY_SADW_ACCIDENTID == null &&
                    !Context.SADW.TryFindByACCIDENTID(SADKEY, out Cache_SADKEY_SADW_ACCIDENTID))
                {
                    Cache_SADKEY_SADW_ACCIDENTID = new List<SADW>().AsReadOnly();
                }

                return Cache_SADKEY_SADW_ACCIDENTID;
            }
        }

        /// <summary>
        /// SAI (Accident Involvements/Sickbay Visits) related entities by [SAD.SADKEY]-&gt;[SAI.ACCIDENTID]
        /// Sequence no
        /// </summary>
        public IReadOnlyList<SAI> SADKEY_SAI_ACCIDENTID
        {
            get
            {
                if (Cache_SADKEY_SAI_ACCIDENTID == null &&
                    !Context.SAI.TryFindByACCIDENTID(SADKEY, out Cache_SADKEY_SAI_ACCIDENTID))
                {
                    Cache_SADKEY_SAI_ACCIDENTID = new List<SAI>().AsReadOnly();
                }

                return Cache_SADKEY_SAI_ACCIDENTID;
            }
        }

        #endregion

    }
}
