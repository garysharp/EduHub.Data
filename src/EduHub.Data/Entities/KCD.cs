using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Doctors
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCD : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<DF> Cache_KCDKEY_DF_DOCTOR;
        private IReadOnlyList<ST> Cache_KCDKEY_ST_DOCTOR;

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
        /// Doctor code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KCDKEY { get; internal set; }

        /// <summary>
        /// Name of doctor or practice
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Individual or Group practice
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DR_GROUP { get; internal set; }

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
        /// Suburb
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
        /// Link to KAP to allow for access to postcodes when entering an address: NOTE this should NOT be a foreign key to KAP as the user is free to enter different data in ADDRESS03 and POSTCODE
        /// [Alphanumeric (34)]
        /// </summary>
        public string KAP_LINK { get; internal set; }

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
        /// DF (Families) related entities by [KCD.KCDKEY]-&gt;[DF.DOCTOR]
        /// Doctor code
        /// </summary>
        public IReadOnlyList<DF> KCDKEY_DF_DOCTOR
        {
            get
            {
                if (Cache_KCDKEY_DF_DOCTOR == null &&
                    !Context.DF.TryFindByDOCTOR(KCDKEY, out Cache_KCDKEY_DF_DOCTOR))
                {
                    Cache_KCDKEY_DF_DOCTOR = new List<DF>().AsReadOnly();
                }

                return Cache_KCDKEY_DF_DOCTOR;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KCD.KCDKEY]-&gt;[ST.DOCTOR]
        /// Doctor code
        /// </summary>
        public IReadOnlyList<ST> KCDKEY_ST_DOCTOR
        {
            get
            {
                if (Cache_KCDKEY_ST_DOCTOR == null &&
                    !Context.ST.TryFindByDOCTOR(KCDKEY, out Cache_KCDKEY_ST_DOCTOR))
                {
                    Cache_KCDKEY_ST_DOCTOR = new List<ST>().AsReadOnly();
                }

                return Cache_KCDKEY_ST_DOCTOR;
            }
        }

        #endregion

    }
}
