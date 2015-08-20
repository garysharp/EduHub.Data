using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Faculties Data Set
    /// </summary>
    public sealed class KSFDataSet : SetBase<KSF>
    {
        private Lazy<Dictionary<string, KSF>> KSFKEYIndex;

        internal KSFDataSet(EduHubContext Context)
            : base(Context)
        {
            KSFKEYIndex = new Lazy<Dictionary<string, KSF>>(() => this.ToDictionary(e => e.KSFKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSF"; } }

        /// <summary>
        /// Find KSF by KSFKEY key field
        /// </summary>
        /// <param name="Key">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSFKEY value didn't match any KSF entities</exception>
        public KSF FindByKSFKEY(string Key)
        {
            KSF result;
            if (KSFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY key field
        /// </summary>
        /// <param name="Key">KSFKEY value used to find KSF</param>
        /// <param name="Value">Related KSF entity</param>
        /// <returns>True if the KSF entity is found</returns>
        public bool TryFindByKSFKEY(string Key, out KSF Value)
        {
            return KSFKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSF by KSFKEY key field
        /// </summary>
        /// <param name="Key">KSFKEY value used to find KSF</param>
        /// <returns>Related KSF entity, or null if not found</returns>
        public KSF TryFindByKSFKEY(string Key)
        {
            KSF result;
            if (KSFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSF" /> fields for each CSV column header</returns>
        protected override Action<KSF, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSFKEY":
                        mapper[i] = (e, v) => e.KSFKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "COORDINATOR":
                        mapper[i] = (e, v) => e.COORDINATOR = v;
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
