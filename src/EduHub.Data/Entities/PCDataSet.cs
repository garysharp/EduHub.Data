using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Cost Centres Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PCDataSet : SetBase<PC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PC"; } }

        internal PCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PCKEY = new Lazy<Dictionary<string, PC>>(() => this.ToDictionary(i => i.PCKEY));
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PC>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PC" /> fields for each CSV column header</returns>
        protected override Action<PC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PCKEY":
                        mapper[i] = (e, v) => e.PCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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

        private Lazy<Dictionary<string, PC>> Index_PCKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<PC>>> Index_INITIATIVE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <returns>Related PC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PC FindByPCKEY(string PCKEY)
        {
            return Index_PCKEY.Value[PCKEY];
        }

        /// <summary>
        /// Attempt to find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <param name="Value">Related PC entity</param>
        /// <returns>True if the related PC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPCKEY(string PCKEY, out PC Value)
        {
            return Index_PCKEY.Value.TryGetValue(PCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PC by PCKEY field
        /// </summary>
        /// <param name="PCKEY">PCKEY value used to find PC</param>
        /// <returns>Related PC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PC TryFindByPCKEY(string PCKEY)
        {
            PC value;
            if (Index_PCKEY.Value.TryGetValue(PCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PC> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PC by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PC> value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PC> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PC by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PC> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <returns>List of related PC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <param name="Value">List of related PC entities</param>
        /// <returns>True if the list of related PC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PC> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PC by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PC</param>
        /// <returns>List of related PC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PC> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PC> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
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
