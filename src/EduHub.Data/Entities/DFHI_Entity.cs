using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family History
    /// </summary>
    public class DFHI_Entity : EntityBase
    {
#region Navigation Property Cache
        private DF_Entity _FKEY_DF;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID (internal) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Family ID (dynamic link that gets updated whenever DF.DFKEY is also updated) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FKEY { get; internal set; }
        /// <summary>
        /// User ID of person creating the record [Uppercase Alphanumeric: u128]
        /// </summary>
        public string CREATION_USER { get; internal set; }
        /// <summary>
        /// Date of history record creation [Date Time nullable: d]
        /// </summary>
        public DateTime? CREATION_DATE { get; internal set; }
        /// <summary>
        /// Time of history record creation [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CREATION_TIME { get; internal set; }
        /// <summary>
        /// User ID of person making the record obsolete [Uppercase Alphanumeric: u128]
        /// </summary>
        public string OBSOLETE_USER { get; internal set; }
        /// <summary>
        /// End date of history record [Date Time nullable: d]
        /// </summary>
        public DateTime? OBSOLETE_DATE { get; internal set; }
        /// <summary>
        /// End time of history record [Integer (16bit signed nullable): i]
        /// </summary>
        public short? OBSOLETE_TIME { get; internal set; }
        /// <summary>
        /// Family ID (static link that retains its value even if DF.DFKEY is updated) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string HKEY { get; internal set; }
        /// <summary>
        /// Parent/guardian A first given name [Alphanumeric: a30]
        /// </summary>
        public string NAME_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A title [Titlecase: t4]
        /// </summary>
        public string TITLE_A { get; internal set; }
        /// <summary>
        /// Parent/guardian A gender: M=Male, F=Female [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER_A { get; internal set; }
        /// <summary>
        /// Parent/guardian B first given name [Alphanumeric: a30]
        /// </summary>
        public string NAME_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B surname [Uppercase Alphanumeric: u30]
        /// </summary>
        public string SURNAME_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B title [Titlecase: t4]
        /// </summary>
        public string TITLE_B { get; internal set; }
        /// <summary>
        /// Parent/guardian B gender: M=Male, F=Female [Uppercase Alphanumeric: u1]
        /// </summary>
        public string GENDER_B { get; internal set; }
        /// <summary>
        /// Home address ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? HOMEKEY { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas) [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas) [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas) [Alphanumeric: a30]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
        /// <summary>
        /// State code (if Australian address) [Uppercase Alphanumeric: u3]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Postcode [Alphanumeric: a4]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Phone no [Uppercase Alphanumeric: u20]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Change made to last record to produce this one [Alphanumeric: a80]
        /// </summary>
        public string CHANGE_MADE { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [FKEY] => [DF_Entity].[DFKEY]
        /// Family ID (dynamic link that gets updated whenever DF.DFKEY is also updated)
        /// </summary>
        public DF_Entity FKEY_DF {
            get
            {
                if (FKEY != null)
                {
                    if (_FKEY_DF == null)
                    {
                        _FKEY_DF = Context.DF.FindByDFKEY(FKEY);
                    }
                    return _FKEY_DF;
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
