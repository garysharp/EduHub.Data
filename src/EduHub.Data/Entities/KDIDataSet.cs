using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// VELS Dimensions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDIDataSet : SetBase<KDI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KDI"; } }

        internal KDIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KDIKEY = new Lazy<Dictionary<string, KDI>>(() => this.ToDictionary(i => i.KDIKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDI" /> fields for each CSV column header</returns>
        protected override Action<KDI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDIKEY":
                        mapper[i] = (e, v) => e.KDIKEY = v;
                        break;
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MIN_SCORE":
                        mapper[i] = (e, v) => e.MIN_SCORE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "MAX_SCORE":
                        mapper[i] = (e, v) => e.MAX_SCORE = v == null ? (double?)null : double.Parse(v);
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

        #region Index Fields

        private Lazy<Dictionary<string, KDI>> Index_KDIKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDI FindByKDIKEY(string KDIKEY)
        {
            return Index_KDIKEY.Value[KDIKEY];
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <param name="Value">Related KDI entity</param>
        /// <returns>True if the related KDI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKDIKEY(string KDIKEY, out KDI Value)
        {
            return Index_KDIKEY.Value.TryGetValue(KDIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDI TryFindByKDIKEY(string KDIKEY)
        {
            KDI value;
            if (Index_KDIKEY.Value.TryGetValue(KDIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
