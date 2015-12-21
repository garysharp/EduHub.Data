using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGD : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<OSCS> Cache_KGDKEY_OSCS_ZEROMTH_CAT_DEST;
        private IReadOnlyList<OSCS> Cache_KGDKEY_OSCS_SIXMTH_CAT_DEST;
        private IReadOnlyList<ST> Cache_KGDKEY_ST_EXIT_DEST01;
        private IReadOnlyList<ST> Cache_KGDKEY_ST_EXIT_DEST02;

        #endregion

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

        #region Foreign Navigation Properties

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [KGD.KGDKEY]-&gt;[OSCS.ZEROMTH_CAT_DEST]
        /// Combination of KGG.KGGKEY and Destination
        /// </summary>
        public IReadOnlyList<OSCS> KGDKEY_OSCS_ZEROMTH_CAT_DEST
        {
            get
            {
                if (Cache_KGDKEY_OSCS_ZEROMTH_CAT_DEST == null &&
                    !Context.OSCS.TryFindByZEROMTH_CAT_DEST(KGDKEY, out Cache_KGDKEY_OSCS_ZEROMTH_CAT_DEST))
                {
                    Cache_KGDKEY_OSCS_ZEROMTH_CAT_DEST = new List<OSCS>().AsReadOnly();
                }

                return Cache_KGDKEY_OSCS_ZEROMTH_CAT_DEST;
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [KGD.KGDKEY]-&gt;[OSCS.SIXMTH_CAT_DEST]
        /// Combination of KGG.KGGKEY and Destination
        /// </summary>
        public IReadOnlyList<OSCS> KGDKEY_OSCS_SIXMTH_CAT_DEST
        {
            get
            {
                if (Cache_KGDKEY_OSCS_SIXMTH_CAT_DEST == null &&
                    !Context.OSCS.TryFindBySIXMTH_CAT_DEST(KGDKEY, out Cache_KGDKEY_OSCS_SIXMTH_CAT_DEST))
                {
                    Cache_KGDKEY_OSCS_SIXMTH_CAT_DEST = new List<OSCS>().AsReadOnly();
                }

                return Cache_KGDKEY_OSCS_SIXMTH_CAT_DEST;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGD.KGDKEY]-&gt;[ST.EXIT_DEST01]
        /// Combination of KGG.KGGKEY and Destination
        /// </summary>
        public IReadOnlyList<ST> KGDKEY_ST_EXIT_DEST01
        {
            get
            {
                if (Cache_KGDKEY_ST_EXIT_DEST01 == null &&
                    !Context.ST.TryFindByEXIT_DEST01(KGDKEY, out Cache_KGDKEY_ST_EXIT_DEST01))
                {
                    Cache_KGDKEY_ST_EXIT_DEST01 = new List<ST>().AsReadOnly();
                }

                return Cache_KGDKEY_ST_EXIT_DEST01;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGD.KGDKEY]-&gt;[ST.EXIT_DEST02]
        /// Combination of KGG.KGGKEY and Destination
        /// </summary>
        public IReadOnlyList<ST> KGDKEY_ST_EXIT_DEST02
        {
            get
            {
                if (Cache_KGDKEY_ST_EXIT_DEST02 == null &&
                    !Context.ST.TryFindByEXIT_DEST02(KGDKEY, out Cache_KGDKEY_ST_EXIT_DEST02))
                {
                    Cache_KGDKEY_ST_EXIT_DEST02 = new List<ST>().AsReadOnly();
                }

                return Cache_KGDKEY_ST_EXIT_DEST02;
            }
        }

        #endregion

    }
}
