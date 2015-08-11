﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Data Export Data Set
    /// </summary>
    public sealed class FDT_EXP_DataSet : SetBase<FDT_EXP_Entity>
    {
        internal FDT_EXP_DataSet(EduHubContext Context)
            : base(Context)
        {
            TID_Index = new Lazy<Dictionary<int, FDT_EXP_Entity>>(() => this.ToDictionary(e => e.TID));
        }

        public override string SetName { get { return "FDT_EXP"; } }

        private Lazy<Dictionary<int, FDT_EXP_Entity>> TID_Index;

        public FDT_EXP_Entity FindByTID(int Key)
        {
            FDT_EXP_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByTID(int Key, out FDT_EXP_Entity Value)
        {
            return TID_Index.Value.TryGetValue(Key, out Value);
        }
        public FDT_EXP_Entity TryFindByTID(int Key)
        {
            FDT_EXP_Entity result;
            if (TID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<FDT_EXP_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<FDT_EXP_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "DEST":
                        mapper[i] = (e, v) => e.DEST = v;
                        break;
                    case "DEST_ID":
                        mapper[i] = (e, v) => e.DEST_ID = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "EXP_DATE":
                        mapper[i] = (e, v) => e.EXP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXP_TIME":
                        mapper[i] = (e, v) => e.EXP_TIME = v == null ? (short?)null : short.Parse(v);
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