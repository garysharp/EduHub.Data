using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Class Sizes Validation Type Data Set
    /// </summary>
    public sealed class SCEN_CVTDataSet : SetBase<SCEN_CVT>
    {
        private Lazy<Dictionary<int, SCEN_CVT>> IDIndex;

        internal SCEN_CVTDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_CVT>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_CVT"; } }

        /// <summary>
        /// Find SCEN_CVT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_CVT</param>
        /// <returns>Related SCEN_CVT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_CVT entities</exception>
        public SCEN_CVT FindByID(int Key)
        {
            SCEN_CVT result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCEN_CVT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_CVT</param>
        /// <param name="Value">Related SCEN_CVT entity</param>
        /// <returns>True if the SCEN_CVT Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_CVT Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_CVT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_CVT</param>
        /// <returns>Related SCEN_CVT entity, or null if not found</returns>
        public SCEN_CVT TryFindByID(int Key)
        {
            SCEN_CVT result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_CVT, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_CVT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "VCODE":
                        mapper[i] = (e, v) => e.VCODE = v;
                        break;
                    case "VALIDATIONMESSAGE":
                        mapper[i] = (e, v) => e.VALIDATIONMESSAGE = v;
                        break;
                    case "WARNING":
                        mapper[i] = (e, v) => e.WARNING = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "DETAILEDMESSAGE":
                        mapper[i] = (e, v) => e.DETAILEDMESSAGE = v;
                        break;
                    case "CVT_TYPE":
                        mapper[i] = (e, v) => e.CVT_TYPE = v;
                        break;
                    case "COMMANDNAME":
                        mapper[i] = (e, v) => e.COMMANDNAME = v;
                        break;
                    case "ISENABLED":
                        mapper[i] = (e, v) => e.ISENABLED = v;
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
