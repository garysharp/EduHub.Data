using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Note Categories Data Set
    /// </summary>
    public sealed partial class KPNDataSet : SetBase<KPN>
    {
        private Lazy<Dictionary<string, KPN>> KPNKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<PEPY>>> PEPY_PURPOSEForeignIndex;

        internal KPNDataSet(EduHubContext Context)
            : base(Context)
        {
            KPNKEYIndex = new Lazy<Dictionary<string, KPN>>(() => this.ToDictionary(e => e.KPNKEY));

            PEPY_PURPOSEForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<PEPY>>>(() =>
                    Context.PEPY
                          .Where(e => e.PURPOSE != null)
                          .GroupBy(e => e.PURPOSE)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<PEPY>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KPN"; } }

        /// <summary>
        /// Find KPN by KPNKEY key field
        /// </summary>
        /// <param name="Key">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KPNKEY value didn't match any KPN entities</exception>
        public KPN FindByKPNKEY(string Key)
        {
            KPN result;
            if (KPNKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY key field
        /// </summary>
        /// <param name="Key">KPNKEY value used to find KPN</param>
        /// <param name="Value">Related KPN entity</param>
        /// <returns>True if the KPN entity is found</returns>
        public bool TryFindByKPNKEY(string Key, out KPN Value)
        {
            return KPNKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KPN by KPNKEY key field
        /// </summary>
        /// <param name="Key">KPNKEY value used to find KPN</param>
        /// <returns>Related KPN entity, or null if not found</returns>
        public KPN TryFindByKPNKEY(string Key)
        {
            KPN result;
            if (KPNKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all PEPY (Employee History) entities by [PEPY.PURPOSE]-&gt;[KPN.KPNKEY]
        /// </summary>
        /// <param name="KPNKEY">KPNKEY value used to find PEPY entities</param>
        /// <returns>A list of related PEPY entities</returns>
        public IReadOnlyList<PEPY> FindPEPYByPURPOSE(string KPNKEY)
        {
            IReadOnlyList<PEPY> result;
            if (PEPY_PURPOSEForeignIndex.Value.TryGetValue(KPNKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<PEPY>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all PEPY entities by [PEPY.PURPOSE]-&gt;[KPN.KPNKEY]
        /// </summary>
        /// <param name="KPNKEY">KPNKEY value used to find PEPY entities</param>
        /// <param name="Value">A list of related PEPY entities</param>
        /// <returns>True if any PEPY entities are found</returns>
        public bool TryFindPEPYByPURPOSE(string KPNKEY, out IReadOnlyList<PEPY> Value)
        {
            return PEPY_PURPOSEForeignIndex.Value.TryGetValue(KPNKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPN" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPN" /> fields for each CSV column header</returns>
        protected override Action<KPN, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPN, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPNKEY":
                        mapper[i] = (e, v) => e.KPNKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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
