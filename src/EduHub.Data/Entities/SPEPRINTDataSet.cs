using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report file audit Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SPEPRINTDataSet : SetBase<SPEPRINT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPEPRINT"; } }

        internal SPEPRINTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<SPEPRINT>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_TID = new Lazy<Dictionary<int, SPEPRINT>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPEPRINT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPEPRINT" /> fields for each CSV column header</returns>
        protected override Action<SPEPRINT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPEPRINT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PRINT_DATE":
                        mapper[i] = (e, v) => e.PRINT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PRINT_BY":
                        mapper[i] = (e, v) => e.PRINT_BY = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SEND_BY":
                        mapper[i] = (e, v) => e.SEND_BY = v;
                        break;
                    case "ENTITY_TABLE":
                        mapper[i] = (e, v) => e.ENTITY_TABLE = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
                        break;
                    case "COPY_ADDRESS":
                        mapper[i] = (e, v) => e.COPY_ADDRESS = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "ATTACHMENT_PATH":
                        mapper[i] = (e, v) => e.ATTACHMENT_PATH = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "DISPLAY":
                        mapper[i] = (e, v) => e.DISPLAY = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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

        private Lazy<Dictionary<string, IReadOnlyList<SPEPRINT>>> Index_CODE;
        private Lazy<Dictionary<int, SPEPRINT>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <returns>List of related SPEPRINT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEPRINT> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <param name="Value">List of related SPEPRINT entities</param>
        /// <returns>True if the list of related SPEPRINT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<SPEPRINT> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find SPEPRINT by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find SPEPRINT</param>
        /// <returns>List of related SPEPRINT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SPEPRINT> TryFindByCODE(string CODE)
        {
            IReadOnlyList<SPEPRINT> value;
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
        /// Find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <returns>Related SPEPRINT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEPRINT FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <param name="Value">Related SPEPRINT entity</param>
        /// <returns>True if the related SPEPRINT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SPEPRINT Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SPEPRINT by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SPEPRINT</param>
        /// <returns>Related SPEPRINT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SPEPRINT TryFindByTID(int TID)
        {
            SPEPRINT value;
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
