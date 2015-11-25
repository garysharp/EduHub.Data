using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Publications Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPUDataSet : SetBase<SPU>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPU"; } }

        internal SPUDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_HOME_LANGUAGE = new Lazy<NullDictionary<string, IReadOnlyList<SPU>>>(() => this.ToGroupedNullDictionary(i => i.HOME_LANGUAGE));
            Index_MAILING_LIST = new Lazy<NullDictionary<string, IReadOnlyList<SPU>>>(() => this.ToGroupedNullDictionary(i => i.MAILING_LIST));
            Index_SPUKEY = new Lazy<Dictionary<string, SPU>>(() => this.ToDictionary(i => i.SPUKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPU" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPU" /> fields for each CSV column header</returns>
        protected override Action<SPU, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPU, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPUKEY":
                        mapper[i] = (e, v) => e.SPUKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TARGET":
                        mapper[i] = (e, v) => e.TARGET = v;
                        break;
                    case "LANGUAGE_INDICATOR":
                        mapper[i] = (e, v) => e.LANGUAGE_INDICATOR = v;
                        break;
                    case "MAILING_MECHANISM":
                        mapper[i] = (e, v) => e.MAILING_MECHANISM = v;
                        break;
                    case "PUBLICATION_TYPE":
                        mapper[i] = (e, v) => e.PUBLICATION_TYPE = v;
                        break;
                    case "ADDRESS_COMMENT":
                        mapper[i] = (e, v) => e.ADDRESS_COMMENT = v;
                        break;
                    case "STUDENT_SPECIFIC":
                        mapper[i] = (e, v) => e.STUDENT_SPECIFIC = v;
                        break;
                    case "MAILING_LIST":
                        mapper[i] = (e, v) => e.MAILING_LIST = v;
                        break;
                    case "ACTUAL_ELIGIBLE_MEMBERS":
                        mapper[i] = (e, v) => e.ACTUAL_ELIGIBLE_MEMBERS = v;
                        break;
                    case "HOME_LANGUAGE":
                        mapper[i] = (e, v) => e.HOME_LANGUAGE = v;
                        break;
                    case "PRIMARY_SORT":
                        mapper[i] = (e, v) => e.PRIMARY_SORT = v;
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

        /// <summary>
        /// Merges <see cref="SPU" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SPU" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SPU" /> items to added or update the base <see cref="SPU" /> items</param>
        /// <returns>A merged list of <see cref="SPU" /> items</returns>
        protected override List<SPU> ApplyDeltaItems(List<SPU> Items, List<SPU> DeltaItems)
        {
            Dictionary<string, int> Index_SPUKEY = Items.ToIndexDictionary(i => i.SPUKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SPU deltaItem in DeltaItems)
            {
                int index;

                if (Index_SPUKEY.TryGetValue(deltaItem.SPUKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SPUKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<SPU>>> Index_HOME_LANGUAGE;
        private Lazy<NullDictionary<string, IReadOnlyList<SPU>>> Index_MAILING_LIST;
        private Lazy<Dictionary<string, SPU>> Index_SPUKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPU by HOME_LANGUAGE field
        /// </summary>
        /// <param name="HOME_LANGUAGE">HOME_LANGUAGE value used to find SPU</param>
        /// <returns>List of related SPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPU> FindByHOME_LANGUAGE(string HOME_LANGUAGE)
        {
            return Index_HOME_LANGUAGE.Value[HOME_LANGUAGE];
        }

        /// <summary>
        /// Attempt to find SPU by HOME_LANGUAGE field
        /// </summary>
        /// <param name="HOME_LANGUAGE">HOME_LANGUAGE value used to find SPU</param>
        /// <param name="Value">List of related SPU entities</param>
        /// <returns>True if the list of related SPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOME_LANGUAGE(string HOME_LANGUAGE, out IReadOnlyList<SPU> Value)
        {
            return Index_HOME_LANGUAGE.Value.TryGetValue(HOME_LANGUAGE, out Value);
        }

        /// <summary>
        /// Attempt to find SPU by HOME_LANGUAGE field
        /// </summary>
        /// <param name="HOME_LANGUAGE">HOME_LANGUAGE value used to find SPU</param>
        /// <returns>List of related SPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPU> TryFindByHOME_LANGUAGE(string HOME_LANGUAGE)
        {
            IReadOnlyList<SPU> value;
            if (Index_HOME_LANGUAGE.Value.TryGetValue(HOME_LANGUAGE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPU by MAILING_LIST field
        /// </summary>
        /// <param name="MAILING_LIST">MAILING_LIST value used to find SPU</param>
        /// <returns>List of related SPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPU> FindByMAILING_LIST(string MAILING_LIST)
        {
            return Index_MAILING_LIST.Value[MAILING_LIST];
        }

        /// <summary>
        /// Attempt to find SPU by MAILING_LIST field
        /// </summary>
        /// <param name="MAILING_LIST">MAILING_LIST value used to find SPU</param>
        /// <param name="Value">List of related SPU entities</param>
        /// <returns>True if the list of related SPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILING_LIST(string MAILING_LIST, out IReadOnlyList<SPU> Value)
        {
            return Index_MAILING_LIST.Value.TryGetValue(MAILING_LIST, out Value);
        }

        /// <summary>
        /// Attempt to find SPU by MAILING_LIST field
        /// </summary>
        /// <param name="MAILING_LIST">MAILING_LIST value used to find SPU</param>
        /// <returns>List of related SPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPU> TryFindByMAILING_LIST(string MAILING_LIST)
        {
            IReadOnlyList<SPU> value;
            if (Index_MAILING_LIST.Value.TryGetValue(MAILING_LIST, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SPU by SPUKEY field
        /// </summary>
        /// <param name="SPUKEY">SPUKEY value used to find SPU</param>
        /// <returns>Related SPU entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPU FindBySPUKEY(string SPUKEY)
        {
            return Index_SPUKEY.Value[SPUKEY];
        }

        /// <summary>
        /// Attempt to find SPU by SPUKEY field
        /// </summary>
        /// <param name="SPUKEY">SPUKEY value used to find SPU</param>
        /// <param name="Value">Related SPU entity</param>
        /// <returns>True if the related SPU entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPUKEY(string SPUKEY, out SPU Value)
        {
            return Index_SPUKEY.Value.TryGetValue(SPUKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SPU by SPUKEY field
        /// </summary>
        /// <param name="SPUKEY">SPUKEY value used to find SPU</param>
        /// <returns>Related SPU entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPU TryFindBySPUKEY(string SPUKEY)
        {
            SPU value;
            if (Index_SPUKEY.Value.TryGetValue(SPUKEY, out value))
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
