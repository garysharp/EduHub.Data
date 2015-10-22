using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Houses Data Set
    /// </summary>
    public sealed partial class KGHDataSet : SetBase<KGH>
    {
        private Lazy<Dictionary<string, KGH>> KGHKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SF>>> SF_HOUSEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SG>>> SG_HOUSEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<ST>>> ST_HOUSEForeignIndex;

        internal KGHDataSet(EduHubContext Context)
            : base(Context)
        {
            KGHKEYIndex = new Lazy<Dictionary<string, KGH>>(() => this.ToDictionary(e => e.KGHKEY));

            SF_HOUSEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SF>>>(() =>
                    Context.SF
                          .Where(e => e.HOUSE != null)
                          .GroupBy(e => e.HOUSE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SF>)g.ToList()
                          .AsReadOnly()));

            SG_HOUSEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SG>>>(() =>
                    Context.SG
                          .Where(e => e.HOUSE != null)
                          .GroupBy(e => e.HOUSE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SG>)g.ToList()
                          .AsReadOnly()));

            ST_HOUSEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.HOUSE != null)
                          .GroupBy(e => e.HOUSE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGH"; } }

        /// <summary>
        /// Find KGH by KGHKEY key field
        /// </summary>
        /// <param name="Key">KGHKEY value used to find KGH</param>
        /// <returns>Related KGH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGHKEY value didn't match any KGH entities</exception>
        public KGH FindByKGHKEY(string Key)
        {
            KGH result;
            if (KGHKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGH by KGHKEY key field
        /// </summary>
        /// <param name="Key">KGHKEY value used to find KGH</param>
        /// <param name="Value">Related KGH entity</param>
        /// <returns>True if the KGH entity is found</returns>
        public bool TryFindByKGHKEY(string Key, out KGH Value)
        {
            return KGHKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGH by KGHKEY key field
        /// </summary>
        /// <param name="Key">KGHKEY value used to find KGH</param>
        /// <returns>Related KGH entity, or null if not found</returns>
        public KGH TryFindByKGHKEY(string Key)
        {
            KGH result;
            if (KGHKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SF (Staff) entities by [SF.HOUSE]-&gt;[KGH.KGHKEY]
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find SF entities</param>
        /// <returns>A list of related SF entities</returns>
        public IReadOnlyList<SF> FindSFByHOUSE(string KGHKEY)
        {
            IReadOnlyList<SF> result;
            if (SF_HOUSEForeignIndex.Value.TryGetValue(KGHKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SF>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SF entities by [SF.HOUSE]-&gt;[KGH.KGHKEY]
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find SF entities</param>
        /// <param name="Value">A list of related SF entities</param>
        /// <returns>True if any SF entities are found</returns>
        public bool TryFindSFByHOUSE(string KGHKEY, out IReadOnlyList<SF> Value)
        {
            return SF_HOUSEForeignIndex.Value.TryGetValue(KGHKEY, out Value);
        }

        /// <summary>
        /// Find all SG (Student Groupings) entities by [SG.HOUSE]-&gt;[KGH.KGHKEY]
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find SG entities</param>
        /// <returns>A list of related SG entities</returns>
        public IReadOnlyList<SG> FindSGByHOUSE(string KGHKEY)
        {
            IReadOnlyList<SG> result;
            if (SG_HOUSEForeignIndex.Value.TryGetValue(KGHKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SG entities by [SG.HOUSE]-&gt;[KGH.KGHKEY]
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find SG entities</param>
        /// <param name="Value">A list of related SG entities</param>
        /// <returns>True if any SG entities are found</returns>
        public bool TryFindSGByHOUSE(string KGHKEY, out IReadOnlyList<SG> Value)
        {
            return SG_HOUSEForeignIndex.Value.TryGetValue(KGHKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.HOUSE]-&gt;[KGH.KGHKEY]
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByHOUSE(string KGHKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_HOUSEForeignIndex.Value.TryGetValue(KGHKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.HOUSE]-&gt;[KGH.KGHKEY]
        /// </summary>
        /// <param name="KGHKEY">KGHKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByHOUSE(string KGHKEY, out IReadOnlyList<ST> Value)
        {
            return ST_HOUSEForeignIndex.Value.TryGetValue(KGHKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGH" /> fields for each CSV column header</returns>
        protected override Action<KGH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGHKEY":
                        mapper[i] = (e, v) => e.KGHKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "HOUSE_SIZE":
                        mapper[i] = (e, v) => e.HOUSE_SIZE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MALES":
                        mapper[i] = (e, v) => e.MALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FEMALES":
                        mapper[i] = (e, v) => e.FEMALES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F01":
                        mapper[i] = (e, v) => e.AGE_F01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F02":
                        mapper[i] = (e, v) => e.AGE_F02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F03":
                        mapper[i] = (e, v) => e.AGE_F03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F04":
                        mapper[i] = (e, v) => e.AGE_F04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F05":
                        mapper[i] = (e, v) => e.AGE_F05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F06":
                        mapper[i] = (e, v) => e.AGE_F06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F07":
                        mapper[i] = (e, v) => e.AGE_F07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F08":
                        mapper[i] = (e, v) => e.AGE_F08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F09":
                        mapper[i] = (e, v) => e.AGE_F09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F10":
                        mapper[i] = (e, v) => e.AGE_F10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F11":
                        mapper[i] = (e, v) => e.AGE_F11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F12":
                        mapper[i] = (e, v) => e.AGE_F12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F13":
                        mapper[i] = (e, v) => e.AGE_F13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F14":
                        mapper[i] = (e, v) => e.AGE_F14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F15":
                        mapper[i] = (e, v) => e.AGE_F15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F16":
                        mapper[i] = (e, v) => e.AGE_F16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F17":
                        mapper[i] = (e, v) => e.AGE_F17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F18":
                        mapper[i] = (e, v) => e.AGE_F18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F19":
                        mapper[i] = (e, v) => e.AGE_F19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_F20":
                        mapper[i] = (e, v) => e.AGE_F20 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M01":
                        mapper[i] = (e, v) => e.AGE_M01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M02":
                        mapper[i] = (e, v) => e.AGE_M02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M03":
                        mapper[i] = (e, v) => e.AGE_M03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M04":
                        mapper[i] = (e, v) => e.AGE_M04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M05":
                        mapper[i] = (e, v) => e.AGE_M05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M06":
                        mapper[i] = (e, v) => e.AGE_M06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M07":
                        mapper[i] = (e, v) => e.AGE_M07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M08":
                        mapper[i] = (e, v) => e.AGE_M08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M09":
                        mapper[i] = (e, v) => e.AGE_M09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M10":
                        mapper[i] = (e, v) => e.AGE_M10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M11":
                        mapper[i] = (e, v) => e.AGE_M11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M12":
                        mapper[i] = (e, v) => e.AGE_M12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M13":
                        mapper[i] = (e, v) => e.AGE_M13 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M14":
                        mapper[i] = (e, v) => e.AGE_M14 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M15":
                        mapper[i] = (e, v) => e.AGE_M15 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M16":
                        mapper[i] = (e, v) => e.AGE_M16 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M17":
                        mapper[i] = (e, v) => e.AGE_M17 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M18":
                        mapper[i] = (e, v) => e.AGE_M18 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M19":
                        mapper[i] = (e, v) => e.AGE_M19 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_M20":
                        mapper[i] = (e, v) => e.AGE_M20 = v == null ? (short?)null : short.Parse(v);
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
