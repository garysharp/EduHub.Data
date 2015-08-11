﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Bank Account Details Data Set
    /// </summary>
    public sealed class GLBANK_DataSet : SetBase<GLBANK_Entity>
    {
        internal GLBANK_DataSet(EduHubContext Context)
            : base(Context)
        {
            GLCODE_Index = new Lazy<Dictionary<string, GLBANK_Entity>>(() => this.ToDictionary(e => e.GLCODE));
            GLBANKKEY_Index = new Lazy<Dictionary<int, GLBANK_Entity>>(() => this.ToDictionary(e => e.GLBANKKEY));
        }

        public override string SetName { get { return "GLBANK"; } }

        private Lazy<Dictionary<string, GLBANK_Entity>> GLCODE_Index;
        private Lazy<Dictionary<int, GLBANK_Entity>> GLBANKKEY_Index;

        public GLBANK_Entity FindByGLCODE(string Key)
        {
            GLBANK_Entity result;
            if (GLCODE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByGLCODE(string Key, out GLBANK_Entity Value)
        {
            return GLCODE_Index.Value.TryGetValue(Key, out Value);
        }
        public GLBANK_Entity TryFindByGLCODE(string Key)
        {
            GLBANK_Entity result;
            if (GLCODE_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public GLBANK_Entity FindByGLBANKKEY(int Key)
        {
            GLBANK_Entity result;
            if (GLBANKKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByGLBANKKEY(int Key, out GLBANK_Entity Value)
        {
            return GLBANKKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public GLBANK_Entity TryFindByGLBANKKEY(int Key)
        {
            GLBANK_Entity result;
            if (GLBANKKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<GLBANK_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<GLBANK_Entity, string>[Headers.Count];

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