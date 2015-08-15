using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Import Errors Data Set
    /// </summary>
    public sealed class KTIE_DataSet : SetBase<KTIE_Entity>
    {
        private Lazy<Dictionary<int, KTIE_Entity>> RECORD_ID_Index;

        internal KTIE_DataSet(EduHubContext Context)
            : base(Context)
        {
            RECORD_ID_Index = new Lazy<Dictionary<int, KTIE_Entity>>(() => this.ToDictionary(e => e.RECORD_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KTIE"; } }

        /// <summary>
        /// Find KTIE by RECORD_ID key field
        /// </summary>
        /// <param name="Key">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">RECORD_ID value didn't match any KTIE entities</exception>
        public KTIE_Entity FindByRECORD_ID(int Key)
        {
            KTIE_Entity result;
            if (RECORD_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID key field
        /// </summary>
        /// <param name="Key">RECORD_ID value used to find KTIE</param>
        /// <param name="Value">Related KTIE entity</param>
        /// <returns>True if the KTIE Entity is found</returns>
        public bool TryFindByRECORD_ID(int Key, out KTIE_Entity Value)
        {
            return RECORD_ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID key field
        /// </summary>
        /// <param name="Key">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity, or null if not found</returns>
        public KTIE_Entity TryFindByRECORD_ID(int Key)
        {
            KTIE_Entity result;
            if (RECORD_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KTIE_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KTIE_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "RECORD_ID":
                        mapper[i] = (e, v) => e.RECORD_ID = int.Parse(v);
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "ERROR_TEXT":
                        mapper[i] = (e, v) => e.ERROR_TEXT = v;
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
