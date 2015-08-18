using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Assets - Departments Data Set
    /// </summary>
    public sealed class AKDDataSet : SetBase<AKD>
    {
        private Lazy<Dictionary<string, AKD>> DEPARTMENTIndex;

        internal AKDDataSet(EduHubContext Context)
            : base(Context)
        {
            DEPARTMENTIndex = new Lazy<Dictionary<string, AKD>>(() => this.ToDictionary(e => e.DEPARTMENT));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "AKD"; } }

        /// <summary>
        /// Find AKD by DEPARTMENT key field
        /// </summary>
        /// <param name="Key">DEPARTMENT value used to find AKD</param>
        /// <returns>Related AKD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">DEPARTMENT value didn't match any AKD entities</exception>
        public AKD FindByDEPARTMENT(string Key)
        {
            AKD result;
            if (DEPARTMENTIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find AKD by DEPARTMENT key field
        /// </summary>
        /// <param name="Key">DEPARTMENT value used to find AKD</param>
        /// <param name="Value">Related AKD entity</param>
        /// <returns>True if the AKD Entity is found</returns>
        public bool TryFindByDEPARTMENT(string Key, out AKD Value)
        {
            return DEPARTMENTIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find AKD by DEPARTMENT key field
        /// </summary>
        /// <param name="Key">DEPARTMENT value used to find AKD</param>
        /// <returns>Related AKD entity, or null if not found</returns>
        public AKD TryFindByDEPARTMENT(string Key)
        {
            AKD result;
            if (DEPARTMENTIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<AKD, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<AKD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "DEPARTMENT":
                        mapper[i] = (e, v) => e.DEPARTMENT = v;
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
