using EduHub.Data.Entities;
using System;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Students
    /// </summary>
    public class V_ST : SeamlessViewsEntity
    {
        #region Backing Fields

        private readonly string _STKEY;
        private readonly string _STUDENT;
        private readonly string _PARENT1;
        private readonly string _LIVING_ARR;
        private readonly string _PARENT2;
        private readonly string _SURNAME;
        private readonly string _FIRST_NAME;
        private readonly string _SECOND_NAME;
        private readonly string _PREF_NAME;
        private readonly string _TITLE;
        private readonly string _AB_STUDY;
        private readonly string _EMA;
        private readonly DateTime? _BIRTHDATE;
        private readonly int? _CAMPUS;
        private readonly DateTime? _ENTRY;
        private readonly string _GENDER;
        private readonly string _HOME_GROUP;
        private readonly string _HOME_LANG;
        private readonly string _HOUSE;
        private readonly string _KOORIE;
        private readonly string _NOTES;
        private readonly string _RELATION_A01;
        private readonly string _SCHOOL_YEAR;
        private readonly short? _FAM_ORDER;
        private readonly string _DESCRIPTION;
        private readonly string _STATUS;
        private readonly byte[] _STUDENT_PIC;
        private readonly string _TAG;
        private readonly string _YOUTH_ALLOW;
        private readonly string _FAMILY;
        private readonly string _LOTE_HOME_CODE;
        private readonly string _SGB_FUNDED;
        private readonly string _INTERNATIONAL_ST_ID;
        private readonly string _CONTACT_A;
        private readonly string _IMMUNISE_CERT_STATUS;
        private readonly string _LBOTE;
        private readonly string _DFKEY;
        private readonly string _SURNAME_A;
        private readonly string _NAME_A;
        private readonly string _TITLE_A;
        private readonly string _E_MAIL_A;
        private readonly string _SURNAME_B;
        private readonly string _NAME_B;
        private readonly string _E_MAIL_B;
        private readonly string _TITLE_B;
        private readonly int? _MAILKEY;
        private readonly short? _NO_STUDENTS;
        private readonly string _LOTE_HOME_CODE_A;
        private readonly string _LOTE_HOME_CODE_B;
        private readonly string _OCCUP_STATUS_A;
        private readonly string _OCCUP_STATUS_B;
        private readonly string _WORK_CONT_A;
        private readonly string _BH_AT_HOME_A;
        private readonly string _BH_CONTACT_A;
        private readonly string _AH_AT_HOME_A;
        private readonly string _AH_CONTACT_A;
        private readonly string _PREF_MAIL_MECH_A;
        private readonly string _FAX_A;
        private readonly string _WORK_CONT_B;
        private readonly string _BH_AT_HOME_B;
        private readonly string _BH_CONTACT_B;
        private readonly string _AH_AT_HOME_B;
        private readonly string _AH_CONTACT_B;
        private readonly string _PREF_MAIL_MECH_B;
        private readonly string _FAX_B;
        private readonly string _FAM_OCCUP;
        private readonly int _UMKEY;
        private readonly string _ADDRESS01;
        private readonly string _ADDRESS02;
        private readonly string _ADDRESS03;
        private readonly string _POSTCODE;
        private readonly string _STATE;
        private readonly string _TELEPHONE;
        private readonly string _FAX;

        #endregion

        internal V_ST(SeamlessViewsContext Context, ST ST)
            : base(Context)
        {
            var KCY = ST.SCHOOL_YEAR_KCY;
            var DF = ST.FAMILY_DF;
            var UM = DF.MAILKEY_UM;

            _STKEY = ST.STKEY;

            // STUDENT
            _STUDENT = $"{ST.SURNAME} {ST.PREF_NAME} {ST.SCHOOL_YEAR} {ST.HOME_GROUP}";

            // PARENT1
            if (ST.CONTACT_A == "A")
            {
                _PARENT1 = $"{DF.TITLE_A} {DF.NAME_A.Substring(0, 1)} {DF.SURNAME_A}";
            }
            else if (ST.CONTACT_A == "B")
            {
                _PARENT1 = $"{DF.TITLE_B} {DF.NAME_B.Substring(0, 1)} {DF.SURNAME_B}";
            }
            else if (ST.CONTACT_A == "N")
            {
                _PARENT1 = null;
            }
            else if (DF.SURNAME_A == DF.SURNAME_B)
            {
                _PARENT1 = $"{DF.TITLE_A} {DF.NAME_A.Substring(0, 1)} & {DF.TITLE_B} {DF.NAME_B.Substring(0, 1)} {DF.SURNAME_A}";
            }
            else if (DF.SURNAME_A != null && DF.SURNAME_B != null)
            {
                _PARENT1 = $"{DF.TITLE_A} {DF.NAME_A.Substring(0, 1)} {DF.SURNAME_A} & {DF.TITLE_B} {DF.NAME_B.Substring(0, 1)} {DF.SURNAME_B}";
            }
            else if (DF.SURNAME_A == null && DF.SURNAME_B != null)
            {
                _PARENT1 = $"{DF.TITLE_B} {DF.NAME_B.Substring(0, 1)} {DF.SURNAME_B}";
            }
            else if (DF.SURNAME_B == null && DF.SURNAME_A != null)
            {
                _PARENT1 = $"{DF.TITLE_A} {DF.NAME_A.Substring(0, 1)} {DF.SURNAME_A}";
            }
            else
            {
                _PARENT1 = "STUDENT HAS NO LISTED PARENTS";
            }

            _LIVING_ARR = ST.LIVING_ARR;

            // PARENT2
            if (ST.CONTACT_A == "A")
            {
                _PARENT2 = $"{DF.TITLE_A} {DF.SURNAME_A}";
            }
            else if (ST.CONTACT_A == "B")
            {
                _PARENT2 = $"{DF.TITLE_B} {DF.SURNAME_B}";
            }
            else if (ST.CONTACT_A == "N")
            {
                _PARENT2 = null;
            }
            else if (DF.SURNAME_A == DF.SURNAME_B)
            {
                _PARENT2 = $"{DF.TITLE_A} & {DF.TITLE_B} {DF.SURNAME_A}";
            }
            else if (DF.SURNAME_A != null && DF.SURNAME_B != null)
            {
                _PARENT1 = $"{DF.TITLE_A} {DF.SURNAME_A} & {DF.TITLE_B} {DF.SURNAME_B}";
            }
            else if (DF.SURNAME_A == null && DF.SURNAME_B != null)
            {
                _PARENT1 = $"{DF.TITLE_B} {DF.SURNAME_B}";
            }
            else if (DF.SURNAME_B == null && DF.SURNAME_A != null)
            {
                _PARENT1 = $"{DF.TITLE_A} {DF.SURNAME_A}";
            }
            else
            {
                _PARENT1 = "STUDENT HAS NO LISTED PARENTS";
            }

            _SURNAME = ST.SURNAME;
            _FIRST_NAME = ST.FIRST_NAME;
            _SECOND_NAME = ST.SECOND_NAME;
            _PREF_NAME = ST.PREF_NAME;
            _TITLE = ST.TITLE;
            _AB_STUDY = ST.AB_STUDY;
            _EMA = ST.ED_ALLOW;
            _BIRTHDATE = ST.BIRTHDATE;
            _CAMPUS = ST.CAMPUS;
            _ENTRY = ST.ENTRY;
            _GENDER = ST.GENDER;
            _HOME_GROUP = ST.HOME_GROUP;
            _HOME_LANG = ST.HOME_LANG;
            _HOUSE = ST.HOUSE;
            _KOORIE = ST.KOORIE;
            _NOTES = ST.NOTES;
            _RELATION_A01 = ST.RELATION_A01;
            _SCHOOL_YEAR = ST.SCHOOL_YEAR;
            _FAM_ORDER = ST.FAM_ORDER;
            _DESCRIPTION = KCY.DESCRIPTION;
            _STATUS = ST.STATUS;
            _STUDENT_PIC = ST.STUDENT_PIC;
            _TAG = ST.TAG;
            _YOUTH_ALLOW = ST.YOUTH_ALLOW;
            _FAMILY = ST.FAMILY;
            _LOTE_HOME_CODE = ST.LOTE_HOME_CODE;
            _SGB_FUNDED = ST.SGB_FUNDED;
            _INTERNATIONAL_ST_ID = ST.INTERNATIONAL_ST_ID;
            _CONTACT_A = ST.CONTACT_A;
            _IMMUNISE_CERT_STATUS = ST.IMMUNISE_CERT_STATUS;
            _LBOTE = ST.LBOTE;
            _DFKEY = DF.DFKEY;
            _SURNAME_A = DF.SURNAME_A;
            _NAME_A = DF.NAME_A;
            _TITLE_A = DF.TITLE_A;
            _E_MAIL_A = DF.E_MAIL_A;
            _SURNAME_B = DF.SURNAME_B;
            _NAME_B = DF.NAME_B;
            _E_MAIL_B = DF.E_MAIL_B;
            _TITLE_B = DF.TITLE_B;
            _MAILKEY = DF.MAILKEY;
            _NO_STUDENTS = DF.NO_STUDENTS;
            _LOTE_HOME_CODE_A = DF.LOTE_HOME_CODE_A;
            _LOTE_HOME_CODE_B = DF.LOTE_HOME_CODE_B;
            _OCCUP_STATUS_A = DF.OCCUP_STATUS_A;
            _OCCUP_STATUS_B = DF.OCCUP_STATUS_B;
            _WORK_CONT_A = DF.WORK_CONT_A;
            _BH_AT_HOME_A = DF.BH_AT_HOME_A;
            _BH_CONTACT_A = DF.BH_CONTACT_A;
            _AH_AT_HOME_A = DF.AH_AT_HOME_A;
            _AH_CONTACT_A = DF.AH_CONTACT_A;
            _PREF_MAIL_MECH_A = DF.PREF_MAIL_MECH_A;
            _FAX_A = DF.FAX_A;
            _WORK_CONT_B = DF.WORK_CONT_B;
            _BH_AT_HOME_B = DF.BH_AT_HOME_B;
            _BH_CONTACT_B = DF.BH_CONTACT_B;
            _AH_AT_HOME_B = DF.AH_AT_HOME_B;
            _AH_CONTACT_B = DF.AH_CONTACT_B;
            _PREF_MAIL_MECH_B = DF.PREF_MAIL_MECH_B;
            _FAX_B = DF.FAX_B;
            _FAM_OCCUP = ST.FAMILY_OCCUPATION;
            _UMKEY = UM.UMKEY;
            _ADDRESS01 = UM.ADDRESS01;
            _ADDRESS02 = UM.ADDRESS02;
            _ADDRESS03 = UM.ADDRESS03;
            _POSTCODE = UM.POSTCODE;
            _STATE = UM.STATE;
            _TELEPHONE = UM.TELEPHONE;
            _FAX = UM.FAX;
        }

        /// <summary>
        /// Student ID
        /// </summary>
        public string STKEY { get { return _STKEY; } }
        /// <summary>
        /// Student Description
        /// </summary>
        public string STUDENT { get { return _STUDENT; } }
        /// <summary>
        /// Parent Description
        /// </summary>
        public string PARENT1 { get { return _PARENT1; } }
        /// <summary>
        /// Student's living arrangement (At home with TWO parents/guardians,Home with ONE parent/guardian,Arranged by State - Out-of-home-care,Homeless,Independent)
        /// </summary>
        public string LIVING_ARR { get { return _LIVING_ARR; } }
        /// <summary>
        /// Short Parent Description
        /// </summary>
        public string PARENT2 { get { return _PARENT2; } }
        /// <summary>
        /// Surname
        /// </summary>
        public string SURNAME { get { return _SURNAME; } }
        /// <summary>
        /// First given name
        /// </summary>
        public string FIRST_NAME { get { return _FIRST_NAME; } }
        /// <summary>
        /// Second given name
        /// </summary>
        public string SECOND_NAME { get { return _SECOND_NAME; } }
        /// <summary>
        /// Preferred name
        /// </summary>
        public string PREF_NAME { get { return _PREF_NAME; } }
        /// <summary>
        /// Title (eg Mr, Ms)
        /// </summary>
        public string TITLE { get { return _TITLE; } }
        /// <summary>
        /// Receives aboriginal allowance
        /// </summary>
        public string AB_STUDY { get { return _AB_STUDY; } }
        /// <summary>
        /// Is this student an applicant for, or in receipt of, CSEF? (Y/N)
        /// </summary>
        public string EMA { get { return _EMA; } }
        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime? BIRTHDATE { get { return _BIRTHDATE; } }
        /// <summary>
        /// Student's home campus
        /// </summary>
        public int? CAMPUS { get { return _CAMPUS; } }
        /// <summary>
        /// Date of entry to school
        /// </summary>
        public DateTime? ENTRY { get { return _ENTRY; } }
        /// <summary>
        /// Student Gender
        /// </summary>
        public string GENDER { get { return _GENDER; } }
        /// <summary>
        /// (Was FORM) Student's home group
        /// </summary>
        public string HOME_GROUP { get { return _HOME_GROUP; } }
        /// <summary>
        /// The language spoken at home: copied from DF record of family with whom student lives most
        /// </summary>
        public string HOME_LANG { get { return _HOME_LANG; } }
        /// <summary>
        /// Student's house group
        /// </summary>
        public string HOUSE { get { return _HOUSE; } }
        /// <summary>
        /// Indigenous background: K=Aboriginal, T=Torres Strait Islander, B=Both Aboriginal and Torres Strait Islander, N=No indigenous background, X=Declined to Respond
        /// </summary>
        public string KOORIE { get { return _KOORIE; } }
        /// <summary>
        /// Notes - any general purpose
        /// </summary>
        public string NOTES { get { return _NOTES; } }
        /// <summary>
        /// Relationships to Adults A and B in prime family
        /// </summary>
        public string RELATION_A01 { get { return _RELATION_A01; } }
        /// <summary>
        /// Year level
        /// </summary>
        public string SCHOOL_YEAR { get { return _SCHOOL_YEAR; } }
        /// <summary>
        /// Order in family (automatically maintained by software)
        /// </summary>
        public short? FAM_ORDER { get { return _FAM_ORDER; } }
        /// <summary>
        /// Year level title
        /// </summary>
        public string DESCRIPTION { get { return _DESCRIPTION; } }
        /// <summary>
        /// Student status: Active, Inactive, Future, Left school, Delete
        /// </summary>
        public string STATUS { get { return _STATUS; } }
        /// <summary>
        /// Student picture
        /// </summary>
        public byte[] STUDENT_PIC { get { return _STUDENT_PIC; } }
        /// <summary>
        /// Classifies students into groups for timetabling (use calendar yr of yr 6 or yr 12):if LEFT or *,student not considered a sibling of family for fee determination
        /// </summary>
        public string TAG { get { return _TAG; } }
        /// <summary>
        ///  Youth allowance (&lt;25)
        /// </summary>
        public string YOUTH_ALLOW { get { return _YOUTH_ALLOW; } }
        /// <summary>
        /// Student's prime family
        /// </summary>
        public string FAMILY { get { return _FAMILY; } }
        /// <summary>
        /// The Language other than English spoken at home by student
        /// </summary>
        public string LOTE_HOME_CODE { get { return _LOTE_HOME_CODE; } }
        /// <summary>
        /// Student is counted for Student Resource Package (SRP) funding
        /// </summary>
        public string SGB_FUNDED { get { return _SGB_FUNDED; } }
        /// <summary>
        /// International Student Id (7 Numeric)
        /// </summary>
        public string INTERNATIONAL_ST_ID { get { return _INTERNATIONAL_ST_ID; } }
        /// <summary>
        /// Which adult receives correspondence: A=Adult A, B=Adult B, C=Both, N=Neither
        /// </summary>
        public string CONTACT_A { get { return _CONTACT_A; } }
        /// <summary>
        /// C = complete, I = Incomplete, N = Not Sighted
        /// </summary>
        public string IMMUNISE_CERT_STATUS { get { return _IMMUNISE_CERT_STATUS; } }
        /// <summary>
        /// Language Background Other Than English
        /// </summary>
        public string LBOTE { get { return _LBOTE; } }
        /// <summary>
        /// Family ID
        /// </summary>
        public string DFKEY { get { return _DFKEY; } }
        /// <summary>
        /// Parent/guardian A surname (default SURNAME)
        /// </summary>
        public string SURNAME_A { get { return _SURNAME_A; } }
        /// <summary>
        /// Parent/guardian A first given name
        /// </summary>
        public string NAME_A { get { return _NAME_A; } }
        /// <summary>
        /// Parent/guardian A title
        /// </summary>
        public string TITLE_A { get { return _TITLE_A; } }
        /// <summary>
        /// Parent/guardian A e-mail address
        /// </summary>
        public string E_MAIL_A { get { return _E_MAIL_A; } }
        /// <summary>
        /// Parent/guardian B surname (default SURNAME)
        /// </summary>
        public string SURNAME_B { get { return _SURNAME_B; } }
        /// <summary>
        /// Parent/guardian B first given name
        /// </summary>
        public string NAME_B { get { return _NAME_B; } }
        /// <summary>
        /// Parent/guardian B e-mail address
        /// </summary>
        public string E_MAIL_B { get { return _E_MAIL_B; } }
        /// <summary>
        /// Parent/guardian B title
        /// </summary>
        public string TITLE_B { get { return _TITLE_B; } }
        /// <summary>
        /// Mail address ID
        /// </summary>
        public int? MAILKEY { get { return _MAILKEY; } }
        /// <summary>
        /// Number of current students for which this family is the PRIME family (automatically maintained by software) (cf NO_ASSOC_STUDENTS)
        /// </summary>
        public short? NO_STUDENTS { get { return _NO_STUDENTS; } }
        /// <summary>
        /// The Language other than English spoken at home by parent/guardian A
        /// </summary>
        public string LOTE_HOME_CODE_A { get { return _LOTE_HOME_CODE_A; } }
        /// <summary>
        /// The Language other than English spoken at home by parent/guardian B
        /// </summary>
        public string LOTE_HOME_CODE_B { get { return _LOTE_HOME_CODE_B; } }
        /// <summary>
        /// Parent/guardian A Occupation Status (A,B,C,D,N,U)
        /// </summary>
        public string OCCUP_STATUS_A { get { return _OCCUP_STATUS_A; } }
        /// <summary>
        /// Parent/guardian B Occupation Status (A,B,C,D,N,U)
        /// </summary>
        public string OCCUP_STATUS_B { get { return _OCCUP_STATUS_B; } }
        /// <summary>
        /// Can parent/guardian A be contacted at work? (Y/N)
        /// </summary>
        public string WORK_CONT_A { get { return _WORK_CONT_A; } }
        /// <summary>
        /// Parent/guardian A at home during business hours? (Y/N)
        /// </summary>
        public string BH_AT_HOME_A { get { return _BH_AT_HOME_A; } }
        /// <summary>
        /// Parent/guardian A telephone contact if not at home during business hours
        /// </summary>
        public string BH_CONTACT_A { get { return _BH_CONTACT_A; } }
        /// <summary>
        /// Parent/guardian A at home after hours? (Y/N)
        /// </summary>
        public string AH_AT_HOME_A { get { return _AH_AT_HOME_A; } }
        /// <summary>
        /// Parent/guardian A telephone contact if not at home after hours
        /// </summary>
        public string AH_CONTACT_A { get { return _AH_CONTACT_A; } }
        /// <summary>
        /// Parent/guardian A preferred mail mechanism: M=Mail, E=E-mail, F=Fax, P=Phone
        /// </summary>
        public string PREF_MAIL_MECH_A { get { return _PREF_MAIL_MECH_A; } }
        /// <summary>
        /// Parent/guardian A fax number
        /// </summary>
        public string FAX_A { get { return _FAX_A; } }
        /// <summary>
        /// Can parent/guardian B be contacted at work? (Y/N)
        /// </summary>
        public string WORK_CONT_B { get { return _WORK_CONT_B; } }
        /// <summary>
        /// Parent/guardian B at home during business hours? (Y/N)
        /// </summary>
        public string BH_AT_HOME_B { get { return _BH_AT_HOME_B; } }
        /// <summary>
        /// Parent/guardian B telephone contact if not at home during business hours
        /// </summary>
        public string BH_CONTACT_B { get { return _BH_CONTACT_B; } }
        /// <summary>
        /// Parent/guardian B at home after hours? (Y/N)
        /// </summary>
        public string AH_AT_HOME_B { get { return _AH_AT_HOME_B; } }
        /// <summary>
        /// Parent/guardian B telephone contact if not at home after hours
        /// </summary>
        public string AH_CONTACT_B { get { return _AH_CONTACT_B; } }
        /// <summary>
        /// Parent/guardian B preferred mail mechanism: M=Mail, E=E-mail, F=Fax, P=Phone
        /// </summary>
        public string PREF_MAIL_MECH_B { get { return _PREF_MAIL_MECH_B; } }
        /// <summary>
        /// Parent/guardian B fax number
        /// </summary>
        public string FAX_B { get { return _FAX_B; } }
        /// <summary>
        ///  Student's Family Occupation
        /// </summary>
        public string FAM_OCCUP { get { return _FAM_OCCUP; } }
        /// <summary>
        /// Address ID
        /// </summary>
        public int UMKEY { get { return _UMKEY; } }
        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// </summary>
        public string ADDRESS01 { get { return _ADDRESS01; } }
        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// </summary>
        public string ADDRESS02 { get { return _ADDRESS02; } }
        /// <summary>
        /// Three address lines (third line used for overseas addresses)
        /// </summary>
        public string ADDRESS03 { get { return _ADDRESS03; } }
        /// <summary>
        /// Postcode (if Australian address)
        /// </summary>
        public string POSTCODE { get { return _POSTCODE; } }
        /// <summary>
        /// State code (if Australian address)
        /// </summary>
        public string STATE { get { return _STATE; } }
        /// <summary>
        /// Phone no
        /// </summary>
        public string TELEPHONE { get { return _TELEPHONE; } }
        /// <summary>
        /// Fax no
        /// </summary>
        public string FAX { get { return _FAX; } }

    }
}
