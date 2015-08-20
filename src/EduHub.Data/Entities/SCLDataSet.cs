using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Classes Data Set
    /// </summary>
    public sealed class SCLDataSet : SetBase<SCL>
    {
        private Lazy<Dictionary<string, SCL>> SCLKEYIndex;

        internal SCLDataSet(EduHubContext Context)
            : base(Context)
        {
            SCLKEYIndex = new Lazy<Dictionary<string, SCL>>(() => this.ToDictionary(e => e.SCLKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCL"; } }

        /// <summary>
        /// Find SCL by SCLKEY key field
        /// </summary>
        /// <param name="Key">SCLKEY value used to find SCL</param>
        /// <returns>Related SCL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCLKEY value didn't match any SCL entities</exception>
        public SCL FindBySCLKEY(string Key)
        {
            SCL result;
            if (SCLKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCL by SCLKEY key field
        /// </summary>
        /// <param name="Key">SCLKEY value used to find SCL</param>
        /// <param name="Value">Related SCL entity</param>
        /// <returns>True if the SCL entity is found</returns>
        public bool TryFindBySCLKEY(string Key, out SCL Value)
        {
            return SCLKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCL by SCLKEY key field
        /// </summary>
        /// <param name="Key">SCLKEY value used to find SCL</param>
        /// <returns>Related SCL entity, or null if not found</returns>
        public SCL TryFindBySCLKEY(string Key)
        {
            SCL result;
            if (SCLKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCL" /> fields for each CSV column header</returns>
        protected override Action<SCL, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCLKEY":
                        mapper[i] = (e, v) => e.SCLKEY = v;
                        break;
                    case "QUILT":
                        mapper[i] = (e, v) => e.QUILT = v;
                        break;
                    case "SUBJECT":
                        mapper[i] = (e, v) => e.SUBJECT = v;
                        break;
                    case "CLASS":
                        mapper[i] = (e, v) => e.CLASS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TEACHER01":
                        mapper[i] = (e, v) => e.TEACHER01 = v;
                        break;
                    case "TEACHER02":
                        mapper[i] = (e, v) => e.TEACHER02 = v;
                        break;
                    case "ROOM01":
                        mapper[i] = (e, v) => e.ROOM01 = v;
                        break;
                    case "ROOM02":
                        mapper[i] = (e, v) => e.ROOM02 = v;
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRINT_FLAGS01":
                        mapper[i] = (e, v) => e.PRINT_FLAGS01 = v;
                        break;
                    case "PRINT_FLAGS02":
                        mapper[i] = (e, v) => e.PRINT_FLAGS02 = v;
                        break;
                    case "PRINT_FLAGS03":
                        mapper[i] = (e, v) => e.PRINT_FLAGS03 = v;
                        break;
                    case "PERIOD_ABSENCES":
                        mapper[i] = (e, v) => e.PERIOD_ABSENCES = v;
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ALIAS":
                        mapper[i] = (e, v) => e.ALIAS = v;
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
