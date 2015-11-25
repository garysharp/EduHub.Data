using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Departments Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PDDataSet : SetBase<PD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PD"; } }

        internal PDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLBANK = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLBANK));
            Index_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE));
            Index_GLTAX = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.GLTAX));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PDKEY = new Lazy<Dictionary<string, PD>>(() => this.ToDictionary(i => i.PDKEY));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PD>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PD" /> fields for each CSV column header</returns>
        protected override Action<PD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PDKEY":
                        mapper[i] = (e, v) => e.PDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANK":
                        mapper[i] = (e, v) => e.GLBANK = v;
                        break;
                    case "GLTAX":
                        mapper[i] = (e, v) => e.GLTAX = v;
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

        /// <summary>
        /// Merges <see cref="PD" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="PD" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="PD" /> items to added or update the base <see cref="PD" /> items</param>
        /// <returns>A merged list of <see cref="PD" /> items</returns>
        protected override List<PD> ApplyDeltaItems(List<PD> Items, List<PD> DeltaItems)
        {
            Dictionary<string, int> Index_PDKEY = Items.ToIndexDictionary(i => i.PDKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (PD deltaItem in DeltaItems)
            {
                int index;

                if (Index_PDKEY.TryGetValue(deltaItem.PDKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.PDKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLBANK;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLCODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_GLTAX;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_INITIATIVE;
        private Lazy<Dictionary<string, PD>> Index_PDKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PD>>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLBANK(string GLBANK)
        {
            return Index_GLBANK.Value[GLBANK];
        }

        /// <summary>
        /// Attempt to find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLBANK(string GLBANK, out IReadOnlyList<PD> Value)
        {
            return Index_GLBANK.Value.TryGetValue(GLBANK, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLBANK field
        /// </summary>
        /// <param name="GLBANK">GLBANK value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLBANK(string GLBANK)
        {
            IReadOnlyList<PD> value;
            if (Index_GLBANK.Value.TryGetValue(GLBANK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out IReadOnlyList<PD> Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLCODE(string GLCODE)
        {
            IReadOnlyList<PD> value;
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
        /// Find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByGLTAX(string GLTAX)
        {
            return Index_GLTAX.Value[GLTAX];
        }

        /// <summary>
        /// Attempt to find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLTAX(string GLTAX, out IReadOnlyList<PD> Value)
        {
            return Index_GLTAX.Value.TryGetValue(GLTAX, out Value);
        }

        /// <summary>
        /// Attempt to find PD by GLTAX field
        /// </summary>
        /// <param name="GLTAX">GLTAX value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByGLTAX(string GLTAX)
        {
            IReadOnlyList<PD> value;
            if (Index_GLTAX.Value.TryGetValue(GLTAX, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PD> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PD by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PD> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <returns>Related PD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PD FindByPDKEY(string PDKEY)
        {
            return Index_PDKEY.Value[PDKEY];
        }

        /// <summary>
        /// Attempt to find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <param name="Value">Related PD entity</param>
        /// <returns>True if the related PD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPDKEY(string PDKEY, out PD Value)
        {
            return Index_PDKEY.Value.TryGetValue(PDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PD by PDKEY field
        /// </summary>
        /// <param name="PDKEY">PDKEY value used to find PD</param>
        /// <returns>Related PD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PD TryFindByPDKEY(string PDKEY)
        {
            PD value;
            if (Index_PDKEY.Value.TryGetValue(PDKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <returns>List of related PD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <param name="Value">List of related PD entities</param>
        /// <returns>True if the list of related PD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PD> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PD by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PD</param>
        /// <returns>List of related PD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PD> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PD> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
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
