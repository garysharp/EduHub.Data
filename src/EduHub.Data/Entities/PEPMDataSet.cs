using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Methods Data Set
    /// </summary>
    public sealed class PEPMDataSet : SetBase<PEPM>
    {

        internal PEPMDataSet(EduHubContext Context)
            : base(Context)
        {
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PEPM"; } }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPM" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPM" /> fields for each CSV column header</returns>
        protected override Action<PEPM, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PEPM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "NAME":
                        mapper[i] = (e, v) => e.NAME = v;
                        break;
                    case "PAYMODE":
                        mapper[i] = (e, v) => e.PAYMODE = v;
                        break;
                    case "REFERENCE_NO":
                        mapper[i] = (e, v) => e.REFERENCE_NO = v;
                        break;
                    case "CHQ_NO":
                        mapper[i] = (e, v) => e.CHQ_NO = v;
                        break;
                    case "DAMOUNT":
                        mapper[i] = (e, v) => e.DAMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BANK":
                        mapper[i] = (e, v) => e.BANK = v;
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "AMOUNT":
                        mapper[i] = (e, v) => e.AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FLAG":
                        mapper[i] = (e, v) => e.FLAG = v;
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EFT_CREATED":
                        mapper[i] = (e, v) => e.EFT_CREATED = v;
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
