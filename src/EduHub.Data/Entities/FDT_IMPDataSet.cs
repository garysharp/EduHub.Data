using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// FDT Financial Raw Import Table Data Set
    /// </summary>
    public sealed partial class FDT_IMPDataSet : SetBase<FDT_IMP>
    {
        private Lazy<Dictionary<int, FDT_IMP>> FDTKEYIndex;


        internal FDT_IMPDataSet(EduHubContext Context)
            : base(Context)
        {
            FDTKEYIndex = new Lazy<Dictionary<int, FDT_IMP>>(() => this.ToDictionary(e => e.FDTKEY));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FDT_IMP"; } }

        /// <summary>
        /// Find FDT_IMP by FDTKEY key field
        /// </summary>
        /// <param name="Key">FDTKEY value used to find FDT_IMP</param>
        /// <returns>Related FDT_IMP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">FDTKEY value didn't match any FDT_IMP entities</exception>
        public FDT_IMP FindByFDTKEY(int Key)
        {
            FDT_IMP result;
            if (FDTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find FDT_IMP by FDTKEY key field
        /// </summary>
        /// <param name="Key">FDTKEY value used to find FDT_IMP</param>
        /// <param name="Value">Related FDT_IMP entity</param>
        /// <returns>True if the FDT_IMP entity is found</returns>
        public bool TryFindByFDTKEY(int Key, out FDT_IMP Value)
        {
            return FDTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_IMP by FDTKEY key field
        /// </summary>
        /// <param name="Key">FDTKEY value used to find FDT_IMP</param>
        /// <returns>Related FDT_IMP entity, or null if not found</returns>
        public FDT_IMP TryFindByFDTKEY(int Key)
        {
            FDT_IMP result;
            if (FDTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FDT_IMP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FDT_IMP" /> fields for each CSV column header</returns>
        protected override Action<FDT_IMP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FDT_IMP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "FDTKEY":
                        mapper[i] = (e, v) => e.FDTKEY = int.Parse(v);
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "SOURCE_TABLE":
                        mapper[i] = (e, v) => e.SOURCE_TABLE = v;
                        break;
                    case "FIELD01":
                        mapper[i] = (e, v) => e.FIELD01 = v;
                        break;
                    case "FIELD02":
                        mapper[i] = (e, v) => e.FIELD02 = v;
                        break;
                    case "FIELD03":
                        mapper[i] = (e, v) => e.FIELD03 = v;
                        break;
                    case "FIELD04":
                        mapper[i] = (e, v) => e.FIELD04 = v;
                        break;
                    case "FIELD05":
                        mapper[i] = (e, v) => e.FIELD05 = v;
                        break;
                    case "FIELD06":
                        mapper[i] = (e, v) => e.FIELD06 = v;
                        break;
                    case "FIELD07":
                        mapper[i] = (e, v) => e.FIELD07 = v;
                        break;
                    case "FIELD08":
                        mapper[i] = (e, v) => e.FIELD08 = v;
                        break;
                    case "FIELD09":
                        mapper[i] = (e, v) => e.FIELD09 = v;
                        break;
                    case "FIELD10":
                        mapper[i] = (e, v) => e.FIELD10 = v;
                        break;
                    case "FIELD11":
                        mapper[i] = (e, v) => e.FIELD11 = v;
                        break;
                    case "FIELD12":
                        mapper[i] = (e, v) => e.FIELD12 = v;
                        break;
                    case "FIELD13":
                        mapper[i] = (e, v) => e.FIELD13 = v;
                        break;
                    case "FIELD14":
                        mapper[i] = (e, v) => e.FIELD14 = v;
                        break;
                    case "FIELD15":
                        mapper[i] = (e, v) => e.FIELD15 = v;
                        break;
                    case "FIELD16":
                        mapper[i] = (e, v) => e.FIELD16 = v;
                        break;
                    case "FIELD17":
                        mapper[i] = (e, v) => e.FIELD17 = v;
                        break;
                    case "FIELD18":
                        mapper[i] = (e, v) => e.FIELD18 = v;
                        break;
                    case "FIELD19":
                        mapper[i] = (e, v) => e.FIELD19 = v;
                        break;
                    case "FIELD20":
                        mapper[i] = (e, v) => e.FIELD20 = v;
                        break;
                    case "FIELD21":
                        mapper[i] = (e, v) => e.FIELD21 = v;
                        break;
                    case "FIELD22":
                        mapper[i] = (e, v) => e.FIELD22 = v;
                        break;
                    case "FIELD23":
                        mapper[i] = (e, v) => e.FIELD23 = v;
                        break;
                    case "FIELD24":
                        mapper[i] = (e, v) => e.FIELD24 = v;
                        break;
                    case "FIELD25":
                        mapper[i] = (e, v) => e.FIELD25 = v;
                        break;
                    case "FIELD26":
                        mapper[i] = (e, v) => e.FIELD26 = v;
                        break;
                    case "FIELD27":
                        mapper[i] = (e, v) => e.FIELD27 = v;
                        break;
                    case "FIELD28":
                        mapper[i] = (e, v) => e.FIELD28 = v;
                        break;
                    case "FIELD29":
                        mapper[i] = (e, v) => e.FIELD29 = v;
                        break;
                    case "FIELD30":
                        mapper[i] = (e, v) => e.FIELD30 = v;
                        break;
                    case "FIELD31":
                        mapper[i] = (e, v) => e.FIELD31 = v;
                        break;
                    case "FIELD32":
                        mapper[i] = (e, v) => e.FIELD32 = v;
                        break;
                    case "FIELD33":
                        mapper[i] = (e, v) => e.FIELD33 = v;
                        break;
                    case "FIELD34":
                        mapper[i] = (e, v) => e.FIELD34 = v;
                        break;
                    case "FIELD35":
                        mapper[i] = (e, v) => e.FIELD35 = v;
                        break;
                    case "FIELD36":
                        mapper[i] = (e, v) => e.FIELD36 = v;
                        break;
                    case "FIELD37":
                        mapper[i] = (e, v) => e.FIELD37 = v;
                        break;
                    case "FIELD38":
                        mapper[i] = (e, v) => e.FIELD38 = v;
                        break;
                    case "FIELD39":
                        mapper[i] = (e, v) => e.FIELD39 = v;
                        break;
                    case "FIELD40":
                        mapper[i] = (e, v) => e.FIELD40 = v;
                        break;
                    case "FIELD41":
                        mapper[i] = (e, v) => e.FIELD41 = v;
                        break;
                    case "FIELD42":
                        mapper[i] = (e, v) => e.FIELD42 = v;
                        break;
                    case "FIELD43":
                        mapper[i] = (e, v) => e.FIELD43 = v;
                        break;
                    case "FIELD44":
                        mapper[i] = (e, v) => e.FIELD44 = v;
                        break;
                    case "FIELD45":
                        mapper[i] = (e, v) => e.FIELD45 = v;
                        break;
                    case "FIELD46":
                        mapper[i] = (e, v) => e.FIELD46 = v;
                        break;
                    case "FIELD47":
                        mapper[i] = (e, v) => e.FIELD47 = v;
                        break;
                    case "FIELD48":
                        mapper[i] = (e, v) => e.FIELD48 = v;
                        break;
                    case "FIELD49":
                        mapper[i] = (e, v) => e.FIELD49 = v;
                        break;
                    case "NOTES01":
                        mapper[i] = (e, v) => e.NOTES01 = v;
                        break;
                    case "NOTES02":
                        mapper[i] = (e, v) => e.NOTES02 = v;
                        break;
                    case "NOTES03":
                        mapper[i] = (e, v) => e.NOTES03 = v;
                        break;
                    case "NOTES04":
                        mapper[i] = (e, v) => e.NOTES04 = v;
                        break;
                    case "ITEM_PIC":
                        mapper[i] = (e, v) => e.ITEM_PIC = null; // eduHub is not encoding byte arrays
                        break;
                    case "FDT_SOURCE":
                        mapper[i] = (e, v) => e.FDT_SOURCE = v;
                        break;
                    case "FDT_DEST":
                        mapper[i] = (e, v) => e.FDT_DEST = v;
                        break;
                    case "FDT_DEST_ID":
                        mapper[i] = (e, v) => e.FDT_DEST_ID = v;
                        break;
                    case "FDT_EXP_DATE":
                        mapper[i] = (e, v) => e.FDT_EXP_DATE = v;
                        break;
                    case "FDT_EXP_TIME":
                        mapper[i] = (e, v) => e.FDT_EXP_TIME = v;
                        break;
                    case "FDT_COMMENT":
                        mapper[i] = (e, v) => e.FDT_COMMENT = v;
                        break;
                    case "CURRENT_VER":
                        mapper[i] = (e, v) => e.CURRENT_VER = v;
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
