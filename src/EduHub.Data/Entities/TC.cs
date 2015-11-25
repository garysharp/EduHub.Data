using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TC : EntityBase
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<TCTB> Cache_TCKEY_TCTB_TCTBKEY;
        private IReadOnlyList<TCTD> Cache_TCKEY_TCTD_TCTDKEY;
        private IReadOnlyList<TCTQ> Cache_TCKEY_TCTQ_TCTQKEY;
        private IReadOnlyList<TCTR> Cache_TCKEY_TCTR_TCTRKEY;

        #endregion

        #region Field Properties

        /// <summary>
        /// Calendar entry code
        /// </summary>
        public DateTime TCKEY { get; internal set; }

        /// <summary>
        /// Title
        /// [Alphanumeric (30)]
        /// </summary>
        public string TITLE { get; internal set; }

        /// <summary>
        /// memo comment
        /// [Memo]
        /// </summary>
        public string DAY_COMMENT { get; internal set; }

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
        /// TCTB (Teacher Absences) related entities by [TC.TCKEY]-&gt;[TCTB.TCTBKEY]
        /// Calendar entry code
        /// </summary>
        public IReadOnlyList<TCTB> TCKEY_TCTB_TCTBKEY
        {
            get
            {
                if (Cache_TCKEY_TCTB_TCTBKEY == null &&
                    !Context.TCTB.TryFindByTCTBKEY(TCKEY, out Cache_TCKEY_TCTB_TCTBKEY))
                {
                    Cache_TCKEY_TCTB_TCTBKEY = new List<TCTB>().AsReadOnly();
                }

                return Cache_TCKEY_TCTB_TCTBKEY;
            }
        }

        /// <summary>
        /// TCTD (Calendar Period Information) related entities by [TC.TCKEY]-&gt;[TCTD.TCTDKEY]
        /// Calendar entry code
        /// </summary>
        public IReadOnlyList<TCTD> TCKEY_TCTD_TCTDKEY
        {
            get
            {
                if (Cache_TCKEY_TCTD_TCTDKEY == null &&
                    !Context.TCTD.TryFindByTCTDKEY(TCKEY, out Cache_TCKEY_TCTD_TCTDKEY))
                {
                    Cache_TCKEY_TCTD_TCTDKEY = new List<TCTD>().AsReadOnly();
                }

                return Cache_TCKEY_TCTD_TCTDKEY;
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TC.TCKEY]-&gt;[TCTQ.TCTQKEY]
        /// Calendar entry code
        /// </summary>
        public IReadOnlyList<TCTQ> TCKEY_TCTQ_TCTQKEY
        {
            get
            {
                if (Cache_TCKEY_TCTQ_TCTQKEY == null &&
                    !Context.TCTQ.TryFindByTCTQKEY(TCKEY, out Cache_TCKEY_TCTQ_TCTQKEY))
                {
                    Cache_TCKEY_TCTQ_TCTQKEY = new List<TCTQ>().AsReadOnly();
                }

                return Cache_TCKEY_TCTQ_TCTQKEY;
            }
        }

        /// <summary>
        /// TCTR (Teacher Replacements) related entities by [TC.TCKEY]-&gt;[TCTR.TCTRKEY]
        /// Calendar entry code
        /// </summary>
        public IReadOnlyList<TCTR> TCKEY_TCTR_TCTRKEY
        {
            get
            {
                if (Cache_TCKEY_TCTR_TCTRKEY == null &&
                    !Context.TCTR.TryFindByTCTRKEY(TCKEY, out Cache_TCKEY_TCTR_TCTRKEY))
                {
                    Cache_TCKEY_TCTR_TCTRKEY = new List<TCTR>().AsReadOnly();
                }

                return Cache_TCKEY_TCTR_TCTRKEY;
            }
        }

        #endregion

    }
}
