﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Absence by Cohort Aggregations Data Set
    /// </summary>
    public sealed class SACAG_DataSet : SetBase<SACAG_Entity>
    {
        internal SACAG_DataSet(EduHubContext Context)
            : base(Context)
        {
            SACAG_ID_Index = new Lazy<Dictionary<int, SACAG_Entity>>(() => this.ToDictionary(e => e.SACAG_ID));
        }

        public override string SetName { get { return "SACAG"; } }

        private Lazy<Dictionary<int, SACAG_Entity>> SACAG_ID_Index;

        public SACAG_Entity FindBySACAG_ID(int Key)
        {
            SACAG_Entity result;
            if (SACAG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindBySACAG_ID(int Key, out SACAG_Entity Value)
        {
            return SACAG_ID_Index.Value.TryGetValue(Key, out Value);
        }
        public SACAG_Entity TryFindBySACAG_ID(int Key)
        {
            SACAG_Entity result;
            if (SACAG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<SACAG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SACAG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SACAG_ID":
                        mapper[i] = (e, v) => e.SACAG_ID = int.Parse(v);
                        break;
                    case "BRY":
                        mapper[i] = (e, v) => e.BRY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR = v;
                        break;
                    case "SEMESTER":
                        mapper[i] = (e, v) => e.SEMESTER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "COHORT":
                        mapper[i] = (e, v) => e.COHORT = v;
                        break;
                    case "FTE":
                        mapper[i] = (e, v) => e.FTE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "UNAPPROVED":
                        mapper[i] = (e, v) => e.UNAPPROVED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "APPROVED":
                        mapper[i] = (e, v) => e.APPROVED = v == null ? (double?)null : double.Parse(v);
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