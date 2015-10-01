using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence Types Data Set
    /// </summary>
    public sealed class KCTDataSet : SetBase<KCT>
    {
        private Lazy<Dictionary<short, KCT>> KCTKEYIndex;

        internal KCTDataSet(EduHubContext Context)
            : base(Context)
        {
            KCTKEYIndex = new Lazy<Dictionary<short, KCT>>(() => this.ToDictionary(e => e.KCTKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCT"; } }

        /// <summary>
        /// Find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCTKEY value didn't match any KCT entities</exception>
        public KCT FindByKCTKEY(short Key)
        {
            KCT result;
            if (KCTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <param name="Value">Related KCT entity</param>
        /// <returns>True if the KCT entity is found</returns>
        public bool TryFindByKCTKEY(short Key, out KCT Value)
        {
            return KCTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCT by KCTKEY key field
        /// </summary>
        /// <param name="Key">KCTKEY value used to find KCT</param>
        /// <returns>Related KCT entity, or null if not found</returns>
        public KCT TryFindByKCTKEY(short Key)
        {
            KCT result;
            if (KCTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCT" /> fields for each CSV column header</returns>
        protected override Action<KCT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCTKEY":
                        mapper[i] = (e, v) => e.KCTKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ABBREV_DESC":
                        mapper[i] = (e, v) => e.ABBREV_DESC = v;
                        break;
                    case "CURRICULUM":
                        mapper[i] = (e, v) => e.CURRICULUM = v;
                        break;
                    case "DOE_TYPE":
                        mapper[i] = (e, v) => e.DOE_TYPE = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "PRE_APPROVED":
                        mapper[i] = (e, v) => e.PRE_APPROVED = v;
                        break;
                    case "ABS_RATE":
                        mapper[i] = (e, v) => e.ABS_RATE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SMS":
                        mapper[i] = (e, v) => e.SMS = v;
                        break;
                    case "SMS_MESSAGE":
                        mapper[i] = (e, v) => e.SMS_MESSAGE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
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
