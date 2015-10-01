using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Languages Data Set
    /// </summary>
    public sealed class KGLDataSet : SetBase<KGL>
    {
        private Lazy<Dictionary<string, KGL>> KGLKEYIndex;

        internal KGLDataSet(EduHubContext Context)
            : base(Context)
        {
            KGLKEYIndex = new Lazy<Dictionary<string, KGL>>(() => this.ToDictionary(e => e.KGLKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGL"; } }

        /// <summary>
        /// Find KGL by KGLKEY key field
        /// </summary>
        /// <param name="Key">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGLKEY value didn't match any KGL entities</exception>
        public KGL FindByKGLKEY(string Key)
        {
            KGL result;
            if (KGLKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY key field
        /// </summary>
        /// <param name="Key">KGLKEY value used to find KGL</param>
        /// <param name="Value">Related KGL entity</param>
        /// <returns>True if the KGL entity is found</returns>
        public bool TryFindByKGLKEY(string Key, out KGL Value)
        {
            return KGLKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGL by KGLKEY key field
        /// </summary>
        /// <param name="Key">KGLKEY value used to find KGL</param>
        /// <returns>Related KGL entity, or null if not found</returns>
        public KGL TryFindByKGLKEY(string Key)
        {
            KGL result;
            if (KGLKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGL" /> fields for each CSV column header</returns>
        protected override Action<KGL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGLKEY":
                        mapper[i] = (e, v) => e.KGLKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "NOTICES_AVAILABLE":
                        mapper[i] = (e, v) => e.NOTICES_AVAILABLE = v;
                        break;
                    case "ASCL":
                        mapper[i] = (e, v) => e.ASCL = v;
                        break;
                    case "CASESKEY":
                        mapper[i] = (e, v) => e.CASESKEY = v;
                        break;
                    case "CASES_CASES21_CONV":
                        mapper[i] = (e, v) => e.CASES_CASES21_CONV = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
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
