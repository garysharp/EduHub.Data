using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Return Summary Data
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_RTN : EduHubEntity
    {

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return null;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID (internal)
        /// </summary>
        public int ID { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RN_SCHOOLNUMBER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (40)]
        /// </summary>
        public string RN_SCHOOLNAME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (40)]
        /// </summary>
        public string RN_SCHOOLTYPE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string RN_MONTH { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RN_YEAR { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RN_STATUS { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? RN_CREATED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string RN_CREATEUSER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? RN_LUPDATED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string RN_LUPDATEUSER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? SD_LREFRESHED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? SD_LVALIDATED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public double? SD_SRPFUNDEDFTE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public double? SD_NOTSRPFUNDEDFTE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public double? SD_TOTALFTE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? SD_INCLUDEDHC { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? SD_SYSTEMEXCLUDEDHC { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? SD_MANUALLYEXCLUDEDHC { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? SD_TOTALHC { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? SD_ERRORCOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? SD_UNPROCESSEDWARNINGCOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? SD_ACKNOWLEDGEDWARNINGCOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? CSD_LHMGREFRESHED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? CSD_LUPDATED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string CSD_LUPDATEUSER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? CSD_LVALIDATED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? CSD_CLASSCOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? CSD_STUDENTHC { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public double? CSD_TEACHERFTE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? CSD_ERRORCOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? CSD_UNPROCESSEDWARNINGCOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public short? CSD_ACKNOWLEDGEDWARNINGCOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (80)]
        /// </summary>
        public string LD_CONTACTNAME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string LD_CONTACTPHONE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (80)]
        /// </summary>
        public string LD_PRINCIPALNAME { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string LD_PRINCIPALPHONE { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string LD_COMMENTS { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LD_USERCERTIFICATION { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string LD_FINALREPORTLOCATION { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string LD_STATUS { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? LD_CREATED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? LD_LODGED { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LD_LUPDATEUSER { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public DateTime? LD_LUPDATED { get; internal set; }

        #endregion

    }
}
