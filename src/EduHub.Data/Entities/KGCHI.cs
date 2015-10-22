using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group History
    /// </summary>
    public partial class KGCHI : EntityBase
    {
#region Navigation Property Cache
        private KGC _KGCKEY_KGC;
#endregion

#region Field Properties
        /// <summary>
        /// Sequence no
        /// </summary>
        public int KGCHIKEY { get; internal set; }
        /// <summary>
        /// Home group code (dynamic link that gets updated whenever KGC.KGCKEY is also updated)
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string KGCKEY { get; internal set; }
        /// <summary>
        /// User ID of person creating the record
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string CREATION_USER { get; internal set; }
        /// <summary>
        /// Date of history record creation
        /// </summary>
        public DateTime? CREATION_DATE { get; internal set; }
        /// <summary>
        /// Time of history record creation
        /// </summary>
        public short? CREATION_TIME { get; internal set; }
        /// <summary>
        /// User ID of person making the record obsolete
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string OBSOLETE_USER { get; internal set; }
        /// <summary>
        /// End date of history record
        /// </summary>
        public DateTime? OBSOLETE_DATE { get; internal set; }
        /// <summary>
        /// End time of history record
        /// </summary>
        public short? OBSOLETE_TIME { get; internal set; }
        /// <summary>
        /// Campus ID + name
        /// [Alphanumeric (45)]
        /// </summary>
        public string CAMPUS { get; internal set; }
        /// <summary>
        /// Staff code + name of first or only home group teacher
        /// [Alphanumeric (35)]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Staff code + name of second home group teacher (if any)
        /// [Alphanumeric (35)]
        /// </summary>
        public string TEACHER_B { get; internal set; }
        /// <summary>
        /// Room code + title of home group room
        /// [Alphanumeric (30)]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Change made to last record to produce this one
        /// [Alphanumeric (40)]
        /// </summary>
        public string CHANGE_MADE { get; internal set; }
#endregion

#region Navigation Properties

        /// <summary>
        /// KGC (Home Groups) related entity by [KGCHI.KGCKEY]-&gt;[KGC.KGCKEY]
        /// Home group code (dynamic link that gets updated whenever KGC.KGCKEY is also updated)
        /// </summary>
        public KGC KGCKEY_KGC
        {
            get
            {
                if (KGCKEY != null)
                {
                    if (_KGCKEY_KGC == null)
                    {
                        _KGCKEY_KGC = Context.KGC.FindByKGCKEY(KGCKEY);
                    }
                    return _KGCKEY_KGC;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
