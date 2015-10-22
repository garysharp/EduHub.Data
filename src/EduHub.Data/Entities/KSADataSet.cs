using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Areas of Teaching Data Set
    /// </summary>
    public sealed partial class KSADataSet : SetBase<KSA>
    {
        private Lazy<Dictionary<string, KSA>> KSAKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_MAJORAForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_MAJORBForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_MAJORCForeignIndex;

        internal KSADataSet(EduHubContext Context)
            : base(Context)
        {
            KSAKEYIndex = new Lazy<Dictionary<string, KSA>>(() => this.ToDictionary(e => e.KSAKEY));

            SF_MAJORAForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.MAJORA != null)
                          .GroupBy(e => e.MAJORA)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_MAJORBForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.MAJORB != null)
                          .GroupBy(e => e.MAJORB)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SF_MAJORCForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.MAJORC != null)
                          .GroupBy(e => e.MAJORC)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSA"; } }

        /// <summary>
        /// Find KSA by KSAKEY key field
        /// </summary>
        /// <param name="Key">KSAKEY value used to find KSA</param>
        /// <returns>Related KSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSAKEY value didn't match any KSA entities</exception>
        public KSA FindByKSAKEY(string Key)
        {
            KSA result;
            if (KSAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSA by KSAKEY key field
        /// </summary>
        /// <param name="Key">KSAKEY value used to find KSA</param>
        /// <param name="Value">Related KSA entity</param>
        /// <returns>True if the KSA entity is found</returns>
        public bool TryFindByKSAKEY(string Key, out KSA Value)
        {
            return KSAKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSA by KSAKEY key field
        /// </summary>
        /// <param name="Key">KSAKEY value used to find KSA</param>
        /// <returns>Related KSA entity, or null if not found</returns>
        public KSA TryFindByKSAKEY(string Key)
        {
            KSA result;
            if (KSAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.MAJORA]-&gt;[KSA.KSAKEY]
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByMAJORA(string KSAKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_MAJORAForeignIndex.Value.TryGetValue(KSAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.MAJORA]-&gt;[KSA.KSAKEY]
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByMAJORA(string KSAKEY, out IReadOnlyList<SF> Value)
        {
            return SF_MAJORAForeignIndex.Value.TryGetValue(KSAKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.MAJORB]-&gt;[KSA.KSAKEY]
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByMAJORB(string KSAKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_MAJORBForeignIndex.Value.TryGetValue(KSAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.MAJORB]-&gt;[KSA.KSAKEY]
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByMAJORB(string KSAKEY, out IReadOnlyList<SF> Value)
        {
            return SF_MAJORBForeignIndex.Value.TryGetValue(KSAKEY, out Value);
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.MAJORC]-&gt;[KSA.KSAKEY]
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByMAJORC(string KSAKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_MAJORCForeignIndex.Value.TryGetValue(KSAKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.MAJORC]-&gt;[KSA.KSAKEY]
        /// </summary>
        /// <param name="KSAKEY">KSAKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByMAJORC(string KSAKEY, out IReadOnlyList<SF> Value)
        {
            return SF_MAJORCForeignIndex.Value.TryGetValue(KSAKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KSA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KSA" /> fields for each CSV column header</returns>
        protected override Action<KSA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KSA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSAKEY":
                        mapper[i] = (e, v) => e.KSAKEY = v;
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
