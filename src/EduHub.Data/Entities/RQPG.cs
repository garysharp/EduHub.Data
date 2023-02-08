#if !EduHubScoped
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Purchasing Group
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class RQPG : EduHubEntity
    {

        #region Navigation Property Cache

        private SF Cache_SFKEY_SF;

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        private IReadOnlyList<RQGL> Cache_RQPGKEY_RQGL_RQPGKEY;
        private IReadOnlyList<RQREL> Cache_RQPGKEY_RQREL_RQPGKEY;
#endif

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
        /// Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string RQPGKEY { get; internal set; }

        /// <summary>
        /// Purchasing Group Description
        /// [Alphanumeric (40)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Authorising Officer
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SFKEY { get; internal set; }

        /// <summary>
        /// Officer Email address
        /// [Alphanumeric (40)]
        /// </summary>
        public string EMAIL { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last opertator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// SF (Staff) related entity by [RQPG.SFKEY]-&gt;[SF.SFKEY]
        /// Authorising Officer
        /// </summary>
        public SF SFKEY_SF
        {
            get
            {
                if (SFKEY == null)
                {
                    return null;
                }
                if (Cache_SFKEY_SF == null)
                {
                    Cache_SFKEY_SF = Context.SF.FindBySFKEY(SFKEY);
                }

                return Cache_SFKEY_SF;
            }
        }

        #endregion

        #region Foreign Navigation Properties

#if !EduHubScoped
        /// <summary>
        /// RQGL (Purchasing Group GL Codes) related entities by [RQPG.RQPGKEY]-&gt;[RQGL.RQPGKEY]
        /// Key
        /// </summary>
        public IReadOnlyList<RQGL> RQPGKEY_RQGL_RQPGKEY
        {
            get
            {
                if (Cache_RQPGKEY_RQGL_RQPGKEY == null &&
                    !Context.RQGL.TryFindByRQPGKEY(RQPGKEY, out Cache_RQPGKEY_RQGL_RQPGKEY))
                {
                    Cache_RQPGKEY_RQGL_RQPGKEY = new List<RQGL>().AsReadOnly();
                }

                return Cache_RQPGKEY_RQGL_RQPGKEY;
            }
        }

        /// <summary>
        /// RQREL (Staff Purchasing Group Link) related entities by [RQPG.RQPGKEY]-&gt;[RQREL.RQPGKEY]
        /// Key
        /// </summary>
        public IReadOnlyList<RQREL> RQPGKEY_RQREL_RQPGKEY
        {
            get
            {
                if (Cache_RQPGKEY_RQREL_RQPGKEY == null &&
                    !Context.RQREL.TryFindByRQPGKEY(RQPGKEY, out Cache_RQPGKEY_RQREL_RQPGKEY))
                {
                    Cache_RQPGKEY_RQREL_RQPGKEY = new List<RQREL>().AsReadOnly();
                }

                return Cache_RQPGKEY_RQREL_RQPGKEY;
            }
        }

#endif
        #endregion

    }
}
#endif
