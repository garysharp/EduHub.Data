using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Programs Data Set
    /// </summary>
    public sealed class KGLPROGDataSet : SetBase<KGLPROG>
    {
        private Lazy<Dictionary<string, KGLPROG>> GLPROGRAMIndex;

        internal KGLPROGDataSet(EduHubContext Context)
            : base(Context)
        {
            GLPROGRAMIndex = new Lazy<Dictionary<string, KGLPROG>>(() => this.ToDictionary(e => e.GLPROGRAM));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLPROG"; } }

        /// <summary>
        /// Find KGLPROG by GLPROGRAM key field
        /// </summary>
        /// <param name="Key">GLPROGRAM value used to find KGLPROG</param>
        /// <returns>Related KGLPROG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">GLPROGRAM value didn't match any KGLPROG entities</exception>
        public KGLPROG FindByGLPROGRAM(string Key)
        {
            KGLPROG result;
            if (GLPROGRAMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGLPROG by GLPROGRAM key field
        /// </summary>
        /// <param name="Key">GLPROGRAM value used to find KGLPROG</param>
        /// <param name="Value">Related KGLPROG entity</param>
        /// <returns>True if the KGLPROG entity is found</returns>
        public bool TryFindByGLPROGRAM(string Key, out KGLPROG Value)
        {
            return GLPROGRAMIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGLPROG by GLPROGRAM key field
        /// </summary>
        /// <param name="Key">GLPROGRAM value used to find KGLPROG</param>
        /// <returns>Related KGLPROG entity, or null if not found</returns>
        public KGLPROG TryFindByGLPROGRAM(string Key)
        {
            KGLPROG result;
            if (GLPROGRAMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLPROG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLPROG" /> fields for each CSV column header</returns>
        protected override Action<KGLPROG, string>[] BuildMapper(List<string> Headers)
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
    }
}
