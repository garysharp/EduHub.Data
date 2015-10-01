using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Future Tax Scales Data Set
    /// </summary>
    public sealed class PX_NEWDataSet : SetBase<PX_NEW>
    {
        private Lazy<Dictionary<short, PX_NEW>> PXKEYIndex;

        internal PX_NEWDataSet(EduHubContext Context)
            : base(Context)
        {
            PXKEYIndex = new Lazy<Dictionary<short, PX_NEW>>(() => this.ToDictionary(e => e.PXKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "PX_NEW"; } }

        /// <summary>
        /// Find PX_NEW by PXKEY key field
        /// </summary>
        /// <param name="Key">PXKEY value used to find PX_NEW</param>
        /// <returns>Related PX_NEW entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">PXKEY value didn't match any PX_NEW entities</exception>
        public PX_NEW FindByPXKEY(short Key)
        {
            PX_NEW result;
            if (PXKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find PX_NEW by PXKEY key field
        /// </summary>
        /// <param name="Key">PXKEY value used to find PX_NEW</param>
        /// <param name="Value">Related PX_NEW entity</param>
        /// <returns>True if the PX_NEW entity is found</returns>
        public bool TryFindByPXKEY(short Key, out PX_NEW Value)
        {
            return PXKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find PX_NEW by PXKEY key field
        /// </summary>
        /// <param name="Key">PXKEY value used to find PX_NEW</param>
        /// <returns>Related PX_NEW entity, or null if not found</returns>
        public PX_NEW TryFindByPXKEY(short Key)
        {
            PX_NEW result;
            if (PXKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PX_NEW" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PX_NEW" /> fields for each CSV column header</returns>
        protected override Action<PX_NEW, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PX_NEW, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PXKEY":
                        mapper[i] = (e, v) => e.PXKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION01":
                        mapper[i] = (e, v) => e.DESCRIPTION01 = v;
                        break;
                    case "DESCRIPTION02":
                        mapper[i] = (e, v) => e.DESCRIPTION02 = v;
                        break;
                    case "ENDINCOME01":
                        mapper[i] = (e, v) => e.ENDINCOME01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME02":
                        mapper[i] = (e, v) => e.ENDINCOME02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME03":
                        mapper[i] = (e, v) => e.ENDINCOME03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME04":
                        mapper[i] = (e, v) => e.ENDINCOME04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME05":
                        mapper[i] = (e, v) => e.ENDINCOME05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME06":
                        mapper[i] = (e, v) => e.ENDINCOME06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME07":
                        mapper[i] = (e, v) => e.ENDINCOME07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME08":
                        mapper[i] = (e, v) => e.ENDINCOME08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME09":
                        mapper[i] = (e, v) => e.ENDINCOME09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME10":
                        mapper[i] = (e, v) => e.ENDINCOME10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME11":
                        mapper[i] = (e, v) => e.ENDINCOME11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME12":
                        mapper[i] = (e, v) => e.ENDINCOME12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME13":
                        mapper[i] = (e, v) => e.ENDINCOME13 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME14":
                        mapper[i] = (e, v) => e.ENDINCOME14 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME15":
                        mapper[i] = (e, v) => e.ENDINCOME15 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME16":
                        mapper[i] = (e, v) => e.ENDINCOME16 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME17":
                        mapper[i] = (e, v) => e.ENDINCOME17 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME18":
                        mapper[i] = (e, v) => e.ENDINCOME18 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME19":
                        mapper[i] = (e, v) => e.ENDINCOME19 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME20":
                        mapper[i] = (e, v) => e.ENDINCOME20 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COEFA01":
                        mapper[i] = (e, v) => e.COEFA01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA02":
                        mapper[i] = (e, v) => e.COEFA02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA03":
                        mapper[i] = (e, v) => e.COEFA03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA04":
                        mapper[i] = (e, v) => e.COEFA04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA05":
                        mapper[i] = (e, v) => e.COEFA05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA06":
                        mapper[i] = (e, v) => e.COEFA06 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA07":
                        mapper[i] = (e, v) => e.COEFA07 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA08":
                        mapper[i] = (e, v) => e.COEFA08 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA09":
                        mapper[i] = (e, v) => e.COEFA09 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA10":
                        mapper[i] = (e, v) => e.COEFA10 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA11":
                        mapper[i] = (e, v) => e.COEFA11 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA12":
                        mapper[i] = (e, v) => e.COEFA12 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA13":
                        mapper[i] = (e, v) => e.COEFA13 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA14":
                        mapper[i] = (e, v) => e.COEFA14 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA15":
                        mapper[i] = (e, v) => e.COEFA15 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA16":
                        mapper[i] = (e, v) => e.COEFA16 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA17":
                        mapper[i] = (e, v) => e.COEFA17 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA18":
                        mapper[i] = (e, v) => e.COEFA18 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA19":
                        mapper[i] = (e, v) => e.COEFA19 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA20":
                        mapper[i] = (e, v) => e.COEFA20 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB01":
                        mapper[i] = (e, v) => e.COEFB01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB02":
                        mapper[i] = (e, v) => e.COEFB02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB03":
                        mapper[i] = (e, v) => e.COEFB03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB04":
                        mapper[i] = (e, v) => e.COEFB04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB05":
                        mapper[i] = (e, v) => e.COEFB05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB06":
                        mapper[i] = (e, v) => e.COEFB06 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB07":
                        mapper[i] = (e, v) => e.COEFB07 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB08":
                        mapper[i] = (e, v) => e.COEFB08 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB09":
                        mapper[i] = (e, v) => e.COEFB09 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB10":
                        mapper[i] = (e, v) => e.COEFB10 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB11":
                        mapper[i] = (e, v) => e.COEFB11 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB12":
                        mapper[i] = (e, v) => e.COEFB12 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB13":
                        mapper[i] = (e, v) => e.COEFB13 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB14":
                        mapper[i] = (e, v) => e.COEFB14 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB15":
                        mapper[i] = (e, v) => e.COEFB15 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB16":
                        mapper[i] = (e, v) => e.COEFB16 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB17":
                        mapper[i] = (e, v) => e.COEFB17 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB18":
                        mapper[i] = (e, v) => e.COEFB18 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB19":
                        mapper[i] = (e, v) => e.COEFB19 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB20":
                        mapper[i] = (e, v) => e.COEFB20 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRANSDATE":
                        mapper[i] = (e, v) => e.TRANSDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HECS":
                        mapper[i] = (e, v) => e.HECS = v;
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
