using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial History Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class FINHISTDataSet : SetBase<FINHIST>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FINHIST"; } }

        internal FINHISTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, FINHIST>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FINHIST" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FINHIST" /> fields for each CSV column header</returns>
        protected override Action<FINHIST, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FINHIST, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "LEDGER":
                        mapper[i] = (e, v) => e.LEDGER = v;
                        break;
                    case "ENTITY":
                        mapper[i] = (e, v) => e.ENTITY = v;
                        break;
                    case "TRANSACTION_ID":
                        mapper[i] = (e, v) => e.TRANSACTION_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.ACCOUNT_NAME = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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

        private Lazy<Dictionary<int, FINHIST>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <returns>Related FINHIST entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FINHIST FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <param name="Value">Related FINHIST entity</param>
        /// <returns>True if the related FINHIST entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out FINHIST Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find FINHIST by ID field
        /// </summary>
        /// <param name="ID">ID value used to find FINHIST</param>
        /// <returns>Related FINHIST entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public FINHIST TryFindByID(int ID)
        {
            FINHIST value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
