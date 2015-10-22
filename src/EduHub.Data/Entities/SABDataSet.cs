using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees - Billing Templates Data Set
    /// </summary>
    public sealed partial class SABDataSet : SetBase<SAB>
    {
        private Lazy<Dictionary<string, SAB>> SABKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SABT>>> SABT_SABTKEYForeignIndex;

        internal SABDataSet(EduHubContext Context)
            : base(Context)
        {
            SABKEYIndex = new Lazy<Dictionary<string, SAB>>(() => this.ToDictionary(e => e.SABKEY));

            SABT_SABTKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SABT>>>(() =>
                    Context.SABT
                          .Where(e => e.SABTKEY != null)
                          .GroupBy(e => e.SABTKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SABT>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAB"; } }

        /// <summary>
        /// Find SAB by SABKEY key field
        /// </summary>
        /// <param name="Key">SABKEY value used to find SAB</param>
        /// <returns>Related SAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SABKEY value didn't match any SAB entities</exception>
        public SAB FindBySABKEY(string Key)
        {
            SAB result;
            if (SABKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SAB by SABKEY key field
        /// </summary>
        /// <param name="Key">SABKEY value used to find SAB</param>
        /// <param name="Value">Related SAB entity</param>
        /// <returns>True if the SAB entity is found</returns>
        public bool TryFindBySABKEY(string Key, out SAB Value)
        {
            return SABKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SAB by SABKEY key field
        /// </summary>
        /// <param name="Key">SABKEY value used to find SAB</param>
        /// <returns>Related SAB entity, or null if not found</returns>
        public SAB TryFindBySABKEY(string Key)
        {
            SAB result;
            if (SABKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SABT (Billing Template Transactions) entities by [SABT.SABTKEY]-&gt;[SAB.SABKEY]
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SABT entities</param>
        /// <returns>A list of related SABT entities</returns>
        public IReadOnlyList<SABT> FindSABTBySABTKEY(string SABKEY)
        {
            IReadOnlyList<SABT> result;
            if (SABT_SABTKEYForeignIndex.Value.TryGetValue(SABKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SABT>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SABT entities by [SABT.SABTKEY]-&gt;[SAB.SABKEY]
        /// </summary>
        /// <param name="SABKEY">SABKEY value used to find SABT entities</param>
        /// <param name="Value">A list of related SABT entities</param>
        /// <returns>True if any SABT entities are found</returns>
        public bool TryFindSABTBySABTKEY(string SABKEY, out IReadOnlyList<SABT> Value)
        {
            return SABT_SABTKEYForeignIndex.Value.TryGetValue(SABKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAB" /> fields for each CSV column header</returns>
        protected override Action<SAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SABKEY":
                        mapper[i] = (e, v) => e.SABKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "BILL_TYPE":
                        mapper[i] = (e, v) => e.BILL_TYPE = v;
                        break;
                    case "FROM_CLASS":
                        mapper[i] = (e, v) => e.FROM_CLASS = v;
                        break;
                    case "TO_CLASS":
                        mapper[i] = (e, v) => e.TO_CLASS = v;
                        break;
                    case "FROM_YEAR":
                        mapper[i] = (e, v) => e.FROM_YEAR = v;
                        break;
                    case "TO_YEAR":
                        mapper[i] = (e, v) => e.TO_YEAR = v;
                        break;
                    case "RES_STATUS":
                        mapper[i] = (e, v) => e.RES_STATUS = v;
                        break;
                    case "FEE_CODE_1ST":
                        mapper[i] = (e, v) => e.FEE_CODE_1ST = v;
                        break;
                    case "FEE_CODE_2ND":
                        mapper[i] = (e, v) => e.FEE_CODE_2ND = v;
                        break;
                    case "FEE_CODE_3RD":
                        mapper[i] = (e, v) => e.FEE_CODE_3RD = v;
                        break;
                    case "FEE_CODE_4TH":
                        mapper[i] = (e, v) => e.FEE_CODE_4TH = v;
                        break;
                    case "FEE_CODE_KG":
                        mapper[i] = (e, v) => e.FEE_CODE_KG = v;
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
