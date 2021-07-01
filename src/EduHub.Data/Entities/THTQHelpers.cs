using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHub.Data.Entities
{
    partial class THTQ
    {

        #region Navigation Property Cache

        private THTN Cache_QCOL_THTN;
        private THTN Cache_QROW_THTN;

        #endregion

        #region Foreign Navigation Properties

        private IReadOnlyList<TTTG> Cache_IDENT_TTTG_IDENT;
        private IReadOnlyList<STMA> Cache_IDENT_STMA_IDENT;

        #endregion

        #region Navigation Properties

        /// <summary>
        /// THTN (Timetable Labels) related entity by [THTQ.QKEY]=[THTN.QKEY] AND [THTN.LABEL_TYPE]='C' AND [THTQ.QCOL]-&gt;[THTN.LABEL_NUMBER]
        /// Quilt cell col
        /// </summary>
        public THTN QCOL_THTN
        {
            get
            {
                if (Cache_QCOL_THTN == null)
                {
                    Cache_QCOL_THTN = Context.THTN.TryFindByQKEY(QKEY).FirstOrDefault(thtn => thtn.LABEL_TYPE == "C" && thtn.LABEL_NUMBER == QCOL);
                }

                return Cache_QCOL_THTN;
            }
        }

        /// <summary>
        /// THTN (Timetable Labels) related entity by [THTQ.QKEY]=[THTN.QKEY] AND [THTN.LABEL_TYPE]='R' AND [THTQ.QROW]-&gt;[THTN.LABEL_NUMBER]
        /// Quilt cell col
        /// </summary>
        public THTN QROW_THTN
        {
            get
            {
                if (Cache_QROW_THTN == null)
                {
                    Cache_QROW_THTN = Context.THTN.TryFindByQKEY(QKEY).FirstOrDefault(thtn => thtn.LABEL_TYPE == "R" && thtn.LABEL_NUMBER == QROW);
                }

                return Cache_QROW_THTN;
            }
        }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// TTTG (Grid Subjects) related entities by [THTQ.IDENT]-&gt;[TTTG.IDENT]
        /// Unique subject identifier
        /// </summary>
        public IReadOnlyList<TTTG> IDENT_TTTG_IDENT
        {
            get
            {
                if (Cache_IDENT_TTTG_IDENT == null &&
                    !Context.TTTG.TryFindByIDENT(IDENT, out Cache_IDENT_TTTG_IDENT))
                {
                    Cache_IDENT_TTTG_IDENT = new List<TTTG>().AsReadOnly();
                }

                return Cache_IDENT_TTTG_IDENT;
            }
        }

        /// <summary>
        /// STMA (Subject Selections &amp; Marks) related entities by [THTQ.IDENT]-&gt;[STMA.IDENT]
        /// Unique subject identifier
        /// </summary>
        public IReadOnlyList<STMA> IDENT_STMA_IDENT
        {
            get
            {
                if (Cache_IDENT_STMA_IDENT == null &&
                    !Context.STMA.TryFindByIDENT(IDENT, out Cache_IDENT_STMA_IDENT))
                {
                    Cache_IDENT_STMA_IDENT = new List<STMA>().AsReadOnly();
                }

                return Cache_IDENT_STMA_IDENT;
            }
        }

        #endregion

    }
}
