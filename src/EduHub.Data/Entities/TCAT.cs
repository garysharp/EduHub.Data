using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TCAT : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<TCTB> Cache_TCATKEY_TCTB_ABSENCE_TYPE;

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
        /// Staff Absence Type Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TCATKEY { get; internal set; }

        /// <summary>
        /// Staff Absence Type Title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// TCTB (Teacher Absences) related entities by [TCAT.TCATKEY]-&gt;[TCTB.ABSENCE_TYPE]
        /// Staff Absence Type Key
        /// </summary>
        public IReadOnlyList<TCTB> TCATKEY_TCTB_ABSENCE_TYPE
        {
            get
            {
                if (Cache_TCATKEY_TCTB_ABSENCE_TYPE == null &&
                    !Context.TCTB.TryFindByABSENCE_TYPE(TCATKEY, out Cache_TCATKEY_TCTB_ABSENCE_TYPE))
                {
                    Cache_TCATKEY_TCTB_ABSENCE_TYPE = new List<TCTB>().AsReadOnly();
                }

                return Cache_TCATKEY_TCTB_ABSENCE_TYPE;
            }
        }

        #endregion

    }
}
