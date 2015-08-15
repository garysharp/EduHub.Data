using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Fees Data Set
    /// </summary>
    public sealed class SA_DataSet : SetBase<SA_Entity>
    {
        private Lazy<Dictionary<string, SA_Entity>> SAKEY_Index;

        internal SA_DataSet(EduHubContext Context)
            : base(Context)
        {
            SAKEY_Index = new Lazy<Dictionary<string, SA_Entity>>(() => this.ToDictionary(e => e.SAKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SA"; } }

        /// <summary>
        /// Find SA by SAKEY key field
        /// </summary>
        /// <param name="Key">SAKEY value used to find SA</param>
        /// <returns>Related SA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SAKEY value didn't match any SA entities</exception>
        public SA_Entity FindBySAKEY(string Key)
        {
            SA_Entity result;
            if (SAKEY_Index.Value.TryGetValue(Key, out result))
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
        /// <returns>True if the SA Entity is found</returns>
        public bool TryFindBySAKEY(string Key, out SA_Entity Value)
        {
            return SAKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SA by SAKEY key field
        /// </summary>
        /// <param name="Key">SAKEY value used to find SA</param>
        /// <returns>Related SA entity, or null if not found</returns>
        public SA_Entity TryFindBySAKEY(string Key)
        {
            SA_Entity result;
            if (SAKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SA_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SA_Entity, string>[Headers.Count];

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
