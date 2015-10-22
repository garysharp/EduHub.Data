using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religious Instruction Curricula
    /// </summary>
    public partial class KCI : EntityBase
    {
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

#region Navigation Properties

        /// <summary>
        /// SCI (School Information) related entities by [SCI.REL_INSTR]-&gt;[KCI.KCIKEY]
        /// </summary>
        public IReadOnlyList<SCI> SCI_REL_INSTR
        {
            get
            {
                return Context.KCI.FindSCIByREL_INSTR(KCIKEY);
            }
        }

        /// <summary>
        /// ST (Students) related entities by [ST.REL_INSTR]-&gt;[KCI.KCIKEY]
        /// </summary>
        public IReadOnlyList<ST> ST_REL_INSTR
        {
            get
            {
                return Context.KCI.FindSTByREL_INSTR(KCIKEY);
            }
        }
#endregion
    }
}
