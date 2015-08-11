using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group History
    /// </summary>
    public class KGCHI_Entity : EntityBase
    {
        /// <summary>
        /// Sequence no [Integer (32bit signed): l]
        /// </summary>
        public int KGCHIKEY { get; internal set; }
        /// <summary>
        /// Home group code (dynamic link that gets updated whenever KGC.KGCKEY is also updated) [Uppercase Alphanumeric: u3]
        /// </summary>
        public string KGCKEY { get; internal set; }
        /// <summary>
        /// Navigation property for [KGCKEY] => [KGC_Entity].[KGCKEY]
        /// Home group code (dynamic link that gets updated whenever KGC.KGCKEY is also updated)
        /// </summary>
        public KGC_Entity KGCKEY_KGC { get { return KGCKEY == null ? null : Context.KGC.FindByKGCKEY(KGCKEY); } }
        /// <summary>
        /// User ID of person creating the record [Uppercase Alphanumeric: u128]
        /// </summary>
        public string CREATION_USER { get; internal set; }
        /// <summary>
        /// Date of history record creation [Date Time nullable: d]
        /// </summary>
        public DateTime? CREATION_DATE { get; internal set; }
        /// <summary>
        /// Time of history record creation [Integer (16bit signed nullable): i]
        /// </summary>
        public short? CREATION_TIME { get; internal set; }
        /// <summary>
        /// User ID of person making the record obsolete [Uppercase Alphanumeric: u128]
        /// </summary>
        public string OBSOLETE_USER { get; internal set; }
        /// <summary>
        /// End date of history record [Date Time nullable: d]
        /// </summary>
        public DateTime? OBSOLETE_DATE { get; internal set; }
        /// <summary>
        /// End time of history record [Integer (16bit signed nullable): i]
        /// </summary>
        public short? OBSOLETE_TIME { get; internal set; }
        /// <summary>
        /// Campus ID + name [Alphanumeric: a45]
        /// </summary>
        public string CAMPUS { get; internal set; }
        /// <summary>
        /// Staff code + name of first or only home group teacher [Alphanumeric: a35]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Staff code + name of second home group teacher (if any) [Alphanumeric: a35]
        /// </summary>
        public string TEACHER_B { get; internal set; }
        /// <summary>
        /// Room code + title of home group room [Alphanumeric: a30]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Change made to last record to produce this one [Alphanumeric: a40]
        /// </summary>
        public string CHANGE_MADE { get; internal set; }
        
        
    }
}
