using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FDT Financial Raw Import Table
    /// </summary>
    public class FDT_IMP : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no
        /// </summary>
        public int FDTKEY { get; internal set; }
        /// <summary>
        /// Import Type (PE,CR,DR,AR)
        /// [Alphanumeric (8)]
        /// </summary>
        public string SOURCE { get; internal set; }
        /// <summary>
        /// Actual Table Data Exported From
        /// [Alphanumeric (8)]
        /// </summary>
        public string SOURCE_TABLE { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD01 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD02 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD03 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD04 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD05 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD06 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD07 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD08 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD09 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD10 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD11 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD12 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD13 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD14 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD15 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD16 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD17 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD18 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD19 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD20 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD21 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD22 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD23 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD24 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD25 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD26 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD27 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD28 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD29 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD30 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD31 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD32 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD33 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD34 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD35 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD36 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD37 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD38 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD39 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD40 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD41 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD42 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD43 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD44 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD45 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD46 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD47 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD48 { get; internal set; }
        /// <summary>
        /// Data Fields
        /// [Alphanumeric (60)]
        /// </summary>
        public string FIELD49 { get; internal set; }
        /// <summary>
        /// Notes field
        /// [Memo]
        /// </summary>
        public string NOTES01 { get; internal set; }
        /// <summary>
        /// Notes field
        /// [Memo]
        /// </summary>
        public string NOTES02 { get; internal set; }
        /// <summary>
        /// Notes field
        /// [Memo]
        /// </summary>
        public string NOTES03 { get; internal set; }
        /// <summary>
        /// Notes field
        /// [Memo]
        /// </summary>
        public string NOTES04 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[] ITEM_PIC { get; internal set; }
        /// <summary>
        /// School originated from
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string FDT_SOURCE { get; internal set; }
        /// <summary>
        /// School being transfered too.
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string FDT_DEST { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string FDT_DEST_ID { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (20)]
        /// </summary>
        public string FDT_EXP_DATE { get; internal set; }
        /// <summary>
        /// 
        /// [Alphanumeric (8)]
        /// </summary>
        public string FDT_EXP_TIME { get; internal set; }
        /// <summary>
        /// FDT Comment
        /// [Memo]
        /// </summary>
        public string FDT_COMMENT { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CURRENT_VER { get; internal set; }
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
#endregion
    }
}
