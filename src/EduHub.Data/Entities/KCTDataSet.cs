using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types Data Set
    /// </summary>
    public sealed partial class KCTDataSet : SetBase<KCT>
    {
        private Lazy<Dictionary<short, KCT>> KCTKEYIndex;

        private Lazy<Dictionary<short, IReadOnlyList<SG>>> SG_ABS_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<ST>>> ST_INAC_ABS_CODEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<STRA>>> STRA_ABS_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<SXAB>>> SXAB_AM_EXP_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<SXAB>>> SXAB_AM_ACT_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<SXAB>>> SXAB_PM_EXP_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<SXAB>>> SXAB_PM_ACT_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<SXABCONV>>> SXABCONV_AM_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<SXABCONV>>> SXABCONV_PM_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<SXAS>>> SXAS_EXP_ABS_TYPEForeignIndex;
        private Lazy<Dictionary<short, IReadOnlyList<SXAS>>> SXAS_ACT_ABS_TYPEForeignIndex;

        internal KCTDataSet(EduHubContext Context)
            : base(Context)
        {
            KCTKEYIndex = new Lazy<Dictionary<short, KCT>>(() => this.ToDictionary(e => e.KCTKEY));

            SG_ABS_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SG>>>(() =>
                    Context.SG
                          .Where(e => e.ABS_TYPE != null)
                          .GroupBy(e => e.ABS_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SG>)g.ToList()
                          .AsReadOnly()));

            ST_INAC_ABS_CODEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<ST>>>(() =>
                    Context.ST
                          .Where(e => e.INAC_ABS_CODE != null)
                          .GroupBy(e => e.INAC_ABS_CODE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<ST>)g.ToList()
                          .AsReadOnly()));

            STRA_ABS_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<STRA>>>(() =>
                    Context.STRA
                          .Where(e => e.ABS_TYPE != null)
                          .GroupBy(e => e.ABS_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<STRA>)g.ToList()
                          .AsReadOnly()));

            SXAB_AM_EXP_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SXAB>>>(() =>
                    Context.SXAB
                          .Where(e => e.AM_EXP_TYPE != null)
                          .GroupBy(e => e.AM_EXP_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAB>)g.ToList()
                          .AsReadOnly()));

            SXAB_AM_ACT_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SXAB>>>(() =>
                    Context.SXAB
                          .Where(e => e.AM_ACT_TYPE != null)
                          .GroupBy(e => e.AM_ACT_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAB>)g.ToList()
                          .AsReadOnly()));

            SXAB_PM_EXP_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SXAB>>>(() =>
                    Context.SXAB
                          .Where(e => e.PM_EXP_TYPE != null)
                          .GroupBy(e => e.PM_EXP_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAB>)g.ToList()
                          .AsReadOnly()));

            SXAB_PM_ACT_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SXAB>>>(() =>
                    Context.SXAB
                          .Where(e => e.PM_ACT_TYPE != null)
                          .GroupBy(e => e.PM_ACT_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAB>)g.ToList()
                          .AsReadOnly()));

            SXABCONV_AM_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SXABCONV>>>(() =>
                    Context.SXABCONV
                          .Where(e => e.AM_TYPE != null)
                          .GroupBy(e => e.AM_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXABCONV>)g.ToList()
                          .AsReadOnly()));

            SXABCONV_PM_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SXABCONV>>>(() =>
                    Context.SXABCONV
                          .Where(e => e.PM_TYPE != null)
                          .GroupBy(e => e.PM_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXABCONV>)g.ToList()
                          .AsReadOnly()));

            SXAS_EXP_ABS_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SXAS>>>(() =>
                    Context.SXAS
                          .Where(e => e.EXP_ABS_TYPE != null)
                          .GroupBy(e => e.EXP_ABS_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAS>)g.ToList()
                          .AsReadOnly()));

            SXAS_ACT_ABS_TYPEForeignIndex =
                new Lazy<Dictionary<short, IReadOnlyList<SXAS>>>(() =>
                    Context.SXAS
                          .Where(e => e.ACT_ABS_TYPE != null)
                          .GroupBy(e => e.ACT_ABS_TYPE.Value)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SXAS>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCT"; } }

        /// <summary>
        /// Find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCTKEY value didn't match any KCT entities</exception>
        public KCT FindByKCTKEY(short Key)
        {
            KCT result;
            if (KCTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <param name="Value">Related KCT entity</param>
        /// <returns>True if the KCT entity is found</returns>
        public bool TryFindByKCTKEY(short Key, out KCT Value)
        {
            return KCTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity, or null if not found</returns>
        public KCT TryFindByKCTKEY(short Key)
        {
            KCT result;
            if (KCTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SG (Student Groupings) entities by [SG.ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SG entities</param>
        /// <returns>A list of related SG entities</returns>
        public IReadOnlyList<SG> FindSGByABS_TYPE(short KCTKEY)
        {
            IReadOnlyList<SG> result;
            if (SG_ABS_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SG entities by [SG.ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SG entities</param>
        /// <param name="Value">A list of related SG entities</param>
        /// <returns>True if any SG entities are found</returns>
        public bool TryFindSGByABS_TYPE(short KCTKEY, out IReadOnlyList<SG> Value)
        {
            return SG_ABS_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all ST (Students) entities by [ST.INAC_ABS_CODE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find ST entities</param>
        /// <returns>A list of related ST entities</returns>
        public IReadOnlyList<ST> FindSTByINAC_ABS_CODE(short KCTKEY)
        {
            IReadOnlyList<ST> result;
            if (ST_INAC_ABS_CODEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<ST>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all ST entities by [ST.INAC_ABS_CODE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find ST entities</param>
        /// <param name="Value">A list of related ST entities</param>
        /// <returns>True if any ST entities are found</returns>
        public bool TryFindSTByINAC_ABS_CODE(short KCTKEY, out IReadOnlyList<ST> Value)
        {
            return ST_INAC_ABS_CODEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all STRA (Multiple Day Absences) entities by [STRA.ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find STRA entities</param>
        /// <returns>A list of related STRA entities</returns>
        public IReadOnlyList<STRA> FindSTRAByABS_TYPE(short KCTKEY)
        {
            IReadOnlyList<STRA> result;
            if (STRA_ABS_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<STRA>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all STRA entities by [STRA.ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find STRA entities</param>
        /// <param name="Value">A list of related STRA entities</param>
        /// <returns>True if any STRA entities are found</returns>
        public bool TryFindSTRAByABS_TYPE(short KCTKEY, out IReadOnlyList<STRA> Value)
        {
            return STRA_ABS_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all SXAB (Student Half-Day Absences) entities by [SXAB.AM_EXP_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAB entities</param>
        /// <returns>A list of related SXAB entities</returns>
        public IReadOnlyList<SXAB> FindSXABByAM_EXP_TYPE(short KCTKEY)
        {
            IReadOnlyList<SXAB> result;
            if (SXAB_AM_EXP_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAB entities by [SXAB.AM_EXP_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAB entities</param>
        /// <param name="Value">A list of related SXAB entities</param>
        /// <returns>True if any SXAB entities are found</returns>
        public bool TryFindSXABByAM_EXP_TYPE(short KCTKEY, out IReadOnlyList<SXAB> Value)
        {
            return SXAB_AM_EXP_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all SXAB (Student Half-Day Absences) entities by [SXAB.AM_ACT_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAB entities</param>
        /// <returns>A list of related SXAB entities</returns>
        public IReadOnlyList<SXAB> FindSXABByAM_ACT_TYPE(short KCTKEY)
        {
            IReadOnlyList<SXAB> result;
            if (SXAB_AM_ACT_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAB entities by [SXAB.AM_ACT_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAB entities</param>
        /// <param name="Value">A list of related SXAB entities</param>
        /// <returns>True if any SXAB entities are found</returns>
        public bool TryFindSXABByAM_ACT_TYPE(short KCTKEY, out IReadOnlyList<SXAB> Value)
        {
            return SXAB_AM_ACT_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all SXAB (Student Half-Day Absences) entities by [SXAB.PM_EXP_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAB entities</param>
        /// <returns>A list of related SXAB entities</returns>
        public IReadOnlyList<SXAB> FindSXABByPM_EXP_TYPE(short KCTKEY)
        {
            IReadOnlyList<SXAB> result;
            if (SXAB_PM_EXP_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAB entities by [SXAB.PM_EXP_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAB entities</param>
        /// <param name="Value">A list of related SXAB entities</param>
        /// <returns>True if any SXAB entities are found</returns>
        public bool TryFindSXABByPM_EXP_TYPE(short KCTKEY, out IReadOnlyList<SXAB> Value)
        {
            return SXAB_PM_EXP_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all SXAB (Student Half-Day Absences) entities by [SXAB.PM_ACT_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAB entities</param>
        /// <returns>A list of related SXAB entities</returns>
        public IReadOnlyList<SXAB> FindSXABByPM_ACT_TYPE(short KCTKEY)
        {
            IReadOnlyList<SXAB> result;
            if (SXAB_PM_ACT_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAB>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAB entities by [SXAB.PM_ACT_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAB entities</param>
        /// <param name="Value">A list of related SXAB entities</param>
        /// <returns>True if any SXAB entities are found</returns>
        public bool TryFindSXABByPM_ACT_TYPE(short KCTKEY, out IReadOnlyList<SXAB> Value)
        {
            return SXAB_PM_ACT_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all SXABCONV (Converted Student Half-Day Absences) entities by [SXABCONV.AM_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXABCONV entities</param>
        /// <returns>A list of related SXABCONV entities</returns>
        public IReadOnlyList<SXABCONV> FindSXABCONVByAM_TYPE(short KCTKEY)
        {
            IReadOnlyList<SXABCONV> result;
            if (SXABCONV_AM_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXABCONV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXABCONV entities by [SXABCONV.AM_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXABCONV entities</param>
        /// <param name="Value">A list of related SXABCONV entities</param>
        /// <returns>True if any SXABCONV entities are found</returns>
        public bool TryFindSXABCONVByAM_TYPE(short KCTKEY, out IReadOnlyList<SXABCONV> Value)
        {
            return SXABCONV_AM_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all SXABCONV (Converted Student Half-Day Absences) entities by [SXABCONV.PM_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXABCONV entities</param>
        /// <returns>A list of related SXABCONV entities</returns>
        public IReadOnlyList<SXABCONV> FindSXABCONVByPM_TYPE(short KCTKEY)
        {
            IReadOnlyList<SXABCONV> result;
            if (SXABCONV_PM_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXABCONV>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXABCONV entities by [SXABCONV.PM_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXABCONV entities</param>
        /// <param name="Value">A list of related SXABCONV entities</param>
        /// <returns>True if any SXABCONV entities are found</returns>
        public bool TryFindSXABCONVByPM_TYPE(short KCTKEY, out IReadOnlyList<SXABCONV> Value)
        {
            return SXABCONV_PM_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all SXAS (Student Scheduled Sessions) entities by [SXAS.EXP_ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAS entities</param>
        /// <returns>A list of related SXAS entities</returns>
        public IReadOnlyList<SXAS> FindSXASByEXP_ABS_TYPE(short KCTKEY)
        {
            IReadOnlyList<SXAS> result;
            if (SXAS_EXP_ABS_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAS entities by [SXAS.EXP_ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAS entities</param>
        /// <param name="Value">A list of related SXAS entities</param>
        /// <returns>True if any SXAS entities are found</returns>
        public bool TryFindSXASByEXP_ABS_TYPE(short KCTKEY, out IReadOnlyList<SXAS> Value)
        {
            return SXAS_EXP_ABS_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }

        /// <summary>
        /// Find all SXAS (Student Scheduled Sessions) entities by [SXAS.ACT_ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAS entities</param>
        /// <returns>A list of related SXAS entities</returns>
        public IReadOnlyList<SXAS> FindSXASByACT_ABS_TYPE(short KCTKEY)
        {
            IReadOnlyList<SXAS> result;
            if (SXAS_ACT_ABS_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SXAS>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SXAS entities by [SXAS.ACT_ABS_TYPE]-&gt;[KCT.KCTKEY]
        /// </summary>
        /// <param name="KCTKEY">KCTKEY value used to find SXAS entities</param>
        /// <param name="Value">A list of related SXAS entities</param>
        /// <returns>True if any SXAS entities are found</returns>
        public bool TryFindSXASByACT_ABS_TYPE(short KCTKEY, out IReadOnlyList<SXAS> Value)
        {
            return SXAS_ACT_ABS_TYPEForeignIndex.Value.TryGetValue(KCTKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCT" /> fields for each CSV column header</returns>
        protected override Action<KCT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCTKEY":
                        mapper[i] = (e, v) => e.KCTKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABBREV_DESC":
                        mapper[i] = (e, v) => e.ABBREV_DESC = v;
                        break;
                    case "CURRICULUM":
                        mapper[i] = (e, v) => e.CURRICULUM = v;
                        break;
                    case "DOE_TYPE":
                        mapper[i] = (e, v) => e.DOE_TYPE = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "PRE_APPROVED":
                        mapper[i] = (e, v) => e.PRE_APPROVED = v;
                        break;
                    case "ABS_RATE":
                        mapper[i] = (e, v) => e.ABS_RATE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SMS":
                        mapper[i] = (e, v) => e.SMS = v;
                        break;
                    case "SMS_MESSAGE":
                        mapper[i] = (e, v) => e.SMS_MESSAGE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
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
