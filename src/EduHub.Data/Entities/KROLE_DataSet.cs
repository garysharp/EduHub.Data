﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Role Codes Data Set
    /// </summary>
    public sealed class KROLE_DataSet : SetBase<KROLE_Entity>
    {
        internal KROLE_DataSet(EduHubContext Context)
            : base(Context)
        {
            KROLEKEY_Index = new Lazy<Dictionary<string, KROLE_Entity>>(() => this.ToDictionary(e => e.KROLEKEY));
        }

        public override string SetName { get { return "KROLE"; } }

        private Lazy<Dictionary<string, KROLE_Entity>> KROLEKEY_Index;

        public KROLE_Entity FindByKROLEKEY(string Key)
        {
            KROLE_Entity result;
            if (KROLEKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByKROLEKEY(string Key, out KROLE_Entity Value)
        {
            return KROLEKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public KROLE_Entity TryFindByKROLEKEY(string Key)
        {
            KROLE_Entity result;
            if (KROLEKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KROLE_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KROLE_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KROLEKEY":
                        mapper[i] = (e, v) => e.KROLEKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROLE_NAME":
                        mapper[i] = (e, v) => e.ROLE_NAME = v;
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