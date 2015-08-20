using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees Data Set
    /// </summary>
    public sealed class SADataSet : SetBase<SA>
    {
        private Lazy<Dictionary<string, SA>> SAKEYIndex;

        internal SADataSet(EduHubContext Context)
            : base(Context)
        {
            SAKEYIndex = new Lazy<Dictionary<string, SA>>(() => this.ToDictionary(e => e.SAKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SA"; } }

        /// <summary>
        /// Find SA by SAKEY key field
        /// </summary>
        /// <param name="Key">SAKEY value used to find SA</param>
        /// <returns>Related SA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SAKEY value didn't match any SA entities</exception>
        public SA FindBySAKEY(string Key)
        {
            SA result;
            if (SAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SA by SAKEY key field
        /// </summary>
        /// <param name="Key">SAKEY value used to find SA</param>
        /// <param name="Value">Related SA entity</param>
        /// <returns>True if the SA entity is found</returns>
        public bool TryFindBySAKEY(string Key, out SA Value)
        {
            return SAKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SA by SAKEY key field
        /// </summary>
        /// <param name="Key">SAKEY value used to find SA</param>
        /// <returns>Related SA entity, or null if not found</returns>
        public SA TryFindBySAKEY(string Key)
        {
            SA result;
            if (SAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SA" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SA" /> fields for each CSV column header</returns>
        protected override Action<SA, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAKEY":
                        mapper[i] = (e, v) => e.SAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "SAGROUP":
                        mapper[i] = (e, v) => e.SAGROUP = v;
                        break;
                    case "STATEMENT":
                        mapper[i] = (e, v) => e.STATEMENT = v;
                        break;
                    case "METHOD":
                        mapper[i] = (e, v) => e.METHOD = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GROSS_AMOUNT":
                        mapper[i] = (e, v) => e.GROSS_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "GST_TYPE":
                        mapper[i] = (e, v) => e.GST_TYPE = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "VOLUNTARY":
                        mapper[i] = (e, v) => e.VOLUNTARY = v;
                        break;
                    case "SPLIT_BILLING":
                        mapper[i] = (e, v) => e.SPLIT_BILLING = v;
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
