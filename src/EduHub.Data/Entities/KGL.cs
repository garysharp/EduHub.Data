using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Languages
    /// </summary>
    public partial class KGL : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Language code
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string KGLKEY { get; internal set; }
        /// <summary>
        /// Long description
        /// [Alphanumeric (75)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Are standard notices available in this language? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string NOTICES_AVAILABLE { get; internal set; }
        /// <summary>
        /// Numeric "Australian Standard Classification of Languages" as defined by Australian Bureau of Statistics
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ASCL { get; internal set; }
        /// <summary>
        /// CASES code to be used when returning data to Census
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string CASESKEY { get; internal set; }
        /// <summary>
        /// Is KGLKEY the code to which CASESKEY should be converted in converting from CASES to CASES21? (Y/blank)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CASES_CASES21_CONV { get; internal set; }
        /// <summary>
        /// Is this code obsolete (no longer in use)? (Y/blank)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OBSOLETE { get; internal set; }
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
        /// DF (Families) related entities by [DF.NATIVE_LANG_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_NATIVE_LANG_A
        {
            get
            {
                return Context.KGL.FindDFByNATIVE_LANG_A(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.OTHER_LANG_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_OTHER_LANG_A
        {
            get
            {
                return Context.KGL.FindDFByOTHER_LANG_A(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.LOTE_HOME_CODE_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_LOTE_HOME_CODE_A
        {
            get
            {
                return Context.KGL.FindDFByLOTE_HOME_CODE_A(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.NATIVE_LANG_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_NATIVE_LANG_B
        {
            get
            {
                return Context.KGL.FindDFByNATIVE_LANG_B(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.OTHER_LANG_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_OTHER_LANG_B
        {
            get
            {
                return Context.KGL.FindDFByOTHER_LANG_B(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.LOTE_HOME_CODE_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_LOTE_HOME_CODE_B
        {
            get
            {
                return Context.KGL.FindDFByLOTE_HOME_CODE_B(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.PREF_NOTICE_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_PREF_NOTICE_LANG
        {
            get
            {
                return Context.KGL.FindDFByPREF_NOTICE_LANG(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_EMERG_LANG01
        {
            get
            {
                return Context.KGL.FindDFByEMERG_LANG01(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_EMERG_LANG02
        {
            get
            {
                return Context.KGL.FindDFByEMERG_LANG02(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.EMERG_LANG03]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_EMERG_LANG03
        {
            get
            {
                return Context.KGL.FindDFByEMERG_LANG03(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.EMERG_LANG04]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_EMERG_LANG04
        {
            get
            {
                return Context.KGL.FindDFByEMERG_LANG04(KGLKEY);
            }
        }

        /// <summary>
        /// DF (Families) related entities by [DF.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<DF> DF_HOME_LANG
        {
            get
            {
                return Context.KGL.FindDFByHOME_LANG(KGLKEY);
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [OSCS.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<OSCS> OSCS_HOME_LANG
        {
            get
            {
                return Context.KGL.FindOSCSByHOME_LANG(KGLKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_LANG01
        {
            get
            {
                return Context.KGL.FindSFByLANG01(KGLKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_LANG02
        {
            get
            {
                return Context.KGL.FindSFByLANG02(KGLKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_EMERG_LANG01
        {
            get
            {
                return Context.KGL.FindSFByEMERG_LANG01(KGLKEY);
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [SF.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<SF> SF_EMERG_LANG02
        {
            get
            {
                return Context.KGL.FindSFByEMERG_LANG02(KGLKEY);
            }
        }

        /// <summary>
        /// SPU (Publications) related entities by [SPU.HOME_LANGUAGE]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<SPU> SPU_HOME_LANGUAGE
        {
            get
            {
                return Context.KGL.FindSPUByHOME_LANGUAGE(KGLKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_HOME_LANG
        {
            get
            {
                return Context.KGL.FindSTByHOME_LANG(KGLKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.EMERG_LANG01]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_EMERG_LANG01
        {
            get
            {
                return Context.KGL.FindSTByEMERG_LANG01(KGLKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.EMERG_LANG02]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_EMERG_LANG02
        {
            get
            {
                return Context.KGL.FindSTByEMERG_LANG02(KGLKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.LANGUAGE_PREVIOUS_SCHOOLING]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_LANGUAGE_PREVIOUS_SCHOOLING
        {
            get
            {
                return Context.KGL.FindSTByLANGUAGE_PREVIOUS_SCHOOLING(KGLKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.LOTE_HOME_CODE]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_LOTE_HOME_CODE
        {
            get
            {
                return Context.KGL.FindSTByLOTE_HOME_CODE(KGLKEY);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.ST_HOME_LANG]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<STRE> STRE_ST_HOME_LANG
        {
            get
            {
                return Context.KGL.FindSTREByST_HOME_LANG(KGLKEY);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.ST_LOTE_HOME_CODE]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<STRE> STRE_ST_LOTE_HOME_CODE
        {
            get
            {
                return Context.KGL.FindSTREByST_LOTE_HOME_CODE(KGLKEY);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.DF_LOTE_HOME_CODE_A]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<STRE> STRE_DF_LOTE_HOME_CODE_A
        {
            get
            {
                return Context.KGL.FindSTREByDF_LOTE_HOME_CODE_A(KGLKEY);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.DF_LOTE_HOME_CODE_B]-&gt;[KGL.KGLKEY]
        /// </summary>
        public IReadOnlyList<STRE> STRE_DF_LOTE_HOME_CODE_B
        {
            get
            {
                return Context.KGL.FindSTREByDF_LOTE_HOME_CODE_B(KGLKEY);
            }
        }
#endregion
    }
}
