using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Books for Hire Data Set
    /// </summary>
    public sealed class BKHDataSet : SetBase<BKH>
    {
        private Lazy<Dictionary<string, BKH>> BKHKEYIndex;

        internal BKHDataSet(EduHubContext Context)
            : base(Context)
        {
            BKHKEYIndex = new Lazy<Dictionary<string, BKH>>(() => this.ToDictionary(e => e.BKHKEY));
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
        /// <returns>True if the BKH Entity is found</returns>
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

        protected override Action<BKH, string>[] BuildMapper(List<string> Headers)
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
