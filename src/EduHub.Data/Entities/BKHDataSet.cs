using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Books for Hire Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class BKHDataSet : SetBase<BKH>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "BKH"; } }

        internal BKHDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BKHKEY = new Lazy<Dictionary<string, BKH>>(() => this.ToDictionary(i => i.BKHKEY));
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

        #region Index Fields

        private Lazy<Dictionary<string, BKH>> Index_BKHKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <returns>Related BKH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKH FindByBKHKEY(string BKHKEY)
        {
            return Index_BKHKEY.Value[BKHKEY];
        }

        /// <summary>
        /// Attempt to find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <param name="Value">Related BKH entity</param>
        /// <returns>True if the related BKH entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBKHKEY(string BKHKEY, out BKH Value)
        {
            return Index_BKHKEY.Value.TryGetValue(BKHKEY, out Value);
        }

        /// <summary>
        /// Attempt to find BKH by BKHKEY field
        /// </summary>
        /// <param name="BKHKEY">BKHKEY value used to find BKH</param>
        /// <returns>Related BKH entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public BKH TryFindByBKHKEY(string BKHKEY)
        {
            BKH value;
            if (Index_BKHKEY.Value.TryGetValue(BKHKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
