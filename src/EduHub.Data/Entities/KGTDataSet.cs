using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Countries Data Set
    /// </summary>
    public sealed class KGTDataSet : SetBase<KGT>
    {
        private Lazy<Dictionary<string, KGT>> COUNTRYIndex;

        internal KGTDataSet(EduHubContext Context)
            : base(Context)
        {
            COUNTRYIndex = new Lazy<Dictionary<string, KGT>>(() => this.ToDictionary(e => e.COUNTRY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGT"; } }

        /// <summary>
        /// Find KGT by COUNTRY key field
        /// </summary>
        /// <param name="Key">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">COUNTRY value didn't match any KGT entities</exception>
        public KGT FindByCOUNTRY(string Key)
        {
            KGT result;
            if (COUNTRYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY key field
        /// </summary>
        /// <param name="Key">COUNTRY value used to find KGT</param>
        /// <param name="Value">Related KGT entity</param>
        /// <returns>True if the KGT entity is found</returns>
        public bool TryFindByCOUNTRY(string Key, out KGT Value)
        {
            return COUNTRYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGT by COUNTRY key field
        /// </summary>
        /// <param name="Key">COUNTRY value used to find KGT</param>
        /// <returns>Related KGT entity, or null if not found</returns>
        public KGT TryFindByCOUNTRY(string Key)
        {
            KGT result;
            if (COUNTRYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGT" /> fields for each CSV column header</returns>
        protected override Action<KGT, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "COUNTRY":
                        mapper[i] = (e, v) => e.COUNTRY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ENGLISH_SPEAKING":
                        mapper[i] = (e, v) => e.ENGLISH_SPEAKING = v;
                        break;
                    case "SACC":
                        mapper[i] = (e, v) => e.SACC = v;
                        break;
                    case "OBSOLETE":
                        mapper[i] = (e, v) => e.OBSOLETE = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
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
