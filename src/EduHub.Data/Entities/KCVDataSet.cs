using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Visa Subclasses Data Set
    /// </summary>
    public sealed class KCVDataSet : SetBase<KCV>
    {
        private Lazy<Dictionary<string, KCV>> VISA_SUBCLASSIndex;

        internal KCVDataSet(EduHubContext Context)
            : base(Context)
        {
            VISA_SUBCLASSIndex = new Lazy<Dictionary<string, KCV>>(() => this.ToDictionary(e => e.VISA_SUBCLASS));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCV"; } }

        /// <summary>
        /// Find KCV by VISA_SUBCLASS key field
        /// </summary>
        /// <param name="Key">VISA_SUBCLASS value used to find KCV</param>
        /// <returns>Related KCV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">VISA_SUBCLASS value didn't match any KCV entities</exception>
        public KCV FindByVISA_SUBCLASS(string Key)
        {
            KCV result;
            if (VISA_SUBCLASSIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCV by VISA_SUBCLASS key field
        /// </summary>
        /// <param name="Key">VISA_SUBCLASS value used to find KCV</param>
        /// <param name="Value">Related KCV entity</param>
        /// <returns>True if the KCV entity is found</returns>
        public bool TryFindByVISA_SUBCLASS(string Key, out KCV Value)
        {
            return VISA_SUBCLASSIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCV by VISA_SUBCLASS key field
        /// </summary>
        /// <param name="Key">VISA_SUBCLASS value used to find KCV</param>
        /// <returns>Related KCV entity, or null if not found</returns>
        public KCV TryFindByVISA_SUBCLASS(string Key)
        {
            KCV result;
            if (VISA_SUBCLASSIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCV" /> fields for each CSV column header</returns>
        protected override Action<KCV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "VISA_RESIDENCY":
                        mapper[i] = (e, v) => e.VISA_RESIDENCY = v;
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "CHECK_STAT_CODE":
                        mapper[i] = (e, v) => e.CHECK_STAT_CODE = v;
                        break;
                    case "CHECK_EXPIRY_DATE":
                        mapper[i] = (e, v) => e.CHECK_EXPIRY_DATE = v;
                        break;
                    case "CHECK_ISID":
                        mapper[i] = (e, v) => e.CHECK_ISID = v;
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
