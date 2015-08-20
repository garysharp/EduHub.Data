using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Details Data Set
    /// </summary>
    public sealed class GLBANKDataSet : SetBase<GLBANK>
    {
        private Lazy<Dictionary<string, GLBANK>> GLCODEIndex;
        private Lazy<Dictionary<int, GLBANK>> GLBANKKEYIndex;

        internal GLBANKDataSet(EduHubContext Context)
            : base(Context)
        {
            GLCODEIndex = new Lazy<Dictionary<string, GLBANK>>(() => this.ToDictionary(e => e.GLCODE));
            GLBANKKEYIndex = new Lazy<Dictionary<int, GLBANK>>(() => this.ToDictionary(e => e.GLBANKKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLBANK"; } }

        /// <summary>
        /// Find GLBANK by GLCODE key field
        /// </summary>
        /// <param name="Key">GLCODE value used to find GLBANK</param>
        /// <returns>Related GLBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">GLCODE value didn't match any GLBANK entities</exception>
        public GLBANK FindByGLCODE(string Key)
        {
            GLBANK result;
            if (GLCODEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find GLBANK by GLCODE key field
        /// </summary>
        /// <param name="Key">GLCODE value used to find GLBANK</param>
        /// <param name="Value">Related GLBANK entity</param>
        /// <returns>True if the GLBANK entity is found</returns>
        public bool TryFindByGLCODE(string Key, out GLBANK Value)
        {
            return GLCODEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find GLBANK by GLCODE key field
        /// </summary>
        /// <param name="Key">GLCODE value used to find GLBANK</param>
        /// <returns>Related GLBANK entity, or null if not found</returns>
        public GLBANK TryFindByGLCODE(string Key)
        {
            GLBANK result;
            if (GLCODEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLBANK by GLBANKKEY key field
        /// </summary>
        /// <param name="Key">GLBANKKEY value used to find GLBANK</param>
        /// <returns>Related GLBANK entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">GLBANKKEY value didn't match any GLBANK entities</exception>
        public GLBANK FindByGLBANKKEY(int Key)
        {
            GLBANK result;
            if (GLBANKKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find GLBANK by GLBANKKEY key field
        /// </summary>
        /// <param name="Key">GLBANKKEY value used to find GLBANK</param>
        /// <param name="Value">Related GLBANK entity</param>
        /// <returns>True if the GLBANK entity is found</returns>
        public bool TryFindByGLBANKKEY(int Key, out GLBANK Value)
        {
            return GLBANKKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find GLBANK by GLBANKKEY key field
        /// </summary>
        /// <param name="Key">GLBANKKEY value used to find GLBANK</param>
        /// <returns>Related GLBANK entity, or null if not found</returns>
        public GLBANK TryFindByGLBANKKEY(int Key)
        {
            GLBANK result;
            if (GLBANKKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLBANK" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLBANK" /> fields for each CSV column header</returns>
        protected override Action<GLBANK, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<GLBANK, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANKKEY":
                        mapper[i] = (e, v) => e.GLBANKKEY = int.Parse(v);
                        break;
                    case "ACCOUNT_TYPE":
                        mapper[i] = (e, v) => e.ACCOUNT_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "INTEREST_RATE":
                        mapper[i] = (e, v) => e.INTEREST_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "INVESTMENT_DATE":
                        mapper[i] = (e, v) => e.INVESTMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "MATURITY_DATE":
                        mapper[i] = (e, v) => e.MATURITY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "INTEREST_EARNED":
                        mapper[i] = (e, v) => e.INTEREST_EARNED = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMENTS":
                        mapper[i] = (e, v) => e.COMMENTS = v;
                        break;
                    case "TOTAL_BANK_BALANCE":
                        mapper[i] = (e, v) => e.TOTAL_BANK_BALANCE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_BANK_BALANCE":
                        mapper[i] = (e, v) => e.LY_BANK_BALANCE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CASH_GRANT":
                        mapper[i] = (e, v) => e.CASH_GRANT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_CASH_GRANT":
                        mapper[i] = (e, v) => e.LY_CASH_GRANT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPERATING_RESERVE":
                        mapper[i] = (e, v) => e.OPERATING_RESERVE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LY_OPERATING_RESERVE":
                        mapper[i] = (e, v) => e.LY_OPERATING_RESERVE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR01":
                        mapper[i] = (e, v) => e.CURR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR02":
                        mapper[i] = (e, v) => e.CURR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR03":
                        mapper[i] = (e, v) => e.CURR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR04":
                        mapper[i] = (e, v) => e.CURR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR05":
                        mapper[i] = (e, v) => e.CURR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR06":
                        mapper[i] = (e, v) => e.CURR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR07":
                        mapper[i] = (e, v) => e.CURR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR08":
                        mapper[i] = (e, v) => e.CURR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR09":
                        mapper[i] = (e, v) => e.CURR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR10":
                        mapper[i] = (e, v) => e.CURR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR11":
                        mapper[i] = (e, v) => e.CURR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR12":
                        mapper[i] = (e, v) => e.CURR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR01":
                        mapper[i] = (e, v) => e.LASTYR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR02":
                        mapper[i] = (e, v) => e.LASTYR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR03":
                        mapper[i] = (e, v) => e.LASTYR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR04":
                        mapper[i] = (e, v) => e.LASTYR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR05":
                        mapper[i] = (e, v) => e.LASTYR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR06":
                        mapper[i] = (e, v) => e.LASTYR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR07":
                        mapper[i] = (e, v) => e.LASTYR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR08":
                        mapper[i] = (e, v) => e.LASTYR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR09":
                        mapper[i] = (e, v) => e.LASTYR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR10":
                        mapper[i] = (e, v) => e.LASTYR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR11":
                        mapper[i] = (e, v) => e.LASTYR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR12":
                        mapper[i] = (e, v) => e.LASTYR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
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
