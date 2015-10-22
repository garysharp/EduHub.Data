using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Positions Data Set
    /// </summary>
    public sealed partial class KSCDataSet : SetBase<KSC>
    {
        private Lazy<Dictionary<string, KSC>> KSCKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_POS_CODE_AForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_POS_CODE_BForeignIndex;

        internal KSCDataSet(EduHubContext Context)
            : base(Context)
        {
            KSCKEYIndex = new Lazy<Dictionary<string, KSC>>(() => this.ToDictionary(e => e.KSCKEY));

            SF_POS_CODE_AForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.POS_CODE_A != null)
                          .GroupBy(e => e.POS_CODE_A)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_POS_CODE_BForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.POS_CODE_B != null)
                          .GroupBy(e => e.POS_CODE_B)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSC"; } }

        /// <summary>
        /// Find KSC by KSCKEY key field
        /// </summary>
        /// <param name="Key">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSCKEY value didn't match any KSC entities</exception>
        public KSC FindByKSCKEY(string Key)
        {
            KSC result;
            if (KSCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY key field
        /// </summary>
        /// <param name="Key">KSCKEY value used to find KSC</param>
        /// <param name="Value">Related KSC entity</param>
        /// <returns>True if the KSC entity is found</returns>
        public bool TryFindByKSCKEY(string Key, out KSC Value)
        {
            return KSCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSC by KSCKEY key field
        /// </summary>
        /// <param name="Key">KSCKEY value used to find KSC</param>
        /// <returns>Related KSC entity, or null if not found</returns>
        public KSC TryFindByKSCKEY(string Key)
        {
            KSC result;
            if (KSCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.POS_CODE_A]-&gt;[KSC.KSCKEY]
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByPOS_CODE_A(string KSCKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_POS_CODE_AForeignIndex.Value.TryGetValue(KSCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.POS_CODE_A]-&gt;[KSC.KSCKEY]
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByPOS_CODE_A(string KSCKEY, out IReadOnlyList<SF> Value)
        {
            return SF_POS_CODE_AForeignIndex.Value.TryGetValue(KSCKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.POS_CODE_B]-&gt;[KSC.KSCKEY]
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByPOS_CODE_B(string KSCKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_POS_CODE_BForeignIndex.Value.TryGetValue(KSCKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.POS_CODE_B]-&gt;[KSC.KSCKEY]
        /// </summary>
        /// <param name="KSCKEY">KSCKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByPOS_CODE_B(string KSCKEY, out IReadOnlyList<SF> Value)
        {
            return SF_POS_CODE_BForeignIndex.Value.TryGetValue(KSCKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSC" /> fields for each CSV column header</returns>
        protected override Action<KSC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSCKEY":
                        mapper[i] = (e, v) => e.KSCKEY = v;
                        break;
                    case "SF_POSITION":
                        mapper[i] = (e, v) => e.SF_POSITION = v;
                        break;
                    case "ALLOTMENT":
                        mapper[i] = (e, v) => e.ALLOTMENT = v == null ? (short?)null : short.Parse(v);
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
