using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Sub Programs Data Set
    /// </summary>
    public sealed class KGLSUBDataSet : SetBase<KGLSUB>
    {
        private Lazy<Dictionary<string, KGLSUB>> SUBPROGRAMIndex;

        internal KGLSUBDataSet(EduHubContext Context)
            : base(Context)
        {
            SUBPROGRAMIndex = new Lazy<Dictionary<string, KGLSUB>>(() => this.ToDictionary(e => e.SUBPROGRAM));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLSUB"; } }

        /// <summary>
        /// Find KGLSUB by SUBPROGRAM key field
        /// </summary>
        /// <param name="Key">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SUBPROGRAM value didn't match any KGLSUB entities</exception>
        public KGLSUB FindBySUBPROGRAM(string Key)
        {
            KGLSUB result;
            if (SUBPROGRAMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM key field
        /// </summary>
        /// <param name="Key">SUBPROGRAM value used to find KGLSUB</param>
        /// <param name="Value">Related KGLSUB entity</param>
        /// <returns>True if the KGLSUB entity is found</returns>
        public bool TryFindBySUBPROGRAM(string Key, out KGLSUB Value)
        {
            return SUBPROGRAMIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM key field
        /// </summary>
        /// <param name="Key">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity, or null if not found</returns>
        public KGLSUB TryFindBySUBPROGRAM(string Key)
        {
            KGLSUB result;
            if (SUBPROGRAMIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLSUB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLSUB" /> fields for each CSV column header</returns>
        protected override Action<KGLSUB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLSUB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "GL_PROGRAM":
                        mapper[i] = (e, v) => e.GL_PROGRAM = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "USER_DEFINABLE":
                        mapper[i] = (e, v) => e.USER_DEFINABLE = v;
                        break;
                    case "RESERVED":
                        mapper[i] = (e, v) => e.RESERVED = v;
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
