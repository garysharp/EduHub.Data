using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Student Excluded Data Data Set
    /// </summary>
    public sealed class SCEN_STE_DataSet : SetBase<SCEN_STE_Entity>
    {
        private Lazy<Dictionary<int, SCEN_STE_Entity>> ID_Index;

        internal SCEN_STE_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_STE_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCEN_STE"; } }

        /// <summary>
        /// Find SCEN_STE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STE</param>
        /// <returns>Related SCEN_STE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_STE entities</exception>
        public SCEN_STE_Entity FindByID(int Key)
        {
            SCEN_STE_Entity result;
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
        /// Attempt to find SCEN_STE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STE</param>
        /// <param name="Value">Related SCEN_STE entity</param>
        /// <returns>True if the SCEN_STE Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_STE_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_STE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_STE</param>
        /// <returns>Related SCEN_STE entity, or null if not found</returns>
        public SCEN_STE_Entity TryFindByID(int Key)
        {
            SCEN_STE_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_STE_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_STE_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STE_TYPE":
                        mapper[i] = (e, v) => e.STE_TYPE = v;
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
