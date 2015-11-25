using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKCDataSet : SetBase<AKC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKC"; } }

        internal AKCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_APTE_GLCODE = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.APTE_GLCODE));
            Index_CATEGORY = new Lazy<Dictionary<string, AKC>>(() => this.ToDictionary(i => i.CATEGORY));
            Index_DEPN_AMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.DEPN_AMETHOD));
            Index_DEPN_TMETHOD = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.DEPN_TMETHOD));
            Index_GL_DISP_PROC = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.GL_DISP_PROC));
            Index_GL_DISP_PROF = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.GL_DISP_PROF));
            Index_GL_REVALS_ASS = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.GL_REVALS_ASS));
            Index_GL_REVALS_BS = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.GL_REVALS_BS));
            Index_GL_REVALS_PL = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.GL_REVALS_PL));
            Index_GLCODE_ASS = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE_ASS));
            Index_GLCODE_EXP = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE_EXP));
            Index_GLCODE_PRV = new Lazy<NullDictionary<string, IReadOnlyList<AKC>>>(() => this.ToGroupedNullDictionary(i => i.GLCODE_PRV));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKC" /> fields for each CSV column header</returns>
        protected override Action<AKC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "GLCODE_ASS":
                        mapper[i] = (e, v) => e.GLCODE_ASS = v;
                        break;
                    case "GLCODE_PRV":
                        mapper[i] = (e, v) => e.GLCODE_PRV = v;
                        break;
                    case "GLCODE_EXP":
                        mapper[i] = (e, v) => e.GLCODE_EXP = v;
                        break;
                    case "GL_REVALS_BS":
                        mapper[i] = (e, v) => e.GL_REVALS_BS = v;
                        break;
                    case "GL_REVALS_PL":
                        mapper[i] = (e, v) => e.GL_REVALS_PL = v;
                        break;
                    case "GL_REVALS_ASS":
                        mapper[i] = (e, v) => e.GL_REVALS_ASS = v;
                        break;
                    case "GL_DISP_PROF":
                        mapper[i] = (e, v) => e.GL_DISP_PROF = v;
                        break;
                    case "GL_DISP_PROC":
                        mapper[i] = (e, v) => e.GL_DISP_PROC = v;
                        break;
                    case "APTE_GLCODE":
                        mapper[i] = (e, v) => e.APTE_GLCODE = v;
                        break;
                    case "PTE_USE_RATE":
                        mapper[i] = (e, v) => e.PTE_USE_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DEPN_AMETHOD":
                        mapper[i] = (e, v) => e.DEPN_AMETHOD = v;
                        break;
                    case "DEPN_TMETHOD":
                        mapper[i] = (e, v) => e.DEPN_TMETHOD = v;
                        break;
                    case "DEPN_ARATE":
                        mapper[i] = (e, v) => e.DEPN_ARATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "APTE_USE_RATE":
                        mapper[i] = (e, v) => e.APTE_USE_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "DEPN_TRATE":
                        mapper[i] = (e, v) => e.DEPN_TRATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TPTE_USE_RATE":
                        mapper[i] = (e, v) => e.TPTE_USE_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "EXPECTED_LIFE":
                        mapper[i] = (e, v) => e.EXPECTED_LIFE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEND_TO_FLAG":
                        mapper[i] = (e, v) => e.SEND_TO_FLAG = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "MAP_CATEGORY":
                        mapper[i] = (e, v) => e.MAP_CATEGORY = v;
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
        /// Merges <see cref="AKC" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="AKC" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="AKC" /> items to added or update the base <see cref="AKC" /> items</param>
        /// <returns>A merged list of <see cref="AKC" /> items</returns>
        protected override List<AKC> ApplyDeltaItems(List<AKC> Items, List<AKC> DeltaItems)
        {
            Dictionary<string, int> Index_CATEGORY = Items.ToIndexDictionary(i => i.CATEGORY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (AKC deltaItem in DeltaItems)
            {
                int index;

                if (Index_CATEGORY.TryGetValue(deltaItem.CATEGORY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.CATEGORY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_APTE_GLCODE;
        private Lazy<Dictionary<string, AKC>> Index_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_DEPN_AMETHOD;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_DEPN_TMETHOD;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_GL_DISP_PROC;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_GL_DISP_PROF;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_GL_REVALS_ASS;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_GL_REVALS_BS;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_GL_REVALS_PL;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_GLCODE_ASS;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_GLCODE_EXP;
        private Lazy<NullDictionary<string, IReadOnlyList<AKC>>> Index_GLCODE_PRV;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find AKC by APTE_GLCODE field
        /// </summary>
        /// <param name="APTE_GLCODE">APTE_GLCODE value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByAPTE_GLCODE(string APTE_GLCODE)
        {
            return Index_APTE_GLCODE.Value[APTE_GLCODE];
        }

        /// <summary>
        /// Attempt to find AKC by APTE_GLCODE field
        /// </summary>
        /// <param name="APTE_GLCODE">APTE_GLCODE value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByAPTE_GLCODE(string APTE_GLCODE, out IReadOnlyList<AKC> Value)
        {
            return Index_APTE_GLCODE.Value.TryGetValue(APTE_GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by APTE_GLCODE field
        /// </summary>
        /// <param name="APTE_GLCODE">APTE_GLCODE value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByAPTE_GLCODE(string APTE_GLCODE)
        {
            IReadOnlyList<AKC> value;
            if (Index_APTE_GLCODE.Value.TryGetValue(APTE_GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKC</param>
        /// <returns>Related AKC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKC FindByCATEGORY(string CATEGORY)
        {
            return Index_CATEGORY.Value[CATEGORY];
        }

        /// <summary>
        /// Attempt to find AKC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKC</param>
        /// <param name="Value">Related AKC entity</param>
        /// <returns>True if the related AKC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCATEGORY(string CATEGORY, out AKC Value)
        {
            return Index_CATEGORY.Value.TryGetValue(CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find AKC</param>
        /// <returns>Related AKC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public AKC TryFindByCATEGORY(string CATEGORY)
        {
            AKC value;
            if (Index_CATEGORY.Value.TryGetValue(CATEGORY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by DEPN_AMETHOD field
        /// </summary>
        /// <param name="DEPN_AMETHOD">DEPN_AMETHOD value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByDEPN_AMETHOD(string DEPN_AMETHOD)
        {
            return Index_DEPN_AMETHOD.Value[DEPN_AMETHOD];
        }

        /// <summary>
        /// Attempt to find AKC by DEPN_AMETHOD field
        /// </summary>
        /// <param name="DEPN_AMETHOD">DEPN_AMETHOD value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEPN_AMETHOD(string DEPN_AMETHOD, out IReadOnlyList<AKC> Value)
        {
            return Index_DEPN_AMETHOD.Value.TryGetValue(DEPN_AMETHOD, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by DEPN_AMETHOD field
        /// </summary>
        /// <param name="DEPN_AMETHOD">DEPN_AMETHOD value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByDEPN_AMETHOD(string DEPN_AMETHOD)
        {
            IReadOnlyList<AKC> value;
            if (Index_DEPN_AMETHOD.Value.TryGetValue(DEPN_AMETHOD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByDEPN_TMETHOD(string DEPN_TMETHOD)
        {
            return Index_DEPN_TMETHOD.Value[DEPN_TMETHOD];
        }

        /// <summary>
        /// Attempt to find AKC by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByDEPN_TMETHOD(string DEPN_TMETHOD, out IReadOnlyList<AKC> Value)
        {
            return Index_DEPN_TMETHOD.Value.TryGetValue(DEPN_TMETHOD, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by DEPN_TMETHOD field
        /// </summary>
        /// <param name="DEPN_TMETHOD">DEPN_TMETHOD value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByDEPN_TMETHOD(string DEPN_TMETHOD)
        {
            IReadOnlyList<AKC> value;
            if (Index_DEPN_TMETHOD.Value.TryGetValue(DEPN_TMETHOD, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by GL_DISP_PROC field
        /// </summary>
        /// <param name="GL_DISP_PROC">GL_DISP_PROC value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByGL_DISP_PROC(string GL_DISP_PROC)
        {
            return Index_GL_DISP_PROC.Value[GL_DISP_PROC];
        }

        /// <summary>
        /// Attempt to find AKC by GL_DISP_PROC field
        /// </summary>
        /// <param name="GL_DISP_PROC">GL_DISP_PROC value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_DISP_PROC(string GL_DISP_PROC, out IReadOnlyList<AKC> Value)
        {
            return Index_GL_DISP_PROC.Value.TryGetValue(GL_DISP_PROC, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by GL_DISP_PROC field
        /// </summary>
        /// <param name="GL_DISP_PROC">GL_DISP_PROC value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByGL_DISP_PROC(string GL_DISP_PROC)
        {
            IReadOnlyList<AKC> value;
            if (Index_GL_DISP_PROC.Value.TryGetValue(GL_DISP_PROC, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by GL_DISP_PROF field
        /// </summary>
        /// <param name="GL_DISP_PROF">GL_DISP_PROF value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByGL_DISP_PROF(string GL_DISP_PROF)
        {
            return Index_GL_DISP_PROF.Value[GL_DISP_PROF];
        }

        /// <summary>
        /// Attempt to find AKC by GL_DISP_PROF field
        /// </summary>
        /// <param name="GL_DISP_PROF">GL_DISP_PROF value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_DISP_PROF(string GL_DISP_PROF, out IReadOnlyList<AKC> Value)
        {
            return Index_GL_DISP_PROF.Value.TryGetValue(GL_DISP_PROF, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by GL_DISP_PROF field
        /// </summary>
        /// <param name="GL_DISP_PROF">GL_DISP_PROF value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByGL_DISP_PROF(string GL_DISP_PROF)
        {
            IReadOnlyList<AKC> value;
            if (Index_GL_DISP_PROF.Value.TryGetValue(GL_DISP_PROF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by GL_REVALS_ASS field
        /// </summary>
        /// <param name="GL_REVALS_ASS">GL_REVALS_ASS value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByGL_REVALS_ASS(string GL_REVALS_ASS)
        {
            return Index_GL_REVALS_ASS.Value[GL_REVALS_ASS];
        }

        /// <summary>
        /// Attempt to find AKC by GL_REVALS_ASS field
        /// </summary>
        /// <param name="GL_REVALS_ASS">GL_REVALS_ASS value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_REVALS_ASS(string GL_REVALS_ASS, out IReadOnlyList<AKC> Value)
        {
            return Index_GL_REVALS_ASS.Value.TryGetValue(GL_REVALS_ASS, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by GL_REVALS_ASS field
        /// </summary>
        /// <param name="GL_REVALS_ASS">GL_REVALS_ASS value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByGL_REVALS_ASS(string GL_REVALS_ASS)
        {
            IReadOnlyList<AKC> value;
            if (Index_GL_REVALS_ASS.Value.TryGetValue(GL_REVALS_ASS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by GL_REVALS_BS field
        /// </summary>
        /// <param name="GL_REVALS_BS">GL_REVALS_BS value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByGL_REVALS_BS(string GL_REVALS_BS)
        {
            return Index_GL_REVALS_BS.Value[GL_REVALS_BS];
        }

        /// <summary>
        /// Attempt to find AKC by GL_REVALS_BS field
        /// </summary>
        /// <param name="GL_REVALS_BS">GL_REVALS_BS value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_REVALS_BS(string GL_REVALS_BS, out IReadOnlyList<AKC> Value)
        {
            return Index_GL_REVALS_BS.Value.TryGetValue(GL_REVALS_BS, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by GL_REVALS_BS field
        /// </summary>
        /// <param name="GL_REVALS_BS">GL_REVALS_BS value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByGL_REVALS_BS(string GL_REVALS_BS)
        {
            IReadOnlyList<AKC> value;
            if (Index_GL_REVALS_BS.Value.TryGetValue(GL_REVALS_BS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by GL_REVALS_PL field
        /// </summary>
        /// <param name="GL_REVALS_PL">GL_REVALS_PL value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByGL_REVALS_PL(string GL_REVALS_PL)
        {
            return Index_GL_REVALS_PL.Value[GL_REVALS_PL];
        }

        /// <summary>
        /// Attempt to find AKC by GL_REVALS_PL field
        /// </summary>
        /// <param name="GL_REVALS_PL">GL_REVALS_PL value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_REVALS_PL(string GL_REVALS_PL, out IReadOnlyList<AKC> Value)
        {
            return Index_GL_REVALS_PL.Value.TryGetValue(GL_REVALS_PL, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by GL_REVALS_PL field
        /// </summary>
        /// <param name="GL_REVALS_PL">GL_REVALS_PL value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByGL_REVALS_PL(string GL_REVALS_PL)
        {
            IReadOnlyList<AKC> value;
            if (Index_GL_REVALS_PL.Value.TryGetValue(GL_REVALS_PL, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by GLCODE_ASS field
        /// </summary>
        /// <param name="GLCODE_ASS">GLCODE_ASS value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByGLCODE_ASS(string GLCODE_ASS)
        {
            return Index_GLCODE_ASS.Value[GLCODE_ASS];
        }

        /// <summary>
        /// Attempt to find AKC by GLCODE_ASS field
        /// </summary>
        /// <param name="GLCODE_ASS">GLCODE_ASS value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE_ASS(string GLCODE_ASS, out IReadOnlyList<AKC> Value)
        {
            return Index_GLCODE_ASS.Value.TryGetValue(GLCODE_ASS, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by GLCODE_ASS field
        /// </summary>
        /// <param name="GLCODE_ASS">GLCODE_ASS value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByGLCODE_ASS(string GLCODE_ASS)
        {
            IReadOnlyList<AKC> value;
            if (Index_GLCODE_ASS.Value.TryGetValue(GLCODE_ASS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by GLCODE_EXP field
        /// </summary>
        /// <param name="GLCODE_EXP">GLCODE_EXP value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByGLCODE_EXP(string GLCODE_EXP)
        {
            return Index_GLCODE_EXP.Value[GLCODE_EXP];
        }

        /// <summary>
        /// Attempt to find AKC by GLCODE_EXP field
        /// </summary>
        /// <param name="GLCODE_EXP">GLCODE_EXP value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE_EXP(string GLCODE_EXP, out IReadOnlyList<AKC> Value)
        {
            return Index_GLCODE_EXP.Value.TryGetValue(GLCODE_EXP, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by GLCODE_EXP field
        /// </summary>
        /// <param name="GLCODE_EXP">GLCODE_EXP value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByGLCODE_EXP(string GLCODE_EXP)
        {
            IReadOnlyList<AKC> value;
            if (Index_GLCODE_EXP.Value.TryGetValue(GLCODE_EXP, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find AKC by GLCODE_PRV field
        /// </summary>
        /// <param name="GLCODE_PRV">GLCODE_PRV value used to find AKC</param>
        /// <returns>List of related AKC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> FindByGLCODE_PRV(string GLCODE_PRV)
        {
            return Index_GLCODE_PRV.Value[GLCODE_PRV];
        }

        /// <summary>
        /// Attempt to find AKC by GLCODE_PRV field
        /// </summary>
        /// <param name="GLCODE_PRV">GLCODE_PRV value used to find AKC</param>
        /// <param name="Value">List of related AKC entities</param>
        /// <returns>True if the list of related AKC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE_PRV(string GLCODE_PRV, out IReadOnlyList<AKC> Value)
        {
            return Index_GLCODE_PRV.Value.TryGetValue(GLCODE_PRV, out Value);
        }

        /// <summary>
        /// Attempt to find AKC by GLCODE_PRV field
        /// </summary>
        /// <param name="GLCODE_PRV">GLCODE_PRV value used to find AKC</param>
        /// <returns>List of related AKC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<AKC> TryFindByGLCODE_PRV(string GLCODE_PRV)
        {
            IReadOnlyList<AKC> value;
            if (Index_GLCODE_PRV.Value.TryGetValue(GLCODE_PRV, out value))
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
