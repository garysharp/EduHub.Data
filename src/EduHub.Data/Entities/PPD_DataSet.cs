using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payer Details Data Set
    /// </summary>
    public sealed class PPD_DataSet : SetBase<PPD_Entity>
    {
        private Lazy<Dictionary<string, PPD_Entity>> PPDKEY_Index;

        internal PPD_DataSet(EduHubContext Context)
            : base(Context)
        {
            PPDKEY_Index = new Lazy<Dictionary<string, PPD_Entity>>(() => this.ToDictionary(e => e.PPDKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "PPD"; } }

        /// <summary>
        /// Find PPD by PPDKEY key field
        /// </summary>
        /// <param name="Key">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PPDKEY value didn't match any PPD entities</exception>
        public PPD_Entity FindByPPDKEY(string Key)
        {
            PPD_Entity result;
            if (PPDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY key field
        /// </summary>
        /// <param name="Key">PPDKEY value used to find PPD</param>
        /// <param name="Value">Related PPD entity</param>
        /// <returns>True if the PPD Entity is found</returns>
        public bool TryFindByPPDKEY(string Key, out PPD_Entity Value)
        {
            return PPDKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY key field
        /// </summary>
        /// <param name="Key">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity, or null if not found</returns>
        public PPD_Entity TryFindByPPDKEY(string Key)
        {
            PPD_Entity result;
            if (PPDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<PPD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PPD_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABN_OR_WPN":
                        mapper[i] = (e, v) => e.ABN_OR_WPN = v;
                        break;
                    case "NUMBER_TYPE":
                        mapper[i] = (e, v) => e.NUMBER_TYPE = v;
                        break;
                    case "BRANCH_NUMBER":
                        mapper[i] = (e, v) => e.BRANCH_NUMBER = v;
                        break;
                    case "FINANCIAL_YEAR":
                        mapper[i] = (e, v) => e.FINANCIAL_YEAR = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "TRADING_NAME":
                        mapper[i] = (e, v) => e.TRADING_NAME = v;
                        break;
                    case "L1_ADDRESS":
                        mapper[i] = (e, v) => e.L1_ADDRESS = v;
                        break;
                    case "L2_ADDRESS":
                        mapper[i] = (e, v) => e.L2_ADDRESS = v;
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
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "CONTACT_NAME":
                        mapper[i] = (e, v) => e.CONTACT_NAME = v;
                        break;
                    case "PHONE":
                        mapper[i] = (e, v) => e.PHONE = v;
                        break;
                    case "FACSIMILE":
                        mapper[i] = (e, v) => e.FACSIMILE = v;
                        break;
                    case "SIGNATURE":
                        mapper[i] = (e, v) => e.SIGNATURE = v;
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
