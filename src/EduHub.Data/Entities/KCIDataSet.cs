using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religious Instruction Curricula Data Set
    /// </summary>
    public sealed class KCIDataSet : SetBase<KCI>
    {
        private Lazy<Dictionary<string, KCI>> KCIKEYIndex;

        internal KCIDataSet(EduHubContext Context)
            : base(Context)
        {
            KCIKEYIndex = new Lazy<Dictionary<string, KCI>>(() => this.ToDictionary(e => e.KCIKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCI"; } }

        /// <summary>
        /// Find KCI by KCIKEY key field
        /// </summary>
        /// <param name="Key">KCIKEY value used to find KCI</param>
        /// <returns>Related KCI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCIKEY value didn't match any KCI entities</exception>
        public KCI FindByKCIKEY(string Key)
        {
            KCI result;
            if (KCIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCI by KCIKEY key field
        /// </summary>
        /// <param name="Key">KCIKEY value used to find KCI</param>
        /// <param name="Value">Related KCI entity</param>
        /// <returns>True if the KCI entity is found</returns>
        public bool TryFindByKCIKEY(string Key, out KCI Value)
        {
            return KCIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCI by KCIKEY key field
        /// </summary>
        /// <param name="Key">KCIKEY value used to find KCI</param>
        /// <returns>Related KCI entity, or null if not found</returns>
        public KCI TryFindByKCIKEY(string Key)
        {
            KCI result;
            if (KCIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCI" /> fields for each CSV column header</returns>
        protected override Action<KCI, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCIKEY":
                        mapper[i] = (e, v) => e.KCIKEY = v;
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
