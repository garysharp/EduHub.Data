﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// BPAY Receipts Import Data Set
    /// </summary>
    public sealed class KBP_DataSet : SetBase<KBP_Entity>
    {
        internal KBP_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, KBP_Entity>>(() => this.ToDictionary(e => e.TID));
            REFERENCE_NO_Index = new Lazy<Dictionary<string, KBP_Entity>>(() => this.ToDictionary(e => e.REFERENCE_NO));
        }

        public override string SetName { get { return "KBP"; } }

        private Lazy<Dictionary<int, KBP_Entity>> TID_Index;
        private Lazy<Dictionary<string, KBP_Entity>> REFERENCE_NO_Index;

        public KBP_Entity FindByTID(int Key)
        {
            KBP_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out KBP_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public KBP_Entity TryFindByTID(int Key)
        {
            KBP_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public KBP_Entity FindByREFERENCE_NO(string Key)
        {
            KBP_Entity result;
            if (REFERENCE_NO_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByREFERENCE_NO(string Key, out KBP_Entity Value)
        {
            return REFERENCE_NO_Index.Value.TryGetValue(Key, out Value);
        }
        public KBP_Entity TryFindByREFERENCE_NO(string Key)
        {
            KBP_Entity result;
            if (REFERENCE_NO_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KBP_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KBP_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CUST_REFERENCE":
                        mapper[i] = (e, v) => e.CUST_REFERENCE = v;
                        break;
                    case "RECORD_TYPE":
                        mapper[i] = (e, v) => e.RECORD_TYPE = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "PAYMENT_TYPE":
                        mapper[i] = (e, v) => e.PAYMENT_TYPE = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PAYMENT_DATE":
                        mapper[i] = (e, v) => e.PAYMENT_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DELETE_FLAG":
                        mapper[i] = (e, v) => e.DELETE_FLAG = v;
                        break;
                    case "INVOICE_TID":
                        mapper[i] = (e, v) => e.INVOICE_TID = v == null ? (int?)null : int.Parse(v);
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