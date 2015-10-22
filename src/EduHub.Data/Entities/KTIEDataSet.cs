using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Timetable Import Errors Data Set
    /// </summary>
    public sealed partial class KTIEDataSet : SetBase<KTIE>
    {
        private Lazy<Dictionary<int, KTIE>> RECORD_IDIndex;


        internal KTIEDataSet(EduHubContext Context)
            : base(Context)
        {
            RECORD_IDIndex = new Lazy<Dictionary<int, KTIE>>(() => this.ToDictionary(e => e.RECORD_ID));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KTIE"; } }

        /// <summary>
        /// Find KTIE by RECORD_ID key field
        /// </summary>
        /// <param name="Key">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">RECORD_ID value didn't match any KTIE entities</exception>
        public KTIE FindByRECORD_ID(int Key)
        {
            KTIE result;
            if (RECORD_IDIndex.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the KTIE entity is found</returns>
        public bool TryFindByRECORD_ID(int Key, out KTIE Value)
        {
            return RECORD_IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KTIE by RECORD_ID key field
        /// </summary>
        /// <param name="Key">RECORD_ID value used to find KTIE</param>
        /// <returns>Related KTIE entity, or null if not found</returns>
        public KTIE TryFindByRECORD_ID(int Key)
        {
            KTIE result;
            if (RECORD_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KTIE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KTIE" /> fields for each CSV column header</returns>
        protected override Action<KTIE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KTIE, string>[Headers.Count];

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
