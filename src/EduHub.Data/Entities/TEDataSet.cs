using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Events Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TEDataSet : SetBase<TE>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TE"; } }

        internal TEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_TEKEY = new Lazy<Dictionary<int, TE>>(() => this.ToDictionary(i => i.TEKEY));
            Index_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.CAMPUS));
            Index_LOCATION = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.LOCATION));
            Index_CATEGORY = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.CATEGORY));
            Index_START_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.START_YEAR));
            Index_END_YEAR = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.END_YEAR));
            Index_START_FORM = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.START_FORM));
            Index_END_FORM = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.END_FORM));
            Index_SUBJ = new Lazy<NullDictionary<string, IReadOnlyList<TE>>>(() => this.ToGroupedNullDictionary(i => i.SUBJ));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TE" /> fields for each CSV column header</returns>
        protected override Action<TE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TEKEY":
                        mapper[i] = (e, v) => e.TEKEY = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECURRENCE":
                        mapper[i] = (e, v) => e.RECURRENCE = v;
                        break;
                    case "RECUR_DAYS":
                        mapper[i] = (e, v) => e.RECUR_DAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_FROM":
                        mapper[i] = (e, v) => e.TIME_FROM = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TO":
                        mapper[i] = (e, v) => e.TIME_TO = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CONVENOR":
                        mapper[i] = (e, v) => e.CONVENOR = v;
                        break;
                    case "CONVENOR_TYPE":
                        mapper[i] = (e, v) => e.CONVENOR_TYPE = v;
                        break;
                    case "LOCATION":
                        mapper[i] = (e, v) => e.LOCATION = v;
                        break;
                    case "EVENT_GROUP":
                        mapper[i] = (e, v) => e.EVENT_GROUP = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "COLOUR":
                        mapper[i] = (e, v) => e.COLOUR = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EVENT_CODE":
                        mapper[i] = (e, v) => e.EVENT_CODE = v;
                        break;
                    case "START_YEAR":
                        mapper[i] = (e, v) => e.START_YEAR = v;
                        break;
                    case "END_YEAR":
                        mapper[i] = (e, v) => e.END_YEAR = v;
                        break;
                    case "START_FORM":
                        mapper[i] = (e, v) => e.START_FORM = v;
                        break;
                    case "END_FORM":
                        mapper[i] = (e, v) => e.END_FORM = v;
                        break;
                    case "SUBJ":
                        mapper[i] = (e, v) => e.SUBJ = v;
                        break;
                    case "START_CLASS_NUM":
                        mapper[i] = (e, v) => e.START_CLASS_NUM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_CLASS_NUM":
                        mapper[i] = (e, v) => e.END_CLASS_NUM = v == null ? (short?)null : short.Parse(v);
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

        private Lazy<Dictionary<int, TE>> Index_TEKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<TE>>> Index_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_LOCATION;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_CATEGORY;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_START_YEAR;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_END_YEAR;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_START_FORM;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_END_FORM;
        private Lazy<NullDictionary<string, IReadOnlyList<TE>>> Index_SUBJ;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TE by TEKEY field
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TE</param>
        /// <returns>Related TE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TE FindByTEKEY(int TEKEY)
        {
            return Index_TEKEY.Value[TEKEY];
        }

        /// <summary>
        /// Attempt to find TE by TEKEY field
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TE</param>
        /// <param name="Value">Related TE entity</param>
        /// <returns>True if the related TE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTEKEY(int TEKEY, out TE Value)
        {
            return Index_TEKEY.Value.TryGetValue(TEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find TE by TEKEY field
        /// </summary>
        /// <param name="TEKEY">TEKEY value used to find TE</param>
        /// <returns>Related TE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TE TryFindByTEKEY(int TEKEY)
        {
            TE value;
            if (Index_TEKEY.Value.TryGetValue(TEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByCAMPUS(int? CAMPUS)
        {
            return Index_CAMPUS.Value[CAMPUS];
        }

        /// <summary>
        /// Attempt to find TE by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAMPUS(int? CAMPUS, out IReadOnlyList<TE> Value)
        {
            return Index_CAMPUS.Value.TryGetValue(CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find TE by CAMPUS field
        /// </summary>
        /// <param name="CAMPUS">CAMPUS value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByCAMPUS(int? CAMPUS)
        {
            IReadOnlyList<TE> value;
            if (Index_CAMPUS.Value.TryGetValue(CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByLOCATION(string LOCATION)
        {
            return Index_LOCATION.Value[LOCATION];
        }

        /// <summary>
        /// Attempt to find TE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLOCATION(string LOCATION, out IReadOnlyList<TE> Value)
        {
            return Index_LOCATION.Value.TryGetValue(LOCATION, out Value);
        }

        /// <summary>
        /// Attempt to find TE by LOCATION field
        /// </summary>
        /// <param name="LOCATION">LOCATION value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByLOCATION(string LOCATION)
        {
            IReadOnlyList<TE> value;
            if (Index_LOCATION.Value.TryGetValue(LOCATION, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByCATEGORY(string CATEGORY)
        {
            return Index_CATEGORY.Value[CATEGORY];
        }

        /// <summary>
        /// Attempt to find TE by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCATEGORY(string CATEGORY, out IReadOnlyList<TE> Value)
        {
            return Index_CATEGORY.Value.TryGetValue(CATEGORY, out Value);
        }

        /// <summary>
        /// Attempt to find TE by CATEGORY field
        /// </summary>
        /// <param name="CATEGORY">CATEGORY value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByCATEGORY(string CATEGORY)
        {
            IReadOnlyList<TE> value;
            if (Index_CATEGORY.Value.TryGetValue(CATEGORY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by START_YEAR field
        /// </summary>
        /// <param name="START_YEAR">START_YEAR value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindBySTART_YEAR(string START_YEAR)
        {
            return Index_START_YEAR.Value[START_YEAR];
        }

        /// <summary>
        /// Attempt to find TE by START_YEAR field
        /// </summary>
        /// <param name="START_YEAR">START_YEAR value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTART_YEAR(string START_YEAR, out IReadOnlyList<TE> Value)
        {
            return Index_START_YEAR.Value.TryGetValue(START_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find TE by START_YEAR field
        /// </summary>
        /// <param name="START_YEAR">START_YEAR value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindBySTART_YEAR(string START_YEAR)
        {
            IReadOnlyList<TE> value;
            if (Index_START_YEAR.Value.TryGetValue(START_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by END_YEAR field
        /// </summary>
        /// <param name="END_YEAR">END_YEAR value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByEND_YEAR(string END_YEAR)
        {
            return Index_END_YEAR.Value[END_YEAR];
        }

        /// <summary>
        /// Attempt to find TE by END_YEAR field
        /// </summary>
        /// <param name="END_YEAR">END_YEAR value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEND_YEAR(string END_YEAR, out IReadOnlyList<TE> Value)
        {
            return Index_END_YEAR.Value.TryGetValue(END_YEAR, out Value);
        }

        /// <summary>
        /// Attempt to find TE by END_YEAR field
        /// </summary>
        /// <param name="END_YEAR">END_YEAR value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByEND_YEAR(string END_YEAR)
        {
            IReadOnlyList<TE> value;
            if (Index_END_YEAR.Value.TryGetValue(END_YEAR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by START_FORM field
        /// </summary>
        /// <param name="START_FORM">START_FORM value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindBySTART_FORM(string START_FORM)
        {
            return Index_START_FORM.Value[START_FORM];
        }

        /// <summary>
        /// Attempt to find TE by START_FORM field
        /// </summary>
        /// <param name="START_FORM">START_FORM value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTART_FORM(string START_FORM, out IReadOnlyList<TE> Value)
        {
            return Index_START_FORM.Value.TryGetValue(START_FORM, out Value);
        }

        /// <summary>
        /// Attempt to find TE by START_FORM field
        /// </summary>
        /// <param name="START_FORM">START_FORM value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindBySTART_FORM(string START_FORM)
        {
            IReadOnlyList<TE> value;
            if (Index_START_FORM.Value.TryGetValue(START_FORM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by END_FORM field
        /// </summary>
        /// <param name="END_FORM">END_FORM value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindByEND_FORM(string END_FORM)
        {
            return Index_END_FORM.Value[END_FORM];
        }

        /// <summary>
        /// Attempt to find TE by END_FORM field
        /// </summary>
        /// <param name="END_FORM">END_FORM value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByEND_FORM(string END_FORM, out IReadOnlyList<TE> Value)
        {
            return Index_END_FORM.Value.TryGetValue(END_FORM, out Value);
        }

        /// <summary>
        /// Attempt to find TE by END_FORM field
        /// </summary>
        /// <param name="END_FORM">END_FORM value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindByEND_FORM(string END_FORM)
        {
            IReadOnlyList<TE> value;
            if (Index_END_FORM.Value.TryGetValue(END_FORM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TE by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TE</param>
        /// <returns>List of related TE entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> FindBySUBJ(string SUBJ)
        {
            return Index_SUBJ.Value[SUBJ];
        }

        /// <summary>
        /// Attempt to find TE by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TE</param>
        /// <param name="Value">List of related TE entities</param>
        /// <returns>True if the list of related TE entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBJ(string SUBJ, out IReadOnlyList<TE> Value)
        {
            return Index_SUBJ.Value.TryGetValue(SUBJ, out Value);
        }

        /// <summary>
        /// Attempt to find TE by SUBJ field
        /// </summary>
        /// <param name="SUBJ">SUBJ value used to find TE</param>
        /// <returns>List of related TE entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TE> TryFindBySUBJ(string SUBJ)
        {
            IReadOnlyList<TE> value;
            if (Index_SUBJ.Value.TryGetValue(SUBJ, out value))
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
