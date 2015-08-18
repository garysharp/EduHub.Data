using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religions Data Set
    /// </summary>
    public sealed class KGRDataSet : SetBase<KGR>
    {
        private Lazy<Dictionary<string, KGR>> RELIGIONIndex;

        internal KGRDataSet(EduHubContext Context)
            : base(Context)
        {
            RELIGIONIndex = new Lazy<Dictionary<string, KGR>>(() => this.ToDictionary(e => e.RELIGION));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGR"; } }

        /// <summary>
        /// Find KGR by RELIGION key field
        /// </summary>
        /// <param name="Key">RELIGION value used to find KGR</param>
        /// <returns>Related KGR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">RELIGION value didn't match any KGR entities</exception>
        public KGR FindByRELIGION(string Key)
        {
            KGR result;
            if (RELIGIONIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGR by RELIGION key field
        /// </summary>
        /// <param name="Key">RELIGION value used to find KGR</param>
        /// <param name="Value">Related KGR entity</param>
        /// <returns>True if the KGR Entity is found</returns>
        public bool TryFindByRELIGION(string Key, out KGR Value)
        {
            return RELIGIONIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGR by RELIGION key field
        /// </summary>
        /// <param name="Key">RELIGION value used to find KGR</param>
        /// <returns>Related KGR entity, or null if not found</returns>
        public KGR TryFindByRELIGION(string Key)
        {
            KGR result;
            if (RELIGIONIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KGR, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RELIGION":
                        mapper[i] = (e, v) => e.RELIGION = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
