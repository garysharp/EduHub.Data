using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KBANKDataSet : SetBase<KBANK>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KBANK"; } }

        internal KBANKDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLCODE = new Lazy<Dictionary<string, KBANK>>(() => this.ToDictionary(i => i.GLCODE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KBANK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KBANK" /> fields for each CSV column header</returns>
        protected override Action<KBANK, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KBANK, string>[Headers.Count];

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

        #region Index Fields

        private Lazy<Dictionary<string, KBANK>> Index_GLCODE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find KBANK</param>
        /// <returns>Related KBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBANK FindByGLCODE(string GLCODE)
        {
            return Index_GLCODE.Value[GLCODE];
        }

        /// <summary>
        /// Attempt to find KBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find KBANK</param>
        /// <param name="Value">Related KBANK entity</param>
        /// <returns>True if the related KBANK entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLCODE(string GLCODE, out KBANK Value)
        {
            return Index_GLCODE.Value.TryGetValue(GLCODE, out Value);
        }

        /// <summary>
        /// Attempt to find KBANK by GLCODE field
        /// </summary>
        /// <param name="GLCODE">GLCODE value used to find KBANK</param>
        /// <returns>Related KBANK entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KBANK TryFindByGLCODE(string GLCODE)
        {
            KBANK value;
            if (Index_GLCODE.Value.TryGetValue(GLCODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
