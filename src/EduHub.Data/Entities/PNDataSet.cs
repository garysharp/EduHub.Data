using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Groups Data Set
    /// </summary>
    public sealed class PNDataSet : SetBase<PN>
    {
        private Lazy<Dictionary<short, PN>> PNKEYIndex;

        internal PNDataSet(EduHubContext Context)
            : base(Context)
        {
            PNKEYIndex = new Lazy<Dictionary<short, PN>>(() => this.ToDictionary(e => e.PNKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PN"; } }

        /// <summary>
        /// Find PN by PNKEY key field
        /// </summary>
        /// <param name="Key">PNKEY value used to find PN</param>
        /// <returns>Related PN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PNKEY value didn't match any PN entities</exception>
        public PN FindByPNKEY(short Key)
        {
            PN result;
            if (PNKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PN by PNKEY key field
        /// </summary>
        /// <param name="Key">PNKEY value used to find PN</param>
        /// <param name="Value">Related PN entity</param>
        /// <returns>True if the PN entity is found</returns>
        public bool TryFindByPNKEY(short Key, out PN Value)
        {
            return PNKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PN by PNKEY key field
        /// </summary>
        /// <param name="Key">PNKEY value used to find PN</param>
        /// <returns>Related PN entity, or null if not found</returns>
        public PN TryFindByPNKEY(short Key)
        {
            PN result;
            if (PNKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PN" /> fields for each CSV column header</returns>
        protected override Action<PN, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PNKEY":
                        mapper[i] = (e, v) => e.PNKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TRANSTYPE":
                        mapper[i] = (e, v) => e.TRANSTYPE = v;
                        break;
                    case "FIRSTDATE":
                        mapper[i] = (e, v) => e.FIRSTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NEXTDATE":
                        mapper[i] = (e, v) => e.NEXTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "NO_PAYS":
                        mapper[i] = (e, v) => e.NO_PAYS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ROUNDOFF":
                        mapper[i] = (e, v) => e.ROUNDOFF = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "ACN":
                        mapper[i] = (e, v) => e.ACN = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "DD_GLCODE":
                        mapper[i] = (e, v) => e.DD_GLCODE = v;
                        break;
                    case "GLCODE":
                        mapper[i] = (e, v) => e.GLCODE = v;
                        break;
                    case "GLBANK":
                        mapper[i] = (e, v) => e.GLBANK = v;
                        break;
                    case "GLTAX":
                        mapper[i] = (e, v) => e.GLTAX = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
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
