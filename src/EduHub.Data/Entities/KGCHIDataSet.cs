using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group History Data Set
    /// </summary>
    public sealed class KGCHIDataSet : SetBase<KGCHI>
    {
        private Lazy<Dictionary<int, KGCHI>> KGCHIKEYIndex;

        internal KGCHIDataSet(EduHubContext Context)
            : base(Context)
        {
            KGCHIKEYIndex = new Lazy<Dictionary<int, KGCHI>>(() => this.ToDictionary(e => e.KGCHIKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KGCHI"; } }

        /// <summary>
        /// Find KGCHI by KGCHIKEY key field
        /// </summary>
        /// <param name="Key">KGCHIKEY value used to find KGCHI</param>
        /// <returns>Related KGCHI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGCHIKEY value didn't match any KGCHI entities</exception>
        public KGCHI FindByKGCHIKEY(int Key)
        {
            KGCHI result;
            if (KGCHIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCHIKEY key field
        /// </summary>
        /// <param name="Key">KGCHIKEY value used to find KGCHI</param>
        /// <param name="Value">Related KGCHI entity</param>
        /// <returns>True if the KGCHI Entity is found</returns>
        public bool TryFindByKGCHIKEY(int Key, out KGCHI Value)
        {
            return KGCHIKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGCHI by KGCHIKEY key field
        /// </summary>
        /// <param name="Key">KGCHIKEY value used to find KGCHI</param>
        /// <returns>Related KGCHI entity, or null if not found</returns>
        public KGCHI TryFindByKGCHIKEY(int Key)
        {
            KGCHI result;
            if (KGCHIKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KGCHI, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGCHI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGCHIKEY":
                        mapper[i] = (e, v) => e.KGCHIKEY = int.Parse(v);
                        break;
                    case "KGCKEY":
                        mapper[i] = (e, v) => e.KGCKEY = v;
                        break;
                    case "CREATION_USER":
                        mapper[i] = (e, v) => e.CREATION_USER = v;
                        break;
                    case "CREATION_DATE":
                        mapper[i] = (e, v) => e.CREATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CREATION_TIME":
                        mapper[i] = (e, v) => e.CREATION_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "OBSOLETE_USER":
                        mapper[i] = (e, v) => e.OBSOLETE_USER = v;
                        break;
                    case "OBSOLETE_DATE":
                        mapper[i] = (e, v) => e.OBSOLETE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "OBSOLETE_TIME":
                        mapper[i] = (e, v) => e.OBSOLETE_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAMPUS":
                        mapper[i] = (e, v) => e.CAMPUS = v;
                        break;
                    case "TEACHER":
                        mapper[i] = (e, v) => e.TEACHER = v;
                        break;
                    case "TEACHER_B":
                        mapper[i] = (e, v) => e.TEACHER_B = v;
                        break;
                    case "ROOM":
                        mapper[i] = (e, v) => e.ROOM = v;
                        break;
                    case "CHANGE_MADE":
                        mapper[i] = (e, v) => e.CHANGE_MADE = v;
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
