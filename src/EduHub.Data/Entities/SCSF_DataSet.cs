﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Strands Data Set
    /// </summary>
    public sealed class SCSF_DataSet : SetBase<SCSF_Entity>
    {
        internal SCSF_DataSet(EduHubContext Context)
            : base(Context)
        {
            SCSFKEY_Index = new Lazy<Dictionary<string, SCSF_Entity>>(() => this.ToDictionary(e => e.SCSFKEY));
        }

        public override string SetName { get { return "SCSF"; } }

        private Lazy<Dictionary<string, SCSF_Entity>> SCSFKEY_Index;

        public SCSF_Entity FindBySCSFKEY(string Key)
        {
            SCSF_Entity result;
            if (SCSFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySCSFKEY(string Key, out SCSF_Entity Value)
        {
            return SCSFKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public SCSF_Entity TryFindBySCSFKEY(string Key)
        {
            SCSF_Entity result;
            if (SCSFKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SCSF_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCSF_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "KLA":
                        mapper[i] = (e, v) => e.KLA = v;
                        break;
                    case "STRAND":
                        mapper[i] = (e, v) => e.STRAND = v;
                        break;
                    case "SUB_STRAND":
                        mapper[i] = (e, v) => e.SUB_STRAND = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "DEET_REQUIRED":
                        mapper[i] = (e, v) => e.DEET_REQUIRED = v;
                        break;
                    case "LOW_LEVEL":
                        mapper[i] = (e, v) => e.LOW_LEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HIGH_LEVEL":
                        mapper[i] = (e, v) => e.HIGH_LEVEL = v == null ? (short?)null : short.Parse(v);
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