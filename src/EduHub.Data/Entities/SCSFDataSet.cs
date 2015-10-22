using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// CSF Strands Data Set
    /// </summary>
    public sealed partial class SCSFDataSet : SetBase<SCSF>
    {
        private Lazy<Dictionary<string, SCSF>> SCSFKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>> SCSFAG_SCSFKEYForeignIndex;

        internal SCSFDataSet(EduHubContext Context)
            : base(Context)
        {
            SCSFKEYIndex = new Lazy<Dictionary<string, SCSF>>(() => this.ToDictionary(e => e.SCSFKEY));

            SCSFAG_SCSFKEYForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SCSFAG>>>(() =>
                    Context.SCSFAG
                          .Where(e => e.SCSFKEY != null)
                          .GroupBy(e => e.SCSFKEY)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SCSFAG>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCSF"; } }

        /// <summary>
        /// Find SCSF by SCSFKEY key field
        /// </summary>
        /// <param name="Key">SCSFKEY value used to find SCSF</param>
        /// <returns>Related SCSF entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCSFKEY value didn't match any SCSF entities</exception>
        public SCSF FindBySCSFKEY(string Key)
        {
            SCSF result;
            if (SCSFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCSF by SCSFKEY key field
        /// </summary>
        /// <param name="Key">SCSFKEY value used to find SCSF</param>
        /// <param name="Value">Related SCSF entity</param>
        /// <returns>True if the SCSF entity is found</returns>
        public bool TryFindBySCSFKEY(string Key, out SCSF Value)
        {
            return SCSFKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCSF by SCSFKEY key field
        /// </summary>
        /// <param name="Key">SCSFKEY value used to find SCSF</param>
        /// <returns>Related SCSF entity, or null if not found</returns>
        public SCSF TryFindBySCSFKEY(string Key)
        {
            SCSF result;
            if (SCSFKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SCSFAG (CSF Data Aggregates) entities by [SCSFAG.SCSFKEY]-&gt;[SCSF.SCSFKEY]
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG entities</param>
        /// <returns>A list of related SCSFAG entities</returns>
        public IReadOnlyList<SCSFAG> FindSCSFAGBySCSFKEY(string SCSFKEY)
        {
            IReadOnlyList<SCSFAG> result;
            if (SCSFAG_SCSFKEYForeignIndex.Value.TryGetValue(SCSFKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SCSFAG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SCSFAG entities by [SCSFAG.SCSFKEY]-&gt;[SCSF.SCSFKEY]
        /// </summary>
        /// <param name="SCSFKEY">SCSFKEY value used to find SCSFAG entities</param>
        /// <param name="Value">A list of related SCSFAG entities</param>
        /// <returns>True if any SCSFAG entities are found</returns>
        public bool TryFindSCSFAGBySCSFKEY(string SCSFKEY, out IReadOnlyList<SCSFAG> Value)
        {
            return SCSFAG_SCSFKEYForeignIndex.Value.TryGetValue(SCSFKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCSF" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCSF" /> fields for each CSV column header</returns>
        protected override Action<SCSF, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCSF, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCSFKEY":
                        mapper[i] = (e, v) => e.SCSFKEY = v;
                        break;
                    case "KLA":
                        mapper[i] = (e, v) => e.KLA = v;
                        break;
                    case "STRAND":
                        mapper[i] = (e, v) => e.STRAND = v;
                        break;
                    case "SUB_STRAND":
                        mapper[i] = (e, v) => e.SUB_STRAND = v;
                        break;
                    case "ENABLED":
                        mapper[i] = (e, v) => e.ENABLED = v;
                        break;
                    case "DEET_REQUIRED":
                        mapper[i] = (e, v) => e.DEET_REQUIRED = v;
                        break;
                    case "LOW_LEVEL":
                        mapper[i] = (e, v) => e.LOW_LEVEL = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "HIGH_LEVEL":
                        mapper[i] = (e, v) => e.HIGH_LEVEL = v == null ? (short?)null : short.Parse(v);
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
