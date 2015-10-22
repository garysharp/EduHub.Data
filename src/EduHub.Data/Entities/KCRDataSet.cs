using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Routes/Stops Data Set
    /// </summary>
    public sealed partial class KCRDataSet : SetBase<KCR>
    {
        private Lazy<Dictionary<string, KCR>> KCRKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_AM1_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_PM1_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_AM2_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_PM2_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_AM3_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_PM3_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_AM4_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_PM4_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_AM5_ROUTEForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<STBT>>> STBT_PM5_ROUTEForeignIndex;

        internal KCRDataSet(EduHubContext Context)
            : base(Context)
        {
            KCRKEYIndex = new Lazy<Dictionary<string, KCR>>(() => this.ToDictionary(e => e.KCRKEY));

            STBT_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.ROUTE != null)
                          .GroupBy(e => e.ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM1_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM1_ROUTE != null)
                          .GroupBy(e => e.AM1_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM1_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM1_ROUTE != null)
                          .GroupBy(e => e.PM1_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM2_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM2_ROUTE != null)
                          .GroupBy(e => e.AM2_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM2_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM2_ROUTE != null)
                          .GroupBy(e => e.PM2_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM3_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM3_ROUTE != null)
                          .GroupBy(e => e.AM3_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM3_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM3_ROUTE != null)
                          .GroupBy(e => e.PM3_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM4_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM4_ROUTE != null)
                          .GroupBy(e => e.AM4_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM4_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM4_ROUTE != null)
                          .GroupBy(e => e.PM4_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_AM5_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.AM5_ROUTE != null)
                          .GroupBy(e => e.AM5_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

            STBT_PM5_ROUTEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<STBT>>>(() =>
                    Context.STBT
                          .Where(e => e.PM5_ROUTE != null)
                          .GroupBy(e => e.PM5_ROUTE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STBT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCR"; } }

        /// <summary>
        /// Find KCR by KCRKEY key field
        /// </summary>
        /// <param name="Key">KCRKEY value used to find KCR</param>
        /// <returns>Related KCR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCRKEY value didn't match any KCR entities</exception>
        public KCR FindByKCRKEY(string Key)
        {
            KCR result;
            if (KCRKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCR by KCRKEY key field
        /// </summary>
        /// <param name="Key">KCRKEY value used to find KCR</param>
        /// <param name="Value">Related KCR entity</param>
        /// <returns>True if the KCR entity is found</returns>
        public bool TryFindByKCRKEY(string Key, out KCR Value)
        {
            return KCRKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCR by KCRKEY key field
        /// </summary>
        /// <param name="Key">KCRKEY value used to find KCR</param>
        /// <returns>Related KCR entity, or null if not found</returns>
        public KCR TryFindByKCRKEY(string Key)
        {
            KCR result;
            if (KCRKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM1_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM1_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM1_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM1_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM1_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM1_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM1_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM1_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM1_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM1_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM1_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM1_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM2_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM2_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM2_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM2_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM2_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM2_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM2_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM2_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM2_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM2_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM2_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM2_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM3_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM3_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM3_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM3_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM3_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM3_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM3_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM3_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM3_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM3_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM3_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM3_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM4_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM4_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM4_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM4_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM4_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM4_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM4_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM4_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM4_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM4_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM4_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM4_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.AM5_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByAM5_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_AM5_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.AM5_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByAM5_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_AM5_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Find all STBT (Student Transport Usage) entities by [STBT.PM5_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <returns>A list of related STBT entities</returns>
        public IReadOnlyList<STBT> FindSTBTByPM5_ROUTE(string KCRKEY)
        {
            IReadOnlyList<STBT> result;
            if (STBT_PM5_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STBT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STBT entities by [STBT.PM5_ROUTE]-&gt;[KCR.KCRKEY]
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find STBT entities</param>
        /// <param name="Value">A list of related STBT entities</param>
        /// <returns>True if any STBT entities are found</returns>
        public bool TryFindSTBTByPM5_ROUTE(string KCRKEY, out IReadOnlyList<STBT> Value)
        {
            return STBT_PM5_ROUTEForeignIndex.Value.TryGetValue(KCRKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCR" /> fields for each CSV column header</returns>
        protected override Action<KCR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCRKEY":
                        mapper[i] = (e, v) => e.KCRKEY = v;
                        break;
                    case "TRANSPORT_TYPE":
                        mapper[i] = (e, v) => e.TRANSPORT_TYPE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROUTE_CODE":
                        mapper[i] = (e, v) => e.ROUTE_CODE = v;
                        break;
                    case "STOP_DESCRIP":
                        mapper[i] = (e, v) => e.STOP_DESCRIP = v;
                        break;
                    case "DAYOFWK01":
                        mapper[i] = (e, v) => e.DAYOFWK01 = v;
                        break;
                    case "DAYOFWK02":
                        mapper[i] = (e, v) => e.DAYOFWK02 = v;
                        break;
                    case "DAYOFWK03":
                        mapper[i] = (e, v) => e.DAYOFWK03 = v;
                        break;
                    case "DAYOFWK04":
                        mapper[i] = (e, v) => e.DAYOFWK04 = v;
                        break;
                    case "DAYOFWK05":
                        mapper[i] = (e, v) => e.DAYOFWK05 = v;
                        break;
                    case "DEPART_AM":
                        mapper[i] = (e, v) => e.DEPART_AM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEPART_PM":
                        mapper[i] = (e, v) => e.DEPART_PM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ARRIVE_AM":
                        mapper[i] = (e, v) => e.ARRIVE_AM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ARRIVE_PM":
                        mapper[i] = (e, v) => e.ARRIVE_PM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "NO_OF_STUD":
                        mapper[i] = (e, v) => e.NO_OF_STUD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PROG_NO":
                        mapper[i] = (e, v) => e.PROG_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DIST_LAST":
                        mapper[i] = (e, v) => e.DIST_LAST = v == null ? (double?)null : double.Parse(v);
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
