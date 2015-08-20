using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Schools Data Set
    /// </summary>
    public sealed class SKGSDataSet : SetBase<SKGS>
    {
        private Lazy<Dictionary<string, SKGS>> SCHOOLIndex;

        internal SKGSDataSet(EduHubContext Context)
            : base(Context)
        {
            SCHOOLIndex = new Lazy<Dictionary<string, SKGS>>(() => this.ToDictionary(e => e.SCHOOL));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SKGS"; } }

        /// <summary>
        /// Find SKGS by SCHOOL key field
        /// </summary>
        /// <param name="Key">SCHOOL value used to find SKGS</param>
        /// <returns>Related SKGS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCHOOL value didn't match any SKGS entities</exception>
        public SKGS FindBySCHOOL(string Key)
        {
            SKGS result;
            if (SCHOOLIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SKGS by SCHOOL key field
        /// </summary>
        /// <param name="Key">SCHOOL value used to find SKGS</param>
        /// <param name="Value">Related SKGS entity</param>
        /// <returns>True if the SKGS entity is found</returns>
        public bool TryFindBySCHOOL(string Key, out SKGS Value)
        {
            return SCHOOLIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SKGS by SCHOOL key field
        /// </summary>
        /// <param name="Key">SCHOOL value used to find SKGS</param>
        /// <returns>Related SKGS entity, or null if not found</returns>
        public SKGS TryFindBySCHOOL(string Key)
        {
            SKGS result;
            if (SCHOOLIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SKGS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SKGS" /> fields for each CSV column header</returns>
        protected override Action<SKGS, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SKGS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCHOOL":
                        mapper[i] = (e, v) => e.SCHOOL = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "SCHOOL_TYPE":
                        mapper[i] = (e, v) => e.SCHOOL_TYPE = v;
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "SCHOOL_ID":
                        mapper[i] = (e, v) => e.SCHOOL_ID = v;
                        break;
                    case "SCHOOL_NUMBER":
                        mapper[i] = (e, v) => e.SCHOOL_NUMBER = v;
                        break;
                    case "CAMPUS_TYPE":
                        mapper[i] = (e, v) => e.CAMPUS_TYPE = v;
                        break;
                    case "CAMPUS_NAME":
                        mapper[i] = (e, v) => e.CAMPUS_NAME = v;
                        break;
                    case "REGION":
                        mapper[i] = (e, v) => e.REGION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REGION_NAME":
                        mapper[i] = (e, v) => e.REGION_NAME = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "MAILING_ADDRESS01":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS01 = v;
                        break;
                    case "MAILING_ADDRESS02":
                        mapper[i] = (e, v) => e.MAILING_ADDRESS02 = v;
                        break;
                    case "MAILING_SUBURB":
                        mapper[i] = (e, v) => e.MAILING_SUBURB = v;
                        break;
                    case "MAILING_STATE":
                        mapper[i] = (e, v) => e.MAILING_STATE = v;
                        break;
                    case "MAILING_POSTCODE":
                        mapper[i] = (e, v) => e.MAILING_POSTCODE = v;
                        break;
                    case "DELIVERY_ADDRESS01":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS01 = v;
                        break;
                    case "DELIVERY_ADDRESS02":
                        mapper[i] = (e, v) => e.DELIVERY_ADDRESS02 = v;
                        break;
                    case "DELIVERY_SUBURB":
                        mapper[i] = (e, v) => e.DELIVERY_SUBURB = v;
                        break;
                    case "DELIVERY_STATE":
                        mapper[i] = (e, v) => e.DELIVERY_STATE = v;
                        break;
                    case "DELIVERY_POSTCODE":
                        mapper[i] = (e, v) => e.DELIVERY_POSTCODE = v;
                        break;
                    case "DELIVERY_TELEPHONE":
                        mapper[i] = (e, v) => e.DELIVERY_TELEPHONE = v;
                        break;
                    case "DELIVERY_FAX":
                        mapper[i] = (e, v) => e.DELIVERY_FAX = v;
                        break;
                    case "E_MAIL":
                        mapper[i] = (e, v) => e.E_MAIL = v;
                        break;
                    case "INTERNET_ADDRESS":
                        mapper[i] = (e, v) => e.INTERNET_ADDRESS = v;
                        break;
                    case "CASES21_RELEASE":
                        mapper[i] = (e, v) => e.CASES21_RELEASE = v;
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "SCH_PRINCIPAL_SALUTATION":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_SALUTATION = v;
                        break;
                    case "SCH_PRINCIPAL_FIRST_NAME":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_FIRST_NAME = v;
                        break;
                    case "SCH_PRINCIPAL_SURNAME":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_SURNAME = v;
                        break;
                    case "SCH_PRINCIPAL_TELEPHONE":
                        mapper[i] = (e, v) => e.SCH_PRINCIPAL_TELEPHONE = v;
                        break;
                    case "SALUTATION":
                        mapper[i] = (e, v) => e.SALUTATION = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "CLOSED":
                        mapper[i] = (e, v) => e.CLOSED = v;
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
    }
}
