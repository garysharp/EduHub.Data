using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Validation Type Data Data Set
    /// </summary>
    public sealed class SCEN_SVT_DataSet : SetBase<SCEN_SVT_Entity>
    {
        private Lazy<Dictionary<int, SCEN_SVT_Entity>> ID_Index;

        internal SCEN_SVT_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_SVT_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCEN_SVT"; } }

        /// <summary>
        /// Find SCEN_SVT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_SVT</param>
        /// <returns>Related SCEN_SVT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_SVT entities</exception>
        public SCEN_SVT_Entity FindByID(int Key)
        {
            SCEN_SVT_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCEN_SVT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_SVT</param>
        /// <param name="Value">Related SCEN_SVT entity</param>
        /// <returns>True if the SCEN_SVT Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_SVT_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_SVT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_SVT</param>
        /// <returns>Related SCEN_SVT entity, or null if not found</returns>
        public SCEN_SVT_Entity TryFindByID(int Key)
        {
            SCEN_SVT_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_SVT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_SVT_Entity, string>[Headers.Count];

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
                    case "FIELDS":
                        mapper[i] = (e, v) => e.FIELDS = v;
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
