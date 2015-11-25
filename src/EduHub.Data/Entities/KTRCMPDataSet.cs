using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Company Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KTRCMPDataSet : SetBase<KTRCMP>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KTRCMP"; } }

        internal KTRCMPDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_COMPANY_ID = new Lazy<Dictionary<int, KTRCMP>>(() => this.ToDictionary(i => i.COMPANY_ID));
            Index_COMPANY_CODE = new Lazy<NullDictionary<string, KTRCMP>>(() => this.ToNullDictionary(i => i.COMPANY_CODE));
            Index_COMPANY_NAME = new Lazy<NullDictionary<string, KTRCMP>>(() => this.ToNullDictionary(i => i.COMPANY_NAME));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTRCMP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTRCMP" /> fields for each CSV column header</returns>
        protected override Action<KTRCMP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTRCMP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COMPANY_ID":
                        mapper[i] = (e, v) => e.COMPANY_ID = int.Parse(v);
                        break;
                    case "COMPANY_CODE":
                        mapper[i] = (e, v) => e.COMPANY_CODE = v;
                        break;
                    case "COMPANY_NAME":
                        mapper[i] = (e, v) => e.COMPANY_NAME = v;
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "PHONE":
                        mapper[i] = (e, v) => e.PHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
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
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        #region Index Fields

        private Lazy<Dictionary<int, KTRCMP>> Index_COMPANY_ID;
        private Lazy<NullDictionary<string, KTRCMP>> Index_COMPANY_CODE;
        private Lazy<NullDictionary<string, KTRCMP>> Index_COMPANY_NAME;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_ID(int COMPANY_ID)
        {
            return Index_COMPANY_ID.Value[COMPANY_ID];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_ID(int COMPANY_ID, out KTRCMP Value)
        {
            return Index_COMPANY_ID.Value.TryGetValue(COMPANY_ID, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_ID field
        /// </summary>
        /// <param name="COMPANY_ID">COMPANY_ID value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_ID(int COMPANY_ID)
        {
            KTRCMP value;
            if (Index_COMPANY_ID.Value.TryGetValue(COMPANY_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_CODE(string COMPANY_CODE)
        {
            return Index_COMPANY_CODE.Value[COMPANY_CODE];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_CODE(string COMPANY_CODE, out KTRCMP Value)
        {
            return Index_COMPANY_CODE.Value.TryGetValue(COMPANY_CODE, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_CODE field
        /// </summary>
        /// <param name="COMPANY_CODE">COMPANY_CODE value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_CODE(string COMPANY_CODE)
        {
            KTRCMP value;
            if (Index_COMPANY_CODE.Value.TryGetValue(COMPANY_CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP FindByCOMPANY_NAME(string COMPANY_NAME)
        {
            return Index_COMPANY_NAME.Value[COMPANY_NAME];
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the related KTRCMP entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCOMPANY_NAME(string COMPANY_NAME, out KTRCMP Value)
        {
            return Index_COMPANY_NAME.Value.TryGetValue(COMPANY_NAME, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_NAME field
        /// </summary>
        /// <param name="COMPANY_NAME">COMPANY_NAME value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KTRCMP TryFindByCOMPANY_NAME(string COMPANY_NAME)
        {
            KTRCMP value;
            if (Index_COMPANY_NAME.Value.TryGetValue(COMPANY_NAME, out value))
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
