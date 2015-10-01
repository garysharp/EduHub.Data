using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Routes Data Set
    /// </summary>
    public sealed class TRPROUTDataSet : SetBase<TRPROUT>
    {
        private Lazy<Dictionary<int, TRPROUT>> ROUTE_IDIndex;

        internal TRPROUTDataSet(EduHubContext Context)
            : base(Context)
        {
            ROUTE_IDIndex = new Lazy<Dictionary<int, TRPROUT>>(() => this.ToDictionary(e => e.ROUTE_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TRPROUT"; } }

        /// <summary>
        /// Find TRPROUT by ROUTE_ID key field
        /// </summary>
        /// <param name="Key">ROUTE_ID value used to find TRPROUT</param>
        /// <returns>Related TRPROUT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ROUTE_ID value didn't match any TRPROUT entities</exception>
        public TRPROUT FindByROUTE_ID(int Key)
        {
            TRPROUT result;
            if (ROUTE_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TRPROUT by ROUTE_ID key field
        /// </summary>
        /// <param name="Key">ROUTE_ID value used to find TRPROUT</param>
        /// <param name="Value">Related TRPROUT entity</param>
        /// <returns>True if the TRPROUT entity is found</returns>
        public bool TryFindByROUTE_ID(int Key, out TRPROUT Value)
        {
            return ROUTE_IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TRPROUT by ROUTE_ID key field
        /// </summary>
        /// <param name="Key">ROUTE_ID value used to find TRPROUT</param>
        /// <returns>Related TRPROUT entity, or null if not found</returns>
        public TRPROUT TryFindByROUTE_ID(int Key)
        {
            TRPROUT result;
            if (ROUTE_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TRPROUT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TRPROUT" /> fields for each CSV column header</returns>
        protected override Action<TRPROUT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TRPROUT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROUTE_ID":
                        mapper[i] = (e, v) => e.ROUTE_ID = int.Parse(v);
                        break;
                    case "ROUTE_NAME":
                        mapper[i] = (e, v) => e.ROUTE_NAME = v;
                        break;
                    case "TRANSPORT_MODE_ID":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRANSPORT_COMPANY_ID":
                        mapper[i] = (e, v) => e.TRANSPORT_COMPANY_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ROUTE_CONTRACT_NO":
                        mapper[i] = (e, v) => e.ROUTE_CONTRACT_NO = v;
                        break;
                    case "CONTACT1_FIRST_NAME":
                        mapper[i] = (e, v) => e.CONTACT1_FIRST_NAME = v;
                        break;
                    case "CONTACT1_LAST_NAME":
                        mapper[i] = (e, v) => e.CONTACT1_LAST_NAME = v;
                        break;
                    case "CONTACT1_PHONE":
                        mapper[i] = (e, v) => e.CONTACT1_PHONE = v;
                        break;
                    case "CONTACT2_FIRST_NAME":
                        mapper[i] = (e, v) => e.CONTACT2_FIRST_NAME = v;
                        break;
                    case "CONTACT2_LAST_NAME":
                        mapper[i] = (e, v) => e.CONTACT2_LAST_NAME = v;
                        break;
                    case "CONTACT2_PHONE":
                        mapper[i] = (e, v) => e.CONTACT2_PHONE = v;
                        break;
                    case "AM_SETDOWN_TIME":
                        mapper[i] = (e, v) => e.AM_SETDOWN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_PICKUP_TIME":
                        mapper[i] = (e, v) => e.PM_PICKUP_TIME = v == null ? (short?)null : short.Parse(v);
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
