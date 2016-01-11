using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family History
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class DFHI : EduHubEntity
    {

        #region Navigation Property Cache

        private DF Cache_FKEY_DF;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return null;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Family ID (dynamic link that gets updated whenever DF.DFKEY is also updated)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string FKEY { get; internal set; }

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
        /// Family ID (static link that retains its value even if DF.DFKEY is updated)
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string HKEY { get; internal set; }

        /// <summary>
        /// Parent/guardian A first given name
        /// [Alphanumeric (30)]
        /// </summary>
        public string NAME_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A title
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE_A { get; internal set; }

        /// <summary>
        /// Parent/guardian A gender: M=Male, F=Female
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER_A { get; internal set; }

        /// <summary>
        /// Parent/guardian B first given name
        /// [Alphanumeric (30)]
        /// </summary>
        public string NAME_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B title
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE_B { get; internal set; }

        /// <summary>
        /// Parent/guardian B gender: M=Male, F=Female
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER_B { get; internal set; }

        /// <summary>
        /// Home address ID
        /// </summary>
        public int? HOMEKEY { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }

        /// <summary>
        /// Three address lines (third line used for overseas)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }

        /// <summary>
        /// State code (if Australian address)
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
        /// Change made to last record to produce this one
        /// [Alphanumeric (80)]
        /// </summary>
        public string CHANGE_MADE { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// DF (Families) related entity by [DFHI.FKEY]-&gt;[DF.DFKEY]
        /// Family ID (dynamic link that gets updated whenever DF.DFKEY is also updated)
        /// </summary>
        public DF FKEY_DF
        {
            get
            {
                if (Cache_FKEY_DF == null)
                {
                    Cache_FKEY_DF = Context.DF.FindByDFKEY(FKEY);
                }

                return Cache_FKEY_DF;
            }
        }

        #endregion

    }
}
