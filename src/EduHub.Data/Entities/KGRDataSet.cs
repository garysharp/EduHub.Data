using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religions Data Set
    /// </summary>
    public sealed partial class KGRDataSet : SetBase<KGR>
    {
        private Lazy<Dictionary<string, KGR>> RELIGIONIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_RELIGIONForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_RELIGIONForeignIndex;

        internal KGRDataSet(EduHubContext Context)
            : base(Context)
        {
            RELIGIONIndex = new Lazy<Dictionary<string, KGR>>(() => this.ToDictionary(e => e.RELIGION));

            SF_RELIGIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.RELIGION != null)
                          .GroupBy(e => e.RELIGION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            ST_RELIGIONForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.RELIGION != null)
                          .GroupBy(e => e.RELIGION)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

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
        /// <returns>True if the KGR entity is found</returns>
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

        /// <summary>
        /// Find all SF (Staff) entities by [SF.RELIGION]-&gt;[KGR.RELIGION]
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByRELIGION(string RELIGION)
        {
            IReadOnlyList<SF> result;
            if (SF_RELIGIONForeignIndex.Value.TryGetValue(RELIGION, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.RELIGION]-&gt;[KGR.RELIGION]
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByRELIGION(string RELIGION, out IReadOnlyList<SF> Value)
        {
            return SF_RELIGIONForeignIndex.Value.TryGetValue(RELIGION, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.RELIGION]-&gt;[KGR.RELIGION]
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByRELIGION(string RELIGION)
        {
            IReadOnlyList<ST> result;
            if (ST_RELIGIONForeignIndex.Value.TryGetValue(RELIGION, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.RELIGION]-&gt;[KGR.RELIGION]
        /// </summary>
        /// <param name="RELIGION">RELIGION value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByRELIGION(string RELIGION, out IReadOnlyList<ST> Value)
        {
            return ST_RELIGIONForeignIndex.Value.TryGetValue(RELIGION, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGR" /> fields for each CSV column header</returns>
        protected override Action<KGR, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
