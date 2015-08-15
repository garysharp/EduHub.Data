using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Data deleted from DataMirror monitored tables Data Set
    /// </summary>
    public sealed class KDELETE_DataSet : SetBase<KDELETE_Entity>
    {
        private Lazy<Dictionary<int, KDELETE_Entity>> ID_Index;

        internal KDELETE_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, KDELETE_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KDELETE"; } }

        /// <summary>
        /// Find KDELETE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any KDELETE entities</exception>
        public KDELETE_Entity FindByID(int Key)
        {
            KDELETE_Entity result;
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
        /// Attempt to find KDELETE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find KDELETE</param>
        /// <param name="Value">Related KDELETE entity</param>
        /// <returns>True if the KDELETE Entity is found</returns>
        public bool TryFindByID(int Key, out KDELETE_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KDELETE by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find KDELETE</param>
        /// <returns>Related KDELETE entity, or null if not found</returns>
        public KDELETE_Entity TryFindByID(int Key)
        {
            KDELETE_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KDELETE_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KDELETE_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TABLENAME":
                        mapper[i] = (e, v) => e.TABLENAME = v;
                        break;
                    case "IDVALUE":
                        mapper[i] = (e, v) => e.IDVALUE = v;
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
