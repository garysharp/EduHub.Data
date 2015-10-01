using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Medical Conditions Data Set
    /// </summary>
    public sealed class KCMDataSet : SetBase<KCM>
    {
        private Lazy<Dictionary<string, KCM>> KCMKEYIndex;

        internal KCMDataSet(EduHubContext Context)
            : base(Context)
        {
            KCMKEYIndex = new Lazy<Dictionary<string, KCM>>(() => this.ToDictionary(e => e.KCMKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCM"; } }

        /// <summary>
        /// Find KCM by KCMKEY key field
        /// </summary>
        /// <param name="Key">KCMKEY value used to find KCM</param>
        /// <returns>Related KCM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCMKEY value didn't match any KCM entities</exception>
        public KCM FindByKCMKEY(string Key)
        {
            KCM result;
            if (KCMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCM by KCMKEY key field
        /// </summary>
        /// <param name="Key">KCMKEY value used to find KCM</param>
        /// <param name="Value">Related KCM entity</param>
        /// <returns>True if the KCM entity is found</returns>
        public bool TryFindByKCMKEY(string Key, out KCM Value)
        {
            return KCMKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCM by KCMKEY key field
        /// </summary>
        /// <param name="Key">KCMKEY value used to find KCM</param>
        /// <returns>Related KCM entity, or null if not found</returns>
        public KCM TryFindByKCMKEY(string Key)
        {
            KCM result;
            if (KCMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCM" /> fields for each CSV column header</returns>
        protected override Action<KCM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCMKEY":
                        mapper[i] = (e, v) => e.KCMKEY = v;
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
