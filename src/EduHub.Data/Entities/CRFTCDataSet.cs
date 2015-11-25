using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Creditor Fuel Tax Credits Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRFTCDataSet : SetBase<CRFTC>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "CRFTC"; } }

        internal CRFTCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<CRFTC>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, CRFTC>>(() => this.ToDictionary(i => i.TID));
            Index_TRREF = new Lazy<NullDictionary<string, IReadOnlyList<CRFTC>>>(() => this.ToGroupedNullDictionary(i => i.TRREF));
            Index_FTC_CODE = new Lazy<NullDictionary<string, IReadOnlyList<CRFTC>>>(() => this.ToGroupedNullDictionary(i => i.FTC_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CRFTC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CRFTC" /> fields for each CSV column header</returns>
        protected override Action<CRFTC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CRFTC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "FUEL_TYPE":
                        mapper[i] = (e, v) => e.FUEL_TYPE = v;
                        break;
                    case "FTC_CODE":
                        mapper[i] = (e, v) => e.FTC_CODE = v;
                        break;
                    case "TOT_LITRES":
                        mapper[i] = (e, v) => e.TOT_LITRES = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_PERC":
                        mapper[i] = (e, v) => e.CLAIM_PERC = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_LITRES":
                        mapper[i] = (e, v) => e.CLAIM_LITRES = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CLAIM_AMOUNT":
                        mapper[i] = (e, v) => e.CLAIM_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CLAIM_PERIOD":
                        mapper[i] = (e, v) => e.CLAIM_PERIOD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<CRFTC>>> Index_CODE;
        private Lazy<Dictionary<int, CRFTC>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<CRFTC>>> Index_TRREF;
        private Lazy<NullDictionary<string, IReadOnlyList<CRFTC>>> Index_FTC_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CRFTC by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find CRFTC by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRFTC</param>
        /// <param name="Value">List of related CRFTC entities</param>
        /// <returns>True if the list of related CRFTC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<CRFTC> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find CRFTC by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> TryFindByCODE(string CODE)
        {
            IReadOnlyList<CRFTC> value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRFTC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRFTC</param>
        /// <returns>Related CRFTC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRFTC FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find CRFTC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRFTC</param>
        /// <param name="Value">Related CRFTC entity</param>
        /// <returns>True if the related CRFTC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out CRFTC Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find CRFTC by TID field
        /// </summary>
        /// <param name="TID">TID value used to find CRFTC</param>
        /// <returns>Related CRFTC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CRFTC TryFindByTID(int TID)
        {
            CRFTC value;
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
        /// Find CRFTC by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> FindByTRREF(string TRREF)
        {
            return Index_TRREF.Value[TRREF];
        }

        /// <summary>
        /// Attempt to find CRFTC by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRFTC</param>
        /// <param name="Value">List of related CRFTC entities</param>
        /// <returns>True if the list of related CRFTC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRREF(string TRREF, out IReadOnlyList<CRFTC> Value)
        {
            return Index_TRREF.Value.TryGetValue(TRREF, out Value);
        }

        /// <summary>
        /// Attempt to find CRFTC by TRREF field
        /// </summary>
        /// <param name="TRREF">TRREF value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> TryFindByTRREF(string TRREF)
        {
            IReadOnlyList<CRFTC> value;
            if (Index_TRREF.Value.TryGetValue(TRREF, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CRFTC by FTC_CODE field
        /// </summary>
        /// <param name="FTC_CODE">FTC_CODE value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> FindByFTC_CODE(string FTC_CODE)
        {
            return Index_FTC_CODE.Value[FTC_CODE];
        }

        /// <summary>
        /// Attempt to find CRFTC by FTC_CODE field
        /// </summary>
        /// <param name="FTC_CODE">FTC_CODE value used to find CRFTC</param>
        /// <param name="Value">List of related CRFTC entities</param>
        /// <returns>True if the list of related CRFTC entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFTC_CODE(string FTC_CODE, out IReadOnlyList<CRFTC> Value)
        {
            return Index_FTC_CODE.Value.TryGetValue(FTC_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find CRFTC by FTC_CODE field
        /// </summary>
        /// <param name="FTC_CODE">FTC_CODE value used to find CRFTC</param>
        /// <returns>List of related CRFTC entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CRFTC> TryFindByFTC_CODE(string FTC_CODE)
        {
            IReadOnlyList<CRFTC> value;
            if (Index_FTC_CODE.Value.TryGetValue(FTC_CODE, out value))
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
