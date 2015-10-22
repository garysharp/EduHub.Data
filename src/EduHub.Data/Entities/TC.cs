using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar
    /// </summary>
    public partial class TC : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// TCTB (Teacher Absences) related entities by [TCTB.TCTBKEY]-&gt;[TC.TCKEY]
        /// </summary>
        public IReadOnlyList<TCTB> TCTB_TCTBKEY
        {
            get
            {
                return Context.TC.FindTCTBByTCTBKEY(TCKEY);
            }
        }

        /// <summary>
        /// TCTD (Calendar Period Information) related entities by [TCTD.TCTDKEY]-&gt;[TC.TCKEY]
        /// </summary>
        public IReadOnlyList<TCTD> TCTD_TCTDKEY
        {
            get
            {
                return Context.TC.FindTCTDByTCTDKEY(TCKEY);
            }
        }

        /// <summary>
        /// TCTQ (Calendar Class Information) related entities by [TCTQ.TCTQKEY]-&gt;[TC.TCKEY]
        /// </summary>
        public IReadOnlyList<TCTQ> TCTQ_TCTQKEY
        {
            get
            {
                return Context.TC.FindTCTQByTCTQKEY(TCKEY);
            }
        }

        /// <summary>
        /// TCTR (Teacher Replacements) related entities by [TCTR.TCTRKEY]-&gt;[TC.TCKEY]
        /// </summary>
        public IReadOnlyList<TCTR> TCTR_TCTRKEY
        {
            get
            {
                return Context.TC.FindTCTRByTCTRKEY(TCKEY);
            }
        }
#endregion
    }
}
