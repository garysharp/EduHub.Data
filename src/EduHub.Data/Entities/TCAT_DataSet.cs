using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Staff Absence Types Data Set
    /// </summary>
    public sealed class TCAT_DataSet : SetBase<TCAT_Entity>
    {
        private Lazy<Dictionary<string, TCAT_Entity>> TCATKEY_Index;

        internal TCAT_DataSet(EduHubContext Context)
            : base(Context)
        {
            TCATKEY_Index = new Lazy<Dictionary<string, TCAT_Entity>>(() => this.ToDictionary(e => e.TCATKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "TCAT"; } }

        /// <summary>
        /// Find TCAT by TCATKEY key field
        /// </summary>
        /// <param name="Key">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TCATKEY value didn't match any TCAT entities</exception>
        public TCAT_Entity FindByTCATKEY(string Key)
        {
            TCAT_Entity result;
            if (TCATKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY key field
        /// </summary>
        /// <param name="Key">TCATKEY value used to find TCAT</param>
        /// <param name="Value">Related TCAT entity</param>
        /// <returns>True if the TCAT Entity is found</returns>
        public bool TryFindByTCATKEY(string Key, out TCAT_Entity Value)
        {
            return TCATKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TCAT by TCATKEY key field
        /// </summary>
        /// <param name="Key">TCATKEY value used to find TCAT</param>
        /// <returns>Related TCAT entity, or null if not found</returns>
        public TCAT_Entity TryFindByTCATKEY(string Key)
        {
            TCAT_Entity result;
            if (TCATKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<TCAT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TCAT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TCATKEY":
                        mapper[i] = (e, v) => e.TCATKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
