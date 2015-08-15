using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Doctors Data Set
    /// </summary>
    public sealed class KCD_DataSet : SetBase<KCD_Entity>
    {
        private Lazy<Dictionary<string, KCD_Entity>> KCDKEY_Index;

        internal KCD_DataSet(EduHubContext Context)
            : base(Context)
        {
            KCDKEY_Index = new Lazy<Dictionary<string, KCD_Entity>>(() => this.ToDictionary(e => e.KCDKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KCD"; } }

        /// <summary>
        /// Find KCD by KCDKEY key field
        /// </summary>
        /// <param name="Key">KCDKEY value used to find KCD</param>
        /// <returns>Related KCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KCDKEY value didn't match any KCD entities</exception>
        public KCD_Entity FindByKCDKEY(string Key)
        {
            KCD_Entity result;
            if (KCDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KCD by KCDKEY key field
        /// </summary>
        /// <param name="Key">KCDKEY value used to find KCD</param>
        /// <param name="Value">Related KCD entity</param>
        /// <returns>True if the KCD Entity is found</returns>
        public bool TryFindByKCDKEY(string Key, out KCD_Entity Value)
        {
            return KCDKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KCD by KCDKEY key field
        /// </summary>
        /// <param name="Key">KCDKEY value used to find KCD</param>
        /// <returns>Related KCD entity, or null if not found</returns>
        public KCD_Entity TryFindByKCDKEY(string Key)
        {
            KCD_Entity result;
            if (KCDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KCD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KCD_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCDKEY":
                        mapper[i] = (e, v) => e.KCDKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DR_GROUP":
                        mapper[i] = (e, v) => e.DR_GROUP = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "SUBURB":
                        mapper[i] = (e, v) => e.SUBURB = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "KAP_LINK":
                        mapper[i] = (e, v) => e.KAP_LINK = v;
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
