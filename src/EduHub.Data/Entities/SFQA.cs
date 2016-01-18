using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Qualifications
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SFQA : EduHubEntity
    {

        #region Navigation Property Cache

        private SF Cache_TEACH_SF;

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
        /// Transaction ID (internal)
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// Staff code of teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACH { get; internal set; }

        /// <summary>
        /// Name of qualification
        /// [Alphanumeric (30)]
        /// </summary>
        public string QUALIFICATION { get; internal set; }

        /// <summary>
        /// When completed
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string YEAR_COMPLETED { get; internal set; }

        /// <summary>
        /// Where studied
        /// [Alphanumeric (30)]
        /// </summary>
        public string INSTITUTION { get; internal set; }

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
        /// SF (Staff) related entity by [SFQA.TEACH]-&gt;[SF.SFKEY]
        /// Staff code of teacher
        /// </summary>
        public SF TEACH_SF
        {
            get
            {
                if (Cache_TEACH_SF == null)
                {
                    Cache_TEACH_SF = Context.SF.FindBySFKEY(TEACH);
                }

                return Cache_TEACH_SF;
            }
        }

        #endregion

    }
}
