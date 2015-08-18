using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student History
    /// </summary>
    public class SXHI : EntityBase
    {
#region Navigation Property Cache
        private ST _SKEY_ST;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }
        /// <summary>
        /// Student registration number
        /// </summary>
        public int? STREG { get; internal set; }
        /// <summary>
        /// Student ID (dynamic link that gets updated whenever ST.STKEY is also updated)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SKEY { get; internal set; }
        /// <summary>
        /// Student ID (static link that retains its value even if ST.STKEY is updated)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HKEY { get; internal set; }
        /// <summary>
        /// User ID of person creating the record
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string CREATION_USER { get; internal set; }
        /// <summary>
        /// Date of history record creation
        /// </summary>
        public DateTime? CREATION_DATE { get; internal set; }
        /// <summary>
        /// Time of history record creation
        /// </summary>
        public short? CREATION_TIME { get; internal set; }
        /// <summary>
        /// User ID of person making the record obsolete
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string OBSOLETE_USER { get; internal set; }
        /// <summary>
        /// End date of history record
        /// </summary>
        public DateTime? OBSOLETE_DATE { get; internal set; }
        /// <summary>
        /// End time of history record
        /// </summary>
        public short? OBSOLETE_TIME { get; internal set; }
        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First given name
        /// [Alphanumeric (20)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Student status: Active, Inactive, Future, Left school, Delete
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STATUS { get; internal set; }
        /// <summary>
        /// Year level
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_YEAR { get; internal set; }
        /// <summary>
        /// Student's home group + teacher name
        /// [Alphanumeric (40)]
        /// </summary>
        public string HOME_GROUP { get; internal set; }
        /// <summary>
        /// Student's prime family (ID + names)
        /// [Alphanumeric (60)]
        /// </summary>
        public string FAMILY { get; internal set; }
        /// <summary>
        /// Student's alternative family (ID + names)
        /// [Alphanumeric (60)]
        /// </summary>
        public string FAMB { get; internal set; }
        /// <summary>
        /// Student's additional contact family (ID + names)
        /// [Alphanumeric (60)]
        /// </summary>
        public string FAMC { get; internal set; }
        /// <summary>
        /// Australian residence status: P=Permanent, T=Temporary
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RESIDENT_STATUS { get; internal set; }
        /// <summary>
        /// Basis of Australian permanent residence status: E=Eligible for Australian passport, A=Holds Australian passport, P=Holds permanent residency visa
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERMANENT_BASIS { get; internal set; }
        /// <summary>
        /// Visa Sub-class
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string VISA_SUBCLASS { get; internal set; }
        /// <summary>
        /// Visa statistical code
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string VISA_STAT_CODE { get; internal set; }
        /// <summary>
        /// Visa expiry date
        /// </summary>
        public DateTime? VISA_EXPIRY { get; internal set; }
        /// <summary>
        /// Student is counted for Student Resource Package (SRP) funding
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SGB_FUNDED { get; internal set; }
        /// <summary>
        /// Time fraction SRP funding for current calendar year
        /// </summary>
        public double? SGB_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Time fraction of student's attendance
        /// </summary>
        public double? ACTUAL_TIME_FRACTION { get; internal set; }
        /// <summary>
        /// Access alert flag
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACCESS_ALERT { get; internal set; }
        /// <summary>
        /// Restricted access memo
        /// [Memo]
        /// </summary>
        public string ACCESS { get; internal set; }
        /// <summary>
        /// Type of access restriction
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string ACCESS_TYPE { get; internal set; }
        /// <summary>
        /// School (number + name) to which departed student has gone (if any)
        /// [Alphanumeric (50)]
        /// </summary>
        public string NEXT_SCHOOL { get; internal set; }
        /// <summary>
        /// Enrolment date
        /// </summary>
        public DateTime? ENTRY { get; internal set; }
        /// <summary>
        /// Date of exit from the school
        /// </summary>
        public DateTime? EXIT_DATE { get; internal set; }
        /// <summary>
        /// International Student Id (7 Numeric)
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string INTERNATIONAL_ST_ID { get; internal set; }
        /// <summary>
        /// Student second name
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Student gender
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// Student date of birth
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Victorian Student Number
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string VSN { get; internal set; }
        /// <summary>
        /// One of E=Enrol, C=Change, X = Exit, D=Delete
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VSR_TYPE { get; internal set; }
        /// <summary>
        /// The TID of the SXHI transaction superceded by this one
        /// </summary>
        public int? PREVIOUS_TID { get; internal set; }
        /// <summary>
        /// Change made to last record to produce this one
        /// [Alphanumeric (80)]
        /// </summary>
        public string CHANGE_MADE { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [SKEY] => [ST].[STKEY]
        /// Student ID (dynamic link that gets updated whenever ST.STKEY is also updated)
        /// </summary>
        public ST SKEY_ST {
            get
            {
                if (SKEY != null)
                {
                    if (_SKEY_ST == null)
                    {
                        _SKEY_ST = Context.ST.FindBySTKEY(SKEY);
                    }
                    return _SKEY_ST;
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
