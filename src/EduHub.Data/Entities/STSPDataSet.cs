using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Suspension Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STSPDataSet : SetBase<STSP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STSP"; } }

        internal STSPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SPKEY = new Lazy<Dictionary<string, IReadOnlyList<STSP>>>(() => this.ToGroupedDictionary(i => i.SPKEY));
            Index_TID = new Lazy<Dictionary<int, STSP>>(() => this.ToDictionary(i => i.TID));
            Index_REF_TEACHERA = new Lazy<NullDictionary<string, IReadOnlyList<STSP>>>(() => this.ToGroupedNullDictionary(i => i.REF_TEACHERA));
            Index_REF_TEACHERB = new Lazy<NullDictionary<string, IReadOnlyList<STSP>>>(() => this.ToGroupedNullDictionary(i => i.REF_TEACHERB));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STSP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STSP" /> fields for each CSV column header</returns>
        protected override Action<STSP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STSP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SPKEY":
                        mapper[i] = (e, v) => e.SPKEY = v;
                        break;
                    case "ENTRY_DATE":
                        mapper[i] = (e, v) => e.ENTRY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUSP_NUMBER":
                        mapper[i] = (e, v) => e.SUSP_NUMBER = v;
                        break;
                    case "REF_TEACHERA":
                        mapper[i] = (e, v) => e.REF_TEACHERA = v;
                        break;
                    case "REF_TEACHERB":
                        mapper[i] = (e, v) => e.REF_TEACHERB = v;
                        break;
                    case "NO_DAYS":
                        mapper[i] = (e, v) => e.NO_DAYS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "FROM_DATE":
                        mapper[i] = (e, v) => e.FROM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TO_DATE":
                        mapper[i] = (e, v) => e.TO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RETURN_DATE":
                        mapper[i] = (e, v) => e.RETURN_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NON_COMP":
                        mapper[i] = (e, v) => e.NON_COMP = v;
                        break;
                    case "SCH_AVOID":
                        mapper[i] = (e, v) => e.SCH_AVOID = v;
                        break;
                    case "VERBAL":
                        mapper[i] = (e, v) => e.VERBAL = v;
                        break;
                    case "PHYSICAL":
                        mapper[i] = (e, v) => e.PHYSICAL = v;
                        break;
                    case "MISUSE":
                        mapper[i] = (e, v) => e.MISUSE = v;
                        break;
                    case "SEXUAL":
                        mapper[i] = (e, v) => e.SEXUAL = v;
                        break;
                    case "INTIM":
                        mapper[i] = (e, v) => e.INTIM = v;
                        break;
                    case "VANDAL":
                        mapper[i] = (e, v) => e.VANDAL = v;
                        break;
                    case "STEALING":
                        mapper[i] = (e, v) => e.STEALING = v;
                        break;
                    case "SMOKING":
                        mapper[i] = (e, v) => e.SMOKING = v;
                        break;
                    case "DRUGS":
                        mapper[i] = (e, v) => e.DRUGS = v;
                        break;
                    case "FAIR":
                        mapper[i] = (e, v) => e.FAIR = v;
                        break;
                    case "CONSULT":
                        mapper[i] = (e, v) => e.CONSULT = v;
                        break;
                    case "PROCED":
                        mapper[i] = (e, v) => e.PROCED = v;
                        break;
                    case "COUNSEL":
                        mapper[i] = (e, v) => e.COUNSEL = v;
                        break;
                    case "CURRIC":
                        mapper[i] = (e, v) => e.CURRIC = v;
                        break;
                    case "PARENT":
                        mapper[i] = (e, v) => e.PARENT = v;
                        break;
                    case "DIRECT":
                        mapper[i] = (e, v) => e.DIRECT = v;
                        break;
                    case "APPEAL":
                        mapper[i] = (e, v) => e.APPEAL = v;
                        break;
                    case "OTHER_AGENCIES":
                        mapper[i] = (e, v) => e.OTHER_AGENCIES = v;
                        break;
                    case "POLICE":
                        mapper[i] = (e, v) => e.POLICE = v;
                        break;
                    case "OTHER_REAS":
                        mapper[i] = (e, v) => e.OTHER_REAS = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
                        break;
                    case "OTHER":
                        mapper[i] = (e, v) => e.OTHER = v;
                        break;
                    case "PRINC_DECISION":
                        mapper[i] = (e, v) => e.PRINC_DECISION = v;
                        break;
                    case "PRINC_RECOM":
                        mapper[i] = (e, v) => e.PRINC_RECOM = v;
                        break;
                    case "RECOM_DIRECT":
                        mapper[i] = (e, v) => e.RECOM_DIRECT = v;
                        break;
                    case "SCHOOL_COMM":
                        mapper[i] = (e, v) => e.SCHOOL_COMM = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<STSP>>> Index_SPKEY;
        private Lazy<Dictionary<int, STSP>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<STSP>>> Index_REF_TEACHERA;
        private Lazy<NullDictionary<string, IReadOnlyList<STSP>>> Index_REF_TEACHERB;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STSP by SPKEY field
        /// </summary>
        /// <param name="SPKEY">SPKEY value used to find STSP</param>
        /// <returns>List of related STSP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> FindBySPKEY(string SPKEY)
        {
            return Index_SPKEY.Value[SPKEY];
        }

        /// <summary>
        /// Attempt to find STSP by SPKEY field
        /// </summary>
        /// <param name="SPKEY">SPKEY value used to find STSP</param>
        /// <param name="Value">List of related STSP entities</param>
        /// <returns>True if the list of related STSP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySPKEY(string SPKEY, out IReadOnlyList<STSP> Value)
        {
            return Index_SPKEY.Value.TryGetValue(SPKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STSP by SPKEY field
        /// </summary>
        /// <param name="SPKEY">SPKEY value used to find STSP</param>
        /// <returns>List of related STSP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> TryFindBySPKEY(string SPKEY)
        {
            IReadOnlyList<STSP> value;
            if (Index_SPKEY.Value.TryGetValue(SPKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSP</param>
        /// <returns>Related STSP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STSP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSP</param>
        /// <param name="Value">Related STSP entity</param>
        /// <returns>True if the related STSP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STSP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STSP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STSP</param>
        /// <returns>Related STSP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STSP TryFindByTID(int TID)
        {
            STSP value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSP by REF_TEACHERA field
        /// </summary>
        /// <param name="REF_TEACHERA">REF_TEACHERA value used to find STSP</param>
        /// <returns>List of related STSP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> FindByREF_TEACHERA(string REF_TEACHERA)
        {
            return Index_REF_TEACHERA.Value[REF_TEACHERA];
        }

        /// <summary>
        /// Attempt to find STSP by REF_TEACHERA field
        /// </summary>
        /// <param name="REF_TEACHERA">REF_TEACHERA value used to find STSP</param>
        /// <param name="Value">List of related STSP entities</param>
        /// <returns>True if the list of related STSP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREF_TEACHERA(string REF_TEACHERA, out IReadOnlyList<STSP> Value)
        {
            return Index_REF_TEACHERA.Value.TryGetValue(REF_TEACHERA, out Value);
        }

        /// <summary>
        /// Attempt to find STSP by REF_TEACHERA field
        /// </summary>
        /// <param name="REF_TEACHERA">REF_TEACHERA value used to find STSP</param>
        /// <returns>List of related STSP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> TryFindByREF_TEACHERA(string REF_TEACHERA)
        {
            IReadOnlyList<STSP> value;
            if (Index_REF_TEACHERA.Value.TryGetValue(REF_TEACHERA, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STSP by REF_TEACHERB field
        /// </summary>
        /// <param name="REF_TEACHERB">REF_TEACHERB value used to find STSP</param>
        /// <returns>List of related STSP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> FindByREF_TEACHERB(string REF_TEACHERB)
        {
            return Index_REF_TEACHERB.Value[REF_TEACHERB];
        }

        /// <summary>
        /// Attempt to find STSP by REF_TEACHERB field
        /// </summary>
        /// <param name="REF_TEACHERB">REF_TEACHERB value used to find STSP</param>
        /// <param name="Value">List of related STSP entities</param>
        /// <returns>True if the list of related STSP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByREF_TEACHERB(string REF_TEACHERB, out IReadOnlyList<STSP> Value)
        {
            return Index_REF_TEACHERB.Value.TryGetValue(REF_TEACHERB, out Value);
        }

        /// <summary>
        /// Attempt to find STSP by REF_TEACHERB field
        /// </summary>
        /// <param name="REF_TEACHERB">REF_TEACHERB value used to find STSP</param>
        /// <returns>List of related STSP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STSP> TryFindByREF_TEACHERB(string REF_TEACHERB)
        {
            IReadOnlyList<STSP> value;
            if (Index_REF_TEACHERB.Value.TryGetValue(REF_TEACHERB, out value))
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
