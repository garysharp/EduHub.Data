using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Multiple Day Absences Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class STRADataSet : SetBase<STRA>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "STRA"; } }

        internal STRADataSet(EduHubContext Context)
            : base(Context)
        {
            Index_STKEY = new Lazy<Dictionary<string, IReadOnlyList<STRA>>>(() => this.ToGroupedDictionary(i => i.STKEY));
            Index_TID = new Lazy<Dictionary<int, STRA>>(() => this.ToDictionary(i => i.TID));
            Index_ABS_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<STRA>>>(() => this.ToGroupedNullDictionary(i => i.ABS_TYPE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="STRA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="STRA" /> fields for each CSV column header</returns>
        protected override Action<STRA, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<STRA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "START_AM_PM":
                        mapper[i] = (e, v) => e.START_AM_PM = v;
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_AM_PM":
                        mapper[i] = (e, v) => e.END_AM_PM = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "ABS_TYPE":
                        mapper[i] = (e, v) => e.ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "START_PERIOD":
                        mapper[i] = (e, v) => e.START_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "END_PERIOD":
                        mapper[i] = (e, v) => e.END_PERIOD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<STRA>>> Index_STKEY;
        private Lazy<Dictionary<int, STRA>> Index_TID;
        private Lazy<NullDictionary<short?, IReadOnlyList<STRA>>> Index_ABS_TYPE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <returns>List of related STRA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> FindBySTKEY(string STKEY)
        {
            return Index_STKEY.Value[STKEY];
        }

        /// <summary>
        /// Attempt to find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <param name="Value">List of related STRA entities</param>
        /// <returns>True if the list of related STRA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySTKEY(string STKEY, out IReadOnlyList<STRA> Value)
        {
            return Index_STKEY.Value.TryGetValue(STKEY, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by STKEY field
        /// </summary>
        /// <param name="STKEY">STKEY value used to find STRA</param>
        /// <returns>List of related STRA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> TryFindBySTKEY(string STKEY)
        {
            IReadOnlyList<STRA> value;
            if (Index_STKEY.Value.TryGetValue(STKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <returns>Related STRA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STRA FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <param name="Value">Related STRA entity</param>
        /// <returns>True if the related STRA entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out STRA Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by TID field
        /// </summary>
        /// <param name="TID">TID value used to find STRA</param>
        /// <returns>Related STRA entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public STRA TryFindByTID(int TID)
        {
            STRA value;
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
        /// Find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <returns>List of related STRA entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> FindByABS_TYPE(short? ABS_TYPE)
        {
            return Index_ABS_TYPE.Value[ABS_TYPE];
        }

        /// <summary>
        /// Attempt to find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <param name="Value">List of related STRA entities</param>
        /// <returns>True if the list of related STRA entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByABS_TYPE(short? ABS_TYPE, out IReadOnlyList<STRA> Value)
        {
            return Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find STRA by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find STRA</param>
        /// <returns>List of related STRA entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<STRA> TryFindByABS_TYPE(short? ABS_TYPE)
        {
            IReadOnlyList<STRA> value;
            if (Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out value))
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
