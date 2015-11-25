using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Departments
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKD : EntityBase
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<AR> Cache_DEPARTMENT_AR_DEPARTMENT;

        #endregion

        #region Field Properties

        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string DEPARTMENT { get; internal set; }

        /// <summary>
        /// Description of department
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

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
        /// AR (Assets) related entities by [AKD.DEPARTMENT]-&gt;[AR.DEPARTMENT]
        /// Prime Key
        /// </summary>
        public IReadOnlyList<AR> DEPARTMENT_AR_DEPARTMENT
        {
            get
            {
                if (Cache_DEPARTMENT_AR_DEPARTMENT == null &&
                    !Context.AR.TryFindByDEPARTMENT(DEPARTMENT, out Cache_DEPARTMENT_AR_DEPARTMENT))
                {
                    Cache_DEPARTMENT_AR_DEPARTMENT = new List<AR>().AsReadOnly();
                }

                return Cache_DEPARTMENT_AR_DEPARTMENT;
            }
        }

        #endregion

    }
}
