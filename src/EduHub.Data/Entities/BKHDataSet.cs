using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Books for Hire Data Set
    /// </summary>
    public sealed partial class BKHDataSet : SetBase<BKH>
    {
        private Lazy<Dictionary<string, BKH>> BKHKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<BKHR>>> BKHR_BKHRKEYForeignIndex;
        private Lazy<Dictionary<string, IReadOnlyList<SUBL>>> SUBL_BOOKForeignIndex;

        internal BKHDataSet(EduHubContext Context)
            : base(Context)
        {
            BKHKEYIndex = new Lazy<Dictionary<string, BKH>>(() => this.ToDictionary(e => e.BKHKEY));

            BKHR_BKHRKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<BKHR>>>(() =>
                    Context.BKHR
                          .Where(e => e.BKHRKEY != null)
                          .GroupBy(e => e.BKHRKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<BKHR>)g.ToList()
                          .AsReadOnly()));

            SUBL_BOOKForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SUBL>>>(() =>
                    Context.SUBL
                          .Where(e => e.BOOK != null)
                          .GroupBy(e => e.BOOK)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SUBL>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "BKH"; } }

        /// <summary>
        /// Find BKH by BKHKEY key field
        /// </summary>
        /// <param name="Key">BKHKEY value used to find BKH</param>
        /// <returns>Related BKH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">BKHKEY value didn't match any BKH entities</exception>
        public BKH FindByBKHKEY(string Key)
        {
            BKH result;
            if (BKHKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find BKH by BKHKEY key field
        /// </summary>
        /// <param name="Key">BKHKEY value used to find BKH</param>
        /// <param name="Value">Related BKH entity</param>
        /// <returns>True if the BKH entity is found</returns>
        public bool TryFindByBKHKEY(string Key, out BKH Value)
        {
            return BKHKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find BKH by BKHKEY key field
        /// </summary>
        /// <param name="Key">BKHKEY value used to find BKH</param>
        /// <returns>Related BKH entity, or null if not found</returns>
        public BKH TryFindByBKHKEY(string Key)
        {
            BKH result;
            if (BKHKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all BKHR (Book Hire Records) entities by [BKHR.BKHRKEY]-&gt;[BKH.BKHKEY]
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKHR entities</param>
        /// <returns>A list of related BKHR entities</returns>
        public IReadOnlyList<BKHR> FindBKHRByBKHRKEY(string BKHKEY)
        {
            IReadOnlyList<BKHR> result;
            if (BKHR_BKHRKEYForeignIndex.Value.TryGetValue(BKHKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<BKHR>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all BKHR entities by [BKHR.BKHRKEY]-&gt;[BKH.BKHKEY]
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKHR entities</param>
        /// <param name="Value">A list of related BKHR entities</param>
        /// <returns>True if any BKHR entities are found</returns>
        public bool TryFindBKHRByBKHRKEY(string BKHKEY, out IReadOnlyList<BKHR> Value)
        {
            return BKHR_BKHRKEYForeignIndex.Value.TryGetValue(BKHKEY, out Value);
        }

        /// <summary>
        /// Find all SUBL (Subject Book List) entities by [SUBL.BOOK]-&gt;[BKH.BKHKEY]
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find SUBL entities</param>
        /// <returns>A list of related SUBL entities</returns>
        public IReadOnlyList<SUBL> FindSUBLByBOOK(string BKHKEY)
        {
            IReadOnlyList<SUBL> result;
            if (SUBL_BOOKForeignIndex.Value.TryGetValue(BKHKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SUBL>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SUBL entities by [SUBL.BOOK]-&gt;[BKH.BKHKEY]
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find SUBL entities</param>
        /// <param name="Value">A list of related SUBL entities</param>
        /// <returns>True if any SUBL entities are found</returns>
        public bool TryFindSUBLByBOOK(string BKHKEY, out IReadOnlyList<SUBL> Value)
        {
            return SUBL_BOOKForeignIndex.Value.TryGetValue(BKHKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="BKH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="BKH" /> fields for each CSV column header</returns>
        protected override Action<BKH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<BKH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BKHKEY":
                        mapper[i] = (e, v) => e.BKHKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "EDITION":
                        mapper[i] = (e, v) => e.EDITION = v;
                        break;
                    case "AUTHOR":
                        mapper[i] = (e, v) => e.AUTHOR = v;
                        break;
                    case "PUBLISHER":
                        mapper[i] = (e, v) => e.PUBLISHER = v;
                        break;
                    case "PRICE":
                        mapper[i] = (e, v) => e.PRICE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ITEM_TYPE":
                        mapper[i] = (e, v) => e.ITEM_TYPE = v;
                        break;
                    case "NO_COPIES":
                        mapper[i] = (e, v) => e.NO_COPIES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SEEDED_NUM":
                        mapper[i] = (e, v) => e.SEEDED_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AVAIL_COPIES":
                        mapper[i] = (e, v) => e.AVAIL_COPIES = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ISBN":
                        mapper[i] = (e, v) => e.ISBN = v;
                        break;
                    case "ANNOTATIONS":
                        mapper[i] = (e, v) => e.ANNOTATIONS = v;
                        break;
                    case "PURCHASE_DATE":
                        mapper[i] = (e, v) => e.PURCHASE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PURCHASE_PRICE":
                        mapper[i] = (e, v) => e.PURCHASE_PRICE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HIRE_FEE":
                        mapper[i] = (e, v) => e.HIRE_FEE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REMOVE":
                        mapper[i] = (e, v) => e.REMOVE = v;
                        break;
                    case "BOOK_MOVIE":
                        mapper[i] = (e, v) => e.BOOK_MOVIE = null; // eduHub is not encoding byte arrays
                        break;
                    case "BOOK_SOUND":
                        mapper[i] = (e, v) => e.BOOK_SOUND = null; // eduHub is not encoding byte arrays
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
