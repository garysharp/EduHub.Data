using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Application Message Data Data Set
    /// </summary>
    public sealed class SCEN_APPDataSet : SetBase<SCEN_APP>
    {
        private Lazy<Dictionary<int, SCEN_APP>> IDIndex;

        internal SCEN_APPDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_APP>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_APP"; } }

        /// <summary>
        /// Find SCEN_APP by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_APP</param>
        /// <returns>Related SCEN_APP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_APP entities</exception>
        public SCEN_APP FindByID(int Key)
        {
            SCEN_APP result;
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
        /// Attempt to find SCEN_APP by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_APP</param>
        /// <param name="Value">Related SCEN_APP entity</param>
        /// <returns>True if the SCEN_APP entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_APP Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_APP by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_APP</param>
        /// <returns>Related SCEN_APP entity, or null if not found</returns>
        public SCEN_APP TryFindByID(int Key)
        {
            SCEN_APP result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_APP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_APP" /> fields for each CSV column header</returns>
        protected override Action<SCEN_APP, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_APP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ITEMNAME":
                        mapper[i] = (e, v) => e.ITEMNAME = v;
                        break;
                    case "ITEMVALUE":
                        mapper[i] = (e, v) => e.ITEMVALUE = v;
                        break;
                    case "ITEMTYPE":
                        mapper[i] = (e, v) => e.ITEMTYPE = v;
                        break;
                    case "ITEMMINITYPE":
                        mapper[i] = (e, v) => e.ITEMMINITYPE = v;
                        break;
                    case "ITEMCOMMENTS":
                        mapper[i] = (e, v) => e.ITEMCOMMENTS = v;
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
