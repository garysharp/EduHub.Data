using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Categories
    /// </summary>
    public partial class KGG : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Category Code
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string KGGKEY { get; internal set; }
        /// <summary>
        /// Description of category
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Reference for sorting
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string EDFLAG_ORDER { get; internal set; }
        /// <summary>
        /// Is this Category open or closed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OPEN_CLOSED { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [OSCS.ZEROMTH_CAT]-&gt;[KGG.KGGKEY]
        /// </summary>
        public IReadOnlyList<OSCS> OSCS_ZEROMTH_CAT
        {
            get
            {
                return Context.KGG.FindOSCSByZEROMTH_CAT(KGGKEY);
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [OSCS.SIXMTH_CAT]-&gt;[KGG.KGGKEY]
        /// </summary>
        public IReadOnlyList<OSCS> OSCS_SIXMTH_CAT
        {
            get
            {
                return Context.KGG.FindOSCSBySIXMTH_CAT(KGGKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.EXIT_CAT01]-&gt;[KGG.KGGKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_EXIT_CAT01
        {
            get
            {
                return Context.KGG.FindSTByEXIT_CAT01(KGGKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.EXIT_CAT02]-&gt;[KGG.KGGKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_EXIT_CAT02
        {
            get
            {
                return Context.KGG.FindSTByEXIT_CAT02(KGGKEY);
            }
        }
#endregion
    }
}
