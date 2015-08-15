using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Validation Data Data Set
    /// </summary>
    public sealed class SCEN_STV_DataSet : SetBase<SCEN_STV_Entity>
    {
        private Lazy<Dictionary<int, SCEN_STV_Entity>> ID_Index;

        internal SCEN_STV_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_STV_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCEN_STV"; } }

        /// <summary>
        /// Find SCEN_STV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STV</param>
        /// <returns>Related SCEN_STV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_STV entities</exception>
        public SCEN_STV_Entity FindByID(int Key)
        {
            SCEN_STV_Entity result;
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
        /// Attempt to find SCEN_STV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STV</param>
        /// <param name="Value">Related SCEN_STV entity</param>
        /// <returns>True if the SCEN_STV Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_STV_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_STV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STV</param>
        /// <returns>Related SCEN_STV entity, or null if not found</returns>
        public SCEN_STV_Entity TryFindByID(int Key)
        {
            SCEN_STV_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_STV_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_STV_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ID_STUDENTVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_STUDENTVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FIELDVALUES":
                        mapper[i] = (e, v) => e.FIELDVALUES = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
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
