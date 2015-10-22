using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Members
    /// </summary>
    public partial class SAM : EntityBase
    {
#region Navigation Property Cache
        private SCA _ASSOC_NAME_SCA;
        private SAP _ASSOC_POSN_SAP;
        private UM _ADDRESSKEY_UM;
        private UM _MAILKEY_UM;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no
        /// </summary>
        public int SAMKEY { get; internal set; }
        /// <summary>
        /// (Was SOURCE) Table to which PERSON refers: NO=No existing record, SF=Staff member, DF=Family member, ST=Student, DN=Donor
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string PERSON_TYPE { get; internal set; }
        /// <summary>
        /// Code of person in table identified in PERSON_TYPE
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PERSON { get; internal set; }
        /// <summary>
        /// (If PERSON_TYPE indicates family) Which parent/guardian?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string WHICH_PARENT { get; internal set; }
        /// <summary>
        /// M or F
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string GENDER { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? BIRTHDATE { get; internal set; }
        /// <summary>
        /// Do you identify as an Aboriginal or Torres Strait Islander?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string KOORIE { get; internal set; }
        /// <summary>
        /// Were you or one of your parents born overseas?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PARENT_OS { get; internal set; }
        /// <summary>
        /// Do you speak a language other than English at home?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LOTE { get; internal set; }
        /// <summary>
        /// Do you have a culturally and linguistically diverse background?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LBOTE { get; internal set; }
        /// <summary>
        /// Do you identify as a person with a disability?
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string DISABILITY { get; internal set; }
        /// <summary>
        /// Association name
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string ASSOC_NAME { get; internal set; }
        /// <summary>
        /// Position within association
        /// [Uppercase Alphanumeric (25)]
        /// </summary>
        public string ASSOC_POSN { get; internal set; }
        /// <summary>
        /// Actual address
        /// </summary>
        public int? ADDRESSKEY { get; internal set; }
        /// <summary>
        /// Postal address
        /// </summary>
        public int? MAILKEY { get; internal set; }
        /// <summary>
        /// (Was HOME_EMAIL) Home e-mail
        /// [Alphanumeric (60)]
        /// </summary>
        public string HOME_E_MAIL { get; internal set; }
        /// <summary>
        /// Work phone
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string WORK_PHONE { get; internal set; }
        /// <summary>
        /// Work fax
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string WORK_FAX { get; internal set; }
        /// <summary>
        /// (Was WORK_EMAIL) Work e-mail
        /// [Alphanumeric (60)]
        /// </summary>
        public string WORK_E_MAIL { get; internal set; }
        /// <summary>
        /// Member's surname and title if not identified in PERSON
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// Member's first given name if not identified in PERSON
        /// [Titlecase (20)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Person title: Mr, Mrs, etc if not identified in PERSON
        /// [Titlecase (4)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Mobile phone no
        /// [Alphanumeric (20)]
        /// </summary>
        public string MOBILE_PHONE { get; internal set; }
        /// <summary>
        /// Association cheque account signatory? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SIGNATORY { get; internal set; }
        /// <summary>
        /// Memo
        /// [Memo]
        /// </summary>
        public string SAM_COMMENT { get; internal set; }
        /// <summary>
        /// Start date
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// End date
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
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
        /// SCA (School Associations) related entity by [SAM.ASSOC_NAME]-&gt;[SCA.SCAKEY]
        /// Association name
        /// </summary>
        public SCA ASSOC_NAME_SCA
        {
            get
            {
                if (ASSOC_NAME != null)
                {
                    if (_ASSOC_NAME_SCA == null)
                    {
                        _ASSOC_NAME_SCA = Context.SCA.FindBySCAKEY(ASSOC_NAME);
                    }
                    return _ASSOC_NAME_SCA;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SAP (School Association Positions) related entity by [SAM.ASSOC_POSN]-&gt;[SAP.SAPKEY]
        /// Position within association
        /// </summary>
        public SAP ASSOC_POSN_SAP
        {
            get
            {
                if (ASSOC_POSN != null)
                {
                    if (_ASSOC_POSN_SAP == null)
                    {
                        _ASSOC_POSN_SAP = Context.SAP.FindBySAPKEY(ASSOC_POSN);
                    }
                    return _ASSOC_POSN_SAP;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// UM (Addresses) related entity by [SAM.ADDRESSKEY]-&gt;[UM.UMKEY]
        /// Actual address
        /// </summary>
        public UM ADDRESSKEY_UM
        {
            get
            {
                if (ADDRESSKEY.HasValue)
                {
                    if (_ADDRESSKEY_UM == null)
                    {
                        _ADDRESSKEY_UM = Context.UM.FindByUMKEY(ADDRESSKEY.Value);
                    }
                    return _ADDRESSKEY_UM;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// UM (Addresses) related entity by [SAM.MAILKEY]-&gt;[UM.UMKEY]
        /// Postal address
        /// </summary>
        public UM MAILKEY_UM
        {
            get
            {
                if (MAILKEY.HasValue)
                {
                    if (_MAILKEY_UM == null)
                    {
                        _MAILKEY_UM = Context.UM.FindByUMKEY(MAILKEY.Value);
                    }
                    return _MAILKEY_UM;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// SAMA (Association Member Attendances) related entities by [SAMA.SAMAKEY]-&gt;[SAM.SAMKEY]
        /// </summary>
        public IReadOnlyList<SAMA> SAMA_SAMAKEY
        {
            get
            {
                return Context.SAM.FindSAMABySAMAKEY(SAMKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SAM_SCH_COUNCIL]-&gt;[SAM.SAMKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SAM_SCH_COUNCIL
        {
            get
            {
                return Context.SAM.FindSCIBySAM_SCH_COUNCIL(SAMKEY);
            }
        }

        /// <summary>
        /// SCI (School Information) related entities by [SCI.SCH_COUNCIL_PRES]-&gt;[SAM.SAMKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_SCH_COUNCIL_PRES
        {
            get
            {
                return Context.SAM.FindSCIBySCH_COUNCIL_PRES(SAMKEY);
            }
        }
#endregion
    }
}
