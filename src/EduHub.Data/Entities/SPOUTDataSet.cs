using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Stored Procedure Return Values Data Set
    /// </summary>
    public sealed class SPOUTDataSet : SetBase<SPOUT>
    {
        private Lazy<Dictionary<string, SPOUT>> SPOUTKEYIndex;

        internal SPOUTDataSet(EduHubContext Context)
            : base(Context)
        {
            SPOUTKEYIndex = new Lazy<Dictionary<string, SPOUT>>(() => this.ToDictionary(e => e.SPOUTKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SPOUT"; } }

        /// <summary>
        /// Find SPOUT by SPOUTKEY key field
        /// </summary>
        /// <param name="Key">SPOUTKEY value used to find SPOUT</param>
        /// <returns>Related SPOUT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SPOUTKEY value didn't match any SPOUT entities</exception>
        public SPOUT FindBySPOUTKEY(string Key)
        {
            SPOUT result;
            if (SPOUTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SPOUT by SPOUTKEY key field
        /// </summary>
        /// <param name="Key">SPOUTKEY value used to find SPOUT</param>
        /// <param name="Value">Related SPOUT entity</param>
        /// <returns>True if the SPOUT entity is found</returns>
        public bool TryFindBySPOUTKEY(string Key, out SPOUT Value)
        {
            return SPOUTKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SPOUT by SPOUTKEY key field
        /// </summary>
        /// <param name="Key">SPOUTKEY value used to find SPOUT</param>
        /// <returns>Related SPOUT entity, or null if not found</returns>
        public SPOUT TryFindBySPOUTKEY(string Key)
        {
            SPOUT result;
            if (SPOUTKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SPOUT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SPOUT" /> fields for each CSV column header</returns>
        protected override Action<SPOUT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SPOUT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPOUTKEY":
                        mapper[i] = (e, v) => e.SPOUTKEY = v;
                        break;
                    case "FILE_NAME":
                        mapper[i] = (e, v) => e.FILE_NAME = v;
                        break;
                    case "ENTITYID":
                        mapper[i] = (e, v) => e.ENTITYID = v;
                        break;
                    case "FLAG01":
                        mapper[i] = (e, v) => e.FLAG01 = v;
                        break;
                    case "FLAG02":
                        mapper[i] = (e, v) => e.FLAG02 = v;
                        break;
                    case "FLAG03":
                        mapper[i] = (e, v) => e.FLAG03 = v;
                        break;
                    case "FLAG04":
                        mapper[i] = (e, v) => e.FLAG04 = v;
                        break;
                    case "TXT01":
                        mapper[i] = (e, v) => e.TXT01 = v;
                        break;
                    case "TXT02":
                        mapper[i] = (e, v) => e.TXT02 = v;
                        break;
                    case "TXT03":
                        mapper[i] = (e, v) => e.TXT03 = v;
                        break;
                    case "TXT04":
                        mapper[i] = (e, v) => e.TXT04 = v;
                        break;
                    case "NUM01":
                        mapper[i] = (e, v) => e.NUM01 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM02":
                        mapper[i] = (e, v) => e.NUM02 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM03":
                        mapper[i] = (e, v) => e.NUM03 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NUM04":
                        mapper[i] = (e, v) => e.NUM04 = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
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
