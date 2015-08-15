using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Routes Data Set
    /// </summary>
    public sealed class TRPROUT_DataSet : SetBase<TRPROUT_Entity>
    {
        private Lazy<Dictionary<int, TRPROUT_Entity>> ROUTE_ID_Index;

        internal TRPROUT_DataSet(EduHubContext Context)
            : base(Context)
        {
            ROUTE_ID_Index = new Lazy<Dictionary<int, TRPROUT_Entity>>(() => this.ToDictionary(e => e.ROUTE_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "TRPROUT"; } }

        /// <summary>
        /// Find TRPROUT by ROUTE_ID key field
        /// </summary>
        /// <param name="Key">ROUTE_ID value used to find TRPROUT</param>
        /// <returns>Related TRPROUT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ROUTE_ID value didn't match any TRPROUT entities</exception>
        public TRPROUT_Entity FindByROUTE_ID(int Key)
        {
            TRPROUT_Entity result;
            if (ROUTE_ID_Index.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the TRPROUT Entity is found</returns>
        public bool TryFindByROUTE_ID(int Key, out TRPROUT_Entity Value)
        {
            return ROUTE_ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TRPROUT by ROUTE_ID key field
        /// </summary>
        /// <param name="Key">ROUTE_ID value used to find TRPROUT</param>
        /// <returns>Related TRPROUT entity, or null if not found</returns>
        public TRPROUT_Entity TryFindByROUTE_ID(int Key)
        {
            TRPROUT_Entity result;
            if (ROUTE_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<TRPROUT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TRPROUT_Entity, string>[Headers.Count];

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
