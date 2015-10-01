using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Company Data Set
    /// </summary>
    public sealed class KTRCMPDataSet : SetBase<KTRCMP>
    {
        private Lazy<Dictionary<int, KTRCMP>> COMPANY_IDIndex;

        internal KTRCMPDataSet(EduHubContext Context)
            : base(Context)
        {
            COMPANY_IDIndex = new Lazy<Dictionary<int, KTRCMP>>(() => this.ToDictionary(e => e.COMPANY_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KTRCMP"; } }

        /// <summary>
        /// Find KTRCMP by COMPANY_ID key field
        /// </summary>
        /// <param name="Key">COMPANY_ID value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">COMPANY_ID value didn't match any KTRCMP entities</exception>
        public KTRCMP FindByCOMPANY_ID(int Key)
        {
            KTRCMP result;
            if (COMPANY_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_ID key field
        /// </summary>
        /// <param name="Key">COMPANY_ID value used to find KTRCMP</param>
        /// <param name="Value">Related KTRCMP entity</param>
        /// <returns>True if the KTRCMP entity is found</returns>
        public bool TryFindByCOMPANY_ID(int Key, out KTRCMP Value)
        {
            return COMPANY_IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KTRCMP by COMPANY_ID key field
        /// </summary>
        /// <param name="Key">COMPANY_ID value used to find KTRCMP</param>
        /// <returns>Related KTRCMP entity, or null if not found</returns>
        public KTRCMP TryFindByCOMPANY_ID(int Key)
        {
            KTRCMP result;
            if (COMPANY_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
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
    }
}
