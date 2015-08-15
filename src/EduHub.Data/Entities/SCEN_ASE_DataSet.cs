using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Student Excluded Data Data Set
    /// </summary>
    public sealed class SCEN_ASE_DataSet : SetBase<SCEN_ASE_Entity>
    {
        private Lazy<Dictionary<int, SCEN_ASE_Entity>> ID_Index;

        internal SCEN_ASE_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_ASE_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCEN_ASE"; } }

        /// <summary>
        /// Find SCEN_ASE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ASE</param>
        /// <returns>Related SCEN_ASE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_ASE entities</exception>
        public SCEN_ASE_Entity FindByID(int Key)
        {
            SCEN_ASE_Entity result;
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
        /// Attempt to find SCEN_ASE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ASE</param>
        /// <param name="Value">Related SCEN_ASE entity</param>
        /// <returns>True if the SCEN_ASE Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_ASE_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ASE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ASE</param>
        /// <returns>Related SCEN_ASE entity, or null if not found</returns>
        public SCEN_ASE_Entity TryFindByID(int Key)
        {
            SCEN_ASE_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_ASE_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_ASE_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ASE_TYPE":
                        mapper[i] = (e, v) => e.ASE_TYPE = v;
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
