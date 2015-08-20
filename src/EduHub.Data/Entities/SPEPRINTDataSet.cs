using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Report file audit Data Set
    /// </summary>
    public sealed class SPEPRINTDataSet : SetBase<SPEPRINT>
    {
        private Lazy<Dictionary<int, SPEPRINT>> TIDIndex;

        internal SPEPRINTDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, SPEPRINT>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPEPRINT"; } }

        /// <summary>
        /// Find SPEPRINT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPEPRINT</param>
        /// <returns>Related SPEPRINT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any SPEPRINT entities</exception>
        public SPEPRINT FindByTID(int Key)
        {
            SPEPRINT result;
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
        /// Attempt to find SPEPRINT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPEPRINT</param>
        /// <param name="Value">Related SPEPRINT entity</param>
        /// <returns>True if the SPEPRINT entity is found</returns>
        public bool TryFindByTID(int Key, out SPEPRINT Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SPEPRINT by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find SPEPRINT</param>
        /// <returns>Related SPEPRINT entity, or null if not found</returns>
        public SPEPRINT TryFindByTID(int Key)
        {
            SPEPRINT result;
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
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPEPRINT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPEPRINT" /> fields for each CSV column header</returns>
        protected override Action<SPEPRINT, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SPEPRINT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PRINT_DATE":
                        mapper[i] = (e, v) => e.PRINT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PRINT_BY":
                        mapper[i] = (e, v) => e.PRINT_BY = v;
                        break;
                    case "SEND_DATE":
                        mapper[i] = (e, v) => e.SEND_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SEND_BY":
                        mapper[i] = (e, v) => e.SEND_BY = v;
                        break;
                    case "ENTITY_TABLE":
                        mapper[i] = (e, v) => e.ENTITY_TABLE = v;
                        break;
                    case "ENTITY_KEY":
                        mapper[i] = (e, v) => e.ENTITY_KEY = v;
                        break;
                    case "EMAIL_ADDRESS":
                        mapper[i] = (e, v) => e.EMAIL_ADDRESS = v;
                        break;
                    case "COPY_ADDRESS":
                        mapper[i] = (e, v) => e.COPY_ADDRESS = v;
                        break;
                    case "EMAIL_SUBJECT":
                        mapper[i] = (e, v) => e.EMAIL_SUBJECT = v;
                        break;
                    case "EMAIL_MESSAGE":
                        mapper[i] = (e, v) => e.EMAIL_MESSAGE = v;
                        break;
                    case "ATTACHMENT_PATH":
                        mapper[i] = (e, v) => e.ATTACHMENT_PATH = v;
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "DISPLAY":
                        mapper[i] = (e, v) => e.DISPLAY = v;
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
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
