using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Routes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TRPROUTDataSet : SetBase<TRPROUT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TRPROUT"; } }

        internal TRPROUTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROUTE_ID = new Lazy<Dictionary<int, TRPROUT>>(() => this.ToDictionary(i => i.ROUTE_ID));
            Index_TRANSPORT_MODE_ID = new Lazy<NullDictionary<int?, IReadOnlyList<TRPROUT>>>(() => this.ToGroupedNullDictionary(i => i.TRANSPORT_MODE_ID));
            Index_TRANSPORT_COMPANY_ID = new Lazy<NullDictionary<int?, IReadOnlyList<TRPROUT>>>(() => this.ToGroupedNullDictionary(i => i.TRANSPORT_COMPANY_ID));
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

        #region Index Fields

        private Lazy<Dictionary<int, TRPROUT>> Index_ROUTE_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<TRPROUT>>> Index_TRANSPORT_MODE_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<TRPROUT>>> Index_TRANSPORT_COMPANY_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TRPROUT by ROUTE_ID field
        /// </summary>
        /// <param name="ROUTE_ID">ROUTE_ID value used to find TRPROUT</param>
        /// <returns>Related TRPROUT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRPROUT FindByROUTE_ID(int ROUTE_ID)
        {
            return Index_ROUTE_ID.Value[ROUTE_ID];
        }

        /// <summary>
        /// Attempt to find TRPROUT by ROUTE_ID field
        /// </summary>
        /// <param name="ROUTE_ID">ROUTE_ID value used to find TRPROUT</param>
        /// <param name="Value">Related TRPROUT entity</param>
        /// <returns>True if the related TRPROUT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROUTE_ID(int ROUTE_ID, out TRPROUT Value)
        {
            return Index_ROUTE_ID.Value.TryGetValue(ROUTE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TRPROUT by ROUTE_ID field
        /// </summary>
        /// <param name="ROUTE_ID">ROUTE_ID value used to find TRPROUT</param>
        /// <returns>Related TRPROUT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRPROUT TryFindByROUTE_ID(int ROUTE_ID)
        {
            TRPROUT value;
            if (Index_ROUTE_ID.Value.TryGetValue(ROUTE_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TRPROUT by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPROUT</param>
        /// <returns>List of related TRPROUT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TRPROUT> FindByTRANSPORT_MODE_ID(int? TRANSPORT_MODE_ID)
        {
            return Index_TRANSPORT_MODE_ID.Value[TRANSPORT_MODE_ID];
        }

        /// <summary>
        /// Attempt to find TRPROUT by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPROUT</param>
        /// <param name="Value">List of related TRPROUT entities</param>
        /// <returns>True if the list of related TRPROUT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRANSPORT_MODE_ID(int? TRANSPORT_MODE_ID, out IReadOnlyList<TRPROUT> Value)
        {
            return Index_TRANSPORT_MODE_ID.Value.TryGetValue(TRANSPORT_MODE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TRPROUT by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPROUT</param>
        /// <returns>List of related TRPROUT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TRPROUT> TryFindByTRANSPORT_MODE_ID(int? TRANSPORT_MODE_ID)
        {
            IReadOnlyList<TRPROUT> value;
            if (Index_TRANSPORT_MODE_ID.Value.TryGetValue(TRANSPORT_MODE_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TRPROUT by TRANSPORT_COMPANY_ID field
        /// </summary>
        /// <param name="TRANSPORT_COMPANY_ID">TRANSPORT_COMPANY_ID value used to find TRPROUT</param>
        /// <returns>List of related TRPROUT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TRPROUT> FindByTRANSPORT_COMPANY_ID(int? TRANSPORT_COMPANY_ID)
        {
            return Index_TRANSPORT_COMPANY_ID.Value[TRANSPORT_COMPANY_ID];
        }

        /// <summary>
        /// Attempt to find TRPROUT by TRANSPORT_COMPANY_ID field
        /// </summary>
        /// <param name="TRANSPORT_COMPANY_ID">TRANSPORT_COMPANY_ID value used to find TRPROUT</param>
        /// <param name="Value">List of related TRPROUT entities</param>
        /// <returns>True if the list of related TRPROUT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRANSPORT_COMPANY_ID(int? TRANSPORT_COMPANY_ID, out IReadOnlyList<TRPROUT> Value)
        {
            return Index_TRANSPORT_COMPANY_ID.Value.TryGetValue(TRANSPORT_COMPANY_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TRPROUT by TRANSPORT_COMPANY_ID field
        /// </summary>
        /// <param name="TRANSPORT_COMPANY_ID">TRANSPORT_COMPANY_ID value used to find TRPROUT</param>
        /// <returns>List of related TRPROUT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TRPROUT> TryFindByTRANSPORT_COMPANY_ID(int? TRANSPORT_COMPANY_ID)
        {
            IReadOnlyList<TRPROUT> value;
            if (Index_TRANSPORT_COMPANY_ID.Value.TryGetValue(TRANSPORT_COMPANY_ID, out value))
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
