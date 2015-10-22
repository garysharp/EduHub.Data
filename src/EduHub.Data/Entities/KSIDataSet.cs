using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Institutions Data Set
    /// </summary>
    public sealed partial class KSIDataSet : SetBase<KSI>
    {
        private Lazy<Dictionary<string, KSI>> KSIKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SFQA>>> SFQA_INSTITUTIONForeignIndex;

        internal KSIDataSet(EduHubContext Context)
            : base(Context)
        {
            KSIKEYIndex = new Lazy<Dictionary<string, KSI>>(() => this.ToDictionary(e => e.KSIKEY));

            SFQA_INSTITUTIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SFQA>>>(() =>
                    Context.SFQA
                          .Where(e => e.INSTITUTION != null)
                          .GroupBy(e => e.INSTITUTION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SFQA>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSI"; } }

        /// <summary>
        /// Find KSI by KSIKEY key field
        /// </summary>
        /// <param name="Key">KSIKEY value used to find KSI</param>
        /// <returns>Related KSI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSIKEY value didn't match any KSI entities</exception>
        public KSI FindByKSIKEY(string Key)
        {
            KSI result;
            if (KSIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSI by KSIKEY key field
        /// </summary>
        /// <param name="Key">KSIKEY value used to find KSI</param>
        /// <param name="Value">Related KSI entity</param>
        /// <returns>True if the KSI entity is found</returns>
        public bool TryFindByKSIKEY(string Key, out KSI Value)
        {
            return KSIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSI by KSIKEY key field
        /// </summary>
        /// <param name="Key">KSIKEY value used to find KSI</param>
        /// <returns>Related KSI entity, or null if not found</returns>
        public KSI TryFindByKSIKEY(string Key)
        {
            KSI result;
            if (KSIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SFQA (Staff Qualifications) entities by [SFQA.INSTITUTION]-&gt;[KSI.KSIKEY]
        /// </summary>
        /// <param name="KSIKEY">KSIKEY value used to find SFQA entities</param>
        /// <returns>A list of related SFQA entities</returns>
        public IReadOnlyList<SFQA> FindSFQAByINSTITUTION(string KSIKEY)
        {
            IReadOnlyList<SFQA> result;
            if (SFQA_INSTITUTIONForeignIndex.Value.TryGetValue(KSIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SFQA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SFQA entities by [SFQA.INSTITUTION]-&gt;[KSI.KSIKEY]
        /// </summary>
        /// <param name="KSIKEY">KSIKEY value used to find SFQA entities</param>
        /// <param name="Value">A list of related SFQA entities</param>
        /// <returns>True if any SFQA entities are found</returns>
        public bool TryFindSFQAByINSTITUTION(string KSIKEY, out IReadOnlyList<SFQA> Value)
        {
            return SFQA_INSTITUTIONForeignIndex.Value.TryGetValue(KSIKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSI" /> fields for each CSV column header</returns>
        protected override Action<KSI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSIKEY":
                        mapper[i] = (e, v) => e.KSIKEY = v;
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
