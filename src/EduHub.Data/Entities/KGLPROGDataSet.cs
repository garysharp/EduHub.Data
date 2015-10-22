using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Programs Data Set
    /// </summary>
    public sealed partial class KGLPROGDataSet : SetBase<KGLPROG>
    {
        private Lazy<Dictionary<string, KGLPROG>> GLPROGRAMIndex;

        private Lazy<Dictionary<string, IReadOnlyList<GLF>>> GLF_GLPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>> GLFPREV_GLPROGRAMForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<KGLSUB>>> KGLSUB_GL_PROGRAMForeignIndex;

        internal KGLPROGDataSet(EduHubContext Context)
            : base(Context)
        {
            GLPROGRAMIndex = new Lazy<Dictionary<string, KGLPROG>>(() => this.ToDictionary(e => e.GLPROGRAM));

            GLF_GLPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLF>>>(() =>
                    Context.GLF
                          .Where(e => e.GLPROGRAM != null)
                          .GroupBy(e => e.GLPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLF>)g.ToList()
                          .AsReadOnly()));

            GLFPREV_GLPROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<GLFPREV>>>(() =>
                    Context.GLFPREV
                          .Where(e => e.GLPROGRAM != null)
                          .GroupBy(e => e.GLPROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<GLFPREV>)g.ToList()
                          .AsReadOnly()));

            KGLSUB_GL_PROGRAMForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<KGLSUB>>>(() =>
                    Context.KGLSUB
                          .Where(e => e.GL_PROGRAM != null)
                          .GroupBy(e => e.GL_PROGRAM)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<KGLSUB>)g.ToList()
                          .AsReadOnly()));

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
        /// Find all GLF (General Ledger Transactions) entities by [GLF.GLPROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLF entities</param>
        /// <returns>A list of related GLF entities</returns>
        public IReadOnlyList<GLF> FindGLFByGLPROGRAM(string GLPROGRAM)
        {
            IReadOnlyList<GLF> result;
            if (GLF_GLPROGRAMForeignIndex.Value.TryGetValue(GLPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<GLF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLF entities by [GLF.GLPROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLF entities</param>
        /// <param name="Value">A list of related GLF entities</param>
        /// <returns>True if any GLF entities are found</returns>
        public bool TryFindGLFByGLPROGRAM(string GLPROGRAM, out IReadOnlyList<GLF> Value)
        {
            return GLF_GLPROGRAMForeignIndex.Value.TryGetValue(GLPROGRAM, out Value);
        }

        /// <summary>
        /// Find all GLFPREV (Last Years GL Financial Trans) entities by [GLFPREV.GLPROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLFPREV entities</param>
        /// <returns>A list of related GLFPREV entities</returns>
        public IReadOnlyList<GLFPREV> FindGLFPREVByGLPROGRAM(string GLPROGRAM)
        {
            IReadOnlyList<GLFPREV> result;
            if (GLFPREV_GLPROGRAMForeignIndex.Value.TryGetValue(GLPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<GLFPREV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all GLFPREV entities by [GLFPREV.GLPROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find GLFPREV entities</param>
        /// <param name="Value">A list of related GLFPREV entities</param>
        /// <returns>True if any GLFPREV entities are found</returns>
        public bool TryFindGLFPREVByGLPROGRAM(string GLPROGRAM, out IReadOnlyList<GLFPREV> Value)
        {
            return GLFPREV_GLPROGRAMForeignIndex.Value.TryGetValue(GLPROGRAM, out Value);
        }

        /// <summary>
        /// Find all KGLSUB (General Ledger Sub Programs) entities by [KGLSUB.GL_PROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLSUB entities</param>
        /// <returns>A list of related KGLSUB entities</returns>
        public IReadOnlyList<KGLSUB> FindKGLSUBByGL_PROGRAM(string GLPROGRAM)
        {
            IReadOnlyList<KGLSUB> result;
            if (KGLSUB_GL_PROGRAMForeignIndex.Value.TryGetValue(GLPROGRAM, out result))
            {
                return result;
            }
            else
            {
                return new List<KGLSUB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all KGLSUB entities by [KGLSUB.GL_PROGRAM]-&gt;[KGLPROG.GLPROGRAM]
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLSUB entities</param>
        /// <param name="Value">A list of related KGLSUB entities</param>
        /// <returns>True if any KGLSUB entities are found</returns>
        public bool TryFindKGLSUBByGL_PROGRAM(string GLPROGRAM, out IReadOnlyList<KGLSUB> Value)
        {
            return KGLSUB_GL_PROGRAMForeignIndex.Value.TryGetValue(GLPROGRAM, out Value);
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
    }
}
