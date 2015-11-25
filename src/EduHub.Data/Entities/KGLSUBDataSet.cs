using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Sub Programs Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLSUBDataSet : SetBase<KGLSUB>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLSUB"; } }

        internal KGLSUBDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GL_PROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<KGLSUB>>>(() => this.ToGroupedNullDictionary(i => i.GL_PROGRAM));
            Index_SUBPROGRAM = new Lazy<Dictionary<string, KGLSUB>>(() => this.ToDictionary(i => i.SUBPROGRAM));
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

        /// <summary>
        /// Merges <see cref="KGLSUB" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGLSUB" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGLSUB" /> items to added or update the base <see cref="KGLSUB" /> items</param>
        /// <returns>A merged list of <see cref="KGLSUB" /> items</returns>
        protected override List<KGLSUB> ApplyDeltaItems(List<KGLSUB> Items, List<KGLSUB> DeltaItems)
        {
            Dictionary<string, int> Index_SUBPROGRAM = Items.ToIndexDictionary(i => i.SUBPROGRAM);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGLSUB deltaItem in DeltaItems)
            {
                int index;

                if (Index_SUBPROGRAM.TryGetValue(deltaItem.SUBPROGRAM, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SUBPROGRAM)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<KGLSUB>>> Index_GL_PROGRAM;
        private Lazy<Dictionary<string, KGLSUB>> Index_SUBPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <returns>List of related KGLSUB entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGLSUB> FindByGL_PROGRAM(string GL_PROGRAM)
        {
            return Index_GL_PROGRAM.Value[GL_PROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <param name="Value">List of related KGLSUB entities</param>
        /// <returns>True if the list of related KGLSUB entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_PROGRAM(string GL_PROGRAM, out IReadOnlyList<KGLSUB> Value)
        {
            return Index_GL_PROGRAM.Value.TryGetValue(GL_PROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLSUB by GL_PROGRAM field
        /// </summary>
        /// <param name="GL_PROGRAM">GL_PROGRAM value used to find KGLSUB</param>
        /// <returns>List of related KGLSUB entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<KGLSUB> TryFindByGL_PROGRAM(string GL_PROGRAM)
        {
            IReadOnlyList<KGLSUB> value;
            if (Index_GL_PROGRAM.Value.TryGetValue(GL_PROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLSUB FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <param name="Value">Related KGLSUB entity</param>
        /// <returns>True if the related KGLSUB entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out KGLSUB Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLSUB by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find KGLSUB</param>
        /// <returns>Related KGLSUB entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLSUB TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            KGLSUB value;
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
