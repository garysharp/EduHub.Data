using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BSB Numbers Data Set
    /// </summary>
    public sealed class KABDataSet : SetBase<KAB>
    {
        private Lazy<Dictionary<string, KAB>> BSBIndex;

        internal KABDataSet(EduHubContext Context)
            : base(Context)
        {
            BSBIndex = new Lazy<Dictionary<string, KAB>>(() => this.ToDictionary(e => e.BSB));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAB"; } }

        /// <summary>
        /// Find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <returns>Related KAB entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">BSB value didn't match any KAB entities</exception>
        public KAB FindByBSB(string Key)
        {
            KAB result;
            if (BSBIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <param name="Value">Related KAB entity</param>
        /// <returns>True if the KAB entity is found</returns>
        public bool TryFindByBSB(string Key, out KAB Value)
        {
            return BSBIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAB by BSB key field
        /// </summary>
        /// <param name="Key">BSB value used to find KAB</param>
        /// <returns>Related KAB entity, or null if not found</returns>
        public KAB TryFindByBSB(string Key)
        {
            KAB result;
            if (BSBIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KAB" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KAB" /> fields for each CSV column header</returns>
        protected override Action<KAB, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KAB, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "ADDRESS":
                        mapper[i] = (e, v) => e.ADDRESS = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
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
