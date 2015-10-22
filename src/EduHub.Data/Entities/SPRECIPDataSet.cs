using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// SMS Recipients Data Set
    /// </summary>
    public sealed partial class SPRECIPDataSet : SetBase<SPRECIP>
    {
        private Lazy<Dictionary<int, SPRECIP>> TIDIndex;


        internal SPRECIPDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, SPRECIP>>(() => this.ToDictionary(e => e.TID));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPRECIP"; } }

        /// <summary>
        /// Find SPRECIP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPRECIP</param>
        /// <returns>Related SPRECIP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any SPRECIP entities</exception>
        public SPRECIP FindByTID(int Key)
        {
            SPRECIP result;
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
        /// Attempt to find SPRECIP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPRECIP</param>
        /// <param name="Value">Related SPRECIP entity</param>
        /// <returns>True if the SPRECIP entity is found</returns>
        public bool TryFindByTID(int Key, out SPRECIP Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SPRECIP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPRECIP</param>
        /// <returns>Related SPRECIP entity, or null if not found</returns>
        public SPRECIP TryFindByTID(int Key)
        {
            SPRECIP result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPRECIP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPRECIP" /> fields for each CSV column header</returns>
        protected override Action<SPRECIP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPRECIP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "RECIPIENT_TABLE":
                        mapper[i] = (e, v) => e.RECIPIENT_TABLE = v;
                        break;
                    case "RECIPIENT_KEY":
                        mapper[i] = (e, v) => e.RECIPIENT_KEY = v;
                        break;
                    case "RECIPIENT_NUMBER":
                        mapper[i] = (e, v) => e.RECIPIENT_NUMBER = v;
                        break;
                    case "READ_RECEIPT":
                        mapper[i] = (e, v) => e.READ_RECEIPT = v;
                        break;
                    case "SOURCE_TABLE":
                        mapper[i] = (e, v) => e.SOURCE_TABLE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "STATUS_MESSAGE":
                        mapper[i] = (e, v) => e.STATUS_MESSAGE = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DELIVERED_DATE":
                        mapper[i] = (e, v) => e.DELIVERED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MESSAGEID":
                        mapper[i] = (e, v) => e.MESSAGEID = v == null ? (int?)null : int.Parse(v);
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
