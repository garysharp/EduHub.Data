using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Categories Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class AKCDataSet : EduHubDataSet<AKC>
    {
        /// <inheritdoc />
        public override string Name { get { return "AKC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

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
        internal override Action<AKC, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
        /// <param name="Entities">Iterator for base <see cref="AKC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="AKC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{AKC}"/> of entities</returns>
        internal override IEnumerable<AKC> ApplyDeltaEntities(IEnumerable<AKC> Entities, List<AKC> DeltaEntities)
        {
            HashSet<string> Index_CATEGORY = new HashSet<string>(DeltaEntities.Select(i => i.CATEGORY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CATEGORY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_CATEGORY.Remove(entity.CATEGORY);
                            
                            if (entity.CATEGORY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
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

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a AKC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[AKC](
        [CATEGORY] varchar(10) NOT NULL,
        [DESCRIPTION] varchar(30) NULL,
        [GLCODE_ASS] varchar(10) NULL,
        [GLCODE_PRV] varchar(10) NULL,
        [GLCODE_EXP] varchar(10) NULL,
        [GL_REVALS_BS] varchar(10) NULL,
        [GL_REVALS_PL] varchar(10) NULL,
        [GL_REVALS_ASS] varchar(10) NULL,
        [GL_DISP_PROF] varchar(10) NULL,
        [GL_DISP_PROC] varchar(10) NULL,
        [APTE_GLCODE] varchar(10) NULL,
        [PTE_USE_RATE] float NULL,
        [DEPN_AMETHOD] varchar(1) NULL,
        [DEPN_TMETHOD] varchar(1) NULL,
        [DEPN_ARATE] float NULL,
        [APTE_USE_RATE] float NULL,
        [DEPN_TRATE] float NULL,
        [TPTE_USE_RATE] float NULL,
        [EXPECTED_LIFE] smallint NULL,
        [SEND_TO_FLAG] varchar(1) NULL,
        [ACTIVE] varchar(1) NULL,
        [MAP_CATEGORY] varchar(10) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [AKC_Index_CATEGORY] PRIMARY KEY CLUSTERED (
            [CATEGORY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_APTE_GLCODE] ON [dbo].[AKC]
    (
            [APTE_GLCODE] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_DEPN_AMETHOD] ON [dbo].[AKC]
    (
            [DEPN_AMETHOD] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_DEPN_TMETHOD] ON [dbo].[AKC]
    (
            [DEPN_TMETHOD] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_GL_DISP_PROC] ON [dbo].[AKC]
    (
            [GL_DISP_PROC] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_GL_DISP_PROF] ON [dbo].[AKC]
    (
            [GL_DISP_PROF] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_GL_REVALS_ASS] ON [dbo].[AKC]
    (
            [GL_REVALS_ASS] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_GL_REVALS_BS] ON [dbo].[AKC]
    (
            [GL_REVALS_BS] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_GL_REVALS_PL] ON [dbo].[AKC]
    (
            [GL_REVALS_PL] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_GLCODE_ASS] ON [dbo].[AKC]
    (
            [GLCODE_ASS] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_GLCODE_EXP] ON [dbo].[AKC]
    (
            [GLCODE_EXP] ASC
    );
    CREATE NONCLUSTERED INDEX [AKC_Index_GLCODE_PRV] ON [dbo].[AKC]
    (
            [GLCODE_PRV] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_APTE_GLCODE')
    ALTER INDEX [Index_APTE_GLCODE] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_DEPN_AMETHOD')
    ALTER INDEX [Index_DEPN_AMETHOD] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_DEPN_TMETHOD')
    ALTER INDEX [Index_DEPN_TMETHOD] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_DISP_PROC')
    ALTER INDEX [Index_GL_DISP_PROC] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_DISP_PROF')
    ALTER INDEX [Index_GL_DISP_PROF] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_REVALS_ASS')
    ALTER INDEX [Index_GL_REVALS_ASS] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_REVALS_BS')
    ALTER INDEX [Index_GL_REVALS_BS] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_REVALS_PL')
    ALTER INDEX [Index_GL_REVALS_PL] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GLCODE_ASS')
    ALTER INDEX [Index_GLCODE_ASS] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GLCODE_EXP')
    ALTER INDEX [Index_GLCODE_EXP] ON [dbo].[AKC] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GLCODE_PRV')
    ALTER INDEX [Index_GLCODE_PRV] ON [dbo].[AKC] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_APTE_GLCODE')
    ALTER INDEX [Index_APTE_GLCODE] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_DEPN_AMETHOD')
    ALTER INDEX [Index_DEPN_AMETHOD] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_DEPN_TMETHOD')
    ALTER INDEX [Index_DEPN_TMETHOD] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_DISP_PROC')
    ALTER INDEX [Index_GL_DISP_PROC] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_DISP_PROF')
    ALTER INDEX [Index_GL_DISP_PROF] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_REVALS_ASS')
    ALTER INDEX [Index_GL_REVALS_ASS] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_REVALS_BS')
    ALTER INDEX [Index_GL_REVALS_BS] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GL_REVALS_PL')
    ALTER INDEX [Index_GL_REVALS_PL] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GLCODE_ASS')
    ALTER INDEX [Index_GLCODE_ASS] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GLCODE_EXP')
    ALTER INDEX [Index_GLCODE_EXP] ON [dbo].[AKC] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[AKC]') AND name = N'Index_GLCODE_PRV')
    ALTER INDEX [Index_GLCODE_PRV] ON [dbo].[AKC] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="AKC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="AKC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<AKC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_CATEGORY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_CATEGORY.Add(entity.CATEGORY);
            }

            builder.AppendLine("DELETE [dbo].[AKC] WHERE");


            // Index_CATEGORY
            builder.Append("[CATEGORY] IN (");
            for (int index = 0; index < Index_CATEGORY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // CATEGORY
                var parameterCATEGORY = $"@p{parameterIndex++}";
                builder.Append(parameterCATEGORY);
                command.Parameters.Add(parameterCATEGORY, SqlDbType.VarChar, 10).Value = Index_CATEGORY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKC data set</returns>
        public override EduHubDataSetDataReader<AKC> GetDataSetDataReader()
        {
            return new AKCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the AKC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the AKC data set</returns>
        public override EduHubDataSetDataReader<AKC> GetDataSetDataReader(List<AKC> Entities)
        {
            return new AKCDataReader(new EduHubDataSetLoadedReader<AKC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class AKCDataReader : EduHubDataSetDataReader<AKC>
        {
            public AKCDataReader(IEduHubDataSetReader<AKC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 25; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // CATEGORY
                        return Current.CATEGORY;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // GLCODE_ASS
                        return Current.GLCODE_ASS;
                    case 3: // GLCODE_PRV
                        return Current.GLCODE_PRV;
                    case 4: // GLCODE_EXP
                        return Current.GLCODE_EXP;
                    case 5: // GL_REVALS_BS
                        return Current.GL_REVALS_BS;
                    case 6: // GL_REVALS_PL
                        return Current.GL_REVALS_PL;
                    case 7: // GL_REVALS_ASS
                        return Current.GL_REVALS_ASS;
                    case 8: // GL_DISP_PROF
                        return Current.GL_DISP_PROF;
                    case 9: // GL_DISP_PROC
                        return Current.GL_DISP_PROC;
                    case 10: // APTE_GLCODE
                        return Current.APTE_GLCODE;
                    case 11: // PTE_USE_RATE
                        return Current.PTE_USE_RATE;
                    case 12: // DEPN_AMETHOD
                        return Current.DEPN_AMETHOD;
                    case 13: // DEPN_TMETHOD
                        return Current.DEPN_TMETHOD;
                    case 14: // DEPN_ARATE
                        return Current.DEPN_ARATE;
                    case 15: // APTE_USE_RATE
                        return Current.APTE_USE_RATE;
                    case 16: // DEPN_TRATE
                        return Current.DEPN_TRATE;
                    case 17: // TPTE_USE_RATE
                        return Current.TPTE_USE_RATE;
                    case 18: // EXPECTED_LIFE
                        return Current.EXPECTED_LIFE;
                    case 19: // SEND_TO_FLAG
                        return Current.SEND_TO_FLAG;
                    case 20: // ACTIVE
                        return Current.ACTIVE;
                    case 21: // MAP_CATEGORY
                        return Current.MAP_CATEGORY;
                    case 22: // LW_DATE
                        return Current.LW_DATE;
                    case 23: // LW_TIME
                        return Current.LW_TIME;
                    case 24: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // GLCODE_ASS
                        return Current.GLCODE_ASS == null;
                    case 3: // GLCODE_PRV
                        return Current.GLCODE_PRV == null;
                    case 4: // GLCODE_EXP
                        return Current.GLCODE_EXP == null;
                    case 5: // GL_REVALS_BS
                        return Current.GL_REVALS_BS == null;
                    case 6: // GL_REVALS_PL
                        return Current.GL_REVALS_PL == null;
                    case 7: // GL_REVALS_ASS
                        return Current.GL_REVALS_ASS == null;
                    case 8: // GL_DISP_PROF
                        return Current.GL_DISP_PROF == null;
                    case 9: // GL_DISP_PROC
                        return Current.GL_DISP_PROC == null;
                    case 10: // APTE_GLCODE
                        return Current.APTE_GLCODE == null;
                    case 11: // PTE_USE_RATE
                        return Current.PTE_USE_RATE == null;
                    case 12: // DEPN_AMETHOD
                        return Current.DEPN_AMETHOD == null;
                    case 13: // DEPN_TMETHOD
                        return Current.DEPN_TMETHOD == null;
                    case 14: // DEPN_ARATE
                        return Current.DEPN_ARATE == null;
                    case 15: // APTE_USE_RATE
                        return Current.APTE_USE_RATE == null;
                    case 16: // DEPN_TRATE
                        return Current.DEPN_TRATE == null;
                    case 17: // TPTE_USE_RATE
                        return Current.TPTE_USE_RATE == null;
                    case 18: // EXPECTED_LIFE
                        return Current.EXPECTED_LIFE == null;
                    case 19: // SEND_TO_FLAG
                        return Current.SEND_TO_FLAG == null;
                    case 20: // ACTIVE
                        return Current.ACTIVE == null;
                    case 21: // MAP_CATEGORY
                        return Current.MAP_CATEGORY == null;
                    case 22: // LW_DATE
                        return Current.LW_DATE == null;
                    case 23: // LW_TIME
                        return Current.LW_TIME == null;
                    case 24: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // CATEGORY
                        return "CATEGORY";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // GLCODE_ASS
                        return "GLCODE_ASS";
                    case 3: // GLCODE_PRV
                        return "GLCODE_PRV";
                    case 4: // GLCODE_EXP
                        return "GLCODE_EXP";
                    case 5: // GL_REVALS_BS
                        return "GL_REVALS_BS";
                    case 6: // GL_REVALS_PL
                        return "GL_REVALS_PL";
                    case 7: // GL_REVALS_ASS
                        return "GL_REVALS_ASS";
                    case 8: // GL_DISP_PROF
                        return "GL_DISP_PROF";
                    case 9: // GL_DISP_PROC
                        return "GL_DISP_PROC";
                    case 10: // APTE_GLCODE
                        return "APTE_GLCODE";
                    case 11: // PTE_USE_RATE
                        return "PTE_USE_RATE";
                    case 12: // DEPN_AMETHOD
                        return "DEPN_AMETHOD";
                    case 13: // DEPN_TMETHOD
                        return "DEPN_TMETHOD";
                    case 14: // DEPN_ARATE
                        return "DEPN_ARATE";
                    case 15: // APTE_USE_RATE
                        return "APTE_USE_RATE";
                    case 16: // DEPN_TRATE
                        return "DEPN_TRATE";
                    case 17: // TPTE_USE_RATE
                        return "TPTE_USE_RATE";
                    case 18: // EXPECTED_LIFE
                        return "EXPECTED_LIFE";
                    case 19: // SEND_TO_FLAG
                        return "SEND_TO_FLAG";
                    case 20: // ACTIVE
                        return "ACTIVE";
                    case 21: // MAP_CATEGORY
                        return "MAP_CATEGORY";
                    case 22: // LW_DATE
                        return "LW_DATE";
                    case 23: // LW_TIME
                        return "LW_TIME";
                    case 24: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "CATEGORY":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "GLCODE_ASS":
                        return 2;
                    case "GLCODE_PRV":
                        return 3;
                    case "GLCODE_EXP":
                        return 4;
                    case "GL_REVALS_BS":
                        return 5;
                    case "GL_REVALS_PL":
                        return 6;
                    case "GL_REVALS_ASS":
                        return 7;
                    case "GL_DISP_PROF":
                        return 8;
                    case "GL_DISP_PROC":
                        return 9;
                    case "APTE_GLCODE":
                        return 10;
                    case "PTE_USE_RATE":
                        return 11;
                    case "DEPN_AMETHOD":
                        return 12;
                    case "DEPN_TMETHOD":
                        return 13;
                    case "DEPN_ARATE":
                        return 14;
                    case "APTE_USE_RATE":
                        return 15;
                    case "DEPN_TRATE":
                        return 16;
                    case "TPTE_USE_RATE":
                        return 17;
                    case "EXPECTED_LIFE":
                        return 18;
                    case "SEND_TO_FLAG":
                        return 19;
                    case "ACTIVE":
                        return 20;
                    case "MAP_CATEGORY":
                        return 21;
                    case "LW_DATE":
                        return 22;
                    case "LW_TIME":
                        return 23;
                    case "LW_USER":
                        return 24;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
