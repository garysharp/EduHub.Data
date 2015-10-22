using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Religious Instruction Curricula Data Set
    /// </summary>
    public sealed partial class KCIDataSet : SetBase<KCI>
    {
        private Lazy<Dictionary<string, KCI>> KCIKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SCI>>> SCI_REL_INSTRForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_REL_INSTRForeignIndex;

        internal KCIDataSet(EduHubContext Context)
            : base(Context)
        {
            KCIKEYIndex = new Lazy<Dictionary<string, KCI>>(() => this.ToDictionary(e => e.KCIKEY));

            SCI_REL_INSTRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCI>>>(() =>
                    Context.SCI
                          .Where(e => e.REL_INSTR != null)
                          .GroupBy(e => e.REL_INSTR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCI>)g.ToList()
                          .AsReadOnly()));

            ST_REL_INSTRForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.REL_INSTR != null)
                          .GroupBy(e => e.REL_INSTR)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

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
        /// Find all SCI (School Information) entities by [SCI.REL_INSTR]-&gt;[KCI.KCIKEY]
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find SCI entities</param>
        /// <returns>A list of related SCI entities</returns>
        public IReadOnlyList<SCI> FindSCIByREL_INSTR(string KCIKEY)
        {
            IReadOnlyList<SCI> result;
            if (SCI_REL_INSTRForeignIndex.Value.TryGetValue(KCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCI>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCI entities by [SCI.REL_INSTR]-&gt;[KCI.KCIKEY]
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find SCI entities</param>
        /// <param name="Value">A list of related SCI entities</param>
        /// <returns>True if any SCI entities are found</returns>
        public bool TryFindSCIByREL_INSTR(string KCIKEY, out IReadOnlyList<SCI> Value)
        {
            return SCI_REL_INSTRForeignIndex.Value.TryGetValue(KCIKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.REL_INSTR]-&gt;[KCI.KCIKEY]
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByREL_INSTR(string KCIKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_REL_INSTRForeignIndex.Value.TryGetValue(KCIKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.REL_INSTR]-&gt;[KCI.KCIKEY]
        /// </summary>
        /// <param name="KCIKEY">KCIKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByREL_INSTR(string KCIKEY, out IReadOnlyList<ST> Value)
        {
            return ST_REL_INSTRForeignIndex.Value.TryGetValue(KCIKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCI" /> fields for each CSV column header</returns>
        protected override Action<KCI, string>[] BuildMapper(IReadOnlyList<string> Headers)
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
