using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Notes Data Set
    /// </summary>
    public sealed partial class KNDataSet : SetBase<KN>
    {
        private Lazy<Dictionary<string, KN>> NOTE_IDIndex;


        internal KNDataSet(EduHubContext Context)
            : base(Context)
        {
            NOTE_IDIndex = new Lazy<Dictionary<string, KN>>(() => this.ToDictionary(e => e.NOTE_ID));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KN"; } }

        /// <summary>
        /// Find KN by NOTE_ID key field
        /// </summary>
        /// <param name="Key">NOTE_ID value used to find KN</param>
        /// <returns>Related KN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">NOTE_ID value didn't match any KN entities</exception>
        public KN FindByNOTE_ID(string Key)
        {
            KN result;
            if (NOTE_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KN by NOTE_ID key field
        /// </summary>
        /// <param name="Key">NOTE_ID value used to find KN</param>
        /// <param name="Value">Related KN entity</param>
        /// <returns>True if the KN entity is found</returns>
        public bool TryFindByNOTE_ID(string Key, out KN Value)
        {
            return NOTE_IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KN by NOTE_ID key field
        /// </summary>
        /// <param name="Key">NOTE_ID value used to find KN</param>
        /// <returns>Related KN entity, or null if not found</returns>
        public KN TryFindByNOTE_ID(string Key)
        {
            KN result;
            if (NOTE_IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KN" /> fields for each CSV column header</returns>
        protected override Action<KN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "NOTE_ID":
                        mapper[i] = (e, v) => e.NOTE_ID = v;
                        break;
                    case "CONTENTS":
                        mapper[i] = (e, v) => e.CONTENTS = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "SCOPE":
                        mapper[i] = (e, v) => e.SCOPE = v;
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
