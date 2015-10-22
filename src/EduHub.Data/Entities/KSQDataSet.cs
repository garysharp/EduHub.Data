using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Available Qualifications Data Set
    /// </summary>
    public sealed partial class KSQDataSet : SetBase<KSQ>
    {
        private Lazy<Dictionary<string, KSQ>> KSQKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SFQA>>> SFQA_QUALIFICATIONForeignIndex;

        internal KSQDataSet(EduHubContext Context)
            : base(Context)
        {
            KSQKEYIndex = new Lazy<Dictionary<string, KSQ>>(() => this.ToDictionary(e => e.KSQKEY));

            SFQA_QUALIFICATIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SFQA>>>(() =>
                    Context.SFQA
                          .Where(e => e.QUALIFICATION != null)
                          .GroupBy(e => e.QUALIFICATION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SFQA>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSQ"; } }

        /// <summary>
        /// Find KSQ by KSQKEY key field
        /// </summary>
        /// <param name="Key">KSQKEY value used to find KSQ</param>
        /// <returns>Related KSQ entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSQKEY value didn't match any KSQ entities</exception>
        public KSQ FindByKSQKEY(string Key)
        {
            KSQ result;
            if (KSQKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSQ by KSQKEY key field
        /// </summary>
        /// <param name="Key">KSQKEY value used to find KSQ</param>
        /// <param name="Value">Related KSQ entity</param>
        /// <returns>True if the KSQ entity is found</returns>
        public bool TryFindByKSQKEY(string Key, out KSQ Value)
        {
            return KSQKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSQ by KSQKEY key field
        /// </summary>
        /// <param name="Key">KSQKEY value used to find KSQ</param>
        /// <returns>Related KSQ entity, or null if not found</returns>
        public KSQ TryFindByKSQKEY(string Key)
        {
            KSQ result;
            if (KSQKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SFQA (Staff Qualifications) entities by [SFQA.QUALIFICATION]-&gt;[KSQ.KSQKEY]
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find SFQA entities</param>
        /// <returns>A list of related SFQA entities</returns>
        public IReadOnlyList<SFQA> FindSFQAByQUALIFICATION(string KSQKEY)
        {
            IReadOnlyList<SFQA> result;
            if (SFQA_QUALIFICATIONForeignIndex.Value.TryGetValue(KSQKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SFQA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SFQA entities by [SFQA.QUALIFICATION]-&gt;[KSQ.KSQKEY]
        /// </summary>
        /// <param name="KSQKEY">KSQKEY value used to find SFQA entities</param>
        /// <param name="Value">A list of related SFQA entities</param>
        /// <returns>True if any SFQA entities are found</returns>
        public bool TryFindSFQAByQUALIFICATION(string KSQKEY, out IReadOnlyList<SFQA> Value)
        {
            return SFQA_QUALIFICATIONForeignIndex.Value.TryGetValue(KSQKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSQ" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSQ" /> fields for each CSV column header</returns>
        protected override Action<KSQ, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSQ, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSQKEY":
                        mapper[i] = (e, v) => e.KSQKEY = v;
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
