using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Initiatives Data Set
    /// </summary>
    public sealed class KGLINITDataSet : SetBase<KGLINIT>
    {
        private Lazy<Dictionary<string, KGLINIT>> INITIATIVEIndex;

        internal KGLINITDataSet(EduHubContext Context)
            : base(Context)
        {
            INITIATIVEIndex = new Lazy<Dictionary<string, KGLINIT>>(() => this.ToDictionary(e => e.INITIATIVE));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGLINIT"; } }

        /// <summary>
        /// Find KGLINIT by INITIATIVE key field
        /// </summary>
        /// <param name="Key">INITIATIVE value used to find KGLINIT</param>
        /// <returns>Related KGLINIT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">INITIATIVE value didn't match any KGLINIT entities</exception>
        public KGLINIT FindByINITIATIVE(string Key)
        {
            KGLINIT result;
            if (INITIATIVEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGLINIT by INITIATIVE key field
        /// </summary>
        /// <param name="Key">INITIATIVE value used to find KGLINIT</param>
        /// <param name="Value">Related KGLINIT entity</param>
        /// <returns>True if the KGLINIT entity is found</returns>
        public bool TryFindByINITIATIVE(string Key, out KGLINIT Value)
        {
            return INITIATIVEIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGLINIT by INITIATIVE key field
        /// </summary>
        /// <param name="Key">INITIATIVE value used to find KGLINIT</param>
        /// <returns>Related KGLINIT entity, or null if not found</returns>
        public KGLINIT TryFindByINITIATIVE(string Key)
        {
            KGLINIT result;
            if (INITIATIVEIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLINIT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLINIT" /> fields for each CSV column header</returns>
        protected override Action<KGLINIT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLINIT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
