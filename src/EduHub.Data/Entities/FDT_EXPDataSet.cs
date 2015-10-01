using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Financial Data Export Data Set
    /// </summary>
    public sealed class FDT_EXPDataSet : SetBase<FDT_EXP>
    {
        private Lazy<Dictionary<int, FDT_EXP>> TIDIndex;

        internal FDT_EXPDataSet(EduHubContext Context)
            : base(Context)
        {
            TIDIndex = new Lazy<Dictionary<int, FDT_EXP>>(() => this.ToDictionary(e => e.TID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "FDT_EXP"; } }

        /// <summary>
        /// Find FDT_EXP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find FDT_EXP</param>
        /// <returns>Related FDT_EXP entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TID value didn't match any FDT_EXP entities</exception>
        public FDT_EXP FindByTID(int Key)
        {
            FDT_EXP result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find FDT_EXP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find FDT_EXP</param>
        /// <param name="Value">Related FDT_EXP entity</param>
        /// <returns>True if the FDT_EXP entity is found</returns>
        public bool TryFindByTID(int Key, out FDT_EXP Value)
        {
            return TIDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find FDT_EXP by TID key field
        /// </summary>
        /// <param name="Key">TID value used to find FDT_EXP</param>
        /// <returns>Related FDT_EXP entity, or null if not found</returns>
        public FDT_EXP TryFindByTID(int Key)
        {
            FDT_EXP result;
            if (TIDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="FDT_EXP" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="FDT_EXP" /> fields for each CSV column header</returns>
        protected override Action<FDT_EXP, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<FDT_EXP, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "DEST":
                        mapper[i] = (e, v) => e.DEST = v;
                        break;
                    case "DEST_ID":
                        mapper[i] = (e, v) => e.DEST_ID = v;
                        break;
                    case "SOURCE":
                        mapper[i] = (e, v) => e.SOURCE = v;
                        break;
                    case "SOURCE_KEY":
                        mapper[i] = (e, v) => e.SOURCE_KEY = v;
                        break;
                    case "NOTES":
                        mapper[i] = (e, v) => e.NOTES = v;
                        break;
                    case "EXP_DATE":
                        mapper[i] = (e, v) => e.EXP_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "EXP_TIME":
                        mapper[i] = (e, v) => e.EXP_TIME = v == null ? (short?)null : short.Parse(v);
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
