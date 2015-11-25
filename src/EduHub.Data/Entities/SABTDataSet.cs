using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Billing Template Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SABTDataSet : SetBase<SABT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SABT"; } }

        internal SABTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SABTKEY = new Lazy<Dictionary<string, IReadOnlyList<SABT>>>(() => this.ToGroupedDictionary(i => i.SABTKEY));
            Index_TID = new Lazy<Dictionary<int, SABT>>(() => this.ToDictionary(i => i.TID));
            Index_FEE_CODE = new Lazy<NullDictionary<string, IReadOnlyList<SABT>>>(() => this.ToGroupedNullDictionary(i => i.FEE_CODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SABT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SABT" /> fields for each CSV column header</returns>
        protected override Action<SABT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SABT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SABTKEY":
                        mapper[i] = (e, v) => e.SABTKEY = v;
                        break;
                    case "LINKKEY":
                        mapper[i] = (e, v) => e.LINKKEY = v;
                        break;
                    case "FEE_CODE":
                        mapper[i] = (e, v) => e.FEE_CODE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<SABT>>> Index_SABTKEY;
        private Lazy<Dictionary<int, SABT>> Index_TID;
        private Lazy<NullDictionary<string, IReadOnlyList<SABT>>> Index_FEE_CODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <returns>List of related SABT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> FindBySABTKEY(string SABTKEY)
        {
            return Index_SABTKEY.Value[SABTKEY];
        }

        /// <summary>
        /// Attempt to find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <param name="Value">List of related SABT entities</param>
        /// <returns>True if the list of related SABT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySABTKEY(string SABTKEY, out IReadOnlyList<SABT> Value)
        {
            return Index_SABTKEY.Value.TryGetValue(SABTKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by SABTKEY field
        /// </summary>
        /// <param name="SABTKEY">SABTKEY value used to find SABT</param>
        /// <returns>List of related SABT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> TryFindBySABTKEY(string SABTKEY)
        {
            IReadOnlyList<SABT> value;
            if (Index_SABTKEY.Value.TryGetValue(SABTKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <returns>Related SABT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SABT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <param name="Value">Related SABT entity</param>
        /// <returns>True if the related SABT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SABT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SABT</param>
        /// <returns>Related SABT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SABT TryFindByTID(int TID)
        {
            SABT value;
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
        /// Find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <returns>List of related SABT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> FindByFEE_CODE(string FEE_CODE)
        {
            return Index_FEE_CODE.Value[FEE_CODE];
        }

        /// <summary>
        /// Attempt to find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <param name="Value">List of related SABT entities</param>
        /// <returns>True if the list of related SABT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFEE_CODE(string FEE_CODE, out IReadOnlyList<SABT> Value)
        {
            return Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SABT by FEE_CODE field
        /// </summary>
        /// <param name="FEE_CODE">FEE_CODE value used to find SABT</param>
        /// <returns>List of related SABT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SABT> TryFindByFEE_CODE(string FEE_CODE)
        {
            IReadOnlyList<SABT> value;
            if (Index_FEE_CODE.Value.TryGetValue(FEE_CODE, out value))
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
