using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Class Information
    /// </summary>
    public class TCTQ : EntityBase
    {
#region Navigation Property Cache
        private TC _TCTQKEY_TC;
        private TH _QKEY_TH;
        private SU _SUBJ_SU;
        private SF _T1TEACH_SF;
        private SF _T2TEACH_SF;
        private SM _R1ROOM_SM;
        private SM _R2ROOM_SM;
        private SF _EXTRA_TEACH_SF;
        private SM _EXTRA_ROOM_SM;
        private TT _GKEY_TT;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// (was TQTCKEY) Owner relation
        /// </summary>
        public DateTime? TCTQKEY { get; internal set; }
        /// <summary>
        /// Associated Quilt
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string QKEY { get; internal set; }
        /// <summary>
        /// Subject
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string SUBJ { get; internal set; }
        /// <summary>
        /// Class number
        /// </summary>
        public short? CLASS { get; internal set; }
        /// <summary>
        /// Ident number
        /// </summary>
        public int? IDENT { get; internal set; }
        /// <summary>
        /// Actual class size
        /// </summary>
        public short? CLASS_SIZE { get; internal set; }
        /// <summary>
        /// 1st teacher for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string T1TEACH { get; internal set; }
        /// <summary>
        /// 2nd teacher for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string T2TEACH { get; internal set; }
        /// <summary>
        /// 1st room for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string R1ROOM { get; internal set; }
        /// <summary>
        /// 2nd room for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string R2ROOM { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES01 { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES02 { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES03 { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES04 { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES05 { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES06 { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES07 { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES08 { get; internal set; }
        /// <summary>
        /// Resources for this period
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string RESOURCES09 { get; internal set; }
        /// <summary>
        /// Teacher replacement
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string EXTRA_TEACH { get; internal set; }
        /// <summary>
        /// Room for replacement
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string EXTRA_ROOM { get; internal set; }
        /// <summary>
        /// Quilt cell row
        /// </summary>
        public short? QROW { get; internal set; }
        /// <summary>
        /// Quilt cell col
        /// </summary>
        public short? QCOL { get; internal set; }
        /// <summary>
        /// Flag indicating if this is a composite class
        /// </summary>
        public short COMPOSITE { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string GKEY { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public short? GROW { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public short? GCOL { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public int? GCOLOUR { get; internal set; }
        /// <summary>
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public short? OCCUR { get; internal set; }
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

#region Navigation Properties
        /// <summary>
        /// Navigation property for [TCTQKEY] => [TC].[TCKEY]
        /// (was TQTCKEY) Owner relation
        /// </summary>
        public TC TCTQKEY_TC {
            get
            {
                if (TCTQKEY.HasValue)
                {
                    if (_TCTQKEY_TC == null)
                    {
                        _TCTQKEY_TC = Context.TC.FindByTCKEY(TCTQKEY.Value);
                    }
                    return _TCTQKEY_TC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [QKEY] => [TH].[THKEY]
        /// Associated Quilt
        /// </summary>
        public TH QKEY_TH {
            get
            {
                if (QKEY != null)
                {
                    if (_QKEY_TH == null)
                    {
                        _QKEY_TH = Context.TH.FindByTHKEY(QKEY);
                    }
                    return _QKEY_TH;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBJ] => [SU].[SUKEY]
        /// Subject
        /// </summary>
        public SU SUBJ_SU {
            get
            {
                if (SUBJ != null)
                {
                    if (_SUBJ_SU == null)
                    {
                        _SUBJ_SU = Context.SU.FindBySUKEY(SUBJ);
                    }
                    return _SUBJ_SU;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [T1TEACH] => [SF].[SFKEY]
        /// 1st teacher for this period
        /// </summary>
        public SF T1TEACH_SF {
            get
            {
                if (T1TEACH != null)
                {
                    if (_T1TEACH_SF == null)
                    {
                        _T1TEACH_SF = Context.SF.FindBySFKEY(T1TEACH);
                    }
                    return _T1TEACH_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [T2TEACH] => [SF].[SFKEY]
        /// 2nd teacher for this period
        /// </summary>
        public SF T2TEACH_SF {
            get
            {
                if (T2TEACH != null)
                {
                    if (_T2TEACH_SF == null)
                    {
                        _T2TEACH_SF = Context.SF.FindBySFKEY(T2TEACH);
                    }
                    return _T2TEACH_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [R1ROOM] => [SM].[ROOM]
        /// 1st room for this period
        /// </summary>
        public SM R1ROOM_SM {
            get
            {
                if (R1ROOM != null)
                {
                    if (_R1ROOM_SM == null)
                    {
                        _R1ROOM_SM = Context.SM.FindByROOM(R1ROOM);
                    }
                    return _R1ROOM_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [R2ROOM] => [SM].[ROOM]
        /// 2nd room for this period
        /// </summary>
        public SM R2ROOM_SM {
            get
            {
                if (R2ROOM != null)
                {
                    if (_R2ROOM_SM == null)
                    {
                        _R2ROOM_SM = Context.SM.FindByROOM(R2ROOM);
                    }
                    return _R2ROOM_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EXTRA_TEACH] => [SF].[SFKEY]
        /// Teacher replacement
        /// </summary>
        public SF EXTRA_TEACH_SF {
            get
            {
                if (EXTRA_TEACH != null)
                {
                    if (_EXTRA_TEACH_SF == null)
                    {
                        _EXTRA_TEACH_SF = Context.SF.FindBySFKEY(EXTRA_TEACH);
                    }
                    return _EXTRA_TEACH_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [EXTRA_ROOM] => [SM].[ROOM]
        /// Room for replacement
        /// </summary>
        public SM EXTRA_ROOM_SM {
            get
            {
                if (EXTRA_ROOM != null)
                {
                    if (_EXTRA_ROOM_SM == null)
                    {
                        _EXTRA_ROOM_SM = Context.SM.FindByROOM(EXTRA_ROOM);
                    }
                    return _EXTRA_ROOM_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [GKEY] => [TT].[TTKEY]
        /// Inserted by Schema Verify for 8.15.1
        /// </summary>
        public TT GKEY_TT {
            get
            {
                if (GKEY != null)
                {
                    if (_GKEY_TT == null)
                    {
                        _GKEY_TT = Context.TT.FindByTTKEY(GKEY);
                    }
                    return _GKEY_TT;
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
