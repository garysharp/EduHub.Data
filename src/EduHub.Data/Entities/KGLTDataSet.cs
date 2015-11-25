using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Account Types Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLTDataSet : SetBase<KGLT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLT"; } }

        internal KGLTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GL_TYPE = new Lazy<Dictionary<string, KGLT>>(() => this.ToDictionary(i => i.GL_TYPE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLT" /> fields for each CSV column header</returns>
        protected override Action<KGLT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GL_TYPE":
                        mapper[i] = (e, v) => e.GL_TYPE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
        /// Merges <see cref="KGLT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KGLT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KGLT" /> items to added or update the base <see cref="KGLT" /> items</param>
        /// <returns>A merged list of <see cref="KGLT" /> items</returns>
        protected override List<KGLT> ApplyDeltaItems(List<KGLT> Items, List<KGLT> DeltaItems)
        {
            Dictionary<string, int> Index_GL_TYPE = Items.ToIndexDictionary(i => i.GL_TYPE);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KGLT deltaItem in DeltaItems)
            {
                int index;

                if (Index_GL_TYPE.TryGetValue(deltaItem.GL_TYPE, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.GL_TYPE)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KGLT>> Index_GL_TYPE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLT by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find KGLT</param>
        /// <returns>Related KGLT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLT FindByGL_TYPE(string GL_TYPE)
        {
            return Index_GL_TYPE.Value[GL_TYPE];
        }

        /// <summary>
        /// Attempt to find KGLT by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find KGLT</param>
        /// <param name="Value">Related KGLT entity</param>
        /// <returns>True if the related KGLT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_TYPE(string GL_TYPE, out KGLT Value)
        {
            return Index_GL_TYPE.Value.TryGetValue(GL_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find KGLT by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find KGLT</param>
        /// <returns>Related KGLT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLT TryFindByGL_TYPE(string GL_TYPE)
        {
            KGLT value;
            if (Index_GL_TYPE.Value.TryGetValue(GL_TYPE, out value))
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
