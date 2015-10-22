using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Report Usage Metadata
    /// </summary>
    public partial class SCEN_RPT : EntityBase
    {
#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PROG { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PERIOD { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string REQUIREDPRINCIPALFIELD { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ISPRIMARY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ISPRIMARYSECONDARY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ISSECONDARY { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ISLANGUAGE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ISSPECIAL { get; internal set; }
#endregion
    }
}
