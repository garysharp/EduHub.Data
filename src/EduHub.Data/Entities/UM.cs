using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Addresses
    /// </summary>
    public partial class UM : EntityBase
    {
#region Navigation Property Cache
        private KGT _COUNTRY_KGT;
#endregion

#region Field Properties
        /// <summary>
        /// Address ID
        /// </summary>
        public int UMKEY { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// [Alphanumeric (30)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
        /// <summary>
        /// State code (if Australian address)
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Postcode (if Australian address)
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Phone no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Home Mobile no
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// This phone no is silent? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SILENT { get; internal set; }
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
        /// Country (default '1101' code for Australia)
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string COUNTRY { get; internal set; }
        /// <summary>
        /// Australia Post address identifier
        /// </summary>
        public int? DPID { get; internal set; }
        /// <summary>
        /// Australia Post barcode numbers
        /// [Alphanumeric (37)]
        /// </summary>
        public string BARCODE { get; internal set; }
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
        /// KGT (Countries) related entity by [UM.COUNTRY]-&gt;[KGT.COUNTRY]
        /// Country (default '1101' code for Australia)
        /// </summary>
        public KGT COUNTRY_KGT
        {
            get
            {
                if (COUNTRY != null)
                {
                    if (_COUNTRY_KGT == null)
                    {
                        _COUNTRY_KGT = Context.KGT.FindByCOUNTRY(COUNTRY);
                    }
                    return _COUNTRY_KGT;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_HOMEKEY
        {
            get
            {
                return Context.UM.FindDFByHOMEKEY(UMKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_MAILKEY
        {
            get
            {
                return Context.UM.FindDFByMAILKEY(UMKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.BILLINGKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_BILLINGKEY
        {
            get
            {
                return Context.UM.FindDFByBILLINGKEY(UMKEY);
            }
        }

        /// <summary>
        /// PE (Employees) related entities by [PE.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<PE> PE_HOMEKEY
        {
            get
            {
                return Context.UM.FindPEByHOMEKEY(UMKEY);
            }
        }

        /// <summary>
        /// PE (Employees) related entities by [PE.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<PE> PE_MAILKEY
        {
            get
            {
                return Context.UM.FindPEByMAILKEY(UMKEY);
            }
        }

        /// <summary>
        /// PE (Employees) related entities by [PE.LEAVEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<PE> PE_LEAVEKEY
        {
            get
            {
                return Context.UM.FindPEByLEAVEKEY(UMKEY);
            }
        }

        /// <summary>
        /// SAM (School Association Members) related entities by [SAM.ADDRESSKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<SAM> SAM_ADDRESSKEY
        {
            get
            {
                return Context.UM.FindSAMByADDRESSKEY(UMKEY);
            }
        }

        /// <summary>
        /// SAM (School Association Members) related entities by [SAM.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<SAM> SAM_MAILKEY
        {
            get
            {
                return Context.UM.FindSAMByMAILKEY(UMKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.HOMEKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_HOMEKEY
        {
            get
            {
                return Context.UM.FindSFByHOMEKEY(UMKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.MAILKEY]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_MAILKEY
        {
            get
            {
                return Context.UM.FindSFByMAILKEY(UMKEY);
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [STTRIPS.AM_PICKUP_ADDRESS_ID]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<STTRIPS> STTRIPS_AM_PICKUP_ADDRESS_ID
        {
            get
            {
                return Context.UM.FindSTTRIPSByAM_PICKUP_ADDRESS_ID(UMKEY);
            }
        }

        /// <summary>
        /// STTRIPS (Student Trips) related entities by [STTRIPS.PM_SETDOWN_ADDRESS_ID]-&gt;[UM.UMKEY]
        /// </summary>
        public IReadOnlyList<STTRIPS> STTRIPS_PM_SETDOWN_ADDRESS_ID
        {
            get
            {
                return Context.UM.FindSTTRIPSByPM_SETDOWN_ADDRESS_ID(UMKEY);
            }
        }
#endregion
    }
}
