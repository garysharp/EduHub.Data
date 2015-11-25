using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Association Members Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAMDataSet : SetBase<SAM>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAM"; } }

        internal SAMDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ADDRESSKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ADDRESSKEY));
            Index_ASSOC_NAME = new Lazy<NullDictionary<string, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ASSOC_NAME));
            Index_ASSOC_POSN = new Lazy<NullDictionary<string, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.ASSOC_POSN));
            Index_MAILKEY = new Lazy<NullDictionary<int?, IReadOnlyList<SAM>>>(() => this.ToGroupedNullDictionary(i => i.MAILKEY));
            Index_SAMKEY = new Lazy<Dictionary<int, SAM>>(() => this.ToDictionary(i => i.SAMKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAM" /> fields for each CSV column header</returns>
        protected override Action<SAM, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAMKEY":
                        mapper[i] = (e, v) => e.SAMKEY = int.Parse(v);
                        break;
                    case "PERSON_TYPE":
                        mapper[i] = (e, v) => e.PERSON_TYPE = v;
                        break;
                    case "PERSON":
                        mapper[i] = (e, v) => e.PERSON = v;
                        break;
                    case "WHICH_PARENT":
                        mapper[i] = (e, v) => e.WHICH_PARENT = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "BIRTHDATE":
                        mapper[i] = (e, v) => e.BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "KOORIE":
                        mapper[i] = (e, v) => e.KOORIE = v;
                        break;
                    case "PARENT_OS":
                        mapper[i] = (e, v) => e.PARENT_OS = v;
                        break;
                    case "LOTE":
                        mapper[i] = (e, v) => e.LOTE = v;
                        break;
                    case "LBOTE":
                        mapper[i] = (e, v) => e.LBOTE = v;
                        break;
                    case "DISABILITY":
                        mapper[i] = (e, v) => e.DISABILITY = v;
                        break;
                    case "ASSOC_NAME":
                        mapper[i] = (e, v) => e.ASSOC_NAME = v;
                        break;
                    case "ASSOC_POSN":
                        mapper[i] = (e, v) => e.ASSOC_POSN = v;
                        break;
                    case "ADDRESSKEY":
                        mapper[i] = (e, v) => e.ADDRESSKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "MAILKEY":
                        mapper[i] = (e, v) => e.MAILKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "HOME_E_MAIL":
                        mapper[i] = (e, v) => e.HOME_E_MAIL = v;
                        break;
                    case "WORK_PHONE":
                        mapper[i] = (e, v) => e.WORK_PHONE = v;
                        break;
                    case "WORK_FAX":
                        mapper[i] = (e, v) => e.WORK_FAX = v;
                        break;
                    case "WORK_E_MAIL":
                        mapper[i] = (e, v) => e.WORK_E_MAIL = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "MOBILE_PHONE":
                        mapper[i] = (e, v) => e.MOBILE_PHONE = v;
                        break;
                    case "SIGNATORY":
                        mapper[i] = (e, v) => e.SIGNATORY = v;
                        break;
                    case "SAM_COMMENT":
                        mapper[i] = (e, v) => e.SAM_COMMENT = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="SAM" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAM" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAM" /> items to added or update the base <see cref="SAM" /> items</param>
        /// <returns>A merged list of <see cref="SAM" /> items</returns>
        protected override List<SAM> ApplyDeltaItems(List<SAM> Items, List<SAM> DeltaItems)
        {
            Dictionary<int, int> Index_SAMKEY = Items.ToIndexDictionary(i => i.SAMKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAM deltaItem in DeltaItems)
            {
                int index;

                if (Index_SAMKEY.TryGetValue(deltaItem.SAMKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SAMKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SAM>>> Index_ADDRESSKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<SAM>>> Index_ASSOC_NAME;
        private Lazy<NullDictionary<string, IReadOnlyList<SAM>>> Index_ASSOC_POSN;
        private Lazy<NullDictionary<int?, IReadOnlyList<SAM>>> Index_MAILKEY;
        private Lazy<Dictionary<int, SAM>> Index_SAMKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByADDRESSKEY(int? ADDRESSKEY)
        {
            return Index_ADDRESSKEY.Value[ADDRESSKEY];
        }

        /// <summary>
        /// Attempt to find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByADDRESSKEY(int? ADDRESSKEY, out IReadOnlyList<SAM> Value)
        {
            return Index_ADDRESSKEY.Value.TryGetValue(ADDRESSKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ADDRESSKEY field
        /// </summary>
        /// <param name="ADDRESSKEY">ADDRESSKEY value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByADDRESSKEY(int? ADDRESSKEY)
        {
            IReadOnlyList<SAM> value;
            if (Index_ADDRESSKEY.Value.TryGetValue(ADDRESSKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByASSOC_NAME(string ASSOC_NAME)
        {
            return Index_ASSOC_NAME.Value[ASSOC_NAME];
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByASSOC_NAME(string ASSOC_NAME, out IReadOnlyList<SAM> Value)
        {
            return Index_ASSOC_NAME.Value.TryGetValue(ASSOC_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_NAME field
        /// </summary>
        /// <param name="ASSOC_NAME">ASSOC_NAME value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByASSOC_NAME(string ASSOC_NAME)
        {
            IReadOnlyList<SAM> value;
            if (Index_ASSOC_NAME.Value.TryGetValue(ASSOC_NAME, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByASSOC_POSN(string ASSOC_POSN)
        {
            return Index_ASSOC_POSN.Value[ASSOC_POSN];
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByASSOC_POSN(string ASSOC_POSN, out IReadOnlyList<SAM> Value)
        {
            return Index_ASSOC_POSN.Value.TryGetValue(ASSOC_POSN, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by ASSOC_POSN field
        /// </summary>
        /// <param name="ASSOC_POSN">ASSOC_POSN value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByASSOC_POSN(string ASSOC_POSN)
        {
            IReadOnlyList<SAM> value;
            if (Index_ASSOC_POSN.Value.TryGetValue(ASSOC_POSN, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <returns>List of related SAM entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> FindByMAILKEY(int? MAILKEY)
        {
            return Index_MAILKEY.Value[MAILKEY];
        }

        /// <summary>
        /// Attempt to find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <param name="Value">List of related SAM entities</param>
        /// <returns>True if the list of related SAM entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByMAILKEY(int? MAILKEY, out IReadOnlyList<SAM> Value)
        {
            return Index_MAILKEY.Value.TryGetValue(MAILKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by MAILKEY field
        /// </summary>
        /// <param name="MAILKEY">MAILKEY value used to find SAM</param>
        /// <returns>List of related SAM entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAM> TryFindByMAILKEY(int? MAILKEY)
        {
            IReadOnlyList<SAM> value;
            if (Index_MAILKEY.Value.TryGetValue(MAILKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <returns>Related SAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAM FindBySAMKEY(int SAMKEY)
        {
            return Index_SAMKEY.Value[SAMKEY];
        }

        /// <summary>
        /// Attempt to find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <param name="Value">Related SAM entity</param>
        /// <returns>True if the related SAM entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAMKEY(int SAMKEY, out SAM Value)
        {
            return Index_SAMKEY.Value.TryGetValue(SAMKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAM by SAMKEY field
        /// </summary>
        /// <param name="SAMKEY">SAMKEY value used to find SAM</param>
        /// <returns>Related SAM entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAM TryFindBySAMKEY(int SAMKEY)
        {
            SAM value;
            if (Index_SAMKEY.Value.TryGetValue(SAMKEY, out value))
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
