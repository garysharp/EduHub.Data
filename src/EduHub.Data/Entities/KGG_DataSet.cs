using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Categories Data Set
    /// </summary>
    public sealed class KGG_DataSet : SetBase<KGG_Entity>
    {
        private Lazy<Dictionary<string, KGG_Entity>> KGGKEY_Index;

        internal KGG_DataSet(EduHubContext Context)
            : base(Context)
        {
            KGGKEY_Index = new Lazy<Dictionary<string, KGG_Entity>>(() => this.ToDictionary(e => e.KGGKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KGG"; } }

        /// <summary>
        /// Find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGGKEY value didn't match any KGG entities</exception>
        public KGG_Entity FindByKGGKEY(string Key)
        {
            KGG_Entity result;
            if (KGGKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <param name="Value">Related KGG entity</param>
        /// <returns>True if the KGG Entity is found</returns>
        public bool TryFindByKGGKEY(string Key, out KGG_Entity Value)
        {
            return KGGKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGG by KGGKEY key field
        /// </summary>
        /// <param name="Key">KGGKEY value used to find KGG</param>
        /// <returns>Related KGG entity, or null if not found</returns>
        public KGG_Entity TryFindByKGGKEY(string Key)
        {
            KGG_Entity result;
            if (KGGKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KGG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGGKEY":
                        mapper[i] = (e, v) => e.KGGKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "EDFLAG_ORDER":
                        mapper[i] = (e, v) => e.EDFLAG_ORDER = v;
                        break;
                    case "OPEN_CLOSED":
                        mapper[i] = (e, v) => e.OPEN_CLOSED = v;
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
