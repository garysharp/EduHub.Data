using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Specialist Subjects Data Set
    /// </summary>
    public sealed partial class SSDataSet : SetBase<SS>
    {
        private Lazy<Dictionary<string, SS>> SSKEYIndex;

        private Lazy<Dictionary<string, IReadOnlyList<SSHG>>> SSHG_SUBJECTForeignIndex;

        internal SSDataSet(EduHubContext Context)
            : base(Context)
        {
            SSKEYIndex = new Lazy<Dictionary<string, SS>>(() => this.ToDictionary(e => e.SSKEY));

            SSHG_SUBJECTForeignIndex =
                new Lazy<Dictionary<string, IReadOnlyList<SSHG>>>(() =>
                    Context.SSHG
                          .Where(e => e.SUBJECT != null)
                          .GroupBy(e => e.SUBJECT)
                          .ToDictionary(g => g.Key, g => (IReadOnlyList<SSHG>)g.ToList()
                          .AsReadOnly()));

        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SS"; } }

        /// <summary>
        /// Find SS by SSKEY key field
        /// </summary>
        /// <param name="Key">SSKEY value used to find SS</param>
        /// <returns>Related SS entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SSKEY value didn't match any SS entities</exception>
        public SS FindBySSKEY(string Key)
        {
            SS result;
            if (SSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SS by SSKEY key field
        /// </summary>
        /// <param name="Key">SSKEY value used to find SS</param>
        /// <param name="Value">Related SS entity</param>
        /// <returns>True if the SS entity is found</returns>
        public bool TryFindBySSKEY(string Key, out SS Value)
        {
            return SSKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SS by SSKEY key field
        /// </summary>
        /// <param name="Key">SSKEY value used to find SS</param>
        /// <returns>Related SS entity, or null if not found</returns>
        public SS TryFindBySSKEY(string Key)
        {
            SS result;
            if (SSKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find all SSHG (Specialist Subjects per Home Group) entities by [SSHG.SUBJECT]-&gt;[SS.SSKEY]
        /// </summary>
        /// <param name="SSKEY">SSKEY value used to find SSHG entities</param>
        /// <returns>A list of related SSHG entities</returns>
        public IReadOnlyList<SSHG> FindSSHGBySUBJECT(string SSKEY)
        {
            IReadOnlyList<SSHG> result;
            if (SSHG_SUBJECTForeignIndex.Value.TryGetValue(SSKEY, out result))
            {
                return result;
            }
            else
            {
                return new List<SSHG>().AsReadOnly();
            }
        }

        /// <summary>
        /// Attempt to find all SSHG entities by [SSHG.SUBJECT]-&gt;[SS.SSKEY]
        /// </summary>
        /// <param name="SSKEY">SSKEY value used to find SSHG entities</param>
        /// <param name="Value">A list of related SSHG entities</param>
        /// <returns>True if any SSHG entities are found</returns>
        public bool TryFindSSHGBySUBJECT(string SSKEY, out IReadOnlyList<SSHG> Value)
        {
            return SSHG_SUBJECTForeignIndex.Value.TryGetValue(SSKEY, out Value);
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SS" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SS" /> fields for each CSV column header</returns>
        protected override Action<SS, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SS, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SSKEY":
                        mapper[i] = (e, v) => e.SSKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FROM_HOMEGROUP":
                        mapper[i] = (e, v) => e.FROM_HOMEGROUP = v;
                        break;
                    case "TO_HOMEGROUP":
                        mapper[i] = (e, v) => e.TO_HOMEGROUP = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "DEFAULT_TEACHER":
                        mapper[i] = (e, v) => e.DEFAULT_TEACHER = v;
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
