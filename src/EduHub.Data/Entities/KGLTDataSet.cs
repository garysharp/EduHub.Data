using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Account Types Data Set
    /// </summary>
    public sealed class KGLTDataSet : SetBase<KGLT>
    {
        private Lazy<Dictionary<string, KGLT>> GL_TYPEIndex;

        internal KGLTDataSet(EduHubContext Context)
            : base(Context)
        {
            GL_TYPEIndex = new Lazy<Dictionary<string, KGLT>>(() => this.ToDictionary(e => e.GL_TYPE));
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLT" /> fields for each CSV column header</returns>
        protected override Action<KGLT, string>[] BuildMapper(List<string> Headers)
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
