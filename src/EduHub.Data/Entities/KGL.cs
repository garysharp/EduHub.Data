using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Languages
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGL : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<DF> Cache_KGLKEY_DF_NATIVE_LANG_A;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_OTHER_LANG_A;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_LOTE_HOME_CODE_A;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_NATIVE_LANG_B;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_OTHER_LANG_B;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_LOTE_HOME_CODE_B;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_PREF_NOTICE_LANG;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_EMERG_LANG01;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_EMERG_LANG02;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_EMERG_LANG03;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_EMERG_LANG04;
        private IReadOnlyList<DF> Cache_KGLKEY_DF_HOME_LANG;
        private IReadOnlyList<OSCS> Cache_KGLKEY_OSCS_HOME_LANG;
        private IReadOnlyList<SF> Cache_KGLKEY_SF_LANG01;
        private IReadOnlyList<SF> Cache_KGLKEY_SF_LANG02;
        private IReadOnlyList<SF> Cache_KGLKEY_SF_EMERG_LANG01;
        private IReadOnlyList<SF> Cache_KGLKEY_SF_EMERG_LANG02;
        private IReadOnlyList<SPU> Cache_KGLKEY_SPU_HOME_LANGUAGE;
        private IReadOnlyList<ST> Cache_KGLKEY_ST_HOME_LANG;
        private IReadOnlyList<ST> Cache_KGLKEY_ST_EMERG_LANG01;
        private IReadOnlyList<ST> Cache_KGLKEY_ST_EMERG_LANG02;
        private IReadOnlyList<ST> Cache_KGLKEY_ST_LANGUAGE_PREVIOUS_SCHOOLING;
        private IReadOnlyList<ST> Cache_KGLKEY_ST_LOTE_HOME_CODE;
        private IReadOnlyList<STRE> Cache_KGLKEY_STRE_ST_HOME_LANG;
        private IReadOnlyList<STRE> Cache_KGLKEY_STRE_ST_LOTE_HOME_CODE;
        private IReadOnlyList<STRE> Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_A;
        private IReadOnlyList<STRE> Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_B;

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

        #region Foreign Navigation Properties

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.NATIVE_LANG_A]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_NATIVE_LANG_A
        {
            get
            {
                if (Cache_KGLKEY_DF_NATIVE_LANG_A == null &&
                    !Context.DF.TryFindByNATIVE_LANG_A(KGLKEY, out Cache_KGLKEY_DF_NATIVE_LANG_A))
                {
                    Cache_KGLKEY_DF_NATIVE_LANG_A = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_NATIVE_LANG_A;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.OTHER_LANG_A]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_OTHER_LANG_A
        {
            get
            {
                if (Cache_KGLKEY_DF_OTHER_LANG_A == null &&
                    !Context.DF.TryFindByOTHER_LANG_A(KGLKEY, out Cache_KGLKEY_DF_OTHER_LANG_A))
                {
                    Cache_KGLKEY_DF_OTHER_LANG_A = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_OTHER_LANG_A;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.LOTE_HOME_CODE_A]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_LOTE_HOME_CODE_A
        {
            get
            {
                if (Cache_KGLKEY_DF_LOTE_HOME_CODE_A == null &&
                    !Context.DF.TryFindByLOTE_HOME_CODE_A(KGLKEY, out Cache_KGLKEY_DF_LOTE_HOME_CODE_A))
                {
                    Cache_KGLKEY_DF_LOTE_HOME_CODE_A = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_LOTE_HOME_CODE_A;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.NATIVE_LANG_B]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_NATIVE_LANG_B
        {
            get
            {
                if (Cache_KGLKEY_DF_NATIVE_LANG_B == null &&
                    !Context.DF.TryFindByNATIVE_LANG_B(KGLKEY, out Cache_KGLKEY_DF_NATIVE_LANG_B))
                {
                    Cache_KGLKEY_DF_NATIVE_LANG_B = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_NATIVE_LANG_B;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.OTHER_LANG_B]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_OTHER_LANG_B
        {
            get
            {
                if (Cache_KGLKEY_DF_OTHER_LANG_B == null &&
                    !Context.DF.TryFindByOTHER_LANG_B(KGLKEY, out Cache_KGLKEY_DF_OTHER_LANG_B))
                {
                    Cache_KGLKEY_DF_OTHER_LANG_B = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_OTHER_LANG_B;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.LOTE_HOME_CODE_B]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_LOTE_HOME_CODE_B
        {
            get
            {
                if (Cache_KGLKEY_DF_LOTE_HOME_CODE_B == null &&
                    !Context.DF.TryFindByLOTE_HOME_CODE_B(KGLKEY, out Cache_KGLKEY_DF_LOTE_HOME_CODE_B))
                {
                    Cache_KGLKEY_DF_LOTE_HOME_CODE_B = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_LOTE_HOME_CODE_B;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.PREF_NOTICE_LANG]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_PREF_NOTICE_LANG
        {
            get
            {
                if (Cache_KGLKEY_DF_PREF_NOTICE_LANG == null &&
                    !Context.DF.TryFindByPREF_NOTICE_LANG(KGLKEY, out Cache_KGLKEY_DF_PREF_NOTICE_LANG))
                {
                    Cache_KGLKEY_DF_PREF_NOTICE_LANG = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_PREF_NOTICE_LANG;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.EMERG_LANG01]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_EMERG_LANG01
        {
            get
            {
                if (Cache_KGLKEY_DF_EMERG_LANG01 == null &&
                    !Context.DF.TryFindByEMERG_LANG01(KGLKEY, out Cache_KGLKEY_DF_EMERG_LANG01))
                {
                    Cache_KGLKEY_DF_EMERG_LANG01 = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_EMERG_LANG01;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.EMERG_LANG02]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_EMERG_LANG02
        {
            get
            {
                if (Cache_KGLKEY_DF_EMERG_LANG02 == null &&
                    !Context.DF.TryFindByEMERG_LANG02(KGLKEY, out Cache_KGLKEY_DF_EMERG_LANG02))
                {
                    Cache_KGLKEY_DF_EMERG_LANG02 = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_EMERG_LANG02;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.EMERG_LANG03]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_EMERG_LANG03
        {
            get
            {
                if (Cache_KGLKEY_DF_EMERG_LANG03 == null &&
                    !Context.DF.TryFindByEMERG_LANG03(KGLKEY, out Cache_KGLKEY_DF_EMERG_LANG03))
                {
                    Cache_KGLKEY_DF_EMERG_LANG03 = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_EMERG_LANG03;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.EMERG_LANG04]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_EMERG_LANG04
        {
            get
            {
                if (Cache_KGLKEY_DF_EMERG_LANG04 == null &&
                    !Context.DF.TryFindByEMERG_LANG04(KGLKEY, out Cache_KGLKEY_DF_EMERG_LANG04))
                {
                    Cache_KGLKEY_DF_EMERG_LANG04 = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_EMERG_LANG04;
            }
        }

        /// <summary>
        /// DF (Families) related entities by [KGL.KGLKEY]-&gt;[DF.HOME_LANG]
        /// Language code
        /// </summary>
        public IReadOnlyList<DF> KGLKEY_DF_HOME_LANG
        {
            get
            {
                if (Cache_KGLKEY_DF_HOME_LANG == null &&
                    !Context.DF.TryFindByHOME_LANG(KGLKEY, out Cache_KGLKEY_DF_HOME_LANG))
                {
                    Cache_KGLKEY_DF_HOME_LANG = new List<DF>().AsReadOnly();
                }

                return Cache_KGLKEY_DF_HOME_LANG;
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [KGL.KGLKEY]-&gt;[OSCS.HOME_LANG]
        /// Language code
        /// </summary>
        public IReadOnlyList<OSCS> KGLKEY_OSCS_HOME_LANG
        {
            get
            {
                if (Cache_KGLKEY_OSCS_HOME_LANG == null &&
                    !Context.OSCS.TryFindByHOME_LANG(KGLKEY, out Cache_KGLKEY_OSCS_HOME_LANG))
                {
                    Cache_KGLKEY_OSCS_HOME_LANG = new List<OSCS>().AsReadOnly();
                }

                return Cache_KGLKEY_OSCS_HOME_LANG;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KGL.KGLKEY]-&gt;[SF.LANG01]
        /// Language code
        /// </summary>
        public IReadOnlyList<SF> KGLKEY_SF_LANG01
        {
            get
            {
                if (Cache_KGLKEY_SF_LANG01 == null &&
                    !Context.SF.TryFindByLANG01(KGLKEY, out Cache_KGLKEY_SF_LANG01))
                {
                    Cache_KGLKEY_SF_LANG01 = new List<SF>().AsReadOnly();
                }

                return Cache_KGLKEY_SF_LANG01;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KGL.KGLKEY]-&gt;[SF.LANG02]
        /// Language code
        /// </summary>
        public IReadOnlyList<SF> KGLKEY_SF_LANG02
        {
            get
            {
                if (Cache_KGLKEY_SF_LANG02 == null &&
                    !Context.SF.TryFindByLANG02(KGLKEY, out Cache_KGLKEY_SF_LANG02))
                {
                    Cache_KGLKEY_SF_LANG02 = new List<SF>().AsReadOnly();
                }

                return Cache_KGLKEY_SF_LANG02;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KGL.KGLKEY]-&gt;[SF.EMERG_LANG01]
        /// Language code
        /// </summary>
        public IReadOnlyList<SF> KGLKEY_SF_EMERG_LANG01
        {
            get
            {
                if (Cache_KGLKEY_SF_EMERG_LANG01 == null &&
                    !Context.SF.TryFindByEMERG_LANG01(KGLKEY, out Cache_KGLKEY_SF_EMERG_LANG01))
                {
                    Cache_KGLKEY_SF_EMERG_LANG01 = new List<SF>().AsReadOnly();
                }

                return Cache_KGLKEY_SF_EMERG_LANG01;
            }
        }

        /// <summary>
        /// SF (Staff) related entities by [KGL.KGLKEY]-&gt;[SF.EMERG_LANG02]
        /// Language code
        /// </summary>
        public IReadOnlyList<SF> KGLKEY_SF_EMERG_LANG02
        {
            get
            {
                if (Cache_KGLKEY_SF_EMERG_LANG02 == null &&
                    !Context.SF.TryFindByEMERG_LANG02(KGLKEY, out Cache_KGLKEY_SF_EMERG_LANG02))
                {
                    Cache_KGLKEY_SF_EMERG_LANG02 = new List<SF>().AsReadOnly();
                }

                return Cache_KGLKEY_SF_EMERG_LANG02;
            }
        }

        /// <summary>
        /// SPU (Publications) related entities by [KGL.KGLKEY]-&gt;[SPU.HOME_LANGUAGE]
        /// Language code
        /// </summary>
        public IReadOnlyList<SPU> KGLKEY_SPU_HOME_LANGUAGE
        {
            get
            {
                if (Cache_KGLKEY_SPU_HOME_LANGUAGE == null &&
                    !Context.SPU.TryFindByHOME_LANGUAGE(KGLKEY, out Cache_KGLKEY_SPU_HOME_LANGUAGE))
                {
                    Cache_KGLKEY_SPU_HOME_LANGUAGE = new List<SPU>().AsReadOnly();
                }

                return Cache_KGLKEY_SPU_HOME_LANGUAGE;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGL.KGLKEY]-&gt;[ST.HOME_LANG]
        /// Language code
        /// </summary>
        public IReadOnlyList<ST> KGLKEY_ST_HOME_LANG
        {
            get
            {
                if (Cache_KGLKEY_ST_HOME_LANG == null &&
                    !Context.ST.TryFindByHOME_LANG(KGLKEY, out Cache_KGLKEY_ST_HOME_LANG))
                {
                    Cache_KGLKEY_ST_HOME_LANG = new List<ST>().AsReadOnly();
                }

                return Cache_KGLKEY_ST_HOME_LANG;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGL.KGLKEY]-&gt;[ST.EMERG_LANG01]
        /// Language code
        /// </summary>
        public IReadOnlyList<ST> KGLKEY_ST_EMERG_LANG01
        {
            get
            {
                if (Cache_KGLKEY_ST_EMERG_LANG01 == null &&
                    !Context.ST.TryFindByEMERG_LANG01(KGLKEY, out Cache_KGLKEY_ST_EMERG_LANG01))
                {
                    Cache_KGLKEY_ST_EMERG_LANG01 = new List<ST>().AsReadOnly();
                }

                return Cache_KGLKEY_ST_EMERG_LANG01;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGL.KGLKEY]-&gt;[ST.EMERG_LANG02]
        /// Language code
        /// </summary>
        public IReadOnlyList<ST> KGLKEY_ST_EMERG_LANG02
        {
            get
            {
                if (Cache_KGLKEY_ST_EMERG_LANG02 == null &&
                    !Context.ST.TryFindByEMERG_LANG02(KGLKEY, out Cache_KGLKEY_ST_EMERG_LANG02))
                {
                    Cache_KGLKEY_ST_EMERG_LANG02 = new List<ST>().AsReadOnly();
                }

                return Cache_KGLKEY_ST_EMERG_LANG02;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGL.KGLKEY]-&gt;[ST.LANGUAGE_PREVIOUS_SCHOOLING]
        /// Language code
        /// </summary>
        public IReadOnlyList<ST> KGLKEY_ST_LANGUAGE_PREVIOUS_SCHOOLING
        {
            get
            {
                if (Cache_KGLKEY_ST_LANGUAGE_PREVIOUS_SCHOOLING == null &&
                    !Context.ST.TryFindByLANGUAGE_PREVIOUS_SCHOOLING(KGLKEY, out Cache_KGLKEY_ST_LANGUAGE_PREVIOUS_SCHOOLING))
                {
                    Cache_KGLKEY_ST_LANGUAGE_PREVIOUS_SCHOOLING = new List<ST>().AsReadOnly();
                }

                return Cache_KGLKEY_ST_LANGUAGE_PREVIOUS_SCHOOLING;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGL.KGLKEY]-&gt;[ST.LOTE_HOME_CODE]
        /// Language code
        /// </summary>
        public IReadOnlyList<ST> KGLKEY_ST_LOTE_HOME_CODE
        {
            get
            {
                if (Cache_KGLKEY_ST_LOTE_HOME_CODE == null &&
                    !Context.ST.TryFindByLOTE_HOME_CODE(KGLKEY, out Cache_KGLKEY_ST_LOTE_HOME_CODE))
                {
                    Cache_KGLKEY_ST_LOTE_HOME_CODE = new List<ST>().AsReadOnly();
                }

                return Cache_KGLKEY_ST_LOTE_HOME_CODE;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [KGL.KGLKEY]-&gt;[STRE.ST_HOME_LANG]
        /// Language code
        /// </summary>
        public IReadOnlyList<STRE> KGLKEY_STRE_ST_HOME_LANG
        {
            get
            {
                if (Cache_KGLKEY_STRE_ST_HOME_LANG == null &&
                    !Context.STRE.TryFindByST_HOME_LANG(KGLKEY, out Cache_KGLKEY_STRE_ST_HOME_LANG))
                {
                    Cache_KGLKEY_STRE_ST_HOME_LANG = new List<STRE>().AsReadOnly();
                }

                return Cache_KGLKEY_STRE_ST_HOME_LANG;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [KGL.KGLKEY]-&gt;[STRE.ST_LOTE_HOME_CODE]
        /// Language code
        /// </summary>
        public IReadOnlyList<STRE> KGLKEY_STRE_ST_LOTE_HOME_CODE
        {
            get
            {
                if (Cache_KGLKEY_STRE_ST_LOTE_HOME_CODE == null &&
                    !Context.STRE.TryFindByST_LOTE_HOME_CODE(KGLKEY, out Cache_KGLKEY_STRE_ST_LOTE_HOME_CODE))
                {
                    Cache_KGLKEY_STRE_ST_LOTE_HOME_CODE = new List<STRE>().AsReadOnly();
                }

                return Cache_KGLKEY_STRE_ST_LOTE_HOME_CODE;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [KGL.KGLKEY]-&gt;[STRE.DF_LOTE_HOME_CODE_A]
        /// Language code
        /// </summary>
        public IReadOnlyList<STRE> KGLKEY_STRE_DF_LOTE_HOME_CODE_A
        {
            get
            {
                if (Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_A == null &&
                    !Context.STRE.TryFindByDF_LOTE_HOME_CODE_A(KGLKEY, out Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_A))
                {
                    Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_A = new List<STRE>().AsReadOnly();
                }

                return Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_A;
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [KGL.KGLKEY]-&gt;[STRE.DF_LOTE_HOME_CODE_B]
        /// Language code
        /// </summary>
        public IReadOnlyList<STRE> KGLKEY_STRE_DF_LOTE_HOME_CODE_B
        {
            get
            {
                if (Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_B == null &&
                    !Context.STRE.TryFindByDF_LOTE_HOME_CODE_B(KGLKEY, out Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_B))
                {
                    Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_B = new List<STRE>().AsReadOnly();
                }

                return Cache_KGLKEY_STRE_DF_LOTE_HOME_CODE_B;
            }
        }

        #endregion

    }
}
