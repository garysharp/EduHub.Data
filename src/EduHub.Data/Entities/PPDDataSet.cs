using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// PAYG Payer Details Data Set
    /// </summary>
    public sealed class PPDDataSet : SetBase<PPD>
    {
        private Lazy<Dictionary<string, PPD>> PPDKEYIndex;

        internal PPDDataSet(EduHubContext Context)
            : base(Context)
        {
            PPDKEYIndex = new Lazy<Dictionary<string, PPD>>(() => this.ToDictionary(e => e.PPDKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PPD"; } }

        /// <summary>
        /// Find PPD by PPDKEY key field
        /// </summary>
        /// <param name="Key">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PPDKEY value didn't match any PPD entities</exception>
        public PPD FindByPPDKEY(string Key)
        {
            PPD result;
            if (PPDKEYIndex.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the PPD entity is found</returns>
        public bool TryFindByPPDKEY(string Key, out PPD Value)
        {
            return PPDKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PPD by PPDKEY key field
        /// </summary>
        /// <param name="Key">PPDKEY value used to find PPD</param>
        /// <returns>Related PPD entity, or null if not found</returns>
        public PPD TryFindByPPDKEY(string Key)
        {
            PPD result;
            if (PPDKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PPD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PPD" /> fields for each CSV column header</returns>
        protected override Action<PPD, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PPD, string>[Headers.Count];

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
