using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Decrypted data IMPORT Data Set
    /// </summary>
    public sealed class A_DECRYPDataSet : SetBase<A_DECRYP>
    {
        private Lazy<Dictionary<int, A_DECRYP>> TIDIndex;

        internal A_DECRYPDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, A_DECRYP>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "A_DECRYP"; } }

        /// <summary>
        /// Find A_DECRYP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any A_DECRYP entities</exception>
        public A_DECRYP FindByTID(int Key)
        {
            A_DECRYP result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find A_DECRYP</param>
        /// <param name="Value">Related A_DECRYP entity</param>
        /// <returns>True if the A_DECRYP entity is found</returns>
        public bool TryFindByTID(int Key, out A_DECRYP Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find A_DECRYP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find A_DECRYP</param>
        /// <returns>Related A_DECRYP entity, or null if not found</returns>
        public A_DECRYP TryFindByTID(int Key)
        {
            A_DECRYP result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="A_DECRYP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="A_DECRYP" /> fields for each CSV column header</returns>
        protected override Action<A_DECRYP, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<A_DECRYP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "LINE_TYPE":
                        mapper[i] = (e, v) => e.LINE_TYPE = v;
                        break;
                    case "RECORD":
                        mapper[i] = (e, v) => e.RECORD = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
