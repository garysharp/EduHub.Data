using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Asset Release Types Data Set
    /// </summary>
    public sealed class AKRDataSet : SetBase<AKR>
    {
        private Lazy<Dictionary<string, AKR>> AKRKEYIndex;

        internal AKRDataSet(EduHubContext Context)
            : base(Context)
        {
            AKRKEYIndex = new Lazy<Dictionary<string, AKR>>(() => this.ToDictionary(e => e.AKRKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKR"; } }

        /// <summary>
        /// Find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">AKRKEY value didn't match any AKR entities</exception>
        public AKR FindByAKRKEY(string Key)
        {
            AKR result;
            if (AKRKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <param name="Value">Related AKR entity</param>
        /// <returns>True if the AKR entity is found</returns>
        public bool TryFindByAKRKEY(string Key, out AKR Value)
        {
            return AKRKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKR by AKRKEY key field
        /// </summary>
        /// <param name="Key">AKRKEY value used to find AKR</param>
        /// <returns>Related AKR entity, or null if not found</returns>
        public AKR TryFindByAKRKEY(string Key)
        {
            AKR result;
            if (AKRKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="AKR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="AKR" /> fields for each CSV column header</returns>
        protected override Action<AKR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<AKR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "AKRKEY":
                        mapper[i] = (e, v) => e.AKRKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
