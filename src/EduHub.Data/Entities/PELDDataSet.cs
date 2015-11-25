using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Details Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PELDDataSet : SetBase<PELD>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PELD"; } }

        internal PELDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PEKEY = new Lazy<Dictionary<string, IReadOnlyList<PELD>>>(() => this.ToGroupedDictionary(i => i.PEKEY));
            Index_TID = new Lazy<Dictionary<int, PELD>>(() => this.ToDictionary(i => i.TID));
            Index_PEKEY_LEAVE_CODE = new Lazy<Dictionary<Tuple<string, string>, PELD>>(() => this.ToDictionary(i => Tuple.Create(i.PEKEY, i.LEAVE_CODE)));
            Index_PLTKEY = new Lazy<NullDictionary<string, IReadOnlyList<PELD>>>(() => this.ToGroupedNullDictionary(i => i.PLTKEY));
            Index_LEAVE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<PELD>>>(() => this.ToGroupedNullDictionary(i => i.LEAVE_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PELD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PELD" /> fields for each CSV column header</returns>
        protected override Action<PELD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PELD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "LEAVE_STARTDATE":
                        mapper[i] = (e, v) => e.LEAVE_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_CALC_DATE":
                        mapper[i] = (e, v) => e.LAST_CALC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_ANNIV_DATE":
                        mapper[i] = (e, v) => e.LAST_ANNIV_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNIVERSARY_DATE":
                        mapper[i] = (e, v) => e.ANNIVERSARY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LEAVE_ENT_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_ENT_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_PRORATA_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_PRORATA_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH_STEP":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WORKED":
                        mapper[i] = (e, v) => e.WORKED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STANDARD":
                        mapper[i] = (e, v) => e.STANDARD = v == null ? (double?)null : double.Parse(v);
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

        private Lazy<Dictionary<string, IReadOnlyList<PELD>>> Index_PEKEY;
        private Lazy<Dictionary<int, PELD>> Index_TID;
        private Lazy<Dictionary<Tuple<string, string>, PELD>> Index_PEKEY_LEAVE_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PELD>>> Index_PLTKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<PELD>>> Index_LEAVE_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PELD by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <returns>List of related PELD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> FindByPEKEY(string PEKEY)
        {
            return Index_PEKEY.Value[PEKEY];
        }

        /// <summary>
        /// Attempt to find PELD by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <param name="Value">List of related PELD entities</param>
        /// <returns>True if the list of related PELD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPEKEY(string PEKEY, out IReadOnlyList<PELD> Value)
        {
            return Index_PEKEY.Value.TryGetValue(PEKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PELD by PEKEY field
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <returns>List of related PELD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> TryFindByPEKEY(string PEKEY)
        {
            IReadOnlyList<PELD> value;
            if (Index_PEKEY.Value.TryGetValue(PEKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELD</param>
        /// <returns>Related PELD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELD FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PELD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELD</param>
        /// <param name="Value">Related PELD entity</param>
        /// <returns>True if the related PELD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PELD Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PELD by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PELD</param>
        /// <returns>Related PELD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELD TryFindByTID(int TID)
        {
            PELD value;
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
        /// Find PELD by PEKEY and LEAVE_CODE fields
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <returns>Related PELD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELD FindByPEKEY_LEAVE_CODE(string PEKEY, string LEAVE_CODE)
        {
            return Index_PEKEY_LEAVE_CODE.Value[Tuple.Create(PEKEY, LEAVE_CODE)];
        }

        /// <summary>
        /// Attempt to find PELD by PEKEY and LEAVE_CODE fields
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <param name="Value">Related PELD entity</param>
        /// <returns>True if the related PELD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPEKEY_LEAVE_CODE(string PEKEY, string LEAVE_CODE, out PELD Value)
        {
            return Index_PEKEY_LEAVE_CODE.Value.TryGetValue(Tuple.Create(PEKEY, LEAVE_CODE), out Value);
        }

        /// <summary>
        /// Attempt to find PELD by PEKEY and LEAVE_CODE fields
        /// </summary>
        /// <param name="PEKEY">PEKEY value used to find PELD</param>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <returns>Related PELD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PELD TryFindByPEKEY_LEAVE_CODE(string PEKEY, string LEAVE_CODE)
        {
            PELD value;
            if (Index_PEKEY_LEAVE_CODE.Value.TryGetValue(Tuple.Create(PEKEY, LEAVE_CODE), out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELD by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PELD</param>
        /// <returns>List of related PELD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> FindByPLTKEY(string PLTKEY)
        {
            return Index_PLTKEY.Value[PLTKEY];
        }

        /// <summary>
        /// Attempt to find PELD by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PELD</param>
        /// <param name="Value">List of related PELD entities</param>
        /// <returns>True if the list of related PELD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPLTKEY(string PLTKEY, out IReadOnlyList<PELD> Value)
        {
            return Index_PLTKEY.Value.TryGetValue(PLTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PELD by PLTKEY field
        /// </summary>
        /// <param name="PLTKEY">PLTKEY value used to find PELD</param>
        /// <returns>List of related PELD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> TryFindByPLTKEY(string PLTKEY)
        {
            IReadOnlyList<PELD> value;
            if (Index_PLTKEY.Value.TryGetValue(PLTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PELD by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <returns>List of related PELD entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> FindByLEAVE_CODE(string LEAVE_CODE)
        {
            return Index_LEAVE_CODE.Value[LEAVE_CODE];
        }

        /// <summary>
        /// Attempt to find PELD by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <param name="Value">List of related PELD entities</param>
        /// <returns>True if the list of related PELD entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByLEAVE_CODE(string LEAVE_CODE, out IReadOnlyList<PELD> Value)
        {
            return Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PELD by LEAVE_CODE field
        /// </summary>
        /// <param name="LEAVE_CODE">LEAVE_CODE value used to find PELD</param>
        /// <returns>List of related PELD entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PELD> TryFindByLEAVE_CODE(string LEAVE_CODE)
        {
            IReadOnlyList<PELD> value;
            if (Index_LEAVE_CODE.Value.TryGetValue(LEAVE_CODE, out value))
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
