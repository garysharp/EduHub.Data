using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Houses
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGH : EduHubEntity
    {

        #region Navigation Property Cache

        private SCI Cache_CAMPUS_SCI;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<SF> Cache_KGHKEY_SF_HOUSE;
        private IReadOnlyList<SG> Cache_KGHKEY_SG_HOUSE;
        private IReadOnlyList<ST> Cache_KGHKEY_ST_HOUSE;

        #endregion

        #region Field Properties

        /// <summary>
        /// (Was HOUSE) House code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KGHKEY { get; internal set; }

        /// <summary>
        /// House description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Campus
        /// </summary>
        public int? CAMPUS { get; internal set; }

        /// <summary>
        /// Active house? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }

        /// <summary>
        /// Number of current students in the house
        /// </summary>
        public short? HOUSE_SIZE { get; internal set; }

        /// <summary>
        /// Number of current males in the house
        /// </summary>
        public short? MALES { get; internal set; }

        /// <summary>
        /// Number of current females in the house
        /// </summary>
        public short? FEMALES { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F01 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F02 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F03 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F04 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F05 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F06 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F07 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F08 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F09 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F10 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F11 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F12 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F13 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F14 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F15 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F16 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F17 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F18 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F19 { get; internal set; }

        /// <summary>
        /// Number of females aged x as at 31st Dec
        /// </summary>
        public short? AGE_F20 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M01 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M02 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M03 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M04 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M05 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M06 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M07 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M08 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M09 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M10 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M11 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M12 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M13 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M14 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M15 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M16 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M17 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M18 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M19 { get; internal set; }

        /// <summary>
        /// Number of males aged x as at 31 dec
        /// </summary>
        public short? AGE_M20 { get; internal set; }

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
        /// SCI (School Information) related entity by [KGH.CAMPUS]-&gt;[SCI.SCIKEY]
        /// Campus
        /// </summary>
        public SCI CAMPUS_SCI
        {
            get
            {
                if (CAMPUS == null)
                {
                    return null;
                }
                if (Cache_CAMPUS_SCI == null)
                {
                    Cache_CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                }

                return Cache_CAMPUS_SCI;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SF (Staff) related entities by [KGH.KGHKEY]-&gt;[SF.HOUSE]
        /// (Was HOUSE) House code
        /// </summary>
        public IReadOnlyList<SF> KGHKEY_SF_HOUSE
        {
            get
            {
                if (Cache_KGHKEY_SF_HOUSE == null &&
                    !Context.SF.TryFindByHOUSE(KGHKEY, out Cache_KGHKEY_SF_HOUSE))
                {
                    Cache_KGHKEY_SF_HOUSE = new List<SF>().AsReadOnly();
                }

                return Cache_KGHKEY_SF_HOUSE;
            }
        }

        /// <summary>
        /// SG (Student Groupings) related entities by [KGH.KGHKEY]-&gt;[SG.HOUSE]
        /// (Was HOUSE) House code
        /// </summary>
        public IReadOnlyList<SG> KGHKEY_SG_HOUSE
        {
            get
            {
                if (Cache_KGHKEY_SG_HOUSE == null &&
                    !Context.SG.TryFindByHOUSE(KGHKEY, out Cache_KGHKEY_SG_HOUSE))
                {
                    Cache_KGHKEY_SG_HOUSE = new List<SG>().AsReadOnly();
                }

                return Cache_KGHKEY_SG_HOUSE;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KGH.KGHKEY]-&gt;[ST.HOUSE]
        /// (Was HOUSE) House code
        /// </summary>
        public IReadOnlyList<ST> KGHKEY_ST_HOUSE
        {
            get
            {
                if (Cache_KGHKEY_ST_HOUSE == null &&
                    !Context.ST.TryFindByHOUSE(KGHKEY, out Cache_KGHKEY_ST_HOUSE))
                {
                    Cache_KGHKEY_ST_HOUSE = new List<ST>().AsReadOnly();
                }

                return Cache_KGHKEY_ST_HOUSE;
            }
        }

        #endregion

    }
}
