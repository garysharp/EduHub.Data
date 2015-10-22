using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations
    /// </summary>
    public partial class KGD : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Combination of KGG.KGGKEY and Destination
        /// [Uppercase Alphanumeric (6)]
        /// </summary>
        public string KGDKEY { get; internal set; }
        /// <summary>
        /// Description of destination
        /// [Alphanumeric (50)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Description of category (to aid selection from moroinfo)
        /// [Alphanumeric (50)]
        /// </summary>
        public string CATEGORY { get; internal set; }
        /// <summary>
        /// Is this Destination open or closed
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string OPEN_CLOSED { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [OSCS.ZEROMTH_CAT_DEST]-&gt;[KGD.KGDKEY]
        /// </summary>
        public IReadOnlyList<OSCS> OSCS_ZEROMTH_CAT_DEST
        {
            get
            {
                return Context.KGD.FindOSCSByZEROMTH_CAT_DEST(KGDKEY);
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [OSCS.SIXMTH_CAT_DEST]-&gt;[KGD.KGDKEY]
        /// </summary>
        public IReadOnlyList<OSCS> OSCS_SIXMTH_CAT_DEST
        {
            get
            {
                return Context.KGD.FindOSCSBySIXMTH_CAT_DEST(KGDKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.EXIT_DEST01]-&gt;[KGD.KGDKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_EXIT_DEST01
        {
            get
            {
                return Context.KGD.FindSTByEXIT_DEST01(KGDKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.EXIT_DEST02]-&gt;[KGD.KGDKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_EXIT_DEST02
        {
            get
            {
                return Context.KGD.FindSTByEXIT_DEST02(KGDKEY);
            }
        }
#endregion
    }
}
