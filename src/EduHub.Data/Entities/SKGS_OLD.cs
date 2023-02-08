#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Old SKGS Schools
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SKGS_OLD : EduHubEntity
    {

        #region Navigation Property Cache

        private SKGS Cache_NEW_SCHOOL_SKGS;

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
        /// School ID
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SCHOOL { get; internal set; }

        /// <summary>
        /// School Name
        /// [Alphanumeric (40)]
        /// </summary>
        public string NAME { get; internal set; }

        /// <summary>
        /// New School ID*DJB - Map to new SKGS values
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string NEW_SCHOOL { get; internal set; }

        /// <summary>
        /// School type: Primary, Secondary, Special, etc
        /// [Alphanumeric (33)]
        /// </summary>
        public string SCHOOL_TYPE { get; internal set; }

        /// <summary>
        /// School type: Government, Private, etc
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string ENTITY { get; internal set; }

        /// <summary>
        /// DEET-defined school ID
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SCHOOL_ID { get; internal set; }

        /// <summary>
        /// (Was SCHOOL_CAMPUS) Campus number
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string SCHOOL_NUMBER { get; internal set; }

        /// <summary>
        /// Campus type: Primary, etc
        /// [Alphanumeric (33)]
        /// </summary>
        public string CAMPUS_TYPE { get; internal set; }

        /// <summary>
        /// Campus name
        /// [Alphanumeric (40)]
        /// </summary>
        public string CAMPUS_NAME { get; internal set; }

        /// <summary>
        /// Region
        /// </summary>
        public short? REGION { get; internal set; }

        /// <summary>
        /// Name of Region
        /// [Alphanumeric (30)]
        /// </summary>
        public string REGION_NAME { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Suburb name
        /// [Alphanumeric (30)]
        /// </summary>
        public string SUBURB { get; internal set; }

        /// <summary>
        /// State code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }

        /// <summary>
        /// Postcode
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }

        /// <summary>
        /// Phone no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE { get; internal set; }

        /// <summary>
        /// Fax no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string FAX { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILING_ADDRESS01 { get; internal set; }

        /// <summary>
        /// Two address lines
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILING_ADDRESS02 { get; internal set; }

        /// <summary>
        /// Suburb name for Mailing
        /// [Alphanumeric (30)]
        /// </summary>
        public string MAILING_SUBURB { get; internal set; }

        /// <summary>
        /// State code for Mailing
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string MAILING_STATE { get; internal set; }

        /// <summary>
        /// Postcode for Mailing
        /// [Alphanumeric (4)]
        /// </summary>
        public string MAILING_POSTCODE { get; internal set; }

        /// <summary>
        /// Two address lines for Delivery
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELIVERY_ADDRESS01 { get; internal set; }

        /// <summary>
        /// Two address lines for Delivery
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELIVERY_ADDRESS02 { get; internal set; }

        /// <summary>
        /// Suburb name for Delivery
        /// [Alphanumeric (30)]
        /// </summary>
        public string DELIVERY_SUBURB { get; internal set; }

        /// <summary>
        /// State code for Delivery
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string DELIVERY_STATE { get; internal set; }

        /// <summary>
        /// Postcode for Delivery
        /// [Alphanumeric (4)]
        /// </summary>
        public string DELIVERY_POSTCODE { get; internal set; }

        /// <summary>
        /// Phone no. for Delivery
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string DELIVERY_TELEPHONE { get; internal set; }

        /// <summary>
        /// Fax no for Delivery
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string DELIVERY_FAX { get; internal set; }

        /// <summary>
        /// (Was E_MAIL_ADDRESS) E-mail address
        /// [Alphanumeric (255)]
        /// </summary>
        public string E_MAIL { get; internal set; }

        /// <summary>
        /// Internet address
        /// [Alphanumeric (255)]
        /// </summary>
        public string INTERNET_ADDRESS { get; internal set; }

        /// <summary>
        /// CASES 21 release no
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string CASES21_RELEASE { get; internal set; }

        /// <summary>
        /// Melway, VicRoads, Country Fire Authority, etc
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MAP_TYPE { get; internal set; }

        /// <summary>
        /// Map no
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAP_NUM { get; internal set; }

        /// <summary>
        /// Horizontal grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string X_AXIS { get; internal set; }

        /// <summary>
        /// Vertical grid reference
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string Y_AXIS { get; internal set; }

        /// <summary>
        /// School Principal's Title: Mr, Mrs, etc
        /// [Titlecase (4)]
        /// </summary>
        public string SCH_PRINCIPAL_SALUTATION { get; internal set; }

        /// <summary>
        /// School Principal's First Name
        /// [Titlecase (20)]
        /// </summary>
        public string SCH_PRINCIPAL_FIRST_NAME { get; internal set; }

        /// <summary>
        /// School Principal's Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SCH_PRINCIPAL_SURNAME { get; internal set; }

        /// <summary>
        /// School Principal's Phone no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string SCH_PRINCIPAL_TELEPHONE { get; internal set; }

        /// <summary>
        /// Campus Principal's title: Mr, Mrs, etc
        /// [Titlecase (4)]
        /// </summary>
        public string SALUTATION { get; internal set; }

        /// <summary>
        /// Campus Principal's surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }

        /// <summary>
        /// Campus Principal's first given name
        /// [Titlecase (20)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }

        /// <summary>
        /// School closed? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CLOSED { get; internal set; }

        /// <summary>
        /// Concurrent enrolment Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CONCURRENT_ENROL { get; internal set; }

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
        /// SKGS (Schools) related entity by [SKGS_OLD.NEW_SCHOOL]-&gt;[SKGS.SCHOOL]
        /// New School ID*DJB - Map to new SKGS values
        /// </summary>
        public SKGS NEW_SCHOOL_SKGS
        {
            get
            {
                if (NEW_SCHOOL == null)
                {
                    return null;
                }
                if (Cache_NEW_SCHOOL_SKGS == null)
                {
                    Cache_NEW_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(NEW_SCHOOL);
                }

                return Cache_NEW_SCHOOL_SKGS;
            }
        }

        #endregion

    }
}
#endif
