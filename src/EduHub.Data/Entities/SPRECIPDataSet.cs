using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPRECIPDataSet : SetBase<SPRECIP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPRECIP"; } }

        internal SPRECIPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<int, IReadOnlyList<SPRECIP>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPRECIP>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPRECIP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPRECIP" /> fields for each CSV column header</returns>
        protected override Action<SPRECIP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPRECIP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = int.Parse(v);
                        break;
                    case "RECIPIENT_TABLE":
                        mapper[i] = (e, v) => e.RECIPIENT_TABLE = v;
                        break;
                    case "RECIPIENT_KEY":
                        mapper[i] = (e, v) => e.RECIPIENT_KEY = v;
                        break;
                    case "RECIPIENT_NUMBER":
                        mapper[i] = (e, v) => e.RECIPIENT_NUMBER = v;
                        break;
                    case "READ_RECEIPT":
                        mapper[i] = (e, v) => e.READ_RECEIPT = v;
                        break;
                    case "SOURCE_TABLE":
                        mapper[i] = (e, v) => e.SOURCE_TABLE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "STATUS_MESSAGE":
                        mapper[i] = (e, v) => e.STATUS_MESSAGE = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DELIVERED_DATE":
                        mapper[i] = (e, v) => e.DELIVERED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MESSAGEID":
                        mapper[i] = (e, v) => e.MESSAGEID = v == null ? (int?)null : int.Parse(v);
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

        private Lazy<Dictionary<int, IReadOnlyList<SPRECIP>>> Index_CODE;
        private Lazy<Dictionary<int, SPRECIP>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <returns>List of related SPRECIP entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPRECIP> FindByCODE(int CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <param name="Value">List of related SPRECIP entities</param>
        /// <returns>True if the list of related SPRECIP entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(int CODE, out IReadOnlyList<SPRECIP> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPRECIP by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPRECIP</param>
        /// <returns>List of related SPRECIP entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPRECIP> TryFindByCODE(int CODE)
        {
            IReadOnlyList<SPRECIP> value;
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
        /// Find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <returns>Related SPRECIP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPRECIP FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <param name="Value">Related SPRECIP entity</param>
        /// <returns>True if the related SPRECIP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPRECIP Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPRECIP by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPRECIP</param>
        /// <returns>Related SPRECIP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPRECIP TryFindByTID(int TID)
        {
            SPRECIP value;
            if (Index_TID.Value.TryGetValue(TID, out value))
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
