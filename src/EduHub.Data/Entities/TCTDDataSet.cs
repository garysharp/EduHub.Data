﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Calendar Period Information Data Set
    /// </summary>
    public sealed partial class TCTDDataSet : SetBase<TCTD>
    {


        internal TCTDDataSet(EduHubContext Context)
            : base(Context)
        {

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TCTD"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TCTD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TCTD" /> fields for each CSV column header</returns>
        protected override Action<TCTD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TCTD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TCTDKEY":
                        mapper[i] = (e, v) => e.TCTDKEY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "QKEY":
                        mapper[i] = (e, v) => e.QKEY = v;
                        break;
                    case "TIME_INDEX":
                        mapper[i] = (e, v) => e.TIME_INDEX = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_START":
                        mapper[i] = (e, v) => e.TIME_START = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_END":
                        mapper[i] = (e, v) => e.TIME_END = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "TIME_TYPE":
                        mapper[i] = (e, v) => e.TIME_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TIME_NAME":
                        mapper[i] = (e, v) => e.TIME_NAME = v;
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
