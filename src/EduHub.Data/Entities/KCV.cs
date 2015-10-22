﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Visa Subclasses
    /// </summary>
    public partial class KCV : EntityBase
    {
#region Field Properties
        /// <summary>
        /// Visa Subclass code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string VISA_SUBCLASS { get; internal set; }
        /// <summary>
        /// Visa Subclass description
        /// [Alphanumeric (52)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Australian residence status of persons with this Visa Subclass: P=Permanent, T=Temporary
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string VISA_RESIDENCY { get; internal set; }
        /// <summary>
        /// Indicates whether students with this Visa Subclass are eligible for (SRP) funding(Y/M)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string SGB_FUNDED { get; internal set; }
        /// <summary>
        /// Indicates whether the Visa Statistical Code should be checked for students with this Visa Subclass (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHECK_STAT_CODE { get; internal set; }
        /// <summary>
        /// Indicates whether the expiry date should be checked for students with this Visa Subclass (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHECK_EXPIRY_DATE { get; internal set; }
        /// <summary>
        /// Identifies visa sub-classes that require an international student id
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string CHECK_ISID { get; internal set; }
        /// <summary>
        /// Identifies if Visa subclass is a refugee type for EAL (refer Aegis 7210).
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REFUGEE { get; internal set; }
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
        /// ST (Students) related entities by [ST.VISA_SUBCLASS]-&gt;[KCV.VISA_SUBCLASS]
        /// </summary>
        public IReadOnlyList<ST> ST_VISA_SUBCLASS
        {
            get
            {
                return Context.KCV.FindSTByVISA_SUBCLASS(VISA_SUBCLASS);
            }
        }

        /// <summary>
        /// STRE (Student Re-Enrolment) related entities by [STRE.ST_VISA_SUBCLASS]-&gt;[KCV.VISA_SUBCLASS]
        /// </summary>
        public IReadOnlyList<STRE> STRE_ST_VISA_SUBCLASS
        {
            get
            {
                return Context.KCV.FindSTREByST_VISA_SUBCLASS(VISA_SUBCLASS);
            }
        }
#endregion
    }
}
