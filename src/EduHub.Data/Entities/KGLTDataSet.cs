using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Account Types Data Set
    /// </summary>
    public sealed partial class KGLTDataSet : SetBase<KGLT>
    {
        private Lazy<Dictionary<string, KGLT>> GL_TYPEIndex;

        private Lazy<Dictionary<string, IReadOnlyList<GL>>> GL_GL_TYPEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLPREV>>> GLPREV_GL_TYPEForeignIndex;

        internal KGLTDataSet(EduHubContext Context)
            : base(Context)
        {
            GL_TYPEIndex = new Lazy<Dictionary<string, KGLT>>(() => this.ToDictionary(e => e.GL_TYPE));

            GL_GL_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GL>>>(() =>
                    Context.GL
                          .Where(e => e.GL_TYPE != null)
                          .GroupBy(e => e.GL_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GL>)g.ToList()
                          .AsReadOnly()));

            GLPREV_GL_TYPEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLPREV>>>(() =>
                    Context.GLPREV
                          .Where(e => e.GL_TYPE != null)
                          .GroupBy(e => e.GL_TYPE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLPREV>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLT"; } }

        /// <summary>
        /// Find KGLT by GL_TYPE key field
        /// </summary>
        /// <param name="Key">GL_TYPE value used to find KGLT</param>
        /// <returns>Related KGLT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">GL_TYPE value didn't match any KGLT entities</exception>
        public KGLT FindByGL_TYPE(string Key)
        {
            KGLT result;
            if (GL_TYPEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGLT by GL_TYPE key field
        /// </summary>
        /// <param name="Key">GL_TYPE value used to find KGLT</param>
        /// <param name="Value">Related KGLT entity</param>
        /// <returns>True if the KGLT entity is found</returns>
        public bool TryFindByGL_TYPE(string Key, out KGLT Value)
        {
            return GL_TYPEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGLT by GL_TYPE key field
        /// </summary>
        /// <param name="Key">GL_TYPE value used to find KGLT</param>
        /// <returns>Related KGLT entity, or null if not found</returns>
        public KGLT TryFindByGL_TYPE(string Key)
        {
            KGLT result;
            if (GL_TYPEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all GL (General Ledger) entities by [GL.GL_TYPE]-&gt;[KGLT.GL_TYPE]
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GL entities</param>
        /// <returns>A list of related GL entities</returns>
        public IReadOnlyList<GL> FindGLByGL_TYPE(string GL_TYPE)
        {
            IReadOnlyList<GL> result;
            if (GL_GL_TYPEForeignIndex.Value.TryGetValue(GL_TYPE, out result))
            {
                return result;
            }
            else
            {
                return new List<GL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GL entities by [GL.GL_TYPE]-&gt;[KGLT.GL_TYPE]
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GL entities</param>
        /// <param name="Value">A list of related GL entities</param>
        /// <returns>True if any GL entities are found</returns>
        public bool TryFindGLByGL_TYPE(string GL_TYPE, out IReadOnlyList<GL> Value)
        {
            return GL_GL_TYPEForeignIndex.Value.TryGetValue(GL_TYPE, out Value);
        }

        /// <summary>
        /// Find all GLPREV (Last Years General Ledger) entities by [GLPREV.GL_TYPE]-&gt;[KGLT.GL_TYPE]
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GLPREV entities</param>
        /// <returns>A list of related GLPREV entities</returns>
        public IReadOnlyList<GLPREV> FindGLPREVByGL_TYPE(string GL_TYPE)
        {
            IReadOnlyList<GLPREV> result;
            if (GLPREV_GL_TYPEForeignIndex.Value.TryGetValue(GL_TYPE, out result))
            {
                return result;
            }
            else
            {
                return new List<GLPREV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLPREV entities by [GLPREV.GL_TYPE]-&gt;[KGLT.GL_TYPE]
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GLPREV entities</param>
        /// <param name="Value">A list of related GLPREV entities</param>
        /// <returns>True if any GLPREV entities are found</returns>
        public bool TryFindGLPREVByGL_TYPE(string GL_TYPE, out IReadOnlyList<GLPREV> Value)
        {
            return GLPREV_GL_TYPEForeignIndex.Value.TryGetValue(GL_TYPE, out Value);
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
    }
}
