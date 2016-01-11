using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Tax Scales Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PXDataSet : EduHubDataSet<PX>
    {
        /// <inheritdoc />
        public override string Name { get { return "PX"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PXDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_PXKEY = new Lazy<Dictionary<short, PX>>(() => this.ToDictionary(i => i.PXKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PX" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PX" /> fields for each CSV column header</returns>
        internal override Action<PX, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PX, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PXKEY":
                        mapper[i] = (e, v) => e.PXKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION01":
                        mapper[i] = (e, v) => e.DESCRIPTION01 = v;
                        break;
                    case "DESCRIPTION02":
                        mapper[i] = (e, v) => e.DESCRIPTION02 = v;
                        break;
                    case "ENDINCOME01":
                        mapper[i] = (e, v) => e.ENDINCOME01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME02":
                        mapper[i] = (e, v) => e.ENDINCOME02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME03":
                        mapper[i] = (e, v) => e.ENDINCOME03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME04":
                        mapper[i] = (e, v) => e.ENDINCOME04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME05":
                        mapper[i] = (e, v) => e.ENDINCOME05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME06":
                        mapper[i] = (e, v) => e.ENDINCOME06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME07":
                        mapper[i] = (e, v) => e.ENDINCOME07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME08":
                        mapper[i] = (e, v) => e.ENDINCOME08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME09":
                        mapper[i] = (e, v) => e.ENDINCOME09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME10":
                        mapper[i] = (e, v) => e.ENDINCOME10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME11":
                        mapper[i] = (e, v) => e.ENDINCOME11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME12":
                        mapper[i] = (e, v) => e.ENDINCOME12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME13":
                        mapper[i] = (e, v) => e.ENDINCOME13 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME14":
                        mapper[i] = (e, v) => e.ENDINCOME14 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME15":
                        mapper[i] = (e, v) => e.ENDINCOME15 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME16":
                        mapper[i] = (e, v) => e.ENDINCOME16 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME17":
                        mapper[i] = (e, v) => e.ENDINCOME17 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME18":
                        mapper[i] = (e, v) => e.ENDINCOME18 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME19":
                        mapper[i] = (e, v) => e.ENDINCOME19 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ENDINCOME20":
                        mapper[i] = (e, v) => e.ENDINCOME20 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COEFA01":
                        mapper[i] = (e, v) => e.COEFA01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA02":
                        mapper[i] = (e, v) => e.COEFA02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA03":
                        mapper[i] = (e, v) => e.COEFA03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA04":
                        mapper[i] = (e, v) => e.COEFA04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA05":
                        mapper[i] = (e, v) => e.COEFA05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA06":
                        mapper[i] = (e, v) => e.COEFA06 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA07":
                        mapper[i] = (e, v) => e.COEFA07 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA08":
                        mapper[i] = (e, v) => e.COEFA08 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA09":
                        mapper[i] = (e, v) => e.COEFA09 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA10":
                        mapper[i] = (e, v) => e.COEFA10 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA11":
                        mapper[i] = (e, v) => e.COEFA11 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA12":
                        mapper[i] = (e, v) => e.COEFA12 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA13":
                        mapper[i] = (e, v) => e.COEFA13 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA14":
                        mapper[i] = (e, v) => e.COEFA14 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA15":
                        mapper[i] = (e, v) => e.COEFA15 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA16":
                        mapper[i] = (e, v) => e.COEFA16 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA17":
                        mapper[i] = (e, v) => e.COEFA17 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA18":
                        mapper[i] = (e, v) => e.COEFA18 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA19":
                        mapper[i] = (e, v) => e.COEFA19 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFA20":
                        mapper[i] = (e, v) => e.COEFA20 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB01":
                        mapper[i] = (e, v) => e.COEFB01 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB02":
                        mapper[i] = (e, v) => e.COEFB02 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB03":
                        mapper[i] = (e, v) => e.COEFB03 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB04":
                        mapper[i] = (e, v) => e.COEFB04 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB05":
                        mapper[i] = (e, v) => e.COEFB05 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB06":
                        mapper[i] = (e, v) => e.COEFB06 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB07":
                        mapper[i] = (e, v) => e.COEFB07 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB08":
                        mapper[i] = (e, v) => e.COEFB08 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB09":
                        mapper[i] = (e, v) => e.COEFB09 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB10":
                        mapper[i] = (e, v) => e.COEFB10 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB11":
                        mapper[i] = (e, v) => e.COEFB11 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB12":
                        mapper[i] = (e, v) => e.COEFB12 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB13":
                        mapper[i] = (e, v) => e.COEFB13 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB14":
                        mapper[i] = (e, v) => e.COEFB14 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB15":
                        mapper[i] = (e, v) => e.COEFB15 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB16":
                        mapper[i] = (e, v) => e.COEFB16 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB17":
                        mapper[i] = (e, v) => e.COEFB17 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB18":
                        mapper[i] = (e, v) => e.COEFB18 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB19":
                        mapper[i] = (e, v) => e.COEFB19 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "COEFB20":
                        mapper[i] = (e, v) => e.COEFB20 = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRANSDATE":
                        mapper[i] = (e, v) => e.TRANSDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HECS":
                        mapper[i] = (e, v) => e.HECS = v;
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

        /// <summary>
        /// Merges <see cref="PX" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PX" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PX" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PX}"/> of entities</returns>
        internal override IEnumerable<PX> ApplyDeltaEntities(IEnumerable<PX> Entities, List<PX> DeltaEntities)
        {
            HashSet<short> Index_PXKEY = new HashSet<short>(DeltaEntities.Select(i => i.PXKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.PXKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_PXKEY.Remove(entity.PXKEY);
                            
                            if (entity.PXKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<Dictionary<short, PX>> Index_PXKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PX by PXKEY field
        /// </summary>
        /// <param name="PXKEY">PXKEY value used to find PX</param>
        /// <returns>Related PX entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PX FindByPXKEY(short PXKEY)
        {
            return Index_PXKEY.Value[PXKEY];
        }

        /// <summary>
        /// Attempt to find PX by PXKEY field
        /// </summary>
        /// <param name="PXKEY">PXKEY value used to find PX</param>
        /// <param name="Value">Related PX entity</param>
        /// <returns>True if the related PX entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPXKEY(short PXKEY, out PX Value)
        {
            return Index_PXKEY.Value.TryGetValue(PXKEY, out Value);
        }

        /// <summary>
        /// Attempt to find PX by PXKEY field
        /// </summary>
        /// <param name="PXKEY">PXKEY value used to find PX</param>
        /// <returns>Related PX entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PX TryFindByPXKEY(short PXKEY)
        {
            PX value;
            if (Index_PXKEY.Value.TryGetValue(PXKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PX table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PX]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PX](
        [PXKEY] smallint NOT NULL,
        [DESCRIPTION01] varchar(30) NULL,
        [DESCRIPTION02] varchar(30) NULL,
        [ENDINCOME01] money NULL,
        [ENDINCOME02] money NULL,
        [ENDINCOME03] money NULL,
        [ENDINCOME04] money NULL,
        [ENDINCOME05] money NULL,
        [ENDINCOME06] money NULL,
        [ENDINCOME07] money NULL,
        [ENDINCOME08] money NULL,
        [ENDINCOME09] money NULL,
        [ENDINCOME10] money NULL,
        [ENDINCOME11] money NULL,
        [ENDINCOME12] money NULL,
        [ENDINCOME13] money NULL,
        [ENDINCOME14] money NULL,
        [ENDINCOME15] money NULL,
        [ENDINCOME16] money NULL,
        [ENDINCOME17] money NULL,
        [ENDINCOME18] money NULL,
        [ENDINCOME19] money NULL,
        [ENDINCOME20] money NULL,
        [COEFA01] float NULL,
        [COEFA02] float NULL,
        [COEFA03] float NULL,
        [COEFA04] float NULL,
        [COEFA05] float NULL,
        [COEFA06] float NULL,
        [COEFA07] float NULL,
        [COEFA08] float NULL,
        [COEFA09] float NULL,
        [COEFA10] float NULL,
        [COEFA11] float NULL,
        [COEFA12] float NULL,
        [COEFA13] float NULL,
        [COEFA14] float NULL,
        [COEFA15] float NULL,
        [COEFA16] float NULL,
        [COEFA17] float NULL,
        [COEFA18] float NULL,
        [COEFA19] float NULL,
        [COEFA20] float NULL,
        [COEFB01] float NULL,
        [COEFB02] float NULL,
        [COEFB03] float NULL,
        [COEFB04] float NULL,
        [COEFB05] float NULL,
        [COEFB06] float NULL,
        [COEFB07] float NULL,
        [COEFB08] float NULL,
        [COEFB09] float NULL,
        [COEFB10] float NULL,
        [COEFB11] float NULL,
        [COEFB12] float NULL,
        [COEFB13] float NULL,
        [COEFB14] float NULL,
        [COEFB15] float NULL,
        [COEFB16] float NULL,
        [COEFB17] float NULL,
        [COEFB18] float NULL,
        [COEFB19] float NULL,
        [COEFB20] float NULL,
        [TRANSDATE] datetime NULL,
        [HECS] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PX_Index_PXKEY] PRIMARY KEY CLUSTERED (
            [PXKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="PXDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="PXDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PX"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PX"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PX> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<short> Index_PXKEY = new List<short>();

            foreach (var entity in Entities)
            {
                Index_PXKEY.Add(entity.PXKEY);
            }

            builder.AppendLine("DELETE [dbo].[PX] WHERE");


            // Index_PXKEY
            builder.Append("[PXKEY] IN (");
            for (int index = 0; index < Index_PXKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // PXKEY
                var parameterPXKEY = $"@p{parameterIndex++}";
                builder.Append(parameterPXKEY);
                command.Parameters.Add(parameterPXKEY, SqlDbType.SmallInt).Value = Index_PXKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PX data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PX data set</returns>
        public override EduHubDataSetDataReader<PX> GetDataSetDataReader()
        {
            return new PXDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PX data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PX data set</returns>
        public override EduHubDataSetDataReader<PX> GetDataSetDataReader(List<PX> Entities)
        {
            return new PXDataReader(new EduHubDataSetLoadedReader<PX>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PXDataReader : EduHubDataSetDataReader<PX>
        {
            public PXDataReader(IEduHubDataSetReader<PX> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 68; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // PXKEY
                        return Current.PXKEY;
                    case 1: // DESCRIPTION01
                        return Current.DESCRIPTION01;
                    case 2: // DESCRIPTION02
                        return Current.DESCRIPTION02;
                    case 3: // ENDINCOME01
                        return Current.ENDINCOME01;
                    case 4: // ENDINCOME02
                        return Current.ENDINCOME02;
                    case 5: // ENDINCOME03
                        return Current.ENDINCOME03;
                    case 6: // ENDINCOME04
                        return Current.ENDINCOME04;
                    case 7: // ENDINCOME05
                        return Current.ENDINCOME05;
                    case 8: // ENDINCOME06
                        return Current.ENDINCOME06;
                    case 9: // ENDINCOME07
                        return Current.ENDINCOME07;
                    case 10: // ENDINCOME08
                        return Current.ENDINCOME08;
                    case 11: // ENDINCOME09
                        return Current.ENDINCOME09;
                    case 12: // ENDINCOME10
                        return Current.ENDINCOME10;
                    case 13: // ENDINCOME11
                        return Current.ENDINCOME11;
                    case 14: // ENDINCOME12
                        return Current.ENDINCOME12;
                    case 15: // ENDINCOME13
                        return Current.ENDINCOME13;
                    case 16: // ENDINCOME14
                        return Current.ENDINCOME14;
                    case 17: // ENDINCOME15
                        return Current.ENDINCOME15;
                    case 18: // ENDINCOME16
                        return Current.ENDINCOME16;
                    case 19: // ENDINCOME17
                        return Current.ENDINCOME17;
                    case 20: // ENDINCOME18
                        return Current.ENDINCOME18;
                    case 21: // ENDINCOME19
                        return Current.ENDINCOME19;
                    case 22: // ENDINCOME20
                        return Current.ENDINCOME20;
                    case 23: // COEFA01
                        return Current.COEFA01;
                    case 24: // COEFA02
                        return Current.COEFA02;
                    case 25: // COEFA03
                        return Current.COEFA03;
                    case 26: // COEFA04
                        return Current.COEFA04;
                    case 27: // COEFA05
                        return Current.COEFA05;
                    case 28: // COEFA06
                        return Current.COEFA06;
                    case 29: // COEFA07
                        return Current.COEFA07;
                    case 30: // COEFA08
                        return Current.COEFA08;
                    case 31: // COEFA09
                        return Current.COEFA09;
                    case 32: // COEFA10
                        return Current.COEFA10;
                    case 33: // COEFA11
                        return Current.COEFA11;
                    case 34: // COEFA12
                        return Current.COEFA12;
                    case 35: // COEFA13
                        return Current.COEFA13;
                    case 36: // COEFA14
                        return Current.COEFA14;
                    case 37: // COEFA15
                        return Current.COEFA15;
                    case 38: // COEFA16
                        return Current.COEFA16;
                    case 39: // COEFA17
                        return Current.COEFA17;
                    case 40: // COEFA18
                        return Current.COEFA18;
                    case 41: // COEFA19
                        return Current.COEFA19;
                    case 42: // COEFA20
                        return Current.COEFA20;
                    case 43: // COEFB01
                        return Current.COEFB01;
                    case 44: // COEFB02
                        return Current.COEFB02;
                    case 45: // COEFB03
                        return Current.COEFB03;
                    case 46: // COEFB04
                        return Current.COEFB04;
                    case 47: // COEFB05
                        return Current.COEFB05;
                    case 48: // COEFB06
                        return Current.COEFB06;
                    case 49: // COEFB07
                        return Current.COEFB07;
                    case 50: // COEFB08
                        return Current.COEFB08;
                    case 51: // COEFB09
                        return Current.COEFB09;
                    case 52: // COEFB10
                        return Current.COEFB10;
                    case 53: // COEFB11
                        return Current.COEFB11;
                    case 54: // COEFB12
                        return Current.COEFB12;
                    case 55: // COEFB13
                        return Current.COEFB13;
                    case 56: // COEFB14
                        return Current.COEFB14;
                    case 57: // COEFB15
                        return Current.COEFB15;
                    case 58: // COEFB16
                        return Current.COEFB16;
                    case 59: // COEFB17
                        return Current.COEFB17;
                    case 60: // COEFB18
                        return Current.COEFB18;
                    case 61: // COEFB19
                        return Current.COEFB19;
                    case 62: // COEFB20
                        return Current.COEFB20;
                    case 63: // TRANSDATE
                        return Current.TRANSDATE;
                    case 64: // HECS
                        return Current.HECS;
                    case 65: // LW_DATE
                        return Current.LW_DATE;
                    case 66: // LW_TIME
                        return Current.LW_TIME;
                    case 67: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION01
                        return Current.DESCRIPTION01 == null;
                    case 2: // DESCRIPTION02
                        return Current.DESCRIPTION02 == null;
                    case 3: // ENDINCOME01
                        return Current.ENDINCOME01 == null;
                    case 4: // ENDINCOME02
                        return Current.ENDINCOME02 == null;
                    case 5: // ENDINCOME03
                        return Current.ENDINCOME03 == null;
                    case 6: // ENDINCOME04
                        return Current.ENDINCOME04 == null;
                    case 7: // ENDINCOME05
                        return Current.ENDINCOME05 == null;
                    case 8: // ENDINCOME06
                        return Current.ENDINCOME06 == null;
                    case 9: // ENDINCOME07
                        return Current.ENDINCOME07 == null;
                    case 10: // ENDINCOME08
                        return Current.ENDINCOME08 == null;
                    case 11: // ENDINCOME09
                        return Current.ENDINCOME09 == null;
                    case 12: // ENDINCOME10
                        return Current.ENDINCOME10 == null;
                    case 13: // ENDINCOME11
                        return Current.ENDINCOME11 == null;
                    case 14: // ENDINCOME12
                        return Current.ENDINCOME12 == null;
                    case 15: // ENDINCOME13
                        return Current.ENDINCOME13 == null;
                    case 16: // ENDINCOME14
                        return Current.ENDINCOME14 == null;
                    case 17: // ENDINCOME15
                        return Current.ENDINCOME15 == null;
                    case 18: // ENDINCOME16
                        return Current.ENDINCOME16 == null;
                    case 19: // ENDINCOME17
                        return Current.ENDINCOME17 == null;
                    case 20: // ENDINCOME18
                        return Current.ENDINCOME18 == null;
                    case 21: // ENDINCOME19
                        return Current.ENDINCOME19 == null;
                    case 22: // ENDINCOME20
                        return Current.ENDINCOME20 == null;
                    case 23: // COEFA01
                        return Current.COEFA01 == null;
                    case 24: // COEFA02
                        return Current.COEFA02 == null;
                    case 25: // COEFA03
                        return Current.COEFA03 == null;
                    case 26: // COEFA04
                        return Current.COEFA04 == null;
                    case 27: // COEFA05
                        return Current.COEFA05 == null;
                    case 28: // COEFA06
                        return Current.COEFA06 == null;
                    case 29: // COEFA07
                        return Current.COEFA07 == null;
                    case 30: // COEFA08
                        return Current.COEFA08 == null;
                    case 31: // COEFA09
                        return Current.COEFA09 == null;
                    case 32: // COEFA10
                        return Current.COEFA10 == null;
                    case 33: // COEFA11
                        return Current.COEFA11 == null;
                    case 34: // COEFA12
                        return Current.COEFA12 == null;
                    case 35: // COEFA13
                        return Current.COEFA13 == null;
                    case 36: // COEFA14
                        return Current.COEFA14 == null;
                    case 37: // COEFA15
                        return Current.COEFA15 == null;
                    case 38: // COEFA16
                        return Current.COEFA16 == null;
                    case 39: // COEFA17
                        return Current.COEFA17 == null;
                    case 40: // COEFA18
                        return Current.COEFA18 == null;
                    case 41: // COEFA19
                        return Current.COEFA19 == null;
                    case 42: // COEFA20
                        return Current.COEFA20 == null;
                    case 43: // COEFB01
                        return Current.COEFB01 == null;
                    case 44: // COEFB02
                        return Current.COEFB02 == null;
                    case 45: // COEFB03
                        return Current.COEFB03 == null;
                    case 46: // COEFB04
                        return Current.COEFB04 == null;
                    case 47: // COEFB05
                        return Current.COEFB05 == null;
                    case 48: // COEFB06
                        return Current.COEFB06 == null;
                    case 49: // COEFB07
                        return Current.COEFB07 == null;
                    case 50: // COEFB08
                        return Current.COEFB08 == null;
                    case 51: // COEFB09
                        return Current.COEFB09 == null;
                    case 52: // COEFB10
                        return Current.COEFB10 == null;
                    case 53: // COEFB11
                        return Current.COEFB11 == null;
                    case 54: // COEFB12
                        return Current.COEFB12 == null;
                    case 55: // COEFB13
                        return Current.COEFB13 == null;
                    case 56: // COEFB14
                        return Current.COEFB14 == null;
                    case 57: // COEFB15
                        return Current.COEFB15 == null;
                    case 58: // COEFB16
                        return Current.COEFB16 == null;
                    case 59: // COEFB17
                        return Current.COEFB17 == null;
                    case 60: // COEFB18
                        return Current.COEFB18 == null;
                    case 61: // COEFB19
                        return Current.COEFB19 == null;
                    case 62: // COEFB20
                        return Current.COEFB20 == null;
                    case 63: // TRANSDATE
                        return Current.TRANSDATE == null;
                    case 64: // HECS
                        return Current.HECS == null;
                    case 65: // LW_DATE
                        return Current.LW_DATE == null;
                    case 66: // LW_TIME
                        return Current.LW_TIME == null;
                    case 67: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // PXKEY
                        return "PXKEY";
                    case 1: // DESCRIPTION01
                        return "DESCRIPTION01";
                    case 2: // DESCRIPTION02
                        return "DESCRIPTION02";
                    case 3: // ENDINCOME01
                        return "ENDINCOME01";
                    case 4: // ENDINCOME02
                        return "ENDINCOME02";
                    case 5: // ENDINCOME03
                        return "ENDINCOME03";
                    case 6: // ENDINCOME04
                        return "ENDINCOME04";
                    case 7: // ENDINCOME05
                        return "ENDINCOME05";
                    case 8: // ENDINCOME06
                        return "ENDINCOME06";
                    case 9: // ENDINCOME07
                        return "ENDINCOME07";
                    case 10: // ENDINCOME08
                        return "ENDINCOME08";
                    case 11: // ENDINCOME09
                        return "ENDINCOME09";
                    case 12: // ENDINCOME10
                        return "ENDINCOME10";
                    case 13: // ENDINCOME11
                        return "ENDINCOME11";
                    case 14: // ENDINCOME12
                        return "ENDINCOME12";
                    case 15: // ENDINCOME13
                        return "ENDINCOME13";
                    case 16: // ENDINCOME14
                        return "ENDINCOME14";
                    case 17: // ENDINCOME15
                        return "ENDINCOME15";
                    case 18: // ENDINCOME16
                        return "ENDINCOME16";
                    case 19: // ENDINCOME17
                        return "ENDINCOME17";
                    case 20: // ENDINCOME18
                        return "ENDINCOME18";
                    case 21: // ENDINCOME19
                        return "ENDINCOME19";
                    case 22: // ENDINCOME20
                        return "ENDINCOME20";
                    case 23: // COEFA01
                        return "COEFA01";
                    case 24: // COEFA02
                        return "COEFA02";
                    case 25: // COEFA03
                        return "COEFA03";
                    case 26: // COEFA04
                        return "COEFA04";
                    case 27: // COEFA05
                        return "COEFA05";
                    case 28: // COEFA06
                        return "COEFA06";
                    case 29: // COEFA07
                        return "COEFA07";
                    case 30: // COEFA08
                        return "COEFA08";
                    case 31: // COEFA09
                        return "COEFA09";
                    case 32: // COEFA10
                        return "COEFA10";
                    case 33: // COEFA11
                        return "COEFA11";
                    case 34: // COEFA12
                        return "COEFA12";
                    case 35: // COEFA13
                        return "COEFA13";
                    case 36: // COEFA14
                        return "COEFA14";
                    case 37: // COEFA15
                        return "COEFA15";
                    case 38: // COEFA16
                        return "COEFA16";
                    case 39: // COEFA17
                        return "COEFA17";
                    case 40: // COEFA18
                        return "COEFA18";
                    case 41: // COEFA19
                        return "COEFA19";
                    case 42: // COEFA20
                        return "COEFA20";
                    case 43: // COEFB01
                        return "COEFB01";
                    case 44: // COEFB02
                        return "COEFB02";
                    case 45: // COEFB03
                        return "COEFB03";
                    case 46: // COEFB04
                        return "COEFB04";
                    case 47: // COEFB05
                        return "COEFB05";
                    case 48: // COEFB06
                        return "COEFB06";
                    case 49: // COEFB07
                        return "COEFB07";
                    case 50: // COEFB08
                        return "COEFB08";
                    case 51: // COEFB09
                        return "COEFB09";
                    case 52: // COEFB10
                        return "COEFB10";
                    case 53: // COEFB11
                        return "COEFB11";
                    case 54: // COEFB12
                        return "COEFB12";
                    case 55: // COEFB13
                        return "COEFB13";
                    case 56: // COEFB14
                        return "COEFB14";
                    case 57: // COEFB15
                        return "COEFB15";
                    case 58: // COEFB16
                        return "COEFB16";
                    case 59: // COEFB17
                        return "COEFB17";
                    case 60: // COEFB18
                        return "COEFB18";
                    case 61: // COEFB19
                        return "COEFB19";
                    case 62: // COEFB20
                        return "COEFB20";
                    case 63: // TRANSDATE
                        return "TRANSDATE";
                    case 64: // HECS
                        return "HECS";
                    case 65: // LW_DATE
                        return "LW_DATE";
                    case 66: // LW_TIME
                        return "LW_TIME";
                    case 67: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "PXKEY":
                        return 0;
                    case "DESCRIPTION01":
                        return 1;
                    case "DESCRIPTION02":
                        return 2;
                    case "ENDINCOME01":
                        return 3;
                    case "ENDINCOME02":
                        return 4;
                    case "ENDINCOME03":
                        return 5;
                    case "ENDINCOME04":
                        return 6;
                    case "ENDINCOME05":
                        return 7;
                    case "ENDINCOME06":
                        return 8;
                    case "ENDINCOME07":
                        return 9;
                    case "ENDINCOME08":
                        return 10;
                    case "ENDINCOME09":
                        return 11;
                    case "ENDINCOME10":
                        return 12;
                    case "ENDINCOME11":
                        return 13;
                    case "ENDINCOME12":
                        return 14;
                    case "ENDINCOME13":
                        return 15;
                    case "ENDINCOME14":
                        return 16;
                    case "ENDINCOME15":
                        return 17;
                    case "ENDINCOME16":
                        return 18;
                    case "ENDINCOME17":
                        return 19;
                    case "ENDINCOME18":
                        return 20;
                    case "ENDINCOME19":
                        return 21;
                    case "ENDINCOME20":
                        return 22;
                    case "COEFA01":
                        return 23;
                    case "COEFA02":
                        return 24;
                    case "COEFA03":
                        return 25;
                    case "COEFA04":
                        return 26;
                    case "COEFA05":
                        return 27;
                    case "COEFA06":
                        return 28;
                    case "COEFA07":
                        return 29;
                    case "COEFA08":
                        return 30;
                    case "COEFA09":
                        return 31;
                    case "COEFA10":
                        return 32;
                    case "COEFA11":
                        return 33;
                    case "COEFA12":
                        return 34;
                    case "COEFA13":
                        return 35;
                    case "COEFA14":
                        return 36;
                    case "COEFA15":
                        return 37;
                    case "COEFA16":
                        return 38;
                    case "COEFA17":
                        return 39;
                    case "COEFA18":
                        return 40;
                    case "COEFA19":
                        return 41;
                    case "COEFA20":
                        return 42;
                    case "COEFB01":
                        return 43;
                    case "COEFB02":
                        return 44;
                    case "COEFB03":
                        return 45;
                    case "COEFB04":
                        return 46;
                    case "COEFB05":
                        return 47;
                    case "COEFB06":
                        return 48;
                    case "COEFB07":
                        return 49;
                    case "COEFB08":
                        return 50;
                    case "COEFB09":
                        return 51;
                    case "COEFB10":
                        return 52;
                    case "COEFB11":
                        return 53;
                    case "COEFB12":
                        return 54;
                    case "COEFB13":
                        return 55;
                    case "COEFB14":
                        return 56;
                    case "COEFB15":
                        return 57;
                    case "COEFB16":
                        return 58;
                    case "COEFB17":
                        return 59;
                    case "COEFB18":
                        return 60;
                    case "COEFB19":
                        return 61;
                    case "COEFB20":
                        return 62;
                    case "TRANSDATE":
                        return 63;
                    case "HECS":
                        return 64;
                    case "LW_DATE":
                        return 65;
                    case "LW_TIME":
                        return 66;
                    case "LW_USER":
                        return 67;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
