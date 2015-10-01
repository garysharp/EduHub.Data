using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// On line receipt history Data Set
    /// </summary>
    public sealed class SIRHDataSet : SetBase<SIRH>
    {
        private Lazy<Dictionary<string, SIRH>> SIRHKEYIndex;

        internal SIRHDataSet(EduHubContext Context)
            : base(Context)
        {
            SIRHKEYIndex = new Lazy<Dictionary<string, SIRH>>(() => this.ToDictionary(e => e.SIRHKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SIRH"; } }

        /// <summary>
        /// Find SIRH by SIRHKEY key field
        /// </summary>
        /// <param name="Key">SIRHKEY value used to find SIRH</param>
        /// <returns>Related SIRH entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SIRHKEY value didn't match any SIRH entities</exception>
        public SIRH FindBySIRHKEY(string Key)
        {
            SIRH result;
            if (SIRHKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SIRH by SIRHKEY key field
        /// </summary>
        /// <param name="Key">SIRHKEY value used to find SIRH</param>
        /// <param name="Value">Related SIRH entity</param>
        /// <returns>True if the SIRH entity is found</returns>
        public bool TryFindBySIRHKEY(string Key, out SIRH Value)
        {
            return SIRHKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SIRH by SIRHKEY key field
        /// </summary>
        /// <param name="Key">SIRHKEY value used to find SIRH</param>
        /// <returns>Related SIRH entity, or null if not found</returns>
        public SIRH TryFindBySIRHKEY(string Key)
        {
            SIRH result;
            if (SIRHKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SIRH" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SIRH" /> fields for each CSV column header</returns>
        protected override Action<SIRH, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SIRH, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SIRHKEY":
                        mapper[i] = (e, v) => e.SIRHKEY = v;
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TRXLEDGER":
                        mapper[i] = (e, v) => e.TRXLEDGER = v;
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TRAMT":
                        mapper[i] = (e, v) => e.TRAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "RTYPE":
                        mapper[i] = (e, v) => e.RTYPE = v;
                        break;
                    case "RECEIPT_USER":
                        mapper[i] = (e, v) => e.RECEIPT_USER = v;
                        break;
                    case "RECEIPT_DATE":
                        mapper[i] = (e, v) => e.RECEIPT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "RECEIPT_TIME":
                        mapper[i] = (e, v) => e.RECEIPT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "NEW_TRREF":
                        mapper[i] = (e, v) => e.NEW_TRREF = v;
                        break;
                    case "ERROR_FLAG":
                        mapper[i] = (e, v) => e.ERROR_FLAG = v;
                        break;
                    case "ERROR_COMMENT":
                        mapper[i] = (e, v) => e.ERROR_COMMENT = v;
                        break;
                    case "ERROR_USER":
                        mapper[i] = (e, v) => e.ERROR_USER = v;
                        break;
                    case "FORMAT_ID":
                        mapper[i] = (e, v) => e.FORMAT_ID = v;
                        break;
                    case "PRINT_ID":
                        mapper[i] = (e, v) => e.PRINT_ID = v == null ? (int?)null : int.Parse(v);
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
