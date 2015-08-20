using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups Data Set
    /// </summary>
    public sealed class KGCDataSet : SetBase<KGC>
    {
        private Lazy<Dictionary<string, KGC>> KGCKEYIndex;

        internal KGCDataSet(EduHubContext Context)
            : base(Context)
        {
            KGCKEYIndex = new Lazy<Dictionary<string, KGC>>(() => this.ToDictionary(e => e.KGCKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGC"; } }

        /// <summary>
        /// Find KGC by KGCKEY key field
        /// </summary>
        /// <param name="Key">KGCKEY value used to find KGC</param>
        /// <returns>Related KGC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGCKEY value didn't match any KGC entities</exception>
        public KGC FindByKGCKEY(string Key)
        {
            KGC result;
            if (KGCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGC by KGCKEY key field
        /// </summary>
        /// <param name="Key">KGCKEY value used to find KGC</param>
        /// <param name="Value">Related KGC entity</param>
        /// <returns>True if the KGC entity is found</returns>
        public bool TryFindByKGCKEY(string Key, out KGC Value)
        {
            return KGCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGC by KGCKEY key field
        /// </summary>
        /// <param name="Key">KGCKEY value used to find KGC</param>
        /// <returns>Related KGC entity, or null if not found</returns>
        public KGC TryFindByKGCKEY(string Key)
        {
            KGC result;
            if (KGCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGC" /> fields for each CSV column header</returns>
        protected override Action<KGC, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "HG_SIZE":
                        mapper[i] = (e, v) => e.HG_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MIN_AC_YR":
                        mapper[i] = (e, v) => e.MIN_AC_YR = v;
                        break;
                    case "MAX_AC_YR":
                        mapper[i] = (e, v) => e.MAX_AC_YR = v;
                        break;
                    case "NEXT_HG":
                        mapper[i] = (e, v) => e.NEXT_HG = v;
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
