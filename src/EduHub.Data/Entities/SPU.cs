using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Publications
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPU : EntityBase
    {

        #region Navigation Property Cache

        private SG Cache_MAILING_LIST_SG;
        private KGL Cache_HOME_LANGUAGE_KGL;

        #endregion

        #region Field Properties

        /// <summary>
        /// Publication code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string SPUKEY { get; internal set; }

        /// <summary>
        /// Publication title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Description of publication
        /// [Memo]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Target audience
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TARGET { get; internal set; }

        /// <summary>
        /// Whether publication is in English only or community languages
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LANGUAGE_INDICATOR { get; internal set; }

        /// <summary>
        /// Mailing mechanism: mail, electronic, by hand
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string MAILING_MECHANISM { get; internal set; }

        /// <summary>
        /// Publication type: Labels, envelopes, documents
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PUBLICATION_TYPE { get; internal set; }

        /// <summary>
        /// Comment to go above address (if required)
        /// [Alphanumeric (40)]
        /// </summary>
        public string ADDRESS_COMMENT { get; internal set; }

        /// <summary>
        /// Is this document to go to each student, or one per family
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STUDENT_SPECIFIC { get; internal set; }

        /// <summary>
        /// Code of group of students to which this publication is to go
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string MAILING_LIST { get; internal set; }

        /// <summary>
        /// Indicates whether publication is to go to all students eligible for the group or only actual members
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTUAL_ELIGIBLE_MEMBERS { get; internal set; }

        /// <summary>
        /// If filled publication only goes to students with matching ST.HOME_LANG
        /// [Uppercase Alphanumeric (7)]
        /// </summary>
        public string HOME_LANGUAGE { get; internal set; }

        /// <summary>
        /// Required sorting sequence: C=Community language, P=Postcode, H=Home group
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRIMARY_SORT { get; internal set; }

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
        /// SG (Student Groupings) related entity by [SPU.MAILING_LIST]-&gt;[SG.SGKEY]
        /// Code of group of students to which this publication is to go
        /// </summary>
        public SG MAILING_LIST_SG
        {
            get
            {
                if (MAILING_LIST == null)
                {
                    return null;
                }
                if (Cache_MAILING_LIST_SG == null)
                {
                    Cache_MAILING_LIST_SG = Context.SG.FindBySGKEY(MAILING_LIST);
                }

                return Cache_MAILING_LIST_SG;
            }
        }

        /// <summary>
        /// KGL (Languages) related entity by [SPU.HOME_LANGUAGE]-&gt;[KGL.KGLKEY]
        /// If filled publication only goes to students with matching ST.HOME_LANG
        /// </summary>
        public KGL HOME_LANGUAGE_KGL
        {
            get
            {
                if (HOME_LANGUAGE == null)
                {
                    return null;
                }
                if (Cache_HOME_LANGUAGE_KGL == null)
                {
                    Cache_HOME_LANGUAGE_KGL = Context.KGL.FindByKGLKEY(HOME_LANGUAGE);
                }

                return Cache_HOME_LANGUAGE_KGL;
            }
        }

        #endregion

    }
}
