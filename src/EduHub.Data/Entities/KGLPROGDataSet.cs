using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Programs Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLPROGDataSet : SetBase<KGLPROG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLPROG"; } }

        internal KGLPROGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLPROGRAM = new Lazy<Dictionary<string, KGLPROG>>(() => this.ToDictionary(i => i.GLPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLPROG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLPROG" /> fields for each CSV column header</returns>
        protected override Action<KGLPROG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLPROG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGLPROG>> Index_GLPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <returns>Related KGLPROG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLPROG FindByGLPROGRAM(string GLPROGRAM)
        {
            return Index_GLPROGRAM.Value[GLPROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <param name="Value">Related KGLPROG entity</param>
        /// <returns>True if the related KGLPROG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLPROGRAM(string GLPROGRAM, out KGLPROG Value)
        {
            return Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <returns>Related KGLPROG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLPROG TryFindByGLPROGRAM(string GLPROGRAM)
        {
            KGLPROG value;
            if (Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
