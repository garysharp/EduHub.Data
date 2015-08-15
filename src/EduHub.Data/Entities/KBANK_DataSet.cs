using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Data Set
    /// </summary>
    public sealed class KBANK_DataSet : SetBase<KBANK_Entity>
    {
        private Lazy<Dictionary<string, KBANK_Entity>> GLCODE_Index;

        internal KBANK_DataSet(EduHubContext Context)
            : base(Context)
        {
            GLCODE_Index = new Lazy<Dictionary<string, KBANK_Entity>>(() => this.ToDictionary(e => e.GLCODE));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KBANK"; } }

        /// <summary>
        /// Find KBANK by GLCODE key field
        /// </summary>
        /// <param name="Key">GLCODE value used to find KBANK</param>
        /// <returns>Related KBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">GLCODE value didn't match any KBANK entities</exception>
        public KBANK_Entity FindByGLCODE(string Key)
        {
            KBANK_Entity result;
            if (GLCODE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KBANK by GLCODE key field
        /// </summary>
        /// <param name="Key">GLCODE value used to find KBANK</param>
        /// <param name="Value">Related KBANK entity</param>
        /// <returns>True if the KBANK Entity is found</returns>
        public bool TryFindByGLCODE(string Key, out KBANK_Entity Value)
        {
            return GLCODE_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KBANK by GLCODE key field
        /// </summary>
        /// <param name="Key">GLCODE value used to find KBANK</param>
        /// <returns>Related KBANK entity, or null if not found</returns>
        public KBANK_Entity TryFindByGLCODE(string Key)
        {
            KBANK_Entity result;
            if (GLCODE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KBANK_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KBANK_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLTITLE":
                        mapper[i] = (e, v) => e.GLTITLE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BANK_NAME":
                        mapper[i] = (e, v) => e.BANK_NAME = v;
                        break;
                    case "BANK_BRANCH":
                        mapper[i] = (e, v) => e.BANK_BRANCH = v;
                        break;
                    case "BANK_ADDRESS01":
                        mapper[i] = (e, v) => e.BANK_ADDRESS01 = v;
                        break;
                    case "BANK_ADDRESS02":
                        mapper[i] = (e, v) => e.BANK_ADDRESS02 = v;
                        break;
                    case "BANK_ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.BANK_ACCOUNT_NAME = v;
                        break;
                    case "BANK_ACCOUNT_BSB":
                        mapper[i] = (e, v) => e.BANK_ACCOUNT_BSB = v;
                        break;
                    case "BANK_ACCOUNT_NO":
                        mapper[i] = (e, v) => e.BANK_ACCOUNT_NO = v;
                        break;
                    case "BANK_ABBREVIATION":
                        mapper[i] = (e, v) => e.BANK_ABBREVIATION = v;
                        break;
                    case "APCA_NUMBER":
                        mapper[i] = (e, v) => e.APCA_NUMBER = v;
                        break;
                    case "BALANCE_ENTRY":
                        mapper[i] = (e, v) => e.BALANCE_ENTRY = v;
                        break;
                    case "LAST_RECONCILE_DATE":
                        mapper[i] = (e, v) => e.LAST_RECONCILE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_RECONCILE_DIFF":
                        mapper[i] = (e, v) => e.LAST_RECONCILE_DIFF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
