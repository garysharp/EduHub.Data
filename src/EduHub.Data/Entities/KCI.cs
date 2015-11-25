using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religious Instruction Curricula
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCI : EntityBase
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<SCI> Cache_KCIKEY_SCI_REL_INSTR;
        private IReadOnlyList<ST> Cache_KCIKEY_ST_REL_INSTR;

        #endregion

        #region Field Properties

        /// <summary>
        /// Religious Instruction Curriculum code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string KCIKEY { get; internal set; }

        /// <summary>
        /// Religious Instruction Curriculum description
        /// [Alphanumeric (40)]
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
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// SCI (School Information) related entities by [KCI.KCIKEY]-&gt;[SCI.REL_INSTR]
        /// Religious Instruction Curriculum code
        /// </summary>
        public IReadOnlyList<SCI> KCIKEY_SCI_REL_INSTR
        {
            get
            {
                if (Cache_KCIKEY_SCI_REL_INSTR == null &&
                    !Context.SCI.TryFindByREL_INSTR(KCIKEY, out Cache_KCIKEY_SCI_REL_INSTR))
                {
                    Cache_KCIKEY_SCI_REL_INSTR = new List<SCI>().AsReadOnly();
                }

                return Cache_KCIKEY_SCI_REL_INSTR;
            }
        }

        /// <summary>
        /// ST (Students) related entities by [KCI.KCIKEY]-&gt;[ST.REL_INSTR]
        /// Religious Instruction Curriculum code
        /// </summary>
        public IReadOnlyList<ST> KCIKEY_ST_REL_INSTR
        {
            get
            {
                if (Cache_KCIKEY_ST_REL_INSTR == null &&
                    !Context.ST.TryFindByREL_INSTR(KCIKEY, out Cache_KCIKEY_ST_REL_INSTR))
                {
                    Cache_KCIKEY_ST_REL_INSTR = new List<ST>().AsReadOnly();
                }

                return Cache_KCIKEY_ST_REL_INSTR;
            }
        }

        #endregion

    }
}
