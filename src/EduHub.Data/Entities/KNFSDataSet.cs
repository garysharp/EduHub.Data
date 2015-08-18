using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family/Student ID Sequence Numbers Data Set
    /// </summary>
    public sealed class KNFSDataSet : SetBase<KNFS>
    {
        private Lazy<Dictionary<string, KNFS>> KNFSKEYIndex;

        internal KNFSDataSet(EduHubContext Context)
            : base(Context)
        {
            KNFSKEYIndex = new Lazy<Dictionary<string, KNFS>>(() => this.ToDictionary(e => e.KNFSKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KNFS"; } }

        /// <summary>
        /// Find KNFS by KNFSKEY key field
        /// </summary>
        /// <param name="Key">KNFSKEY value used to find KNFS</param>
        /// <returns>Related KNFS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KNFSKEY value didn't match any KNFS entities</exception>
        public KNFS FindByKNFSKEY(string Key)
        {
            KNFS result;
            if (KNFSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KNFS by KNFSKEY key field
        /// </summary>
        /// <param name="Key">KNFSKEY value used to find KNFS</param>
        /// <param name="Value">Related KNFS entity</param>
        /// <returns>True if the KNFS Entity is found</returns>
        public bool TryFindByKNFSKEY(string Key, out KNFS Value)
        {
            return KNFSKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KNFS by KNFSKEY key field
        /// </summary>
        /// <param name="Key">KNFSKEY value used to find KNFS</param>
        /// <returns>Related KNFS entity, or null if not found</returns>
        public KNFS TryFindByKNFSKEY(string Key)
        {
            KNFS result;
            if (KNFSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KNFS, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KNFS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KNFSKEY":
                        mapper[i] = (e, v) => e.KNFSKEY = v;
                        break;
                    case "NEXT_NUMBER":
                        mapper[i] = (e, v) => e.NEXT_NUMBER = v;
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
