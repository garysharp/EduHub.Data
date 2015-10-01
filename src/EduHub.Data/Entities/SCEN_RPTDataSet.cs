using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Report Usage Metadata Data Set
    /// </summary>
    public sealed class SCEN_RPTDataSet : SetBase<SCEN_RPT>
    {
        private Lazy<Dictionary<int, SCEN_RPT>> IDIndex;

        internal SCEN_RPTDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_RPT>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_RPT"; } }

        /// <summary>
        /// Find SCEN_RPT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_RPT entities</exception>
        public SCEN_RPT FindByID(int Key)
        {
            SCEN_RPT result;
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
        /// Attempt to find SCEN_RPT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RPT</param>
        /// <param name="Value">Related SCEN_RPT entity</param>
        /// <returns>True if the SCEN_RPT entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_RPT Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity, or null if not found</returns>
        public SCEN_RPT TryFindByID(int Key)
        {
            SCEN_RPT result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_RPT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_RPT" /> fields for each CSV column header</returns>
        protected override Action<SCEN_RPT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_RPT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "PROG":
                        mapper[i] = (e, v) => e.PROG = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "REQUIREDPRINCIPALFIELD":
                        mapper[i] = (e, v) => e.REQUIREDPRINCIPALFIELD = v;
                        break;
                    case "ISPRIMARY":
                        mapper[i] = (e, v) => e.ISPRIMARY = v;
                        break;
                    case "ISPRIMARYSECONDARY":
                        mapper[i] = (e, v) => e.ISPRIMARYSECONDARY = v;
                        break;
                    case "ISSECONDARY":
                        mapper[i] = (e, v) => e.ISSECONDARY = v;
                        break;
                    case "ISLANGUAGE":
                        mapper[i] = (e, v) => e.ISLANGUAGE = v;
                        break;
                    case "ISSPECIAL":
                        mapper[i] = (e, v) => e.ISSPECIAL = v;
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
