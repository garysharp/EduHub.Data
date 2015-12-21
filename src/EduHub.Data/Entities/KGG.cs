using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Categories
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGG : EduHubEntity
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<OSCS> Cache_KGGKEY_OSCS_ZEROMTH_CAT;
        private IReadOnlyList<OSCS> Cache_KGGKEY_OSCS_SIXMTH_CAT;
        private IReadOnlyList<ST> Cache_KGGKEY_ST_EXIT_CAT01;
        private IReadOnlyList<ST> Cache_KGGKEY_ST_EXIT_CAT02;

        #endregion

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

        #region Foreign Navigation Properties

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [KGG.KGGKEY]-&gt;[OSCS.ZEROMTH_CAT]
        /// Category Code
        /// </summary>
        public IReadOnlyList<OSCS> KGGKEY_OSCS_ZEROMTH_CAT
        {
            get
            {
                if (Cache_KGGKEY_OSCS_ZEROMTH_CAT == null &&
                    !Context.OSCS.TryFindByZEROMTH_CAT(KGGKEY, out Cache_KGGKEY_OSCS_ZEROMTH_CAT))
                {
                    Cache_KGGKEY_OSCS_ZEROMTH_CAT = new List<OSCS>().AsReadOnly();
                }

                return Cache_KGGKEY_OSCS_ZEROMTH_CAT;
            }
        }

        /// <summary>
        /// OSCS (CASES Past Students) related entities by [KGG.KGGKEY]-&gt;[OSCS.SIXMTH_CAT]
        /// Category Code
        /// </summary>
        public IReadOnlyList<OSCS> KGGKEY_OSCS_SIXMTH_CAT
        {
            get
            {
                if (Cache_KGGKEY_OSCS_SIXMTH_CAT == null &&
                    !Context.OSCS.TryFindBySIXMTH_CAT(KGGKEY, out Cache_KGGKEY_OSCS_SIXMTH_CAT))
                {
                    Cache_KGGKEY_OSCS_SIXMTH_CAT = new List<OSCS>().AsReadOnly();
                }

                return Cache_KGGKEY_OSCS_SIXMTH_CAT;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGG.KGGKEY]-&gt;[ST.EXIT_CAT01]
        /// Category Code
        /// </summary>
        public IReadOnlyList<ST> KGGKEY_ST_EXIT_CAT01
        {
            get
            {
                if (Cache_KGGKEY_ST_EXIT_CAT01 == null &&
                    !Context.ST.TryFindByEXIT_CAT01(KGGKEY, out Cache_KGGKEY_ST_EXIT_CAT01))
                {
                    Cache_KGGKEY_ST_EXIT_CAT01 = new List<ST>().AsReadOnly();
                }

                return Cache_KGGKEY_ST_EXIT_CAT01;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGG.KGGKEY]-&gt;[ST.EXIT_CAT02]
        /// Category Code
        /// </summary>
        public IReadOnlyList<ST> KGGKEY_ST_EXIT_CAT02
        {
            get
            {
                if (Cache_KGGKEY_ST_EXIT_CAT02 == null &&
                    !Context.ST.TryFindByEXIT_CAT02(KGGKEY, out Cache_KGGKEY_ST_EXIT_CAT02))
                {
                    Cache_KGGKEY_ST_EXIT_CAT02 = new List<ST>().AsReadOnly();
                }

                return Cache_KGGKEY_ST_EXIT_CAT02;
            }
        }

        #endregion

    }
}
