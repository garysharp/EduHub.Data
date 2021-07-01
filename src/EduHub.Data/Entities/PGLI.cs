using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Import
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PGLI : EduHubEntity
    {

        #region Navigation Property Cache

        private PGID Cache_FILE_ID_PGID;
        private GL Cache_CODE_GL;

        #endregion

        /// <inheritdoc />
        public override DateTime? EntityLastModified
        {
            get
            {
                return LW_DATE;
            }
        }

        #region Field Properties

        /// <summary>
        /// Transaction ID
        /// </summary>
        public int TID { get; internal set; }

        /// <summary>
        /// File from which this record was imported
        /// </summary>
        public int FILE_ID { get; internal set; }

        /// <summary>
        /// General Ledger Code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CODE { get; internal set; }

        /// <summary>
        /// Batch number
        /// </summary>
        public int TRBATCH { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public int TRPERD { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TRTYPE { get; internal set; }

        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime TRDATE { get; internal set; }

        /// <summary>
        /// Transaction reference
        /// [Alphanumeric (10)]
        /// </summary>
        public string TRREF { get; internal set; }

        /// <summary>
        /// Transaction amount
        /// </summary>
        public decimal TRAMT { get; internal set; }

        /// <summary>
        /// Transaction description
        /// [Alphanumeric (30)]
        /// </summary>
        public string TRDET { get; internal set; }

        /// <summary>
        /// Ledger type eg DF, IV, AR, CR, DM
        /// [Uppercase Alphanumeric (2)]
        /// </summary>
        public string TRXLEDGER { get; internal set; }

        /// <summary>
        /// Not used in JX leave for
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TRBANK { get; internal set; }

        /// <summary>
        /// Payee for cheques
        /// [Alphanumeric (30)]
        /// </summary>
        public string PAYEE { get; internal set; }

        /// <summary>
        /// GST Dollar amount for this
        /// transaction
        /// </summary>
        public decimal GST_AMOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal TRNETT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal TRGROSS { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? WITHHOLD_AMOUNT { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? DEBIT_TOTAL { get; internal set; }

        /// <summary>
        /// &lt;No documentation available&gt;
        /// </summary>
        public decimal? CREDIT_TOTAL { get; internal set; }

        /// <summary>
        /// For every transaction there is a subprogram
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }

        /// <summary>
        /// A subprogram always belongs to a program
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string GLPROGRAM { get; internal set; }

        /// <summary>
        /// Transaction might belong to an Initiative
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string INITIATIVE { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// PGID (General Ledger Import Details) related entity by [PGLI.FILE_ID]-&gt;[PGID.GLID]
        /// File from which this record was imported
        /// </summary>
        public PGID FILE_ID_PGID
        {
            get
            {
                if (Cache_FILE_ID_PGID == null)
                {
                    Cache_FILE_ID_PGID = Context.PGID.FindByGLID(FILE_ID);
                }

                return Cache_FILE_ID_PGID;
            }
        }

        /// <summary>
        /// GL (General Ledger) related entity by [PGLI.CODE]-&gt;[GL.CODE]
        /// General Ledger Code
        /// </summary>
        public GL CODE_GL
        {
            get
            {
                if (Cache_CODE_GL == null)
                {
                    Cache_CODE_GL = Context.GL.FindByCODE(CODE);
                }

                return Cache_CODE_GL;
            }
        }

        #endregion

    }
}
